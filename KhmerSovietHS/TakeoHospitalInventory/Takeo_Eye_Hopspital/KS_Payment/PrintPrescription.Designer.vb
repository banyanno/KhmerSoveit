<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintPrescription))
        Me.AxAcroPDFPrescription = New AxAcroPDFLib.AxAcroPDF
        CType(Me.AxAcroPDFPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDFPrescription
        '
        Me.AxAcroPDFPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDFPrescription.Enabled = True
        Me.AxAcroPDFPrescription.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDFPrescription.Name = "AxAcroPDFPrescription"
        Me.AxAcroPDFPrescription.OcxState = CType(resources.GetObject("AxAcroPDFPrescription.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFPrescription.Size = New System.Drawing.Size(852, 592)
        Me.AxAcroPDFPrescription.TabIndex = 2
        '
        'PrintPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 592)
        Me.Controls.Add(Me.AxAcroPDFPrescription)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrintPrescription"
        Me.Text = "Prescription"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxAcroPDFPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxAcroPDFPrescription As AxAcroPDFLib.AxAcroPDF
End Class
