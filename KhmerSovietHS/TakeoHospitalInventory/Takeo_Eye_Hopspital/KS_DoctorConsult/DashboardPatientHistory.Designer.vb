<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPatientHistory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardPatientHistory))
        Dim GridPatientInformation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridHistoy_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridImageList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridOT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnUpdateConsult = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintHistory = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridPatientInformation = New Janus.Windows.GridEX.GridEX
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtTelephone = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.RadTelephone = New System.Windows.Forms.RadioButton
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.RadPatientNo = New System.Windows.Forms.RadioButton
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridHistoy = New Janus.Windows.GridEX.GridEX
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.CboDoctorConsult = New System.Windows.Forms.ComboBox
        Me.TxtMedication = New System.Windows.Forms.TextBox
        Me.GroupMangement = New System.Windows.Forms.GroupBox
        Me.TxtPriceSurgery = New System.Windows.Forms.TextBox
        Me.TxtSurgery = New System.Windows.Forms.ComboBox
        Me.RadManageOutPatient = New System.Windows.Forms.RadioButton
        Me.RadManageInpatient = New System.Windows.Forms.RadioButton
        Me.RadManageSurgery = New System.Windows.Forms.RadioButton
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtDiagnosisNote = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupEye = New System.Windows.Forms.GroupBox
        Me.RadDiagnosisRighEye = New System.Windows.Forms.RadioButton
        Me.RadDiagnosisBothEyes = New System.Windows.Forms.RadioButton
        Me.RadDiagnosisLefEye = New System.Windows.Forms.RadioButton
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridImageList = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage6 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridOT = New Janus.Windows.GridEX.GridEX
        Me.MenuOperationNote = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnUpdateOPNote = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintPreview = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TxtHistory = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtLLe1 = New System.Windows.Forms.TextBox
        Me.TxtRRe1 = New System.Windows.Forms.TextBox
        Me.TxtLRef1 = New System.Windows.Forms.TextBox
        Me.TxtREF1 = New System.Windows.Forms.TextBox
        Me.TxtLPh1 = New System.Windows.Forms.TextBox
        Me.TxtRPh1 = New System.Windows.Forms.TextBox
        Me.TxtLe1 = New System.Windows.Forms.TextBox
        Me.TxtRE1 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtIOPLE = New System.Windows.Forms.TextBox
        Me.TxtIOPRE = New System.Windows.Forms.TextBox
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridHistoy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupMangement.SuspendLayout()
        Me.GroupEye.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage3.SuspendLayout()
        CType(Me.GridImageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage6.SuspendLayout()
        CType(Me.GridOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuOperationNote.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUpdateConsult, Me.ToolStripSeparator1, Me.BtnPrintHistory})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1411, 60)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnUpdateConsult
        '
        Me.BtnUpdateConsult.BackgroundImage = CType(resources.GetObject("BtnUpdateConsult.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdateConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdateConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateConsult.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateConsult.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.BtnUpdateConsult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateConsult.Name = "BtnUpdateConsult"
        Me.BtnUpdateConsult.Size = New System.Drawing.Size(153, 57)
        Me.BtnUpdateConsult.Text = "       Edit Exam      "
        Me.BtnUpdateConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 60)
        '
        'BtnPrintHistory
        '
        Me.BtnPrintHistory.BackgroundImage = CType(resources.GetObject("BtnPrintHistory.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintHistory.ForeColor = System.Drawing.Color.White
        Me.BtnPrintHistory.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnPrintHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintHistory.Name = "BtnPrintHistory"
        Me.BtnPrintHistory.Size = New System.Drawing.Size(151, 57)
        Me.BtnPrintHistory.Text = "     Print History    "
        Me.BtnPrintHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1411, 844)
        Me.SplitContainer1.SplitterDistance = 292
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.TxtTelephone)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadTelephone)
        Me.GroupBox1.Controls.Add(Me.RadPatientName)
        Me.GroupBox1.Controls.Add(Me.RadPatientNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 842)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GridPatientInformation)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(7, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 600)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient List"
        '
        'GridPatientInformation
        '
        Me.GridPatientInformation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPatientInformation.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridPatientInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridPatientInformation.BackgroundImageDrawMode = Janus.Windows.GridEX.BackgroundImageDrawMode.Stretch
        Me.GridPatientInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPatientInformation.DataMember = "TblPatients"
        GridPatientInformation_DesignTimeLayout.LayoutString = resources.GetString("GridPatientInformation_DesignTimeLayout.LayoutString")
        Me.GridPatientInformation.DesignTimeLayout = GridPatientInformation_DesignTimeLayout
        Me.GridPatientInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientInformation.GroupByBoxVisible = False
        Me.GridPatientInformation.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridPatientInformation.HeaderFormatStyle.FontSize = 10.0!
        Me.GridPatientInformation.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridPatientInformation.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPatientInformation.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientInformation.Hierarchical = True
        Me.GridPatientInformation.Location = New System.Drawing.Point(3, 22)
        Me.GridPatientInformation.Name = "GridPatientInformation"
        Me.GridPatientInformation.RecordNavigator = True
        Me.GridPatientInformation.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientInformation.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.GridPatientInformation.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.GrayText
        Me.GridPatientInformation.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque
        Me.GridPatientInformation.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.GrayText
        Me.GridPatientInformation.SelectedInactiveFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque
        Me.GridPatientInformation.Size = New System.Drawing.Size(276, 575)
        Me.GridPatientInformation.TabIndex = 3
        Me.GridPatientInformation.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.Transparent
        Me.BtnFind.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Location = New System.Drawing.Point(9, 199)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(116, 32)
        Me.BtnFind.TabIndex = 8
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'TxtTelephone
        '
        Me.TxtTelephone.Enabled = False
        Me.TxtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelephone.Location = New System.Drawing.Point(10, 166)
        Me.TxtTelephone.Name = "TxtTelephone"
        Me.TxtTelephone.Size = New System.Drawing.Size(186, 26)
        Me.TxtTelephone.TabIndex = 6
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(10, 103)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(186, 26)
        Me.TxtPatientName.TabIndex = 5
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(10, 44)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(186, 26)
        Me.TxtPatientNo.TabIndex = 4
        '
        'RadTelephone
        '
        Me.RadTelephone.AutoSize = True
        Me.RadTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTelephone.Location = New System.Drawing.Point(10, 135)
        Me.RadTelephone.Name = "RadTelephone"
        Me.RadTelephone.Size = New System.Drawing.Size(98, 21)
        Me.RadTelephone.TabIndex = 2
        Me.RadTelephone.TabStop = True
        Me.RadTelephone.Text = "Telephone:"
        Me.RadTelephone.UseVisualStyleBackColor = True
        '
        'RadPatientName
        '
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPatientName.Location = New System.Drawing.Point(10, 76)
        Me.RadPatientName.Name = "RadPatientName"
        Me.RadPatientName.Size = New System.Drawing.Size(115, 21)
        Me.RadPatientName.TabIndex = 1
        Me.RadPatientName.TabStop = True
        Me.RadPatientName.Text = "Patient Name:"
        Me.RadPatientName.UseVisualStyleBackColor = True
        '
        'RadPatientNo
        '
        Me.RadPatientNo.AutoSize = True
        Me.RadPatientNo.Checked = True
        Me.RadPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPatientNo.Location = New System.Drawing.Point(10, 17)
        Me.RadPatientNo.Name = "RadPatientNo"
        Me.RadPatientNo.Size = New System.Drawing.Size(96, 21)
        Me.RadPatientNo.TabIndex = 0
        Me.RadPatientNo.TabStop = True
        Me.RadPatientNo.Text = "Patient No:"
        Me.RadPatientNo.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer2.Size = New System.Drawing.Size(1115, 844)
        Me.SplitContainer2.SplitterDistance = 206
        Me.SplitContainer2.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridHistoy)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1113, 204)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "History"
        '
        'GridHistoy
        '
        Me.GridHistoy.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridHistoy.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridHistoy.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridHistoy_DesignTimeLayout.LayoutString = resources.GetString("GridHistoy_DesignTimeLayout.LayoutString")
        Me.GridHistoy.DesignTimeLayout = GridHistoy_DesignTimeLayout
        Me.GridHistoy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridHistoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridHistoy.GroupByBoxVisible = False
        Me.GridHistoy.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridHistoy.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridHistoy.Location = New System.Drawing.Point(3, 22)
        Me.GridHistoy.Name = "GridHistoy"
        Me.GridHistoy.RecordNavigator = True
        Me.GridHistoy.Size = New System.Drawing.Size(1107, 179)
        Me.GridHistoy.TabIndex = 7
        Me.GridHistoy.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1113, 632)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "History Detail"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.UiTab1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.TxtHistory)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1107, 607)
        Me.Panel1.TabIndex = 0
        '
        'UiTab1
        '
        Me.UiTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTab1.Location = New System.Drawing.Point(8, 117)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(1612, 652)
        Me.UiTab1.TabIndex = 53
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPage3, Me.UiTabPage6})
        Me.UiTab1.TabsStateStyles.HotFormatStyle.FontItalic = Janus.Windows.UI.TriState.[True]
        Me.UiTab1.TabsStateStyles.HotFormatStyle.FontSize = 12.0!
        Me.UiTab1.TabsStateStyles.HotFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003
        '
        'UiTabPage1
        '
        Me.UiTabPage1.AutoScroll = True
        Me.UiTabPage1.Controls.Add(Me.Label1)
        Me.UiTabPage1.Controls.Add(Me.CboDiagnosis)
        Me.UiTabPage1.Controls.Add(Me.Label45)
        Me.UiTabPage1.Controls.Add(Me.CboDoctorConsult)
        Me.UiTabPage1.Controls.Add(Me.TxtMedication)
        Me.UiTabPage1.Controls.Add(Me.GroupMangement)
        Me.UiTabPage1.Controls.Add(Me.Label15)
        Me.UiTabPage1.Controls.Add(Me.TxtDiagnosisNote)
        Me.UiTabPage1.Controls.Add(Me.Label12)
        Me.UiTabPage1.Controls.Add(Me.GroupEye)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1610, 623)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "   Diagnosis(ICD-10)   "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Diagnosis(ICD-10):"
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.DropDownWidth = 500
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(496, 18)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(194, 28)
        Me.CboDiagnosis.TabIndex = 6
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(904, 23)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(65, 13)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "Exam By Dr:"
        '
        'CboDoctorConsult
        '
        Me.CboDoctorConsult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctorConsult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctorConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctorConsult.FormattingEnabled = True
        Me.CboDoctorConsult.Location = New System.Drawing.Point(696, 18)
        Me.CboDoctorConsult.Name = "CboDoctorConsult"
        Me.CboDoctorConsult.Size = New System.Drawing.Size(202, 28)
        Me.CboDoctorConsult.TabIndex = 50
        '
        'TxtMedication
        '
        Me.TxtMedication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtMedication.Location = New System.Drawing.Point(17, 155)
        Me.TxtMedication.Multiline = True
        Me.TxtMedication.Name = "TxtMedication"
        Me.TxtMedication.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMedication.Size = New System.Drawing.Size(1048, 158)
        Me.TxtMedication.TabIndex = 12
        '
        'GroupMangement
        '
        Me.GroupMangement.BackColor = System.Drawing.Color.Transparent
        Me.GroupMangement.Controls.Add(Me.TxtPriceSurgery)
        Me.GroupMangement.Controls.Add(Me.TxtSurgery)
        Me.GroupMangement.Controls.Add(Me.RadManageOutPatient)
        Me.GroupMangement.Controls.Add(Me.RadManageInpatient)
        Me.GroupMangement.Controls.Add(Me.RadManageSurgery)
        Me.GroupMangement.Location = New System.Drawing.Point(165, 63)
        Me.GroupMangement.Name = "GroupMangement"
        Me.GroupMangement.Size = New System.Drawing.Size(804, 51)
        Me.GroupMangement.TabIndex = 27
        Me.GroupMangement.TabStop = False
        '
        'TxtPriceSurgery
        '
        Me.TxtPriceSurgery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPriceSurgery.Enabled = False
        Me.TxtPriceSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPriceSurgery.Location = New System.Drawing.Point(601, 16)
        Me.TxtPriceSurgery.Name = "TxtPriceSurgery"
        Me.TxtPriceSurgery.Size = New System.Drawing.Size(162, 26)
        Me.TxtPriceSurgery.TabIndex = 13
        Me.TxtPriceSurgery.Text = "0"
        Me.TxtPriceSurgery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSurgery
        '
        Me.TxtSurgery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSurgery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtSurgery.DropDownWidth = 500
        Me.TxtSurgery.Enabled = False
        Me.TxtSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurgery.FormattingEnabled = True
        Me.TxtSurgery.Location = New System.Drawing.Point(368, 15)
        Me.TxtSurgery.Name = "TxtSurgery"
        Me.TxtSurgery.Size = New System.Drawing.Size(223, 28)
        Me.TxtSurgery.TabIndex = 12
        '
        'RadManageOutPatient
        '
        Me.RadManageOutPatient.AutoSize = True
        Me.RadManageOutPatient.BackColor = System.Drawing.Color.Transparent
        Me.RadManageOutPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadManageOutPatient.ForeColor = System.Drawing.Color.Blue
        Me.RadManageOutPatient.Location = New System.Drawing.Point(13, 19)
        Me.RadManageOutPatient.Name = "RadManageOutPatient"
        Me.RadManageOutPatient.Size = New System.Drawing.Size(107, 24)
        Me.RadManageOutPatient.TabIndex = 9
        Me.RadManageOutPatient.TabStop = True
        Me.RadManageOutPatient.Text = "Out Patient"
        Me.RadManageOutPatient.UseVisualStyleBackColor = False
        '
        'RadManageInpatient
        '
        Me.RadManageInpatient.AutoSize = True
        Me.RadManageInpatient.BackColor = System.Drawing.Color.Transparent
        Me.RadManageInpatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadManageInpatient.ForeColor = System.Drawing.Color.Blue
        Me.RadManageInpatient.Location = New System.Drawing.Point(132, 19)
        Me.RadManageInpatient.Name = "RadManageInpatient"
        Me.RadManageInpatient.Size = New System.Drawing.Size(90, 24)
        Me.RadManageInpatient.TabIndex = 10
        Me.RadManageInpatient.TabStop = True
        Me.RadManageInpatient.Text = "Inpatient"
        Me.RadManageInpatient.UseVisualStyleBackColor = False
        '
        'RadManageSurgery
        '
        Me.RadManageSurgery.AutoSize = True
        Me.RadManageSurgery.BackColor = System.Drawing.Color.Transparent
        Me.RadManageSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadManageSurgery.ForeColor = System.Drawing.Color.Blue
        Me.RadManageSurgery.Location = New System.Drawing.Point(242, 19)
        Me.RadManageSurgery.Name = "RadManageSurgery"
        Me.RadManageSurgery.Size = New System.Drawing.Size(82, 24)
        Me.RadManageSurgery.TabIndex = 11
        Me.RadManageSurgery.TabStop = True
        Me.RadManageSurgery.Text = "Surgery"
        Me.RadManageSurgery.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(13, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 20)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Management Note:"
        '
        'TxtDiagnosisNote
        '
        Me.TxtDiagnosisNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiagnosisNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtDiagnosisNote.Location = New System.Drawing.Point(925, 87)
        Me.TxtDiagnosisNote.Multiline = True
        Me.TxtDiagnosisNote.Name = "TxtDiagnosisNote"
        Me.TxtDiagnosisNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDiagnosisNote.Size = New System.Drawing.Size(682, 37)
        Me.TxtDiagnosisNote.TabIndex = 8
        Me.TxtDiagnosisNote.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(13, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Management"
        '
        'GroupEye
        '
        Me.GroupEye.BackColor = System.Drawing.Color.Transparent
        Me.GroupEye.Controls.Add(Me.RadDiagnosisRighEye)
        Me.GroupEye.Controls.Add(Me.RadDiagnosisBothEyes)
        Me.GroupEye.Controls.Add(Me.RadDiagnosisLefEye)
        Me.GroupEye.Location = New System.Drawing.Point(169, 5)
        Me.GroupEye.Name = "GroupEye"
        Me.GroupEye.Size = New System.Drawing.Size(321, 52)
        Me.GroupEye.TabIndex = 28
        Me.GroupEye.TabStop = False
        '
        'RadDiagnosisRighEye
        '
        Me.RadDiagnosisRighEye.AutoSize = True
        Me.RadDiagnosisRighEye.BackColor = System.Drawing.Color.Transparent
        Me.RadDiagnosisRighEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDiagnosisRighEye.ForeColor = System.Drawing.Color.Blue
        Me.RadDiagnosisRighEye.Location = New System.Drawing.Point(6, 19)
        Me.RadDiagnosisRighEye.Name = "RadDiagnosisRighEye"
        Me.RadDiagnosisRighEye.Size = New System.Drawing.Size(96, 24)
        Me.RadDiagnosisRighEye.TabIndex = 3
        Me.RadDiagnosisRighEye.TabStop = True
        Me.RadDiagnosisRighEye.Text = "Right Eye"
        Me.RadDiagnosisRighEye.UseVisualStyleBackColor = False
        '
        'RadDiagnosisBothEyes
        '
        Me.RadDiagnosisBothEyes.AutoSize = True
        Me.RadDiagnosisBothEyes.BackColor = System.Drawing.Color.Transparent
        Me.RadDiagnosisBothEyes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDiagnosisBothEyes.ForeColor = System.Drawing.Color.Blue
        Me.RadDiagnosisBothEyes.Location = New System.Drawing.Point(204, 18)
        Me.RadDiagnosisBothEyes.Name = "RadDiagnosisBothEyes"
        Me.RadDiagnosisBothEyes.Size = New System.Drawing.Size(100, 24)
        Me.RadDiagnosisBothEyes.TabIndex = 5
        Me.RadDiagnosisBothEyes.TabStop = True
        Me.RadDiagnosisBothEyes.Text = "Both Eyes"
        Me.RadDiagnosisBothEyes.UseVisualStyleBackColor = False
        '
        'RadDiagnosisLefEye
        '
        Me.RadDiagnosisLefEye.AutoSize = True
        Me.RadDiagnosisLefEye.BackColor = System.Drawing.Color.Transparent
        Me.RadDiagnosisLefEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDiagnosisLefEye.ForeColor = System.Drawing.Color.Blue
        Me.RadDiagnosisLefEye.Location = New System.Drawing.Point(108, 19)
        Me.RadDiagnosisLefEye.Name = "RadDiagnosisLefEye"
        Me.RadDiagnosisLefEye.Size = New System.Drawing.Size(86, 24)
        Me.RadDiagnosisLefEye.TabIndex = 4
        Me.RadDiagnosisLefEye.TabStop = True
        Me.RadDiagnosisLefEye.Text = "Left Eye"
        Me.RadDiagnosisLefEye.UseVisualStyleBackColor = False
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.GridPrescription)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1610, 623)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "     Prescription    "
        '
        'GridPrescription
        '
        Me.GridPrescription.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridPrescription.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        GridPrescription_DesignTimeLayout.LayoutString = resources.GetString("GridPrescription_DesignTimeLayout.LayoutString")
        Me.GridPrescription.DesignTimeLayout = GridPrescription_DesignTimeLayout
        Me.GridPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridPrescription.GroupByBoxVisible = False
        Me.GridPrescription.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridPrescription.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPrescription.Location = New System.Drawing.Point(0, 0)
        Me.GridPrescription.Name = "GridPrescription"
        Me.GridPrescription.RecordNavigator = True
        Me.GridPrescription.Size = New System.Drawing.Size(1610, 623)
        Me.GridPrescription.TabIndex = 0
        Me.GridPrescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.GridImageList)
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(1610, 623)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "    Image    "
        '
        'GridImageList
        '
        Me.GridImageList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridImageList.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D
        Me.GridImageList.CardBorders = False
        Me.GridImageList.CardColumnHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridImageList.CardHeaders = False
        Me.GridImageList.CardSpacing = 5
        Me.GridImageList.CardWidth = 200
        Me.GridImageList.CenterSingleCard = False
        GridImageList_DesignTimeLayout.LayoutString = resources.GetString("GridImageList_DesignTimeLayout.LayoutString")
        Me.GridImageList.DesignTimeLayout = GridImageList_DesignTimeLayout
        Me.GridImageList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridImageList.GroupByBoxVisible = False
        Me.GridImageList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridImageList.Location = New System.Drawing.Point(3, 18)
        Me.GridImageList.Name = "GridImageList"
        Me.GridImageList.Size = New System.Drawing.Size(4041, 209)
        Me.GridImageList.TabIndex = 18
        Me.GridImageList.View = Janus.Windows.GridEX.View.CardView
        '
        'UiTabPage6
        '
        Me.UiTabPage6.Controls.Add(Me.GridOT)
        Me.UiTabPage6.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage6.Name = "UiTabPage6"
        Me.UiTabPage6.Size = New System.Drawing.Size(1610, 623)
        Me.UiTabPage6.TabStop = True
        Me.UiTabPage6.Text = "     Operation Note    "
        '
        'GridOT
        '
        Me.GridOT.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridOT.ContextMenuStrip = Me.MenuOperationNote
        GridOT_DesignTimeLayout.LayoutString = resources.GetString("GridOT_DesignTimeLayout.LayoutString")
        Me.GridOT.DesignTimeLayout = GridOT_DesignTimeLayout
        Me.GridOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridOT.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridOT.GroupByBoxVisible = False
        Me.GridOT.HeaderFormatStyle.FontSize = 12.0!
        Me.GridOT.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridOT.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridOT.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridOT.Hierarchical = True
        Me.GridOT.Location = New System.Drawing.Point(0, 0)
        Me.GridOT.Name = "GridOT"
        Me.GridOT.RecordNavigator = True
        Me.GridOT.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridOT.Size = New System.Drawing.Size(1610, 623)
        Me.GridOT.TabIndex = 6
        Me.GridOT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MenuOperationNote
        '
        Me.MenuOperationNote.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUpdateOPNote, Me.ToolStripMenuItem2, Me.BtnPrintPreview})
        Me.MenuOperationNote.Name = "MenuOperationNote"
        Me.MenuOperationNote.Size = New System.Drawing.Size(240, 62)
        '
        'BtnUpdateOPNote
        '
        Me.BtnUpdateOPNote.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnUpdateOPNote.Name = "BtnUpdateOPNote"
        Me.BtnUpdateOPNote.Size = New System.Drawing.Size(239, 26)
        Me.BtnUpdateOPNote.Text = "Update Operation Note"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(236, 6)
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(239, 26)
        Me.BtnPrintPreview.Text = "Print Preview"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(992, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(7, 2)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(139, 20)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Finding / Complain"
        '
        'TxtHistory
        '
        Me.TxtHistory.BackColor = System.Drawing.Color.White
        Me.TxtHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHistory.Location = New System.Drawing.Point(9, 27)
        Me.TxtHistory.Multiline = True
        Me.TxtHistory.Name = "TxtHistory"
        Me.TxtHistory.ReadOnly = True
        Me.TxtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtHistory.Size = New System.Drawing.Size(431, 79)
        Me.TxtHistory.TabIndex = 44
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtIOPLE)
        Me.GroupBox6.Controls.Add(Me.TxtIOPRE)
        Me.GroupBox6.Controls.Add(Me.TxtLLe1)
        Me.GroupBox6.Controls.Add(Me.TxtRRe1)
        Me.GroupBox6.Controls.Add(Me.TxtLRef1)
        Me.GroupBox6.Controls.Add(Me.TxtREF1)
        Me.GroupBox6.Controls.Add(Me.TxtLPh1)
        Me.GroupBox6.Controls.Add(Me.TxtRPh1)
        Me.GroupBox6.Controls.Add(Me.TxtLe1)
        Me.GroupBox6.Controls.Add(Me.TxtRE1)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(445, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(541, 102)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Visual Acuity"
        '
        'TxtLLe1
        '
        Me.TxtLLe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLLe1.Location = New System.Drawing.Point(391, 64)
        Me.TxtLLe1.Name = "TxtLLe1"
        Me.TxtLLe1.ReadOnly = True
        Me.TxtLLe1.Size = New System.Drawing.Size(67, 26)
        Me.TxtLLe1.TabIndex = 7
        Me.TxtLLe1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRRe1
        '
        Me.TxtRRe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRRe1.Location = New System.Drawing.Point(391, 29)
        Me.TxtRRe1.Name = "TxtRRe1"
        Me.TxtRRe1.ReadOnly = True
        Me.TxtRRe1.Size = New System.Drawing.Size(67, 26)
        Me.TxtRRe1.TabIndex = 3
        Me.TxtRRe1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLRef1
        '
        Me.TxtLRef1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLRef1.Location = New System.Drawing.Point(282, 64)
        Me.TxtLRef1.Name = "TxtLRef1"
        Me.TxtLRef1.ReadOnly = True
        Me.TxtLRef1.Size = New System.Drawing.Size(66, 26)
        Me.TxtLRef1.TabIndex = 6
        Me.TxtLRef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtREF1
        '
        Me.TxtREF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtREF1.Location = New System.Drawing.Point(282, 29)
        Me.TxtREF1.Name = "TxtREF1"
        Me.TxtREF1.ReadOnly = True
        Me.TxtREF1.Size = New System.Drawing.Size(66, 26)
        Me.TxtREF1.TabIndex = 2
        Me.TxtREF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLPh1
        '
        Me.TxtLPh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLPh1.Location = New System.Drawing.Point(163, 64)
        Me.TxtLPh1.Name = "TxtLPh1"
        Me.TxtLPh1.ReadOnly = True
        Me.TxtLPh1.Size = New System.Drawing.Size(63, 26)
        Me.TxtLPh1.TabIndex = 5
        Me.TxtLPh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRPh1
        '
        Me.TxtRPh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRPh1.Location = New System.Drawing.Point(163, 29)
        Me.TxtRPh1.Name = "TxtRPh1"
        Me.TxtRPh1.ReadOnly = True
        Me.TxtRPh1.Size = New System.Drawing.Size(63, 26)
        Me.TxtRPh1.TabIndex = 1
        Me.TxtRPh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLe1
        '
        Me.TxtLe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLe1.Location = New System.Drawing.Point(51, 64)
        Me.TxtLe1.Name = "TxtLe1"
        Me.TxtLe1.ReadOnly = True
        Me.TxtLe1.Size = New System.Drawing.Size(72, 26)
        Me.TxtLe1.TabIndex = 4
        Me.TxtLe1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRE1
        '
        Me.TxtRE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRE1.Location = New System.Drawing.Point(51, 29)
        Me.TxtRE1.Name = "TxtRE1"
        Me.TxtRE1.ReadOnly = True
        Me.TxtRE1.Size = New System.Drawing.Size(72, 26)
        Me.TxtRE1.TabIndex = 0
        Me.TxtRE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(483, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "IOP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(352, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 20)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "LE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(352, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "RE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(234, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 20)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "REF"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(232, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 20)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "REF"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(129, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 20)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Ph"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(127, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Ph"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 20)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "LE"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 35)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 20)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "RE"
        '
        'TxtIOPLE
        '
        Me.TxtIOPLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIOPLE.Location = New System.Drawing.Point(461, 64)
        Me.TxtIOPLE.Name = "TxtIOPLE"
        Me.TxtIOPLE.ReadOnly = True
        Me.TxtIOPLE.Size = New System.Drawing.Size(72, 26)
        Me.TxtIOPLE.TabIndex = 12
        Me.TxtIOPLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIOPRE
        '
        Me.TxtIOPRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIOPRE.Location = New System.Drawing.Point(461, 29)
        Me.TxtIOPRE.Name = "TxtIOPRE"
        Me.TxtIOPRE.ReadOnly = True
        Me.TxtIOPRE.Size = New System.Drawing.Size(72, 26)
        Me.TxtIOPRE.TabIndex = 11
        Me.TxtIOPRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DashboardPatientHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardPatientHistory"
        Me.Size = New System.Drawing.Size(1411, 904)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridHistoy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        Me.GroupMangement.ResumeLayout(False)
        Me.GroupMangement.PerformLayout()
        Me.GroupEye.ResumeLayout(False)
        Me.GroupEye.PerformLayout()
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage3.ResumeLayout(False)
        CType(Me.GridImageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage6.ResumeLayout(False)
        CType(Me.GridOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuOperationNote.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridHistoy As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents CboDoctorConsult As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents GroupEye As System.Windows.Forms.GroupBox
    Friend WithEvents RadDiagnosisRighEye As System.Windows.Forms.RadioButton
    Friend WithEvents RadDiagnosisBothEyes As System.Windows.Forms.RadioButton
    Friend WithEvents RadDiagnosisLefEye As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDiagnosisNote As System.Windows.Forms.TextBox
    Friend WithEvents GroupMangement As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPriceSurgery As System.Windows.Forms.TextBox
    Friend WithEvents TxtSurgery As System.Windows.Forms.ComboBox
    Friend WithEvents RadManageOutPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadManageInpatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadManageSurgery As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtMedication As System.Windows.Forms.TextBox
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridImageList As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtHistory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtLLe1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtRRe1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLRef1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtREF1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLPh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtRPh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLe1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtRE1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdateConsult As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadTelephone As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPatientInformation As Janus.Windows.GridEX.GridEX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage6 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridOT As Janus.Windows.GridEX.GridEX
    Friend WithEvents MenuOperationNote As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnUpdateOPNote As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtIOPLE As System.Windows.Forms.TextBox
    Friend WithEvents TxtIOPRE As System.Windows.Forms.TextBox

End Class
