<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainCustomer
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
        Dim GridCustomer_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainCustomer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridCustomer = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadCustomerName = New System.Windows.Forms.RadioButton
        Me.RadCustomerNo = New System.Windows.Forms.RadioButton
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtCustomerName = New System.Windows.Forms.TextBox
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewCustomer = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewAllData = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GridCustomer)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(592, 439)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GridCustomer
        '
        Me.GridCustomer.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCustomer_DesignTimeLayout.LayoutString = resources.GetString("GridCustomer_DesignTimeLayout.LayoutString")
        Me.GridCustomer.DesignTimeLayout = GridCustomer_DesignTimeLayout
        Me.GridCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridCustomer.GroupByBoxVisible = False
        Me.GridCustomer.Location = New System.Drawing.Point(2, 68)
        Me.GridCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.GridCustomer.Name = "GridCustomer"
        Me.GridCustomer.RecordNavigator = True
        Me.GridCustomer.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridCustomer.Size = New System.Drawing.Size(588, 369)
        Me.GridCustomer.TabIndex = 1
        Me.GridCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadCustomerName)
        Me.GroupBox2.Controls.Add(Me.RadCustomerNo)
        Me.GroupBox2.Controls.Add(Me.BtnFind)
        Me.GroupBox2.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(2, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(588, 53)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Find Patient and Customer Old"
        '
        'RadCustomerName
        '
        Me.RadCustomerName.AutoSize = True
        Me.RadCustomerName.Location = New System.Drawing.Point(56, 23)
        Me.RadCustomerName.Margin = New System.Windows.Forms.Padding(2)
        Me.RadCustomerName.Name = "RadCustomerName"
        Me.RadCustomerName.Size = New System.Drawing.Size(53, 17)
        Me.RadCustomerName.TabIndex = 3
        Me.RadCustomerName.Text = "Name"
        Me.RadCustomerName.UseVisualStyleBackColor = True
        '
        'RadCustomerNo
        '
        Me.RadCustomerNo.AutoSize = True
        Me.RadCustomerNo.Checked = True
        Me.RadCustomerNo.Location = New System.Drawing.Point(7, 23)
        Me.RadCustomerNo.Margin = New System.Windows.Forms.Padding(2)
        Me.RadCustomerNo.Name = "RadCustomerNo"
        Me.RadCustomerNo.Size = New System.Drawing.Size(39, 17)
        Me.RadCustomerNo.TabIndex = 3
        Me.RadCustomerNo.TabStop = True
        Me.RadCustomerNo.Text = "No"
        Me.RadCustomerNo.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.BtnFind.Location = New System.Drawing.Point(460, 15)
        Me.BtnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(68, 28)
        Me.BtnFind.TabIndex = 2
        Me.BtnFind.Text = "Find"
        Me.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(110, 17)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(332, 26)
        Me.TxtCustomerName.TabIndex = 1
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Aproved
        Me.BtnOk.Location = New System.Drawing.Point(440, 476)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(73, 32)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.BtnCancel.Location = New System.Drawing.Point(518, 476)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(72, 32)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewCustomer, Me.ToolStripSeparator1, Me.BtnUpdate, Me.ToolStripSeparator2, Me.BtnViewAllData})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(592, 31)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewCustomer
        '
        Me.BtnNewCustomer.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.BtnNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewCustomer.Name = "BtnNewCustomer"
        Me.BtnNewCustomer.Size = New System.Drawing.Size(105, 28)
        Me.BtnNewCustomer.Text = "New Customer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        Me.ToolStripSeparator1.Visible = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(70, 28)
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BtnViewAllData
        '
        Me.BtnViewAllData.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnViewAllData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewAllData.Name = "BtnViewAllData"
        Me.BtnViewAllData.Size = New System.Drawing.Size(97, 28)
        Me.BtnViewAllData.Text = "View All Data"
        '
        'MainCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(592, 512)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainCustomer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Customer"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewCustomer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridCustomer As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewAllData As System.Windows.Forms.ToolStripButton
    Friend WithEvents RadCustomerNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadCustomerName As System.Windows.Forms.RadioButton
End Class
