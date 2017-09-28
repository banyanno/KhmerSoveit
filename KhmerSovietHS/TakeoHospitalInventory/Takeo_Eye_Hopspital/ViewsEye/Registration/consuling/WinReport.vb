Public Class WinReport
    Dim DA_Donater As New DSConsultTableAdapters.DONATIONTableAdapter
    Dim DA_Consulting As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim TblConsulting As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With cboDonate
            .DataSource = DA_Donater.GetData
            .ValueMember = DA_Donater.GetData.Columns("DonationID").ColumnName
            .DisplayMember = DA_Donater.GetData.Columns("DonationName").ColumnName
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    
    Private Sub WinReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If ChViewAll.Checked = False Then
            If ValidateCombobox(cboDonate, "", ErrReport) = False Then Exit Sub
        End If
        MainForm.StatusLoading(True)
        BgLoadConsult.RunWorkerAsync()
    End Sub
    Private Sub ViewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ViewReport))
        Else
            If ChConsultCancel.Checked = False Then
                If ChViewAll.Checked = True Then
                    If RadAllConsult.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateToDateStatus(DFrom.Value.Date, DTo.Value.Date, 1)
                    End If
                    If RadForNewPatient.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, 1)

                    End If
                    If RadForOld.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, 1)

                    End If
                    If RadForInPatient.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, 1)

                    End If
                    If RadForOpticalShop.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, 1)

                    End If
                Else
                    If RadAllConsult.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateToDateDonateStatus(DFrom.Value.Date, DTo.Value.Date, cboDonate.Text, 1)
                    End If
                    If RadForNewPatient.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, cboDonate.Text, 1)

                    End If
                    If RadForOld.Checked = True Then

                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, cboDonate.Text, 1)
                    End If
                    If RadForInPatient.Checked = True Then

                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, cboDonate.Text, 1)
                    End If
                    If RadForOpticalShop.Checked = True Then

                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, cboDonate.Text, 1)
                    End If
                End If
            Else
                If ChViewAll.Checked = True Then
                    If RadAllConsult.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateToDateStatus(DFrom.Value.Date, DTo.Value.Date, 2)
                    End If
                    If RadForNewPatient.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, 2)

                    End If
                    If RadForOld.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, 2)

                    End If
                    If RadForInPatient.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, 2)

                    End If
                    If RadForOpticalShop.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, 2)

                    End If
                Else
                    If RadAllConsult.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateToDateDonateStatus(DFrom.Value.Date, DTo.Value.Date, cboDonate.Text, 2)
                    End If
                    If RadForNewPatient.Checked = True Then
                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, cboDonate.Text, 2)

                    End If
                    If RadForOld.Checked = True Then

                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, cboDonate.Text, 2)
                    End If
                    If RadForInPatient.Checked = True Then

                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, cboDonate.Text, 2)
                    End If
                    If RadForOpticalShop.Checked = True Then

                        TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, cboDonate.Text, 2)
                    End If
                End If
            End If
            

        End If

    End Sub

    Private Sub BgLoadConsult_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadConsult.DoWork
        ViewReport()
    End Sub

    Private Sub BgLoadConsult_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadConsult.RunWorkerCompleted

        Dim RDailyConsulting As New CRDailyConsulting
        Dim RDialyConsultDelete As New CRDailyConsultingDelete



        If ChConsultCancel.Checked = False Then
            RDailyConsulting.SetDataSource(TblConsulting)
            CrvConsulting.ReportSource = RDailyConsulting
            If ChViewAll.Checked = True Then

                If RadAllConsult.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If

                If RadForNewPatient.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (New Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If
                If RadForOld.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (Old Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If
                If RadForInPatient.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (In-Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If
                If RadForOpticalShop.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (Optical Shop) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If


            Else
                If RadAllConsult.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If

                If RadForNewPatient.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (New Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If
                If RadForOld.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (Old Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If
                If RadForInPatient.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (In-Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If
                If RadForOpticalShop.Checked = True Then
                    RDailyConsulting.SetParameterValue("Title", "Consult for (Optical Shop) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If

            End If
        Else

            RDialyConsultDelete.SetDataSource(TblConsulting)
            CrvConsulting.ReportSource = RDialyConsultDelete
            If ChViewAll.Checked = True Then

                If RadAllConsult.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "All Consult that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If

                If RadForNewPatient.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (New Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If
                If RadForOld.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (Old Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If
                If RadForInPatient.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (In-Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If
                If RadForOpticalShop.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (Optical Shop) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy"))
                End If


            Else
                If RadAllConsult.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "All Consult that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If

                If RadForNewPatient.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (New Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If
                If RadForOld.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (Old Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If
                If RadForInPatient.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (In-Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If
                If RadForOpticalShop.Checked = True Then
                    RDialyConsultDelete.SetParameterValue("Title", "Consult for (Optical Shop) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text)
                End If

            End If
        End If
        
       
        MainForm.StatusLoading(False)
    End Sub
End Class