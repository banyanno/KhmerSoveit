<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddItemInOpticalShop
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtBarcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblItemID = New System.Windows.Forms.Label
        Me.PictItem = New System.Windows.Forms.PictureBox
        Me.TxtItemPrice = New System.Windows.Forms.TextBox
        Me.LblPrice = New System.Windows.Forms.Label
        Me.TxtItemQTY = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ErrReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtUnitInstock = New System.Windows.Forms.TextBox
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtUnitInstock)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TxtBarcode)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.LblItemID)
        Me.GroupBox4.Controls.Add(Me.PictItem)
        Me.GroupBox4.Controls.Add(Me.TxtItemPrice)
        Me.GroupBox4.Controls.Add(Me.LblPrice)
        Me.GroupBox4.Controls.Add(Me.TxtItemQTY)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TxtItemName)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(379, 259)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item Information"
        '
        'TxtBarcode
        '
        Me.TxtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcode.Location = New System.Drawing.Point(85, 17)
        Me.TxtBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBarcode.Name = "TxtBarcode"
        Me.TxtBarcode.Size = New System.Drawing.Size(274, 26)
        Me.TxtBarcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(4, 242)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Click: Enter = Add Item , F2 = Close Form"
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Location = New System.Drawing.Point(16, 166)
        Me.LblItemID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemID.TabIndex = 14
        Me.LblItemID.Text = "0"
        Me.LblItemID.Visible = False
        '
        'PictItem
        '
        Me.PictItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictItem.Location = New System.Drawing.Point(84, 173)
        Me.PictItem.Margin = New System.Windows.Forms.Padding(2)
        Me.PictItem.Name = "PictItem"
        Me.PictItem.Size = New System.Drawing.Size(274, 67)
        Me.PictItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictItem.TabIndex = 8
        Me.PictItem.TabStop = False
        '
        'TxtItemPrice
        '
        Me.TxtItemPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemPrice.Location = New System.Drawing.Point(85, 80)
        Me.TxtItemPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemPrice.Name = "TxtItemPrice"
        Me.TxtItemPrice.ReadOnly = True
        Me.TxtItemPrice.Size = New System.Drawing.Size(274, 26)
        Me.TxtItemPrice.TabIndex = 2
        Me.TxtItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(4, 89)
        Me.LblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(56, 13)
        Me.LblPrice.TabIndex = 3
        Me.LblPrice.Text = "Price ($): *"
        '
        'TxtItemQTY
        '
        Me.TxtItemQTY.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtItemQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemQTY.Location = New System.Drawing.Point(85, 110)
        Me.TxtItemQTY.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemQTY.Name = "TxtItemQTY"
        Me.TxtItemQTY.Size = New System.Drawing.Size(274, 26)
        Me.TxtItemQTY.TabIndex = 3
        Me.TxtItemQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 119)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Quantity: *"
        '
        'TxtItemName
        '
        Me.TxtItemName.BackColor = System.Drawing.Color.White
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(85, 50)
        Me.TxtItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.ReadOnly = True
        Me.TxtItemName.Size = New System.Drawing.Size(274, 26)
        Me.TxtItemName.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 59)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Item Name: *"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 25)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Item Barcode: *"
        '
        'ErrReceipt
        '
        Me.ErrReceipt.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Unit In Stock:"
        '
        'TxtUnitInstock
        '
        Me.TxtUnitInstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUnitInstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnitInstock.Location = New System.Drawing.Point(84, 143)
        Me.TxtUnitInstock.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUnitInstock.Name = "TxtUnitInstock"
        Me.TxtUnitInstock.ReadOnly = True
        Me.TxtUnitInstock.Size = New System.Drawing.Size(274, 26)
        Me.TxtUnitInstock.TabIndex = 17
        Me.TxtUnitInstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmAddItemInOpticalShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddItemInOpticalShop"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Item"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictItem As System.Windows.Forms.PictureBox
    Friend WithEvents TxtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents TxtItemQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents ErrReceipt As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnitInstock As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
