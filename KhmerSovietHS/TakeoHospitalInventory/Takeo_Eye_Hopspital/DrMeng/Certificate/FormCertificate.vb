Public Class FormCertificate
    Dim DA_Patient As New DSConsultHistoryTableAdapters.TblPatientsTableAdapter
    Dim DA_Certificate As New DSCertificateTableAdapters.S_PATIENT_CERTIFICATETableAdapter
    Private Sub FormCertificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLoadPatientNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadPatientNo.Click
        LoadPatientInfo(EmptyString(TxtPatientNo.Text))
    End Sub
    Private Sub LoadPatientInfo(ByVal PatientNo As Double)
        Dim TPatient As DataTable = DA_Patient.SelectByPatientNo(PatientNo)
        If TPatient.Rows.Count = 0 Then
            TxtPatientName.Text = ""
            TxtAge.Text = ""
            TxtSex.Text = ""
            MessageBox.Show("Please check patient No again. The patient doesn't have in system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For Each rows As DataRow In TPatient.Rows
                TxtPatientName.Text = rows("NameEng")
                TxtAge.Text = rows("Age")
                TxtSex.Text = rows("Sex")
            Next
        End If
        
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
   

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DateCreate, "", ErrCertificate) = False Then Exit Sub
        If ValidateTextField(TxtPatientNo, "", ErrCertificate) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrCertificate) = False Then Exit Sub
        If ValidateTextField(TxtSex, "", ErrCertificate) = False Then Exit Sub
        If ValidateTextField(TxtAge, "", ErrCertificate) = False Then Exit Sub
        If ValidateDateTimePicker(DateExamination, "", ErrCertificate) = False Then Exit Sub
        If ValidateDateTimePicker(DateStayFrom, "", ErrCertificate) = False Then Exit Sub
        If ValidateDateTimePicker(DateStayTo, "", ErrCertificate) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Certificate.InsertNewCertificate(DateCreate.Value.Date, EmptyString(TxtPatientNo.Text), TxtPatientName.Text, TxtSex.Text, TxtAge.Text, DateExamination.Value.Date, TxtMedicalFinding.Text, TxtUnderwent.Text, CboPeriod.Text, DateStayFrom.Value.Date, DateStayTo.Value.Date, CboDoctor.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                MessageBox.Show("Error save certificate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Certificate.UpdateCertificate(DateCreate.Value.Date, EmptyString(TxtPatientNo.Text), TxtPatientName.Text, TxtSex.Text, TxtAge.Text, DateExamination.Value.Date, TxtMedicalFinding.Text, TxtUnderwent.Text, CboPeriod.Text, DateStayFrom.Value.Date, DateStayTo.Value.Date, CboDoctor.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                MessageBox.Show("Error update certificate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class