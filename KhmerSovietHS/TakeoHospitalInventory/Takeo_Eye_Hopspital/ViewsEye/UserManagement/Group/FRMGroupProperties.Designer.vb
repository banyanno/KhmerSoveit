<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMGroupProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMGroupProperties))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblGroupID = New System.Windows.Forms.Label
        Me.Ch2 = New System.Windows.Forms.CheckedListBox
        Me.btnMove2 = New System.Windows.Forms.Button
        Me.btnMove1 = New System.Windows.Forms.Button
        Me.Ch1 = New System.Windows.Forms.CheckedListBox
        Me.TxtGroupName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtGroupName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(916, 685)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Department Properties"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblGroupID)
        Me.GroupBox2.Controls.Add(Me.Ch2)
        Me.GroupBox2.Controls.Add(Me.btnMove2)
        Me.GroupBox2.Controls.Add(Me.btnMove1)
        Me.GroupBox2.Controls.Add(Me.Ch1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 75)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(892, 598)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permistion"
        '
        'LblGroupID
        '
        Me.LblGroupID.AutoSize = True
        Me.LblGroupID.Location = New System.Drawing.Point(456, 91)
        Me.LblGroupID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGroupID.Name = "LblGroupID"
        Me.LblGroupID.Size = New System.Drawing.Size(18, 20)
        Me.LblGroupID.TabIndex = 3
        Me.LblGroupID.Text = "0"
        Me.LblGroupID.Visible = False
        '
        'Ch2
        '
        Me.Ch2.FormattingEnabled = True
        Me.Ch2.Location = New System.Drawing.Point(513, 31)
        Me.Ch2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ch2.Name = "Ch2"
        Me.Ch2.ScrollAlwaysVisible = True
        Me.Ch2.Size = New System.Drawing.Size(368, 550)
        Me.Ch2.TabIndex = 10
        '
        'btnMove2
        '
        Me.btnMove2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMove2.Location = New System.Drawing.Point(387, 315)
        Me.btnMove2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMove2.Name = "btnMove2"
        Me.btnMove2.Size = New System.Drawing.Size(116, 40)
        Me.btnMove2.TabIndex = 9
        Me.btnMove2.Text = "<<"
        Me.btnMove2.UseVisualStyleBackColor = True
        '
        'btnMove1
        '
        Me.btnMove1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMove1.Location = New System.Drawing.Point(387, 255)
        Me.btnMove1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMove1.Name = "btnMove1"
        Me.btnMove1.Size = New System.Drawing.Size(116, 40)
        Me.btnMove1.TabIndex = 8
        Me.btnMove1.Text = ">>"
        Me.btnMove1.UseVisualStyleBackColor = True
        '
        'Ch1
        '
        Me.Ch1.FormattingEnabled = True
        Me.Ch1.Location = New System.Drawing.Point(8, 29)
        Me.Ch1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ch1.Name = "Ch1"
        Me.Ch1.ScrollAlwaysVisible = True
        Me.Ch1.Size = New System.Drawing.Size(368, 550)
        Me.Ch1.TabIndex = 7
        '
        'TxtGroupName
        '
        Me.TxtGroupName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroupName.Location = New System.Drawing.Point(168, 28)
        Me.TxtGroupName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtGroupName.Name = "TxtGroupName"
        Me.TxtGroupName.Size = New System.Drawing.Size(380, 35)
        Me.TxtGroupName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department Name:"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(364, 700)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(104, 49)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(477, 700)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(104, 49)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FRMGroupProperties
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 755)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRMGroupProperties"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Properties"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblGroupID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtGroupName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Ch2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnMove2 As System.Windows.Forms.Button
    Friend WithEvents btnMove1 As System.Windows.Forms.Button
    Friend WithEvents Ch1 As System.Windows.Forms.CheckedListBox
End Class
