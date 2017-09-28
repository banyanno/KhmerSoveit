Public Class DASH_INVEST_LASER
    Dim DA_Laser As New DS_Invest_LaserTableAdapters.S_LASERTableAdapter
    Dim DA_Invest As New DS_Invest_LaserTableAdapters.S_INVESTIGATETableAdapter
    Private Sub BtnNewLaser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLaser.Click
        Dim FLaser As New FormLaser
        If FLaser.ShowDialog = DialogResult.OK Then
            RefreshLaser()
        End If
    End Sub
    Private Sub RefreshLaser()
        GridLaser.DataSource = DA_Laser.GetData
    End Sub

    Private Sub BtnUpdateLaser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateLaser.Click
        If GridLaser.SelectedItems.Count = 0 Then Exit Sub
        Dim FLaser As New FormLaser
        FLaser.LblSaveOption.Text = GridLaser.GetRow.Cells("LASER_ID").Value
        FLaser.TxtLaser.Text = GridLaser.GetRow.Cells("LASER_NAME").Value
        FLaser.TxtLaserPrice.Text = GridLaser.GetRow.Cells("LASER_PRICE").Value
        If FLaser.ShowDialog = DialogResult.OK Then
            RefreshLaser()
        End If
    End Sub

    Private Sub BtnDeleteLaser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteLaser.Click
        If GridLaser.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Laser.DeleteLaser(GridLaser.GetRow.Cells("LASER_ID").Value) = 1 Then
                RefreshLaser()
            End If
        End If
    End Sub
    Private Sub RefreshInvest()
        GridEX1.DataSource = DA_Invest.GetData
    End Sub
    Private Sub DASH_INVEST_LASER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshLaser()
        RefreshInvest()
    End Sub

    Private Sub BtnNewInvest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInvest.Click
        Dim FInvest As New FormNewInvest
        If FInvest.ShowDialog = DialogResult.OK Then
            RefreshInvest()
        End If
    End Sub

    Private Sub BtlUpdateInves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtlUpdateInves.Click
        If GridEX1.SelectedItems.Count = 0 Then Exit Sub
        Dim FInvest As New FormNewInvest
        FInvest.LblSaveOption.Text = GridEX1.GetRow.Cells("INVES_ID").Value
        FInvest.TxtInvestigate.Text = GridEX1.GetRow.Cells("INVEST_NAME").Value
        FInvest.TxtInvestPrice.Text = GridEX1.GetRow.Cells("INVEST_PRICE").Value
        If FInvest.ShowDialog = DialogResult.OK Then
            RefreshInvest()
        End If
    End Sub

    Private Sub BtnRefreshInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshInv.Click
        RefreshInvest()
    End Sub

    Private Sub GridLaser_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridLaser.RowDoubleClick
        If GridLaser.SelectedItems.Count = 0 Then Exit Sub
        Dim FLaser As New FormLaser
        FLaser.LblSaveOption.Text = GridLaser.GetRow.Cells("LASER_ID").Value
        FLaser.TxtLaser.Text = GridLaser.GetRow.Cells("LASER_NAME").Value
        FLaser.TxtLaserPrice.Text = GridLaser.GetRow.Cells("LASER_PRICE").Value
        If FLaser.ShowDialog = DialogResult.OK Then
            RefreshLaser()
        End If
    End Sub

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If GridEX1.SelectedItems.Count = 0 Then Exit Sub
        Dim FInvest As New FormNewInvest
        FInvest.LblSaveOption.Text = GridEX1.GetRow.Cells("INVES_ID").Value
        FInvest.TxtInvestigate.Text = GridEX1.GetRow.Cells("INVEST_NAME").Value
        FInvest.TxtInvestPrice.Text = GridEX1.GetRow.Cells("INVEST_PRICE").Value
        If FInvest.ShowDialog = DialogResult.OK Then
            RefreshInvest()
        End If
    End Sub

    Private Sub BtnDeletInves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletInves.Click
        If GridEX1.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Invest.DeleteIvest(GridEX1.GetRow.Cells("INVES_ID").Value) = 1 Then
                RefreshInvest()
            End If
        End If
    End Sub
End Class
