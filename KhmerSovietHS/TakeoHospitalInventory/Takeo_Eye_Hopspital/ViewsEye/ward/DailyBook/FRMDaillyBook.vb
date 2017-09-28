Public Class FRMDaillyBook
    Public isCloseDaillBook As Boolean = False
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModDaillyBook.SaveNewDaillyBook(LblNewInpatientNo.Text, TxtPatientNo.Text, CboEye.Text, TxtTreatment.Text, Now) = 1 Then
                    MsgBox("Save dailly book successfully.", MsgBoxStyle.Information, "Save")
                    Me.isCloseDaillBook = True
                    Me.Close()
                Else
                    MsgBox("Error save dailly book.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModDaillyBook.UpdateDaillyBook(LblSaveOption.Text, CboEye.Text, TxtTreatment.Text, Now) = 1 Then
                    MsgBox("Update dailly book successfully.", MsgBoxStyle.Information, "Update")
                    Me.isCloseDaillBook = True
                    Me.Close()
                Else
                    MsgBox("Error update dailly book.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.isCloseDaillBook = False
        Me.Close()
    End Sub

End Class