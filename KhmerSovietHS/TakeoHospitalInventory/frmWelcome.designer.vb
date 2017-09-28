<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.pbarLoad = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'pbarLoad
        '
        Me.pbarLoad.BackColor = System.Drawing.Color.Khaki
        Me.pbarLoad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbarLoad.ForeColor = System.Drawing.Color.Gold
        Me.pbarLoad.Location = New System.Drawing.Point(0, 211)
        Me.pbarLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.pbarLoad.Name = "pbarLoad"
        Me.pbarLoad.Size = New System.Drawing.Size(491, 18)
        Me.pbarLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbarLoad.TabIndex = 1
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.optomap_moss_optical_minneapolis_eye_exams3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbarLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWelcome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbarLoad As System.Windows.Forms.ProgressBar

End Class
