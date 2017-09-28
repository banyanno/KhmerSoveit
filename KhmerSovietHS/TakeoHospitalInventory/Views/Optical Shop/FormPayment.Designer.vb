<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPayment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GBPaymentType = New System.Windows.Forms.GroupBox
        Me.TxtTemSocialAmount = New System.Windows.Forms.TextBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.RadKHR = New System.Windows.Forms.RadioButton
        Me.RadUSD = New System.Windows.Forms.RadioButton
        Me.TxtSocialAmount = New System.Windows.Forms.TextBox
        Me.TxtNilAmount = New System.Windows.Forms.TextBox
        Me.TxtFullAmount = New System.Windows.Forms.TextBox
        Me.RadSocial = New System.Windows.Forms.RadioButton
        Me.RadNil = New System.Windows.Forms.RadioButton
        Me.RadFull = New System.Windows.Forms.RadioButton
        Me.GPIncomeType = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.RadOther = New System.Windows.Forms.RadioButton
        Me.RadReadMod = New System.Windows.Forms.RadioButton
        Me.RadFundRaising = New System.Windows.Forms.RadioButton
        Me.RadSunGlasses = New System.Windows.Forms.RadioButton
        Me.RadSpectacle = New System.Windows.Forms.RadioButton
        Me.RadMedicine = New System.Windows.Forms.RadioButton
        Me.LblReceiptID = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtDonateAmount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtFundName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtSex = New System.Windows.Forms.TextBox
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.TxtCustomerName = New System.Windows.Forms.TextBox
        Me.TxtCustomerNo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblReceiptDate = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtTotalAsDolar = New System.Windows.Forms.TextBox
        Me.TxtTotalAsReal = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblReceiptNo = New System.Windows.Forms.Label
        Me.TxtPayByFund = New System.Windows.Forms.TextBox
        Me.TxtPayBySelf = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtComment = New System.Windows.Forms.RichTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.LblAmountInFigureD = New System.Windows.Forms.Label
        Me.LblAmountInFigureR = New System.Windows.Forms.Label
        Me.RadPayDolar = New System.Windows.Forms.RadioButton
        Me.RadPayRiel = New System.Windows.Forms.RadioButton
        Me.ChDolar = New System.Windows.Forms.CheckBox
        Me.ChReal = New System.Windows.Forms.CheckBox
        Me.TxtAmountDolar = New System.Windows.Forms.TextBox
        Me.TxtAmounInReal = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtAmountInWord = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtReturnDolar = New System.Windows.Forms.TextBox
        Me.TxtReturnReal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnSavePayingReceip = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrPayment = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblIsPaidStatus = New System.Windows.Forms.Label
        Me.RadLV = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GBPaymentType.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GPIncomeType.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GBPaymentType)
        Me.GroupBox1.Controls.Add(Me.GPIncomeType)
        Me.GroupBox1.Controls.Add(Me.LblReceiptID)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LblReceiptDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblReceiptNo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 378)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Information"
        '
        'GBPaymentType
        '
        Me.GBPaymentType.Controls.Add(Me.TxtTemSocialAmount)
        Me.GBPaymentType.Controls.Add(Me.GroupBox9)
        Me.GBPaymentType.Controls.Add(Me.TxtSocialAmount)
        Me.GBPaymentType.Controls.Add(Me.TxtNilAmount)
        Me.GBPaymentType.Controls.Add(Me.TxtFullAmount)
        Me.GBPaymentType.Controls.Add(Me.RadSocial)
        Me.GBPaymentType.Controls.Add(Me.RadNil)
        Me.GBPaymentType.Controls.Add(Me.RadFull)
        Me.GBPaymentType.Location = New System.Drawing.Point(540, 258)
        Me.GBPaymentType.Name = "GBPaymentType"
        Me.GBPaymentType.Size = New System.Drawing.Size(351, 115)
        Me.GBPaymentType.TabIndex = 20
        Me.GBPaymentType.TabStop = False
        Me.GBPaymentType.Text = "Payment Type"
        '
        'TxtTemSocialAmount
        '
        Me.TxtTemSocialAmount.Location = New System.Drawing.Point(0, 95)
        Me.TxtTemSocialAmount.Name = "TxtTemSocialAmount"
        Me.TxtTemSocialAmount.Size = New System.Drawing.Size(50, 20)
        Me.TxtTemSocialAmount.TabIndex = 7
        Me.TxtTemSocialAmount.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.RadKHR)
        Me.GroupBox9.Controls.Add(Me.RadUSD)
        Me.GroupBox9.Location = New System.Drawing.Point(233, 13)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(73, 81)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Currency"
        '
        'RadKHR
        '
        Me.RadKHR.AutoSize = True
        Me.RadKHR.Checked = True
        Me.RadKHR.Location = New System.Drawing.Point(6, 18)
        Me.RadKHR.Name = "RadKHR"
        Me.RadKHR.Size = New System.Drawing.Size(48, 17)
        Me.RadKHR.TabIndex = 1
        Me.RadKHR.TabStop = True
        Me.RadKHR.Text = "KHR"
        Me.RadKHR.UseVisualStyleBackColor = True
        '
        'RadUSD
        '
        Me.RadUSD.AutoSize = True
        Me.RadUSD.Location = New System.Drawing.Point(6, 45)
        Me.RadUSD.Name = "RadUSD"
        Me.RadUSD.Size = New System.Drawing.Size(48, 17)
        Me.RadUSD.TabIndex = 0
        Me.RadUSD.Text = "USD"
        Me.RadUSD.UseVisualStyleBackColor = True
        '
        'TxtSocialAmount
        '
        Me.TxtSocialAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSocialAmount.Location = New System.Drawing.Point(58, 68)
        Me.TxtSocialAmount.Name = "TxtSocialAmount"
        Me.TxtSocialAmount.Size = New System.Drawing.Size(174, 26)
        Me.TxtSocialAmount.TabIndex = 5
        '
        'TxtNilAmount
        '
        Me.TxtNilAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNilAmount.Location = New System.Drawing.Point(318, 95)
        Me.TxtNilAmount.Name = "TxtNilAmount"
        Me.TxtNilAmount.Size = New System.Drawing.Size(27, 26)
        Me.TxtNilAmount.TabIndex = 4
        Me.TxtNilAmount.Visible = False
        '
        'TxtFullAmount
        '
        Me.TxtFullAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtFullAmount.Location = New System.Drawing.Point(58, 19)
        Me.TxtFullAmount.Name = "TxtFullAmount"
        Me.TxtFullAmount.Size = New System.Drawing.Size(174, 26)
        Me.TxtFullAmount.TabIndex = 3
        '
        'RadSocial
        '
        Me.RadSocial.AutoSize = True
        Me.RadSocial.Location = New System.Drawing.Point(8, 68)
        Me.RadSocial.Name = "RadSocial"
        Me.RadSocial.Size = New System.Drawing.Size(54, 17)
        Me.RadSocial.TabIndex = 2
        Me.RadSocial.TabStop = True
        Me.RadSocial.Text = "Social"
        Me.RadSocial.UseVisualStyleBackColor = True
        '
        'RadNil
        '
        Me.RadNil.AutoSize = True
        Me.RadNil.Location = New System.Drawing.Point(269, 97)
        Me.RadNil.Name = "RadNil"
        Me.RadNil.Size = New System.Drawing.Size(37, 17)
        Me.RadNil.TabIndex = 1
        Me.RadNil.TabStop = True
        Me.RadNil.Text = "Nil"
        Me.RadNil.UseVisualStyleBackColor = True
        Me.RadNil.Visible = False
        '
        'RadFull
        '
        Me.RadFull.AutoSize = True
        Me.RadFull.Location = New System.Drawing.Point(9, 22)
        Me.RadFull.Name = "RadFull"
        Me.RadFull.Size = New System.Drawing.Size(41, 17)
        Me.RadFull.TabIndex = 0
        Me.RadFull.TabStop = True
        Me.RadFull.Text = "Full"
        Me.RadFull.UseVisualStyleBackColor = True
        '
        'GPIncomeType
        '
        Me.GPIncomeType.Controls.Add(Me.RadLV)
        Me.GPIncomeType.Controls.Add(Me.Label7)
        Me.GPIncomeType.Controls.Add(Me.RadOther)
        Me.GPIncomeType.Controls.Add(Me.RadReadMod)
        Me.GPIncomeType.Controls.Add(Me.RadFundRaising)
        Me.GPIncomeType.Controls.Add(Me.RadSunGlasses)
        Me.GPIncomeType.Controls.Add(Me.RadSpectacle)
        Me.GPIncomeType.Controls.Add(Me.RadMedicine)
        Me.GPIncomeType.Location = New System.Drawing.Point(9, 259)
        Me.GPIncomeType.Margin = New System.Windows.Forms.Padding(2)
        Me.GPIncomeType.Name = "GPIncomeType"
        Me.GPIncomeType.Padding = New System.Windows.Forms.Padding(2)
        Me.GPIncomeType.Size = New System.Drawing.Size(513, 114)
        Me.GPIncomeType.TabIndex = 3
        Me.GPIncomeType.TabStop = False
        Me.GPIncomeType.Text = "Select In payment for"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(5, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Eye Glasses"
        '
        'RadOther
        '
        Me.RadOther.AutoSize = True
        Me.RadOther.BackColor = System.Drawing.Color.Transparent
        Me.RadOther.Location = New System.Drawing.Point(357, 41)
        Me.RadOther.Margin = New System.Windows.Forms.Padding(2)
        Me.RadOther.Name = "RadOther"
        Me.RadOther.Size = New System.Drawing.Size(51, 17)
        Me.RadOther.TabIndex = 0
        Me.RadOther.TabStop = True
        Me.RadOther.Tag = "6"
        Me.RadOther.Text = "Other"
        Me.RadOther.UseVisualStyleBackColor = False
        '
        'RadReadMod
        '
        Me.RadReadMod.AutoSize = True
        Me.RadReadMod.BackColor = System.Drawing.Color.Transparent
        Me.RadReadMod.Location = New System.Drawing.Point(214, 17)
        Me.RadReadMod.Margin = New System.Windows.Forms.Padding(2)
        Me.RadReadMod.Name = "RadReadMod"
        Me.RadReadMod.Size = New System.Drawing.Size(86, 17)
        Me.RadReadMod.TabIndex = 0
        Me.RadReadMod.TabStop = True
        Me.RadReadMod.Tag = "3"
        Me.RadReadMod.Text = "Ready Made"
        Me.RadReadMod.UseVisualStyleBackColor = False
        '
        'RadFundRaising
        '
        Me.RadFundRaising.AutoSize = True
        Me.RadFundRaising.BackColor = System.Drawing.Color.Transparent
        Me.RadFundRaising.Location = New System.Drawing.Point(357, 17)
        Me.RadFundRaising.Margin = New System.Windows.Forms.Padding(2)
        Me.RadFundRaising.Name = "RadFundRaising"
        Me.RadFundRaising.Size = New System.Drawing.Size(87, 17)
        Me.RadFundRaising.TabIndex = 0
        Me.RadFundRaising.TabStop = True
        Me.RadFundRaising.Tag = "5"
        Me.RadFundRaising.Text = "Fund Raising"
        Me.RadFundRaising.UseVisualStyleBackColor = False
        '
        'RadSunGlasses
        '
        Me.RadSunGlasses.AutoSize = True
        Me.RadSunGlasses.BackColor = System.Drawing.Color.Transparent
        Me.RadSunGlasses.Location = New System.Drawing.Point(101, 39)
        Me.RadSunGlasses.Margin = New System.Windows.Forms.Padding(2)
        Me.RadSunGlasses.Name = "RadSunGlasses"
        Me.RadSunGlasses.Size = New System.Drawing.Size(84, 17)
        Me.RadSunGlasses.TabIndex = 0
        Me.RadSunGlasses.TabStop = True
        Me.RadSunGlasses.Tag = "2"
        Me.RadSunGlasses.Text = "Sun Glasses"
        Me.RadSunGlasses.UseVisualStyleBackColor = False
        '
        'RadSpectacle
        '
        Me.RadSpectacle.AutoSize = True
        Me.RadSpectacle.BackColor = System.Drawing.Color.Transparent
        Me.RadSpectacle.Location = New System.Drawing.Point(101, 17)
        Me.RadSpectacle.Margin = New System.Windows.Forms.Padding(2)
        Me.RadSpectacle.Name = "RadSpectacle"
        Me.RadSpectacle.Size = New System.Drawing.Size(73, 17)
        Me.RadSpectacle.TabIndex = 0
        Me.RadSpectacle.TabStop = True
        Me.RadSpectacle.Tag = "4"
        Me.RadSpectacle.Text = "Spectacle"
        Me.RadSpectacle.UseVisualStyleBackColor = False
        '
        'RadMedicine
        '
        Me.RadMedicine.AutoSize = True
        Me.RadMedicine.BackColor = System.Drawing.Color.Transparent
        Me.RadMedicine.Location = New System.Drawing.Point(214, 39)
        Me.RadMedicine.Margin = New System.Windows.Forms.Padding(2)
        Me.RadMedicine.Name = "RadMedicine"
        Me.RadMedicine.Size = New System.Drawing.Size(68, 17)
        Me.RadMedicine.TabIndex = 0
        Me.RadMedicine.TabStop = True
        Me.RadMedicine.Tag = "1"
        Me.RadMedicine.Text = "Medicine"
        Me.RadMedicine.UseVisualStyleBackColor = False
        '
        'LblReceiptID
        '
        Me.LblReceiptID.AutoSize = True
        Me.LblReceiptID.Location = New System.Drawing.Point(298, 16)
        Me.LblReceiptID.Name = "LblReceiptID"
        Me.LblReceiptID.Size = New System.Drawing.Size(13, 13)
        Me.LblReceiptID.TabIndex = 14
        Me.LblReceiptID.Text = "0"
        Me.LblReceiptID.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.TxtDonateAmount)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.TxtFundName)
        Me.GroupBox7.Location = New System.Drawing.Point(540, 106)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(350, 153)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Supported By"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(324, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 20)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Amount ;"
        '
        'TxtDonateAmount
        '
        Me.TxtDonateAmount.BackColor = System.Drawing.Color.White
        Me.TxtDonateAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtDonateAmount.Location = New System.Drawing.Point(95, 56)
        Me.TxtDonateAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDonateAmount.Name = "TxtDonateAmount"
        Me.TxtDonateAmount.ReadOnly = True
        Me.TxtDonateAmount.Size = New System.Drawing.Size(222, 26)
        Me.TxtDonateAmount.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Supporter ;"
        '
        'TxtFundName
        '
        Me.TxtFundName.BackColor = System.Drawing.Color.White
        Me.TxtFundName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtFundName.Location = New System.Drawing.Point(95, 26)
        Me.TxtFundName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFundName.Name = "TxtFundName"
        Me.TxtFundName.ReadOnly = True
        Me.TxtFundName.Size = New System.Drawing.Size(222, 26)
        Me.TxtFundName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtSex)
        Me.GroupBox2.Controls.Add(Me.TxtAge)
        Me.GroupBox2.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox2.Controls.Add(Me.TxtCustomerNo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(326, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 94)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Sex:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Age:"
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.Color.White
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtSex.Location = New System.Drawing.Point(248, 54)
        Me.TxtSex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.ReadOnly = True
        Me.TxtSex.Size = New System.Drawing.Size(57, 26)
        Me.TxtSex.TabIndex = 2
        Me.TxtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.White
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtAge.Location = New System.Drawing.Point(100, 54)
        Me.TxtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(57, 26)
        Me.TxtAge.TabIndex = 1
        Me.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.White
        Me.TxtCustomerName.Font = New System.Drawing.Font("Limon S1", 22.0!)
        Me.TxtCustomerName.Location = New System.Drawing.Point(311, 35)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(247, 41)
        Me.TxtCustomerName.TabIndex = 3
        '
        'TxtCustomerNo
        '
        Me.TxtCustomerNo.BackColor = System.Drawing.Color.White
        Me.TxtCustomerNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtCustomerNo.Location = New System.Drawing.Point(100, 17)
        Me.TxtCustomerNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomerNo.Name = "TxtCustomerNo"
        Me.TxtCustomerNo.ReadOnly = True
        Me.TxtCustomerNo.Size = New System.Drawing.Size(205, 26)
        Me.TxtCustomerNo.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Customer Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customer No:"
        '
        'LblReceiptDate
        '
        Me.LblReceiptDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblReceiptDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceiptDate.Location = New System.Drawing.Point(98, 67)
        Me.LblReceiptDate.Name = "LblReceiptDate"
        Me.LblReceiptDate.Size = New System.Drawing.Size(222, 27)
        Me.LblReceiptDate.TabIndex = 1
        Me.LblReceiptDate.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Invoice Date:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtTotalAsDolar)
        Me.GroupBox5.Controls.Add(Me.TxtTotalAsReal)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(513, 153)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total (Riel and Dollar)"
        '
        'TxtTotalAsDolar
        '
        Me.TxtTotalAsDolar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalAsDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.TxtTotalAsDolar.Location = New System.Drawing.Point(10, 86)
        Me.TxtTotalAsDolar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalAsDolar.Name = "TxtTotalAsDolar"
        Me.TxtTotalAsDolar.ReadOnly = True
        Me.TxtTotalAsDolar.Size = New System.Drawing.Size(311, 47)
        Me.TxtTotalAsDolar.TabIndex = 1
        Me.TxtTotalAsDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalAsReal
        '
        Me.TxtTotalAsReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalAsReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.TxtTotalAsReal.Location = New System.Drawing.Point(10, 25)
        Me.TxtTotalAsReal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalAsReal.Name = "TxtTotalAsReal"
        Me.TxtTotalAsReal.ReadOnly = True
        Me.TxtTotalAsReal.Size = New System.Drawing.Size(311, 47)
        Me.TxtTotalAsReal.TabIndex = 0
        Me.TxtTotalAsReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(330, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Total (Dollar)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(332, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Total (Riel)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Invoice No:"
        '
        'lblReceiptNo
        '
        Me.lblReceiptNo.AutoSize = True
        Me.lblReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptNo.ForeColor = System.Drawing.Color.Blue
        Me.lblReceiptNo.Location = New System.Drawing.Point(98, 28)
        Me.lblReceiptNo.Name = "lblReceiptNo"
        Me.lblReceiptNo.Size = New System.Drawing.Size(39, 13)
        Me.lblReceiptNo.TabIndex = 0
        Me.lblReceiptNo.Text = "Label6"
        '
        'TxtPayByFund
        '
        Me.TxtPayByFund.BackColor = System.Drawing.Color.White
        Me.TxtPayByFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtPayByFund.Location = New System.Drawing.Point(94, 623)
        Me.TxtPayByFund.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPayByFund.Name = "TxtPayByFund"
        Me.TxtPayByFund.ReadOnly = True
        Me.TxtPayByFund.Size = New System.Drawing.Size(205, 26)
        Me.TxtPayByFund.TabIndex = 2
        Me.TxtPayByFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPayByFund.Visible = False
        '
        'TxtPayBySelf
        '
        Me.TxtPayBySelf.BackColor = System.Drawing.Color.White
        Me.TxtPayBySelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtPayBySelf.Location = New System.Drawing.Point(94, 599)
        Me.TxtPayBySelf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPayBySelf.Name = "TxtPayBySelf"
        Me.TxtPayBySelf.ReadOnly = True
        Me.TxtPayBySelf.Size = New System.Drawing.Size(205, 26)
        Me.TxtPayBySelf.TabIndex = 1
        Me.TxtPayBySelf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPayBySelf.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 631)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Pay by Fund:"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 605)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Pay by Self:"
        Me.Label13.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtComment)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.LblAmountInFigureD)
        Me.GroupBox3.Controls.Add(Me.LblAmountInFigureR)
        Me.GroupBox3.Controls.Add(Me.RadPayDolar)
        Me.GroupBox3.Controls.Add(Me.RadPayRiel)
        Me.GroupBox3.Controls.Add(Me.ChDolar)
        Me.GroupBox3.Controls.Add(Me.ChReal)
        Me.GroupBox3.Controls.Add(Me.TxtAmountDolar)
        Me.GroupBox3.Controls.Add(Me.TxtAmounInReal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtAmountInWord)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 383)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(907, 211)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'TxtComment
        '
        Me.TxtComment.Enabled = False
        Me.TxtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComment.Location = New System.Drawing.Point(101, 155)
        Me.TxtComment.Name = "TxtComment"
        Me.TxtComment.Size = New System.Drawing.Size(792, 46)
        Me.TxtComment.TabIndex = 6
        Me.TxtComment.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(33, 158)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Comment :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(367, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(129, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "(Current Amount in figure):"
        Me.Label19.Visible = False
        '
        'LblAmountInFigureD
        '
        Me.LblAmountInFigureD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAmountInFigureD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblAmountInFigureD.ForeColor = System.Drawing.Color.Blue
        Me.LblAmountInFigureD.Location = New System.Drawing.Point(371, 112)
        Me.LblAmountInFigureD.Name = "LblAmountInFigureD"
        Me.LblAmountInFigureD.Size = New System.Drawing.Size(159, 30)
        Me.LblAmountInFigureD.TabIndex = 8
        Me.LblAmountInFigureD.Text = "0.00"
        Me.LblAmountInFigureD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblAmountInFigureD.Visible = False
        '
        'LblAmountInFigureR
        '
        Me.LblAmountInFigureR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAmountInFigureR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblAmountInFigureR.ForeColor = System.Drawing.Color.Blue
        Me.LblAmountInFigureR.Location = New System.Drawing.Point(371, 71)
        Me.LblAmountInFigureR.Name = "LblAmountInFigureR"
        Me.LblAmountInFigureR.Size = New System.Drawing.Size(159, 30)
        Me.LblAmountInFigureR.TabIndex = 7
        Me.LblAmountInFigureR.Text = "0.00"
        Me.LblAmountInFigureR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblAmountInFigureR.Visible = False
        '
        'RadPayDolar
        '
        Me.RadPayDolar.AutoSize = True
        Me.RadPayDolar.Location = New System.Drawing.Point(4, 173)
        Me.RadPayDolar.Name = "RadPayDolar"
        Me.RadPayDolar.Size = New System.Drawing.Size(86, 17)
        Me.RadPayDolar.TabIndex = 6
        Me.RadPayDolar.Text = "Pay As Dolar"
        Me.RadPayDolar.UseVisualStyleBackColor = True
        Me.RadPayDolar.Visible = False
        '
        'RadPayRiel
        '
        Me.RadPayRiel.AutoSize = True
        Me.RadPayRiel.Checked = True
        Me.RadPayRiel.Location = New System.Drawing.Point(4, 194)
        Me.RadPayRiel.Name = "RadPayRiel"
        Me.RadPayRiel.Size = New System.Drawing.Size(79, 17)
        Me.RadPayRiel.TabIndex = 6
        Me.RadPayRiel.TabStop = True
        Me.RadPayRiel.Text = "Pay As Riel"
        Me.RadPayRiel.UseVisualStyleBackColor = True
        Me.RadPayRiel.Visible = False
        '
        'ChDolar
        '
        Me.ChDolar.AutoSize = True
        Me.ChDolar.Location = New System.Drawing.Point(36, 120)
        Me.ChDolar.Name = "ChDolar"
        Me.ChDolar.Size = New System.Drawing.Size(32, 17)
        Me.ChDolar.TabIndex = 4
        Me.ChDolar.Text = "$"
        Me.ChDolar.UseVisualStyleBackColor = True
        '
        'ChReal
        '
        Me.ChReal.AutoSize = True
        Me.ChReal.Location = New System.Drawing.Point(36, 79)
        Me.ChReal.Name = "ChReal"
        Me.ChReal.Size = New System.Drawing.Size(34, 17)
        Me.ChReal.TabIndex = 3
        Me.ChReal.Text = "R"
        Me.ChReal.UseVisualStyleBackColor = True
        '
        'TxtAmountDolar
        '
        Me.TxtAmountDolar.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAmountDolar.Enabled = False
        Me.TxtAmountDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmountDolar.Location = New System.Drawing.Point(74, 112)
        Me.TxtAmountDolar.Name = "TxtAmountDolar"
        Me.TxtAmountDolar.Size = New System.Drawing.Size(291, 30)
        Me.TxtAmountDolar.TabIndex = 2
        Me.TxtAmountDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtAmounInReal
        '
        Me.TxtAmounInReal.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAmounInReal.Enabled = False
        Me.TxtAmounInReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmounInReal.Location = New System.Drawing.Point(74, 70)
        Me.TxtAmounInReal.Name = "TxtAmounInReal"
        Me.TxtAmounInReal.Size = New System.Drawing.Size(291, 30)
        Me.TxtAmounInReal.TabIndex = 1
        Me.TxtAmounInReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(Amount in figure):"
        '
        'TxtAmountInWord
        '
        Me.TxtAmountInWord.BackColor = System.Drawing.Color.White
        Me.TxtAmountInWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmountInWord.Location = New System.Drawing.Point(134, 18)
        Me.TxtAmountInWord.Name = "TxtAmountInWord"
        Me.TxtAmountInWord.ReadOnly = True
        Me.TxtAmountInWord.Size = New System.Drawing.Size(673, 26)
        Me.TxtAmountInWord.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount In Words :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TxtReturnDolar)
        Me.GroupBox4.Controls.Add(Me.TxtReturnReal)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(588, 50)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(305, 98)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cash Return"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Return in Dollar :"
        '
        'TxtReturnDolar
        '
        Me.TxtReturnDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReturnDolar.ForeColor = System.Drawing.Color.Red
        Me.TxtReturnDolar.Location = New System.Drawing.Point(92, 57)
        Me.TxtReturnDolar.Name = "TxtReturnDolar"
        Me.TxtReturnDolar.Size = New System.Drawing.Size(206, 26)
        Me.TxtReturnDolar.TabIndex = 1
        Me.TxtReturnDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtReturnReal
        '
        Me.TxtReturnReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReturnReal.ForeColor = System.Drawing.Color.Red
        Me.TxtReturnReal.Location = New System.Drawing.Point(92, 21)
        Me.TxtReturnReal.Name = "TxtReturnReal"
        Me.TxtReturnReal.Size = New System.Drawing.Size(207, 26)
        Me.TxtReturnReal.TabIndex = 0
        Me.TxtReturnReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Return in Riel :"
        '
        'BtnSavePayingReceip
        '
        Me.BtnSavePayingReceip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSavePayingReceip.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1323157036_check
        Me.BtnSavePayingReceip.Location = New System.Drawing.Point(637, 600)
        Me.BtnSavePayingReceip.Name = "BtnSavePayingReceip"
        Me.BtnSavePayingReceip.Size = New System.Drawing.Size(151, 49)
        Me.BtnSavePayingReceip.TabIndex = 1
        Me.BtnSavePayingReceip.Text = "Pay Invoice"
        Me.BtnSavePayingReceip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSavePayingReceip.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.BtnCancel.Location = New System.Drawing.Point(794, 600)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(122, 49)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrPayment
        '
        Me.ErrPayment.ContainerControl = Me
        '
        'LblIsPaidStatus
        '
        Me.LblIsPaidStatus.AutoSize = True
        Me.LblIsPaidStatus.Location = New System.Drawing.Point(305, 612)
        Me.LblIsPaidStatus.Name = "LblIsPaidStatus"
        Me.LblIsPaidStatus.Size = New System.Drawing.Size(45, 13)
        Me.LblIsPaidStatus.TabIndex = 3
        Me.LblIsPaidStatus.Text = "Label19"
        Me.LblIsPaidStatus.Visible = False
        '
        'RadLV
        '
        Me.RadLV.AutoSize = True
        Me.RadLV.Location = New System.Drawing.Point(101, 67)
        Me.RadLV.Name = "RadLV"
        Me.RadLV.Size = New System.Drawing.Size(75, 17)
        Me.RadLV.TabIndex = 2
        Me.RadLV.TabStop = True
        Me.RadLV.Text = "LV Device"
        Me.RadLV.UseVisualStyleBackColor = True
        '
        'FormPayment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(924, 657)
        Me.Controls.Add(Me.LblIsPaidStatus)
        Me.Controls.Add(Me.TxtPayByFund)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtPayBySelf)
        Me.Controls.Add(Me.BtnSavePayingReceip)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPayment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBPaymentType.ResumeLayout(False)
        Me.GBPaymentType.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GPIncomeType.ResumeLayout(False)
        Me.GPIncomeType.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAmountInWord As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtAmountDolar As System.Windows.Forms.TextBox
    Friend WithEvents TxtAmounInReal As System.Windows.Forms.TextBox
    Friend WithEvents ChDolar As System.Windows.Forms.CheckBox
    Friend WithEvents ChReal As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtReturnDolar As System.Windows.Forms.TextBox
    Friend WithEvents TxtReturnReal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblReceiptNo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblReceiptDate As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotalAsReal As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAsDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtPayByFund As System.Windows.Forms.TextBox
    Friend WithEvents TxtPayBySelf As System.Windows.Forms.TextBox
    Friend WithEvents TxtFundName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnSavePayingReceip As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblReceiptID As System.Windows.Forms.Label
    Friend WithEvents ErrPayment As System.Windows.Forms.ErrorProvider
    Friend WithEvents RadPayDolar As System.Windows.Forms.RadioButton
    Friend WithEvents RadPayRiel As System.Windows.Forms.RadioButton
    Friend WithEvents GPIncomeType As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadOther As System.Windows.Forms.RadioButton
    Friend WithEvents RadReadMod As System.Windows.Forms.RadioButton
    Friend WithEvents RadFundRaising As System.Windows.Forms.RadioButton
    Friend WithEvents RadSunGlasses As System.Windows.Forms.RadioButton
    Friend WithEvents RadSpectacle As System.Windows.Forms.RadioButton
    Friend WithEvents RadMedicine As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtDonateAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblIsPaidStatus As System.Windows.Forms.Label
    Friend WithEvents LblAmountInFigureR As System.Windows.Forms.Label
    Friend WithEvents LblAmountInFigureD As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GBPaymentType As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents RadKHR As System.Windows.Forms.RadioButton
    Friend WithEvents RadUSD As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSocialAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtNilAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtFullAmount As System.Windows.Forms.TextBox
    Friend WithEvents RadSocial As System.Windows.Forms.RadioButton
    Friend WithEvents RadNil As System.Windows.Forms.RadioButton
    Friend WithEvents RadFull As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtComment As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtTemSocialAmount As System.Windows.Forms.TextBox
    Friend WithEvents RadLV As System.Windows.Forms.RadioButton
End Class
