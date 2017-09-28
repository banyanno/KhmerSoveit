<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportCashCountDaily
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
        Me.crvReportCashCountDaily = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReportCashCountDaily
        '
        Me.crvReportCashCountDaily.ActiveViewIndex = -1
        Me.crvReportCashCountDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportCashCountDaily.DisplayGroupTree = False
        Me.crvReportCashCountDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportCashCountDaily.Location = New System.Drawing.Point(0, 0)
        Me.crvReportCashCountDaily.Name = "crvReportCashCountDaily"
        Me.crvReportCashCountDaily.SelectionFormula = ""
        Me.crvReportCashCountDaily.Size = New System.Drawing.Size(1284, 761)
        Me.crvReportCashCountDaily.TabIndex = 0
        Me.crvReportCashCountDaily.ViewTimeSelectionFormula = ""
        '
        'frmReportCashCountDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 761)
        Me.Controls.Add(Me.crvReportCashCountDaily)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportCashCountDaily"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Cash Count Daily"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReportCashCountDaily As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
