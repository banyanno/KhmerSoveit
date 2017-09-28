<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMWardPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMWardPreview))
        Me.CRVWard = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BgLoadPatientNew = New System.ComponentModel.BackgroundWorker
        Me.BgLoadLeav = New System.ComponentModel.BackgroundWorker
        Me.PicLoading = New System.Windows.Forms.PictureBox
        Me.DSWard = New TakeoHospitalInventory.DSWard
        Me.TblPatientLeavTableAdapter = New TakeoHospitalInventory.DSWardTableAdapters.TblPatientLeavTableAdapter
        Me.TblNewInpatientTableAdapter = New TakeoHospitalInventory.DSWardTableAdapters.TblNewInpatientTableAdapter
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnPrintLeavVeiw = New System.Windows.Forms.Button
        Me.DateDisTo = New System.Windows.Forms.DateTimePicker
        Me.DateDisFrom = New System.Windows.Forms.DateTimePicker
        Me.TblWardDiseaseTableAdapter = New TakeoHospitalInventory.DSWardTableAdapters.TblWardDiseaseTableAdapter
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSWard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVWard
        '
        Me.CRVWard.ActiveViewIndex = -1
        Me.CRVWard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVWard.DisplayGroupTree = False
        Me.CRVWard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVWard.Location = New System.Drawing.Point(0, 104)
        Me.CRVWard.Name = "CRVWard"
        Me.CRVWard.SelectionFormula = ""
        Me.CRVWard.Size = New System.Drawing.Size(869, 597)
        Me.CRVWard.TabIndex = 0
        Me.CRVWard.ViewTimeSelectionFormula = ""
        '
        'BgLoadPatientNew
        '
        '
        'BgLoadLeav
        '
        '
        'PicLoading
        '
        Me.PicLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar
        Me.PicLoading.Location = New System.Drawing.Point(312, 337)
        Me.PicLoading.Name = "PicLoading"
        Me.PicLoading.Size = New System.Drawing.Size(235, 24)
        Me.PicLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoading.TabIndex = 1
        Me.PicLoading.TabStop = False
        Me.PicLoading.Visible = False
        '
        'DSWard
        '
        Me.DSWard.DataSetName = "DSWard"
        Me.DSWard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientLeavTableAdapter
        '
        Me.TblPatientLeavTableAdapter.ClearBeforeFill = True
        '
        'TblNewInpatientTableAdapter
        '
        Me.TblNewInpatientTableAdapter.ClearBeforeFill = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label7)
        Me.GroupBox10.Controls.Add(Me.Label8)
        Me.GroupBox10.Controls.Add(Me.BtnPrintLeavVeiw)
        Me.GroupBox10.Controls.Add(Me.DateDisTo)
        Me.GroupBox10.Controls.Add(Me.DateDisFrom)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox10.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(869, 104)
        Me.GroupBox10.TabIndex = 6
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Eye Disease in ward"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "And"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Betweent"
        '
        'BtnPrintLeavVeiw
        '
        Me.BtnPrintLeavVeiw.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnPrintLeavVeiw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintLeavVeiw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintLeavVeiw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintLeavVeiw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintLeavVeiw.ForeColor = System.Drawing.Color.White
        Me.BtnPrintLeavVeiw.Location = New System.Drawing.Point(174, 23)
        Me.BtnPrintLeavVeiw.Name = "BtnPrintLeavVeiw"
        Me.BtnPrintLeavVeiw.Size = New System.Drawing.Size(121, 61)
        Me.BtnPrintLeavVeiw.TabIndex = 2
        Me.BtnPrintLeavVeiw.Text = "Print Previe&w"
        Me.BtnPrintLeavVeiw.UseVisualStyleBackColor = True
        '
        'DateDisTo
        '
        Me.DateDisTo.CustomFormat = "dd/MM/yyyy"
        Me.DateDisTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDisTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDisTo.Location = New System.Drawing.Point(57, 58)
        Me.DateDisTo.Name = "DateDisTo"
        Me.DateDisTo.Size = New System.Drawing.Size(112, 26)
        Me.DateDisTo.TabIndex = 1
        '
        'DateDisFrom
        '
        Me.DateDisFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateDisFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDisFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDisFrom.Location = New System.Drawing.Point(57, 23)
        Me.DateDisFrom.Name = "DateDisFrom"
        Me.DateDisFrom.Size = New System.Drawing.Size(112, 26)
        Me.DateDisFrom.TabIndex = 0
        '
        'TblWardDiseaseTableAdapter
        '
        Me.TblWardDiseaseTableAdapter.ClearBeforeFill = True
        '
        'FRMWardPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(869, 701)
        Me.Controls.Add(Me.CRVWard)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.PicLoading)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMWardPreview"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Preview"
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSWard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSWard As TakeoHospitalInventory.DSWard
    Friend WithEvents TblPatientLeavTableAdapter As TakeoHospitalInventory.DSWardTableAdapters.TblPatientLeavTableAdapter
    Friend WithEvents TblNewInpatientTableAdapter As TakeoHospitalInventory.DSWardTableAdapters.TblNewInpatientTableAdapter
    Friend WithEvents CRVWard As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BgLoadPatientNew As System.ComponentModel.BackgroundWorker
    Friend WithEvents BgLoadLeav As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicLoading As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintLeavVeiw As System.Windows.Forms.Button
    Friend WithEvents DateDisTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateDisFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents TblWardDiseaseTableAdapter As TakeoHospitalInventory.DSWardTableAdapters.TblWardDiseaseTableAdapter
End Class
