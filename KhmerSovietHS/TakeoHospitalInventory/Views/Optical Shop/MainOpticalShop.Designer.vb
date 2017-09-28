<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainOpticalShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainOpticalShop))
        Dim GridReceipt_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ImageAddItem = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageStatusbar = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridReceipt = New Janus.Windows.GridEX.GridEX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnEditDonateOptical = New System.Windows.Forms.Button
        Me.BtnEditeDateReceipt = New System.Windows.Forms.Button
        Me.BtnPrintInvoice = New System.Windows.Forms.Button
        Me.BtnEditInvoice = New System.Windows.Forms.Button
        Me.RadReceiptCancel = New System.Windows.Forms.RadioButton
        Me.RadWaitAndPaid = New System.Windows.Forms.RadioButton
        Me.BtnNewReceipt1 = New System.Windows.Forms.Button
        Me.BtnView = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FilterReceipt = New Janus.Windows.FilterEditor.FilterEditor
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BGLoadOpticalShop = New System.ComponentModel.BackgroundWorker
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageAddItem
        '
        Me.ImageAddItem.ImageStream = CType(resources.GetObject("ImageAddItem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageAddItem.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageAddItem.Images.SetKeyName(0, "Vista (199).png")
        Me.ImageAddItem.Images.SetKeyName(1, "Vista (198).png")
        Me.ImageAddItem.Images.SetKeyName(2, "delete.ico")
        Me.ImageAddItem.Images.SetKeyName(3, "app_48.ico")
        '
        'ImageStatusbar
        '
        Me.ImageStatusbar.ImageStream = CType(resources.GetObject("ImageStatusbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageStatusbar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageStatusbar.Images.SetKeyName(0, "check.ico")
        Me.ImageStatusbar.Images.SetKeyName(1, "document-print.ico")
        Me.ImageStatusbar.Images.SetKeyName(2, "arrow_down.ico")
        Me.ImageStatusbar.Images.SetKeyName(3, "blue_new.png")
        Me.ImageStatusbar.Images.SetKeyName(4, "edit.png")
        Me.ImageStatusbar.Images.SetKeyName(5, "document-print.png")
        Me.ImageStatusbar.Images.SetKeyName(6, "CashReceipt.png")
        '
        'ErrReceipt
        '
        Me.ErrReceipt.ContainerControl = Me
        '
        'GridReceipt
        '
        GridReceipt_DesignTimeLayout.LayoutString = resources.GetString("GridReceipt_DesignTimeLayout.LayoutString")
        Me.GridReceipt.DesignTimeLayout = GridReceipt_DesignTimeLayout
        Me.GridReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridReceipt.GroupByBoxVisible = False
        Me.GridReceipt.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridReceipt.Hierarchical = True
        Me.GridReceipt.Location = New System.Drawing.Point(0, 109)
        Me.GridReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.GridReceipt.Name = "GridReceipt"
        Me.GridReceipt.RecordNavigator = True
        Me.GridReceipt.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridReceipt.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReceipt.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridReceipt.Size = New System.Drawing.Size(1006, 417)
        Me.GridReceipt.TabIndex = 3
        Me.GridReceipt.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnEditDonateOptical)
        Me.Panel1.Controls.Add(Me.BtnEditeDateReceipt)
        Me.Panel1.Controls.Add(Me.BtnPrintInvoice)
        Me.Panel1.Controls.Add(Me.BtnEditInvoice)
        Me.Panel1.Controls.Add(Me.RadReceiptCancel)
        Me.Panel1.Controls.Add(Me.RadWaitAndPaid)
        Me.Panel1.Controls.Add(Me.BtnNewReceipt1)
        Me.Panel1.Controls.Add(Me.BtnView)
        Me.Panel1.Controls.Add(Me.DateTo)
        Me.Panel1.Controls.Add(Me.DateFrom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 58)
        Me.Panel1.TabIndex = 5
        '
        'BtnEditDonateOptical
        '
        Me.BtnEditDonateOptical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditDonateOptical.Location = New System.Drawing.Point(292, 8)
        Me.BtnEditDonateOptical.Name = "BtnEditDonateOptical"
        Me.BtnEditDonateOptical.Size = New System.Drawing.Size(101, 34)
        Me.BtnEditDonateOptical.TabIndex = 15
        Me.BtnEditDonateOptical.Text = "Edit Donate In Optical"
        Me.BtnEditDonateOptical.UseVisualStyleBackColor = True
        '
        'BtnEditeDateReceipt
        '
        Me.BtnEditeDateReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditeDateReceipt.ImageIndex = 4
        Me.BtnEditeDateReceipt.ImageList = Me.ImageStatusbar
        Me.BtnEditeDateReceipt.Location = New System.Drawing.Point(188, 8)
        Me.BtnEditeDateReceipt.Name = "BtnEditeDateReceipt"
        Me.BtnEditeDateReceipt.Size = New System.Drawing.Size(98, 34)
        Me.BtnEditeDateReceipt.TabIndex = 14
        Me.BtnEditeDateReceipt.Text = "Edit Date Receipt"
        Me.BtnEditeDateReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditeDateReceipt.UseVisualStyleBackColor = True
        '
        'BtnPrintInvoice
        '
        Me.BtnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintInvoice.ImageIndex = 5
        Me.BtnPrintInvoice.ImageList = Me.ImageStatusbar
        Me.BtnPrintInvoice.Location = New System.Drawing.Point(399, 8)
        Me.BtnPrintInvoice.Name = "BtnPrintInvoice"
        Me.BtnPrintInvoice.Size = New System.Drawing.Size(89, 34)
        Me.BtnPrintInvoice.TabIndex = 13
        Me.BtnPrintInvoice.Text = "Print Invoice"
        Me.BtnPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintInvoice.UseVisualStyleBackColor = True
        '
        'BtnEditInvoice
        '
        Me.BtnEditInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditInvoice.ImageIndex = 4
        Me.BtnEditInvoice.ImageList = Me.ImageStatusbar
        Me.BtnEditInvoice.Location = New System.Drawing.Point(97, 8)
        Me.BtnEditInvoice.Name = "BtnEditInvoice"
        Me.BtnEditInvoice.Size = New System.Drawing.Size(86, 34)
        Me.BtnEditInvoice.TabIndex = 12
        Me.BtnEditInvoice.Text = "Edit Invoice"
        Me.BtnEditInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditInvoice.UseVisualStyleBackColor = True
        '
        'RadReceiptCancel
        '
        Me.RadReceiptCancel.AutoSize = True
        Me.RadReceiptCancel.Location = New System.Drawing.Point(877, 27)
        Me.RadReceiptCancel.Name = "RadReceiptCancel"
        Me.RadReceiptCancel.Size = New System.Drawing.Size(96, 17)
        Me.RadReceiptCancel.TabIndex = 11
        Me.RadReceiptCancel.Text = "Invoice Cancel"
        Me.RadReceiptCancel.UseVisualStyleBackColor = True
        '
        'RadWaitAndPaid
        '
        Me.RadWaitAndPaid.AutoSize = True
        Me.RadWaitAndPaid.Checked = True
        Me.RadWaitAndPaid.Location = New System.Drawing.Point(877, 6)
        Me.RadWaitAndPaid.Name = "RadWaitAndPaid"
        Me.RadWaitAndPaid.Size = New System.Drawing.Size(144, 17)
        Me.RadWaitAndPaid.TabIndex = 11
        Me.RadWaitAndPaid.TabStop = True
        Me.RadWaitAndPaid.Text = "Waiting and Paid Invoice"
        Me.RadWaitAndPaid.UseVisualStyleBackColor = True
        '
        'BtnNewReceipt1
        '
        Me.BtnNewReceipt1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewReceipt1.ImageIndex = 3
        Me.BtnNewReceipt1.ImageList = Me.ImageStatusbar
        Me.BtnNewReceipt1.Location = New System.Drawing.Point(2, 8)
        Me.BtnNewReceipt1.Name = "BtnNewReceipt1"
        Me.BtnNewReceipt1.Size = New System.Drawing.Size(90, 34)
        Me.BtnNewReceipt1.TabIndex = 10
        Me.BtnNewReceipt1.Text = "New Invoice"
        Me.BtnNewReceipt1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNewReceipt1.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.ImageIndex = 2
        Me.BtnView.ImageList = Me.ImageStatusbar
        Me.BtnView.Location = New System.Drawing.Point(791, 7)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(82, 29)
        Me.BtnView.TabIndex = 8
        Me.BtnView.Text = "View"
        Me.BtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(694, 12)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(92, 23)
        Me.DateTo.TabIndex = 6
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(571, 12)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(91, 23)
        Me.DateFrom.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(667, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From:"
        '
        'FilterReceipt
        '
        Me.FilterReceipt.AutoApply = True
        Me.FilterReceipt.BackColor = System.Drawing.Color.Transparent
        Me.FilterReceipt.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterReceipt.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterReceipt.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterReceipt.Location = New System.Drawing.Point(0, 58)
        Me.FilterReceipt.MinSize = New System.Drawing.Size(16, 45)
        Me.FilterReceipt.Name = "FilterReceipt"
        Me.FilterReceipt.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterReceipt.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterReceipt.ScrollStep = 15
        Me.FilterReceipt.Size = New System.Drawing.Size(1006, 48)
        Me.FilterReceipt.SourceControl = Me.GridReceipt
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 106)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1006, 3)
        Me.Splitter1.TabIndex = 7
        Me.Splitter1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 20)
        Me.Label3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(31, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Is Paid"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(79, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 20)
        Me.Label5.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(107, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Is Waiting Payment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 526)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1006, 36)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'BGLoadOpticalShop
        '
        '
        'MainOpticalShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridReceipt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.FilterReceipt)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainOpticalShop"
        Me.Size = New System.Drawing.Size(1006, 562)
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageAddItem As System.Windows.Forms.ImageList
    Friend WithEvents ImageStatusbar As System.Windows.Forms.ImageList
    Friend WithEvents ErrReceipt As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridReceipt As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnNewReceipt1 As System.Windows.Forms.Button
    Friend WithEvents FilterReceipt As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents RadReceiptCancel As System.Windows.Forms.RadioButton
    Friend WithEvents RadWaitAndPaid As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEditInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnPrintInvoice As System.Windows.Forms.Button
    Friend WithEvents BGLoadOpticalShop As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnEditeDateReceipt As System.Windows.Forms.Button
    Friend WithEvents BtnEditDonateOptical As System.Windows.Forms.Button

End Class
