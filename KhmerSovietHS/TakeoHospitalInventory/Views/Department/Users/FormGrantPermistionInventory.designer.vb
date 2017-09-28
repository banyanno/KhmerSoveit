<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGrantPermistionInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGrantPermistionInventory))
        Dim GridPermistion2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPermistion1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ImgPermistion = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtGroupName = New System.Windows.Forms.Label
        Me.LblGroupID = New System.Windows.Forms.Label
        Me.GridPermistion2 = New Janus.Windows.GridEX.GridEX
        Me.GridPermistion1 = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnGrand = New Janus.Windows.EditControls.UIButton
        Me.BtnRevoke = New Janus.Windows.EditControls.UIButton
        CType(Me.GridPermistion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPermistion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImgPermistion
        '
        Me.ImgPermistion.ImageStream = CType(resources.GetObject("ImgPermistion.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgPermistion.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgPermistion.Images.SetKeyName(0, "1316418719_button-check_red.png")
        Me.ImgPermistion.Images.SetKeyName(1, "Aproved.gif")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Group Name:"
        '
        'TxtGroupName
        '
        Me.TxtGroupName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroupName.Location = New System.Drawing.Point(117, 26)
        Me.TxtGroupName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtGroupName.Name = "TxtGroupName"
        Me.TxtGroupName.Size = New System.Drawing.Size(899, 55)
        Me.TxtGroupName.TabIndex = 5
        '
        'LblGroupID
        '
        Me.LblGroupID.AutoSize = True
        Me.LblGroupID.Location = New System.Drawing.Point(502, 114)
        Me.LblGroupID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGroupID.Name = "LblGroupID"
        Me.LblGroupID.Size = New System.Drawing.Size(18, 20)
        Me.LblGroupID.TabIndex = 6
        Me.LblGroupID.Text = "0"
        Me.LblGroupID.Visible = False
        '
        'GridPermistion2
        '
        Me.GridPermistion2.BackgroundImage = CType(resources.GetObject("GridPermistion2.BackgroundImage"), System.Drawing.Image)
        Me.GridPermistion2.BackgroundImageDrawMode = Janus.Windows.GridEX.BackgroundImageDrawMode.Stretch
        GridPermistion2_DesignTimeLayout.LayoutString = resources.GetString("GridPermistion2_DesignTimeLayout.LayoutString")
        Me.GridPermistion2.DesignTimeLayout = GridPermistion2_DesignTimeLayout
        Me.GridPermistion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPermistion2.GroupByBoxVisible = False
        Me.GridPermistion2.ImageList = Me.ImgPermistion
        Me.GridPermistion2.Location = New System.Drawing.Point(558, 101)
        Me.GridPermistion2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridPermistion2.Name = "GridPermistion2"
        Me.GridPermistion2.RecordNavigator = True
        Me.GridPermistion2.Size = New System.Drawing.Size(469, 488)
        Me.GridPermistion2.TabIndex = 1
        Me.GridPermistion2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GridPermistion1
        '
        Me.GridPermistion1.BackgroundImage = CType(resources.GetObject("GridPermistion1.BackgroundImage"), System.Drawing.Image)
        Me.GridPermistion1.BackgroundImageDrawMode = Janus.Windows.GridEX.BackgroundImageDrawMode.Stretch
        GridPermistion1_DesignTimeLayout.LayoutString = resources.GetString("GridPermistion1_DesignTimeLayout.LayoutString")
        Me.GridPermistion1.DesignTimeLayout = GridPermistion1_DesignTimeLayout
        Me.GridPermistion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPermistion1.GroupByBoxVisible = False
        Me.GridPermistion1.ImageList = Me.ImgPermistion
        Me.GridPermistion1.Location = New System.Drawing.Point(3, 101)
        Me.GridPermistion1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridPermistion1.Name = "GridPermistion1"
        Me.GridPermistion1.RecordNavigator = True
        Me.GridPermistion1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPermistion1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPermistion1.Size = New System.Drawing.Size(467, 488)
        Me.GridPermistion1.TabIndex = 1
        Me.GridPermistion1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtGroupName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1030, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Department Information"
        '
        'BtnGrand
        '
        Me.BtnGrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGrand.Location = New System.Drawing.Point(477, 205)
        Me.BtnGrand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGrand.Name = "BtnGrand"
        Me.BtnGrand.Size = New System.Drawing.Size(74, 48)
        Me.BtnGrand.TabIndex = 2
        Me.BtnGrand.Text = ">>"
        Me.BtnGrand.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BtnRevoke
        '
        Me.BtnRevoke.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRevoke.Location = New System.Drawing.Point(477, 266)
        Me.BtnRevoke.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRevoke.Name = "BtnRevoke"
        Me.BtnRevoke.Size = New System.Drawing.Size(74, 48)
        Me.BtnRevoke.TabIndex = 2
        Me.BtnRevoke.Text = "<<"
        Me.BtnRevoke.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'FormGrantPermistionInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1030, 601)
        Me.Controls.Add(Me.LblGroupID)
        Me.Controls.Add(Me.BtnRevoke)
        Me.Controls.Add(Me.BtnGrand)
        Me.Controls.Add(Me.GridPermistion2)
        Me.Controls.Add(Me.GridPermistion1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGrantPermistionInventory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grant Permistion"
        CType(Me.GridPermistion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPermistion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImgPermistion As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtGroupName As System.Windows.Forms.Label
    Friend WithEvents LblGroupID As System.Windows.Forms.Label
    Friend WithEvents GridPermistion2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridPermistion1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGrand As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnRevoke As Janus.Windows.EditControls.UIButton
End Class
