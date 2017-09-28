Public Class FRMNewDoctor
    Public isDoctorClose As Boolean = False
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.isDoctorClose = False
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click


        If ValidateTextField(TxtDoctorName, "Doctor name", ErrDoctor) = False _
        Or ValidateCombobox(CboSex, "Sex", ErrDoctor) = False _
        Or ValidateTextField(TxtAge, "age", ErrDoctor) = False _
        Or ValidateTextField(TxtTel, "Telephone", ErrDoctor) = False Then
            Exit Sub
        End If
        If lblSaveOption.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModDoctor.SaveDoctor(TxtDoctorName.Text, CboSex.Text, TxtAge.Text, TxtTel.Text, TxtFunction.Text) = 1 Then
                    'MsgBox("Save doctor successfully.", MsgBoxStyle.Information, "Save")
                    isDoctorClose = True
                    Me.Close()
                Else
                    MsgBox("Error save doctor.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModDoctor.UpdateDoctor(lblSaveOption.Text, TxtDoctorName.Text, CboSex.Text, TxtAge.Text, TxtTel.Text, TxtFunction.Text) = 1 Then
                    ' MsgBox("Update doctor successfully.", MsgBoxStyle.Information, "Update")
                    Me.isDoctorClose = True
                    Me.Close()
                Else
                    MsgBox("Error update doctor.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class