<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRequestOrder
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
        Dim GridRequestDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCRequestOrder))
        Dim GridItemRequestDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TVRequestOrderStatus = New System.Windows.Forms.TreeView
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridRequestDetail = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridItemRequestDetail = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnCompareStock = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMarkOrderChecked = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMarkOrderForward = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMarkOrderApproved = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridRequestDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridItemRequestDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TVRequestOrderStatus)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1593, 944)
        Me.SplitContainer1.SplitterDistance = 162
        Me.SplitContainer1.SplitterWidth = 7
        Me.SplitContainer1.TabIndex = 0
        '
        'TVRequestOrderStatus
        '
        Me.TVRequestOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVRequestOrderStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVRequestOrderStatus.Location = New System.Drawing.Point(0, 0)
        Me.TVRequestOrderStatus.Margin = New System.Windows.Forms.Padding(5)
        Me.TVRequestOrderStatus.Name = "TVRequestOrderStatus"
        Me.TVRequestOrderStatus.Size = New System.Drawing.Size(162, 944)
        Me.TVRequestOrderStatus.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridRequestDetail)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1424, 944)
        Me.SplitContainer2.SplitterDistance = 201
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 0
        '
        'GridRequestDetail
        '
        Me.GridRequestDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridRequestDetail_DesignTimeLayout.LayoutString = resources.GetString("GridRequestDetail_DesignTimeLayout.LayoutString")
        Me.GridRequestDetail.DesignTimeLayout = GridRequestDetail_DesignTimeLayout
        Me.GridRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRequestDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GridRequestDetail.GroupByBoxVisible = False
        Me.GridRequestDetail.Location = New System.Drawing.Point(0, 31)
        Me.GridRequestDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridRequestDetail.Name = "GridRequestDetail"
        Me.GridRequestDetail.RecordNavigator = True
        Me.GridRequestDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridRequestDetail.Size = New System.Drawing.Size(1424, 170)
        Me.GridRequestDetail.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1424, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request information detail"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridItemRequestDetail)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1424, 738)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Item Detaile"
        '
        'GridItemRequestDetail
        '
        Me.GridItemRequestDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridItemRequestDetail.ContextMenuStrip = Me.ContextMenuStrip1
        GridItemRequestDetail_DesignTimeLayout.LayoutString = resources.GetString("GridItemRequestDetail_DesignTimeLayout.LayoutString")
        Me.GridItemRequestDetail.DesignTimeLayout = GridItemRequestDetail_DesignTimeLayout
        Me.GridItemRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemRequestDetail.GroupByBoxVisible = False
        Me.GridItemRequestDetail.Location = New System.Drawing.Point(3, 23)
        Me.GridItemRequestDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridItemRequestDetail.Name = "GridItemRequestDetail"
        Me.GridItemRequestDetail.RecordNavigator = True
        Me.GridItemRequestDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItemRequestDetail.Size = New System.Drawing.Size(1418, 711)
        Me.GridItemRequestDetail.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCompareStock, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 32)
        '
        'btnCompareStock
        '
        Me.btnCompareStock.Name = "btnCompareStock"
        Me.btnCompareStock.Size = New System.Drawing.Size(140, 22)
        Me.btnCompareStock.Text = "InStock..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 6)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator3, Me.btnMarkOrderChecked, Me.ToolStripSeparator4, Me.btnMarkOrderForward, Me.ToolStripSeparator5, Me.btnMarkOrderApproved, Me.ToolStripSeparator6, Me.BtnRefresh})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1593, 31)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.CheckOnClick = True
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(136, 28)
        Me.BtnRefresh.Text = "Refresh Data"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'BtnNew
        '
        Me.BtnNew.CheckOnClick = True
        Me.BtnNew.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(76, 28)
        Me.BtnNew.Text = "New "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btnEdit
        '
        Me.btnEdit.CheckOnClick = True
        Me.btnEdit.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(67, 28)
        Me.btnEdit.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'btnDelete
        '
        Me.btnDelete.CheckOnClick = True
        Me.btnDelete.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit_trash
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 28)
        Me.btnDelete.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'btnMarkOrderChecked
        '
        Me.btnMarkOrderChecked.CheckOnClick = True
        Me.btnMarkOrderChecked.Image = Global.TakeoHospitalInventory.My.Resources.Resources.check_red
        Me.btnMarkOrderChecked.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarkOrderChecked.Name = "btnMarkOrderChecked"
        Me.btnMarkOrderChecked.Size = New System.Drawing.Size(100, 28)
        Me.btnMarkOrderChecked.Text = "Checked"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'btnMarkOrderForward
        '
        Me.btnMarkOrderForward.CheckOnClick = True
        Me.btnMarkOrderForward.Image = Global.TakeoHospitalInventory.My.Resources.Resources.RightLeft2Red
        Me.btnMarkOrderForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarkOrderForward.Name = "btnMarkOrderForward"
        Me.btnMarkOrderForward.Size = New System.Drawing.Size(99, 28)
        Me.btnMarkOrderForward.Text = "Forward"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'btnMarkOrderApproved
        '
        Me.btnMarkOrderApproved.CheckOnClick = True
        Me.btnMarkOrderApproved.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Aproved
        Me.btnMarkOrderApproved.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarkOrderApproved.Name = "btnMarkOrderApproved"
        Me.btnMarkOrderApproved.Size = New System.Drawing.Size(108, 28)
        Me.btnMarkOrderApproved.Text = "Approved"
        '
        'UCRequestOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "UCRequestOrder"
        Me.Size = New System.Drawing.Size(1593, 975)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridRequestDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridItemRequestDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TVRequestOrderStatus As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridRequestDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridItemRequestDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMarkOrderChecked As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMarkOrderForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMarkOrderApproved As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnCompareStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator

End Class
