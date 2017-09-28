<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMOTRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMOTRegistration))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ChPrepareOT = New System.Windows.Forms.CheckBox
        Me.TxtOther = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtSex = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtInpatientNo = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblIOLIDOLD = New System.Windows.Forms.Label
        Me.CboIOLItem = New System.Windows.Forms.ComboBox
        Me.DateOperated = New System.Windows.Forms.DateTimePicker
        Me.CboAnesthetist = New System.Windows.Forms.ComboBox
        Me.TxtCirculation = New System.Windows.Forms.ComboBox
        Me.CboAssistant = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CboOperationType = New System.Windows.Forms.ComboBox
        Me.CboSurgeon = New System.Windows.Forms.ComboBox
        Me.CboEye = New System.Windows.Forms.ComboBox
        Me.TxtCompli = New System.Windows.Forms.TextBox
        Me.TxtAnesthesia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboOperationTime = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ChOT = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrOT = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label12 = New System.Windows.Forms.Label
        Me.DateOT = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ChPrepareOT)
        Me.GroupBox4.Controls.Add(Me.TxtOther)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TxtAddress)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxtSex)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtAge)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TxtPatientName)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TxtInpatientNo)
        Me.GroupBox4.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(5, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(704, 220)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "In-patient info"
        '
        'ChPrepareOT
        '
        Me.ChPrepareOT.AutoSize = True
        Me.ChPrepareOT.Checked = True
        Me.ChPrepareOT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChPrepareOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPrepareOT.Location = New System.Drawing.Point(491, 26)
        Me.ChPrepareOT.Name = "ChPrepareOT"
        Me.ChPrepareOT.Size = New System.Drawing.Size(167, 21)
        Me.ChPrepareOT.TabIndex = 25
        Me.ChPrepareOT.Text = "Prepare To OT List"
        Me.ChPrepareOT.UseVisualStyleBackColor = True
        Me.ChPrepareOT.Visible = False
        '
        'TxtOther
        '
        Me.TxtOther.BackColor = System.Drawing.Color.White
        Me.TxtOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOther.Location = New System.Drawing.Point(11, 181)
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(523, 26)
        Me.TxtOther.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Other:"
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(10, 129)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(525, 26)
        Me.TxtAddress.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address:"
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.Location = New System.Drawing.Point(491, 74)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.ReadOnly = True
        Me.TxtSex.Size = New System.Drawing.Size(43, 26)
        Me.TxtSex.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(451, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sex:"
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(407, 74)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(43, 26)
        Me.TxtAge.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Age:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientName.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(122, 65)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.ReadOnly = True
        Me.TxtPatientName.Size = New System.Drawing.Size(236, 37)
        Me.TxtPatientName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Patient Name:"
        '
        'TxtInpatientNo
        '
        Me.TxtInpatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInpatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInpatientNo.Location = New System.Drawing.Point(564, 74)
        Me.TxtInpatientNo.Name = "TxtInpatientNo"
        Me.TxtInpatientNo.ReadOnly = True
        Me.TxtInpatientNo.Size = New System.Drawing.Size(27, 26)
        Me.TxtInpatientNo.TabIndex = 1
        Me.TxtInpatientNo.Visible = False
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(122, 28)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.ReadOnly = True
        Me.TxtPatientNo.Size = New System.Drawing.Size(236, 26)
        Me.TxtPatientNo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient No:"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(474, 226)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 15
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.lblIOLIDOLD)
        Me.GroupBox5.Controls.Add(Me.CboIOLItem)
        Me.GroupBox5.Controls.Add(Me.DateOperated)
        Me.GroupBox5.Controls.Add(Me.LblSaveOption)
        Me.GroupBox5.Controls.Add(Me.CboAnesthetist)
        Me.GroupBox5.Controls.Add(Me.TxtCirculation)
        Me.GroupBox5.Controls.Add(Me.CboAssistant)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.CboOperationType)
        Me.GroupBox5.Controls.Add(Me.CboSurgeon)
        Me.GroupBox5.Controls.Add(Me.CboEye)
        Me.GroupBox5.Controls.Add(Me.TxtCompli)
        Me.GroupBox5.Controls.Add(Me.TxtAnesthesia)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.CboOperationTime)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.ChOT)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(4, 266)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(705, 358)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Registration OT"
        '
        'lblIOLIDOLD
        '
        Me.lblIOLIDOLD.AutoSize = True
        Me.lblIOLIDOLD.Location = New System.Drawing.Point(582, 226)
        Me.lblIOLIDOLD.Name = "lblIOLIDOLD"
        Me.lblIOLIDOLD.Size = New System.Drawing.Size(18, 20)
        Me.lblIOLIDOLD.TabIndex = 20
        Me.lblIOLIDOLD.Text = "0"
        Me.lblIOLIDOLD.Visible = False
        '
        'CboIOLItem
        '
        Me.CboIOLItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboIOLItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboIOLItem.DropDownWidth = 550
        Me.CboIOLItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIOLItem.FormattingEnabled = True
        Me.CboIOLItem.Location = New System.Drawing.Point(598, 161)
        Me.CboIOLItem.Name = "CboIOLItem"
        Me.CboIOLItem.Size = New System.Drawing.Size(173, 28)
        Me.CboIOLItem.TabIndex = 19
        Me.CboIOLItem.Visible = False
        '
        'DateOperated
        '
        Me.DateOperated.Checked = False
        Me.DateOperated.CustomFormat = "dd/MM/yyyy"
        Me.DateOperated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOperated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOperated.Location = New System.Drawing.Point(494, 34)
        Me.DateOperated.Name = "DateOperated"
        Me.DateOperated.ShowCheckBox = True
        Me.DateOperated.Size = New System.Drawing.Size(188, 26)
        Me.DateOperated.TabIndex = 3
        Me.DateOperated.Visible = False
        '
        'CboAnesthetist
        '
        Me.CboAnesthetist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAnesthetist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAnesthetist.DropDownHeight = 500
        Me.CboAnesthetist.DropDownWidth = 300
        Me.CboAnesthetist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAnesthetist.FormattingEnabled = True
        Me.CboAnesthetist.IntegralHeight = False
        Me.CboAnesthetist.Location = New System.Drawing.Point(498, 80)
        Me.CboAnesthetist.Name = "CboAnesthetist"
        Me.CboAnesthetist.Size = New System.Drawing.Size(188, 28)
        Me.CboAnesthetist.TabIndex = 4
        '
        'TxtCirculation
        '
        Me.TxtCirculation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtCirculation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtCirculation.DropDownHeight = 500
        Me.TxtCirculation.DropDownWidth = 300
        Me.TxtCirculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCirculation.FormattingEnabled = True
        Me.TxtCirculation.IntegralHeight = False
        Me.TxtCirculation.Location = New System.Drawing.Point(154, 282)
        Me.TxtCirculation.Name = "TxtCirculation"
        Me.TxtCirculation.Size = New System.Drawing.Size(290, 28)
        Me.TxtCirculation.TabIndex = 8
        '
        'CboAssistant
        '
        Me.CboAssistant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAssistant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAssistant.DropDownHeight = 500
        Me.CboAssistant.DropDownWidth = 300
        Me.CboAssistant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAssistant.FormattingEnabled = True
        Me.CboAssistant.IntegralHeight = False
        Me.CboAssistant.Location = New System.Drawing.Point(154, 242)
        Me.CboAssistant.Name = "CboAssistant"
        Me.CboAssistant.Size = New System.Drawing.Size(289, 28)
        Me.CboAssistant.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 20)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Operation Type:"
        '
        'CboOperationType
        '
        Me.CboOperationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboOperationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboOperationType.DropDownHeight = 500
        Me.CboOperationType.DropDownWidth = 350
        Me.CboOperationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOperationType.FormattingEnabled = True
        Me.CboOperationType.IntegralHeight = False
        Me.CboOperationType.Location = New System.Drawing.Point(154, 163)
        Me.CboOperationType.Name = "CboOperationType"
        Me.CboOperationType.Size = New System.Drawing.Size(290, 28)
        Me.CboOperationType.TabIndex = 5
        '
        'CboSurgeon
        '
        Me.CboSurgeon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSurgeon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSurgeon.DropDownHeight = 500
        Me.CboSurgeon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSurgeon.FormattingEnabled = True
        Me.CboSurgeon.IntegralHeight = False
        Me.CboSurgeon.Location = New System.Drawing.Point(154, 202)
        Me.CboSurgeon.Name = "CboSurgeon"
        Me.CboSurgeon.Size = New System.Drawing.Size(289, 28)
        Me.CboSurgeon.TabIndex = 6
        '
        'CboEye
        '
        Me.CboEye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboEye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEye.FormattingEnabled = True
        Me.CboEye.Items.AddRange(New Object() {"", "Right Eye", "Left Eye", "Both Eye"})
        Me.CboEye.Location = New System.Drawing.Point(154, 123)
        Me.CboEye.Name = "CboEye"
        Me.CboEye.Size = New System.Drawing.Size(194, 28)
        Me.CboEye.TabIndex = 2
        '
        'TxtCompli
        '
        Me.TxtCompli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCompli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompli.Location = New System.Drawing.Point(154, 322)
        Me.TxtCompli.Name = "TxtCompli"
        Me.TxtCompli.Size = New System.Drawing.Size(290, 26)
        Me.TxtCompli.TabIndex = 9
        '
        'TxtAnesthesia
        '
        Me.TxtAnesthesia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAnesthesia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnesthesia.Location = New System.Drawing.Point(154, 82)
        Me.TxtAnesthesia.Name = "TxtAnesthesia"
        Me.TxtAnesthesia.Size = New System.Drawing.Size(193, 26)
        Me.TxtAnesthesia.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Compli:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Circulating:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 247)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Scrub:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(27, 210)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Surgeon:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Eye:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(355, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Anesthesionlogist:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Anesthesia:"
        '
        'CboOperationTime
        '
        Me.CboOperationTime.Checked = False
        Me.CboOperationTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOperationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.CboOperationTime.Location = New System.Drawing.Point(154, 34)
        Me.CboOperationTime.Name = "CboOperationTime"
        Me.CboOperationTime.ShowCheckBox = True
        Me.CboOperationTime.ShowUpDown = True
        Me.CboOperationTime.Size = New System.Drawing.Size(194, 26)
        Me.CboOperationTime.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(355, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Date Operated:"
        Me.Label13.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Operated Time:"
        '
        'ChOT
        '
        Me.ChOT.AutoSize = True
        Me.ChOT.Location = New System.Drawing.Point(534, 276)
        Me.ChOT.Name = "ChOT"
        Me.ChOT.Size = New System.Drawing.Size(68, 24)
        Me.ChOT.TabIndex = 16
        Me.ChOT.Text = "Other"
        Me.ChOT.UseVisualStyleBackColor = True
        Me.ChOT.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(509, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 20)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "+ IOL"
        Me.Label19.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(5, 630)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 36)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(102, 630)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(98, 36)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrOT
        '
        Me.ErrOT.ContainerControl = Me
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(9, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Date Prepare OT:"
        '
        'DateOT
        '
        Me.DateOT.Checked = False
        Me.DateOT.CustomFormat = "dd/MM/yyyy"
        Me.DateOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOT.Location = New System.Drawing.Point(148, 11)
        Me.DateOT.Name = "DateOT"
        Me.DateOT.ShowCheckBox = True
        Me.DateOT.Size = New System.Drawing.Size(171, 26)
        Me.DateOT.TabIndex = 0
        '
        'FRMOTRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(722, 674)
        Me.Controls.Add(Me.DateOT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMOTRegistration"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operation Information"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSex As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtInpatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents CboAssistant As System.Windows.Forms.ComboBox
    Friend WithEvents CboSurgeon As System.Windows.Forms.ComboBox
    Friend WithEvents CboEye As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAnesthesia As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboOperationTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboOperationType As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCompli As System.Windows.Forms.TextBox
    Friend WithEvents TxtCirculation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboAnesthetist As System.Windows.Forms.ComboBox
    Friend WithEvents ChOT As System.Windows.Forms.CheckBox
    Friend WithEvents ErrOT As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateOT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateOperated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtOther As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ChPrepareOT As System.Windows.Forms.CheckBox
    Friend WithEvents CboIOLItem As System.Windows.Forms.ComboBox
    Friend WithEvents lblIOLIDOLD As System.Windows.Forms.Label
End Class
