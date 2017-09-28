<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportReceiptDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportReceiptDetail))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkOthers = New System.Windows.Forms.CheckBox
        Me.chkArtificialEye = New System.Windows.Forms.CheckBox
        Me.chkOperation = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.chkGlasses = New System.Windows.Forms.CheckBox
        Me.chkMedicine = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkFollowUp = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkConsltation = New System.Windows.Forms.CheckBox
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ChOtherReceipt = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 294)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conditions to print"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date from:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date to:"
        '
        'cmdClose
        '
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(375, 321)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(105, 41)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(261, 321)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(108, 41)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(293, 23)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(123, 26)
        Me.dtpDateTo.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkOthers)
        Me.GroupBox4.Controls.Add(Me.chkArtificialEye)
        Me.GroupBox4.Controls.Add(Me.chkOperation)
        Me.GroupBox4.Location = New System.Drawing.Point(219, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 125)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Inpatient"
        '
        'chkOthers
        '
        Me.chkOthers.Location = New System.Drawing.Point(17, 86)
        Me.chkOthers.Name = "chkOthers"
        Me.chkOthers.Size = New System.Drawing.Size(184, 24)
        Me.chkOthers.TabIndex = 5
        Me.chkOthers.Text = "&Ot&hers"
        Me.chkOthers.UseVisualStyleBackColor = True
        '
        'chkArtificialEye
        '
        Me.chkArtificialEye.Location = New System.Drawing.Point(17, 56)
        Me.chkArtificialEye.Name = "chkArtificialEye"
        Me.chkArtificialEye.Size = New System.Drawing.Size(184, 24)
        Me.chkArtificialEye.TabIndex = 4
        Me.chkArtificialEye.Text = "&Artificial Eye"
        Me.chkArtificialEye.UseVisualStyleBackColor = True
        '
        'chkOperation
        '
        Me.chkOperation.Location = New System.Drawing.Point(17, 28)
        Me.chkOperation.Name = "chkOperation"
        Me.chkOperation.Size = New System.Drawing.Size(184, 22)
        Me.chkOperation.TabIndex = 3
        Me.chkOperation.Text = "&Operation"
        Me.chkOperation.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkGlasses)
        Me.GroupBox5.Controls.Add(Me.chkMedicine)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 201)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(207, 82)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cash Receipt"
        '
        'chkGlasses
        '
        Me.chkGlasses.Location = New System.Drawing.Point(11, 49)
        Me.chkGlasses.Name = "chkGlasses"
        Me.chkGlasses.Size = New System.Drawing.Size(184, 24)
        Me.chkGlasses.TabIndex = 2
        Me.chkGlasses.Text = "&Glasses"
        Me.chkGlasses.UseVisualStyleBackColor = True
        '
        'chkMedicine
        '
        Me.chkMedicine.Location = New System.Drawing.Point(11, 19)
        Me.chkMedicine.Name = "chkMedicine"
        Me.chkMedicine.Size = New System.Drawing.Size(184, 24)
        Me.chkMedicine.TabIndex = 1
        Me.chkMedicine.Text = "&Medicine"
        Me.chkMedicine.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkFollowUp)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(207, 63)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Old-out patient"
        '
        'chkFollowUp
        '
        Me.chkFollowUp.Location = New System.Drawing.Point(11, 26)
        Me.chkFollowUp.Name = "chkFollowUp"
        Me.chkFollowUp.Size = New System.Drawing.Size(184, 24)
        Me.chkFollowUp.TabIndex = 1
        Me.chkFollowUp.Text = "&Follow up"
        Me.chkFollowUp.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkConsltation)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 63)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New-out patient"
        '
        'chkConsltation
        '
        Me.chkConsltation.Location = New System.Drawing.Point(11, 26)
        Me.chkConsltation.Name = "chkConsltation"
        Me.chkConsltation.Size = New System.Drawing.Size(184, 24)
        Me.chkConsltation.TabIndex = 0
        Me.chkConsltation.Text = "Co&nsultation"
        Me.chkConsltation.UseVisualStyleBackColor = True
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(87, 23)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(123, 26)
        Me.dtpDateFrom.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ChOtherReceipt)
        Me.GroupBox6.Location = New System.Drawing.Point(220, 203)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(221, 80)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Other Receipt"
        '
        'ChOtherReceipt
        '
        Me.ChOtherReceipt.AutoSize = True
        Me.ChOtherReceipt.Location = New System.Drawing.Point(13, 36)
        Me.ChOtherReceipt.Name = "ChOtherReceipt"
        Me.ChOtherReceipt.Size = New System.Drawing.Size(116, 17)
        Me.ChOtherReceipt.TabIndex = 0
        Me.ChOtherReceipt.Text = "Print Other Receipt"
        Me.ChOtherReceipt.UseVisualStyleBackColor = True
        '
        'frmReportReceiptDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportReceiptDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Receipt Detail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkArtificialEye As System.Windows.Forms.CheckBox
    Friend WithEvents chkOperation As System.Windows.Forms.CheckBox
    Friend WithEvents chkGlasses As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedicine As System.Windows.Forms.CheckBox
    Friend WithEvents chkFollowUp As System.Windows.Forms.CheckBox
    Friend WithEvents chkConsltation As System.Windows.Forms.CheckBox
    Friend WithEvents chkOthers As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ChOtherReceipt As System.Windows.Forms.CheckBox
End Class
