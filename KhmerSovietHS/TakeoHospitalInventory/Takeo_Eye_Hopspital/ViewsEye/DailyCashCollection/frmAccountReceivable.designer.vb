<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountReceivable
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountReceivable))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.LblReceiveAbleID = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.cmdView = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblUSD = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAID = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkRiel = New System.Windows.Forms.CheckBox
        Me.txtAmountUSD = New System.Windows.Forms.TextBox
        Me.chkDollar = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAmountRiel = New System.Windows.Forms.TextBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cboAccountName = New System.Windows.Forms.ComboBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdAccName = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvAccountReceivable = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountUSD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountRiel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateIn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ctmModifyDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnModifyDate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ErrAccountReceiveAble = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAccountReceivable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctmModifyDate.SuspendLayout()
        CType(Me.ErrAccountReceiveAble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1161, 738)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1153, 705)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Remarks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblReceiveAbleID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkRiel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAmountUSD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkDollar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAmountRiel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdNew)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboAccountName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAccName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdClose)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1147, 699)
        Me.SplitContainer1.SplitterDistance = 226
        Me.SplitContainer1.TabIndex = 18
        '
        'LblReceiveAbleID
        '
        Me.LblReceiveAbleID.AutoSize = True
        Me.LblReceiveAbleID.Location = New System.Drawing.Point(408, 17)
        Me.LblReceiveAbleID.Name = "LblReceiveAbleID"
        Me.LblReceiveAbleID.Size = New System.Drawing.Size(18, 20)
        Me.LblReceiveAbleID.TabIndex = 26
        Me.LblReceiveAbleID.Text = "0"
        Me.LblReceiveAbleID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DateTo)
        Me.GroupBox2.Controls.Add(Me.DateFrom)
        Me.GroupBox2.Controls.Add(Me.cmdView)
        Me.GroupBox2.Location = New System.Drawing.Point(870, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 121)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "To:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "From:"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(82, 57)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(165, 26)
        Me.DateTo.TabIndex = 7
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(82, 24)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(165, 26)
        Me.DateFrom.TabIndex = 6
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(163, 86)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(84, 30)
        Me.cmdView.TabIndex = 11
        Me.cmdView.Text = "&View"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Warning
        Me.PictureBox1.Location = New System.Drawing.Point(132, 195)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(154, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(514, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Please select the item in the below list and right click to update the date."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblUSD)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(160, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 38)
        Me.Panel1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total:"
        '
        'lblUSD
        '
        Me.lblUSD.AutoSize = True
        Me.lblUSD.Location = New System.Drawing.Point(67, 8)
        Me.lblUSD.Name = "lblUSD"
        Me.lblUSD.Size = New System.Drawing.Size(47, 20)
        Me.lblUSD.TabIndex = 19
        Me.lblUSD.Text = "USD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Amount RIEL:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(674, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "View &All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Name:"
        '
        'lblAID
        '
        Me.lblAID.AutoSize = True
        Me.lblAID.Location = New System.Drawing.Point(331, 19)
        Me.lblAID.Name = "lblAID"
        Me.lblAID.Size = New System.Drawing.Size(18, 20)
        Me.lblAID.TabIndex = 16
        Me.lblAID.Text = "0"
        Me.lblAID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount USD:"
        '
        'chkRiel
        '
        Me.chkRiel.AutoSize = True
        Me.chkRiel.Location = New System.Drawing.Point(509, 118)
        Me.chkRiel.Name = "chkRiel"
        Me.chkRiel.Size = New System.Drawing.Size(65, 24)
        Me.chkRiel.TabIndex = 15
        Me.chkRiel.Text = "RIEL"
        Me.chkRiel.UseVisualStyleBackColor = True
        '
        'txtAmountUSD
        '
        Me.txtAmountUSD.Enabled = False
        Me.txtAmountUSD.Location = New System.Drawing.Point(160, 83)
        Me.txtAmountUSD.Name = "txtAmountUSD"
        Me.txtAmountUSD.Size = New System.Drawing.Size(343, 26)
        Me.txtAmountUSD.TabIndex = 3
        Me.txtAmountUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkDollar
        '
        Me.chkDollar.AutoSize = True
        Me.chkDollar.Location = New System.Drawing.Point(509, 86)
        Me.chkDollar.Name = "chkDollar"
        Me.chkDollar.Size = New System.Drawing.Size(64, 24)
        Me.chkDollar.TabIndex = 14
        Me.chkDollar.Text = "US $"
        Me.chkDollar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date create:"
        '
        'txtAmountRiel
        '
        Me.txtAmountRiel.Enabled = False
        Me.txtAmountRiel.Location = New System.Drawing.Point(160, 115)
        Me.txtAmountRiel.Name = "txtAmountRiel"
        Me.txtAmountRiel.Size = New System.Drawing.Size(343, 26)
        Me.txtAmountRiel.TabIndex = 13
        Me.txtAmountRiel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDate
        '
        Me.dtpDate.Checked = False
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(160, 14)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShowCheckBox = True
        Me.dtpDate.Size = New System.Drawing.Size(165, 26)
        Me.dtpDate.TabIndex = 5
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(674, 30)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(84, 30)
        Me.cmdNew.TabIndex = 7
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cboAccountName
        '
        Me.cboAccountName.FormattingEnabled = True
        Me.cboAccountName.Location = New System.Drawing.Point(160, 46)
        Me.cboAccountName.Name = "cboAccountName"
        Me.cboAccountName.Size = New System.Drawing.Size(414, 28)
        Me.cboAccountName.TabIndex = 10
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(764, 30)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(84, 30)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdAccName
        '
        Me.cmdAccName.Location = New System.Drawing.Point(580, 45)
        Me.cmdAccName.Name = "cmdAccName"
        Me.cmdAccName.Size = New System.Drawing.Size(50, 30)
        Me.cmdAccName.TabIndex = 9
        Me.cmdAccName.Text = "..."
        Me.cmdAccName.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(674, 102)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(174, 38)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvAccountReceivable)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1145, 467)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remarks list"
        '
        'dgvAccountReceivable
        '
        Me.dgvAccountReceivable.AllowUserToAddRows = False
        Me.dgvAccountReceivable.AllowUserToDeleteRows = False
        Me.dgvAccountReceivable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAccountReceivable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAccountReceivable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccountReceivable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.AID, Me.AccountName, Me.AmountUSD, Me.AmountRiel, Me.DateIn})
        Me.dgvAccountReceivable.ContextMenuStrip = Me.ctmModifyDate
        Me.dgvAccountReceivable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAccountReceivable.Location = New System.Drawing.Point(3, 22)
        Me.dgvAccountReceivable.Name = "dgvAccountReceivable"
        Me.dgvAccountReceivable.ReadOnly = True
        Me.dgvAccountReceivable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccountReceivable.Size = New System.Drawing.Size(1139, 442)
        Me.dgvAccountReceivable.TabIndex = 0
        Me.dgvAccountReceivable.Tag = ""
        '
        'ID
        '
        Me.ID.DataPropertyName = "IDs"
        Me.ID.Frozen = True
        Me.ID.HeaderText = ""
        Me.ID.MinimumWidth = 2
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 2
        '
        'AID
        '
        Me.AID.DataPropertyName = "ID"
        Me.AID.HeaderText = "Account No"
        Me.AID.Name = "AID"
        Me.AID.ReadOnly = True
        Me.AID.Width = 150
        '
        'AccountName
        '
        Me.AccountName.DataPropertyName = "Account Name"
        Me.AccountName.HeaderText = "Account Name"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.ReadOnly = True
        Me.AccountName.Width = 300
        '
        'AmountUSD
        '
        Me.AmountUSD.DataPropertyName = "Amount USD"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.AmountUSD.DefaultCellStyle = DataGridViewCellStyle1
        Me.AmountUSD.HeaderText = "Amount USD"
        Me.AmountUSD.Name = "AmountUSD"
        Me.AmountUSD.ReadOnly = True
        Me.AmountUSD.Width = 130
        '
        'AmountRiel
        '
        Me.AmountRiel.DataPropertyName = "Amount RIEL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "R 0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.AmountRiel.DefaultCellStyle = DataGridViewCellStyle2
        Me.AmountRiel.HeaderText = "Amount RIEL"
        Me.AmountRiel.Name = "AmountRiel"
        Me.AmountRiel.ReadOnly = True
        Me.AmountRiel.Width = 130
        '
        'DateIn
        '
        Me.DateIn.DataPropertyName = "Date"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DateIn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateIn.HeaderText = "Date"
        Me.DateIn.Name = "DateIn"
        Me.DateIn.ReadOnly = True
        Me.DateIn.Width = 120
        '
        'ctmModifyDate
        '
        Me.ctmModifyDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.mnModifyDate, Me.ToolStripMenuItem2})
        Me.ctmModifyDate.Name = "ctmModifyDate"
        Me.ctmModifyDate.Size = New System.Drawing.Size(230, 38)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(226, 6)
        '
        'mnModifyDate
        '
        Me.mnModifyDate.Name = "mnModifyDate"
        Me.mnModifyDate.Size = New System.Drawing.Size(229, 22)
        Me.mnModifyDate.Text = "Modify &Date Account Receipt"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(226, 6)
        '
        'ErrAccountReceiveAble
        '
        Me.ErrAccountReceiveAble.ContainerControl = Me
        '
        'frmAccountReceivable
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 738)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccountReceivable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Receivable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvAccountReceivable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctmModifyDate.ResumeLayout(False)
        CType(Me.ErrAccountReceiveAble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtAmountUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dgvAccountReceivable As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAccName As System.Windows.Forms.Button
    Friend WithEvents cboAccountName As System.Windows.Forms.ComboBox
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents chkRiel As System.Windows.Forms.CheckBox
    Friend WithEvents chkDollar As System.Windows.Forms.CheckBox
    Friend WithEvents txtAmountRiel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAID As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUSD As System.Windows.Forms.Label
    Friend WithEvents ctmModifyDate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnModifyDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblReceiveAbleID As System.Windows.Forms.Label
    Friend WithEvents ErrAccountReceiveAble As System.Windows.Forms.ErrorProvider
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountUSD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountRiel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateIn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
