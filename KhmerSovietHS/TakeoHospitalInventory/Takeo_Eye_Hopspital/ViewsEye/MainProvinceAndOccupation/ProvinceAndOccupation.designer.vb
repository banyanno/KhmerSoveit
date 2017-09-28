<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCProvinceAndOccupation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCProvinceAndOccupation))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridOccupation = New System.Windows.Forms.DataGridView
        Me.OccuNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Occupation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuOccupation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteOccupation = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnNewOccupation = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnLoadOccupation = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridDistrict = New System.Windows.Forms.DataGridView
        Me.ContextMenuCommune = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridCommune = New System.Windows.Forms.DataGridView
        Me.GridProvince = New System.Windows.Forms.DataGridView
        Me.ProNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Province = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuProvince = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewDistrict = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.BtnProvince = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GridOrgRefer = New System.Windows.Forms.DataGridView
        Me.ReferNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Refer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewReferTo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnLoadData = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DistrictNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProvinceNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.District = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDProvCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrokCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KhumCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Commune = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridOccupation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuOccupation.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuCommune.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridCommune, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuProvince.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.GridOrgRefer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridOccupation)
        Me.GroupBox1.Controls.Add(Me.ToolStrip2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(899, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(331, 1198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Occupation Patient"
        '
        'GridOccupation
        '
        Me.GridOccupation.AllowUserToAddRows = False
        Me.GridOccupation.AllowUserToDeleteRows = False
        Me.GridOccupation.BackgroundColor = System.Drawing.Color.White
        Me.GridOccupation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridOccupation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOccupation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OccuNo, Me.Occupation})
        Me.GridOccupation.ContextMenuStrip = Me.ContextMenuOccupation
        Me.GridOccupation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOccupation.Location = New System.Drawing.Point(4, 44)
        Me.GridOccupation.Margin = New System.Windows.Forms.Padding(4)
        Me.GridOccupation.Name = "GridOccupation"
        Me.GridOccupation.ReadOnly = True
        Me.GridOccupation.RowHeadersWidth = 60
        Me.GridOccupation.RowTemplate.Height = 24
        Me.GridOccupation.Size = New System.Drawing.Size(323, 1150)
        Me.GridOccupation.TabIndex = 0
        '
        'OccuNo
        '
        Me.OccuNo.DataPropertyName = "OccNo"
        Me.OccuNo.HeaderText = "OccuNo"
        Me.OccuNo.Name = "OccuNo"
        Me.OccuNo.ReadOnly = True
        Me.OccuNo.Visible = False
        '
        'Occupation
        '
        Me.Occupation.DataPropertyName = "Occupation"
        Me.Occupation.HeaderText = "Occupation"
        Me.Occupation.Name = "Occupation"
        Me.Occupation.ReadOnly = True
        Me.Occupation.Width = 250
        '
        'ContextMenuOccupation
        '
        Me.ContextMenuOccupation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteOccupation})
        Me.ContextMenuOccupation.Name = "ContextMenuOccupation"
        Me.ContextMenuOccupation.Size = New System.Drawing.Size(118, 26)
        '
        'DeleteOccupation
        '
        Me.DeleteOccupation.Name = "DeleteOccupation"
        Me.DeleteOccupation.Size = New System.Drawing.Size(117, 22)
        Me.DeleteOccupation.Text = "Delete"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewOccupation, Me.ToolStripSeparator4, Me.BtnLoadOccupation, Me.ToolStripSeparator5})
        Me.ToolStrip2.Location = New System.Drawing.Point(4, 19)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(323, 25)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnNewOccupation
        '
        Me.BtnNewOccupation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewOccupation.Image = CType(resources.GetObject("BtnNewOccupation.Image"), System.Drawing.Image)
        Me.BtnNewOccupation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewOccupation.Name = "BtnNewOccupation"
        Me.BtnNewOccupation.Size = New System.Drawing.Size(117, 22)
        Me.BtnNewOccupation.Text = "New Occupation"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BtnLoadOccupation
        '
        Me.BtnLoadOccupation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnLoadOccupation.ForeColor = System.Drawing.Color.Blue
        Me.BtnLoadOccupation.Image = CType(resources.GetObject("BtnLoadOccupation.Image"), System.Drawing.Image)
        Me.BtnLoadOccupation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLoadOccupation.Name = "BtnLoadOccupation"
        Me.BtnLoadOccupation.Size = New System.Drawing.Size(79, 22)
        Me.BtnLoadOccupation.Text = "Load Data"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GridProvince)
        Me.GroupBox2.Controls.Add(Me.ToolStrip3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(899, 1198)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Of Provinces"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridDistrict)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(304, 44)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(262, 1150)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Districts"
        '
        'GridDistrict
        '
        Me.GridDistrict.AllowUserToAddRows = False
        Me.GridDistrict.AllowUserToDeleteRows = False
        Me.GridDistrict.BackgroundColor = System.Drawing.Color.White
        Me.GridDistrict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDistrict.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DistrictNo, Me.ProvinceNo, Me.District})
        Me.GridDistrict.ContextMenuStrip = Me.ContextMenuCommune
        Me.GridDistrict.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDistrict.Location = New System.Drawing.Point(4, 19)
        Me.GridDistrict.Margin = New System.Windows.Forms.Padding(4)
        Me.GridDistrict.Name = "GridDistrict"
        Me.GridDistrict.ReadOnly = True
        Me.GridDistrict.RowHeadersWidth = 60
        Me.GridDistrict.RowTemplate.Height = 24
        Me.GridDistrict.Size = New System.Drawing.Size(254, 1127)
        Me.GridDistrict.TabIndex = 4
        '
        'ContextMenuCommune
        '
        Me.ContextMenuCommune.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.ToolStripMenuItem2})
        Me.ContextMenuCommune.Name = "ContextMenuProvince"
        Me.ContextMenuCommune.Size = New System.Drawing.Size(225, 54)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.ToolStripMenuItem1.Text = "Delete District"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(221, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 22)
        Me.ToolStripMenuItem2.Text = "Create &New Commune"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridCommune)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox4.Location = New System.Drawing.Point(570, 44)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(325, 1150)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Communes"
        '
        'GridCommune
        '
        Me.GridCommune.AllowUserToAddRows = False
        Me.GridCommune.AllowUserToDeleteRows = False
        Me.GridCommune.BackgroundColor = System.Drawing.Color.White
        Me.GridCommune.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridCommune.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCommune.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProvCode, Me.SrokCode, Me.KhumCode, Me.Commune})
        Me.GridCommune.ContextMenuStrip = Me.ContextMenuCommune
        Me.GridCommune.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCommune.Location = New System.Drawing.Point(4, 19)
        Me.GridCommune.Margin = New System.Windows.Forms.Padding(4)
        Me.GridCommune.Name = "GridCommune"
        Me.GridCommune.ReadOnly = True
        Me.GridCommune.RowHeadersWidth = 60
        Me.GridCommune.RowTemplate.Height = 24
        Me.GridCommune.Size = New System.Drawing.Size(317, 1127)
        Me.GridCommune.TabIndex = 5
        '
        'GridProvince
        '
        Me.GridProvince.AllowUserToAddRows = False
        Me.GridProvince.AllowUserToDeleteRows = False
        Me.GridProvince.BackgroundColor = System.Drawing.Color.White
        Me.GridProvince.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProvince.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProNo, Me.Province})
        Me.GridProvince.ContextMenuStrip = Me.ContextMenuProvince
        Me.GridProvince.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridProvince.Location = New System.Drawing.Point(4, 44)
        Me.GridProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.GridProvince.Name = "GridProvince"
        Me.GridProvince.ReadOnly = True
        Me.GridProvince.RowHeadersWidth = 60
        Me.GridProvince.RowTemplate.Height = 24
        Me.GridProvince.Size = New System.Drawing.Size(300, 1150)
        Me.GridProvince.TabIndex = 0
        '
        'ProNo
        '
        Me.ProNo.DataPropertyName = "IDProvCode"
        Me.ProNo.HeaderText = "ProvinceNo"
        Me.ProNo.Name = "ProNo"
        Me.ProNo.ReadOnly = True
        '
        'Province
        '
        Me.Province.DataPropertyName = "Province"
        Me.Province.HeaderText = "Provinces"
        Me.Province.Name = "Province"
        Me.Province.ReadOnly = True
        Me.Province.Width = 250
        '
        'ContextMenuProvince
        '
        Me.ContextMenuProvince.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDistrict})
        Me.ContextMenuProvince.Name = "ContextMenuProvince"
        Me.ContextMenuProvince.Size = New System.Drawing.Size(201, 26)
        '
        'NewDistrict
        '
        Me.NewDistrict.Name = "NewDistrict"
        Me.NewDistrict.Size = New System.Drawing.Size(200, 22)
        Me.NewDistrict.Text = "Create &New District"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnProvince, Me.ToolStripSeparator6})
        Me.ToolStrip3.Location = New System.Drawing.Point(4, 19)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(891, 25)
        Me.ToolStrip3.TabIndex = 4
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'BtnProvince
        '
        Me.BtnProvince.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnProvince.Image = CType(resources.GetObject("BtnProvince.Image"), System.Drawing.Image)
        Me.BtnProvince.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnProvince.Name = "BtnProvince"
        Me.BtnProvince.Size = New System.Drawing.Size(79, 22)
        Me.BtnProvince.Text = "Load Data"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GridOrgRefer)
        Me.GroupBox7.Controls.Add(Me.ToolStrip1)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox7.Location = New System.Drawing.Point(1230, 0)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(447, 1198)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "List Organization For Patient Refer To"
        '
        'GridOrgRefer
        '
        Me.GridOrgRefer.AllowUserToAddRows = False
        Me.GridOrgRefer.AllowUserToDeleteRows = False
        Me.GridOrgRefer.BackgroundColor = System.Drawing.Color.White
        Me.GridOrgRefer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridOrgRefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOrgRefer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReferNo, Me.Refer, Me.ReferNote})
        Me.GridOrgRefer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrgRefer.Location = New System.Drawing.Point(4, 44)
        Me.GridOrgRefer.Margin = New System.Windows.Forms.Padding(4)
        Me.GridOrgRefer.Name = "GridOrgRefer"
        Me.GridOrgRefer.ReadOnly = True
        Me.GridOrgRefer.RowHeadersWidth = 60
        Me.GridOrgRefer.RowTemplate.Height = 24
        Me.GridOrgRefer.Size = New System.Drawing.Size(439, 1150)
        Me.GridOrgRefer.TabIndex = 0
        '
        'ReferNo
        '
        Me.ReferNo.DataPropertyName = "ReferNo"
        Me.ReferNo.HeaderText = "ReferNo"
        Me.ReferNo.Name = "ReferNo"
        Me.ReferNo.ReadOnly = True
        Me.ReferNo.Visible = False
        '
        'Refer
        '
        Me.Refer.DataPropertyName = "Refer"
        Me.Refer.HeaderText = "Refer"
        Me.Refer.Name = "Refer"
        Me.Refer.ReadOnly = True
        Me.Refer.Width = 250
        '
        'ReferNote
        '
        Me.ReferNote.DataPropertyName = "ReferNote"
        Me.ReferNote.HeaderText = "ReferNote"
        Me.ReferNote.Name = "ReferNote"
        Me.ReferNote.ReadOnly = True
        Me.ReferNote.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewReferTo, Me.ToolStripSeparator1, Me.BtnLoadData, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 19)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(439, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewReferTo
        '
        Me.BtnNewReferTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewReferTo.Image = CType(resources.GetObject("BtnNewReferTo.Image"), System.Drawing.Image)
        Me.BtnNewReferTo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewReferTo.Name = "BtnNewReferTo"
        Me.BtnNewReferTo.Size = New System.Drawing.Size(103, 22)
        Me.BtnNewReferTo.Text = "New Refer To"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnLoadData
        '
        Me.BtnLoadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnLoadData.ForeColor = System.Drawing.Color.Blue
        Me.BtnLoadData.Image = CType(resources.GetObject("BtnLoadData.Image"), System.Drawing.Image)
        Me.BtnLoadData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLoadData.Name = "BtnLoadData"
        Me.BtnLoadData.Size = New System.Drawing.Size(79, 22)
        Me.BtnLoadData.Text = "Load Data"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(500, 290)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1720, 1198)
        Me.Panel1.TabIndex = 5
        '
        'DistrictNo
        '
        Me.DistrictNo.DataPropertyName = "SrokCode"
        Me.DistrictNo.HeaderText = "D Code"
        Me.DistrictNo.Name = "DistrictNo"
        Me.DistrictNo.ReadOnly = True
        '
        'ProvinceNo
        '
        Me.ProvinceNo.DataPropertyName = "IDProvCode"
        Me.ProvinceNo.HeaderText = "ProvinceNo"
        Me.ProvinceNo.Name = "ProvinceNo"
        Me.ProvinceNo.ReadOnly = True
        Me.ProvinceNo.Visible = False
        '
        'District
        '
        Me.District.DataPropertyName = "District"
        Me.District.HeaderText = "District"
        Me.District.Name = "District"
        Me.District.ReadOnly = True
        Me.District.Width = 250
        '
        'IDProvCode
        '
        Me.IDProvCode.DataPropertyName = "IDProvCode"
        Me.IDProvCode.HeaderText = "IDProvCode"
        Me.IDProvCode.Name = "IDProvCode"
        Me.IDProvCode.ReadOnly = True
        Me.IDProvCode.Visible = False
        '
        'SrokCode
        '
        Me.SrokCode.DataPropertyName = "SrokCode"
        Me.SrokCode.HeaderText = "DistrictNo1"
        Me.SrokCode.Name = "SrokCode"
        Me.SrokCode.ReadOnly = True
        Me.SrokCode.Visible = False
        '
        'KhumCode
        '
        Me.KhumCode.DataPropertyName = "KhumCode"
        Me.KhumCode.HeaderText = "C Code"
        Me.KhumCode.Name = "KhumCode"
        Me.KhumCode.ReadOnly = True
        '
        'Commune
        '
        Me.Commune.DataPropertyName = "Commune"
        Me.Commune.HeaderText = "Commune"
        Me.Commune.Name = "Commune"
        Me.Commune.ReadOnly = True
        Me.Commune.Width = 250
        '
        'UCProvinceAndOccupation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCProvinceAndOccupation"
        Me.Size = New System.Drawing.Size(1720, 1198)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridOccupation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuOccupation.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuCommune.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridCommune, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridProvince, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuProvince.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.GridOrgRefer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridOccupation As System.Windows.Forms.DataGridView
    Friend WithEvents GridProvince As System.Windows.Forms.DataGridView
    Friend WithEvents GridDistrict As System.Windows.Forms.DataGridView
    Friend WithEvents GridCommune As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuOccupation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteOccupation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuProvince As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewDistrict As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuCommune As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OccuNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Occupation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GridOrgRefer As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewReferTo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnLoadData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewOccupation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnLoadOccupation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnProvince As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReferNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Refer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Province As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistrictNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinceNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents District As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDProvCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrokCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KhumCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Commune As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
