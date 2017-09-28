Public Class InPatientPayFor
    Dim DA_PaymentFor As New DSInpatientReportTableAdapters.V_InpatientDetailTableAdapter
    Dim CInpatientPay As New CRInPatientPay
    Dim TblIncomeStatementTem As DataTable
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click


        If RadAllPay.Checked = True Then
            'TblIncomeStatementTem = DAOpticalShopIncomeS.GetDataByDateWithPaid(DatePayFrom.Value.Date, DatePayTo.Value.Date, 1)
            'ObjReportIncome.SetDataSource(TblIncomeStatementTem)
            'ObjReportIncome.SetParameterValue("Title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy"))
            'CRVOpticalPayment.ReportSource = ObjReportIncome
        ElseIf RadFull.Checked = True Then
            TblIncomeStatementTem = DA_PaymentFor.GetDataByInpatientPayFull(DatePayFrom.Value.Date, DatePayTo.Value.Date)
            CInpatientPay.SetDataSource(TblIncomeStatementTem)
            CInpatientPay.SetParameterValue("title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " For Full payment ( In-Patient )")
            CRVOpticalPayment.ReportSource = CInpatientPay
        ElseIf RadNil.Checked = True Then
            TblIncomeStatementTem = DA_PaymentFor.GetDataByInPatientNil(DatePayFrom.Value.Date, DatePayTo.Value.Date)
            CInpatientPay.SetDataSource(TblIncomeStatementTem)
            CInpatientPay.SetParameterValue("title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " For Nil payment ( In-Patient )")
            CRVOpticalPayment.ReportSource = CInpatientPay
        ElseIf RadSocial.Checked = True Then
            TblIncomeStatementTem = DA_PaymentFor.GetDataByInPatientPaySocial(DatePayFrom.Value.Date, DatePayTo.Value.Date)
            CInpatientPay.SetDataSource(TblIncomeStatementTem)
            CInpatientPay.SetParameterValue("Title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " For Social payment ( In-Patient )")
            CRVOpticalPayment.ReportSource = CInpatientPay
        End If
    End Sub
End Class