<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDepartment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDepartment))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.LsDepartment = New System.Windows.Forms.ListView
        Me.ContextDepartment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuGrantToDepart = New System.Windows.Forms.ToolStripMenuItem
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LsPermistion = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMenuEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewAllPermission = New System.Windows.Forms.ToolStripButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LsUser = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ToolStripUser = New System.Windows.Forms.ToolStrip
        Me.BtnNewUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnChangePassword = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewAllUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPermission = New System.Windows.Forms.ToolStripButton
        Me.BgLoadingDepartment = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ContextDepartment.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStripUser.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(952, 408)
        Me.SplitContainer1.SplitterDistance = 404
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.LsDepartment)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(404, 408)
        Me.SplitContainer2.SplitterDistance = 199
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 2
        '
        'LsDepartment
        '
        Me.LsDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LsDepartment.BackgroundImageTiled = True
        Me.LsDepartment.ContextMenuStrip = Me.ContextDepartment
        Me.LsDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsDepartment.ForeColor = System.Drawing.Color.Red
        Me.LsDepartment.HideSelection = False
        Me.LsDepartment.LargeImageList = Me.ImgList
        Me.LsDepartment.Location = New System.Drawing.Point(0, 0)
        Me.LsDepartment.MultiSelect = False
        Me.LsDepartment.Name = "LsDepartment"
        Me.LsDepartment.Size = New System.Drawing.Size(404, 199)
        Me.LsDepartment.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LsDepartment.TabIndex = 1
        Me.LsDepartment.UseCompatibleStateImageBehavior = False
        '
        'ContextDepartment
        '
        Me.ContextDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGrantToDepart})
        Me.ContextDepartment.Name = "ContextMenuStrip1"
        Me.ContextDepartment.Size = New System.Drawing.Size(142, 26)
        '
        'MenuGrantToDepart
        '
        Me.MenuGrantToDepart.Name = "MenuGrantToDepart"
        Me.MenuGrantToDepart.Size = New System.Drawing.Size(141, 22)
        Me.MenuGrantToDepart.Text = "Permission..."
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "1318172659_Home.png")
        Me.ImgList.Images.SetKeyName(1, "kmenuedit.png")
        Me.ImgList.Images.SetKeyName(2, "user3.png")
        Me.ImgList.Images.SetKeyName(3, "user_info.png")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LsPermistion)
        Me.GroupBox3.Controls.Add(Me.ToolStrip2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox3.Size = New System.Drawing.Size(404, 206)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Permission of Departement"
        '
        'LsPermistion
        '
        Me.LsPermistion.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LsPermistion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LsPermistion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsPermistion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsPermistion.ForeColor = System.Drawing.Color.Red
        Me.LsPermistion.HideSelection = False
        Me.LsPermistion.LargeImageList = Me.ImgList
        Me.LsPermistion.Location = New System.Drawing.Point(2, 45)
        Me.LsPermistion.MultiSelect = False
        Me.LsPermistion.Name = "LsPermistion"
        Me.LsPermistion.Size = New System.Drawing.Size(400, 160)
        Me.LsPermistion.TabIndex = 5
        Me.LsPermistion.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NO"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 85
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Login Name"
        Me.ColumnHeader7.Width = 108
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Password"
        Me.ColumnHeader8.Width = 84
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator11, Me.BtnMenuEdit, Me.ToolStripSeparator8, Me.BtnViewAllPermission})
        Me.ToolStrip2.Location = New System.Drawing.Point(2, 14)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(400, 31)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackgroundImage = CType(resources.GetObject("ToolStripButton1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(120, 28)
        Me.ToolStripButton1.Text = "New Permission"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 31)
        '
        'BtnMenuEdit
        '
        Me.BtnMenuEdit.BackgroundImage = CType(resources.GetObject("BtnMenuEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnMenuEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMenuEdit.ForeColor = System.Drawing.Color.White
        Me.BtnMenuEdit.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.BtnMenuEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMenuEdit.Name = "BtnMenuEdit"
        Me.BtnMenuEdit.Size = New System.Drawing.Size(73, 28)
        Me.BtnMenuEdit.Text = "   Edit   "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'BtnViewAllPermission
        '
        Me.BtnViewAllPermission.BackgroundImage = CType(resources.GetObject("BtnViewAllPermission.BackgroundImage"), System.Drawing.Image)
        Me.BtnViewAllPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnViewAllPermission.ForeColor = System.Drawing.Color.White
        Me.BtnViewAllPermission.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnViewAllPermission.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewAllPermission.Name = "BtnViewAllPermission"
        Me.BtnViewAllPermission.Size = New System.Drawing.Size(101, 28)
        Me.BtnViewAllPermission.Text = "Refresh Data"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LsUser)
        Me.GroupBox4.Controls.Add(Me.ToolStripUser)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox4.Size = New System.Drawing.Size(545, 408)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Users in department"
        '
        'LsUser
        '
        Me.LsUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LsUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LsUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsUser.ForeColor = System.Drawing.Color.Red
        Me.LsUser.HideSelection = False
        Me.LsUser.LargeImageList = Me.ImgList
        Me.LsUser.Location = New System.Drawing.Point(2, 45)
        Me.LsUser.MultiSelect = False
        Me.LsUser.Name = "LsUser"
        Me.LsUser.Size = New System.Drawing.Size(541, 362)
        Me.LsUser.TabIndex = 1
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
        'ToolStripUser
        '
        Me.ToolStripUser.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripUser.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStripUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewUser, Me.ToolStripSeparator6, Me.BtnEditUser, Me.ToolStripSeparator12, Me.BtnChangePassword, Me.ToolStripSeparator7, Me.BtnViewAllUser, Me.ToolStripSeparator4, Me.BtnDeleteUser})
        Me.ToolStripUser.Location = New System.Drawing.Point(2, 14)
        Me.ToolStripUser.Name = "ToolStripUser"
        Me.ToolStripUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripUser.Size = New System.Drawing.Size(541, 31)
        Me.ToolStripUser.TabIndex = 3
        Me.ToolStripUser.Text = "ToolStrip2"
        '
        'BtnNewUser
        '
        Me.BtnNewUser.BackgroundImage = CType(resources.GetObject("BtnNewUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewUser.ForeColor = System.Drawing.Color.White
        Me.BtnNewUser.Image = Global.TakeoHospitalInventory.My.Resources.Resources.new_vendor
        Me.BtnNewUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(85, 28)
        Me.BtnNewUser.Text = "New User"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'BtnEditUser
        '
        Me.BtnEditUser.BackgroundImage = CType(resources.GetObject("BtnEditUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditUser.ForeColor = System.Drawing.Color.White
        Me.BtnEditUser.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.BtnEditUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditUser.Name = "BtnEditUser"
        Me.BtnEditUser.Size = New System.Drawing.Size(73, 28)
        Me.BtnEditUser.Text = "   Edit   "
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 31)
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.BackgroundImage = CType(resources.GetObject("BtnChangePassword.BackgroundImage"), System.Drawing.Image)
        Me.BtnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnChangePassword.ForeColor = System.Drawing.Color.White
        Me.BtnChangePassword.Image = Global.TakeoHospitalInventory.My.Resources.Resources.RightLeft2Red
        Me.BtnChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.Size = New System.Drawing.Size(138, 28)
        Me.BtnChangePassword.Text = "Change Password..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'BtnViewAllUser
        '
        Me.BtnViewAllUser.BackgroundImage = CType(resources.GetObject("BtnViewAllUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnViewAllUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnViewAllUser.ForeColor = System.Drawing.Color.White
        Me.BtnViewAllUser.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnViewAllUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewAllUser.Name = "BtnViewAllUser"
        Me.BtnViewAllUser.Size = New System.Drawing.Size(101, 28)
        Me.BtnViewAllUser.Text = "Refresh Data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'BtnDeleteUser
        '
        Me.BtnDeleteUser.BackgroundImage = CType(resources.GetObject("BtnDeleteUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteUser.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteUser.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Remove
        Me.BtnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteUser.Name = "BtnDeleteUser"
        Me.BtnDeleteUser.Size = New System.Drawing.Size(94, 28)
        Me.BtnDeleteUser.Text = "Delete User"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.BtnRefresh, Me.ToolStripSeparator3, Me.BtnPermission})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(952, 34)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.AutoSize = False
        Me.BtnNew.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(80, 31)
        Me.BtnNew.Text = "New "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = False
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 31)
        Me.btnEdit.Text = "   Edit   "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AutoSize = False
        Me.BtnRefresh.BackgroundImage = CType(resources.GetObject("BtnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(120, 30)
        Me.BtnRefresh.Text = "Refresh Data"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'BtnPermission
        '
        Me.BtnPermission.BackgroundImage = CType(resources.GetObject("BtnPermission.BackgroundImage"), System.Drawing.Image)
        Me.BtnPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPermission.ForeColor = System.Drawing.Color.White
        Me.BtnPermission.Image = Global.TakeoHospitalInventory.My.Resources.Resources.process
        Me.BtnPermission.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPermission.Name = "BtnPermission"
        Me.BtnPermission.Size = New System.Drawing.Size(134, 31)
        Me.BtnPermission.Text = "Permission Of Dep-"
        '
        'BgLoadingDepartment
        '
        '
        'UCDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCDepartment"
        Me.Size = New System.Drawing.Size(952, 442)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ContextDepartment.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStripUser.ResumeLayout(False)
        Me.ToolStripUser.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents BgLoadingDepartment As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents LsDepartment As System.Windows.Forms.ListView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LsUser As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents BtnNewUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnChangePassword As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewAllUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewAllPermission As System.Windows.Forms.ToolStripButton
    Friend WithEvents LsPermistion As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextDepartment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuGrantToDepart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripUser As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPermission As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnMenuEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteUser As System.Windows.Forms.ToolStripButton

End Class
