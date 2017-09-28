<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNurseOnCallEdit
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbNurseOnCall = New System.Windows.Forms.TabPage
        Me.DateIn = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.txtOthers = New System.Windows.Forms.TextBox
        Me.txtUlcer = New System.Windows.Forms.TextBox
        Me.txtPostOther = New System.Windows.Forms.TextBox
        Me.txtWaiting = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtPostCat = New System.Windows.Forms.TextBox
        Me.txtDischarged = New System.Windows.Forms.TextBox
        Me.txtSurgery = New System.Windows.Forms.TextBox
        Me.txtAdmission = New System.Windows.Forms.TextBox
        Me.txtInpatient = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tbNurseOnCall.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbNurseOnCall)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(461, 496)
        Me.TabControl1.TabIndex = 0
        '
        'tbNurseOnCall
        '
        Me.tbNurseOnCall.Controls.Add(Me.DateIn)
        Me.tbNurseOnCall.Controls.Add(Me.cmdClose)
        Me.tbNurseOnCall.Controls.Add(Me.cmdSave)
        Me.tbNurseOnCall.Controls.Add(Me.txtNote)
        Me.tbNurseOnCall.Controls.Add(Me.txtOthers)
        Me.tbNurseOnCall.Controls.Add(Me.txtUlcer)
        Me.tbNurseOnCall.Controls.Add(Me.txtPostOther)
        Me.tbNurseOnCall.Controls.Add(Me.txtWaiting)
        Me.tbNurseOnCall.Controls.Add(Me.txtTotal)
        Me.tbNurseOnCall.Controls.Add(Me.txtPostCat)
        Me.tbNurseOnCall.Controls.Add(Me.txtDischarged)
        Me.tbNurseOnCall.Controls.Add(Me.txtSurgery)
        Me.tbNurseOnCall.Controls.Add(Me.txtAdmission)
        Me.tbNurseOnCall.Controls.Add(Me.txtInpatient)
        Me.tbNurseOnCall.Controls.Add(Me.Label11)
        Me.tbNurseOnCall.Controls.Add(Me.Label10)
        Me.tbNurseOnCall.Controls.Add(Me.Label9)
        Me.tbNurseOnCall.Controls.Add(Me.Label8)
        Me.tbNurseOnCall.Controls.Add(Me.Label7)
        Me.tbNurseOnCall.Controls.Add(Me.Label6)
        Me.tbNurseOnCall.Controls.Add(Me.Label5)
        Me.tbNurseOnCall.Controls.Add(Me.Label4)
        Me.tbNurseOnCall.Controls.Add(Me.Label3)
        Me.tbNurseOnCall.Controls.Add(Me.Label2)
        Me.tbNurseOnCall.Controls.Add(Me.Label1)
        Me.tbNurseOnCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNurseOnCall.Location = New System.Drawing.Point(4, 29)
        Me.tbNurseOnCall.Name = "tbNurseOnCall"
        Me.tbNurseOnCall.Padding = New System.Windows.Forms.Padding(3)
        Me.tbNurseOnCall.Size = New System.Drawing.Size(453, 463)
        Me.tbNurseOnCall.TabIndex = 0
        Me.tbNurseOnCall.Text = "Infos"
        Me.tbNurseOnCall.UseVisualStyleBackColor = True
        '
        'DateIn
        '
        Me.DateIn.AutoSize = True
        Me.DateIn.Location = New System.Drawing.Point(356, 16)
        Me.DateIn.Name = "DateIn"
        Me.DateIn.Size = New System.Drawing.Size(54, 18)
        Me.DateIn.TabIndex = 13
        Me.DateIn.Text = "Date In"
        Me.DateIn.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(322, 411)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(104, 37)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(219, 411)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(97, 37)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(119, 315)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(307, 90)
        Me.txtNote.TabIndex = 10
        '
        'txtOthers
        '
        Me.txtOthers.Location = New System.Drawing.Point(119, 285)
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(215, 24)
        Me.txtOthers.TabIndex = 9
        '
        'txtUlcer
        '
        Me.txtUlcer.Location = New System.Drawing.Point(119, 225)
        Me.txtUlcer.Name = "txtUlcer"
        Me.txtUlcer.Size = New System.Drawing.Size(215, 24)
        Me.txtUlcer.TabIndex = 7
        '
        'txtPostOther
        '
        Me.txtPostOther.Location = New System.Drawing.Point(119, 195)
        Me.txtPostOther.Name = "txtPostOther"
        Me.txtPostOther.Size = New System.Drawing.Size(215, 24)
        Me.txtPostOther.TabIndex = 6
        '
        'txtWaiting
        '
        Me.txtWaiting.Location = New System.Drawing.Point(119, 255)
        Me.txtWaiting.Name = "txtWaiting"
        Me.txtWaiting.Size = New System.Drawing.Size(215, 24)
        Me.txtWaiting.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(119, 100)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(215, 29)
        Me.txtTotal.TabIndex = 3
        '
        'txtPostCat
        '
        Me.txtPostCat.Location = New System.Drawing.Point(119, 165)
        Me.txtPostCat.Name = "txtPostCat"
        Me.txtPostCat.Size = New System.Drawing.Size(215, 24)
        Me.txtPostCat.TabIndex = 5
        '
        'txtDischarged
        '
        Me.txtDischarged.Location = New System.Drawing.Point(119, 70)
        Me.txtDischarged.Name = "txtDischarged"
        Me.txtDischarged.Size = New System.Drawing.Size(215, 24)
        Me.txtDischarged.TabIndex = 2
        '
        'txtSurgery
        '
        Me.txtSurgery.Enabled = False
        Me.txtSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurgery.Location = New System.Drawing.Point(119, 130)
        Me.txtSurgery.Name = "txtSurgery"
        Me.txtSurgery.Size = New System.Drawing.Size(215, 29)
        Me.txtSurgery.TabIndex = 4
        '
        'txtAdmission
        '
        Me.txtAdmission.Location = New System.Drawing.Point(119, 40)
        Me.txtAdmission.Name = "txtAdmission"
        Me.txtAdmission.Size = New System.Drawing.Size(215, 24)
        Me.txtAdmission.TabIndex = 1
        '
        'txtInpatient
        '
        Me.txtInpatient.Location = New System.Drawing.Point(119, 10)
        Me.txtInpatient.Name = "txtInpatient"
        Me.txtInpatient.Size = New System.Drawing.Size(215, 24)
        Me.txtInpatient.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Notes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Others:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Waiting:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "C. Ulcer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Post Other:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Post Cat.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Surgery:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Discharge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Admission:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inpatient:"
        '
        'FormNurseOnCallEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormNurseOnCallEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Nurse On Call"
        Me.TabControl1.ResumeLayout(False)
        Me.tbNurseOnCall.ResumeLayout(False)
        Me.tbNurseOnCall.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbNurseOnCall As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents txtOthers As System.Windows.Forms.TextBox
    Friend WithEvents txtUlcer As System.Windows.Forms.TextBox
    Friend WithEvents txtPostOther As System.Windows.Forms.TextBox
    Friend WithEvents txtWaiting As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCat As System.Windows.Forms.TextBox
    Friend WithEvents txtDischarged As System.Windows.Forms.TextBox
    Friend WithEvents txtSurgery As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmission As System.Windows.Forms.TextBox
    Friend WithEvents txtInpatient As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateIn As System.Windows.Forms.Label
End Class
