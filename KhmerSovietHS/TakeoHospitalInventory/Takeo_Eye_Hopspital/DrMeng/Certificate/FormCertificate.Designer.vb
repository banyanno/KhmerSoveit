<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCertificate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCertificate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.DateStayTo = New System.Windows.Forms.DateTimePicker
        Me.DateStayFrom = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboPeriod = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtUnderwent = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtMedicalFinding = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateExamination = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtSex = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnLoadPatientNo = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateCreate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrCertificate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Medical Certificate"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.DateStayTo)
        Me.GroupBox1.Controls.Add(Me.DateStayFrom)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CboPeriod)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtUnderwent)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtMedicalFinding)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DateExamination)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtSex)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnLoadPatientNo)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateCreate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(5, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 673)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(589, 125)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 25
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'CboDoctor
        '
        Me.CboDoctor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(570, 627)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(246, 28)
        Me.CboDoctor.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(406, 635)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 20)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Staff Opthalmologist:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(263, 597)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "To:"
        '
        'DateStayTo
        '
        Me.DateStayTo.Checked = False
        Me.DateStayTo.CustomFormat = "dd  -  MMM  -   yyyy"
        Me.DateStayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateStayTo.Location = New System.Drawing.Point(300, 591)
        Me.DateStayTo.Name = "DateStayTo"
        Me.DateStayTo.ShowCheckBox = True
        Me.DateStayTo.Size = New System.Drawing.Size(190, 26)
        Me.DateStayTo.TabIndex = 11
        '
        'DateStayFrom
        '
        Me.DateStayFrom.Checked = False
        Me.DateStayFrom.CustomFormat = "dd  -  MMM  -   yyyy"
        Me.DateStayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateStayFrom.Location = New System.Drawing.Point(63, 591)
        Me.DateStayFrom.Name = "DateStayFrom"
        Me.DateStayFrom.ShowCheckBox = True
        Me.DateStayFrom.Size = New System.Drawing.Size(190, 26)
        Me.DateStayFrom.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 597)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "From :"
        '
        'CboPeriod
        '
        Me.CboPeriod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboPeriod.FormattingEnabled = True
        Me.CboPeriod.Items.AddRange(New Object() {"Day", "Week", "Month"})
        Me.CboPeriod.Location = New System.Drawing.Point(663, 559)
        Me.CboPeriod.Name = "CboPeriod"
        Me.CboPeriod.Size = New System.Drawing.Size(151, 28)
        Me.CboPeriod.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 564)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(662, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "The Patient has been recommend to take medical leave of absence from work for a p" & _
            "eriod of "
        '
        'TxtUnderwent
        '
        Me.TxtUnderwent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnderwent.Location = New System.Drawing.Point(6, 403)
        Me.TxtUnderwent.Multiline = True
        Me.TxtUnderwent.Name = "TxtUnderwent"
        Me.TxtUnderwent.Size = New System.Drawing.Size(808, 145)
        Me.TxtUnderwent.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "The Patient has been underwent:"
        '
        'TxtMedicalFinding
        '
        Me.TxtMedicalFinding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMedicalFinding.Location = New System.Drawing.Point(8, 220)
        Me.TxtMedicalFinding.Multiline = True
        Me.TxtMedicalFinding.Name = "TxtMedicalFinding"
        Me.TxtMedicalFinding.Size = New System.Drawing.Size(808, 151)
        Me.TxtMedicalFinding.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(228, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "The Medical Finding/Diagnosis:"
        '
        'DateExamination
        '
        Me.DateExamination.CalendarForeColor = System.Drawing.Color.Red
        Me.DateExamination.Checked = False
        Me.DateExamination.CustomFormat = "dd  -  MMM  -   yyyy"
        Me.DateExamination.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateExamination.Location = New System.Drawing.Point(272, 160)
        Me.DateExamination.Name = "DateExamination"
        Me.DateExamination.ShowCheckBox = True
        Me.DateExamination.Size = New System.Drawing.Size(190, 26)
        Me.DateExamination.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Has Been Examined at this clinic on:"
        '
        'TxtSex
        '
        Me.TxtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSex.Location = New System.Drawing.Point(400, 125)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.ReadOnly = True
        Me.TxtSex.Size = New System.Drawing.Size(61, 26)
        Me.TxtSex.TabIndex = 5
        Me.TxtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sex:"
        '
        'TxtAge
        '
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAge.Location = New System.Drawing.Point(272, 125)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(61, 26)
        Me.TxtAge.TabIndex = 4
        Me.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Age:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientName.Location = New System.Drawing.Point(254, 93)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.ReadOnly = True
        Me.TxtPatientName.Size = New System.Drawing.Size(310, 26)
        Me.TxtPatientName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Patient's Name*:"
        '
        'BtnLoadPatientNo
        '
        Me.BtnLoadPatientNo.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnLoadPatientNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLoadPatientNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoadPatientNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLoadPatientNo.ForeColor = System.Drawing.Color.White
        Me.BtnLoadPatientNo.Location = New System.Drawing.Point(570, 59)
        Me.BtnLoadPatientNo.Name = "BtnLoadPatientNo"
        Me.BtnLoadPatientNo.Size = New System.Drawing.Size(121, 28)
        Me.BtnLoadPatientNo.TabIndex = 2
        Me.BtnLoadPatientNo.Text = "Load Patient"
        Me.BtnLoadPatientNo.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientNo.Location = New System.Drawing.Point(254, 61)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(310, 26)
        Me.TxtPatientNo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "This certifies that(Patient Name)*:"
        '
        'DateCreate
        '
        Me.DateCreate.CalendarForeColor = System.Drawing.Color.Red
        Me.DateCreate.Checked = False
        Me.DateCreate.CustomFormat = "dd  -  MMM  -   yyyy"
        Me.DateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCreate.Location = New System.Drawing.Point(75, 25)
        Me.DateCreate.Name = "DateCreate"
        Me.DateCreate.ShowCheckBox = True
        Me.DateCreate.Size = New System.Drawing.Size(192, 26)
        Me.DateCreate.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date * :"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(586, 712)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(121, 40)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(713, 712)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(121, 40)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrCertificate
        '
        Me.ErrCertificate.ContainerControl = Me
        '
        'FormCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(846, 755)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCertificate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Certificate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateCreate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnLoadPatientNo As System.Windows.Forms.Button
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSex As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateExamination As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtUnderwent As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtMedicalFinding As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateStayTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateStayFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrCertificate As System.Windows.Forms.ErrorProvider
End Class
