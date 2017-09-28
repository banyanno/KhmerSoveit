<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPrescription))
        Me.BtnRemovePrescription = New System.Windows.Forms.Button
        Me.BtnAddPrescription = New System.Windows.Forms.Button
        Me.CboDuration = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.TxtUsage = New System.Windows.Forms.ComboBox
        Me.cbomedicine = New System.Windows.Forms.ComboBox
        Me.TxtQTY = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.LblPrice = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtdosage = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ErrConsult = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrConsult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRemovePrescription
        '
        Me.BtnRemovePrescription.BackColor = System.Drawing.Color.Transparent
        Me.BtnRemovePrescription.BackgroundImage = CType(resources.GetObject("BtnRemovePrescription.BackgroundImage"), System.Drawing.Image)
        Me.BtnRemovePrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRemovePrescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemovePrescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRemovePrescription.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemovePrescription.ForeColor = System.Drawing.Color.White
        Me.BtnRemovePrescription.Location = New System.Drawing.Point(295, 244)
        Me.BtnRemovePrescription.Name = "BtnRemovePrescription"
        Me.BtnRemovePrescription.Size = New System.Drawing.Size(92, 34)
        Me.BtnRemovePrescription.TabIndex = 72
        Me.BtnRemovePrescription.Text = "Cancel"
        Me.BtnRemovePrescription.UseVisualStyleBackColor = False
        '
        'BtnAddPrescription
        '
        Me.BtnAddPrescription.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddPrescription.BackgroundImage = CType(resources.GetObject("BtnAddPrescription.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddPrescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddPrescription.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPrescription.ForeColor = System.Drawing.Color.White
        Me.BtnAddPrescription.Location = New System.Drawing.Point(197, 244)
        Me.BtnAddPrescription.Name = "BtnAddPrescription"
        Me.BtnAddPrescription.Size = New System.Drawing.Size(92, 34)
        Me.BtnAddPrescription.TabIndex = 71
        Me.BtnAddPrescription.Text = "Update"
        Me.BtnAddPrescription.UseVisualStyleBackColor = False
        '
        'CboDuration
        '
        Me.CboDuration.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.CboDuration.FormattingEnabled = True
        Me.CboDuration.Location = New System.Drawing.Point(113, 189)
        Me.CboDuration.Name = "CboDuration"
        Me.CboDuration.Size = New System.Drawing.Size(232, 32)
        Me.CboDuration.TabIndex = 81
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(18, 203)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(68, 18)
        Me.Label36.TabIndex = 87
        Me.Label36.Text = "Duration:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(188, 71)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 18)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "Price $:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUsage
        '
        Me.TxtUsage.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.TxtUsage.FormattingEnabled = True
        Me.TxtUsage.Location = New System.Drawing.Point(113, 144)
        Me.TxtUsage.Name = "TxtUsage"
        Me.TxtUsage.Size = New System.Drawing.Size(232, 32)
        Me.TxtUsage.TabIndex = 79
        '
        'cbomedicine
        '
        Me.cbomedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomedicine.DropDownWidth = 500
        Me.cbomedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbomedicine.FormattingEnabled = True
        Me.cbomedicine.Location = New System.Drawing.Point(113, 23)
        Me.cbomedicine.Name = "cbomedicine"
        Me.cbomedicine.Size = New System.Drawing.Size(232, 28)
        Me.cbomedicine.TabIndex = 73
        '
        'TxtQTY
        '
        Me.TxtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQTY.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTY.Location = New System.Drawing.Point(113, 62)
        Me.TxtQTY.Name = "TxtQTY"
        Me.TxtQTY.Size = New System.Drawing.Size(69, 27)
        Me.TxtQTY.TabIndex = 76
        Me.TxtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(18, 71)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(76, 18)
        Me.Label35.TabIndex = 83
        Me.Label35.Text = "Qty Use *:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(246, 71)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(16, 18)
        Me.LblPrice.TabIndex = 85
        Me.LblPrice.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Medicince *:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(18, 158)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 18)
        Me.Label28.TabIndex = 74
        Me.Label28.Text = "Usage *:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdosage
        '
        Me.txtdosage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtdosage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtdosage.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdosage.FormattingEnabled = True
        Me.txtdosage.Location = New System.Drawing.Point(113, 99)
        Me.txtdosage.Name = "txtdosage"
        Me.txtdosage.Size = New System.Drawing.Size(232, 32)
        Me.txtdosage.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(18, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 18)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "On Eye *:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbomedicine)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtdosage)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.CboDuration)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.LblPrice)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.TxtUsage)
        Me.GroupBox1.Controls.Add(Me.TxtQTY)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 232)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prescription"
        '
        'ErrConsult
        '
        Me.ErrConsult.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(36, 260)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(39, 13)
        Me.LblSaveOption.TabIndex = 89
        Me.LblSaveOption.Text = "Label1"
        Me.LblSaveOption.Visible = False
        '
        'EditPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(394, 283)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRemovePrescription)
        Me.Controls.Add(Me.BtnAddPrescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditPrescription"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrConsult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRemovePrescription As System.Windows.Forms.Button
    Friend WithEvents BtnAddPrescription As System.Windows.Forms.Button
    Friend WithEvents CboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TxtUsage As System.Windows.Forms.ComboBox
    Friend WithEvents cbomedicine As System.Windows.Forms.ComboBox
    Friend WithEvents TxtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtdosage As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrConsult As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
End Class
