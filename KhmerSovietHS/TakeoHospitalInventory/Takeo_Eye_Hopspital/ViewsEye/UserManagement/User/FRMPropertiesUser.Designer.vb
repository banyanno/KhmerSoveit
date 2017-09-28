<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPropertiesUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMPropertiesUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Ls2 = New System.Windows.Forms.ListView
        Me.GroupName2 = New System.Windows.Forms.ColumnHeader
        Me.GroupNo2 = New System.Windows.Forms.ColumnHeader
        Me.Ls1 = New System.Windows.Forms.ListView
        Me.GroupName1 = New System.Windows.Forms.ColumnHeader
        Me.GroupNo1 = New System.Windows.Forms.ColumnHeader
        Me.btnMove2 = New System.Windows.Forms.Button
        Me.btnMove1 = New System.Windows.Forms.Button
        Me.LblUserId = New System.Windows.Forms.Label
        Me.TxtUserName = New System.Windows.Forms.Label
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
        Me.GroupBox1.Controls.Add(Me.LblUserId)
        Me.GroupBox1.Controls.Add(Me.TxtUserName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 353)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Properties"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Ls2)
        Me.GroupBox2.Controls.Add(Me.Ls1)
        Me.GroupBox2.Controls.Add(Me.btnMove2)
        Me.GroupBox2.Controls.Add(Me.btnMove1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 300)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Group"
        '
        'Ls2
        '
        Me.Ls2.CheckBoxes = True
        Me.Ls2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GroupName2, Me.GroupNo2})
        Me.Ls2.Location = New System.Drawing.Point(202, 20)
        Me.Ls2.Name = "Ls2"
        Me.Ls2.Size = New System.Drawing.Size(154, 274)
        Me.Ls2.TabIndex = 3
        Me.Ls2.UseCompatibleStateImageBehavior = False
        Me.Ls2.View = System.Windows.Forms.View.Details
        '
        'GroupName2
        '
        Me.GroupName2.Text = "Group Name"
        Me.GroupName2.Width = 146
        '
        'GroupNo2
        '
        Me.GroupNo2.Text = "No"
        Me.GroupNo2.Width = 0
        '
        'Ls1
        '
        Me.Ls1.BackgroundImageTiled = True
        Me.Ls1.CheckBoxes = True
        Me.Ls1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GroupName1, Me.GroupNo1})
        Me.Ls1.Location = New System.Drawing.Point(5, 20)
        Me.Ls1.Name = "Ls1"
        Me.Ls1.Size = New System.Drawing.Size(154, 274)
        Me.Ls1.TabIndex = 0
        Me.Ls1.UseCompatibleStateImageBehavior = False
        Me.Ls1.View = System.Windows.Forms.View.Details
        '
        'GroupName1
        '
        Me.GroupName1.Text = "Group Name"
        Me.GroupName1.Width = 143
        '
        'GroupNo1
        '
        Me.GroupNo1.Text = "No"
        Me.GroupNo1.Width = 0
        '
        'btnMove2
        '
        Me.btnMove2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMove2.Location = New System.Drawing.Point(165, 118)
        Me.btnMove2.Name = "btnMove2"
        Me.btnMove2.Size = New System.Drawing.Size(31, 23)
        Me.btnMove2.TabIndex = 2
        Me.btnMove2.Text = "<<"
        Me.btnMove2.UseVisualStyleBackColor = True
        '
        'btnMove1
        '
        Me.btnMove1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMove1.Location = New System.Drawing.Point(165, 79)
        Me.btnMove1.Name = "btnMove1"
        Me.btnMove1.Size = New System.Drawing.Size(31, 23)
        Me.btnMove1.TabIndex = 1
        Me.btnMove1.Text = ">>"
        Me.btnMove1.UseVisualStyleBackColor = True
        '
        'LblUserId
        '
        Me.LblUserId.AutoSize = True
        Me.LblUserId.Location = New System.Drawing.Point(306, 25)
        Me.LblUserId.Name = "LblUserId"
        Me.LblUserId.Size = New System.Drawing.Size(13, 13)
        Me.LblUserId.TabIndex = 3
        Me.LblUserId.Text = "0"
        Me.LblUserId.Visible = False
        '
        'TxtUserName
        '
        Me.TxtUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(127, 16)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(159, 23)
        Me.TxtUserName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login:"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(118, 363)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(67, 28)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(191, 363)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(67, 28)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FRMPropertiesUser
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(378, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMPropertiesUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group User Membership"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtUserName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblUserId As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMove2 As System.Windows.Forms.Button
    Friend WithEvents btnMove1 As System.Windows.Forms.Button
    Friend WithEvents Ls2 As System.Windows.Forms.ListView
    Friend WithEvents Ls1 As System.Windows.Forms.ListView
    Friend WithEvents GroupName1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupNo1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupName2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupNo2 As System.Windows.Forms.ColumnHeader
End Class
