<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiagnosisAndSurgeries
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim GridEXSergery_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDiagnosisAndSurgeries))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridMainDiagnosis = New System.Windows.Forms.DataGridView
        Me.SID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Surgery = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextSubDiagnosis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateSubDiagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnNewDiagosis = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtFindDiagnosis = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridEXSergery = New Janus.Windows.GridEX.GridEX
        Me.BtnNewSurgeries = New System.Windows.Forms.Button
        Me.BtnFindSurgeries = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSurgeries = New System.Windows.Forms.TextBox
        Me.ContextMenuSurgeries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextDeleteSubDiagnosis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSubDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridMainDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextSubDiagnosis.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridEXSergery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuSurgeries.SuspendLayout()
        Me.ContextDeleteSubDiagnosis.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1213, 814)
        Me.SplitContainer1.SplitterDistance = 641
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridMainDiagnosis)
        Me.GroupBox1.Controls.Add(Me.BtnNewDiagosis)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.TxtFindDiagnosis)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 814)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Diagnosis"
        '
        'GridMainDiagnosis
        '
        Me.GridMainDiagnosis.AllowUserToAddRows = False
        Me.GridMainDiagnosis.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridMainDiagnosis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridMainDiagnosis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMainDiagnosis.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GridMainDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridMainDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMainDiagnosis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SID, Me.Surgery, Me.Type, Me.Description, Me.Code})
        Me.GridMainDiagnosis.ContextMenuStrip = Me.ContextSubDiagnosis
        Me.GridMainDiagnosis.Location = New System.Drawing.Point(6, 105)
        Me.GridMainDiagnosis.MultiSelect = False
        Me.GridMainDiagnosis.Name = "GridMainDiagnosis"
        Me.GridMainDiagnosis.ReadOnly = True
        Me.GridMainDiagnosis.RowHeadersWidth = 50
        Me.GridMainDiagnosis.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMainDiagnosis.RowTemplate.Height = 35
        Me.GridMainDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridMainDiagnosis.Size = New System.Drawing.Size(629, 703)
        Me.GridMainDiagnosis.TabIndex = 3
        '
        'SID
        '
        Me.SID.DataPropertyName = "SID"
        Me.SID.HeaderText = "SID"
        Me.SID.Name = "SID"
        Me.SID.ReadOnly = True
        Me.SID.Visible = False
        '
        'Surgery
        '
        Me.Surgery.DataPropertyName = "Surgery"
        Me.Surgery.HeaderText = "Diagnosis"
        Me.Surgery.Name = "Surgery"
        Me.Surgery.ReadOnly = True
        Me.Surgery.Width = 200
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type Other"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Type.Visible = False
        Me.Type.Width = 150
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Visible = False
        Me.Description.Width = 150
        '
        'Code
        '
        Me.Code.DataPropertyName = "Code"
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'ContextSubDiagnosis
        '
        Me.ContextSubDiagnosis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateSubDiagToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteDiagnosisToolStripMenuItem})
        Me.ContextSubDiagnosis.Name = "ContextSubDiagnosis"
        Me.ContextSubDiagnosis.Size = New System.Drawing.Size(195, 54)
        '
        'CreateSubDiagToolStripMenuItem
        '
        Me.CreateSubDiagToolStripMenuItem.Name = "CreateSubDiagToolStripMenuItem"
        Me.CreateSubDiagToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CreateSubDiagToolStripMenuItem.Text = "Create Sub Diagnosis..."
        Me.CreateSubDiagToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'DeleteDiagnosisToolStripMenuItem
        '
        Me.DeleteDiagnosisToolStripMenuItem.Name = "DeleteDiagnosisToolStripMenuItem"
        Me.DeleteDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DeleteDiagnosisToolStripMenuItem.Text = "Delete Diagnosis"
        '
        'BtnNewDiagosis
        '
        Me.BtnNewDiagosis.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnNewDiagosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewDiagosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewDiagosis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewDiagosis.ForeColor = System.Drawing.Color.White
        Me.BtnNewDiagosis.Location = New System.Drawing.Point(381, 36)
        Me.BtnNewDiagosis.Name = "BtnNewDiagosis"
        Me.BtnNewDiagosis.Size = New System.Drawing.Size(125, 35)
        Me.BtnNewDiagosis.TabIndex = 2
        Me.BtnNewDiagosis.Text = "&New Diagnosis"
        Me.BtnNewDiagosis.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Location = New System.Drawing.Point(308, 36)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(67, 35)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.Text = "&Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtFindDiagnosis
        '
        Me.TxtFindDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindDiagnosis.Location = New System.Drawing.Point(94, 45)
        Me.TxtFindDiagnosis.Name = "TxtFindDiagnosis"
        Me.TxtFindDiagnosis.Size = New System.Drawing.Size(195, 26)
        Me.TxtFindDiagnosis.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daignosis:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridEXSergery)
        Me.GroupBox2.Controls.Add(Me.BtnNewSurgeries)
        Me.GroupBox2.Controls.Add(Me.BtnFindSurgeries)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtSurgeries)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 814)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Surgeries and Service Price"
        '
        'GridEXSergery
        '
        Me.GridEXSergery.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXSergery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXSergery.ContextMenuStrip = Me.ContextMenuSurgeries
        GridEXSergery_DesignTimeLayout.LayoutString = resources.GetString("GridEXSergery_DesignTimeLayout.LayoutString")
        Me.GridEXSergery.DesignTimeLayout = GridEXSergery_DesignTimeLayout
        Me.GridEXSergery.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEXSergery.GroupByBoxVisible = False
        Me.GridEXSergery.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXSergery.Location = New System.Drawing.Point(7, 93)
        Me.GridEXSergery.Name = "GridEXSergery"
        Me.GridEXSergery.RecordNavigator = True
        Me.GridEXSergery.Size = New System.Drawing.Size(553, 715)
        Me.GridEXSergery.TabIndex = 4
        Me.GridEXSergery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'BtnNewSurgeries
        '
        Me.BtnNewSurgeries.BackgroundImage = CType(resources.GetObject("BtnNewSurgeries.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewSurgeries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewSurgeries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewSurgeries.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewSurgeries.ForeColor = System.Drawing.Color.White
        Me.BtnNewSurgeries.Location = New System.Drawing.Point(131, 52)
        Me.BtnNewSurgeries.Name = "BtnNewSurgeries"
        Me.BtnNewSurgeries.Size = New System.Drawing.Size(114, 35)
        Me.BtnNewSurgeries.TabIndex = 2
        Me.BtnNewSurgeries.Text = "New &Service"
        Me.BtnNewSurgeries.UseVisualStyleBackColor = True
        '
        'BtnFindSurgeries
        '
        Me.BtnFindSurgeries.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnFindSurgeries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFindSurgeries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindSurgeries.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFindSurgeries.ForeColor = System.Drawing.Color.White
        Me.BtnFindSurgeries.Location = New System.Drawing.Point(7, 52)
        Me.BtnFindSurgeries.Name = "BtnFindSurgeries"
        Me.BtnFindSurgeries.Size = New System.Drawing.Size(114, 35)
        Me.BtnFindSurgeries.TabIndex = 1
        Me.BtnFindSurgeries.Text = "Fi&nd"
        Me.BtnFindSurgeries.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Surgeries Type:"
        '
        'TxtSurgeries
        '
        Me.TxtSurgeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSurgeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurgeries.Location = New System.Drawing.Point(131, 22)
        Me.TxtSurgeries.Name = "TxtSurgeries"
        Me.TxtSurgeries.Size = New System.Drawing.Size(371, 26)
        Me.TxtSurgeries.TabIndex = 0
        '
        'ContextMenuSurgeries
        '
        Me.ContextMenuSurgeries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuSurgeries.Name = "ContextDeleteSubDiagnosis"
        Me.ContextMenuSurgeries.Size = New System.Drawing.Size(108, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem2.Text = "Delete"
        '
        'ContextDeleteSubDiagnosis
        '
        Me.ContextDeleteSubDiagnosis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSubDiagnosisToolStripMenuItem})
        Me.ContextDeleteSubDiagnosis.Name = "ContextDeleteSubDiagnosis"
        Me.ContextDeleteSubDiagnosis.Size = New System.Drawing.Size(185, 26)
        '
        'DeleteSubDiagnosisToolStripMenuItem
        '
        Me.DeleteSubDiagnosisToolStripMenuItem.Name = "DeleteSubDiagnosisToolStripMenuItem"
        Me.DeleteSubDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DeleteSubDiagnosisToolStripMenuItem.Text = "Delete Sub Diagnosis"
        '
        'UCDiagnosisAndSurgeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCDiagnosisAndSurgeries"
        Me.Size = New System.Drawing.Size(1213, 814)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridMainDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextSubDiagnosis.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridEXSergery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuSurgeries.ResumeLayout(False)
        Me.ContextDeleteSubDiagnosis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridMainDiagnosis As System.Windows.Forms.DataGridView
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtFindDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNewDiagosis As System.Windows.Forms.Button
    Friend WithEvents ContextSubDiagnosis As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateSubDiagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteDiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextDeleteSubDiagnosis As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSubDiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnNewSurgeries As System.Windows.Forms.Button
    Friend WithEvents BtnFindSurgeries As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSurgeries As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuSurgeries As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surgery As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridEXSergery As Janus.Windows.GridEX.GridEX

End Class
