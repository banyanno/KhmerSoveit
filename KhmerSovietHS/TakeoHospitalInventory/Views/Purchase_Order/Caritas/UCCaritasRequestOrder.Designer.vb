<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCaritasRequestOrder
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
        Dim gridCaritasRequestOrder123_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCaritasRequestOrder))
        Me.MenuStripCate = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuRequestExitingItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.subMenuRequestNewItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.menuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.menuRecRequestItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuApprovedRecRequest = New System.Windows.Forms.ToolStripMenuItem
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.menuRefreshData = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnRecieveNotComplet = New System.Windows.Forms.Button
        Me.BtnNotyetComplet = New System.Windows.Forms.Button
        Me.BtnRequestCaristas = New System.Windows.Forms.Button
        Me.BtnFilter = New System.Windows.Forms.Button
        Me.BtnItemSupUsed = New System.Windows.Forms.Button
        Me.BtnPrintSupGinven = New System.Windows.Forms.Button
        Me.dptToDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.BgRunReceived = New System.ComponentModel.BackgroundWorker
        Me.gridCaritasRequestOrder123 = New Janus.Windows.GridEX.GridEX
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor
        Me.MenuStripCate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridCaritasRequestOrder123, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripCate
        '
        Me.MenuStripCate.AutoSize = False
        Me.MenuStripCate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripCate.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStripCate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.menuEdit, Me.menuDelete, Me.menuRecRequestItem, Me.ToolStripMenuItem3, Me.menuApprovedRecRequest, Me.menuPrint, Me.menuRefreshData})
        Me.MenuStripCate.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripCate.Name = "MenuStripCate"
        Me.MenuStripCate.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStripCate.Size = New System.Drawing.Size(1044, 34)
        Me.MenuStripCate.TabIndex = 10
        Me.MenuStripCate.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuRequestExitingItem, Me.ToolStripSeparator1, Me.subMenuRequestNewItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 30)
        Me.ToolStripMenuItem1.Text = "New"
        '
        'subMenuRequestExitingItem
        '
        Me.subMenuRequestExitingItem.Name = "subMenuRequestExitingItem"
        Me.subMenuRequestExitingItem.Size = New System.Drawing.Size(194, 22)
        Me.subMenuRequestExitingItem.Text = "Request Existing Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'subMenuRequestNewItem
        '
        Me.subMenuRequestNewItem.Enabled = False
        Me.subMenuRequestNewItem.Name = "subMenuRequestNewItem"
        Me.subMenuRequestNewItem.Size = New System.Drawing.Size(194, 22)
        Me.subMenuRequestNewItem.Text = "Request New Item"
        '
        'menuEdit
        '
        Me.menuEdit.AutoSize = False
        Me.menuEdit.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(94, 30)
        Me.menuEdit.Text = "Edit"
        '
        'menuDelete
        '
        Me.menuDelete.AutoSize = False
        Me.menuDelete.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit_trash
        Me.menuDelete.Name = "menuDelete"
        Me.menuDelete.Size = New System.Drawing.Size(94, 30)
        Me.menuDelete.Text = "Delete"
        '
        'menuRecRequestItem
        '
        Me.menuRecRequestItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.input_keyboard
        Me.menuRecRequestItem.Name = "menuRecRequestItem"
        Me.menuRecRequestItem.Size = New System.Drawing.Size(123, 30)
        Me.menuRecRequestItem.Text = "Receive Item"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 30)
        '
        'menuApprovedRecRequest
        '
        Me.menuApprovedRecRequest.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Approved
        Me.menuApprovedRecRequest.Name = "menuApprovedRecRequest"
        Me.menuApprovedRecRequest.Size = New System.Drawing.Size(154, 30)
        Me.menuApprovedRecRequest.Text = "Approve  Received"
        '
        'menuPrint
        '
        Me.menuPrint.AutoSize = False
        Me.menuPrint.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.Size = New System.Drawing.Size(94, 30)
        Me.menuPrint.Text = "Print"
        '
        'menuRefreshData
        '
        Me.menuRefreshData.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.menuRefreshData.Name = "menuRefreshData"
        Me.menuRefreshData.Size = New System.Drawing.Size(121, 30)
        Me.menuRefreshData.Text = "Refresh Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnRequestCaristas)
        Me.GroupBox1.Controls.Add(Me.BtnFilter)
        Me.GroupBox1.Controls.Add(Me.BtnItemSupUsed)
        Me.GroupBox1.Controls.Add(Me.BtnPrintSupGinven)
        Me.GroupBox1.Controls.Add(Me.dptToDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dptFromDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1044, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRecieveNotComplet)
        Me.GroupBox2.Controls.Add(Me.BtnNotyetComplet)
        Me.GroupBox2.Location = New System.Drawing.Point(473, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 75)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Status"
        '
        'btnRecieveNotComplet
        '
        Me.btnRecieveNotComplet.BackColor = System.Drawing.Color.Linen
        Me.btnRecieveNotComplet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecieveNotComplet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecieveNotComplet.Location = New System.Drawing.Point(6, 45)
        Me.btnRecieveNotComplet.Name = "btnRecieveNotComplet"
        Me.btnRecieveNotComplet.Size = New System.Drawing.Size(188, 23)
        Me.btnRecieveNotComplet.TabIndex = 2
        Me.btnRecieveNotComplet.Text = "Received not complet"
        Me.btnRecieveNotComplet.UseVisualStyleBackColor = False
        '
        'BtnNotyetComplet
        '
        Me.BtnNotyetComplet.BackColor = System.Drawing.SystemColors.Control
        Me.BtnNotyetComplet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotyetComplet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotyetComplet.Location = New System.Drawing.Point(6, 17)
        Me.BtnNotyetComplet.Name = "BtnNotyetComplet"
        Me.BtnNotyetComplet.Size = New System.Drawing.Size(188, 23)
        Me.BtnNotyetComplet.TabIndex = 2
        Me.BtnNotyetComplet.Text = "Not yet received"
        Me.BtnNotyetComplet.UseVisualStyleBackColor = False
        '
        'BtnRequestCaristas
        '
        Me.BtnRequestCaristas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRequestCaristas.Location = New System.Drawing.Point(244, 53)
        Me.BtnRequestCaristas.Name = "BtnRequestCaristas"
        Me.BtnRequestCaristas.Size = New System.Drawing.Size(204, 25)
        Me.BtnRequestCaristas.TabIndex = 20
        Me.BtnRequestCaristas.Text = "View Report Request Item of Caritas"
        Me.BtnRequestCaristas.UseVisualStyleBackColor = True
        '
        'BtnFilter
        '
        Me.BtnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFilter.Location = New System.Drawing.Point(244, 17)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(204, 27)
        Me.BtnFilter.TabIndex = 19
        Me.BtnFilter.Text = "Display"
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        'BtnItemSupUsed
        '
        Me.BtnItemSupUsed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnItemSupUsed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnItemSupUsed.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnItemSupUsed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnItemSupUsed.Location = New System.Drawing.Point(787, 53)
        Me.BtnItemSupUsed.Name = "BtnItemSupUsed"
        Me.BtnItemSupUsed.Size = New System.Drawing.Size(251, 41)
        Me.BtnItemSupUsed.TabIndex = 18
        Me.BtnItemSupUsed.Text = "Print Item Request Used In Hospital"
        Me.BtnItemSupUsed.UseVisualStyleBackColor = True
        Me.BtnItemSupUsed.Visible = False
        '
        'BtnPrintSupGinven
        '
        Me.BtnPrintSupGinven.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintSupGinven.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintSupGinven.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnPrintSupGinven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrintSupGinven.Location = New System.Drawing.Point(787, 9)
        Me.BtnPrintSupGinven.Name = "BtnPrintSupGinven"
        Me.BtnPrintSupGinven.Size = New System.Drawing.Size(251, 41)
        Me.BtnPrintSupGinven.TabIndex = 17
        Me.BtnPrintSupGinven.Text = "Print Item Requested and Received"
        Me.BtnPrintSupGinven.UseVisualStyleBackColor = True
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(78, 52)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(151, 26)
        Me.dptToDate.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "To Date:"
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(78, 18)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(151, 26)
        Me.dptFromDate.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "From Date:"
        '
        'BgRunReceived
        '
        '
        'gridCaritasRequestOrder123
        '
        gridCaritasRequestOrder123_DesignTimeLayout.LayoutString = resources.GetString("gridCaritasRequestOrder123_DesignTimeLayout.LayoutString")
        Me.gridCaritasRequestOrder123.DesignTimeLayout = gridCaritasRequestOrder123_DesignTimeLayout
        Me.gridCaritasRequestOrder123.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCaritasRequestOrder123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridCaritasRequestOrder123.GroupByBoxVisible = False
        Me.gridCaritasRequestOrder123.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.gridCaritasRequestOrder123.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.gridCaritasRequestOrder123.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridCaritasRequestOrder123.Hierarchical = True
        Me.gridCaritasRequestOrder123.Location = New System.Drawing.Point(0, 182)
        Me.gridCaritasRequestOrder123.Name = "gridCaritasRequestOrder123"
        Me.gridCaritasRequestOrder123.RecordNavigator = True
        Me.gridCaritasRequestOrder123.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.gridCaritasRequestOrder123.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridCaritasRequestOrder123.Size = New System.Drawing.Size(1044, 427)
        Me.gridCaritasRequestOrder123.TabIndex = 14
        '
        'FilterEditor1
        '
        Me.FilterEditor1.AutoApply = True
        Me.FilterEditor1.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(0, 134)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(16, 45)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(1044, 48)
        Me.FilterEditor1.SourceControl = Me.gridCaritasRequestOrder123
        '
        'UCCaritasRequestOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridCaritasRequestOrder123)
        Me.Controls.Add(Me.FilterEditor1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStripCate)
        Me.Name = "UCCaritasRequestOrder"
        Me.Size = New System.Drawing.Size(1044, 609)
        Me.MenuStripCate.ResumeLayout(False)
        Me.MenuStripCate.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridCaritasRequestOrder123, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStripCate As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuRequestExitingItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuRequestNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRefreshData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRecRequestItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuApprovedRecRequest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnItemSupUsed As System.Windows.Forms.Button
    Friend WithEvents BtnPrintSupGinven As System.Windows.Forms.Button
    Friend WithEvents BtnFilter As System.Windows.Forms.Button
    Friend WithEvents BtnRequestCaristas As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecieveNotComplet As System.Windows.Forms.Button
    Friend WithEvents BtnNotyetComplet As System.Windows.Forms.Button
    Friend WithEvents BgRunReceived As System.ComponentModel.BackgroundWorker
    Friend WithEvents gridCaritasRequestOrder123 As Janus.Windows.GridEX.GridEX
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor

End Class
