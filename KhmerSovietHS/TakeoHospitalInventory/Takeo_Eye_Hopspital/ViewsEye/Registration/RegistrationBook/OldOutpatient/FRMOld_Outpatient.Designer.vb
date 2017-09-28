<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMOld_Outpatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMOld_Outpatient))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblConsultID = New System.Windows.Forms.Label
        Me.LblSendBy = New System.Windows.Forms.Label
        Me.lblConsultFor = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblConsultDate = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblConsultType = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GrpReferal = New System.Windows.Forms.GroupBox
        Me.ChOtherReferal = New System.Windows.Forms.CheckBox
        Me.ChOtherNGO = New System.Windows.Forms.CheckBox
        Me.ChMoPoCho = New System.Windows.Forms.CheckBox
        Me.ChCDMDP = New System.Windows.Forms.CheckBox
        Me.ChSchoolScreening = New System.Windows.Forms.CheckBox
        Me.ChHealth = New System.Windows.Forms.CheckBox
        Me.ChChurch = New System.Windows.Forms.CheckBox
        Me.ChScreeningKV = New System.Windows.Forms.CheckBox
        Me.ChEyeScreenig = New System.Windows.Forms.CheckBox
        Me.ChPreyScreening = New System.Windows.Forms.CheckBox
        Me.ChPreyKabasVC = New System.Windows.Forms.CheckBox
        Me.ChFriend = New System.Windows.Forms.CheckBox
        Me.ChPatient = New System.Windows.Forms.CheckBox
        Me.ChSelf = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ChHearing = New System.Windows.Forms.CheckBox
        Me.ChPhysical = New System.Windows.Forms.CheckBox
        Me.ChUnderstand = New System.Windows.Forms.CheckBox
        Me.ChSeeing = New System.Windows.Forms.CheckBox
        Me.ChTypeOther = New System.Windows.Forms.CheckBox
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.RadioDolar = New System.Windows.Forms.RadioButton
        Me.RadioRiel = New System.Windows.Forms.RadioButton
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.TxtOther = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblLoadData = New System.Windows.Forms.LinkLabel
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.TxtPatientFee = New System.Windows.Forms.TextBox
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.TxtSex = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.Label
        Me.TxtPatientNo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrOldOutpatient = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GReferralFrom = New System.Windows.Forms.GroupBox
        Me.ChListReferral = New System.Windows.Forms.CheckedListBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrpReferal.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrOldOutpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GReferralFrom.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GrpReferal)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.ChTypeOther)
        Me.GroupBox1.Controls.Add(Me.DateFollowUp)
        Me.GroupBox1.Controls.Add(Me.RadioDolar)
        Me.GroupBox1.Controls.Add(Me.RadioRiel)
        Me.GroupBox1.Controls.Add(Me.CboDiagnosis)
        Me.GroupBox1.Controls.Add(Me.TxtOther)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.LblLoadData)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.TxtPatientFee)
        Me.GroupBox1.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.TxtSex)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtAddress)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 316)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblConsultID)
        Me.GroupBox2.Controls.Add(Me.LblSendBy)
        Me.GroupBox2.Controls.Add(Me.lblConsultFor)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.LblConsultDate)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LblConsultType)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(292, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 105)
        Me.GroupBox2.TabIndex = 205
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information From Consult"
        '
        'LblConsultID
        '
        Me.LblConsultID.AutoSize = True
        Me.LblConsultID.Location = New System.Drawing.Point(191, 17)
        Me.LblConsultID.Name = "LblConsultID"
        Me.LblConsultID.Size = New System.Drawing.Size(13, 13)
        Me.LblConsultID.TabIndex = 8
        Me.LblConsultID.Text = "0"
        Me.LblConsultID.Visible = False
        '
        'LblSendBy
        '
        Me.LblSendBy.AutoSize = True
        Me.LblSendBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSendBy.ForeColor = System.Drawing.Color.Red
        Me.LblSendBy.Location = New System.Drawing.Point(100, 108)
        Me.LblSendBy.Name = "LblSendBy"
        Me.LblSendBy.Size = New System.Drawing.Size(77, 17)
        Me.LblSendBy.TabIndex = 7
        Me.LblSendBy.Text = "No Consult"
        '
        'lblConsultFor
        '
        Me.lblConsultFor.AutoSize = True
        Me.lblConsultFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultFor.ForeColor = System.Drawing.Color.Red
        Me.lblConsultFor.Location = New System.Drawing.Point(100, 80)
        Me.lblConsultFor.Name = "lblConsultFor"
        Me.lblConsultFor.Size = New System.Drawing.Size(77, 17)
        Me.lblConsultFor.TabIndex = 6
        Me.lblConsultFor.Text = "No Consult"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(6, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 17)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Consult For:"
        '
        'LblConsultDate
        '
        Me.LblConsultDate.AutoSize = True
        Me.LblConsultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultDate.ForeColor = System.Drawing.Color.Red
        Me.LblConsultDate.Location = New System.Drawing.Point(100, 26)
        Me.LblConsultDate.Name = "LblConsultDate"
        Me.LblConsultDate.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultDate.TabIndex = 4
        Me.LblConsultDate.Text = "No Consult"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(6, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Date Consult:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(6, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Consult By:"
        '
        'LblConsultType
        '
        Me.LblConsultType.AutoSize = True
        Me.LblConsultType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultType.ForeColor = System.Drawing.Color.Red
        Me.LblConsultType.Location = New System.Drawing.Point(100, 53)
        Me.LblConsultType.Name = "LblConsultType"
        Me.LblConsultType.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultType.TabIndex = 1
        Me.LblConsultType.Text = "No Consult"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(6, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Consult Type:"
        '
        'GrpReferal
        '
        Me.GrpReferal.BackColor = System.Drawing.Color.Transparent
        Me.GrpReferal.Controls.Add(Me.ChOtherReferal)
        Me.GrpReferal.Controls.Add(Me.ChOtherNGO)
        Me.GrpReferal.Controls.Add(Me.ChMoPoCho)
        Me.GrpReferal.Controls.Add(Me.ChCDMDP)
        Me.GrpReferal.Controls.Add(Me.ChSchoolScreening)
        Me.GrpReferal.Controls.Add(Me.ChHealth)
        Me.GrpReferal.Controls.Add(Me.ChChurch)
        Me.GrpReferal.Controls.Add(Me.ChScreeningKV)
        Me.GrpReferal.Controls.Add(Me.ChEyeScreenig)
        Me.GrpReferal.Controls.Add(Me.ChPreyScreening)
        Me.GrpReferal.Controls.Add(Me.ChPreyKabasVC)
        Me.GrpReferal.Controls.Add(Me.ChFriend)
        Me.GrpReferal.Controls.Add(Me.ChPatient)
        Me.GrpReferal.Controls.Add(Me.ChSelf)
        Me.GrpReferal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpReferal.Location = New System.Drawing.Point(461, 316)
        Me.GrpReferal.Name = "GrpReferal"
        Me.GrpReferal.Size = New System.Drawing.Size(23, 26)
        Me.GrpReferal.TabIndex = 204
        Me.GrpReferal.TabStop = False
        Me.GrpReferal.Text = "Referal from:   "
        Me.GrpReferal.Visible = False
        '
        'ChOtherReferal
        '
        Me.ChOtherReferal.AutoSize = True
        Me.ChOtherReferal.Location = New System.Drawing.Point(352, 130)
        Me.ChOtherReferal.Name = "ChOtherReferal"
        Me.ChOtherReferal.Size = New System.Drawing.Size(68, 24)
        Me.ChOtherReferal.TabIndex = 194
        Me.ChOtherReferal.Text = "Other"
        Me.ChOtherReferal.UseVisualStyleBackColor = True
        '
        'ChOtherNGO
        '
        Me.ChOtherNGO.AutoSize = True
        Me.ChOtherNGO.Location = New System.Drawing.Point(352, 102)
        Me.ChOtherNGO.Name = "ChOtherNGO"
        Me.ChOtherNGO.Size = New System.Drawing.Size(116, 24)
        Me.ChOtherNGO.TabIndex = 194
        Me.ChOtherNGO.Text = "Other NGOs"
        Me.ChOtherNGO.UseVisualStyleBackColor = True
        '
        'ChMoPoCho
        '
        Me.ChMoPoCho.AutoSize = True
        Me.ChMoPoCho.Location = New System.Drawing.Point(352, 77)
        Me.ChMoPoCho.Name = "ChMoPoCho"
        Me.ChMoPoCho.Size = New System.Drawing.Size(110, 24)
        Me.ChMoPoCho.TabIndex = 194
        Me.ChMoPoCho.Text = "Mo.Po.Tsyo"
        Me.ChMoPoCho.UseVisualStyleBackColor = True
        '
        'ChCDMDP
        '
        Me.ChCDMDP.AutoSize = True
        Me.ChCDMDP.Location = New System.Drawing.Point(352, 50)
        Me.ChCDMDP.Name = "ChCDMDP"
        Me.ChCDMDP.Size = New System.Drawing.Size(76, 24)
        Me.ChCDMDP.TabIndex = 194
        Me.ChCDMDP.Text = "CDMD"
        Me.ChCDMDP.UseVisualStyleBackColor = True
        '
        'ChSchoolScreening
        '
        Me.ChSchoolScreening.AutoSize = True
        Me.ChSchoolScreening.Location = New System.Drawing.Point(190, 132)
        Me.ChSchoolScreening.Name = "ChSchoolScreening"
        Me.ChSchoolScreening.Size = New System.Drawing.Size(153, 24)
        Me.ChSchoolScreening.TabIndex = 194
        Me.ChSchoolScreening.Text = "School Screening"
        Me.ChSchoolScreening.UseVisualStyleBackColor = True
        '
        'ChHealth
        '
        Me.ChHealth.AutoSize = True
        Me.ChHealth.Location = New System.Drawing.Point(190, 102)
        Me.ChHealth.Name = "ChHealth"
        Me.ChHealth.Size = New System.Drawing.Size(130, 24)
        Me.ChHealth.TabIndex = 194
        Me.ChHealth.Text = "Health Worker"
        Me.ChHealth.UseVisualStyleBackColor = True
        '
        'ChChurch
        '
        Me.ChChurch.AutoSize = True
        Me.ChChurch.Location = New System.Drawing.Point(190, 76)
        Me.ChChurch.Name = "ChChurch"
        Me.ChChurch.Size = New System.Drawing.Size(109, 24)
        Me.ChChurch.TabIndex = 194
        Me.ChChurch.Text = "Kirivong VC"
        Me.ChChurch.UseVisualStyleBackColor = True
        '
        'ChScreeningKV
        '
        Me.ChScreeningKV.AutoSize = True
        Me.ChScreeningKV.Location = New System.Drawing.Point(190, 50)
        Me.ChScreeningKV.Name = "ChScreeningKV"
        Me.ChScreeningKV.Size = New System.Drawing.Size(152, 24)
        Me.ChScreeningKV.TabIndex = 194
        Me.ChScreeningKV.Text = "Screening By K-V"
        Me.ChScreeningKV.UseVisualStyleBackColor = True
        '
        'ChEyeScreenig
        '
        Me.ChEyeScreenig.AutoSize = True
        Me.ChEyeScreenig.Location = New System.Drawing.Point(190, 21)
        Me.ChEyeScreenig.Name = "ChEyeScreenig"
        Me.ChEyeScreenig.Size = New System.Drawing.Size(150, 24)
        Me.ChEyeScreenig.TabIndex = 194
        Me.ChEyeScreenig.Text = "Screening By T-K"
        Me.ChEyeScreenig.UseVisualStyleBackColor = True
        '
        'ChPreyScreening
        '
        Me.ChPreyScreening.AutoSize = True
        Me.ChPreyScreening.Location = New System.Drawing.Point(9, 132)
        Me.ChPreyScreening.Name = "ChPreyScreening"
        Me.ChPreyScreening.Size = New System.Drawing.Size(184, 24)
        Me.ChPreyScreening.TabIndex = 194
        Me.ChPreyScreening.Text = "Prey Kabas Screening"
        Me.ChPreyScreening.UseVisualStyleBackColor = True
        '
        'ChPreyKabasVC
        '
        Me.ChPreyKabasVC.AutoSize = True
        Me.ChPreyKabasVC.Location = New System.Drawing.Point(9, 102)
        Me.ChPreyKabasVC.Name = "ChPreyKabasVC"
        Me.ChPreyKabasVC.Size = New System.Drawing.Size(134, 24)
        Me.ChPreyKabasVC.TabIndex = 194
        Me.ChPreyKabasVC.Text = "Prey Kabas VC"
        Me.ChPreyKabasVC.UseVisualStyleBackColor = True
        '
        'ChFriend
        '
        Me.ChFriend.AutoSize = True
        Me.ChFriend.Location = New System.Drawing.Point(9, 78)
        Me.ChFriend.Name = "ChFriend"
        Me.ChFriend.Size = New System.Drawing.Size(138, 24)
        Me.ChFriend.TabIndex = 194
        Me.ChFriend.Text = "Friend /Relative"
        Me.ChFriend.UseVisualStyleBackColor = True
        '
        'ChPatient
        '
        Me.ChPatient.AutoSize = True
        Me.ChPatient.Location = New System.Drawing.Point(9, 48)
        Me.ChPatient.Name = "ChPatient"
        Me.ChPatient.Size = New System.Drawing.Size(78, 24)
        Me.ChPatient.TabIndex = 194
        Me.ChPatient.Text = "Patient"
        Me.ChPatient.UseVisualStyleBackColor = True
        '
        'ChSelf
        '
        Me.ChSelf.AutoSize = True
        Me.ChSelf.Location = New System.Drawing.Point(9, 21)
        Me.ChSelf.Name = "ChSelf"
        Me.ChSelf.Size = New System.Drawing.Size(56, 24)
        Me.ChSelf.TabIndex = 194
        Me.ChSelf.Text = "Self"
        Me.ChSelf.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.ChHearing)
        Me.GroupBox5.Controls.Add(Me.ChPhysical)
        Me.GroupBox5.Controls.Add(Me.ChUnderstand)
        Me.GroupBox5.Controls.Add(Me.ChSeeing)
        Me.GroupBox5.Location = New System.Drawing.Point(292, 131)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(219, 94)
        Me.GroupBox5.TabIndex = 203
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Difficulty"
        '
        'ChHearing
        '
        Me.ChHearing.AutoSize = True
        Me.ChHearing.Location = New System.Drawing.Point(15, 19)
        Me.ChHearing.Name = "ChHearing"
        Me.ChHearing.Size = New System.Drawing.Size(63, 17)
        Me.ChHearing.TabIndex = 0
        Me.ChHearing.Text = "Hearing"
        Me.ChHearing.UseVisualStyleBackColor = True
        '
        'ChPhysical
        '
        Me.ChPhysical.AutoSize = True
        Me.ChPhysical.Location = New System.Drawing.Point(15, 71)
        Me.ChPhysical.Name = "ChPhysical"
        Me.ChPhysical.Size = New System.Drawing.Size(107, 17)
        Me.ChPhysical.TabIndex = 3
        Me.ChPhysical.Text = "Physical disability"
        Me.ChPhysical.UseVisualStyleBackColor = True
        '
        'ChUnderstand
        '
        Me.ChUnderstand.AutoSize = True
        Me.ChUnderstand.Location = New System.Drawing.Point(15, 44)
        Me.ChUnderstand.Name = "ChUnderstand"
        Me.ChUnderstand.Size = New System.Drawing.Size(180, 17)
        Me.ChUnderstand.TabIndex = 1
        Me.ChUnderstand.Text = "Uderstand / Intellectual / Mental"
        Me.ChUnderstand.UseVisualStyleBackColor = True
        '
        'ChSeeing
        '
        Me.ChSeeing.AutoSize = True
        Me.ChSeeing.Location = New System.Drawing.Point(40, 132)
        Me.ChSeeing.Name = "ChSeeing"
        Me.ChSeeing.Size = New System.Drawing.Size(59, 17)
        Me.ChSeeing.TabIndex = 2
        Me.ChSeeing.Text = "Seeing"
        Me.ChSeeing.UseVisualStyleBackColor = True
        '
        'ChTypeOther
        '
        Me.ChTypeOther.AutoSize = True
        Me.ChTypeOther.Location = New System.Drawing.Point(376, 326)
        Me.ChTypeOther.Name = "ChTypeOther"
        Me.ChTypeOther.Size = New System.Drawing.Size(79, 17)
        Me.ChTypeOther.TabIndex = 15
        Me.ChTypeOther.Text = "Type Other"
        Me.ChTypeOther.UseVisualStyleBackColor = True
        Me.ChTypeOther.Visible = False
        '
        'DateFollowUp
        '
        Me.DateFollowUp.Checked = False
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(95, 29)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.ShowCheckBox = True
        Me.DateFollowUp.Size = New System.Drawing.Size(127, 26)
        Me.DateFollowUp.TabIndex = 0
        '
        'RadioDolar
        '
        Me.RadioDolar.AutoSize = True
        Me.RadioDolar.Location = New System.Drawing.Point(334, 286)
        Me.RadioDolar.Name = "RadioDolar"
        Me.RadioDolar.Size = New System.Drawing.Size(31, 17)
        Me.RadioDolar.TabIndex = 14
        Me.RadioDolar.Text = "$"
        Me.RadioDolar.UseVisualStyleBackColor = True
        '
        'RadioRiel
        '
        Me.RadioRiel.AutoSize = True
        Me.RadioRiel.Checked = True
        Me.RadioRiel.Location = New System.Drawing.Point(285, 284)
        Me.RadioRiel.Name = "RadioRiel"
        Me.RadioRiel.Size = New System.Drawing.Size(43, 17)
        Me.RadioRiel.TabIndex = 13
        Me.RadioRiel.TabStop = True
        Me.RadioRiel.Text = "Riel"
        Me.RadioRiel.UseVisualStyleBackColor = True
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(75, 240)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(204, 28)
        Me.CboDiagnosis.TabIndex = 8
        '
        'TxtOther
        '
        Me.TxtOther.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtOther.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOther.FormattingEnabled = True
        Me.TxtOther.Location = New System.Drawing.Point(75, 318)
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(38, 28)
        Me.TxtOther.TabIndex = 9
        Me.TxtOther.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Diagnosis:"
        '
        'LblLoadData
        '
        Me.LblLoadData.AutoSize = True
        Me.LblLoadData.Location = New System.Drawing.Point(255, 39)
        Me.LblLoadData.Name = "LblLoadData"
        Me.LblLoadData.Size = New System.Drawing.Size(31, 13)
        Me.LblLoadData.TabIndex = 6
        Me.LblLoadData.TabStop = True
        Me.LblLoadData.Text = "Load"
        Me.LblLoadData.Visible = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(236, 29)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 5
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'TxtPatientFee
        '
        Me.TxtPatientFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientFee.Location = New System.Drawing.Point(75, 277)
        Me.TxtPatientFee.Name = "TxtPatientFee"
        Me.TxtPatientFee.Size = New System.Drawing.Size(204, 26)
        Me.TxtPatientFee.TabIndex = 7
        Me.TxtPatientFee.Text = "0"
        Me.TxtPatientFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(95, 62)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(184, 26)
        Me.TxtReceiptNo.TabIndex = 1
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.Location = New System.Drawing.Point(229, 171)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.Size = New System.Drawing.Size(50, 23)
        Me.TxtSex.TabIndex = 5
        Me.TxtSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 329)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Other"
        Me.Label15.Visible = False
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(138, 171)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(50, 23)
        Me.TxtAge.TabIndex = 4
        Me.TxtAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(12, 197)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(267, 28)
        Me.TxtAddress.TabIndex = 6
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(95, 129)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(184, 34)
        Me.TxtPatientName.TabIndex = 3
        Me.TxtPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(95, 98)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(184, 23)
        Me.TxtPatientNo.TabIndex = 2
        Me.TxtPatientNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Patient Fee:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sex:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name of patient:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Receipt No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No:"
        '
        'CboCancel
        '
        Me.CboCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboCancel.Location = New System.Drawing.Point(379, 327)
        Me.CboCancel.Name = "CboCancel"
        Me.CboCancel.Size = New System.Drawing.Size(75, 35)
        Me.CboCancel.TabIndex = 2
        Me.CboCancel.Text = "&Cancel"
        Me.CboCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(299, 327)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 35)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrOldOutpatient
        '
        Me.ErrOldOutpatient.ContainerControl = Me
        '
        'GReferralFrom
        '
        Me.GReferralFrom.Controls.Add(Me.ChListReferral)
        Me.GReferralFrom.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GReferralFrom.Location = New System.Drawing.Point(543, -7)
        Me.GReferralFrom.Name = "GReferralFrom"
        Me.GReferralFrom.Size = New System.Drawing.Size(208, 327)
        Me.GReferralFrom.TabIndex = 205
        Me.GReferralFrom.TabStop = False
        Me.GReferralFrom.Text = "Referral From:"
        '
        'ChListReferral
        '
        Me.ChListReferral.BackColor = System.Drawing.SystemColors.Control
        Me.ChListReferral.CheckOnClick = True
        Me.ChListReferral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChListReferral.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChListReferral.FormattingEnabled = True
        Me.ChListReferral.HorizontalScrollbar = True
        Me.ChListReferral.Location = New System.Drawing.Point(3, 36)
        Me.ChListReferral.Name = "ChListReferral"
        Me.ChListReferral.ScrollAlwaysVisible = True
        Me.ChListReferral.Size = New System.Drawing.Size(202, 284)
        Me.ChListReferral.TabIndex = 194
        '
        'FRMOld_Outpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 367)
        Me.Controls.Add(Me.GReferralFrom)
        Me.Controls.Add(Me.CboCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMOld_Outpatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OLD PATIENT BOOK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrpReferal.ResumeLayout(False)
        Me.GrpReferal.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrOldOutpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GReferralFrom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSex As System.Windows.Forms.Label
    Friend WithEvents TxtAge As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrOldOutpatient As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblLoadData As System.Windows.Forms.LinkLabel
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientFee As System.Windows.Forms.TextBox
    Friend WithEvents TxtOther As System.Windows.Forms.ComboBox
    Friend WithEvents RadioDolar As System.Windows.Forms.RadioButton
    Friend WithEvents RadioRiel As System.Windows.Forms.RadioButton
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChTypeOther As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ChHearing As System.Windows.Forms.CheckBox
    Friend WithEvents ChPhysical As System.Windows.Forms.CheckBox
    Friend WithEvents ChUnderstand As System.Windows.Forms.CheckBox
    Friend WithEvents ChSeeing As System.Windows.Forms.CheckBox
    Friend WithEvents GReferralFrom As System.Windows.Forms.GroupBox
    Friend WithEvents ChListReferral As System.Windows.Forms.CheckedListBox
    Friend WithEvents GrpReferal As System.Windows.Forms.GroupBox
    Friend WithEvents ChOtherReferal As System.Windows.Forms.CheckBox
    Friend WithEvents ChOtherNGO As System.Windows.Forms.CheckBox
    Friend WithEvents ChMoPoCho As System.Windows.Forms.CheckBox
    Friend WithEvents ChCDMDP As System.Windows.Forms.CheckBox
    Friend WithEvents ChSchoolScreening As System.Windows.Forms.CheckBox
    Friend WithEvents ChHealth As System.Windows.Forms.CheckBox
    Friend WithEvents ChChurch As System.Windows.Forms.CheckBox
    Friend WithEvents ChScreeningKV As System.Windows.Forms.CheckBox
    Friend WithEvents ChEyeScreenig As System.Windows.Forms.CheckBox
    Friend WithEvents ChPreyScreening As System.Windows.Forms.CheckBox
    Friend WithEvents ChPreyKabasVC As System.Windows.Forms.CheckBox
    Friend WithEvents ChFriend As System.Windows.Forms.CheckBox
    Friend WithEvents ChPatient As System.Windows.Forms.CheckBox
    Friend WithEvents ChSelf As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblConsultType As System.Windows.Forms.Label
    Friend WithEvents LblSendBy As System.Windows.Forms.Label
    Friend WithEvents lblConsultFor As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblConsultDate As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblConsultID As System.Windows.Forms.Label
End Class
