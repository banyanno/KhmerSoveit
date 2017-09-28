Public Class FamilyStatus
    Dim DA_FamilyStatus As New DSConsultTableAdapters.FAMILY_STATUSTableAdapter
    Private Sub FamilyStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshStatus()
    End Sub
    Private Sub RefreshStatus()
        GridFamilyStatus.DataSource = DA_FamilyStatus.GetData
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FNewFamilyStatus As New NewFamilyStatus
        If FNewFamilyStatus.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshStatus()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If GridFamilyStatus.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_FamilyStatus.DeleteFamilyStatus(GridFamilyStatus.GetRow.Cells("F_ID").Value) = 1 Then
                RefreshStatus()
            End If
        End If
    End Sub

    Private Sub GridFamilyStatus_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFamilyStatus.RowDoubleClick
        If GridFamilyStatus.SelectedItems.Count = 0 Then Exit Sub
        Dim FNewFamilyStatus As New NewFamilyStatus
        FNewFamilyStatus.lblSaveOption.Text = GridFamilyStatus.GetRow.Cells("F_ID").Value
        FNewFamilyStatus.txtStatus.Text = GridFamilyStatus.GetRow.Cells("FAMILY_STATUS").Value
        If FNewFamilyStatus.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshStatus()
        End If
    End Sub
End Class