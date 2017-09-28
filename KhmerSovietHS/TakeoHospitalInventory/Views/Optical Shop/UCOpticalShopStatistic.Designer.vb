<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCOpticalShopStatistic
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
        Me.BtnNillAndFull = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheOldPatient = New System.Windows.Forms.CheckBox
        Me.BtnOSPatientAgeIncome = New System.Windows.Forms.Button
        Me.BtnOPItemSaleOff = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPToDate = New System.Windows.Forms.DateTimePicker
        Me.DTPFDate = New System.Windows.Forms.DateTimePicker
        Me.BtnOPCusAgeStatistic = New System.Windows.Forms.Button
        Me.SplitOpticalShopReport = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CVStaticPaymentFor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadOther = New System.Windows.Forms.RadioButton
        Me.RadLV = New System.Windows.Forms.RadioButton
        Me.RadFundRaising = New System.Windows.Forms.RadioButton
        Me.RadSunGlasses = New System.Windows.Forms.RadioButton
        Me.RadMedicine = New System.Windows.Forms.RadioButton
        Me.RadReadyMadeSpectacle = New System.Windows.Forms.RadioButton
        Me.RadCustomerMadeSpectacle = New System.Windows.Forms.RadioButton
        Me.BtnPrintPreviewPayfor = New System.Windows.Forms.Button
        Me.CRVReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BacWOPCusAgeSta = New System.ComponentModel.BackgroundWorker
        Me.BacWOPItemSaleOff = New System.ComponentModel.BackgroundWorker
        Me.BacWOPPatientAgeIncome = New System.ComponentModel.BackgroundWorker
        Me.BacWOPPayTypeAgeSta = New System.ComponentModel.BackgroundWorker
        Me.ErrPReportOPT = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RadAllPaymentType = New System.Windows.Forms.RadioButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitOpticalShopReport.Panel1.SuspendLayout()
        Me.SplitOpticalShopReport.Panel2.SuspendLayout()
        Me.SplitOpticalShopReport.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrPReportOPT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnNillAndFull)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnOPItemSaleOff)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTPToDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTPFDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnOPCusAgeStatistic)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitOpticalShopReport)
        Me.SplitContainer1.Size = New System.Drawing.Size(1138, 600)
        Me.SplitContainer1.SplitterDistance = 258
        Me.SplitContainer1.TabIndex = 0
        '
        'BtnNillAndFull
        '
        Me.BtnNillAndFull.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNillAndFull.Image = Global.TakeoHospitalInventory.My.Resources.Resources.column_chart32
        Me.BtnNillAndFull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNillAndFull.Location = New System.Drawing.Point(19, 342)
        Me.BtnNillAndFull.Name = "BtnNillAndFull"
        Me.BtnNillAndFull.Size = New System.Drawing.Size(199, 60)
        Me.BtnNillAndFull.TabIndex = 16
        Me.BtnNillAndFull.Text = "Statistic Payment Type"
        Me.BtnNillAndFull.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheOldPatient)
        Me.GroupBox1.Controls.Add(Me.BtnOSPatientAgeIncome)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 121)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Statistic By Patient Type"
        '
        'CheOldPatient
        '
        Me.CheOldPatient.AutoSize = True
        Me.CheOldPatient.BackColor = System.Drawing.SystemColors.Control
        Me.CheOldPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheOldPatient.ForeColor = System.Drawing.Color.Red
        Me.CheOldPatient.Location = New System.Drawing.Point(6, 19)
        Me.CheOldPatient.Name = "CheOldPatient"
        Me.CheOldPatient.Size = New System.Drawing.Size(117, 24)
        Me.CheOldPatient.TabIndex = 12
        Me.CheOldPatient.Text = "Old Patient"
        Me.CheOldPatient.UseVisualStyleBackColor = False
        '
        'BtnOSPatientAgeIncome
        '
        Me.BtnOSPatientAgeIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOSPatientAgeIncome.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnOSPatientAgeIncome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnOSPatientAgeIncome.Location = New System.Drawing.Point(14, 48)
        Me.BtnOSPatientAgeIncome.Name = "BtnOSPatientAgeIncome"
        Me.BtnOSPatientAgeIncome.Size = New System.Drawing.Size(197, 68)
        Me.BtnOSPatientAgeIncome.TabIndex = 11
        Me.BtnOSPatientAgeIncome.Text = "Optical Shop Patient’s age Statistic"
        Me.BtnOSPatientAgeIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnOSPatientAgeIncome.UseVisualStyleBackColor = True
        '
        'BtnOPItemSaleOff
        '
        Me.BtnOPItemSaleOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOPItemSaleOff.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnOPItemSaleOff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnOPItemSaleOff.Location = New System.Drawing.Point(19, 272)
        Me.BtnOPItemSaleOff.Name = "BtnOPItemSaleOff"
        Me.BtnOPItemSaleOff.Size = New System.Drawing.Size(197, 61)
        Me.BtnOPItemSaleOff.TabIndex = 10
        Me.BtnOPItemSaleOff.Text = "Optical Shop Item Sole"
        Me.BtnOPItemSaleOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnOPItemSaleOff.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "From Date :"
        '
        'DTPToDate
        '
        Me.DTPToDate.Checked = False
        Me.DTPToDate.CustomFormat = "dd/MM/yyyy"
        Me.DTPToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPToDate.Location = New System.Drawing.Point(89, 47)
        Me.DTPToDate.Name = "DTPToDate"
        Me.DTPToDate.ShowCheckBox = True
        Me.DTPToDate.Size = New System.Drawing.Size(143, 23)
        Me.DTPToDate.TabIndex = 7
        '
        'DTPFDate
        '
        Me.DTPFDate.Checked = False
        Me.DTPFDate.CustomFormat = "dd/MM/yyyy"
        Me.DTPFDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFDate.Location = New System.Drawing.Point(89, 13)
        Me.DTPFDate.Name = "DTPFDate"
        Me.DTPFDate.ShowCheckBox = True
        Me.DTPFDate.Size = New System.Drawing.Size(143, 23)
        Me.DTPFDate.TabIndex = 6
        '
        'BtnOPCusAgeStatistic
        '
        Me.BtnOPCusAgeStatistic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOPCusAgeStatistic.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnOPCusAgeStatistic.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnOPCusAgeStatistic.Location = New System.Drawing.Point(19, 205)
        Me.BtnOPCusAgeStatistic.Name = "BtnOPCusAgeStatistic"
        Me.BtnOPCusAgeStatistic.Size = New System.Drawing.Size(197, 61)
        Me.BtnOPCusAgeStatistic.TabIndex = 0
        Me.BtnOPCusAgeStatistic.Text = "Optical Shop Customer’s age Statistic"
        Me.BtnOPCusAgeStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnOPCusAgeStatistic.UseVisualStyleBackColor = True
        '
        'SplitOpticalShopReport
        '
        Me.SplitOpticalShopReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitOpticalShopReport.Location = New System.Drawing.Point(0, 0)
        Me.SplitOpticalShopReport.Name = "SplitOpticalShopReport"
        '
        'SplitOpticalShopReport.Panel1
        '
        Me.SplitOpticalShopReport.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitOpticalShopReport.Panel2
        '
        Me.SplitOpticalShopReport.Panel2.Controls.Add(Me.CRVReportViewer)
        Me.SplitOpticalShopReport.Panel2Collapsed = True
        Me.SplitOpticalShopReport.Size = New System.Drawing.Size(876, 600)
        Me.SplitOpticalShopReport.SplitterDistance = 596
        Me.SplitOpticalShopReport.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CVStaticPaymentFor)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 600)
        Me.Panel1.TabIndex = 0
        '
        'CVStaticPaymentFor
        '
        Me.CVStaticPaymentFor.ActiveViewIndex = -1
        Me.CVStaticPaymentFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CVStaticPaymentFor.DisplayGroupTree = False
        Me.CVStaticPaymentFor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CVStaticPaymentFor.Location = New System.Drawing.Point(0, 76)
        Me.CVStaticPaymentFor.Name = "CVStaticPaymentFor"
        Me.CVStaticPaymentFor.SelectionFormula = ""
        Me.CVStaticPaymentFor.Size = New System.Drawing.Size(876, 524)
        Me.CVStaticPaymentFor.TabIndex = 1
        Me.CVStaticPaymentFor.ViewTimeSelectionFormula = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadAllPaymentType)
        Me.GroupBox2.Controls.Add(Me.RadOther)
        Me.GroupBox2.Controls.Add(Me.RadLV)
        Me.GroupBox2.Controls.Add(Me.RadFundRaising)
        Me.GroupBox2.Controls.Add(Me.RadSunGlasses)
        Me.GroupBox2.Controls.Add(Me.RadMedicine)
        Me.GroupBox2.Controls.Add(Me.RadReadyMadeSpectacle)
        Me.GroupBox2.Controls.Add(Me.RadCustomerMadeSpectacle)
        Me.GroupBox2.Controls.Add(Me.BtnPrintPreviewPayfor)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 76)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'RadOther
        '
        Me.RadOther.AutoSize = True
        Me.RadOther.BackColor = System.Drawing.Color.Transparent
        Me.RadOther.Location = New System.Drawing.Point(360, 46)
        Me.RadOther.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadOther.Name = "RadOther"
        Me.RadOther.Size = New System.Drawing.Size(51, 17)
        Me.RadOther.TabIndex = 143
        Me.RadOther.Tag = "6"
        Me.RadOther.Text = "Other"
        Me.RadOther.UseVisualStyleBackColor = False
        '
        'RadLV
        '
        Me.RadLV.AutoSize = True
        Me.RadLV.Location = New System.Drawing.Point(261, 13)
        Me.RadLV.Name = "RadLV"
        Me.RadLV.Size = New System.Drawing.Size(75, 17)
        Me.RadLV.TabIndex = 142
        Me.RadLV.Tag = "7"
        Me.RadLV.Text = "LV Device"
        Me.RadLV.UseVisualStyleBackColor = True
        '
        'RadFundRaising
        '
        Me.RadFundRaising.AutoSize = True
        Me.RadFundRaising.BackColor = System.Drawing.Color.Transparent
        Me.RadFundRaising.Location = New System.Drawing.Point(261, 45)
        Me.RadFundRaising.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadFundRaising.Name = "RadFundRaising"
        Me.RadFundRaising.Size = New System.Drawing.Size(87, 17)
        Me.RadFundRaising.TabIndex = 141
        Me.RadFundRaising.Tag = "5"
        Me.RadFundRaising.Text = "Fund Raising"
        Me.RadFundRaising.UseVisualStyleBackColor = False
        '
        'RadSunGlasses
        '
        Me.RadSunGlasses.AutoSize = True
        Me.RadSunGlasses.BackColor = System.Drawing.Color.Transparent
        Me.RadSunGlasses.Location = New System.Drawing.Point(171, 13)
        Me.RadSunGlasses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadSunGlasses.Name = "RadSunGlasses"
        Me.RadSunGlasses.Size = New System.Drawing.Size(84, 17)
        Me.RadSunGlasses.TabIndex = 15
        Me.RadSunGlasses.Tag = "2"
        Me.RadSunGlasses.Text = "Sun Glasses"
        Me.RadSunGlasses.UseVisualStyleBackColor = False
        '
        'RadMedicine
        '
        Me.RadMedicine.AutoSize = True
        Me.RadMedicine.BackColor = System.Drawing.Color.Transparent
        Me.RadMedicine.Location = New System.Drawing.Point(171, 45)
        Me.RadMedicine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadMedicine.Name = "RadMedicine"
        Me.RadMedicine.Size = New System.Drawing.Size(68, 17)
        Me.RadMedicine.TabIndex = 16
        Me.RadMedicine.Tag = "1"
        Me.RadMedicine.Text = "Medicine"
        Me.RadMedicine.UseVisualStyleBackColor = False
        '
        'RadReadyMadeSpectacle
        '
        Me.RadReadyMadeSpectacle.AutoSize = True
        Me.RadReadyMadeSpectacle.BackColor = System.Drawing.Color.Transparent
        Me.RadReadyMadeSpectacle.Location = New System.Drawing.Point(15, 45)
        Me.RadReadyMadeSpectacle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadReadyMadeSpectacle.Name = "RadReadyMadeSpectacle"
        Me.RadReadyMadeSpectacle.Size = New System.Drawing.Size(137, 17)
        Me.RadReadyMadeSpectacle.TabIndex = 14
        Me.RadReadyMadeSpectacle.Tag = "3"
        Me.RadReadyMadeSpectacle.Text = "Ready Made Spectacle"
        Me.RadReadyMadeSpectacle.UseVisualStyleBackColor = False
        '
        'RadCustomerMadeSpectacle
        '
        Me.RadCustomerMadeSpectacle.AutoSize = True
        Me.RadCustomerMadeSpectacle.BackColor = System.Drawing.Color.Transparent
        Me.RadCustomerMadeSpectacle.Location = New System.Drawing.Point(15, 13)
        Me.RadCustomerMadeSpectacle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadCustomerMadeSpectacle.Name = "RadCustomerMadeSpectacle"
        Me.RadCustomerMadeSpectacle.Size = New System.Drawing.Size(150, 17)
        Me.RadCustomerMadeSpectacle.TabIndex = 13
        Me.RadCustomerMadeSpectacle.Tag = "4"
        Me.RadCustomerMadeSpectacle.Text = "Customer Made Spectacle"
        Me.RadCustomerMadeSpectacle.UseVisualStyleBackColor = False
        '
        'BtnPrintPreviewPayfor
        '
        Me.BtnPrintPreviewPayfor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreviewPayfor.Location = New System.Drawing.Point(490, 18)
        Me.BtnPrintPreviewPayfor.Name = "BtnPrintPreviewPayfor"
        Me.BtnPrintPreviewPayfor.Size = New System.Drawing.Size(125, 44)
        Me.BtnPrintPreviewPayfor.TabIndex = 12
        Me.BtnPrintPreviewPayfor.Text = "Print Preview"
        Me.BtnPrintPreviewPayfor.UseVisualStyleBackColor = True
        '
        'CRVReportViewer
        '
        Me.CRVReportViewer.ActiveViewIndex = -1
        Me.CRVReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportViewer.DisplayGroupTree = False
        Me.CRVReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRVReportViewer.Margin = New System.Windows.Forms.Padding(2)
        Me.CRVReportViewer.Name = "CRVReportViewer"
        Me.CRVReportViewer.SelectionFormula = ""
        Me.CRVReportViewer.ShowGroupTreeButton = False
        Me.CRVReportViewer.ShowRefreshButton = False
        Me.CRVReportViewer.Size = New System.Drawing.Size(276, 600)
        Me.CRVReportViewer.TabIndex = 3
        Me.CRVReportViewer.ViewTimeSelectionFormula = ""
        '
        'BacWOPCusAgeSta
        '
        Me.BacWOPCusAgeSta.WorkerSupportsCancellation = True
        '
        'BacWOPItemSaleOff
        '
        Me.BacWOPItemSaleOff.WorkerSupportsCancellation = True
        '
        'BacWOPPatientAgeIncome
        '
        Me.BacWOPPatientAgeIncome.WorkerSupportsCancellation = True
        '
        'BacWOPPayTypeAgeSta
        '
        Me.BacWOPPayTypeAgeSta.WorkerSupportsCancellation = True
        '
        'ErrPReportOPT
        '
        Me.ErrPReportOPT.ContainerControl = Me
        '
        'RadAllPaymentType
        '
        Me.RadAllPaymentType.AutoSize = True
        Me.RadAllPaymentType.Checked = True
        Me.RadAllPaymentType.Location = New System.Drawing.Point(360, 13)
        Me.RadAllPaymentType.Name = "RadAllPaymentType"
        Me.RadAllPaymentType.Size = New System.Drawing.Size(107, 17)
        Me.RadAllPaymentType.TabIndex = 144
        Me.RadAllPaymentType.TabStop = True
        Me.RadAllPaymentType.Text = "All Payment Type"
        Me.RadAllPaymentType.UseVisualStyleBackColor = True
        '
        'UCOpticalShopStatistic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCOpticalShopStatistic"
        Me.Size = New System.Drawing.Size(1138, 600)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitOpticalShopReport.Panel1.ResumeLayout(False)
        Me.SplitOpticalShopReport.Panel2.ResumeLayout(False)
        Me.SplitOpticalShopReport.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrPReportOPT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnOPCusAgeStatistic As System.Windows.Forms.Button
    Friend WithEvents CRVReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnOPItemSaleOff As System.Windows.Forms.Button
    Friend WithEvents BacWOPCusAgeSta As System.ComponentModel.BackgroundWorker
    Friend WithEvents BacWOPItemSaleOff As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnOSPatientAgeIncome As System.Windows.Forms.Button
    Friend WithEvents CheOldPatient As System.Windows.Forms.CheckBox
    Friend WithEvents BacWOPPatientAgeIncome As System.ComponentModel.BackgroundWorker
    Friend WithEvents BacWOPPayTypeAgeSta As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitOpticalShopReport As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnNillAndFull As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CVStaticPaymentFor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnPrintPreviewPayfor As System.Windows.Forms.Button
    Friend WithEvents ErrPReportOPT As System.Windows.Forms.ErrorProvider
    Friend WithEvents RadCustomerMadeSpectacle As System.Windows.Forms.RadioButton
    Friend WithEvents RadReadyMadeSpectacle As System.Windows.Forms.RadioButton
    Friend WithEvents RadSunGlasses As System.Windows.Forms.RadioButton
    Friend WithEvents RadMedicine As System.Windows.Forms.RadioButton
    Friend WithEvents RadLV As System.Windows.Forms.RadioButton
    Friend WithEvents RadFundRaising As System.Windows.Forms.RadioButton
    Friend WithEvents RadOther As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllPaymentType As System.Windows.Forms.RadioButton

End Class
