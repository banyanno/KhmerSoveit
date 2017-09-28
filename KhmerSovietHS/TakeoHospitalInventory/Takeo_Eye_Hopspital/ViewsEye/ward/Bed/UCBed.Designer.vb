<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBed
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCBed))
        Me.GroupFindBed = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtFindRoom = New System.Windows.Forms.TextBox
        Me.GridRoom = New System.Windows.Forms.DataGridView
        Me.RoomNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameRoom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lsBed = New System.Windows.Forms.ListView
        Me.ImgListBed = New System.Windows.Forms.ImageList(Me.components)
        Me.lblBedNo = New System.Windows.Forms.Label
        Me.BtnRoom = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboRoom = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBed = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrBed = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupFindBed.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrBed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupFindBed
        '
        Me.GroupFindBed.Controls.Add(Me.GroupBox1)
        Me.GroupFindBed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFindBed.Location = New System.Drawing.Point(0, 0)
        Me.GroupFindBed.Name = "GroupFindBed"
        Me.GroupFindBed.Size = New System.Drawing.Size(828, 787)
        Me.GroupFindBed.TabIndex = 0
        Me.GroupFindBed.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtFindRoom)
        Me.GroupBox1.Controls.Add(Me.GridRoom)
        Me.GroupBox1.Controls.Add(Me.lsBed)
        Me.GroupBox1.Controls.Add(Me.lblBedNo)
        Me.GroupBox1.Controls.Add(Me.BtnRoom)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.TxtDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CboRoom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 768)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Bed"
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(197, 47)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(75, 29)
        Me.BtnFind.TabIndex = 13
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Room:"
        '
        'TxtFindRoom
        '
        Me.TxtFindRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindRoom.Location = New System.Drawing.Point(51, 50)
        Me.TxtFindRoom.Name = "TxtFindRoom"
        Me.TxtFindRoom.Size = New System.Drawing.Size(140, 26)
        Me.TxtFindRoom.TabIndex = 11
        '
        'GridRoom
        '
        Me.GridRoom.AllowUserToAddRows = False
        Me.GridRoom.AllowUserToDeleteRows = False
        Me.GridRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridRoom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNo, Me.NameRoom, Me.Description})
        Me.GridRoom.Location = New System.Drawing.Point(13, 156)
        Me.GridRoom.Name = "GridRoom"
        Me.GridRoom.ReadOnly = True
        Me.GridRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridRoom.Size = New System.Drawing.Size(351, 537)
        Me.GridRoom.TabIndex = 10
        '
        'RoomNo
        '
        Me.RoomNo.DataPropertyName = "RoomNo"
        Me.RoomNo.HeaderText = "No"
        Me.RoomNo.Name = "RoomNo"
        Me.RoomNo.ReadOnly = True
        '
        'NameRoom
        '
        Me.NameRoom.DataPropertyName = "Name"
        Me.NameRoom.HeaderText = "Name"
        Me.NameRoom.Name = "NameRoom"
        Me.NameRoom.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'lsBed
        '
        Me.lsBed.GridLines = True
        Me.lsBed.LargeImageList = Me.ImgListBed
        Me.lsBed.Location = New System.Drawing.Point(370, 156)
        Me.lsBed.MultiSelect = False
        Me.lsBed.Name = "lsBed"
        Me.lsBed.ShowItemToolTips = True
        Me.lsBed.Size = New System.Drawing.Size(406, 537)
        Me.lsBed.SmallImageList = Me.ImgListBed
        Me.lsBed.TabIndex = 1
        Me.lsBed.UseCompatibleStateImageBehavior = False
        '
        'ImgListBed
        '
        Me.ImgListBed.ImageStream = CType(resources.GetObject("ImgListBed.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListBed.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListBed.Images.SetKeyName(0, "bed_nofree.jpg")
        Me.ImgListBed.Images.SetKeyName(1, "bed_free.jpg")
        '
        'lblBedNo
        '
        Me.lblBedNo.AutoSize = True
        Me.lblBedNo.Location = New System.Drawing.Point(619, 33)
        Me.lblBedNo.Name = "lblBedNo"
        Me.lblBedNo.Size = New System.Drawing.Size(13, 13)
        Me.lblBedNo.TabIndex = 9
        Me.lblBedNo.Text = "0"
        '
        'BtnRoom
        '
        Me.BtnRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRoom.Location = New System.Drawing.Point(564, 57)
        Me.BtnRoom.Name = "BtnRoom"
        Me.BtnRoom.Size = New System.Drawing.Size(24, 25)
        Me.BtnRoom.TabIndex = 7
        Me.BtnRoom.Text = "..."
        Me.BtnRoom.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(742, 37)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(63, 33)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(440, 90)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(336, 54)
        Me.TxtDescription.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description:"
        '
        'CboRoom
        '
        Me.CboRoom.FormattingEnabled = True
        Me.CboRoom.Location = New System.Drawing.Point(440, 59)
        Me.CboRoom.Name = "CboRoom"
        Me.CboRoom.Size = New System.Drawing.Size(121, 21)
        Me.CboRoom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room:"
        '
        'txtBed
        '
        Me.txtBed.Location = New System.Drawing.Point(440, 30)
        Me.txtBed.Name = "txtBed"
        Me.txtBed.Size = New System.Drawing.Size(121, 20)
        Me.txtBed.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bed Number:"
        '
        'ErrBed
        '
        Me.ErrBed.ContainerControl = Me
        '
        'UCBed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupFindBed)
        Me.Name = "UCBed"
        Me.Size = New System.Drawing.Size(828, 787)
        Me.GroupFindBed.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrBed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupFindBed As System.Windows.Forms.GroupBox
    Friend WithEvents lsBed As System.Windows.Forms.ListView
    Friend WithEvents ImgListBed As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboRoom As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBed As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnRoom As System.Windows.Forms.Button
    Friend WithEvents ErrBed As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblBedNo As System.Windows.Forms.Label
    Friend WithEvents GridRoom As System.Windows.Forms.DataGridView
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFindRoom As System.Windows.Forms.TextBox
    Friend WithEvents RoomNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameRoom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
