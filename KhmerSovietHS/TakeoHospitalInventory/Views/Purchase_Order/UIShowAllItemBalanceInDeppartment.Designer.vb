<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIShowAllItemBalanceInDeppartment
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
        Dim GridAllItemBalance_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIShowAllItemBalanceInDeppartment))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.BtnViewItemBalance = New System.Windows.Forms.Button
        Me.btnDepartCurrentStock = New Janus.Windows.EditControls.UIButton
        Me.dptDate = New System.Windows.Forms.DateTimePicker
        Me.GridAllItemBalance = New Janus.Windows.GridEX.GridEX
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GroupStatus = New Janus.Windows.EditControls.UIGroupBox
        Me.LVDepStatus = New System.Windows.Forms.ListView
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.BgCheckRunEOD = New System.ComponentModel.BackgroundWorker
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.GridAllItemBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GroupStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.BtnViewItemBalance)
        Me.UiGroupBox1.Controls.Add(Me.btnDepartCurrentStock)
        Me.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(1143, 66)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Show Balance"
        '
        'BtnViewItemBalance
        '
        Me.BtnViewItemBalance.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnViewItemBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnViewItemBalance.Location = New System.Drawing.Point(221, 16)
        Me.BtnViewItemBalance.Name = "BtnViewItemBalance"
        Me.BtnViewItemBalance.Size = New System.Drawing.Size(234, 36)
        Me.BtnViewItemBalance.TabIndex = 3
        Me.BtnViewItemBalance.Text = "Report Item Balance In Hospital"
        Me.BtnViewItemBalance.UseVisualStyleBackColor = True
        '
        'btnDepartCurrentStock
        '
        Me.btnDepartCurrentStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepartCurrentStock.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.btnDepartCurrentStock.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnDepartCurrentStock.Location = New System.Drawing.Point(4, 16)
        Me.btnDepartCurrentStock.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDepartCurrentStock.Name = "btnDepartCurrentStock"
        Me.btnDepartCurrentStock.Size = New System.Drawing.Size(187, 36)
        Me.btnDepartCurrentStock.TabIndex = 2
        Me.btnDepartCurrentStock.Text = "Check Departments Stock"
        '
        'dptDate
        '
        Me.dptDate.Checked = False
        Me.dptDate.CustomFormat = "dd/MM/yyyy"
        Me.dptDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptDate.Location = New System.Drawing.Point(35, 82)
        Me.dptDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptDate.Name = "dptDate"
        Me.dptDate.Size = New System.Drawing.Size(151, 26)
        Me.dptDate.TabIndex = 16
        '
        'GridAllItemBalance
        '
        GridAllItemBalance_DesignTimeLayout.LayoutString = resources.GetString("GridAllItemBalance_DesignTimeLayout.LayoutString")
        Me.GridAllItemBalance.DesignTimeLayout = GridAllItemBalance_DesignTimeLayout
        Me.GridAllItemBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAllItemBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridAllItemBalance.GroupByBoxVisible = False
        Me.GridAllItemBalance.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridAllItemBalance.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAllItemBalance.Hierarchical = True
        Me.GridAllItemBalance.Location = New System.Drawing.Point(2, 15)
        Me.GridAllItemBalance.Margin = New System.Windows.Forms.Padding(2)
        Me.GridAllItemBalance.Name = "GridAllItemBalance"
        Me.GridAllItemBalance.RecordNavigator = True
        Me.GridAllItemBalance.Size = New System.Drawing.Size(434, 496)
        Me.GridAllItemBalance.TabIndex = 1
        Me.GridAllItemBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "circle_red.png")
        Me.ImageList1.Images.SetKeyName(1, "circle_blue.png")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 66)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupStatus)
        Me.SplitContainer1.Size = New System.Drawing.Size(1143, 513)
        Me.SplitContainer1.SplitterDistance = 438
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridAllItemBalance)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(438, 513)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of current stock each department"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dptDate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 477)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(702, 36)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Note"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Check Date Run End Of Day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Already run end of day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Not yet run end of day"
        '
        'Label2
        '
        Me.Label2.ImageIndex = 1
        Me.Label2.ImageList = Me.ImageList1
        Me.Label2.Location = New System.Drawing.Point(237, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 45)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.ImageIndex = 0
        Me.Label1.ImageList = Me.ImageList1
        Me.Label1.Location = New System.Drawing.Point(34, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 45)
        Me.Label1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 475)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(702, 2)
        Me.Splitter1.TabIndex = 7
        Me.Splitter1.TabStop = False
        '
        'GroupStatus
        '
        Me.GroupStatus.Controls.Add(Me.LVDepStatus)
        Me.GroupStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupStatus.Location = New System.Drawing.Point(0, 0)
        Me.GroupStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupStatus.Name = "GroupStatus"
        Me.GroupStatus.Size = New System.Drawing.Size(702, 475)
        Me.GroupStatus.TabIndex = 6
        Me.GroupStatus.Text = "Department Status"
        '
        'LVDepStatus
        '
        Me.LVDepStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LVDepStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVDepStatus.LargeImageList = Me.ImageList2
        Me.LVDepStatus.Location = New System.Drawing.Point(3, 16)
        Me.LVDepStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.LVDepStatus.Name = "LVDepStatus"
        Me.LVDepStatus.Size = New System.Drawing.Size(696, 456)
        Me.LVDepStatus.TabIndex = 0
        Me.LVDepStatus.UseCompatibleStateImageBehavior = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "circle_red.png")
        Me.ImageList2.Images.SetKeyName(1, "circle_blue.png")
        '
        'BgCheckRunEOD
        '
        '
        'UIShowAllItemBalanceInDeppartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UIShowAllItemBalanceInDeppartment"
        Me.Size = New System.Drawing.Size(1143, 579)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.GridAllItemBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GroupStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents GridAllItemBalance As Janus.Windows.GridEX.GridEX
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnDepartCurrentStock As Janus.Windows.EditControls.UIButton
    Friend WithEvents dptDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents GroupStatus As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents LVDepStatus As System.Windows.Forms.ListView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BgCheckRunEOD As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnViewItemBalance As System.Windows.Forms.Button

End Class
