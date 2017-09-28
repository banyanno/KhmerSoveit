<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDrug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDrug))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CboOpticalShop = New System.Windows.Forms.ComboBox
        Me.RadItemInOpticalShop = New System.Windows.Forms.RadioButton
        Me.GroupMedicineInfo = New System.Windows.Forms.GroupBox
        Me.cbItemContainer = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbLabourFac = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtUnitsInStock = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblItemUnitID = New System.Windows.Forms.Label
        Me.cbItemUnit = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.RbDrugOutsideHos = New System.Windows.Forms.RadioButton
        Me.RbDrugInHos = New System.Windows.Forms.RadioButton
        Me.cbRemark = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblItemID = New System.Windows.Forms.Label
        Me.CboItemName = New System.Windows.Forms.ComboBox
        Me.ErroAddMedicine = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupMedicineInfo.SuspendLayout()
        CType(Me.ErroAddMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CboOpticalShop)
        Me.GroupBox4.Controls.Add(Me.RadItemInOpticalShop)
        Me.GroupBox4.Controls.Add(Me.GroupMedicineInfo)
        Me.GroupBox4.Controls.Add(Me.TxtUnitsInStock)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.LblItemUnitID)
        Me.GroupBox4.Controls.Add(Me.cbItemUnit)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TxtQuantity)
        Me.GroupBox4.Controls.Add(Me.RbDrugOutsideHos)
        Me.GroupBox4.Controls.Add(Me.RbDrugInHos)
        Me.GroupBox4.Controls.Add(Me.cbRemark)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.LblItemID)
        Me.GroupBox4.Controls.Add(Me.CboItemName)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(767, 270)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Medicine Information"
        '
        'CboOpticalShop
        '
        Me.CboOpticalShop.Enabled = False
        Me.CboOpticalShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOpticalShop.FormattingEnabled = True
        Me.CboOpticalShop.Location = New System.Drawing.Point(492, 40)
        Me.CboOpticalShop.Name = "CboOpticalShop"
        Me.CboOpticalShop.Size = New System.Drawing.Size(254, 28)
        Me.CboOpticalShop.TabIndex = 30
        '
        'RadItemInOpticalShop
        '
        Me.RadItemInOpticalShop.AutoSize = True
        Me.RadItemInOpticalShop.Location = New System.Drawing.Point(492, 18)
        Me.RadItemInOpticalShop.Name = "RadItemInOpticalShop"
        Me.RadItemInOpticalShop.Size = New System.Drawing.Size(121, 17)
        Me.RadItemInOpticalShop.TabIndex = 29
        Me.RadItemInOpticalShop.TabStop = True
        Me.RadItemInOpticalShop.Text = "Item In Optical Shop"
        Me.RadItemInOpticalShop.UseVisualStyleBackColor = True
        '
        'GroupMedicineInfo
        '
        Me.GroupMedicineInfo.Controls.Add(Me.cbItemContainer)
        Me.GroupMedicineInfo.Controls.Add(Me.Label7)
        Me.GroupMedicineInfo.Controls.Add(Me.cbLabourFac)
        Me.GroupMedicineInfo.Controls.Add(Me.Label8)
        Me.GroupMedicineInfo.Controls.Add(Me.TxtItemName)
        Me.GroupMedicineInfo.Controls.Add(Me.Label6)
        Me.GroupMedicineInfo.Enabled = False
        Me.GroupMedicineInfo.Location = New System.Drawing.Point(24, 96)
        Me.GroupMedicineInfo.Name = "GroupMedicineInfo"
        Me.GroupMedicineInfo.Size = New System.Drawing.Size(422, 124)
        Me.GroupMedicineInfo.TabIndex = 28
        Me.GroupMedicineInfo.TabStop = False
        Me.GroupMedicineInfo.Text = "Medicine Outside Hospital Info"
        '
        'cbItemContainer
        '
        Me.cbItemContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItemContainer.FormattingEnabled = True
        Me.cbItemContainer.Location = New System.Drawing.Point(108, 50)
        Me.cbItemContainer.Name = "cbItemContainer"
        Me.cbItemContainer.Size = New System.Drawing.Size(298, 28)
        Me.cbItemContainer.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Item Containing : "
        '
        'cbLabourFac
        '
        Me.cbLabourFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbLabourFac.FormattingEnabled = True
        Me.cbLabourFac.Location = New System.Drawing.Point(108, 84)
        Me.cbLabourFac.Name = "cbLabourFac"
        Me.cbLabourFac.Size = New System.Drawing.Size(298, 28)
        Me.cbLabourFac.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Laboratory : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtItemName
        '
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtItemName.Location = New System.Drawing.Point(108, 19)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(298, 26)
        Me.TxtItemName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Item Name : *"
        '
        'TxtUnitsInStock
        '
        Me.TxtUnitsInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtUnitsInStock.Location = New System.Drawing.Point(683, 143)
        Me.TxtUnitsInStock.Name = "TxtUnitsInStock"
        Me.TxtUnitsInStock.ReadOnly = True
        Me.TxtUnitsInStock.Size = New System.Drawing.Size(63, 26)
        Me.TxtUnitsInStock.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(564, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Quantity In Stock: "
        '
        'LblItemUnitID
        '
        Me.LblItemUnitID.AutoSize = True
        Me.LblItemUnitID.Location = New System.Drawing.Point(600, 240)
        Me.LblItemUnitID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemUnitID.Name = "LblItemUnitID"
        Me.LblItemUnitID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemUnitID.TabIndex = 24
        Me.LblItemUnitID.Text = "0"
        Me.LblItemUnitID.Visible = False
        '
        'cbItemUnit
        '
        Me.cbItemUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItemUnit.Location = New System.Drawing.Point(682, 232)
        Me.cbItemUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.cbItemUnit.Name = "cbItemUnit"
        Me.cbItemUnit.Size = New System.Drawing.Size(64, 28)
        Me.cbItemUnit.TabIndex = 3
        Me.cbItemUnit.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(623, 240)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "UoM: *"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(474, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Quantity: *"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtQuantity.Location = New System.Drawing.Point(532, 111)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(214, 26)
        Me.TxtQuantity.TabIndex = 4
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RbDrugOutsideHos
        '
        Me.RbDrugOutsideHos.AutoSize = True
        Me.RbDrugOutsideHos.Location = New System.Drawing.Point(24, 73)
        Me.RbDrugOutsideHos.Name = "RbDrugOutsideHos"
        Me.RbDrugOutsideHos.Size = New System.Drawing.Size(148, 17)
        Me.RbDrugOutsideHos.TabIndex = 19
        Me.RbDrugOutsideHos.Text = "Medicine Outside Hospital"
        Me.RbDrugOutsideHos.UseVisualStyleBackColor = True
        '
        'RbDrugInHos
        '
        Me.RbDrugInHos.AutoSize = True
        Me.RbDrugInHos.Checked = True
        Me.RbDrugInHos.Location = New System.Drawing.Point(22, 18)
        Me.RbDrugInHos.Name = "RbDrugInHos"
        Me.RbDrugInHos.Size = New System.Drawing.Size(187, 17)
        Me.RbDrugInHos.TabIndex = 18
        Me.RbDrugInHos.TabStop = True
        Me.RbDrugInHos.Text = "Medicine in Hospital Item Name : *"
        Me.RbDrugInHos.UseVisualStyleBackColor = True
        '
        'cbRemark
        '
        Me.cbRemark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbRemark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRemark.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRemark.FormattingEnabled = True
        Me.cbRemark.Location = New System.Drawing.Point(532, 187)
        Me.cbRemark.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRemark.Name = "cbRemark"
        Me.cbRemark.Size = New System.Drawing.Size(214, 28)
        Me.cbRemark.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(474, 202)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Remark *:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(21, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Click: Enter = Add Item , F2 = Close Form"
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Location = New System.Drawing.Point(583, 240)
        Me.LblItemID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemID.TabIndex = 14
        Me.LblItemID.Text = "0"
        Me.LblItemID.Visible = False
        '
        'CboItemName
        '
        Me.CboItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboItemName.Location = New System.Drawing.Point(22, 40)
        Me.CboItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.CboItemName.Name = "CboItemName"
        Me.CboItemName.Size = New System.Drawing.Size(314, 28)
        Me.CboItemName.TabIndex = 1
        '
        'ErroAddMedicine
        '
        Me.ErroAddMedicine.ContainerControl = Me
        '
        'frmAddDrug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 286)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAddDrug"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Medicine"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupMedicineInfo.ResumeLayout(False)
        Me.GroupMedicineInfo.PerformLayout()
        CType(Me.ErroAddMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbRemark As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents CboItemName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents RbDrugOutsideHos As System.Windows.Forms.RadioButton
    Friend WithEvents RbDrugInHos As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LblItemUnitID As System.Windows.Forms.Label
    Friend WithEvents ErroAddMedicine As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtUnitsInStock As System.Windows.Forms.TextBox
    Friend WithEvents cbItemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupMedicineInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cbItemContainer As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbLabourFac As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RadItemInOpticalShop As System.Windows.Forms.RadioButton
    Friend WithEvents CboOpticalShop As System.Windows.Forms.ComboBox
End Class
