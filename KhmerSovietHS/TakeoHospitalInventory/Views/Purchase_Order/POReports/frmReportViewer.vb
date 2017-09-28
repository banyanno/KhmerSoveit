Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmReportViewer
    Public RequestOrderID As Integer
    Public paraDepRequest As String
    Private CrRequestOrderRpt As New CrRequestOrder
    Private CrInhouseUsedItemRpt As New CrInhouseUsedItem
    Private CrItemInStockReportRpt As New CrItemInStockReport
    Private CrItemInDepartmentStockRpt As New CrItemInStockReport
    Private CrHisRequestRpt As New CrHisRequest
    Private CaritasRequestOrderRpt As New RptCaritasReqOrder
    Public CaritasRequestID As Integer
    Private MedicineOutsideHospitalRpt As New RptMedicineOutsideHos
    Private DepartEndofDayRpt As New CrDepartEndofDay
    Dim REODGroupByItem As New ReportDepartEODDedielt
    Private ItemAlertRpt As New CrItemAlert
    Private CrItemReq_Sup_Rec_Trace As New RptItemRequestSupplierGivenTrace
    Private CrIteReq_Used_In_Hos As New RptItemRequestSupplierUsedInDepart
    Private ObjReceiptCry_V1 As New CryReceipt_V1
    Private CrAccountPayable As New CryAccountPayable
    Private CrItemHospitalProject As New RptItemHospitalProject
    Dim CrItemHospitalProjectV1 As New RptItemHospitalProjectV1
    Private ReceivedItem As New Received_Order

    Private PARAMETKHMER As String = ""
    Private PARAMETENG As String = ""
    Public ReceiptNo As String = ""
    Public ReceiptID As String = "0"
    Public PrintReceiptAgain As Boolean = False

    Dim DaReceiptPrint As New DSOpticalShopTableAdapters.V_Receipt_InvoiceTableAdapter
    Dim VReportRequestOrder As PurchaseOrderTableAdapters.VReportRequestOrderTableAdapter
    Dim VReportInhouseUsedItemDataAdapter As DSInhouseUsedItemTableAdapters.VUsedWithUsedDetailTableAdapter
    Dim VItemListDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim VItemListInDepartmentDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim VRptRequestHisStatusTraceDataAdapter As DSRptRequestHistoryStatusTraceTableAdapters.VRptRequestHistoryStatuTraceTableAdapter
    Dim VCARITAS_REQDataAdapter As DSHospitalRequestToCaritasTableAdapters.V_CARITAS_REQTableAdapter
    Dim VMedicineOutsideHosDataAdapter As DSPharmacyTableAdapters.V_ITEM_OUTSIDE_INVENTableAdapter
    Dim DepartRepo As IDepartRepository = New DepartRepository
    Dim EndofDayRunDataAdapter As DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
    Dim ItemReqSupRecTrace As DSHospitalRequestToCaritasTableAdapters.V_ITEM_PROVIDER_GIVEN_TRACETableAdapter
    Dim ItemReqUsedInHospital As DSHospitalRequestToCaritasTableAdapters.V_ITEM_DEPART_PROVIDER_USED_TRACETableAdapter
    Dim DaReceipt As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim DAAccountPayable As New DSAccountPayableTableAdapters.V_ACCOUNT_PAYABLE_DETAILTableAdapter
    Dim DAItemHospitalProject As New DSHospitalRequestToCaritasTableAdapters.V_HospitalItemRequestProjectTableAdapter
    Dim DA_RequestHospital As New DSHospitalRequestToCaritasTableAdapters.VREQUEST_CARITASTableAdapter


    Public ReportOption As Integer
    Public FDate As Date
    Public TDate As Date
    Public CateID As Integer
    Public DepartID As Integer
    Public STATUS As Boolean = False

    ' global variables for print hitory request order
    Public POStatus As Integer
    Public StrOPStatus As String
    Public IsIncomingReq As Boolean

    'Report For old and new 

    Public IS_DIAGNOSIS As Boolean
    Public DIAGNOSIS As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        VReportRequestOrder = New PurchaseOrderTableAdapters.VReportRequestOrderTableAdapter
        VReportInhouseUsedItemDataAdapter = New DSInhouseUsedItemTableAdapters.VUsedWithUsedDetailTableAdapter
        VItemListDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VItemListInDepartmentDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        VRptRequestHisStatusTraceDataAdapter = New DSRptRequestHistoryStatusTraceTableAdapters.VRptRequestHistoryStatuTraceTableAdapter
        VCARITAS_REQDataAdapter = New DSHospitalRequestToCaritasTableAdapters.V_CARITAS_REQTableAdapter
        VMedicineOutsideHosDataAdapter = New DSPharmacyTableAdapters.V_ITEM_OUTSIDE_INVENTableAdapter
        EndofDayRunDataAdapter = New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
        ItemReqSupRecTrace = New DSHospitalRequestToCaritasTableAdapters.V_ITEM_PROVIDER_GIVEN_TRACETableAdapter
        ItemReqUsedInHospital = New DSHospitalRequestToCaritasTableAdapters.V_ITEM_DEPART_PROVIDER_USED_TRACETableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmRPTRequestView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmRPTRequestView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ContainerLoading.Visible = True
        Application.DoEvents()
        BgLoadingReport.RunWorkerAsync()
    End Sub

    Sub GenerateDataToReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf GenerateDataToReport))
        Else
            Select Case ReportOption
                Case 1
                    PrintRequestOrder(paraDepRequest)
                Case 2
                    PrintInhouseUseItem()
                Case 3
                    PrintAllItemInMainInventory()
                Case 4
                    PrintAllItemInMainInventoryByCateID()
                Case 5
                    PrintAllItemInDepartment()
                Case 6
                    PrintHisRequestInDepartment()
                Case 7
                    PrintCaritasRequestOrder()
                Case 8
                    PrintMedicineOutsideHospital()
                Case 9
                    PrintDepartEndofDay()
                Case 10
                    PrintItemAlertStock()
                Case 11
                    PrintItemExpiredAlertStock()
                Case 12
                    PrintItemSupRecTrace()
                Case 13
                    PrintItemReqUsedInHospital()
                Case 14
                    If PrintReceiptAgain = True Then
                        PrintReceiptByID(ReceiptID)
                    Else
                        PrintReceipt(ReceiptNo)
                    End If
                Case 15
                    PrintAccountPayable()
                Case 16
                    PrintDepartEODByDayGroupByItem()
                Case 17
                    PrintItemHospitalProject()
                Case 18
                    PrintPatientNotFillDiagnosisVA()
                Case 19
                    PintPatientDiagnosisOldNew()
            End Select
        End If
    End Sub
    Sub BindReportViewerAfterBGComplete()

    End Sub

    Public Sub PrintItemHospitalProject()
        Dim ItemHospitalProjectDT As DataTable = DA_RequestHospital.SelectRequestDateToDate(FDate, TDate)
        CrItemHospitalProjectV1.SetDataSource(ItemHospitalProjectDT)
        'CrItemHospitalProject.SetParameterValue("fromDate", Format(FDate, "dd/MMM/yyyy"))
        'CrItemHospitalProject.SetParameterValue("toDate", Format(TDate, "dd/MMM/yyyy"))
        CRVReportViewer.ReportSource = CrItemHospitalProjectV1
        'CRVReportViewer.Refresh()
        CrItemHospitalProjectV1.SetParameterValue("Title", "Date From:" & Format(FDate, "dd/MMM/yyyy") & " To:" & Format(TDate, "dd/MMM/yyyy"))
    End Sub
    Dim DA_PatientFillDiagnosis As New DSOutPatientReportTableAdapters.V_NewOutpatientDetailTableAdapter
    Dim CRport As New ReportPatientNoDiagnosis
    Public Sub PintPatientDiagnosisOldNew()
        Dim tblPatientDg As DataTable
        If IS_DIAGNOSIS = True Then
            tblPatientDg = DA_PatientFillDiagnosis.SelectWithDiagnosis(FDate, TDate, DIAGNOSIS, STATUS)
        Else
            tblPatientDg = DA_PatientFillDiagnosis.SelectAllDiagnosis(FDate, TDate, STATUS)
        End If
        CRport.SetDataSource(tblPatientDg)
        CRVReportViewer.ReportSource = CRport
    End Sub
    Public Sub PrintPatientNotFillDiagnosisVA()
        Dim tblPatientDg As DataTable = DA_PatientFillDiagnosis.SelectPatientNotFillDiagnosis(FDate, TDate, STATUS)


        CRport.SetDataSource(tblPatientDg)
        CRVReportViewer.ReportSource = CRport

    End Sub

    Public Sub PrintItemExpiredAlertStock()

        Dim ItemAlertStockDT As DataTable = VItemListDataAdapter.GetItemExpiredAlert
        ItemAlertRpt.SetDataSource(ItemAlertStockDT)
        ItemAlertRpt.SetParameterValue("pTitle", "Item Alert Expired In Stock")
        CRVReportViewer.ReportSource = ItemAlertRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintItemAlertStock()

        Dim ItemAlertStockDT As DataTable = VItemListDataAdapter.GetItemAlertStock()

        ItemAlertRpt.SetDataSource(ItemAlertStockDT)        
        ItemAlertRpt.SetParameterValue("pTitle", "Item Alert Quantity In Stock")

        CRVReportViewer.ReportSource = ItemAlertRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintDepartEndofDay()

        Dim DepartEndofDayDT As DataTable = EndofDayRunDataAdapter.GetAllItemEndofDaySearch(DepartID, FDate, TDate)

        DepartEndofDayRpt.SetDataSource(DepartEndofDayDT)
        DepartEndofDayRpt.SetParameterValue("fromDate", Format(FDate, "dd/MMM/yyyy"))
        DepartEndofDayRpt.SetParameterValue("toDate", Format(TDate, "dd/MMM/yyyy"))

        CRVReportViewer.ReportSource = DepartEndofDayRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintDepartEODByDayGroupByItem()
        Dim DepartEndofDayDT As DataTable = EndofDayRunDataAdapter.GetAllItemEndofDaySearch(DepartID, FDate, TDate)

        REODGroupByItem.SetDataSource(DepartEndofDayDT)
        REODGroupByItem.SetParameterValue("fromDate", Format(FDate, "dd/MMM/yyyy"))
        REODGroupByItem.SetParameterValue("toDate", Format(TDate, "dd/MMM/yyyy"))
        CRVReportViewer.ReportSource = REODGroupByItem
        CRVReportViewer.Refresh()
    End Sub

    Public Sub PrintMedicineOutsideHospital()

        Dim MedicineOutsideHosDT As DataTable = VMedicineOutsideHosDataAdapter.GetItemOutsideInPeriod(FDate, TDate)
        MedicineOutsideHospitalRpt.SetDataSource(MedicineOutsideHosDT)
        MedicineOutsideHospitalRpt.SetParameterValue("FDate", Format(FDate, "dd/MMM/yyyy"))
        MedicineOutsideHospitalRpt.SetParameterValue("TDate", Format(TDate, "dd/MMM/yyyy"))

        CRVReportViewer.ReportSource = MedicineOutsideHospitalRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintCaritasRequestOrder()

        Dim CaritasReqDT As DataTable = VCARITAS_REQDataAdapter.SelectRequestID(CaritasRequestID)
        CaritasRequestOrderRpt.SetDataSource(CaritasReqDT)

        CRVReportViewer.ReportSource = CaritasRequestOrderRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintRequestOrder(ByVal ParRequestName As String)

        Dim requestOrder As DataTable = VReportRequestOrder.GetDataRequestByRequestID(RequestOrderID)
        CrRequestOrderRpt.SetDataSource(requestOrder)
        CrRequestOrderRpt.SetParameterValue("pRequestFromDepart", DEPART_NAME)
        CRVReportViewer.ReportSource = CrRequestOrderRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintInhouseUseItem()

        Dim inHouseUsedItemDT As DataTable = VReportInhouseUsedItemDataAdapter.GetUsedDataInPeriodOfTime(CInt(DEPART_ID), FDate, TDate)

        CrInhouseUsedItemRpt.SetDataSource(inHouseUsedItemDT)
        CrInhouseUsedItemRpt.SetParameterValue("fromDate", Format(FDate, "dd/MMM/yyyy"))
        CrInhouseUsedItemRpt.SetParameterValue("toDate", Format(TDate, "dd/MMM/yyyy"))

        CRVReportViewer.ReportSource = CrInhouseUsedItemRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintAllItemInMainInventory()

        Dim itemInMainInventoryDT As DataTable = VItemListDataAdapter.GetData

        CrItemInStockReportRpt.SetDataSource(itemInMainInventoryDT)
        CrItemInStockReportRpt.SetParameterValue("departName", DEPART_NAME)

        CRVReportViewer.ReportSource = CrItemInStockReportRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintAllItemInMainInventoryByCateID()

        Dim itemInMainInventoryDT As DataTable = VItemListDataAdapter.GetItemDataByCateID(CateID)

        CrItemInStockReportRpt.SetDataSource(itemInMainInventoryDT)
        CrItemInStockReportRpt.SetParameterValue("departName", DEPART_NAME)

        CRVReportViewer.ReportSource = CrItemInStockReportRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintItemSupRecTrace()

        Dim TblReceivedTem As DataTable = VCARITAS_REQDataAdapter.SelectDateToDate(FDate, TDate)
        ReceivedItem.SetDataSource(TblReceivedTem)
        ReceivedItem.SetParameterValue("Title", "Date from: " & Format(FDate, "dd/MM/yyyy") & " To " & Format(TDate, "dd/MM/yyyy"))
        CRVReportViewer.ReportSource = ReceivedItem
        CRVReportViewer.Refresh()
        'Dim ItemReq_Sup_Rec_TraceDT As DataTable = ItemReqSupRecTrace.GetReqItemRecTrace(CaritasRequestID, FDate, TDate)
        'CrItemReq_Sup_Rec_Trace.SetDataSource(ItemReq_Sup_Rec_TraceDT)
        ''--- Set Parameters of report
        'CrItemReq_Sup_Rec_Trace.SetParameterValue("FDate", Format(FDate, "dd/MMM/yyyy"))
        'CrItemReq_Sup_Rec_Trace.SetParameterValue("TDate", Format(TDate, "dd/MMM/yyyy"))
        'CRVReportViewer.ReportSource = CrItemReq_Sup_Rec_Trace
        'CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintItemReqUsedInHospital()

        Dim ItemReq_Sup_Rec_TraceDT As DataTable = ItemReqUsedInHospital.GetItemReqUsedInHospital(CaritasRequestID, FDate, TDate)
        CrIteReq_Used_In_Hos.SetDataSource(ItemReq_Sup_Rec_TraceDT)
        '--- Set Parameters of report
        CrIteReq_Used_In_Hos.SetParameterValue("FDate", Format(FDate, "dd/MMM/yyyy"))
        CrIteReq_Used_In_Hos.SetParameterValue("TDate", Format(TDate, "dd/MMM/yyyy"))
        CRVReportViewer.ReportSource = CrIteReq_Used_In_Hos
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintAllItemInDepartment()

        Dim itemInDepartDT As DataTable = VItemListInDepartmentDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
        CrItemInDepartmentStockRpt.SetDataSource(itemInDepartDT)
        CrItemInDepartmentStockRpt.SetParameterValue("departName", DEPART_NAME)

        CRVReportViewer.ReportSource = CrItemInDepartmentStockRpt
        CRVReportViewer.Refresh()

    End Sub

    Public Sub PrintHisRequestInDepartment()

        If IsIncomingReq = False Then
            Dim requestHisStatusTrace As DataTable = VRptRequestHisStatusTraceDataAdapter.GetHisRequestBYStatus(CInt(DEPART_ID), POStatus, FDate, TDate)

            CrHisRequestRpt.SetDataSource(requestHisStatusTrace)

            '--- Set Parameters of report
            CrHisRequestRpt.SetParameterValue("FromDate", Format(FDate, "dd/MMM/yyyy"))
            CrHisRequestRpt.SetParameterValue("ToDate", Format(TDate, "dd/MMM/yyyy"))
            CrHisRequestRpt.SetParameterValue("DepartName", DEPART_NAME)
            CrHisRequestRpt.SetParameterValue("Status", StrOPStatus)

            CRVReportViewer.ReportSource = CrHisRequestRpt
            CRVReportViewer.Refresh()

        Else

            Dim requestHisStatusTrace As DataTable = VRptRequestHisStatusTraceDataAdapter.GetHisIncomingReqByStatus(CInt(DEPART_ID), POStatus, FDate, TDate)
            Dim DepartReqID As Integer = 0
            Dim DepartName As String = ""

            For Each row As DataRow In requestHisStatusTrace.Rows
                DepartReqID = row("RequestFromDepartID")
                Exit For
            Next

            If DepartReqID <> 0 Then
                DepartName = DepartRepo.GetDepartNameByID(DepartReqID)
            Else
                DepartName = ""
            End If

            CrHisRequestRpt.SetDataSource(requestHisStatusTrace)
            '--- Set Parameters of report
            CrHisRequestRpt.SetParameterValue("FromDate", Format(FDate, "dd/MMM/yyyy"))
            CrHisRequestRpt.SetParameterValue("ToDate", Format(TDate, "dd/MMM/yyyy"))
            CrHisRequestRpt.SetParameterValue("DepartName", DepartName)
            CrHisRequestRpt.SetParameterValue("Status", StrOPStatus)
            CRVReportViewer.ReportSource = CrHisRequestRpt
            CRVReportViewer.Refresh()
        End If
    End Sub

    Public Sub PrintAccountPayable()

        Dim accountPayable As DataTable = DAAccountPayable.GetDataByDate(FDate, TDate)

        CrAccountPayable.SetDataSource(accountPayable)
        CrAccountPayable.SetParameterValue("FromDate", Format(FDate, "dd/MMM/yyyy"))
        CrAccountPayable.SetParameterValue("ToDate", Format(TDate, "dd/MMM/yyyy"))

        CRVReportViewer.ReportSource = CrAccountPayable
        CRVReportViewer.Refresh()

    End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        GenerateDataToReport()
    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        Application.DoEvents()
        Me.ContainerLoading.Visible = False
    End Sub
    Sub PrintReceipt(ByVal pReceipNo As String)

        CreateParameterCrystal()
        ObjReceiptCry_V1.SetDataSource(CType(DaReceiptPrint.GetDataByReceiptNo(pReceipNo), DataTable))
        ObjReceiptCry_V1.SetParameterValue("InPaymentForKhmer", PARAMETKHMER)
        ObjReceiptCry_V1.SetParameterValue("ParameterEng", PARAMETENG)

        CRVReportViewer.ReportSource = ObjReceiptCry_V1
        CRVReportViewer.Refresh()

        ObjReceiptCry_V1.Dispose()
        ObjReceiptCry_V1.Close()

    End Sub
    Sub PrintReceiptByID(ByVal ReceiptID As Double)
        CreateParameterCrystal()
        ObjReceiptCry_V1.SetDataSource(CType(DaReceiptPrint.GetDataByReceiptID(ReceiptID), DataTable))
        ObjReceiptCry_V1.SetParameterValue("InPaymentForKhmer", PARAMETKHMER)
        ObjReceiptCry_V1.SetParameterValue("ParameterEng", PARAMETENG)

        CRVReportViewer.ReportSource = ObjReceiptCry_V1
        CRVReportViewer.Refresh()

        ObjReceiptCry_V1.Dispose()
        ObjReceiptCry_V1.Close()
    End Sub

    Sub CreateParameterCrystal()
        Dim DTblReceipt As DataTable = DaReceipt.GetDataByReceiptNo(ReceiptNo)
        For Each row As DataRow In DTblReceipt.Rows
            If TypeOf row("IncomType") Is DBNull = False Then
                If row("IncomType") = "1" Then
                    'RadMedicine.Checked = True
                    PARAMETKHMER = "fñaMeBTüepSg²"
                    PARAMETENG = "(Special medicine)"
                ElseIf row("IncomType") = "2" Then
                    'RadSunGlasses.Checked = True
                    PARAMETKHMER = "Ev:nta"
                    PARAMETENG = "(Eye Glasses)"
                ElseIf row("IncomType") = "4" Then
                    'RadSpectacle.Checked = True
                    PARAMETKHMER = "Ev:nta"
                    PARAMETENG = "(Eye Glasses)"
                ElseIf row("IncomType") = "3" Then
                    'RadReadMod.Checked = True
                    PARAMETKHMER = "Ev:nta"
                    PARAMETENG = "(Eye Glasses)"
                ElseIf row("IncomType") = "5" Then
                    'RadFundRaising.Checked = True
                    PARAMETKHMER = ""
                    PARAMETENG = "Fund Raising"
                Else
                    'RadOther.Checked = True
                    PARAMETKHMER = ""
                    PARAMETENG = "Other"
                End If
            End If
        Next
    End Sub

End Class