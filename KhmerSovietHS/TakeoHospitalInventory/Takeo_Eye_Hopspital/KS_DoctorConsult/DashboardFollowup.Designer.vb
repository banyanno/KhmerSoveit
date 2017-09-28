<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardFollowup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardFollowup))
        Dim GridFollowUp_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewFollowUP = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSendToWaiting = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFollowupReport = New System.Windows.Forms.ToolStripButton
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.DateFollowupTo = New System.Windows.Forms.DateTimePicker
        Me.TxtTelephone = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.BtnView = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.RadDoctory = New System.Windows.Forms.RadioButton
        Me.RadTelephone = New System.Windows.Forms.RadioButton
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.RadPatientNo = New System.Windows.Forms.RadioButton
        Me.GridFollowUp = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewFollowUP, Me.ToolStripSeparator1, Me.BtnSendToWaiting, Me.ToolStripSeparator2, Me.BtnFollowupReport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(898, 50)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewFollowUP
        '
        Me.BtnNewFollowUP.BackgroundImage = CType(resources.GetObject("BtnNewFollowUP.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewFollowUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewFollowUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewFollowUP.ForeColor = System.Drawing.Color.White
        Me.BtnNewFollowUP.Image = Global.TakeoHospitalInventory.My.Resources.Resources._3d_orange_man_magnifying_glass
        Me.BtnNewFollowUP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewFollowUP.Name = "BtnNewFollowUP"
        Me.BtnNewFollowUP.Size = New System.Drawing.Size(161, 47)
        Me.BtnNewFollowUP.Text = "    New FollowUp    "
        Me.BtnNewFollowUP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'BtnSendToWaiting
        '
        Me.BtnSendToWaiting.BackgroundImage = CType(resources.GetObject("BtnSendToWaiting.BackgroundImage"), System.Drawing.Image)
        Me.BtnSendToWaiting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSendToWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSendToWaiting.ForeColor = System.Drawing.Color.White
        Me.BtnSendToWaiting.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Users_icon
        Me.BtnSendToWaiting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSendToWaiting.Name = "BtnSendToWaiting"
        Me.BtnSendToWaiting.Size = New System.Drawing.Size(176, 47)
        Me.BtnSendToWaiting.Text = "     Send to Waiting    "
        Me.BtnSendToWaiting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'BtnFollowupReport
        '
        Me.BtnFollowupReport.BackgroundImage = CType(resources.GetObject("BtnFollowupReport.BackgroundImage"), System.Drawing.Image)
        Me.BtnFollowupReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFollowupReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFollowupReport.ForeColor = System.Drawing.Color.White
        Me.BtnFollowupReport.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1404479843_project_plan
        Me.BtnFollowupReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFollowupReport.Name = "BtnFollowupReport"
        Me.BtnFollowupReport.Size = New System.Drawing.Size(186, 47)
        Me.BtnFollowupReport.Text = "     Report Followup     "
        Me.BtnFollowupReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.ContainerControl = Me
        Me.uiPanel0.Id = New System.Guid("3e960fc6-d793-40b9-965e-a99253c5bdec")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("3e960fc6-d793-40b9-965e-a99253c5bdec"), Janus.Windows.UI.Dock.PanelDockStyle.Right, New System.Drawing.Size(238, 731), True)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("3e960fc6-d793-40b9-965e-a99253c5bdec"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.CaptionFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(657, 53)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(238, 731)
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.Text = "Patient Followup"
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.GroupBox1)
        Me.uiPanel0Container.Location = New System.Drawing.Point(5, 23)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(232, 707)
        Me.uiPanel0Container.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.DateFollowupTo)
        Me.GroupBox1.Controls.Add(Me.TxtTelephone)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.BtnView)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.DateFollowUp)
        Me.GroupBox1.Controls.Add(Me.RadDoctory)
        Me.GroupBox1.Controls.Add(Me.RadTelephone)
        Me.GroupBox1.Controls.Add(Me.RadPatientName)
        Me.GroupBox1.Controls.Add(Me.RadPatientNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 707)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Date FollowUp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(7, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To:"
        '
        'BtnFind
        '
        Me.BtnFind.BackgroundImage = CType(resources.GetObject("BtnFind.BackgroundImage"), System.Drawing.Image)
        Me.BtnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Location = New System.Drawing.Point(7, 379)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(170, 38)
        Me.BtnFind.TabIndex = 8
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From:"
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(7, 345)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(170, 28)
        Me.CboDoctor.TabIndex = 7
        '
        'DateFollowupTo
        '
        Me.DateFollowupTo.CalendarForeColor = System.Drawing.Color.Red
        Me.DateFollowupTo.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.DateFollowupTo.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowupTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowupTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowupTo.Location = New System.Drawing.Point(62, 64)
        Me.DateFollowupTo.Name = "DateFollowupTo"
        Me.DateFollowupTo.Size = New System.Drawing.Size(123, 26)
        Me.DateFollowupTo.TabIndex = 4
        '
        'TxtTelephone
        '
        Me.TxtTelephone.Enabled = False
        Me.TxtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelephone.Location = New System.Drawing.Point(7, 291)
        Me.TxtTelephone.Name = "TxtTelephone"
        Me.TxtTelephone.Size = New System.Drawing.Size(170, 26)
        Me.TxtTelephone.TabIndex = 6
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(7, 228)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(170, 26)
        Me.TxtPatientName.TabIndex = 5
        '
        'BtnView
        '
        Me.BtnView.BackgroundImage = CType(resources.GetObject("BtnView.BackgroundImage"), System.Drawing.Image)
        Me.BtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.ForeColor = System.Drawing.Color.White
        Me.BtnView.Location = New System.Drawing.Point(7, 99)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(178, 37)
        Me.BtnView.TabIndex = 2
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(7, 169)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(170, 26)
        Me.TxtPatientNo.TabIndex = 4
        '
        'DateFollowUp
        '
        Me.DateFollowUp.CalendarForeColor = System.Drawing.Color.Red
        Me.DateFollowUp.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(62, 29)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.Size = New System.Drawing.Size(123, 26)
        Me.DateFollowUp.TabIndex = 1
        '
        'RadDoctory
        '
        Me.RadDoctory.AutoSize = True
        Me.RadDoctory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDoctory.Location = New System.Drawing.Point(7, 323)
        Me.RadDoctory.Name = "RadDoctory"
        Me.RadDoctory.Size = New System.Drawing.Size(104, 21)
        Me.RadDoctory.TabIndex = 3
        Me.RadDoctory.TabStop = True
        Me.RadDoctory.Text = "With Doctor:"
        Me.RadDoctory.UseVisualStyleBackColor = True
        '
        'RadTelephone
        '
        Me.RadTelephone.AutoSize = True
        Me.RadTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTelephone.Location = New System.Drawing.Point(7, 260)
        Me.RadTelephone.Name = "RadTelephone"
        Me.RadTelephone.Size = New System.Drawing.Size(98, 21)
        Me.RadTelephone.TabIndex = 2
        Me.RadTelephone.TabStop = True
        Me.RadTelephone.Text = "Telephone:"
        Me.RadTelephone.UseVisualStyleBackColor = True
        '
        'RadPatientName
        '
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPatientName.Location = New System.Drawing.Point(7, 201)
        Me.RadPatientName.Name = "RadPatientName"
        Me.RadPatientName.Size = New System.Drawing.Size(115, 21)
        Me.RadPatientName.TabIndex = 1
        Me.RadPatientName.TabStop = True
        Me.RadPatientName.Text = "Patient Name:"
        Me.RadPatientName.UseVisualStyleBackColor = True
        '
        'RadPatientNo
        '
        Me.RadPatientNo.AutoSize = True
        Me.RadPatientNo.Checked = True
        Me.RadPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPatientNo.Location = New System.Drawing.Point(7, 142)
        Me.RadPatientNo.Name = "RadPatientNo"
        Me.RadPatientNo.Size = New System.Drawing.Size(96, 21)
        Me.RadPatientNo.TabIndex = 0
        Me.RadPatientNo.TabStop = True
        Me.RadPatientNo.Text = "Patient No:"
        Me.RadPatientNo.UseVisualStyleBackColor = True
        '
        'GridFollowUp
        '
        Me.GridFollowUp.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFollowUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridFollowUp_DesignTimeLayout.LayoutString = resources.GetString("GridFollowUp_DesignTimeLayout.LayoutString")
        Me.GridFollowUp.DesignTimeLayout = GridFollowUp_DesignTimeLayout
        Me.GridFollowUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFollowUp.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridFollowUp.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridFollowUp.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridFollowUp.GroupByBoxVisible = False
        Me.GridFollowUp.HeaderFormatStyle.FontSize = 12.0!
        Me.GridFollowUp.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridFollowUp.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridFollowUp.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridFollowUp.Location = New System.Drawing.Point(3, 53)
        Me.GridFollowUp.Name = "GridFollowUp"
        Me.GridFollowUp.RecordNavigator = True
        Me.GridFollowUp.RowFormatStyle.FontSize = 12.0!
        Me.GridFollowUp.Size = New System.Drawing.Size(654, 731)
        Me.GridFollowUp.TabIndex = 5
        Me.GridFollowUp.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'DashboardFollowup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.GridFollowUp)
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardFollowup"
        Me.Size = New System.Drawing.Size(898, 787)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents GridFollowUp As Janus.Windows.GridEX.GridEX
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadTelephone As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadDoctory As System.Windows.Forms.RadioButton
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNewFollowUP As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSendToWaiting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFollowupReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateFollowupTo As System.Windows.Forms.DateTimePicker

End Class
