<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainDonateReport
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
        Dim GridDonation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainDonateReport))
        Dim GridDonatedDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadReportDelete = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadShowAllDonate = New System.Windows.Forms.RadioButton
        Me.RadDonateInPatient = New System.Windows.Forms.RadioButton
        Me.RadDonateInOpticalShop = New System.Windows.Forms.RadioButton
        Me.GroupOpticalShop = New System.Windows.Forms.GroupBox
        Me.RadGlasessAndMedicince = New System.Windows.Forms.RadioButton
        Me.RadMedicince = New System.Windows.Forms.RadioButton
        Me.RadGlasess = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadCompareReport = New System.Windows.Forms.RadioButton
        Me.RadNormalReport = New System.Windows.Forms.RadioButton
        Me.BtnUpdateDonate = New System.Windows.Forms.Button
        Me.PicLoading = New System.Windows.Forms.PictureBox
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.RadAsReports = New System.Windows.Forms.RadioButton
        Me.RadAsGrid = New System.Windows.Forms.RadioButton
        Me.ChViewall = New System.Windows.Forms.CheckBox
        Me.DatePickTo = New System.Windows.Forms.DateTimePicker
        Me.DatePickerFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboDonation = New System.Windows.Forms.ComboBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GridDonation = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridDonatedDetail = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuDelete = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteDonateSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.UndodeleteDonateSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewDonateDeletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor
        Me.CrysViewerDonation = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.BtnDelete1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnClose = New System.Windows.Forms.ToolStripButton
        Me.ErrDonate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgLoadDonateRepord = New System.ComponentModel.BackgroundWorker
        Me.BgSelectDonate = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupOpticalShop.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDonation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridDonatedDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuDelete.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrDonate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridDonation)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1181, 768)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadReportDelete)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnUpdateDonate)
        Me.GroupBox1.Controls.Add(Me.PicLoading)
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.RadAsReports)
        Me.GroupBox1.Controls.Add(Me.RadAsGrid)
        Me.GroupBox1.Controls.Add(Me.ChViewall)
        Me.GroupBox1.Controls.Add(Me.DatePickTo)
        Me.GroupBox1.Controls.Add(Me.DatePickerFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CboDonation)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 268)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(247, 500)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report of Donation"
        '
        'RadReportDelete
        '
        Me.RadReportDelete.AutoSize = True
        Me.RadReportDelete.Location = New System.Drawing.Point(113, 42)
        Me.RadReportDelete.Name = "RadReportDelete"
        Me.RadReportDelete.Size = New System.Drawing.Size(160, 17)
        Me.RadReportDelete.TabIndex = 10
        Me.RadReportDelete.TabStop = True
        Me.RadReportDelete.Text = "View as report donate delete"
        Me.RadReportDelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RadShowAllDonate)
        Me.GroupBox2.Controls.Add(Me.RadDonateInPatient)
        Me.GroupBox2.Controls.Add(Me.RadDonateInOpticalShop)
        Me.GroupBox2.Controls.Add(Me.GroupOpticalShop)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 209)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'RadShowAllDonate
        '
        Me.RadShowAllDonate.AutoSize = True
        Me.RadShowAllDonate.Checked = True
        Me.RadShowAllDonate.Location = New System.Drawing.Point(8, 19)
        Me.RadShowAllDonate.Name = "RadShowAllDonate"
        Me.RadShowAllDonate.Size = New System.Drawing.Size(214, 17)
        Me.RadShowAllDonate.TabIndex = 2
        Me.RadShowAllDonate.TabStop = True
        Me.RadShowAllDonate.Text = "All Donate's Optical Shop and In-Pateint"
        Me.RadShowAllDonate.UseVisualStyleBackColor = True
        '
        'RadDonateInPatient
        '
        Me.RadDonateInPatient.AutoSize = True
        Me.RadDonateInPatient.Location = New System.Drawing.Point(9, 115)
        Me.RadDonateInPatient.Name = "RadDonateInPatient"
        Me.RadDonateInPatient.Size = New System.Drawing.Size(115, 17)
        Me.RadDonateInPatient.TabIndex = 1
        Me.RadDonateInPatient.Text = "Donate's In-Patient"
        Me.RadDonateInPatient.UseVisualStyleBackColor = True
        '
        'RadDonateInOpticalShop
        '
        Me.RadDonateInOpticalShop.AutoSize = True
        Me.RadDonateInOpticalShop.Location = New System.Drawing.Point(8, 43)
        Me.RadDonateInOpticalShop.Name = "RadDonateInOpticalShop"
        Me.RadDonateInOpticalShop.Size = New System.Drawing.Size(14, 13)
        Me.RadDonateInOpticalShop.TabIndex = 0
        Me.RadDonateInOpticalShop.UseVisualStyleBackColor = True
        '
        'GroupOpticalShop
        '
        Me.GroupOpticalShop.Controls.Add(Me.RadGlasessAndMedicince)
        Me.GroupOpticalShop.Controls.Add(Me.RadMedicince)
        Me.GroupOpticalShop.Controls.Add(Me.RadGlasess)
        Me.GroupOpticalShop.Enabled = False
        Me.GroupOpticalShop.Location = New System.Drawing.Point(3, 43)
        Me.GroupOpticalShop.Name = "GroupOpticalShop"
        Me.GroupOpticalShop.Size = New System.Drawing.Size(219, 66)
        Me.GroupOpticalShop.TabIndex = 3
        Me.GroupOpticalShop.TabStop = False
        Me.GroupOpticalShop.Text = "   Donate's Optical Shop"
        '
        'RadGlasessAndMedicince
        '
        Me.RadGlasessAndMedicince.AutoSize = True
        Me.RadGlasessAndMedicince.Location = New System.Drawing.Point(12, 19)
        Me.RadGlasessAndMedicince.Name = "RadGlasessAndMedicince"
        Me.RadGlasessAndMedicince.Size = New System.Drawing.Size(135, 17)
        Me.RadGlasessAndMedicince.TabIndex = 4
        Me.RadGlasessAndMedicince.TabStop = True
        Me.RadGlasessAndMedicince.Text = "Glasess and Medicince"
        Me.RadGlasessAndMedicince.UseVisualStyleBackColor = True
        '
        'RadMedicince
        '
        Me.RadMedicince.AutoSize = True
        Me.RadMedicince.Location = New System.Drawing.Point(100, 42)
        Me.RadMedicince.Name = "RadMedicince"
        Me.RadMedicince.Size = New System.Drawing.Size(74, 17)
        Me.RadMedicince.TabIndex = 1
        Me.RadMedicince.TabStop = True
        Me.RadMedicince.Text = "Medicince"
        Me.RadMedicince.UseVisualStyleBackColor = True
        '
        'RadGlasess
        '
        Me.RadGlasess.AutoSize = True
        Me.RadGlasess.Location = New System.Drawing.Point(12, 42)
        Me.RadGlasess.Name = "RadGlasess"
        Me.RadGlasess.Size = New System.Drawing.Size(62, 17)
        Me.RadGlasess.TabIndex = 0
        Me.RadGlasess.TabStop = True
        Me.RadGlasess.Text = "Glasess"
        Me.RadGlasess.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadCompareReport)
        Me.GroupBox3.Controls.Add(Me.RadNormalReport)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(8, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 69)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type of Report"
        '
        'RadCompareReport
        '
        Me.RadCompareReport.AutoSize = True
        Me.RadCompareReport.ForeColor = System.Drawing.Color.Blue
        Me.RadCompareReport.Location = New System.Drawing.Point(7, 46)
        Me.RadCompareReport.Name = "RadCompareReport"
        Me.RadCompareReport.Size = New System.Drawing.Size(127, 17)
        Me.RadCompareReport.TabIndex = 1
        Me.RadCompareReport.TabStop = True
        Me.RadCompareReport.Text = "Compare report social"
        Me.RadCompareReport.UseVisualStyleBackColor = True
        '
        'RadNormalReport
        '
        Me.RadNormalReport.AutoSize = True
        Me.RadNormalReport.Checked = True
        Me.RadNormalReport.ForeColor = System.Drawing.Color.Blue
        Me.RadNormalReport.Location = New System.Drawing.Point(7, 19)
        Me.RadNormalReport.Name = "RadNormalReport"
        Me.RadNormalReport.Size = New System.Drawing.Size(93, 17)
        Me.RadNormalReport.TabIndex = 0
        Me.RadNormalReport.TabStop = True
        Me.RadNormalReport.Text = "Normal Report"
        Me.RadNormalReport.UseVisualStyleBackColor = True
        '
        'BtnUpdateDonate
        '
        Me.BtnUpdateDonate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateDonate.Location = New System.Drawing.Point(105, 362)
        Me.BtnUpdateDonate.Name = "BtnUpdateDonate"
        Me.BtnUpdateDonate.Size = New System.Drawing.Size(101, 26)
        Me.BtnUpdateDonate.TabIndex = 8
        Me.BtnUpdateDonate.Text = "Update Donate &Paid"
        Me.BtnUpdateDonate.UseVisualStyleBackColor = True
        '
        'PicLoading
        '
        Me.PicLoading.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loadgraphic
        Me.PicLoading.Location = New System.Drawing.Point(2, 477)
        Me.PicLoading.Name = "PicLoading"
        Me.PicLoading.Size = New System.Drawing.Size(243, 21)
        Me.PicLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoading.TabIndex = 7
        Me.PicLoading.TabStop = False
        Me.PicLoading.Visible = False
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(8, 362)
        Me.BtnPrintPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(79, 26)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'RadAsReports
        '
        Me.RadAsReports.AutoSize = True
        Me.RadAsReports.Location = New System.Drawing.Point(113, 17)
        Me.RadAsReports.Margin = New System.Windows.Forms.Padding(2)
        Me.RadAsReports.Name = "RadAsReports"
        Me.RadAsReports.Size = New System.Drawing.Size(92, 17)
        Me.RadAsReports.TabIndex = 5
        Me.RadAsReports.Text = "View as report"
        Me.RadAsReports.UseVisualStyleBackColor = True
        '
        'RadAsGrid
        '
        Me.RadAsGrid.AutoSize = True
        Me.RadAsGrid.Checked = True
        Me.RadAsGrid.Location = New System.Drawing.Point(8, 17)
        Me.RadAsGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.RadAsGrid.Name = "RadAsGrid"
        Me.RadAsGrid.Size = New System.Drawing.Size(88, 17)
        Me.RadAsGrid.TabIndex = 5
        Me.RadAsGrid.TabStop = True
        Me.RadAsGrid.Text = "View as table"
        Me.RadAsGrid.UseVisualStyleBackColor = True
        '
        'ChViewall
        '
        Me.ChViewall.AutoSize = True
        Me.ChViewall.Checked = True
        Me.ChViewall.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChViewall.Location = New System.Drawing.Point(8, 43)
        Me.ChViewall.Margin = New System.Windows.Forms.Padding(2)
        Me.ChViewall.Name = "ChViewall"
        Me.ChViewall.Size = New System.Drawing.Size(75, 17)
        Me.ChViewall.TabIndex = 4
        Me.ChViewall.Text = "All Donate"
        Me.ChViewall.UseVisualStyleBackColor = True
        '
        'DatePickTo
        '
        Me.DatePickTo.CustomFormat = "dd/MM/yyyy"
        Me.DatePickTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePickTo.Location = New System.Drawing.Point(61, 125)
        Me.DatePickTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePickTo.Name = "DatePickTo"
        Me.DatePickTo.ShowCheckBox = True
        Me.DatePickTo.Size = New System.Drawing.Size(151, 23)
        Me.DatePickTo.TabIndex = 3
        '
        'DatePickerFrom
        '
        Me.DatePickerFrom.CustomFormat = "dd/MM/yyyy"
        Me.DatePickerFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePickerFrom.Location = New System.Drawing.Point(61, 93)
        Me.DatePickerFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePickerFrom.Name = "DatePickerFrom"
        Me.DatePickerFrom.ShowCheckBox = True
        Me.DatePickerFrom.Size = New System.Drawing.Size(151, 23)
        Me.DatePickerFrom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From:"
        '
        'CboDonation
        '
        Me.CboDonation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDonation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDonation.FormattingEnabled = True
        Me.CboDonation.Location = New System.Drawing.Point(8, 65)
        Me.CboDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.CboDonation.Name = "CboDonation"
        Me.CboDonation.Size = New System.Drawing.Size(204, 24)
        Me.CboDonation.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 266)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(247, 2)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'GridDonation
        '
        GridDonation_DesignTimeLayout.LayoutString = resources.GetString("GridDonation_DesignTimeLayout.LayoutString")
        Me.GridDonation.DesignTimeLayout = GridDonation_DesignTimeLayout
        Me.GridDonation.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridDonation.GroupByBoxVisible = False
        Me.GridDonation.Location = New System.Drawing.Point(0, 0)
        Me.GridDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.GridDonation.Name = "GridDonation"
        Me.GridDonation.RecordNavigator = True
        Me.GridDonation.Size = New System.Drawing.Size(247, 266)
        Me.GridDonation.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridDonatedDetail)
        Me.SplitContainer2.Panel1.Controls.Add(Me.FilterEditor1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CrysViewerDonation)
        Me.SplitContainer2.Size = New System.Drawing.Size(931, 768)
        Me.SplitContainer2.SplitterDistance = 877
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 0
        '
        'GridDonatedDetail
        '
        Me.GridDonatedDetail.ContextMenuStrip = Me.ContextMenuDelete
        GridDonatedDetail_DesignTimeLayout.LayoutString = resources.GetString("GridDonatedDetail_DesignTimeLayout.LayoutString")
        Me.GridDonatedDetail.DesignTimeLayout = GridDonatedDetail_DesignTimeLayout
        Me.GridDonatedDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDonatedDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridDonatedDetail.GroupByBoxVisible = False
        Me.GridDonatedDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDonatedDetail.Location = New System.Drawing.Point(0, 46)
        Me.GridDonatedDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.GridDonatedDetail.Name = "GridDonatedDetail"
        Me.GridDonatedDetail.RecordNavigator = True
        Me.GridDonatedDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDonatedDetail.Size = New System.Drawing.Size(877, 722)
        Me.GridDonatedDetail.TabIndex = 0
        Me.GridDonatedDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        '
        'ContextMenuDelete
        '
        Me.ContextMenuDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteDonateSupportToolStripMenuItem, Me.ToolStripMenuItem1, Me.UndodeleteDonateSupportToolStripMenuItem, Me.ToolStripMenuItem2, Me.ViewDonateDeletedToolStripMenuItem})
        Me.ContextMenuDelete.Name = "ContextMenuDelete"
        Me.ContextMenuDelete.Size = New System.Drawing.Size(248, 82)
        '
        'DeleteDonateSupportToolStripMenuItem
        '
        Me.DeleteDonateSupportToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DeleteDonateSupportToolStripMenuItem.Name = "DeleteDonateSupportToolStripMenuItem"
        Me.DeleteDonateSupportToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DeleteDonateSupportToolStripMenuItem.Text = "Delete donate support"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(244, 6)
        '
        'UndodeleteDonateSupportToolStripMenuItem
        '
        Me.UndodeleteDonateSupportToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.UndodeleteDonateSupportToolStripMenuItem.Name = "UndodeleteDonateSupportToolStripMenuItem"
        Me.UndodeleteDonateSupportToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.UndodeleteDonateSupportToolStripMenuItem.Text = "Undo &delete donate support"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(244, 6)
        '
        'ViewDonateDeletedToolStripMenuItem
        '
        Me.ViewDonateDeletedToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ViewDonateDeletedToolStripMenuItem.Name = "ViewDonateDeletedToolStripMenuItem"
        Me.ViewDonateDeletedToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ViewDonateDeletedToolStripMenuItem.Text = "View donate deleted"
        '
        'FilterEditor1
        '
        Me.FilterEditor1.AutoApply = True
        Me.FilterEditor1.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(0, 0)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(16, 45)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(877, 46)
        Me.FilterEditor1.SourceControl = Me.GridDonatedDetail
        '
        'CrysViewerDonation
        '
        Me.CrysViewerDonation.ActiveViewIndex = -1
        Me.CrysViewerDonation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrysViewerDonation.DisplayGroupTree = False
        Me.CrysViewerDonation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrysViewerDonation.Location = New System.Drawing.Point(0, 0)
        Me.CrysViewerDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.CrysViewerDonation.Name = "CrysViewerDonation"
        Me.CrysViewerDonation.SelectionFormula = ""
        Me.CrysViewerDonation.ShowCloseButton = False
        Me.CrysViewerDonation.ShowGroupTreeButton = False
        Me.CrysViewerDonation.ShowRefreshButton = False
        Me.CrysViewerDonation.Size = New System.Drawing.Size(51, 768)
        Me.CrysViewerDonation.TabIndex = 0
        Me.CrysViewerDonation.ViewTimeSelectionFormula = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.BtnEdit, Me.BtnDelete1, Me.BtnRefreshData, Me.ToolStripSeparator2, Me.BtnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1181, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNew.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(87, 22)
        Me.BtnNew.Text = "New Donate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnEdit
        '
        Me.BtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(123, 22)
        Me.BtnEdit.Text = "Edit Donate Name"
        '
        'BtnDelete1
        '
        Me.BtnDelete1.Name = "BtnDelete1"
        Me.BtnDelete1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnRefreshData.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnRefreshData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRefreshData.Image = CType(resources.GetObject("BtnRefreshData.Image"), System.Drawing.Image)
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(117, 22)
        Me.BtnRefreshData.Text = "Load Information"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnClose
        '
        Me.BtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(44, 22)
        Me.BtnClose.Text = "Close"
        '
        'ErrDonate
        '
        Me.ErrDonate.ContainerControl = Me
        '
        'BgLoadDonateRepord
        '
        '
        'BgSelectDonate
        '
        '
        'FormMainDonateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 793)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMainDonateReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Donate Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupOpticalShop.ResumeLayout(False)
        Me.GroupOpticalShop.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDonation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridDonatedDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuDelete.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrDonate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridDonation As Janus.Windows.GridEX.GridEX
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDelete1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridDonatedDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboDonation As System.Windows.Forms.ComboBox
    Friend WithEvents DatePickTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChViewall As System.Windows.Forms.CheckBox
    Friend WithEvents RadAsGrid As System.Windows.Forms.RadioButton
    Friend WithEvents RadAsReports As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ErrDonate As System.Windows.Forms.ErrorProvider
    Friend WithEvents CrysViewerDonation As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents BgLoadDonateRepord As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicLoading As System.Windows.Forms.PictureBox
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents BgSelectDonate As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnUpdateDonate As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadShowAllDonate As System.Windows.Forms.RadioButton
    Friend WithEvents RadDonateInPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadDonateInOpticalShop As System.Windows.Forms.RadioButton
    Friend WithEvents GroupOpticalShop As System.Windows.Forms.GroupBox
    Friend WithEvents RadMedicince As System.Windows.Forms.RadioButton
    Friend WithEvents RadGlasess As System.Windows.Forms.RadioButton
    Friend WithEvents RadGlasessAndMedicince As System.Windows.Forms.RadioButton
    Friend WithEvents ContextMenuDelete As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteDonateSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndodeleteDonateSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewDonateDeletedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadReportDelete As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadCompareReport As System.Windows.Forms.RadioButton
    Friend WithEvents RadNormalReport As System.Windows.Forms.RadioButton
End Class
