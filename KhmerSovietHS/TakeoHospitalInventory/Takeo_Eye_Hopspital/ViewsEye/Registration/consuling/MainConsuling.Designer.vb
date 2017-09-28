<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainConsuling
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
        Dim GridConsulting_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainConsuling))
        Me.ToolMenuConsuling = New System.Windows.Forms.ToolStrip
        Me.BtnNewConsulting = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnConsultReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnConsultForm = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadAllConsult = New System.Windows.Forms.RadioButton
        Me.RadForNewPatient = New System.Windows.Forms.RadioButton
        Me.RadForOpticalShop = New System.Windows.Forms.RadioButton
        Me.RadForInPatient = New System.Windows.Forms.RadioButton
        Me.RadForOld = New System.Windows.Forms.RadioButton
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridConsulting = New Janus.Windows.GridEX.GridEX
        Me.MenuConsulting = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuApprove = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteConsult = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BgLoadConsult = New System.ComponentModel.BackgroundWorker
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolMenuConsuling.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridConsulting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuConsulting.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolMenuConsuling
        '
        Me.ToolMenuConsuling.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolMenuConsuling.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewConsulting, Me.ToolStripSeparator1, Me.BtnConsultReport, Me.ToolStripSeparator2, Me.BtnConsultForm})
        Me.ToolMenuConsuling.Location = New System.Drawing.Point(0, 0)
        Me.ToolMenuConsuling.Name = "ToolMenuConsuling"
        Me.ToolMenuConsuling.Size = New System.Drawing.Size(1404, 32)
        Me.ToolMenuConsuling.TabIndex = 0
        Me.ToolMenuConsuling.Text = "ToolStrip1"
        '
        'BtnNewConsulting
        '
        Me.BtnNewConsulting.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnNewConsulting.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewConsulting.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.BtnNewConsulting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewConsulting.Name = "BtnNewConsulting"
        Me.BtnNewConsulting.Size = New System.Drawing.Size(127, 29)
        Me.BtnNewConsulting.Text = "New Consult"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnConsultReport
        '
        Me.BtnConsultReport.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnConsultReport.ForeColor = System.Drawing.Color.Blue
        Me.BtnConsultReport.Image = Global.TakeoHospitalInventory.My.Resources.Resources.sales_report
        Me.BtnConsultReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultReport.Name = "BtnConsultReport"
        Me.BtnConsultReport.Size = New System.Drawing.Size(165, 29)
        Me.BtnConsultReport.Text = "Consulting Report"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnConsultForm
        '
        Me.BtnConsultForm.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnConsultForm.ForeColor = System.Drawing.Color.Blue
        Me.BtnConsultForm.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Open
        Me.BtnConsultForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultForm.Name = "BtnConsultForm"
        Me.BtnConsultForm.Size = New System.Drawing.Size(155, 29)
        Me.BtnConsultForm.Text = "Consulting Form"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtPatientNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnFind)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1404, 575)
        Me.SplitContainer1.SplitterDistance = 48
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadAllConsult)
        Me.GroupBox3.Controls.Add(Me.RadForNewPatient)
        Me.GroupBox3.Controls.Add(Me.RadForOpticalShop)
        Me.GroupBox3.Controls.Add(Me.RadForInPatient)
        Me.GroupBox3.Controls.Add(Me.RadForOld)
        Me.GroupBox3.Location = New System.Drawing.Point(603, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(524, 44)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Option Consult For"
        '
        'RadAllConsult
        '
        Me.RadAllConsult.AutoSize = True
        Me.RadAllConsult.Checked = True
        Me.RadAllConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAllConsult.Location = New System.Drawing.Point(9, 16)
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
        Me.RadForNewPatient.Location = New System.Drawing.Point(107, 16)
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
        Me.RadForOpticalShop.Location = New System.Drawing.Point(408, 16)
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
        Me.RadForInPatient.Location = New System.Drawing.Point(316, 16)
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
        Me.RadForOld.Location = New System.Drawing.Point(214, 16)
        Me.RadForOld.Name = "RadForOld"
        Me.RadForOld.Size = New System.Drawing.Size(96, 21)
        Me.RadForOld.TabIndex = 10
        Me.RadForOld.Text = "Old Patient"
        Me.RadForOld.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForOld.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(73, 12)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(125, 26)
        Me.TxtPatientNo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patient No:"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Location = New System.Drawing.Point(514, 9)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(80, 29)
        Me.BtnFind.TabIndex = 4
        Me.BtnFind.Text = "Display"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.Checked = False
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(397, 11)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(110, 26)
        Me.DTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To :"
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(245, 12)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(111, 26)
        Me.DFrom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From :"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1404, 523)
        Me.SplitContainer2.SplitterDistance = 707
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridConsulting)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1404, 523)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consuling Information"
        '
        'GridConsulting
        '
        Me.GridConsulting.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridConsulting.ContextMenuStrip = Me.MenuConsulting
        GridConsulting_DesignTimeLayout.LayoutString = resources.GetString("GridConsulting_DesignTimeLayout.LayoutString")
        Me.GridConsulting.DesignTimeLayout = GridConsulting_DesignTimeLayout
        Me.GridConsulting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridConsulting.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GridConsulting.GroupByBoxVisible = False
        Me.GridConsulting.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridConsulting.Location = New System.Drawing.Point(3, 20)
        Me.GridConsulting.Name = "GridConsulting"
        Me.GridConsulting.RecordNavigator = True
        Me.GridConsulting.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridConsulting.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridConsulting.Size = New System.Drawing.Size(1398, 475)
        Me.GridConsulting.TabIndex = 0
        '
        'MenuConsulting
        '
        Me.MenuConsulting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuApprove, Me.ToolStripMenuItem1, Me.BtnDeleteConsult, Me.ToolStripSeparator3, Me.BtnUndo})
        Me.MenuConsulting.Name = "MenuConsulting"
        Me.MenuConsulting.Size = New System.Drawing.Size(145, 82)
        '
        'MenuApprove
        '
        Me.MenuApprove.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MenuApprove.Name = "MenuApprove"
        Me.MenuApprove.Size = New System.Drawing.Size(144, 22)
        Me.MenuApprove.Text = "Approve"
        Me.MenuApprove.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(141, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'BtnDeleteConsult
        '
        Me.BtnDeleteConsult.Enabled = False
        Me.BtnDeleteConsult.Name = "BtnDeleteConsult"
        Me.BtnDeleteConsult.Size = New System.Drawing.Size(144, 22)
        Me.BtnDeleteConsult.Text = "Delete Consult"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'BtnUndo
        '
        Me.BtnUndo.Enabled = False
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(144, 22)
        Me.BtnUndo.Text = "Undo Consult"
        '
        'GroupBox2
        '
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consuling Information"
        '
        'BgLoadConsult
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(3, 495)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pleace Check Status Consultation"
        '
        'MainConsuling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolMenuConsuling)
        Me.Name = "MainConsuling"
        Me.Size = New System.Drawing.Size(1404, 607)
        Me.ToolMenuConsuling.ResumeLayout(False)
        Me.ToolMenuConsuling.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridConsulting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuConsulting.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolMenuConsuling As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewConsulting As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BgLoadConsult As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnConsultReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnConsultForm As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuConsulting As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuApprove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteConsult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridConsulting As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadForNewPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadForOpticalShop As System.Windows.Forms.RadioButton
    Friend WithEvents RadForInPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadForOld As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllConsult As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
