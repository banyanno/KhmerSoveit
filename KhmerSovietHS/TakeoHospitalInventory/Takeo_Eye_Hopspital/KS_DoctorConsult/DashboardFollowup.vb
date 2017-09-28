Imports CrystalDecisions.Shared

Public Class DashboardFollowup
    Dim DA_HistoryFollowUp As New DSConsultHistoryTableAdapters.S_FOLLOWUPTableAdapter
    Dim DAPatientWaiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Dim DAFollowUP As New DSWaitingConsultTableAdapters.S_PATIENT_FOLLOWUPTableAdapter
    Dim DA_Doctor As New DSWaitingConsultTableAdapters.VUsersInGroupTableAdapter
    Dim DA_VA As New DSWaitingConsultTableAdapters.S_VISUAL_ACUITYTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' =================== Select User in department Doctors = 36 =======================
        With CboDoctor
            .DataSource = DA_Doctor.SelectGroupDepartment(36)
            .ValueMember = "UserID"
            .DisplayMember = "EmployeeName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ViewPatientFollowUpByDate(ByVal DateFollowup As Date, ByVal DateFollowUPto As Date)
        GridFollowUp.DataSource = DA_HistoryFollowUp.SelectDateFollowup(DateFollowup.Date, DateFollowUPto.Date)
    End Sub

    Private Sub DashboardFollowup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewPatientFollowUpByDate(DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        ViewPatientFollowUpByDate(DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
    End Sub

    Private Sub BtnNewFollowUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewFollowUP.Click
        Dim FFollowUp As New NewFollowUp
        If FFollowUp.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnSendToWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendToWaiting.Click
        If GridFollowUp.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to send to patient waiting list?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'DAPatientWaiting.InsertNewWaiting(GridPatientInformation.GetRow.Cells("PatientNo").Value, 0, "", "2", GetDateServer.Date, "1")
            If DAPatientWaiting.InsertNewWaiting(GridFollowUp.GetRow.Cells("PatientNo").Value, 0, GridFollowUp.GetRow.Cells("FOLLOW_NOTE").Value, "2", GetDateServer.Date, "1") = 1 Then
                DA_VA.InsertNewVA(GridFollowUp.GetRow.Cells("PatientNo").Value, DAPatientWaiting.SelectMaxWaitID, Now.Date, "", "", "", "", "", "", "", "", "", "", "", "")
                If DAFollowUP.UpdateStatus(2, GridFollowUp.GetRow.Cells("FOLLOW_ID").Value) = 1 Then
                    ViewPatientFollowUpByDate(DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
                End If
            End If
        End If
    End Sub

    Private Sub RadPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientNo.CheckedChanged
        TxtPatientNo.Enabled = RadPatientNo.Checked
        TxtPatientNo.Select()
        TxtPatientNo.Focus()
    End Sub

    Private Sub RadPatientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientName.CheckedChanged
        TxtPatientName.Enabled = RadPatientName.Checked
        TxtPatientName.Select()
        TxtPatientName.Focus()
    End Sub

    Private Sub RadTelephone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTelephone.CheckedChanged
        TxtTelephone.Enabled = RadTelephone.Checked
        TxtTelephone.Select()
        TxtTelephone.Focus()
    End Sub

    Private Sub RadDoctory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDoctory.CheckedChanged
        CboDoctor.Enabled = RadDoctory.Checked
        CboDoctor.Select()
        CboDoctor.Focus()
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadPatientNo.Checked = True Then
            GridFollowUp.DataSource = DA_HistoryFollowUp.SelectFollowUpPatientNo(EmptyString(TxtPatientNo.Text), DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
        ElseIf RadPatientName.Checked = True Then
            GridFollowUp.DataSource = DA_HistoryFollowUp.SelectPatientName("%" & TxtPatientName.Text & "%", DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
        ElseIf RadTelephone.Checked = True Then
            GridFollowUp.DataSource = DA_HistoryFollowUp.SelectFollowupByPhone("%" & TxtTelephone.Text & "%", DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
        ElseIf RadDoctory.Checked = True Then
            GridFollowUp.DataSource = DA_HistoryFollowUp.SelectFollowupByDoctor(CboDoctor.Text, DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
        End If
    End Sub

    Private Sub BtnFollowupReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFollowupReport.Click
        Dim FPrintPreview As New FormPrintPreview
        Dim RDialyFollowup As New DialyFollowup
        Dim TblFollowup As DataTable = DA_HistoryFollowUp.SelectDateFollowup(DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
        RDialyFollowup.SetDataSource(TblFollowup)
        RDialyFollowup.SetParameterValue("DateFollowup", DateFollowUp.Text)


        ' Declare for export Big app form
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\ListPatientFollowup.pdf"
        CrExportOptionsBig = RDialyFollowup.ExportOptions

        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With

        RDialyFollowup.Export()
        Application.DoEvents()
        Application.DoEvents()
        FPrintPreview.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\ListPatientFollowup.pdf"
        FPrintPreview.AxAcroPDF1.setZoom(100)
        FPrintPreview.ShowDialog()
    End Sub

    
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub GridFollowUp_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFollowUp.RowDoubleClick
        If GridFollowUp.SelectedItems.Count = 0 Then Exit Sub
        Dim FFollowUp As New NewFollowUp
        FFollowUp.LblSaveOption.Text = GridFollowUp.GetRow.Cells("FOLLOW_ID").Value
        FFollowUp.TxtPatientNo.Text = GridFollowUp.GetRow.Cells("PatientNo").Value
        'FFollowUp.TxtSex.Text = GridFollowUp.GetRow.Cells("").Value
        'FFollowUp.TxtTel.Text = GridFollowUp.GetRow.Cells("").Value
        'FFollowUp.TxtAge.Text = GridFollowUp.GetRow.Cells("").Value
        FFollowUp.DateFollowUp.Checked = True
        FFollowUp.DateFollowUp.Value = GridFollowUp.GetRow.Cells("DATE_FOLLOWUP").Value
        FFollowUp.TimeFollowup.Checked = True
        FFollowUp.TimeFollowup.Text = GridFollowUp.GetRow.Cells("TIME_FOLLOWUP").Value
        FFollowUp.CboDoctorConsult.SelectedValue = GridFollowUp.GetRow.Cells("DOCTOR_ID").Value
        FFollowUp.TxtFollowUpNote.Text = GridFollowUp.GetRow.Cells("FOLLOW_NOTE").Value
        FFollowUp.FindPatient(GridFollowUp.GetRow.Cells("PatientNo").Value)
        If FFollowUp.ShowDialog = DialogResult.OK Then
            ViewPatientFollowUpByDate(DateFollowUp.Value.Date, DateFollowupTo.Value.Date)
        End If
    End Sub

    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFind_Click(sender, e)
        End If
    End Sub

    Private Sub TxtPatientName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFind_Click(sender, e)
        End If
    End Sub

    Private Sub TxtTelephone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTelephone.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFind_Click(sender, e)
        End If
    End Sub

    Private Sub CboDoctor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboDoctor.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFind_Click(sender, e)
        End If
    End Sub
End Class
