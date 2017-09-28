<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHosItemBalance
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.BtnViewReport = New System.Windows.Forms.Button
        Me.CBDepart = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChBAllDepart = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBCate = New System.Windows.Forms.ComboBox
        Me.ChBAllItem = New System.Windows.Forms.CheckBox
        Me.RibbonStatusBar1 = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.ContainerCtr = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.CRVReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrorCtr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundLoadReport = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCtr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnViewReport)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CBDepart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChBAllDepart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CBCate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChBAllItem)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RibbonStatusBar1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CRVReportViewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(1183, 612)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'BtnViewReport
        '
        Me.BtnViewReport.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.BtnViewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnViewReport.Location = New System.Drawing.Point(421, 86)
        Me.BtnViewReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnViewReport.Name = "BtnViewReport"
        Me.BtnViewReport.Size = New System.Drawing.Size(175, 53)
        Me.BtnViewReport.TabIndex = 8
        Me.BtnViewReport.Text = "View Report"
        Me.BtnViewReport.UseVisualStyleBackColor = True
        '
        'CBDepart
        '
        Me.CBDepart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBDepart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBDepart.Enabled = False
        Me.CBDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CBDepart.FormattingEnabled = True
        Me.CBDepart.Location = New System.Drawing.Point(141, 43)
        Me.CBDepart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBDepart.Name = "CBDepart"
        Me.CBDepart.Size = New System.Drawing.Size(256, 25)
        Me.CBDepart.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Departments :"
        '
        'ChBAllDepart
        '
        Me.ChBAllDepart.AutoSize = True
        Me.ChBAllDepart.Checked = True
        Me.ChBAllDepart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBAllDepart.Location = New System.Drawing.Point(141, 15)
        Me.ChBAllDepart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChBAllDepart.Name = "ChBAllDepart"
        Me.ChBAllDepart.Size = New System.Drawing.Size(127, 21)
        Me.ChBAllDepart.TabIndex = 5
        Me.ChBAllDepart.Text = "All Departments"
        Me.ChBAllDepart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Categories :"
        '
        'CBCate
        '
        Me.CBCate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCate.Enabled = False
        Me.CBCate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CBCate.FormattingEnabled = True
        Me.CBCate.Location = New System.Drawing.Point(140, 113)
        Me.CBCate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBCate.Name = "CBCate"
        Me.CBCate.Size = New System.Drawing.Size(256, 25)
        Me.CBCate.TabIndex = 3
        '
        'ChBAllItem
        '
        Me.ChBAllItem.AutoSize = True
        Me.ChBAllItem.Checked = True
        Me.ChBAllItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBAllItem.Location = New System.Drawing.Point(141, 85)
        Me.ChBAllItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChBAllItem.Name = "ChBAllItem"
        Me.ChBAllItem.Size = New System.Drawing.Size(72, 21)
        Me.ChBAllItem.TabIndex = 2
        Me.ChBAllItem.Text = "All Item"
        Me.ChBAllItem.UseVisualStyleBackColor = True
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ImageSize = New System.Drawing.Size(16, 16)
        Me.RibbonStatusBar1.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ContainerCtr})
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 433)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom
        Me.RibbonStatusBar1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RibbonStatusBar1.ShowToolTips = False
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1183, 22)
        '
        '
        '
        Me.RibbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000
        Me.RibbonStatusBar1.SuperTipComponent.ImageList = Nothing
        Me.RibbonStatusBar1.TabIndex = 4
        Me.RibbonStatusBar1.Text = "RibbonStatusBar1"
        Me.RibbonStatusBar1.UseCompatibleTextRendering = False
        '
        'ContainerCtr
        '
        Me.ContainerCtr.Control = Me.PictureBox3
        Me.ContainerCtr.Key = "ContainerControlCommand1"
        Me.ContainerCtr.Name = "ContainerCtr"
        Me.ContainerCtr.Text = "Loading"
        Me.ContainerCtr.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar1
        Me.PictureBox3.Location = New System.Drawing.Point(50, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'CRVReportViewer
        '
        Me.CRVReportViewer.ActiveViewIndex = -1
        Me.CRVReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportViewer.DisplayGroupTree = False
        Me.CRVReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRVReportViewer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CRVReportViewer.Name = "CRVReportViewer"
        Me.CRVReportViewer.SelectionFormula = ""
        Me.CRVReportViewer.ShowGroupTreeButton = False
        Me.CRVReportViewer.ShowRefreshButton = False
        Me.CRVReportViewer.Size = New System.Drawing.Size(1183, 455)
        Me.CRVReportViewer.TabIndex = 3
        Me.CRVReportViewer.ViewTimeSelectionFormula = ""
        '
        'ErrorCtr
        '
        Me.ErrorCtr.ContainerControl = Me
        '
        'BackgroundLoadReport
        '
        '
        'frmHosItemBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHosItemBalance"
        Me.Text = "Hospital Item Balance"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCtr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CBCate As System.Windows.Forms.ComboBox
    Friend WithEvents ChBAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents BtnViewReport As System.Windows.Forms.Button
    Friend WithEvents CBDepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChBAllDepart As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CRVReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ErrorCtr As System.Windows.Forms.ErrorProvider
    Friend WithEvents RibbonStatusBar1 As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents ContainerCtr As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundLoadReport As System.ComponentModel.BackgroundWorker
End Class
