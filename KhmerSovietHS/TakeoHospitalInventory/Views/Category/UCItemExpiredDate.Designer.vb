<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCItemExpiredDate
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
        Dim GridItemExpiredDate_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCItemExpiredDate))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboCategory = New System.Windows.Forms.ComboBox
        Me.ChCategory = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DTPToDate = New System.Windows.Forms.DateTimePicker
        Me.ChBActivePeriod = New System.Windows.Forms.CheckBox
        Me.DTPFDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.RBViewTable = New System.Windows.Forms.RadioButton
        Me.RBViewReport = New System.Windows.Forms.RadioButton
        Me.CBItem = New System.Windows.Forms.ComboBox
        Me.ChBAllItem = New System.Windows.Forms.CheckBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridItemExpiredDate = New Janus.Windows.GridEX.GridEX
        Me.CRVReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BGWExpiredDate = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridItemExpiredDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1123, 694)
        Me.SplitContainer1.SplitterDistance = 265
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboCategory)
        Me.GroupBox1.Controls.Add(Me.ChCategory)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnPreview)
        Me.GroupBox1.Controls.Add(Me.RBViewTable)
        Me.GroupBox1.Controls.Add(Me.RBViewReport)
        Me.GroupBox1.Controls.Add(Me.CBItem)
        Me.GroupBox1.Controls.Add(Me.ChBAllItem)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 694)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Filter"
        '
        'CboCategory
        '
        Me.CboCategory.Enabled = False
        Me.CboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Location = New System.Drawing.Point(18, 128)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(225, 28)
        Me.CboCategory.TabIndex = 12
        '
        'ChCategory
        '
        Me.ChCategory.AutoSize = True
        Me.ChCategory.Checked = True
        Me.ChCategory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChCategory.Location = New System.Drawing.Point(18, 105)
        Me.ChCategory.Name = "ChCategory"
        Me.ChCategory.Size = New System.Drawing.Size(82, 17)
        Me.ChCategory.TabIndex = 11
        Me.ChCategory.Text = "All Category"
        Me.ChCategory.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTPToDate)
        Me.GroupBox2.Controls.Add(Me.ChBActivePeriod)
        Me.GroupBox2.Controls.Add(Me.DTPFDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 80)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'DTPToDate
        '
        Me.DTPToDate.CustomFormat = "dd/MM/yyyy"
        Me.DTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPToDate.Location = New System.Drawing.Point(77, 45)
        Me.DTPToDate.Name = "DTPToDate"
        Me.DTPToDate.Size = New System.Drawing.Size(143, 20)
        Me.DTPToDate.TabIndex = 3
        '
        'ChBActivePeriod
        '
        Me.ChBActivePeriod.AutoSize = True
        Me.ChBActivePeriod.Checked = True
        Me.ChBActivePeriod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBActivePeriod.Location = New System.Drawing.Point(9, -1)
        Me.ChBActivePeriod.Name = "ChBActivePeriod"
        Me.ChBActivePeriod.Size = New System.Drawing.Size(135, 17)
        Me.ChBActivePeriod.TabIndex = 9
        Me.ChBActivePeriod.Text = "Specific Period of Time"
        Me.ChBActivePeriod.UseVisualStyleBackColor = True
        '
        'DTPFDate
        '
        Me.DTPFDate.CustomFormat = "dd/MM/yyyy"
        Me.DTPFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFDate.Location = New System.Drawing.Point(77, 19)
        Me.DTPFDate.Name = "DTPFDate"
        Me.DTPFDate.Size = New System.Drawing.Size(143, 20)
        Me.DTPFDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To Date :"
        '
        'BtnPreview
        '
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.Location = New System.Drawing.Point(152, 182)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(91, 28)
        Me.BtnPreview.TabIndex = 8
        Me.BtnPreview.Text = "Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'RBViewTable
        '
        Me.RBViewTable.AutoSize = True
        Me.RBViewTable.Checked = True
        Me.RBViewTable.Location = New System.Drawing.Point(21, 193)
        Me.RBViewTable.Name = "RBViewTable"
        Me.RBViewTable.Size = New System.Drawing.Size(88, 17)
        Me.RBViewTable.TabIndex = 7
        Me.RBViewTable.TabStop = True
        Me.RBViewTable.Text = "View as table"
        Me.RBViewTable.UseVisualStyleBackColor = True
        '
        'RBViewReport
        '
        Me.RBViewReport.AutoSize = True
        Me.RBViewReport.Location = New System.Drawing.Point(21, 165)
        Me.RBViewReport.Name = "RBViewReport"
        Me.RBViewReport.Size = New System.Drawing.Size(92, 17)
        Me.RBViewReport.TabIndex = 6
        Me.RBViewReport.Text = "View as report"
        Me.RBViewReport.UseVisualStyleBackColor = True
        '
        'CBItem
        '
        Me.CBItem.Enabled = False
        Me.CBItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBItem.FormattingEnabled = True
        Me.CBItem.Location = New System.Drawing.Point(18, 327)
        Me.CBItem.Name = "CBItem"
        Me.CBItem.Size = New System.Drawing.Size(225, 28)
        Me.CBItem.TabIndex = 1
        Me.CBItem.Visible = False
        '
        'ChBAllItem
        '
        Me.ChBAllItem.AutoSize = True
        Me.ChBAllItem.Checked = True
        Me.ChBAllItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBAllItem.Location = New System.Drawing.Point(18, 304)
        Me.ChBAllItem.Name = "ChBAllItem"
        Me.ChBAllItem.Size = New System.Drawing.Size(60, 17)
        Me.ChBAllItem.TabIndex = 0
        Me.ChBAllItem.Text = "All Item"
        Me.ChBAllItem.UseVisualStyleBackColor = True
        Me.ChBAllItem.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridItemExpiredDate)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CRVReportViewer)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(854, 694)
        Me.SplitContainer2.SplitterDistance = 201
        Me.SplitContainer2.TabIndex = 0
        '
        'GridItemExpiredDate
        '
        Me.GridItemExpiredDate.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridItemExpiredDate_DesignTimeLayout.LayoutString = resources.GetString("GridItemExpiredDate_DesignTimeLayout.LayoutString")
        Me.GridItemExpiredDate.DesignTimeLayout = GridItemExpiredDate_DesignTimeLayout
        Me.GridItemExpiredDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemExpiredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridItemExpiredDate.GroupByBoxVisible = False
        Me.GridItemExpiredDate.Location = New System.Drawing.Point(0, 0)
        Me.GridItemExpiredDate.Margin = New System.Windows.Forms.Padding(2)
        Me.GridItemExpiredDate.Name = "GridItemExpiredDate"
        Me.GridItemExpiredDate.RecordNavigator = True
        Me.GridItemExpiredDate.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridItemExpiredDate.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItemExpiredDate.Size = New System.Drawing.Size(854, 694)
        Me.GridItemExpiredDate.TabIndex = 4
        Me.GridItemExpiredDate.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'CRVReportViewer
        '
        Me.CRVReportViewer.ActiveViewIndex = -1
        Me.CRVReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportViewer.DisplayGroupTree = False
        Me.CRVReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRVReportViewer.Name = "CRVReportViewer"
        Me.CRVReportViewer.SelectionFormula = ""
        Me.CRVReportViewer.Size = New System.Drawing.Size(150, 46)
        Me.CRVReportViewer.TabIndex = 0
        Me.CRVReportViewer.ViewTimeSelectionFormula = ""
        '
        'BGWExpiredDate
        '
        '
        'UCItemExpiredDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCItemExpiredDate"
        Me.Size = New System.Drawing.Size(1123, 694)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridItemExpiredDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChBActivePeriod As System.Windows.Forms.CheckBox
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents RBViewTable As System.Windows.Forms.RadioButton
    Friend WithEvents RBViewReport As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBItem As System.Windows.Forms.ComboBox
    Friend WithEvents ChBAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents BGWExpiredDate As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridItemExpiredDate As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CRVReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ChCategory As System.Windows.Forms.CheckBox
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox

End Class
