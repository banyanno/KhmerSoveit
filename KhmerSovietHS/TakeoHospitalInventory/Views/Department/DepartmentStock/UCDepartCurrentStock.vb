Imports Janus.Windows.GridEX

Public Class UCDepartCurrentStock
    Dim ItemListInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim DAInHouseUsed As New DSInhouseUsedItemTableAdapters.VUsedWithUsedDetailTableAdapter
    Dim IsSplitClose As Boolean = False
    Private MTakeoInventory As MainTakeoInventory

    Public Sub New(ByVal MTakeoInventory As MainTakeoInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        ItemListInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub UCDepartCurrentStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))

    End Sub

    Private Sub menuRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
    End Sub

    Private Sub BtnInitialItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInitialItem.Click

        'Try
        Dim FItemListForDepart As New frmItemListForDepart
        If FItemListForDepart.ShowDialog() = Windows.Forms.DialogResult.OK Then
            gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
        End If
        'Catch ex As Exception

        'End Try
        
    End Sub

    Private Sub BtnAdjustStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdjustStock.Click
        Dim FAdjustStock As New frmAdjustStock
        If gridDepartItems.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select item in the list that you want to Adjust.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'If Not gridDepartItems.CurrentRow Is Nothing AndAlso gridDepartItems.CurrentRow.RowType = RowType.Record Then
        Else

            FAdjustStock.isAdjustExistItem = True
            FAdjustStock.adjustItemID = gridDepartItems.SelectedItems(0).GetRow.Cells("ItemID").Value
            FAdjustStock.adjustItemName = gridDepartItems.SelectedItems(0).GetRow.Cells("ItemName").Value

            'If IsDBNull(gridDepartItems.SelectedItems(0).GetRow.Cells("Barcode").Value) = False Then
            FAdjustStock.adjustBarcode = gridDepartItems.SelectedItems(0).GetRow.Cells("Barcode").Value
            'End If

            If FAdjustStock.ShowDialog() = Windows.Forms.DialogResult.OK Then
                gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
            End If
        End If
    End Sub

    Private Sub BtnRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshData.Click
        gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
        SplitContainer2.Panel1Collapsed = False
        SplitContainer2.Panel2Collapsed = True

    End Sub

    Private Sub BtnUsedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUsedItem.Click

        Dim FInHouseUsedItem As New frmDepartInHouseUsedItem
        If FInHouseUsedItem.ShowDialog() = Windows.Forms.DialogResult.OK Then
            DEP_EOD.BtnEndofDay_Click(sender, e)
            gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
        End If

    End Sub

    Private Sub gridDepartItems_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridDepartItems.SelectionChanged
        Try
            Dim ItemUseByItem As Double = gridDepartItems.GetRow.Cells("ItemID").Value
            Dim TemTblUser As DataTable = DAInHouseUsed.GetUsedParticularItemInPeriodOfTime(DEPART_ID, dptFromDate.Value.Date, dptToDate.Value.Date, ItemUseByItem)
            gridItemUsed.DataSource = TemTblUser
            PictItem.Image = gridDepartItems.GetRow.Cells("Picture").Value
        Catch ex As Exception
            PictItem.Image = Nothing
        End Try
    End Sub

    Private Sub BtnUseTemplet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUseTemplet.Click

        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        If BgLoadingReport.IsBusy = True Then
            BgLoadingReport.CancelAsync()
        Else            
            BgLoadingReport.RunWorkerAsync()
        End If

    End Sub

    Sub PrintItemUseTemplet()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PrintItemUseTemplet))
        Else
            Dim TblItemTemInDepar As DataTable = ItemListInDepartDataAdapter.GetItemDataByDepartID(DEPART_ID)
            Dim ObjMonlyUsedItem As New CryMonlyUsedItem
            ObjMonlyUsedItem.SetDataSource(TblItemTemInDepar)
            CRVItemMonthlyUsed.ReportSource = ObjMonlyUsedItem

            SplitContainer2.Panel1Collapsed = True
            SplitContainer2.Panel2Collapsed = False
        End If

    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        '---- print request order ----------
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.ReportOption = 5    
        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim TemDepItemUser As DataTable = DAInHouseUsed.GetUsedDataInPeriodOfTime(DEPART_ID, dptFromDate.Value.Date, dptToDate.Value.Date)
        gridItemUsed.DataSource = TemDepItemUser
    End Sub

    Private Sub BtnViewHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewHistory.Click
        If IsSplitClose = False Then
            SplitContainer1.Panel2Collapsed = False
            IsSplitClose = True
        Else
            SplitContainer1.Panel2Collapsed = True
            IsSplitClose = False
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        '---- print request order ----------
        Dim FRptRequestView As New frmReportViewer

        FRptRequestView.ReportOption = 2
        FRptRequestView.FDate = dptFromDate.Value.Date
        FRptRequestView.TDate = dptToDate.Value.Date

        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    
    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        PrintItemUseTemplet()
    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub
End Class
