<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListUndoPatient
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListUndoPatient))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridUndoInPatient = New System.Windows.Forms.DataGridView
        Me.NewInPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eye = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diagnosis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_RE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_LE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDischarge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateFollowUp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Signature = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Leave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Waiting = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDiagnosis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeleteOption = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextUndoInPatient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridUndoInPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextUndoInPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1260, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Patient Information"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.BtnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFind.Location = New System.Drawing.Point(550, 57)
        Me.BtnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(123, 41)
        Me.BtnFind.TabIndex = 3
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(99, 28)
        Me.TxtPatientNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(432, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(365, 72)
        Me.DateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(166, 26)
        Me.DateTo.TabIndex = 1
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(99, 72)
        Me.DateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(175, 26)
        Me.DateFrom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridUndoInPatient)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1260, 620)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Patient Deleted"
        '
        'GridUndoInPatient
        '
        Me.GridUndoInPatient.AllowUserToAddRows = False
        Me.GridUndoInPatient.AllowUserToDeleteRows = False
        Me.GridUndoInPatient.BackgroundColor = System.Drawing.Color.White
        Me.GridUndoInPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridUndoInPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUndoInPatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NewInPatientNo, Me.PatientNo, Me.NameKhmer, Me.Age, Me.Sex, Me.Address, Me.Eye, Me.Diagnosis, Me.VA_RE, Me.VA_LE, Me.DateDischarge, Me.DateFollowUp, Me.Signature, Me.Leave, Me.CreateDate, Me.Waiting, Me.TypeDiagnosis, Me.DeleteOption})
        Me.GridUndoInPatient.ContextMenuStrip = Me.ContextUndoInPatient
        Me.GridUndoInPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUndoInPatient.Location = New System.Drawing.Point(4, 21)
        Me.GridUndoInPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.GridUndoInPatient.Name = "GridUndoInPatient"
        Me.GridUndoInPatient.ReadOnly = True
        Me.GridUndoInPatient.RowHeadersWidth = 60
        Me.GridUndoInPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridUndoInPatient.Size = New System.Drawing.Size(1252, 595)
        Me.GridUndoInPatient.TabIndex = 0
        '
        'NewInPatientNo
        '
        Me.NewInPatientNo.DataPropertyName = "NewInPatientNo"
        Me.NewInPatientNo.HeaderText = "NewInPatientNo"
        Me.NewInPatientNo.Name = "NewInPatientNo"
        Me.NewInPatientNo.ReadOnly = True
        Me.NewInPatientNo.Visible = False
        '
        'PatientNo
        '
        Me.PatientNo.DataPropertyName = "PatientNo"
        Me.PatientNo.FillWeight = 110.0!
        Me.PatientNo.HeaderText = "Patient No"
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        Me.PatientNo.Width = 110
        '
        'NameKhmer
        '
        Me.NameKhmer.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Wat Phnom T3", 11.0!)
        Me.NameKhmer.DefaultCellStyle = DataGridViewCellStyle1
        Me.NameKhmer.HeaderText = "Khmer Name"
        Me.NameKhmer.Name = "NameKhmer"
        Me.NameKhmer.ReadOnly = True
        Me.NameKhmer.Width = 130
        '
        'Age
        '
        Me.Age.DataPropertyName = "Age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.FillWeight = 40.0!
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = True
        Me.Sex.Width = 40
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'Eye
        '
        Me.Eye.DataPropertyName = "Eye"
        Me.Eye.HeaderText = "Eye"
        Me.Eye.Name = "Eye"
        Me.Eye.ReadOnly = True
        '
        'Diagnosis
        '
        Me.Diagnosis.DataPropertyName = "Diagnosis"
        Me.Diagnosis.HeaderText = "Diagnosis"
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.ReadOnly = True
        '
        'VA_RE
        '
        Me.VA_RE.DataPropertyName = "VA_RE"
        Me.VA_RE.FillWeight = 50.0!
        Me.VA_RE.HeaderText = "VA_RE"
        Me.VA_RE.Name = "VA_RE"
        Me.VA_RE.ReadOnly = True
        Me.VA_RE.Width = 50
        '
        'VA_LE
        '
        Me.VA_LE.DataPropertyName = "VA_LE"
        Me.VA_LE.FillWeight = 50.0!
        Me.VA_LE.HeaderText = "VA_LE"
        Me.VA_LE.Name = "VA_LE"
        Me.VA_LE.ReadOnly = True
        Me.VA_LE.Width = 50
        '
        'DateDischarge
        '
        Me.DateDischarge.DataPropertyName = "DateDischarge"
        Me.DateDischarge.HeaderText = "Date Discharge"
        Me.DateDischarge.Name = "DateDischarge"
        Me.DateDischarge.ReadOnly = True
        Me.DateDischarge.Width = 135
        '
        'DateFollowUp
        '
        Me.DateFollowUp.DataPropertyName = "DateFollowUp"
        Me.DateFollowUp.FillWeight = 130.0!
        Me.DateFollowUp.HeaderText = "Date FollowUp"
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.ReadOnly = True
        Me.DateFollowUp.Width = 135
        '
        'Signature
        '
        Me.Signature.DataPropertyName = "Signature"
        Me.Signature.HeaderText = "Signature"
        Me.Signature.Name = "Signature"
        Me.Signature.ReadOnly = True
        '
        'Leave
        '
        Me.Leave.DataPropertyName = "Leave"
        Me.Leave.HeaderText = "Leave"
        Me.Leave.Name = "Leave"
        Me.Leave.ReadOnly = True
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "CreateDate"
        Me.CreateDate.FillWeight = 120.0!
        Me.CreateDate.HeaderText = "Create Date"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 120
        '
        'Waiting
        '
        Me.Waiting.DataPropertyName = "Waiting"
        Me.Waiting.HeaderText = "Waiting"
        Me.Waiting.Name = "Waiting"
        Me.Waiting.ReadOnly = True
        '
        'TypeDiagnosis
        '
        Me.TypeDiagnosis.DataPropertyName = "TypeDiagnosis"
        Me.TypeDiagnosis.HeaderText = "TypeDiagnosis"
        Me.TypeDiagnosis.Name = "TypeDiagnosis"
        Me.TypeDiagnosis.ReadOnly = True
        Me.TypeDiagnosis.Visible = False
        '
        'DeleteOption
        '
        Me.DeleteOption.DataPropertyName = "DeleteOption"
        Me.DeleteOption.HeaderText = "DeleteOption"
        Me.DeleteOption.Name = "DeleteOption"
        Me.DeleteOption.ReadOnly = True
        Me.DeleteOption.Visible = False
        '
        'ContextUndoInPatient
        '
        Me.ContextUndoInPatient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MUndo})
        Me.ContextUndoInPatient.Name = "ContextUndoInPatient"
        Me.ContextUndoInPatient.Size = New System.Drawing.Size(135, 26)
        '
        'MUndo
        '
        Me.MUndo.Name = "MUndo"
        Me.MUndo.Size = New System.Drawing.Size(134, 22)
        Me.MUndo.Text = "Undo Cancel"
        '
        'FrmListUndoPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 740)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmListUndoPatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Undo In Patient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridUndoInPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextUndoInPatient.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridUndoInPatient As System.Windows.Forms.DataGridView
    Friend WithEvents ContextUndoInPatient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewInPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eye As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_RE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_LE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDischarge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFollowUp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Signature As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Leave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Waiting As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDiagnosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteOption As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
