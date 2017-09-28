<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOldOutPatientReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOldOutPatientReceipt))
        Me.lblFees = New System.Windows.Forms.Label
        Me.lblRielDolar = New System.Windows.Forms.Label
        Me.rdFollowUpD = New System.Windows.Forms.RadioButton
        Me.cmdAddRate = New System.Windows.Forms.Button
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtReturnD = New System.Windows.Forms.TextBox
        Me.rdFollowUpR = New System.Windows.Forms.RadioButton
        Me.txtHN = New System.Windows.Forms.TextBox
        Me.txtReceiptNumber = New System.Windows.Forms.TextBox
        Me.txtReturnR = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker
        Me.chkDollar = New System.Windows.Forms.CheckBox
        Me.chkRiel = New System.Windows.Forms.CheckBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtFollowUp = New System.Windows.Forms.TextBox
        Me.txtAmountFigureR = New System.Windows.Forms.TextBox
        Me.txtAmountWord = New System.Windows.Forms.TextBox
        Me.txtPatient = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtAmountFigureD = New System.Windows.Forms.TextBox
        Me.lblCashier = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdNew = New System.Windows.Forms.Button
        Me.chkSocialFee = New System.Windows.Forms.CheckBox
        Me.lblReceiptToPrintID = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdCashierSave = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdSearchReceipt = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.lblCashierLogin = New System.Windows.Forms.Label
        Me.ChPrintPreveiw = New System.Windows.Forms.CheckBox
        Me.cmdFindHN = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.GDifficulty = New System.Windows.Forms.GroupBox
        Me.ChHearing = New System.Windows.Forms.CheckBox
        Me.ChPhysical = New System.Windows.Forms.CheckBox
        Me.ChUnderstand = New System.Windows.Forms.CheckBox
        Me.ChSeeing = New System.Windows.Forms.CheckBox
        Me.lblHistoryNo = New System.Windows.Forms.Label
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
        Me.BgPrinter = New System.ComponentModel.BackgroundWorker
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.GReferralFrom = New System.Windows.Forms.GroupBox
        Me.ChListReferral = New System.Windows.Forms.CheckedListBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblConsultID = New System.Windows.Forms.Label
        Me.LblSendBy = New System.Windows.Forms.Label
        Me.lblConsultFor = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblConsultDate = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.LblConsultType = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GDifficulty.SuspendLayout()
        Me.GrpReferal.SuspendLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GReferralFrom.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Location = New System.Drawing.Point(845, 29)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(45, 13)
        Me.lblFees.TabIndex = 131
        Me.lblFees.Text = "Label15"
        Me.lblFees.Visible = False
        '
        'lblRielDolar
        '
        Me.lblRielDolar.AutoSize = True
        Me.lblRielDolar.BackColor = System.Drawing.Color.Transparent
        Me.lblRielDolar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRielDolar.Location = New System.Drawing.Point(354, 108)
        Me.lblRielDolar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRielDolar.Name = "lblRielDolar"
        Me.lblRielDolar.Size = New System.Drawing.Size(74, 31)
        Me.lblRielDolar.TabIndex = 124
        Me.lblRielDolar.Text = "erol duløar"
        '
        'rdFollowUpD
        '
        Me.rdFollowUpD.AutoSize = True
        Me.rdFollowUpD.BackColor = System.Drawing.Color.Transparent
        Me.rdFollowUpD.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFollowUpD.Location = New System.Drawing.Point(356, 59)
        Me.rdFollowUpD.Name = "rdFollowUpD"
        Me.rdFollowUpD.Size = New System.Drawing.Size(57, 31)
        Me.rdFollowUpD.TabIndex = 12
        Me.rdFollowUpD.Text = "duløar"
        Me.rdFollowUpD.UseVisualStyleBackColor = False
        '
        'cmdAddRate
        '
        Me.cmdAddRate.Enabled = False
        Me.cmdAddRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.cmdAddRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddRate.Location = New System.Drawing.Point(337, 141)
        Me.cmdAddRate.Name = "cmdAddRate"
        Me.cmdAddRate.Size = New System.Drawing.Size(44, 32)
        Me.cmdAddRate.TabIndex = 1
        Me.cmdAddRate.Text = "..."
        Me.cmdAddRate.UseVisualStyleBackColor = True
        Me.cmdAddRate.Visible = False
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.Color.Navy
        Me.txtRate.Location = New System.Drawing.Point(157, 143)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(174, 30)
        Me.txtRate.TabIndex = 0
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReturnD
        '
        Me.txtReturnD.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtReturnD.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnD.Location = New System.Drawing.Point(57, 77)
        Me.txtReturnD.Name = "txtReturnD"
        Me.txtReturnD.ReadOnly = True
        Me.txtReturnD.Size = New System.Drawing.Size(197, 41)
        Me.txtReturnD.TabIndex = 1
        Me.txtReturnD.Text = "0"
        Me.txtReturnD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdFollowUpR
        '
        Me.rdFollowUpR.AutoSize = True
        Me.rdFollowUpR.BackColor = System.Drawing.Color.Transparent
        Me.rdFollowUpR.Checked = True
        Me.rdFollowUpR.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFollowUpR.Location = New System.Drawing.Point(356, 33)
        Me.rdFollowUpR.Name = "rdFollowUpR"
        Me.rdFollowUpR.Size = New System.Drawing.Size(55, 31)
        Me.rdFollowUpR.TabIndex = 11
        Me.rdFollowUpR.TabStop = True
        Me.rdFollowUpR.Text = "erol"
        Me.rdFollowUpR.UseVisualStyleBackColor = False
        '
        'txtHN
        '
        Me.txtHN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtHN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHN.Location = New System.Drawing.Point(157, 91)
        Me.txtHN.Name = "txtHN"
        Me.txtHN.Size = New System.Drawing.Size(520, 31)
        Me.txtHN.TabIndex = 2
        '
        'txtReceiptNumber
        '
        Me.txtReceiptNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtReceiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNumber.Location = New System.Drawing.Point(157, 52)
        Me.txtReceiptNumber.Name = "txtReceiptNumber"
        Me.txtReceiptNumber.Size = New System.Drawing.Size(520, 31)
        Me.txtReceiptNumber.TabIndex = 0
        '
        'txtReturnR
        '
        Me.txtReturnR.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtReturnR.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnR.Location = New System.Drawing.Point(57, 30)
        Me.txtReturnR.Name = "txtReturnR"
        Me.txtReturnR.ReadOnly = True
        Me.txtReturnR.Size = New System.Drawing.Size(197, 41)
        Me.txtReturnR.TabIndex = 0
        Me.txtReturnR.Text = "0"
        Me.txtReturnR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtReturnD)
        Me.GroupBox1.Controls.Add(Me.txtReturnR)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(457, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 130)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "R)ak;Gab;"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 86)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 33)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "duløar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 40)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 33)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "erol"
        '
        'dtpDateIn
        '
        Me.dtpDateIn.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateIn.Location = New System.Drawing.Point(490, 141)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.ShowCheckBox = True
        Me.dtpDateIn.Size = New System.Drawing.Size(187, 29)
        Me.dtpDateIn.TabIndex = 3
        '
        'chkDollar
        '
        Me.chkDollar.AutoSize = True
        Me.chkDollar.BackColor = System.Drawing.Color.Transparent
        Me.chkDollar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDollar.Location = New System.Drawing.Point(575, 17)
        Me.chkDollar.Name = "chkDollar"
        Me.chkDollar.Size = New System.Drawing.Size(62, 35)
        Me.chkDollar.TabIndex = 9
        Me.chkDollar.Text = "duløar"
        Me.chkDollar.UseVisualStyleBackColor = False
        '
        'chkRiel
        '
        Me.chkRiel.AutoSize = True
        Me.chkRiel.BackColor = System.Drawing.Color.Transparent
        Me.chkRiel.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRiel.Location = New System.Drawing.Point(502, 17)
        Me.chkRiel.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.chkRiel.Name = "chkRiel"
        Me.chkRiel.Size = New System.Drawing.Size(60, 35)
        Me.chkRiel.TabIndex = 8
        Me.chkRiel.Text = "erol"
        Me.chkRiel.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotal.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(126, 94)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(218, 45)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFollowUp
        '
        Me.txtFollowUp.BackColor = System.Drawing.Color.Azure
        Me.txtFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFollowUp.Location = New System.Drawing.Point(126, 42)
        Me.txtFollowUp.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtFollowUp.Name = "txtFollowUp"
        Me.txtFollowUp.Size = New System.Drawing.Size(218, 45)
        Me.txtFollowUp.TabIndex = 10
        Me.txtFollowUp.Text = "0"
        Me.txtFollowUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountFigureR
        '
        Me.txtAmountFigureR.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountFigureR.Location = New System.Drawing.Point(154, 8)
        Me.txtAmountFigureR.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountFigureR.Name = "txtAmountFigureR"
        Me.txtAmountFigureR.Size = New System.Drawing.Size(162, 48)
        Me.txtAmountFigureR.TabIndex = 6
        Me.txtAmountFigureR.Text = "0"
        Me.txtAmountFigureR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountWord
        '
        Me.txtAmountWord.BackColor = System.Drawing.Color.Linen
        Me.txtAmountWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountWord.Location = New System.Drawing.Point(157, 234)
        Me.txtAmountWord.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountWord.Name = "txtAmountWord"
        Me.txtAmountWord.ReadOnly = True
        Me.txtAmountWord.Size = New System.Drawing.Size(520, 30)
        Me.txtAmountWord.TabIndex = 5
        '
        'txtPatient
        '
        Me.txtPatient.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient.Location = New System.Drawing.Point(157, 186)
        Me.txtPatient.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Size = New System.Drawing.Size(520, 39)
        Me.txtPatient.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 101)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 31)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "srub"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 31)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "karBinitüeLIgvij"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 31)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "cMNayeTAelI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Amount in figure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 31)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "cMnYnTwkR)ak;"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 31)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = ")anTTYlBI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "HN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 31)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "elxvikáybRt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(180, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 36)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Old-Out Patient Receipt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "kalbriecäT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblFees)
        Me.Panel1.Controls.Add(Me.txtAmountFigureD)
        Me.Panel1.Controls.Add(Me.chkDollar)
        Me.Panel1.Controls.Add(Me.chkRiel)
        Me.Panel1.Controls.Add(Me.txtAmountFigureR)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(28, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 63)
        Me.Panel1.TabIndex = 132
        '
        'txtAmountFigureD
        '
        Me.txtAmountFigureD.BackColor = System.Drawing.Color.LightYellow
        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountFigureD.ForeColor = System.Drawing.Color.Navy
        Me.txtAmountFigureD.Location = New System.Drawing.Point(328, 8)
        Me.txtAmountFigureD.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountFigureD.Name = "txtAmountFigureD"
        Me.txtAmountFigureD.Size = New System.Drawing.Size(162, 48)
        Me.txtAmountFigureD.TabIndex = 7
        Me.txtAmountFigureD.Text = "0"
        Me.txtAmountFigureD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.BackColor = System.Drawing.Color.Transparent
        Me.lblCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(166, 15)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(0, 20)
        Me.lblCashier.TabIndex = 134
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(83, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Cashier:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdNew)
        Me.GroupBox3.Controls.Add(Me.chkSocialFee)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(785, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(38, 18)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Free Fees"
        Me.GroupBox3.Visible = False
        '
        'cmdNew
        '
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = Global.TakeoHospitalInventory.My.Resources.Resources.report
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(113, 18)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(133, 40)
        Me.cmdNew.TabIndex = 14
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.Visible = False
        '
        'chkSocialFee
        '
        Me.chkSocialFee.Location = New System.Drawing.Point(21, 26)
        Me.chkSocialFee.Name = "chkSocialFee"
        Me.chkSocialFee.Size = New System.Drawing.Size(182, 24)
        Me.chkSocialFee.TabIndex = 0
        Me.chkSocialFee.Text = "Free"
        Me.chkSocialFee.UseVisualStyleBackColor = True
        '
        'lblReceiptToPrintID
        '
        Me.lblReceiptToPrintID.AutoSize = True
        Me.lblReceiptToPrintID.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiptToPrintID.Location = New System.Drawing.Point(12, 9)
        Me.lblReceiptToPrintID.Name = "lblReceiptToPrintID"
        Me.lblReceiptToPrintID.Size = New System.Drawing.Size(85, 13)
        Me.lblReceiptToPrintID.TabIndex = 137
        Me.lblReceiptToPrintID.Text = "ReceiptIDtoPrint"
        Me.lblReceiptToPrintID.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Floppy_s2
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(12, 558)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(193, 53)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCashierSave
        '
        Me.cmdCashierSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCashierSave.Enabled = False
        Me.cmdCashierSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmdCashierSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.welcome_bg
        Me.cmdCashierSave.Location = New System.Drawing.Point(562, 559)
        Me.cmdCashierSave.Name = "cmdCashierSave"
        Me.cmdCashierSave.Size = New System.Drawing.Size(172, 53)
        Me.cmdCashierSave.TabIndex = 138
        Me.cmdCashierSave.Text = "&Cashier Save"
        Me.cmdCashierSave.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(224, 558)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(169, 53)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdSearchReceipt
        '
        Me.cmdSearchReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchReceipt.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.cmdSearchReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearchReceipt.Location = New System.Drawing.Point(686, 52)
        Me.cmdSearchReceipt.Name = "cmdSearchReceipt"
        Me.cmdSearchReceipt.Size = New System.Drawing.Size(31, 32)
        Me.cmdSearchReceipt.TabIndex = 1
        Me.cmdSearchReceipt.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(399, 559)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(157, 53)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblCashierLogin
        '
        Me.lblCashierLogin.AutoSize = True
        Me.lblCashierLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblCashierLogin.Location = New System.Drawing.Point(47, 27)
        Me.lblCashierLogin.Name = "lblCashierLogin"
        Me.lblCashierLogin.Size = New System.Drawing.Size(68, 13)
        Me.lblCashierLogin.TabIndex = 150
        Me.lblCashierLogin.Text = "CashierLogin"
        Me.lblCashierLogin.Visible = False
        '
        'ChPrintPreveiw
        '
        Me.ChPrintPreveiw.AutoSize = True
        Me.ChPrintPreveiw.BackColor = System.Drawing.Color.Transparent
        Me.ChPrintPreveiw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPrintPreveiw.Location = New System.Drawing.Point(748, 532)
        Me.ChPrintPreveiw.Name = "ChPrintPreveiw"
        Me.ChPrintPreveiw.Size = New System.Drawing.Size(162, 24)
        Me.ChPrintPreveiw.TabIndex = 151
        Me.ChPrintPreveiw.Text = "Show Print Preveiw"
        Me.ChPrintPreveiw.UseVisualStyleBackColor = False
        '
        'cmdFindHN
        '
        Me.cmdFindHN.Image = Global.TakeoHospitalInventory.My.Resources.Resources.preview
        Me.cmdFindHN.Location = New System.Drawing.Point(684, 90)
        Me.cmdFindHN.Name = "cmdFindHN"
        Me.cmdFindHN.Size = New System.Drawing.Size(33, 31)
        Me.cmdFindHN.TabIndex = 152
        Me.cmdFindHN.UseVisualStyleBackColor = True
        Me.cmdFindHN.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Location = New System.Drawing.Point(716, 27)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 157
        Me.lblID.Text = "0"
        Me.lblID.Visible = False
        '
        'GDifficulty
        '
        Me.GDifficulty.BackColor = System.Drawing.Color.Transparent
        Me.GDifficulty.Controls.Add(Me.ChHearing)
        Me.GDifficulty.Controls.Add(Me.ChPhysical)
        Me.GDifficulty.Controls.Add(Me.ChUnderstand)
        Me.GDifficulty.Location = New System.Drawing.Point(750, 42)
        Me.GDifficulty.Name = "GDifficulty"
        Me.GDifficulty.Size = New System.Drawing.Size(388, 46)
        Me.GDifficulty.TabIndex = 158
        Me.GDifficulty.TabStop = False
        Me.GDifficulty.Text = "Difficulty"
        '
        'ChHearing
        '
        Me.ChHearing.AutoSize = True
        Me.ChHearing.Location = New System.Drawing.Point(9, 16)
        Me.ChHearing.Name = "ChHearing"
        Me.ChHearing.Size = New System.Drawing.Size(63, 17)
        Me.ChHearing.TabIndex = 0
        Me.ChHearing.Text = "Hearing"
        Me.ChHearing.UseVisualStyleBackColor = True
        '
        'ChPhysical
        '
        Me.ChPhysical.AutoSize = True
        Me.ChPhysical.Location = New System.Drawing.Point(274, 16)
        Me.ChPhysical.Name = "ChPhysical"
        Me.ChPhysical.Size = New System.Drawing.Size(107, 17)
        Me.ChPhysical.TabIndex = 3
        Me.ChPhysical.Text = "Physical disability"
        Me.ChPhysical.UseVisualStyleBackColor = True
        '
        'ChUnderstand
        '
        Me.ChUnderstand.AutoSize = True
        Me.ChUnderstand.Location = New System.Drawing.Point(88, 16)
        Me.ChUnderstand.Name = "ChUnderstand"
        Me.ChUnderstand.Size = New System.Drawing.Size(180, 17)
        Me.ChUnderstand.TabIndex = 1
        Me.ChUnderstand.Text = "Uderstand / Intellectual / Mental"
        Me.ChUnderstand.UseVisualStyleBackColor = True
        '
        'ChSeeing
        '
        Me.ChSeeing.AutoSize = True
        Me.ChSeeing.Location = New System.Drawing.Point(920, 12)
        Me.ChSeeing.Name = "ChSeeing"
        Me.ChSeeing.Size = New System.Drawing.Size(59, 17)
        Me.ChSeeing.TabIndex = 2
        Me.ChSeeing.Text = "Seeing"
        Me.ChSeeing.UseVisualStyleBackColor = True
        Me.ChSeeing.Visible = False
        '
        'lblHistoryNo
        '
        Me.lblHistoryNo.AutoSize = True
        Me.lblHistoryNo.BackColor = System.Drawing.Color.Transparent
        Me.lblHistoryNo.Location = New System.Drawing.Point(856, 32)
        Me.lblHistoryNo.Name = "lblHistoryNo"
        Me.lblHistoryNo.Size = New System.Drawing.Size(13, 13)
        Me.lblHistoryNo.TabIndex = 160
        Me.lblHistoryNo.Text = "0"
        Me.lblHistoryNo.Visible = False
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
        Me.GrpReferal.Location = New System.Drawing.Point(615, 9)
        Me.GrpReferal.Name = "GrpReferal"
        Me.GrpReferal.Size = New System.Drawing.Size(145, 15)
        Me.GrpReferal.TabIndex = 202
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
        'BgPrinter
        '
        '
        'PictLoading
        '
        Me.PictLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loadgraphic
        Me.PictLoading.Location = New System.Drawing.Point(745, 562)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(212, 25)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 203
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'GReferralFrom
        '
        Me.GReferralFrom.Controls.Add(Me.ChListReferral)
        Me.GReferralFrom.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GReferralFrom.Location = New System.Drawing.Point(748, 100)
        Me.GReferralFrom.Name = "GReferralFrom"
        Me.GReferralFrom.Size = New System.Drawing.Size(287, 426)
        Me.GReferralFrom.TabIndex = 204
        Me.GReferralFrom.TabStop = False
        Me.GReferralFrom.Text = "Referral From:"
        '
        'ChListReferral
        '
        Me.ChListReferral.CheckOnClick = True
        Me.ChListReferral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChListReferral.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChListReferral.FormattingEnabled = True
        Me.ChListReferral.HorizontalScrollbar = True
        Me.ChListReferral.Location = New System.Drawing.Point(3, 36)
        Me.ChListReferral.Name = "ChListReferral"
        Me.ChListReferral.ScrollAlwaysVisible = True
        Me.ChListReferral.Size = New System.Drawing.Size(281, 354)
        Me.ChListReferral.TabIndex = 194
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdAddRate)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txtRate)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txtPatient)
        Me.GroupBox6.Controls.Add(Me.cmdFindHN)
        Me.GroupBox6.Controls.Add(Me.txtAmountWord)
        Me.GroupBox6.Controls.Add(Me.dtpDateIn)
        Me.GroupBox6.Controls.Add(Me.txtReceiptNumber)
        Me.GroupBox6.Controls.Add(Me.txtHN)
        Me.GroupBox6.Controls.Add(Me.lblCashier)
        Me.GroupBox6.Controls.Add(Me.cmdSearchReceipt)
        Me.GroupBox6.Controls.Add(Me.Panel1)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(730, 347)
        Me.GroupBox6.TabIndex = 205
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Patient Information"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(47, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 31)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "GRtabþÚrR)ak;"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.txtFollowUp)
        Me.GroupBox7.Controls.Add(Me.txtTotal)
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Controls.Add(Me.rdFollowUpR)
        Me.GroupBox7.Controls.Add(Me.rdFollowUpD)
        Me.GroupBox7.Controls.Add(Me.lblRielDolar)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 390)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(730, 163)
        Me.GroupBox7.TabIndex = 206
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Amount Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblConsultID)
        Me.GroupBox2.Controls.Add(Me.LblSendBy)
        Me.GroupBox2.Controls.Add(Me.lblConsultFor)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.LblConsultDate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.LblConsultType)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(1038, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 136)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information From Consult"
        '
        'LblConsultID
        '
        Me.LblConsultID.AutoSize = True
        Me.LblConsultID.Location = New System.Drawing.Point(188, 23)
        Me.LblConsultID.Name = "LblConsultID"
        Me.LblConsultID.Size = New System.Drawing.Size(18, 20)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(6, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Date Consult:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(6, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 17)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Consult By:"
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(6, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Consult Type:"
        '
        'frmOldOutPatientReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 619)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.ChSeeing)
        Me.Controls.Add(Me.GReferralFrom)
        Me.Controls.Add(Me.PictLoading)
        Me.Controls.Add(Me.GrpReferal)
        Me.Controls.Add(Me.lblHistoryNo)
        Me.Controls.Add(Me.GDifficulty)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.ChPrintPreveiw)
        Me.Controls.Add(Me.lblCashierLogin)
        Me.Controls.Add(Me.cmdCashierSave)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.lblReceiptToPrintID)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOldOutPatientReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Old-out Patient Receipt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GDifficulty.ResumeLayout(False)
        Me.GDifficulty.PerformLayout()
        Me.GrpReferal.ResumeLayout(False)
        Me.GrpReferal.PerformLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GReferralFrom.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFees As System.Windows.Forms.Label
    Friend WithEvents lblRielDolar As System.Windows.Forms.Label
    Friend WithEvents rdFollowUpD As System.Windows.Forms.RadioButton
    Friend WithEvents cmdAddRate As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnD As System.Windows.Forms.TextBox
    Friend WithEvents rdFollowUpR As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtHN As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents txtReturnR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDollar As System.Windows.Forms.CheckBox
    Friend WithEvents chkRiel As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFollowUp As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountFigureR As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountWord As System.Windows.Forms.TextBox
    Friend WithEvents txtPatient As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSocialFee As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents lblReceiptToPrintID As System.Windows.Forms.Label
    Friend WithEvents cmdSearchReceipt As System.Windows.Forms.Button
    Friend WithEvents cmdCashierSave As System.Windows.Forms.Button
    Friend WithEvents txtAmountFigureD As System.Windows.Forms.TextBox
    Friend WithEvents lblCashierLogin As System.Windows.Forms.Label
    Friend WithEvents ChPrintPreveiw As System.Windows.Forms.CheckBox
    Friend WithEvents cmdFindHN As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents GDifficulty As System.Windows.Forms.GroupBox
    Friend WithEvents ChHearing As System.Windows.Forms.CheckBox
    Friend WithEvents ChPhysical As System.Windows.Forms.CheckBox
    Friend WithEvents ChUnderstand As System.Windows.Forms.CheckBox
    Friend WithEvents ChSeeing As System.Windows.Forms.CheckBox
    Friend WithEvents lblHistoryNo As System.Windows.Forms.Label
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
    Friend WithEvents BgPrinter As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents GReferralFrom As System.Windows.Forms.GroupBox
    Friend WithEvents ChListReferral As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblConsultID As System.Windows.Forms.Label
    Friend WithEvents LblSendBy As System.Windows.Forms.Label
    Friend WithEvents lblConsultFor As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblConsultDate As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblConsultType As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
