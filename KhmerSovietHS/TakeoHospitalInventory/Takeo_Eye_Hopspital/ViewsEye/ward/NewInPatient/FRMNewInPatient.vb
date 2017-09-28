Public Class FRMNewInPatient
    Public isCloseNewInPatient As Boolean = False
    Dim newInpatientForm As UCNewInPatient
    Sub New(ByVal wardInPatient As UCNewInPatient)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.newInpatientForm = wardInPatient
        Try
            With CboDiagnosis
                .DataSource = ModDiagnosis.SelectMainSurgery()
                .DisplayMember = "Surgery"
                .ValueMember = "SID"
                .Text = Nothing
            End With
            With CboSurgery
                .DataSource = ModSurgeries.SelectSurgeries()
                .DisplayMember = "Surgeries"
                .ValueMember = "SID"
                .Text = Nothing
            End With
        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            With CboDiagnosis
                .DataSource = ModDiagnosis.SelectMainSurgery()
                .DisplayMember = "Surgery"
                .ValueMember = "SID"
                .Text = Nothing
            End With
        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        isCloseNewInPatient = False
        Me.Close()
    End Sub
    Sub ClearForm()
        TxtPatientNo.Text = ""
        TxtPatientName.Text = ""
        TxtAge.Text = ""
        TxtSex.Text = ""
        TxtAddress.Text = ""
        CboEye.Text = ""
        CboDiagnosis.Text = ""
        CboSurgery.Text = ""
        txtVALE.Text = ""
        TxtVARE.Text = ""
        DateDischarge.Checked = False
        DateFollowUp.Checked = False
        ChSignature.Checked = False
        ChTypeOther.Checked = False
        TxtPatientNo.Focus()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DDischarge As String
        Dim DFollowup As String
        Dim CWaiting As String
        

        If DateDischarge.Checked = True Then
            DDischarge = "'" & DateDischarge.Value & "'"
        Else
            DDischarge = "NULL"
        End If
        If DateFollowUp.Checked = True Then
            DFollowup = "'" & DateFollowUp.Value & "'"
        Else
            DFollowup = "NULL"
        End If

        If ValidateTextField(TxtPatientNo, "patientNo", ErrNewInpatient) = False Or _
            ValidateTextField(TxtPatientName, "patient name", ErrNewInpatient) = False Or _
            ValidateCombobox(CboDiagnosis, "diagnosis", ErrNewInpatient) = False _
      Then
            MsgBox("Could you fill new in-patient.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        ' Check Diagnosis name
        If ModDiagnosis.CheckNameDiagnosis(CboDiagnosis.Text.Trim) = 0 Then
            MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
            CboDiagnosis.Focus()
            CboDiagnosis.SelectAll()
            Exit Sub
        End If

        If LblSaveOption.Text = "0" Then
            If ModNewInPatient.CheckNewInpatient(EmptyString(TxtPatientNo.Text)) = True Then
                MsgBox("This patient not yet leave.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModNewInPatient.SaveNewInPatient( _
                TxtPatientNo.Text, _
                CboEye.Text, _
                CboDiagnosis.Text, _
                CboSurgery.Text, _
                TxtVARE.Text, _
                txtVALE.Text, _
                DDischarge, _
                DFollowup, _
                ChSignature.Checked, _
                ChTypeOther.Checked, _
                0) = 1 Then
                    MsgBox("Save new in-patient successfully.", MsgBoxStyle.Information, "Save")
                    newInpatientForm.FindAction("", "", "")
                    newInpatientForm.CountDailyInpatient()
                    ClearForm()
                    'Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox("Error save new in-patient.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_SAVE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModNewInPatient.UpdateNewInPatient(LblSaveOption.Text, _
                TxtPatientNo.Text, _
                CboEye.Text, _
                CboDiagnosis.Text, _
                CboSurgery.Text, _
                TxtVARE.Text, _
                txtVALE.Text, _
                DDischarge, _
                DFollowup, _
                ChSignature.Checked, _
                ChTypeOther.Checked) = 1 Then
                    MsgBox("Update new in-patient successfully.", MsgBoxStyle.Information, "Update")
                    isCloseNewInPatient = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()

                Else
                    MsgBox("Error new in-patient.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If

    End Sub


   
    Private Sub LblLoad_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblLoad.LinkClicked
        LoadPatientInfo()
    End Sub
    Sub LoadPatientInfo()
        Dim TblPatient As DataTable = ModNewInPatient.SelectPatient(EmptyString(TxtPatientNo.Text))
        Dim DRow As DataRow
        If TblPatient.Rows.Count > 0 Then
            For i As Integer = 0 To TblPatient.Rows.Count - 1
                DRow = TblPatient.Rows(i)
                TxtPatientName.Text = DRow("NameEng").ToString
                TxtAge.Text = DRow(2).ToString
                TxtSex.Text = DRow(3).ToString
                TxtAddress.Text = DRow(4).ToString
            Next
            CboEye.Focus()
        Else
            TxtPatientName.Text = ""
            TxtAge.Text = ""
            TxtSex.Text = ""
            TxtAddress.Text = ""
        End If
    End Sub
    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    
    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadPatientInfo()
        End If
    End Sub

    Private Sub CboDiagnosis_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDiagnosis.SelectedValueChanged
        Try
            ChTypeOther.Checked = ModDiagnosis.SelectDiagnosisTypeOther(CboDiagnosis.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CboEye_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboEye.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboDiagnosis.Focus()
        End If
    End Sub

    Private Sub CboDiagnosis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboDiagnosis.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVARE.Focus()
        End If
    End Sub

    Private Sub txtVALE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVALE.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateFollowUp.Focus()
        End If
    End Sub

    Private Sub DateFollowUp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateFollowUp.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChSignature.Focus()
        End If
    End Sub

    Private Sub ChSignature_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChSignature.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.Focus()
        End If
    End Sub

    Private Sub TxtVARE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVARE.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtVALE.Focus()
        End If
    End Sub
End Class