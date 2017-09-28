Public Class UCaseLab
    Dim DA_LABO As New DS_Invest_LaserTableAdapters.S_LABORATORYTableAdapter
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim Labo As New FLabo
        If Labo.ShowDialog = DialogResult.OK Then
            GridLaboratory.DataSource = DA_LABO.GetData
        End If

    End Sub

    Private Sub UCaseLab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridLaboratory.DataSource = DA_LABO.GetData
    End Sub

    Private Sub bntRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntRefresh.Click
        GridLaboratory.DataSource = DA_LABO.GetData
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If GridLaboratory.SelectedItems.Count = 0 Then Exit Sub
        Dim Labo As New FLabo
        Labo.LblSaveOption.Text = GridLaboratory.GetRow.Cells("LABO_ID").Value
        Labo.TxtLaboratory.Text = GridLaboratory.GetRow.Cells("LABO_NAME").Value
        Labo.TxtLaboPrice.Text = GridLaboratory.GetRow.Cells("LABO_PRICE").Value
        If Labo.ShowDialog = DialogResult.OK Then
            GridLaboratory.DataSource = DA_LABO.GetData
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridLaboratory.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_LABO.DeleteLabo(GridLaboratory.GetRow.Cells("LABO_ID").Value) = 1 Then
                GridLaboratory.DataSource = DA_LABO.GetData
            End If
        End If
    End Sub

    Private Sub GridLaboratory_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridLaboratory.RowDoubleClick
        If GridLaboratory.SelectedItems.Count = 0 Then Exit Sub
        Dim Labo As New FLabo
        Labo.LblSaveOption.Text = GridLaboratory.GetRow.Cells("LABO_ID").Value
        Labo.TxtLaboratory.Text = GridLaboratory.GetRow.Cells("LABO_NAME").Value
        Labo.TxtLaboPrice.Text = GridLaboratory.GetRow.Cells("LABO_PRICE").Value
        If Labo.ShowDialog = DialogResult.OK Then
            GridLaboratory.DataSource = DA_LABO.GetData
        End If
    End Sub
End Class
