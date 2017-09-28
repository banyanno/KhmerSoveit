Public Class NewReferral
    Dim DA_Referral As New DSConsultHistoryTableAdapters.S_REFERRALTableAdapter
    Dim DA_Patient As New DSConsultHistoryTableAdapters.TblPatientsTableAdapter

    
    Private Sub PatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnLoadPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadPatient.Click
        FindPatient(EmptyString(PatientNo.Text))
    End Sub
    Public Sub FindPatient(ByVal PatientNo As Double)
        Dim tlbPatient As DataTable = DA_Patient.SelectByPatientNo(PatientNo)
        If tlbPatient.Rows.Count <= 0 Then
            MessageBox.Show("Doesn't have patient ID in system. Please check ID's patient again.", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PatientName.Text = ""
            Sex.Text = ""
            Age.Text = ""
            PictureBox1.Image = Nothing
        Else
            For Each rows As DataRow In tlbPatient.Rows
                PatientName.Text = rows("NameEng")
                Sex.Text = rows("Sex")
                Age.Text = rows("Age")
                PictureBox1.Image = ByteArrayToImage(rows("PatientPicture"))
            Next
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewReferral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateDateTimePicker(DateCreate, "", ErrReferral) = False Then Exit Sub
        If ValidateTextField(PatientNo, "", ErrReferral) = False Then Exit Sub
        If ValidateTextField(PatientName, "", ErrReferral) = False Then Exit Sub

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Referral.InsertNewReferral(EmptyString(PatientNo.Text), PatientName.Text, Sex.Text, Age.Text, DateCreate.Value.Date, ChiefComplaint.Text, ODSC.Text, ODCC.Text, ODCCPH.Text, OSSC.Text, OSCC.Text, OSCCPH.Text, ODSPH.Text, ODCYL.Text, ODVA.Text, OSSPH.Text, OSCYL.Text, OSVA.Text, ODMMHG.Text, OSMMHG.Text, SLIT_LAM.Text, FUNDUS_FINDING.Text, DIAGNOSIS.Text, TREATMENT.Text) = 1 Then

                    Dim CRVReferral As New PatientReportReferral
                    Dim tblReferral As DataTable = DA_Referral.SelectReferralReport(DA_Referral.SelectMaxReferral)
                    Dim FPrintPreview As New FormPrintPreview
                    EXPORT_PDF_PRINTER(CRVReferral, tblReferral, FPrintPreview.AxAcroPDF1, "PatientReferral")
                    FPrintPreview.ShowDialog()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Referral.UpdateReferral(EmptyString(PatientNo.Text), PatientName.Text, Sex.Text, Age.Text, DateCreate.Value.Date, ChiefComplaint.Text, ODSC.Text, ODCC.Text, ODCCPH.Text, OSSC.Text, OSCC.Text, OSCCPH.Text, ODSPH.Text, ODCYL.Text, ODVA.Text, OSSPH.Text, OSCYL.Text, OSVA.Text, ODMMHG.Text, OSMMHG.Text, SLIT_LAM.Text, FUNDUS_FINDING.Text, DIAGNOSIS.Text, TREATMENT.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class