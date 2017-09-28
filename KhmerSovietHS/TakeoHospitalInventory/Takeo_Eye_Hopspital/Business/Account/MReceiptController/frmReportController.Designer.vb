<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportController
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvReportReceiptController = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReportReceiptController
        '
        Me.crvReportReceiptController.ActiveViewIndex = -1
        Me.crvReportReceiptController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportReceiptController.DisplayGroupTree = False
        Me.crvReportReceiptController.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportReceiptController.Location = New System.Drawing.Point(0, 0)
        Me.crvReportReceiptController.Name = "crvReportReceiptController"
        Me.crvReportReceiptController.SelectionFormula = ""
        Me.crvReportReceiptController.Size = New System.Drawing.Size(922, 744)
        Me.crvReportReceiptController.TabIndex = 0
        Me.crvReportReceiptController.ViewTimeSelectionFormula = ""
        '
        'frmReportController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 744)
        Me.Controls.Add(Me.crvReportReceiptController)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportController"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt Report Flow"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReportReceiptController As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
