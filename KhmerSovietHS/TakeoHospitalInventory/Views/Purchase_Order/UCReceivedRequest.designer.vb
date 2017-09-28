<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCReceivedRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCReceivedRequest))
        Dim GridItemRequestDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridRequestHis_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadApproved = New System.Windows.Forms.RadioButton
        Me.RadRequest = New System.Windows.Forms.RadioButton
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.TVRequestOrderStatus = New System.Windows.Forms.TreeView
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GridRequestDetail = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridItemRequestDetail = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.menuInStock = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.menuEditQtyApprovedItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.menuAddApprovedItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRemoveItem = New System.Windows.Forms.ToolStripButton
        Me.gridRequestHis = New Janus.Windows.GridEX.GridEX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CBAllDepart = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CbDepartment = New System.Windows.Forms.ComboBox
        Me.btnGridDisplay = New System.Windows.Forms.Button
        Me.dptToDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnInStock = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnApproved = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAddApprovedItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.btnAproItems = New System.Windows.Forms.ToolStripButton
        Me.btnMarkOrderForward = New System.Windows.Forms.ToolStripButton
        Me.btnMarkOrderApproved = New System.Windows.Forms.ToolStripButton
        Me.btnEdit = New System.Windows.Forms.ToolStripButton
        Me.BtnPrintRequest = New System.Windows.Forms.ToolStripButton
        Me.ErrorPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.GridRequestDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridItemRequestDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.gridRequestHis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TVRequestOrderStatus)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1277, 519)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.SplitterWidth = 9
        Me.SplitContainer1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.RadApproved)
        Me.GroupBox1.Controls.Add(Me.RadRequest)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 383)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(270, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request History"
        '
        'RadApproved
        '
        Me.RadApproved.AutoSize = True
        Me.RadApproved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadApproved.Location = New System.Drawing.Point(23, 79)
        Me.RadApproved.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadApproved.Name = "RadApproved"
        Me.RadApproved.Size = New System.Drawing.Size(88, 22)
        Me.RadApproved.TabIndex = 3
        Me.RadApproved.TabStop = True
        Me.RadApproved.Text = "Approved"
        Me.RadApproved.UseVisualStyleBackColor = True
        '
        'RadRequest
        '
        Me.RadRequest.AutoSize = True
        Me.RadRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadRequest.Location = New System.Drawing.Point(23, 48)
        Me.RadRequest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadRequest.Name = "RadRequest"
        Me.RadRequest.Size = New System.Drawing.Size(145, 22)
        Me.RadRequest.TabIndex = 0
        Me.RadRequest.TabStop = True
        Me.RadRequest.Text = "Incoming Request"
        Me.RadRequest.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 379)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(270, 4)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'TVRequestOrderStatus
        '
        Me.TVRequestOrderStatus.BackColor = System.Drawing.SystemColors.Window
        Me.TVRequestOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVRequestOrderStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.TVRequestOrderStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVRequestOrderStatus.HideSelection = False
        Me.TVRequestOrderStatus.Location = New System.Drawing.Point(0, 0)
        Me.TVRequestOrderStatus.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TVRequestOrderStatus.Name = "TVRequestOrderStatus"
        Me.TVRequestOrderStatus.Size = New System.Drawing.Size(270, 379)
        Me.TVRequestOrderStatus.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.gridRequestHis)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(998, 519)
        Me.SplitContainer2.SplitterDistance = 308
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GridRequestDetail)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer3.Size = New System.Drawing.Size(998, 308)
        Me.SplitContainer3.SplitterDistance = 92
        Me.SplitContainer3.SplitterWidth = 5
        Me.SplitContainer3.TabIndex = 0
        '
        'GridRequestDetail
        '
        Me.GridRequestDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridRequestDetail_DesignTimeLayout.LayoutString = resources.GetString("GridRequestDetail_DesignTimeLayout.LayoutString")
        Me.GridRequestDetail.DesignTimeLayout = GridRequestDetail_DesignTimeLayout
        Me.GridRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRequestDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridRequestDetail.GroupByBoxVisible = False
        Me.GridRequestDetail.Location = New System.Drawing.Point(0, 33)
        Me.GridRequestDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridRequestDetail.Name = "GridRequestDetail"
        Me.GridRequestDetail.RecordNavigator = True
        Me.GridRequestDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridRequestDetail.Size = New System.Drawing.Size(998, 59)
        Me.GridRequestDetail.TabIndex = 0
        Me.GridRequestDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(998, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request information detail"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridItemRequestDetail)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 31)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(998, 180)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Item Detail"
        '
        'GridItemRequestDetail
        '
        Me.GridItemRequestDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridItemRequestDetail_DesignTimeLayout.LayoutString = resources.GetString("GridItemRequestDetail_DesignTimeLayout.LayoutString")
        Me.GridItemRequestDetail.DesignTimeLayout = GridItemRequestDetail_DesignTimeLayout
        Me.GridItemRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemRequestDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridItemRequestDetail.GroupByBoxVisible = False
        Me.GridItemRequestDetail.HeaderFormatStyle.FontSize = 10.0!
        Me.GridItemRequestDetail.Location = New System.Drawing.Point(4, 20)
        Me.GridItemRequestDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridItemRequestDetail.Name = "GridItemRequestDetail"
        Me.GridItemRequestDetail.RecordNavigator = True
        Me.GridItemRequestDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridItemRequestDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItemRequestDetail.Size = New System.Drawing.Size(990, 155)
        Me.GridItemRequestDetail.TabIndex = 1
        Me.GridItemRequestDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInStock, Me.ToolStripSeparator2, Me.menuEditQtyApprovedItem, Me.ToolStripSeparator3, Me.menuAddApprovedItem, Me.ToolStripSeparator5, Me.BtnRemoveItem})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(998, 31)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'menuInStock
        '
        Me.menuInStock.Image = Global.TakeoHospitalInventory.My.Resources.Resources.instock
        Me.menuInStock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuInStock.Name = "menuInStock"
        Me.menuInStock.Size = New System.Drawing.Size(168, 28)
        Me.menuInStock.Text = "Check Current Stock"
        Me.menuInStock.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        Me.ToolStripSeparator2.Visible = False
        '
        'menuEditQtyApprovedItem
        '
        Me.menuEditQtyApprovedItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.app_48
        Me.menuEditQtyApprovedItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuEditQtyApprovedItem.Name = "menuEditQtyApprovedItem"
        Me.menuEditQtyApprovedItem.Size = New System.Drawing.Size(155, 28)
        Me.menuEditQtyApprovedItem.Text = "Response Amount"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'menuAddApprovedItem
        '
        Me.menuAddApprovedItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.add_to_list
        Me.menuAddApprovedItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuAddApprovedItem.Name = "menuAddApprovedItem"
        Me.menuAddApprovedItem.Size = New System.Drawing.Size(171, 28)
        Me.menuAddApprovedItem.Text = "Add  Response Item"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.BtnRemoveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(195, 28)
        Me.BtnRemoveItem.Text = "Remove Response Item"
        '
        'gridRequestHis
        '
        Me.gridRequestHis.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridRequestHis_DesignTimeLayout.LayoutString = resources.GetString("gridRequestHis_DesignTimeLayout.LayoutString")
        Me.gridRequestHis.DesignTimeLayout = gridRequestHis_DesignTimeLayout
        Me.gridRequestHis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRequestHis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridRequestHis.GroupByBoxVisible = False
        Me.gridRequestHis.Hierarchical = True
        Me.gridRequestHis.Location = New System.Drawing.Point(0, 130)
        Me.gridRequestHis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridRequestHis.Name = "gridRequestHis"
        Me.gridRequestHis.RecordNavigator = True
        Me.gridRequestHis.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridRequestHis.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridRequestHis.Size = New System.Drawing.Size(998, 75)
        Me.gridRequestHis.TabIndex = 5
        Me.gridRequestHis.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.CBAllDepart)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.CbDepartment)
        Me.GroupBox3.Controls.Add(Me.btnGridDisplay)
        Me.GroupBox3.Controls.Add(Me.dptToDate)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnPreview)
        Me.GroupBox3.Controls.Add(Me.dptFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(998, 130)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'CBAllDepart
        '
        Me.CBAllDepart.AutoSize = True
        Me.CBAllDepart.Checked = True
        Me.CBAllDepart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBAllDepart.Location = New System.Drawing.Point(469, 86)
        Me.CBAllDepart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBAllDepart.Name = "CBAllDepart"
        Me.CBAllDepart.Size = New System.Drawing.Size(177, 21)
        Me.CBAllDepart.TabIndex = 20
        Me.CBAllDepart.Text = "Display All Departments"
        Me.CBAllDepart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Department:"
        '
        'CbDepartment
        '
        Me.CbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDepartment.FormattingEnabled = True
        Me.CbDepartment.Location = New System.Drawing.Point(104, 78)
        Me.CbDepartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CbDepartment.Name = "CbDepartment"
        Me.CbDepartment.Size = New System.Drawing.Size(263, 33)
        Me.CbDepartment.TabIndex = 18
        '
        'btnGridDisplay
        '
        Me.btnGridDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGridDisplay.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.btnGridDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGridDisplay.Location = New System.Drawing.Point(697, 74)
        Me.btnGridDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGridDisplay.Name = "btnGridDisplay"
        Me.btnGridDisplay.Size = New System.Drawing.Size(124, 39)
        Me.btnGridDisplay.TabIndex = 17
        Me.btnGridDisplay.Text = "Display"
        Me.btnGridDisplay.UseVisualStyleBackColor = True
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(444, 20)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(200, 30)
        Me.dptToDate.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(375, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "To Date:"
        '
        'btnPreview
        '
        Me.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreview.Image = Global.TakeoHospitalInventory.My.Resources.Resources.preview
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(829, 73)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(124, 39)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(96, 21)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(271, 30)
        Me.dptFromDate.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "From Date:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInStock, Me.ToolStripMenuItem1, Me.btnApproved, Me.ToolStripSeparator1, Me.btnAddApprovedItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(206, 82)
        '
        'btnInStock
        '
        Me.btnInStock.Name = "btnInStock"
        Me.btnInStock.Size = New System.Drawing.Size(205, 22)
        Me.btnInStock.Text = "InStock"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 6)
        '
        'btnApproved
        '
        Me.btnApproved.Name = "btnApproved"
        Me.btnApproved.Size = New System.Drawing.Size(205, 22)
        Me.btnApproved.Text = "Edit Approved Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'btnAddApprovedItem
        '
        Me.btnAddApprovedItem.Name = "btnAddApprovedItem"
        Me.btnAddApprovedItem.Size = New System.Drawing.Size(205, 22)
        Me.btnAddApprovedItem.Text = "Add Approved Item"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        Me.ToolStripSeparator6.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator6, Me.btnAproItems, Me.ToolStripSeparator4, Me.btnMarkOrderForward, Me.btnMarkOrderApproved, Me.btnEdit, Me.BtnPrintRequest})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1277, 31)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.CheckOnClick = True
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(122, 28)
        Me.BtnRefresh.Text = "Refresh Data"
        '
        'btnAproItems
        '
        Me.btnAproItems.CheckOnClick = True
        Me.btnAproItems.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.btnAproItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAproItems.Name = "btnAproItems"
        Me.btnAproItems.Size = New System.Drawing.Size(185, 28)
        Me.btnAproItems.Text = "Approved And Forward"
        Me.btnAproItems.Visible = False
        '
        'btnMarkOrderForward
        '
        Me.btnMarkOrderForward.CheckOnClick = True
        Me.btnMarkOrderForward.Image = Global.TakeoHospitalInventory.My.Resources.Resources.RightLeft2Red
        Me.btnMarkOrderForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarkOrderForward.Name = "btnMarkOrderForward"
        Me.btnMarkOrderForward.Size = New System.Drawing.Size(227, 28)
        Me.btnMarkOrderForward.Text = "Forward All Items In Request"
        Me.btnMarkOrderForward.Visible = False
        '
        'btnMarkOrderApproved
        '
        Me.btnMarkOrderApproved.CheckOnClick = True
        Me.btnMarkOrderApproved.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Aproved
        Me.btnMarkOrderApproved.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarkOrderApproved.Name = "btnMarkOrderApproved"
        Me.btnMarkOrderApproved.Size = New System.Drawing.Size(237, 28)
        Me.btnMarkOrderApproved.Text = "Approved All Items In Request"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(59, 28)
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.Visible = False
        '
        'BtnPrintRequest
        '
        Me.BtnPrintRequest.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnPrintRequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintRequest.Name = "BtnPrintRequest"
        Me.BtnPrintRequest.Size = New System.Drawing.Size(64, 28)
        Me.BtnPrintRequest.Text = "Print"
        '
        'ErrorPro
        '
        Me.ErrorPro.ContainerControl = Me
        '
        'UCReceivedRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UCReceivedRequest"
        Me.Size = New System.Drawing.Size(1277, 550)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.GridRequestDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridItemRequestDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.gridRequestHis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TVRequestOrderStatus As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridRequestDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridItemRequestDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnInStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAproItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMarkOrderForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMarkOrderApproved As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAddApprovedItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnApproved As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents menuInStock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuEditQtyApprovedItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuAddApprovedItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadApproved As System.Windows.Forms.RadioButton
    Friend WithEvents RadRequest As System.Windows.Forms.RadioButton
    Friend WithEvents gridRequestHis As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGridDisplay As System.Windows.Forms.Button
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintRequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents CBAllDepart As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorPro As System.Windows.Forms.ErrorProvider

End Class
