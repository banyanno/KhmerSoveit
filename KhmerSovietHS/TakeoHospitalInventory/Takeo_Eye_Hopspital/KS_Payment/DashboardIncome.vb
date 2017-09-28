Imports CrystalDecisions.Shared

Public Class DashboardIncome
    Dim DA_Income As New DS_KSPAYMENTTableAdapters.S_INVOICE_KSTableAdapter
    Dim DA_InvoiceDetail As New DS_KSPAYMENTTableAdapters.S_INVOICE_DETAILTableAdapter
    Dim DA_Prescription As New DS_KSPAYMENTTableAdapters.S_PRESCRIPTIONTableAdapter
    Dim DA_PrescriptionReport As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter
    Dim Prescription As New DS_KSPAYMENTTableAdapters.V_EYE_PRESCRIPTIONTableAdapter
    Dim MainIncome As New DS_KSPAYMENT
    Dim DA_PrintInvoice As New DS_KSPAYMENTTableAdapters.S_INVOICE_KSR_VIEWTableAdapter
    Dim DA_MedicinePay As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter
    Private Sub DashboardIncome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewIncome(DateFrom.Value.Date, DateTo.Value.Date)
    End Sub
    Sub ViewIncome(ByVal DFrom As Date, ByVal DTo As Date)
        DA_Income.FillByInvoiceDateToDate(MainIncome.S_INVOICE_KS, DFrom, DTo)
        DA_InvoiceDetail.Fill(MainIncome.S_INVOICE_DETAIL)
        DA_Prescription.Fill(MainIncome.S_PRESCRIPTION)
        GridIncome.DataSource = MainIncome.S_INVOICE_KS
        GridIncome.RootTable.ChildTables(0).DataMember = "S_INVOICE_KS_S_INVOICE_DETAIL"
        GridIncome.RootTable.ChildTables(1).DataMember = "S_INVOICE_KS_S_PRESCRIPTION"
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If ChReport.Checked = True Then
            AxAcroPDF1.Visible = True
            Dim HospitalIncome As New ReportIncome
            Dim TblIncome As DataTable = DA_Income.SelectInvoiceDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            HospitalIncome.SetDataSource(TblIncome)
            HospitalIncome.SetParameterValue("Title", "From: " & DateFrom.Text & " To: " & DateTo.Text)
            ' Declare for export Big app form
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\HospitalIncome.pdf"
            CrExportOptionsBig = HospitalIncome.ExportOptions
            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With
            HospitalIncome.Export()
            Application.DoEvents()
            Application.DoEvents()
            AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\HospitalIncome.pdf"
            AxAcroPDF1.setZoom(100)
            AxAcroPDF1.Dock = DockStyle.Fill
            GridIncome.Visible = False
        Else
            GridIncome.Dock = DockStyle.Fill
            AxAcroPDF1.Visible = False
            GridIncome.Visible = True
            ViewIncome(DateFrom.Value.Date, DateTo.Value.Date)
        End If

    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Try
            Dim VReport As New PrintPreviewInvoice
            Dim ViewInvoice As New IssureInvoice
            Dim TblInvoice As DataTable = DA_PrintInvoice.SelectByInvoiceID(GridIncome.GetRow.Cells("INVOICE_ID").Value)
            ViewInvoice.SetDataSource(TblInvoice)

            ' Declare for export Big app form
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\Invoice.pdf"
            CrExportOptionsBig = ViewInvoice.ExportOptions
            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With
            ViewInvoice.Export()
            Application.DoEvents()
            Application.DoEvents()
            VReport.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\Invoice.pdf"
            VReport.AxAcroPDF1.setZoom(100)


            '============== For Prescription ===========================
            Dim ViewPrescrip As New CrpPrescription
            Dim CrExportOptionsBig1 As ExportOptions

            Dim TblPrescription As DataTable = Prescription.SelectPrescriptionWaitingID(GridIncome.GetRow.Cells("WAITING_ID").Value)
            ViewPrescrip.SetDataSource(TblPrescription)
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

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AxAcroPDF1.Visible = True
        Dim HospitalIncome As New ReportIncome
        Dim TblIncome As DataTable = DA_Income.SelectInvoiceDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        HospitalIncome.SetDataSource(TblIncome)
        HospitalIncome.SetParameterValue("Title", "From: " & DateFrom.Text & " To: " & DateTo.Text)
        ' Declare for export Big app form
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\HospitalIncome.pdf"
        CrExportOptionsBig = HospitalIncome.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        HospitalIncome.Export()
        Application.DoEvents()
        Application.DoEvents()
        AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\HospitalIncome.pdf"
        AxAcroPDF1.setZoom(100)
        AxAcroPDF1.Dock = DockStyle.Fill
        GridIncome.Visible = False
    End Sub

    Private Sub BtnPrintlabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintlabel.Click
        Try
            Dim FPrintLabel As New FormLabelPrinter
            Dim CrvPrintLabel As New PrintLabel
            Dim tblPrescripLabel As DataTable = DA_MedicinePay.SelectPrintLabel(GridIncome.GetRow.Cells("WAITING_ID").Value)
            EXPORT_PDF_PRINTER(CrvPrintLabel, tblPrescripLabel, FPrintLabel.AxAcroPDF1, "LABEL_PRECRIPTION")
            FPrintLabel.ShowDialog()
        Catch ex As Exception

        End Try
       
    End Sub
End Class
