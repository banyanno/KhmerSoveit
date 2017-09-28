<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCaseLab
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
        Dim GridLaboratory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCaseLab))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.GridLaboratory = New Janus.Windows.GridEX.GridEX
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.BtnUpdate = New System.Windows.Forms.ToolStripButton
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.bntRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridLaboratory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.BtnUpdate, Me.ToolStripSeparator2, Me.BtnDelete, Me.ToolStripSeparator3, Me.bntRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(954, 32)
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
        'GridLaboratory
        '
        Me.GridLaboratory.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridLaboratory_DesignTimeLayout.LayoutString = resources.GetString("GridLaboratory_DesignTimeLayout.LayoutString")
        Me.GridLaboratory.DesignTimeLayout = GridLaboratory_DesignTimeLayout
        Me.GridLaboratory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLaboratory.GroupByBoxVisible = False
        Me.GridLaboratory.HeaderFormatStyle.FontSize = 12.0!
        Me.GridLaboratory.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridLaboratory.Location = New System.Drawing.Point(0, 32)
        Me.GridLaboratory.Name = "GridLaboratory"
        Me.GridLaboratory.RecordNavigator = True
        Me.GridLaboratory.Size = New System.Drawing.Size(954, 593)
        Me.GridLaboratory.TabIndex = 1
        '
        'BtnNew
        '
        Me.BtnNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNew.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1436959918_lab
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(100, 29)
        Me.BtnNew.Text = "New Lab"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUpdate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit1
        Me.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(118, 29)
        Me.BtnUpdate.Text = "Update Lab"
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDelete.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(112, 29)
        Me.BtnDelete.Text = "Delete Lab"
        '
        'bntRefresh
        '
        Me.bntRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bntRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bntRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.bntRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntRefresh.Name = "bntRefresh"
        Me.bntRefresh.Size = New System.Drawing.Size(121, 29)
        Me.bntRefresh.Text = "Refresh Lab"
        '
        'UCaseLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridLaboratory)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCaseLab"
        Me.Size = New System.Drawing.Size(954, 625)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridLaboratory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bntRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridLaboratory As Janus.Windows.GridEX.GridEX

End Class
