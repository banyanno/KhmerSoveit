Public Class UCMainVA
    Dim fVA As FRMPatientVA
    Dim PatientNo As Integer = 0
    Dim PatientEngName As String
    Dim PateintKhmerName As String
    Dim ValueInputBox As String
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CboMonth.SelectedIndex = 0
        CboYear.SelectedIndex = 0
        For i As Integer = 0 To 100
            CboAge1.Items.Add(i)
        Next
        CboAge1.SelectedIndex = 0

        For i As Integer = 0 To 100
            CboAge2.Items.Add(i)
        Next
        CboAge2.SelectedIndex = 0
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub LoadVAPatient(ByVal PatientNo As String)
        GridVAFollowUpRight.DataSource = ModV_A.SelectVAByPatientNoR(PatientNo)
        GridVAFollowUpLeft.DataSource = ModV_A.SelectVAByPatientNoL(PatientNo)
    End Sub

    Sub LoadVAFind()
        ' Dim TblPatient As DataTable = ModRegistration.GetPatientByNo(EmptyString(TxtPatientNo.Text))
        'Dim DRow As DataRow
        'If TblPatient.Rows.Count > 0 Then
        '    For i As Integer = 0 To TblPatient.Rows.Count - 1
        '        DRow = TblPatient.Rows(i)
        '        'TxtPatientNo.Text = DRow("PatientNo").ToString
        '        TxtEngName.Text = DRow("NameEng").ToString
        '        TxtKhName.Text = DRow("NameKhmer").ToString
        '        TxtAge.Text = DRow("Age").ToString
        '        TxtSex.Text = DRow("Sex").ToString
        '        TxtAddress.Text = DRow("Address").ToString
        '    Next
        '    LoadVAPatient(EmptyString(TxtPatientNo.Text))
        'Else
        '    MsgBox("Patient No does not exist in system.", MsgBoxStyle.Critical, "Error")
        '    TxtEngName.Text = ""
        '    TxtKhName.Text = ""
        '    TxtAge.Text = ""
        '    TxtSex.Text = ""
        '    TxtAddress.Text = ""
        '    TxtPatientNo.Focus()
        '    LoadVAPatient(EmptyString(TxtPatientNo.Text))
        'End If
    End Sub
    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub GridVAFollowUpRight_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVAFollowUpRight.DoubleClick
      

    End Sub

    Private Sub DeleteVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteVAToolStripMenuItem.Click
        Try
            Dim VANo As String = GridVAFollowUpRight.SelectedItems(0).GetRow.Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModV_A.DeleteVA(VANo) = 1 Then
                    MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                    'Me.LoadVAPatient(EmptyString(TxtPatientNo.Text))
                Else
                    MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            LoadVAFind()
        End If
    End Sub

    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Me.rdRightEye.Checked = True Then
            GridPlain.DataSource = ModV_A.VAStatisticR(CboMonth.SelectedIndex + 1, CboYear.Text, "PlainCat", CboAge1.Text, CboAge2.Text)
            GridPH.DataSource = ModV_A.VAStatisticR(CboMonth.SelectedIndex + 1, CboYear.Text, "PHCate", CboAge1.Text, CboAge2.Text)
            GridGlasses.DataSource = ModV_A.VAStatisticR(CboMonth.SelectedIndex + 1, CboYear.Text, "GCate", CboAge1.Text, CboAge2.Text)
        Else
            GridPlain.DataSource = ModV_A.VAStatistic(CboMonth.SelectedIndex + 1, CboYear.Text, "PlainCat", CboAge1.Text, CboAge2.Text)
            GridPH.DataSource = ModV_A.VAStatistic(CboMonth.SelectedIndex + 1, CboYear.Text, "PHCate", CboAge1.Text, CboAge2.Text)
            GridGlasses.DataSource = ModV_A.VAStatistic(CboMonth.SelectedIndex + 1, CboYear.Text, "GCate", CboAge1.Text, CboAge2.Text)
        End If

    End Sub


    Private Sub GridVAFollowUpLeft_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVAFollowUpLeft.DoubleClick
       
    End Sub

    Sub BindVA(ByVal Sender As System.Object, ByVal e As System.EventArgs)
        Dim fPatientVA As New FRMPatientVA

        Try

            Dim VaNo As String = GridVAFollowUpRight.GetRow.Cells(0).Value
            Dim PatientNo As String = GridVAFollowUpRight.GetRow.Cells(1).Value
            Dim PlainVA As String = GridVAFollowUpRight.GetRow.Cells(2).Value
            Dim PlainValue As String = GridVAFollowUpRight.GetRow.Cells(3).Value
            Dim PlainCate As String = GridVAFollowUpRight.GetRow.Cells(4).Value
            Dim PHVA As String = GridVAFollowUpRight.GetRow.Cells(5).Value
            Dim PHValue As String = GridVAFollowUpRight.GetRow.Cells(6).Value
            Dim PHCate As String = GridVAFollowUpRight.GetRow.Cells(7).Value
            Dim GVA As String = GridVAFollowUpRight.GetRow.Cells(8).Value
            Dim GValue As String = GridVAFollowUpRight.GetRow.Cells(9).Value
            Dim GCate As String = GridVAFollowUpRight.GetRow.Cells(10).Value
            Dim DateTime As String = GridVAFollowUpRight.GetRow.Cells(11).Value
            fPatientVA.LoadPatientInfo(PatientNo)
            fPatientVA.LblSaveOption.Text = PatientNo
            fPatientVA.TxtPatientNo.Text = PatientNo
            fPatientVA.TrackPlainRightEye.Value = PlainVA
            fPatientVA.LblPlainRight.Text = PlainValue
            fPatientVA.lblCatPlainRight.Text = PlainCate

            fPatientVA.TrackPHRightEye.Value = PHVA
            fPatientVA.LblPHRight.Text = PHValue
            fPatientVA.LblCatPHRight.Text = PHCate

            fPatientVA.TrackGlassesRightEye.Value = GVA
            fPatientVA.LblGlassesRight.Text = GValue
            fPatientVA.LblCatGlassesRight.Text = GCate
            fPatientVA.DateVA.Value = DateTime

        Catch ex As Exception

        End Try
        ' VA Left 
        Try

            Dim PatientNo As String = GridVAFollowUpLeft.GetRow.Cells(1).Value
            Dim PlainVA As String = GridVAFollowUpLeft.GetRow.Cells(2).Value
            Dim PlainValue As String = GridVAFollowUpLeft.GetRow.Cells(3).Value
            Dim PlainCate As String = GridVAFollowUpLeft.GetRow.Cells(4).Value
            Dim PHVA As String = GridVAFollowUpLeft.GetRow.Cells(5).Value
            Dim PHValue As String = GridVAFollowUpLeft.GetRow.Cells(6).Value
            Dim PHCate As String = GridVAFollowUpLeft.GetRow.Cells(7).Value
            Dim GVA As String = GridVAFollowUpLeft.GetRow.Cells(8).Value
            Dim GValue As String = GridVAFollowUpLeft.GetRow.Cells(9).Value
            Dim GCate As String = GridVAFollowUpLeft.GetRow.Cells(10).Value
            Dim DateTime As String = GridVAFollowUpLeft.GetRow.Cells(11).Value
            fPatientVA.TxtPatientNo.Text = PatientNo
            fPatientVA.TrackPlainLeftEye.Value = PlainVA
            fPatientVA.LblPlainLeft.Text = PlainValue
            fPatientVA.lblCatPlainLeft.Text = PlainCate

            fPatientVA.TrackPHLeftEye.Value = PHVA
            fPatientVA.LblPhLeft.Text = PHValue
            fPatientVA.LblCatPHLeft.Text = PHCate

            fPatientVA.TrackGlassesLeftEye.Value = GVA
            fPatientVA.LblGlassesLeft.Text = GValue
            fPatientVA.LblCatGlassesLeft.Text = GCate
            fPatientVA.DateVA.Value = DateTime

            fPatientVA.CallScroll(Sender, e)
            fPatientVA.ShowDialog()
            If fPatientVA.isClose = True Then
                LoadVAPatient(fPatientVA.TxtPatientNo.Text)
            End If
            fPatientVA.Dispose()
            fPatientVA.Close()


        Catch ex As Exception

        End Try

    End Sub
  

    Private Sub BtnNewPatientVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPatientVA.Click
        fVA = New FRMPatientVA(Me)
        fVA.ShowDialog()
        fVA.Dispose()
        fVA.Close()
    End Sub

    Private Sub BtnReportPatientReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportPatientReport.Click
        Try
            Dim FVAReports As New FrmVAReport
            FVAReports.ShowDialog()
            FVAReports.Close()
            FVAReports.Dispose()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub BtnFindPatientNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatientNo.Click
        Dim FVAFind As New FrmFindVA
        If FVAFind.ShowDialog() = DialogResult.OK Then
            GridPatientVA.DataSource = ModRegistration.GetPatientByNo(EmptyString(FVAFind.TxtValue.Text))
        End If
        FVAFind.Close()
        FVAFind.Dispose()
    End Sub


    Private Sub ByPatientEnglishNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByPatientEnglishNameToolStripMenuItem.Click
        GridPatientVA.DataSource = ModRegistration.GetAllPatient()
    End Sub


    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        BindVA(sender, e)
    End Sub

    Private Sub GridPatientVA_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientVA.SelectionChanged
        Try
            LoadVAPatient(Me.GridPatientVA.GetRow.Cells(0).Value)
        Catch ex As Exception

        End Try
    End Sub
End Class
