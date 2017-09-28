<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCOutPatientReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCOutPatientReport))
        Me.CROutPatientView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnNewOutStatistic = New System.Windows.Forms.Button
        Me.BtnOldOutStatistic = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DSOutPatientReport = New TakeoHospitalInventory.DSOutPatientReport
        Me.DataTable1TableAdapter = New TakeoHospitalInventory.DSOutPatientReportTableAdapters.DataTable1TableAdapter
        Me.BgLoadReport = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DSOutPatientReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CROutPatientView
        '
        Me.CROutPatientView.ActiveViewIndex = -1
        Me.CROutPatientView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CROutPatientView.DisplayGroupTree = False
        Me.CROutPatientView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CROutPatientView.Location = New System.Drawing.Point(3, 16)
        Me.CROutPatientView.Name = "CROutPatientView"
        Me.CROutPatientView.SelectionFormula = ""
        Me.CROutPatientView.ShowGroupTreeButton = False
        Me.CROutPatientView.Size = New System.Drawing.Size(1037, 669)
        Me.CROutPatientView.TabIndex = 2
        Me.CROutPatientView.ViewTimeSelectionFormula = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnNewOutStatistic)
        Me.GroupBox3.Controls.Add(Me.BtnOldOutStatistic)
        Me.GroupBox3.Controls.Add(Me.BtnPreview)
        Me.GroupBox3.Controls.Add(Me.DateTo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.DateFrom)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(353, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(687, 131)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date From:"
        '
        'BtnNewOutStatistic
        '
        Me.BtnNewOutStatistic.BackColor = System.Drawing.Color.Transparent
        Me.BtnNewOutStatistic.BackgroundImage = CType(resources.GetObject("BtnNewOutStatistic.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewOutStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewOutStatistic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewOutStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewOutStatistic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewOutStatistic.ForeColor = System.Drawing.Color.White
        Me.BtnNewOutStatistic.Location = New System.Drawing.Point(288, 33)
        Me.BtnNewOutStatistic.Name = "BtnNewOutStatistic"
        Me.BtnNewOutStatistic.Size = New System.Drawing.Size(164, 42)
        Me.BtnNewOutStatistic.TabIndex = 5
        Me.BtnNewOutStatistic.Text = "New Out Patient Statistic"
        Me.BtnNewOutStatistic.UseVisualStyleBackColor = False
        '
        'BtnOldOutStatistic
        '
        Me.BtnOldOutStatistic.BackgroundImage = CType(resources.GetObject("BtnOldOutStatistic.BackgroundImage"), System.Drawing.Image)
        Me.BtnOldOutStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOldOutStatistic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOldOutStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOldOutStatistic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOldOutStatistic.ForeColor = System.Drawing.Color.White
        Me.BtnOldOutStatistic.Location = New System.Drawing.Point(288, 80)
        Me.BtnOldOutStatistic.Name = "BtnOldOutStatistic"
        Me.BtnOldOutStatistic.Size = New System.Drawing.Size(164, 43)
        Me.BtnOldOutStatistic.TabIndex = 5
        Me.BtnOldOutStatistic.Text = "Old Out Patient Satistic"
        Me.BtnOldOutStatistic.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.BtnPreview.BackgroundImage = CType(resources.GetObject("BtnPreview.BackgroundImage"), System.Drawing.Image)
        Me.BtnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPreview.Location = New System.Drawing.Point(174, 36)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(108, 87)
        Me.BtnPreview.TabIndex = 5
        Me.BtnPreview.Text = "Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(11, 93)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(157, 30)
        Me.DateTo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date To:"
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(11, 37)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(157, 30)
        Me.DateFrom.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monthly Out Patient Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Hospital"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CROutPatientView)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1043, 688)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'DSOutPatientReport
        '
        Me.DSOutPatientReport.DataSetName = "DSOutPatientReport"
        Me.DSOutPatientReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'BgLoadReport
        '
        '
        'UCOutPatientReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCOutPatientReport"
        Me.Size = New System.Drawing.Size(1043, 838)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DSOutPatientReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CROutPatientView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DSOutPatientReport As TakeoHospitalInventory.DSOutPatientReport
    Friend WithEvents DataTable1TableAdapter As TakeoHospitalInventory.DSOutPatientReportTableAdapters.DataTable1TableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BgLoadReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnNewOutStatistic As System.Windows.Forms.Button
    Friend WithEvents BtnOldOutStatistic As System.Windows.Forms.Button

End Class
