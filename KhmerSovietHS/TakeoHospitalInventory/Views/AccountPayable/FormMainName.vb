Public Class FormMainName

    Dim DAAccountPayable As New DSAccountPayableTableAdapters.ACCOUNT_PAYABLETableAdapter
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshAccount()
    End Sub

    Sub RefreshAccount()
        GridAccountName.DataSource = DAAccountPayable.GetData
    End Sub

    Private Sub BtnNewName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewName.Click
        Dim FNewAccountName As New FormPayablename
        If FNewAccountName.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAccount()
        End If
    End Sub

    Private Sub GridAccountName_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAccountName.RowDoubleClick
        Dim FNewAccountName As New FormPayablename
        FNewAccountName.LblSaveOption.Text = GridAccountName.GetRow.Cells("AccountID").Value
        FNewAccountName.TxtAccountName.Text = GridAccountName.GetRow.Cells("AccountName").Value
        FNewAccountName.TxtDescription.Text = GridAccountName.GetRow.Cells("Description").Value
        If FNewAccountName.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAccount()
        End If
    End Sub
End Class