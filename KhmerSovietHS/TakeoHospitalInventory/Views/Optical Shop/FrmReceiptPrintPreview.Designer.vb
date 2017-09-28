<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceiptPrintPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceiptPrintPreview))
        Me.CryPrintPreview = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CryPrintPreview
        '
        Me.CryPrintPreview.ActiveViewIndex = -1
        Me.CryPrintPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryPrintPreview.DisplayGroupTree = False
        Me.CryPrintPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryPrintPreview.Location = New System.Drawing.Point(0, 0)
        Me.CryPrintPreview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CryPrintPreview.Name = "CryPrintPreview"
        Me.CryPrintPreview.SelectionFormula = ""
        Me.CryPrintPreview.ShowGroupTreeButton = False
        Me.CryPrintPreview.ShowRefreshButton = False
        Me.CryPrintPreview.ShowTextSearchButton = False
        Me.CryPrintPreview.Size = New System.Drawing.Size(884, 480)
        Me.CryPrintPreview.TabIndex = 0
        Me.CryPrintPreview.ViewTimeSelectionFormula = ""
        '
        'FrmReceiptPrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 480)
        Me.Controls.Add(Me.CryPrintPreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmReceiptPrintPreview"
        Me.ShowInTaskbar = False
        Me.Text = "Invoice Print Preview"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CryPrintPreview As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
