Public Class UCRefferralOfTEH
    Dim DA_Referral_TEH As New DSREFFERRAL_TEHTableAdapters.REFFERAL_TEHTableAdapter

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click

        Dim F_TehReferral As New FRM_TEHReferral
        If F_TehReferral.ShowDialog = DialogResult.OK Then
            RefreshReferral()
        End If
    End Sub
    Private Sub RefreshReferral()
        GridReferral.DataSource = DA_Referral_TEH.GetData
    End Sub

    Private Sub UCRefferralOfTEH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshReferral()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If GridReferral.SelectedItems.Count = 0 Then Exit Sub
        Dim F_TehReferral As New FRM_TEHReferral
        F_TehReferral.LblSave.Text = GridReferral.GetRow.Cells("REFERRAL_ID").Value
        F_TehReferral.TxtReferral.Text = GridReferral.GetRow.Cells("REFFERAL_NAME").Value
        F_TehReferral.TxtDescription.Text = GridReferral.GetRow.Cells("REFFERAL_DES").Value
        If F_TehReferral.ShowDialog = DialogResult.OK Then
            RefreshReferral()
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridReferral.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete this referral?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Referral_TEH.DeleteReferral(GridReferral.GetRow.Cells("REFERRAL_ID").Value) = 1 Then
                RefreshReferral()
            Else
                MessageBox.Show("Error delete referral.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

   
End Class
