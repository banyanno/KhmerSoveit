Public Class FrmNewOccupation

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateTextField(TxtOccupation, "", ErrOccupation) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            Dim DialogSave As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DialogSave = Windows.Forms.DialogResult.Yes Then
                If ModOccupation.InsertOccupation(TxtOccupation.Text) = 1 Then
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            Dim DialogUpdate As DialogResult = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DialogUpdate = Windows.Forms.DialogResult.Yes Then
                If ModOccupation.UpdateOccupation(LblSaveOption.Text, TxtOccupation.Text) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub
End Class