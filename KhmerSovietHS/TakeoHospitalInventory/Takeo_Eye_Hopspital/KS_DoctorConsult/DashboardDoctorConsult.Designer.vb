<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardDoctorConsult
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
        Dim GridPatientWaiting_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardDoctorConsult))
        Dim GridOT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridHistoy_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridImageList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridFollowUp_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridPatientWaiting = New Janus.Windows.GridEX.GridEX
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.UiTab4 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage6 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtIOPLE = New System.Windows.Forms.TextBox
        Me.TxtIOPRE = New System.Windows.Forms.TextBox
        Me.TxtLLE = New System.Windows.Forms.TextBox
        Me.TxtRRE = New System.Windows.Forms.TextBox
        Me.TxtLREF = New System.Windows.Forms.TextBox
        Me.TxtRREF = New System.Windows.Forms.TextBox
        Me.TxtLPh = New System.Windows.Forms.TextBox
        Me.TxtRPh = New System.Windows.Forms.TextBox
        Me.TxtLE = New System.Windows.Forms.TextBox
        Me.TxtRE = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.UiTabPage9 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridOT = New Janus.Windows.GridEX.GridEX
        Me.MenuOperationNote = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnUpdateOPNote = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintPreview = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridHistoy = New Janus.Windows.GridEX.GridEX
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UiTab2 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTab3 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage7 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage8 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridImageList = New Janus.Windows.GridEX.GridEX
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.CboDoctorConsult = New System.Windows.Forms.ComboBox
        Me.TxtMedication = New System.Windows.Forms.TextBox
        Me.TxtDiagnosisNote = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupEye = New System.Windows.Forms.GroupBox
        Me.RadDiagnosisRighEye = New System.Windows.Forms.RadioButton
        Me.RadDiagnosisBothEyes = New System.Windows.Forms.RadioButton
        Me.RadDiagnosisLefEye = New System.Windows.Forms.RadioButton
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtDiagnosisCode = New System.Windows.Forms.TextBox
        Me.GroupMangement = New System.Windows.Forms.GroupBox
        Me.TxtPriceSurgery = New System.Windows.Forms.TextBox
        Me.TxtSurgery = New System.Windows.Forms.ComboBox
        Me.RadManageOutPatient = New System.Windows.Forms.RadioButton
        Me.RadManageInpatient = New System.Windows.Forms.RadioButton
        Me.RadManageSurgery = New System.Windows.Forms.RadioButton
        Me.Label26 = New System.Windows.Forms.Label
        Me.TxtHistory = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtIOPLE_His = New System.Windows.Forms.TextBox
        Me.TxtIOPRE_His = New System.Windows.Forms.TextBox
        Me.TxtLLe1_His = New System.Windows.Forms.TextBox
        Me.TxtRRe1_His = New System.Windows.Forms.TextBox
        Me.TxtLRef1_His = New System.Windows.Forms.TextBox
        Me.TxtREF1_His = New System.Windows.Forms.TextBox
        Me.TxtLPh1_His = New System.Windows.Forms.TextBox
        Me.TxtRPh1_His = New System.Windows.Forms.TextBox
        Me.TxtLe1_His = New System.Windows.Forms.TextBox
        Me.TxtRE1His = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnStartConsult = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRefreshData = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteWaiting = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPatientHistory = New System.Windows.Forms.ToolStripButton
        Me.ContextMenuFollowUp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnNewConsultFollow = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancelFollowUP = New System.Windows.Forms.ToolStripMenuItem
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridFollowUp = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnSendToConsult = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.NewPatientFollowupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridPatientWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiTab4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab4.SuspendLayout()
        Me.UiTabPage6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.UiTabPage9.SuspendLayout()
        CType(Me.GridOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuOperationNote.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridHistoy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab2.SuspendLayout()
        Me.UiTabPage4.SuspendLayout()
        CType(Me.UiTab3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab3.SuspendLayout()
        Me.UiTabPage7.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage8.SuspendLayout()
        CType(Me.GridImageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupEye.SuspendLayout()
        Me.GroupMangement.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuFollowUp.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.UiTabPage3.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.GridFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UiTab4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1263, 1059)
        Me.SplitContainer1.SplitterDistance = 704
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox9)
        Me.SplitContainer3.Size = New System.Drawing.Size(1263, 704)
        Me.SplitContainer3.SplitterDistance = 1010
        Me.SplitContainer3.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridPatientWaiting)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1008, 702)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ចំនួនអ្នកជំងឺរងចាំ"
        '
        'GridPatientWaiting
        '
        Me.GridPatientWaiting.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPatientWaiting.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridPatientWaiting.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridPatientWaiting_DesignTimeLayout.LayoutString = resources.GetString("GridPatientWaiting_DesignTimeLayout.LayoutString")
        Me.GridPatientWaiting.DesignTimeLayout = GridPatientWaiting_DesignTimeLayout
        Me.GridPatientWaiting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientWaiting.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridPatientWaiting.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridPatientWaiting.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridPatientWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientWaiting.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPatientWaiting.GroupByBoxVisible = False
        Me.GridPatientWaiting.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridPatientWaiting.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientWaiting.Location = New System.Drawing.Point(3, 33)
        Me.GridPatientWaiting.Name = "GridPatientWaiting"
        Me.GridPatientWaiting.RecordNavigator = True
        Me.GridPatientWaiting.RowFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.SelectedFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridPatientWaiting.SelectedFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPatientWaiting.Size = New System.Drawing.Size(1002, 666)
        Me.GridPatientWaiting.TabIndex = 6
        Me.GridPatientWaiting.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.PictureBox1)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(247, 702)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "រូបភាព"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(4, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 253)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UiTab4
        '
        Me.UiTab4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab4.Location = New System.Drawing.Point(0, 0)
        Me.UiTab4.Name = "UiTab4"
        Me.UiTab4.Size = New System.Drawing.Size(1261, 349)
        Me.UiTab4.TabIndex = 1
        Me.UiTab4.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage6, Me.UiTabPage9})
        Me.UiTab4.TabsStateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.UiTab4.TabsStateStyles.HotFormatStyle.FontItalic = Janus.Windows.UI.TriState.[True]
        Me.UiTab4.TabsStateStyles.HotFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTab4.TabStripFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.UiTab4.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003
        '
        'UiTabPage6
        '
        Me.UiTabPage6.Controls.Add(Me.GroupBox1)
        Me.UiTabPage6.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage6.Name = "UiTabPage6"
        Me.UiTabPage6.Size = New System.Drawing.Size(1259, 320)
        Me.UiTabPage6.TabStop = True
        Me.UiTabPage6.Text = "    New Visual Acuity    "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNote)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1259, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtNote
        '
        Me.TxtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNote.BackColor = System.Drawing.Color.White
        Me.TxtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNote.Location = New System.Drawing.Point(6, 45)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.ReadOnly = True
        Me.TxtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtNote.Size = New System.Drawing.Size(1247, 83)
        Me.TxtNote.TabIndex = 17
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(6, 22)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(128, 20)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Complain/History"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtIOPLE)
        Me.GroupBox2.Controls.Add(Me.TxtIOPRE)
        Me.GroupBox2.Controls.Add(Me.TxtLLE)
        Me.GroupBox2.Controls.Add(Me.TxtRRE)
        Me.GroupBox2.Controls.Add(Me.TxtLREF)
        Me.GroupBox2.Controls.Add(Me.TxtRREF)
        Me.GroupBox2.Controls.Add(Me.TxtLPh)
        Me.GroupBox2.Controls.Add(Me.TxtRPh)
        Me.GroupBox2.Controls.Add(Me.TxtLE)
        Me.GroupBox2.Controls.Add(Me.TxtRE)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1253, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Visual Acuity"
        '
        'TxtIOPLE
        '
        Me.TxtIOPLE.BackColor = System.Drawing.Color.White
        Me.TxtIOPLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIOPLE.Location = New System.Drawing.Point(659, 71)
        Me.TxtIOPLE.Name = "TxtIOPLE"
        Me.TxtIOPLE.ReadOnly = True
        Me.TxtIOPLE.Size = New System.Drawing.Size(82, 26)
        Me.TxtIOPLE.TabIndex = 10
        Me.TxtIOPLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIOPRE
        '
        Me.TxtIOPRE.BackColor = System.Drawing.Color.White
        Me.TxtIOPRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIOPRE.Location = New System.Drawing.Point(659, 39)
        Me.TxtIOPRE.Name = "TxtIOPRE"
        Me.TxtIOPRE.ReadOnly = True
        Me.TxtIOPRE.Size = New System.Drawing.Size(82, 26)
        Me.TxtIOPRE.TabIndex = 9
        Me.TxtIOPRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLLE
        '
        Me.TxtLLE.BackColor = System.Drawing.Color.White
        Me.TxtLLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLLE.Location = New System.Drawing.Point(548, 71)
        Me.TxtLLE.Name = "TxtLLE"
        Me.TxtLLE.ReadOnly = True
        Me.TxtLLE.Size = New System.Drawing.Size(82, 26)
        Me.TxtLLE.TabIndex = 7
        Me.TxtLLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRRE
        '
        Me.TxtRRE.BackColor = System.Drawing.Color.White
        Me.TxtRRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRRE.Location = New System.Drawing.Point(548, 39)
        Me.TxtRRE.Name = "TxtRRE"
        Me.TxtRRE.ReadOnly = True
        Me.TxtRRE.Size = New System.Drawing.Size(82, 26)
        Me.TxtRRE.TabIndex = 6
        Me.TxtRRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLREF
        '
        Me.TxtLREF.BackColor = System.Drawing.Color.White
        Me.TxtLREF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLREF.Location = New System.Drawing.Point(375, 71)
        Me.TxtLREF.Name = "TxtLREF"
        Me.TxtLREF.ReadOnly = True
        Me.TxtLREF.Size = New System.Drawing.Size(123, 26)
        Me.TxtLREF.TabIndex = 5
        Me.TxtLREF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRREF
        '
        Me.TxtRREF.BackColor = System.Drawing.Color.White
        Me.TxtRREF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRREF.Location = New System.Drawing.Point(375, 39)
        Me.TxtRREF.Name = "TxtRREF"
        Me.TxtRREF.ReadOnly = True
        Me.TxtRREF.Size = New System.Drawing.Size(123, 26)
        Me.TxtRREF.TabIndex = 4
        Me.TxtRREF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLPh
        '
        Me.TxtLPh.BackColor = System.Drawing.Color.White
        Me.TxtLPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLPh.Location = New System.Drawing.Point(218, 71)
        Me.TxtLPh.Name = "TxtLPh"
        Me.TxtLPh.ReadOnly = True
        Me.TxtLPh.Size = New System.Drawing.Size(104, 26)
        Me.TxtLPh.TabIndex = 3
        Me.TxtLPh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRPh
        '
        Me.TxtRPh.BackColor = System.Drawing.Color.White
        Me.TxtRPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRPh.Location = New System.Drawing.Point(218, 39)
        Me.TxtRPh.Name = "TxtRPh"
        Me.TxtRPh.ReadOnly = True
        Me.TxtRPh.Size = New System.Drawing.Size(104, 26)
        Me.TxtRPh.TabIndex = 2
        Me.TxtRPh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLE
        '
        Me.TxtLE.BackColor = System.Drawing.Color.White
        Me.TxtLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLE.Location = New System.Drawing.Point(48, 71)
        Me.TxtLE.Name = "TxtLE"
        Me.TxtLE.ReadOnly = True
        Me.TxtLE.Size = New System.Drawing.Size(123, 26)
        Me.TxtLE.TabIndex = 1
        Me.TxtLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRE
        '
        Me.TxtRE.BackColor = System.Drawing.Color.White
        Me.TxtRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRE.Location = New System.Drawing.Point(48, 39)
        Me.TxtRE.Name = "TxtRE"
        Me.TxtRE.ReadOnly = True
        Me.TxtRE.Size = New System.Drawing.Size(123, 26)
        Me.TxtRE.TabIndex = 0
        Me.TxtRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(679, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "IOP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(509, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "LE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(509, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "RE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "REF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "REF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ph"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ph"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RE"
        '
        'UiTabPage9
        '
        Me.UiTabPage9.Controls.Add(Me.GridOT)
        Me.UiTabPage9.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage9.Name = "UiTabPage9"
        Me.UiTabPage9.Size = New System.Drawing.Size(1259, 460)
        Me.UiTabPage9.TabStop = True
        Me.UiTabPage9.Text = "     Operation Note History    "
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
        Me.GridOT.Size = New System.Drawing.Size(1259, 460)
        Me.GridOT.TabIndex = 4
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1263, 1059)
        Me.SplitContainer2.SplitterDistance = 258
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridHistoy)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1261, 256)
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
        Me.GridHistoy.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridHistoy.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridHistoy.Location = New System.Drawing.Point(3, 22)
        Me.GridHistoy.Name = "GridHistoy"
        Me.GridHistoy.RecordNavigator = True
        Me.GridHistoy.RowFormatStyle.FontSize = 12.0!
        Me.GridHistoy.Size = New System.Drawing.Size(1255, 231)
        Me.GridHistoy.TabIndex = 7
        Me.GridHistoy.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1261, 795)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "History Detail"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.UiTab2)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.TxtHistory)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 770)
        Me.Panel1.TabIndex = 0
        '
        'UiTab2
        '
        Me.UiTab2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTab2.Location = New System.Drawing.Point(7, 105)
        Me.UiTab2.Name = "UiTab2"
        Me.UiTab2.Size = New System.Drawing.Size(1216, 665)
        Me.UiTab2.TabIndex = 52
        Me.UiTab2.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage4})
        Me.UiTab2.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003
        '
        'UiTabPage4
        '
        Me.UiTabPage4.AutoScroll = True
        Me.UiTabPage4.Controls.Add(Me.UiTab3)
        Me.UiTabPage4.Controls.Add(Me.Label15)
        Me.UiTabPage4.Controls.Add(Me.Label45)
        Me.UiTabPage4.Controls.Add(Me.CboDoctorConsult)
        Me.UiTabPage4.Controls.Add(Me.TxtMedication)
        Me.UiTabPage4.Controls.Add(Me.TxtDiagnosisNote)
        Me.UiTabPage4.Controls.Add(Me.Label12)
        Me.UiTabPage4.Controls.Add(Me.Label1)
        Me.UiTabPage4.Controls.Add(Me.GroupEye)
        Me.UiTabPage4.Controls.Add(Me.CboDiagnosis)
        Me.UiTabPage4.Controls.Add(Me.Label11)
        Me.UiTabPage4.Controls.Add(Me.TxtDiagnosisCode)
        Me.UiTabPage4.Controls.Add(Me.GroupMangement)
        Me.UiTabPage4.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(1214, 636)
        Me.UiTabPage4.TabStop = True
        Me.UiTabPage4.Text = "      Diagnosis(ICD-10)      "
        '
        'UiTab3
        '
        Me.UiTab3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UiTab3.Location = New System.Drawing.Point(0, 220)
        Me.UiTab3.Name = "UiTab3"
        Me.UiTab3.Size = New System.Drawing.Size(2041, 399)
        Me.UiTab3.TabIndex = 52
        Me.UiTab3.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage7, Me.UiTabPage8})
        Me.UiTab3.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage7
        '
        Me.UiTabPage7.Controls.Add(Me.GridPrescription)
        Me.UiTabPage7.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage7.Name = "UiTabPage7"
        Me.UiTabPage7.Size = New System.Drawing.Size(2039, 370)
        Me.UiTabPage7.TabStop = True
        Me.UiTabPage7.Text = "      Prescription     "
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
        Me.GridPrescription.Size = New System.Drawing.Size(2039, 370)
        Me.GridPrescription.TabIndex = 1
        Me.GridPrescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'UiTabPage8
        '
        Me.UiTabPage8.Controls.Add(Me.GridImageList)
        Me.UiTabPage8.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage8.Name = "UiTabPage8"
        Me.UiTabPage8.Size = New System.Drawing.Size(2039, 370)
        Me.UiTabPage8.TabStop = True
        Me.UiTabPage8.Text = "   Images    "
        '
        'GridImageList
        '
        Me.GridImageList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridImageList.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.GridImageList.Location = New System.Drawing.Point(3, 13)
        Me.GridImageList.Name = "GridImageList"
        Me.GridImageList.Size = New System.Drawing.Size(2025, 463)
        Me.GridImageList.TabIndex = 18
        Me.GridImageList.View = Janus.Windows.GridEX.View.CardView
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(3, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 20)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Management Note:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(981, 4)
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
        Me.CboDoctorConsult.Location = New System.Drawing.Point(944, 23)
        Me.CboDoctorConsult.Name = "CboDoctorConsult"
        Me.CboDoctorConsult.Size = New System.Drawing.Size(167, 28)
        Me.CboDoctorConsult.TabIndex = 50
        '
        'TxtMedication
        '
        Me.TxtMedication.BackColor = System.Drawing.Color.White
        Me.TxtMedication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtMedication.Location = New System.Drawing.Point(157, 117)
        Me.TxtMedication.Multiline = True
        Me.TxtMedication.Name = "TxtMedication"
        Me.TxtMedication.ReadOnly = True
        Me.TxtMedication.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMedication.Size = New System.Drawing.Size(1106, 92)
        Me.TxtMedication.TabIndex = 12
        '
        'TxtDiagnosisNote
        '
        Me.TxtDiagnosisNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiagnosisNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtDiagnosisNote.Location = New System.Drawing.Point(1065, 117)
        Me.TxtDiagnosisNote.Multiline = True
        Me.TxtDiagnosisNote.Name = "TxtDiagnosisNote"
        Me.TxtDiagnosisNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDiagnosisNote.Size = New System.Drawing.Size(976, 46)
        Me.TxtDiagnosisNote.TabIndex = 8
        Me.TxtDiagnosisNote.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(3, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Management"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(1, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Diagnosis(ICD-10):"
        '
        'GroupEye
        '
        Me.GroupEye.BackColor = System.Drawing.Color.Transparent
        Me.GroupEye.Controls.Add(Me.RadDiagnosisRighEye)
        Me.GroupEye.Controls.Add(Me.RadDiagnosisBothEyes)
        Me.GroupEye.Controls.Add(Me.RadDiagnosisLefEye)
        Me.GroupEye.Location = New System.Drawing.Point(157, 5)
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
        Me.RadDiagnosisBothEyes.Location = New System.Drawing.Point(209, 18)
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
        Me.RadDiagnosisLefEye.Location = New System.Drawing.Point(115, 19)
        Me.RadDiagnosisLefEye.Name = "RadDiagnosisLefEye"
        Me.RadDiagnosisLefEye.Size = New System.Drawing.Size(86, 24)
        Me.RadDiagnosisLefEye.TabIndex = 4
        Me.RadDiagnosisLefEye.TabStop = True
        Me.RadDiagnosisLefEye.Text = "Left Eye"
        Me.RadDiagnosisLefEye.UseVisualStyleBackColor = False
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.DropDownWidth = 500
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(577, 23)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(223, 28)
        Me.CboDiagnosis.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(482, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Diagnosis"
        '
        'TxtDiagnosisCode
        '
        Me.TxtDiagnosisCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiagnosisCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiagnosisCode.Location = New System.Drawing.Point(806, 25)
        Me.TxtDiagnosisCode.Name = "TxtDiagnosisCode"
        Me.TxtDiagnosisCode.Size = New System.Drawing.Size(132, 26)
        Me.TxtDiagnosisCode.TabIndex = 7
        Me.TxtDiagnosisCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupMangement
        '
        Me.GroupMangement.BackColor = System.Drawing.Color.Transparent
        Me.GroupMangement.Controls.Add(Me.TxtPriceSurgery)
        Me.GroupMangement.Controls.Add(Me.TxtSurgery)
        Me.GroupMangement.Controls.Add(Me.RadManageOutPatient)
        Me.GroupMangement.Controls.Add(Me.RadManageInpatient)
        Me.GroupMangement.Controls.Add(Me.RadManageSurgery)
        Me.GroupMangement.Location = New System.Drawing.Point(157, 55)
        Me.GroupMangement.Name = "GroupMangement"
        Me.GroupMangement.Size = New System.Drawing.Size(954, 51)
        Me.GroupMangement.TabIndex = 27
        Me.GroupMangement.TabStop = False
        '
        'TxtPriceSurgery
        '
        Me.TxtPriceSurgery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPriceSurgery.Enabled = False
        Me.TxtPriceSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPriceSurgery.Location = New System.Drawing.Point(584, 16)
        Me.TxtPriceSurgery.Name = "TxtPriceSurgery"
        Me.TxtPriceSurgery.Size = New System.Drawing.Size(132, 26)
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
        Me.TxtSurgery.Location = New System.Drawing.Point(329, 15)
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
        Me.RadManageOutPatient.Location = New System.Drawing.Point(6, 19)
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
        Me.RadManageInpatient.Location = New System.Drawing.Point(115, 19)
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
        Me.RadManageSurgery.Location = New System.Drawing.Point(209, 19)
        Me.RadManageSurgery.Name = "RadManageSurgery"
        Me.RadManageSurgery.Size = New System.Drawing.Size(82, 24)
        Me.RadManageSurgery.TabIndex = 11
        Me.RadManageSurgery.TabStop = True
        Me.RadManageSurgery.Text = "Surgery"
        Me.RadManageSurgery.UseVisualStyleBackColor = False
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
        Me.TxtHistory.Size = New System.Drawing.Size(555, 72)
        Me.TxtHistory.TabIndex = 44
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtIOPLE_His)
        Me.GroupBox6.Controls.Add(Me.TxtIOPRE_His)
        Me.GroupBox6.Controls.Add(Me.TxtLLe1_His)
        Me.GroupBox6.Controls.Add(Me.TxtRRe1_His)
        Me.GroupBox6.Controls.Add(Me.TxtLRef1_His)
        Me.GroupBox6.Controls.Add(Me.TxtREF1_His)
        Me.GroupBox6.Controls.Add(Me.TxtLPh1_His)
        Me.GroupBox6.Controls.Add(Me.TxtRPh1_His)
        Me.GroupBox6.Controls.Add(Me.TxtLe1_His)
        Me.GroupBox6.Controls.Add(Me.TxtRE1His)
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
        Me.GroupBox6.Location = New System.Drawing.Point(570, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(662, 92)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Visual Acuity"
        '
        'TxtIOPLE_His
        '
        Me.TxtIOPLE_His.BackColor = System.Drawing.Color.White
        Me.TxtIOPLE_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIOPLE_His.Location = New System.Drawing.Point(570, 60)
        Me.TxtIOPLE_His.Name = "TxtIOPLE_His"
        Me.TxtIOPLE_His.ReadOnly = True
        Me.TxtIOPLE_His.Size = New System.Drawing.Size(85, 26)
        Me.TxtIOPLE_His.TabIndex = 10
        Me.TxtIOPLE_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIOPRE_His
        '
        Me.TxtIOPRE_His.BackColor = System.Drawing.Color.White
        Me.TxtIOPRE_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIOPRE_His.Location = New System.Drawing.Point(570, 28)
        Me.TxtIOPRE_His.Name = "TxtIOPRE_His"
        Me.TxtIOPRE_His.ReadOnly = True
        Me.TxtIOPRE_His.Size = New System.Drawing.Size(85, 26)
        Me.TxtIOPRE_His.TabIndex = 9
        Me.TxtIOPRE_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLLe1_His
        '
        Me.TxtLLe1_His.BackColor = System.Drawing.Color.White
        Me.TxtLLe1_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLLe1_His.Location = New System.Drawing.Point(479, 60)
        Me.TxtLLe1_His.Name = "TxtLLe1_His"
        Me.TxtLLe1_His.ReadOnly = True
        Me.TxtLLe1_His.Size = New System.Drawing.Size(85, 26)
        Me.TxtLLe1_His.TabIndex = 7
        Me.TxtLLe1_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRRe1_His
        '
        Me.TxtRRe1_His.BackColor = System.Drawing.Color.White
        Me.TxtRRe1_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRRe1_His.Location = New System.Drawing.Point(479, 28)
        Me.TxtRRe1_His.Name = "TxtRRe1_His"
        Me.TxtRRe1_His.ReadOnly = True
        Me.TxtRRe1_His.Size = New System.Drawing.Size(85, 26)
        Me.TxtRRe1_His.TabIndex = 3
        Me.TxtRRe1_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLRef1_His
        '
        Me.TxtLRef1_His.BackColor = System.Drawing.Color.White
        Me.TxtLRef1_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLRef1_His.Location = New System.Drawing.Point(327, 60)
        Me.TxtLRef1_His.Name = "TxtLRef1_His"
        Me.TxtLRef1_His.ReadOnly = True
        Me.TxtLRef1_His.Size = New System.Drawing.Size(107, 26)
        Me.TxtLRef1_His.TabIndex = 6
        Me.TxtLRef1_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtREF1_His
        '
        Me.TxtREF1_His.BackColor = System.Drawing.Color.White
        Me.TxtREF1_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtREF1_His.Location = New System.Drawing.Point(327, 28)
        Me.TxtREF1_His.Name = "TxtREF1_His"
        Me.TxtREF1_His.ReadOnly = True
        Me.TxtREF1_His.Size = New System.Drawing.Size(107, 26)
        Me.TxtREF1_His.TabIndex = 2
        Me.TxtREF1_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLPh1_His
        '
        Me.TxtLPh1_His.BackColor = System.Drawing.Color.White
        Me.TxtLPh1_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLPh1_His.Location = New System.Drawing.Point(179, 60)
        Me.TxtLPh1_His.Name = "TxtLPh1_His"
        Me.TxtLPh1_His.ReadOnly = True
        Me.TxtLPh1_His.Size = New System.Drawing.Size(90, 26)
        Me.TxtLPh1_His.TabIndex = 5
        Me.TxtLPh1_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRPh1_His
        '
        Me.TxtRPh1_His.BackColor = System.Drawing.Color.White
        Me.TxtRPh1_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRPh1_His.Location = New System.Drawing.Point(179, 28)
        Me.TxtRPh1_His.Name = "TxtRPh1_His"
        Me.TxtRPh1_His.ReadOnly = True
        Me.TxtRPh1_His.Size = New System.Drawing.Size(90, 26)
        Me.TxtRPh1_His.TabIndex = 1
        Me.TxtRPh1_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLe1_His
        '
        Me.TxtLe1_His.BackColor = System.Drawing.Color.White
        Me.TxtLe1_His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLe1_His.Location = New System.Drawing.Point(51, 60)
        Me.TxtLe1_His.Name = "TxtLe1_His"
        Me.TxtLe1_His.ReadOnly = True
        Me.TxtLe1_His.Size = New System.Drawing.Size(82, 26)
        Me.TxtLe1_His.TabIndex = 4
        Me.TxtLe1_His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRE1His
        '
        Me.TxtRE1His.BackColor = System.Drawing.Color.White
        Me.TxtRE1His.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRE1His.Location = New System.Drawing.Point(51, 28)
        Me.TxtRE1His.Name = "TxtRE1His"
        Me.TxtRE1His.ReadOnly = True
        Me.TxtRE1His.Size = New System.Drawing.Size(82, 26)
        Me.TxtRE1His.TabIndex = 0
        Me.TxtRE1His.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(597, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "IOP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(440, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 20)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "LE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(440, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "RE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(279, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 20)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "REF"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(277, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 20)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "REF"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(145, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 20)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Ph"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(143, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Ph"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 20)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "LE"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 20)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "RE"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStartConsult, Me.ToolStripSeparator1, Me.btnRefreshData, Me.ToolStripSeparator2, Me.BtnDeleteWaiting, Me.ToolStripSeparator3, Me.BtnPatientHistory})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1263, 52)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnStartConsult
        '
        Me.BtnStartConsult.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.button_background_red
        Me.BtnStartConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStartConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartConsult.ForeColor = System.Drawing.Color.Blue
        Me.BtnStartConsult.Image = Global.TakeoHospitalInventory.My.Resources.Resources.dokter
        Me.BtnStartConsult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStartConsult.Name = "BtnStartConsult"
        Me.BtnStartConsult.Size = New System.Drawing.Size(183, 49)
        Me.BtnStartConsult.Text = "      New Examination      "
        Me.BtnStartConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'btnRefreshData
        '
        Me.btnRefreshData.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.button_background_red
        Me.btnRefreshData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRefreshData.ForeColor = System.Drawing.Color.Blue
        Me.btnRefreshData.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.btnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefreshData.Name = "btnRefreshData"
        Me.btnRefreshData.Size = New System.Drawing.Size(157, 49)
        Me.btnRefreshData.Text = "      Refresh Data      "
        Me.btnRefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'BtnDeleteWaiting
        '
        Me.BtnDeleteWaiting.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.button_background_red
        Me.BtnDeleteWaiting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnDeleteWaiting.ForeColor = System.Drawing.Color.Blue
        Me.BtnDeleteWaiting.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteWaiting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteWaiting.Name = "BtnDeleteWaiting"
        Me.BtnDeleteWaiting.Size = New System.Drawing.Size(199, 49)
        Me.BtnDeleteWaiting.Text = "   Delete Waiting Consult   "
        Me.BtnDeleteWaiting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'BtnPatientHistory
        '
        Me.BtnPatientHistory.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.button_background_red
        Me.BtnPatientHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPatientHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnPatientHistory.ForeColor = System.Drawing.Color.Blue
        Me.BtnPatientHistory.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1417699293_Scheduled
        Me.BtnPatientHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPatientHistory.Name = "BtnPatientHistory"
        Me.BtnPatientHistory.Size = New System.Drawing.Size(197, 49)
        Me.BtnPatientHistory.Text = "    Patient History Report   "
        Me.BtnPatientHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ContextMenuFollowUp
        '
        Me.ContextMenuFollowUp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ContextMenuFollowUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewConsultFollow, Me.ToolStripMenuItem1, Me.BtnCancelFollowUP})
        Me.ContextMenuFollowUp.Name = "ContextMenuFollowUp"
        Me.ContextMenuFollowUp.Size = New System.Drawing.Size(292, 62)
        '
        'BtnNewConsultFollow
        '
        Me.BtnNewConsultFollow.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewConsultFollow.Name = "BtnNewConsultFollow"
        Me.BtnNewConsultFollow.Size = New System.Drawing.Size(291, 26)
        Me.BtnNewConsultFollow.Text = "New Consult Patient FollowUp"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(288, 6)
        '
        'BtnCancelFollowUP
        '
        Me.BtnCancelFollowUP.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancelFollowUP.Name = "BtnCancelFollowUP"
        Me.BtnCancelFollowUP.Size = New System.Drawing.Size(291, 26)
        Me.BtnCancelFollowUP.Text = "Cancel FollowUp"
        '
        'UiTab1
        '
        Me.UiTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 52)
        Me.UiTab1.MultiLine = True
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.PageBorder = Janus.Windows.UI.Tab.PageBorder.StripLine
        Me.UiTab1.Size = New System.Drawing.Size(1263, 1087)
        Me.UiTab1.TabIndex = 6
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage3, Me.UiTabPage2})
        Me.UiTab1.TabsStateStyles.FormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.UiTab1.TabsStateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.[False]
        Me.UiTab1.TabsStateStyles.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTab1.TabsStateStyles.HotFormatStyle.FontItalic = Janus.Windows.UI.TriState.[True]
        Me.UiTab1.TabsStateStyles.HotFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTab1.TabStripFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.TabStripFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.SplitContainer1)
        Me.UiTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTabPage1.Location = New System.Drawing.Point(0, 28)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1263, 1059)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "   &Patient Waiting Exam   "
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.SplitContainer2)
        Me.UiTabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTabPage3.Location = New System.Drawing.Point(0, 28)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(1263, 1059)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "   Patient Exam History   "
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.GridFollowUp)
        Me.UiTabPage2.Location = New System.Drawing.Point(0, 28)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1263, 1059)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Patient Follow Up Today"
        '
        'GridFollowUp
        '
        Me.GridFollowUp.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFollowUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridFollowUp.ContextMenuStrip = Me.ContextMenuStrip1
        GridFollowUp_DesignTimeLayout.LayoutString = resources.GetString("GridFollowUp_DesignTimeLayout.LayoutString")
        Me.GridFollowUp.DesignTimeLayout = GridFollowUp_DesignTimeLayout
        Me.GridFollowUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFollowUp.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridFollowUp.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridFollowUp.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridFollowUp.GroupByBoxVisible = False
        Me.GridFollowUp.HeaderFormatStyle.FontSize = 12.0!
        Me.GridFollowUp.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridFollowUp.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridFollowUp.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridFollowUp.Location = New System.Drawing.Point(0, 0)
        Me.GridFollowUp.Name = "GridFollowUp"
        Me.GridFollowUp.RecordNavigator = True
        Me.GridFollowUp.RowFormatStyle.FontSize = 12.0!
        Me.GridFollowUp.Size = New System.Drawing.Size(1263, 1059)
        Me.GridFollowUp.TabIndex = 7
        Me.GridFollowUp.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSendToConsult, Me.ToolStripMenuItem10, Me.NewPatientFollowupToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(243, 62)
        '
        'BtnSendToConsult
        '
        Me.BtnSendToConsult.ForeColor = System.Drawing.Color.Blue
        Me.BtnSendToConsult.Name = "BtnSendToConsult"
        Me.BtnSendToConsult.Size = New System.Drawing.Size(242, 26)
        Me.BtnSendToConsult.Text = "Send to waiting consult"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(239, 6)
        Me.ToolStripMenuItem10.Visible = False
        '
        'NewPatientFollowupToolStripMenuItem
        '
        Me.NewPatientFollowupToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.NewPatientFollowupToolStripMenuItem.Name = "NewPatientFollowupToolStripMenuItem"
        Me.NewPatientFollowupToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.NewPatientFollowupToolStripMenuItem.Text = "New patient followup"
        Me.NewPatientFollowupToolStripMenuItem.Visible = False
        '
        'DashboardDoctorConsult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.UiTab1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardDoctorConsult"
        Me.Size = New System.Drawing.Size(1263, 1139)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridPatientWaiting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiTab4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab4.ResumeLayout(False)
        Me.UiTabPage6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.UiTabPage9.ResumeLayout(False)
        CType(Me.GridOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuOperationNote.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridHistoy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab2.ResumeLayout(False)
        Me.UiTabPage4.ResumeLayout(False)
        Me.UiTabPage4.PerformLayout()
        CType(Me.UiTab3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab3.ResumeLayout(False)
        Me.UiTabPage7.ResumeLayout(False)
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage8.ResumeLayout(False)
        CType(Me.GridImageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupEye.ResumeLayout(False)
        Me.GroupEye.PerformLayout()
        Me.GroupMangement.ResumeLayout(False)
        Me.GroupMangement.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuFollowUp.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage3.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.GridFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnStartConsult As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridPatientWaiting As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtLLE As System.Windows.Forms.TextBox
    Friend WithEvents TxtRRE As System.Windows.Forms.TextBox
    Friend WithEvents TxtLREF As System.Windows.Forms.TextBox
    Friend WithEvents TxtRREF As System.Windows.Forms.TextBox
    Friend WithEvents TxtLPh As System.Windows.Forms.TextBox
    Friend WithEvents TxtRPh As System.Windows.Forms.TextBox
    Friend WithEvents TxtLE As System.Windows.Forms.TextBox
    Friend WithEvents TxtRE As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridHistoy As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtLLe1_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtRRe1_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtLRef1_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtREF1_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtLPh1_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtRPh1_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtLe1_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtRE1His As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtHistory As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteWaiting As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPatientHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuFollowUp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnNewConsultFollow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancelFollowUP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents GroupEye As System.Windows.Forms.GroupBox
    Friend WithEvents RadDiagnosisRighEye As System.Windows.Forms.RadioButton
    Friend WithEvents RadDiagnosisBothEyes As System.Windows.Forms.RadioButton
    Friend WithEvents RadDiagnosisLefEye As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDiagnosisCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents GridImageList As Janus.Windows.GridEX.GridEX
    Friend WithEvents CboDoctorConsult As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTab2 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTab3 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage7 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage8 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTab4 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage6 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage9 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridOT As Janus.Windows.GridEX.GridEX
    Friend WithEvents MenuOperationNote As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnUpdateOPNote As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtIOPLE As System.Windows.Forms.TextBox
    Friend WithEvents TxtIOPRE As System.Windows.Forms.TextBox
    Friend WithEvents TxtIOPLE_His As System.Windows.Forms.TextBox
    Friend WithEvents TxtIOPRE_His As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridFollowUp As Janus.Windows.GridEX.GridEX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnSendToConsult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewPatientFollowupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
