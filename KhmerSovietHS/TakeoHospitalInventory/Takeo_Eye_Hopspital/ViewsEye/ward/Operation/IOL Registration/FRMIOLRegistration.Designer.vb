<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMIOLRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMIOLRegistration))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtSex = New System.Windows.Forms.TextBox
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.txtPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblDateCreateIOL = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CboIOLItem = New System.Windows.Forms.ComboBox
        Me.DateIOL = New System.Windows.Forms.DateTimePicker
        Me.CboEye = New System.Windows.Forms.ComboBox
        Me.CboSurgeon = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblOptionSave = New System.Windows.Forms.Label
        Me.ErrIOL = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblOTNo = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrIOL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtSex)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.txtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient info"
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.Location = New System.Drawing.Point(86, 130)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.Size = New System.Drawing.Size(193, 26)
        Me.TxtSex.TabIndex = 3
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(86, 96)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(193, 26)
        Me.TxtAge.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtName.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(86, 50)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(193, 39)
        Me.TxtName.TabIndex = 1
        '
        'txtPatientNo
        '
        Me.txtPatientNo.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientNo.Location = New System.Drawing.Point(86, 18)
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(193, 26)
        Me.txtPatientNo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sex:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'LblDateCreateIOL
        '
        Me.LblDateCreateIOL.AutoSize = True
        Me.LblDateCreateIOL.Location = New System.Drawing.Point(10, 32)
        Me.LblDateCreateIOL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDateCreateIOL.Name = "LblDateCreateIOL"
        Me.LblDateCreateIOL.Size = New System.Drawing.Size(53, 13)
        Me.LblDateCreateIOL.TabIndex = 4
        Me.LblDateCreateIOL.Text = "Date IOL:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CboIOLItem)
        Me.GroupBox2.Controls.Add(Me.DateIOL)
        Me.GroupBox2.Controls.Add(Me.LblDateCreateIOL)
        Me.GroupBox2.Controls.Add(Me.CboEye)
        Me.GroupBox2.Controls.Add(Me.CboSurgeon)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(5, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 173)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IOL Registration"
        '
        'CboIOLItem
        '
        Me.CboIOLItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboIOLItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboIOLItem.DropDownWidth = 550
        Me.CboIOLItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIOLItem.FormattingEnabled = True
        Me.CboIOLItem.Location = New System.Drawing.Point(81, 131)
        Me.CboIOLItem.Name = "CboIOLItem"
        Me.CboIOLItem.Size = New System.Drawing.Size(198, 28)
        Me.CboIOLItem.TabIndex = 20
        '
        'DateIOL
        '
        Me.DateIOL.Checked = False
        Me.DateIOL.CustomFormat = "dd/MM/yyyy"
        Me.DateIOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateIOL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateIOL.Location = New System.Drawing.Point(81, 24)
        Me.DateIOL.Margin = New System.Windows.Forms.Padding(2)
        Me.DateIOL.Name = "DateIOL"
        Me.DateIOL.ShowCheckBox = True
        Me.DateIOL.Size = New System.Drawing.Size(151, 23)
        Me.DateIOL.TabIndex = 0
        '
        'CboEye
        '
        Me.CboEye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboEye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEye.FormattingEnabled = True
        Me.CboEye.Items.AddRange(New Object() {"", "Right Eye", "Left Eye", "Right / Left Eye"})
        Me.CboEye.Location = New System.Drawing.Point(81, 91)
        Me.CboEye.Name = "CboEye"
        Me.CboEye.Size = New System.Drawing.Size(198, 28)
        Me.CboEye.TabIndex = 2
        '
        'CboSurgeon
        '
        Me.CboSurgeon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboSurgeon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSurgeon.DropDownHeight = 500
        Me.CboSurgeon.DropDownWidth = 300
        Me.CboSurgeon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSurgeon.FormattingEnabled = True
        Me.CboSurgeon.IntegralHeight = False
        Me.CboSurgeon.Location = New System.Drawing.Point(81, 54)
        Me.CboSurgeon.Name = "CboSurgeon"
        Me.CboSurgeon.Size = New System.Drawing.Size(198, 28)
        Me.CboSurgeon.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "IOL Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Eye:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Surgeon:"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(8, 367)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 31)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(103, 367)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(89, 31)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblOptionSave
        '
        Me.LblOptionSave.AutoSize = True
        Me.LblOptionSave.Location = New System.Drawing.Point(271, 376)
        Me.LblOptionSave.Name = "LblOptionSave"
        Me.LblOptionSave.Size = New System.Drawing.Size(13, 13)
        Me.LblOptionSave.TabIndex = 3
        Me.LblOptionSave.Text = "0"
        Me.LblOptionSave.Visible = False
        '
        'ErrIOL
        '
        Me.ErrIOL.ContainerControl = Me
        '
        'LblOTNo
        '
        Me.LblOTNo.AutoSize = True
        Me.LblOTNo.Location = New System.Drawing.Point(290, 376)
        Me.LblOTNo.Name = "LblOTNo"
        Me.LblOTNo.Size = New System.Drawing.Size(13, 13)
        Me.LblOTNo.TabIndex = 4
        Me.LblOTNo.Text = "0"
        Me.LblOTNo.Visible = False
        '
        'FRMIOLRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(307, 405)
        Me.Controls.Add(Me.LblOTNo)
        Me.Controls.Add(Me.LblOptionSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMIOLRegistration"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IOL Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrIOL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CboEye As System.Windows.Forms.ComboBox
    Friend WithEvents CboSurgeon As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblOptionSave As System.Windows.Forms.Label
    Friend WithEvents ErrIOL As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblOTNo As System.Windows.Forms.Label
    Friend WithEvents LblDateCreateIOL As System.Windows.Forms.Label
    Friend WithEvents DateIOL As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboIOLItem As System.Windows.Forms.ComboBox
End Class
