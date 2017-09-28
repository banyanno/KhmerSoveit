Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Threading
Imports System.Configuration

Public Class frmBackupDatabase

    Inherits System.Windows.Forms.Form
    Dim generalDAO As New GeneralDAO
    Dim StrDevice As String = ""

    Private Sub frmBackupDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proPicture.Visible = False
        Me.txtFileName.Text = "TakeoDB_" & Format(Date.Now(), "dd-MM-yyyy_h.m.s")
        Me.cmdSave.Enabled = False
        Me.cboDeviceType.SelectedIndex = 0
        StrDevice = Me.cboDeviceType.Text
        'Me.cboDeviceTypeRestore.SelectedIndex = 0
        If File.Exists(Application.StartupPath.ToString & "\backup.ini") = True Then
            Me.txtDesPath.Text = GetFileContents(Application.StartupPath.ToString & "\backup.ini")
        End If
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Me.txtDesPath.Text = Me.FolderBrowserDialog1.SelectedPath
        Me.txtFileName.Text = "TakeoDB_" & Format(Date.Now(), "dd-MM-yyyy_h.m.s")
        If Me.txtDesPath.Text <> "" Then
            If ModWriteFile.SaveTextToFile(Me.txtDesPath.Text, Application.StartupPath.ToString & "\backup.ini") = False Then
                MsgBox("The string path cannot be saved.", MsgBoxStyle.Information, "Write file")
                Me.cmdBrowse.Focus()
            End If
        End If
    End Sub

    Private Sub txtFileName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileName.TextChanged
        If Me.txtDesPath.Text.Trim <> "" Then
            If Me.txtFileName.Text.Trim.Length > 0 Then
                Me.cmdSave.Enabled = True
            Else
                Me.cmdSave.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtDesPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesPath.TextChanged
        If Me.txtFileName.Text.Trim <> "" Then
            If Me.txtDesPath.Text.Trim.Length > 0 Then
                Me.cmdSave.Enabled = True
            Else
                Me.cmdSave.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If MsgBox("Do you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Close Form") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    'Declare delegate for making thread safe calls 
    Delegate Sub SetControlValueCallback(ByVal oControl As Control, ByVal propName As String, ByVal propValue As Object)

    'Method which invokes thread safe call 
    Private Sub SetControlPropertyValue(ByVal oControl As Control, ByVal propName As String, ByVal propValue As Object)
        If oControl.InvokeRequired Then
            Dim d As New SetControlValueCallback(AddressOf SetControlPropertyValue)
            oControl.Invoke(d, New Object() {oControl, propName, propValue})
        Else
            Dim t As Type = oControl.[GetType]()
            Dim props As PropertyInfo() = t.GetProperties()
            For Each p As PropertyInfo In props
                If p.Name.ToUpper() = propName.ToUpper() Then
                    p.SetValue(oControl, propValue, Nothing)
                End If
            Next
        End If
    End Sub

    Sub ShowProgressBar()
        SetControlPropertyValue(Me.proPicture, "Visible", True)
        'SetControlPropertyValue(Me.cmdSave, "Visible", False)
        'Me.PicLoading.Visible = True
    End Sub

    'When process completed, enable controls on form
    Sub HideProgressBar()
        SetControlPropertyValue(Me.proPicture, "Visible", False)
        'SetControlPropertyValue(Me.cmdSave, "Visible", True)
        'Me.PicLoading.Visible = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Me.cmdSave.Enabled = False
            StrDevice = Me.cboDeviceType.Text
            If Me.cboDeviceType.Text.Trim = "" Then
                MsgBox("Please select device type.", MsgBoxStyle.Exclamation, "Null Value")
                Me.cboDeviceType.Focus()
                Exit Sub
            End If
            Me.TabControl1.Enabled = False
            Me.Refresh()
            Dim t1 As New Thread(AddressOf BackUp_Database)
            t1.Start()
            '-------------to refresh backup name------------------------------
            Me.txtFileName.Text = "TakeoDB_" & Format(Date.Now(), "dd-MM-yyyy_h.m.s")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "System Error")
        Finally
            HideProgressBar()
            Me.cmdSave.Enabled = True
            Me.TabControl1.Enabled = True
        End Try
    End Sub

    Private Sub BackUp_Database()
        Dim NConnection As SqlClient.SqlConnection = generalDAO.getConnection
        If NConnection.State = ConnectionState.Closed Then
            NConnection.Open()
        End If
        Dim SqlCmd As New SqlClient.SqlCommand("SBackUpDataBase", NConnection)
        SqlCmd.CommandType = CommandType.StoredProcedure
        If Me.txtFileName.Text.Trim <> "" And Me.txtDesPath.Text.Trim <> "" Then
            ShowProgressBar()
            With SqlCmd
                .Parameters.Add("@DestinationPath", SqlDbType.VarChar, 2000).Value = Me.txtDesPath.Text.Trim & "\" & Me.txtFileName.Text.Trim & ".bak"
                .Parameters.Add("@FileName", SqlDbType.VarChar, 1000).Value = Me.txtFileName.Text.Trim
                .Parameters.Add("@DeviceType", SqlDbType.VarChar, 500).Value = StrDevice
                .Parameters.Add("@StrError", SqlDbType.VarChar, 2000).Direction = ParameterDirection.Output
                .Parameters.Add("@GetReturn", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
                Try
                    .ExecuteNonQuery()

                    Select Case .Parameters("@GetReturn").Value
                        Case 0
                            Call ModBackupDatabase.InsertBackupDB(USER_NAME, Me.txtFileName.Text & ".bak", Date.Now())
                            NConnection.Close()
                            HideProgressBar()
                            MsgBox(.Parameters("@StrError").Value, MsgBoxStyle.Information, "Backup Completed")
                            'Return True
                        Case 1
                            NConnection.Close()
                            HideProgressBar()
                            MsgBox(.Parameters("@StrError").Value, MsgBoxStyle.Critical, "System Error")
                            'Return False
                    End Select
                Catch ex As Exception
                    NConnection.Close()
                    HideProgressBar()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "System Error")
                    'Return False
                End Try
            End With
            HideProgressBar()
        Else
            MsgBox("Please check backup file name and destination path.", MsgBoxStyle.Information, "Backup Confirm")
            Me.txtFileName.Focus()
        End If
        NConnection.Close()
    End Sub

    'Private Sub cmdBrowseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Try
    '    '    If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '    '        If OpenFileDialog1.FileName <> "" Then
    '    '            Me.txtSourceFile.Text = Me.OpenFileDialog1.FileName
    '    '        End If
    '    '    Else
    '    '        Me.txtSourceFile.Text = ""
    '    '    End If
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "System Error")
    '    '    Exit Sub
    '    'End Try

    'End Sub

    'Private Function Restore_DataBase() As Boolean
    '    Dim strConn As String = "data source=localhost;" & _
    '          "initial catalog=master;integrated security=SSPI;"
    '    Dim conn As New SqlClient.SqlConnection(strConn)
    '    SqlConnection.ClearAllPools()
    '    conn.Open()
    '    Dim SqlCmd As New SqlClient.SqlCommand
    '    If Me.cboDeviceTypeRestore.Text.Trim <> "" And Me.txtSourceFile.Text.Trim <> "" Then
    '        'SqlCmd.CommandText = "Alter Database ADHospital SET MULTI_USER With ROLLBACK IMMEDIATE"
    '        SqlCmd.CommandText = "Restore Database ADHospital From " & Me.cboDeviceTypeRestore.Text.Trim & "='" & Me.txtSourceFile.Text.Trim & "' With Replace"
    '        'SqlCmd.CommandText = "ALTER DATABASE ADHospital SET MULTI_USER"
    '        SqlCmd.Connection = conn
    '        SqlCmd.CommandTimeout = 36000
    '        Try
    '            SqlCmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            conn.Close()
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "System Error")
    '            Return False
    '        End Try
    '    End If
    '    conn.Close()
    '    'NConnection = New SqlClient.SqlConnection(strConnString)
    '    'If NConnection.State = ConnectionState.Closed Then
    '    '    NConnection.Open()
    '    'End If
    '    Return True
    'End Function

    'Private Sub txtSourceFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.txtSourceFile.Text.Trim.Length > 0 Then
    '        Me.cmdSave.Enabled = True
    '    Else
    '        Me.cmdSave.Enabled = False
    '    End If
    'End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'Select Case Me.TabControl1.SelectedIndex
        '    Case 0
        Me.txtFileName.Text = "TakeoDB_" & Format(Date.Now(), "dd-MM-yyyy_h.m.s")
        'Me.cboDeviceType.SelectedIndex = -1
        StrDevice = Me.cboDeviceType.Text
        If File.Exists(Application.StartupPath.ToString & "\backup.ini") = True Then
            Me.txtDesPath.Text = GetFileContents(Application.StartupPath.ToString & "\backup.ini")
        End If
        'Case 1
        '    Me.cboDeviceTypeRestore.SelectedIndex = -1
        '    Me.cboDeviceTypeRestore.Focus()
        '    Me.txtSourceFile.Text = ""
        'End Select
        'Me.cmdSave.Enabled = False
    End Sub

    Private Sub cboDeviceType_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDeviceType.SelectionChangeCommitted
        StrDevice = Me.cboDeviceType.Text
    End Sub
End Class