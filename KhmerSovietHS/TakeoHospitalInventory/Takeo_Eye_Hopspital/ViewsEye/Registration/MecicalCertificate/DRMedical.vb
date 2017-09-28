Public Class DRMedical
    Dim DA_Medical As New DSMedicalCertificateTableAdapters.MEDICAL_DRTableAdapter
    Private Sub BtnDr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDr.Click
        Dim NDr As New NewDr
        If NDr.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshDr()
        End If

    End Sub
    Private Sub RefreshDr()
        GridDr.DataSource = DA_Medical.GetData
    End Sub

    Private Sub GridDr_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDr.RowDoubleClick
        If GridDr.SelectedItems.Count = 0 Then Exit Sub
        Dim NDr As New NewDr
        NDr.lblSave.Text = GridDr.GetRow.Cells("DR_ID").Value
        NDr.TxtDrname.Text = GridDr.GetRow.Cells("DRNAME").Value
        NDr.TxtSkill.Text = GridDr.GetRow.Cells("DR_SKILL").Value
        If NDr.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshDr()
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridDr.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Medical.DeleteDr(GridDr.GetRow.Cells("DR_ID").Value) Then
                RefreshDr()
            End If
        End If
    End Sub

    Private Sub DRMedical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshDr()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshDr()
    End Sub
End Class