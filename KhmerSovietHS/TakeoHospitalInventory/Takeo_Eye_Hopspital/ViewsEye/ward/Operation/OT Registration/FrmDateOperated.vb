Public Class FrmDateOperated

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DateOperated.Checked = False Then
            MsgBox("Please check date operated.", MsgBoxStyle.Critical, "Date Operated")
            Exit Sub
        Else
            If ModOTRegistration.UpdateDateOperated(LblSaveOption.Text, DateOperated.Value) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class