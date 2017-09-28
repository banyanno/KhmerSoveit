Imports CrystalDecisions.Shared

Public Class IssueInvoice

    Dim DA_Rate As New DS_KSPAYMENTTableAdapters.S_EXCHANGE_RATETableAdapter
    Dim DA_Invoice As New DS_KSPAYMENTTableAdapters.S_INVOICE_KSTableAdapter
    Dim DA_Invoice_Detail As New DS_KSPAYMENTTableAdapters.S_INVOICE_DETAILTableAdapter
    Dim DA_Waiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Dim DPayment As DashboardPayment
    Dim DA_PrintInvoice As New DS_KSPAYMENTTableAdapters.S_INVOICE_KSR_VIEWTableAdapter
    Dim DA_Prescription As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter
    Sub New(ByVal DPayment As DashboardPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DPayment = DPayment
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub TxtDiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiscount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDiscount_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscount.KeyUp
        TxtEndbalance.Text = (CDbl(EmptyString(TxtTotalConsultFee.Text)) + CDbl(EmptyString(TxtMedicineFee.Text))) - (CDbl(EmptyString(TxtDiscount.Text)) + CDbl(EmptyString(TxtDeposit.Text)))
        TxtReil.Text = CDbl(EmptyString(TxtTotalAferDiscount.Text)) * CDbl(EmptyString(TxtExchageRate.Text))
        TxtReceive_KeyUp(sender, e)
    End Sub

    Private Sub TxtReceive_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceive.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceive_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceive.KeyUp
        If EmptyString(TxtReceive.Text) > CDbl(EmptyString(TxtTotalAferDiscount.Text)) Then
            TxtReturn.Text = CDbl(EmptyString(TxtReceive.Text)) - CDbl(EmptyString(TxtEndbalance.Text))
            TxtExchangRiel.Text = CDbl(EmptyString(TxtReturn.Text)) * CDbl(TxtExchageRate.Text)
        Else
            TxtReturn.Text = 0
            TxtExchangRiel.Text = 0
        End If
    End Sub

    Private Sub IssueInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtExchageRate.Text = DA_Rate.SelectValueExchage
        TxtReil.Text = CDbl(EmptyString(TxtExchageRate.Text)) * CDbl(EmptyString(TxtTotalAferDiscount.Text))
        TxtReceive.Focus()
        TxtReceive.Select()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtReceive, "", ErrorIssureInvoice) = False Then
            TxtReceive.Focus()
            TxtReceive.SelectAll()
            Exit Sub
        End If
        If CDbl(EmptyString(TxtReceive.Text)) < CDbl(EmptyString(TxtEndbalance.Text)) Then
            MessageBox.Show("The total recieved can not small than sub total.", "Issue invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtReceive.Focus()
            TxtReceive.SelectAll()
            Exit Sub
        End If
        If MessageBox.Show("Do you want to save new invoice?", "Issure Invoce", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim InvoiceID As Double
            If DA_Invoice.InsertNewInvoice(LblWaitingID.Text, Now.Date, TxtPaitneNo.Text, _
                                           EmptyString(TxtTotalAferDiscount.Text), EmptyString(TxtEndbalance.Text), _
                                           EmptyString(TxtExchageRate.Text), EmptyString(TxtReceive.Text), EmptyString(TxtReturn.Text), _
                                           USER_NAME, EmptyString(TxtDiscount.Text), 0, 0, 0, 0, TxtPaintNameEng.Text, _
                                           TxtPatientNameKh.Text, TxtSex.Text, TxtAge.Text, LblDrName.Text, LblDiagnosis.Text, _
                                           EmptyString(TxtTotalConsultFee.Text), EmptyString(TxtMedicineFee.Text), EmptyString(TxtDeposit.Text)) = 1 Then
                InvoiceID = DA_Invoice.SelectMaxInvoiceID
                For i As Integer = 0 To Me.DPayment.GridConsultFee.RowCount - 2
                    DA_Invoice_Detail.InsertInvoiceDetail(InvoiceID, Me.DPayment.GridConsultFee.GetRow(i).Cells("PAY_ON").Value, "1", "1", Me.DPayment.GridConsultFee.GetRow(i).Cells("PRICE_PAY").Value, Me.DPayment.GridConsultFee.GetRow(i).Cells("PRICE_PAY").Value)
                Next
                For I As Integer = 0 To Me.DPayment.GridPrescription.RowCount - 2
                    If Me.DPayment.GridPrescription.GetRow(I).Cells("IS_DELETE").Value <> True Then
                        DA_Invoice_Detail.InsertInvoiceDetail(InvoiceID, Me.DPayment.GridPrescription.GetRow(I).Cells("MEDICINCE_NAME").Value, Me.DPayment.GridPrescription.GetRow(I).Cells("MEDICINCE_QTY").Value, "", Me.DPayment.GridPrescription.GetRow(I).Cells("MEDICINCE_PRICE").Value, Me.DPayment.GridPrescription.GetRow(I).Cells("TOTAL_PRICE").Value)
                    End If
                Next
                If DA_Waiting.UpdatePatientStatus("", "4", "2", LblWaitingID.Text) = 1 Then
                    If ChInvoicePreview.Checked = True Then
                        Dim VReport As New PrintPreviewInvoice
                        Dim ViewInvoice As New IssureInvoice
                        Dim CrvPrintLabel As New PrintLabel
                        Dim TblInvoice As DataTable = DA_PrintInvoice.SelectByInvoiceID(InvoiceID)
                        Dim tblPrescripLabel As DataTable = DA_Prescription.SelectPrintLabel(LblWaitingID.Text)
                        EXPORT_PDF_PRINTER(ViewInvoice, TblInvoice, VReport.AxAcroPDF1, "Invoice")
                        EXPORT_PDF_PRINTER(CrvPrintLabel, tblPrescripLabel, VReport.AxAcroPDFPrescription, "LABEL_PRECRIPTION")
                        VReport.ShowDialog()
                    Else
                        Dim ViewInvoice As New IssureInvoice
                        printDocument.PrinterSettings.PrinterName = ModCommon.PrinterReceipt
                        Dim TblInvoice As DataTable = DA_PrintInvoice.SelectByInvoiceID(InvoiceID)
                        ViewInvoice.SetDataSource(TblInvoice)
                        Try
                            ViewInvoice.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
                            ViewInvoice.PrintToPrinter(1, True, 1, 1)
                            ViewInvoice.Dispose()
                            ViewInvoice.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error Printer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                        
                    End If

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub TxtMedicineFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMedicineFee.KeyPress
        SetDisableKey(e)
    End Sub

    Private Sub TxtDeposit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDeposit.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDeposit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDeposit.KeyUp
        TxtEndbalance.Text = (CDbl(EmptyString(TxtTotalConsultFee.Text)) + CDbl(EmptyString(TxtMedicineFee.Text))) - (CDbl(EmptyString(TxtDiscount.Text)) + CDbl(EmptyString(TxtDeposit.Text)))
        TxtReil.Text = CDbl(EmptyString(TxtTotalAferDiscount.Text)) * CDbl(EmptyString(TxtExchageRate.Text))
        TxtReceive_KeyUp(sender, e)
    End Sub
End Class