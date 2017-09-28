Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data.Common

Public Class UCReportItemTransaction

    Dim CateDataAdapter As DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
    Dim ItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim VRunEndofDayResultDataAdapter As DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
    Dim VRunEndofMonthDataAdapter As DSEndofDayRunTableAdapters.VRunEndOfPeriodMonthTableAdapter
    Dim VRunEndOfMonthResultDataAdapter As DSEndofDayRunTableAdapters.tblEndofMonthRunTableAdapter
    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim VDataStockAdjustmentDataAdapter As DSDepartmentStockTableAdapters.VAdjustStockHistoryTableAdapter

    Dim REDRepo As EndofDayRepository = New EndofDayRepository
    Private DFrom As Date
    Private DTo As Date
    Private IsDailyReport As Boolean
    Private IsMonthlyReport As Boolean
    Private Cr As New CrCategoryItemDailyTransactionReport
    Private Cr1 As New CrCategoryItemDailyTransactionReportV1
    Private CrCateItemMonthlyTransRpt As New CrCategoryItemMonthlyTransactionReport
    Private THIDataContext As New BaseDataContext
    Private CrStockAdjustmentRpt As New CrStockAdjustmentReport
    Private ReportOption As Integer
    Private cbCateSelectedValue As Integer
    Private MTakeoInventory As MainTakeoInventory


    Public Sub New(ByVal MTakeoInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        CateDataAdapter = New DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
        ItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        VRunEndofDayResultDataAdapter = New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
        VRunEndofMonthDataAdapter = New DSEndofDayRunTableAdapters.VRunEndOfPeriodMonthTableAdapter
        VRunEndOfMonthResultDataAdapter = New DSEndofDayRunTableAdapters.tblEndofMonthRunTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        VDataStockAdjustmentDataAdapter = New DSDepartmentStockTableAdapters.VAdjustStockHistoryTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub
   
    Private Sub UCReportItemTransaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'InitializeReportTypesList()
        'initialize Categories
        With cbCate
            .DataSource = CateDataAdapter.GetData
            .ValueMember = "CateID"
            .DisplayMember = "CateName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
            
            'Initialize Items
            With cbItems
                .DataSource = ItemDataAdapter.GetData
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .SelectedIndex = -1
                '.AutoCompleteMode = AutoCompleteMode.Suggest
                '.AutoCompleteSource = AutoCompleteSource.ListItems
            End With

            'Initialize Department
            With cbDepart
                .DataSource = DepartDataAdapter.GetData
                .ValueMember = "DepartID"
                .DisplayMember = "DepartName"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Else

            With cbItems
                .DataSource = ItemInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With

            'Initialize Department
            With cbDepart
                .DataSource = DepartDataAdapter.GetDepartDataByDepartID(CInt(DEPART_ID))
                .ValueMember = "DepartID"
                .DisplayMember = "DepartName"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If

        'rbDaily.Checked = True
        'IsDailyReport = True

        'ReportOption = 0

    End Sub    

    Sub PreviewByCate()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewByCate))
        Else
            MTakeoInventory.StatusLoading(True)
            DFrom = dptFromDate.Value.Date
            DTo = dptToDate.Value.Date
            Dim paramFields As New ParameterFields
            Dim paramField1 As New ParameterField
            Dim paramField2 As New ParameterField
            Dim paramField3 As New ParameterField



            If RadDateToDate.Checked = True Then
                '--- Update 09/12/2011 (Use dataset instead of sql command)
                Dim departTranDataByCateID As New DataTable
                If DEPART_ID = 28 Then
                    departTranDataByCateID = VRunEndofDayResultDataAdapter.GetDepartTranDataByCateID(Val(cbDepart.SelectedValue), cbCate.SelectedValue, DFrom, DTo)
                    Cr1.SetDataSource(departTranDataByCateID)
                    Cr1.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("category", "Category :" & cbCate.Text)
                    Cr1.SetParameterValue("depart", cbDepart.Text)
                Else
                    departTranDataByCateID = VRunEndofDayResultDataAdapter.GetDepartTranDataByCateID(Val(DEPART_ID), cbCate.SelectedValue, DFrom, DTo)

                    Cr1.SetDataSource(departTranDataByCateID)
                    Cr1.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("category", "Category :" & cbCate.Text)
                    Cr1.SetParameterValue("depart", DEPART_NAME)
                End If
                CRVItemTransaction.ReportSource = Cr1

                CRVItemTransaction.Refresh()
            End If
            If rbMontly.Checked = True Then
                Dim myRunEndofMonthResult As New DataTable
                If DEPART_ID = 28 Then
                    myRunEndofMonthResult = VRunEndofMonthDataAdapter.GetDataByCateIDAndDepartID(DFrom, DTo, cbCate.SelectedValue, CInt(cbDepart.SelectedValue))
                Else
                    myRunEndofMonthResult = VRunEndofMonthDataAdapter.GetDataByCateIDAndDepartID(DFrom, DTo, cbCate.SelectedValue, CInt(DEPART_ID))
                End If

                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans
                Try
                    Dim objDataTable As New TakeoHospitalInventory.DSEndofDayRun.tblEndofMonthRunDataTable
                    For Each rRow As DataRow In myRunEndofMonthResult.Rows
                        'If rRow("DepartID") = MAIN_STOCK_DEPART_ID Then

                        Dim beginBalanceOfMonth As Integer
                        Dim endBalanceOfMonth As Integer
                        Dim tmpMonthAndYear As String = ""

                        ' Prevent when rRow("smonth") return value "1/2012"
                        If rRow("smonth").ToString.Length = 6 Then
                            tmpMonthAndYear = "0" & rRow("smonth").ToString()
                        Else
                            tmpMonthAndYear = rRow("smonth").ToString()
                        End If

                        Dim sMonthAndYear As String = MonthName(CInt(tmpMonthAndYear.Substring(0, 2)))
                        sMonthAndYear &= " , " & tmpMonthAndYear.Substring(3, 4)

                        Dim q = From runendofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where runendofday.DepartID = CInt(DEPART_ID) And runendofday.ItemID = CInt(rRow("ItemID")) And runendofday.RunEndOfDayDate.Value.Date.Month = tmpMonthAndYear.Substring(0, 2) And runendofday.RunEndOfDayDate.Value.Date.Year = tmpMonthAndYear.Substring(3, 4) Order By runendofday.RunEndOfDayDate
                        If q.ToList.Count > 0 Then
                            Dim lstRunEndOfDay As New List(Of tblEndofDayRun)
                            lstRunEndOfDay = q.ToList
                            beginBalanceOfMonth = lstRunEndOfDay(0).BeginBalance
                            endBalanceOfMonth = lstRunEndOfDay(lstRunEndOfDay.Count - 1).EndBalance
                        Else
                            beginBalanceOfMonth = 0
                            endBalanceOfMonth = 0
                        End If

                        Dim mytblItem As tblItem = (From item In THIDataContext.getTHIDataContext.tblItems Where item.ItemID = CInt(rRow("ItemID"))).SingleOrDefault

                        Dim dataRow As DataRow = objDataTable.NewRow
                        dataRow("Date") = sMonthAndYear
                        dataRow("RequestQty") = CInt(rRow("RequestQty"))
                        dataRow("ReceivedQty") = CInt(rRow("ReceivedQty"))
                        dataRow("UsedQty") = CInt(rRow("UsedQty"))
                        dataRow("BeginBalance") = beginBalanceOfMonth
                        dataRow("EndBalance") = endBalanceOfMonth
                        dataRow("DepartID") = CInt(DEPART_ID) 'MAIN_STOCK_DEPART_ID
                        dataRow("ItemID") = CInt(rRow("ItemID"))
                        dataRow("ItemName") = mytblItem.ItemName
                        dataRow("Barcode") = mytblItem.Barcode

                        objDataTable.Rows.Add(dataRow)

                    Next
                    trans.Commit()

                    '---- Print report ------ VRunEndOfMonthResultDataAdapter
                    Dim runEndofMonthResult As DataTable = objDataTable
                    CrCateItemMonthlyTransRpt.SetDataSource(runEndofMonthResult)
                    CrCateItemMonthlyTransRpt.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    CrCateItemMonthlyTransRpt.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    CrCateItemMonthlyTransRpt.SetParameterValue("category", cbCate.Text)

                    If DEPART_ID = 28 Then
                        CrCateItemMonthlyTransRpt.SetParameterValue("depart", cbDepart.Text)
                    Else
                        CrCateItemMonthlyTransRpt.SetParameterValue("depart", DEPART_NAME)
                    End If


                    CRVItemTransaction.ReportSource = CrCateItemMonthlyTransRpt

                    CRVItemTransaction.Refresh()

                Catch ex As Exception
                    trans.Rollback()
                Finally
                    trans = Nothing
                    THIDataContext.getTHIDataContext.Connection.Close()
                End Try
            End If
            If rbDaily.Checked = True Then
                '--- Update 09/12/2011 (Use dataset instead of sql command)
                Dim departTranDataByCateID As New DataTable
                If DEPART_ID = 28 Then
                    departTranDataByCateID = VRunEndofDayResultDataAdapter.GetDepartTranDataByCateID(Val(cbDepart.SelectedValue), cbCate.SelectedValue, DFrom, DTo)
                    Cr.SetDataSource(departTranDataByCateID)
                    Cr.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("category", "Category :" & cbCate.Text)
                    Cr.SetParameterValue("depart", cbDepart.Text)
                Else
                    departTranDataByCateID = VRunEndofDayResultDataAdapter.GetDepartTranDataByCateID(Val(DEPART_ID), cbCate.SelectedValue, DFrom, DTo)

                    Cr.SetDataSource(departTranDataByCateID)
                    Cr.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("category", "Category :" & cbCate.Text)
                    Cr.SetParameterValue("depart", DEPART_NAME)
                End If

                CRVItemTransaction.ReportSource = Cr
                CRVItemTransaction.Refresh()
            End If
            If IsDailyReport = True Then




            Else ' In case user select Monthly



            End If
        End If

    End Sub

    Private Sub btnPreviewByCate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewByCate.Click
        If ValidateCombobox(cbDepart, "", ErrReport) = False Then Exit Sub
        If ValidateCombobox(cbCate, "", ErrReport) = False Then Exit Sub
        ' MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        If BgLoadingReport.IsBusy = True Then
            BgLoadingReport.CancelAsync()
        Else
            ReportOption = 1
            BgLoadingReport.RunWorkerAsync()
        End If

    End Sub

    Sub PreviewByItem()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewByItem))
        Else
            MTakeoInventory.StatusLoading(True)
            DFrom = dptFromDate.Value.Date
            DTo = dptToDate.Value.Date
            Dim paramFields As New ParameterFields
            Dim paramField1 As New ParameterField
            Dim paramField2 As New ParameterField
            Dim paramField3 As New ParameterField
            If RadDateToDate.Checked = True Then
                '--- Update 09/12/2011 (Use dataset instead of sql command)
                Dim departTranDataByItemID As New DataTable
                If DEPART_ID = 28 Then
                    departTranDataByItemID = VRunEndofDayResultDataAdapter.GetDepartTranDataByItemID(Val(cbDepart.SelectedValue), cbItems.SelectedValue, DFrom, DTo)
                    Cr1.SetDataSource(departTranDataByItemID)
                    Cr1.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("category", cbItems.Text)
                    Cr1.SetParameterValue("depart", cbDepart.Text)
                Else
                    departTranDataByItemID = VRunEndofDayResultDataAdapter.GetDepartTranDataByItemID(Val(DEPART_ID), cbItems.SelectedValue, DFrom, DTo)
                    Cr1.SetDataSource(departTranDataByItemID)
                    Cr1.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("category", cbItems.Text)
                    Cr1.SetParameterValue("depart", DEPART_NAME)
                End If
                CRVItemTransaction.ReportSource = Cr1
                CRVItemTransaction.Refresh()
            End If
            If rbMontly.Checked = True Then
                Dim myRunEndofMonthResult As New DataTable
                If DEPART_ID = 28 Then
                    myRunEndofMonthResult = VRunEndofMonthDataAdapter.GetDataByItemIDAndDepartID(DFrom, DTo, cbItems.SelectedValue, CInt(cbDepart.SelectedValue)) 'GetDataByCateIDAndDepartID(DFrom, DTo, cbCate.SelectedValue, CInt(DEPART_ID))
                Else
                    myRunEndofMonthResult = VRunEndofMonthDataAdapter.GetDataByItemIDAndDepartID(DFrom, DTo, cbItems.SelectedValue, CInt(DEPART_ID))
                End If


                Try
                    Dim objDataTable As TakeoHospitalInventory.DSEndofDayRun.tblEndofMonthRunDataTable
                    For Each rRow As DataRow In myRunEndofMonthResult.Rows

                        Dim beginBalanceOfMonth As Integer
                        Dim endBalanceOfMonth As Integer
                        Dim tmpMonthAndYear As String = ""

                        ' Prevent when rRow("smonth") return value "1/2012"
                        If rRow("smonth").ToString.Length = 6 Then
                            tmpMonthAndYear = "0" & rRow("smonth").ToString()
                        Else
                            tmpMonthAndYear = rRow("smonth").ToString()
                        End If

                        Dim sMonthAndYear As String = MonthName(CInt(tmpMonthAndYear.Substring(0, 2)))
                        sMonthAndYear &= " , " & tmpMonthAndYear.Substring(3, 4)

                        Dim q = From runendofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where runendofday.DepartID = CInt(DEPART_ID) And runendofday.ItemID = CInt(rRow("ItemID")) And runendofday.RunEndOfDayDate.Value.Date.Month = tmpMonthAndYear.Substring(0, 2) And runendofday.RunEndOfDayDate.Value.Date.Year = tmpMonthAndYear.Substring(3, 4) Order By runendofday.RunEndOfDayDate
                        If q.ToList.Count > 0 Then
                            Dim lstRunEndOfDay As New List(Of tblEndofDayRun)
                            lstRunEndOfDay = q.ToList
                            beginBalanceOfMonth = lstRunEndOfDay(0).BeginBalance
                            endBalanceOfMonth = lstRunEndOfDay(lstRunEndOfDay.Count - 1).EndBalance
                        Else
                            beginBalanceOfMonth = 0
                            endBalanceOfMonth = 0
                        End If

                        Dim mytblItem As tblItem = (From item In THIDataContext.getTHIDataContext.tblItems Where item.ItemID = CInt(rRow("ItemID"))).SingleOrDefault

                        Dim dataRow As DataRow = objDataTable.NewRow
                        dataRow("Date") = sMonthAndYear
                        dataRow("RequestQty") = CInt(rRow("RequestQty"))
                        dataRow("ReceivedQty") = CInt(rRow("ReceivedQty"))
                        dataRow("UsedQty") = CInt(rRow("UsedQty"))
                        dataRow("BeginBalance") = beginBalanceOfMonth
                        dataRow("EndBalance") = endBalanceOfMonth
                        dataRow("DepartID") = CInt(DEPART_ID) 'MAIN_STOCK_DEPART_ID
                        dataRow("ItemID") = CInt(rRow("ItemID"))
                        dataRow("ItemName") = mytblItem.ItemName
                        dataRow("Barcode") = mytblItem.Barcode

                        objDataTable.Rows.Add(dataRow)

                    Next

                    '---- Print report ------ VRunEndOfMonthResultDataAdapter
                    Dim runEndofMonthResult As DataTable = objDataTable
                    CrCateItemMonthlyTransRpt.SetDataSource(runEndofMonthResult)

                    CrCateItemMonthlyTransRpt.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    CrCateItemMonthlyTransRpt.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    CrCateItemMonthlyTransRpt.SetParameterValue("category", cbItems.Text)


                    If DEPART_ID = 28 Then
                        CrCateItemMonthlyTransRpt.SetParameterValue("depart", cbDepart.Text)

                    Else
                        CrCateItemMonthlyTransRpt.SetParameterValue("depart", DEPART_NAME)

                    End If

                    CRVItemTransaction.ReportSource = CrCateItemMonthlyTransRpt


                    CRVItemTransaction.Refresh()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally

                End Try
            End If
            If rbDaily.Checked = True Then
                '--- Update 09/12/2011 (Use dataset instead of sql command)
                Dim departTranDataByItemID As New DataTable
                If DEPART_ID = 28 Then
                    departTranDataByItemID = VRunEndofDayResultDataAdapter.GetDepartTranDataByItemID(Val(cbDepart.SelectedValue), cbItems.SelectedValue, DFrom, DTo)
                    Cr.SetDataSource(departTranDataByItemID)
                    Cr.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("category", cbItems.Text)
                    Cr.SetParameterValue("depart", cbDepart.Text)
                Else
                    departTranDataByItemID = VRunEndofDayResultDataAdapter.GetDepartTranDataByItemID(Val(DEPART_ID), cbItems.SelectedValue, DFrom, DTo)
                    Cr.SetDataSource(departTranDataByItemID)
                    Cr.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("category", cbItems.Text)
                    Cr.SetParameterValue("depart", DEPART_NAME)
                End If
                CRVItemTransaction.ReportSource = Cr
                CRVItemTransaction.Refresh()
            End If


        End If



    End Sub

    Private Sub btnPreviewByItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewByItem.Click
        If ValidateCombobox(cbDepart, "", ErrReport) = False Then Exit Sub
        If ValidateCombobox(cbItems, "", ErrReport) = False Then Exit Sub

        ' MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        If BgLoadingReport.IsBusy = True Then
            BgLoadingReport.CancelAsync()
        Else
            ReportOption = 2
            BgLoadingReport.RunWorkerAsync()
        End If

    End Sub

    Sub PreviewByDepart()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewByDepart))
        Else
            MTakeoInventory.StatusLoading(True)
            DFrom = dptFromDate.Value.Date
            DTo = dptToDate.Value.Date
            Dim paramFields As New ParameterFields
            Dim paramField1 As New ParameterField
            Dim paramField2 As New ParameterField
            Dim paramField3 As New ParameterField
            If RadDateToDate.Checked = True Then
                '--- Update 09/12/2011 (Use dataset instead of sql command)
                Dim departTranDataByDepartID As New DataTable
                If DEPART_ID = 28 Then
                    departTranDataByDepartID = VRunEndofDayResultDataAdapter.GetDepartTranDataByDepartID(Val(cbDepart.SelectedValue), DFrom, DTo)

                    Cr1.SetDataSource(departTranDataByDepartID)
                    Cr1.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("category", "") 'cbCate.Text)
                    Cr1.SetParameterValue("depart", cbDepart.Text)
                Else
                    departTranDataByDepartID = VRunEndofDayResultDataAdapter.GetDepartTranDataByDepartID(Val(DEPART_ID), DFrom, DTo)

                    Cr1.SetDataSource(departTranDataByDepartID)
                    Cr1.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr1.SetParameterValue("category", "") 'cbCate.Text)
                    Cr1.SetParameterValue("depart", DEPART_NAME)
                End If
                CRVItemTransaction.ReportSource = Cr1
                CRVItemTransaction.Refresh()
            End If
            If rbDaily.Checked = True Then
                '--- Update 09/12/2011 (Use dataset instead of sql command)
                Dim departTranDataByDepartID As New DataTable
                If DEPART_ID = 28 Then
                    departTranDataByDepartID = VRunEndofDayResultDataAdapter.GetDepartTranDataByDepartID(Val(cbDepart.SelectedValue), DFrom, DTo)
                    Cr.SetDataSource(departTranDataByDepartID)
                    Cr.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("category", "") 'cbCate.Text)
                    Cr.SetParameterValue("depart", cbDepart.Text)
                Else
                    departTranDataByDepartID = VRunEndofDayResultDataAdapter.GetDepartTranDataByDepartID(Val(DEPART_ID), DFrom, DTo)

                    Cr.SetDataSource(departTranDataByDepartID)
                    Cr.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                    Cr.SetParameterValue("category", "") 'cbCate.Text)
                    Cr.SetParameterValue("depart", DEPART_NAME)
                End If


                CRVItemTransaction.ReportSource = Cr
                CRVItemTransaction.Refresh()
            End If
            If rbMontly.Checked = True Then
                Dim myRunEndofMonthResult As New DataTable
                If DEPART_ID = 28 Then
                    myRunEndofMonthResult = VRunEndofMonthDataAdapter.GetDataByDepartID(DFrom, DTo, cbDepart.SelectedValue)
                Else
                    myRunEndofMonthResult = VRunEndofMonthDataAdapter.GetDataByDepartID(DFrom, DTo, DEPART_ID)
                End If


                'Try
                Dim objDataTable As New TakeoHospitalInventory.DSEndofDayRun.tblEndofMonthRunDataTable
                For Each rRow As DataRow In myRunEndofMonthResult.Rows

                    'If rRow("DepartID") = MAIN_STOCK_DEPART_ID Then
                    Dim beginBalanceOfMonth As Integer
                    Dim endBalanceOfMonth As Integer
                    Dim tmpMonthAndYear As String = ""

                    ' Prevent when rRow("smonth") return value "1/2012"
                    If rRow("smonth").ToString.Length = 6 Then
                        tmpMonthAndYear = "0" & rRow("smonth").ToString()
                    Else
                        tmpMonthAndYear = rRow("smonth").ToString()
                    End If

                    Dim sMonthAndYear As String = MonthName(CInt(tmpMonthAndYear.Substring(0, 2)))
                    sMonthAndYear &= " , " & tmpMonthAndYear.Substring(3, 4)

                    Dim q = From runendofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where runendofday.DepartID = CInt(cbDepart.SelectedValue) And runendofday.ItemID = CInt(rRow("ItemID")) And runendofday.RunEndOfDayDate.Value.Date.Month = tmpMonthAndYear.Substring(0, 2) And runendofday.RunEndOfDayDate.Value.Date.Year = tmpMonthAndYear.Substring(3, 4) Order By runendofday.RunEndOfDayDate
                    If q.ToList.Count > 0 Then
                        Dim lstRunEndOfDay As New List(Of tblEndofDayRun)
                        lstRunEndOfDay = q.ToList
                        Try
                            beginBalanceOfMonth = lstRunEndOfDay(0).BeginBalance
                            endBalanceOfMonth = lstRunEndOfDay(lstRunEndOfDay.Count - 1).EndBalance
                        Catch ex As Exception
                            beginBalanceOfMonth = 0
                            endBalanceOfMonth = 0
                        End Try

                    Else
                        beginBalanceOfMonth = 0
                        endBalanceOfMonth = 0
                    End If

                    Dim mytblItem As tblItem = (From item In THIDataContext.getTHIDataContext.tblItems Where item.ItemID = CInt(rRow("ItemID"))).SingleOrDefault

                    Dim dataRow As DataRow = objDataTable.NewRow
                    dataRow("Date") = sMonthAndYear
                    dataRow("RequestQty") = CInt(rRow("RequestQty"))
                    dataRow("ReceivedQty") = CInt(rRow("ReceivedQty"))
                    dataRow("UsedQty") = CInt(rRow("UsedQty"))
                    dataRow("BeginBalance") = beginBalanceOfMonth
                    dataRow("EndBalance") = endBalanceOfMonth
                    dataRow("DepartID") = CInt(DEPART_ID) 'MAIN_STOCK_DEPART_ID
                    dataRow("ItemID") = CInt(rRow("ItemID"))
                    dataRow("ItemName") = mytblItem.ItemName
                    dataRow("Barcode") = mytblItem.Barcode

                    objDataTable.Rows.Add(dataRow)

                    'Else '*** implement for Department (TODO)

                    'End If
                Next

                '---- Print report ------ VRunEndOfMonthResultDataAdapter
                Dim runEndofMonthResult As DataTable = objDataTable
                CrCateItemMonthlyTransRpt.SetDataSource(runEndofMonthResult)
                CrCateItemMonthlyTransRpt.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                CrCateItemMonthlyTransRpt.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                CrCateItemMonthlyTransRpt.SetParameterValue("category", "") 'cbCate.Text)

                If DEPART_ID = 28 Then
                    CrCateItemMonthlyTransRpt.SetParameterValue("depart", cbDepart.Text)

                Else
                    CrCateItemMonthlyTransRpt.SetParameterValue("depart", DEPART_NAME)

                End If
                CRVItemTransaction.ReportSource = CrCateItemMonthlyTransRpt


                CRVItemTransaction.Refresh()

                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'Finally

                'End Try
            End If
            '    If IsDailyReport = True Then



            '    Else 'In case user select Monthly
            '        

            '    End If
        End If

    End Sub

    Private Sub btnPreviewByDepart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewByDepart.Click
        If ValidateCombobox(cbDepart, "", ErrReport) = False Then Exit Sub

        Application.DoEvents()
        If BgLoadingReport.IsBusy = True Then
            BgLoadingReport.CancelAsync()
        Else
            ReportOption = 3
            BgLoadingReport.RunWorkerAsync()
        End If

    End Sub

    Private Sub rbDaily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDaily.CheckedChanged
        If rbDaily.Checked = True Then
            IsDailyReport = True
        Else
            IsDailyReport = False
        End If
    End Sub

    Private Sub rbMontly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMontly.CheckedChanged
        If rbMontly.Checked = True Then
            IsMonthlyReport = True
        Else
            IsMonthlyReport = False
        End If
    End Sub

    Sub PreviewStockAdjustment()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewStockAdjustment))
        Else
            Try
                MTakeoInventory.StatusLoading(True)
                DFrom = dptFromDate.Value.Date
                DTo = dptToDate.Value.Date
                Dim stockAdjustmentDT As DataTable = VDataStockAdjustmentDataAdapter.GetDataAdjustStockInPeriodTime(CInt(cbDepart.SelectedValue), DFrom, DTo)
                CrStockAdjustmentRpt.SetDataSource(stockAdjustmentDT)
                CrStockAdjustmentRpt.SetParameterValue("fromDate", Format(DFrom, "dd/MMM/yyyy"))
                CrStockAdjustmentRpt.SetParameterValue("toDate", Format(DTo, "dd/MMM/yyyy"))
                CrStockAdjustmentRpt.SetParameterValue("departName", cbDepart.Text)

                CRVItemTransaction.ReportSource = CrStockAdjustmentRpt
                CRVItemTransaction.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnStockAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockAdjustment.Click

        ' MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        If BgLoadingReport.IsBusy = True Then
            BgLoadingReport.CancelAsync()
        Else
            ReportOption = 4
            BgLoadingReport.RunWorkerAsync()
        End If

    End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork

        Select Case ReportOption
            Case 1
                PreviewByCate()
            Case 2
                PreviewByItem()
            Case 3
                PreviewByDepart()
            Case 4
                PreviewStockAdjustment()
        End Select

    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub RadCate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCate.CheckedChanged
        EnableReportCate(RadCate.Checked)
        EnableReportItem(RadItem.Checked)
    End Sub
    Private Sub EnableReportItem(ByVal values As Boolean)
        cbItems.Enabled = values
        btnPreviewByItem.Enabled = values
    End Sub
    Private Sub EnableReportCate(ByVal values As Boolean)

        cbCate.Enabled = values
        btnPreviewByCate.Enabled = values
    End Sub
    Private Sub RadItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadItem.CheckedChanged
        EnableReportCate(RadCate.Checked)
        EnableReportItem(RadItem.Checked)
    End Sub

   
End Class
