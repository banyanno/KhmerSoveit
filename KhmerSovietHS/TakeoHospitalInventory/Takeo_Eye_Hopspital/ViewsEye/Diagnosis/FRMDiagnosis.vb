Public Class FRMDiagnosis

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtDiagnosis, "diagnosis", ErrSubDiagnosis) = False Then
            MsgBox("Please fill diagnosis.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If LblSaveOption.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModDiagnosis.InsertSubDiagnosis(LblMainDiagID.Text, txtDiagnosis.Text, txtDescription.Text, TxtCode.Text) = 1 Then
                    MsgBox("Save sub diagnosis successfully", MsgBoxStyle.Information, "Save")
                Else
                    MsgBox("Error save sub diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModDiagnosis.UpdateSubDiagnosis(LblSaveOption.Text, LblMainDiagID.Text, txtDiagnosis.Text, txtDescription.Text, TxtCode.Text) = 1 Then
                    MsgBox("Update diagnosis successfully.", MsgBoxStyle.Information, "Update")
                Else
                    MsgBox("Error update diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If

        End If
    End Sub

    Private Sub TxtCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCancel.Click
        Me.Close()
    End Sub


   
End Class