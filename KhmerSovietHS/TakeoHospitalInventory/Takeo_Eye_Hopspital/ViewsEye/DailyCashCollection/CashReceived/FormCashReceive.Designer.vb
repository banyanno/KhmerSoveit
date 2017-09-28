<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCashReceive
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
        Dim GridOtherReceipt_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCashReceive))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewReceiptOther = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnClientList = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TBtnViewDiale = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintReportOther = New System.Windows.Forms.ToolStripButton
        Me.GridOtherReceipt = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuCashOtherReceipt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDeleteReceipt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUndoReceipt = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RDateTo = New System.Windows.Forms.DateTimePicker
        Me.RDateFrom = New System.Windows.Forms.DateTimePicker
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BgLoadCashOtherReceipt = New System.ComponentModel.BackgroundWorker
        Me.SplitOtherCash = New System.Windows.Forms.SplitContainer
        Me.CRViewerOtherReceipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridOtherReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuCashOtherReceipt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitOtherCash.Panel1.SuspendLayout()
        Me.SplitOtherCash.Panel2.SuspendLayout()
        Me.SplitOtherCash.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewReceiptOther, Me.ToolStripSeparator1, Me.BtnClientList, Me.ToolStripSeparator3, Me.BtnPrintReceipt, Me.ToolStripSeparator2, Me.TBtnViewDiale, Me.ToolStripSeparator4, Me.BtnPrintReportOther})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1153, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewReceiptOther
        '
        Me.BtnNewReceiptOther.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.BtnNewReceiptOther.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewReceiptOther.Name = "BtnNewReceiptOther"
        Me.BtnNewReceiptOther.Size = New System.Drawing.Size(190, 34)
        Me.BtnNewReceiptOther.Text = "New Cash Other Receipt"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'BtnClientList
        '
        Me.BtnClientList.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.BtnClientList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClientList.Name = "BtnClientList"
        Me.BtnClientList.Size = New System.Drawing.Size(99, 34)
        Me.BtnClientList.Text = "Client List"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'BtnPrintReceipt
        '
        Me.BtnPrintReceipt.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.BtnPrintReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintReceipt.Name = "BtnPrintReceipt"
        Me.BtnPrintReceipt.Size = New System.Drawing.Size(119, 34)
        Me.BtnPrintReceipt.Text = "Print Receipt"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'TBtnViewDiale
        '
        Me.TBtnViewDiale.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1316761851_ark2
        Me.TBtnViewDiale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBtnViewDiale.Name = "TBtnViewDiale"
        Me.TBtnViewDiale.Size = New System.Drawing.Size(142, 34)
        Me.TBtnViewDiale.Text = "View Cash Other"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'BtnPrintReportOther
        '
        Me.BtnPrintReportOther.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1323157036_check
        Me.BtnPrintReportOther.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintReportOther.Name = "BtnPrintReportOther"
        Me.BtnPrintReportOther.Size = New System.Drawing.Size(227, 34)
        Me.BtnPrintReportOther.Text = "View List Other Receipt Report"
        '
        'GridOtherReceipt
        '
        Me.GridOtherReceipt.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridOtherReceipt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOtherReceipt.ContextMenuStrip = Me.ContextMenuCashOtherReceipt
        GridOtherReceipt_DesignTimeLayout.LayoutString = resources.GetString("GridOtherReceipt_DesignTimeLayout.LayoutString")
        Me.GridOtherReceipt.DesignTimeLayout = GridOtherReceipt_DesignTimeLayout
        Me.GridOtherReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridOtherReceipt.GroupByBoxVisible = False
        Me.GridOtherReceipt.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridOtherReceipt.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridOtherReceipt.Location = New System.Drawing.Point(7, 66)
        Me.GridOtherReceipt.Name = "GridOtherReceipt"
        Me.GridOtherReceipt.RecordNavigator = True
        Me.GridOtherReceipt.Size = New System.Drawing.Size(1142, 486)
        Me.GridOtherReceipt.TabIndex = 1
        '
        'ContextMenuCashOtherReceipt
        '
        Me.ContextMenuCashOtherReceipt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ContextMenuCashOtherReceipt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeleteReceipt, Me.ToolStripMenuItem1, Me.BtnUndoReceipt})
        Me.ContextMenuCashOtherReceipt.Name = "ContextMenuCashOtherReceipt"
        Me.ContextMenuCashOtherReceipt.Size = New System.Drawing.Size(179, 58)
        '
        'BtnDeleteReceipt
        '
        Me.BtnDeleteReceipt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnDeleteReceipt.Name = "BtnDeleteReceipt"
        Me.BtnDeleteReceipt.Size = New System.Drawing.Size(178, 24)
        Me.BtnDeleteReceipt.Text = "Delete Receipt"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(175, 6)
        '
        'BtnUndoReceipt
        '
        Me.BtnUndoReceipt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnUndoReceipt.Name = "BtnUndoReceipt"
        Me.BtnUndoReceipt.Size = New System.Drawing.Size(178, 24)
        Me.BtnUndoReceipt.Text = "Undo Receipt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RDateTo)
        Me.GroupBox1.Controls.Add(Me.RDateFrom)
        Me.GroupBox1.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1961, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'RDateTo
        '
        Me.RDateTo.CustomFormat = "dd/MM/yyyy"
        Me.RDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RDateTo.Location = New System.Drawing.Point(611, 18)
        Me.RDateTo.Name = "RDateTo"
        Me.RDateTo.Size = New System.Drawing.Size(142, 26)
        Me.RDateTo.TabIndex = 5
        '
        'RDateFrom
        '
        Me.RDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.RDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RDateFrom.Location = New System.Drawing.Point(434, 18)
        Me.RDateFrom.Name = "RDateFrom"
        Me.RDateFrom.Size = New System.Drawing.Size(142, 26)
        Me.RDateFrom.TabIndex = 4
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(79, 18)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(281, 26)
        Me.TxtReceiptNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(582, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No:"
        '
        'BgLoadCashOtherReceipt
        '
        '
        'SplitOtherCash
        '
        Me.SplitOtherCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitOtherCash.Location = New System.Drawing.Point(0, 37)
        Me.SplitOtherCash.Name = "SplitOtherCash"
        '
        'SplitOtherCash.Panel1
        '
        Me.SplitOtherCash.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitOtherCash.Panel1.Controls.Add(Me.GridOtherReceipt)
        '
        'SplitOtherCash.Panel2
        '
        Me.SplitOtherCash.Panel2.Controls.Add(Me.CRViewerOtherReceipt)
        Me.SplitOtherCash.Panel2Collapsed = True
        Me.SplitOtherCash.Size = New System.Drawing.Size(1153, 555)
        Me.SplitOtherCash.SplitterDistance = 637
        Me.SplitOtherCash.TabIndex = 3
        '
        'CRViewerOtherReceipt
        '
        Me.CRViewerOtherReceipt.ActiveViewIndex = -1
        Me.CRViewerOtherReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewerOtherReceipt.DisplayGroupTree = False
        Me.CRViewerOtherReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewerOtherReceipt.Location = New System.Drawing.Point(0, 0)
        Me.CRViewerOtherReceipt.Name = "CRViewerOtherReceipt"
        Me.CRViewerOtherReceipt.SelectionFormula = ""
        Me.CRViewerOtherReceipt.ShowCloseButton = False
        Me.CRViewerOtherReceipt.ShowGroupTreeButton = False
        Me.CRViewerOtherReceipt.Size = New System.Drawing.Size(96, 100)
        Me.CRViewerOtherReceipt.TabIndex = 0
        Me.CRViewerOtherReceipt.ViewTimeSelectionFormula = ""
        '
        'FormCashReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 592)
        Me.Controls.Add(Me.SplitOtherCash)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCashReceive"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Received"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridOtherReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuCashOtherReceipt.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitOtherCash.Panel1.ResumeLayout(False)
        Me.SplitOtherCash.Panel2.ResumeLayout(False)
        Me.SplitOtherCash.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewReceiptOther As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClientList As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridOtherReceipt As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BgLoadCashOtherReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuCashOtherReceipt As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeleteReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUndoReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintReportOther As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitOtherCash As System.Windows.Forms.SplitContainer
    Friend WithEvents CRViewerOtherReceipt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBtnViewDiale As System.Windows.Forms.ToolStripButton
End Class
