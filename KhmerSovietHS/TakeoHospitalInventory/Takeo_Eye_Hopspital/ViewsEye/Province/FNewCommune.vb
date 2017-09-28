Public Class FNewCommune

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtCommune, "", ErrCommune) = False Then Exit Sub
        If ValidateTextField(TxtCommuneCode, "", ErrCommune) = False Then Exit Sub
       
        If LblSaveOption.Text = "0" Then
            If CheckComCode(TxtCommuneCode.Text) = True Then
                MessageBox.Show("This commune code already exist. Could you change other code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModProvince.InsertCommune(lblProvince.Text, LblDistric.Text, TxtCommuneCode.Text, TxtCommune.Text) = 1 Then
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModProvince.UpdateCommune(LblSaveOption.Text.Trim, TxtCommune.Text.Trim) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub TxtCommuneCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCommuneCode.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class