<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportCashReceipt
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
        Me.crvReportCashReceipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReportCashReceipt
        '
        Me.crvReportCashReceipt.ActiveViewIndex = -1
        Me.crvReportCashReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportCashReceipt.DisplayGroupTree = False
        Me.crvReportCashReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportCashReceipt.Location = New System.Drawing.Point(0, 0)
        Me.crvReportCashReceipt.Name = "crvReportCashReceipt"
        Me.crvReportCashReceipt.SelectionFormula = ""
        Me.crvReportCashReceipt.Size = New System.Drawing.Size(1114, 785)
        Me.crvReportCashReceipt.TabIndex = 0
        Me.crvReportCashReceipt.ViewTimeSelectionFormula = ""
        '
        'frmReportCashReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 785)
        Me.Controls.Add(Me.crvReportCashReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportCashReceipt"
        Me.ShowInTaskbar = False
        Me.Text = "Report Cash Receipt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReportCashReceipt As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
