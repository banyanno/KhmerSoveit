<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewReceipt
    Inherits System.Windows.Forms.Form


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewReceipt))
        Me.DateCreateReceipt = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblCombindReferal = New System.Windows.Forms.Label
        Me.CheOldPatient = New System.Windows.Forms.CheckBox
        Me.TxtCusNameEng = New System.Windows.Forms.TextBox
        Me.BtnSelectPatient = New Janus.Windows.EditControls.UIButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnCleanCustomer = New Janus.Windows.EditControls.UIButton
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.TxtSex = New System.Windows.Forms.TextBox
        Me.TxtCusOccupation = New System.Windows.Forms.TextBox
        Me.TxtCustomerName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnAddCustomer = New Janus.Windows.EditControls.UIButton
        Me.TxtCustomerID = New System.Windows.Forms.TextBox
        Me.GridItemDetail = New System.Windows.Forms.DataGridView
        Me.ColumnItemID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnQTY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotalDolar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Picture = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GPIncomeType = New System.Windows.Forms.GroupBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.LblConsultID = New System.Windows.Forms.Label
        Me.LblSendBy = New System.Windows.Forms.Label
        Me.lblConsultFor = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.LblConsultDate = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.LblConsultType = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.RadLV = New System.Windows.Forms.RadioButton
        Me.RadCustomerMadeSpectacle = New System.Windows.Forms.RadioButton
        Me.RadReadyMadeSpectacle = New System.Windows.Forms.RadioButton
        Me.RadSunGlasses = New System.Windows.Forms.RadioButton
        Me.LblSaveStatus = New System.Windows.Forms.Label
        Me.TxtCustomerNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.RadOther = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cmdAddRate = New System.Windows.Forms.Button
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.ChDonation = New System.Windows.Forms.CheckBox
        Me.RadFundRaising = New System.Windows.Forms.RadioButton
        Me.RadMedicine = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtDonateAmount = New System.Windows.Forms.TextBox
        Me.CboDonation = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GBoxCustomerMade = New System.Windows.Forms.GroupBox
        Me.RadDistance1 = New System.Windows.Forms.RadioButton
        Me.RadRedding1 = New System.Windows.Forms.RadioButton
        Me.RadBifocal = New System.Windows.Forms.RadioButton
        Me.GBoxReadyMade = New System.Windows.Forms.GroupBox
        Me.RadDistance2 = New System.Windows.Forms.RadioButton
        Me.RadRedding2 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtTotalAsReal = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtTotalAsDolar = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnAddItem = New System.Windows.Forms.Button
        Me.BtnRemoveItem = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnSaveReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.LblTotalConsult = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LblReceiptID = New System.Windows.Forms.Label
        Me.GBPaymentType = New System.Windows.Forms.GroupBox
        Me.GroupPayCorrency = New System.Windows.Forms.GroupBox
        Me.RadKHR = New System.Windows.Forms.RadioButton
        Me.RadUSD = New System.Windows.Forms.RadioButton
        Me.TxtSocialAmount = New System.Windows.Forms.TextBox
        Me.TxtNilAmount = New System.Windows.Forms.TextBox
        Me.TxtFullAmount = New System.Windows.Forms.TextBox
        Me.RadNil = New System.Windows.Forms.RadioButton
        Me.RadSocial = New System.Windows.Forms.RadioButton
        Me.RadFull = New System.Windows.Forms.RadioButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TxtNumGlasses = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ChbNewGlasses = New System.Windows.Forms.CheckBox
        Me.TxtReceiptNo = New System.Windows.Forms.Label
        Me.ChPrintPreview = New System.Windows.Forms.CheckBox
        Me.TxtGetBarcode = New System.Windows.Forms.TextBox
        Me.ErrReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgSaveAndPrinting = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GPIncomeType.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GBoxCustomerMade.SuspendLayout()
        Me.GBoxReadyMade.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBPaymentType.SuspendLayout()
        Me.GroupPayCorrency.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateCreateReceipt
        '
        Me.DateCreateReceipt.Checked = False
        Me.DateCreateReceipt.CustomFormat = "dd/MM/yyyy"
        Me.DateCreateReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreateReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCreateReceipt.Location = New System.Drawing.Point(95, 16)
        Me.DateCreateReceipt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateCreateReceipt.Name = "DateCreateReceipt"
        Me.DateCreateReceipt.ShowCheckBox = True
        Me.DateCreateReceipt.Size = New System.Drawing.Size(130, 26)
        Me.DateCreateReceipt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Invoice Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(5, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Invoice No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblCombindReferal)
        Me.GroupBox1.Controls.Add(Me.CheOldPatient)
        Me.GroupBox1.Controls.Add(Me.TxtCusNameEng)
        Me.GroupBox1.Controls.Add(Me.BtnSelectPatient)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnCleanCustomer)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtSex)
        Me.GroupBox1.Controls.Add(Me.TxtCusOccupation)
        Me.GroupBox1.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnAddCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(542, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Informatrion"
        '
        'LblCombindReferal
        '
        Me.LblCombindReferal.AutoSize = True
        Me.LblCombindReferal.Location = New System.Drawing.Point(9, 121)
        Me.LblCombindReferal.Name = "LblCombindReferal"
        Me.LblCombindReferal.Size = New System.Drawing.Size(82, 13)
        Me.LblCombindReferal.TabIndex = 11
        Me.LblCombindReferal.Text = "CombindReferal"
        Me.LblCombindReferal.Visible = False
        '
        'CheOldPatient
        '
        Me.CheOldPatient.AutoSize = True
        Me.CheOldPatient.BackColor = System.Drawing.SystemColors.Control
        Me.CheOldPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheOldPatient.ForeColor = System.Drawing.Color.Red
        Me.CheOldPatient.Location = New System.Drawing.Point(7, 141)
        Me.CheOldPatient.Name = "CheOldPatient"
        Me.CheOldPatient.Size = New System.Drawing.Size(117, 24)
        Me.CheOldPatient.TabIndex = 10
        Me.CheOldPatient.Text = "Old Patient"
        Me.CheOldPatient.UseVisualStyleBackColor = False
        '
        'TxtCusNameEng
        '
        Me.TxtCusNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.TxtCusNameEng.Location = New System.Drawing.Point(309, 21)
        Me.TxtCusNameEng.Name = "TxtCusNameEng"
        Me.TxtCusNameEng.Size = New System.Drawing.Size(217, 33)
        Me.TxtCusNameEng.TabIndex = 1
        '
        'BtnSelectPatient
        '
        Me.BtnSelectPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelectPatient.Location = New System.Drawing.Point(136, 136)
        Me.BtnSelectPatient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSelectPatient.Name = "BtnSelectPatient"
        Me.BtnSelectPatient.Size = New System.Drawing.Size(119, 34)
        Me.BtnSelectPatient.TabIndex = 6
        Me.BtnSelectPatient.Text = "Select New Patient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name:"
        '
        'BtnCleanCustomer
        '
        Me.BtnCleanCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCleanCustomer.Location = New System.Drawing.Point(425, 135)
        Me.BtnCleanCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCleanCustomer.Name = "BtnCleanCustomer"
        Me.BtnCleanCustomer.Size = New System.Drawing.Size(109, 35)
        Me.BtnCleanCustomer.TabIndex = 8
        Me.BtnCleanCustomer.Text = "Clean Cus-info"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(72, 89)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(456, 37)
        Me.txtAddress.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Occupation:"
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.White
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(447, 57)
        Me.TxtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(79, 26)
        Me.TxtAge.TabIndex = 4
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.Color.White
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.Location = New System.Drawing.Point(300, 58)
        Me.TxtSex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.ReadOnly = True
        Me.TxtSex.Size = New System.Drawing.Size(48, 26)
        Me.TxtSex.TabIndex = 3
        '
        'TxtCusOccupation
        '
        Me.TxtCusOccupation.BackColor = System.Drawing.Color.White
        Me.TxtCusOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusOccupation.Location = New System.Drawing.Point(72, 59)
        Me.TxtCusOccupation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCusOccupation.Name = "TxtCusOccupation"
        Me.TxtCusOccupation.ReadOnly = True
        Me.TxtCusOccupation.Size = New System.Drawing.Size(169, 26)
        Me.TxtCusOccupation.TabIndex = 2
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.White
        Me.TxtCustomerName.Font = New System.Drawing.Font("Limon S1", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(72, 21)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(230, 33)
        Me.TxtCustomerName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(391, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sex:"
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCustomer.Location = New System.Drawing.Point(259, 135)
        Me.BtnAddCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.Size = New System.Drawing.Size(161, 35)
        Me.BtnAddCustomer.TabIndex = 7
        Me.BtnAddCustomer.Text = "Select New Customer And Old Patient"
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.White
        Me.TxtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerID.Location = New System.Drawing.Point(382, 18)
        Me.TxtCustomerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(73, 26)
        Me.TxtCustomerID.TabIndex = 1
        Me.TxtCustomerID.Visible = False
        '
        'GridItemDetail
        '
        Me.GridItemDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.GridItemDetail.AllowUserToAddRows = False
        Me.GridItemDetail.AllowUserToDeleteRows = False
        Me.GridItemDetail.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GridItemDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridItemDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnItemID, Me.ColumnBarcode, Me.ColumnName, Me.ColumnPrice, Me.ColumnQTY, Me.SubTotal, Me.SubTotalDolar, Me.Picture})
        Me.GridItemDetail.Location = New System.Drawing.Point(11, 217)
        Me.GridItemDetail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridItemDetail.Name = "GridItemDetail"
        Me.GridItemDetail.ReadOnly = True
        Me.GridItemDetail.RowTemplate.Height = 30
        Me.GridItemDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridItemDetail.Size = New System.Drawing.Size(1101, 221)
        Me.GridItemDetail.TabIndex = 3
        '
        'ColumnItemID
        '
        Me.ColumnItemID.DataPropertyName = "ColumnItemID"
        Me.ColumnItemID.HeaderText = "ColumnItemID"
        Me.ColumnItemID.Name = "ColumnItemID"
        Me.ColumnItemID.ReadOnly = True
        Me.ColumnItemID.Visible = False
        Me.ColumnItemID.Width = 50
        '
        'ColumnBarcode
        '
        Me.ColumnBarcode.DataPropertyName = "ColumnBarcode"
        Me.ColumnBarcode.HeaderText = "Barcode"
        Me.ColumnBarcode.Name = "ColumnBarcode"
        Me.ColumnBarcode.ReadOnly = True
        Me.ColumnBarcode.Width = 200
        '
        'ColumnName
        '
        Me.ColumnName.DataPropertyName = "ColumnName"
        Me.ColumnName.HeaderText = "Name"
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.ReadOnly = True
        Me.ColumnName.Width = 200
        '
        'ColumnPrice
        '
        Me.ColumnPrice.DataPropertyName = "ColumnPrice"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColumnPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColumnPrice.HeaderText = "Price"
        Me.ColumnPrice.Name = "ColumnPrice"
        Me.ColumnPrice.ReadOnly = True
        '
        'ColumnQTY
        '
        Me.ColumnQTY.DataPropertyName = "ColumnQTY"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColumnQTY.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnQTY.HeaderText = "Quality"
        Me.ColumnQTY.Name = "ColumnQTY"
        Me.ColumnQTY.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotalReal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "R"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubTotal.HeaderText = "Sub Total R"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 150
        '
        'SubTotalDolar
        '
        Me.SubTotalDolar.DataPropertyName = "SubTotalDolar"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SubTotalDolar.DefaultCellStyle = DataGridViewCellStyle4
        Me.SubTotalDolar.HeaderText = "Sub Total $"
        Me.SubTotalDolar.Name = "SubTotalDolar"
        Me.SubTotalDolar.ReadOnly = True
        Me.SubTotalDolar.Width = 150
        '
        'Picture
        '
        Me.Picture.DataPropertyName = "Picture"
        Me.Picture.HeaderText = "Picture"
        Me.Picture.Name = "Picture"
        Me.Picture.ReadOnly = True
        Me.Picture.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GPIncomeType)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 442)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1101, 238)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "In payment for"
        '
        'GPIncomeType
        '
        Me.GPIncomeType.Controls.Add(Me.GroupBox10)
        Me.GPIncomeType.Controls.Add(Me.RadLV)
        Me.GPIncomeType.Controls.Add(Me.RadCustomerMadeSpectacle)
        Me.GPIncomeType.Controls.Add(Me.RadReadyMadeSpectacle)
        Me.GPIncomeType.Controls.Add(Me.RadSunGlasses)
        Me.GPIncomeType.Controls.Add(Me.LblSaveStatus)
        Me.GPIncomeType.Controls.Add(Me.TxtCustomerNo)
        Me.GPIncomeType.Controls.Add(Me.Label7)
        Me.GPIncomeType.Controls.Add(Me.RadOther)
        Me.GPIncomeType.Controls.Add(Me.TxtCustomerID)
        Me.GPIncomeType.Controls.Add(Me.GroupBox8)
        Me.GPIncomeType.Controls.Add(Me.ChDonation)
        Me.GPIncomeType.Controls.Add(Me.RadFundRaising)
        Me.GPIncomeType.Controls.Add(Me.RadMedicine)
        Me.GPIncomeType.Controls.Add(Me.GroupBox5)
        Me.GPIncomeType.Controls.Add(Me.GBoxCustomerMade)
        Me.GPIncomeType.Controls.Add(Me.GBoxReadyMade)
        Me.GPIncomeType.Location = New System.Drawing.Point(8, 75)
        Me.GPIncomeType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPIncomeType.Name = "GPIncomeType"
        Me.GPIncomeType.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPIncomeType.Size = New System.Drawing.Size(1087, 155)
        Me.GPIncomeType.TabIndex = 2
        Me.GPIncomeType.TabStop = False
        Me.GPIncomeType.Text = "Select In payment for"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.LblConsultID)
        Me.GroupBox10.Controls.Add(Me.LblSendBy)
        Me.GroupBox10.Controls.Add(Me.lblConsultFor)
        Me.GroupBox10.Controls.Add(Me.Label24)
        Me.GroupBox10.Controls.Add(Me.LblConsultDate)
        Me.GroupBox10.Controls.Add(Me.Label25)
        Me.GroupBox10.Controls.Add(Me.Label26)
        Me.GroupBox10.Controls.Add(Me.LblConsultType)
        Me.GroupBox10.Controls.Add(Me.Label27)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Red
        Me.GroupBox10.Location = New System.Drawing.Point(853, 13)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(225, 136)
        Me.GroupBox10.TabIndex = 211
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Information From Consult"
        '
        'LblConsultID
        '
        Me.LblConsultID.AutoSize = True
        Me.LblConsultID.Location = New System.Drawing.Point(188, 23)
        Me.LblConsultID.Name = "LblConsultID"
        Me.LblConsultID.Size = New System.Drawing.Size(17, 17)
        Me.LblConsultID.TabIndex = 8
        Me.LblConsultID.Text = "0"
        Me.LblConsultID.Visible = False
        '
        'LblSendBy
        '
        Me.LblSendBy.AutoSize = True
        Me.LblSendBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSendBy.ForeColor = System.Drawing.Color.Red
        Me.LblSendBy.Location = New System.Drawing.Point(100, 108)
        Me.LblSendBy.Name = "LblSendBy"
        Me.LblSendBy.Size = New System.Drawing.Size(77, 17)
        Me.LblSendBy.TabIndex = 7
        Me.LblSendBy.Text = "No Consult"
        '
        'lblConsultFor
        '
        Me.lblConsultFor.AutoSize = True
        Me.lblConsultFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultFor.ForeColor = System.Drawing.Color.Red
        Me.lblConsultFor.Location = New System.Drawing.Point(100, 80)
        Me.lblConsultFor.Name = "lblConsultFor"
        Me.lblConsultFor.Size = New System.Drawing.Size(77, 17)
        Me.lblConsultFor.TabIndex = 6
        Me.lblConsultFor.Text = "No Consult"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(6, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 17)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Consult For:"
        '
        'LblConsultDate
        '
        Me.LblConsultDate.AutoSize = True
        Me.LblConsultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultDate.ForeColor = System.Drawing.Color.Red
        Me.LblConsultDate.Location = New System.Drawing.Point(100, 26)
        Me.LblConsultDate.Name = "LblConsultDate"
        Me.LblConsultDate.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultDate.TabIndex = 4
        Me.LblConsultDate.Text = "No Consult"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(6, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 17)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Date Consult:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(6, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 17)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Consult By:"
        '
        'LblConsultType
        '
        Me.LblConsultType.AutoSize = True
        Me.LblConsultType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultType.ForeColor = System.Drawing.Color.Red
        Me.LblConsultType.Location = New System.Drawing.Point(100, 53)
        Me.LblConsultType.Name = "LblConsultType"
        Me.LblConsultType.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultType.TabIndex = 1
        Me.LblConsultType.Text = "No Consult"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(6, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 17)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Consult Type:"
        '
        'RadLV
        '
        Me.RadLV.AutoSize = True
        Me.RadLV.Location = New System.Drawing.Point(284, 96)
        Me.RadLV.Name = "RadLV"
        Me.RadLV.Size = New System.Drawing.Size(75, 17)
        Me.RadLV.TabIndex = 6
        Me.RadLV.TabStop = True
        Me.RadLV.Tag = "7"
        Me.RadLV.Text = "LV Device"
        Me.RadLV.UseVisualStyleBackColor = True
        '
        'RadCustomerMadeSpectacle
        '
        Me.RadCustomerMadeSpectacle.AutoSize = True
        Me.RadCustomerMadeSpectacle.BackColor = System.Drawing.Color.Transparent
        Me.RadCustomerMadeSpectacle.Location = New System.Drawing.Point(83, 15)
        Me.RadCustomerMadeSpectacle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadCustomerMadeSpectacle.Name = "RadCustomerMadeSpectacle"
        Me.RadCustomerMadeSpectacle.Size = New System.Drawing.Size(150, 17)
        Me.RadCustomerMadeSpectacle.TabIndex = 0
        Me.RadCustomerMadeSpectacle.TabStop = True
        Me.RadCustomerMadeSpectacle.Tag = "4"
        Me.RadCustomerMadeSpectacle.Text = "Customer Made Spectacle"
        Me.RadCustomerMadeSpectacle.UseVisualStyleBackColor = False
        '
        'RadReadyMadeSpectacle
        '
        Me.RadReadyMadeSpectacle.AutoSize = True
        Me.RadReadyMadeSpectacle.BackColor = System.Drawing.Color.Transparent
        Me.RadReadyMadeSpectacle.Location = New System.Drawing.Point(83, 84)
        Me.RadReadyMadeSpectacle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadReadyMadeSpectacle.Name = "RadReadyMadeSpectacle"
        Me.RadReadyMadeSpectacle.Size = New System.Drawing.Size(137, 17)
        Me.RadReadyMadeSpectacle.TabIndex = 2
        Me.RadReadyMadeSpectacle.TabStop = True
        Me.RadReadyMadeSpectacle.Tag = "3"
        Me.RadReadyMadeSpectacle.Text = "Ready Made Spectacle"
        Me.RadReadyMadeSpectacle.UseVisualStyleBackColor = False
        '
        'RadSunGlasses
        '
        Me.RadSunGlasses.AutoSize = True
        Me.RadSunGlasses.BackColor = System.Drawing.Color.Transparent
        Me.RadSunGlasses.Location = New System.Drawing.Point(284, 37)
        Me.RadSunGlasses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadSunGlasses.Name = "RadSunGlasses"
        Me.RadSunGlasses.Size = New System.Drawing.Size(84, 17)
        Me.RadSunGlasses.TabIndex = 4
        Me.RadSunGlasses.TabStop = True
        Me.RadSunGlasses.Tag = "2"
        Me.RadSunGlasses.Text = "Sun Glasses"
        Me.RadSunGlasses.UseVisualStyleBackColor = False
        '
        'LblSaveStatus
        '
        Me.LblSaveStatus.AutoSize = True
        Me.LblSaveStatus.Location = New System.Drawing.Point(327, 16)
        Me.LblSaveStatus.Name = "LblSaveStatus"
        Me.LblSaveStatus.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveStatus.TabIndex = 19
        Me.LblSaveStatus.Text = "0"
        Me.LblSaveStatus.Visible = False
        '
        'TxtCustomerNo
        '
        Me.TxtCustomerNo.BackColor = System.Drawing.Color.White
        Me.TxtCustomerNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerNo.Location = New System.Drawing.Point(382, 53)
        Me.TxtCustomerNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomerNo.Name = "TxtCustomerNo"
        Me.TxtCustomerNo.ReadOnly = True
        Me.TxtCustomerNo.Size = New System.Drawing.Size(73, 26)
        Me.TxtCustomerNo.TabIndex = 9
        Me.TxtCustomerNo.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(7, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Eye Glasses"
        '
        'RadOther
        '
        Me.RadOther.AutoSize = True
        Me.RadOther.BackColor = System.Drawing.Color.Transparent
        Me.RadOther.Location = New System.Drawing.Point(404, 114)
        Me.RadOther.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadOther.Name = "RadOther"
        Me.RadOther.Size = New System.Drawing.Size(51, 17)
        Me.RadOther.TabIndex = 8
        Me.RadOther.TabStop = True
        Me.RadOther.Tag = "6"
        Me.RadOther.Text = "Other"
        Me.RadOther.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.cmdAddRate)
        Me.GroupBox8.Controls.Add(Me.txtRate)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(465, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(164, 50)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "អត្រាប្តូប្រាក់"
        '
        'cmdAddRate
        '
        Me.cmdAddRate.Enabled = False
        Me.cmdAddRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.cmdAddRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddRate.Location = New System.Drawing.Point(169, 29)
        Me.cmdAddRate.Name = "cmdAddRate"
        Me.cmdAddRate.Size = New System.Drawing.Size(19, 10)
        Me.cmdAddRate.TabIndex = 1
        Me.cmdAddRate.Text = "..."
        Me.cmdAddRate.UseVisualStyleBackColor = True
        Me.cmdAddRate.Visible = False
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.Color.Navy
        Me.txtRate.Location = New System.Drawing.Point(7, 21)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(151, 23)
        Me.txtRate.TabIndex = 0
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChDonation
        '
        Me.ChDonation.AutoSize = True
        Me.ChDonation.Enabled = False
        Me.ChDonation.Location = New System.Drawing.Point(474, 63)
        Me.ChDonation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChDonation.Name = "ChDonation"
        Me.ChDonation.Size = New System.Drawing.Size(102, 17)
        Me.ChDonation.TabIndex = 11
        Me.ChDonation.Text = "Source of Fund:"
        Me.ChDonation.UseVisualStyleBackColor = True
        '
        'RadFundRaising
        '
        Me.RadFundRaising.AutoSize = True
        Me.RadFundRaising.BackColor = System.Drawing.Color.Transparent
        Me.RadFundRaising.Location = New System.Drawing.Point(284, 118)
        Me.RadFundRaising.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadFundRaising.Name = "RadFundRaising"
        Me.RadFundRaising.Size = New System.Drawing.Size(87, 17)
        Me.RadFundRaising.TabIndex = 7
        Me.RadFundRaising.TabStop = True
        Me.RadFundRaising.Tag = "5"
        Me.RadFundRaising.Text = "Fund Raising"
        Me.RadFundRaising.UseVisualStyleBackColor = False
        '
        'RadMedicine
        '
        Me.RadMedicine.AutoSize = True
        Me.RadMedicine.BackColor = System.Drawing.Color.Transparent
        Me.RadMedicine.Location = New System.Drawing.Point(284, 60)
        Me.RadMedicine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadMedicine.Name = "RadMedicine"
        Me.RadMedicine.Size = New System.Drawing.Size(68, 17)
        Me.RadMedicine.TabIndex = 5
        Me.RadMedicine.TabStop = True
        Me.RadMedicine.Tag = "1"
        Me.RadMedicine.Text = "Medicine"
        Me.RadMedicine.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtDonateAmount)
        Me.GroupBox5.Controls.Add(Me.CboDonation)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(467, 65)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(279, 74)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'TxtDonateAmount
        '
        Me.TxtDonateAmount.Enabled = False
        Me.TxtDonateAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDonateAmount.Location = New System.Drawing.Point(92, 45)
        Me.TxtDonateAmount.Name = "TxtDonateAmount"
        Me.TxtDonateAmount.Size = New System.Drawing.Size(170, 23)
        Me.TxtDonateAmount.TabIndex = 1
        Me.TxtDonateAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CboDonation
        '
        Me.CboDonation.Enabled = False
        Me.CboDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDonation.FormattingEnabled = True
        Me.CboDonation.Location = New System.Drawing.Point(92, 16)
        Me.CboDonation.Name = "CboDonation"
        Me.CboDonation.Size = New System.Drawing.Size(170, 24)
        Me.CboDonation.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Donate :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Donate Name :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(261, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "$"
        '
        'GBoxCustomerMade
        '
        Me.GBoxCustomerMade.Controls.Add(Me.RadDistance1)
        Me.GBoxCustomerMade.Controls.Add(Me.RadRedding1)
        Me.GBoxCustomerMade.Controls.Add(Me.RadBifocal)
        Me.GBoxCustomerMade.Enabled = False
        Me.GBoxCustomerMade.Location = New System.Drawing.Point(78, 18)
        Me.GBoxCustomerMade.Name = "GBoxCustomerMade"
        Me.GBoxCustomerMade.Size = New System.Drawing.Size(200, 62)
        Me.GBoxCustomerMade.TabIndex = 1
        Me.GBoxCustomerMade.TabStop = False
        '
        'RadDistance1
        '
        Me.RadDistance1.AutoSize = True
        Me.RadDistance1.Location = New System.Drawing.Point(13, 19)
        Me.RadDistance1.Name = "RadDistance1"
        Me.RadDistance1.Size = New System.Drawing.Size(67, 17)
        Me.RadDistance1.TabIndex = 0
        Me.RadDistance1.TabStop = True
        Me.RadDistance1.Text = "Distance"
        Me.RadDistance1.UseVisualStyleBackColor = True
        '
        'RadRedding1
        '
        Me.RadRedding1.AutoSize = True
        Me.RadRedding1.Location = New System.Drawing.Point(101, 19)
        Me.RadRedding1.Name = "RadRedding1"
        Me.RadRedding1.Size = New System.Drawing.Size(65, 17)
        Me.RadRedding1.TabIndex = 1
        Me.RadRedding1.TabStop = True
        Me.RadRedding1.Text = "Reading"
        Me.RadRedding1.UseVisualStyleBackColor = True
        '
        'RadBifocal
        '
        Me.RadBifocal.AutoSize = True
        Me.RadBifocal.Location = New System.Drawing.Point(13, 41)
        Me.RadBifocal.Name = "RadBifocal"
        Me.RadBifocal.Size = New System.Drawing.Size(57, 17)
        Me.RadBifocal.TabIndex = 2
        Me.RadBifocal.TabStop = True
        Me.RadBifocal.Text = "Bifocal"
        Me.RadBifocal.UseVisualStyleBackColor = True
        '
        'GBoxReadyMade
        '
        Me.GBoxReadyMade.Controls.Add(Me.RadDistance2)
        Me.GBoxReadyMade.Controls.Add(Me.RadRedding2)
        Me.GBoxReadyMade.Enabled = False
        Me.GBoxReadyMade.Location = New System.Drawing.Point(78, 86)
        Me.GBoxReadyMade.Name = "GBoxReadyMade"
        Me.GBoxReadyMade.Size = New System.Drawing.Size(200, 48)
        Me.GBoxReadyMade.TabIndex = 3
        Me.GBoxReadyMade.TabStop = False
        '
        'RadDistance2
        '
        Me.RadDistance2.AutoSize = True
        Me.RadDistance2.Location = New System.Drawing.Point(13, 20)
        Me.RadDistance2.Name = "RadDistance2"
        Me.RadDistance2.Size = New System.Drawing.Size(67, 17)
        Me.RadDistance2.TabIndex = 0
        Me.RadDistance2.TabStop = True
        Me.RadDistance2.Text = "Distance"
        Me.RadDistance2.UseVisualStyleBackColor = True
        '
        'RadRedding2
        '
        Me.RadRedding2.AutoSize = True
        Me.RadRedding2.Location = New System.Drawing.Point(101, 20)
        Me.RadRedding2.Name = "RadRedding2"
        Me.RadRedding2.Size = New System.Drawing.Size(65, 17)
        Me.RadRedding2.TabIndex = 1
        Me.RadRedding2.TabStop = True
        Me.RadRedding2.Text = "Reading"
        Me.RadRedding2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtTotalAsReal)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(504, 57)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Riel"
        '
        'TxtTotalAsReal
        '
        Me.TxtTotalAsReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalAsReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtTotalAsReal.Location = New System.Drawing.Point(9, 17)
        Me.TxtTotalAsReal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalAsReal.Name = "TxtTotalAsReal"
        Me.TxtTotalAsReal.Size = New System.Drawing.Size(393, 30)
        Me.TxtTotalAsReal.TabIndex = 0
        Me.TxtTotalAsReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(408, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Total (Riel)"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtTotalAsDolar)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(518, 15)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(577, 56)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dolar"
        '
        'TxtTotalAsDolar
        '
        Me.TxtTotalAsDolar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalAsDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtTotalAsDolar.Location = New System.Drawing.Point(15, 17)
        Me.TxtTotalAsDolar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalAsDolar.Name = "TxtTotalAsDolar"
        Me.TxtTotalAsDolar.ReadOnly = True
        Me.TxtTotalAsDolar.Size = New System.Drawing.Size(440, 30)
        Me.TxtTotalAsDolar.TabIndex = 0
        Me.TxtTotalAsDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(461, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total (Dolar)"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.BtnAddItem.Location = New System.Drawing.Point(1116, 217)
        Me.BtnAddItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(38, 31)
        Me.BtnAddItem.TabIndex = 4
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.BtnRemoveItem.Location = New System.Drawing.Point(1116, 254)
        Me.BtnRemoveItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(38, 31)
        Me.BtnRemoveItem.TabIndex = 5
        Me.BtnRemoveItem.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSaveReceipt, Me.ToolStripSeparator1, Me.BtnCancel, Me.ToolStripSeparator2, Me.LblTotalConsult})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1160, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSaveReceipt
        '
        Me.BtnSaveReceipt.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.BtnSaveReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSaveReceipt.Name = "BtnSaveReceipt"
        Me.BtnSaveReceipt.Size = New System.Drawing.Size(93, 24)
        Me.BtnSaveReceipt.Text = "Save Invoice"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(57, 24)
        Me.BtnCancel.Text = "Close"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'LblTotalConsult
        '
        Me.LblTotalConsult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalConsult.ForeColor = System.Drawing.Color.Red
        Me.LblTotalConsult.Name = "LblTotalConsult"
        Me.LblTotalConsult.Size = New System.Drawing.Size(128, 24)
        Me.LblTotalConsult.Text = "Total Consult: 0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblReceiptID)
        Me.GroupBox4.Controls.Add(Me.GBPaymentType)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox4.Controls.Add(Me.ChPrintPreview)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.DateCreateReceipt)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(557, 33)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(597, 174)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoice Info"
        '
        'LblReceiptID
        '
        Me.LblReceiptID.AutoSize = True
        Me.LblReceiptID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblReceiptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblReceiptID.ForeColor = System.Drawing.Color.Red
        Me.LblReceiptID.Location = New System.Drawing.Point(168, 69)
        Me.LblReceiptID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblReceiptID.Name = "LblReceiptID"
        Me.LblReceiptID.Size = New System.Drawing.Size(21, 22)
        Me.LblReceiptID.TabIndex = 12
        Me.LblReceiptID.Text = "0"
        Me.LblReceiptID.Visible = False
        '
        'GBPaymentType
        '
        Me.GBPaymentType.Controls.Add(Me.GroupPayCorrency)
        Me.GBPaymentType.Controls.Add(Me.TxtSocialAmount)
        Me.GBPaymentType.Controls.Add(Me.TxtNilAmount)
        Me.GBPaymentType.Controls.Add(Me.TxtFullAmount)
        Me.GBPaymentType.Controls.Add(Me.RadNil)
        Me.GBPaymentType.Controls.Add(Me.RadSocial)
        Me.GBPaymentType.Controls.Add(Me.RadFull)
        Me.GBPaymentType.Location = New System.Drawing.Point(231, 9)
        Me.GBPaymentType.Name = "GBPaymentType"
        Me.GBPaymentType.Size = New System.Drawing.Size(360, 150)
        Me.GBPaymentType.TabIndex = 4
        Me.GBPaymentType.TabStop = False
        Me.GBPaymentType.Text = "Payment Type"
        '
        'GroupPayCorrency
        '
        Me.GroupPayCorrency.Controls.Add(Me.RadKHR)
        Me.GroupPayCorrency.Controls.Add(Me.RadUSD)
        Me.GroupPayCorrency.Location = New System.Drawing.Point(272, 28)
        Me.GroupPayCorrency.Name = "GroupPayCorrency"
        Me.GroupPayCorrency.Size = New System.Drawing.Size(73, 64)
        Me.GroupPayCorrency.TabIndex = 3
        Me.GroupPayCorrency.TabStop = False
        Me.GroupPayCorrency.Text = "Currency"
        '
        'RadKHR
        '
        Me.RadKHR.AutoSize = True
        Me.RadKHR.Location = New System.Drawing.Point(6, 18)
        Me.RadKHR.Name = "RadKHR"
        Me.RadKHR.Size = New System.Drawing.Size(48, 17)
        Me.RadKHR.TabIndex = 1
        Me.RadKHR.Text = "KHR"
        Me.RadKHR.UseVisualStyleBackColor = True
        '
        'RadUSD
        '
        Me.RadUSD.AutoSize = True
        Me.RadUSD.Location = New System.Drawing.Point(6, 41)
        Me.RadUSD.Name = "RadUSD"
        Me.RadUSD.Size = New System.Drawing.Size(48, 17)
        Me.RadUSD.TabIndex = 0
        Me.RadUSD.Text = "USD"
        Me.RadUSD.UseVisualStyleBackColor = True
        '
        'TxtSocialAmount
        '
        Me.TxtSocialAmount.BackColor = System.Drawing.Color.White
        Me.TxtSocialAmount.Enabled = False
        Me.TxtSocialAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSocialAmount.Location = New System.Drawing.Point(69, 66)
        Me.TxtSocialAmount.Name = "TxtSocialAmount"
        Me.TxtSocialAmount.Size = New System.Drawing.Size(174, 26)
        Me.TxtSocialAmount.TabIndex = 1
        Me.TxtSocialAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNilAmount
        '
        Me.TxtNilAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNilAmount.Location = New System.Drawing.Point(207, 102)
        Me.TxtNilAmount.Name = "TxtNilAmount"
        Me.TxtNilAmount.Size = New System.Drawing.Size(36, 26)
        Me.TxtNilAmount.TabIndex = 4
        Me.TxtNilAmount.Visible = False
        '
        'TxtFullAmount
        '
        Me.TxtFullAmount.BackColor = System.Drawing.Color.White
        Me.TxtFullAmount.Enabled = False
        Me.TxtFullAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtFullAmount.Location = New System.Drawing.Point(69, 35)
        Me.TxtFullAmount.Name = "TxtFullAmount"
        Me.TxtFullAmount.Size = New System.Drawing.Size(174, 26)
        Me.TxtFullAmount.TabIndex = 0
        Me.TxtFullAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadNil
        '
        Me.RadNil.AutoSize = True
        Me.RadNil.Enabled = False
        Me.RadNil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNil.ForeColor = System.Drawing.Color.Blue
        Me.RadNil.Location = New System.Drawing.Point(17, 102)
        Me.RadNil.Name = "RadNil"
        Me.RadNil.Size = New System.Drawing.Size(114, 24)
        Me.RadNil.TabIndex = 2
        Me.RadNil.TabStop = True
        Me.RadNil.Text = "Nil Receipt"
        Me.RadNil.UseVisualStyleBackColor = True
        '
        'RadSocial
        '
        Me.RadSocial.AutoSize = True
        Me.RadSocial.Enabled = False
        Me.RadSocial.Location = New System.Drawing.Point(17, 75)
        Me.RadSocial.Name = "RadSocial"
        Me.RadSocial.Size = New System.Drawing.Size(54, 17)
        Me.RadSocial.TabIndex = 2
        Me.RadSocial.TabStop = True
        Me.RadSocial.Text = "Social"
        Me.RadSocial.UseVisualStyleBackColor = True
        '
        'RadFull
        '
        Me.RadFull.AutoSize = True
        Me.RadFull.Enabled = False
        Me.RadFull.Location = New System.Drawing.Point(17, 44)
        Me.RadFull.Name = "RadFull"
        Me.RadFull.Size = New System.Drawing.Size(41, 17)
        Me.RadFull.TabIndex = 0
        Me.RadFull.TabStop = True
        Me.RadFull.Text = "Full"
        Me.RadFull.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtNumGlasses)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.ChbNewGlasses)
        Me.GroupBox7.Location = New System.Drawing.Point(15, 115)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(204, 46)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'TxtNumGlasses
        '
        Me.TxtNumGlasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumGlasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNumGlasses.Location = New System.Drawing.Point(81, 14)
        Me.TxtNumGlasses.Name = "TxtNumGlasses"
        Me.TxtNumGlasses.Size = New System.Drawing.Size(100, 26)
        Me.TxtNumGlasses.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Quantity :"
        '
        'ChbNewGlasses
        '
        Me.ChbNewGlasses.AutoSize = True
        Me.ChbNewGlasses.Location = New System.Drawing.Point(6, -1)
        Me.ChbNewGlasses.Name = "ChbNewGlasses"
        Me.ChbNewGlasses.Size = New System.Drawing.Size(88, 17)
        Me.ChbNewGlasses.TabIndex = 0
        Me.ChbNewGlasses.Text = "New Glasses"
        Me.ChbNewGlasses.UseVisualStyleBackColor = True
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.AutoSize = True
        Me.TxtReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtReceiptNo.ForeColor = System.Drawing.Color.Red
        Me.TxtReceiptNo.Location = New System.Drawing.Point(95, 50)
        Me.TxtReceiptNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(65, 22)
        Me.TxtReceiptNo.TabIndex = 2
        Me.TxtReceiptNo.Text = "Label9"
        '
        'ChPrintPreview
        '
        Me.ChPrintPreview.AutoSize = True
        Me.ChPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPrintPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChPrintPreview.Location = New System.Drawing.Point(15, 81)
        Me.ChPrintPreview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChPrintPreview.Name = "ChPrintPreview"
        Me.ChPrintPreview.Size = New System.Drawing.Size(157, 21)
        Me.ChPrintPreview.TabIndex = 3
        Me.ChPrintPreview.Text = "Invoice Print Preview"
        Me.ChPrintPreview.UseVisualStyleBackColor = True
        '
        'TxtGetBarcode
        '
        Me.TxtGetBarcode.Location = New System.Drawing.Point(704, 118)
        Me.TxtGetBarcode.Name = "TxtGetBarcode"
        Me.TxtGetBarcode.Size = New System.Drawing.Size(185, 20)
        Me.TxtGetBarcode.TabIndex = 16
        '
        'ErrReceipt
        '
        Me.ErrReceipt.ContainerControl = Me
        '
        'BgSaveAndPrinting
        '
        '
        'FrmNewReceipt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1160, 683)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRemoveItem)
        Me.Controls.Add(Me.BtnAddItem)
        Me.Controls.Add(Me.TxtGetBarcode)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GridItemDetail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmNewReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Optical Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GPIncomeType.ResumeLayout(False)
        Me.GPIncomeType.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBoxCustomerMade.ResumeLayout(False)
        Me.GBoxCustomerMade.PerformLayout()
        Me.GBoxReadyMade.ResumeLayout(False)
        Me.GBoxReadyMade.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GBPaymentType.ResumeLayout(False)
        Me.GBPaymentType.PerformLayout()
        Me.GroupPayCorrency.ResumeLayout(False)
        Me.GroupPayCorrency.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateCreateReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCleanCustomer As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAddCustomer As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtCusOccupation As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridItemDetail As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChDonation As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTotalAsDolar As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAsReal As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSaveReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrReceipt As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChPrintPreview As System.Windows.Forms.CheckBox
    Friend WithEvents GPIncomeType As System.Windows.Forms.GroupBox
    Friend WithEvents RadOther As System.Windows.Forms.RadioButton
    Friend WithEvents RadReadyMadeSpectacle As System.Windows.Forms.RadioButton
    Friend WithEvents RadFundRaising As System.Windows.Forms.RadioButton
    Friend WithEvents RadSunGlasses As System.Windows.Forms.RadioButton
    Friend WithEvents RadCustomerMadeSpectacle As System.Windows.Forms.RadioButton
    Friend WithEvents RadMedicine As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.Label
    Friend WithEvents TxtGetBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSelectPatient As Janus.Windows.EditControls.UIButton
    Friend WithEvents BgSaveAndPrinting As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtCusNameEng As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNumGlasses As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChbNewGlasses As System.Windows.Forms.CheckBox
    Friend WithEvents GBPaymentType As System.Windows.Forms.GroupBox
    Friend WithEvents RadSocial As System.Windows.Forms.RadioButton
    Friend WithEvents RadNil As System.Windows.Forms.RadioButton
    Friend WithEvents RadFull As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPayCorrency As System.Windows.Forms.GroupBox
    Friend WithEvents RadKHR As System.Windows.Forms.RadioButton
    Friend WithEvents RadUSD As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSocialAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtNilAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtFullAmount As System.Windows.Forms.TextBox
    Friend WithEvents CheOldPatient As System.Windows.Forms.CheckBox
    Friend WithEvents LblSaveStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAddRate As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents LblCombindReferal As System.Windows.Forms.Label
    Friend WithEvents RadLV As System.Windows.Forms.RadioButton
    Friend WithEvents GBoxReadyMade As System.Windows.Forms.GroupBox
    Friend WithEvents RadDistance2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadRedding2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadBifocal As System.Windows.Forms.RadioButton
    Friend WithEvents GBoxCustomerMade As System.Windows.Forms.GroupBox
    Friend WithEvents RadDistance1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadRedding1 As System.Windows.Forms.RadioButton
    Friend WithEvents CboDonation As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDonateAmount As System.Windows.Forms.TextBox
    Friend WithEvents ColumnItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnQTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDolar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Picture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents LblConsultID As System.Windows.Forms.Label
    Friend WithEvents LblSendBy As System.Windows.Forms.Label
    Friend WithEvents lblConsultFor As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LblConsultDate As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblConsultType As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblTotalConsult As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblReceiptID As System.Windows.Forms.Label
End Class
