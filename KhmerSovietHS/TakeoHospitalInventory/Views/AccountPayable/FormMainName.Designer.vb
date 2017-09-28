<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainName
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim GridAccountName_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainName))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewName = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.GridAccountName = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridAccountName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewName, Me.ToolStripSeparator1, Me.BtnRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(559, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewName
        '
        Me.BtnNewName.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1323157036_check
        Me.BtnNewName.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewName.Name = "BtnNewName"
        Me.BtnNewName.Size = New System.Drawing.Size(120, 22)
        Me.BtnNewName.Text = "New Account Name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(65, 22)
        Me.BtnRefresh.Text = "Refresh"
        '
        'GridAccountName
        '
        Me.GridAccountName.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAccountName_DesignTimeLayout.LayoutString = resources.GetString("GridAccountName_DesignTimeLayout.LayoutString")
        Me.GridAccountName.DesignTimeLayout = GridAccountName_DesignTimeLayout
        Me.GridAccountName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAccountName.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridAccountName.GroupByBoxVisible = False
        Me.GridAccountName.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridAccountName.Location = New System.Drawing.Point(0, 25)
        Me.GridAccountName.Name = "GridAccountName"
        Me.GridAccountName.RecordNavigator = True
        Me.GridAccountName.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAccountName.Size = New System.Drawing.Size(559, 279)
        Me.GridAccountName.TabIndex = 1
        '
        'FormMainName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 304)
        Me.Controls.Add(Me.GridAccountName)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMainName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Payable Name"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridAccountName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewName As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridAccountName As Janus.Windows.GridEX.GridEX
End Class
