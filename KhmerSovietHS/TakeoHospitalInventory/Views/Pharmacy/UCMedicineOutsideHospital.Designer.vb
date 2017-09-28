<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMedicineOutsideHospital
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
        Dim gridMedicineOutsideHospital_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMedicineOutsideHospital))
        Dim gridItemOutsideTrans_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefreshPrescrip = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnItemOutsideHos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMedicineOutsideHospital = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewItemOutsideTrans = New System.Windows.Forms.ToolStripButton
        Me.gridMedicineOutsideHospital = New Janus.Windows.GridEX.GridEX
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gridItemOutsideTrans = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dptToDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.DTPTo = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridMedicineOutsideHospital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridItemOutsideTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefreshPrescrip, Me.ToolStripSeparator4, Me.BtnItemOutsideHos, Me.ToolStripSeparator1, Me.BtnEdit, Me.ToolStripSeparator2, Me.BtnMedicineOutsideHospital, Me.ToolStripSeparator3, Me.BtnViewItemOutsideTrans})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1295, 37)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefreshPrescrip
        '
        Me.BtnRefreshPrescrip.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefreshPrescrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshPrescrip.Name = "BtnRefreshPrescrip"
        Me.BtnRefreshPrescrip.Size = New System.Drawing.Size(105, 34)
        Me.BtnRefreshPrescrip.Text = "Refresh Data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'BtnItemOutsideHos
        '
        Me.BtnItemOutsideHos.Image = Global.TakeoHospitalInventory.My.Resources.Resources.medicine
        Me.BtnItemOutsideHos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnItemOutsideHos.Name = "BtnItemOutsideHos"
        Me.BtnItemOutsideHos.Size = New System.Drawing.Size(167, 34)
        Me.BtnItemOutsideHos.Text = "New Medicine Outside Hos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        Me.ToolStripSeparator1.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(59, 34)
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        Me.ToolStripSeparator2.Visible = False
        '
        'BtnMedicineOutsideHospital
        '
        Me.BtnMedicineOutsideHospital.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnMedicineOutsideHospital.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMedicineOutsideHospital.Name = "BtnMedicineOutsideHospital"
        Me.BtnMedicineOutsideHospital.Size = New System.Drawing.Size(188, 34)
        Me.BtnMedicineOutsideHospital.Text = "Print Medicine Outside Hospital"
        Me.BtnMedicineOutsideHospital.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'BtnViewItemOutsideTrans
        '
        Me.BtnViewItemOutsideTrans.Image = Global.TakeoHospitalInventory.My.Resources.Resources.arrow_down_green_48
        Me.BtnViewItemOutsideTrans.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewItemOutsideTrans.Name = "BtnViewItemOutsideTrans"
        Me.BtnViewItemOutsideTrans.Size = New System.Drawing.Size(147, 34)
        Me.BtnViewItemOutsideTrans.Text = "View Item Transaction"
        '
        'gridMedicineOutsideHospital
        '
        Me.gridMedicineOutsideHospital.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridMedicineOutsideHospital_DesignTimeLayout.LayoutString = resources.GetString("gridMedicineOutsideHospital_DesignTimeLayout.LayoutString")
        Me.gridMedicineOutsideHospital.DesignTimeLayout = gridMedicineOutsideHospital_DesignTimeLayout
        Me.gridMedicineOutsideHospital.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridMedicineOutsideHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridMedicineOutsideHospital.GroupByBoxVisible = False
        Me.gridMedicineOutsideHospital.Location = New System.Drawing.Point(0, 0)
        Me.gridMedicineOutsideHospital.Name = "gridMedicineOutsideHospital"
        Me.gridMedicineOutsideHospital.RecordNavigator = True
        Me.gridMedicineOutsideHospital.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridMedicineOutsideHospital.Size = New System.Drawing.Size(485, 355)
        Me.gridMedicineOutsideHospital.TabIndex = 7
        Me.gridMedicineOutsideHospital.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'FilterEditor1
        '
        Me.FilterEditor1.AutoApply = True
        Me.FilterEditor1.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(0, 99)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(16, 45)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(1295, 67)
        Me.FilterEditor1.SourceControl = Me.gridMedicineOutsideHospital
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 166)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridMedicineOutsideHospital)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridItemOutsideTrans)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1295, 355)
        Me.SplitContainer1.SplitterDistance = 485
        Me.SplitContainer1.TabIndex = 9
        '
        'gridItemOutsideTrans
        '
        Me.gridItemOutsideTrans.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemOutsideTrans_DesignTimeLayout.LayoutString = resources.GetString("gridItemOutsideTrans_DesignTimeLayout.LayoutString")
        Me.gridItemOutsideTrans.DesignTimeLayout = gridItemOutsideTrans_DesignTimeLayout
        Me.gridItemOutsideTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemOutsideTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemOutsideTrans.GroupByBoxVisible = False
        Me.gridItemOutsideTrans.Location = New System.Drawing.Point(0, 48)
        Me.gridItemOutsideTrans.Name = "gridItemOutsideTrans"
        Me.gridItemOutsideTrans.RecordNavigator = True
        Me.gridItemOutsideTrans.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemOutsideTrans.Size = New System.Drawing.Size(806, 307)
        Me.gridItemOutsideTrans.TabIndex = 8
        Me.gridItemOutsideTrans.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dptToDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dptFromDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 48)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(284, 12)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(151, 26)
        Me.dptToDate.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "To Date:"
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(68, 12)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(151, 26)
        Me.dptFromDate.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "From Date:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnPrint)
        Me.GroupBox2.Controls.Add(Me.DTPTo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DTPFrom)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1295, 62)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(462, 15)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(228, 38)
        Me.BtnPrint.TabIndex = 25
        Me.BtnPrint.Text = "Print Medicine Outside Hospital"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'DTPTo
        '
        Me.DTPTo.Checked = False
        Me.DTPTo.CustomFormat = "dd/MM/yyyy"
        Me.DTPTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(291, 18)
        Me.DTPTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(151, 26)
        Me.DTPTo.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "To Date:"
        '
        'DTPFrom
        '
        Me.DTPFrom.Checked = False
        Me.DTPFrom.CustomFormat = "dd/MM/yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(75, 18)
        Me.DTPFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(151, 26)
        Me.DTPFrom.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "From Date:"
        '
        'UCMedicineOutsideHospital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FilterEditor1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCMedicineOutsideHospital"
        Me.Size = New System.Drawing.Size(1295, 521)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridMedicineOutsideHospital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridItemOutsideTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnRefreshPrescrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMedicineOutsideHospital As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridMedicineOutsideHospital As Janus.Windows.GridEX.GridEX
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents BtnItemOutsideHos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewItemOutsideTrans As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridItemOutsideTrans As Janus.Windows.GridEX.GridEX
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button

End Class
