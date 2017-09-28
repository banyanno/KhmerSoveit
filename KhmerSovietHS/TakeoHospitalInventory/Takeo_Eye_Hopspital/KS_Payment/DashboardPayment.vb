Imports CrystalDecisions.Shared

Public Class DashboardPayment
    Dim DA_Waiting_View As New DSWaitingConsultTableAdapters.S_WAITING_VIEWTableAdapter
    Dim DAPatient As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    Dim Da_WaitPay As New DS_KSPAYMENTTableAdapters.S_TEM_LISTPAYMENTTableAdapter
    Dim DA_AddService As New DS_KSPAYMENTTableAdapters.S_TEM_LISTPAYMENTTableAdapter
    Dim DA_Rate As New DS_KSPAYMENTTableAdapters.S_EXCHANGE_RATETableAdapter
    Dim DA_Medicine As New DS_KSPAYMENTTableAdapters.S_TEM_LISTMEDICINE_PAYMENTTableAdapter
    Dim DA_MedicinePay As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter
    Dim DA_Consult As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Dim DA_Waiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Dim Prescription As New DS_KSPAYMENTTableAdapters.V_EYE_PRESCRIPTIONTableAdapter
    Dim DA_FollowUp As New DSWaitingConsultTableAdapters.S_PATIENT_FOLLOWUPTableAdapter


    Dim DA_Item As New DSAddQTYTableAdapters.tblItemTableAdapter
    Dim DA_QTY As New DSAddQTYTableAdapters.tblCentralInventoryTableAdapter

    Private Sub DashboardPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewWaitingPay(3, Now.Date)
    End Sub
    Private Sub ViewWaitingPay(ByVal status As Integer, ByVal WDate As Date)
        GridPatientWaiting.DataSource = DA_Waiting_View.SelectWaitingPaymentByDay(status, WDate)
    End Sub
    Private Sub ViewPatientConsult(ByVal status As Double)
        GridPatientWaiting.DataSource = DA_Waiting_View.SelectWaitingConsult(status)
    End Sub
    Sub ViewTotalPayDetail()
        If GridPatientWaiting.SelectedItems.Count = 0 Then
            Me.TxtTotalConsultFee.Text = "0"
            Me.TxtMedicineFee.Text = "0"
            Me.TxtTotalAferDiscount.Text = "0"
            Me.TxtReil.Text = "0"
        Else
            Dim TotalServiceFee As Double = 0
            Dim TotalMedicineFee As Double = 0
            Dim TotalMedicineDel As Double = 0
            For i As Integer = 0 To GridConsultFee.RowCount - 2
                TotalServiceFee = TotalServiceFee + CDbl(GridConsultFee.GetRow(i).Cells("PRICE_PAY").Value)
            Next
            For i As Integer = 0 To GridPrescription.RowCount - 2
                'Try
                '    If GridPrescription.GetRow(i).Cells("IS_DELETE").Value = True Then
                '        TotalMedicineDel = CDbl(GridPrescription.GetRow(i).Cells("TOTAL_PRICE").Value)
                '    End If
                'Catch ex As Exception

                'End Try

                TotalMedicineFee = TotalMedicineFee + CDbl(IIf(GridPrescription.GetRow(i).Cells("IS_DELETE").Value = True, 0, CDbl(GridPrescription.GetRow(i).Cells("TOTAL_PRICE").Value)))
            Next
            Me.TxtTotalConsultFee.Text = TotalServiceFee
            Me.TxtMedicineFee.Text = TotalMedicineFee
            Me.TxtTotalAferDiscount.Text = TotalServiceFee + TotalMedicineFee
            Me.TxtReil.Text = FormatNumber(CDbl(EmptyString(TxtTotalAferDiscount.Text)) * CDbl(EmptyString(DA_Rate.SelectValueExchage)))
        End If

        

    End Sub
    Private Sub GridPatientWaiting_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientWaiting.SelectionChanged
        Try
            If GridPatientWaiting.SelectedItems.Count = 0 Then
                GridConsultFee.DataSource = Nothing
                GridPrescription.DataSource = Nothing
                PictureBox1.Image = Nothing
                Exit Sub
            Else
                ViewPatientWaitingPay(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
                ViewPatientMedicine(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
                PictureBox1.Image = ByteArrayToImage(DAPatient.SelectPicture(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value))
            End If
            ViewTotalPayDetail()
        Catch ex As Exception
            ' MessageBox.Show("Please select on patient payment", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub
    Public Sub ViewPatientWaitingPay(ByVal WaitingID As Double)
        GridConsultFee.DataSource = Da_WaitPay.SelectWaitingPayNo(WaitingID)
    End Sub
    Public Sub ViewPatientMedicine(ByVal WaitingID As Double)
        GridPrescription.DataSource = DA_MedicinePay.SelectMedicinePay(WaitingID) 'DA_Medicine.SelectMedicineByWaitingNo(WaitingID)
    End Sub
    Private Sub BtnIssureInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIssureInvoice.Click
        NewIssueInvoice()
    End Sub

    Private Sub BtnAddHosFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddHosFee.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        Dim newFee As New AddMoreConsutFee(Me)
        newFee.LblWaitingFee.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        newFee.ShowDialog()
        ViewTotalPayDetail()
    End Sub

    Private Sub BtnSetExchangeRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetExchangeRate.Click
        Dim SExchageRate As New SetExchageRate
        SExchageRate.TxtExChangeRate.Text = DA_Rate.SelectValueExchage
        SExchageRate.ShowDialog()
    End Sub

    Private Sub BtnRefreshWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshWaiting.Click
        ViewPatientConsult(3)
    End Sub

    Private Sub BtnRemoveFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveFee.Click
        If GridConsultFee.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove this consult fee?", "Consult Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_AddService.DeleteWaitingPay(GridConsultFee.GetRow.Cells("WAIT_PAY_NO").Value) = 1 Then
                ViewPatientWaitingPay(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
                ViewTotalPayDetail()
            End If
        End If
    End Sub

    Private Sub BtnAddMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedicine.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        Dim FMoreMedicine As New AddMoreMedicine(Me)
        FMoreMedicine.LblWaitingFee.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        FMoreMedicine.LblPatientNo.Text = GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value
        FMoreMedicine.ShowDialog()
        ViewTotalPayDetail()
    End Sub

    Private Sub BtnRemoveMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveMedicine.Click
        Try
            If MessageBox.Show("Do you want to delete this medicine?", "Delete medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' DA_Medicine.DeleteMedicinePay(GridPrescription.GetRow.Cells("WAITING_NO_MEDICINE").Value)
                DA_MedicinePay.DeletePrescript(True, GridPrescription.GetRow.Cells("PRES_ID").Value)
                ViewPatientMedicine(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
                ViewTotalPayDetail()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPrintCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintCard.Click
       
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        Dim FPrintLabel As New FormLabelPrinter
        Dim CrvPrintLabel As New PrintLabel
        Dim tblPrescripLabel As DataTable = DA_MedicinePay.SelectPrintLabel(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
        EXPORT_PDF_PRINTER(CrvPrintLabel, tblPrescripLabel, FPrintLabel.AxAcroPDF1, "LABEL_PRECRIPTION")
        FPrintLabel.ShowDialog()
    End Sub

    Private Sub BtnCustomerOutsite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerOutsite.Click
        Dim FNewPatientPay As New NewPatientPayment
        FNewPatientPay.IS_OUTPATIEN = True
        If FNewPatientPay.ShowDialog() = DialogResult.OK Then
            ViewPatientConsult(3)
        End If

        'FNewPatientPay.Dispose()
        'FNewPatientPay.Close()
    End Sub


    Private Sub GridPatientWaiting_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPatientWaiting.RowDoubleClick
        NewIssueInvoice()
    End Sub
    Sub NewIssueInvoice()
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        If GridPatientWaiting.FilterRow.Selected = True Then
            MessageBox.Show("Please select patient before issue invoice", "Examination", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DA_Waiting.CheckPatientPay(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value) = 1 Then
            MessageBox.Show("This patient already paid. Please refresh new payment", "Issue Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BtnRefreshWaiting_Click(sender, e)
            Exit Sub
        End If
        Dim IsInvoice As New IssueInvoice(Me)
        IsInvoice.TxtPaitneNo.Text = GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value
        IsInvoice.TxtPaintNameEng.Text = GridPatientWaiting.GetRow.Cells("NameEng").Value
        IsInvoice.TxtPatientNameKh.Text = GridPatientWaiting.GetRow.Cells("NameKhmer").Value
        IsInvoice.TxtSex.Text = GridPatientWaiting.GetRow.Cells("Sex").Value
        IsInvoice.TxtAge.Text = GridPatientWaiting.GetRow.Cells("Age").Value
        IsInvoice.LblWaitingID.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        IsInvoice.LblDrName.Text = GridPatientWaiting.GetRow.Cells("OPHTHAMOLOGIST").Value
        IsInvoice.LblDiagnosis.Text = GridPatientWaiting.GetRow.Cells("DIAGNOSIS").Value
        IsInvoice.PictureBox1.Image = ByteArrayToImage(DAPatient.SelectPicture(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value))
        Dim TotalServiceFee As Double = 0
        Dim TotalMedicineFee As Double = 0
        Dim TotalMedicineDel As Double = 0
        For i As Integer = 0 To GridConsultFee.RowCount - 2
            TotalServiceFee = TotalServiceFee + CDbl(GridConsultFee.GetRow(i).Cells("PRICE_PAY").Value)
        Next
        For i As Integer = 0 To GridPrescription.RowCount - 2
            'Try
            '    If GridPrescription.GetRow(i).Cells("IS_DELETE").Value = True Then
            '        TotalMedicineDel = CDbl(GridPrescription.GetRow(i).Cells("TOTAL_PRICE").Value)
            '    End If
            'Catch ex As Exception

            'End Try

            TotalMedicineFee = TotalMedicineFee + CDbl(IIf(GridPrescription.GetRow(i).Cells("IS_DELETE").Value = True, 0, CDbl(GridPrescription.GetRow(i).Cells("TOTAL_PRICE").Value)))
        Next
        IsInvoice.TxtTotalConsultFee.Text = TotalServiceFee
        IsInvoice.TxtMedicineFee.Text = TotalMedicineFee
        IsInvoice.TxtTotalAferDiscount.Text = TotalServiceFee + TotalMedicineFee
        IsInvoice.TxtEndbalance.Text = TotalServiceFee + TotalMedicineFee
        If IsInvoice.ShowDialog = DialogResult.OK Then
            For i As Integer = 0 To GridPrescription.RowCount - 2
                If GridPrescription.GetRow(i).Cells("IS_DELETE").Value <> True Then
                    ProcessCutStock(CInt(GridPrescription.GetRow(i).Cells("MEDICINCE_ID").Value), -CInt(GridPrescription.GetRow(i).Cells("MEDICINCE_QTY").Value))
                End If
            Next
            ViewPatientConsult(3)
        End If
    End Sub
    Public Sub ProcessCutStock(ByVal ItemNo As Integer, ByVal qty As Integer)
        DA_QTY.UpdateQTY(qty, ItemNo)
    End Sub
    Private Sub BtnDeleteIssueInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteIssueInvoice.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete payment?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Consult.UpdageDeleteWaitingPayment("5", GridPatientWaiting.GetRow.Cells("WAIT_ID").Value) = 1 Then
                ViewPatientConsult(3)
            End If
        End If
    End Sub

    Private Sub BtnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndo.Click
        Try
            If MessageBox.Show("Do you want to delete this medicine?", "Delete medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' DA_Medicine.DeleteMedicinePay(GridPrescription.GetRow.Cells("WAITING_NO_MEDICINE").Value)
                DA_MedicinePay.DeletePrescript(False, GridPrescription.GetRow.Cells("PRES_ID").Value)
                ViewPatientMedicine(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
                ViewTotalPayDetail()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnLaserService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaserService.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        Dim newFee As New AddLaserService(Me)
        newFee.LblWaitingID.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        newFee.ShowDialog()
        ViewTotalPayDetail()
    End Sub

    Private Sub BtnInvestigate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvestigate.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        Dim newFee As New AddInvestigate(Me)
        newFee.LblWaitingID.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        newFee.ShowDialog()
        ViewTotalPayDetail()
    End Sub

    Private Sub BtnPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrescription.Click
        Try
            Dim VReport As New PrintPreviewInvoice
            VReport.SplitContainer1.Panel1Collapsed = True
            '============== For Prescription ===========================
            Dim ViewPrescrip As New CrpPrescription
            Dim CrExportOptionsBig1 As ExportOptions

            Dim TblPrescription As DataTable = Prescription.SelectPrescriptionWaitingID(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
            Dim TblFollowUp As DataTable = DA_FollowUp.SelectPFollowupByWaitingID(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
            ViewPrescrip.SetDataSource(TblPrescription)
            ViewPrescrip.Subreports("PatientFollowup").SetDataSource(TblFollowUp)
            Dim CrDiskFileDestinationOptionsBig1 As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig1 As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig1.DiskFileName = My.Application.Info.DirectoryPath & "\Prescription.pdf"
            CrExportOptionsBig1 = ViewPrescrip.ExportOptions
            With CrExportOptionsBig1
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig1
                .FormatOptions = CrFormatTypeOptionsBig1
            End With
            ViewPrescrip.Export()
            Application.DoEvents()
            Application.DoEvents()
            VReport.AxAcroPDFPrescription.src = My.Application.Info.DirectoryPath & "\Prescription.pdf"
            VReport.AxAcroPDFPrescription.setZoom(100)
            VReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddLaboratoryService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLaboratoryService.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        Dim FLaboFee As New AddLaboratory(Me)
        FLaboFee.LblWaitingID.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        FLaboFee.ShowDialog()
        ViewTotalPayDetail()
    End Sub

    Private Sub BtnViewPaymentToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewPaymentToday.Click
        ViewWaitingPay(3, Now.Date)
    End Sub
End Class
