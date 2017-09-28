<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIBarcodeGenerator
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
        Dim GridBarcode_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIBarcodeGenerator))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewBarcode = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintPreviewBarcode = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton
        Me.GridBarcode = New Janus.Windows.GridEX.GridEX
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewBarcode, Me.ToolStripSeparator2, Me.BtnPrintPreviewBarcode, Me.ToolStripSeparator1, Me.BtnRefreshData})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(965, 34)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewBarcode
        '
        Me.BtnNewBarcode.AutoSize = False
        Me.BtnNewBarcode.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Barcode
        Me.BtnNewBarcode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewBarcode.Name = "BtnNewBarcode"
        Me.BtnNewBarcode.Size = New System.Drawing.Size(120, 40)
        Me.BtnNewBarcode.Text = "New Barcode"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'BtnPrintPreviewBarcode
        '
        Me.BtnPrintPreviewBarcode.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnPrintPreviewBarcode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPreviewBarcode.Name = "BtnPrintPreviewBarcode"
        Me.BtnPrintPreviewBarcode.Size = New System.Drawing.Size(148, 31)
        Me.BtnPrintPreviewBarcode.Text = "Print Preview Barcode"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(107, 31)
        Me.BtnRefreshData.Text = "Refresh Data"
        '
        'GridBarcode
        '
        GridBarcode_DesignTimeLayout.LayoutString = resources.GetString("GridBarcode_DesignTimeLayout.LayoutString")
        Me.GridBarcode.DesignTimeLayout = GridBarcode_DesignTimeLayout
        Me.GridBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridBarcode.GroupByBoxVisible = False
        Me.GridBarcode.Location = New System.Drawing.Point(0, 79)
        Me.GridBarcode.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GridBarcode.Name = "GridBarcode"
        Me.GridBarcode.RecordNavigator = True
        Me.GridBarcode.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridBarcode.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBarcode.Size = New System.Drawing.Size(965, 492)
        Me.GridBarcode.TabIndex = 1
        Me.GridBarcode.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'FilterEditor1
        '
        Me.FilterEditor1.AutoApply = True
        Me.FilterEditor1.AutomaticHeightResize = True
        Me.FilterEditor1.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(0, 34)
        Me.FilterEditor1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(16, 45)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(965, 45)
        Me.FilterEditor1.SourceControl = Me.GridBarcode
        '
        'UIBarcodeGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridBarcode)
        Me.Controls.Add(Me.FilterEditor1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "UIBarcodeGenerator"
        Me.Size = New System.Drawing.Size(965, 571)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewBarcode As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridBarcode As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents BtnPrintPreviewBarcode As System.Windows.Forms.ToolStripButton

End Class
