<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCReportItemTransaction
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadDateToDate = New System.Windows.Forms.RadioButton
        Me.dptToDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.rbMontly = New System.Windows.Forms.RadioButton
        Me.rbDaily = New System.Windows.Forms.RadioButton
        Me.gbDepart = New System.Windows.Forms.GroupBox
        Me.RadItem = New System.Windows.Forms.RadioButton
        Me.btnPreviewByCate = New System.Windows.Forms.Button
        Me.RadCate = New System.Windows.Forms.RadioButton
        Me.btnPreviewByItem = New System.Windows.Forms.Button
        Me.btnStockAdjustment = New System.Windows.Forms.Button
        Me.cbCate = New System.Windows.Forms.ComboBox
        Me.btnPreviewByDepart = New System.Windows.Forms.Button
        Me.cbItems = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbDepart = New System.Windows.Forms.ComboBox
        Me.CRVItemTransaction = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.ContainerLoading = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.ErrReport = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbDepart.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbDepart)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CRVItemTransaction)
        Me.SplitContainer1.Size = New System.Drawing.Size(952, 549)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(637, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Begin Balance=(End Balace+Used)-Received"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(635, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 62)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Note : To view the latest updated data, Department is required to run end of day " & _
            "process"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadDateToDate)
        Me.GroupBox4.Controls.Add(Me.dptToDate)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dptFromDate)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.rbMontly)
        Me.GroupBox4.Controls.Add(Me.rbDaily)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 186)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'RadDateToDate
        '
        Me.RadDateToDate.AutoSize = True
        Me.RadDateToDate.Checked = True
        Me.RadDateToDate.Location = New System.Drawing.Point(6, 116)
        Me.RadDateToDate.Name = "RadDateToDate"
        Me.RadDateToDate.Size = New System.Drawing.Size(90, 17)
        Me.RadDateToDate.TabIndex = 13
        Me.RadDateToDate.TabStop = True
        Me.RadDateToDate.Text = "Date To Date"
        Me.RadDateToDate.UseVisualStyleBackColor = True
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(5, 82)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(151, 26)
        Me.dptToDate.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "To Date:"
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(5, 28)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(151, 26)
        Me.dptFromDate.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "From Date:"
        '
        'rbMontly
        '
        Me.rbMontly.AutoSize = True
        Me.rbMontly.Location = New System.Drawing.Point(8, 146)
        Me.rbMontly.Name = "rbMontly"
        Me.rbMontly.Size = New System.Drawing.Size(56, 17)
        Me.rbMontly.TabIndex = 1
        Me.rbMontly.Text = "Montly"
        Me.rbMontly.UseVisualStyleBackColor = True
        '
        'rbDaily
        '
        Me.rbDaily.AutoSize = True
        Me.rbDaily.Location = New System.Drawing.Point(94, 147)
        Me.rbDaily.Name = "rbDaily"
        Me.rbDaily.Size = New System.Drawing.Size(48, 17)
        Me.rbDaily.TabIndex = 0
        Me.rbDaily.Text = "Daily"
        Me.rbDaily.UseVisualStyleBackColor = True
        '
        'gbDepart
        '
        Me.gbDepart.Controls.Add(Me.RadItem)
        Me.gbDepart.Controls.Add(Me.btnPreviewByCate)
        Me.gbDepart.Controls.Add(Me.RadCate)
        Me.gbDepart.Controls.Add(Me.btnPreviewByItem)
        Me.gbDepart.Controls.Add(Me.btnStockAdjustment)
        Me.gbDepart.Controls.Add(Me.cbCate)
        Me.gbDepart.Controls.Add(Me.btnPreviewByDepart)
        Me.gbDepart.Controls.Add(Me.cbItems)
        Me.gbDepart.Controls.Add(Me.Label4)
        Me.gbDepart.Controls.Add(Me.cbDepart)
        Me.gbDepart.Location = New System.Drawing.Point(185, 14)
        Me.gbDepart.Name = "gbDepart"
        Me.gbDepart.Size = New System.Drawing.Size(446, 175)
        Me.gbDepart.TabIndex = 7
        Me.gbDepart.TabStop = False
        Me.gbDepart.Text = "Department Item Transaction Report"
        '
        'RadItem
        '
        Me.RadItem.AutoSize = True
        Me.RadItem.Location = New System.Drawing.Point(6, 103)
        Me.RadItem.Name = "RadItem"
        Me.RadItem.Size = New System.Drawing.Size(56, 17)
        Me.RadItem.TabIndex = 11
        Me.RadItem.Text = "Items :"
        Me.RadItem.UseVisualStyleBackColor = True
        '
        'btnPreviewByCate
        '
        Me.btnPreviewByCate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreviewByCate.Enabled = False
        Me.btnPreviewByCate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.preview
        Me.btnPreviewByCate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewByCate.Location = New System.Drawing.Point(348, 51)
        Me.btnPreviewByCate.Name = "btnPreviewByCate"
        Me.btnPreviewByCate.Size = New System.Drawing.Size(93, 33)
        Me.btnPreviewByCate.TabIndex = 21
        Me.btnPreviewByCate.Text = "Preview"
        Me.btnPreviewByCate.UseVisualStyleBackColor = True
        '
        'RadCate
        '
        Me.RadCate.AutoSize = True
        Me.RadCate.Location = New System.Drawing.Point(6, 67)
        Me.RadCate.Name = "RadCate"
        Me.RadCate.Size = New System.Drawing.Size(81, 17)
        Me.RadCate.TabIndex = 10
        Me.RadCate.Text = "Categories :"
        Me.RadCate.UseVisualStyleBackColor = True
        '
        'btnPreviewByItem
        '
        Me.btnPreviewByItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreviewByItem.Enabled = False
        Me.btnPreviewByItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.preview
        Me.btnPreviewByItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewByItem.Location = New System.Drawing.Point(348, 89)
        Me.btnPreviewByItem.Name = "btnPreviewByItem"
        Me.btnPreviewByItem.Size = New System.Drawing.Size(93, 33)
        Me.btnPreviewByItem.TabIndex = 21
        Me.btnPreviewByItem.Text = "Preview"
        Me.btnPreviewByItem.UseVisualStyleBackColor = True
        '
        'btnStockAdjustment
        '
        Me.btnStockAdjustment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockAdjustment.Image = Global.TakeoHospitalInventory.My.Resources.Resources.preview
        Me.btnStockAdjustment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockAdjustment.Location = New System.Drawing.Point(23, 135)
        Me.btnStockAdjustment.Name = "btnStockAdjustment"
        Me.btnStockAdjustment.Size = New System.Drawing.Size(237, 34)
        Me.btnStockAdjustment.TabIndex = 22
        Me.btnStockAdjustment.Text = "Preview Department Stock Adjustment"
        Me.btnStockAdjustment.UseVisualStyleBackColor = True
        '
        'cbCate
        '
        Me.cbCate.Enabled = False
        Me.cbCate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbCate.FormattingEnabled = True
        Me.cbCate.Location = New System.Drawing.Point(93, 56)
        Me.cbCate.Name = "cbCate"
        Me.cbCate.Size = New System.Drawing.Size(238, 28)
        Me.cbCate.TabIndex = 19
        '
        'btnPreviewByDepart
        '
        Me.btnPreviewByDepart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreviewByDepart.Image = Global.TakeoHospitalInventory.My.Resources.Resources.preview
        Me.btnPreviewByDepart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewByDepart.Location = New System.Drawing.Point(348, 12)
        Me.btnPreviewByDepart.Name = "btnPreviewByDepart"
        Me.btnPreviewByDepart.Size = New System.Drawing.Size(93, 33)
        Me.btnPreviewByDepart.TabIndex = 21
        Me.btnPreviewByDepart.Text = "Preview"
        Me.btnPreviewByDepart.UseVisualStyleBackColor = True
        '
        'cbItems
        '
        Me.cbItems.Enabled = False
        Me.cbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItems.FormattingEnabled = True
        Me.cbItems.Location = New System.Drawing.Point(93, 92)
        Me.cbItems.Name = "cbItems"
        Me.cbItems.Size = New System.Drawing.Size(238, 28)
        Me.cbItems.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Departments :"
        '
        'cbDepart
        '
        Me.cbDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbDepart.FormattingEnabled = True
        Me.cbDepart.Location = New System.Drawing.Point(93, 19)
        Me.cbDepart.Name = "cbDepart"
        Me.cbDepart.Size = New System.Drawing.Size(238, 28)
        Me.cbDepart.TabIndex = 19
        '
        'CRVItemTransaction
        '
        Me.CRVItemTransaction.ActiveViewIndex = -1
        Me.CRVItemTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVItemTransaction.DisplayGroupTree = False
        Me.CRVItemTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVItemTransaction.Location = New System.Drawing.Point(0, 0)
        Me.CRVItemTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.CRVItemTransaction.Name = "CRVItemTransaction"
        Me.CRVItemTransaction.SelectionFormula = ""
        Me.CRVItemTransaction.ShowGroupTreeButton = False
        Me.CRVItemTransaction.ShowRefreshButton = False
        Me.CRVItemTransaction.Size = New System.Drawing.Size(952, 353)
        Me.CRVItemTransaction.TabIndex = 7
        Me.CRVItemTransaction.ViewTimeSelectionFormula = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loadingNew3
        Me.PictureBox2.Location = New System.Drawing.Point(88, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loadingNew3
        Me.PictureBox1.Location = New System.Drawing.Point(88, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BgLoadingReport
        '
        Me.BgLoadingReport.WorkerSupportsCancellation = True
        '
        'ContainerLoading
        '
        Me.ContainerLoading.Control = Me.PictureBox2
        Me.ContainerLoading.ControlWidth = 200
        Me.ContainerLoading.Key = "ContainerControlCommand1"
        Me.ContainerLoading.Name = "ContainerLoading"
        Me.ContainerLoading.Text = "Loading Report:"
        '
        'ErrReport
        '
        Me.ErrReport.ContainerControl = Me
        '
        'UCReportItemTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCReportItemTransaction"
        Me.Size = New System.Drawing.Size(952, 549)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbDepart.ResumeLayout(False)
        Me.gbDepart.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbMontly As System.Windows.Forms.RadioButton
    Friend WithEvents rbDaily As System.Windows.Forms.RadioButton
    Friend WithEvents gbDepart As System.Windows.Forms.GroupBox
    Friend WithEvents btnStockAdjustment As System.Windows.Forms.Button
    Friend WithEvents btnPreviewByDepart As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbDepart As System.Windows.Forms.ComboBox
    Friend WithEvents btnPreviewByCate As System.Windows.Forms.Button
    Friend WithEvents cbCate As System.Windows.Forms.ComboBox
    Friend WithEvents btnPreviewByItem As System.Windows.Forms.Button
    Friend WithEvents cbItems As System.Windows.Forms.ComboBox
    Friend WithEvents CRVItemTransaction As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ContainerLoading As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadItem As System.Windows.Forms.RadioButton
    Friend WithEvents RadCate As System.Windows.Forms.RadioButton
    Friend WithEvents ErrReport As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadDateToDate As System.Windows.Forms.RadioButton

End Class
