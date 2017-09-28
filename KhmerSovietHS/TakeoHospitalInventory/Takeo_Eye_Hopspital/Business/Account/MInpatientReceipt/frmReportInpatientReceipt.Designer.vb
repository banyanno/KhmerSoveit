<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportInpatientReceipt
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
        Me.crvInpatientReceipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvInpatientReceipt
        '
        Me.crvInpatientReceipt.ActiveViewIndex = -1
        Me.crvInpatientReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInpatientReceipt.DisplayGroupTree = False
        Me.crvInpatientReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvInpatientReceipt.Location = New System.Drawing.Point(0, 0)
        Me.crvInpatientReceipt.Name = "crvInpatientReceipt"
        Me.crvInpatientReceipt.SelectionFormula = ""
        Me.crvInpatientReceipt.Size = New System.Drawing.Size(1026, 724)
        Me.crvInpatientReceipt.TabIndex = 0
        Me.crvInpatientReceipt.ViewTimeSelectionFormula = ""
        '
        'frmReportInpatientReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 724)
        Me.Controls.Add(Me.crvInpatientReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportInpatientReceipt"
        Me.ShowInTaskbar = False
        Me.Text = "Report Inpatient Receipt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvInpatientReceipt As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
