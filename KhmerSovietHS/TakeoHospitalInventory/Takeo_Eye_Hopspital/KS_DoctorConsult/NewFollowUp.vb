Public Class NewFollowUp
    Dim DA_FollowUp As New DSWaitingConsultTableAdapters.S_PATIENT_FOLLOWUPTableAdapter
    Dim DA_Patient As New DSConsultHistoryTableAdapters.TblPatientsTableAdapter
    Dim DA_Doctor As New DSWaitingConsultTableAdapters.VUsersInGroupTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        With CboDoctorConsult
            .DataSource = DA_Doctor.SelectGroupDepartment(36)
            .ValueMember = "UserID"
            .DisplayMember = "EmployeeName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtPatientNo, "", ErrFollowUp) = False Then Exit Sub
        If ValidateTextField(TxtSex, "", ErrFollowUp) = False Then Exit Sub
        If ValidateDateTimePicker(DateFollowUp, "", ErrFollowUp) = False Then Exit Sub
        If ValidateDateTimePicker(TimeFollowup, "", ErrFollowUp) = False Then Exit Sub
        If ValidateCombobox(CboDoctorConsult, "", ErrFollowUp) = False Then Exit Sub
        FindPatient(EmptyString(TxtPatientNo.Text))
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new followup?", "Follow Up", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FollowUp.InsertPatientFollowup(0, TxtPatientNo.Text, DateFollowUp.Value.Date, TxtFollowUpNote.Text, CboDoctorConsult.Text, TimeFollowup.Text, 1, CInt(CboDoctorConsult.SelectedValue)) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update followup?", "Follow Up", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FollowUp.UpdateFollowUp(CDbl(TxtPatientNo.Text), DateFollowUp.Value.Date, TxtFollowUpNote.Text, CboDoctorConsult.Text, TimeFollowup.Text, CInt(CboDoctorConsult.SelectedValue), LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
        
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnPatientNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientNo.Click
        FindPatient(EmptyString(TxtPatientNo.Text))
    End Sub
    Public Sub FindPatient(ByVal PatientNo As Double)
        Dim tlbPatient As DataTable = DA_Patient.SelectByPatientNo(PatientNo)
        If tlbPatient.Rows.Count <= 0 Then
            MessageBox.Show("Doesn't have patient ID in system. Please check ID's patient again.", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtSex.Text = ""
            TxtAge.Text = ""
            TxtTel.Text = ""
            PictureBox1.Image = Nothing
        Else
            For Each rows As DataRow In tlbPatient.Rows
                TxtPName.Text = rows("NameEng")
                TxtSex.Text = rows("Sex")
                TxtAge.Text = rows("Age")
                TxtTel.Text = rows("Telephone")
                PictureBox1.Image = ByteArrayToImage(rows("PatientPicture"))
            Next
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class