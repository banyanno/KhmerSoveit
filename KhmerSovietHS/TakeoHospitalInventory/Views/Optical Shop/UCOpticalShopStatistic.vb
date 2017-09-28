Public Class UCOpticalShopStatistic

    Private CrOpticalShopCusAge As New CROpticalShopCusAgeStatistic
    Private CrOpticalShopItemSaleOff As New CROpticalShopItemSaleOff
    Private CrOpticalShopPatAgeIncome As New CROpticalShopPatientAgeIncomeStatistic
    Private CrOpticalShopPayTypeAge As New CROpticalShopPaymentTypeByAgeStatistic

    Dim DAOPCusAge As New DSOpticalShopTableAdapters.V_OpticalShopCusStatisticTableAdapter
    Dim DAOPItemSaleOff As New DSOpticalShopTableAdapters.V_OpticalShopItemSaleOffTableAdapter
    Dim DAOPPatAgeIncome As New DSOpticalShopTableAdapters.V_OpticalShopPatientStatisticByIcomeTypeTableAdapter
    Dim DAOPPayTypeAge As New DSOpticalShopTableAdapters.V_OpticalShopPaymentTypeByAgeStatisticTableAdapter

    Dim MTakeoInventory As MainTakeoInventory

    Public Sub New(ByVal MTakeo As MainTakeoInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeo
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnOPCusAgeStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOPCusAgeStatistic.Click
        If ValidateDateTimePicker(DTPFDate, "", ErrPReportOPT) = False Then Exit Sub
        If ValidateDateTimePicker(DTPToDate, "", ErrPReportOPT) = False Then Exit Sub
        SplitOpticalShopReport.Panel1Collapsed = True
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        BacWOPCusAgeSta.RunWorkerAsync()
    End Sub
    '--- Optical Shop Customer's Age Statistic
    Sub ViewReportOPCusAgeStatistic()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewReportOPCusAgeStatistic))
        Else
            Dim OPCusAgeDT As DataTable = DAOPCusAge.GetDataFDateTDate(DTPFDate.Value.Date, DTPToDate.Value.Date)
            CrOpticalShopCusAge.SetDataSource(OPCusAgeDT)
            CrOpticalShopCusAge.SetParameterValue("FDate", Format(DTPFDate.Value.Date, "dd/MMM/yyyy"))
            CrOpticalShopCusAge.SetParameterValue("TDate", Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))
            CRVReportViewer.ReportSource = CrOpticalShopCusAge
            CRVReportViewer.Refresh()
        End If
    End Sub
    '--- Optical Shop Item Sale Off
    Sub ViewReportOPItemSaleOff()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewReportOPItemSaleOff))
        Else
            Dim OPItemSaleOffDT As DataTable = DAOPItemSaleOff.GetDataOPItemSaleOff(DTPFDate.Value.Date, DTPToDate.Value.Date)
            CrOpticalShopItemSaleOff.SetDataSource(OPItemSaleOffDT)
            CrOpticalShopItemSaleOff.SetParameterValue("FDate", Format(DTPFDate.Value.Date, "dd/MMM/yyyy"))
            CrOpticalShopItemSaleOff.SetParameterValue("TDate", Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))
            CRVReportViewer.ReportSource = CrOpticalShopItemSaleOff
            CRVReportViewer.Refresh()
        End If
    End Sub

    
    Private Sub BacWOPCusAgeSta_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BacWOPCusAgeSta.DoWork
        Me.ViewReportOPCusAgeStatistic()
    End Sub

    Private Sub BacWOPCusAgeSta_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BacWOPCusAgeSta.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub BtnOPItemSaleOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOPItemSaleOff.Click
        If ValidateDateTimePicker(DTPFDate, "", ErrPReportOPT) = False Then Exit Sub
        If ValidateDateTimePicker(DTPToDate, "", ErrPReportOPT) = False Then Exit Sub
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        SplitOpticalShopReport.Panel1Collapsed = True
        BacWOPItemSaleOff.RunWorkerAsync()
    End Sub

    Private Sub BacWOPItemSaleOff_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BacWOPItemSaleOff.DoWork
       
        Me.ViewReportOPItemSaleOff()

    End Sub

    Private Sub BacWOPItemSaleOff_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BacWOPItemSaleOff.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub BtnOSPatientAgeIncome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOSPatientAgeIncome.Click
        If ValidateDateTimePicker(DTPFDate, "", ErrPReportOPT) = False Then Exit Sub
        If ValidateDateTimePicker(DTPToDate, "", ErrPReportOPT) = False Then Exit Sub
        MTakeoInventory.StatusLoading(True)
        SplitOpticalShopReport.Panel1Collapsed = True
        Application.DoEvents()
        BacWOPPatientAgeIncome.RunWorkerAsync()
    End Sub

    Private Sub BacWOPPatientAgeIncome_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BacWOPPatientAgeIncome.DoWork
        Me.ViewReportPatientAgeIncomStatis()
    End Sub

    Private Sub BacWOPPatientAgeIncome_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BacWOPPatientAgeIncome.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub
    '--- Optical Shop Patient Age Income Statistic
    Sub ViewReportPatientAgeIncomStatis()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewReportPatientAgeIncomStatis))
        Else
            Dim OPPatAgeIncome As DataTable = DAOPPatAgeIncome.GetDataFDateTDate(DTPFDate.Value.Date, DTPToDate.Value.Date, CheOldPatient.Checked)
            CrOpticalShopPatAgeIncome.SetDataSource(OPPatAgeIncome)
            CrOpticalShopPatAgeIncome.SetParameterValue("FDate", Format(DTPFDate.Value.Date, "dd/MMM/yyyy"))
            CrOpticalShopPatAgeIncome.SetParameterValue("TDate", Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))

            If CheOldPatient.Checked = True Then
                CrOpticalShopPatAgeIncome.SetParameterValue("PatientStatus", "Old Patient")
            Else
                CrOpticalShopPatAgeIncome.SetParameterValue("PatientStatus", "New Patient")
            End If
            CRVReportViewer.ReportSource = CrOpticalShopPatAgeIncome
            CRVReportViewer.Refresh()
        End If

    End Sub

    
    '--- Optical Shop Payment Type By Age Statistic
    Sub ViewReportPaymentTypeByAgeStatis()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewReportPaymentTypeByAgeStatis))
        Else
            Dim OPPayTypeAge As DataTable
            If RadAllPaymentType.Checked = True Then
                OPPayTypeAge = DAOPPayTypeAge.GetDataByAllPaymentType(DTPFDate.Value.Date, DTPToDate.Value.Date)
                CrOpticalShopPayTypeAge.SetDataSource(OPPayTypeAge)
                CrOpticalShopPayTypeAge.SetParameterValue("ParameterTitle", "Report of All with Payment Type from " & Format(DTPFDate.Value.Date, "dd/MMM/yyyy") & " To " & Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))
            Else
                OPPayTypeAge = DAOPPayTypeAge.GetDataFDateTDate(DTPFDate.Value.Date, DTPToDate.Value.Date, GetReceiptType())
                CrOpticalShopPayTypeAge.SetDataSource(OPPayTypeAge)
                CrOpticalShopPayTypeAge.SetParameterValue("ParameterTitle", "Report of " & GetReceiptType().ToUpper & " with Payment Type from " & Format(DTPFDate.Value.Date, "dd/MMM/yyyy") & " To " & Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))
            End If

            CrOpticalShopPayTypeAge.SetParameterValue("FDate", Format(DTPFDate.Value.Date, "dd/MMM/yyyy"))
            CrOpticalShopPayTypeAge.SetParameterValue("TDate", Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))
            CVStaticPaymentFor.ReportSource = CrOpticalShopPayTypeAge
            CVStaticPaymentFor.Refresh()
        End If

    End Sub

    Private Sub BacWOPPayTypeAgeSta_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BacWOPPayTypeAgeSta.DoWork
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        Me.ViewReportPaymentTypeByAgeStatis()
    End Sub

    Private Sub BacWOPPayTypeAgeSta_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BacWOPPayTypeAgeSta.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub BtnNillAndFull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNillAndFull.Click
        SplitOpticalShopReport.Panel1Collapsed = False
        SplitOpticalShopReport.Panel2Collapsed = True
    End Sub

    Private Sub BtnPrintPreviewPayfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreviewPayfor.Click
        If ValidateDateTimePicker(DTPFDate, "", ErrPReportOPT) = False Then Exit Sub
        If ValidateDateTimePicker(DTPToDate, "", ErrPReportOPT) = False Then Exit Sub
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        BacWOPPayTypeAgeSta.RunWorkerAsync()
    End Sub
    Function GetReceiptType() As String
        If RadCustomerMadeSpectacle.Checked = True Then
            Return "Customer Made Spectacle"
        ElseIf RadReadyMadeSpectacle.Checked = True Then
            Return "Ready Made Spectacle"
        ElseIf RadFundRaising.Checked = True Then
            Return "Fund Raising"
        ElseIf RadSunGlasses.Checked = True Then
            Return "Sun Glasses"
        ElseIf RadMedicine.Checked = True Then
            Return "Medicine"
        ElseIf RadOther.Checked = True Then
            Return "Other"
        ElseIf RadLV.Checked = True Then
            Return "LV Device"
        End If
    End Function
End Class
