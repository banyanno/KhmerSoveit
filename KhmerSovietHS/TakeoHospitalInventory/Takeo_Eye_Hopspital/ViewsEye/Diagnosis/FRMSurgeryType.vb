Public Class FRMSurgeryType
    Public isSurgClose As Boolean = False
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtSurgeriesType, "Surgeries", ErrSurgeries) = False Then
            MsgBox("Please fill surgeries type.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If LblSaveOption.Text = "0" Then
            If ModSurgeries.CheckSurgeries(TxtSurgeriesType.Text) > 0 Then
                MsgBox("Duplicate surgeries name. Could you check agian", MsgBoxStyle.Critical, "Error")
                TxtSurgeriesType.Focus()
                TxtSurgeriesType.SelectAll()
                Exit Sub
            End If
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModSurgeries.InsertNewSurgeries(TxtSurgeriesType.Text, TxtDescription.Text, ChTypeOther.Checked, EmptyString(TxtSurgeryPrice.Text)) = 1 Then
                    MsgBox("Save surgeries successfully.", MsgBoxStyle.Information, "Save")
                    isSurgClose = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Error save surgeries.", MsgBoxStyle.Critical)
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModSurgeries.UpdateSurgeries(LblSaveOption.Text, TxtSurgeriesType.Text, TxtDescription.Text, ChTypeOther.Checked, EmptyString(TxtSurgeryPrice.Text)) = 1 Then
                    MsgBox("Update surgeries successfully", MsgBoxStyle.Information)
                    isSurgClose = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Error update surgeries.", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        isSurgClose = False
        Me.Close()
    End Sub

    Private Sub TxtSurgeryPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSurgeryPrice.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class