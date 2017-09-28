Public Class DashMedicalCertificate
    Dim DA_Certifcate As New DSCertificateTableAdapters.S_PATIENT_CERTIFICATETableAdapter
    Private Sub BtnNewCertificate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCertificate.Click
        Dim FCertificate As New FormCertificate
        If FCertificate.ShowDialog Then
            LoadPatientCertificate()
        End If
    End Sub

    Private Sub DashMedicalCertificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPatientCertificate()
    End Sub
    Private Sub LoadPatientCertificate()
        GridCertificate.DataSource = DA_Certifcate.GetData
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        LoadPatientCertificate()
    End Sub

    Private Sub BtnUpdateCertificate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateCertificate.Click
        If GridCertificate.SelectedItems.Count = 0 Then Exit Sub
        Dim FCertificate As New FormCertificate
        FCertificate.LblSaveOption.Text = GridCertificate.GetRow.Cells("CERT_ID").Value
        FCertificate.DateCreate.Checked = True
        FCertificate.DateCreate.Value = GridCertificate.GetRow.Cells("CREATE_DATE").Value
        FCertificate.TxtPatientNo.Text = GridCertificate.GetRow.Cells("PATIENT_NO").Value
        FCertificate.TxtPatientName.Text = GridCertificate.GetRow.Cells("PATIENT_NAME").Value
        FCertificate.TxtSex.Text = GridCertificate.GetRow.Cells("SEX").Value
        FCertificate.TxtAge.Text = GridCertificate.GetRow.Cells("AGE").Value
        FCertificate.DateExamination.Checked = True
        FCertificate.DateExamination.Value = GridCertificate.GetRow.Cells("DATE_EXAM").Value
        FCertificate.TxtMedicalFinding.Text = GridCertificate.GetRow.Cells("MEDICAL_FINDING").Value
        FCertificate.TxtUnderwent.Text = GridCertificate.GetRow.Cells("UNDERWENT").Value
        FCertificate.CboPeriod.Text = GridCertificate.GetRow.Cells("PERIOD").Value
        FCertificate.DateStayFrom.Checked = True
        FCertificate.DateStayFrom.Value = GridCertificate.GetRow.Cells("START_FROM").Value
        FCertificate.DateStayTo.Checked = True
        FCertificate.DateStayTo.Value = GridCertificate.GetRow.Cells("END_TO").Value
        FCertificate.CboDoctor.Text = GridCertificate.GetRow.Cells("STAFF_OPT").Value
        If FCertificate.ShowDialog Then
            LoadPatientCertificate()
        End If
    End Sub

    Private Sub BtnDeleteCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteCert.Click
        If GridCertificate.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Certifcate.DeleteCertificate(GridCertificate.GetRow.Cells("CERT_ID").Value) = 1 Then
                LoadPatientCertificate()
            End If
        End If
    End Sub

    Private Sub GridCertificate_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridCertificate.RowDoubleClick
        If GridCertificate.SelectedItems.Count = 0 Then Exit Sub
        Dim FCertificate As New FormCertificate
        FCertificate.LblSaveOption.Text = GridCertificate.GetRow.Cells("CERT_ID").Value
        FCertificate.DateCreate.Checked = True
        FCertificate.DateCreate.Value = GridCertificate.GetRow.Cells("CREATE_DATE").Value
        FCertificate.TxtPatientNo.Text = GridCertificate.GetRow.Cells("PATIENT_NO").Value
        FCertificate.TxtPatientName.Text = GridCertificate.GetRow.Cells("PATIENT_NAME").Value
        FCertificate.TxtSex.Text = GridCertificate.GetRow.Cells("SEX").Value
        FCertificate.TxtAge.Text = GridCertificate.GetRow.Cells("AGE").Value
        FCertificate.DateExamination.Checked = True
        FCertificate.DateExamination.Value = GridCertificate.GetRow.Cells("DATE_EXAM").Value
        FCertificate.TxtMedicalFinding.Text = GridCertificate.GetRow.Cells("MEDICAL_FINDING").Value
        FCertificate.TxtUnderwent.Text = GridCertificate.GetRow.Cells("UNDERWENT").Value
        FCertificate.CboPeriod.Text = GridCertificate.GetRow.Cells("PERIOD").Value
        FCertificate.DateStayFrom.Checked = True
        FCertificate.DateStayFrom.Value = GridCertificate.GetRow.Cells("START_FROM").Value
        FCertificate.DateStayTo.Checked = True
        FCertificate.DateStayTo.Value = GridCertificate.GetRow.Cells("END_TO").Value
        FCertificate.CboDoctor.Text = GridCertificate.GetRow.Cells("STAFF_OPT").Value
        If FCertificate.ShowDialog Then
            LoadPatientCertificate()
        End If
    End Sub

    Private Sub BtnPrintCertifcate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintCertifcate.Click
        If GridCertificate.SelectedItems.Count = 0 Then Exit Sub
        Dim FViewCertificate As New FormViewCertificate
        Dim CCertificate As New CRVCertificate
        Dim TCertificate As DataTable = DA_Certifcate.SelectByPatientNo(GridCertificate.GetRow.Cells("PATIENT_NO").Value, GridCertificate.GetRow.Cells("CERT_ID").Value)
        EXPORT_PDF_PRINTER(CCertificate, TCertificate, FViewCertificate.AxAcroPDF1, "MedicalCertificate")
        FViewCertificate.ShowDialog()


    End Sub
End Class
