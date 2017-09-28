<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageZoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageZoom))
        Me.PictureZoom = New System.Windows.Forms.PictureBox
        CType(Me.PictureZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureZoom
        '
        Me.PictureZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureZoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureZoom.Location = New System.Drawing.Point(0, 0)
        Me.PictureZoom.Name = "PictureZoom"
        Me.PictureZoom.Size = New System.Drawing.Size(865, 609)
        Me.PictureZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureZoom.TabIndex = 0
        Me.PictureZoom.TabStop = False
        '
        'ImageZoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 609)
        Me.Controls.Add(Me.PictureZoom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImageZoom"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zoom Image"
        CType(Me.PictureZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureZoom As System.Windows.Forms.PictureBox
End Class
