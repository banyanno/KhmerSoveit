<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashMedicalCertificate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashMedicalCertificate))
        Dim GridCertificate_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewCertificate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateCertificate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteCert = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintCertifcate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.GridCertificate = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewCertificate, Me.ToolStripSeparator1, Me.BtnUpdateCertificate, Me.ToolStripSeparator2, Me.BtnDeleteCert, Me.ToolStripSeparator3, Me.BtnPrintCertifcate, Me.ToolStripSeparator4, Me.BtnRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(936, 52)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewCertificate
        '
        Me.BtnNewCertificate.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnNewCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewCertificate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnNewCertificate.ForeColor = System.Drawing.Color.White
        Me.BtnNewCertificate.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1422017622_Terms_rev_512
        Me.BtnNewCertificate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewCertificate.Name = "BtnNewCertificate"
        Me.BtnNewCertificate.Size = New System.Drawing.Size(115, 49)
        Me.BtnNewCertificate.Text = "New Certificate"
        Me.BtnNewCertificate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'BtnUpdateCertificate
        '
        Me.BtnUpdateCertificate.BackgroundImage = CType(resources.GetObject("BtnUpdateCertificate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdateCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdateCertificate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnUpdateCertificate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateCertificate.Image = Global.TakeoHospitalInventory.My.Resources.Resources._3d_orange_man_magnifying_glass
        Me.BtnUpdateCertificate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateCertificate.Name = "BtnUpdateCertificate"
        Me.BtnUpdateCertificate.Size = New System.Drawing.Size(134, 49)
        Me.BtnUpdateCertificate.Text = "Update Certificate"
        Me.BtnUpdateCertificate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'BtnDeleteCert
        '
        Me.BtnDeleteCert.BackgroundImage = CType(resources.GetObject("BtnDeleteCert.BackgroundImage"), System.Drawing.Image)
        Me.BtnDeleteCert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteCert.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnDeleteCert.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteCert.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteCert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteCert.Name = "BtnDeleteCert"
        Me.BtnDeleteCert.Size = New System.Drawing.Size(129, 49)
        Me.BtnDeleteCert.Text = "Delete Certificate"
        Me.BtnDeleteCert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'BtnPrintCertifcate
        '
        Me.BtnPrintCertifcate.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnPrintCertifcate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintCertifcate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnPrintCertifcate.ForeColor = System.Drawing.Color.White
        Me.BtnPrintCertifcate.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1421916923_printer
        Me.BtnPrintCertifcate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintCertifcate.Name = "BtnPrintCertifcate"
        Me.BtnPrintCertifcate.Size = New System.Drawing.Size(123, 49)
        Me.BtnPrintCertifcate.Text = " Print Certificate "
        Me.BtnPrintCertifcate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 52)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImage = CType(resources.GetObject("BtnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(86, 49)
        Me.BtnRefresh.Text = "   Refresh   "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GridCertificate
        '
        Me.GridCertificate.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCertificate.AlternatingColors = True
        GridCertificate_DesignTimeLayout.LayoutString = resources.GetString("GridCertificate_DesignTimeLayout.LayoutString")
        Me.GridCertificate.DesignTimeLayout = GridCertificate_DesignTimeLayout
        Me.GridCertificate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCertificate.DynamicFiltering = True
        Me.GridCertificate.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridCertificate.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridCertificate.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridCertificate.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridCertificate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCertificate.GroupByBoxVisible = False
        Me.GridCertificate.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridCertificate.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridCertificate.HeaderFormatStyle.FontSize = 12.0!
        Me.GridCertificate.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridCertificate.Location = New System.Drawing.Point(0, 52)
        Me.GridCertificate.Name = "GridCertificate"
        Me.GridCertificate.RecordNavigator = True
        Me.GridCertificate.Size = New System.Drawing.Size(936, 603)
        Me.GridCertificate.TabIndex = 1
        Me.GridCertificate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'DashMedicalCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.GridCertificate)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashMedicalCertificate"
        Me.Size = New System.Drawing.Size(936, 655)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewCertificate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateCertificate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteCert As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridCertificate As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnPrintCertifcate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator

End Class
