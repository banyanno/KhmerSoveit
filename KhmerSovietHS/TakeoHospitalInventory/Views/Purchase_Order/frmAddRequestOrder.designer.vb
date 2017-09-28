<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRequestOrder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRequestOrder))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rtbComment = New System.Windows.Forms.RichTextBox
        Me.labelComment = New System.Windows.Forms.Label
        Me.lbUserRequest = New System.Windows.Forms.Label
        Me.lbOwnerDepart = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.rtbDes = New System.Windows.Forms.RichTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.cbDepart = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpRDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtReOrNum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGVRequestItemsDetail = New System.Windows.Forms.DataGridView
        Me.cItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cUnitItem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cContaining = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cInStock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnAddItemReDetail1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRemoveItem1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.lbNumEntries = New System.Windows.Forms.ToolStripLabel
        Me.ErrorRequestOrder = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorRequestOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rtbComment)
        Me.GroupBox1.Controls.Add(Me.labelComment)
        Me.GroupBox1.Controls.Add(Me.lbUserRequest)
        Me.GroupBox1.Controls.Add(Me.lbOwnerDepart)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.rtbDes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.cbDepart)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpRDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtReOrNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1062, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request Info"
        '
        'rtbComment
        '
        Me.rtbComment.BackColor = System.Drawing.SystemColors.Window
        Me.rtbComment.Location = New System.Drawing.Point(563, 174)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.Size = New System.Drawing.Size(345, 96)
        Me.rtbComment.TabIndex = 18
        Me.rtbComment.Text = ""
        Me.rtbComment.Visible = False
        '
        'labelComment
        '
        Me.labelComment.AutoSize = True
        Me.labelComment.Location = New System.Drawing.Point(562, 153)
        Me.labelComment.Name = "labelComment"
        Me.labelComment.Size = New System.Drawing.Size(57, 13)
        Me.labelComment.TabIndex = 17
        Me.labelComment.Text = "Comment :"
        Me.labelComment.Visible = False
        '
        'lbUserRequest
        '
        Me.lbUserRequest.BackColor = System.Drawing.Color.White
        Me.lbUserRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbUserRequest.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserRequest.Location = New System.Drawing.Point(141, 55)
        Me.lbUserRequest.Name = "lbUserRequest"
        Me.lbUserRequest.Size = New System.Drawing.Size(202, 22)
        Me.lbUserRequest.TabIndex = 15
        Me.lbUserRequest.Text = "Chan Vibol"
        '
        'lbOwnerDepart
        '
        Me.lbOwnerDepart.AutoSize = True
        Me.lbOwnerDepart.BackColor = System.Drawing.Color.Transparent
        Me.lbOwnerDepart.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOwnerDepart.Location = New System.Drawing.Point(442, 57)
        Me.lbOwnerDepart.Name = "lbOwnerDepart"
        Me.lbOwnerDepart.Size = New System.Drawing.Size(115, 20)
        Me.lbOwnerDepart.TabIndex = 3
        Me.lbOwnerDepart.Text = "Operation Theater"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(356, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Department :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(542, 145)
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
        Me.Label16.Location = New System.Drawing.Point(542, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "*"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(142, 82)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(201, 24)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Open"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(542, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Status :"
        '
        'rtbDes
        '
        Me.rtbDes.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDes.Location = New System.Drawing.Point(141, 178)
        Me.rtbDes.Name = "rtbDes"
        Me.rtbDes.Size = New System.Drawing.Size(395, 86)
        Me.rtbDes.TabIndex = 13
        Me.rtbDes.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Request Creator :"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(18, 184)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(66, 13)
        Me.lblDescription.TabIndex = 12
        Me.lblDescription.Text = "Description :"
        '
        'cbDepart
        '
        Me.cbDepart.BackColor = System.Drawing.SystemColors.Window
        Me.cbDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbDepart.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbDepart.Location = New System.Drawing.Point(141, 145)
        Me.cbDepart.Name = "cbDepart"
        Me.cbDepart.Size = New System.Drawing.Size(395, 28)
        Me.cbDepart.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Request to Department :"
        '
        'dtpRDate
        '
        Me.dtpRDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate.Enabled = False
        Me.dtpRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate.Location = New System.Drawing.Point(141, 112)
        Me.dtpRDate.Name = "dtpRDate"
        Me.dtpRDate.Size = New System.Drawing.Size(395, 26)
        Me.dtpRDate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Request Order Date :"
        '
        'txtReOrNum
        '
        Me.txtReOrNum.Enabled = False
        Me.txtReOrNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtReOrNum.Location = New System.Drawing.Point(141, 23)
        Me.txtReOrNum.Name = "txtReOrNum"
        Me.txtReOrNum.Size = New System.Drawing.Size(395, 26)
        Me.txtReOrNum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Request Order Number :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGVRequestItemsDetail)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1063, 261)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Detail Item Info"
        '
        'DGVRequestItemsDetail
        '
        Me.DGVRequestItemsDetail.AllowUserToAddRows = False
        Me.DGVRequestItemsDetail.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVRequestItemsDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVRequestItemsDetail.ColumnHeadersHeight = 30
        Me.DGVRequestItemsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVRequestItemsDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemNo, Me.cItemName, Me.cCategory, Me.cUnitItem, Me.cContaining, Me.cInStock, Me.cRQuantity, Me.cBarcode})
        Me.DGVRequestItemsDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVRequestItemsDetail.Location = New System.Drawing.Point(3, 41)
        Me.DGVRequestItemsDetail.Name = "DGVRequestItemsDetail"
        Me.DGVRequestItemsDetail.RowTemplate.Height = 24
        Me.DGVRequestItemsDetail.Size = New System.Drawing.Size(1057, 217)
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
        Me.cCategory.Width = 150
        '
        'cUnitItem
        '
        Me.cUnitItem.DataPropertyName = "ItemUnitName"
        Me.cUnitItem.HeaderText = "Unit of Measuring"
        Me.cUnitItem.Name = "cUnitItem"
        Me.cUnitItem.ReadOnly = True
        Me.cUnitItem.Width = 140
        '
        'cContaining
        '
        Me.cContaining.DataPropertyName = "ContainerName"
        Me.cContaining.HeaderText = "Containing"
        Me.cContaining.Name = "cContaining"
        Me.cContaining.ReadOnly = True
        Me.cContaining.Width = 140
        '
        'cInStock
        '
        Me.cInStock.DataPropertyName = "cInStock"
        Me.cInStock.HeaderText = "InStock"
        Me.cInStock.Name = "cInStock"
        Me.cInStock.ReadOnly = True
        Me.cInStock.Visible = False
        '
        'cRQuantity
        '
        Me.cRQuantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cRQuantity.DefaultCellStyle = DataGridViewCellStyle1
        Me.cRQuantity.HeaderText = "Request Quantity"
        Me.cRQuantity.Name = "cRQuantity"
        Me.cRQuantity.Width = 140
        '
        'cBarcode
        '
        Me.cBarcode.DataPropertyName = "Barcode"
        Me.cBarcode.HeaderText = "Barcode"
        Me.cBarcode.Name = "cBarcode"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddItemReDetail1, Me.ToolStripSeparator1, Me.btnRemoveItem1, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.lbNumEntries})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1057, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddItemReDetail1
        '
        Me.btnAddItemReDetail1.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.btnAddItemReDetail1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddItemReDetail1.Name = "btnAddItemReDetail1"
        Me.btnAddItemReDetail1.Size = New System.Drawing.Size(149, 22)
        Me.btnAddItemReDetail1.Text = "Add Items Request Detail"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRemoveItem1
        '
        Me.btnRemoveItem1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Close1
        Me.btnRemoveItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemoveItem1.Name = "btnRemoveItem1"
        Me.btnRemoveItem1.Size = New System.Drawing.Size(208, 22)
        Me.btnRemoveItem1.Text = "Remove Selected Item Request Detail"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel1.Text = "Number of entries :"
        '
        'lbNumEntries
        '
        Me.lbNumEntries.Name = "lbNumEntries"
        Me.lbNumEntries.Size = New System.Drawing.Size(13, 22)
        Me.lbNumEntries.Text = "0"
        '
        'ErrorRequestOrder
        '
        Me.ErrorRequestOrder.ContainerControl = Me
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(987, 569)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 41)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.btnSave.Location = New System.Drawing.Point(896, 570)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 41)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAddRequestOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 614)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddRequestOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorRequestOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbOwnerDepart As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReOrNum As System.Windows.Forms.TextBox
    Friend WithEvents cbDepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rtbDes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbUserRequest As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrorRequestOrder As System.Windows.Forms.ErrorProvider
    Friend WithEvents DGVRequestItemsDetail As System.Windows.Forms.DataGridView
    Friend WithEvents rtbComment As System.Windows.Forms.RichTextBox
    Friend WithEvents labelComment As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAddItemReDetail1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRemoveItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbNumEntries As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUnitItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaining As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cInStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
