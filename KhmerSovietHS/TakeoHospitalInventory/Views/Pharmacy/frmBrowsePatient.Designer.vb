<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowsePatient
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
        Dim gridPatient_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowsePatient))
        Me.gridPatient = New Janus.Windows.GridEX.GridEX
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOK = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RibbonStatusBar1 = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.ContainerBrowsePatient = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.BackgroundWorkerPatient = New System.ComponentModel.BackgroundWorker
        CType(Me.gridPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridPatient
        '
        Me.gridPatient.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridPatient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        gridPatient_DesignTimeLayout.LayoutString = resources.GetString("gridPatient_DesignTimeLayout.LayoutString")
        Me.gridPatient.DesignTimeLayout = gridPatient_DesignTimeLayout
        Me.gridPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPatient.GroupByBoxVisible = False
        Me.gridPatient.Location = New System.Drawing.Point(21, 76)
        Me.gridPatient.Name = "gridPatient"
        Me.gridPatient.RecordNavigator = True
        Me.gridPatient.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridPatient.Size = New System.Drawing.Size(676, 266)
        Me.gridPatient.TabIndex = 1
        Me.gridPatient.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.BtnCancel.Location = New System.Drawing.Point(606, 348)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(85, 36)
        Me.BtnCancel.TabIndex = 19
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnOK.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Aproved
        Me.BtnOK.Location = New System.Drawing.Point(515, 348)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(85, 36)
        Me.BtnOK.TabIndex = 18
        Me.BtnOK.Text = " OK"
        Me.BtnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnOK)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.gridPatient)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 418)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnFind)
        Me.GroupBox2.Controls.Add(Me.TxtPatientName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(703, 51)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Find No:"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.BtnFind.Location = New System.Drawing.Point(360, 14)
        Me.BtnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(68, 31)
        Me.BtnFind.TabIndex = 2
        Me.BtnFind.Text = "Find"
        Me.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(92, 17)
        Me.TxtPatientName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(255, 26)
        Me.TxtPatientName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ImageSize = New System.Drawing.Size(16, 16)
        Me.RibbonStatusBar1.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ContainerBrowsePatient})
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 395)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Office2007CustomColor = System.Drawing.Color.Empty
        Me.RibbonStatusBar1.ShowToolTips = False
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(709, 23)
        '
        '
        '
        Me.RibbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000
        Me.RibbonStatusBar1.SuperTipComponent.ImageList = Nothing
        Me.RibbonStatusBar1.TabIndex = 21
        Me.RibbonStatusBar1.Text = "RibbonStatusBar1"
        Me.RibbonStatusBar1.UseCompatibleTextRendering = False
        '
        'ContainerBrowsePatient
        '
        Me.ContainerBrowsePatient.Control = Me.PictureBox3
        Me.ContainerBrowsePatient.Key = "ContainerControlCommand1"
        Me.ContainerBrowsePatient.Name = "ContainerBrowsePatient"
        Me.ContainerBrowsePatient.Text = "Loading : "
        Me.ContainerBrowsePatient.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loadingNew3
        Me.PictureBox3.Location = New System.Drawing.Point(59, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'BackgroundWorkerPatient
        '
        '
        'frmBrowsePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 418)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBrowsePatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patients"
        CType(Me.gridPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridPatient As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RibbonStatusBar1 As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ContainerBrowsePatient As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents BackgroundWorkerPatient As System.ComponentModel.BackgroundWorker
End Class
