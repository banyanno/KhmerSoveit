Public Class frmDepartment
    Dim departRepo As IDepartRepository = New DepartRepository    
    Dim UDepartment As UCDepartment
    Public departID As Integer

    Sub New(ByVal mainDep As UCDepartment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UDepartment = mainDep
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim depart As New tblDepartment
        Dim departTransMsgStatus As String

        ' Validation
        If ValidateTextField(txtDepartName, "Department name", ErrorDepartment) = False Then
            Exit Sub
        End If

        If UCase(txtTempDepartName.Text) <> UCase(txtDepartName.Text) Then
            If departRepo.isDepartExistSearchByDepartName(txtDepartName.Text) Then
                MsgBox("Department name already exist.")
                Exit Sub
            End If
        End If        
        '===

        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new department?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                depart.DepartName = txtDepartName.Text

                departTransMsgStatus = departRepo.CreateDepart(depart)

                If departTransMsgStatus <> "True" Then
                    MsgBox("Error save department.", MsgBoxStyle.Critical, "Error : " & departTransMsgStatus)

                Else
                    MessageBox.Show("Save new department successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'UDepartment.FillDataByDepName(txtDepartName.Text)
                    Me.Close()
                End If

            End If
        Else ' Update vendor to database
            If departID = 0 Then ' get item unit attempt to update
                MsgBox("Invalid Item Unit ID.")
                Exit Sub
            End If
            If MessageBox.Show("Do you want update department?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                depart = departRepo.GetDepartByID(departID)
                depart.DepartName = txtDepartName.Text
                departTransMsgStatus = departRepo.UpdateDepart

                If departTransMsgStatus <> "True" Then
                    MsgBox("Error update department.", MsgBoxStyle.Critical, "Error : " & departTransMsgStatus)
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click        
        Me.Close()
    End Sub

    Private Sub frmDepartment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim depart As New tblDepartment
        If lblSaveOption.Text <> "0" Then
            txtDepartID.Text = departID
            depart = departRepo.GetDepartByID(departID)
            txtDepartID.Text = depart.DepartID.ToString
            txtDepartName.Text = depart.DepartName
            txtTempDepartName.Text = depart.DepartName
        Else
            txtDepartID.Text = departRepo.GenerateDepartmentID
        End If

    End Sub
End Class