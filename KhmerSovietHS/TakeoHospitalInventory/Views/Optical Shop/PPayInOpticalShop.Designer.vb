<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPayInOpticalShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPayInOpticalShop))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadSocial = New System.Windows.Forms.RadioButton
        Me.RadNil = New System.Windows.Forms.RadioButton
        Me.RadFull = New System.Windows.Forms.RadioButton
        Me.RadAllPay = New System.Windows.Forms.RadioButton
        Me.DatePayTo = New System.Windows.Forms.DateTimePicker
        Me.DatePayFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CRVOpticalPayment = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.CRVOpticalPayment)
        Me.SplitContainer1.Size = New System.Drawing.Size(894, 416)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DatePayTo)
        Me.GroupBox1.Controls.Add(Me.DatePayFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 416)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optical Shop Payment"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(100, 157)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(95, 26)
        Me.BtnPrintPreview.TabIndex = 5
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RadSocial)
        Me.GroupBox2.Controls.Add(Me.RadNil)
        Me.GroupBox2.Controls.Add(Me.RadFull)
        Me.GroupBox2.Controls.Add(Me.RadAllPay)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 70)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Payment As"
        '
        'RadSocial
        '
        Me.RadSocial.AutoSize = True
        Me.RadSocial.Location = New System.Drawing.Point(124, 19)
        Me.RadSocial.Name = "RadSocial"
        Me.RadSocial.Size = New System.Drawing.Size(54, 17)
        Me.RadSocial.TabIndex = 3
        Me.RadSocial.Text = "Social"
        Me.RadSocial.UseVisualStyleBackColor = True
        '
        'RadNil
        '
        Me.RadNil.AutoSize = True
        Me.RadNil.Location = New System.Drawing.Point(124, 42)
        Me.RadNil.Name = "RadNil"
        Me.RadNil.Size = New System.Drawing.Size(37, 17)
        Me.RadNil.TabIndex = 2
        Me.RadNil.Text = "Nil"
        Me.RadNil.UseVisualStyleBackColor = True
        '
        'RadFull
        '
        Me.RadFull.AutoSize = True
        Me.RadFull.Checked = True
        Me.RadFull.Location = New System.Drawing.Point(6, 19)
        Me.RadFull.Name = "RadFull"
        Me.RadFull.Size = New System.Drawing.Size(44, 17)
        Me.RadFull.TabIndex = 1
        Me.RadFull.TabStop = True
        Me.RadFull.Text = "Full "
        Me.RadFull.UseVisualStyleBackColor = True
        '
        'RadAllPay
        '
        Me.RadAllPay.AutoSize = True
        Me.RadAllPay.Location = New System.Drawing.Point(6, 42)
        Me.RadAllPay.Name = "RadAllPay"
        Me.RadAllPay.Size = New System.Drawing.Size(57, 17)
        Me.RadAllPay.TabIndex = 0
        Me.RadAllPay.Text = "All Pay"
        Me.RadAllPay.UseVisualStyleBackColor = True
        Me.RadAllPay.Visible = False
        '
        'DatePayTo
        '
        Me.DatePayTo.CustomFormat = "dd/MM/yyyy"
        Me.DatePayTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePayTo.Location = New System.Drawing.Point(51, 52)
        Me.DatePayTo.Name = "DatePayTo"
        Me.DatePayTo.Size = New System.Drawing.Size(145, 23)
        Me.DatePayTo.TabIndex = 3
        '
        'DatePayFrom
        '
        Me.DatePayFrom.CustomFormat = "dd/MM/yyyy"
        Me.DatePayFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePayFrom.Location = New System.Drawing.Point(51, 20)
        Me.DatePayFrom.Name = "DatePayFrom"
        Me.DatePayFrom.Size = New System.Drawing.Size(145, 23)
        Me.DatePayFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'CRVOpticalPayment
        '
        Me.CRVOpticalPayment.ActiveViewIndex = -1
        Me.CRVOpticalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVOpticalPayment.DisplayGroupTree = False
        Me.CRVOpticalPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVOpticalPayment.Location = New System.Drawing.Point(0, 0)
        Me.CRVOpticalPayment.Name = "CRVOpticalPayment"
        Me.CRVOpticalPayment.SelectionFormula = ""
        Me.CRVOpticalPayment.ShowGroupTreeButton = False
        Me.CRVOpticalPayment.Size = New System.Drawing.Size(684, 416)
        Me.CRVOpticalPayment.TabIndex = 0
        Me.CRVOpticalPayment.ViewTimeSelectionFormula = ""
        '
        'PPayInOpticalShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 416)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PPayInOpticalShop"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Optical Report Payment"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DatePayFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DatePayTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadSocial As System.Windows.Forms.RadioButton
    Friend WithEvents RadNil As System.Windows.Forms.RadioButton
    Friend WithEvents RadFull As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllPay As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents CRVOpticalPayment As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
