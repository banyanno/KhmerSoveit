<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemOutsideHospital
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemOutsideHospital))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorItemOutsideHospital = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Department = New System.Windows.Forms.Label
        Me.LbDepartName = New System.Windows.Forms.Label
        Me.lblSaveOption = New System.Windows.Forms.Label
        Me.TxtHiddenItemName = New System.Windows.Forms.Label
        Me.cbItemContainer = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbLabourFac = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.ErrorItemOutsideHospital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(322, 158)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 42)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.btnSave.Location = New System.Drawing.Point(233, 158)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 42)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TxtItemName
        '
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtItemName.Location = New System.Drawing.Point(117, 54)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(298, 26)
        Me.TxtItemName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Item Name * :"
        '
        'ErrorItemOutsideHospital
        '
        Me.ErrorItemOutsideHospital.ContainerControl = Me
        '
        'Department
        '
        Me.Department.AutoSize = True
        Me.Department.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.Location = New System.Drawing.Point(25, 29)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(77, 20)
        Me.Department.TabIndex = 23
        Me.Department.Text = "Department"
        '
        'LbDepartName
        '
        Me.LbDepartName.AutoSize = True
        Me.LbDepartName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDepartName.ForeColor = System.Drawing.Color.Blue
        Me.LbDepartName.Location = New System.Drawing.Point(108, 29)
        Me.LbDepartName.Name = "LbDepartName"
        Me.LbDepartName.Size = New System.Drawing.Size(49, 20)
        Me.LbDepartName.TabIndex = 24
        Me.LbDepartName.Text = "Label2"
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.Location = New System.Drawing.Point(22, 174)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.lblSaveOption.TabIndex = 25
        Me.lblSaveOption.Text = "0"
        Me.lblSaveOption.Visible = False
        '
        'TxtHiddenItemName
        '
        Me.TxtHiddenItemName.AutoSize = True
        Me.TxtHiddenItemName.Location = New System.Drawing.Point(53, 174)
        Me.TxtHiddenItemName.Name = "TxtHiddenItemName"
        Me.TxtHiddenItemName.Size = New System.Drawing.Size(13, 13)
        Me.TxtHiddenItemName.TabIndex = 26
        Me.TxtHiddenItemName.Text = "1"
        Me.TxtHiddenItemName.Visible = False
        '
        'cbItemContainer
        '
        Me.cbItemContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItemContainer.FormattingEnabled = True
        Me.cbItemContainer.Location = New System.Drawing.Point(117, 86)
        Me.cbItemContainer.Name = "cbItemContainer"
        Me.cbItemContainer.Size = New System.Drawing.Size(298, 28)
        Me.cbItemContainer.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Item Containing : "
        '
        'cbLabourFac
        '
        Me.cbLabourFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbLabourFac.FormattingEnabled = True
        Me.cbLabourFac.Location = New System.Drawing.Point(117, 120)
        Me.cbLabourFac.Name = "cbLabourFac"
        Me.cbLabourFac.Size = New System.Drawing.Size(298, 28)
        Me.cbLabourFac.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Laboratory : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmItemOutsideHospital
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 218)
        Me.Controls.Add(Me.cbItemContainer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbLabourFac)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtHiddenItemName)
        Me.Controls.Add(Me.lblSaveOption)
        Me.Controls.Add(Me.LbDepartName)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtItemName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmItemOutsideHospital"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Outside Hospital"
        CType(Me.ErrorItemOutsideHospital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorItemOutsideHospital As System.Windows.Forms.ErrorProvider
    Friend WithEvents Department As System.Windows.Forms.Label
    Friend WithEvents LbDepartName As System.Windows.Forms.Label
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents TxtHiddenItemName As System.Windows.Forms.Label
    Friend WithEvents cbItemContainer As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbLabourFac As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
