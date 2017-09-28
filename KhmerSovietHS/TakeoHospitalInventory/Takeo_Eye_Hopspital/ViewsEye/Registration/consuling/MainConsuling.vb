Public Class MainConsuling
    Dim DA_Consulting As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim DA_New_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter
    Dim TblConsulting As DataTable
    Dim MEyeInventory As MainTakeoInventory
    Dim WReport As New WinReport
    Dim ConViewer As Integer = 0
    Sub New(ByVal MEyeInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MEyeInventory = MEyeInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnNewConsulting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewConsulting.Click
        Dim NConsult As New NewConsuling
        NConsult.BtnFind.Visible = True
        NConsult.TxtPatientNo.ReadOnly = False
        If NConsult.ShowDialog() = DialogResult.OK Then
            MEyeInventory.StatusLoading(True)
            TxtPatientNo.Text = NConsult.TxtPatientNo.Text
            ConViewer = 3
            BgLoadConsult.RunWorkerAsync()
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MEyeInventory.StatusLoading(True)
        ConViewer = 3
        BgLoadConsult.RunWorkerAsync()
    End Sub
    Private Sub FindingConsult()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf FindingConsult))
        Else
            If TxtPatientNo.Text = "" Then
                'Find consulting by date:
                TblConsulting = DA_Consulting.GetDataByDateToDate(DFrom.Value.Date, DTo.Value.Date)
            Else
                TblConsulting = DA_Consulting.GetDataByDateToDateWithPNo(TxtPatientNo.Text, DFrom.Value.Date, DTo.Value.Date)
            End If
        End If
    End Sub
    
    Private Sub BgLoadConsult_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadConsult.RunWorkerCompleted

        If ConViewer = 1 Then
            WReport.CrvConsulting.Refresh()
            Dim RDailyConsulting As New CRDailyConsulting



            If RadAllConsult.Checked = True Then
                TblConsulting = DA_Consulting.GetDataByDateToDateApprove(DFrom.Value.Date, DTo.Value.Date, 1)
            End If
            If RadForNewPatient.Checked = True Then
                TblConsulting = DA_Consulting.GetDataByDateToDateApprovedConsult(DFrom.Value.Date, DTo.Value.Date, 1, RadForNewPatient.Text)
            End If
            If RadForOld.Checked = True Then
                TblConsulting = DA_Consulting.GetDataByDateToDateApprovedConsult(DFrom.Value.Date, DTo.Value.Date, 1, RadForOld.Text)
            End If
            If RadForInPatient.Checked = True Then
                TblConsulting = DA_Consulting.GetDataByDateToDateApprovedConsult(DFrom.Value.Date, DTo.Value.Date, 1, RadForInPatient.Text)
            End If
            If RadForOpticalShop.Checked = True Then
                TblConsulting = DA_Consulting.GetDataByDateToDateApprovedConsult(DFrom.Value.Date, DTo.Value.Date, 1, RadForOpticalShop.Text)
            End If

            RDailyConsulting.SetDataSource(TblConsulting)
            WReport.CrvConsulting.ReportSource = RDailyConsulting
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

            MEyeInventory.StatusLoading(False)

            WReport.ShowDialog()
        ElseIf ConViewer = 2 Then
            WReport.CrvConsulting.Refresh()
            Dim RConsultForm As New RPConsulting
            RConsultForm.SetDataSource(TblConsulting)
            WReport.CrvConsulting.ReportSource = RConsultForm
            MEyeInventory.StatusLoading(False)
            WReport.SplitContainerConsult.Panel1Collapsed = True
            WReport.ShowDialog()
        ElseIf ConViewer = 3 Then
            GridConsulting.DataSource = TblConsulting
            MEyeInventory.StatusLoading(False)
        End If
       
    End Sub

    
    Private Sub BgLoadConsult_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadConsult.DoWork
        ViewReport()
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnConsultReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultReport.Click
        Dim WinRe As New WinReport
        WinRe.ShowDialog()
        'MEyeInventory.StatusLoading(True)
        'ConViewer = 1
        'BgLoadConsult.RunWorkerAsync()
    End Sub

   
    Private Sub ViewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ViewReport))
        Else
            If ConViewer = 1 Then
                If RadAllConsult.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDate(DFrom.Value.Date, DTo.Value.Date)
                End If
                If RadForNewPatient.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text)

                End If
                If RadForOld.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text)

                End If
                If RadForInPatient.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text)

                End If
                If RadForOpticalShop.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text)

                End If
            ElseIf ConViewer = 2 Then
                TblConsulting = DA_Consulting.GetDataByConsultID(GridConsulting.GetRow.Cells("CONSULING_ID").Value)
            ElseIf ConViewer = 3 Then
                FindingConsult()
            End If
        End If
    End Sub
    Private Sub BtnConsultForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultForm.Click
        If GridConsulting.SelectedItems.Count = 0 Then Exit Sub
        MEyeInventory.StatusLoading(True)
        ConViewer = 2
        BgLoadConsult.RunWorkerAsync()
    End Sub

    Private Sub BtnDeleteConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteConsult.Click
        If GridConsulting.SelectedItems.Count = 0 Then Exit Sub
        Dim FDeleteResion As New FormDeleteResion
        FDeleteResion.LblConsultID.Text = GridConsulting.GetRow.Cells("CONSULING_ID").Value
        FDeleteResion.LblDelete.Text = 2
        If FDeleteResion.ShowDialog = DialogResult.OK Then
            MEyeInventory.StatusLoading(True)
            TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
            ConViewer = 3
            BgLoadConsult.RunWorkerAsync()
        End If
        'If MessageBox.Show("Do you want delete this consulting?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    If DA_New_Consult.DeleteConsulting(2, GridConsulting.GetRow.Cells("CONSULING_ID").Value) = 1 Then
        '        MEyeInventory.StatusLoading(True)
        '        TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
        '        ConViewer = 3
        '        BgLoadConsult.RunWorkerAsync()
        '    End If
        'End If
    End Sub

    Private Sub MenuUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndo.Click
        If GridConsulting.SelectedItems.Count = 0 Then Exit Sub
        Dim FDeleteResion As New FormDeleteResion
        FDeleteResion.LblConsultID.Text = GridConsulting.GetRow.Cells("CONSULING_ID").Value
        FDeleteResion.LblDelete.Text = 0
        If FDeleteResion.ShowDialog = DialogResult.OK Then
            MEyeInventory.StatusLoading(True)
            TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
            ConViewer = 3
            BgLoadConsult.RunWorkerAsync()
        End If

        'If GridConsulting.SelectedItems.Count = 0 Then Exit Sub
        'If MessageBox.Show("Do you want undo this consulting?", "undo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    If DA_New_Consult.DeleteConsulting(0,"" GridConsulting.GetRow.Cells("CONSULING_ID").Value) = 1 Then
        '        MEyeInventory.StatusLoading(True)
        '        TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
        '        ConViewer = 3
        '        BgLoadConsult.RunWorkerAsync()
        '    End If
        'End If
    End Sub

    Private Sub MenuApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuApprove.Click
        If GridConsulting.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to approve this consulting?", "Approve", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_New_Consult.DeleteConsulting(1, "", GridConsulting.GetRow.Cells("CONSULING_ID").Value) = 1 Then
                MEyeInventory.StatusLoading(True)
                TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
                ConViewer = 3
                BgLoadConsult.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub GridConsulting_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridConsulting.RowDoubleClick
        Try
            Dim Acess As String = ""
            For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
                With TBLACCESS_ROLE.Rows(i)
                    If .Item(0) = "Administrator" Then
                        Acess = "Administrator"
                    End If
                End With
            Next
            If Acess = "Administrator" Then
                If GridConsulting.SelectedItems.Count = 0 Then Exit Sub
                Dim NConsulting As New NewConsuling
                NConsulting.DateConsult.Checked = True
                NConsulting.DateConsult.Value = GridConsulting.GetRow.Cells("CONSULING_DATE").Value
                NConsulting.LblSaveOption.Text = GridConsulting.GetRow.Cells("CONSULING_ID").Value
                NConsulting.TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
                NConsulting.TxtPatientName.Text = GridConsulting.GetRow.Cells("NameKhmer").Value
                NConsulting.TxtSex.Text = GridConsulting.GetRow.Cells("Sex").Value
                NConsulting.TxtAge.Text = GridConsulting.GetRow.Cells("Age").Value
                NConsulting.TxtPatientAddress.Text = GridConsulting.GetRow.Cells("Address").Value
                NConsulting.TxtPatientOccupation.Text = GridConsulting.GetRow.Cells("Occupation").Value
                NConsulting.CboPatientStatus.Text = GridConsulting.GetRow.Cells("FAMILY_STATUS").Value
                NConsulting.cboPatientMoney.Text = GridConsulting.GetRow.Cells("FAMINLY_MONEY").Value
                NConsulting.CboOrg.Text = GridConsulting.GetRow.Cells("ORG").Value
                NConsulting.TxtOrgNote.Text = GridConsulting.GetRow.Cells("ORG_NOTE").Value
                If GridConsulting.GetRow.Cells("CONSULT_FOR").Value = "Old Patient" Then
                    NConsulting.RadForOld.Checked = True
                ElseIf GridConsulting.GetRow.Cells("CONSULT_FOR").Value = "In-Patient" Then
                    NConsulting.RadForInPatient.Checked = True
                ElseIf GridConsulting.GetRow.Cells("CONSULT_FOR").Value = "Optical Shop" Then
                    NConsulting.RadForOpticalShop.Checked = True
                End If
                If GridConsulting.GetRow.Cells("DONATE_TYPE").Value = "Social" Then
                    NConsulting.RadSocial.Checked = True
                ElseIf GridConsulting.GetRow.Cells("DONATE_TYPE").Value = "Nil" Then
                    NConsulting.RadNil.Checked = True
                ElseIf GridConsulting.GetRow.Cells("DONATE_TYPE").Value = "Full" Then
                    NConsulting.RadFull.Checked = True
                End If
                If TypeOf GridConsulting.GetRow.Cells("FAMILY_NAME").Value Is DBNull Then

                Else
                    NConsulting.TxtFamilyName.Text = GridConsulting.GetRow.Cells("FAMILY_NAME").Value
                End If
                If TypeOf GridConsulting.GetRow.Cells("FAMILY_AGE").Value Is DBNull Then
                Else
                    NConsulting.TxtFamilyAge.Text = GridConsulting.GetRow.Cells("FAMILY_AGE").Value
                End If
                If TypeOf GridConsulting.GetRow.Cells("FAMILY_SEX").Value Is DBNull Then
                Else
                    NConsulting.cboFamilySex.Text = GridConsulting.GetRow.Cells("FAMILY_SEX").Value
                End If

                If TypeOf GridConsulting.GetRow.Cells("FAMILY_RELATIVE_PATIENT").Value Is DBNull Then
                Else
                    NConsulting.TxtFamilyRelative.Text = GridConsulting.GetRow.Cells("FAMILY_RELATIVE_PATIENT").Value
                End If
                If TypeOf GridConsulting.GetRow.Cells("FAMILY_ADDRES").Value Is DBNull Then
                Else
                    NConsulting.txtFamilyAddress.Text = GridConsulting.GetRow.Cells("FAMILY_ADDRES").Value
                End If
                If TypeOf GridConsulting.GetRow.Cells("FAMILY_OCCUPATION").Value Is DBNull Then
                Else
                    NConsulting.CboFamilyOccupation.Text = GridConsulting.GetRow.Cells("FAMILY_OCCUPATION").Value
                End If
                If TypeOf GridConsulting.GetRow.Cells("FAMILY_MONEY1").Value Is DBNull Then
                Else
                    NConsulting.cboFamilyMoney.Text = GridConsulting.GetRow.Cells("FAMILY_MONEY1").Value
                End If
                If TypeOf GridConsulting.GetRow.Cells("FAMILY_STATUS1").Value Is DBNull Then
                Else
                    NConsulting.CboFamilyStatus.Text = GridConsulting.GetRow.Cells("FAMILY_STATUS1").Value
                End If
                NConsulting.CboOrg.Text = GridConsulting.GetRow.Cells("ORG").Value



                NConsulting.Ch1.Checked = GridConsulting.GetRow.Cells("CH1").Value
                NConsulting.Ch2.Checked = GridConsulting.GetRow.Cells("CH2").Value
                NConsulting.Ch3.Checked = GridConsulting.GetRow.Cells("CH3").Value
                NConsulting.Ch4.Checked = GridConsulting.GetRow.Cells("CH4").Value
                NConsulting.Ch5.Checked = GridConsulting.GetRow.Cells("CH5").Value
                NConsulting.CboSecondDiagnosis.Text = GridConsulting.GetRow.Cells("DIAGNOSIS2").Value
                NConsulting.CboSecondSurgery.Text = GridConsulting.GetRow.Cells("OPERATION2").Value
                NConsulting.TxtHospitalFee.Text = GridConsulting.GetRow.Cells("HOSPITAL_FEE").Value
                NConsulting.CboEye.Text = GridConsulting.GetRow.Cells("EYE").Value

                If GridConsulting.GetRow.Cells("IS_RIEL_DOLAR").Value = True Then
                    NConsulting.RadPatientPayR.Checked = True
                    NConsulting.TxtDonateR.Text = GridConsulting.GetRow.Cells("DONATE_RIEL").Value
                Else
                    NConsulting.RadPatientPayD.Checked = True
                    NConsulting.TxtDonateR.Text = GridConsulting.GetRow.Cells("PATIENT_PAY_DOLAR").Value

                End If

                NConsulting.TxtDonateD.Text = GridConsulting.GetRow.Cells("DONATE_DOLAR").Value
                NConsulting.TxtConsultNote.Text = GridConsulting.GetRow.Cells("CONSULTING_NOTE").Value
                If NConsulting.ShowDialog() = DialogResult.OK Then
                    TxtPatientNo.Text = NConsulting.TxtPatientNo.Text
                    MEyeInventory.StatusLoading(True)
                    ConViewer = 3
                    BgLoadConsult.RunWorkerAsync()
                End If
            Else
                If GridConsulting.GetRow.Cells("STATUS").Value = 0 Then

                    Dim NConsulting As New NewConsuling
                    NConsulting.DateConsult.Checked = True
                    NConsulting.DateConsult.Value = GridConsulting.GetRow.Cells("CONSULING_DATE").Value
                    NConsulting.LblSaveOption.Text = GridConsulting.GetRow.Cells("CONSULING_ID").Value
                    NConsulting.TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
                    NConsulting.TxtPatientName.Text = GridConsulting.GetRow.Cells("NameKhmer").Value
                    NConsulting.TxtSex.Text = GridConsulting.GetRow.Cells("Sex").Value
                    NConsulting.TxtAge.Text = GridConsulting.GetRow.Cells("Age").Value
                    NConsulting.TxtPatientAddress.Text = GridConsulting.GetRow.Cells("Address").Value
                    NConsulting.TxtPatientOccupation.Text = GridConsulting.GetRow.Cells("Occupation").Value
                    NConsulting.CboPatientStatus.Text = GridConsulting.GetRow.Cells("FAMILY_STATUS").Value
                    NConsulting.cboPatientMoney.Text = GridConsulting.GetRow.Cells("FAMINLY_MONEY").Value
                    NConsulting.CboOrg.Text = GridConsulting.GetRow.Cells("ORG").Value
                    NConsulting.TxtOrgNote.Text = GridConsulting.GetRow.Cells("ORG_NOTE").Value
                    If GridConsulting.GetRow.Cells("CONSULT_FOR").Value = "Old Patient" Then
                        NConsulting.RadForOld.Checked = True
                    ElseIf GridConsulting.GetRow.Cells("CONSULT_FOR").Value = "In-Patient" Then
                        NConsulting.RadForInPatient.Checked = True
                    ElseIf GridConsulting.GetRow.Cells("CONSULT_FOR").Value = "Optical Shop" Then
                        NConsulting.RadForOpticalShop.Checked = True
                    End If
                    If GridConsulting.GetRow.Cells("DONATE_TYPE").Value = "Social" Then
                        NConsulting.RadSocial.Checked = True
                    ElseIf GridConsulting.GetRow.Cells("DONATE_TYPE").Value = "Nil" Then
                        NConsulting.RadNil.Checked = True
                    ElseIf GridConsulting.GetRow.Cells("DONATE_TYPE").Value = "Full" Then
                        NConsulting.RadFull.Checked = True
                    End If
                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_NAME").Value Is DBNull Then

                    Else
                        NConsulting.TxtFamilyName.Text = GridConsulting.GetRow.Cells("FAMILY_NAME").Value
                    End If
                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_AGE").Value Is DBNull Then
                    Else
                        NConsulting.TxtFamilyAge.Text = GridConsulting.GetRow.Cells("FAMILY_AGE").Value
                    End If
                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_SEX").Value Is DBNull Then
                    Else
                        NConsulting.cboFamilySex.Text = GridConsulting.GetRow.Cells("FAMILY_SEX").Value
                    End If

                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_RELATIVE_PATIENT").Value Is DBNull Then
                    Else
                        NConsulting.TxtFamilyRelative.Text = GridConsulting.GetRow.Cells("FAMILY_RELATIVE_PATIENT").Value
                    End If
                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_ADDRES").Value Is DBNull Then
                    Else
                        NConsulting.txtFamilyAddress.Text = GridConsulting.GetRow.Cells("FAMILY_ADDRES").Value
                    End If
                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_OCCUPATION").Value Is DBNull Then
                    Else
                        NConsulting.CboFamilyOccupation.Text = GridConsulting.GetRow.Cells("FAMILY_OCCUPATION").Value
                    End If
                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_MONEY1").Value Is DBNull Then
                    Else
                        NConsulting.cboFamilyMoney.Text = GridConsulting.GetRow.Cells("FAMILY_MONEY1").Value
                    End If
                    If TypeOf GridConsulting.GetRow.Cells("FAMILY_STATUS1").Value Is DBNull Then
                    Else
                        NConsulting.CboFamilyStatus.Text = GridConsulting.GetRow.Cells("FAMILY_STATUS1").Value
                    End If
                    NConsulting.CboOrg.Text = GridConsulting.GetRow.Cells("ORG").Value



                    NConsulting.Ch1.Checked = GridConsulting.GetRow.Cells("CH1").Value
                    NConsulting.Ch2.Checked = GridConsulting.GetRow.Cells("CH2").Value
                    NConsulting.Ch3.Checked = GridConsulting.GetRow.Cells("CH3").Value
                    NConsulting.Ch4.Checked = GridConsulting.GetRow.Cells("CH4").Value
                    NConsulting.Ch5.Checked = GridConsulting.GetRow.Cells("CH5").Value
                    NConsulting.CboSecondDiagnosis.Text = GridConsulting.GetRow.Cells("DIAGNOSIS2").Value
                    NConsulting.CboSecondSurgery.Text = GridConsulting.GetRow.Cells("OPERATION2").Value
                    NConsulting.TxtHospitalFee.Text = GridConsulting.GetRow.Cells("HOSPITAL_FEE").Value
                    NConsulting.CboEye.Text = GridConsulting.GetRow.Cells("EYE").Value

                    If GridConsulting.GetRow.Cells("IS_RIEL_DOLAR").Value = True Then
                        NConsulting.RadPatientPayR.Checked = True
                        NConsulting.TxtDonateR.Text = GridConsulting.GetRow.Cells("DONATE_RIEL").Value
                    Else
                        NConsulting.RadPatientPayD.Checked = True
                        NConsulting.TxtDonateR.Text = GridConsulting.GetRow.Cells("PATIENT_PAY_DOLAR").Value

                    End If

                    NConsulting.TxtDonateD.Text = GridConsulting.GetRow.Cells("DONATE_DOLAR").Value
                    NConsulting.TxtConsultNote.Text = GridConsulting.GetRow.Cells("CONSULTING_NOTE").Value

                    If NConsulting.ShowDialog() = DialogResult.OK Then
                        TxtPatientNo.Text = NConsulting.TxtPatientNo.Text
                        MEyeInventory.StatusLoading(True)
                        ConViewer = 3
                        BgLoadConsult.RunWorkerAsync()
                    End If
                Else
                    MessageBox.Show("You don't have permision edit consultation. Please contact admin system to edit it.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If



            End If


        Catch ex As Exception
            'MessageBox.Show("Please select patient information.", "Patient Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MainConsuling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnFind_Click(sender, e)
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Administrator" Then
                    BtnUndo.Enabled = True
                    BtnDeleteConsult.Enabled = True
                End If
            End With
        Next
    End Sub

    
End Class
