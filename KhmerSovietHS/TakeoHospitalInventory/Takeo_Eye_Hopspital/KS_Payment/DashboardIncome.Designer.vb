<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardIncome))
        Dim GridIncome_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintlabel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF
        Me.GridIncome = New Janus.Windows.GridEX.GridEX
        Me.ChReport = New System.Windows.Forms.CheckBox
        Me.btnView = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintPreview, Me.ToolStripSeparator1, Me.BtnPrintlabel, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1253, 62)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackgroundImage = CType(resources.GetObject("BtnPrintPreview.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.BtnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(262, 59)
        Me.BtnPrintPreview.Text = "     Print Invoice / Prescription   "
        Me.BtnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 62)
        '
        'BtnPrintlabel
        '
        Me.BtnPrintlabel.BackgroundImage = CType(resources.GetObject("BtnPrintlabel.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintlabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintlabel.ForeColor = System.Drawing.Color.White
        Me.BtnPrintlabel.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1422017622_Terms_rev_512
        Me.BtnPrintlabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintlabel.Name = "BtnPrintlabel"
        Me.BtnPrintlabel.Size = New System.Drawing.Size(154, 59)
        Me.BtnPrintlabel.Text = "        Print Label         "
        Me.BtnPrintlabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 62)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackgroundImage = CType(resources.GetObject("ToolStripButton1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Receipt_oop
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(185, 59)
        Me.ToolStripButton1.Text = "         Report Income         "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 62)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.AxAcroPDF1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridIncome)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChReport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateFrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1253, 534)
        Me.SplitContainer1.SplitterDistance = 1026
        Me.SplitContainer1.TabIndex = 1
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(147, 156)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(810, 272)
        Me.AxAcroPDF1.TabIndex = 1
        Me.AxAcroPDF1.Visible = False
        '
        'GridIncome
        '
        Me.GridIncome.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridIncome.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridIncome_DesignTimeLayout.LayoutString = resources.GetString("GridIncome_DesignTimeLayout.LayoutString")
        Me.GridIncome.DesignTimeLayout = GridIncome_DesignTimeLayout
        Me.GridIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridIncome.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridIncome.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridIncome.GroupByBoxVisible = False
        Me.GridIncome.HeaderFormatStyle.FontSize = 10.0!
        Me.GridIncome.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridIncome.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridIncome.Hierarchical = True
        Me.GridIncome.Location = New System.Drawing.Point(0, 0)
        Me.GridIncome.Name = "GridIncome"
        Me.GridIncome.RecordNavigator = True
        Me.GridIncome.RowFormatStyle.FontSize = 12.0!
        Me.GridIncome.Size = New System.Drawing.Size(1024, 532)
        Me.GridIncome.TabIndex = 0
        Me.GridIncome.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridIncome.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ChReport
        '
        Me.ChReport.AutoSize = True
        Me.ChReport.ForeColor = System.Drawing.Color.Blue
        Me.ChReport.Location = New System.Drawing.Point(10, 98)
        Me.ChReport.Name = "ChReport"
        Me.ChReport.Size = New System.Drawing.Size(98, 17)
        Me.ChReport.TabIndex = 5
        Me.ChReport.Text = "View as Report"
        Me.ChReport.UseVisualStyleBackColor = True
        Me.ChReport.Visible = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(110, 90)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(102, 32)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View Data"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(72, 56)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(135, 26)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(72, 20)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(135, 26)
        Me.DateFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        '
        'DashboardIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardIncome"
        Me.Size = New System.Drawing.Size(1253, 596)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridIncome As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents ChReport As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintlabel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
