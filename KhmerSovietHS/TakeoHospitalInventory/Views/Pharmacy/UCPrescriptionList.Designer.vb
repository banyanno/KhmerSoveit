<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPrescriptionList
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
        Dim gridPrescriptions_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPrescriptionList))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewPrescrip = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditPrescription = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshPrescrip = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnGiveMedicine = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCheck = New System.Windows.Forms.ToolStripButton
        Me.gridPrescriptions = New Janus.Windows.GridEX.GridEX
        Me.SplitContainerPrescription = New System.Windows.Forms.SplitContainer
        Me.CRVPrescription = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.RdNotYetGive = New System.Windows.Forms.RadioButton
        Me.RadGive = New System.Windows.Forms.RadioButton
        Me.BtnFind = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnPrescriptinPreveiw = New System.Windows.Forms.Button
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.RadByDoctor = New System.Windows.Forms.RadioButton
        Me.RadAllPrescription = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.BGLoadPrescription = New System.ComponentModel.BackgroundWorker
        Me.ErrPrescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridPrescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPrescription.Panel1.SuspendLayout()
        Me.SplitContainerPrescription.Panel2.SuspendLayout()
        Me.SplitContainerPrescription.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewPrescrip, Me.ToolStripSeparator2, Me.BtnEditPrescription, Me.ToolStripSeparator3, Me.BtnRefreshPrescrip, Me.ToolStripSeparator1, Me.BtnGiveMedicine, Me.ToolStripSeparator4, Me.BtnCheck})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1030, 37)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewPrescrip
        '
        Me.BtnNewPrescrip.Image = Global.TakeoHospitalInventory.My.Resources.Resources.prescription
        Me.BtnNewPrescrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewPrescrip.Name = "BtnNewPrescrip"
        Me.BtnNewPrescrip.Size = New System.Drawing.Size(133, 34)
        Me.BtnNewPrescrip.Text = "Create Prescription"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'BtnEditPrescription
        '
        Me.BtnEditPrescription.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.BtnEditPrescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditPrescription.Name = "BtnEditPrescription"
        Me.BtnEditPrescription.Size = New System.Drawing.Size(118, 34)
        Me.BtnEditPrescription.Text = "Edit Prescription"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'BtnRefreshPrescrip
        '
        Me.BtnRefreshPrescrip.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefreshPrescrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshPrescrip.Name = "BtnRefreshPrescrip"
        Me.BtnRefreshPrescrip.Size = New System.Drawing.Size(103, 34)
        Me.BtnRefreshPrescrip.Text = "View All Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'BtnGiveMedicine
        '
        Me.BtnGiveMedicine.Image = Global.TakeoHospitalInventory.My.Resources.Resources._64aba8208423082b80b19790b24c2c085d955202_m
        Me.BtnGiveMedicine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGiveMedicine.Name = "BtnGiveMedicine"
        Me.BtnGiveMedicine.Size = New System.Drawing.Size(106, 34)
        Me.BtnGiveMedicine.Text = "Give Medicine"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'BtnCheck
        '
        Me.BtnCheck.Image = Global.TakeoHospitalInventory.My.Resources.Resources.check
        Me.BtnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(84, 34)
        Me.BtnCheck.Text = "Check All"
        '
        'gridPrescriptions
        '
        gridPrescriptions_DesignTimeLayout.LayoutString = resources.GetString("gridPrescriptions_DesignTimeLayout.LayoutString")
        Me.gridPrescriptions.DesignTimeLayout = gridPrescriptions_DesignTimeLayout
        Me.gridPrescriptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPrescriptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridPrescriptions.GroupByBoxVisible = False
        Me.gridPrescriptions.Hierarchical = True
        Me.gridPrescriptions.Location = New System.Drawing.Point(0, 0)
        Me.gridPrescriptions.Name = "gridPrescriptions"
        Me.gridPrescriptions.RecordNavigator = True
        Me.gridPrescriptions.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridPrescriptions.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridPrescriptions.Size = New System.Drawing.Size(343, 379)
        Me.gridPrescriptions.TabIndex = 4
        Me.gridPrescriptions.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'SplitContainerPrescription
        '
        Me.SplitContainerPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPrescription.Location = New System.Drawing.Point(0, 128)
        Me.SplitContainerPrescription.Name = "SplitContainerPrescription"
        '
        'SplitContainerPrescription.Panel1
        '
        Me.SplitContainerPrescription.Panel1.Controls.Add(Me.gridPrescriptions)
        '
        'SplitContainerPrescription.Panel2
        '
        Me.SplitContainerPrescription.Panel2.Controls.Add(Me.CRVPrescription)
        Me.SplitContainerPrescription.Size = New System.Drawing.Size(1030, 379)
        Me.SplitContainerPrescription.SplitterDistance = 343
        Me.SplitContainerPrescription.TabIndex = 6
        '
        'CRVPrescription
        '
        Me.CRVPrescription.ActiveViewIndex = -1
        Me.CRVPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPrescription.DisplayGroupTree = False
        Me.CRVPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPrescription.Location = New System.Drawing.Point(0, 0)
        Me.CRVPrescription.Name = "CRVPrescription"
        Me.CRVPrescription.SelectionFormula = ""
        Me.CRVPrescription.Size = New System.Drawing.Size(683, 379)
        Me.CRVPrescription.TabIndex = 0
        Me.CRVPrescription.ViewTimeSelectionFormula = ""
        '
        'RdNotYetGive
        '
        Me.RdNotYetGive.AutoSize = True
        Me.RdNotYetGive.Checked = True
        Me.RdNotYetGive.Location = New System.Drawing.Point(6, 19)
        Me.RdNotYetGive.Name = "RdNotYetGive"
        Me.RdNotYetGive.Size = New System.Drawing.Size(132, 17)
        Me.RdNotYetGive.TabIndex = 0
        Me.RdNotYetGive.TabStop = True
        Me.RdNotYetGive.Text = "Not Yet Give Medicine"
        Me.RdNotYetGive.UseVisualStyleBackColor = True
        '
        'RadGive
        '
        Me.RadGive.AutoSize = True
        Me.RadGive.Location = New System.Drawing.Point(6, 42)
        Me.RadGive.Name = "RadGive"
        Me.RadGive.Size = New System.Drawing.Size(127, 17)
        Me.RadGive.TabIndex = 1
        Me.RadGive.Text = "Give Medicine Ready"
        Me.RadGive.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(167, 36)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(85, 23)
        Me.BtnFind.TabIndex = 2
        Me.BtnFind.Text = "Find Patient"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.RadGive)
        Me.GroupBox1.Controls.Add(Me.RdNotYetGive)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1030, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BtnPrescriptinPreveiw)
        Me.GroupBox2.Controls.Add(Me.CboDoctor)
        Me.GroupBox2.Controls.Add(Me.RadByDoctor)
        Me.GroupBox2.Controls.Add(Me.RadAllPrescription)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DTo)
        Me.GroupBox2.Controls.Add(Me.DFrom)
        Me.GroupBox2.Location = New System.Drawing.Point(361, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 77)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prescription On Pharmacy"
        '
        'BtnPrescriptinPreveiw
        '
        Me.BtnPrescriptinPreveiw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrescriptinPreveiw.Location = New System.Drawing.Point(478, 42)
        Me.BtnPrescriptinPreveiw.Name = "BtnPrescriptinPreveiw"
        Me.BtnPrescriptinPreveiw.Size = New System.Drawing.Size(103, 23)
        Me.BtnPrescriptinPreveiw.TabIndex = 7
        Me.BtnPrescriptinPreveiw.Text = "Print Preview"
        Me.BtnPrescriptinPreveiw.UseVisualStyleBackColor = True
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(295, 39)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(177, 28)
        Me.CboDoctor.TabIndex = 6
        '
        'RadByDoctor
        '
        Me.RadByDoctor.AutoSize = True
        Me.RadByDoctor.Location = New System.Drawing.Point(221, 48)
        Me.RadByDoctor.Name = "RadByDoctor"
        Me.RadByDoctor.Size = New System.Drawing.Size(75, 17)
        Me.RadByDoctor.TabIndex = 5
        Me.RadByDoctor.TabStop = True
        Me.RadByDoctor.Text = "By Doctor:"
        Me.RadByDoctor.UseVisualStyleBackColor = True
        '
        'RadAllPrescription
        '
        Me.RadAllPrescription.AutoSize = True
        Me.RadAllPrescription.Checked = True
        Me.RadAllPrescription.Location = New System.Drawing.Point(221, 21)
        Me.RadAllPrescription.Name = "RadAllPrescription"
        Me.RadAllPrescription.Size = New System.Drawing.Size(36, 17)
        Me.RadAllPrescription.TabIndex = 4
        Me.RadAllPrescription.TabStop = True
        Me.RadAllPrescription.Text = "All"
        Me.RadAllPrescription.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(54, 48)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(133, 23)
        Me.DTo.TabIndex = 1
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(54, 19)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(133, 23)
        Me.DFrom.TabIndex = 0
        '
        'BGLoadPrescription
        '
        '
        'ErrPrescription
        '
        Me.ErrPrescription.ContainerControl = Me
        '
        'UCPrescriptionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerPrescription)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCPrescriptionList"
        Me.Size = New System.Drawing.Size(1030, 507)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridPrescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPrescription.Panel1.ResumeLayout(False)
        Me.SplitContainerPrescription.Panel2.ResumeLayout(False)
        Me.SplitContainerPrescription.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewPrescrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshPrescrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridPrescriptions As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnGiveMedicine As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditPrescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainerPrescription As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents RadGive As System.Windows.Forms.RadioButton
    Friend WithEvents RdNotYetGive As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadByDoctor As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllPrescription As System.Windows.Forms.RadioButton
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents BtnPrescriptinPreveiw As System.Windows.Forms.Button
    Friend WithEvents CRVPrescription As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BGLoadPrescription As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrPrescription As System.Windows.Forms.ErrorProvider

End Class
