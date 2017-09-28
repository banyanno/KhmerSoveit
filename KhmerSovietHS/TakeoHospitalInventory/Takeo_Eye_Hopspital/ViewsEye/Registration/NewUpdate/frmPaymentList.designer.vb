<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentList
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentList))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdViewToday = New System.Windows.Forms.Button
        Me.dtpDateView = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkView = New System.Windows.Forms.CheckBox
        Me.cmdView = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgvPaymentList = New System.Windows.Forms.DataGridView
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.HN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDCashReceipt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConPay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tmrPay = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdUndo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdViewToday)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(889, 753)
        Me.SplitContainer1.SplitterDistance = 119
        Me.SplitContainer1.TabIndex = 0
        '
        'cmdUndo
        '
        Me.cmdUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUndo.Location = New System.Drawing.Point(615, 66)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(137, 52)
        Me.cmdUndo.TabIndex = 5
        Me.cmdUndo.Text = "&Undo Delete"
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(615, 8)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(137, 52)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdViewToday
        '
        Me.cmdViewToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdViewToday.Location = New System.Drawing.Point(472, 64)
        Me.cmdViewToday.Name = "cmdViewToday"
        Me.cmdViewToday.Size = New System.Drawing.Size(137, 52)
        Me.cmdViewToday.TabIndex = 0
        Me.cmdViewToday.Text = "Refresh &Today"
        Me.cmdViewToday.UseVisualStyleBackColor = True
        '
        'dtpDateView
        '
        Me.dtpDateView.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpDateView.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateView.Location = New System.Drawing.Point(304, 21)
        Me.dtpDateView.Name = "dtpDateView"
        Me.dtpDateView.Size = New System.Drawing.Size(151, 26)
        Me.dtpDateView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(239, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date:"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdClose.Location = New System.Drawing.Point(761, 7)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(116, 109)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 55)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option View"
        Me.GroupBox1.Visible = False
        '
        'chkView
        '
        Me.chkView.Location = New System.Drawing.Point(27, 21)
        Me.chkView.Name = "chkView"
        Me.chkView.Size = New System.Drawing.Size(163, 24)
        Me.chkView.TabIndex = 0
        Me.chkView.Text = "Auto"
        Me.chkView.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Location = New System.Drawing.Point(472, 8)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(137, 52)
        Me.cmdView.TabIndex = 2
        Me.cmdView.Text = "&View"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(889, 630)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvPaymentList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(881, 597)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Payment List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvPaymentList
        '
        Me.dgvPaymentList.AllowUserToAddRows = False
        Me.dgvPaymentList.AllowUserToDeleteRows = False
        Me.dgvPaymentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPaymentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Check, Me.HN, Me.PatientName, Me.ReceiptNo, Me.IDCashReceipt, Me.ConPay, Me.ConGeneral})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaymentList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPaymentList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPaymentList.Location = New System.Drawing.Point(3, 3)
        Me.dgvPaymentList.Name = "dgvPaymentList"
        Me.dgvPaymentList.ReadOnly = True
        Me.dgvPaymentList.RowHeadersWidth = 12
        Me.dgvPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentList.Size = New System.Drawing.Size(875, 591)
        Me.dgvPaymentList.TabIndex = 0
        '
        'No
        '
        Me.No.Frozen = True
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 70
        '
        'Check
        '
        Me.Check.FillWeight = 50.0!
        Me.Check.Frozen = True
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.ReadOnly = True
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Check.Width = 50
        '
        'HN
        '
        Me.HN.DataPropertyName = "HN"
        Me.HN.Frozen = True
        Me.HN.HeaderText = "HN"
        Me.HN.Name = "HN"
        Me.HN.ReadOnly = True
        Me.HN.Width = 120
        '
        'PatientName
        '
        Me.PatientName.DataPropertyName = "PatientName"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.DefaultCellStyle = DataGridViewCellStyle1
        Me.PatientName.HeaderText = "Name"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        Me.PatientName.Width = 200
        '
        'ReceiptNo
        '
        Me.ReceiptNo.DataPropertyName = "ReceiptNo"
        Me.ReceiptNo.HeaderText = "Receipt No."
        Me.ReceiptNo.Name = "ReceiptNo"
        Me.ReceiptNo.ReadOnly = True
        Me.ReceiptNo.Width = 170
        '
        'IDCashReceipt
        '
        Me.IDCashReceipt.DataPropertyName = "IDCashReceipt"
        Me.IDCashReceipt.HeaderText = "Cash Receipt No."
        Me.IDCashReceipt.Name = "IDCashReceipt"
        Me.IDCashReceipt.ReadOnly = True
        Me.IDCashReceipt.Width = 170
        '
        'ConPay
        '
        Me.ConPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ConPay.DataPropertyName = "ConPay"
        Me.ConPay.FillWeight = 2.0!
        Me.ConPay.HeaderText = ""
        Me.ConPay.MinimumWidth = 2
        Me.ConPay.Name = "ConPay"
        Me.ConPay.ReadOnly = True
        Me.ConPay.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConPay.Width = 2
        '
        'ConGeneral
        '
        Me.ConGeneral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ConGeneral.DataPropertyName = "ConGeneral"
        Me.ConGeneral.FillWeight = 2.0!
        Me.ConGeneral.HeaderText = ""
        Me.ConGeneral.MinimumWidth = 2
        Me.ConGeneral.Name = "ConGeneral"
        Me.ConGeneral.ReadOnly = True
        Me.ConGeneral.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConGeneral.Width = 2
        '
        'tmrPay
        '
        Me.tmrPay.Interval = 300
        '
        'frmPaymentList
        '
        Me.AcceptButton = Me.cmdViewToday
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 753)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPaymentList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment List"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvPaymentList As System.Windows.Forms.DataGridView
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkView As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dtpDateView As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdViewToday As System.Windows.Forms.Button
    Friend WithEvents tmrPay As System.Windows.Forms.Timer
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCashReceipt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConGeneral As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
