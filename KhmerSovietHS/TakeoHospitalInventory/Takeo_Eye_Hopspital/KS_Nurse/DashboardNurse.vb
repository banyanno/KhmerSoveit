Public Class DashboardNurse
    Dim DA_WaitingView As New DSWaitingConsultTableAdapters.S_WAITING_VIEWTableAdapter
    Dim DAPatient As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    Dim DA_VA As New DSWaitingConsultTableAdapters.S_VISUAL_ACUITYTableAdapter
    Dim DA_Waiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Private Sub DashboardNurse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadingPatientWaiting("2", "1")
    End Sub
    Private Sub LoadingPatientWaiting(ByVal Status As String, ByVal Nurse As String)
        GridPatientWaiting.DataSource = DA_WaitingView.SelectWaitingStatus(Status, Nurse)
    End Sub

    Private Sub GridPatientWaiting_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientWaiting.SelectionChanged
        Try
            If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
            PictureBox1.Image = ByteArrayToImage(DAPatient.SelectPicture(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value))
        Catch ex As Exception

        End Try
       
    End Sub

   
    Private Sub BtnSendToDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendToDoctor.Click

        CreateNewVA()

    End Sub

    Sub CreateNewVA()
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        If GridPatientWaiting.FilterRow.Selected = True Then
            MessageBox.Show("Please select patient before send to doctor examination", "Examination", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DA_Waiting.CheckDoctorConsulting(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value).Rows.Count > 0 Then
            MessageBox.Show("Doctor is consulting this patient. you can not start enter VA", "Consultation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FVa As New FormVA
        FVa.LblWating.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        FVa.TxtNote.Text = GridPatientWaiting.GetRow.Cells("WAITING_DESC").Value
        If FVa.ShowDialog = DialogResult.OK Then
            LoadingPatientWaiting("2", "1")
        End If
        'If MessageBox.Show("Do you want to send to doctor consult?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    If DA_Waiting.UpdatePatientStatus(TxtNote.Text, "2", "2", GridPatientWaiting.GetRow.Cells("WAIT_ID").Value) = 1 Then
        '        If DA_VA.UpdateVA(TxtRE.Text, TxtRPh.Text, TxtRREF.Text, TxtRRE.Text, TxtLE.Text, TxtLPh.Text, TxtLREF.Text, TxtLLE.Text, TxtNote.Text, CDbl(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)) >= 1 Then
        '            LoadingPatientWaiting("2", "1")
        '            ClearnInForm()
        '        Else
        '            MessageBox.Show("")
        '        End If
        '        'If DA_VA.InsertNewVA(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value, GridPatientWaiting.GetRow.Cells("WAIT_ID").Value, Now.Date, TxtRE.Text, TxtRPh.Text, TxtRREF.Text, TxtRRE.Text, TxtLE.Text, TxtLPh.Text, TxtLREF.Text, TxtLLE.Text, USER_NAME, TxtNote.Text) = 1 Then
        '        '    LoadingPatientWaiting("1")
        '        '    ClearnInForm()
        '        'End If
        '    End If
        'End If
    End Sub
    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        ClearnInForm()
        LoadingPatientWaiting("2", "1")
    End Sub

    Private Sub BtnDeleteWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteWaiting.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete waiting?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Waiting.DeleteWaiting(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value) = 1 Then
                LoadingPatientWaiting("2", "1")
                ClearnInForm()
            End If
        End If
    End Sub
    Private Sub ClearnInForm()
        TxtNote.Text = ""
        TxtRE.Text = ""
        TxtRPh.Text = ""
        TxtRREF.Text = ""
        TxtRRE.Text = ""
        TxtLE.Text = ""
        TxtLPh.Text = ""
        TxtLREF.Text = ""
        TxtLLE.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub DashboardNurse_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Refresh_Click(sender, e)
        End If
    End Sub

    Private Sub GridPatientWaiting_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridPatientWaiting.KeyDown
        If e.KeyCode = Keys.F5 Then
            Refresh_Click(sender, e)
        End If
    End Sub

    Private Sub BtnRefreshWaiting_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnRefreshWaiting.KeyDown
        If e.KeyCode = Keys.F5 Then
            Refresh_Click(sender, e)
        End If
    End Sub

    Private Sub GridPatientWaiting_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPatientWaiting.RowDoubleClick
        CreateNewVA()
    End Sub
End Class
