<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUndoDelete
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.cmdViewAll = New System.Windows.Forms.Button
        Me.dtpDateView = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgvPaymentList = New System.Windows.Forms.DataGridView
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.HN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Patient = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDCashReceipt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConPay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateIn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdViewAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdUndo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1368, 519)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'cmdViewAll
        '
        Me.cmdViewAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdViewAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewAll.ForeColor = System.Drawing.Color.Black
        Me.cmdViewAll.Location = New System.Drawing.Point(496, 9)
        Me.cmdViewAll.Name = "cmdViewAll"
        Me.cmdViewAll.Size = New System.Drawing.Size(107, 34)
        Me.cmdViewAll.TabIndex = 6
        Me.cmdViewAll.Text = "View &All"
        Me.cmdViewAll.UseVisualStyleBackColor = True
        '
        'dtpDateView
        '
        Me.dtpDateView.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpDateView.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateView.Location = New System.Drawing.Point(103, 17)
        Me.dtpDateView.Name = "dtpDateView"
        Me.dtpDateView.Size = New System.Drawing.Size(115, 26)
        Me.dtpDateView.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date From:"
        '
        'cmdView
        '
        Me.cmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Location = New System.Drawing.Point(383, 9)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(107, 34)
        Me.cmdView.TabIndex = 2
        Me.cmdView.Text = "&View"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(775, 9)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(107, 34)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUndo.Location = New System.Drawing.Point(622, 9)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(137, 34)
        Me.cmdUndo.TabIndex = 0
        Me.cmdUndo.Text = "&Restore Delete"
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1368, 437)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvPaymentList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1360, 404)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deleted Receipt List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvPaymentList
        '
        Me.dgvPaymentList.AllowUserToAddRows = False
        Me.dgvPaymentList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvPaymentList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPaymentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPaymentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Check, Me.HN, Me.Patient, Me.ReceiptNo, Me.IDCashReceipt, Me.ConPay, Me.ConGeneral, Me.DateIn})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaymentList.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPaymentList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPaymentList.Location = New System.Drawing.Point(3, 3)
        Me.dgvPaymentList.Name = "dgvPaymentList"
        Me.dgvPaymentList.ReadOnly = True
        Me.dgvPaymentList.RowHeadersWidth = 12
        Me.dgvPaymentList.RowTemplate.Height = 35
        Me.dgvPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentList.Size = New System.Drawing.Size(1354, 398)
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
        'Patient
        '
        Me.Patient.DataPropertyName = "PatientName"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient.DefaultCellStyle = DataGridViewCellStyle2
        Me.Patient.Frozen = True
        Me.Patient.HeaderText = "Name"
        Me.Patient.Name = "Patient"
        Me.Patient.ReadOnly = True
        Me.Patient.Width = 200
        '
        'ReceiptNo
        '
        Me.ReceiptNo.DataPropertyName = "ReceiptNo"
        Me.ReceiptNo.Frozen = True
        Me.ReceiptNo.HeaderText = "Receipt No."
        Me.ReceiptNo.Name = "ReceiptNo"
        Me.ReceiptNo.ReadOnly = True
        Me.ReceiptNo.Width = 170
        '
        'IDCashReceipt
        '
        Me.IDCashReceipt.DataPropertyName = "IDCashReceipt"
        Me.IDCashReceipt.Frozen = True
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
        Me.ConPay.Visible = False
        Me.ConPay.Width = 2
        '
        'ConGeneral
        '
        Me.ConGeneral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ConGeneral.DataPropertyName = "ConGeneral"
        Me.ConGeneral.FillWeight = 2.0!
        Me.ConGeneral.HeaderText = "Receipt Type"
        Me.ConGeneral.MinimumWidth = 2
        Me.ConGeneral.Name = "ConGeneral"
        Me.ConGeneral.ReadOnly = True
        '
        'DateIn
        '
        Me.DateIn.DataPropertyName = "DateIn"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.DateIn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateIn.HeaderText = "Receipt Date"
        Me.DateIn.Name = "DateIn"
        Me.DateIn.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(888, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 67)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Note:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "OR = Old-Patient Receipt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "IR = In-Patient Receipt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NR = New-Patient Receipt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "OP = Optical Shop Receipt"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(262, 17)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(115, 26)
        Me.DateTo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "To:"
        '
        'frmUndoDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 519)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUndoDelete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Deleted Receipt List"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvPaymentList As System.Windows.Forms.DataGridView
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdViewAll As System.Windows.Forms.Button
    Friend WithEvents dtpDateView As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Patient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCashReceipt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConGeneral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
End Class
