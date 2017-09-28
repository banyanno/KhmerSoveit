<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIntravitrealInjection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIntravitrealInjection))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LblOpNumber = New System.Windows.Forms.Label
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.DIAGNOSIS = New System.Windows.Forms.ComboBox
        Me.START_TIME = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PATIENT_AGE = New System.Windows.Forms.TextBox
        Me.PATIENT_SEX = New System.Windows.Forms.TextBox
        Me.PATIENT_NAME = New System.Windows.Forms.TextBox
        Me.PATIENT_NO = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.SURGEON_SIGNATURE = New System.Windows.Forms.ComboBox
        Me.ANESTHESIONLOGIST = New System.Windows.Forms.ComboBox
        Me.CIRCULATING = New System.Windows.Forms.ComboBox
        Me.SCRUB = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.NOTE = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.NO_COMPLICATION = New System.Windows.Forms.CheckBox
        Me.PATH = New System.Windows.Forms.CheckBox
        Me.MAXITROL_EYE_OITMENT = New System.Windows.Forms.CheckBox
        Me.VIGAMO_TROPICAL_NOTE = New System.Windows.Forms.TextBox
        Me.VIGAMOX_TROPICAL = New System.Windows.Forms.CheckBox
        Me.POLY_OPH_TROPICAL = New System.Windows.Forms.CheckBox
        Me.NEO_SYNEPHRINE = New System.Windows.Forms.CheckBox
        Me.ALPHAGAM = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.INTRA_LUCENTIS_DOSE = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.INTRA_AVASTIN_DOSE = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.INTRA_TRIAM_DOSE = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.INTRA_LUCENTIS = New System.Windows.Forms.CheckBox
        Me.INTRA_AVASTIN = New System.Windows.Forms.CheckBox
        Me.INTRA_TRIAMCINOLONE = New System.Windows.Forms.CheckBox
        Me.PATIENT_FULL = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.FULL_PRE_OP = New System.Windows.Forms.CheckBox
        Me.AN_SUBCONJUNCTIVAL = New System.Windows.Forms.CheckBox
        Me.AN_TOPICAL = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LUCENTIS = New System.Windows.Forms.CheckBox
        Me.AVASTIN = New System.Windows.Forms.CheckBox
        Me.IVTA = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrInjection = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrInjection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblOpNumber)
        Me.Panel1.Controls.Add(Me.LblSaveOption)
        Me.Panel1.Controls.Add(Me.DIAGNOSIS)
        Me.Panel1.Controls.Add(Me.START_TIME)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.SURGEON_SIGNATURE)
        Me.Panel1.Controls.Add(Me.ANESTHESIONLOGIST)
        Me.Panel1.Controls.Add(Me.CIRCULATING)
        Me.Panel1.Controls.Add(Me.SCRUB)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.NOTE)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.NO_COMPLICATION)
        Me.Panel1.Controls.Add(Me.PATH)
        Me.Panel1.Controls.Add(Me.MAXITROL_EYE_OITMENT)
        Me.Panel1.Controls.Add(Me.VIGAMO_TROPICAL_NOTE)
        Me.Panel1.Controls.Add(Me.VIGAMOX_TROPICAL)
        Me.Panel1.Controls.Add(Me.POLY_OPH_TROPICAL)
        Me.Panel1.Controls.Add(Me.NEO_SYNEPHRINE)
        Me.Panel1.Controls.Add(Me.ALPHAGAM)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.INTRA_LUCENTIS_DOSE)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.INTRA_AVASTIN_DOSE)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.INTRA_TRIAM_DOSE)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.INTRA_LUCENTIS)
        Me.Panel1.Controls.Add(Me.INTRA_AVASTIN)
        Me.Panel1.Controls.Add(Me.INTRA_TRIAMCINOLONE)
        Me.Panel1.Controls.Add(Me.PATIENT_FULL)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.FULL_PRE_OP)
        Me.Panel1.Controls.Add(Me.AN_SUBCONJUNCTIVAL)
        Me.Panel1.Controls.Add(Me.AN_TOPICAL)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LUCENTIS)
        Me.Panel1.Controls.Add(Me.AVASTIN)
        Me.Panel1.Controls.Add(Me.IVTA)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1382, 1054)
        Me.Panel1.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(114, 943)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(93, 34)
        Me.BtnCancel.TabIndex = 50
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(14, 943)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 34)
        Me.BtnSave.TabIndex = 49
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.INJECTION
        Me.PictureBox1.Location = New System.Drawing.Point(80, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'LblOpNumber
        '
        Me.LblOpNumber.AutoSize = True
        Me.LblOpNumber.Location = New System.Drawing.Point(41, 245)
        Me.LblOpNumber.Name = "LblOpNumber"
        Me.LblOpNumber.Size = New System.Drawing.Size(18, 20)
        Me.LblOpNumber.TabIndex = 47
        Me.LblOpNumber.Text = "0"
        Me.LblOpNumber.Visible = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(6, 245)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 46
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'DIAGNOSIS
        '
        Me.DIAGNOSIS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DIAGNOSIS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DIAGNOSIS.FormattingEnabled = True
        Me.DIAGNOSIS.Location = New System.Drawing.Point(105, 125)
        Me.DIAGNOSIS.Name = "DIAGNOSIS"
        Me.DIAGNOSIS.Size = New System.Drawing.Size(307, 28)
        Me.DIAGNOSIS.TabIndex = 45
        '
        'START_TIME
        '
        Me.START_TIME.Checked = False
        Me.START_TIME.CustomFormat = "ddd-MMM-yyyy HH:mm"
        Me.START_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.START_TIME.Location = New System.Drawing.Point(764, 88)
        Me.START_TIME.Name = "START_TIME"
        Me.START_TIME.ShowCheckBox = True
        Me.START_TIME.Size = New System.Drawing.Size(279, 26)
        Me.START_TIME.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PATIENT_AGE)
        Me.GroupBox1.Controls.Add(Me.PATIENT_SEX)
        Me.GroupBox1.Controls.Add(Me.PATIENT_NAME)
        Me.GroupBox1.Controls.Add(Me.PATIENT_NO)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(1063, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 157)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'PATIENT_AGE
        '
        Me.PATIENT_AGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PATIENT_AGE.Location = New System.Drawing.Point(299, 113)
        Me.PATIENT_AGE.Name = "PATIENT_AGE"
        Me.PATIENT_AGE.ReadOnly = True
        Me.PATIENT_AGE.Size = New System.Drawing.Size(64, 26)
        Me.PATIENT_AGE.TabIndex = 3
        Me.PATIENT_AGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PATIENT_SEX
        '
        Me.PATIENT_SEX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PATIENT_SEX.Location = New System.Drawing.Point(178, 113)
        Me.PATIENT_SEX.Name = "PATIENT_SEX"
        Me.PATIENT_SEX.ReadOnly = True
        Me.PATIENT_SEX.Size = New System.Drawing.Size(63, 26)
        Me.PATIENT_SEX.TabIndex = 2
        Me.PATIENT_SEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PATIENT_NAME
        '
        Me.PATIENT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PATIENT_NAME.Location = New System.Drawing.Point(130, 77)
        Me.PATIENT_NAME.Name = "PATIENT_NAME"
        Me.PATIENT_NAME.ReadOnly = True
        Me.PATIENT_NAME.Size = New System.Drawing.Size(247, 26)
        Me.PATIENT_NAME.TabIndex = 1
        '
        'PATIENT_NO
        '
        Me.PATIENT_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PATIENT_NO.Location = New System.Drawing.Point(130, 37)
        Me.PATIENT_NO.Name = "PATIENT_NO"
        Me.PATIENT_NO.ReadOnly = True
        Me.PATIENT_NO.Size = New System.Drawing.Size(247, 26)
        Me.PATIENT_NO.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(252, 119)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 20)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "Age:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(137, 119)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 20)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Sex:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 20)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Patient Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 20)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Patient No:"
        '
        'SURGEON_SIGNATURE
        '
        Me.SURGEON_SIGNATURE.FormattingEnabled = True
        Me.SURGEON_SIGNATURE.Location = New System.Drawing.Point(860, 882)
        Me.SURGEON_SIGNATURE.Name = "SURGEON_SIGNATURE"
        Me.SURGEON_SIGNATURE.Size = New System.Drawing.Size(215, 28)
        Me.SURGEON_SIGNATURE.TabIndex = 42
        '
        'ANESTHESIONLOGIST
        '
        Me.ANESTHESIONLOGIST.FormattingEnabled = True
        Me.ANESTHESIONLOGIST.Location = New System.Drawing.Point(764, 210)
        Me.ANESTHESIONLOGIST.Name = "ANESTHESIONLOGIST"
        Me.ANESTHESIONLOGIST.Size = New System.Drawing.Size(279, 28)
        Me.ANESTHESIONLOGIST.TabIndex = 41
        '
        'CIRCULATING
        '
        Me.CIRCULATING.FormattingEnabled = True
        Me.CIRCULATING.Location = New System.Drawing.Point(764, 170)
        Me.CIRCULATING.Name = "CIRCULATING"
        Me.CIRCULATING.Size = New System.Drawing.Size(279, 28)
        Me.CIRCULATING.TabIndex = 40
        '
        'SCRUB
        '
        Me.SCRUB.FormattingEnabled = True
        Me.SCRUB.Location = New System.Drawing.Point(764, 125)
        Me.SCRUB.Name = "SCRUB"
        Me.SCRUB.Size = New System.Drawing.Size(279, 28)
        Me.SCRUB.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(696, 890)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 20)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Surgeon's Signature:"
        '
        'NOTE
        '
        Me.NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOTE.Location = New System.Drawing.Point(10, 754)
        Me.NOTE.Multiline = True
        Me.NOTE.Name = "NOTE"
        Me.NOTE.Size = New System.Drawing.Size(455, 156)
        Me.NOTE.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 731)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 20)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Note:"
        '
        'NO_COMPLICATION
        '
        Me.NO_COMPLICATION.AutoSize = True
        Me.NO_COMPLICATION.Location = New System.Drawing.Point(486, 886)
        Me.NO_COMPLICATION.Name = "NO_COMPLICATION"
        Me.NO_COMPLICATION.Size = New System.Drawing.Size(140, 24)
        Me.NO_COMPLICATION.TabIndex = 34
        Me.NO_COMPLICATION.Text = "No complication"
        Me.NO_COMPLICATION.UseVisualStyleBackColor = True
        '
        'PATH
        '
        Me.PATH.AutoSize = True
        Me.PATH.Location = New System.Drawing.Point(486, 856)
        Me.PATH.Name = "PATH"
        Me.PATH.Size = New System.Drawing.Size(69, 24)
        Me.PATH.TabIndex = 33
        Me.PATH.Text = "Patch"
        Me.PATH.UseVisualStyleBackColor = True
        '
        'MAXITROL_EYE_OITMENT
        '
        Me.MAXITROL_EYE_OITMENT.AutoSize = True
        Me.MAXITROL_EYE_OITMENT.Location = New System.Drawing.Point(485, 826)
        Me.MAXITROL_EYE_OITMENT.Name = "MAXITROL_EYE_OITMENT"
        Me.MAXITROL_EYE_OITMENT.Size = New System.Drawing.Size(177, 24)
        Me.MAXITROL_EYE_OITMENT.TabIndex = 32
        Me.MAXITROL_EYE_OITMENT.Text = "Maxitrol eye ointment"
        Me.MAXITROL_EYE_OITMENT.UseVisualStyleBackColor = True
        '
        'VIGAMO_TROPICAL_NOTE
        '
        Me.VIGAMO_TROPICAL_NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VIGAMO_TROPICAL_NOTE.Location = New System.Drawing.Point(834, 794)
        Me.VIGAMO_TROPICAL_NOTE.Name = "VIGAMO_TROPICAL_NOTE"
        Me.VIGAMO_TROPICAL_NOTE.Size = New System.Drawing.Size(241, 26)
        Me.VIGAMO_TROPICAL_NOTE.TabIndex = 31
        '
        'VIGAMOX_TROPICAL
        '
        Me.VIGAMOX_TROPICAL.AutoSize = True
        Me.VIGAMOX_TROPICAL.Location = New System.Drawing.Point(684, 796)
        Me.VIGAMOX_TROPICAL.Name = "VIGAMOX_TROPICAL"
        Me.VIGAMOX_TROPICAL.Size = New System.Drawing.Size(144, 24)
        Me.VIGAMOX_TROPICAL.TabIndex = 30
        Me.VIGAMOX_TROPICAL.Text = "Vigamox tropical"
        Me.VIGAMOX_TROPICAL.UseVisualStyleBackColor = True
        '
        'POLY_OPH_TROPICAL
        '
        Me.POLY_OPH_TROPICAL.AutoSize = True
        Me.POLY_OPH_TROPICAL.Location = New System.Drawing.Point(485, 796)
        Me.POLY_OPH_TROPICAL.Name = "POLY_OPH_TROPICAL"
        Me.POLY_OPH_TROPICAL.Size = New System.Drawing.Size(144, 24)
        Me.POLY_OPH_TROPICAL.TabIndex = 29
        Me.POLY_OPH_TROPICAL.Text = "Poly-oph tropical"
        Me.POLY_OPH_TROPICAL.UseVisualStyleBackColor = True
        '
        'NEO_SYNEPHRINE
        '
        Me.NEO_SYNEPHRINE.AutoSize = True
        Me.NEO_SYNEPHRINE.Location = New System.Drawing.Point(684, 767)
        Me.NEO_SYNEPHRINE.Name = "NEO_SYNEPHRINE"
        Me.NEO_SYNEPHRINE.Size = New System.Drawing.Size(139, 24)
        Me.NEO_SYNEPHRINE.TabIndex = 28
        Me.NEO_SYNEPHRINE.Text = "Neo-synephrine"
        Me.NEO_SYNEPHRINE.UseVisualStyleBackColor = True
        '
        'ALPHAGAM
        '
        Me.ALPHAGAM.AutoSize = True
        Me.ALPHAGAM.Location = New System.Drawing.Point(485, 767)
        Me.ALPHAGAM.Name = "ALPHAGAM"
        Me.ALPHAGAM.Size = New System.Drawing.Size(96, 24)
        Me.ALPHAGAM.TabIndex = 27
        Me.ALPHAGAM.Text = "Alphagan"
        Me.ALPHAGAM.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(329, 626)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(221, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "At Site ""X"" shown on diagram."
        '
        'INTRA_LUCENTIS_DOSE
        '
        Me.INTRA_LUCENTIS_DOSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.INTRA_LUCENTIS_DOSE.Location = New System.Drawing.Point(785, 569)
        Me.INTRA_LUCENTIS_DOSE.Name = "INTRA_LUCENTIS_DOSE"
        Me.INTRA_LUCENTIS_DOSE.Size = New System.Drawing.Size(290, 26)
        Me.INTRA_LUCENTIS_DOSE.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(719, 575)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Dose:"
        '
        'INTRA_AVASTIN_DOSE
        '
        Me.INTRA_AVASTIN_DOSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.INTRA_AVASTIN_DOSE.Location = New System.Drawing.Point(785, 516)
        Me.INTRA_AVASTIN_DOSE.Name = "INTRA_AVASTIN_DOSE"
        Me.INTRA_AVASTIN_DOSE.Size = New System.Drawing.Size(290, 26)
        Me.INTRA_AVASTIN_DOSE.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(719, 522)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Dose:"
        '
        'INTRA_TRIAM_DOSE
        '
        Me.INTRA_TRIAM_DOSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.INTRA_TRIAM_DOSE.Location = New System.Drawing.Point(785, 465)
        Me.INTRA_TRIAM_DOSE.Name = "INTRA_TRIAM_DOSE"
        Me.INTRA_TRIAM_DOSE.Size = New System.Drawing.Size(290, 26)
        Me.INTRA_TRIAM_DOSE.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(719, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Dose:"
        '
        'INTRA_LUCENTIS
        '
        Me.INTRA_LUCENTIS.AutoSize = True
        Me.INTRA_LUCENTIS.Location = New System.Drawing.Point(333, 571)
        Me.INTRA_LUCENTIS.Name = "INTRA_LUCENTIS"
        Me.INTRA_LUCENTIS.Size = New System.Drawing.Size(227, 24)
        Me.INTRA_LUCENTIS.TabIndex = 19
        Me.INTRA_LUCENTIS.Text = "Intravitreal Lucentis Injected"
        Me.INTRA_LUCENTIS.UseVisualStyleBackColor = True
        '
        'INTRA_AVASTIN
        '
        Me.INTRA_AVASTIN.AutoSize = True
        Me.INTRA_AVASTIN.Location = New System.Drawing.Point(333, 518)
        Me.INTRA_AVASTIN.Name = "INTRA_AVASTIN"
        Me.INTRA_AVASTIN.Size = New System.Drawing.Size(216, 24)
        Me.INTRA_AVASTIN.TabIndex = 18
        Me.INTRA_AVASTIN.Text = "Intravtreal Avastin Injected"
        Me.INTRA_AVASTIN.UseVisualStyleBackColor = True
        '
        'INTRA_TRIAMCINOLONE
        '
        Me.INTRA_TRIAMCINOLONE.AutoSize = True
        Me.INTRA_TRIAMCINOLONE.Location = New System.Drawing.Point(333, 470)
        Me.INTRA_TRIAMCINOLONE.Name = "INTRA_TRIAMCINOLONE"
        Me.INTRA_TRIAMCINOLONE.Size = New System.Drawing.Size(339, 24)
        Me.INTRA_TRIAMCINOLONE.TabIndex = 17
        Me.INTRA_TRIAMCINOLONE.Text = "Intravitreal Triamcinolone Acetonide injected"
        Me.INTRA_TRIAMCINOLONE.UseVisualStyleBackColor = True
        '
        'PATIENT_FULL
        '
        Me.PATIENT_FULL.AutoSize = True
        Me.PATIENT_FULL.Location = New System.Drawing.Point(625, 415)
        Me.PATIENT_FULL.Name = "PATIENT_FULL"
        Me.PATIENT_FULL.Size = New System.Drawing.Size(428, 24)
        Me.PATIENT_FULL.TabIndex = 16
        Me.PATIENT_FULL.Text = "Patient full prep and drape and full sterile technique used"
        Me.PATIENT_FULL.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(645, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(318, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "5% Povidone solution eye drop admnistrator"
        '
        'FULL_PRE_OP
        '
        Me.FULL_PRE_OP.AutoSize = True
        Me.FULL_PRE_OP.Location = New System.Drawing.Point(625, 328)
        Me.FULL_PRE_OP.Name = "FULL_PRE_OP"
        Me.FULL_PRE_OP.Size = New System.Drawing.Size(342, 24)
        Me.FULL_PRE_OP.TabIndex = 14
        Me.FULL_PRE_OP.Text = "Full pre-op antibiotic eye drop administration."
        Me.FULL_PRE_OP.UseVisualStyleBackColor = True
        '
        'AN_SUBCONJUNCTIVAL
        '
        Me.AN_SUBCONJUNCTIVAL.AutoSize = True
        Me.AN_SUBCONJUNCTIVAL.Location = New System.Drawing.Point(936, 260)
        Me.AN_SUBCONJUNCTIVAL.Name = "AN_SUBCONJUNCTIVAL"
        Me.AN_SUBCONJUNCTIVAL.Size = New System.Drawing.Size(139, 24)
        Me.AN_SUBCONJUNCTIVAL.TabIndex = 13
        Me.AN_SUBCONJUNCTIVAL.Text = "Subconjunctival"
        Me.AN_SUBCONJUNCTIVAL.UseVisualStyleBackColor = True
        '
        'AN_TOPICAL
        '
        Me.AN_TOPICAL.AutoSize = True
        Me.AN_TOPICAL.Location = New System.Drawing.Point(776, 260)
        Me.AN_TOPICAL.Name = "AN_TOPICAL"
        Me.AN_TOPICAL.Size = New System.Drawing.Size(78, 24)
        Me.AN_TOPICAL.TabIndex = 12
        Me.AN_TOPICAL.Text = "Topical"
        Me.AN_TOPICAL.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(617, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Anesthesia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(617, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Anesthesionlogist:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(617, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Circulating:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(617, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Scrub:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(617, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Start Time:"
        '
        'LUCENTIS
        '
        Me.LUCENTIS.AutoSize = True
        Me.LUCENTIS.Location = New System.Drawing.Point(324, 218)
        Me.LUCENTIS.Name = "LUCENTIS"
        Me.LUCENTIS.Size = New System.Drawing.Size(88, 24)
        Me.LUCENTIS.TabIndex = 6
        Me.LUCENTIS.Text = "Lucentis"
        Me.LUCENTIS.UseVisualStyleBackColor = True
        '
        'AVASTIN
        '
        Me.AVASTIN.AutoSize = True
        Me.AVASTIN.Location = New System.Drawing.Point(238, 218)
        Me.AVASTIN.Name = "AVASTIN"
        Me.AVASTIN.Size = New System.Drawing.Size(80, 24)
        Me.AVASTIN.TabIndex = 5
        Me.AVASTIN.Text = "Avastin"
        Me.AVASTIN.UseVisualStyleBackColor = True
        '
        'IVTA
        '
        Me.IVTA.AutoSize = True
        Me.IVTA.Location = New System.Drawing.Point(105, 218)
        Me.IVTA.Name = "IVTA"
        Me.IVTA.Size = New System.Drawing.Size(127, 24)
        Me.IVTA.TabIndex = 4
        Me.IVTA.Text = "IVTA(Filtered)"
        Me.IVTA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Procedure: Intravitreal Injection"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diagnosis:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VITOROUS INJECTION NOT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(18, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operation Notes:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ErrInjection
        '
        Me.ErrInjection.ContainerControl = Me
        '
        'FormIntravitrealInjection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1382, 1054)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormIntravitrealInjection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intravitreal Injection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrInjection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LUCENTIS As System.Windows.Forms.CheckBox
    Friend WithEvents AVASTIN As System.Windows.Forms.CheckBox
    Friend WithEvents IVTA As System.Windows.Forms.CheckBox
    Friend WithEvents AN_TOPICAL As System.Windows.Forms.CheckBox
    Friend WithEvents AN_SUBCONJUNCTIVAL As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FULL_PRE_OP As System.Windows.Forms.CheckBox
    Friend WithEvents PATIENT_FULL As System.Windows.Forms.CheckBox
    Friend WithEvents INTRA_TRIAMCINOLONE As System.Windows.Forms.CheckBox
    Friend WithEvents INTRA_LUCENTIS As System.Windows.Forms.CheckBox
    Friend WithEvents INTRA_AVASTIN As System.Windows.Forms.CheckBox
    Friend WithEvents INTRA_LUCENTIS_DOSE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents INTRA_AVASTIN_DOSE As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents INTRA_TRIAM_DOSE As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents VIGAMOX_TROPICAL As System.Windows.Forms.CheckBox
    Friend WithEvents POLY_OPH_TROPICAL As System.Windows.Forms.CheckBox
    Friend WithEvents NEO_SYNEPHRINE As System.Windows.Forms.CheckBox
    Friend WithEvents ALPHAGAM As System.Windows.Forms.CheckBox
    Friend WithEvents VIGAMO_TROPICAL_NOTE As System.Windows.Forms.TextBox
    Friend WithEvents NO_COMPLICATION As System.Windows.Forms.CheckBox
    Friend WithEvents PATH As System.Windows.Forms.CheckBox
    Friend WithEvents MAXITROL_EYE_OITMENT As System.Windows.Forms.CheckBox
    Friend WithEvents NOTE As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ANESTHESIONLOGIST As System.Windows.Forms.ComboBox
    Friend WithEvents CIRCULATING As System.Windows.Forms.ComboBox
    Friend WithEvents SCRUB As System.Windows.Forms.ComboBox
    Friend WithEvents SURGEON_SIGNATURE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PATIENT_AGE As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_SEX As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NAME As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents START_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents DIAGNOSIS As System.Windows.Forms.ComboBox
    Friend WithEvents LblOpNumber As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrInjection As System.Windows.Forms.ErrorProvider
End Class
