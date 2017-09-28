Public Class FrmMainDiagnosis
    Public isDiagClose As Boolean = False
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtDiagnosis, "diagnosis", ErrDiagnosis) = False Then
            MsgBox("Please you fill diagnosis.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If LblSaveOption.Text = "0" Then
            If ModDiagnosis.CheckNameDiagnosis(TxtDiagnosis.Text) > 0 Then
                MsgBox("Duplicate diagnosis name. Could check agian", MsgBoxStyle.Critical, "Error")
                TxtDiagnosis.Focus()
                TxtDiagnosis.SelectAll()
                Exit Sub
            End If
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModDiagnosis.InsertMainDiagnosis(TxtDiagnosis.Text, TxtDescription.Text, TxtCode.Text, ChTypeOther.Checked) = 1 Then
                    MsgBox("Save diagnosis successfully.", MsgBoxStyle.Information, "Save")
                    isDiagClose = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Error save diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModDiagnosis.UpdateMainDiagnosis(LblSaveOption.Text, TxtDiagnosis.Text, TxtDescription.Text, TxtCode.Text, ChTypeOther.Checked) = 1 Then
                    MsgBox("Update diagnosis successfully.", MsgBoxStyle.Information, "Update")
                    isDiagClose = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox("Error update diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub BtnCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCance.Click
        isDiagClose = False
        Me.Close()
    End Sub
End Class