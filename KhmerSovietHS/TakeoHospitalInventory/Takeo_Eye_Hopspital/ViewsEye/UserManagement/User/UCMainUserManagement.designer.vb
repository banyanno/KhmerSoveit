<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMainUserManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMainUserManagement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LsGroup = New System.Windows.Forms.ListView
        Me.ContexMenuGroup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.PropertiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.LsUser = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ContexMenuUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStripGroup = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewGroup = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteGroup = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPropertyGroup = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripUser = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnChangePassword = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPropertyUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewAllUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox1.SuspendLayout()
        Me.ContexMenuGroup.SuspendLayout()
        Me.ContexMenuUser.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripGroup.SuspendLayout()
        Me.ToolStripUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LsGroup)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 702)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Groups"
        '
        'LsGroup
        '
        Me.LsGroup.BackgroundImageTiled = True
        Me.LsGroup.ContextMenuStrip = Me.ContexMenuGroup
        Me.LsGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsGroup.LargeImageList = Me.ImgList
        Me.LsGroup.Location = New System.Drawing.Point(3, 16)
        Me.LsGroup.Name = "LsGroup"
        Me.LsGroup.Size = New System.Drawing.Size(425, 683)
        Me.LsGroup.TabIndex = 0
        Me.LsGroup.UseCompatibleStateImageBehavior = False
        '
        'ContexMenuGroup
        '
        Me.ContexMenuGroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGroupToolStripMenuItem, Me.ToolStripMenuItem4, Me.DeleteGroupToolStripMenuItem, Me.ToolStripMenuItem6, Me.PropertiesToolStripMenuItem1})
        Me.ContexMenuGroup.Name = "ContexMenuGroup"
        Me.ContexMenuGroup.Size = New System.Drawing.Size(140, 82)
        '
        'NewGroupToolStripMenuItem
        '
        Me.NewGroupToolStripMenuItem.Name = "NewGroupToolStripMenuItem"
        Me.NewGroupToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.NewGroupToolStripMenuItem.Text = "New Group..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(136, 6)
        '
        'DeleteGroupToolStripMenuItem
        '
        Me.DeleteGroupToolStripMenuItem.Name = "DeleteGroupToolStripMenuItem"
        Me.DeleteGroupToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DeleteGroupToolStripMenuItem.Text = "Delete Group"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(136, 6)
        '
        'PropertiesToolStripMenuItem1
        '
        Me.PropertiesToolStripMenuItem1.Name = "PropertiesToolStripMenuItem1"
        Me.PropertiesToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PropertiesToolStripMenuItem1.Text = "Properties..."
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "1268629527_user-group-new.ico")
        Me.ImgList.Images.SetKeyName(1, "1268629550_contact-new.ico")
        '
        'LsUser
        '
        Me.LsUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LsUser.ContextMenuStrip = Me.ContexMenuUser
        Me.LsUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsUser.LargeImageList = Me.ImgList
        Me.LsUser.Location = New System.Drawing.Point(3, 16)
        Me.LsUser.Name = "LsUser"
        Me.LsUser.Size = New System.Drawing.Size(493, 683)
        Me.LsUser.TabIndex = 0
        Me.LsUser.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NO"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Login Name"
        Me.ColumnHeader3.Width = 108
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Password"
        Me.ColumnHeader4.Width = 84
        '
        'ContexMenuUser
        '
        Me.ContexMenuUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.ToolStripMenuItem2, Me.ChangePasswordToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteUserToolStripMenuItem, Me.ToolStripMenuItem3, Me.PropertiesToolStripMenuItem})
        Me.ContexMenuUser.Name = "ContexMenuUser"
        Me.ContexMenuUser.Size = New System.Drawing.Size(173, 110)
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.NewUserToolStripMenuItem.Text = "New User..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(169, 6)
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(169, 6)
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(169, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LsUser)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 702)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Users"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripGroup)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripUser)
        Me.SplitContainer1.Size = New System.Drawing.Size(934, 727)
        Me.SplitContainer1.SplitterDistance = 431
        Me.SplitContainer1.TabIndex = 1
        '
        'ToolStripGroup
        '
        Me.ToolStripGroup.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripGroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BtnNewGroup, Me.ToolStripSeparator2, Me.BtnDeleteGroup, Me.ToolStripSeparator3, Me.BtnPropertyGroup, Me.ToolStripSeparator4})
        Me.ToolStripGroup.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGroup.Name = "ToolStripGroup"
        Me.ToolStripGroup.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripGroup.Size = New System.Drawing.Size(431, 25)
        Me.ToolStripGroup.TabIndex = 1
        Me.ToolStripGroup.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnNewGroup
        '
        Me.BtnNewGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewGroup.Image = CType(resources.GetObject("BtnNewGroup.Image"), System.Drawing.Image)
        Me.BtnNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewGroup.Name = "BtnNewGroup"
        Me.BtnNewGroup.Size = New System.Drawing.Size(76, 22)
        Me.BtnNewGroup.Text = "New Group..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnDeleteGroup
        '
        Me.BtnDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnDeleteGroup.Image = CType(resources.GetObject("BtnDeleteGroup.Image"), System.Drawing.Image)
        Me.BtnDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteGroup.Name = "BtnDeleteGroup"
        Me.BtnDeleteGroup.Size = New System.Drawing.Size(74, 22)
        Me.BtnDeleteGroup.Text = "Delete Group"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BtnPropertyGroup
        '
        Me.BtnPropertyGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnPropertyGroup.Image = CType(resources.GetObject("BtnPropertyGroup.Image"), System.Drawing.Image)
        Me.BtnPropertyGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPropertyGroup.Name = "BtnPropertyGroup"
        Me.BtnPropertyGroup.Size = New System.Drawing.Size(72, 22)
        Me.BtnPropertyGroup.Text = "Properties..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripUser
        '
        Me.ToolStripUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.BtnNewUser, Me.ToolStripSeparator6, Me.BtnChangePassword, Me.ToolStripSeparator7, Me.BtnDeleteUser, Me.ToolStripSeparator8, Me.BtnPropertyUser, Me.ToolStripSeparator10, Me.BtnViewAllUser, Me.ToolStripSeparator9})
        Me.ToolStripUser.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripUser.Name = "ToolStripUser"
        Me.ToolStripUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripUser.Size = New System.Drawing.Size(499, 25)
        Me.ToolStripUser.TabIndex = 2
        Me.ToolStripUser.Text = "ToolStrip2"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BtnNewUser
        '
        Me.BtnNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewUser.Image = CType(resources.GetObject("BtnNewUser.Image"), System.Drawing.Image)
        Me.BtnNewUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(69, 22)
        Me.BtnNewUser.Text = "New User..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnChangePassword.Image = CType(resources.GetObject("BtnChangePassword.Image"), System.Drawing.Image)
        Me.BtnChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.Size = New System.Drawing.Size(109, 22)
        Me.BtnChangePassword.Text = "Change Password..."
        Me.BtnChangePassword.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator7.Visible = False
        '
        'BtnDeleteUser
        '
        Me.BtnDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnDeleteUser.Image = CType(resources.GetObject("BtnDeleteUser.Image"), System.Drawing.Image)
        Me.BtnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteUser.Name = "BtnDeleteUser"
        Me.BtnDeleteUser.Size = New System.Drawing.Size(67, 22)
        Me.BtnDeleteUser.Text = "Delete User"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'BtnPropertyUser
        '
        Me.BtnPropertyUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnPropertyUser.Image = CType(resources.GetObject("BtnPropertyUser.Image"), System.Drawing.Image)
        Me.BtnPropertyUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPropertyUser.Name = "BtnPropertyUser"
        Me.BtnPropertyUser.Size = New System.Drawing.Size(72, 22)
        Me.BtnPropertyUser.Text = "Properties..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'BtnViewAllUser
        '
        Me.BtnViewAllUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnViewAllUser.Image = CType(resources.GetObject("BtnViewAllUser.Image"), System.Drawing.Image)
        Me.BtnViewAllUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewAllUser.Name = "BtnViewAllUser"
        Me.BtnViewAllUser.Size = New System.Drawing.Size(75, 22)
        Me.BtnViewAllUser.Text = "View all users"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'UCMainUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCMainUserManagement"
        Me.Size = New System.Drawing.Size(934, 727)
        Me.GroupBox1.ResumeLayout(False)
        Me.ContexMenuGroup.ResumeLayout(False)
        Me.ContexMenuUser.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripGroup.ResumeLayout(False)
        Me.ToolStripGroup.PerformLayout()
        Me.ToolStripUser.ResumeLayout(False)
        Me.ToolStripUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LsUser As System.Windows.Forms.ListView
    Friend WithEvents LsGroup As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents ContexMenuUser As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContexMenuGroup As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripGroup As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPropertyGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripUser As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnChangePassword As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPropertyUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewAllUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator

End Class
