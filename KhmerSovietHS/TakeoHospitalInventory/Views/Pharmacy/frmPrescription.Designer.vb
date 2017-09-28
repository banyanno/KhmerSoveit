<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrescription
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
        Dim GridPatientInformation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrescription))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadPatientNo = New System.Windows.Forms.RadioButton
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridPatientInformation = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtPatientNoReal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNameKh = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtTempPatientNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.TxtPatOccupation = New System.Windows.Forms.TextBox
        Me.TxtPatSex = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPatAge = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboPatient = New System.Windows.Forms.TextBox
        Me.BtnBrowsePatient = New Janus.Windows.EditControls.UIButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbDiagnosis = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LblNew_OldID = New System.Windows.Forms.Label
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.TxtDoctorNo = New System.Windows.Forms.TextBox
        Me.BtnBrowseDoctor = New Janus.Windows.EditControls.UIButton
        Me.TxtDocSex = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateCreatePrescrip = New System.Windows.Forms.DateTimePicker
        Me.GridMedicine = New System.Windows.Forms.DataGridView
        Me.cItemID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRemark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cIsOutsideMedicine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContainerID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabourFacID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BtnAddMedicine = New System.Windows.Forms.Button
        Me.BtnRemveMedicine = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrorPrescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveStatus = New System.Windows.Forms.Label
        Me.BgLoadPatient = New System.ComponentModel.BackgroundWorker
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.LblLoading = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadPatientName)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CboPatient)
        Me.GroupBox1.Controls.Add(Me.BtnBrowsePatient)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1013, 271)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find By"
        '
        'RadPatientNo
        '
        Me.RadPatientNo.AutoSize = True
        Me.RadPatientNo.ForeColor = System.Drawing.Color.Blue
        Me.RadPatientNo.Location = New System.Drawing.Point(107, 23)
        Me.RadPatientNo.Name = "RadPatientNo"
        Me.RadPatientNo.Size = New System.Drawing.Size(75, 17)
        Me.RadPatientNo.TabIndex = 12
        Me.RadPatientNo.Text = "Patient No"
        Me.RadPatientNo.UseVisualStyleBackColor = True
        '
        'RadPatientName
        '
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Checked = True
        Me.RadPatientName.ForeColor = System.Drawing.Color.Blue
        Me.RadPatientName.Location = New System.Drawing.Point(12, 23)
        Me.RadPatientName.Name = "RadPatientName"
        Me.RadPatientName.Size = New System.Drawing.Size(89, 17)
        Me.RadPatientName.TabIndex = 11
        Me.RadPatientName.TabStop = True
        Me.RadPatientName.Text = "Patient Name"
        Me.RadPatientName.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GridPatientInformation)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 50)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(569, 207)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient Information"
        '
        'GridPatientInformation
        '
        Me.GridPatientInformation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPatientInformation_DesignTimeLayout.LayoutString = resources.GetString("GridPatientInformation_DesignTimeLayout.LayoutString")
        Me.GridPatientInformation.DesignTimeLayout = GridPatientInformation_DesignTimeLayout
        Me.GridPatientInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientInformation.GroupByBoxVisible = False
        Me.GridPatientInformation.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientInformation.Location = New System.Drawing.Point(2, 15)
        Me.GridPatientInformation.Margin = New System.Windows.Forms.Padding(2)
        Me.GridPatientInformation.Name = "GridPatientInformation"
        Me.GridPatientInformation.RecordNavigator = True
        Me.GridPatientInformation.Size = New System.Drawing.Size(565, 190)
        Me.GridPatientInformation.TabIndex = 0
        Me.GridPatientInformation.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtPatientNoReal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtNameKh)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtTempPatientNo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtPatientName)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.TxtPatOccupation)
        Me.GroupBox2.Controls.Add(Me.TxtPatSex)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtPatAge)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(584, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 232)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Info"
        '
        'TxtPatientNoReal
        '
        Me.TxtPatientNoReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPatientNoReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNoReal.Location = New System.Drawing.Point(86, 39)
        Me.TxtPatientNoReal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatientNoReal.Name = "TxtPatientNoReal"
        Me.TxtPatientNoReal.ReadOnly = True
        Me.TxtPatientNoReal.Size = New System.Drawing.Size(318, 26)
        Me.TxtPatientNoReal.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Patient No:"
        '
        'TxtNameKh
        '
        Me.TxtNameKh.BackColor = System.Drawing.Color.White
        Me.TxtNameKh.Font = New System.Drawing.Font("Wat Phnom T3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameKh.Location = New System.Drawing.Point(86, 79)
        Me.TxtNameKh.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNameKh.Name = "TxtNameKh"
        Me.TxtNameKh.ReadOnly = True
        Me.TxtNameKh.Size = New System.Drawing.Size(138, 34)
        Me.TxtNameKh.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name: *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sex:"
        '
        'TxtTempPatientNo
        '
        Me.TxtTempPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTempPatientNo.Location = New System.Drawing.Point(12, 19)
        Me.TxtTempPatientNo.Name = "TxtTempPatientNo"
        Me.TxtTempPatientNo.Size = New System.Drawing.Size(163, 20)
        Me.TxtTempPatientNo.TabIndex = 7
        Me.TxtTempPatientNo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Age:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BackColor = System.Drawing.Color.White
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtPatientName.Location = New System.Drawing.Point(268, 81)
        Me.TxtPatientName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.ReadOnly = True
        Me.TxtPatientName.Size = New System.Drawing.Size(136, 26)
        Me.TxtPatientName.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(86, 168)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(318, 34)
        Me.txtAddress.TabIndex = 7
        '
        'TxtPatOccupation
        '
        Me.TxtPatOccupation.BackColor = System.Drawing.Color.White
        Me.TxtPatOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatOccupation.Location = New System.Drawing.Point(86, 125)
        Me.TxtPatOccupation.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatOccupation.Name = "TxtPatOccupation"
        Me.TxtPatOccupation.ReadOnly = True
        Me.TxtPatOccupation.Size = New System.Drawing.Size(138, 26)
        Me.TxtPatOccupation.TabIndex = 4
        '
        'TxtPatSex
        '
        Me.TxtPatSex.BackColor = System.Drawing.Color.White
        Me.TxtPatSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatSex.Location = New System.Drawing.Point(268, 124)
        Me.TxtPatSex.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatSex.Name = "TxtPatSex"
        Me.TxtPatSex.ReadOnly = True
        Me.TxtPatSex.Size = New System.Drawing.Size(37, 26)
        Me.TxtPatSex.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Occupation:"
        '
        'TxtPatAge
        '
        Me.TxtPatAge.BackColor = System.Drawing.Color.White
        Me.TxtPatAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatAge.Location = New System.Drawing.Point(354, 125)
        Me.TxtPatAge.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatAge.Name = "TxtPatAge"
        Me.TxtPatAge.ReadOnly = True
        Me.TxtPatAge.Size = New System.Drawing.Size(50, 26)
        Me.TxtPatAge.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 179)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Address:"
        '
        'CboPatient
        '
        Me.CboPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CboPatient.Location = New System.Drawing.Point(187, 18)
        Me.CboPatient.Margin = New System.Windows.Forms.Padding(2)
        Me.CboPatient.Name = "CboPatient"
        Me.CboPatient.Size = New System.Drawing.Size(242, 30)
        Me.CboPatient.TabIndex = 0
        '
        'BtnBrowsePatient
        '
        Me.BtnBrowsePatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowsePatient.Location = New System.Drawing.Point(435, 17)
        Me.BtnBrowsePatient.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBrowsePatient.Name = "BtnBrowsePatient"
        Me.BtnBrowsePatient.Size = New System.Drawing.Size(93, 33)
        Me.BtnBrowsePatient.TabIndex = 1
        Me.BtnBrowsePatient.Text = "Find"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(338, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Diagnosis:"
        '
        'CbDiagnosis
        '
        Me.CbDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbDiagnosis.FormattingEnabled = True
        Me.CbDiagnosis.Location = New System.Drawing.Point(399, 48)
        Me.CbDiagnosis.Name = "CbDiagnosis"
        Me.CbDiagnosis.Size = New System.Drawing.Size(318, 28)
        Me.CbDiagnosis.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.LblNew_OldID)
        Me.GroupBox4.Controls.Add(Me.CboDoctor)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TxtDoctorNo)
        Me.GroupBox4.Controls.Add(Me.BtnBrowseDoctor)
        Me.GroupBox4.Controls.Add(Me.CbDiagnosis)
        Me.GroupBox4.Controls.Add(Me.TxtDocSex)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.DateCreatePrescrip)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 279)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(1015, 88)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Doctor Info"
        '
        'LblNew_OldID
        '
        Me.LblNew_OldID.AutoSize = True
        Me.LblNew_OldID.Location = New System.Drawing.Point(500, 19)
        Me.LblNew_OldID.Name = "LblNew_OldID"
        Me.LblNew_OldID.Size = New System.Drawing.Size(13, 13)
        Me.LblNew_OldID.TabIndex = 22
        Me.LblNew_OldID.Text = "0"
        Me.LblNew_OldID.Visible = False
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(86, 18)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(236, 28)
        Me.CboDoctor.TabIndex = 21
        '
        'TxtDoctorNo
        '
        Me.TxtDoctorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDoctorNo.Location = New System.Drawing.Point(739, 12)
        Me.TxtDoctorNo.Name = "TxtDoctorNo"
        Me.TxtDoctorNo.Size = New System.Drawing.Size(71, 20)
        Me.TxtDoctorNo.TabIndex = 20
        Me.TxtDoctorNo.Visible = False
        '
        'BtnBrowseDoctor
        '
        Me.BtnBrowseDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowseDoctor.Location = New System.Drawing.Point(847, 45)
        Me.BtnBrowseDoctor.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBrowseDoctor.Name = "BtnBrowseDoctor"
        Me.BtnBrowseDoctor.Size = New System.Drawing.Size(35, 26)
        Me.BtnBrowseDoctor.TabIndex = 1
        Me.BtnBrowseDoctor.Text = "..."
        Me.BtnBrowseDoctor.Visible = False
        Me.BtnBrowseDoctor.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'TxtDocSex
        '
        Me.TxtDocSex.BackColor = System.Drawing.Color.White
        Me.TxtDocSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocSex.Location = New System.Drawing.Point(847, 11)
        Me.TxtDocSex.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDocSex.Name = "TxtDocSex"
        Me.TxtDocSex.ReadOnly = True
        Me.TxtDocSex.Size = New System.Drawing.Size(37, 26)
        Me.TxtDocSex.TabIndex = 2
        Me.TxtDocSex.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(815, 19)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sex:"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Doctor Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Issue Date:"
        '
        'DateCreatePrescrip
        '
        Me.DateCreatePrescrip.CustomFormat = "dd/MM/yyyy"
        Me.DateCreatePrescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreatePrescrip.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCreatePrescrip.Location = New System.Drawing.Point(86, 52)
        Me.DateCreatePrescrip.Margin = New System.Windows.Forms.Padding(2)
        Me.DateCreatePrescrip.Name = "DateCreatePrescrip"
        Me.DateCreatePrescrip.Size = New System.Drawing.Size(236, 26)
        Me.DateCreatePrescrip.TabIndex = 3
        '
        'GridMedicine
        '
        Me.GridMedicine.AllowUserToAddRows = False
        Me.GridMedicine.AllowUserToDeleteRows = False
        Me.GridMedicine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMedicine.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GridMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridMedicine.ColumnHeadersHeight = 30
        Me.GridMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridMedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemID, Me.cItemName, Me.cQuantity, Me.cItemUnitID, Me.cRemark, Me.cIsOutsideMedicine, Me.ContainerID, Me.LabourFacID})
        Me.GridMedicine.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GridMedicine.Location = New System.Drawing.Point(9, 382)
        Me.GridMedicine.Margin = New System.Windows.Forms.Padding(2)
        Me.GridMedicine.Name = "GridMedicine"
        Me.GridMedicine.ReadOnly = True
        Me.GridMedicine.RowTemplate.Height = 30
        Me.GridMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridMedicine.Size = New System.Drawing.Size(1012, 219)
        Me.GridMedicine.TabIndex = 3
        '
        'cItemID
        '
        Me.cItemID.HeaderText = "ItemID"
        Me.cItemID.Name = "cItemID"
        Me.cItemID.ReadOnly = True
        Me.cItemID.Visible = False
        Me.cItemID.Width = 50
        '
        'cItemName
        '
        Me.cItemName.HeaderText = "Medicine"
        Me.cItemName.Name = "cItemName"
        Me.cItemName.ReadOnly = True
        Me.cItemName.Width = 250
        '
        'cQuantity
        '
        Me.cQuantity.HeaderText = "Quantity"
        Me.cQuantity.Name = "cQuantity"
        Me.cQuantity.ReadOnly = True
        '
        'cItemUnitID
        '
        Me.cItemUnitID.HeaderText = "Unit of Measuring"
        Me.cItemUnitID.Name = "cItemUnitID"
        Me.cItemUnitID.ReadOnly = True
        Me.cItemUnitID.Visible = False
        '
        'cRemark
        '
        Me.cRemark.HeaderText = "Remark"
        Me.cRemark.Name = "cRemark"
        Me.cRemark.ReadOnly = True
        Me.cRemark.Width = 200
        '
        'cIsOutsideMedicine
        '
        Me.cIsOutsideMedicine.HeaderText = "Medicine In Hospital"
        Me.cIsOutsideMedicine.Name = "cIsOutsideMedicine"
        Me.cIsOutsideMedicine.ReadOnly = True
        Me.cIsOutsideMedicine.Visible = False
        Me.cIsOutsideMedicine.Width = 200
        '
        'ContainerID
        '
        Me.ContainerID.HeaderText = "Containing"
        Me.ContainerID.Name = "ContainerID"
        Me.ContainerID.ReadOnly = True
        Me.ContainerID.Visible = False
        '
        'LabourFacID
        '
        Me.LabourFacID.HeaderText = "Labouratory"
        Me.LabourFacID.Name = "LabourFacID"
        Me.LabourFacID.ReadOnly = True
        Me.LabourFacID.Visible = False
        '
        'BtnAddMedicine
        '
        Me.BtnAddMedicine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedicine.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.BtnAddMedicine.Location = New System.Drawing.Point(1027, 383)
        Me.BtnAddMedicine.Name = "BtnAddMedicine"
        Me.BtnAddMedicine.Size = New System.Drawing.Size(33, 31)
        Me.BtnAddMedicine.TabIndex = 4
        Me.BtnAddMedicine.TabStop = False
        Me.BtnAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddMedicine.UseVisualStyleBackColor = True
        '
        'BtnRemveMedicine
        '
        Me.BtnRemveMedicine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemveMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRemveMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemveMedicine.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.BtnRemveMedicine.Location = New System.Drawing.Point(1027, 420)
        Me.BtnRemveMedicine.Name = "BtnRemveMedicine"
        Me.BtnRemveMedicine.Size = New System.Drawing.Size(33, 31)
        Me.BtnRemveMedicine.TabIndex = 5
        Me.BtnRemveMedicine.TabStop = False
        Me.BtnRemveMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemveMedicine.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.BtnSave.Location = New System.Drawing.Point(846, 606)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 37)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.BtnCancel.Location = New System.Drawing.Point(939, 606)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(85, 37)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrorPrescription
        '
        Me.ErrorPrescription.ContainerControl = Me
        '
        'LblSaveStatus
        '
        Me.LblSaveStatus.AutoSize = True
        Me.LblSaveStatus.Location = New System.Drawing.Point(255, 630)
        Me.LblSaveStatus.Name = "LblSaveStatus"
        Me.LblSaveStatus.Size = New System.Drawing.Size(76, 13)
        Me.LblSaveStatus.TabIndex = 20
        Me.LblSaveStatus.Text = "LblSaveStatus"
        Me.LblSaveStatus.Visible = False
        '
        'BgLoadPatient
        '
        '
        'PictLoading
        '
        Me.PictLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar1
        Me.PictLoading.Location = New System.Drawing.Point(58, 620)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(130, 23)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 21
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'LblLoading
        '
        Me.LblLoading.AutoSize = True
        Me.LblLoading.Location = New System.Drawing.Point(6, 626)
        Me.LblLoading.Name = "LblLoading"
        Me.LblLoading.Size = New System.Drawing.Size(45, 13)
        Me.LblLoading.TabIndex = 22
        Me.LblLoading.Text = "Loading"
        Me.LblLoading.Visible = False
        '
        'frmPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 648)
        Me.Controls.Add(Me.LblLoading)
        Me.Controls.Add(Me.PictLoading)
        Me.Controls.Add(Me.LblSaveStatus)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnRemveMedicine)
        Me.Controls.Add(Me.BtnAddMedicine)
        Me.Controls.Add(Me.GridMedicine)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrescription"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GridMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPatAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatOccupation As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnBrowsePatient As Janus.Windows.EditControls.UIButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateCreatePrescrip As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDocSex As System.Windows.Forms.TextBox
    Friend WithEvents GridMedicine As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAddMedicine As System.Windows.Forms.Button
    Friend WithEvents BtnRemveMedicine As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnBrowseDoctor As Janus.Windows.EditControls.UIButton
    Friend WithEvents TxtTempPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDoctorNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorPrescription As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveStatus As System.Windows.Forms.Label
    Friend WithEvents BgLoadPatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents LblLoading As System.Windows.Forms.Label
    Friend WithEvents CboPatient As System.Windows.Forms.TextBox
    Friend WithEvents TxtNameKh As System.Windows.Forms.TextBox
    Friend WithEvents cItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemUnitID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRemark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIsOutsideMedicine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContainerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabourFacID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblNew_OldID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPatientInformation As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtPatientNoReal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
End Class
