Imports System.Threading
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmReportReceiptController

    'Dim generalDAO As New GeneralDAO
    Dim DTP As Integer

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub SearchReceipt(ByVal HN As String, ByVal PName As String, ByVal ReceiptNo As String, _
                                ByVal CashReceiptNo As String, ByVal ExpDate As String)
        Dim cnn As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim sqlComm As SqlClient.SqlCommand
        Dim iasycroresul As System.IAsyncResult
        Dim waitHandler As System.Threading.WaitHandle
        Dim StrHN As String = ""
        Dim StrPName As String = ""
        Dim StrDate As String = ""
        Dim StrName As String = ""
        Dim StrReceipt As String = ""
        Dim StrCashReceipt As String = ""
        Dim Sql As String = "Select HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel," _
                            & " DateIn, ConPay from tblPatientReceipt Where "
        If HN <> "" And PName <> "" And ExpDate <> "" Then
            StrHN = " HN="
            StrPName = " And PatientName"
            StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
            StrName = " Like '%" & PName & "%'"
        ElseIf HN <> "" And PName <> "" Then
            StrHN = " HN="
            StrPName = " And PatientName"
            StrDate = ""
            StrName = " Like '%" & PName & "%'"
        ElseIf HN <> "" And ExpDate <> "" Then
            StrHN = "HN="
            StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
            StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
        ElseIf PName <> "" And ExpDate <> "" Then
            StrPName = "PatientName"
            StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
            StrName = " Like '%" & PName & "%'"
        ElseIf HN <> "" Then
            StrHN = "HN="
        ElseIf PName <> "" Then
            StrPName = "PatientName"
            StrName = " Like '%" & PName & "%'"
        ElseIf ReceiptNo <> "" Then
            StrReceipt = "ReceiptNo="
        ElseIf CashReceiptNo <> "" Then
            StrCashReceipt = "IDCashReceipt="
        ElseIf ExpDate <> "" Then
            StrDate = "CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
        End If
        If DTP = 1 Then
            Sql = Sql & "" & StrHN & "" & HN & "" _
                        & StrPName & "" & StrName & "" _
                        & StrDate & "'" & Format(CType(ExpDate, Date), "MM-dd-yyyy") & "' and ConDelete='0'"
        Else
            Sql = Sql & "" & StrHN & "" & HN & "" & StrPName & "" & StrName & "" _
                    & StrReceipt & "" & ReceiptNo & "" & StrCashReceipt & "" & CashReceiptNo & " and ConDelete='0'"
        End If
        'cnn.open()
        'MsgBox(Sql)
        Dim OLE As New OleDb.OleDbCommand
        sqlComm = New SqlClient.SqlCommand("WAITFOR DELAY '00:00:00'; " + Sql, cnn)
        iasycroresul = sqlComm.BeginExecuteReader(Nothing, sqlComm, CommandBehavior.CloseConnection)
        waitHandler = iasycroresul.AsyncWaitHandle
        Dim cmm As SqlCommand
        cmm = CType(iasycroresul.AsyncState, SqlCommand)
        Stock(cmm, iasycroresul)
        cmm.Dispose()
        'cnn.Close()
    End Sub

    Private Sub Stock(ByVal cmm As SqlCommand, ByVal result As IAsyncResult)
        Try
            Dim sqlReader As SqlDataReader = cmm.EndExecuteReader(result)
            Dim dt As New DataTable
            dt.Load(sqlReader)
            If Me.InvokeRequired Then
                Me.Invoke(New MyBindDelegate(AddressOf MyBind), dt)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

    End Sub

    Private Delegate Sub MyBindDelegate(ByVal table As DataTable)

    Private Sub MyBind(ByVal dataTable As DataTable)
        If dataTable.Rows.Count <> 0 Then
            Dim StrDate As String = ""
            If Me.dtpDateIn.Checked = True Then
                StrDate = Format(Me.dtpDateIn.Value, "MM-dd-yyyy")
            End If
            'If BGW = True Then
            '    Me.lblSearch.Text = "Searched by: " & Me.txtDID.Text.Trim &  & Me.txtDName.Text.Trim &  & Me.cboCategory.Text.Trim &  & StrDate
            'Else
            '    Me.lblSearch.Text = "Searched by: Show All"
            'End If
            'Me.lblRecord.Text = "Record(s): " & dataTable.Rows.Count
            Me.dgvFindInfos.DataSource = dataTable
            NumberAllRowHeaderDataGrid(Me.dgvFindInfos)
            Me.dgvFindInfos.ClearSelection()

            'Dim BalanceStock As Integer
            'For Each Rowt As DataGridViewRow In Me.dgvFindInfos.Rows
            '    BalanceStock = Rowt.Cells.Item("Balance").Value
            '    If BalanceStock <= Rowt.Cells.Item("Alert").Value Then
            '        Rowt.DefaultCellStyle.BackColor = Color.Red
            '    End If
            'Next
        Else
            MsgBox("Sorry, there has no data that matches your criteria.", MsgBoxStyle.Information, "Search confirm")
            dataTable.Rows.Clear()
            Me.dgvFindInfos.DataSource = dataTable
            'Me.lblSearch.Text = ""
            'Me.lblRecord.Text = ""
            'Me.txtDID.Focus()
        End If
    End Sub

    Sub NumberAllRowHeaderDataGrid(ByVal Gr As DataGridView)

        'Add row header
        Dim j As Integer = 0
        For i As Integer = 0 To Gr.Rows.Count - 1
            j = i
            j = j + 1
            Gr.Rows(i).HeaderCell.Value = j.ToString
        Next
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If Me.dtpDateIn.Checked = False And Me.txtHN.Text = "" And Me.txtPatientName.Text = "" And Me.txtReceiptNo.Text = "" And Me.txtCashReceipt.Text = "" Then
            MsgBox("Please enter any criteria to find your receipt information.", MsgBoxStyle.Information, "Find criteria confirm")
            Me.txtHN.Focus()
            Exit Sub
        End If
        Me.cmdFind.Enabled = False
        DTP = 3
        If Me.dtpDateIn.Checked = True Then
            DTP = 1
        Else
            DTP = 0
        End If
        Me.bgwReceipt.RunWorkerAsync()
    End Sub

    Private Sub bgwReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwReceipt.DoWork
        Call SearchReceipt(Me.txtHN.Text, Me.txtPatientName.Text, Me.txtReceiptNo.Text, Me.txtCashReceipt.Text, Me.dtpDateIn.Value)

        If Me.bgwReceipt.CancellationPending = True Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub bgwReceipt_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReceipt.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MsgBox("Search Error: " & e.Error.Message)
        ElseIf e.Cancelled Then
            MsgBox("Search cancelled.", MsgBoxStyle.Exclamation, "Cancel")
        Else
            Me.cmdFind.Enabled = True
            DTP = 3
        End If
    End Sub

    Private Sub frmReceiptController_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpDateIn.Checked = False
    End Sub

    Private Sub txtReceiptNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceiptNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtReceiptNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptNo.TextChanged
        Me.dtpDateIn.Checked = False
        Me.txtHN.Clear()
        Me.txtPatientName.Clear()
    End Sub

    Private Sub txtCashReceipt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashReceipt.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtCashReceipt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashReceipt.TextChanged
        Me.dtpDateIn.Checked = False
        Me.txtHN.Clear()
        Me.txtPatientName.Clear()
    End Sub

    Private Sub dgvFindInfos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFindInfos.CellClick
        Dim i As Integer
        Try
            If Me.dgvFindInfos.Rows(e.RowIndex).Cells("Check").Value = CheckState.Checked Then
                Me.dgvFindInfos.Rows(e.RowIndex).Cells("Check").Value = CheckState.Unchecked
                'Me.dgvSearch.Rows(e.RowIndex).Cells(e.RowIndex).Selected = False
                'Me.dgvSearch.Rows(e.RowIndex).Selected = False
            Else
                Me.dgvFindInfos.Rows(e.RowIndex).Cells("Check").Value = CheckState.Checked
                'Me.dgvSearch.Rows(e.RowIndex).Cells(e.RowIndex).Selected = True
                'Me.dgvSearch.Rows(e.RowIndex).Selected = True
            End If
            For i = 0 To Me.dgvFindInfos.Rows.Count - 1
                If Me.dgvFindInfos.Rows(i).Cells(0).Value = CheckState.Checked Then
                    Me.dgvFindInfos.Rows(i).Selected = True
                Else
                    Me.dgvFindInfos.Rows(i).Selected = False
                End If
            Next
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dgvFindInfos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFindInfos.CellContentClick

    End Sub

    Private Function ReportReceiptController(ByVal HN As String, ByVal PName As String, ByVal ReceiptNo As String, _
                                ByVal CashReceiptNo As String, ByVal ExpDate As String) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReceiptController
            Dim Sql As String = ""
            Dim StrHN As String = ""
            Dim StrPName As String = ""
            Dim StrDate As String = ""
            Dim StrName As String = ""
            Dim StrReceipt As String = ""
            Dim StrCashReceipt As String = ""
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "Select HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel," _
                                & " DateIn, ConPay from tblPatientReceipt Where "
            If HN <> "" And PName <> "" And ExpDate <> "" Then
                StrHN = " HN="
                StrPName = " And PatientName"
                StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
                StrName = " Like '%" & PName & "%'"
            ElseIf HN <> "" And PName <> "" Then
                StrHN = " HN="
                StrPName = " And PatientName"
                StrDate = ""
                StrName = " Like '%" & PName & "%'"
            ElseIf HN <> "" And ExpDate <> "" Then
                StrHN = "HN="
                StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
                StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
            ElseIf PName <> "" And ExpDate <> "" Then
                StrPName = " PatientName"
                StrDate = " And CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
                StrName = " Like '%" & PName & "%'"
            ElseIf HN <> "" Then
                StrHN = "HN="
            ElseIf PName <> "" Then
                StrPName = "PatientName"
                StrName = " Like '%" & PName & "%'"
            ElseIf ReceiptNo <> "" Then
                StrReceipt = "ReceiptNo="
            ElseIf CashReceiptNo <> "" Then
                StrCashReceipt = "IDCashReceipt="
            ElseIf ExpDate <> "" Then
                StrDate = "CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)="
            End If
            If DTP = 1 Then
                Sql = Sql & "" & StrHN & "" & HN & "" _
                            & StrPName & "" & StrName & "" _
                            & StrDate & "'" & Format(CType(ExpDate, Date), "MM-dd-yyyy") & "' and ConDelete='0'"
            Else
                Sql = Sql & "" & StrHN & "" & HN & "" & StrPName & "" & StrName & "" _
                        & StrReceipt & "" & ReceiptNo & "" & StrCashReceipt & "" & CashReceiptNo & " and ConDelete='0'"
            End If
            Sql = Sql & " ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Private Function ReportReceiptDelete(ByVal HN As String, ByVal PName As String, ByVal ReceiptNo As String, _
                                ByVal CashReceiptNo As String, ByVal ExpDate As String) As DataTable
        Try
            Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReceiptController
            Dim Sql As String = ""
            Dim StrHN As String = ""
            Dim StrPName As String = ""
            Dim StrDate As String = ""
            Dim StrName As String = ""
            Dim StrReceipt As String = ""
            Dim StrCashReceipt As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "Select HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel," _
                                & " DateIn, ConPay from tblPatientReceipt Where "
            If HN <> "" And PName <> "" And ExpDate <> "" Then
                StrHN = " HN="
                StrPName = " And PatientName"
                StrDate = " And DateIn="
                StrName = " Like '%" & PName & "%'"
            ElseIf HN <> "" And PName <> "" Then
                StrHN = " HN="
                StrPName = " And PatientName"
                StrDate = ""
                StrName = " Like '%" & PName & "%'"
            ElseIf HN <> "" And ExpDate <> "" Then
                StrHN = "HN="
                StrDate = " And DateIn="
                StrDate = " And DateIn="
            ElseIf PName <> "" And ExpDate <> "" Then
                StrPName = "PatientName"
                StrDate = " And DateIn="
                StrName = " Like '%" & PName & "%'"
            ElseIf HN <> "" Then
                StrHN = "HN="
            ElseIf PName <> "" Then
                StrPName = "PatientName"
                StrName = " Like '%" & PName & "%'"
            ElseIf ReceiptNo <> "" Then
                StrReceipt = "ReceiptNo="
            ElseIf CashReceiptNo <> "" Then
                StrCashReceipt = "IDCashReceipt="
            ElseIf ExpDate <> "" Then
                StrDate = "DateIn="
            End If
            If DTP = 1 Then
                Sql = Sql & "" & StrHN & "" & HN & "" _
                            & StrPName & "" & StrName & "" _
                            & StrDate & "'" & Format(CType(ExpDate, Date), "MM-dd-yyyy") & "'"
            Else
                Sql = Sql & "" & StrHN & "" & HN & "" & StrPName & "" & StrName & "" _
                        & StrReceipt & "" & ReceiptNo & "" & StrCashReceipt & "" & CashReceiptNo & ""
            End If
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(Sql)
            'SqlCom.CommandText = Sql
            'SqlCom.Connection = Con
            'SqlAdapter.SelectCommand = SqlCom
            'SqlAdapter.Fill(DSet)
            'Con.Close()
            'Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            If Me.dtpDateIn.Checked = False And Me.txtHN.Text = "" And Me.txtPatientName.Text = "" And Me.txtReceiptNo.Text = "" And Me.txtCashReceipt.Text = "" Then
                MsgBox("There has no data to print. Please find the information before printing.", MsgBoxStyle.Information, "Print confirm")
                Me.txtHN.Focus()
                Exit Sub
            End If
            DTP = 3
            If Me.dtpDateIn.Checked = True Then
                DTP = 1
            Else
                DTP = 0
            End If
            Me.cmdPrint.Enabled = False
            Dim frmReportRController As New frmReportController
            '-------------Report Form Active--------------------------------
            Dim ReportRController As New ReportReceiptController
            ReportRController.SetDataSource(ReportReceiptController(Me.txtHN.Text, Me.txtPatientName.Text, Me.txtReceiptNo.Text, Me.txtCashReceipt.Text, Me.dtpDateIn.Value).Tables(1))
            frmReportRController.crvReportReceiptController.ReportSource = ReportRController
            ReportRController.Refresh()
            '-------Parameter for Date from to date to-----------------
            'Dim DateFromTo As ParameterField
            'DateFromTo = ReportCCW.ParameterFields("txtDateFromTo")
            'DateFromTo.CurrentValues.AddValue("Date: " & Format(Me.dtpDateFrom.Value, "dd/MM/yyyy") & " to: " & Format(Me.dtpDateTo.Value, "dd/MM/yyyy"))
            frmReportRController.ShowDialog()
            Me.cmdPrint.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim i As Integer
        Dim DialogBox As DialogResult
        DTP = 3
        If Me.dtpDateIn.Checked = True Then
            DTP = 1
        Else
            DTP = 0
        End If
        If Me.dgvFindInfos.RowCount > 0 Then
            DialogBox = MessageBox.Show("Do you really want to delete this (these) selected receipts?" & Chr(13) & "* Note: The system cannot restore the deleted data after deletion.", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                For i = 0 To Me.dgvFindInfos.Rows.Count - 1
                    If Me.dgvFindInfos.Rows(i).Cells(0).Value = CheckState.Checked Then
                        Call MReceiptController.DeleteReceipt(Me.dgvFindInfos.Rows(i).Cells(3).Value)
                    End If
                Next
                Me.dgvFindInfos.DataSource = ReportReceiptDelete(Me.txtHN.Text, Me.txtPatientName.Text, Me.txtReceiptNo.Text, Me.txtCashReceipt.Text, Me.dtpDateIn.Value)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdPrintDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintDetail.Click
        Dim frmPrintDetail As New frmReportReceiptDetail
        frmPrintDetail.ShowDialog()
    End Sub

    Private Sub txtHN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHN.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtHN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHN.TextChanged

    End Sub

    Private Sub dgvFindInfos_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvFindInfos.ColumnHeaderMouseClick
        NumberAllRowHeaderDataGrid(Me.dgvFindInfos)
    End Sub
End Class