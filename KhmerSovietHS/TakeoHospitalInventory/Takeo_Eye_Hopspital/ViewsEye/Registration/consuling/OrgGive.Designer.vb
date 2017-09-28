<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrgGive
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
        Me.components = New System.ComponentModel.Container
        Dim GridOffer_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrgGive))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TxtOffer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridOffer = New Janus.Windows.GridEX.GridEX
        Me.MenuOffer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeleteOffer = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewOffer = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrOffer = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuOffer.SuspendLayout()
        CType(Me.ErrOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.TxtOffer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Location = New System.Drawing.Point(479, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(76, 25)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(7, 14)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(395, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 26)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtOffer
        '
        Me.TxtOffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOffer.Location = New System.Drawing.Point(55, 20)
        Me.TxtOffer.Name = "TxtOffer"
        Me.TxtOffer.Size = New System.Drawing.Size(334, 26)
        Me.TxtOffer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Offer:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridOffer)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 231)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List offer"
        '
        'GridOffer
        '
        Me.GridOffer.ContextMenuStrip = Me.MenuOffer
        GridOffer_DesignTimeLayout.LayoutString = resources.GetString("GridOffer_DesignTimeLayout.LayoutString")
        Me.GridOffer.DesignTimeLayout = GridOffer_DesignTimeLayout
        Me.GridOffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOffer.GroupByBoxVisible = False
        Me.GridOffer.HeaderFormatStyle.FontSize = 12.0!
        Me.GridOffer.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridOffer.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridOffer.Location = New System.Drawing.Point(3, 16)
        Me.GridOffer.Name = "GridOffer"
        Me.GridOffer.RecordNavigator = True
        Me.GridOffer.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridOffer.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridOffer.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.White
        Me.GridOffer.Size = New System.Drawing.Size(556, 212)
        Me.GridOffer.TabIndex = 0
        '
        'MenuOffer
        '
        Me.MenuOffer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeleteOffer, Me.ToolStripSeparator1, Me.BtnNewOffer})
        Me.MenuOffer.Name = "MenuOffer"
        Me.MenuOffer.Size = New System.Drawing.Size(135, 54)
        '
        'BtnDeleteOffer
        '
        Me.BtnDeleteOffer.Name = "BtnDeleteOffer"
        Me.BtnDeleteOffer.Size = New System.Drawing.Size(134, 22)
        Me.BtnDeleteOffer.Text = "Delete Offer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'BtnNewOffer
        '
        Me.BtnNewOffer.Name = "BtnNewOffer"
        Me.BtnNewOffer.Size = New System.Drawing.Size(134, 22)
        Me.BtnNewOffer.Text = "New Offer"
        '
        'ErrOffer
        '
        Me.ErrOffer.ContainerControl = Me
        '
        'OrgGive
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrgGive"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Org Offer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridOffer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuOffer.ResumeLayout(False)
        CType(Me.ErrOffer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtOffer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridOffer As Janus.Windows.GridEX.GridEX
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrOffer As System.Windows.Forms.ErrorProvider
    Friend WithEvents MenuOffer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteOffer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewOffer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
