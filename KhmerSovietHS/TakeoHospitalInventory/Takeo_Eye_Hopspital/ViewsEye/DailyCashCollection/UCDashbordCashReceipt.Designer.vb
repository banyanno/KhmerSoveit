<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDashbordCashReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDashbordCashReceipt))
        Dim GridJanusWaitingPayment_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnDonated = New System.Windows.Forms.Button
        Me.ImpDashbordCashReceipt = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdReceiptControl = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdCashReceipt = New System.Windows.Forms.Button
        Me.cmdOPReceipt = New System.Windows.Forms.Button
        Me.cmdNPReceipt = New System.Windows.Forms.Button
        Me.cmdIPReceipt = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridJanusWaitingPayment = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.dgvPaymentList = New System.Windows.Forms.DataGridView
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.HN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDCashReceipt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConPay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateIn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsDonation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DonationID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DonationName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DonationPay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DonateNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HosFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CashTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnSocialServiceInpatient = New System.Windows.Forms.Button
        Me.BtnSocialOpticalShop = New System.Windows.Forms.Button
        Me.cmdViewAll = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.DateReceipt = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridJanusWaitingPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDonated)
        Me.GroupBox1.Controls.Add(Me.cmdReceiptControl)
        Me.GroupBox1.Controls.Add(Me.cmdView)
        Me.GroupBox1.Controls.Add(Me.cmdCashReceipt)
        Me.GroupBox1.Controls.Add(Me.cmdOPReceipt)
        Me.GroupBox1.Controls.Add(Me.cmdNPReceipt)
        Me.GroupBox1.Controls.Add(Me.cmdIPReceipt)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(844, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 1100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnDonated
        '
        Me.BtnDonated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDonated.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDonated.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.BtnDonated.ImageIndex = 5
        Me.BtnDonated.ImageList = Me.ImpDashbordCashReceipt
        Me.BtnDonated.Location = New System.Drawing.Point(8, 494)
        Me.BtnDonated.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDonated.Name = "BtnDonated"
        Me.BtnDonated.Size = New System.Drawing.Size(180, 86)
        Me.BtnDonated.TabIndex = 14
        Me.BtnDonated.Text = "Donated"
        Me.BtnDonated.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnDonated.UseVisualStyleBackColor = True
        '
        'ImpDashbordCashReceipt
        '
        Me.ImpDashbordCashReceipt.ImageStream = CType(resources.GetObject("ImpDashbordCashReceipt.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImpDashbordCashReceipt.TransparentColor = System.Drawing.Color.Transparent
        Me.ImpDashbordCashReceipt.Images.SetKeyName(0, "Receipt_nop.png")
        Me.ImpDashbordCashReceipt.Images.SetKeyName(1, "Receipt_oop.png")
        Me.ImpDashbordCashReceipt.Images.SetKeyName(2, "cashbox.png")
        Me.ImpDashbordCashReceipt.Images.SetKeyName(3, "CashReceipt.png")
        Me.ImpDashbordCashReceipt.Images.SetKeyName(4, "cabinet.ico")
        Me.ImpDashbordCashReceipt.Images.SetKeyName(5, "transaction_report.ico")
        '
        'cmdReceiptControl
        '
        Me.cmdReceiptControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdReceiptControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReceiptControl.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReceiptControl.ImageIndex = 4
        Me.cmdReceiptControl.ImageList = Me.ImpDashbordCashReceipt
        Me.cmdReceiptControl.Location = New System.Drawing.Point(8, 391)
        Me.cmdReceiptControl.Name = "cmdReceiptControl"
        Me.cmdReceiptControl.Size = New System.Drawing.Size(180, 86)
        Me.cmdReceiptControl.TabIndex = 13
        Me.cmdReceiptControl.Text = "Receipt Control"
        Me.cmdReceiptControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdReceiptControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdReceiptControl.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.BackgroundImage = CType(resources.GetObject("cmdView.BackgroundImage"), System.Drawing.Image)
        Me.cmdView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdView.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Image = Global.TakeoHospitalInventory.My.Resources.Resources.waiting
        Me.cmdView.Location = New System.Drawing.Point(58, 842)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(97, 65)
        Me.cmdView.TabIndex = 11
        Me.cmdView.Text = "Waiting Payment"
        Me.cmdView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdView.UseVisualStyleBackColor = True
        Me.cmdView.Visible = False
        '
        'cmdCashReceipt
        '
        Me.cmdCashReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdCashReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCashReceipt.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCashReceipt.ImageIndex = 3
        Me.cmdCashReceipt.ImageList = Me.ImpDashbordCashReceipt
        Me.cmdCashReceipt.Location = New System.Drawing.Point(8, 296)
        Me.cmdCashReceipt.Name = "cmdCashReceipt"
        Me.cmdCashReceipt.Size = New System.Drawing.Size(180, 86)
        Me.cmdCashReceipt.TabIndex = 10
        Me.cmdCashReceipt.Text = "Cash Other Receipt"
        Me.cmdCashReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCashReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCashReceipt.UseVisualStyleBackColor = True
        '
        'cmdOPReceipt
        '
        Me.cmdOPReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdOPReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOPReceipt.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOPReceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdOPReceipt.ImageKey = "Receipt_oop.png"
        Me.cmdOPReceipt.ImageList = Me.ImpDashbordCashReceipt
        Me.cmdOPReceipt.Location = New System.Drawing.Point(8, 106)
        Me.cmdOPReceipt.Name = "cmdOPReceipt"
        Me.cmdOPReceipt.Size = New System.Drawing.Size(180, 86)
        Me.cmdOPReceipt.TabIndex = 9
        Me.cmdOPReceipt.Text = "Old-Out Patient Receipt"
        Me.cmdOPReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOPReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOPReceipt.UseVisualStyleBackColor = True
        '
        'cmdNPReceipt
        '
        Me.cmdNPReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNPReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNPReceipt.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNPReceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNPReceipt.ImageIndex = 0
        Me.cmdNPReceipt.ImageList = Me.ImpDashbordCashReceipt
        Me.cmdNPReceipt.Location = New System.Drawing.Point(8, 11)
        Me.cmdNPReceipt.Name = "cmdNPReceipt"
        Me.cmdNPReceipt.Size = New System.Drawing.Size(180, 86)
        Me.cmdNPReceipt.TabIndex = 8
        Me.cmdNPReceipt.Text = "New-Out Patient Receipt"
        Me.cmdNPReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNPReceipt.UseVisualStyleBackColor = True
        '
        'cmdIPReceipt
        '
        Me.cmdIPReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdIPReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIPReceipt.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIPReceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdIPReceipt.ImageIndex = 2
        Me.cmdIPReceipt.ImageList = Me.ImpDashbordCashReceipt
        Me.cmdIPReceipt.Location = New System.Drawing.Point(8, 201)
        Me.cmdIPReceipt.Name = "cmdIPReceipt"
        Me.cmdIPReceipt.Size = New System.Drawing.Size(180, 86)
        Me.cmdIPReceipt.TabIndex = 7
        Me.cmdIPReceipt.Text = "Inpatient Receipt"
        Me.cmdIPReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIPReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdIPReceipt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridJanusWaitingPayment)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Controls.Add(Me.dgvPaymentList)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1042, 1119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Waiting Payment"
        '
        'GridJanusWaitingPayment
        '
        GridJanusWaitingPayment_DesignTimeLayout.LayoutString = resources.GetString("GridJanusWaitingPayment_DesignTimeLayout.LayoutString")
        Me.GridJanusWaitingPayment.DesignTimeLayout = GridJanusWaitingPayment_DesignTimeLayout
        Me.GridJanusWaitingPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridJanusWaitingPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridJanusWaitingPayment.GroupByBoxVisible = False
        Me.GridJanusWaitingPayment.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridJanusWaitingPayment.Location = New System.Drawing.Point(3, 110)
        Me.GridJanusWaitingPayment.Name = "GridJanusWaitingPayment"
        Me.GridJanusWaitingPayment.RecordNavigator = True
        Me.GridJanusWaitingPayment.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridJanusWaitingPayment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridJanusWaitingPayment.Size = New System.Drawing.Size(841, 981)
        Me.GridJanusWaitingPayment.TabIndex = 8
        Me.GridJanusWaitingPayment.WatermarkImage.Image = CType(resources.GetObject("GridJanusWaitingPayment.WatermarkImage.Image"), System.Drawing.Image)
        Me.GridJanusWaitingPayment.WatermarkImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.ToolStripSeparator4, Me.ToolStripLabel5})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 1091)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(841, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripLabel1.Text = "Status Note:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripLabel2.Text = "Receipt's New-Patient"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripLabel3.Text = "Receipt's Old-Patients"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripLabel4.Text = "Receipt's In-Patients"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(138, 22)
        Me.ToolStripLabel5.Text = "Receipt's Optical Shops"
        '
        'dgvPaymentList
        '
        Me.dgvPaymentList.AllowUserToAddRows = False
        Me.dgvPaymentList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvPaymentList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPaymentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPaymentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaymentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.HN, Me.ReceiptNo, Me.PatientName, Me.IDCashReceipt, Me.ConPay, Me.ConGeneral, Me.DateIn, Me.ID, Me.IsDonation, Me.DonationID, Me.DonationName, Me.DonationPay, Me.DonateNote, Me.HosFee, Me.CashTotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaymentList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPaymentList.Location = New System.Drawing.Point(648, 407)
        Me.dgvPaymentList.Name = "dgvPaymentList"
        Me.dgvPaymentList.ReadOnly = True
        Me.dgvPaymentList.RowHeadersWidth = 55
        Me.dgvPaymentList.RowTemplate.Height = 35
        Me.dgvPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentList.Size = New System.Drawing.Size(167, 560)
        Me.dgvPaymentList.TabIndex = 1
        Me.dgvPaymentList.Visible = False
        '
        'Check
        '
        Me.Check.FillWeight = 50.0!
        Me.Check.Frozen = True
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.ReadOnly = True
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Check.Width = 50
        '
        'HN
        '
        Me.HN.DataPropertyName = "HN"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        Me.HN.DefaultCellStyle = DataGridViewCellStyle3
        Me.HN.Frozen = True
        Me.HN.HeaderText = "HN"
        Me.HN.Name = "HN"
        Me.HN.ReadOnly = True
        Me.HN.Width = 120
        '
        'ReceiptNo
        '
        Me.ReceiptNo.DataPropertyName = "ReceiptNo"
        Me.ReceiptNo.Frozen = True
        Me.ReceiptNo.HeaderText = "Receipt No."
        Me.ReceiptNo.Name = "ReceiptNo"
        Me.ReceiptNo.ReadOnly = True
        Me.ReceiptNo.Width = 150
        '
        'PatientName
        '
        Me.PatientName.DataPropertyName = "PatientName"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PatientName.DefaultCellStyle = DataGridViewCellStyle4
        Me.PatientName.Frozen = True
        Me.PatientName.HeaderText = "Name"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        Me.PatientName.Width = 250
        '
        'IDCashReceipt
        '
        Me.IDCashReceipt.DataPropertyName = "IDCashReceipt"
        Me.IDCashReceipt.Frozen = True
        Me.IDCashReceipt.HeaderText = "Cash Receipt No."
        Me.IDCashReceipt.Name = "IDCashReceipt"
        Me.IDCashReceipt.ReadOnly = True
        Me.IDCashReceipt.Visible = False
        Me.IDCashReceipt.Width = 150
        '
        'ConPay
        '
        Me.ConPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ConPay.DataPropertyName = "ConPay"
        Me.ConPay.FillWeight = 2.0!
        Me.ConPay.Frozen = True
        Me.ConPay.HeaderText = ""
        Me.ConPay.MinimumWidth = 2
        Me.ConPay.Name = "ConPay"
        Me.ConPay.ReadOnly = True
        Me.ConPay.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConPay.Visible = False
        Me.ConPay.Width = 2
        '
        'ConGeneral
        '
        Me.ConGeneral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ConGeneral.DataPropertyName = "ConGeneral"
        Me.ConGeneral.FillWeight = 2.0!
        Me.ConGeneral.Frozen = True
        Me.ConGeneral.HeaderText = ""
        Me.ConGeneral.MinimumWidth = 2
        Me.ConGeneral.Name = "ConGeneral"
        Me.ConGeneral.ReadOnly = True
        Me.ConGeneral.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConGeneral.Visible = False
        Me.ConGeneral.Width = 2
        '
        'DateIn
        '
        Me.DateIn.DataPropertyName = "DateIn"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Format = "dd/MM/yyyy"
        Me.DateIn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DateIn.Frozen = True
        Me.DateIn.HeaderText = "Receipt Date"
        Me.DateIn.Name = "DateIn"
        Me.DateIn.ReadOnly = True
        Me.DateIn.Width = 150
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.Frozen = True
        Me.ID.HeaderText = ""
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'IsDonation
        '
        Me.IsDonation.DataPropertyName = "IsDonation"
        Me.IsDonation.HeaderText = "IsDonation"
        Me.IsDonation.Name = "IsDonation"
        Me.IsDonation.ReadOnly = True
        Me.IsDonation.Visible = False
        '
        'DonationID
        '
        Me.DonationID.DataPropertyName = "DonationID"
        Me.DonationID.HeaderText = "DonationID"
        Me.DonationID.Name = "DonationID"
        Me.DonationID.ReadOnly = True
        Me.DonationID.Visible = False
        '
        'DonationName
        '
        Me.DonationName.DataPropertyName = "DonationName"
        Me.DonationName.HeaderText = "DonationName"
        Me.DonationName.Name = "DonationName"
        Me.DonationName.ReadOnly = True
        Me.DonationName.Visible = False
        '
        'DonationPay
        '
        Me.DonationPay.DataPropertyName = "DonationPay"
        Me.DonationPay.HeaderText = "DonationPay"
        Me.DonationPay.Name = "DonationPay"
        Me.DonationPay.ReadOnly = True
        Me.DonationPay.Visible = False
        '
        'DonateNote
        '
        Me.DonateNote.DataPropertyName = "DonateNote"
        Me.DonateNote.HeaderText = "DonateNote"
        Me.DonateNote.Name = "DonateNote"
        Me.DonateNote.ReadOnly = True
        Me.DonateNote.Visible = False
        '
        'HosFee
        '
        Me.HosFee.DataPropertyName = "HosFee"
        Me.HosFee.HeaderText = "HosFee"
        Me.HosFee.Name = "HosFee"
        Me.HosFee.ReadOnly = True
        Me.HosFee.Visible = False
        '
        'CashTotal
        '
        Me.CashTotal.DataPropertyName = "CashTotal"
        Me.CashTotal.HeaderText = "CashTotal"
        Me.CashTotal.Name = "CashTotal"
        Me.CashTotal.ReadOnly = True
        Me.CashTotal.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnSocialServiceInpatient)
        Me.GroupBox3.Controls.Add(Me.BtnSocialOpticalShop)
        Me.GroupBox3.Controls.Add(Me.cmdViewAll)
        Me.GroupBox3.Controls.Add(Me.cmdUndo)
        Me.GroupBox3.Controls.Add(Me.cmdDelete)
        Me.GroupBox3.Controls.Add(Me.DateReceipt)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(841, 94)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'BtnSocialServiceInpatient
        '
        Me.BtnSocialServiceInpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSocialServiceInpatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSocialServiceInpatient.Location = New System.Drawing.Point(489, 17)
        Me.BtnSocialServiceInpatient.Name = "BtnSocialServiceInpatient"
        Me.BtnSocialServiceInpatient.Size = New System.Drawing.Size(274, 28)
        Me.BtnSocialServiceInpatient.TabIndex = 12
        Me.BtnSocialServiceInpatient.Text = "Report Social Seervice  For In-Patient"
        Me.BtnSocialServiceInpatient.UseVisualStyleBackColor = True
        '
        'BtnSocialOpticalShop
        '
        Me.BtnSocialOpticalShop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSocialOpticalShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSocialOpticalShop.Location = New System.Drawing.Point(489, 49)
        Me.BtnSocialOpticalShop.Name = "BtnSocialOpticalShop"
        Me.BtnSocialOpticalShop.Size = New System.Drawing.Size(274, 25)
        Me.BtnSocialOpticalShop.TabIndex = 11
        Me.BtnSocialOpticalShop.Text = "Report Social Service For Optical Shop"
        Me.BtnSocialOpticalShop.UseVisualStyleBackColor = True
        '
        'cmdViewAll
        '
        Me.cmdViewAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdViewAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdViewAll.Location = New System.Drawing.Point(383, 17)
        Me.cmdViewAll.Name = "cmdViewAll"
        Me.cmdViewAll.Size = New System.Drawing.Size(100, 57)
        Me.cmdViewAll.TabIndex = 10
        Me.cmdViewAll.Text = "&View Alll"
        Me.cmdViewAll.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUndo.Location = New System.Drawing.Point(711, 50)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(124, 26)
        Me.cmdUndo.TabIndex = 9
        Me.cmdUndo.Text = "&Undo Delete"
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(711, 16)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(124, 31)
        Me.cmdDelete.TabIndex = 7
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'DateReceipt
        '
        Me.DateReceipt.CustomFormat = "dd/MM/yyyy"
        Me.DateReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceipt.Location = New System.Drawing.Point(22, 38)
        Me.DateReceipt.Name = "DateReceipt"
        Me.DateReceipt.Size = New System.Drawing.Size(125, 26)
        Me.DateReceipt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date From:"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(162, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 57)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Load Receipt For Payment Today"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UCDashbordCashReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "UCDashbordCashReceipt"
        Me.Size = New System.Drawing.Size(1042, 1119)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridJanusWaitingPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdReceiptControl As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdCashReceipt As System.Windows.Forms.Button
    Friend WithEvents cmdOPReceipt As System.Windows.Forms.Button
    Friend WithEvents cmdNPReceipt As System.Windows.Forms.Button
    Friend WithEvents cmdIPReceipt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPaymentList As System.Windows.Forms.DataGridView
    Friend WithEvents DateReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdViewAll As System.Windows.Forms.Button
    Friend WithEvents BtnDonated As System.Windows.Forms.Button
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCashReceipt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConGeneral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsDonation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonationID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonationName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonationPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonateNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HosFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpDashbordCashReceipt As System.Windows.Forms.ImageList
    Friend WithEvents GridJanusWaitingPayment As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnSocialServiceInpatient As System.Windows.Forms.Button
    Friend WithEvents BtnSocialOpticalShop As System.Windows.Forms.Button

End Class
