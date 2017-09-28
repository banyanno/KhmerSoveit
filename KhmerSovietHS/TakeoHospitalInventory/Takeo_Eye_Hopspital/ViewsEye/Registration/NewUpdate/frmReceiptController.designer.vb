<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportReceiptController
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportReceiptController))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.cmdPrintDetail = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdFind = New System.Windows.Forms.Button
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCashReceipt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPatientName = New System.Windows.Forms.TextBox
        Me.txtHN = New System.Windows.Forms.TextBox
        Me.txtReceiptNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgvFindInfos = New System.Windows.Forms.DataGridView
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.HN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CashReceipt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.USD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RIEL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateIn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Con = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bgwReceipt = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvFindInfos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPrintDetail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPrint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(963, 612)
        Me.SplitContainer1.SplitterDistance = 181
        Me.SplitContainer1.TabIndex = 0
        '
        'cmdPrintDetail
        '
        Me.cmdPrintDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrintDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintDetail.Location = New System.Drawing.Point(651, 106)
        Me.cmdPrintDetail.Name = "cmdPrintDetail"
        Me.cmdPrintDetail.Size = New System.Drawing.Size(169, 61)
        Me.cmdPrintDetail.TabIndex = 3
        Me.cmdPrintDetail.Text = "Print &Detail"
        Me.cmdPrintDetail.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.cmdPrint.Location = New System.Drawing.Point(650, 42)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(169, 61)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(832, 42)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(132, 125)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(970, 12)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(43, 34)
        Me.cmdDelete.TabIndex = 0
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdFind)
        Me.GroupBox1.Controls.Add(Me.dtpDateIn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCashReceipt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPatientName)
        Me.GroupBox1.Controls.Add(Me.txtHN)
        Me.GroupBox1.Controls.Add(Me.txtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 181)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Conditions"
        '
        'cmdFind
        '
        Me.cmdFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Location = New System.Drawing.Point(464, 94)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(133, 62)
        Me.cmdFind.TabIndex = 5
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'dtpDateIn
        '
        Me.dtpDateIn.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateIn.Location = New System.Drawing.Point(130, 30)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.ShowCheckBox = True
        Me.dtpDateIn.Size = New System.Drawing.Size(146, 26)
        Me.dtpDateIn.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Patient Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HN:"
        '
        'txtCashReceipt
        '
        Me.txtCashReceipt.Location = New System.Drawing.Point(437, 62)
        Me.txtCashReceipt.Name = "txtCashReceipt"
        Me.txtCashReceipt.Size = New System.Drawing.Size(160, 26)
        Me.txtCashReceipt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cash Receipt No.:"
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(130, 94)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(301, 39)
        Me.txtPatientName.TabIndex = 2
        '
        'txtHN
        '
        Me.txtHN.Location = New System.Drawing.Point(130, 62)
        Me.txtHN.Name = "txtHN"
        Me.txtHN.Size = New System.Drawing.Size(146, 26)
        Me.txtHN.TabIndex = 1
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Location = New System.Drawing.Point(437, 30)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(160, 26)
        Me.txtReceiptNo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Receipt No.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No.:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(963, 427)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvFindInfos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(955, 394)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Find Results"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvFindInfos
        '
        Me.dgvFindInfos.AllowUserToAddRows = False
        Me.dgvFindInfos.AllowUserToDeleteRows = False
        Me.dgvFindInfos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvFindInfos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFindInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFindInfos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.HN, Me.PatientName, Me.ReceiptNo, Me.CashReceipt, Me.USD, Me.RIEL, Me.DateIn, Me.Con})
        Me.dgvFindInfos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFindInfos.Location = New System.Drawing.Point(3, 3)
        Me.dgvFindInfos.Name = "dgvFindInfos"
        Me.dgvFindInfos.ReadOnly = True
        Me.dgvFindInfos.RowHeadersWidth = 55
        Me.dgvFindInfos.RowTemplate.Height = 24
        Me.dgvFindInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFindInfos.Size = New System.Drawing.Size(949, 388)
        Me.dgvFindInfos.TabIndex = 0
        '
        'Check
        '
        Me.Check.FillWeight = 30.0!
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.ReadOnly = True
        Me.Check.Width = 30
        '
        'HN
        '
        Me.HN.DataPropertyName = "HN"
        Me.HN.HeaderText = "HN"
        Me.HN.Name = "HN"
        Me.HN.ReadOnly = True
        '
        'PatientName
        '
        Me.PatientName.DataPropertyName = "PatientName"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.DefaultCellStyle = DataGridViewCellStyle1
        Me.PatientName.FillWeight = 200.0!
        Me.PatientName.HeaderText = "Patient Name"
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
        Me.ReceiptNo.Width = 140
        '
        'CashReceipt
        '
        Me.CashReceipt.DataPropertyName = "IDCashReceipt"
        Me.CashReceipt.HeaderText = "Cash Receipt"
        Me.CashReceipt.Name = "CashReceipt"
        Me.CashReceipt.ReadOnly = True
        Me.CashReceipt.Width = 150
        '
        'USD
        '
        Me.USD.DataPropertyName = "CashUSD"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        Me.USD.DefaultCellStyle = DataGridViewCellStyle2
        Me.USD.HeaderText = "USD"
        Me.USD.Name = "USD"
        Me.USD.ReadOnly = True
        '
        'RIEL
        '
        Me.RIEL.DataPropertyName = "CashRiel"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.RIEL.DefaultCellStyle = DataGridViewCellStyle3
        Me.RIEL.FillWeight = 130.0!
        Me.RIEL.HeaderText = "RIEL"
        Me.RIEL.Name = "RIEL"
        Me.RIEL.ReadOnly = True
        Me.RIEL.Width = 130
        '
        'DateIn
        '
        Me.DateIn.DataPropertyName = "DateIn"
        DataGridViewCellStyle4.Format = "dd/MM/yyyy"
        Me.DateIn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DateIn.HeaderText = "Date"
        Me.DateIn.Name = "DateIn"
        Me.DateIn.ReadOnly = True
        '
        'Con
        '
        Me.Con.DataPropertyName = "ConPay"
        Me.Con.FillWeight = 2.0!
        Me.Con.HeaderText = ""
        Me.Con.MinimumWidth = 2
        Me.Con.Name = "Con"
        Me.Con.ReadOnly = True
        Me.Con.Width = 2
        '
        'bgwReceipt
        '
        '
        'frmReportReceiptController
        '
        Me.AcceptButton = Me.cmdFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportReceiptController"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt Information"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvFindInfos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents dtpDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCashReceipt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents txtHN As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvFindInfos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents bgwReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdPrintDetail As System.Windows.Forms.Button
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashReceipt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RIEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Con As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
