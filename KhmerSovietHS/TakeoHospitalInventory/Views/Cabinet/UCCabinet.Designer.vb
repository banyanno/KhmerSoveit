<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCabinet
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
        Dim gridItems_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCabinet))
        Dim gridLocation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.listCabinet = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.gridItems = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnStoreItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUnStoreItem = New System.Windows.Forms.ToolStripButton
        Me.lbItemCount = New System.Windows.Forms.Label
        Me.gridLocation = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbItems = New System.Windows.Forms.ComboBox
        Me.lbLocation = New System.Windows.Forms.Label
        Me.lbCabinet = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbLocaInCabi = New System.Windows.Forms.Label
        Me.MenuStripCate = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuAddCabinet = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuAddLocation = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuEditCabinet = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuEditLocation = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuDeleteLocation = New System.Windows.Forms.ToolStripMenuItem
        Me.menuRefreshData = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStripCate.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.listCabinet)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridItems)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbItemCount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridLocation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbLocaInCabi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuStripCate)
        Me.SplitContainer1.Size = New System.Drawing.Size(889, 641)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 0
        '
        'listCabinet
        '
        Me.listCabinet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listCabinet.FormattingEnabled = True
        Me.listCabinet.Location = New System.Drawing.Point(0, 29)
        Me.listCabinet.Name = "listCabinet"
        Me.listCabinet.Size = New System.Drawing.Size(100, 602)
        Me.listCabinet.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PeachPuff
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cabinets"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gridItems
        '
        Me.gridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItems_DesignTimeLayout.LayoutString = resources.GetString("gridItems_DesignTimeLayout.LayoutString")
        Me.gridItems.DesignTimeLayout = gridItems_DesignTimeLayout
        Me.gridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItems.GroupByBoxVisible = False
        Me.gridItems.Location = New System.Drawing.Point(0, 512)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RecordNavigator = True
        Me.gridItems.Size = New System.Drawing.Size(785, 129)
        Me.gridItems.TabIndex = 14
        Me.gridItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStoreItem, Me.ToolStripSeparator1, Me.btnUnStoreItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 482)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(785, 30)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnStoreItem
        '
        Me.btnStoreItem.AutoSize = False
        Me.btnStoreItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.btnStoreItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStoreItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStoreItem.Name = "btnStoreItem"
        Me.btnStoreItem.Size = New System.Drawing.Size(140, 27)
        Me.btnStoreItem.Text = "Add Items to Location"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'btnUnStoreItem
        '
        Me.btnUnStoreItem.AutoSize = False
        Me.btnUnStoreItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.btnUnStoreItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnStoreItem.Name = "btnUnStoreItem"
        Me.btnUnStoreItem.Size = New System.Drawing.Size(120, 27)
        Me.btnUnStoreItem.Text = "UnStore Item"
        '
        'lbItemCount
        '
        Me.lbItemCount.BackColor = System.Drawing.Color.PeachPuff
        Me.lbItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbItemCount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbItemCount.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItemCount.Location = New System.Drawing.Point(0, 453)
        Me.lbItemCount.Name = "lbItemCount"
        Me.lbItemCount.Size = New System.Drawing.Size(785, 29)
        Me.lbItemCount.TabIndex = 13
        Me.lbItemCount.Text = "Items in Location :"
        Me.lbItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gridLocation
        '
        Me.gridLocation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridLocation_DesignTimeLayout.LayoutString = resources.GetString("gridLocation_DesignTimeLayout.LayoutString")
        Me.gridLocation.DesignTimeLayout = gridLocation_DesignTimeLayout
        Me.gridLocation.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridLocation.GroupByBoxVisible = False
        Me.gridLocation.Location = New System.Drawing.Point(0, 262)
        Me.gridLocation.Name = "gridLocation"
        Me.gridLocation.RecordNavigator = True
        Me.gridLocation.Size = New System.Drawing.Size(785, 191)
        Me.gridLocation.TabIndex = 12
        Me.gridLocation.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbItems)
        Me.GroupBox1.Controls.Add(Me.lbLocation)
        Me.GroupBox1.Controls.Add(Me.lbCabinet)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 199)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Location of Item"
        '
        'cbItems
        '
        Me.cbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItems.FormattingEnabled = True
        Me.cbItems.Location = New System.Drawing.Point(82, 19)
        Me.cbItems.Name = "cbItems"
        Me.cbItems.Size = New System.Drawing.Size(424, 28)
        Me.cbItems.TabIndex = 20
        '
        'lbLocation
        '
        Me.lbLocation.BackColor = System.Drawing.Color.White
        Me.lbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLocation.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLocation.Location = New System.Drawing.Point(172, 114)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(712, 82)
        Me.lbLocation.TabIndex = 16
        '
        'lbCabinet
        '
        Me.lbCabinet.BackColor = System.Drawing.Color.White
        Me.lbCabinet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCabinet.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCabinet.Location = New System.Drawing.Point(0, 114)
        Me.lbCabinet.Name = "lbCabinet"
        Me.lbCabinet.Size = New System.Drawing.Size(175, 82)
        Me.lbCabinet.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(712, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Location"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cabinet"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(884, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Search Result"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearch.Location = New System.Drawing.Point(513, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 34)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Item Name : "
        '
        'lbLocaInCabi
        '
        Me.lbLocaInCabi.BackColor = System.Drawing.Color.PeachPuff
        Me.lbLocaInCabi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLocaInCabi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbLocaInCabi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLocaInCabi.Location = New System.Drawing.Point(0, 34)
        Me.lbLocaInCabi.Name = "lbLocaInCabi"
        Me.lbLocaInCabi.Size = New System.Drawing.Size(785, 29)
        Me.lbLocaInCabi.TabIndex = 11
        Me.lbLocaInCabi.Text = "Locations in Cabinet :"
        Me.lbLocaInCabi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStripCate
        '
        Me.MenuStripCate.AutoSize = False
        Me.MenuStripCate.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.MenuStripCate.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStripCate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.menuRefreshData})
        Me.MenuStripCate.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripCate.Name = "MenuStripCate"
        Me.MenuStripCate.Size = New System.Drawing.Size(785, 34)
        Me.MenuStripCate.TabIndex = 10
        Me.MenuStripCate.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuAddCabinet, Me.subMenuAddLocation})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ToolStripMenuItem1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 30)
        Me.ToolStripMenuItem1.Text = "New"
        '
        'subMenuAddCabinet
        '
        Me.subMenuAddCabinet.Name = "subMenuAddCabinet"
        Me.subMenuAddCabinet.Size = New System.Drawing.Size(138, 22)
        Me.subMenuAddCabinet.Text = "New Cabinet"
        '
        'subMenuAddLocation
        '
        Me.subMenuAddLocation.Name = "subMenuAddLocation"
        Me.subMenuAddLocation.Size = New System.Drawing.Size(138, 22)
        Me.subMenuAddLocation.Text = "New Location"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.AutoSize = False
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuEditCabinet, Me.subMenuEditLocation})
        Me.EditToolStripMenuItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(80, 30)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'subMenuEditCabinet
        '
        Me.subMenuEditCabinet.Name = "subMenuEditCabinet"
        Me.subMenuEditCabinet.Size = New System.Drawing.Size(161, 22)
        Me.subMenuEditCabinet.Text = "Edit Cabinet"
        '
        'subMenuEditLocation
        '
        Me.subMenuEditLocation.Name = "subMenuEditLocation"
        Me.subMenuEditLocation.Size = New System.Drawing.Size(161, 22)
        Me.subMenuEditLocation.Text = "Edit Location Data"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.AutoSize = False
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuDeleteLocation})
        Me.DeleteToolStripMenuItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit_trash
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(80, 30)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'subMenuDeleteLocation
        '
        Me.subMenuDeleteLocation.Name = "subMenuDeleteLocation"
        Me.subMenuDeleteLocation.Size = New System.Drawing.Size(148, 22)
        Me.subMenuDeleteLocation.Text = "Delete Location"
        '
        'menuRefreshData
        '
        Me.menuRefreshData.AutoSize = False
        Me.menuRefreshData.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.menuRefreshData.Name = "menuRefreshData"
        Me.menuRefreshData.Size = New System.Drawing.Size(120, 30)
        Me.menuRefreshData.Text = "Refresh Data"
        '
        'UCCabinet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCCabinet"
        Me.Size = New System.Drawing.Size(889, 641)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStripCate.ResumeLayout(False)
        Me.MenuStripCate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents listCabinet As System.Windows.Forms.ListBox
    Friend WithEvents MenuStripCate As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuAddCabinet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuAddLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuEditCabinet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuDeleteLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRefreshData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbLocaInCabi As System.Windows.Forms.Label
    Friend WithEvents gridLocation As Janus.Windows.GridEX.GridEX
    Friend WithEvents lbItemCount As System.Windows.Forms.Label
    Friend WithEvents gridItems As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents subMenuEditLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnStoreItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUnStoreItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbCabinet As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbLocation As System.Windows.Forms.Label
    Friend WithEvents cbItems As System.Windows.Forms.ComboBox

End Class
