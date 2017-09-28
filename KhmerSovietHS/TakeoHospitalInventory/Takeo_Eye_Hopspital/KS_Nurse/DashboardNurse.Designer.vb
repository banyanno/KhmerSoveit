<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardNurse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardNurse))
        Dim GridPatientWaiting_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.BtnRefreshWaiting = New System.Windows.Forms.ToolStrip
        Me.BtnSendToDoctor = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Refresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteWaiting = New System.Windows.Forms.ToolStripButton
        Me.GridPatientWaiting = New Janus.Windows.GridEX.GridEX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtLLE = New System.Windows.Forms.TextBox
        Me.TxtRRE = New System.Windows.Forms.TextBox
        Me.TxtLREF = New System.Windows.Forms.TextBox
        Me.TxtRREF = New System.Windows.Forms.TextBox
        Me.TxtLPh = New System.Windows.Forms.TextBox
        Me.TxtRPh = New System.Windows.Forms.TextBox
        Me.TxtLE = New System.Windows.Forms.TextBox
        Me.TxtRE = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnRefreshWaiting.SuspendLayout()
        CType(Me.GridPatientWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRefreshWaiting
        '
        Me.BtnRefreshWaiting.BackColor = System.Drawing.Color.Transparent
        Me.BtnRefreshWaiting.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BtnRefreshWaiting.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.BtnRefreshWaiting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSendToDoctor, Me.ToolStripSeparator1, Me.Refresh, Me.ToolStripSeparator2, Me.BtnDeleteWaiting})
        Me.BtnRefreshWaiting.Location = New System.Drawing.Point(0, 0)
        Me.BtnRefreshWaiting.Name = "BtnRefreshWaiting"
        Me.BtnRefreshWaiting.Size = New System.Drawing.Size(1029, 47)
        Me.BtnRefreshWaiting.TabIndex = 0
        Me.BtnRefreshWaiting.Text = "Refresh"
        '
        'BtnSendToDoctor
        '
        Me.BtnSendToDoctor.BackgroundImage = CType(resources.GetObject("BtnSendToDoctor.BackgroundImage"), System.Drawing.Image)
        Me.BtnSendToDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSendToDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSendToDoctor.ForeColor = System.Drawing.Color.White
        Me.BtnSendToDoctor.Image = Global.TakeoHospitalInventory.My.Resources.Resources.doctor_checking_patients_eyes
        Me.BtnSendToDoctor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSendToDoctor.Name = "BtnSendToDoctor"
        Me.BtnSendToDoctor.Size = New System.Drawing.Size(163, 44)
        Me.BtnSendToDoctor.Text = "    New Finding and VA  "
        Me.BtnSendToDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'Refresh
        '
        Me.Refresh.BackgroundImage = CType(resources.GetObject("Refresh.BackgroundImage"), System.Drawing.Image)
        Me.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh.ForeColor = System.Drawing.Color.White
        Me.Refresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(141, 44)
        Me.Refresh.Text = "         Refresh           "
        Me.Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'BtnDeleteWaiting
        '
        Me.BtnDeleteWaiting.BackgroundImage = CType(resources.GetObject("BtnDeleteWaiting.BackgroundImage"), System.Drawing.Image)
        Me.BtnDeleteWaiting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteWaiting.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteWaiting.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteWaiting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteWaiting.Name = "BtnDeleteWaiting"
        Me.BtnDeleteWaiting.Size = New System.Drawing.Size(137, 44)
        Me.BtnDeleteWaiting.Text = "    Delete Waiting    "
        Me.BtnDeleteWaiting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GridPatientWaiting
        '
        Me.GridPatientWaiting.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPatientWaiting.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridPatientWaiting_DesignTimeLayout.LayoutString = resources.GetString("GridPatientWaiting_DesignTimeLayout.LayoutString")
        Me.GridPatientWaiting.DesignTimeLayout = GridPatientWaiting_DesignTimeLayout
        Me.GridPatientWaiting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientWaiting.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridPatientWaiting.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridPatientWaiting.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridPatientWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientWaiting.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPatientWaiting.GroupByBoxVisible = False
        Me.GridPatientWaiting.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridPatientWaiting.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientWaiting.Location = New System.Drawing.Point(3, 22)
        Me.GridPatientWaiting.Name = "GridPatientWaiting"
        Me.GridPatientWaiting.RecordNavigator = True
        Me.GridPatientWaiting.RowFormatStyle.FontSize = 10.0!
        Me.GridPatientWaiting.SelectedFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridPatientWaiting.SelectedFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPatientWaiting.Size = New System.Drawing.Size(727, 727)
        Me.GridPatientWaiting.TabIndex = 5
        Me.GridPatientWaiting.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 47)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label27)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtNote)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1029, 754)
        Me.SplitContainer1.SplitterDistance = 428
        Me.SplitContainer1.TabIndex = 6
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.ForeColor = System.Drawing.Color.Blue
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1029, 754)
        Me.SplitContainer2.SplitterDistance = 735
        Me.SplitContainer2.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridPatientWaiting)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(733, 752)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Patient wainting Complain and VA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 291)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "រូបភាព"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(8, 13)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 17)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Finding / Complain"
        '
        'TxtNote
        '
        Me.TxtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNote.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNote.Location = New System.Drawing.Point(7, 36)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtNote.Size = New System.Drawing.Size(793, 123)
        Me.TxtNote.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtLLE)
        Me.GroupBox1.Controls.Add(Me.TxtRRE)
        Me.GroupBox1.Controls.Add(Me.TxtLREF)
        Me.GroupBox1.Controls.Add(Me.TxtRREF)
        Me.GroupBox1.Controls.Add(Me.TxtLPh)
        Me.GroupBox1.Controls.Add(Me.TxtRPh)
        Me.GroupBox1.Controls.Add(Me.TxtLE)
        Me.GroupBox1.Controls.Add(Me.TxtRE)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(7, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 137)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visual Acuity"
        '
        'TxtLLE
        '
        Me.TxtLLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLLE.Location = New System.Drawing.Point(543, 80)
        Me.TxtLLE.Name = "TxtLLE"
        Me.TxtLLE.Size = New System.Drawing.Size(123, 23)
        Me.TxtLLE.TabIndex = 16
        Me.TxtLLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRRE
        '
        Me.TxtRRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRRE.Location = New System.Drawing.Point(543, 37)
        Me.TxtRRE.Name = "TxtRRE"
        Me.TxtRRE.Size = New System.Drawing.Size(123, 23)
        Me.TxtRRE.TabIndex = 15
        Me.TxtRRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLREF
        '
        Me.TxtLREF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLREF.Location = New System.Drawing.Point(375, 80)
        Me.TxtLREF.Name = "TxtLREF"
        Me.TxtLREF.Size = New System.Drawing.Size(123, 23)
        Me.TxtLREF.TabIndex = 14
        Me.TxtLREF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRREF
        '
        Me.TxtRREF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRREF.Location = New System.Drawing.Point(375, 37)
        Me.TxtRREF.Name = "TxtRREF"
        Me.TxtRREF.Size = New System.Drawing.Size(123, 23)
        Me.TxtRREF.TabIndex = 13
        Me.TxtRREF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLPh
        '
        Me.TxtLPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLPh.Location = New System.Drawing.Point(218, 80)
        Me.TxtLPh.Name = "TxtLPh"
        Me.TxtLPh.Size = New System.Drawing.Size(104, 23)
        Me.TxtLPh.TabIndex = 12
        Me.TxtLPh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRPh
        '
        Me.TxtRPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRPh.Location = New System.Drawing.Point(218, 37)
        Me.TxtRPh.Name = "TxtRPh"
        Me.TxtRPh.Size = New System.Drawing.Size(104, 23)
        Me.TxtRPh.TabIndex = 11
        Me.TxtRPh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLE
        '
        Me.TxtLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLE.Location = New System.Drawing.Point(48, 80)
        Me.TxtLE.Name = "TxtLE"
        Me.TxtLE.Size = New System.Drawing.Size(123, 23)
        Me.TxtLE.TabIndex = 10
        Me.TxtLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRE
        '
        Me.TxtRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRE.Location = New System.Drawing.Point(50, 37)
        Me.TxtRE.Name = "TxtRE"
        Me.TxtRE.Size = New System.Drawing.Size(123, 23)
        Me.TxtRE.TabIndex = 9
        Me.TxtRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(504, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "IOP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(504, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "LE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(504, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "RE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "REF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "REF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ph"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ph"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RE"
        '
        'DashboardNurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BtnRefreshWaiting)
        Me.Name = "DashboardNurse"
        Me.Size = New System.Drawing.Size(1029, 801)
        Me.BtnRefreshWaiting.ResumeLayout(False)
        Me.BtnRefreshWaiting.PerformLayout()
        CType(Me.GridPatientWaiting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRefreshWaiting As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSendToDoctor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteWaiting As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridPatientWaiting As Janus.Windows.GridEX.GridEX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtLLE As System.Windows.Forms.TextBox
    Friend WithEvents TxtRRE As System.Windows.Forms.TextBox
    Friend WithEvents TxtLREF As System.Windows.Forms.TextBox
    Friend WithEvents TxtRREF As System.Windows.Forms.TextBox
    Friend WithEvents TxtLPh As System.Windows.Forms.TextBox
    Friend WithEvents TxtRPh As System.Windows.Forms.TextBox
    Friend WithEvents TxtLE As System.Windows.Forms.TextBox
    Friend WithEvents TxtRE As System.Windows.Forms.TextBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
