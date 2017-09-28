<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVAReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVAReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.DateMainTo = New System.Windows.Forms.DateTimePicker
        Me.DateMainStart = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnPrintMain2 = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.BtnPrintMain1 = New System.Windows.Forms.Button
        Me.CboMainMonth = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CboMainYear = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnPrintByBetween = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnByMonth = New System.Windows.Forms.Button
        Me.CboMonth = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.CboYear = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.rdLeftEye = New System.Windows.Forms.RadioButton
        Me.rdRightEye = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PicLoadReport = New System.Windows.Forms.PictureBox
        Me.CrvVAReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BgLoadVAByMonth = New System.ComponentModel.BackgroundWorker
        Me.BgLoadVAByDate = New System.ComponentModel.BackgroundWorker
        Me.BgMainByMonth = New System.ComponentModel.BackgroundWorker
        Me.BgMainByDate = New System.ComponentModel.BackgroundWorker
        Me.DSVA = New TakeoHospitalInventory.DSVA
        Me.TblVAPlainTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblVAPlainTableAdapter
        Me.TblVAPHTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblVAPHTableAdapter
        Me.TblVAGlassesTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblVAGlassesTableAdapter
        Me.TblVAPlainRightTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblVAPlainRightTableAdapter
        Me.TblVAPHRightTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblVAPHRightTableAdapter
        Me.TblVAGlassesRightTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblVAGlassesRightTableAdapter
        Me.TblMainPlainTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblMainPlainTableAdapter
        Me.TblMainPhTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblMainPhTableAdapter
        Me.TblMainGlassesTableAdapter = New TakeoHospitalInventory.DSVATableAdapters.TblMainGlassesTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicLoadReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(516, 110)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DateMainTo)
        Me.GroupBox7.Controls.Add(Me.DateMainStart)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.BtnPrintMain2)
        Me.GroupBox7.Location = New System.Drawing.Point(253, 13)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(256, 89)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Report By From- To date"
        '
        'DateMainTo
        '
        Me.DateMainTo.CustomFormat = "dd/MM/yyyy"
        Me.DateMainTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateMainTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateMainTo.Location = New System.Drawing.Point(45, 52)
        Me.DateMainTo.Name = "DateMainTo"
        Me.DateMainTo.Size = New System.Drawing.Size(119, 26)
        Me.DateMainTo.TabIndex = 11
        '
        'DateMainStart
        '
        Me.DateMainStart.CustomFormat = "dd/MM/yyyy"
        Me.DateMainStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateMainStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateMainStart.Location = New System.Drawing.Point(45, 20)
        Me.DateMainStart.Name = "DateMainStart"
        Me.DateMainStart.Size = New System.Drawing.Size(119, 26)
        Me.DateMainStart.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "From:"
        '
        'BtnPrintMain2
        '
        Me.BtnPrintMain2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintMain2.Location = New System.Drawing.Point(170, 52)
        Me.BtnPrintMain2.Name = "BtnPrintMain2"
        Me.BtnPrintMain2.Size = New System.Drawing.Size(77, 27)
        Me.BtnPrintMain2.TabIndex = 10
        Me.BtnPrintMain2.Text = "Print Preview"
        Me.BtnPrintMain2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.BtnPrintMain1)
        Me.GroupBox8.Controls.Add(Me.CboMainMonth)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.CboMainYear)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(242, 89)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Report VA By Month and Year"
        '
        'BtnPrintMain1
        '
        Me.BtnPrintMain1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintMain1.Location = New System.Drawing.Point(156, 54)
        Me.BtnPrintMain1.Name = "BtnPrintMain1"
        Me.BtnPrintMain1.Size = New System.Drawing.Size(78, 30)
        Me.BtnPrintMain1.TabIndex = 10
        Me.BtnPrintMain1.Text = "Print Preview"
        Me.BtnPrintMain1.UseVisualStyleBackColor = True
        '
        'CboMainMonth
        '
        Me.CboMainMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMainMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMainMonth.FormattingEnabled = True
        Me.CboMainMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.CboMainMonth.Location = New System.Drawing.Point(47, 22)
        Me.CboMainMonth.Name = "CboMainMonth"
        Me.CboMainMonth.Size = New System.Drawing.Size(103, 28)
        Me.CboMainMonth.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Year:"
        '
        'CboMainYear
        '
        Me.CboMainYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMainYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMainYear.FormattingEnabled = True
        Me.CboMainYear.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.CboMainYear.Location = New System.Drawing.Point(47, 55)
        Me.CboMainYear.Name = "CboMainYear"
        Me.CboMainYear.Size = New System.Drawing.Size(103, 28)
        Me.CboMainYear.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Month:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.rdLeftEye)
        Me.GroupBox5.Controls.Add(Me.rdRightEye)
        Me.GroupBox5.Location = New System.Drawing.Point(528, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(597, 110)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "By condition"
        Me.GroupBox5.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTo)
        Me.GroupBox4.Controls.Add(Me.DateFrom)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.BtnPrintByBetween)
        Me.GroupBox4.Location = New System.Drawing.Point(333, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 89)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report By Between date To date"
        Me.GroupBox4.Visible = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(61, 52)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(103, 26)
        Me.DateTo.TabIndex = 11
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(61, 20)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(103, 26)
        Me.DateFrom.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Between:"
        '
        'BtnPrintByBetween
        '
        Me.BtnPrintByBetween.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintByBetween.Location = New System.Drawing.Point(170, 52)
        Me.BtnPrintByBetween.Name = "BtnPrintByBetween"
        Me.BtnPrintByBetween.Size = New System.Drawing.Size(77, 27)
        Me.BtnPrintByBetween.TabIndex = 10
        Me.BtnPrintByBetween.Text = "Print Preview"
        Me.BtnPrintByBetween.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnByMonth)
        Me.GroupBox3.Controls.Add(Me.CboMonth)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.CboYear)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(86, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 89)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report By Month and Year"
        '
        'BtnByMonth
        '
        Me.BtnByMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnByMonth.Location = New System.Drawing.Point(156, 54)
        Me.BtnByMonth.Name = "BtnByMonth"
        Me.BtnByMonth.Size = New System.Drawing.Size(78, 30)
        Me.BtnByMonth.TabIndex = 10
        Me.BtnByMonth.Text = "Print Preview"
        Me.BtnByMonth.UseVisualStyleBackColor = True
        '
        'CboMonth
        '
        Me.CboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMonth.FormattingEnabled = True
        Me.CboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.CboMonth.Location = New System.Drawing.Point(47, 22)
        Me.CboMonth.Name = "CboMonth"
        Me.CboMonth.Size = New System.Drawing.Size(103, 28)
        Me.CboMonth.TabIndex = 9
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 67)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Year:"
        '
        'CboYear
        '
        Me.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboYear.FormattingEnabled = True
        Me.CboYear.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.CboYear.Location = New System.Drawing.Point(47, 55)
        Me.CboYear.Name = "CboYear"
        Me.CboYear.Size = New System.Drawing.Size(103, 28)
        Me.CboYear.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Month:"
        '
        'rdLeftEye
        '
        Me.rdLeftEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdLeftEye.Location = New System.Drawing.Point(8, 52)
        Me.rdLeftEye.Name = "rdLeftEye"
        Me.rdLeftEye.Size = New System.Drawing.Size(90, 23)
        Me.rdLeftEye.TabIndex = 23
        Me.rdLeftEye.Text = "&Left Eye"
        Me.rdLeftEye.UseVisualStyleBackColor = True
        '
        'rdRightEye
        '
        Me.rdRightEye.Checked = True
        Me.rdRightEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdRightEye.Location = New System.Drawing.Point(8, 22)
        Me.rdRightEye.Name = "rdRightEye"
        Me.rdRightEye.Size = New System.Drawing.Size(90, 24)
        Me.rdRightEye.TabIndex = 22
        Me.rdRightEye.TabStop = True
        Me.rdRightEye.Text = "&Right Eye"
        Me.rdRightEye.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicLoadReport)
        Me.GroupBox2.Controls.Add(Me.CrvVAReport)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(963, 483)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VA Result"
        '
        'PicLoadReport
        '
        Me.PicLoadReport.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar
        Me.PicLoadReport.Location = New System.Drawing.Point(558, 420)
        Me.PicLoadReport.Name = "PicLoadReport"
        Me.PicLoadReport.Size = New System.Drawing.Size(168, 22)
        Me.PicLoadReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoadReport.TabIndex = 2
        Me.PicLoadReport.TabStop = False
        Me.PicLoadReport.Visible = False
        '
        'CrvVAReport
        '
        Me.CrvVAReport.ActiveViewIndex = -1
        Me.CrvVAReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvVAReport.DisplayGroupTree = False
        Me.CrvVAReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvVAReport.Location = New System.Drawing.Point(3, 16)
        Me.CrvVAReport.Name = "CrvVAReport"
        Me.CrvVAReport.SelectionFormula = ""
        Me.CrvVAReport.Size = New System.Drawing.Size(957, 464)
        Me.CrvVAReport.TabIndex = 0
        Me.CrvVAReport.ViewTimeSelectionFormula = ""
        '
        'BgLoadVAByMonth
        '
        '
        'BgLoadVAByDate
        '
        '
        'BgMainByMonth
        '
        '
        'BgMainByDate
        '
        '
        'DSVA
        '
        Me.DSVA.DataSetName = "DSVA"
        Me.DSVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblVAPlainTableAdapter
        '
        Me.TblVAPlainTableAdapter.ClearBeforeFill = True
        '
        'TblVAPHTableAdapter
        '
        Me.TblVAPHTableAdapter.ClearBeforeFill = True
        '
        'TblVAGlassesTableAdapter
        '
        Me.TblVAGlassesTableAdapter.ClearBeforeFill = True
        '
        'TblVAPlainRightTableAdapter
        '
        Me.TblVAPlainRightTableAdapter.ClearBeforeFill = True
        '
        'TblVAPHRightTableAdapter
        '
        Me.TblVAPHRightTableAdapter.ClearBeforeFill = True
        '
        'TblVAGlassesRightTableAdapter
        '
        Me.TblVAGlassesRightTableAdapter.ClearBeforeFill = True
        '
        'TblMainPlainTableAdapter
        '
        Me.TblMainPlainTableAdapter.ClearBeforeFill = True
        '
        'TblMainPhTableAdapter
        '
        Me.TblMainPhTableAdapter.ClearBeforeFill = True
        '
        'TblMainGlassesTableAdapter
        '
        Me.TblMainGlassesTableAdapter.ClearBeforeFill = True
        '
        'FrmVAReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(963, 612)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVAReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Acuity Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicLoadReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CrvVAReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnByMonth As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintByBetween As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DSVA As TakeoHospitalInventory.DSVA
    Friend WithEvents TblVAPlainTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblVAPlainTableAdapter
    Friend WithEvents TblVAPHTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblVAPHTableAdapter
    Friend WithEvents TblVAGlassesTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblVAGlassesTableAdapter
    Friend WithEvents PicLoadReport As System.Windows.Forms.PictureBox
    Friend WithEvents BgLoadVAByMonth As System.ComponentModel.BackgroundWorker
    Friend WithEvents BgLoadVAByDate As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLeftEye As System.Windows.Forms.RadioButton
    Friend WithEvents rdRightEye As System.Windows.Forms.RadioButton
    Friend WithEvents TblVAPlainRightTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblVAPlainRightTableAdapter
    Friend WithEvents TblVAPHRightTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblVAPHRightTableAdapter
    Friend WithEvents TblVAGlassesRightTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblVAGlassesRightTableAdapter
    Friend WithEvents TblMainPlainTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblMainPlainTableAdapter
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DateMainTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateMainStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintMain2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintMain1 As System.Windows.Forms.Button
    Friend WithEvents CboMainMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboMainYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BgMainByMonth As System.ComponentModel.BackgroundWorker
    Friend WithEvents TblMainPhTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblMainPhTableAdapter
    Friend WithEvents TblMainGlassesTableAdapter As TakeoHospitalInventory.DSVATableAdapters.TblMainGlassesTableAdapter
    Friend WithEvents BgMainByDate As System.ComponentModel.BackgroundWorker
End Class
