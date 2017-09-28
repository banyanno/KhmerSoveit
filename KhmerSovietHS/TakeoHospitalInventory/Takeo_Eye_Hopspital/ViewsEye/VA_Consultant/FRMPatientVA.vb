Public Class FRMPatientVA
    Public isClose As Boolean = False
    Dim mainVA As UCMainVA
    Dim OrderPlain As Integer = 1
    Dim OrderPh As Integer = 1
    Dim OrderGlases As Int16 = 1
    Sub New(ByVal va As UCMainVA)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.mainVA = va
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
  
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim firstTime As Boolean = False
        If ModV_A.CheckPatientVA(EmptyString(TxtPatientNo.Text)) > 0 Then
            firstTime = True
        End If
        If TxtPatientNo.Text = "" Then
            MsgBox("Please enter patient No.", MsgBoxStyle.Critical, "Error")
            TxtPatientNo.Focus()
            Exit Sub
        End If
        If TxtKhName.Text = "" Then
            MsgBox("Please enter Patient Name.", MsgBoxStyle.Critical, "Error")
            TxtPatientNo.Focus()
            Exit Sub
        End If
       
        If LblSaveOption.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                '============== Check for Plain eye ===================
                If lblPlainEye.Text = VA_NORMAL Then
                    OrderPlain = 1
                End If
                If lblPlainEye.Text = VA_VISUAL_IMPAIRMENT Then
                    OrderPlain = 2
                End If
                If lblPlainEye.Text = VA_SEVERE_VISUAL_IMPAIRMENT Then
                    OrderPlain = 3
                End If
                If lblPlainEye.Text = VA_BLIND Then
                    OrderPlain = 4
                End If
                '============ PH ==================
                If LblPhEye.Text = VA_NORMAL Then
                    OrderPh = 1
                End If
                If LblPhEye.Text = VA_VISUAL_IMPAIRMENT Then
                    OrderPh = 2
                End If
                If LblPhEye.Text = VA_SEVERE_VISUAL_IMPAIRMENT Then
                    OrderPh = 3
                End If
                If LblPhEye.Text = VA_BLIND Then
                    OrderPh = 4
                End If
                '=============== Glass ==================
                If LblGlassesEye.Text = VA_NORMAL Then
                    OrderGlases = 1
                End If
                If LblGlassesEye.Text = VA_VISUAL_IMPAIRMENT Then
                    OrderGlases = 2
                End If
                If LblGlassesEye.Text = VA_SEVERE_VISUAL_IMPAIRMENT Then
                    OrderGlases = 3
                End If
                If LblGlassesEye.Text = VA_BLIND Then
                    OrderGlases = 4
                End If
                If ModV_A.NewMainVAPatient(TxtPatientNo.Text, _
                lblPlainEye.Text, _
                LblPhEye.Text, _
                LblGlassesEye.Text, _
                DateVA.Value, OrderPlain, OrderPh, OrderGlases) = 1 _
                And _
                ModV_A.NewPatientVALeftRight("TblVALeft", TxtPatientNo.Text, _
                TrackPlainLeftEye.Value, LblPlainLeft.Text, _
                lblCatPlainLeft.Text, TrackPHLeftEye.Value, _
                LblPhLeft.Text, LblCatPHLeft.Text, _
                TrackGlassesLeftEye.Value, LblGlassesLeft.Text, _
                LblCatGlassesLeft.Text, DateVA.Value, firstTime) = 1 _
                And _
                ModV_A.NewPatientVALeftRight("TblVARight", TxtPatientNo.Text, _
                TrackPlainRightEye.Value, LblPlainRight.Text, _
                lblCatPlainRight.Text, TrackPHRightEye.Value, _
                LblPHRight.Text, LblCatPHRight.Text, _
                TrackGlassesRightEye.Value, LblGlassesRight.Text, _
                LblCatGlassesRight.Text, DateVA.Value, firstTime) = 1 _
                Then
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                    isClose = True
                    Me.Close()
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModV_A.UpdateVA(LblSaveOption.Text, lblPlainEye.Text, LblPhEye.Text, LblGlassesEye.Text) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    isClose = True
                    Me.Close()
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.isClose = False
        Me.Close()
    End Sub
    Sub ClearForm()
        TxtPatientNo.Text = ""
        TxtKhName.Text = ""
        TxtEngName.Text = ""
        TxtSex.Text = ""
        TxtAge.Text = ""
        TxtAddress.Text = ""
        TrackPlainLeftEye.Value = 0
        TrackPHLeftEye.Value = 0
        TrackGlassesLeftEye.Value = 0
        LblPlainLeft.Text = "0"
        LblPhLeft.Text = "0"
        LblGlassesLeft.Text = "0"
        lblCatPlainLeft.Text = ""
        LblCatPHLeft.Text = ""
        LblCatGlassesLeft.Text = ""
    End Sub
    Sub LoadPatientInfo(ByVal PatientNO As String)
        Dim TblPatient As DataTable = ModRegistration.GetPatientByNo(EmptyString(PatientNO))
        Dim DRow As DataRow
        If TblPatient.Rows.Count > 0 Then
            For i As Integer = 0 To TblPatient.Rows.Count - 1
                DRow = TblPatient.Rows(i)
                'TxtPatientNo.Text = DRow("PatientNo").ToString
                TxtEngName.Text = DRow("NameEng").ToString
                TxtKhName.Text = DRow("NameKhmer").ToString
                TxtAge.Text = DRow("Age").ToString
                TxtSex.Text = DRow("Sex").ToString
                TxtAddress.Text = DRow("Address").ToString
            Next
        Else
            MsgBox("Patient No does not exist in system.", MsgBoxStyle.Critical, "Error")
            TxtEngName.Text = ""
            TxtKhName.Text = ""
            TxtAge.Text = ""
            TxtSex.Text = ""
            TxtAddress.Text = ""
            TxtPatientNo.Focus()
        End If
    End Sub

    Private Sub TrackPlain_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackPlainLeftEye.Scroll
        CreateVA(TrackPlainLeftEye, LblPlainLeft, lblCatPlainLeft)
        CompareVALeftRight(lblCatPlainLeft, lblCatPlainRight, lblPlainEye)
    End Sub

    Private Shared VA_NORMAL = "NORMAL"
    Private Shared VA_VISUAL_IMPAIRMENT = "VISUAL IMPAIRMENT"
    Private Shared VA_SEVERE_VISUAL_IMPAIRMENT = "SEVERE VISUAL IMPAIRMENT"
    Private Shared VA_BLIND = "BLIND"

    Sub CompareVALeftRight(ByVal Left As Label, ByVal Right As Label, ByVal Left_Right As Label)
        ' Case Left Eye Nomal with Righ eye
        If Left.Text = VA_NORMAL And Right.Text = VA_VISUAL_IMPAIRMENT Then
            Left_Right.Text = VA_NORMAL
        End If
        If Left.Text = VA_NORMAL And Right.Text = VA_SEVERE_VISUAL_IMPAIRMENT Then
            Left_Right.Text = VA_NORMAL
        End If
        If Left.Text = VA_NORMAL And Right.Text = VA_BLIND Then
            Left_Right.Text = VA_NORMAL
        End If

        ' Case Left Eye VISUAL IMPAIRMENT with Righ eye
        If Left.Text = VA_VISUAL_IMPAIRMENT And Right.Text = VA_NORMAL Then
            Left_Right.Text = VA_NORMAL
        End If
        If Left.Text = VA_SEVERE_VISUAL_IMPAIRMENT And Right.Text = VA_NORMAL Then
            Left_Right.Text = VA_NORMAL
        End If
        If Left.Text = VA_BLIND And Right.Text = VA_NORMAL Then
            Left_Right.Text = VA_NORMAL
        End If


        If Left.Text = VA_VISUAL_IMPAIRMENT And Right.Text = VA_VISUAL_IMPAIRMENT Then
            Left_Right.Text = VA_VISUAL_IMPAIRMENT
        End If
        If Left.Text = VA_SEVERE_VISUAL_IMPAIRMENT And Right.Text = VA_SEVERE_VISUAL_IMPAIRMENT Then
            Left_Right.Text = VA_SEVERE_VISUAL_IMPAIRMENT
        End If
        If Left.Text = VA_BLIND And Right.Text = VA_BLIND Then
            Left_Right.Text = VA_BLIND
        End If

        If Left.Text = VA_VISUAL_IMPAIRMENT And Right.Text = VA_SEVERE_VISUAL_IMPAIRMENT Then
            Left_Right.Text = VA_VISUAL_IMPAIRMENT
        End If
        If Left.Text = VA_SEVERE_VISUAL_IMPAIRMENT And Right.Text = VA_VISUAL_IMPAIRMENT Then
            Left_Right.Text = VA_VISUAL_IMPAIRMENT
        End If
        If Left.Text = VA_BLIND And Right.Text = VA_SEVERE_VISUAL_IMPAIRMENT Then
            Left_Right.Text = VA_SEVERE_VISUAL_IMPAIRMENT
        End If
        If Left.Text = VA_SEVERE_VISUAL_IMPAIRMENT And Right.Text = VA_BLIND Then
            Left_Right.Text = VA_SEVERE_VISUAL_IMPAIRMENT
        End If

    End Sub
    Sub CreateVA(ByVal ObjTrackBar As TrackBar, ByVal lbl As Label, ByVal lblCategory As Label)
        If ObjTrackBar.Value = 0 Then
            lbl.Text = "6/5"
            lblCategory.Text = VA_NORMAL
        ElseIf ObjTrackBar.Value = 1 Then
            lbl.Text = "6/5"
            lblCategory.Text = VA_NORMAL
        ElseIf ObjTrackBar.Value = 2 Then
            lbl.Text = "6/6"
            lblCategory.Text = VA_NORMAL
        ElseIf ObjTrackBar.Value = 3 Then
            lbl.Text = "6/9"
            lblCategory.Text = VA_NORMAL
        ElseIf ObjTrackBar.Value = 4 Then
            lbl.Text = "6/12"
            lblCategory.Text = VA_NORMAL
        ElseIf ObjTrackBar.Value = 5 Then
            lbl.Text = "6/18"
            lblCategory.Text = VA_NORMAL
        ElseIf ObjTrackBar.Value = 6 Then
            lbl.Text = "6/24"
            lblCategory.Text = VA_VISUAL_IMPAIRMENT
        ElseIf ObjTrackBar.Value = 7 Then
            lbl.Text = "6/36"
            lblCategory.Text = VA_VISUAL_IMPAIRMENT
        ElseIf ObjTrackBar.Value = 8 Then
            lbl.Text = "6/60"
            lblCategory.Text = VA_VISUAL_IMPAIRMENT
        ElseIf ObjTrackBar.Value = 9 Then
            lbl.Text = "3/60"
            lblCategory.Text = VA_SEVERE_VISUAL_IMPAIRMENT
        ElseIf ObjTrackBar.Value = 10 Then
            lbl.Text = "6/120"
            lblCategory.Text = VA_BLIND
        ElseIf ObjTrackBar.Value = 11 Then
            lbl.Text = "1/60"
            lblCategory.Text = VA_BLIND
        ElseIf ObjTrackBar.Value = 12 Then
            lbl.Text = "CF"
            lblCategory.Text = VA_BLIND
        ElseIf ObjTrackBar.Value = 13 Then
            lbl.Text = "HM"
            lblCategory.Text = VA_BLIND
        ElseIf ObjTrackBar.Value = 14 Then
            lbl.Text = "LP : PL"
            lblCategory.Text = VA_BLIND
        ElseIf ObjTrackBar.Value = 15 Then
            lbl.Text = "N.P.L"
            lblCategory.Text = VA_BLIND
        Else
            lbl.Text = "0"
            lblCategory.Text = ""
        End If
    End Sub

    Private Sub TrackPH_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackPHLeftEye.Scroll
        CreateVA(TrackPHLeftEye, LblPhLeft, LblCatPHLeft)
        CompareVALeftRight(LblCatPHLeft, LblCatPHRight, LblPhEye)
    End Sub

    Private Sub TrackGlasses_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackGlassesLeftEye.Scroll
        CreateVA(TrackGlassesLeftEye, LblGlassesLeft, LblCatGlassesLeft)
        CompareVALeftRight(LblCatGlassesLeft, LblCatGlassesRight, LblGlassesEye)
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoadPatientInfo(TxtPatientNo.Text)
    End Sub

    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadPatientInfo(TxtPatientNo.Text)
        End If
    End Sub

    Private Sub TrackPlainRightEye_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackPlainRightEye.Scroll
        CreateVA(TrackPlainRightEye, LblPlainRight, lblCatPlainRight)
        CompareVALeftRight(lblCatPlainLeft, lblCatPlainRight, lblPlainEye)
    End Sub

    Private Sub TrackPHRightEye_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackPHRightEye.Scroll
        CreateVA(TrackPHRightEye, LblPHRight, LblCatPHRight)
        CompareVALeftRight(LblCatPHLeft, LblCatPHRight, LblPhEye)
    End Sub

    Private Sub TrackGlassesRightEye_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackGlassesRightEye.Scroll
        CreateVA(TrackGlassesRightEye, LblGlassesRight, LblCatGlassesRight)
        CompareVALeftRight(LblCatGlassesLeft, LblCatGlassesRight, LblGlassesEye)
    End Sub
    Public Sub CallScroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TrackPlainRightEye_Scroll(sender, e)
        TrackPHRightEye_Scroll(sender, e)
        TrackGlassesRightEye_Scroll(sender, e)
        TrackPlain_Scroll(sender, e)
        TrackPH_Scroll(sender, e)
        TrackGlasses_Scroll(sender, e)
    End Sub


  
End Class