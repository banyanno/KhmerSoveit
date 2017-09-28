Public Class FrmChangeUserPWD
    Dim IUser As New UserManagementImplement
    Dim ObjDepUser As Department_User

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If checkValidateField() = False Then
            Exit Sub
        Else
            If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtNewPwd.Text.ToUpper.Trim Then
                MsgBox("Password does not match verify password. Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
                Me.TxtVerifyPwd.Focus()
                Exit Sub
            End If
            DIALOG_SAVE = MessageBox.Show("Do you want change password?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                ObjDepUser.NewPassword = TxtVerifyPwd.Text
                If IUser.UpdateUser() = True Then
                    MessageBox.Show("Change password succesfful.", "Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Can't change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                'ModUserLogin.changePassword(TxtUserName.Text, TxtVerifyPwd.Text)
                'MsgBox("Password changed successfully.", MsgBoxStyle.Information, "Save")
                'Me.Close()
            End If
        End If
    End Sub
    Function checkValidateField() As Boolean
        If Me.TxtUserName.Text.Trim = "" Then
            MsgBox("Please key in user name.", MsgBoxStyle.Information, "UserName")
            Me.TxtUserName.Focus()
            Return False
        Else
            Return True
        End If
        If Me.TxtNewPwd.Text.Trim = "" Then
            MsgBox("Please key in password.", MsgBoxStyle.Information, "Password")
            Me.TxtNewPwd.Focus()
            Return False
        Else
            Return True
        End If
        If Me.TxtVerifyPwd.Text.Trim = "" Then
            MsgBox("Please key in verify password.", MsgBoxStyle.Information, "Verify Password")
            Me.TxtVerifyPwd.Focus()
            Return False
        Else
            Return True
        End If
        If Me.TxtNewPwd.Text.Length <= 5 Then
            MsgBox("Password cannot be less than 6 numbers or characters.", MsgBoxStyle.Critical, "Password Check confirm")
            Me.TxtNewPwd.Focus()
            Return False
        Else
            Return True
        End If
        If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtNewPwd.Text.ToUpper.Trim Then
            MsgBox("Password does not match verify password. Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
            Me.TxtVerifyPwd.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmChangeUserPWD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObjDepUser = IUser.GetUID(LblUserID.Text)
    End Sub
End Class