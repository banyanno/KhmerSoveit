<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNewCommune
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FNewCommune))
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.LblDistric = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCommune = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.lblProvince = New System.Windows.Forms.Label
        Me.ErrCommune = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCommuneCode = New System.Windows.Forms.TextBox
        CType(Me.ErrCommune, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(4, 5)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveOption.TabIndex = 0
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'LblDistric
        '
        Me.LblDistric.AutoSize = True
        Me.LblDistric.Location = New System.Drawing.Point(45, 5)
        Me.LblDistric.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDistric.Name = "LblDistric"
        Me.LblDistric.Size = New System.Drawing.Size(16, 17)
        Me.LblDistric.TabIndex = 1
        Me.LblDistric.Text = "0"
        Me.LblDistric.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Commune:"
        '
        'TxtCommune
        '
        Me.TxtCommune.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCommune.Location = New System.Drawing.Point(81, 64)
        Me.TxtCommune.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCommune.Name = "TxtCommune"
        Me.TxtCommune.Size = New System.Drawing.Size(229, 30)
        Me.TxtCommune.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(234, 102)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(76, 31)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(93, 5)
        Me.lblProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(16, 17)
        Me.lblProvince.TabIndex = 5
        Me.lblProvince.Text = "0"
        Me.lblProvince.Visible = False
        '
        'ErrCommune
        '
        Me.ErrCommune.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "C- Code:"
        '
        'TxtCommuneCode
        '
        Me.TxtCommuneCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCommuneCode.Location = New System.Drawing.Point(81, 26)
        Me.TxtCommuneCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCommuneCode.Name = "TxtCommuneCode"
        Me.TxtCommuneCode.Size = New System.Drawing.Size(229, 30)
        Me.TxtCommuneCode.TabIndex = 0
        '
        'FNewCommune
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 141)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtCommuneCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCommune)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDistric)
        Me.Controls.Add(Me.LblSaveOption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FNewCommune"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Commune"
        CType(Me.ErrCommune, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents LblDistric As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCommune As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents ErrCommune As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtCommuneCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
