<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompareItemInStock
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
        Dim gridCompareItemInStock_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompareItemInStock))
        Me.gridCompareItemInStock = New Janus.Windows.GridEX.GridEX
        CType(Me.gridCompareItemInStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridCompareItemInStock
        '
        Me.gridCompareItemInStock.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridCompareItemInStock.CardCaptionFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.gridCompareItemInStock.CardCaptionFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.gridCompareItemInStock.CardSpacing = 5
        Me.gridCompareItemInStock.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both
        Me.gridCompareItemInStock.CardWidth = 396
        Me.gridCompareItemInStock.ColumnAutoResize = True
        gridCompareItemInStock_DesignTimeLayout.LayoutString = resources.GetString("gridCompareItemInStock_DesignTimeLayout.LayoutString")
        Me.gridCompareItemInStock.DesignTimeLayout = gridCompareItemInStock_DesignTimeLayout
        Me.gridCompareItemInStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCompareItemInStock.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridCompareItemInStock.GroupByBoxVisible = False
        Me.gridCompareItemInStock.Location = New System.Drawing.Point(0, 0)
        Me.gridCompareItemInStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gridCompareItemInStock.Name = "gridCompareItemInStock"
        Me.gridCompareItemInStock.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridCompareItemInStock.Size = New System.Drawing.Size(410, 313)
        Me.gridCompareItemInStock.TabIndex = 2
        Me.gridCompareItemInStock.View = Janus.Windows.GridEX.View.CardView
        '
        'frmCompareItemInStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(410, 313)
        Me.Controls.Add(Me.gridCompareItemInStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompareItemInStock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Quantity InStock"
        CType(Me.gridCompareItemInStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridCompareItemInStock As Janus.Windows.GridEX.GridEX
End Class
