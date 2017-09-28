<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainCategory))
        Dim GridIncomeCategory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnIncomeType = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.GridIncomeCategory = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridIncomeCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnIncomeType, Me.ToolStripSeparator1, Me.BtnEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(957, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnIncomeType
        '
        Me.BtnIncomeType.Image = CType(resources.GetObject("BtnIncomeType.Image"), System.Drawing.Image)
        Me.BtnIncomeType.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIncomeType.Name = "BtnIncomeType"
        Me.BtnIncomeType.Size = New System.Drawing.Size(175, 22)
        Me.BtnIncomeType.Text = "New Income Category"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnEdit
        '
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(51, 22)
        Me.BtnEdit.Text = "Edit"
        '
        'GridIncomeCategory
        '
        GridIncomeCategory_DesignTimeLayout.LayoutString = resources.GetString("GridIncomeCategory_DesignTimeLayout.LayoutString")
        Me.GridIncomeCategory.DesignTimeLayout = GridIncomeCategory_DesignTimeLayout
        Me.GridIncomeCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridIncomeCategory.GroupByBoxVisible = False
        Me.GridIncomeCategory.Location = New System.Drawing.Point(0, 25)
        Me.GridIncomeCategory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridIncomeCategory.Name = "GridIncomeCategory"
        Me.GridIncomeCategory.RecordNavigator = True
        Me.GridIncomeCategory.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridIncomeCategory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridIncomeCategory.Size = New System.Drawing.Size(957, 503)
        Me.GridIncomeCategory.TabIndex = 1
        Me.GridIncomeCategory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'FormMainCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 528)
        Me.Controls.Add(Me.GridIncomeCategory)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMainCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income Category"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridIncomeCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnIncomeType As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridIncomeCategory As Janus.Windows.GridEX.GridEX
End Class
