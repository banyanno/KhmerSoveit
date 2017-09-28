<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindInPatientHistory
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
        Dim GridNewInPatient_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFindInPatientHistory))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridNewInPatient = New Janus.Windows.GridEX.GridEX
        Me.DSWardWithOT = New TakeoHospitalInventory.DSWardWithOT
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridDiallyBook = New System.Windows.Forms.DataGridView
        Me.DaillyBookNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewInpatientNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eye1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Treatment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.BtnDisplay = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.TxtPatienNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.V_NewInpatientDetialLeaveTableAdapter = New TakeoHospitalInventory.DSWardWithOTTableAdapters.V_NewInpatientDetialLeaveTableAdapter
        Me.View_OTRegistrationTableAdapter = New TakeoHospitalInventory.DSWardWithOTTableAdapters.View_OTRegistrationTableAdapter
        Me.V_IOLRegistrationTableAdapter = New TakeoHospitalInventory.DSWardWithOTTableAdapters.V_IOLRegistrationTableAdapter
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridNewInPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSWardWithOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridDiallyBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1142, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hospital Find History Patient"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1142, 749)
        Me.SplitContainer1.SplitterDistance = 695
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridNewInPatient)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 749)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List history In-Patient"
        '
        'GridNewInPatient
        '
        Me.GridNewInPatient.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridNewInPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridNewInPatient.DataMember = "V_NewInpatientDetialLeave"
        Me.GridNewInPatient.DataSource = Me.DSWardWithOT
        GridNewInPatient_DesignTimeLayout.LayoutString = resources.GetString("GridNewInPatient_DesignTimeLayout.LayoutString")
        Me.GridNewInPatient.DesignTimeLayout = GridNewInPatient_DesignTimeLayout
        Me.GridNewInPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNewInPatient.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridNewInPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridNewInPatient.GroupByBoxVisible = False
        Me.GridNewInPatient.Hierarchical = True
        Me.GridNewInPatient.Location = New System.Drawing.Point(3, 16)
        Me.GridNewInPatient.Name = "GridNewInPatient"
        Me.GridNewInPatient.RecordNavigator = True
        Me.GridNewInPatient.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridNewInPatient.Size = New System.Drawing.Size(689, 730)
        Me.GridNewInPatient.TabIndex = 2
        Me.GridNewInPatient.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'DSWardWithOT
        '
        Me.DSWardWithOT.DataSetName = "DSWardWithOT"
        Me.DSWardWithOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 749)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridDiallyBook)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(430, 378)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "History Daily Book Treatment"
        '
        'GridDiallyBook
        '
        Me.GridDiallyBook.AllowUserToAddRows = False
        Me.GridDiallyBook.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridDiallyBook.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridDiallyBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridDiallyBook.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridDiallyBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDiallyBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DaillyBookNo, Me.NewInpatientNo1, Me.PatientNo1, Me.Eye1, Me.Treatment, Me.CreateDate})
        Me.GridDiallyBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiallyBook.Location = New System.Drawing.Point(3, 16)
        Me.GridDiallyBook.Name = "GridDiallyBook"
        Me.GridDiallyBook.ReadOnly = True
        Me.GridDiallyBook.RowHeadersWidth = 25
        Me.GridDiallyBook.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDiallyBook.RowTemplate.Height = 35
        Me.GridDiallyBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDiallyBook.Size = New System.Drawing.Size(424, 359)
        Me.GridDiallyBook.TabIndex = 1
        '
        'DaillyBookNo
        '
        Me.DaillyBookNo.DataPropertyName = "DaillyBookNo"
        Me.DaillyBookNo.HeaderText = "No"
        Me.DaillyBookNo.Name = "DaillyBookNo"
        Me.DaillyBookNo.ReadOnly = True
        Me.DaillyBookNo.Visible = False
        '
        'NewInpatientNo1
        '
        Me.NewInpatientNo1.DataPropertyName = "NewInpatientNo"
        Me.NewInpatientNo1.HeaderText = "NewInpatientNo"
        Me.NewInpatientNo1.Name = "NewInpatientNo1"
        Me.NewInpatientNo1.ReadOnly = True
        Me.NewInpatientNo1.Visible = False
        '
        'PatientNo1
        '
        Me.PatientNo1.DataPropertyName = "PatientNo"
        Me.PatientNo1.HeaderText = "PatientNo"
        Me.PatientNo1.Name = "PatientNo1"
        Me.PatientNo1.ReadOnly = True
        Me.PatientNo1.Visible = False
        '
        'Eye1
        '
        Me.Eye1.DataPropertyName = "Eye"
        Me.Eye1.HeaderText = "Eye"
        Me.Eye1.Name = "Eye1"
        Me.Eye1.ReadOnly = True
        '
        'Treatment
        '
        Me.Treatment.DataPropertyName = "Treatment"
        Me.Treatment.HeaderText = "Treatment"
        Me.Treatment.Name = "Treatment"
        Me.Treatment.ReadOnly = True
        Me.Treatment.Width = 200
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "CreateDate"
        Me.CreateDate.HeaderText = "Date Treatment"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 200
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.BtnFind)
        Me.GroupBox3.Controls.Add(Me.DateTo)
        Me.GroupBox3.Controls.Add(Me.DateFrom)
        Me.GroupBox3.Controls.Add(Me.TxtPatienNo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 127)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Find By"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DateFollowUp)
        Me.GroupBox5.Controls.Add(Me.BtnDisplay)
        Me.GroupBox5.Location = New System.Drawing.Point(268, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(142, 100)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Patient FollowUp"
        '
        'DateFollowUp
        '
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(6, 23)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.Size = New System.Drawing.Size(119, 24)
        Me.DateFollowUp.TabIndex = 2
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDisplay.Location = New System.Drawing.Point(50, 64)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(75, 30)
        Me.BtnDisplay.TabIndex = 3
        Me.BtnDisplay.Text = "Display"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(187, 80)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(75, 30)
        Me.BtnFind.TabIndex = 3
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(66, 86)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(114, 24)
        Me.DateTo.TabIndex = 2
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(66, 51)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(114, 24)
        Me.DateFrom.TabIndex = 2
        '
        'TxtPatienNo
        '
        Me.TxtPatienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.TxtPatienNo.Location = New System.Drawing.Point(66, 15)
        Me.TxtPatienNo.Name = "TxtPatienNo"
        Me.TxtPatienNo.Size = New System.Drawing.Size(196, 30)
        Me.TxtPatienNo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient No:"
        '
        'V_NewInpatientDetialLeaveTableAdapter
        '
        Me.V_NewInpatientDetialLeaveTableAdapter.ClearBeforeFill = True
        '
        'View_OTRegistrationTableAdapter
        '
        Me.View_OTRegistrationTableAdapter.ClearBeforeFill = True
        '
        'V_IOLRegistrationTableAdapter
        '
        Me.V_IOLRegistrationTableAdapter.ClearBeforeFill = True
        '
        'FrmFindInPatientHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1142, 784)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFindInPatientHistory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find In-Patient History"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridNewInPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSWardWithOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridDiallyBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridNewInPatient As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDiallyBook As System.Windows.Forms.DataGridView
    Friend WithEvents DaillyBookNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewInpatientNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eye1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Treatment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPatienNo As System.Windows.Forms.TextBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnDisplay As System.Windows.Forms.Button
    Friend WithEvents DSWardWithOT As TakeoHospitalInventory.DSWardWithOT
    Friend WithEvents V_NewInpatientDetialLeaveTableAdapter As TakeoHospitalInventory.DSWardWithOTTableAdapters.V_NewInpatientDetialLeaveTableAdapter
    Friend WithEvents View_OTRegistrationTableAdapter As TakeoHospitalInventory.DSWardWithOTTableAdapters.View_OTRegistrationTableAdapter
    Friend WithEvents V_IOLRegistrationTableAdapter As TakeoHospitalInventory.DSWardWithOTTableAdapters.V_IOLRegistrationTableAdapter
End Class
