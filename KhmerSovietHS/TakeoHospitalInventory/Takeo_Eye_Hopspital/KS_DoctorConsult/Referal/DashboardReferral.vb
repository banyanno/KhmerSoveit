Public Class DashboardReferral
    Dim DA_Referral As New DSConsultHistoryTableAdapters.S_REFERRALTableAdapter
    Dim DAPatientWait As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    Private Sub BtnNewReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReferral.Click
        Dim NReferral As New NewReferral
        NReferral.PatientNo.ReadOnly = False
        NReferral.BtnLoadPatient.Visible = True
        If NReferral.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        FindByDate(Now.Date, Now.Date)
    End Sub
    Public Sub FindByDate(ByVal DateFrom As Date, ByVal DateTo As Date)
        GridReferral.DataSource = DA_Referral.SelectDateToDate(DateFrom.Date, DateTo.Date)
    End Sub
    Public Sub FindPatientNo(ByVal PatientNo As Double)
        GridReferral.DataSource = DA_Referral.SelectByPatientNo(PatientNo)
    End Sub
    Private Sub BtnFindPatientReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatientReferral.Click
        Dim FFReferral As New FormFindReferral(Me)
        FFReferral.ShowDialog()

    End Sub

    Private Sub DashboardReferral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FindByDate(Now.Date, Now.Date)
    End Sub

    Private Sub btnUpdateReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateReferral.Click
        If GridReferral.SelectedItems.Count = 0 Then Exit Sub
        UpdateReferral()
    End Sub
    Private Sub UpdateReferral()
        Dim FReferral As New NewReferral
        FReferral.LblSaveOption.Text = GridReferral.GetRow.Cells("REFERRAL_ID").Value
        FReferral.DateCreate.Checked = True
        FReferral.DateCreate.Value = GridReferral.GetRow.Cells("CREATE_DATE").Value
        FReferral.PatientNo.Text = GridReferral.GetRow.Cells("PATIENT_NO").Value
        FReferral.PatientName.Text = GridReferral.GetRow.Cells("PATIENT_NAME").Value
        FReferral.Sex.Text = GridReferral.GetRow.Cells("PATIENT_SEX").Value
        FReferral.Age.Text = GridReferral.GetRow.Cells("PATIENT_AGE").Value
        FReferral.PictureBox1.Image = ByteArrayToImage(DAPatientWait.SelectPicture(GridReferral.GetRow.Cells("PATIENT_NO").Value))
        FReferral.ChiefComplaint.Text = GridReferral.GetRow.Cells("CHIEF_COMPLAINT").Value

        FReferral.ODSC.Text = GridReferral.GetRow.Cells("ODSC").Value
        FReferral.ODCC.Text = GridReferral.GetRow.Cells("ODCC").Value
        FReferral.ODCCPH.Text = GridReferral.GetRow.Cells("ODCCPH").Value
        FReferral.OSSC.Text = GridReferral.GetRow.Cells("OSSC").Value
        FReferral.OSCC.Text = GridReferral.GetRow.Cells("OSCC").Value
        FReferral.OSCCPH.Text = GridReferral.GetRow.Cells("OSCCPH").Value
        FReferral.ODSPH.Text = GridReferral.GetRow.Cells("ODSPH").Value
        FReferral.ODCYL.Text = GridReferral.GetRow.Cells("ODCYL").Value
        FReferral.ODVA.Text = GridReferral.GetRow.Cells("ODVA").Value
        FReferral.OSSPH.Text = GridReferral.GetRow.Cells("OSSPH").Value
        FReferral.OSCYL.Text = GridReferral.GetRow.Cells("OSCYL").Value
        FReferral.OSVA.Text = GridReferral.GetRow.Cells("OSVA").Value
        FReferral.ODMMHG.Text = GridReferral.GetRow.Cells("ODMMHG").Value
        FReferral.OSMMHG.Text = GridReferral.GetRow.Cells("OSMMHG").Value
        FReferral.SLIT_LAM.Text = GridReferral.GetRow.Cells("SLIT_LAM").Value
        FReferral.FUNDUS_FINDING.Text = GridReferral.GetRow.Cells("FUNDUS_FINDING").Value
        FReferral.DIAGNOSIS.Text = GridReferral.GetRow.Cells("DIAGNOSIS").Value
        FReferral.TREATMENT.Text = GridReferral.GetRow.Cells("TREATMENT").Value
        If FReferral.ShowDialog() = DialogResult.OK Then
            Dim CRVReferral As New PatientReportReferral
            Dim tblReferral As DataTable = DA_Referral.SelectReferralReport(GridReferral.GetRow.Cells("REFERRAL_ID").Value)
            Dim FPrintPreview As New FormPrintPreview
            EXPORT_PDF_PRINTER(CRVReferral, tblReferral, FPrintPreview.AxAcroPDF1, "PatientReferral")
            FPrintPreview.ShowDialog()
        End If
    End Sub

    Private Sub GridReferral_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridReferral.RowDoubleClick
        If GridReferral.SelectedItems.Count = 0 Then Exit Sub
        UpdateReferral()
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If GridReferral.SelectedItems.Count = 0 Then Exit Sub
        Dim CRVReferral As New PatientReportReferral
        Dim tblReferral As DataTable = DA_Referral.SelectReferralReport(GridReferral.GetRow.Cells("REFERRAL_ID").Value)
        Dim FPrintPreview As New FormPrintPreview
        EXPORT_PDF_PRINTER(CRVReferral, tblReferral, FPrintPreview.AxAcroPDF1, "PatientReferral")
        FPrintPreview.ShowDialog()
    End Sub
End Class
