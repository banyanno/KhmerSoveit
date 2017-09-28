<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportReceiptIP
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
        Me.crvReportReceiptIP = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReportReceiptIP
        '
        Me.crvReportReceiptIP.ActiveViewIndex = -1
        Me.crvReportReceiptIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportReceiptIP.DisplayGroupTree = False
        Me.crvReportReceiptIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportReceiptIP.Location = New System.Drawing.Point(0, 0)
        Me.crvReportReceiptIP.Name = "crvReportReceiptIP"
        Me.crvReportReceiptIP.SelectionFormula = ""
        Me.crvReportReceiptIP.Size = New System.Drawing.Size(1031, 813)
        Me.crvReportReceiptIP.TabIndex = 0
        Me.crvReportReceiptIP.ViewTimeSelectionFormula = ""
        '
        'frmReportReceiptIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 813)
        Me.Controls.Add(Me.crvReportReceiptIP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportReceiptIP"
        Me.ShowInTaskbar = False
        Me.Text = "Report Receipt IP"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReportReceiptIP As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
