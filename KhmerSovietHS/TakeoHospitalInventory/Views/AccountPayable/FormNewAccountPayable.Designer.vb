<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewAccountPayable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewAccountPayable))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboAccountName = New System.Windows.Forms.ComboBox
        Me.DatePaidAble = New System.Windows.Forms.DateTimePicker
        Me.TxtAmountDolar = New System.Windows.Forms.TextBox
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrPayable = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.TxtAmountRiel = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ChDolar = New System.Windows.Forms.CheckBox
        Me.ChRiel = New System.Windows.Forms.CheckBox
        CType(Me.ErrPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date Paid:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount Dolar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Description:"
        '
        'CboAccountName
        '
        Me.CboAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAccountName.FormattingEnabled = True
        Me.CboAccountName.Location = New System.Drawing.Point(92, 6)
        Me.CboAccountName.Name = "CboAccountName"
        Me.CboAccountName.Size = New System.Drawing.Size(200, 28)
        Me.CboAccountName.TabIndex = 0
        '
        'DatePaidAble
        '
        Me.DatePaidAble.Checked = False
        Me.DatePaidAble.CustomFormat = "dd/MM/yyyy"
        Me.DatePaidAble.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePaidAble.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePaidAble.Location = New System.Drawing.Point(92, 42)
        Me.DatePaidAble.Name = "DatePaidAble"
        Me.DatePaidAble.ShowCheckBox = True
        Me.DatePaidAble.Size = New System.Drawing.Size(157, 26)
        Me.DatePaidAble.TabIndex = 1
        '
        'TxtAmountDolar
        '
        Me.TxtAmountDolar.Enabled = False
        Me.TxtAmountDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmountDolar.Location = New System.Drawing.Point(92, 76)
        Me.TxtAmountDolar.Name = "TxtAmountDolar"
        Me.TxtAmountDolar.Size = New System.Drawing.Size(200, 26)
        Me.TxtAmountDolar.TabIndex = 2
        Me.TxtAmountDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(92, 140)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(200, 31)
        Me.TxtDescription.TabIndex = 6
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(136, 178)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(217, 178)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrPayable
        '
        Me.ErrPayable.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(33, 182)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 10
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'TxtAmountRiel
        '
        Me.TxtAmountRiel.Enabled = False
        Me.TxtAmountRiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmountRiel.Location = New System.Drawing.Point(92, 108)
        Me.TxtAmountRiel.Name = "TxtAmountRiel"
        Me.TxtAmountRiel.Size = New System.Drawing.Size(200, 26)
        Me.TxtAmountRiel.TabIndex = 4
        Me.TxtAmountRiel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Amount Riel:"
        '
        'ChDolar
        '
        Me.ChDolar.AutoSize = True
        Me.ChDolar.Location = New System.Drawing.Point(298, 83)
        Me.ChDolar.Name = "ChDolar"
        Me.ChDolar.Size = New System.Drawing.Size(50, 17)
        Me.ChDolar.TabIndex = 3
        Me.ChDolar.Text = "US $"
        Me.ChDolar.UseVisualStyleBackColor = True
        '
        'ChRiel
        '
        Me.ChRiel.AutoSize = True
        Me.ChRiel.Location = New System.Drawing.Point(298, 115)
        Me.ChRiel.Name = "ChRiel"
        Me.ChRiel.Size = New System.Drawing.Size(55, 17)
        Me.ChRiel.TabIndex = 5
        Me.ChRiel.Text = "Riel R"
        Me.ChRiel.UseVisualStyleBackColor = True
        '
        'FormNewAccountPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 205)
        Me.Controls.Add(Me.ChRiel)
        Me.Controls.Add(Me.ChDolar)
        Me.Controls.Add(Me.TxtAmountRiel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.TxtAmountDolar)
        Me.Controls.Add(Me.DatePaidAble)
        Me.Controls.Add(Me.CboAccountName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormNewAccountPayable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payable"
        CType(Me.ErrPayable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboAccountName As System.Windows.Forms.ComboBox
    Friend WithEvents DatePaidAble As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtAmountDolar As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrPayable As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents TxtAmountRiel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChRiel As System.Windows.Forms.CheckBox
    Friend WithEvents ChDolar As System.Windows.Forms.CheckBox
End Class
