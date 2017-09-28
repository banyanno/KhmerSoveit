<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCamera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCamera))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictPatient = New System.Windows.Forms.PictureBox
        Me.BCapture = New System.Windows.Forms.Button
        Me.B_Ok_Or_Cancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictPatient)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 461)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictPatient
        '
        Me.PictPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictPatient.Location = New System.Drawing.Point(3, 16)
        Me.PictPatient.Name = "PictPatient"
        Me.PictPatient.Size = New System.Drawing.Size(522, 442)
        Me.PictPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictPatient.TabIndex = 0
        Me.PictPatient.TabStop = False
        '
        'BCapture
        '
        Me.BCapture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BCapture.BackgroundImage = CType(resources.GetObject("BCapture.BackgroundImage"), System.Drawing.Image)
        Me.BCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCapture.ForeColor = System.Drawing.Color.White
        Me.BCapture.Location = New System.Drawing.Point(6, 474)
        Me.BCapture.Name = "BCapture"
        Me.BCapture.Size = New System.Drawing.Size(119, 34)
        Me.BCapture.TabIndex = 1
        Me.BCapture.Text = "Capture:"
        Me.BCapture.UseVisualStyleBackColor = True
        '
        'B_Ok_Or_Cancel
        '
        Me.B_Ok_Or_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_Ok_Or_Cancel.BackgroundImage = CType(resources.GetObject("B_Ok_Or_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.B_Ok_Or_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_Ok_Or_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B_Ok_Or_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Ok_Or_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Ok_Or_Cancel.ForeColor = System.Drawing.Color.White
        Me.B_Ok_Or_Cancel.Location = New System.Drawing.Point(131, 474)
        Me.B_Ok_Or_Cancel.Name = "B_Ok_Or_Cancel"
        Me.B_Ok_Or_Cancel.Size = New System.Drawing.Size(141, 34)
        Me.B_Ok_Or_Cancel.TabIndex = 2
        Me.B_Ok_Or_Cancel.Text = "Cancel Capture:"
        Me.B_Ok_Or_Cancel.UseVisualStyleBackColor = True
        '
        'FormCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 513)
        Me.Controls.Add(Me.B_Ok_Or_Cancel)
        Me.Controls.Add(Me.BCapture)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCamera"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Camera"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BCapture As System.Windows.Forms.Button
    Friend WithEvents B_Ok_Or_Cancel As System.Windows.Forms.Button
    Friend WithEvents PictPatient As System.Windows.Forms.PictureBox
End Class
