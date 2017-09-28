<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCOperationReport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCOperationReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnPrintIOL = New System.Windows.Forms.Button
        Me.DateIOLFrom = New System.Windows.Forms.DateTimePicker
        Me.DateIOLTo = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CRVOperation = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BGLoadDiagnosisWithSurgery = New System.ComponentModel.BackgroundWorker
        Me.BgLoadDgWithIOL = New System.ComponentModel.BackgroundWorker
        Me.DSOperationReport = New TakeoHospitalInventory.DSOperationReport
        Me.DTblOperationTableAdapter = New TakeoHospitalInventory.DSOperationReportTableAdapters.DTblOperationTableAdapter
        Me.TblOperationIOLTableAdapter = New TakeoHospitalInventory.DSOperationReportTableAdapters.TblOperationIOLTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DSOperationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1088, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.BtnPrintIOL)
        Me.GroupBox4.Controls.Add(Me.DateIOLFrom)
        Me.GroupBox4.Controls.Add(Me.DateIOLTo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(325, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(234, 128)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report surgery cataract with IOL Number"
        Me.GroupBox4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Date From:"
        '
        'BtnPrintIOL
        '
        Me.BtnPrintIOL.BackgroundImage = CType(resources.GetObject("BtnPrintIOL.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintIOL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintIOL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintIOL.ForeColor = System.Drawing.Color.White
        Me.BtnPrintIOL.Location = New System.Drawing.Point(151, 77)
        Me.BtnPrintIOL.Name = "BtnPrintIOL"
        Me.BtnPrintIOL.Size = New System.Drawing.Size(72, 36)
        Me.BtnPrintIOL.TabIndex = 4
        Me.BtnPrintIOL.Text = "Preview"
        Me.BtnPrintIOL.UseVisualStyleBackColor = True
        '
        'DateIOLFrom
        '
        Me.DateIOLFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateIOLFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateIOLFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateIOLFrom.Location = New System.Drawing.Point(15, 37)
        Me.DateIOLFrom.Name = "DateIOLFrom"
        Me.DateIOLFrom.Size = New System.Drawing.Size(130, 26)
        Me.DateIOLFrom.TabIndex = 3
        '
        'DateIOLTo
        '
        Me.DateIOLTo.CustomFormat = "dd/MM/yyyy"
        Me.DateIOLTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateIOLTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateIOLTo.Location = New System.Drawing.Point(15, 87)
        Me.DateIOLTo.Name = "DateIOLTo"
        Me.DateIOLTo.Size = New System.Drawing.Size(130, 26)
        Me.DateIOLTo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Date To:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox3.Controls.Add(Me.DateFrom)
        Me.GroupBox3.Controls.Add(Me.DateTo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(837, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 128)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Diagnosis with surgery type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date From:"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackgroundImage = CType(resources.GetObject("BtnPrintPreview.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview.Location = New System.Drawing.Point(154, 77)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(72, 36)
        Me.BtnPrintPreview.TabIndex = 4
        Me.BtnPrintPreview.Text = "Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(18, 37)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(130, 26)
        Me.DateFrom.TabIndex = 3
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(18, 87)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(130, 26)
        Me.DateTo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monthly Operation Statistic on"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CRVOperation)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1088, 807)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CRVOperation
        '
        Me.CRVOperation.ActiveViewIndex = -1
        Me.CRVOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVOperation.DisplayGroupTree = False
        Me.CRVOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVOperation.Location = New System.Drawing.Point(3, 16)
        Me.CRVOperation.Name = "CRVOperation"
        Me.CRVOperation.SelectionFormula = ""
        Me.CRVOperation.Size = New System.Drawing.Size(1082, 788)
        Me.CRVOperation.TabIndex = 0
        Me.CRVOperation.ViewTimeSelectionFormula = ""
        '
        'BGLoadDiagnosisWithSurgery
        '
        '
        'BgLoadDgWithIOL
        '
        '
        'DSOperationReport
        '
        Me.DSOperationReport.DataSetName = "DSOperationReport"
        Me.DSOperationReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTblOperationTableAdapter
        '
        Me.DTblOperationTableAdapter.ClearBeforeFill = True
        '
        'TblOperationIOLTableAdapter
        '
        Me.TblOperationIOLTableAdapter.ClearBeforeFill = True
        '
        'UCOperationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCOperationReport"
        Me.Size = New System.Drawing.Size(1088, 957)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DSOperationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents CRVOperation As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DSOperationReport As TakeoHospitalInventory.DSOperationReport
    Friend WithEvents DTblOperationTableAdapter As TakeoHospitalInventory.DSOperationReportTableAdapters.DTblOperationTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BGLoadDiagnosisWithSurgery As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintIOL As System.Windows.Forms.Button
    Friend WithEvents DateIOLFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateIOLTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TblOperationIOLTableAdapter As TakeoHospitalInventory.DSOperationReportTableAdapters.TblOperationIOLTableAdapter
    Friend WithEvents BgLoadDgWithIOL As System.ComponentModel.BackgroundWorker

End Class
