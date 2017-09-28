<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCaritasRequestOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCaritasRequestOrder))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChDateTo = New System.Windows.Forms.DateTimePicker
        Me.ChDateFrom = New System.Windows.Forms.DateTimePicker
        Me.DateUsedTo = New System.Windows.Forms.Label
        Me.DateUsedFrom = New System.Windows.Forms.Label
        Me.rtbComment = New System.Windows.Forms.RichTextBox
        Me.labelComment = New System.Windows.Forms.Label
        Me.lbUserRequest = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpRDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtReOrNum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGVRequestItemsDetail = New System.Windows.Forms.DataGridView
        Me.cItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnAddItemReDetail = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRemoveItem = New System.Windows.Forms.ToolStripButton
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.ErrRequest = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1029, 676)
        Me.SplitContainer1.SplitterDistance = 181
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChDateTo)
        Me.GroupBox1.Controls.Add(Me.ChDateFrom)
        Me.GroupBox1.Controls.Add(Me.DateUsedTo)
        Me.GroupBox1.Controls.Add(Me.DateUsedFrom)
        Me.GroupBox1.Controls.Add(Me.rtbComment)
        Me.GroupBox1.Controls.Add(Me.labelComment)
        Me.GroupBox1.Controls.Add(Me.lbUserRequest)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpRDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtReOrNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1029, 181)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request Info"
        '
        'ChDateTo
        '
        Me.ChDateTo.Checked = False
        Me.ChDateTo.CustomFormat = "dd/MM/yyyy"
        Me.ChDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ChDateTo.Location = New System.Drawing.Point(717, 80)
        Me.ChDateTo.Name = "ChDateTo"
        Me.ChDateTo.ShowCheckBox = True
        Me.ChDateTo.Size = New System.Drawing.Size(145, 26)
        Me.ChDateTo.TabIndex = 22
        '
        'ChDateFrom
        '
        Me.ChDateFrom.Checked = False
        Me.ChDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.ChDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ChDateFrom.Location = New System.Drawing.Point(717, 45)
        Me.ChDateFrom.Name = "ChDateFrom"
        Me.ChDateFrom.ShowCheckBox = True
        Me.ChDateFrom.Size = New System.Drawing.Size(145, 26)
        Me.ChDateFrom.TabIndex = 21
        '
        'DateUsedTo
        '
        Me.DateUsedTo.AutoSize = True
        Me.DateUsedTo.ForeColor = System.Drawing.Color.Red
        Me.DateUsedTo.Location = New System.Drawing.Point(609, 87)
        Me.DateUsedTo.Name = "DateUsedTo"
        Me.DateUsedTo.Size = New System.Drawing.Size(92, 13)
        Me.DateUsedTo.TabIndex = 20
        Me.DateUsedTo.Text = "Date Request To:"
        '
        'DateUsedFrom
        '
        Me.DateUsedFrom.AutoSize = True
        Me.DateUsedFrom.ForeColor = System.Drawing.Color.Red
        Me.DateUsedFrom.Location = New System.Drawing.Point(609, 51)
        Me.DateUsedFrom.Name = "DateUsedFrom"
        Me.DateUsedFrom.Size = New System.Drawing.Size(102, 13)
        Me.DateUsedFrom.TabIndex = 19
        Me.DateUsedFrom.Text = "Date Request From:"
        '
        'rtbComment
        '
        Me.rtbComment.BackColor = System.Drawing.SystemColors.Window
        Me.rtbComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbComment.Location = New System.Drawing.Point(183, 109)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.Size = New System.Drawing.Size(395, 67)
        Me.rtbComment.TabIndex = 18
        Me.rtbComment.Text = ""
        '
        'labelComment
        '
        Me.labelComment.AutoSize = True
        Me.labelComment.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelComment.Location = New System.Drawing.Point(12, 119)
        Me.labelComment.Name = "labelComment"
        Me.labelComment.Size = New System.Drawing.Size(74, 20)
        Me.labelComment.TabIndex = 17
        Me.labelComment.Text = "Comment :"
        '
        'lbUserRequest
        '
        Me.lbUserRequest.BackColor = System.Drawing.Color.White
        Me.lbUserRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbUserRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserRequest.Location = New System.Drawing.Point(183, 20)
        Me.lbUserRequest.Name = "lbUserRequest"
        Me.lbUserRequest.Size = New System.Drawing.Size(395, 26)
        Me.lbUserRequest.TabIndex = 15
        Me.lbUserRequest.Text = "Chan Vibol"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Request Creator :"
        '
        'dtpRDate
        '
        Me.dtpRDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate.Enabled = False
        Me.dtpRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate.Location = New System.Drawing.Point(183, 77)
        Me.dtpRDate.Name = "dtpRDate"
        Me.dtpRDate.Size = New System.Drawing.Size(395, 26)
        Me.dtpRDate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Request Order Date :"
        '
        'txtReOrNum
        '
        Me.txtReOrNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReOrNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReOrNum.Enabled = False
        Me.txtReOrNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReOrNum.Location = New System.Drawing.Point(183, 48)
        Me.txtReOrNum.Name = "txtReOrNum"
        Me.txtReOrNum.Size = New System.Drawing.Size(395, 26)
        Me.txtReOrNum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Request Order Number :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVRequestItemsDetail)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1029, 466)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Detail Item Info"
        '
        'DGVRequestItemsDetail
        '
        Me.DGVRequestItemsDetail.AllowUserToAddRows = False
        Me.DGVRequestItemsDetail.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVRequestItemsDetail.ColumnHeadersHeight = 30
        Me.DGVRequestItemsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVRequestItemsDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemNo, Me.cItemName, Me.cRQuantity, Me.cBarcode})
        Me.DGVRequestItemsDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVRequestItemsDetail.Location = New System.Drawing.Point(3, 16)
        Me.DGVRequestItemsDetail.MultiSelect = False
        Me.DGVRequestItemsDetail.Name = "DGVRequestItemsDetail"
        Me.DGVRequestItemsDetail.RowTemplate.Height = 24
        Me.DGVRequestItemsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRequestItemsDetail.Size = New System.Drawing.Size(1023, 447)
        Me.DGVRequestItemsDetail.TabIndex = 24
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
        'cRQuantity
        '
        Me.cRQuantity.DataPropertyName = "RequestQuantity"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
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
        Me.cBarcode.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddItemReDetail, Me.ToolStripSeparator1, Me.btnRemoveItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1029, 25)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddItemReDetail
        '
        Me.btnAddItemReDetail.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.btnAddItemReDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddItemReDetail.Name = "btnAddItemReDetail"
        Me.btnAddItemReDetail.Size = New System.Drawing.Size(149, 22)
        Me.btnAddItemReDetail.Text = "Add Items Request Detail"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Close1
        Me.btnRemoveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(208, 22)
        Me.btnRemoveItem.Text = "Remove Selected Item Request Detail"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(941, 682)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 33)
        Me.btnCancel.TabIndex = 39
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
        Me.btnSave.Location = New System.Drawing.Point(850, 682)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 33)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrRequest
        '
        Me.ErrRequest.ContainerControl = Me
        '
        'frmAddCaritasRequestOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 727)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddCaritasRequestOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caritas Request Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rtbComment As System.Windows.Forms.RichTextBox
    Friend WithEvents labelComment As System.Windows.Forms.Label
    Friend WithEvents lbUserRequest As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReOrNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAddItemReDetail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRemoveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DGVRequestItemsDetail As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateUsedTo As System.Windows.Forms.Label
    Friend WithEvents DateUsedFrom As System.Windows.Forms.Label
    Friend WithEvents ChDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrRequest As System.Windows.Forms.ErrorProvider
End Class
