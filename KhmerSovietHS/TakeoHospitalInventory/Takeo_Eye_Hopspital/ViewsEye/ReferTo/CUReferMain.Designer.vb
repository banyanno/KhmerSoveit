<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUReferMain
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
        Dim GridListReferTo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CUReferMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ChViewBy = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CboReferTo = New System.Windows.Forms.ComboBox
        Me.RadViewByRefer = New System.Windows.Forms.RadioButton
        Me.RadViewAllRefer = New System.Windows.Forms.RadioButton
        Me.BtnPrintRefer = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateReferTo = New System.Windows.Forms.DateTimePicker
        Me.DateReferFrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnResult = New System.Windows.Forms.Button
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitPatientReferTo = New System.Windows.Forms.SplitContainer
        Me.GridListReferTo = New Janus.Windows.GridEX.GridEX
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.CReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletePatientReferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BgLoadReport = New System.ComponentModel.BackgroundWorker
        Me.DataReportUtility = New TakeoHospitalInventory.DataReportUtility
        Me.V_PatientReferTableAdapter = New TakeoHospitalInventory.DataReportUtilityTableAdapters.V_PatientReferTableAdapter
        Me.TblReferToByDiagnosisTableAdapter = New TakeoHospitalInventory.DataReportUtilityTableAdapters.TblReferToByDiagnosisTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitPatientReferTo.Panel1.SuspendLayout()
        Me.SplitPatientReferTo.Panel2.SuspendLayout()
        Me.SplitPatientReferTo.SuspendLayout()
        CType(Me.GridListReferTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DataReportUtility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.BtnResult)
        Me.GroupBox1.Controls.Add(Me.DTo)
        Me.GroupBox1.Controls.Add(Me.DFrom)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1239, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Patient Refer Conditon By"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ChViewBy)
        Me.GroupBox6.Controls.Add(Me.GroupBox3)
        Me.GroupBox6.Controls.Add(Me.BtnPrintRefer)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.DateReferTo)
        Me.GroupBox6.Controls.Add(Me.DateReferFrom)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(341, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(535, 111)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Report Patient Refer To"
        '
        'ChViewBy
        '
        Me.ChViewBy.AutoSize = True
        Me.ChViewBy.Location = New System.Drawing.Point(180, 16)
        Me.ChViewBy.Name = "ChViewBy"
        Me.ChViewBy.Size = New System.Drawing.Size(15, 14)
        Me.ChViewBy.TabIndex = 0
        Me.ChViewBy.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CboReferTo)
        Me.GroupBox3.Controls.Add(Me.RadViewByRefer)
        Me.GroupBox3.Controls.Add(Me.RadViewAllRefer)
        Me.GroupBox3.Location = New System.Drawing.Point(174, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 90)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "    View Report by age:"
        '
        'CboReferTo
        '
        Me.CboReferTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboReferTo.DropDownWidth = 250
        Me.CboReferTo.Enabled = False
        Me.CboReferTo.FormattingEnabled = True
        Me.CboReferTo.Location = New System.Drawing.Point(99, 50)
        Me.CboReferTo.Name = "CboReferTo"
        Me.CboReferTo.Size = New System.Drawing.Size(166, 21)
        Me.CboReferTo.TabIndex = 1
        '
        'RadViewByRefer
        '
        Me.RadViewByRefer.AutoSize = True
        Me.RadViewByRefer.Enabled = False
        Me.RadViewByRefer.Location = New System.Drawing.Point(6, 53)
        Me.RadViewByRefer.Name = "RadViewByRefer"
        Me.RadViewByRefer.Size = New System.Drawing.Size(95, 17)
        Me.RadViewByRefer.TabIndex = 0
        Me.RadViewByRefer.Text = "View By Refer:"
        Me.RadViewByRefer.UseVisualStyleBackColor = True
        '
        'RadViewAllRefer
        '
        Me.RadViewAllRefer.AutoSize = True
        Me.RadViewAllRefer.Checked = True
        Me.RadViewAllRefer.Enabled = False
        Me.RadViewAllRefer.Location = New System.Drawing.Point(6, 20)
        Me.RadViewAllRefer.Name = "RadViewAllRefer"
        Me.RadViewAllRefer.Size = New System.Drawing.Size(107, 17)
        Me.RadViewAllRefer.TabIndex = 0
        Me.RadViewAllRefer.TabStop = True
        Me.RadViewAllRefer.Text = "View All Refer To"
        Me.RadViewAllRefer.UseVisualStyleBackColor = True
        '
        'BtnPrintRefer
        '
        Me.BtnPrintRefer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintRefer.Location = New System.Drawing.Point(451, 31)
        Me.BtnPrintRefer.Name = "BtnPrintRefer"
        Me.BtnPrintRefer.Size = New System.Drawing.Size(75, 63)
        Me.BtnPrintRefer.TabIndex = 12
        Me.BtnPrintRefer.Text = "&Print Preview"
        Me.BtnPrintRefer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Between:"
        '
        'DateReferTo
        '
        Me.DateReferTo.CustomFormat = "dd/MM/yyyy"
        Me.DateReferTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReferTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReferTo.Location = New System.Drawing.Point(56, 68)
        Me.DateReferTo.Name = "DateReferTo"
        Me.DateReferTo.Size = New System.Drawing.Size(107, 26)
        Me.DateReferTo.TabIndex = 11
        '
        'DateReferFrom
        '
        Me.DateReferFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateReferFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReferFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReferFrom.Location = New System.Drawing.Point(56, 30)
        Me.DateReferFrom.Name = "DateReferFrom"
        Me.DateReferFrom.Size = New System.Drawing.Size(107, 26)
        Me.DateReferFrom.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "And:"
        '
        'BtnResult
        '
        Me.BtnResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResult.Location = New System.Drawing.Point(245, 74)
        Me.BtnResult.Name = "BtnResult"
        Me.BtnResult.Size = New System.Drawing.Size(88, 38)
        Me.BtnResult.TabIndex = 4
        Me.BtnResult.Text = "Result"
        Me.BtnResult.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(74, 86)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(165, 26)
        Me.DTo.TabIndex = 3
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(74, 54)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(165, 26)
        Me.DFrom.TabIndex = 3
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(74, 22)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(165, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SplitPatientReferTo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1239, 577)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Result Patient Refer"
        '
        'SplitPatientReferTo
        '
        Me.SplitPatientReferTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitPatientReferTo.Location = New System.Drawing.Point(3, 16)
        Me.SplitPatientReferTo.Name = "SplitPatientReferTo"
        '
        'SplitPatientReferTo.Panel1
        '
        Me.SplitPatientReferTo.Panel1.Controls.Add(Me.GridListReferTo)
        Me.SplitPatientReferTo.Panel1Collapsed = True
        '
        'SplitPatientReferTo.Panel2
        '
        Me.SplitPatientReferTo.Panel2.AutoScroll = True
        Me.SplitPatientReferTo.Panel2.Controls.Add(Me.PictLoading)
        Me.SplitPatientReferTo.Panel2.Controls.Add(Me.CReportViewer)
        Me.SplitPatientReferTo.Size = New System.Drawing.Size(1233, 558)
        Me.SplitPatientReferTo.SplitterDistance = 618
        Me.SplitPatientReferTo.TabIndex = 2
        '
        'GridListReferTo
        '
        Me.GridListReferTo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridListReferTo_DesignTimeLayout.LayoutString = resources.GetString("GridListReferTo_DesignTimeLayout.LayoutString")
        Me.GridListReferTo.DesignTimeLayout = GridListReferTo_DesignTimeLayout
        Me.GridListReferTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListReferTo.GroupByBoxVisible = False
        Me.GridListReferTo.Location = New System.Drawing.Point(0, 0)
        Me.GridListReferTo.Margin = New System.Windows.Forms.Padding(2)
        Me.GridListReferTo.Name = "GridListReferTo"
        Me.GridListReferTo.RecordNavigator = True
        Me.GridListReferTo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListReferTo.Size = New System.Drawing.Size(618, 100)
        Me.GridListReferTo.TabIndex = 1
        '
        'PictLoading
        '
        Me.PictLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar
        Me.PictLoading.Location = New System.Drawing.Point(533, 213)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(214, 23)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 1
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'CReportViewer
        '
        Me.CReportViewer.ActiveViewIndex = -1
        Me.CReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CReportViewer.DisplayGroupTree = False
        Me.CReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CReportViewer.Name = "CReportViewer"
        Me.CReportViewer.SelectionFormula = ""
        Me.CReportViewer.Size = New System.Drawing.Size(1233, 558)
        Me.CReportViewer.TabIndex = 0
        Me.CReportViewer.ViewTimeSelectionFormula = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletePatientReferToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 26)
        '
        'DeletePatientReferToolStripMenuItem
        '
        Me.DeletePatientReferToolStripMenuItem.Name = "DeletePatientReferToolStripMenuItem"
        Me.DeletePatientReferToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DeletePatientReferToolStripMenuItem.Text = "Delete Patient Refer"
        '
        'BgLoadReport
        '
        Me.BgLoadReport.WorkerReportsProgress = True
        Me.BgLoadReport.WorkerSupportsCancellation = True
        '
        'DataReportUtility
        '
        Me.DataReportUtility.DataSetName = "DataReportUtility"
        Me.DataReportUtility.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_PatientReferTableAdapter
        '
        Me.V_PatientReferTableAdapter.ClearBeforeFill = True
        '
        'TblReferToByDiagnosisTableAdapter
        '
        Me.TblReferToByDiagnosisTableAdapter.ClearBeforeFill = True
        '
        'CUReferMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CUReferMain"
        Me.Size = New System.Drawing.Size(1239, 700)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitPatientReferTo.Panel1.ResumeLayout(False)
        Me.SplitPatientReferTo.Panel2.ResumeLayout(False)
        Me.SplitPatientReferTo.ResumeLayout(False)
        CType(Me.GridListReferTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DataReportUtility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnResult As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeletePatientReferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridListReferTo As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintRefer As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateReferTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateReferFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SplitPatientReferTo As System.Windows.Forms.SplitContainer
    Friend WithEvents CReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DataReportUtility As TakeoHospitalInventory.DataReportUtility
    Friend WithEvents V_PatientReferTableAdapter As TakeoHospitalInventory.DataReportUtilityTableAdapters.V_PatientReferTableAdapter
    Friend WithEvents BgLoadReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents TblReferToByDiagnosisTableAdapter As TakeoHospitalInventory.DataReportUtilityTableAdapters.TblReferToByDiagnosisTableAdapter
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents ChViewBy As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadViewByRefer As System.Windows.Forms.RadioButton
    Friend WithEvents RadViewAllRefer As System.Windows.Forms.RadioButton
    Friend WithEvents CboReferTo As System.Windows.Forms.ComboBox

End Class
