<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Me.ReportviewerForm = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DSPatientForm = New TakeoHospitalInventory.DSPatientForm
        Me.TblPatientReferalTableAdapter = New TakeoHospitalInventory.DSPatientFormTableAdapters.TblPatientReferalTableAdapter
        CType(Me.DSPatientForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportviewerForm
        '
        Me.ReportviewerForm.ActiveViewIndex = -1
        Me.ReportviewerForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportviewerForm.DisplayGroupTree = False
        Me.ReportviewerForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportviewerForm.Location = New System.Drawing.Point(0, 0)
        Me.ReportviewerForm.Name = "ReportviewerForm"
        Me.ReportviewerForm.SelectionFormula = ""
        Me.ReportviewerForm.Size = New System.Drawing.Size(981, 694)
        Me.ReportviewerForm.TabIndex = 0
        Me.ReportviewerForm.ViewTimeSelectionFormula = ""
        '
        'DSPatientForm
        '
        Me.DSPatientForm.DataSetName = "DSPatientForm"
        Me.DSPatientForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientReferalTableAdapter
        '
        Me.TblPatientReferalTableAdapter.ClearBeforeFill = True
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 694)
        Me.Controls.Add(Me.ReportviewerForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportForm"
        Me.ShowInTaskbar = False
        Me.Text = "ReportForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSPatientForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportviewerForm As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DSPatientForm As TakeoHospitalInventory.DSPatientForm
    Friend WithEvents TblPatientReferalTableAdapter As TakeoHospitalInventory.DSPatientFormTableAdapters.TblPatientReferalTableAdapter
End Class
