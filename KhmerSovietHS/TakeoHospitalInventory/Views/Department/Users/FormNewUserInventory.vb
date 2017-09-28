Public Class FormNewUserInventory
    Dim DepDataAdapter As New DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim IUser As IUserManagement = New UserManagementImplement
    Private THIUserContex As New BaseDataContext

    Private Sub FormNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CboDepartment
            .DataSource = DepDataAdapter.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedValue = -1
        End With

        With CbDepartment
            .DataSource = DepDataAdapter.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedValue = -1
        End With

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Try
            If ValidateTextField(TxtUserName, "Name", ErrUser) = False Then
                Exit Sub
            End If
            If ValidateTextField(TxtLoginName, "Login name", ErrUser) = False Then
                Exit Sub
            End If
            If ValidateTextField(TxtPwd, "password", ErrUser) = False Then
                Exit Sub
            End If
            If ValidateTextField(TxtVerifyPwd, "verify password", ErrUser) = False Then
                Exit Sub
            End If
            If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtPwd.Text.ToUpper.Trim Then
                MsgBox("Password does not match verify password.please Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
                Me.TxtVerifyPwd.Focus()
                Exit Sub
            End If
            If ValidateCombobox(CboDepartment, "", ErrUser) = False Then Exit Sub

            '--- Validate duplicate user name
            Dim V_user = From T_User In THIUserContex.getTHIDataContextUserManagement.Department_Users Where T_User.UserName = UCase(TxtUserName.Text)
            If (V_user.ToList.Count > 0) Then
                MessageBox.Show("Login name already registed in system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Do you want save new user?", "Takeo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            System.Windows.Forms.DialogResult.Yes Then

                Dim user As New Department_User
                user.EmployeeName = TxtUserName.Text.Trim
                user.UserName = TxtUserName.Text.Trim
                'user.Password = TxtVerifyPwd.Text.Trim
                user.isHospitalManager = CbHosManager.Checked
                user.isMainStockManager = CbMSManager.Checked
                If IUser.SaveNewUser(user) = True Then
                    Dim Dep_user As New Department_Add_User
                    Dep_user.GroupNo = CInt(CboDepartment.SelectedValue)
                    Dep_user.UserNo = CInt(user.UserID)
                    IUser.SaveUserIntoDepartment(Dep_user)

                    '--- Add Permission for user run end-of-day department
                    With GridEODAccessRight
                        For Each rRow As DataGridViewRow In .Rows
                            Dim EOD_AR As New EOD_ACCESS_RIGHT
                            EOD_AR.UserNo = CInt(user.UserID)
                            EOD_AR.EOD_Right_DepartID = CInt(rRow.Cells("cDepartID").Value)
                            THIUserContex.getTHIDataContextUserManagement.EOD_ACCESS_RIGHTs.InsertOnSubmit(EOD_AR)
                            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
                        Next
                    End With


                    MessageBox.Show("Save new user successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateCombobox(CbDepartment, "", ErrUser) = False Then
            Exit Sub
        End If
        Dim obj(1) As Object
        obj(0) = CbDepartment.SelectedValue
        obj(1) = CbDepartment.Text

        With GridEODAccessRight
            If .Rows.Count = 0 Then
                .Rows.Add(obj)
            Else
                If IsValidateDupDepart(obj, obj(0)) = True Then
                    MessageBox.Show("Department already added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    .Rows.Add(obj)
                End If
            End If
        End With

    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        With GridEODAccessRight
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete selected department ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Function IsValidateDupDepart(ByVal pObj() As Object, ByVal pDepartID As Integer) As Boolean

        Dim IsExist As Boolean = False

        With GridEODAccessRight
            For Each rRow As DataGridViewRow In .Rows
                If rRow.Cells("cDepartID").Value = pDepartID Then
                    IsExist = True
                    Exit For
                End If
            Next
        End With

        Return IsExist

    End Function

End Class