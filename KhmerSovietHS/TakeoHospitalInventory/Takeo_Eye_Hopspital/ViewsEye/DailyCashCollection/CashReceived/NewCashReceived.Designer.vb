<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCashReceived
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCashReceived))
        Me.GroupOtherReceipt = New System.Windows.Forms.GroupBox
        Me.BtnFindPatient = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.ChPatient = New System.Windows.Forms.CheckBox
        Me.TxtPatientKHName = New System.Windows.Forms.TextBox
        Me.G1 = New System.Windows.Forms.GroupBox
        Me.RadReil = New System.Windows.Forms.RadioButton
        Me.RadDolar = New System.Windows.Forms.RadioButton
        Me.TxtReceivedNote = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboReceivedFrom = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCashReceived = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateReceiptIn = New System.Windows.Forms.DateTimePicker
        Me.txtReceiptNumber = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ErrCashReceived = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblSaveOption = New System.Windows.Forms.Label
        Me.BgSaveNewOtherReceipt = New System.ComponentModel.BackgroundWorker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAmountWord = New System.Windows.Forms.TextBox
        Me.GroupOtherReceipt.SuspendLayout()
        Me.G1.SuspendLayout()
        CType(Me.ErrCashReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupOtherReceipt
        '
        Me.GroupOtherReceipt.Controls.Add(Me.Label7)
        Me.GroupOtherReceipt.Controls.Add(Me.txtAmountWord)
        Me.GroupOtherReceipt.Controls.Add(Me.BtnFindPatient)
        Me.GroupOtherReceipt.Controls.Add(Me.TxtPatientNo)
        Me.GroupOtherReceipt.Controls.Add(Me.ChPatient)
        Me.GroupOtherReceipt.Controls.Add(Me.TxtPatientKHName)
        Me.GroupOtherReceipt.Controls.Add(Me.G1)
        Me.GroupOtherReceipt.Controls.Add(Me.TxtReceivedNote)
        Me.GroupOtherReceipt.Controls.Add(Me.Label4)
        Me.GroupOtherReceipt.Controls.Add(Me.CboReceivedFrom)
        Me.GroupOtherReceipt.Controls.Add(Me.Label3)
        Me.GroupOtherReceipt.Controls.Add(Me.Label2)
        Me.GroupOtherReceipt.Controls.Add(Me.Label1)
        Me.GroupOtherReceipt.Controls.Add(Me.TxtCashReceived)
        Me.GroupOtherReceipt.Controls.Add(Me.Label6)
        Me.GroupOtherReceipt.Controls.Add(Me.DateReceiptIn)
        Me.GroupOtherReceipt.Controls.Add(Me.txtReceiptNumber)
        Me.GroupOtherReceipt.Location = New System.Drawing.Point(9, 54)
        Me.GroupOtherReceipt.Name = "GroupOtherReceipt"
        Me.GroupOtherReceipt.Size = New System.Drawing.Size(708, 439)
        Me.GroupOtherReceipt.TabIndex = 0
        Me.GroupOtherReceipt.TabStop = False
        '
        'BtnFindPatient
        '
        Me.BtnFindPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindPatient.Enabled = False
        Me.BtnFindPatient.Location = New System.Drawing.Point(463, 107)
        Me.BtnFindPatient.Name = "BtnFindPatient"
        Me.BtnFindPatient.Size = New System.Drawing.Size(34, 27)
        Me.BtnFindPatient.TabIndex = 127
        Me.BtnFindPatient.Text = "..."
        Me.BtnFindPatient.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Enabled = False
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(201, 108)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(256, 26)
        Me.TxtPatientNo.TabIndex = 126
        '
        'ChPatient
        '
        Me.ChPatient.AutoSize = True
        Me.ChPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPatient.Location = New System.Drawing.Point(10, 110)
        Me.ChPatient.Name = "ChPatient"
        Me.ChPatient.Size = New System.Drawing.Size(193, 24)
        Me.ChPatient.TabIndex = 125
        Me.ChPatient.Text = "Received From Patient:"
        Me.ChPatient.UseVisualStyleBackColor = True
        '
        'TxtPatientKHName
        '
        Me.TxtPatientKHName.Font = New System.Drawing.Font("Wat Phnom T3", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientKHName.Location = New System.Drawing.Point(202, 191)
        Me.TxtPatientKHName.Name = "TxtPatientKHName"
        Me.TxtPatientKHName.ReadOnly = True
        Me.TxtPatientKHName.Size = New System.Drawing.Size(291, 29)
        Me.TxtPatientKHName.TabIndex = 3
        '
        'G1
        '
        Me.G1.Controls.Add(Me.RadReil)
        Me.G1.Controls.Add(Me.RadDolar)
        Me.G1.Location = New System.Drawing.Point(498, 294)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(196, 52)
        Me.G1.TabIndex = 5
        Me.G1.TabStop = False
        '
        'RadReil
        '
        Me.RadReil.AutoSize = True
        Me.RadReil.BackColor = System.Drawing.Color.Transparent
        Me.RadReil.Checked = True
        Me.RadReil.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadReil.Location = New System.Drawing.Point(14, 14)
        Me.RadReil.Name = "RadReil"
        Me.RadReil.Size = New System.Drawing.Size(67, 35)
        Me.RadReil.TabIndex = 0
        Me.RadReil.TabStop = True
        Me.RadReil.Text = "erol"
        Me.RadReil.UseVisualStyleBackColor = False
        '
        'RadDolar
        '
        Me.RadDolar.AutoSize = True
        Me.RadDolar.BackColor = System.Drawing.Color.Transparent
        Me.RadDolar.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDolar.Location = New System.Drawing.Point(113, 15)
        Me.RadDolar.Name = "RadDolar"
        Me.RadDolar.Size = New System.Drawing.Size(74, 35)
        Me.RadDolar.TabIndex = 1
        Me.RadDolar.Text = "duløar"
        Me.RadDolar.UseVisualStyleBackColor = False
        '
        'TxtReceivedNote
        '
        Me.TxtReceivedNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceivedNote.Location = New System.Drawing.Point(6, 381)
        Me.TxtReceivedNote.Multiline = True
        Me.TxtReceivedNote.Name = "TxtReceivedNote"
        Me.TxtReceivedNote.ReadOnly = True
        Me.TxtReceivedNote.Size = New System.Drawing.Size(688, 46)
        Me.TxtReceivedNote.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Received Note:"
        '
        'CboReceivedFrom
        '
        Me.CboReceivedFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboReceivedFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboReceivedFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboReceivedFrom.FormattingEnabled = True
        Me.CboReceivedFrom.Location = New System.Drawing.Point(201, 153)
        Me.CboReceivedFrom.Name = "CboReceivedFrom"
        Me.CboReceivedFrom.Size = New System.Drawing.Size(294, 28)
        Me.CboReceivedFrom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Receive From(Name):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Receipt Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Receipt No:"
        '
        'TxtCashReceived
        '
        Me.TxtCashReceived.BackColor = System.Drawing.Color.Azure
        Me.TxtCashReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCashReceived.Location = New System.Drawing.Point(201, 301)
        Me.TxtCashReceived.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TxtCashReceived.Name = "TxtCashReceived"
        Me.TxtCashReceived.Size = New System.Drawing.Size(291, 45)
        Me.TxtCashReceived.TabIndex = 4
        Me.TxtCashReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 301)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 31)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "cMnYnTwkR)ak;TTYl"
        '
        'DateReceiptIn
        '
        Me.DateReceiptIn.Checked = False
        Me.DateReceiptIn.CustomFormat = "dd/MM/yyyy"
        Me.DateReceiptIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReceiptIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceiptIn.Location = New System.Drawing.Point(201, 65)
        Me.DateReceiptIn.Name = "DateReceiptIn"
        Me.DateReceiptIn.ShowCheckBox = True
        Me.DateReceiptIn.Size = New System.Drawing.Size(293, 29)
        Me.DateReceiptIn.TabIndex = 1
        '
        'txtReceiptNumber
        '
        Me.txtReceiptNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtReceiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNumber.Location = New System.Drawing.Point(201, 16)
        Me.txtReceiptNumber.Name = "txtReceiptNumber"
        Me.txtReceiptNumber.ReadOnly = True
        Me.txtReceiptNumber.Size = New System.Drawing.Size(293, 31)
        Me.txtReceiptNumber.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(532, 499)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 33)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(629, 499)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 33)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ErrCashReceived
        '
        Me.ErrCashReceived.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(256, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Other Receipt Received"
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.Location = New System.Drawing.Point(521, 13)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.lblSaveOption.TabIndex = 4
        Me.lblSaveOption.Text = "0"
        Me.lblSaveOption.Visible = False
        '
        'BgSaveNewOtherReceipt
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 241)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 31)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "cMnYnTwkR)ak;"
        '
        'txtAmountWord
        '
        Me.txtAmountWord.BackColor = System.Drawing.Color.Linen
        Me.txtAmountWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountWord.Location = New System.Drawing.Point(201, 240)
        Me.txtAmountWord.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountWord.Name = "txtAmountWord"
        Me.txtAmountWord.ReadOnly = True
        Me.txtAmountWord.Size = New System.Drawing.Size(493, 30)
        Me.txtAmountWord.TabIndex = 128
        '
        'NewCashReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 544)
        Me.Controls.Add(Me.lblSaveOption)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupOtherReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewCashReceived"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receipt Cash Other Received"
        Me.GroupOtherReceipt.ResumeLayout(False)
        Me.GroupOtherReceipt.PerformLayout()
        Me.G1.ResumeLayout(False)
        Me.G1.PerformLayout()
        CType(Me.ErrCashReceived, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupOtherReceipt As System.Windows.Forms.GroupBox
    Friend WithEvents txtReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents DateReceiptIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCashReceived As System.Windows.Forms.TextBox
    Friend WithEvents RadReil As System.Windows.Forms.RadioButton
    Friend WithEvents RadDolar As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtReceivedNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboReceivedFrom As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrCashReceived As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents G1 As System.Windows.Forms.GroupBox
    Friend WithEvents BgSaveNewOtherReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtPatientKHName As System.Windows.Forms.TextBox
    Friend WithEvents ChPatient As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnFindPatient As System.Windows.Forms.Button
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAmountWord As System.Windows.Forms.TextBox
End Class
