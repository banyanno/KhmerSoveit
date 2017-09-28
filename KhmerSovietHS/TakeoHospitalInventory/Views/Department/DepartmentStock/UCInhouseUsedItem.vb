Public Class UCInhouseUsedItem

    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim MainStockItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
  
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim VUsedWithUsedDetailDataAdapter As DSInhouseUsedItemTableAdapters.VUsedWithUsedDetailTableAdapter

    Dim VUsedDataAdapter As DSInhouseUsedItemTableAdapters.VUsedTableAdapter
    Dim VUsedDetailDataAdapter As DSInhouseUsedItemTableAdapters.VUsedDetailTableAdapter

    '--- New Update 12/12/2011

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        VUsedDataAdapter = New DSInhouseUsedItemTableAdapters.VUsedTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        VUsedDetailDataAdapter = New DSInhouseUsedItemTableAdapters.VUsedDetailTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        MainStockItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VUsedWithUsedDetailDataAdapter = New DSInhouseUsedItemTableAdapters.VUsedWithUsedDetailTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnNewInhouseUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInhouseUsed.Click

        Dim FInHouseUsedItem As New frmMainStockInHouseUsedItem
        If FInHouseUsedItem.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
        End If
    End Sub

    Private Sub UCInhouseUsedItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
            LoadHospitalItemUsed()
        Else
            LoadDepartItemUsed()
        End If

    End Sub

    Private Sub LoadDepartItemUsed()
        Dim inhouseUsedItem As New DSInhouseUsedItem

        VUsedDataAdapter.FillByDepartmentInPeriodOfTime(inhouseUsedItem.VUsed, DEPART_ID, dptFromDate.Value.Date, dptToDate.Value.Date)
        VUsedDetailDataAdapter.GetData()
        VUsedDetailDataAdapter.Fill(inhouseUsedItem.VUsedDetail)

        gridItemUsed.DataSource = inhouseUsedItem.VUsed
        gridItemUsed.RootTable.ChildTables(0).DataMember = "VUsed_VUsedDetail"

    End Sub

    Private Sub LoadHospitalItemUsed()
        Dim inhouseUsedItem As New DSInhouseUsedItem

        VUsedDataAdapter.FillByDateToDate(inhouseUsedItem.VUsed, dptFromDate.Value.Date, dptToDate.Value.Date)
        VUsedDataAdapter.GetData()
        VUsedDetailDataAdapter.Fill(inhouseUsedItem.VUsedDetail)

        gridItemUsed.DataSource = inhouseUsedItem.VUsed
        gridItemUsed.RootTable.ChildTables(0).DataMember = "VUsed_VUsedDetail"

    End Sub

    Private Sub BtnRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshData.Click
        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
            LoadHospitalItemUsed()
        Else
            LoadDepartItemUsed()
        End If
    End Sub

    'Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
    '    '---- print request order ----------
    '    Dim FRptRequestView As New frmReportViewer

    '    FRptRequestView.ReportOption = 2
    '    FRptRequestView.FDate = dptFromDate.Value.Date
    '    FRptRequestView.TDate = dptToDate.Value.Date

    '    If FRptRequestView.ShowDialog = DialogResult.OK Then

    '    End If
    'End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        Dim FRptRequestView As New frmReportViewer

        FRptRequestView.ReportOption = 2
        FRptRequestView.FDate = dptFromDate.Value.Date
        FRptRequestView.TDate = dptToDate.Value.Date

        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If

    End Sub

    Private Sub BgLoadingData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingData.DoWork

    End Sub
End Class
