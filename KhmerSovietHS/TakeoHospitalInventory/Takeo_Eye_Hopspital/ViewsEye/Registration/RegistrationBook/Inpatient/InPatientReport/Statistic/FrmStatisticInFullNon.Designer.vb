<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatisticInFullNon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStatisticInFullNon))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChListSurgery = New System.Windows.Forms.CheckedListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioFull = New System.Windows.Forms.RadioButton
        Me.RadioMore50 = New System.Windows.Forms.RadioButton
        Me.RadioLess50 = New System.Windows.Forms.RadioButton
        Me.RadioNonPay = New System.Windows.Forms.RadioButton
        Me.Rad2 = New System.Windows.Forms.RadioButton
        Me.Rad1 = New System.Windows.Forms.RadioButton
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnResult = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CboMonth = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.CboYear = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupResult = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupOther = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BgPayment = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupResult.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupOther.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(963, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payments for Operations ( Full and Non Person  )"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChListSurgery
        '
        Me.ChListSurgery.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChListSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChListSurgery.FormattingEnabled = True
        Me.ChListSurgery.HorizontalScrollbar = True
        Me.ChListSurgery.Location = New System.Drawing.Point(0, 33)
        Me.ChListSurgery.Name = "ChListSurgery"
        Me.ChListSurgery.Size = New System.Drawing.Size(202, 781)
        Me.ChListSurgery.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictLoading)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Rad2)
        Me.GroupBox1.Controls.Add(Me.Rad1)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnResult)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(202, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 181)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select condition"
        '
        'PictLoading
        '
        Me.PictLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar
        Me.PictLoading.Location = New System.Drawing.Point(14, 152)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(257, 26)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 24
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioFull)
        Me.GroupBox2.Controls.Add(Me.RadioMore50)
        Me.GroupBox2.Controls.Add(Me.RadioLess50)
        Me.GroupBox2.Controls.Add(Me.RadioNonPay)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 76)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condition"
        '
        'RadioFull
        '
        Me.RadioFull.AutoSize = True
        Me.RadioFull.Location = New System.Drawing.Point(7, 19)
        Me.RadioFull.Name = "RadioFull"
        Me.RadioFull.Size = New System.Drawing.Size(112, 17)
        Me.RadioFull.TabIndex = 0
        Me.RadioFull.TabStop = True
        Me.RadioFull.Text = "Full Paying Patient"
        Me.RadioFull.UseVisualStyleBackColor = True
        '
        'RadioMore50
        '
        Me.RadioMore50.AutoSize = True
        Me.RadioMore50.Location = New System.Drawing.Point(7, 46)
        Me.RadioMore50.Name = "RadioMore50"
        Me.RadioMore50.Size = New System.Drawing.Size(256, 17)
        Me.RadioMore50.TabIndex = 0
        Me.RadioMore50.TabStop = True
        Me.RadioMore50.Text = "Partial Paying Patient-$50 or more paid by patient"
        Me.RadioMore50.UseVisualStyleBackColor = True
        '
        'RadioLess50
        '
        Me.RadioLess50.AutoSize = True
        Me.RadioLess50.Location = New System.Drawing.Point(273, 19)
        Me.RadioLess50.Name = "RadioLess50"
        Me.RadioLess50.Size = New System.Drawing.Size(266, 17)
        Me.RadioLess50.TabIndex = 0
        Me.RadioLess50.TabStop = True
        Me.RadioLess50.Text = "Partial Paying Patient -less than $50 paid by patient"
        Me.RadioLess50.UseVisualStyleBackColor = True
        '
        'RadioNonPay
        '
        Me.RadioNonPay.AutoSize = True
        Me.RadioNonPay.Location = New System.Drawing.Point(273, 46)
        Me.RadioNonPay.Name = "RadioNonPay"
        Me.RadioNonPay.Size = New System.Drawing.Size(121, 17)
        Me.RadioNonPay.TabIndex = 0
        Me.RadioNonPay.TabStop = True
        Me.RadioNonPay.Text = "Non Paying Patients"
        Me.RadioNonPay.UseVisualStyleBackColor = True
        '
        'Rad2
        '
        Me.Rad2.AutoSize = True
        Me.Rad2.Location = New System.Drawing.Point(318, 42)
        Me.Rad2.Name = "Rad2"
        Me.Rad2.Size = New System.Drawing.Size(130, 17)
        Me.Rad2.TabIndex = 22
        Me.Rad2.Text = "Show Operation Other"
        Me.Rad2.UseVisualStyleBackColor = True
        '
        'Rad1
        '
        Me.Rad1.AutoSize = True
        Me.Rad1.Checked = True
        Me.Rad1.Location = New System.Drawing.Point(318, 19)
        Me.Rad1.Name = "Rad1"
        Me.Rad1.Size = New System.Drawing.Size(101, 17)
        Me.Rad1.TabIndex = 21
        Me.Rad1.TabStop = True
        Me.Rad1.Text = "Show Operation"
        Me.Rad1.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Location = New System.Drawing.Point(599, 14)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 37)
        Me.BtnClose.TabIndex = 20
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnResult
        '
        Me.BtnResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResult.Location = New System.Drawing.Point(469, 14)
        Me.BtnResult.Name = "BtnResult"
        Me.BtnResult.Size = New System.Drawing.Size(115, 37)
        Me.BtnResult.TabIndex = 19
        Me.BtnResult.Text = "&Result"
        Me.BtnResult.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CboMonth)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.CboYear)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(287, 56)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'CboMonth
        '
        Me.CboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMonth.FormattingEnabled = True
        Me.CboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.CboMonth.Location = New System.Drawing.Point(42, 19)
        Me.CboMonth.Name = "CboMonth"
        Me.CboMonth.Size = New System.Drawing.Size(121, 28)
        Me.CboMonth.TabIndex = 9
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(166, 27)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Year:"
        '
        'CboYear
        '
        Me.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboYear.FormattingEnabled = True
        Me.CboYear.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.CboYear.Location = New System.Drawing.Point(199, 19)
        Me.CboYear.Name = "CboYear"
        Me.CboYear.Size = New System.Drawing.Size(82, 28)
        Me.CboYear.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Month:"
        '
        'GroupResult
        '
        Me.GroupResult.Controls.Add(Me.Label4)
        Me.GroupResult.Controls.Add(Me.Label3)
        Me.GroupResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupResult.Location = New System.Drawing.Point(0, 0)
        Me.GroupResult.Name = "GroupResult"
        Me.GroupResult.Size = New System.Drawing.Size(447, 603)
        Me.GroupResult.TabIndex = 3
        Me.GroupResult.TabStop = False
        Me.GroupResult.Text = "Result"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Operation Type:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(202, 214)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupResult)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupOther)
        Me.SplitContainer1.Size = New System.Drawing.Size(761, 603)
        Me.SplitContainer1.SplitterDistance = 447
        Me.SplitContainer1.TabIndex = 4
        '
        'GroupOther
        '
        Me.GroupOther.Controls.Add(Me.Label5)
        Me.GroupOther.Controls.Add(Me.Label6)
        Me.GroupOther.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupOther.Location = New System.Drawing.Point(0, 0)
        Me.GroupOther.Name = "GroupOther"
        Me.GroupOther.Size = New System.Drawing.Size(310, 603)
        Me.GroupOther.TabIndex = 4
        Me.GroupOther.TabStop = False
        Me.GroupOther.Text = "Result Other"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Operation Type:"
        '
        'BgPayment
        '
        Me.BgPayment.WorkerReportsProgress = True
        Me.BgPayment.WorkerSupportsCancellation = True
        '
        'FrmStatisticInFullNon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 817)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChListSurgery)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStatisticInFullNon"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funll/Non Payment Patient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupResult.ResumeLayout(False)
        Me.GroupResult.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupOther.ResumeLayout(False)
        Me.GroupOther.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChListSurgery As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupResult As System.Windows.Forms.GroupBox
    Friend WithEvents RadioLess50 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMore50 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioFull As System.Windows.Forms.RadioButton
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnResult As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioNonPay As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupOther As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents BgPayment As System.ComponentModel.BackgroundWorker
End Class
