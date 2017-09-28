<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDashboardWaitingPayment
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
        Dim GridReceipt_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDashboardWaitingPayment))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnPayment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnWaitingReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancelReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewReceipt = New System.Windows.Forms.ToolStripDropDownButton
        Me.BtnUndoReceipt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFindReceiptForUpdate = New System.Windows.Forms.ToolStripButton
        Me.BtnWaitingNilInvoice = New System.Windows.Forms.ToolStripButton
        Me.BtnApproveNilInvoice = New System.Windows.Forms.ToolStripButton
        Me.GridReceipt = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DTPTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPayment, Me.ToolStripSeparator1, Me.BtnWaitingReceipt, Me.ToolStripSeparator5, Me.BtnCancelReceipt, Me.ToolStripSeparator3, Me.BtnViewReceipt, Me.ToolStripSeparator4, Me.BtnFindReceiptForUpdate, Me.BtnWaitingNilInvoice, Me.BtnApproveNilInvoice})
        Me.ToolStrip1.Location = New System.Drawing.Point(156, 31)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(976, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnPayment
        '
        Me.BtnPayment.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1316415362_cashbox
        Me.BtnPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPayment.Name = "BtnPayment"
        Me.BtnPayment.Size = New System.Drawing.Size(121, 34)
        Me.BtnPayment.Text = "Payment Invoice"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'BtnWaitingReceipt
        '
        Me.BtnWaitingReceipt.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1316401141_Schedule_File
        Me.BtnWaitingReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnWaitingReceipt.Name = "BtnWaitingReceipt"
        Me.BtnWaitingReceipt.Size = New System.Drawing.Size(141, 34)
        Me.BtnWaitingReceipt.Text = "Load Waiting Invoice"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 37)
        '
        'BtnCancelReceipt
        '
        Me.BtnCancelReceipt.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Remove
        Me.BtnCancelReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelReceipt.Name = "BtnCancelReceipt"
        Me.BtnCancelReceipt.Size = New System.Drawing.Size(111, 34)
        Me.BtnCancelReceipt.Text = "Cancel Invoice"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'BtnViewReceipt
        '
        Me.BtnViewReceipt.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUndoReceipt})
        Me.BtnViewReceipt.Image = Global.TakeoHospitalInventory.My.Resources.Resources.RightLeft2Red
        Me.BtnViewReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewReceipt.Name = "BtnViewReceipt"
        Me.BtnViewReceipt.Size = New System.Drawing.Size(157, 34)
        Me.BtnViewReceipt.Text = "View Invioce Canceled"
        '
        'BtnUndoReceipt
        '
        Me.BtnUndoReceipt.Name = "BtnUndoReceipt"
        Me.BtnUndoReceipt.Size = New System.Drawing.Size(138, 22)
        Me.BtnUndoReceipt.Text = "Undo Receipt"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'BtnFindReceiptForUpdate
        '
        Me.BtnFindReceiptForUpdate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.prescription
        Me.BtnFindReceiptForUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFindReceiptForUpdate.Name = "BtnFindReceiptForUpdate"
        Me.BtnFindReceiptForUpdate.Size = New System.Drawing.Size(99, 34)
        Me.BtnFindReceiptForUpdate.Text = "Find Invioce"
        '
        'BtnWaitingNilInvoice
        '
        Me.BtnWaitingNilInvoice.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1316401141_Schedule_File
        Me.BtnWaitingNilInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnWaitingNilInvoice.Name = "BtnWaitingNilInvoice"
        Me.BtnWaitingNilInvoice.Size = New System.Drawing.Size(155, 34)
        Me.BtnWaitingNilInvoice.Text = "Load Waiting Nil Invoice"
        Me.BtnWaitingNilInvoice.Visible = False
        '
        'BtnApproveNilInvoice
        '
        Me.BtnApproveNilInvoice.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Checked
        Me.BtnApproveNilInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnApproveNilInvoice.Name = "BtnApproveNilInvoice"
        Me.BtnApproveNilInvoice.Size = New System.Drawing.Size(134, 34)
        Me.BtnApproveNilInvoice.Text = "Approve Nil Invoice"
        Me.BtnApproveNilInvoice.Visible = False
        '
        'GridReceipt
        '
        GridReceipt_DesignTimeLayout.LayoutString = resources.GetString("GridReceipt_DesignTimeLayout.LayoutString")
        Me.GridReceipt.DesignTimeLayout = GridReceipt_DesignTimeLayout
        Me.GridReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridReceipt.GroupByBoxVisible = False
        Me.GridReceipt.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridReceipt.Location = New System.Drawing.Point(0, 73)
        Me.GridReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.GridReceipt.Name = "GridReceipt"
        Me.GridReceipt.RecordNavigator = True
        Me.GridReceipt.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridReceipt.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReceipt.Size = New System.Drawing.Size(1229, 386)
        Me.GridReceipt.TabIndex = 4
        Me.GridReceipt.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTPTo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DTPFrom)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 63)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'DTPTo
        '
        Me.DTPTo.CustomFormat = "dd/MM/yyyy"
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(38, 37)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(99, 20)
        Me.DTPTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To :"
        '
        'DTPFrom
        '
        Me.DTPFrom.CustomFormat = "dd/MM/yyyy"
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(38, 10)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(99, 20)
        Me.DTPFrom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1229, 73)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'UCDashboardWaitingPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridReceipt)
        Me.Controls.Add(Me.GroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UCDashboardWaitingPayment"
        Me.Size = New System.Drawing.Size(1229, 459)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancelReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnWaitingReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnViewReceipt As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnUndoReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridReceipt As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFindReceiptForUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnWaitingNilInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnApproveNilInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
