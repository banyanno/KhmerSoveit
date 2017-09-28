<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResponseRequestOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnAddItemReDetail = New System.Windows.Forms.Button
        Me.btnRemoveItem = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ErrorRequestOrder = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lbNumEntries = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rtbComment = New System.Windows.Forms.RichTextBox
        Me.labelComment = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.rtbDes = New System.Windows.Forms.RichTextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.cbDepart = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpRDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtReOrNum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DGVRequestItemsDetail = New System.Windows.Forms.DataGridView
        Me.cItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cUnitItem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cContaining = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cInStock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResponseQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbUserRequest = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbOwnerDepart = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbApproved = New System.Windows.Forms.RadioButton
        Me.rbForward = New System.Windows.Forms.RadioButton
        Me.txtInStock = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtResponseQty = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtRequestQty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.ErrorRequestOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddItemReDetail
        '
        Me.btnAddItemReDetail.Location = New System.Drawing.Point(192, 313)
        Me.btnAddItemReDetail.Name = "btnAddItemReDetail"
        Me.btnAddItemReDetail.Size = New System.Drawing.Size(140, 23)
        Me.btnAddItemReDetail.TabIndex = 51
        Me.btnAddItemReDetail.Text = "Add Items Request Detail"
        Me.btnAddItemReDetail.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(338, 313)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(202, 23)
        Me.btnRemoveItem.TabIndex = 58
        Me.btnRemoveItem.Text = "Remove Selected Item Request Detail"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        Me.btnRemoveItem.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnCancel.Location = New System.Drawing.Point(1086, 613)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 57
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnSave.Location = New System.Drawing.Point(987, 613)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 40)
        Me.btnSave.TabIndex = 56
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.PeachPuff
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 20)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Request Info"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.PeachPuff
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 20)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Request Detail Item Info"
        '
        'ErrorRequestOrder
        '
        Me.ErrorRequestOrder.ContainerControl = Me
        '
        'lbNumEntries
        '
        Me.lbNumEntries.AutoSize = True
        Me.lbNumEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbNumEntries.Location = New System.Drawing.Point(1160, 316)
        Me.lbNumEntries.Name = "lbNumEntries"
        Me.lbNumEntries.Size = New System.Drawing.Size(16, 17)
        Me.lbNumEntries.TabIndex = 48
        Me.lbNumEntries.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1020, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Number of entries :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Department :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rtbComment)
        Me.GroupBox1.Controls.Add(Me.labelComment)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.rtbDes)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.cbDepart)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpRDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtReOrNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 208)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'rtbComment
        '
        Me.rtbComment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rtbComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbComment.Location = New System.Drawing.Point(152, 154)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.Size = New System.Drawing.Size(395, 29)
        Me.rtbComment.TabIndex = 18
        Me.rtbComment.Text = ""
        Me.rtbComment.Visible = False
        '
        'labelComment
        '
        Me.labelComment.AutoSize = True
        Me.labelComment.Location = New System.Drawing.Point(9, 154)
        Me.labelComment.Name = "labelComment"
        Me.labelComment.Size = New System.Drawing.Size(57, 13)
        Me.labelComment.TabIndex = 17
        Me.labelComment.Text = "Comment :"
        Me.labelComment.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(553, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(553, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(553, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "*"
        '
        'rtbDes
        '
        Me.rtbDes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rtbDes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDes.Enabled = False
        Me.rtbDes.Location = New System.Drawing.Point(152, 112)
        Me.rtbDes.Name = "rtbDes"
        Me.rtbDes.Size = New System.Drawing.Size(395, 29)
        Me.rtbDes.TabIndex = 13
        Me.rtbDes.Text = ""
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(9, 119)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(66, 13)
        Me.lblDescription.TabIndex = 12
        Me.lblDescription.Text = "Description :"
        '
        'cbDepart
        '
        Me.cbDepart.BackColor = System.Drawing.SystemColors.Control
        Me.cbDepart.Enabled = False
        Me.cbDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbDepart.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbDepart.FormattingEnabled = True
        Me.cbDepart.Location = New System.Drawing.Point(152, 79)
        Me.cbDepart.Name = "cbDepart"
        Me.cbDepart.Size = New System.Drawing.Size(395, 28)
        Me.cbDepart.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Request From Department :"
        '
        'dtpRDate
        '
        Me.dtpRDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate.Enabled = False
        Me.dtpRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate.Location = New System.Drawing.Point(152, 46)
        Me.dtpRDate.Name = "dtpRDate"
        Me.dtpRDate.Size = New System.Drawing.Size(395, 26)
        Me.dtpRDate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date :"
        '
        'txtReOrNum
        '
        Me.txtReOrNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReOrNum.Enabled = False
        Me.txtReOrNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtReOrNum.Location = New System.Drawing.Point(152, 15)
        Me.txtReOrNum.Name = "txtReOrNum"
        Me.txtReOrNum.Size = New System.Drawing.Size(395, 26)
        Me.txtReOrNum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Request Order Number :"
        '
        'DGVRequestItemsDetail
        '
        Me.DGVRequestItemsDetail.AllowUserToAddRows = False
        Me.DGVRequestItemsDetail.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVRequestItemsDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVRequestItemsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRequestItemsDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemNo, Me.cItemName, Me.cCategory, Me.cUnitItem, Me.cContaining, Me.cInStock, Me.cRQuantity, Me.ResponseQty, Me.cStatus})
        Me.DGVRequestItemsDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVRequestItemsDetail.Location = New System.Drawing.Point(3, 16)
        Me.DGVRequestItemsDetail.Name = "DGVRequestItemsDetail"
        Me.DGVRequestItemsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRequestItemsDetail.Size = New System.Drawing.Size(1164, 258)
        Me.DGVRequestItemsDetail.TabIndex = 9
        '
        'cItemNo
        '
        Me.cItemNo.DataPropertyName = "ItemID"
        Me.cItemNo.HeaderText = "ItemNo"
        Me.cItemNo.Name = "cItemNo"
        Me.cItemNo.ReadOnly = True
        '
        'cItemName
        '
        Me.cItemName.DataPropertyName = "ItemName"
        Me.cItemName.HeaderText = "Item Name"
        Me.cItemName.Name = "cItemName"
        Me.cItemName.ReadOnly = True
        Me.cItemName.Width = 210
        '
        'cCategory
        '
        Me.cCategory.DataPropertyName = "CateName"
        Me.cCategory.HeaderText = "Cetegory"
        Me.cCategory.Name = "cCategory"
        Me.cCategory.ReadOnly = True
        Me.cCategory.Width = 120
        '
        'cUnitItem
        '
        Me.cUnitItem.DataPropertyName = "ItemUnitName"
        Me.cUnitItem.HeaderText = "Unit of Measuring"
        Me.cUnitItem.Name = "cUnitItem"
        Me.cUnitItem.ReadOnly = True
        '
        'cContaining
        '
        Me.cContaining.DataPropertyName = "ContainerName"
        Me.cContaining.HeaderText = "Containing"
        Me.cContaining.Name = "cContaining"
        Me.cContaining.ReadOnly = True
        '
        'cInStock
        '
        Me.cInStock.DataPropertyName = "cInStock"
        Me.cInStock.HeaderText = "InStock"
        Me.cInStock.Name = "cInStock"
        Me.cInStock.ReadOnly = True
        Me.cInStock.Width = 70
        '
        'cRQuantity
        '
        Me.cRQuantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cRQuantity.DefaultCellStyle = DataGridViewCellStyle8
        Me.cRQuantity.HeaderText = "Request Quantity"
        Me.cRQuantity.Name = "cRQuantity"
        Me.cRQuantity.Width = 140
        '
        'ResponseQty
        '
        Me.ResponseQty.HeaderText = "Response Quantity"
        Me.ResponseQty.Name = "ResponseQty"
        Me.ResponseQty.Width = 130
        '
        'cStatus
        '
        Me.cStatus.HeaderText = "Status"
        Me.cStatus.Name = "cStatus"
        Me.cStatus.Width = 130
        '
        'lbUserRequest
        '
        Me.lbUserRequest.AutoSize = True
        Me.lbUserRequest.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserRequest.Location = New System.Drawing.Point(1102, 10)
        Me.lbUserRequest.Name = "lbUserRequest"
        Me.lbUserRequest.Size = New System.Drawing.Size(74, 20)
        Me.lbUserRequest.TabIndex = 43
        Me.lbUserRequest.Text = "Chan Vibol"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGVRequestItemsDetail)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1170, 277)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(973, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Request Creator :"
        '
        'lbOwnerDepart
        '
        Me.lbOwnerDepart.AutoSize = True
        Me.lbOwnerDepart.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOwnerDepart.Location = New System.Drawing.Point(103, 13)
        Me.lbOwnerDepart.Name = "lbOwnerDepart"
        Me.lbOwnerDepart.Size = New System.Drawing.Size(115, 20)
        Me.lbOwnerDepart.TabIndex = 41
        Me.lbOwnerDepart.Text = "Operation Theater"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(609, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Respone Item"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtInStock)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtResponseQty)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtRequestQty)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtItemName)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(609, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 208)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(447, 149)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 52)
        Me.btnUpdate.TabIndex = 55
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Status :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbApproved)
        Me.GroupBox4.Controls.Add(Me.rbForward)
        Me.GroupBox4.Location = New System.Drawing.Point(155, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(286, 58)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        '
        'rbApproved
        '
        Me.rbApproved.AutoSize = True
        Me.rbApproved.Location = New System.Drawing.Point(15, 10)
        Me.rbApproved.Name = "rbApproved"
        Me.rbApproved.Size = New System.Drawing.Size(71, 17)
        Me.rbApproved.TabIndex = 51
        Me.rbApproved.TabStop = True
        Me.rbApproved.Text = "Approved"
        Me.rbApproved.UseVisualStyleBackColor = True
        '
        'rbForward
        '
        Me.rbForward.AutoSize = True
        Me.rbForward.Location = New System.Drawing.Point(15, 35)
        Me.rbForward.Name = "rbForward"
        Me.rbForward.Size = New System.Drawing.Size(63, 17)
        Me.rbForward.TabIndex = 52
        Me.rbForward.TabStop = True
        Me.rbForward.Text = "Forward"
        Me.rbForward.UseVisualStyleBackColor = True
        '
        'txtInStock
        '
        Me.txtInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInStock.Enabled = False
        Me.txtInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtInStock.Location = New System.Drawing.Point(155, 46)
        Me.txtInStock.Name = "txtInStock"
        Me.txtInStock.Size = New System.Drawing.Size(395, 26)
        Me.txtInStock.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "InStock :"
        '
        'txtResponseQty
        '
        Me.txtResponseQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtResponseQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResponseQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtResponseQty.Location = New System.Drawing.Point(155, 112)
        Me.txtResponseQty.Name = "txtResponseQty"
        Me.txtResponseQty.Size = New System.Drawing.Size(395, 26)
        Me.txtResponseQty.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Response Quantity :"
        '
        'txtRequestQty
        '
        Me.txtRequestQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRequestQty.Enabled = False
        Me.txtRequestQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRequestQty.Location = New System.Drawing.Point(155, 79)
        Me.txtRequestQty.Name = "txtRequestQty"
        Me.txtRequestQty.Size = New System.Drawing.Size(395, 26)
        Me.txtRequestQty.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Request Quantity :"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtItemName.Location = New System.Drawing.Point(155, 15)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(395, 26)
        Me.txtItemName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Item Name :"
        '
        'frmResponseRequestOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1203, 663)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAddItemReDetail)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbNumEntries)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbUserRequest)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbOwnerDepart)
        Me.Name = "frmResponseRequestOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Response Request Order"
        CType(Me.ErrorRequestOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddItemReDetail As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ErrorRequestOrder As System.Windows.Forms.ErrorProvider
    Friend WithEvents lbNumEntries As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rtbComment As System.Windows.Forms.RichTextBox
    Friend WithEvents labelComment As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents rtbDes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents cbDepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReOrNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbUserRequest As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVRequestItemsDetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbOwnerDepart As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtResponseQty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRequestQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtInStock As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbApproved As System.Windows.Forms.RadioButton
    Friend WithEvents rbForward As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUnitItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaining As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cInStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResponseQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
