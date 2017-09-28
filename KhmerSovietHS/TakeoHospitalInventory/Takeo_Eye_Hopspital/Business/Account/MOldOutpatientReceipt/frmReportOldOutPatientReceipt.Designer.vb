<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportOldOutPatientReceipt
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
        Me.crvReportOldOutPatientReceipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReportOldOutPatientReceipt
        '
        Me.crvReportOldOutPatientReceipt.ActiveViewIndex = -1
        Me.crvReportOldOutPatientReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportOldOutPatientReceipt.DisplayGroupTree = False
        Me.crvReportOldOutPatientReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportOldOutPatientReceipt.Location = New System.Drawing.Point(0, 0)
        Me.crvReportOldOutPatientReceipt.Name = "crvReportOldOutPatientReceipt"
        Me.crvReportOldOutPatientReceipt.SelectionFormula = ""
        Me.crvReportOldOutPatientReceipt.Size = New System.Drawing.Size(1064, 781)
        Me.crvReportOldOutPatientReceipt.TabIndex = 0
        Me.crvReportOldOutPatientReceipt.ViewTimeSelectionFormula = ""
        '
        'frmReportOldOutPatientReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 781)
        Me.Controls.Add(Me.crvReportOldOutPatientReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportOldOutPatientReceipt"
        Me.ShowInTaskbar = False
        Me.Text = "Report Old-Out Patient Receipt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReportOldOutPatientReceipt As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
