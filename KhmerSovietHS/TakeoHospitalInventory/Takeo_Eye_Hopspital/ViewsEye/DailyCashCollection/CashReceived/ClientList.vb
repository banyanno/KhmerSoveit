Public Class ClientList
    Dim DA_Client As New DSPatientReceiptTableAdapters.CASH_RECEIVED_CUSTOMERTableAdapter
    Private Sub btnNewClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewClient.Click
        Dim ClientInfo As New NewCustomReceived
        If ClientInfo.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshClient()
        End If
    End Sub
    Private Sub RefreshClient()
        Dim tblClient As DataTable = DA_Client.GetData
        GridClient.DataSource = tblClient
    End Sub

    Private Sub GridClient_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClient.RowDoubleClick
        If GridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim ClientInfo As New NewCustomReceived
        ClientInfo.LblSaveOption.Text = GridClient.GetRow.Cells("CUS_RECEIVEDID").Value
        ClientInfo.TxtCusName.Text = GridClient.GetRow.Cells("CUS_NAME").Value
        ClientInfo.TxtCusNameEng.Text = GridClient.GetRow.Cells("CUS_NAME_ENG").Value
        ClientInfo.TxtAge.Text = GridClient.GetRow.Cells("AGE").Value
        ClientInfo.CboSex.Text = GridClient.GetRow.Cells("SEX").Value
        ClientInfo.TxtMoreInfo.Text = GridClient.GetRow.Cells("DES_INFO").Value
        If ClientInfo.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshClient()
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridClient.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete this client?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Client.DeleteClient(True, GridClient.GetRow.Cells("CUS_RECEIVEDID").Value) = 1 Then
                RefreshClient()
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshClient()
    End Sub

    Private Sub ClientList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshClient()
    End Sub
End Class