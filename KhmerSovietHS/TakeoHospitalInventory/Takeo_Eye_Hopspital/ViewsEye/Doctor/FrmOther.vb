Public Class FrmOther
    Public isCloseOther As Boolean = False
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtOther, "other", ErrOther) = False Then
            MsgBox("Please fill other.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            If LblSaveOption.Text = "0" Then
                DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                    If ModDoctor.SaveOther(TxtOther.Text, TxtDescription.Text) = 1 Then
                        MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                        isCloseOther = True
                        Me.Close()
                    Else
                        MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            Else
                DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                    If ModDoctor.UdateOther(LblSaveOption.Text, TxtOther.Text, TxtDescription.Text) = 1 Then
                        MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                        isCloseOther = True
                        Me.Close()
                    End If
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
            End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        isCloseOther = False
        Me.Close()
    End Sub
End Class