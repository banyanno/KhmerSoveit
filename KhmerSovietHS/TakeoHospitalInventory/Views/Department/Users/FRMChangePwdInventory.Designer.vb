<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMChangePwdInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMChangePwdInventory))
        Me.TxtVerifyPwd = New System.Windows.Forms.TextBox
        Me.TxtPwd = New System.Windows.Forms.TextBox
        Me.TxtLoginName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnChange = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.ErrChangePWD = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblUserID = New System.Windows.Forms.Label
        CType(Me.ErrChangePWD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtVerifyPwd
        '
        Me.TxtVerifyPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVerifyPwd.Location = New System.Drawing.Point(94, 75)
        Me.TxtVerifyPwd.Name = "TxtVerifyPwd"
        Me.TxtVerifyPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtVerifyPwd.Size = New System.Drawing.Size(204, 26)
        Me.TxtVerifyPwd.TabIndex = 12
        '
        'TxtPwd
        '
        Me.TxtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPwd.Location = New System.Drawing.Point(94, 42)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwd.Size = New System.Drawing.Size(204, 26)
        Me.TxtPwd.TabIndex = 11
        '
        'TxtLoginName
        '
        Me.TxtLoginName.BackColor = System.Drawing.Color.White
        Me.TxtLoginName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoginName.Enabled = False
        Me.TxtLoginName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoginName.Location = New System.Drawing.Point(94, 10)
        Me.TxtLoginName.Name = "TxtLoginName"
        Me.TxtLoginName.ReadOnly = True
        Me.TxtLoginName.Size = New System.Drawing.Size(204, 26)
        Me.TxtLoginName.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Verify Password: *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "New Password: *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Login name: *"
        '
        'BtnChange
        '
        Me.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChange.Location = New System.Drawing.Point(180, 105)
        Me.BtnChange.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(56, 25)
        Me.BtnChange.TabIndex = 15
        Me.BtnChange.Text = "Change"
        Me.BtnChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(241, 105)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(56, 25)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'ErrChangePWD
        '
        Me.ErrChangePWD.ContainerControl = Me
        '
        'LblUserID
        '
        Me.LblUserID.AutoSize = True
        Me.LblUserID.Location = New System.Drawing.Point(31, 118)
        Me.LblUserID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUserID.Name = "LblUserID"
        Me.LblUserID.Size = New System.Drawing.Size(13, 13)
        Me.LblUserID.TabIndex = 16
        Me.LblUserID.Text = "0"
        Me.LblUserID.Visible = False
        '
        'FRMChangePwdInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 133)
        Me.Controls.Add(Me.LblUserID)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnChange)
        Me.Controls.Add(Me.TxtVerifyPwd)
        Me.Controls.Add(Me.TxtPwd)
        Me.Controls.Add(Me.TxtLoginName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMChangePwdInventory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.ErrChangePWD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtVerifyPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxtPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoginName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents ErrChangePWD As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblUserID As System.Windows.Forms.Label
End Class
