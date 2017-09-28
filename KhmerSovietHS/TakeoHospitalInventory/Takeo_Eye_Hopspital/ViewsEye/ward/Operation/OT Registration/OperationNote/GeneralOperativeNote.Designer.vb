<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralOperativeNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralOperativeNote))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.lblOpNo = New System.Windows.Forms.Label
        Me.lblSaveOption = New System.Windows.Forms.Label
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
        Me.S_AN_SUBCONJUNCTIVAL = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TOPICAL_OTHER = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.SUB_OTHER = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.S_AN_STANDBY = New System.Windows.Forms.CheckBox
        Me.S_AN_NEURO = New System.Windows.Forms.CheckBox
        Me.S_AN_PERIBULBAR = New System.Windows.Forms.CheckBox
        Me.S_AN_RETROBULBAR = New System.Windows.Forms.CheckBox
        Me.DIAGNOSIS = New System.Windows.Forms.ComboBox
        Me.SURGEON_SIGNATURE = New System.Windows.Forms.ComboBox
        Me.ANESTHESIONLOGIST = New System.Windows.Forms.ComboBox
        Me.CIRCULATING = New System.Windows.Forms.ComboBox
        Me.SCRUB = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.OTHER_PROCEDURES = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.SUB_CEFAZOLIN = New System.Windows.Forms.CheckBox
        Me.TOPICAL_MAXITRAL = New System.Windows.Forms.CheckBox
        Me.TOPICAL_PILOCARPINE = New System.Windows.Forms.CheckBox
        Me.SUB_GENTAL = New System.Windows.Forms.CheckBox
        Me.TOPICAL_ATROPINE = New System.Windows.Forms.CheckBox
        Me.SUB_DEXAMETHASONE = New System.Windows.Forms.CheckBox
        Me.S_AN_GA = New System.Windows.Forms.CheckBox
        Me.S_AN_TOPICAL = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrOperative = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrOperative, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.lblOpNo)
        Me.Panel1.Controls.Add(Me.lblSaveOption)
        Me.Panel1.Controls.Add(Me.START_TIME)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.S_AN_SUBCONJUNCTIVAL)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.TOPICAL_OTHER)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.SUB_OTHER)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.S_AN_STANDBY)
        Me.Panel1.Controls.Add(Me.S_AN_NEURO)
        Me.Panel1.Controls.Add(Me.S_AN_PERIBULBAR)
        Me.Panel1.Controls.Add(Me.S_AN_RETROBULBAR)
        Me.Panel1.Controls.Add(Me.DIAGNOSIS)
        Me.Panel1.Controls.Add(Me.SURGEON_SIGNATURE)
        Me.Panel1.Controls.Add(Me.ANESTHESIONLOGIST)
        Me.Panel1.Controls.Add(Me.CIRCULATING)
        Me.Panel1.Controls.Add(Me.SCRUB)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.OTHER_PROCEDURES)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.SUB_CEFAZOLIN)
        Me.Panel1.Controls.Add(Me.TOPICAL_MAXITRAL)
        Me.Panel1.Controls.Add(Me.TOPICAL_PILOCARPINE)
        Me.Panel1.Controls.Add(Me.SUB_GENTAL)
        Me.Panel1.Controls.Add(Me.TOPICAL_ATROPINE)
        Me.Panel1.Controls.Add(Me.SUB_DEXAMETHASONE)
        Me.Panel1.Controls.Add(Me.S_AN_GA)
        Me.Panel1.Controls.Add(Me.S_AN_TOPICAL)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1571, 1045)
        Me.Panel1.TabIndex = 2
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(123, 644)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(93, 34)
        Me.BtnCancel.TabIndex = 66
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
        Me.BtnSave.Location = New System.Drawing.Point(23, 644)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 34)
        Me.BtnSave.TabIndex = 65
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'lblOpNo
        '
        Me.lblOpNo.AutoSize = True
        Me.lblOpNo.Location = New System.Drawing.Point(103, 246)
        Me.lblOpNo.Name = "lblOpNo"
        Me.lblOpNo.Size = New System.Drawing.Size(18, 20)
        Me.lblOpNo.TabIndex = 64
        Me.lblOpNo.Text = "0"
        Me.lblOpNo.Visible = False
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.Location = New System.Drawing.Point(29, 248)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.lblSaveOption.TabIndex = 63
        Me.lblSaveOption.Text = "0"
        Me.lblSaveOption.Visible = False
        '
        'START_TIME
        '
        Me.START_TIME.Checked = False
        Me.START_TIME.CustomFormat = "ddd-MMM-yyyy HH:mm"
        Me.START_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.START_TIME.Location = New System.Drawing.Point(684, 41)
        Me.START_TIME.Name = "START_TIME"
        Me.START_TIME.ShowCheckBox = True
        Me.START_TIME.Size = New System.Drawing.Size(279, 26)
        Me.START_TIME.TabIndex = 62
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
        Me.GroupBox1.Location = New System.Drawing.Point(985, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 165)
        Me.GroupBox1.TabIndex = 61
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
        'S_AN_SUBCONJUNCTIVAL
        '
        Me.S_AN_SUBCONJUNCTIVAL.AutoSize = True
        Me.S_AN_SUBCONJUNCTIVAL.Location = New System.Drawing.Point(812, 278)
        Me.S_AN_SUBCONJUNCTIVAL.Name = "S_AN_SUBCONJUNCTIVAL"
        Me.S_AN_SUBCONJUNCTIVAL.Size = New System.Drawing.Size(139, 24)
        Me.S_AN_SUBCONJUNCTIVAL.TabIndex = 60
        Me.S_AN_SUBCONJUNCTIVAL.Text = "Subconjunctival"
        Me.S_AN_SUBCONJUNCTIVAL.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(658, 565)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 20)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Others:"
        '
        'TOPICAL_OTHER
        '
        Me.TOPICAL_OTHER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOPICAL_OTHER.Location = New System.Drawing.Point(725, 559)
        Me.TOPICAL_OTHER.Name = "TOPICAL_OTHER"
        Me.TOPICAL_OTHER.Size = New System.Drawing.Size(346, 26)
        Me.TOPICAL_OTHER.TabIndex = 58
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(658, 531)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 20)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Others:"
        '
        'SUB_OTHER
        '
        Me.SUB_OTHER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SUB_OTHER.Location = New System.Drawing.Point(725, 525)
        Me.SUB_OTHER.Name = "SUB_OTHER"
        Me.SUB_OTHER.Size = New System.Drawing.Size(346, 26)
        Me.SUB_OTHER.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 572)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 20)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Topical Med:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 540)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 20)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Subconjunctival Inj:"
        '
        'S_AN_STANDBY
        '
        Me.S_AN_STANDBY.AutoSize = True
        Me.S_AN_STANDBY.Location = New System.Drawing.Point(904, 216)
        Me.S_AN_STANDBY.Name = "S_AN_STANDBY"
        Me.S_AN_STANDBY.Size = New System.Drawing.Size(91, 24)
        Me.S_AN_STANDBY.TabIndex = 47
        Me.S_AN_STANDBY.Text = "Stand by"
        Me.S_AN_STANDBY.UseVisualStyleBackColor = True
        '
        'S_AN_NEURO
        '
        Me.S_AN_NEURO.AutoSize = True
        Me.S_AN_NEURO.Location = New System.Drawing.Point(812, 216)
        Me.S_AN_NEURO.Name = "S_AN_NEURO"
        Me.S_AN_NEURO.Size = New System.Drawing.Size(71, 24)
        Me.S_AN_NEURO.TabIndex = 46
        Me.S_AN_NEURO.Text = "Neuro"
        Me.S_AN_NEURO.UseVisualStyleBackColor = True
        '
        'S_AN_PERIBULBAR
        '
        Me.S_AN_PERIBULBAR.AutoSize = True
        Me.S_AN_PERIBULBAR.Location = New System.Drawing.Point(812, 246)
        Me.S_AN_PERIBULBAR.Name = "S_AN_PERIBULBAR"
        Me.S_AN_PERIBULBAR.Size = New System.Drawing.Size(99, 24)
        Me.S_AN_PERIBULBAR.TabIndex = 45
        Me.S_AN_PERIBULBAR.Text = "Peribulbar"
        Me.S_AN_PERIBULBAR.UseVisualStyleBackColor = True
        '
        'S_AN_RETROBULBAR
        '
        Me.S_AN_RETROBULBAR.AutoSize = True
        Me.S_AN_RETROBULBAR.Location = New System.Drawing.Point(684, 246)
        Me.S_AN_RETROBULBAR.Name = "S_AN_RETROBULBAR"
        Me.S_AN_RETROBULBAR.Size = New System.Drawing.Size(112, 24)
        Me.S_AN_RETROBULBAR.TabIndex = 44
        Me.S_AN_RETROBULBAR.Text = "Retrobulbar"
        Me.S_AN_RETROBULBAR.UseVisualStyleBackColor = True
        '
        'DIAGNOSIS
        '
        Me.DIAGNOSIS.FormattingEnabled = True
        Me.DIAGNOSIS.Location = New System.Drawing.Point(99, 109)
        Me.DIAGNOSIS.Name = "DIAGNOSIS"
        Me.DIAGNOSIS.Size = New System.Drawing.Size(279, 28)
        Me.DIAGNOSIS.TabIndex = 43
        '
        'SURGEON_SIGNATURE
        '
        Me.SURGEON_SIGNATURE.FormattingEnabled = True
        Me.SURGEON_SIGNATURE.Location = New System.Drawing.Point(856, 650)
        Me.SURGEON_SIGNATURE.Name = "SURGEON_SIGNATURE"
        Me.SURGEON_SIGNATURE.Size = New System.Drawing.Size(215, 28)
        Me.SURGEON_SIGNATURE.TabIndex = 42
        '
        'ANESTHESIONLOGIST
        '
        Me.ANESTHESIONLOGIST.FormattingEnabled = True
        Me.ANESTHESIONLOGIST.Location = New System.Drawing.Point(684, 166)
        Me.ANESTHESIONLOGIST.Name = "ANESTHESIONLOGIST"
        Me.ANESTHESIONLOGIST.Size = New System.Drawing.Size(279, 28)
        Me.ANESTHESIONLOGIST.TabIndex = 41
        '
        'CIRCULATING
        '
        Me.CIRCULATING.FormattingEnabled = True
        Me.CIRCULATING.Location = New System.Drawing.Point(684, 126)
        Me.CIRCULATING.Name = "CIRCULATING"
        Me.CIRCULATING.Size = New System.Drawing.Size(279, 28)
        Me.CIRCULATING.TabIndex = 40
        '
        'SCRUB
        '
        Me.SCRUB.FormattingEnabled = True
        Me.SCRUB.Location = New System.Drawing.Point(684, 81)
        Me.SCRUB.Name = "SCRUB"
        Me.SCRUB.Size = New System.Drawing.Size(279, 28)
        Me.SCRUB.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(692, 658)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 20)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Surgeon's Signature:"
        '
        'OTHER_PROCEDURES
        '
        Me.OTHER_PROCEDURES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OTHER_PROCEDURES.Location = New System.Drawing.Point(163, 480)
        Me.OTHER_PROCEDURES.Name = "OTHER_PROCEDURES"
        Me.OTHER_PROCEDURES.Size = New System.Drawing.Size(908, 26)
        Me.OTHER_PROCEDURES.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 489)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 20)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Other Procedures:"
        '
        'SUB_CEFAZOLIN
        '
        Me.SUB_CEFAZOLIN.AutoSize = True
        Me.SUB_CEFAZOLIN.Location = New System.Drawing.Point(336, 535)
        Me.SUB_CEFAZOLIN.Name = "SUB_CEFAZOLIN"
        Me.SUB_CEFAZOLIN.Size = New System.Drawing.Size(94, 24)
        Me.SUB_CEFAZOLIN.TabIndex = 34
        Me.SUB_CEFAZOLIN.Text = "Cefazolin"
        Me.SUB_CEFAZOLIN.UseVisualStyleBackColor = True
        '
        'TOPICAL_MAXITRAL
        '
        Me.TOPICAL_MAXITRAL.AutoSize = True
        Me.TOPICAL_MAXITRAL.Location = New System.Drawing.Point(167, 568)
        Me.TOPICAL_MAXITRAL.Name = "TOPICAL_MAXITRAL"
        Me.TOPICAL_MAXITRAL.Size = New System.Drawing.Size(113, 24)
        Me.TOPICAL_MAXITRAL.TabIndex = 32
        Me.TOPICAL_MAXITRAL.Text = "Maxitrol E.O"
        Me.TOPICAL_MAXITRAL.UseVisualStyleBackColor = True
        '
        'TOPICAL_PILOCARPINE
        '
        Me.TOPICAL_PILOCARPINE.AutoSize = True
        Me.TOPICAL_PILOCARPINE.Location = New System.Drawing.Point(336, 567)
        Me.TOPICAL_PILOCARPINE.Name = "TOPICAL_PILOCARPINE"
        Me.TOPICAL_PILOCARPINE.Size = New System.Drawing.Size(132, 24)
        Me.TOPICAL_PILOCARPINE.TabIndex = 30
        Me.TOPICAL_PILOCARPINE.Text = "Pilocarpine 2%"
        Me.TOPICAL_PILOCARPINE.UseVisualStyleBackColor = True
        '
        'SUB_GENTAL
        '
        Me.SUB_GENTAL.AutoSize = True
        Me.SUB_GENTAL.Location = New System.Drawing.Point(167, 536)
        Me.SUB_GENTAL.Name = "SUB_GENTAL"
        Me.SUB_GENTAL.Size = New System.Drawing.Size(109, 24)
        Me.SUB_GENTAL.TabIndex = 29
        Me.SUB_GENTAL.Text = "Gentamicin"
        Me.SUB_GENTAL.UseVisualStyleBackColor = True
        '
        'TOPICAL_ATROPINE
        '
        Me.TOPICAL_ATROPINE.AutoSize = True
        Me.TOPICAL_ATROPINE.Location = New System.Drawing.Point(490, 564)
        Me.TOPICAL_ATROPINE.Name = "TOPICAL_ATROPINE"
        Me.TOPICAL_ATROPINE.Size = New System.Drawing.Size(115, 24)
        Me.TOPICAL_ATROPINE.TabIndex = 18
        Me.TOPICAL_ATROPINE.Text = "Atropine 1%"
        Me.TOPICAL_ATROPINE.UseVisualStyleBackColor = True
        '
        'SUB_DEXAMETHASONE
        '
        Me.SUB_DEXAMETHASONE.AutoSize = True
        Me.SUB_DEXAMETHASONE.Location = New System.Drawing.Point(490, 534)
        Me.SUB_DEXAMETHASONE.Name = "SUB_DEXAMETHASONE"
        Me.SUB_DEXAMETHASONE.Size = New System.Drawing.Size(145, 24)
        Me.SUB_DEXAMETHASONE.TabIndex = 17
        Me.SUB_DEXAMETHASONE.Text = "Dexamethasone"
        Me.SUB_DEXAMETHASONE.UseVisualStyleBackColor = True
        '
        'S_AN_GA
        '
        Me.S_AN_GA.AutoSize = True
        Me.S_AN_GA.Location = New System.Drawing.Point(684, 216)
        Me.S_AN_GA.Name = "S_AN_GA"
        Me.S_AN_GA.Size = New System.Drawing.Size(68, 24)
        Me.S_AN_GA.TabIndex = 13
        Me.S_AN_GA.Text = "G .A ."
        Me.S_AN_GA.UseVisualStyleBackColor = True
        '
        'S_AN_TOPICAL
        '
        Me.S_AN_TOPICAL.AutoSize = True
        Me.S_AN_TOPICAL.Location = New System.Drawing.Point(684, 278)
        Me.S_AN_TOPICAL.Name = "S_AN_TOPICAL"
        Me.S_AN_TOPICAL.Size = New System.Drawing.Size(78, 24)
        Me.S_AN_TOPICAL.TabIndex = 12
        Me.S_AN_TOPICAL.Text = "Topical"
        Me.S_AN_TOPICAL.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(537, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Anesthesia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(537, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Anesthesionlogist:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(537, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Circulating:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(537, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Scrub:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Start Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(322, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Procedure: GENERAL OPERATIVE NOTES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 114)
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
        Me.Label2.Location = New System.Drawing.Point(10, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GENERAL OPERATIVE NOTES"
        '
        'ErrOperative
        '
        Me.ErrOperative.ContainerControl = Me
        '
        'GeneralOperativeNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1571, 1045)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GeneralOperativeNote"
        Me.ShowInTaskbar = False
        Me.Text = "General Operative Notes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrOperative, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TOPICAL_OTHER As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SUB_OTHER As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents S_AN_STANDBY As System.Windows.Forms.CheckBox
    Friend WithEvents S_AN_NEURO As System.Windows.Forms.CheckBox
    Friend WithEvents S_AN_PERIBULBAR As System.Windows.Forms.CheckBox
    Friend WithEvents S_AN_RETROBULBAR As System.Windows.Forms.CheckBox
    Friend WithEvents DIAGNOSIS As System.Windows.Forms.ComboBox
    Friend WithEvents SURGEON_SIGNATURE As System.Windows.Forms.ComboBox
    Friend WithEvents ANESTHESIONLOGIST As System.Windows.Forms.ComboBox
    Friend WithEvents CIRCULATING As System.Windows.Forms.ComboBox
    Friend WithEvents SCRUB As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents OTHER_PROCEDURES As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SUB_CEFAZOLIN As System.Windows.Forms.CheckBox
    Friend WithEvents TOPICAL_MAXITRAL As System.Windows.Forms.CheckBox
    Friend WithEvents TOPICAL_PILOCARPINE As System.Windows.Forms.CheckBox
    Friend WithEvents SUB_GENTAL As System.Windows.Forms.CheckBox
    Friend WithEvents TOPICAL_ATROPINE As System.Windows.Forms.CheckBox
    Friend WithEvents SUB_DEXAMETHASONE As System.Windows.Forms.CheckBox
    Friend WithEvents S_AN_GA As System.Windows.Forms.CheckBox
    Friend WithEvents S_AN_TOPICAL As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents S_AN_SUBCONJUNCTIVAL As System.Windows.Forms.CheckBox
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
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents lblOpNo As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrOperative As System.Windows.Forms.ErrorProvider
End Class
