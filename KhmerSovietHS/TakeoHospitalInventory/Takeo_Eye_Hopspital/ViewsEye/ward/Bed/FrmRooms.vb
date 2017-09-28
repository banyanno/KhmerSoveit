Public Class FrmRooms

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo)
        If ValidateTextField(txtRoomName, "room name", ErrRoom) = False Then
            Exit Sub
        End If
        If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
            ModRoomAndBed.SaveRoom(txtRoomName.Text, txtDescription.Text)
        End If
    End Sub
End Class