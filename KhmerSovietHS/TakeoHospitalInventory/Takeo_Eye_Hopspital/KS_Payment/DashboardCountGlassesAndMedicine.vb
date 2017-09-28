Public Class DashboardCountGlassesAndMedicine
    Dim DACountMedicine As New DS_KSPAYMENTTableAdapters.S_COUNT_MEDICINE_AND_GLASSESTableAdapter

    Private Sub BtnPrintPreviewMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreviewMedicine.Click
        Dim RCountMedicine As New ReportCountMedicine
        Dim tblCountMedicine As DataTable = DACountMedicine.SelectCountMedicince(DateFromMedicine.Value.Date, DateToMedicine.Value.Date)

        RCountMedicine.SetDataSource(tblCountMedicine)
        RCountMedicine.SetParameterValue("title", "From " & Format(DateFromMedicine.Value.Date, "dd-MM-yyyy") & " to " & Format(DateToMedicine.Value.Date, "dd-MM-yyyy"))
        CViewerMedicine.ReportSource = RCountMedicine
    End Sub
End Class
