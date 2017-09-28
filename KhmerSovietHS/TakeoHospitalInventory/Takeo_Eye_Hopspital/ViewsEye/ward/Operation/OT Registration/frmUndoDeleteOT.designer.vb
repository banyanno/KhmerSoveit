<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUndoDeleteOT
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUndoDeleteOT))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridOTRegistration = New System.Windows.Forms.DataGridView
        Me.OTNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewInPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OperationTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Anesthesia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Anesthetist = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eye = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OperationType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Surgeon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Assistant = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Circulation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Compli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateOperated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Others = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ContextUndoInPatient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.BtnFind = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPatientNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridOTRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextUndoInPatient.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridOTRegistration)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1028, 510)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Patient"
        '
        'GridOTRegistration
        '
        Me.GridOTRegistration.AllowUserToAddRows = False
        Me.GridOTRegistration.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridOTRegistration.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridOTRegistration.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridOTRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridOTRegistration.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridOTRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOTRegistration.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OTNo, Me.NewInPatientNo, Me.PatientNo, Me.NameKhmer, Me.Age, Me.Sex, Me.Address, Me.OperationTime, Me.Anesthesia, Me.Anesthetist, Me.Eye, Me.OperationType, Me.IOL, Me.Surgeon, Me.Assistant, Me.Circulation, Me.Compli, Me.CreateDate, Me.DateOperated, Me.Others, Me.Status})
        Me.GridOTRegistration.ContextMenuStrip = Me.ContextUndoInPatient
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridOTRegistration.DefaultCellStyle = DataGridViewCellStyle4
        Me.GridOTRegistration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOTRegistration.Location = New System.Drawing.Point(3, 16)
        Me.GridOTRegistration.Name = "GridOTRegistration"
        Me.GridOTRegistration.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridOTRegistration.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GridOTRegistration.RowHeadersWidth = 50
        Me.GridOTRegistration.RowTemplate.Height = 35
        Me.GridOTRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridOTRegistration.Size = New System.Drawing.Size(1022, 491)
        Me.GridOTRegistration.TabIndex = 1
        '
        'OTNo
        '
        Me.OTNo.DataPropertyName = "OTNo"
        Me.OTNo.HeaderText = "No"
        Me.OTNo.Name = "OTNo"
        Me.OTNo.ReadOnly = True
        Me.OTNo.Visible = False
        '
        'NewInPatientNo
        '
        Me.NewInPatientNo.DataPropertyName = "NewInPatientNo"
        Me.NewInPatientNo.HeaderText = "New Inno"
        Me.NewInPatientNo.Name = "NewInPatientNo"
        Me.NewInPatientNo.ReadOnly = True
        Me.NewInPatientNo.Visible = False
        '
        'PatientNo
        '
        Me.PatientNo.DataPropertyName = "PatientNo"
        Me.PatientNo.HeaderText = "PatientNo"
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        '
        'NameKhmer
        '
        Me.NameKhmer.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = Nothing
        Me.NameKhmer.DefaultCellStyle = DataGridViewCellStyle3
        Me.NameKhmer.HeaderText = "Patient Name"
        Me.NameKhmer.Name = "NameKhmer"
        Me.NameKhmer.ReadOnly = True
        '
        'Age
        '
        Me.Age.DataPropertyName = "Age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Width = 50
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = True
        Me.Sex.Width = 50
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'OperationTime
        '
        Me.OperationTime.DataPropertyName = "OperationTime"
        Me.OperationTime.HeaderText = "Operation Time"
        Me.OperationTime.Name = "OperationTime"
        Me.OperationTime.ReadOnly = True
        Me.OperationTime.Width = 110
        '
        'Anesthesia
        '
        Me.Anesthesia.DataPropertyName = "Anesthesia"
        Me.Anesthesia.HeaderText = "Anesthesia"
        Me.Anesthesia.Name = "Anesthesia"
        Me.Anesthesia.ReadOnly = True
        '
        'Anesthetist
        '
        Me.Anesthetist.DataPropertyName = "Anesthetist"
        Me.Anesthetist.HeaderText = "Anesthetist"
        Me.Anesthetist.Name = "Anesthetist"
        Me.Anesthetist.ReadOnly = True
        '
        'Eye
        '
        Me.Eye.DataPropertyName = "Eye"
        Me.Eye.HeaderText = "Eye"
        Me.Eye.Name = "Eye"
        Me.Eye.ReadOnly = True
        Me.Eye.Width = 80
        '
        'OperationType
        '
        Me.OperationType.DataPropertyName = "OperationType"
        Me.OperationType.HeaderText = "Operation Type"
        Me.OperationType.Name = "OperationType"
        Me.OperationType.ReadOnly = True
        Me.OperationType.Width = 150
        '
        'IOL
        '
        Me.IOL.DataPropertyName = "IOL"
        Me.IOL.HeaderText = "IOL"
        Me.IOL.Name = "IOL"
        Me.IOL.ReadOnly = True
        Me.IOL.Width = 50
        '
        'Surgeon
        '
        Me.Surgeon.DataPropertyName = "Surgeon"
        Me.Surgeon.HeaderText = "Surgeon"
        Me.Surgeon.Name = "Surgeon"
        Me.Surgeon.ReadOnly = True
        '
        'Assistant
        '
        Me.Assistant.DataPropertyName = "Assistant"
        Me.Assistant.HeaderText = "Assistant"
        Me.Assistant.Name = "Assistant"
        Me.Assistant.ReadOnly = True
        '
        'Circulation
        '
        Me.Circulation.DataPropertyName = "Circulation"
        Me.Circulation.HeaderText = "Circulation"
        Me.Circulation.Name = "Circulation"
        Me.Circulation.ReadOnly = True
        '
        'Compli
        '
        Me.Compli.DataPropertyName = "Compli"
        Me.Compli.HeaderText = "Compli"
        Me.Compli.Name = "Compli"
        Me.Compli.ReadOnly = True
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "CreateDate"
        Me.CreateDate.HeaderText = "Date Prepare OT"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 150
        '
        'DateOperated
        '
        Me.DateOperated.DataPropertyName = "DateOperated"
        Me.DateOperated.HeaderText = "Date Operated"
        Me.DateOperated.Name = "DateOperated"
        Me.DateOperated.ReadOnly = True
        Me.DateOperated.Width = 150
        '
        'Others
        '
        Me.Others.DataPropertyName = "Others"
        Me.Others.HeaderText = "Others"
        Me.Others.Name = "Others"
        Me.Others.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ContextUndoInPatient
        '
        Me.ContextUndoInPatient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MUndo})
        Me.ContextUndoInPatient.Name = "ContextUndoInPatient"
        Me.ContextUndoInPatient.Size = New System.Drawing.Size(140, 26)
        '
        'MUndo
        '
        Me.MUndo.Name = "MUndo"
        Me.MUndo.Size = New System.Drawing.Size(139, 22)
        Me.MUndo.Text = "Undo &Delete"
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(66, 52)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(117, 26)
        Me.DateFrom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date From:"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(255, 52)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(113, 26)
        Me.DateTo.TabIndex = 1
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(374, 20)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(98, 58)
        Me.BtnFind.TabIndex = 3
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.txtPatientNo)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 87)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Patient Information"
        '
        'txtPatientNo
        '
        Me.txtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientNo.Location = New System.Drawing.Point(66, 20)
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(302, 26)
        Me.txtPatientNo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'frmUndoDeleteOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 597)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUndoDeleteOT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Undo Delete OT"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridOTRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextUndoInPatient.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextUndoInPatient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridOTRegistration As System.Windows.Forms.DataGridView
    Friend WithEvents OTNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewInPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperationTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anesthesia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anesthetist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eye As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperationType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surgeon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Assistant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Circulation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOperated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Others As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
