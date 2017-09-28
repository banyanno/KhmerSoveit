<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEachProvinceAndDistrict
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridConsultationEachProvince_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCEachProvinceAndDistrict))
        Dim GridDiagnosisbyDistrict_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridConsultationEachProvince = New Janus.Windows.GridEX.GridEX
        Me.DSProvinceAndDistrict = New TakeoHospitalInventory.DSProvinceAndDistrict
        Me.StatusStripPateint = New System.Windows.Forms.StatusStrip
        Me.ProgrestData = New System.Windows.Forms.ToolStripProgressBar
        Me.lblTimeShowData = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitContainerReport = New System.Windows.Forms.SplitContainer
        Me.GridDiagnosisbyDistrict = New Janus.Windows.GridEX.GridEX
        Me.CRVConsultation = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.BtnPrintPreview1 = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.CboYear1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CboMonth = New System.Windows.Forms.ComboBox
        Me.BtnLoadData = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.CboYear = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bgPatient = New System.ComponentModel.BackgroundWorker
        Me.BgReportConsultation = New System.ComponentModel.BackgroundWorker
        Me.BgReportProviceDiagnosis = New System.ComponentModel.BackgroundWorker
        Me.TimerSearchPatien = New System.Windows.Forms.Timer(Me.components)
        Me.DSProvinceReport = New TakeoHospitalInventory.DSProvinceReport
        Me.DTblProvinceReportTableAdapter = New TakeoHospitalInventory.DSProvinceReportTableAdapters.DTblProvinceReportTableAdapter
        Me.TblConsultationEachTableAdapter = New TakeoHospitalInventory.DSProvinceReportTableAdapters.TblConsultationEachTableAdapter
        Me.TblProvincesTableAdapter = New TakeoHospitalInventory.DSProvinceAndDistrictTableAdapters.tblProvincesTableAdapter
        Me.V_CosultationEachProvinceTableAdapter = New TakeoHospitalInventory.DSProvinceAndDistrictTableAdapters.V_CosultationEachProvinceTableAdapter
        Me.V_DiagnosisByDistrictTableAdapter = New TakeoHospitalInventory.DSProvinceAndDistrictTableAdapters.V_DiagnosisByDistrictTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridConsultationEachProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSProvinceAndDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStripPateint.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainerReport.Panel1.SuspendLayout()
        Me.SplitContainerReport.Panel2.SuspendLayout()
        Me.SplitContainerReport.SuspendLayout()
        CType(Me.GridDiagnosisbyDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DSProvinceReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridConsultationEachProvince)
        Me.GroupBox1.Controls.Add(Me.StatusStripPateint)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 684)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Province And District"
        '
        'GridConsultationEachProvince
        '
        Me.GridConsultationEachProvince.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridConsultationEachProvince.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridConsultationEachProvince.DataMember = "tblProvinces"
        Me.GridConsultationEachProvince.DataSource = Me.DSProvinceAndDistrict
        GridConsultationEachProvince_DesignTimeLayout.LayoutString = resources.GetString("GridConsultationEachProvince_DesignTimeLayout.LayoutString")
        Me.GridConsultationEachProvince.DesignTimeLayout = GridConsultationEachProvince_DesignTimeLayout
        Me.GridConsultationEachProvince.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridConsultationEachProvince.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridConsultationEachProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridConsultationEachProvince.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridConsultationEachProvince.GroupByBoxVisible = False
        Me.GridConsultationEachProvince.Location = New System.Drawing.Point(3, 16)
        Me.GridConsultationEachProvince.Name = "GridConsultationEachProvince"
        Me.GridConsultationEachProvince.RecordNavigator = True
        Me.GridConsultationEachProvince.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridConsultationEachProvince.Size = New System.Drawing.Size(271, 643)
        Me.GridConsultationEachProvince.TabIndex = 0
        Me.GridConsultationEachProvince.TabStop = False
        Me.GridConsultationEachProvince.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'DSProvinceAndDistrict
        '
        Me.DSProvinceAndDistrict.DataSetName = "DSProvinceAndDistrict"
        Me.DSProvinceAndDistrict.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStripPateint
        '
        Me.StatusStripPateint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrestData, Me.lblTimeShowData})
        Me.StatusStripPateint.Location = New System.Drawing.Point(3, 659)
        Me.StatusStripPateint.Name = "StatusStripPateint"
        Me.StatusStripPateint.Size = New System.Drawing.Size(271, 22)
        Me.StatusStripPateint.TabIndex = 35
        Me.StatusStripPateint.Text = "StatusStrip1"
        '
        'ProgrestData
        '
        Me.ProgrestData.Name = "ProgrestData"
        Me.ProgrestData.Size = New System.Drawing.Size(100, 16)
        Me.ProgrestData.Visible = False
        '
        'lblTimeShowData
        '
        Me.lblTimeShowData.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeShowData.Name = "lblTimeShowData"
        Me.lblTimeShowData.Size = New System.Drawing.Size(53, 17)
        Me.lblTimeShowData.Text = "Duration"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplitContainerReport)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 684)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consultations(New and Follow Up) Each Province and District"
        '
        'SplitContainerReport
        '
        Me.SplitContainerReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerReport.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainerReport.Name = "SplitContainerReport"
        '
        'SplitContainerReport.Panel1
        '
        Me.SplitContainerReport.Panel1.Controls.Add(Me.GridDiagnosisbyDistrict)
        '
        'SplitContainerReport.Panel2
        '
        Me.SplitContainerReport.Panel2.Controls.Add(Me.CRVConsultation)
        Me.SplitContainerReport.Panel2Collapsed = True
        Me.SplitContainerReport.Size = New System.Drawing.Size(645, 665)
        Me.SplitContainerReport.SplitterDistance = 202
        Me.SplitContainerReport.TabIndex = 1
        '
        'GridDiagnosisbyDistrict
        '
        Me.GridDiagnosisbyDistrict.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiagnosisbyDistrict.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridDiagnosisbyDistrict.DataMember = "V_DiagnosisByDistrict"
        Me.GridDiagnosisbyDistrict.DataSource = Me.DSProvinceAndDistrict
        GridDiagnosisbyDistrict_DesignTimeLayout.LayoutString = resources.GetString("GridDiagnosisbyDistrict_DesignTimeLayout.LayoutString")
        Me.GridDiagnosisbyDistrict.DesignTimeLayout = GridDiagnosisbyDistrict_DesignTimeLayout
        Me.GridDiagnosisbyDistrict.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiagnosisbyDistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDiagnosisbyDistrict.GroupByBoxVisible = False
        Me.GridDiagnosisbyDistrict.HeaderFormatStyle.FontSize = 12.0!
        Me.GridDiagnosisbyDistrict.Location = New System.Drawing.Point(0, 0)
        Me.GridDiagnosisbyDistrict.Name = "GridDiagnosisbyDistrict"
        Me.GridDiagnosisbyDistrict.RowFormatStyle.FontSize = 12.0!
        Me.GridDiagnosisbyDistrict.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDiagnosisbyDistrict.Size = New System.Drawing.Size(645, 665)
        Me.GridDiagnosisbyDistrict.TabIndex = 1
        Me.GridDiagnosisbyDistrict.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDiagnosisbyDistrict.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'CRVConsultation
        '
        Me.CRVConsultation.ActiveViewIndex = -1
        Me.CRVConsultation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CRVConsultation.DisplayGroupTree = False
        Me.CRVConsultation.DisplayStatusBar = False
        Me.CRVConsultation.DisplayToolbar = False
        Me.CRVConsultation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVConsultation.Location = New System.Drawing.Point(0, 0)
        Me.CRVConsultation.Name = "CRVConsultation"
        Me.CRVConsultation.SelectionFormula = ""
        Me.CRVConsultation.ShowCloseButton = False
        Me.CRVConsultation.ShowGroupTreeButton = False
        Me.CRVConsultation.ShowRefreshButton = False
        Me.CRVConsultation.ShowTextSearchButton = False
        Me.CRVConsultation.Size = New System.Drawing.Size(96, 100)
        Me.CRVConsultation.TabIndex = 0
        Me.CRVConsultation.ViewTimeSelectionFormula = ""
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 124)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(932, 684)
        Me.SplitContainer1.SplitterDistance = 277
        Me.SplitContainer1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(932, 124)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Province and District statistics"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnPrintPreview1)
        Me.GroupBox6.Controls.Add(Me.DateTo)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.DateFrom)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(603, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(268, 95)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Statistics Diagnosiss Each Province"
        '
        'BtnPrintPreview1
        '
        Me.BtnPrintPreview1.BackgroundImage = CType(resources.GetObject("BtnPrintPreview1.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintPreview1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintPreview1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintPreview1.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview1.Location = New System.Drawing.Point(173, 22)
        Me.BtnPrintPreview1.Name = "BtnPrintPreview1"
        Me.BtnPrintPreview1.Size = New System.Drawing.Size(89, 56)
        Me.BtnPrintPreview1.TabIndex = 2
        Me.BtnPrintPreview1.Text = "Print Preview"
        Me.BtnPrintPreview1.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(45, 52)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(122, 26)
        Me.DateTo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To:"
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(45, 22)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(122, 26)
        Me.DateFrom.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox5.Controls.Add(Me.CboYear1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(324, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(267, 94)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Statistics Consultations Each Province "
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackgroundImage = CType(resources.GetObject("BtnPrintPreview.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview.Location = New System.Drawing.Point(178, 22)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(76, 40)
        Me.BtnPrintPreview.TabIndex = 1
        Me.BtnPrintPreview.Text = "&Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'CboYear1
        '
        Me.CboYear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboYear1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboYear1.FormattingEnabled = True
        Me.CboYear1.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.CboYear1.Location = New System.Drawing.Point(51, 34)
        Me.CboYear1.Name = "CboYear1"
        Me.CboYear1.Size = New System.Drawing.Size(121, 28)
        Me.CboYear1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Year:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CboMonth)
        Me.GroupBox4.Controls.Add(Me.BtnLoadData)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.CboYear)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(10, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 95)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'CboMonth
        '
        Me.CboMonth.DropDownHeight = 500
        Me.CboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMonth.DropDownWidth = 300
        Me.CboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMonth.FormattingEnabled = True
        Me.CboMonth.IntegralHeight = False
        Me.CboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "Octomer", "November", "December"})
        Me.CboMonth.Location = New System.Drawing.Point(42, 19)
        Me.CboMonth.Name = "CboMonth"
        Me.CboMonth.Size = New System.Drawing.Size(121, 28)
        Me.CboMonth.TabIndex = 0
        '
        'BtnLoadData
        '
        Me.BtnLoadData.BackgroundImage = CType(resources.GetObject("BtnLoadData.BackgroundImage"), System.Drawing.Image)
        Me.BtnLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLoadData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLoadData.ForeColor = System.Drawing.Color.White
        Me.BtnLoadData.Location = New System.Drawing.Point(169, 19)
        Me.BtnLoadData.Name = "BtnLoadData"
        Me.BtnLoadData.Size = New System.Drawing.Size(110, 62)
        Me.BtnLoadData.TabIndex = 2
        Me.BtnLoadData.Text = "&Load Data"
        Me.BtnLoadData.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 61)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Year:"
        '
        'CboYear
        '
        Me.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboYear.FormattingEnabled = True
        Me.CboYear.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.CboYear.Location = New System.Drawing.Point(42, 53)
        Me.CboYear.Name = "CboYear"
        Me.CboYear.Size = New System.Drawing.Size(121, 28)
        Me.CboYear.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Month:"
        '
        'bgPatient
        '
        '
        'BgReportConsultation
        '
        '
        'BgReportProviceDiagnosis
        '
        '
        'TimerSearchPatien
        '
        '
        'DSProvinceReport
        '
        Me.DSProvinceReport.DataSetName = "DSProvinceReport"
        Me.DSProvinceReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTblProvinceReportTableAdapter
        '
        Me.DTblProvinceReportTableAdapter.ClearBeforeFill = True
        '
        'TblConsultationEachTableAdapter
        '
        Me.TblConsultationEachTableAdapter.ClearBeforeFill = True
        '
        'TblProvincesTableAdapter
        '
        Me.TblProvincesTableAdapter.ClearBeforeFill = True
        '
        'V_CosultationEachProvinceTableAdapter
        '
        Me.V_CosultationEachProvinceTableAdapter.ClearBeforeFill = True
        '
        'V_DiagnosisByDistrictTableAdapter
        '
        Me.V_DiagnosisByDistrictTableAdapter.ClearBeforeFill = True
        '
        'UCEachProvinceAndDistrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "UCEachProvinceAndDistrict"
        Me.Size = New System.Drawing.Size(932, 808)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridConsultationEachProvince, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSProvinceAndDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStripPateint.ResumeLayout(False)
        Me.StatusStripPateint.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainerReport.Panel1.ResumeLayout(False)
        Me.SplitContainerReport.Panel2.ResumeLayout(False)
        Me.SplitContainerReport.ResumeLayout(False)
        CType(Me.GridDiagnosisbyDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DSProvinceReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DSProvinceAndDistrict As TakeoHospitalInventory.DSProvinceAndDistrict
    Friend WithEvents TblProvincesTableAdapter As TakeoHospitalInventory.DSProvinceAndDistrictTableAdapters.tblProvincesTableAdapter
    Friend WithEvents V_CosultationEachProvinceTableAdapter As TakeoHospitalInventory.DSProvinceAndDistrictTableAdapters.V_CosultationEachProvinceTableAdapter
    Friend WithEvents GridConsultationEachProvince As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLoadData As System.Windows.Forms.Button
    Friend WithEvents bgPatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStripPateint As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgrestData As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblTimeShowData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents V_DiagnosisByDistrictTableAdapter As TakeoHospitalInventory.DSProvinceAndDistrictTableAdapters.V_DiagnosisByDistrictTableAdapter
    Friend WithEvents SplitContainerReport As System.Windows.Forms.SplitContainer
    Friend WithEvents GridDiagnosisbyDistrict As Janus.Windows.GridEX.GridEX
    Friend WithEvents CRVConsultation As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents BgReportConsultation As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CboYear1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintPreview1 As System.Windows.Forms.Button
    Friend WithEvents BgReportProviceDiagnosis As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerSearchPatien As System.Windows.Forms.Timer
    Friend WithEvents DSProvinceReport As TakeoHospitalInventory.DSProvinceReport
    Friend WithEvents DTblProvinceReportTableAdapter As TakeoHospitalInventory.DSProvinceReportTableAdapters.DTblProvinceReportTableAdapter
    Friend WithEvents TblConsultationEachTableAdapter As TakeoHospitalInventory.DSProvinceReportTableAdapters.TblConsultationEachTableAdapter

   

End Class
