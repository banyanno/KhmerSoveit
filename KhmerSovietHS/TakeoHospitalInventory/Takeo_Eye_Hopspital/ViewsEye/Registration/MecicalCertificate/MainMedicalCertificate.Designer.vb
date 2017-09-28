<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMedicalCertificate
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
        Dim GridMedicalCertificate_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMedicalCertificate))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewMedicalCertificate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDr = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMedicalCertificate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefesh = New System.Windows.Forms.ToolStripButton
        Me.GridMedicalCertificate = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.BtnView = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.BGLoadingData = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridMedicalCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewMedicalCertificate, Me.ToolStripSeparator1, Me.BtnDr, Me.ToolStripSeparator2, Me.BtnMedicalCertificate, Me.ToolStripSeparator3, Me.BtnRefesh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1066, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewMedicalCertificate
        '
        Me.BtnNewMedicalCertificate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Certificate1
        Me.BtnNewMedicalCertificate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewMedicalCertificate.Name = "BtnNewMedicalCertificate"
        Me.BtnNewMedicalCertificate.Size = New System.Drawing.Size(147, 28)
        Me.BtnNewMedicalCertificate.Text = "New Medical Certificate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BtnDr
        '
        Me.BtnDr.Image = Global.TakeoHospitalInventory.My.Resources.Resources.dokter
        Me.BtnDr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDr.Name = "BtnDr"
        Me.BtnDr.Size = New System.Drawing.Size(105, 28)
        Me.BtnDr.Text = "Dr Prescription"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BtnMedicalCertificate
        '
        Me.BtnMedicalCertificate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.MedicalCertificate
        Me.BtnMedicalCertificate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMedicalCertificate.Name = "BtnMedicalCertificate"
        Me.BtnMedicalCertificate.Size = New System.Drawing.Size(147, 28)
        Me.BtnMedicalCertificate.Text = "Give Medical Certificate"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'BtnRefesh
        '
        Me.BtnRefesh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefesh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefesh.Name = "BtnRefesh"
        Me.BtnRefesh.Size = New System.Drawing.Size(73, 28)
        Me.BtnRefesh.Text = "Refresh"
        '
        'GridMedicalCertificate
        '
        Me.GridMedicalCertificate.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMedicalCertificate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridMedicalCertificate_DesignTimeLayout.LayoutString = resources.GetString("GridMedicalCertificate_DesignTimeLayout.LayoutString")
        Me.GridMedicalCertificate.DesignTimeLayout = GridMedicalCertificate_DesignTimeLayout
        Me.GridMedicalCertificate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMedicalCertificate.GroupByBoxVisible = False
        Me.GridMedicalCertificate.HeaderFormatStyle.FontSize = 12.0!
        Me.GridMedicalCertificate.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridMedicalCertificate.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridMedicalCertificate.Location = New System.Drawing.Point(3, 81)
        Me.GridMedicalCertificate.Name = "GridMedicalCertificate"
        Me.GridMedicalCertificate.RecordNavigator = True
        Me.GridMedicalCertificate.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridMedicalCertificate.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.White
        Me.GridMedicalCertificate.Size = New System.Drawing.Size(1060, 465)
        Me.GridMedicalCertificate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(498, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(340, 43)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(150, 26)
        Me.DFrom.TabIndex = 4
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(527, 43)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(150, 26)
        Me.DateTo.TabIndex = 5
        '
        'BtnView
        '
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.Location = New System.Drawing.Point(698, 42)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(78, 26)
        Me.BtnView.TabIndex = 6
        Me.BtnView.Text = "View Data"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Patient No:"
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(80, 43)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(207, 26)
        Me.TxtPatientNo.TabIndex = 8
        '
        'BGLoadingData
        '
        '
        'MainMedicalCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtPatientNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridMedicalCertificate)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "MainMedicalCertificate"
        Me.Size = New System.Drawing.Size(1066, 549)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridMedicalCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewMedicalCertificate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDr As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridMedicalCertificate As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnMedicalCertificate As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents BGLoadingData As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefesh As System.Windows.Forms.ToolStripButton

End Class
