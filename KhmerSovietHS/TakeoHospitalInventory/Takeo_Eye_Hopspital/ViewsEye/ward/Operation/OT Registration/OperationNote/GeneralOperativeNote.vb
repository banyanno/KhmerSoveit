Public Class GeneralOperativeNote
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Dim DA_OPERATIVE As New DSOPERATIONNOTETableAdapters.S_OPER_GENERAL_OPERATIVETableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With SCRUB
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        With CIRCULATING
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        With ANESTHESIONLOGIST
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        With DIAGNOSIS
            .DataSource = DA_DIAGNOSIS.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgery"
            .SelectedIndex = -1
        End With
        With SURGEON_SIGNATURE
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(DIAGNOSIS, "", ErrOperative) = False Then Exit Sub
        If ValidateDateTimePicker(START_TIME, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrOperative) = False Then Exit Sub
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_OPERATIVE.InsertGenOperative(Now.Date, lblOpNo.Text, PATIENT_NO.Text, PATIENT_NAME.Text, PATIENT_SEX.Text, PATIENT_AGE.Text, START_TIME.Text, "", SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, S_AN_SUBCONJUNCTIVAL.Checked, OTHER_PROCEDURES.Text, SUB_GENTAL.Checked, SUB_CEFAZOLIN.Checked, SUB_DEXAMETHASONE.Checked, SUB_OTHER.Text, TOPICAL_MAXITRAL.Checked, TOPICAL_PILOCARPINE.Checked, TOPICAL_ATROPINE.Checked, TOPICAL_OTHER.Text, SURGEON_SIGNATURE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save general operative.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_OPERATIVE.UpdateGenOperative(START_TIME.Text, "", SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, S_AN_SUBCONJUNCTIVAL.Checked, OTHER_PROCEDURES.Text, SUB_GENTAL.Checked, SUB_CEFAZOLIN.Checked, SUB_DEXAMETHASONE.Checked, SUB_OTHER.Text, TOPICAL_MAXITRAL.Checked, TOPICAL_PILOCARPINE.Checked, TOPICAL_ATROPINE.Checked, TOPICAL_OTHER.Text, SURGEON_SIGNATURE.Text, lblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update general operative.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            
        End If
    End Sub
End Class