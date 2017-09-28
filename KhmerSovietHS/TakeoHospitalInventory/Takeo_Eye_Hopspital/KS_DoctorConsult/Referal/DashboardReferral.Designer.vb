<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardReferral
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
        Dim GridReferral_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardReferral))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewReferral = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUpdateReferral = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDeleteReferral = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFindPatientReferral = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.GridReferral = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridReferral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewReferral, Me.ToolStripSeparator1, Me.btnUpdateReferral, Me.ToolStripSeparator2, Me.btnDeleteReferral, Me.ToolStripSeparator3, Me.BtnFindPatientReferral, Me.ToolStripSeparator4, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.BtnPrintPreview})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1061, 53)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewReferral
        '
        Me.BtnNewReferral.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewReferral.Image = Global.TakeoHospitalInventory.My.Resources.Resources.new_vendor
        Me.BtnNewReferral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewReferral.Name = "BtnNewReferral"
        Me.BtnNewReferral.Size = New System.Drawing.Size(105, 50)
        Me.BtnNewReferral.Text = "New Referral"
        Me.BtnNewReferral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'btnUpdateReferral
        '
        Me.btnUpdateReferral.ForeColor = System.Drawing.Color.Blue
        Me.btnUpdateReferral.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.btnUpdateReferral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdateReferral.Name = "btnUpdateReferral"
        Me.btnUpdateReferral.Size = New System.Drawing.Size(123, 50)
        Me.btnUpdateReferral.Text = "Update Referral"
        Me.btnUpdateReferral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        Me.ToolStripSeparator2.Visible = False
        '
        'btnDeleteReferral
        '
        Me.btnDeleteReferral.ForeColor = System.Drawing.Color.Blue
        Me.btnDeleteReferral.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.btnDeleteReferral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteReferral.Name = "btnDeleteReferral"
        Me.btnDeleteReferral.Size = New System.Drawing.Size(117, 50)
        Me.btnDeleteReferral.Text = "Delete Referral"
        Me.btnDeleteReferral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteReferral.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'BtnFindPatientReferral
        '
        Me.BtnFindPatientReferral.ForeColor = System.Drawing.Color.Blue
        Me.BtnFindPatientReferral.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.BtnFindPatientReferral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFindPatientReferral.Name = "BtnFindPatientReferral"
        Me.BtnFindPatientReferral.Size = New System.Drawing.Size(155, 50)
        Me.BtnFindPatientReferral.Text = "Find Patient Referral"
        Me.BtnFindPatientReferral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton4.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(91, 50)
        Me.ToolStripButton4.Text = "   Refresh   "
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 53)
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintPreview.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.BtnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(114, 50)
        Me.BtnPrintPreview.Text = " Print Preveiw "
        Me.BtnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GridReferral
        '
        Me.GridReferral.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridReferral_DesignTimeLayout.LayoutString = resources.GetString("GridReferral_DesignTimeLayout.LayoutString")
        Me.GridReferral.DesignTimeLayout = GridReferral_DesignTimeLayout
        Me.GridReferral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReferral.GroupByBoxVisible = False
        Me.GridReferral.HeaderFormatStyle.FontSize = 12.0!
        Me.GridReferral.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridReferral.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridReferral.Location = New System.Drawing.Point(0, 53)
        Me.GridReferral.Name = "GridReferral"
        Me.GridReferral.RecordNavigator = True
        Me.GridReferral.RowFormatStyle.FontSize = 12.0!
        Me.GridReferral.Size = New System.Drawing.Size(1061, 491)
        Me.GridReferral.TabIndex = 1
        Me.GridReferral.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'DashboardReferral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridReferral)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardReferral"
        Me.Size = New System.Drawing.Size(1061, 544)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridReferral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewReferral As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUpdateReferral As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDeleteReferral As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridReferral As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFindPatientReferral As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.ToolStripButton

End Class
