<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCVendor_V1
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
        Dim gridItems_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCVendor_V1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.listDonator = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.listVendor = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LbDID = New System.Windows.Forms.Label
        Me.LbVID = New System.Windows.Forms.Label
        Me.gridItems = New Janus.Windows.GridEX.GridEX
        Me.Label9 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUnStoreItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewVendor = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnNewDonator = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditDonator = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ErrorVendor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorVendor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.listDonator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.listVendor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LbDID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LbVID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridItems)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(902, 462)
        Me.SplitContainer1.SplitterDistance = 178
        Me.SplitContainer1.TabIndex = 0
        '
        'listDonator
        '
        Me.listDonator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listDonator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.listDonator.FormattingEnabled = True
        Me.listDonator.ItemHeight = 15
        Me.listDonator.Location = New System.Drawing.Point(0, 335)
        Me.listDonator.Name = "listDonator"
        Me.listDonator.Size = New System.Drawing.Size(178, 124)
        Me.listDonator.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Donators"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'listVendor
        '
        Me.listVendor.Dock = System.Windows.Forms.DockStyle.Top
        Me.listVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.listVendor.FormattingEnabled = True
        Me.listVendor.Location = New System.Drawing.Point(0, 29)
        Me.listVendor.Name = "listVendor"
        Me.listVendor.Size = New System.Drawing.Size(178, 277)
        Me.listVendor.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PeachPuff
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Vendors"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbDID
        '
        Me.LbDID.AutoSize = True
        Me.LbDID.Location = New System.Drawing.Point(509, 43)
        Me.LbDID.Name = "LbDID"
        Me.LbDID.Size = New System.Drawing.Size(26, 13)
        Me.LbDID.TabIndex = 19
        Me.LbDID.Text = "DID"
        Me.LbDID.Visible = False
        '
        'LbVID
        '
        Me.LbVID.AutoSize = True
        Me.LbVID.Location = New System.Drawing.Point(478, 43)
        Me.LbVID.Name = "LbVID"
        Me.LbVID.Size = New System.Drawing.Size(25, 13)
        Me.LbVID.TabIndex = 18
        Me.LbVID.Text = "VID"
        Me.LbVID.Visible = False
        '
        'gridItems
        '
        Me.gridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItems_DesignTimeLayout.LayoutString = resources.GetString("gridItems_DesignTimeLayout.LayoutString")
        Me.gridItems.DesignTimeLayout = gridItems_DesignTimeLayout
        Me.gridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItems.GroupByBoxVisible = False
        Me.gridItems.Location = New System.Drawing.Point(0, 63)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RecordNavigator = True
        Me.gridItems.Size = New System.Drawing.Size(720, 399)
        Me.gridItems.TabIndex = 17
        Me.gridItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.PeachPuff
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(720, 29)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Detail Items Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.btnUnStoreItem})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 374)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(768, 30)
        Me.ToolStrip2.TabIndex = 16
        Me.ToolStrip2.Text = "ToolStrip2"
        Me.ToolStrip2.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'btnUnStoreItem
        '
        Me.btnUnStoreItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.btnUnStoreItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnStoreItem.Name = "btnUnStoreItem"
        Me.btnUnStoreItem.Size = New System.Drawing.Size(153, 27)
        Me.btnUnStoreItem.Text = "Not Supply Checked Items"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewVendor, Me.ToolStripSeparator1, Me.btnNewDonator, Me.ToolStripSeparator3, Me.btnEdit, Me.ToolStripSeparator6, Me.btnDelete, Me.ToolStripSeparator5, Me.BtnEditDonator, Me.ToolStripSeparator2, Me.BtnRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(720, 34)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewVendor
        '
        Me.BtnNewVendor.AutoSize = False
        Me.BtnNewVendor.Image = Global.TakeoHospitalInventory.My.Resources.Resources.new_vendor
        Me.BtnNewVendor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewVendor.Name = "BtnNewVendor"
        Me.BtnNewVendor.Size = New System.Drawing.Size(120, 31)
        Me.BtnNewVendor.Text = "New Vendor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'btnNewDonator
        '
        Me.btnNewDonator.AutoSize = False
        Me.btnNewDonator.Image = Global.TakeoHospitalInventory.My.Resources.Resources.new_vendor
        Me.btnNewDonator.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewDonator.Name = "btnNewDonator"
        Me.btnNewDonator.Size = New System.Drawing.Size(120, 31)
        Me.btnNewDonator.Text = "New Donator"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = False
        Me.btnEdit.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 31)
        Me.btnEdit.Text = "Edit Vendor"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 34)
        Me.ToolStripSeparator6.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = False
        Me.btnDelete.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit_trash
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 31)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 34)
        '
        'BtnEditDonator
        '
        Me.BtnEditDonator.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.BtnEditDonator.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditDonator.Name = "BtnEditDonator"
        Me.BtnEditDonator.Size = New System.Drawing.Size(103, 31)
        Me.BtnEditDonator.Text = "Edit Donator"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AutoSize = False
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(120, 31)
        Me.BtnRefresh.Text = "Refresh Data"
        '
        'ErrorVendor
        '
        Me.ErrorVendor.ContainerControl = Me
        '
        'UCVendor_V1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCVendor_V1"
        Me.Size = New System.Drawing.Size(902, 462)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorVendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents listDonator As System.Windows.Forms.ListBox
    Friend WithEvents listVendor As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewVendor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUnStoreItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridItems As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnNewDonator As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorVendor As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditDonator As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LbDID As System.Windows.Forms.Label
    Friend WithEvents LbVID As System.Windows.Forms.Label

End Class
