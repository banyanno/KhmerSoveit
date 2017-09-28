Public Class FrmNewDistrict

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtDistrict, "", ErrDistrict) = False Then Exit Sub
        If ValidateTextField(TxtDistrictCode, "", ErrDistrict) = False Then Exit Sub
       
        If LblSaveOption.Text = "0" Then
            If CheckDistictCode(TxtDistrictCode.Text) = True Then
                MessageBox.Show("This district code already exist. Could you change other code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModProvince.InsertDistrict(LblProvinceNo.Text, TxtDistrictCode.Text, TxtDistrict.Text) = 1 Then
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModProvince.UpdateDistrict(LblSaveOption.Text, TxtDistrict.Text) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub TxtDistrictCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDistrictCode.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class