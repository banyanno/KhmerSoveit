<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCountGlassesAndMedicine
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnPrintPreviewMedicine = New System.Windows.Forms.Button
        Me.DateToMedicine = New System.Windows.Forms.DateTimePicker
        Me.DateFromMedicine = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CViewerMedicine = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.CViewerMedicine)
        Me.SplitContainer1.Size = New System.Drawing.Size(1369, 743)
        Me.SplitContainer1.SplitterDistance = 205
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreviewMedicine)
        Me.GroupBox1.Controls.Add(Me.DateToMedicine)
        Me.GroupBox1.Controls.Add(Me.DateFromMedicine)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Count Medicine"
        '
        'BtnPrintPreviewMedicine
        '
        Me.BtnPrintPreviewMedicine.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.mZihS
        Me.BtnPrintPreviewMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrintPreviewMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreviewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintPreviewMedicine.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreviewMedicine.Location = New System.Drawing.Point(87, 95)
        Me.BtnPrintPreviewMedicine.Name = "BtnPrintPreviewMedicine"
        Me.BtnPrintPreviewMedicine.Size = New System.Drawing.Size(110, 34)
        Me.BtnPrintPreviewMedicine.TabIndex = 4
        Me.BtnPrintPreviewMedicine.Text = "Print Preview"
        Me.BtnPrintPreviewMedicine.UseVisualStyleBackColor = True
        '
        'DateToMedicine
        '
        Me.DateToMedicine.CustomFormat = "dd-MM-yyyy"
        Me.DateToMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToMedicine.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateToMedicine.Location = New System.Drawing.Point(60, 63)
        Me.DateToMedicine.Name = "DateToMedicine"
        Me.DateToMedicine.Size = New System.Drawing.Size(137, 26)
        Me.DateToMedicine.TabIndex = 3
        '
        'DateFromMedicine
        '
        Me.DateFromMedicine.CustomFormat = "dd-MM-yyyy"
        Me.DateFromMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFromMedicine.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFromMedicine.Location = New System.Drawing.Point(60, 21)
        Me.DateFromMedicine.Name = "DateFromMedicine"
        Me.DateFromMedicine.Size = New System.Drawing.Size(137, 26)
        Me.DateFromMedicine.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'CViewerMedicine
        '
        Me.CViewerMedicine.ActiveViewIndex = -1
        Me.CViewerMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CViewerMedicine.DisplayGroupTree = False
        Me.CViewerMedicine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CViewerMedicine.Location = New System.Drawing.Point(0, 0)
        Me.CViewerMedicine.Name = "CViewerMedicine"
        Me.CViewerMedicine.SelectionFormula = ""
        Me.CViewerMedicine.ShowGroupTreeButton = False
        Me.CViewerMedicine.Size = New System.Drawing.Size(1158, 741)
        Me.CViewerMedicine.TabIndex = 0
        Me.CViewerMedicine.ViewTimeSelectionFormula = ""
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.ForeColor = System.Drawing.Color.Red
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(1371, 772)
        Me.UiTab1.TabIndex = 1
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.SplitContainer1)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1369, 743)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Count Medicince"
        '
        'DashboardCountGlassesAndMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.UiTab1)
        Me.Name = "DashboardCountGlassesAndMedicine"
        Me.Size = New System.Drawing.Size(1371, 772)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateToMedicine As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFromMedicine As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintPreviewMedicine As System.Windows.Forms.Button
    Friend WithEvents CViewerMedicine As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage

End Class
