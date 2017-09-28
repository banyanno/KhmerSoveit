Public Class FormMainPoMoSypo
    Dim TblTem As DataTable
    Dim DFrom, DTo As Date
    Dim CMoPoTsyo As New CryMoPoTsyo
      
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DFrom = DateMoFrom.Value
        DTo = DateMoTo.Value
        CallLoadMoPoTysoPatient()
    End Sub
    Sub CallLoadMoPoTysoPatient()
        ShowSplitPanel(SplitListMoPoTysoAndReport, 1)
        LblNotFill.Text = ModMoPoTsyo.CountNotFill(DFrom, DTo)
        LblFill.Text = ModMoPoTsyo.CountFill(DFrom, DTo)
        PictLoading.Visible = True
        RunBG()
    End Sub
    Sub RunBG()
        BGMoPoTsyo.RunWorkerAsync()
    End Sub

    Private Sub BGMoPoTsyo_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGMoPoTsyo.DoWork
        'Try

        If TxtPatientNo.Text.Trim = "" Then
            TblTem = Me.V_MoPoTysoTableAdapter.GetDataByDate(DFrom, DTo)
        Else
            TblTem = Me.V_MoPoTysoTableAdapter.GetDataByDateAndPatientNo(TxtPatientNo.Text, DFrom, DTo)
        End If
        'Catch ex As Exception

        'End Try
       

    End Sub

    Private Sub BGMoPoTsyo_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGMoPoTsyo.RunWorkerCompleted
        Me.GridPatientMoPoTsyo.DataSource = TblTem
        CMoPoTsyo.SetDataSource(TblTem)
        CRViewer.DisplayStatusBar = True
        CRViewer.DisplayToolbar = True
        CRViewer.ReportSource = CMoPoTsyo
        PictLoading.Visible = False
    End Sub

   
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Try
            ShowSplitPanel(SplitListMoPoTysoAndReport, 0)
            PictLoading.Visible = True
            DFrom = DateMoFrom.Value
            DTo = DateMoTo.Value
            RunBG()
        Catch ex As Exception

        End Try
        
      
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Sub EnterMoPoTsyo()
        If GridPatientMoPoTsyo.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select Mo-Po-Tyso's patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim FMoPoTsyo As New FormMoreMoPoTsyo
            FMoPoTsyo.BtnFind.Enabled = False
            FMoPoTsyo.LblSaveOption.Text = GridPatientMoPoTsyo.GetRow.Cells("MoPoID").Value
            If TypeOf (GridPatientMoPoTsyo.GetRow.Cells("MoPoTsyCode").Value) Is DBNull Then
                FMoPoTsyo.TxtMPCode.Text = ""
            Else
                FMoPoTsyo.TxtMPCode.Text = GridPatientMoPoTsyo.GetRow.Cells("MoPoTsyCode").Value
            End If
            FMoPoTsyo.TxtPatientNo.Text = GridPatientMoPoTsyo.GetRow.Cells("PatientNo").Value
            FMoPoTsyo.TxtPatientName.Text = GridPatientMoPoTsyo.GetRow.Cells("NameKhmer").Value
            FMoPoTsyo.TxtSex.Text = GridPatientMoPoTsyo.GetRow.Cells("Sex").Value
            FMoPoTsyo.TxtAge.Text = GridPatientMoPoTsyo.GetRow.Cells("Age").Value
            FMoPoTsyo.TxtAddress.Text = GridPatientMoPoTsyo.GetRow.Cells("Address").Value
            If TypeOf (GridPatientMoPoTsyo.GetRow.Cells("NewReceipt").Value) Is DBNull Then
                FMoPoTsyo.TxtNewPatientReceipt.Text = "0"
            Else
                FMoPoTsyo.TxtNewPatientReceipt.Text = GridPatientMoPoTsyo.GetRow.Cells("NewReceipt").Value
            End If
            If TypeOf GridPatientMoPoTsyo.GetRow.Cells("OldReceipt").Value Is DBNull Then
                FMoPoTsyo.TxtOldPatientReceipt.Text = "0"
            Else
                FMoPoTsyo.TxtOldPatientReceipt.Text = GridPatientMoPoTsyo.GetRow.Cells("OldReceipt").Value
            End If
            If TypeOf GridPatientMoPoTsyo.GetRow.Cells("InReceipt").Value Is DBNull Then
                FMoPoTsyo.TxtInPatientReceipt.Text = "0"
            Else
                FMoPoTsyo.TxtInPatientReceipt.Text = GridPatientMoPoTsyo.GetRow.Cells("InReceipt").Value
            End If
            If TypeOf GridPatientMoPoTsyo.GetRow.Cells("OPTReceipt").Value Is DBNull Then
                FMoPoTsyo.TxtOPTPatientReceipt.Text = "0"
            Else
                FMoPoTsyo.TxtOPTPatientReceipt.Text = GridPatientMoPoTsyo.GetRow.Cells("OPTReceipt").Value
            End If
            If TypeOf GridPatientMoPoTsyo.GetRow.Cells("TreatmentFee").Value Is DBNull Then
                FMoPoTsyo.TxtTotalFee.Text = "0"
            Else
                FMoPoTsyo.TxtTotalFee.Text = GridPatientMoPoTsyo.GetRow.Cells("TreatmentFee").Value
            End If

            FMoPoTsyo.DateExam.Checked = True
            FMoPoTsyo.DateExam.Value = GridPatientMoPoTsyo.GetRow.Cells("CreateDate").Value
            'Check For radio button
            If TypeOf GridPatientMoPoTsyo.GetRow.Cells(8).Value Is DBNull Then
            Else
                Select Case GridPatientMoPoTsyo.GetRow.Cells(8).Value
                    Case "1"
                        FMoPoTsyo.RadDiabete1.Checked = True
                    Case "2"
                        FMoPoTsyo.RadDiabete2.Checked = True
                    Case "3"
                        FMoPoTsyo.RadDiabete3.Checked = True
                    Case "4"
                        FMoPoTsyo.RadDiabete4.Checked = True
                End Select
            End If
            FMoPoTsyo.ChDiagnosis1.Checked = GridPatientMoPoTsyo.GetRow.Cells("DRetina_desease").Value
            FMoPoTsyo.ChDiagnosis2.Checked = GridPatientMoPoTsyo.GetRow.Cells("DCataract").Value
            FMoPoTsyo.ChDiagnosis3.Checked = GridPatientMoPoTsyo.GetRow.Cells("DPteriguim").Value
            FMoPoTsyo.ChDiagnosis4.Checked = GridPatientMoPoTsyo.GetRow.Cells("DGlaucom").Value
            FMoPoTsyo.ChDiagnosis5.Checked = GridPatientMoPoTsyo.GetRow.Cells("DRefractive_error").Value
            FMoPoTsyo.ChDiagnosis6.Checked = GridPatientMoPoTsyo.GetRow.Cells("DOther_deseases").Value
            'If TypeOf GridPatientMoPoTsyo.GetRow.Cells(9).Value Is DBNull Then
            'Else
            '    Select Case GridPatientMoPoTsyo.GetRow.Cells(9).Value
            '        Case 1
            '            FMoPoTsyo.RadDiagnosis1.Checked = True
            '        Case 2
            '            FMoPoTsyo.RadDiagnosis2.Checked = True
            '        Case 3
            '            FMoPoTsyo.RadDiagnosis3.Checked = True
            '        Case 4
            '            FMoPoTsyo.RadDiagnosis4.Checked = True
            '        Case 5
            '            FMoPoTsyo.RadDiagnosis5.Checked = True
            '        Case 6
            '            FMoPoTsyo.RadDiagnosis6.Checked = True

            '    End Select
            'End If
            If TypeOf GridPatientMoPoTsyo.GetRow.Cells("TyeOfDR").Value Is DBNull Then
            Else
                Select Case GridPatientMoPoTsyo.GetRow.Cells("TyeOfDR").Value
                    Case "1"
                        FMoPoTsyo.RadDR1.Checked = True
                    Case "2"
                        FMoPoTsyo.RadDR2.Checked = True
                    Case "3"
                        FMoPoTsyo.RadDR3.Checked = True
                    Case "4"
                        FMoPoTsyo.RadDR4.Checked = True
                    Case "5"
                        FMoPoTsyo.RadDR5.Checked = True

                End Select
            End If
            If TypeOf GridPatientMoPoTsyo.GetRow.Cells("Treatment").Value Is DBNull Then
            Else
                FMoPoTsyo.TxtTreatment.Text = GridPatientMoPoTsyo.GetRow.Cells("Treatment").Value
            End If

            If TypeOf GridPatientMoPoTsyo.GetRow.Cells("AppDate").Value Is DBNull Then
            Else
                FMoPoTsyo.DateAppointment.Checked = True
                FMoPoTsyo.DateAppointment.Value = GridPatientMoPoTsyo.GetRow.Cells("AppDate").Value
            End If

            If FMoPoTsyo.ShowDialog = Windows.Forms.DialogResult.OK Then
                CallLoadMoPoTysoPatient()
            End If
        End If

    End Sub

    Private Sub BtnEnterMPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnterMPC.Click
        EnterMoPoTsyo()
    End Sub

    Private Sub GridPatientMoPoTsyo_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPatientMoPoTsyo.RowDoubleClick
        EnterMoPoTsyo()
    End Sub

    Private Sub BtnNewMoPotsyo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewMoPotsyo.Click
        Dim FMoPoTsyo As New FormMoreMoPoTsyo
        FMoPoTsyo.TxtMPCode.ReadOnly = False
        FMoPoTsyo.TxtPatientNo.ReadOnly = False
        FMoPoTsyo.BtnFind.Enabled = True
        DFrom = DateMoFrom.Value
        DTo = DateMoTo.Value
        If FMoPoTsyo.ShowDialog = Windows.Forms.DialogResult.OK Then
            CallLoadMoPoTysoPatient()
        End If
        FMoPoTsyo.Close()
        FMoPoTsyo.Dispose()
    End Sub

End Class