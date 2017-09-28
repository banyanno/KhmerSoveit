Public Class FRMOld_Outpatient
    Public isCloseOld As Boolean = False
    Dim DA_Referral As New DSREFFERRAL_TEHTableAdapters.REFFERAL_TEHTableAdapter
    Dim DA_Consult_Detail As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim DA_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            With CboDiagnosis
                .DataSource = ModDiagnosis.SelectMainSurgery()
                .ValueMember = "Surgery"
                .SelectedValue = "SID"
                .SelectAll()
            End With
            With TxtOther
                .DataSource = ModDoctor.SelectOther
                .ValueMember = "Other"
                .SelectedValue = "No"
                .SelectAll()
            End With
        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DateFollowUp.Checked = False Then
            MsgBox("Pleas check date.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim Riel As Double
        Dim Dolar As Double
        Dim DiagnosisTem As String
        If RadioRiel.Checked = True Then
            Riel = EmptyString(TxtPatientFee.Text)
            Dolar = 0
        End If
        If RadioDolar.Checked = True Then
            Dolar = EmptyString(TxtPatientFee.Text)
            Riel = 0
        End If
        If CboDiagnosis.Text <> "" Then
            If ModDiagnosis.CheckNameDiagnosis(CboDiagnosis.Text) = 0 Then
                MsgBox("Daignosis not exist in system. Could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
                CboDiagnosis.Focus()
                CboDiagnosis.SelectAll()
                Exit Sub
            End If
        End If
        If ValidateTextField(TxtReceiptNo, "receipt no", ErrOldOutpatient) = False Then
            Exit Sub
        End If
        If ValidateLabelField(TxtPatientNo, "patientNo", ErrOldOutpatient) = False Then
            Exit Sub
        End If
        If ChTypeOther.Checked = True Then
            DiagnosisTem = "Others"
        Else
            DiagnosisTem = CboDiagnosis.Text
        End If
        'If CheckStatusReferal() = False Then
        '    MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    GrpReferal.BackColor = Color.Khaki
        '    Exit Sub
        'Else
        '    GrpReferal.BackColor = Color.Transparent
        'End If

        

        If LblSaveOption.Text = "0" Then
            If GetTextReferralV1() = "" Then
                ChListReferral.BackColor = Color.Aqua
                MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Try
                    ChListReferral.BackColor = Color.White
                Catch ex As Exception

                End Try
            End If
            If TxtReceiptNo.Text <> "0" Then
                If ModNew_Outpatient.CheckReceiptAndPatient(TxtPatientNo.Text, TxtReceiptNo.Text) = True Then
                    MsgBox("Patient already exist for old-out patient book. Could you check old-out patient book again", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            End If
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, SAVE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModOld_Outpatient.SaveOldPatient(TxtReceiptNo.Text, _
                TxtPatientNo.Text, _
                CboDiagnosis.Text, _
                DiagnosisTem, _
               Riel, _
               Dolar, _
                ChPhysical.Checked, _
                ChSeeing.Checked, _
                ChHearing.Checked, _
                ChUnderstand.Checked, _
                ChSeeing.Checked, _
                ChPhysical.Checked, _
                TxtOther.Text, _
                DateFollowUp.Value, _
                ChTypeOther.Checked, GetTextReferralV1()) = 1 Then
                    SqlSaveOrUpdateRegistrationFormForReferal()
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, SAVE_TITLE)
                    DA_Consult.UpdateStatus(1, LblConsultID.Text)
                    isCloseOld = True
                    Me.Close()
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, ERROR_TITLE)
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, UPDATE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModOld_Outpatient.UpdateOldPatient(LblSaveOption.Text, _
                    TxtReceiptNo.Text, _
                    TxtPatientNo.Text, _
                    CboDiagnosis.Text, _
                    DiagnosisTem, _
                    Riel, _
                    Dolar, _
                    True, _
                    True, _
                    ChHearing.Checked, _
                    ChUnderstand.Checked, _
                    ChSeeing.Checked, _
                    ChPhysical.Checked, _
                    TxtOther.Text, DateFollowUp.Value, ChTypeOther.Checked) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, UPDATE_TITLE)
                    isCloseOld = True
                    Me.Close()
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, ERROR_TITLE)
                End If
            End If
        End If

    End Sub
    Sub InitChListReferral()
        With ChListReferral
            .Items.Clear()
            Dim TblReferral As DataTable = DA_Referral.GetData
            For Each DRow As DataRow In TblReferral.Rows
                .Items.Add(DRow("REFFERAL_NAME"))
            Next
        End With
    End Sub
    Function CheckStatusReferal() As Boolean
        For Each obj As Object In GrpReferal.Controls
            If TypeOf obj Is CheckBox Then
                Dim rd As CheckBox = CType(obj, CheckBox)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function
    Function GetTextReferralV1() As String
        Try
            Dim str As String = ""
            For i As Int16 = 0 To ChListReferral.Items.Count - 1
                If ChListReferral.GetItemChecked(i) = True Then
                    str = str & " + " & ChListReferral.Items(i).ToString
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Function SqlSaveOrUpdateRegistrationFormForReferal() As String
        Return Me.StringSaveReferal( _
               TxtPatientNo.Text, _
               DateFollowUp.Value, _
               ChHearing.Checked, _
               ChUnderstand.Checked, _
               ChSeeing.Checked, _
               ChPhysical.Checked, _
               ChCDMDP.Checked, _
               ChEyeScreenig.Checked, _
               ChScreeningKV.Checked, _
               ChSelf.Checked, _
               ChPatient.Checked, _
               ChFriend.Checked, _
               ChOtherNGO.Checked, _
               ChChurch.Checked, _
               ChHealth.Checked, _
               ChOtherReferal.Checked, _
               ChPreyKabasVC.Checked, _
               ChPreyScreening.Checked, _
               ChSchoolScreening.Checked, _
               ChMoPoCho.Checked, _
               GetTextReferralV1())
    End Function
    Function StringSaveReferal( _
                      ByVal PatientNo As String _
                     , ByVal CreateDate As String _
                     , ByVal Hearing As Boolean _
                     , ByVal Understand As Boolean _
                     , ByVal Seeing As Boolean _
                     , ByVal Physical As Boolean _
                     , ByVal CDMDPatient As Boolean _
                     , ByVal EyeScreeningTK As Boolean _
                     , ByVal ScreeningKV As Boolean _
                     , ByVal Self As Boolean _
                     , ByVal PatientReferal As Boolean _
                     , ByVal Friend_Relation As Boolean _
                     , ByVal OtherNGO As Boolean _
                     , ByVal Church As Boolean _
                     , ByVal HealthWorker As Boolean _
                     , ByVal OtherReferal As Boolean _
                     , ByVal PreyKabasVC As Boolean _
                     , ByVal PreyScreening As Boolean _
                     , ByVal SchoolScreening As Boolean _
                     , ByVal MoPoCho As Boolean _
                     , ByVal CombinRefferal As String) As String
        Dim sql As String = "INSERT INTO TblFollowUp " & _
                    "(PatientNo" & _
                    ",CreateDate" & _
                    ",Hearing" & _
                    ",Understand" & _
                    ",Seeing" & _
                    ",Physical" & _
                    ",CDMDPatient" & _
                    ",EyeSreening" & _
                    ",ScreeningKV" & _
                    ",Self" & _
                    ",PatientReferal" & _
                    ",Friend_Relation" & _
                    ",OtherNGO" & _
                    ",Church" & _
                    ",HealthWorker" & _
                    ",OtherReferal,PreyKabasVC,PreyScreening,SchoolScreening,MoPoCho,ComBindRefferal,FollowUpStatus)" & _
                    " VALUES " & _
                    "(" & PatientNo & _
                    ",'" & CreateDate & _
                    "','" & Hearing & _
                    "','" & Understand & _
                    "','" & Seeing & _
                    "','" & Physical & _
                    "','" & CDMDPatient & _
                    "','" & EyeScreeningTK & _
                    "','" & ScreeningKV & _
                    "','" & Self & _
                    "','" & PatientReferal & _
                    "','" & Friend_Relation & _
                    "','" & OtherNGO & _
                    "','" & Church & _
                    "','" & HealthWorker & _
                    "','" & OtherReferal & _
                    "','" & PreyKabasVC & _
                    "','" & PreyScreening & _
                    "','" & SchoolScreening & _
                    "','" & MoPoCho & _
                    "','" & CombinRefferal & _
                    "',1)"
        Return sql
    End Function
    Function GetTextReferral() As String
        Try
            Dim str As String
            For i As Int16 = 0 To GrpReferal.Controls.Count - 1
                Dim ch As CheckBox = CType(GrpReferal.Controls(i), CheckBox)
                If ch.Checked = True Then
                    str = str & " + " & ch.Text
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Private Sub CboCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCancel.Click
        isCloseOld = False
        Me.Close()
    End Sub

    Private Sub LblLoadData_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblLoadData.LinkClicked
        'LoadOldPatient()
    End Sub
    'Sub LoadOldPatient()
    '    Dim TblOldPatientReceipt As DataTable = ModOld_Outpatient.SelectOldReceiptNo(EmptyString(TxtReceiptNo.Text))
    '    Dim DRow As DataRow, money As Integer
    '    If TblOldPatientReceipt.Rows.Count > 0 Then
    '        For I As Integer = 0 To TblOldPatientReceipt.Rows.Count - 1
    '            DRow = TblOldPatientReceipt.Rows(I)
    '            TxtPatientNo.Text = DRow("PatientNo").ToString
    '            TxtPatientName.Text = DRow("NameEng").ToString
    '            TxtAge.Text = DRow("Age").ToString
    '            TxtSex.Text = DRow("Sex").ToString
    '            TxtAddress.Text = DRow("Address").ToString
    '            money = DRow("TotalRiel").ToString
    '        Next
    '    Else
    '        TxtPatientNo.Text = ""
    '        TxtPatientName.Text = ""
    '        TxtAge.Text = ""
    '        TxtSex.Text = ""
    '        TxtAddress.Text = ""
    '        TxtPatientFee.Text = ""
    '    End If
    'End Sub


    Private Sub TxtReceiptNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceiptNo.KeyDown, TxtPatientFee.KeyDown
        'LoadOldPatient()
    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress, TxtPatientFee.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub



    Private Sub CboDiagnosis_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDiagnosis.SelectedValueChanged
        Try
            ChTypeOther.Checked = ModDiagnosis.SelectDiagnosisTypeOther(CboDiagnosis.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FRMOld_Outpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitChListReferral()
        CheckIsPatientConsult(TxtPatientNo.Text, "Old Patient", 0)
    End Sub
    Public Function CheckIsPatientConsult(ByVal PatientNo As Double, ByVal ConsultFor As String, ByVal Status As Integer) As Boolean
        Dim DataTbl As DataTable = DA_Consult_Detail.GetDataByConsultFor(PatientNo, ConsultFor, Status)
        If DataTbl.Rows.Count = 1 Then
            For i As Integer = 0 To DataTbl.Rows.Count - 1
                ' MsgBox(DataTbl.Rows(i).Item("CONSULT_FOR"))
                LblConsultID.Text = DataTbl.Rows(i).Item("CONSULING_ID")
                LblConsultDate.Text = DataTbl.Rows(i).Item("CONSULING_DATE")
                LblConsultType.Text = DataTbl.Rows(i).Item("DONATE_TYPE")
                lblConsultFor.Text = DataTbl.Rows(i).Item("CONSULT_FOR")
                LblSendBy.Text = DataTbl.Rows(i).Item("APROVE_BY")
                TxtPatientFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                CboDiagnosis.Text = DataTbl.Rows(i).Item("DIAGNOSIS2")
            Next
            Return True
        Else
            Return False
        End If
    End Function

    
End Class