<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinReport))
        Me.SplitContainerConsult = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.cboDonate = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChViewAll = New System.Windows.Forms.CheckBox
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadAllConsult = New System.Windows.Forms.RadioButton
        Me.RadForNewPatient = New System.Windows.Forms.RadioButton
        Me.RadForOpticalShop = New System.Windows.Forms.RadioButton
        Me.RadForInPatient = New System.Windows.Forms.RadioButton
        Me.RadForOld = New System.Windows.Forms.RadioButton
        Me.CrvConsulting = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrReport = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgLoadConsult = New System.ComponentModel.BackgroundWorker
        Me.ChConsultCancel = New System.Windows.Forms.CheckBox
        Me.SplitContainerConsult.Panel1.SuspendLayout()
        Me.SplitContainerConsult.Panel2.SuspendLayout()
        Me.SplitContainerConsult.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerConsult
        '
        Me.SplitContainerConsult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerConsult.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerConsult.Name = "SplitContainerConsult"
        Me.SplitContainerConsult.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerConsult.Panel1
        '
        Me.SplitContainerConsult.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainerConsult.Panel2
        '
        Me.SplitContainerConsult.Panel2.Controls.Add(Me.CrvConsulting)
        Me.SplitContainerConsult.Size = New System.Drawing.Size(1246, 641)
        Me.SplitContainerConsult.SplitterDistance = 150
        Me.SplitContainerConsult.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChConsultCancel)
        Me.GroupBox3.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox3.Controls.Add(Me.DTo)
        Me.GroupBox3.Controls.Add(Me.cboDonate)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ChViewAll)
        Me.GroupBox3.Controls.Add(Me.DFrom)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.RadAllConsult)
        Me.GroupBox3.Controls.Add(Me.RadForNewPatient)
        Me.GroupBox3.Controls.Add(Me.RadForOpticalShop)
        Me.GroupBox3.Controls.Add(Me.RadForInPatient)
        Me.GroupBox3.Controls.Add(Me.RadForOld)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1246, 150)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Option Consult For"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(642, 52)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(166, 29)
        Me.BtnPrintPreview.TabIndex = 17
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.Checked = False
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(57, 51)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(126, 26)
        Me.DTo.TabIndex = 12
        '
        'cboDonate
        '
        Me.cboDonate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDonate.FormattingEnabled = True
        Me.cboDonate.Location = New System.Drawing.Point(322, 53)
        Me.cboDonate.Name = "cboDonate"
        Me.cboDonate.Size = New System.Drawing.Size(283, 28)
        Me.cboDonate.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "To :"
        '
        'ChViewAll
        '
        Me.ChViewAll.AutoSize = True
        Me.ChViewAll.Checked = True
        Me.ChViewAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChViewAll.Location = New System.Drawing.Point(198, 60)
        Me.ChViewAll.Name = "ChViewAll"
        Me.ChViewAll.Size = New System.Drawing.Size(104, 17)
        Me.ChViewAll.TabIndex = 15
        Me.ChViewAll.Text = "View All Donate:"
        Me.ChViewAll.UseVisualStyleBackColor = True
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(56, 19)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(127, 26)
        Me.DFrom.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "From :"
        '
        'RadAllConsult
        '
        Me.RadAllConsult.AutoSize = True
        Me.RadAllConsult.Checked = True
        Me.RadAllConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAllConsult.Location = New System.Drawing.Point(198, 24)
        Me.RadAllConsult.Name = "RadAllConsult"
        Me.RadAllConsult.Size = New System.Drawing.Size(92, 21)
        Me.RadAllConsult.TabIndex = 14
        Me.RadAllConsult.TabStop = True
        Me.RadAllConsult.Text = "All Consult"
        Me.RadAllConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadAllConsult.UseVisualStyleBackColor = True
        '
        'RadForNewPatient
        '
        Me.RadForNewPatient.AutoSize = True
        Me.RadForNewPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForNewPatient.Location = New System.Drawing.Point(322, 24)
        Me.RadForNewPatient.Name = "RadForNewPatient"
        Me.RadForNewPatient.Size = New System.Drawing.Size(101, 21)
        Me.RadForNewPatient.TabIndex = 13
        Me.RadForNewPatient.Text = "New Patient"
        Me.RadForNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForNewPatient.UseVisualStyleBackColor = True
        '
        'RadForOpticalShop
        '
        Me.RadForOpticalShop.AutoSize = True
        Me.RadForOpticalShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForOpticalShop.Location = New System.Drawing.Point(677, 24)
        Me.RadForOpticalShop.Name = "RadForOpticalShop"
        Me.RadForOpticalShop.Size = New System.Drawing.Size(107, 21)
        Me.RadForOpticalShop.TabIndex = 12
        Me.RadForOpticalShop.Text = "Optical Shop"
        Me.RadForOpticalShop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForOpticalShop.UseVisualStyleBackColor = True
        '
        'RadForInPatient
        '
        Me.RadForInPatient.AutoSize = True
        Me.RadForInPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForInPatient.Location = New System.Drawing.Point(565, 24)
        Me.RadForInPatient.Name = "RadForInPatient"
        Me.RadForInPatient.Size = New System.Drawing.Size(86, 21)
        Me.RadForInPatient.TabIndex = 11
        Me.RadForInPatient.Text = "In-Patient"
        Me.RadForInPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForInPatient.UseVisualStyleBackColor = True
        '
        'RadForOld
        '
        Me.RadForOld.AutoSize = True
        Me.RadForOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForOld.Location = New System.Drawing.Point(444, 24)
        Me.RadForOld.Name = "RadForOld"
        Me.RadForOld.Size = New System.Drawing.Size(96, 21)
        Me.RadForOld.TabIndex = 10
        Me.RadForOld.Text = "Old Patient"
        Me.RadForOld.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForOld.UseVisualStyleBackColor = True
        '
        'CrvConsulting
        '
        Me.CrvConsulting.ActiveViewIndex = -1
        Me.CrvConsulting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvConsulting.DisplayGroupTree = False
        Me.CrvConsulting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvConsulting.Location = New System.Drawing.Point(0, 0)
        Me.CrvConsulting.Name = "CrvConsulting"
        Me.CrvConsulting.SelectionFormula = ""
        Me.CrvConsulting.ShowGroupTreeButton = False
        Me.CrvConsulting.Size = New System.Drawing.Size(1246, 487)
        Me.CrvConsulting.TabIndex = 0
        Me.CrvConsulting.ViewTimeSelectionFormula = ""
        '
        'ErrReport
        '
        Me.ErrReport.ContainerControl = Me
        '
        'BgLoadConsult
        '
        '
        'ChConsultCancel
        '
        Me.ChConsultCancel.AutoSize = True
        Me.ChConsultCancel.Location = New System.Drawing.Point(198, 97)
        Me.ChConsultCancel.Name = "ChConsultCancel"
        Me.ChConsultCancel.Size = New System.Drawing.Size(123, 17)
        Me.ChConsultCancel.TabIndex = 18
        Me.ChConsultCancel.Text = "View Consult Cancel"
        Me.ChConsultCancel.UseVisualStyleBackColor = True
        '
        'WinReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 641)
        Me.Controls.Add(Me.SplitContainerConsult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WinReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.SplitContainerConsult.Panel1.ResumeLayout(False)
        Me.SplitContainerConsult.Panel2.ResumeLayout(False)
        Me.SplitContainerConsult.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerConsult As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChViewAll As System.Windows.Forms.CheckBox
    Friend WithEvents RadAllConsult As System.Windows.Forms.RadioButton
    Friend WithEvents RadForNewPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadForOpticalShop As System.Windows.Forms.RadioButton
    Friend WithEvents RadForInPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadForOld As System.Windows.Forms.RadioButton
    Friend WithEvents cboDonate As System.Windows.Forms.ComboBox
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrvConsulting As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ErrReport As System.Windows.Forms.ErrorProvider
    Friend WithEvents BgLoadConsult As System.ComponentModel.BackgroundWorker
    Friend WithEvents ChConsultCancel As System.Windows.Forms.CheckBox
End Class
