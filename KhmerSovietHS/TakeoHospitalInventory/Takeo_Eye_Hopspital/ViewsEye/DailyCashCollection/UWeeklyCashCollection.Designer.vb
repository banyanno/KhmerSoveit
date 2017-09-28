<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UWeeklyCashCollection
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
        Dim GridAccountPayable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UWeeklyCashCollection))
        Dim dgvCashTotalAll_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim dgvTotalCash_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim dgvRemarks_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim dgvCashCount_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim dgvCash_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GridAccountPayable = New Janus.Windows.GridEX.GridEX
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalR = New System.Windows.Forms.TextBox
        Me.txtTotalUS = New System.Windows.Forms.TextBox
        Me.dgvCashTotalAll = New Janus.Windows.GridEX.GridEX
        Me.dgvTotalCash = New Janus.Windows.GridEX.GridEX
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.dgvRemarks = New Janus.Windows.GridEX.GridEX
        Me.dgvCashCount = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PicLoad = New System.Windows.Forms.PictureBox
        Me.dgvCash = New Janus.Windows.GridEX.GridEX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker
        Me.BgWeekly = New System.ComponentModel.BackgroundWorker
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GridAccountPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCashTotalAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTotalCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCashCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1145, 1005)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1137, 972)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Weekly Summary Report of Cash Collections"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(1326, 2000)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1131, 966)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.dgvCashTotalAll)
        Me.GroupBox2.Controls.Add(Me.dgvTotalCash)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.dgvCashCount)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 394)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 1606)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Cash Count Weekly"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GridAccountPayable)
        Me.GroupBox6.Location = New System.Drawing.Point(496, 357)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(462, 189)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Remark Account Payable"
        '
        'GridAccountPayable
        '
        Me.GridAccountPayable.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAccountPayable_DesignTimeLayout.LayoutString = resources.GetString("GridAccountPayable_DesignTimeLayout.LayoutString")
        Me.GridAccountPayable.DesignTimeLayout = GridAccountPayable_DesignTimeLayout
        Me.GridAccountPayable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAccountPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridAccountPayable.GroupByBoxVisible = False
        Me.GridAccountPayable.Location = New System.Drawing.Point(3, 22)
        Me.GridAccountPayable.Name = "GridAccountPayable"
        Me.GridAccountPayable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAccountPayable.Size = New System.Drawing.Size(456, 164)
        Me.GridAccountPayable.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtTotalR)
        Me.GroupBox4.Controls.Add(Me.txtTotalUS)
        Me.GroupBox4.Location = New System.Drawing.Point(1022, 379)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(87, 125)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Weekly Cash Count"
        Me.GroupBox4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "RIEL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "US $"
        '
        'txtTotalR
        '
        Me.txtTotalR.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalR.Location = New System.Drawing.Point(315, 61)
        Me.txtTotalR.Name = "txtTotalR"
        Me.txtTotalR.Size = New System.Drawing.Size(266, 38)
        Me.txtTotalR.TabIndex = 0
        Me.txtTotalR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalUS
        '
        Me.txtTotalUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUS.Location = New System.Drawing.Point(43, 61)
        Me.txtTotalUS.Name = "txtTotalUS"
        Me.txtTotalUS.Size = New System.Drawing.Size(266, 38)
        Me.txtTotalUS.TabIndex = 0
        Me.txtTotalUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvCashTotalAll
        '
        dgvCashTotalAll_DesignTimeLayout.LayoutString = resources.GetString("dgvCashTotalAll_DesignTimeLayout.LayoutString")
        Me.dgvCashTotalAll.DesignTimeLayout = dgvCashTotalAll_DesignTimeLayout
        Me.dgvCashTotalAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvCashTotalAll.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dgvCashTotalAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dgvCashTotalAll.GroupByBoxVisible = False
        Me.dgvCashTotalAll.Location = New System.Drawing.Point(3, 314)
        Me.dgvCashTotalAll.Name = "dgvCashTotalAll"
        Me.dgvCashTotalAll.Size = New System.Drawing.Size(1320, 41)
        Me.dgvCashTotalAll.TabIndex = 9
        Me.dgvCashTotalAll.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.dgvCashTotalAll.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'dgvTotalCash
        '
        dgvTotalCash_DesignTimeLayout.LayoutString = resources.GetString("dgvTotalCash_DesignTimeLayout.LayoutString")
        Me.dgvTotalCash.DesignTimeLayout = dgvTotalCash_DesignTimeLayout
        Me.dgvTotalCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvTotalCash.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dgvTotalCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dgvTotalCash.GroupByBoxVisible = False
        Me.dgvTotalCash.Location = New System.Drawing.Point(3, 273)
        Me.dgvTotalCash.Name = "dgvTotalCash"
        Me.dgvTotalCash.Size = New System.Drawing.Size(1320, 41)
        Me.dgvTotalCash.TabIndex = 8
        Me.dgvTotalCash.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.dgvTotalCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvRemarks)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 357)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(474, 192)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Tag = "Remark Account Receiptable"
        Me.GroupBox5.Text = "Remark Account Receiveable"
        '
        'dgvRemarks
        '
        dgvRemarks_DesignTimeLayout.LayoutString = resources.GetString("dgvRemarks_DesignTimeLayout.LayoutString")
        Me.dgvRemarks.DesignTimeLayout = dgvRemarks_DesignTimeLayout
        Me.dgvRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRemarks.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dgvRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dgvRemarks.GroupByBoxVisible = False
        Me.dgvRemarks.Location = New System.Drawing.Point(3, 22)
        Me.dgvRemarks.Name = "dgvRemarks"
        Me.dgvRemarks.Size = New System.Drawing.Size(468, 167)
        Me.dgvRemarks.TabIndex = 0
        '
        'dgvCashCount
        '
        dgvCashCount_DesignTimeLayout.LayoutString = resources.GetString("dgvCashCount_DesignTimeLayout.LayoutString")
        Me.dgvCashCount.DesignTimeLayout = dgvCashCount_DesignTimeLayout
        Me.dgvCashCount.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvCashCount.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dgvCashCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dgvCashCount.GroupByBoxVisible = False
        Me.dgvCashCount.Location = New System.Drawing.Point(3, 22)
        Me.dgvCashCount.Name = "dgvCashCount"
        Me.dgvCashCount.RecordNavigator = True
        Me.dgvCashCount.Size = New System.Drawing.Size(1320, 251)
        Me.dgvCashCount.TabIndex = 0
        Me.dgvCashCount.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.dgvCashCount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicLoad)
        Me.GroupBox1.Controls.Add(Me.dgvCash)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 394)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Cash Weekly"
        '
        'PicLoad
        '
        Me.PicLoad.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar
        Me.PicLoad.Location = New System.Drawing.Point(475, 232)
        Me.PicLoad.Name = "PicLoad"
        Me.PicLoad.Size = New System.Drawing.Size(195, 24)
        Me.PicLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoad.TabIndex = 3
        Me.PicLoad.TabStop = False
        Me.PicLoad.Visible = False
        '
        'dgvCash
        '
        Me.dgvCash.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        dgvCash_DesignTimeLayout.LayoutString = resources.GetString("dgvCash_DesignTimeLayout.LayoutString")
        Me.dgvCash.DesignTimeLayout = dgvCash_DesignTimeLayout
        Me.dgvCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dgvCash.GroupByBoxVisible = False
        Me.dgvCash.Location = New System.Drawing.Point(3, 98)
        Me.dgvCash.Name = "dgvCash"
        Me.dgvCash.RecordNavigator = True
        Me.dgvCash.Size = New System.Drawing.Size(1320, 293)
        Me.dgvCash.TabIndex = 0
        Me.dgvCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmdPrint)
        Me.GroupBox3.Controls.Add(Me.cmdView)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpDateTo)
        Me.GroupBox3.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1320, 76)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Date to view"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(607, 25)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(85, 40)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Location = New System.Drawing.Point(516, 25)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(85, 40)
        Me.cmdView.TabIndex = 1
        Me.cmdView.Text = "&View"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date from:"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(344, 32)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(152, 26)
        Me.dtpDateTo.TabIndex = 0
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(104, 33)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(150, 26)
        Me.dtpDateFrom.TabIndex = 0
        '
        'BgWeekly
        '
        '
        'UWeeklyCashCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "UWeeklyCashCollection"
        Me.Size = New System.Drawing.Size(1145, 1005)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.GridAccountPayable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvCashTotalAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTotalCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCashCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRemarks As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCashCount As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCash As Janus.Windows.GridEX.GridEX
    Friend WithEvents PicLoad As System.Windows.Forms.PictureBox
    Friend WithEvents BgWeekly As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvTotalCash As Janus.Windows.GridEX.GridEX
    Friend WithEvents dgvCashTotalAll As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalR As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalUS As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GridAccountPayable As Janus.Windows.GridEX.GridEX

End Class
