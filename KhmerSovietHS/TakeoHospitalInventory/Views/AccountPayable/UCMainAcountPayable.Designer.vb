<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMainAcountPayable
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
        Dim GridAccountPayable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMainAcountPayable))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.BtnView = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewPayAble = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMainAccountPayable = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.GridAccountPayable = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuAccountPayable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUndoDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridAccountPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuAccountPayable.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnPrintPreview)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridAccountPayable)
        Me.SplitContainer1.Size = New System.Drawing.Size(861, 459)
        Me.SplitContainer1.SplitterDistance = 63
        Me.SplitContainer1.TabIndex = 0
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(445, 33)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(103, 23)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.Location = New System.Drawing.Point(364, 33)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 5
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(224, 30)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(134, 26)
        Me.DateTo.TabIndex = 4
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(49, 30)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(138, 26)
        Me.DateFrom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewPayAble, Me.ToolStripSeparator1, Me.BtnMainAccountPayable, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(861, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewPayAble
        '
        Me.BtnNewPayAble.Image = Global.TakeoHospitalInventory.My.Resources.Resources.CashReceipt
        Me.BtnNewPayAble.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewPayAble.Name = "BtnNewPayAble"
        Me.BtnNewPayAble.Size = New System.Drawing.Size(93, 24)
        Me.BtnNewPayAble.Text = "New Payable"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BtnMainAccountPayable
        '
        Me.BtnMainAccountPayable.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.BtnMainAccountPayable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMainAccountPayable.Name = "BtnMainAccountPayable"
        Me.BtnMainAccountPayable.Size = New System.Drawing.Size(141, 24)
        Me.BtnMainAccountPayable.Text = "Account Payable Name"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'GridAccountPayable
        '
        Me.GridAccountPayable.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAccountPayable.ContextMenuStrip = Me.ContextMenuAccountPayable
        GridAccountPayable_DesignTimeLayout.LayoutString = resources.GetString("GridAccountPayable_DesignTimeLayout.LayoutString")
        Me.GridAccountPayable.DesignTimeLayout = GridAccountPayable_DesignTimeLayout
        Me.GridAccountPayable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAccountPayable.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridAccountPayable.GroupByBoxVisible = False
        Me.GridAccountPayable.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridAccountPayable.Location = New System.Drawing.Point(0, 0)
        Me.GridAccountPayable.Name = "GridAccountPayable"
        Me.GridAccountPayable.RecordNavigator = True
        Me.GridAccountPayable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAccountPayable.Size = New System.Drawing.Size(861, 392)
        Me.GridAccountPayable.TabIndex = 0
        '
        'ContextMenuAccountPayable
        '
        Me.ContextMenuAccountPayable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDelete, Me.ToolStripMenuItem1, Me.BtnUndoDelete})
        Me.ContextMenuAccountPayable.Name = "ContextMenuAccountPayable"
        Me.ContextMenuAccountPayable.Size = New System.Drawing.Size(106, 54)
        '
        'BtnDelete
        '
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(105, 22)
        Me.BtnDelete.Text = "Delete"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(102, 6)
        '
        'BtnUndoDelete
        '
        Me.BtnUndoDelete.Name = "BtnUndoDelete"
        Me.BtnUndoDelete.Size = New System.Drawing.Size(105, 22)
        Me.BtnUndoDelete.Text = "Undo"
        '
        'UCMainAcountPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCMainAcountPayable"
        Me.Size = New System.Drawing.Size(861, 459)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridAccountPayable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuAccountPayable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewPayAble As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMainAccountPayable As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents GridAccountPayable As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ContextMenuAccountPayable As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUndoDelete As System.Windows.Forms.ToolStripMenuItem

End Class
