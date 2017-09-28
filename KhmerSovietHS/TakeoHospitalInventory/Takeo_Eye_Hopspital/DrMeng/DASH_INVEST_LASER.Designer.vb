<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DASH_INVEST_LASER
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
        Dim GridLaser_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DASH_INVEST_LASER))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.GridLaser = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.BtnNewLaser = New System.Windows.Forms.ToolStripButton
        Me.BtnUpdateLaser = New System.Windows.Forms.ToolStripButton
        Me.BtnDeleteLaser = New System.Windows.Forms.ToolStripButton
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.BtnNewInvest = New System.Windows.Forms.ToolStripButton
        Me.BtlUpdateInves = New System.Windows.Forms.ToolStripButton
        Me.BtnDeletInves = New System.Windows.Forms.ToolStripButton
        Me.BtnRefreshInv = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1370, 760)
        Me.SplitContainer1.SplitterDistance = 550
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GridLaser)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 760)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laser"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GridEX1)
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(816, 760)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Investigate"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewLaser, Me.ToolStripSeparator1, Me.BtnUpdateLaser, Me.ToolStripSeparator2, Me.BtnDeleteLaser, Me.ToolStripSeparator3, Me.BtnRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 22)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(544, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'GridLaser
        '
        Me.GridLaser.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridLaser.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridLaser_DesignTimeLayout.LayoutString = resources.GetString("GridLaser_DesignTimeLayout.LayoutString")
        Me.GridLaser.DesignTimeLayout = GridLaser_DesignTimeLayout
        Me.GridLaser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLaser.GroupByBoxVisible = False
        Me.GridLaser.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridLaser.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridLaser.Location = New System.Drawing.Point(3, 54)
        Me.GridLaser.Name = "GridLaser"
        Me.GridLaser.RecordNavigator = True
        Me.GridLaser.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridLaser.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridLaser.Size = New System.Drawing.Size(544, 703)
        Me.GridLaser.TabIndex = 1
        Me.GridLaser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewInvest, Me.ToolStripSeparator4, Me.BtlUpdateInves, Me.ToolStripSeparator5, Me.BtnDeletInves, Me.ToolStripSeparator6, Me.BtnRefreshInv})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 22)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(810, 32)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 32)
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEX1.Location = New System.Drawing.Point(3, 54)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.Size = New System.Drawing.Size(810, 703)
        Me.GridEX1.TabIndex = 4
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'BtnNewLaser
        '
        Me.BtnNewLaser.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnNewLaser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewLaser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNewLaser.ForeColor = System.Drawing.Color.White
        Me.BtnNewLaser.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Addnew
        Me.BtnNewLaser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewLaser.Name = "BtnNewLaser"
        Me.BtnNewLaser.Size = New System.Drawing.Size(112, 29)
        Me.BtnNewLaser.Text = "New Laser"
        '
        'BtnUpdateLaser
        '
        Me.BtnUpdateLaser.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnUpdateLaser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdateLaser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnUpdateLaser.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateLaser.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit1
        Me.BtnUpdateLaser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateLaser.Name = "BtnUpdateLaser"
        Me.BtnUpdateLaser.Size = New System.Drawing.Size(130, 29)
        Me.BtnUpdateLaser.Text = "Update Laser"
        '
        'BtnDeleteLaser
        '
        Me.BtnDeleteLaser.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnDeleteLaser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteLaser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeleteLaser.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteLaser.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteLaser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteLaser.Name = "BtnDeleteLaser"
        Me.BtnDeleteLaser.Size = New System.Drawing.Size(124, 29)
        Me.BtnDeleteLaser.Text = "Delete Laser"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(87, 29)
        Me.BtnRefresh.Text = "  Refresh  "
        '
        'BtnNewInvest
        '
        Me.BtnNewInvest.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnNewInvest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewInvest.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNewInvest.ForeColor = System.Drawing.Color.White
        Me.BtnNewInvest.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Addnew
        Me.BtnNewInvest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewInvest.Name = "BtnNewInvest"
        Me.BtnNewInvest.Size = New System.Drawing.Size(112, 29)
        Me.BtnNewInvest.Text = "New Laser"
        '
        'BtlUpdateInves
        '
        Me.BtlUpdateInves.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtlUpdateInves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtlUpdateInves.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtlUpdateInves.ForeColor = System.Drawing.Color.White
        Me.BtlUpdateInves.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit1
        Me.BtlUpdateInves.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtlUpdateInves.Name = "BtlUpdateInves"
        Me.BtlUpdateInves.Size = New System.Drawing.Size(130, 29)
        Me.BtlUpdateInves.Text = "Update Laser"
        '
        'BtnDeletInves
        '
        Me.BtnDeletInves.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnDeletInves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeletInves.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDeletInves.ForeColor = System.Drawing.Color.White
        Me.BtnDeletInves.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeletInves.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeletInves.Name = "BtnDeletInves"
        Me.BtnDeletInves.Size = New System.Drawing.Size(124, 29)
        Me.BtnDeletInves.Text = "Delete Laser"
        '
        'BtnRefreshInv
        '
        Me.BtnRefreshInv.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnRefreshInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefreshInv.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshInv.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefreshInv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshInv.Name = "BtnRefreshInv"
        Me.BtnRefreshInv.Size = New System.Drawing.Size(87, 29)
        Me.BtnRefreshInv.Text = "  Refresh  "
        '
        'DASH_INVEST_LASER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DASH_INVEST_LASER"
        Me.Size = New System.Drawing.Size(1370, 760)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridLaser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewLaser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateLaser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteLaser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridLaser As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewInvest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtlUpdateInves As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeletInves As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshInv As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX

End Class
