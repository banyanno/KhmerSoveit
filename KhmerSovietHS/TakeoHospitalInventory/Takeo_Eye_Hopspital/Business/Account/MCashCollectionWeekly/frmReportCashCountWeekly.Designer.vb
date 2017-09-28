<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportCashCountWeekly
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
        Me.crvReportCashCountWeekly = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReportCashCountWeekly
        '
        Me.crvReportCashCountWeekly.ActiveViewIndex = -1
        Me.crvReportCashCountWeekly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportCashCountWeekly.DisplayGroupTree = False
        Me.crvReportCashCountWeekly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportCashCountWeekly.Location = New System.Drawing.Point(0, 0)
        Me.crvReportCashCountWeekly.Name = "crvReportCashCountWeekly"
        Me.crvReportCashCountWeekly.SelectionFormula = ""
        Me.crvReportCashCountWeekly.Size = New System.Drawing.Size(980, 746)
        Me.crvReportCashCountWeekly.TabIndex = 0
        Me.crvReportCashCountWeekly.ViewTimeSelectionFormula = ""
        '
        'frmReportCashCountWeekly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 746)
        Me.Controls.Add(Me.crvReportCashCountWeekly)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportCashCountWeekly"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Cash Count"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReportCashCountWeekly As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
