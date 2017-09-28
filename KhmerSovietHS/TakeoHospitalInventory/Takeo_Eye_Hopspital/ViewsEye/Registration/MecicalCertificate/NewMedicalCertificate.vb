Public Class NewMedicalCertificate
    Dim DA_Patient As New DSConsultTableAdapters.TblPatientsTableAdapter
    Dim DA_MedicalCertificate As New DSMedicalCertificateTableAdapters.MEDICAL_CERTIFICATETableAdapter
    Dim DA_Dignosis As New DSConsultTableAdapters.TblSurgeryTableAdapter
    Dim DA_Surgery As New DSConsultTableAdapters.tblDiagSurgeriesTableAdapter
    Dim DA_Doctor As New DSMedicalCertificateTableAdapters.MEDICAL_DRTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDiagnosis
            .DataSource = DA_Dignosis.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgery"
            .SelectedIndex = -1
        End With
        Dim TblDiagnosis As DataTable = DA_Dignosis.GetData
        For Each rows As DataRow In TblDiagnosis.Rows
            AutocompleteDiagnosis.AddItem(rows("Surgery"))
        Next
        With CboSurgery
            .DataSource = DA_Surgery.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgeries"
            .SelectedIndex = -1
        End With
        Dim TblSurgery As DataTable = DA_Surgery.GetData
        For Each rows As DataRow In TblSurgery.Rows
            AutocompleteSurgery.AddItem(rows("Surgeries"))
        Next
        With CboDoctor
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DR_ID"
            .DisplayMember = "DRNAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub NewMedicalCertificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Dim TblPatient As DataTable = DA_Patient.GetDataByPatientNo(EmptyString(TxtPatientNo.Text))
        If TblPatient.Rows.Count <= 0 Then
            MessageBox.Show("Patient No not found. Please check again.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPatientNo.SelectAll()
            TxtPatientName.Text = ""
            TxtPatientSex.Text = ""
            txtPatientAge.Text = ""
            TxtPatientAddress.Text = ""
            TxtPatientOccupation.Text = ""
        Else
            For Each DRow As DataRow In TblPatient.Rows
                TxtPatientName.Text = DRow("NameKhmer")
                TxtPatientSex.Text = DRow("Sex")
                txtPatientAge.Text = DRow("Age")
                TxtPatientAddress.Text = DRow("Address")
                TxtPatientOccupation.Text = DRow("Occupation")
            Next
        End If
        
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtPatientNo, "", ErrMedicalCertificate) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrMedicalCertificate) = False Then Exit Sub
        'If ValidateDateTimePicker(DateExam, "", ErrMedicalCertificate) = False Then Exit Sub
        ''If ValidateCombobox(CboDiagnosis, "", ErrMedicalCertificate) = False Then Exit Sub
        ''If ValidateCombobox(CboSurgery, "", ErrMedicalCertificate) = False Then Exit Sub
        ''If ValidateCombobox(cboEye1, "", ErrMedicalCertificate) = False Then Exit Sub
        'If ValidateDateTimePicker(DateAdvice, "", ErrMedicalCertificate) = False Then Exit Sub
        If ValidateDateTimePicker(DatePrepare, "", ErrMedicalCertificate) = False Then Exit Sub
        'If ValidateCombobox(CboDoctor, "", ErrMedicalCertificate) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new medical certificate?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_MedicalCertificate.InsertNewMedical(TxtPatientNo.Text, DateExam.Value.Date, TxtSymtom.Text, TxtTREATMENT.Text, TxtAdvice.Text, DatePrepare.Value.Date, CboDoctor.Text, cboEye1.Text, DateSurgery.Value.Date) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want update medical certificate?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_MedicalCertificate.UpdateMedical(TxtPatientNo.Text, DateExam.Value.Date, TxtSymtom.Text, TxtTREATMENT.Text, TxtAdvice.Text, DatePrepare.Value.Date, CboDoctor.Text, cboEye1.Text, DateSurgery.Value.Date, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class