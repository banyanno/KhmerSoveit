Public Class FRMChangePwdInventory
    Dim IUser As IUserManagement = New UserManagementImplement
    Private THIUserContex As New BaseDataContext

    Private Sub BtnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChange.Click

        If ValidateTextField(TxtPwd, "", ErrChangePWD) = False Then Exit Sub
        If ValidateTextField(TxtVerifyPwd, "", ErrChangePWD) = False Then Exit Sub
        If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtPwd.Text.ToUpper.Trim Then
            MsgBox("Password does not match verify password.please Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
            Me.TxtVerifyPwd.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Do you want to change password?", "Pwd", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim user = From TblUser In THIUserContex.getTHIDataContextUserManagement.Department_Users Where TblUser.UserID = Val(LblUserID.Text)
            Dim Tuser As Department_User = user.SingleOrDefault
            'user.UserID = LblUserID.Text
            'user.UserName = TxtLoginName.Text
            'user.EmployeeName = TxtLoginName.Text
            'user.Password = TxtVerifyPwd.Text.Trim
            Tuser.NewPassword = TxtVerifyPwd.Text.Trim
            If IUser.ChangePwdUser(Tuser) = True Then
                MessageBox.Show("Change password successful.", "pwd", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Close()
            Me.Dispose()
        End If

    End Sub


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

End Class