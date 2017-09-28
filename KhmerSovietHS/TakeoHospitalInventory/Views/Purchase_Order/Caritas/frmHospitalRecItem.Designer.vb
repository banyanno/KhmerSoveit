<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHospitalRecItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHospitalRecItem))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.BtnRegisterItem = New Janus.Windows.EditControls.UIButton
        Me.dtpRDate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.LbComment = New System.Windows.Forms.Label
        Me.LbReqOrderDate = New System.Windows.Forms.Label
        Me.LbReqOrderNum = New System.Windows.Forms.Label
        Me.LbReqCreator = New System.Windows.Forms.Label
        Me.LabelComment = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DGVRequestItemsDetail = New System.Windows.Forms.DataGridView
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LbInstruction2 = New System.Windows.Forms.Label
        Me.LbInstruction1 = New System.Windows.Forms.Label
        Me.CIsReceive = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRequestDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cReceived = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cExpiredDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsReady = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.dtpRDate)
        Me.UiGroupBox1.Controls.Add(Me.Label10)
        Me.UiGroupBox1.Controls.Add(Me.LbComment)
        Me.UiGroupBox1.Controls.Add(Me.LbReqOrderDate)
        Me.UiGroupBox1.Controls.Add(Me.LbReqOrderNum)
        Me.UiGroupBox1.Controls.Add(Me.LbReqCreator)
        Me.UiGroupBox1.Controls.Add(Me.LabelComment)
        Me.UiGroupBox1.Controls.Add(Me.Label9)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(520, 187)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Request Information"
        '
        'BtnRegisterItem
        '
        Me.BtnRegisterItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegisterItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegisterItem.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegisterItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.BtnRegisterItem.Location = New System.Drawing.Point(869, 205)
        Me.BtnRegisterItem.Name = "BtnRegisterItem"
        Me.BtnRegisterItem.Size = New System.Drawing.Size(34, 34)
        Me.BtnRegisterItem.TabIndex = 43
        Me.BtnRegisterItem.ToolTipText = "Add Item"
        '
        'dtpRDate
        '
        Me.dtpRDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate.Enabled = False
        Me.dtpRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate.Location = New System.Drawing.Point(190, 107)
        Me.dtpRDate.Name = "dtpRDate"
        Me.dtpRDate.Size = New System.Drawing.Size(242, 26)
        Me.dtpRDate.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Received Date :"
        '
        'LbComment
        '
        Me.LbComment.BackColor = System.Drawing.Color.Transparent
        Me.LbComment.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbComment.Location = New System.Drawing.Point(190, 137)
        Me.LbComment.Name = "LbComment"
        Me.LbComment.Size = New System.Drawing.Size(324, 43)
        Me.LbComment.TabIndex = 30
        Me.LbComment.Text = "Request Creator :"
        '
        'LbReqOrderDate
        '
        Me.LbReqOrderDate.AutoSize = True
        Me.LbReqOrderDate.BackColor = System.Drawing.Color.Transparent
        Me.LbReqOrderDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReqOrderDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbReqOrderDate.Location = New System.Drawing.Point(190, 83)
        Me.LbReqOrderDate.Name = "LbReqOrderDate"
        Me.LbReqOrderDate.Size = New System.Drawing.Size(114, 20)
        Me.LbReqOrderDate.TabIndex = 29
        Me.LbReqOrderDate.Text = "Request Creator :"
        '
        'LbReqOrderNum
        '
        Me.LbReqOrderNum.AutoSize = True
        Me.LbReqOrderNum.BackColor = System.Drawing.Color.Transparent
        Me.LbReqOrderNum.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReqOrderNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbReqOrderNum.Location = New System.Drawing.Point(190, 55)
        Me.LbReqOrderNum.Name = "LbReqOrderNum"
        Me.LbReqOrderNum.Size = New System.Drawing.Size(114, 20)
        Me.LbReqOrderNum.TabIndex = 28
        Me.LbReqOrderNum.Text = "Request Creator :"
        '
        'LbReqCreator
        '
        Me.LbReqCreator.AutoSize = True
        Me.LbReqCreator.BackColor = System.Drawing.Color.Transparent
        Me.LbReqCreator.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReqCreator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbReqCreator.Location = New System.Drawing.Point(190, 27)
        Me.LbReqCreator.Name = "LbReqCreator"
        Me.LbReqCreator.Size = New System.Drawing.Size(114, 20)
        Me.LbReqCreator.TabIndex = 27
        Me.LbReqCreator.Text = "Request Creator :"
        '
        'LabelComment
        '
        Me.LabelComment.AutoSize = True
        Me.LabelComment.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComment.Location = New System.Drawing.Point(21, 137)
        Me.LabelComment.Name = "LabelComment"
        Me.LabelComment.Size = New System.Drawing.Size(74, 20)
        Me.LabelComment.TabIndex = 26
        Me.LabelComment.Text = "Comment :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Request Creator :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Request Order Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Request Order Number :"
        '
        'DGVRequestItemsDetail
        '
        Me.DGVRequestItemsDetail.AllowUserToAddRows = False
        Me.DGVRequestItemsDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVRequestItemsDetail.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVRequestItemsDetail.ColumnHeadersHeight = 35
        Me.DGVRequestItemsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVRequestItemsDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIsReceive, Me.cBarcode, Me.cRequestDetailID, Me.cItemNo, Me.cItemName, Me.cRQuantity, Me.cReceived, Me.cExpiredDate, Me.IsReady})
        Me.DGVRequestItemsDetail.Location = New System.Drawing.Point(12, 205)
        Me.DGVRequestItemsDetail.MultiSelect = False
        Me.DGVRequestItemsDetail.Name = "DGVRequestItemsDetail"
        Me.DGVRequestItemsDetail.RowTemplate.Height = 24
        Me.DGVRequestItemsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRequestItemsDetail.Size = New System.Drawing.Size(851, 418)
        Me.DGVRequestItemsDetail.TabIndex = 25
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Close1
        Me.btnCancel.Location = New System.Drawing.Point(778, 629)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 41)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Close"
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
        Me.btnSave.Location = New System.Drawing.Point(591, 630)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(179, 41)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save and Waiting Approval"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbInstruction2)
        Me.GroupBox1.Controls.Add(Me.LbInstruction1)
        Me.GroupBox1.Location = New System.Drawing.Point(546, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 186)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Note"
        '
        'LbInstruction2
        '
        Me.LbInstruction2.BackColor = System.Drawing.Color.Transparent
        Me.LbInstruction2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruction2.ForeColor = System.Drawing.Color.Blue
        Me.LbInstruction2.Location = New System.Drawing.Point(11, 26)
        Me.LbInstruction2.Name = "LbInstruction2"
        Me.LbInstruction2.Size = New System.Drawing.Size(306, 64)
        Me.LbInstruction2.TabIndex = 27
        Me.LbInstruction2.Text = "1. Click Button Add Item to register new item in case received new item."
        '
        'LbInstruction1
        '
        Me.LbInstruction1.BackColor = System.Drawing.Color.Transparent
        Me.LbInstruction1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruction1.ForeColor = System.Drawing.Color.Blue
        Me.LbInstruction1.Location = New System.Drawing.Point(11, 90)
        Me.LbInstruction1.Name = "LbInstruction1"
        Me.LbInstruction1.Size = New System.Drawing.Size(306, 64)
        Me.LbInstruction1.TabIndex = 26
        Me.LbInstruction1.Text = "2. Double Click Table Row For Input Received Item Quantity , Cost , Expired Date"
        '
        'CIsReceive
        '
        Me.CIsReceive.HeaderText = ""
        Me.CIsReceive.Name = "CIsReceive"
        Me.CIsReceive.Width = 30
        '
        'cBarcode
        '
        Me.cBarcode.HeaderText = "Barcode"
        Me.cBarcode.Name = "cBarcode"
        Me.cBarcode.ReadOnly = True
        '
        'cRequestDetailID
        '
        Me.cRequestDetailID.HeaderText = "RequestDetailID"
        Me.cRequestDetailID.Name = "cRequestDetailID"
        Me.cRequestDetailID.ReadOnly = True
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
        Me.cRQuantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cRQuantity.DefaultCellStyle = DataGridViewCellStyle1
        Me.cRQuantity.HeaderText = "Request Quantity"
        Me.cRQuantity.Name = "cRQuantity"
        Me.cRQuantity.Width = 150
        '
        'cReceived
        '
        Me.cReceived.HeaderText = "Received Qunatity"
        Me.cReceived.Name = "cReceived"
        Me.cReceived.ReadOnly = True
        Me.cReceived.Width = 150
        '
        'cExpiredDate
        '
        Me.cExpiredDate.HeaderText = "Expired Date"
        Me.cExpiredDate.Name = "cExpiredDate"
        Me.cExpiredDate.ReadOnly = True
        Me.cExpiredDate.Visible = False
        '
        'IsReady
        '
        Me.IsReady.HeaderText = "Ready Received"
        Me.IsReady.Name = "IsReady"
        Me.IsReady.ReadOnly = True
        Me.IsReady.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsReady.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmHospitalRecItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 677)
        Me.Controls.Add(Me.BtnRegisterItem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DGVRequestItemsDetail)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHospitalRecItem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hospital Received Item"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.DGVRequestItemsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents LabelComment As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbComment As System.Windows.Forms.Label
    Friend WithEvents LbReqOrderDate As System.Windows.Forms.Label
    Friend WithEvents LbReqOrderNum As System.Windows.Forms.Label
    Friend WithEvents LbReqCreator As System.Windows.Forms.Label
    Friend WithEvents DGVRequestItemsDetail As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbInstruction1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbInstruction2 As System.Windows.Forms.Label
    Friend WithEvents BtnRegisterItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents CIsReceive As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRequestDetailID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cReceived As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cExpiredDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsReady As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
