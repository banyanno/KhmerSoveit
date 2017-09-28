<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindPatientFollowUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindPatientFollowUp))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateFollowupTo = New System.Windows.Forms.DateTimePicker
        Me.BtnView = New System.Windows.Forms.Button
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnFind = New System.Windows.Forms.Button
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.TxtTelephone = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.RadDoctory = New System.Windows.Forms.RadioButton
        Me.RadTelephone = New System.Windows.Forms.RadioButton
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.RadPatientNo = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(201, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "From:"
        '
        'DateFollowupTo
        '
        Me.DateFollowupTo.CalendarForeColor = System.Drawing.Color.Red
        Me.DateFollowupTo.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.DateFollowupTo.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowupTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowupTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowupTo.Location = New System.Drawing.Point(238, 12)
        Me.DateFollowupTo.Name = "DateFollowupTo"
        Me.DateFollowupTo.Size = New System.Drawing.Size(123, 26)
        Me.DateFollowupTo.TabIndex = 9
        '
        'BtnView
        '
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.ForeColor = System.Drawing.Color.Blue
        Me.BtnView.Location = New System.Drawing.Point(276, 226)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(91, 29)
        Me.BtnView.TabIndex = 8
        Me.BtnView.Text = "Close"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'DateFollowUp
        '
        Me.DateFollowUp.CalendarForeColor = System.Drawing.Color.Red
        Me.DateFollowUp.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(72, 12)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.Size = New System.Drawing.Size(123, 26)
        Me.DateFollowUp.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.TxtTelephone)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadDoctory)
        Me.GroupBox1.Controls.Add(Me.RadTelephone)
        Me.GroupBox1.Controls.Add(Me.RadPatientName)
        Me.GroupBox1.Controls.Add(Me.RadPatientNo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 174)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.Blue
        Me.BtnFind.Location = New System.Drawing.Point(182, 224)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(88, 31)
        Me.BtnFind.TabIndex = 8
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(157, 128)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(170, 28)
        Me.CboDoctor.TabIndex = 7
        '
        'TxtTelephone
        '
        Me.TxtTelephone.Enabled = False
        Me.TxtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelephone.Location = New System.Drawing.Point(157, 91)
        Me.TxtTelephone.Name = "TxtTelephone"
        Me.TxtTelephone.Size = New System.Drawing.Size(170, 26)
        Me.TxtTelephone.TabIndex = 6
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(157, 56)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(170, 26)
        Me.TxtPatientName.TabIndex = 5
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(157, 22)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(170, 26)
        Me.TxtPatientNo.TabIndex = 4
        '
        'RadDoctory
        '
        Me.RadDoctory.AutoSize = True
        Me.RadDoctory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDoctory.Location = New System.Drawing.Point(36, 132)
        Me.RadDoctory.Name = "RadDoctory"
        Me.RadDoctory.Size = New System.Drawing.Size(104, 21)
        Me.RadDoctory.TabIndex = 3
        Me.RadDoctory.TabStop = True
        Me.RadDoctory.Text = "With Doctor:"
        Me.RadDoctory.UseVisualStyleBackColor = True
        '
        'RadTelephone
        '
        Me.RadTelephone.AutoSize = True
        Me.RadTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTelephone.Location = New System.Drawing.Point(36, 96)
        Me.RadTelephone.Name = "RadTelephone"
        Me.RadTelephone.Size = New System.Drawing.Size(98, 21)
        Me.RadTelephone.TabIndex = 2
        Me.RadTelephone.TabStop = True
        Me.RadTelephone.Text = "Telephone:"
        Me.RadTelephone.UseVisualStyleBackColor = True
        '
        'RadPatientName
        '
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPatientName.Location = New System.Drawing.Point(36, 60)
        Me.RadPatientName.Name = "RadPatientName"
        Me.RadPatientName.Size = New System.Drawing.Size(115, 21)
        Me.RadPatientName.TabIndex = 1
        Me.RadPatientName.TabStop = True
        Me.RadPatientName.Text = "Patient Name:"
        Me.RadPatientName.UseVisualStyleBackColor = True
        '
        'RadPatientNo
        '
        Me.RadPatientNo.AutoSize = True
        Me.RadPatientNo.Checked = True
        Me.RadPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPatientNo.Location = New System.Drawing.Point(36, 27)
        Me.RadPatientNo.Name = "RadPatientNo"
        Me.RadPatientNo.Size = New System.Drawing.Size(96, 21)
        Me.RadPatientNo.TabIndex = 0
        Me.RadPatientNo.TabStop = True
        Me.RadPatientNo.Text = "Patient No:"
        Me.RadPatientNo.UseVisualStyleBackColor = True
        '
        'FindPatientFollowUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 259)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateFollowupTo)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.DateFollowUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindPatientFollowUp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Patient FollowUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateFollowupTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadDoctory As System.Windows.Forms.RadioButton
    Friend WithEvents RadTelephone As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents BtnFind As System.Windows.Forms.Button
End Class
