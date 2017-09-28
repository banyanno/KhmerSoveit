Public Class NewFamilyStatus
    Dim DA_FamilyStatus As New DSConsultTableAdapters.FAMILY_STATUSTableAdapter
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(txtStatus, "", ErrFamilyStatus) = False Then Exit Sub
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new family status", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FamilyStatus.InsertFamilyStatus(txtStatus.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update family status", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FamilyStatus.UpdateFamilyStatus(txtStatus.Text, lblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class