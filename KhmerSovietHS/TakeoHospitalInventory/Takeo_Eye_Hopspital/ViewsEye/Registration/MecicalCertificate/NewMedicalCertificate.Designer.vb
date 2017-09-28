<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMedicalCertificate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewMedicalCertificate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtAdvice = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtSymtom = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtTREATMENT = New System.Windows.Forms.TextBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.DatePrepare = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtPatientOccupation = New System.Windows.Forms.TextBox
        Me.DateExam = New System.Windows.Forms.DateTimePicker
        Me.TxtPatientAddress = New System.Windows.Forms.TextBox
        Me.txtPatientAge = New System.Windows.Forms.TextBox
        Me.TxtPatientSex = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.DateAdvice = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.CboSurgery = New System.Windows.Forms.ComboBox
        Me.DateSurgery = New System.Windows.Forms.DateTimePicker
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.cboEye1 = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrMedicalCertificate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AutocompleteDiagnosis = New AutocompleteMenuNS.AutocompleteMenu
        Me.AutocompleteSurgery = New AutocompleteMenuNS.AutocompleteMenu
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrMedicalCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "លិខិតបញ្ជាក់"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MEDICAL CERTIFICATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.DatePrepare)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtPatientOccupation)
        Me.GroupBox1.Controls.Add(Me.DateExam)
        Me.GroupBox1.Controls.Add(Me.TxtPatientAddress)
        Me.GroupBox1.Controls.Add(Me.txtPatientAge)
        Me.GroupBox1.Controls.Add(Me.TxtPatientSex)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 650)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtAdvice)
        Me.GroupBox3.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 420)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(773, 126)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ដំបូន្មាន :"
        '
        'TxtAdvice
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtAdvice, Nothing)
        Me.TxtAdvice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAdvice.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdvice.Location = New System.Drawing.Point(3, 30)
        Me.TxtAdvice.Multiline = True
        Me.TxtAdvice.Name = "TxtAdvice"
        Me.TxtAdvice.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtAdvice.Size = New System.Drawing.Size(767, 93)
        Me.TxtAdvice.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSymtom)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(773, 232)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "រោគវិនិច្ឆ័យ :"
        '
        'TxtSymtom
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtSymtom, Me.AutocompleteSurgery)
        Me.TxtSymtom.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSymtom.Location = New System.Drawing.Point(12, 30)
        Me.TxtSymtom.Multiline = True
        Me.TxtSymtom.Name = "TxtSymtom"
        Me.TxtSymtom.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtSymtom.Size = New System.Drawing.Size(755, 73)
        Me.TxtSymtom.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTREATMENT)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(758, 112)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "កាព្យបាល :"
        '
        'TxtTREATMENT
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtTREATMENT, Me.AutocompleteSurgery)
        Me.TxtTREATMENT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTREATMENT.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTREATMENT.Location = New System.Drawing.Point(3, 30)
        Me.TxtTREATMENT.Multiline = True
        Me.TxtTREATMENT.Name = "TxtTREATMENT"
        Me.TxtTREATMENT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtTREATMENT.Size = New System.Drawing.Size(752, 79)
        Me.TxtTREATMENT.TabIndex = 0
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(9, 350)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 5
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(438, 18)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(38, 25)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.Text = "..."
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(562, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Age"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(451, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Sex"
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(541, 607)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(273, 28)
        Me.CboDoctor.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(473, 615)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Doctor:"
        '
        'DatePrepare
        '
        Me.DatePrepare.Checked = False
        Me.DatePrepare.CustomFormat = "dd/MM/yyyy"
        Me.DatePrepare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePrepare.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePrepare.Location = New System.Drawing.Point(657, 567)
        Me.DatePrepare.Name = "DatePrepare"
        Me.DatePrepare.ShowCheckBox = True
        Me.DatePrepare.Size = New System.Drawing.Size(157, 26)
        Me.DatePrepare.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(537, 573)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Date Prepare:"
        '
        'TxtPatientOccupation
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtPatientOccupation, Nothing)
        Me.TxtPatientOccupation.BackColor = System.Drawing.Color.White
        Me.TxtPatientOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientOccupation.Location = New System.Drawing.Point(198, 88)
        Me.TxtPatientOccupation.Name = "TxtPatientOccupation"
        Me.TxtPatientOccupation.ReadOnly = True
        Me.TxtPatientOccupation.Size = New System.Drawing.Size(234, 26)
        Me.TxtPatientOccupation.TabIndex = 4
        '
        'DateExam
        '
        Me.DateExam.Checked = False
        Me.DateExam.CustomFormat = "dd/MM/yyyy"
        Me.DateExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateExam.Location = New System.Drawing.Point(198, 156)
        Me.DateExam.Name = "DateExam"
        Me.DateExam.ShowCheckBox = True
        Me.DateExam.Size = New System.Drawing.Size(157, 26)
        Me.DateExam.TabIndex = 7
        '
        'TxtPatientAddress
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtPatientAddress, Nothing)
        Me.TxtPatientAddress.BackColor = System.Drawing.Color.White
        Me.TxtPatientAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientAddress.Location = New System.Drawing.Point(198, 120)
        Me.TxtPatientAddress.Name = "TxtPatientAddress"
        Me.TxtPatientAddress.ReadOnly = True
        Me.TxtPatientAddress.Size = New System.Drawing.Size(616, 26)
        Me.TxtPatientAddress.TabIndex = 6
        '
        'txtPatientAge
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.txtPatientAge, Nothing)
        Me.txtPatientAge.BackColor = System.Drawing.Color.White
        Me.txtPatientAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientAge.Location = New System.Drawing.Point(594, 53)
        Me.txtPatientAge.Name = "txtPatientAge"
        Me.txtPatientAge.ReadOnly = True
        Me.txtPatientAge.Size = New System.Drawing.Size(60, 26)
        Me.txtPatientAge.TabIndex = 5
        '
        'TxtPatientSex
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtPatientSex, Nothing)
        Me.TxtPatientSex.BackColor = System.Drawing.Color.White
        Me.TxtPatientSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientSex.Location = New System.Drawing.Point(482, 53)
        Me.TxtPatientSex.Name = "TxtPatientSex"
        Me.TxtPatientSex.ReadOnly = True
        Me.TxtPatientSex.Size = New System.Drawing.Size(69, 26)
        Me.TxtPatientSex.TabIndex = 3
        '
        'TxtPatientName
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtPatientName, Nothing)
        Me.TxtPatientName.BackColor = System.Drawing.Color.White
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(198, 50)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.ReadOnly = True
        Me.TxtPatientName.Size = New System.Drawing.Size(234, 33)
        Me.TxtPatientName.TabIndex = 2
        '
        'TxtPatientNo
        '
        Me.AutocompleteDiagnosis.SetAutocompleteMenu(Me.TxtPatientNo, Nothing)
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(198, 18)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(234, 26)
        Me.TxtPatientNo.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 27)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "មុខរបរ :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 27)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ថ្ងៃ ខែ ឆ្នាំ ចូលពិនិត្យ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 27)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "អាស័យដ្ឋាន :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "អ្នកជំងឺឈ្មោះ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Patient No:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(885, 513)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 27)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "និងត្រឡប់មកម្តងទៀត"
        Me.Label15.Visible = False
        '
        'DateAdvice
        '
        Me.DateAdvice.Checked = False
        Me.DateAdvice.CustomFormat = "dd/MM/yyyy"
        Me.DateAdvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAdvice.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAdvice.Location = New System.Drawing.Point(908, 543)
        Me.DateAdvice.Name = "DateAdvice"
        Me.DateAdvice.ShowCheckBox = True
        Me.DateAdvice.Size = New System.Drawing.Size(157, 26)
        Me.DateAdvice.TabIndex = 11
        Me.DateAdvice.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(869, 426)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "ថ្ងៃព្យបាល :"
        Me.Label17.Visible = False
        '
        'CboSurgery
        '
        Me.CboSurgery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSurgery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSurgery.FormattingEnabled = True
        Me.CboSurgery.Location = New System.Drawing.Point(888, 446)
        Me.CboSurgery.Name = "CboSurgery"
        Me.CboSurgery.Size = New System.Drawing.Size(139, 28)
        Me.CboSurgery.TabIndex = 9
        Me.CboSurgery.Visible = False
        '
        'DateSurgery
        '
        Me.DateSurgery.Checked = False
        Me.DateSurgery.CustomFormat = "dd/MM/yyyy"
        Me.DateSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateSurgery.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateSurgery.Location = New System.Drawing.Point(952, 427)
        Me.DateSurgery.Name = "DateSurgery"
        Me.DateSurgery.ShowCheckBox = True
        Me.DateSurgery.Size = New System.Drawing.Size(157, 26)
        Me.DateSurgery.TabIndex = 27
        Me.DateSurgery.Visible = False
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(892, 153)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(217, 28)
        Me.CboDiagnosis.TabIndex = 8
        Me.CboDiagnosis.Visible = False
        '
        'cboEye1
        '
        Me.cboEye1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEye1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEye1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEye1.FormattingEnabled = True
        Me.cboEye1.Items.AddRange(New Object() {"Left eye", "Right eye", "Both eye"})
        Me.cboEye1.Location = New System.Drawing.Point(952, 202)
        Me.cboEye1.Name = "cboEye1"
        Me.cboEye1.Size = New System.Drawing.Size(157, 28)
        Me.cboEye1.TabIndex = 10
        Me.cboEye1.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(869, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "នៅលើភ្នែក"
        Me.Label16.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(651, 701)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(98, 33)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(755, 701)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(98, 33)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrMedicalCertificate
        '
        Me.ErrMedicalCertificate.ContainerControl = Me
        '
        'AutocompleteDiagnosis
        '
        Me.AutocompleteDiagnosis.AppearInterval = 100
        Me.AutocompleteDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AutocompleteDiagnosis.ImageList = Nothing
        Me.AutocompleteDiagnosis.Items = New String(-1) {}
        Me.AutocompleteDiagnosis.MinFragmentLength = 1
        Me.AutocompleteDiagnosis.TargetControlWrapper = Nothing
        Me.AutocompleteDiagnosis.ToolTipDuration = 3000
        '
        'AutocompleteSurgery
        '
        Me.AutocompleteSurgery.AppearInterval = 100
        Me.AutocompleteSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AutocompleteSurgery.ImageList = Nothing
        Me.AutocompleteSurgery.Items = New String(-1) {}
        Me.AutocompleteSurgery.MinFragmentLength = 1
        Me.AutocompleteSurgery.TargetControlWrapper = Nothing
        Me.AutocompleteSurgery.ToolTipDuration = 3000
        '
        'NewMedicalCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 748)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.CboDiagnosis)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboEye1)
        Me.Controls.Add(Me.DateAdvice)
        Me.Controls.Add(Me.CboSurgery)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateSurgery)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewMedicalCertificate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Certificate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrMedicalCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateExam As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtPatientAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientOccupation As System.Windows.Forms.TextBox
    Friend WithEvents DateAdvice As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents DatePrepare As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CboSurgery As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboEye1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ErrMedicalCertificate As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents DateSurgery As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAdvice As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtTREATMENT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSymtom As System.Windows.Forms.TextBox
    Friend WithEvents AutocompleteDiagnosis As AutocompleteMenuNS.AutocompleteMenu
    Friend WithEvents AutocompleteSurgery As AutocompleteMenuNS.AutocompleteMenu
End Class
