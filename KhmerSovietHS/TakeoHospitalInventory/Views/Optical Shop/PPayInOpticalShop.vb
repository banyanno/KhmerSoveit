Public Class PPayInOpticalShop
    Dim DAOpticalShopIncomeS As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim ObjReportIncome As New CryIncomeOpticalShop
    Private Sub PPayInOpticalShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Dim TblIncomeStatementTem As DataTable

        If RadAllPay.Checked = True Then
            TblIncomeStatementTem = DAOpticalShopIncomeS.GetDataByDateWithPaid(DatePayFrom.Value.Date, DatePayTo.Value.Date, 1)
            ObjReportIncome.SetDataSource(TblIncomeStatementTem)
            ObjReportIncome.SetParameterValue("Title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy"))
            CRVOpticalPayment.ReportSource = ObjReportIncome
        ElseIf RadFull.Checked = True Then
            TblIncomeStatementTem = DAOpticalShopIncomeS.GetDataByPatientPaySocial(DatePayFrom.Value.Date, DatePayTo.Value.Date, 1, 1)
            ObjReportIncome.SetDataSource(TblIncomeStatementTem)
            ObjReportIncome.SetParameterValue("Title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " For Full payment ( Optical Shop )")
            CRVOpticalPayment.ReportSource = ObjReportIncome
        ElseIf RadNil.Checked = True Then
            TblIncomeStatementTem = DAOpticalShopIncomeS.GetDataByPatientPaySocial(DatePayFrom.Value.Date, DatePayTo.Value.Date, 0, 2)
            ObjReportIncome.SetDataSource(TblIncomeStatementTem)
            ObjReportIncome.SetParameterValue("Title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " For Nil payment ( Optical Shop )")
            CRVOpticalPayment.ReportSource = ObjReportIncome
        ElseIf RadSocial.Checked = True Then
            TblIncomeStatementTem = DAOpticalShopIncomeS.GetDataByPatientPaySocial(DatePayFrom.Value.Date, DatePayTo.Value.Date, 1, 3)
            ObjReportIncome.SetDataSource(TblIncomeStatementTem)
            ObjReportIncome.SetParameterValue("Title", "From:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " To:" & Format(DatePayTo.Value.Date, "dd/MM/yyyy") & " For Social payment ( Optical Shop )")
            CRVOpticalPayment.ReportSource = ObjReportIncome
        End If

       
    End Sub
End Class