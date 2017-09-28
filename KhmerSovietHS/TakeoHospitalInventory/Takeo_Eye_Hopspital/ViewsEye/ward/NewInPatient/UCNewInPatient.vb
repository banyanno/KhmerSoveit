Public Class UCNewInPatient
    Dim FMain As MainTakeoInventory
    Dim PatientNo As String = ""
    Dim DateFrom As String
    Dim DateTo As String
    Dim DateHistory As Date
    Dim PatientNoHistory As String = ""
    Dim GroupDataGridForInPatient As New Janus.Windows.GridEX.GridEXGroup
    Dim DAPatientWait As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    Sub New(ByVal Main As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FMain = Main

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub DaillyBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaillyBooksToolStripMenuItem.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim frmDaillyBook As New FRMDaillyBook
                Dim NewInNo As Double = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                Dim PatientNo As Double = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Text
                frmDaillyBook.TxtPatientNo.Text = PatientNo
                frmDaillyBook.LblNewInpatientNo.Text = NewInNo
                frmDaillyBook.ShowDialog()
                If frmDaillyBook.isCloseDaillBook = True Then
                    ' GridDiallyBook.DataSource = ModDaillyBook.SelectDaillyBookByNewInpatient(frmDaillyBook.LblNewInpatientNo.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox("Could you select patient info.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    
    Function SelectNewInPatientNormal(ByVal PatientNo As String, ByVal DateFrom2 As String, ByVal DateTo2 As String) As String
        Dim sql As String = "SELECT " & _
       " * FROM V_NewInPatientDetial" & _
       " WHERE Waiting!=2 AND DeleteOption='False'"
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        If DateFrom <> "" And DateTo <> "" Then
            sql = sql & _
            " AND (CAST(CONVERT(VARCHAR(10), CreateDate, 1)  " & _
            " AS DateTime) BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) " & _
            " AND CAST(CONVERT(VARCHAR(10), " & _
            " CAST('" & DateTo & "' AS DATETIME), 1) AS Datetime))  "
        End If
        sql = sql & " ORDER BY CreateDate ASC"
        Return sql
    End Function
    Function SelectNewInPatientPrepareOT(ByVal PatientNo As String) As String
        Dim sql As String = "SELECT " & _
         " * FROM V_NewInPatientDetial" & _
         " WHERE  Waiting=2"
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " ORDER BY CreateDate ASC"
        Return sql
    End Function
    Private Sub FillNewInPatientNormal()
        Me.DSWardWithOT.Clear()
        Dim SQlDataAdapter As New SqlClient.SqlDataAdapter
        Dim Cnn As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim SqlComman As New SqlClient.SqlCommand
        Try
            SqlComman.CommandText = SelectNewInPatientNormal(PatientNo, DateFrom, DateTo)
            SqlComman.Connection = Cnn
            SQlDataAdapter.SelectCommand = SqlComman
            SQlDataAdapter.Fill(DSWardWithOT.V_NewInpatientDetial)
            SQlDataAdapter.Dispose()
            SqlComman.Dispose()

            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FillNewInpatientOT()
        Me.DSPrepareOTList.Clear()
        Dim SqlDAdapter As New SqlClient.SqlDataAdapter
        Dim Cnn As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim SqlCmm As New SqlClient.SqlCommand
        Try
            SqlCmm.CommandText = SelectNewInPatientPrepareOT(PatientNo)
            SqlCmm.Connection = Cnn
            SqlDAdapter.SelectCommand = SqlCmm
            SqlDAdapter.Fill(DSPrepareOTList.V_NewInpatientDetial)
            SqlDAdapter.Dispose()
            SqlCmm.Dispose()
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
   
    Private Sub GridDaillyBook_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Try
        '    Dim DiallyNo As String = GridDiallyBook.Rows(e.RowIndex).Cells(0).Value
        '    Dim NewInpatientNo As String = GridDiallyBook.Rows(e.RowIndex).Cells(1).Value
        '    Dim PatientNo As String = GridDiallyBook.Rows(e.RowIndex).Cells(2).Value
        '    Dim Eye As String = GridDiallyBook.Rows(e.RowIndex).Cells(3).Value
        '    Dim Treatment As String = GridDiallyBook.Rows(e.RowIndex).Cells(4).Value
        '    Dim FDiallyBook As New FRMDaillyBook
        '    FDiallyBook.LblSaveOption.Text = DiallyNo
        '    FDiallyBook.LblNewInpatientNo.Text = NewInpatientNo
        '    FDiallyBook.TxtPatientNo.Text = PatientNo
        '    FDiallyBook.CboEye.Text = Eye
        '    FDiallyBook.TxtTreatment.Text = Treatment
        '    FDiallyBook.ShowDialog()
        '    If FDiallyBook.isCloseDaillBook = True Then
        '        GridDiallyBook.DataSource = ModDaillyBook.SelectDiallyByNo(FDiallyBook.LblNewInpatientNo.Text)
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Function FindNewInpatientHistory(ByVal DateFollowUp As String, ByVal PatientNo As String) As String
        Dim sql As String = "SELECT * FROM V_NewInPatientDetial WHERE Leave<>'0' AND CONVERT(VARCHAR(10),DateDischarge, 103)>= CONVERT(VARCHAR(10),CAST('" & DateFollowUp & "' as DATETIME),103) "
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        Return sql
    End Function

    Private Sub BtnNewInpatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInpatient.Click
        Dim FNewInpatient As New FRMNewInPatient(Me)
        FNewInpatient.ShowDialog()
        'If FNewInpatient.ShowDialog() = DialogResult.OK Then
        '    BtnDailyInpatient_Click(sender, e)
        'End If
        ' ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text)
        FNewInpatient.Dispose()
        FNewInpatient.Close()
        FNewInpatient.Dispose()
    End Sub

   

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Try
            'If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
            Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
            Dim RowIndex As Integer = ModCommon.GetRowIndexDataGrid(GridDiallyBook)
            Dim DaillyNo As Integer = GridDiallyBook.Rows(RowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModDaillyBook.DeleteDaillyBook(DaillyNo) = 1 Then
                    MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                    GridDiallyBook.DataSource = ModDaillyBook.SelectDiallyByNo(NewInNo)
                Else
                    MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
            'End If

        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub ReferalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReferal.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 1 Then
                    MsgBox("This patient is waiting for operation. If patient wants to leave then must set to normal In-patient.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                Dim DialogLeave As DialogResult = MessageBox.Show("Are you sure, this patient will leave today?", "Leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogLeave = DialogResult.Yes Then
                    If ModNewInPatient.UpdateLeave(NewInNo, "1") = 1 Then     ' ------------for Referal (Leave)-----------------

                        Dim FDateFollowUp As New FrmDateFollowUP
                        FDateFollowUp.LblSaveOption.Text = NewInNo
                        FDateFollowUp.ShowDialog()
                        If FDateFollowUp.isClose = True Then
                            MsgBox("This patient set to leave the hospital.", MsgBoxStyle.Information, "Leave")
                        Else
                            FDateFollowUp.Close()
                            FDateFollowUp.Dispose()
                        End If
                        FindAction("", "", "")
                        ' ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text)
                    Else
                        MsgBox("Error update patient leave. Could contact system administrator", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PermissionLeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPermissionLeave.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 1 Then
                    MsgBox("This patient is waiting operation. If patient want leave must set to normal In-patient.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                Dim DialogLeave As DialogResult = MessageBox.Show("Are you sure, this patient will leave today?", "Leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogLeave = DialogResult.Yes Then
                    If ModNewInPatient.UpdateLeave(NewInNo, "2") = 1 Then     ' ------------for Referal (Leave)-----------------

                        Dim FDateFollowUp As New FrmDateFollowUP
                        FDateFollowUp.LblSaveOption.Text = NewInNo
                        FDateFollowUp.ShowDialog()
                        FDateFollowUp.Close()
                        FDateFollowUp.Dispose()
                        MsgBox("This patient set to leaved hospital.", MsgBoxStyle.Information, "Leave")
                        FindAction("", "", "")
                        'ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text)
                    Else
                        MsgBox("Error update patient leave. Could contact system administrator", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NoPermissionLeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNoPermissionLeave.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 1 Then
                    MsgBox("This patient is waiting operation. If patient want leave must set to normal In-patient.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                Dim DialogLeave As DialogResult = MessageBox.Show("Are you sure, this patient will leave today?", "Leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogLeave = DialogResult.Yes Then
                    If ModNewInPatient.UpdateLeave(NewInNo, "3") = 1 Then     ' ------------for Referal (Leave)-----------------
                        Dim FDateFollowUp As New FrmDateFollowUP
                        FDateFollowUp.LblSaveOption.Text = NewInNo
                        FDateFollowUp.ShowDialog()
                        FDateFollowUp.Close()
                        FDateFollowUp.Dispose()
                        MsgBox("This patient set to leaved hospital.", MsgBoxStyle.Information, "Leave")
                        FindAction("", "", "")
                        'ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text)
                    Else
                        MsgBox("Error update patient leave. Could contact system administrator", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BgLoadNewInpatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadNewInpatient.DoWork
        Try
            FillNewInPatientNormal()
            Me.View_OTRegistrationTableAdapter.Fill(Me.DSWardWithOT.View_OTRegistration)
            Me.V_IOLRegistrationTableAdapter.Fill(Me.DSWardWithOT.V_IOLRegistration)
            'FillNewInpatientOT()
            'Me.View_OTRegistrationTableAdapterPrepare.Fill(Me.DSPrepareOTList.View_OTRegistration)
            'Me.V_IOLRegistrationTableAdapterPrepare.Fill(Me.DSPrepareOTList.V_IOLRegistration)
            'FillNewInpatientPrepareOT()
            'Me.V_PrepareOTNewInpatientTableAdapter.Fill(Me.DSWardWithOT.V_PrepareOTNewInpatient)
            'Me.V_PrepareIOLRegistrationTableAdapter.Fill(Me.DSWardWithOT.V_PrepareIOLRegistration)
            If (BgLoadNewInpatient.CancellationPending) Then ' Test if user hit Cancel key
                e.Cancel = True
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BgLoadNewInpatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadNewInpatient.RunWorkerCompleted
        BtnFind.Enabled = True
        Me.FMain.StatusLoading(False)
        TxtPatientNo.Enabled = True
        BtnReloadData.Enabled = True
        BtnShow.Enabled = True
        CountDailyInpatient()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FPrepareForOperation As New FRMPreparedForOperation
        FPrepareForOperation.OptionReport = 1
        FPrepareForOperation.Title1 = "HOSPITAL-OPERATION LIST"
        FPrepareForOperation.Title2 = Format(Now, "dd-MMM-yyyy")
        FPrepareForOperation.ShowDialog()
        FPrepareForOperation.Dispose()
        FPrepareForOperation.Close()
    End Sub

    Sub CountDailyInpatient()
        'GDailyInpatient.Text = "Nurse on call by date: " & Format(ModGlobleVariable.GeteDateServer, "dd/MM/yyyy")
        ' Dialy In-Patient
        Dim InPatient As Integer = ModNewInPatient.TotalInpatient(ModGlobleVariable.GeteDateServer)
        Dim Admmision As Integer = ModNewInPatient.TotalAdmmision(ModGlobleVariable.GeteDateServer)
        Dim Discharge As Integer = ModNewInPatient.TotalDischarge(ModGlobleVariable.GeteDateServer)
        Dim Total As Integer = ModNewInPatient.TotalAllNewInaptient
        ' In-patient 
        Dim CataractOT As Integer = ModNewInPatient.CountOTCataractReady(ModGlobleVariable.GeteDateServer)
        Dim OtherOT As Integer = ModNewInPatient.CountOTOtherReady(ModGlobleVariable.GeteDateServer)
        Dim WaitingOT As Integer = ModNewInPatient.CountWaitingOT()
        Dim CorneaUlcer As Integer = ModNewInPatient.CountCorneaUlcer
        Dim Other As Integer = ModNewInPatient.CountOther

        'LblCataractOT.Text = CataractOT
        'LblOtherOT.Text = OtherOT
        'LblTotalSurgery.Text = CataractOT + OtherOT
        'LblWaitingOT.Text = WaitingOT
        'LblCorneaUlcer.Text = CorneaUlcer
        'LblOthers.Text = Other - (CataractOT + OtherOT + WaitingOT)

        'lblInpatient.Text = InPatient
        'LblAdmision.Text = Admmision
        'lblDischarge.Text = Discharge
        'LblTotal.Text = Total '(CInt(lblInpatient.Text) + Admmision) - Discharge
    End Sub

    Private Sub GridNewInPatient_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridNewInPatient.RowDoubleClick
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim FNewInPatient As New FRMNewInPatient(Me)
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Value
                Dim PatientNo As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Value
                Dim PatienName As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(2).Value
                Dim Age As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(3).Value
                Dim Sex As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(4).Value
                Dim address As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(5).Value
                Dim Eye As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(6).Value
                Dim Diagnosis As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(7).Value
                Dim VA_RE As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(8).Value
                Dim VA_LE As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(9).Value
                Try
                    FNewInPatient.DateDischarge.Checked = True
                    FNewInPatient.DateDischarge.Value = GridNewInPatient.SelectedItems(0).GetRow.Cells(10).Value
                Catch ex As Exception
                    FNewInPatient.DateDischarge.Checked = False
                End Try
                Try
                    FNewInPatient.DateFollowUp.Checked = True
                    FNewInPatient.DateFollowUp.Value = GridNewInPatient.SelectedItems(0).GetRow.Cells(11).Value
                Catch ex As Exception
                    FNewInPatient.DateFollowUp.Checked = False
                End Try
                Dim Signature As Boolean = GridNewInPatient.SelectedItems(0).GetRow.Cells(12).Value
                Dim TypeDiagnosis As Boolean = GridNewInPatient.SelectedItems(0).GetRow.Cells(16).Value
                Dim Waiting As Boolean = GridNewInPatient.SelectedItems(0).GetRow.Cells(14).Value
                FNewInPatient.LblSaveOption.Text = NewInNo
                FNewInPatient.TxtPatientNo.Text = PatientNo
                FNewInPatient.TxtPatientName.Text = PatienName
                FNewInPatient.TxtAge.Text = Age
                FNewInPatient.TxtSex.Text = Sex
                FNewInPatient.TxtAddress.Text = address
                FNewInPatient.CboEye.Text = Eye
                FNewInPatient.CboDiagnosis.Text = Diagnosis
                FNewInPatient.TxtVARE.Text = VA_RE
                FNewInPatient.txtVALE.Text = VA_LE
                FNewInPatient.ChSignature.Checked = Signature
                FNewInPatient.ChTypeOther.Checked = TypeDiagnosis
                'FNewInPatient.ChWaitingOT.Checked = Waiting
                FNewInPatient.ShowDialog()
                If FNewInPatient.isCloseNewInPatient = True Then
                    FindAction(FNewInPatient.TxtPatientNo.Text, "", "")
                End If
                FNewInPatient.Dispose()
                FNewInPatient.Close()
            End If
            If GridNewInPatient.SelectedItems(0).Table.Key = "IOLRegistration" Then
                'If GridNewInPatient.GetRow.Cells("Waiting").Value = 3 Then
                '    MessageBox.Show("You can not edit Operation. Because this patient already operate.", "OT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Else
                Dim fIOL As New FRMIOLRegistration
                fIOL.LblOptionSave.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Value
                fIOL.LblOTNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Value
                fIOL.txtPatientNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(2).Value
                fIOL.TxtName.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(3).Value
                fIOL.TxtAge.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(4).Value
                fIOL.TxtSex.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(5).Value
                fIOL.CboSurgeon.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(6).Value
                fIOL.CboEye.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(7).Value
                fIOL.CboIOLItem.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(8).Value
                fIOL.ShowDialog()
                If fIOL.isClose = True Then
                    FindAction(EmptyString(fIOL.txtPatientNo.Text), "", "")
                End If
                fIOL.Dispose()
                fIOL.Close()
                'End If

            End If
            If GridNewInPatient.SelectedItems(0).Table.Key = "OTRegistration" Then
                Try
                
                    If GridNewInPatient.SelectedItems(0).GetRow.Cells("Status").Value = True Then
                        MessageBox.Show("You can not edit Operation. Because this patient already operate.", "OT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim FOTRegistration As New FRMOTRegistration
                        FOTRegistration.LblSaveOption.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Value
                        FOTRegistration.TxtInpatientNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Value
                        FOTRegistration.TxtPatientNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(2).Value
                        FOTRegistration.TxtPatientName.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(3).Value
                        FOTRegistration.TxtAge.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(4).Value
                        FOTRegistration.TxtSex.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(5).Value
                        FOTRegistration.TxtAddress.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(6).Value
                        Try
                            FOTRegistration.CboOperationTime.Checked = True
                            FOTRegistration.CboOperationTime.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(7).Value
                        Catch ex As Exception
                            FOTRegistration.CboOperationTime.Checked = False
                        End Try

                        FOTRegistration.TxtAnesthesia.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(8).Value
                        FOTRegistration.CboAnesthetist.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(9).Value
                        FOTRegistration.CboEye.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(10).Value
                        FOTRegistration.CboOperationType.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(11).Value
                        FOTRegistration.CboIOLItem.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(12).Value
                        FOTRegistration.CboSurgeon.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(13).Value
                        FOTRegistration.CboAssistant.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(14).Value
                        FOTRegistration.TxtCirculation.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(15).Value
                        FOTRegistration.TxtCompli.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(16).Value
                        Try
                            FOTRegistration.DateOperated.Checked = True
                            FOTRegistration.DateOperated.Value = GridNewInPatient.SelectedItems(0).GetRow.Cells(18).Value
                        Catch ex As Exception
                            FOTRegistration.DateOperated.Checked = False
                        End Try
                        FOTRegistration.TxtOther.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells(19).Value
                        FOTRegistration.ShowDialog()
                        If FOTRegistration.isCloseOT = True Then
                            FindAction(EmptyString(FOTRegistration.TxtPatientNo.Text), "", "")
                        End If
                        FOTRegistration.Dispose()
                        FOTRegistration.Close()
                    End If
                    

                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub
  
 
    Private Sub GridNewInPatient_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridNewInPatient.SelectionChanged
        Try
            'If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            '    MCancel.Enabled = False
            '    MUndoCancel.Enabled = False
            'End If
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                BtnPrepareOTRegistrattion1.Enabled = True
                BtnPrepareOTRegistrattion.Enabled = True
                BtnMovePatientWaiting1.Enabled = True
                BtnMovePatientWaiting.Enabled = True
                BtnSetToNormal1.Enabled = True
                BtnSetToNormal.Enabled = True
                PictureBox1.Image = ByteArrayToImage(DAPatientWait.SelectPicture(GridNewInPatient.GetRow.Cells("PatientNo").Value))
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 1 Then
                    BtnPrepareOTRegistrattion1.Enabled = False
                    BtnPrepareOTRegistrattion.Enabled = False
                    BtnSetToNormal1.Enabled = True
                End If
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 0 Then
                    BtnMovePatientWaiting1.Enabled = False
                    BtnMovePatientWaiting.Enabled = False
                    BtnSetToNormal1.Enabled = True
                End If
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 3 Then
                    BtnSetToNormal1.Enabled = False
                    BtnSetToNormal.Enabled = False
                    BtnSetToNormal1.Enabled = True
                End If
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                'GridDiallyBook.DataSource = ModDaillyBook.SelectDaillyBookByNewInpatient(NewInNo)
            End If
        Catch ex As Exception
        End Try
    End Sub

  

    Private Sub OTRegistrationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrepareOTRegistrattion1.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Double = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                Dim PatientNo As Double = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Text
                Dim PatientName As String = GridNewInPatient.SelectedItems(0).GetRow.Cells("NameEng").Text
                Dim Age As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(3).Text
                Dim Sex As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(4).Text
                Dim Address As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(5).Text
                Dim FOTRegistration As New FRMOTRegistration
                FOTRegistration.TxtPatientNo.Text = PatientNo
                FOTRegistration.TxtInpatientNo.Text = NewInNo
                FOTRegistration.TxtPatientName.Text = PatientName
                FOTRegistration.TxtAge.Text = Age
                FOTRegistration.TxtSex.Text = Sex
                FOTRegistration.TxtAddress.Text = Address
                FOTRegistration.ShowDialog()
                If FOTRegistration.isCloseOT = True Then
                    FindAction("", "", "")
                End If
                FOTRegistration.Dispose()
                FOTRegistration.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub SubMoveToListOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMovePatientWaiting1.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you realy want move to prepare OT list?", "OT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = Windows.Forms.DialogResult.Yes Then
                    Dim NewInPatientNo As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                    ModNewInPatient.UpdateOTWating(NewInPatientNo, 2)
                    ModNewInPatient.UpdateOTHistory(NewInPatientNo, 2, Now.Date)
                    FindAction("", "", "")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MoveToWaitingOTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToWaitingOTToolStripMenuItem.Click
        'Try
        '    If GridPrepareOT.SelectedItems(0).Table.Key = "PatientInfo" Then
        '        Dim dialogResult As DialogResult = MessageBox.Show("Do you realy want move to prepare OT list?", "OT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '        If dialogResult = Windows.Forms.DialogResult.Yes Then
        '            Dim NewInPatientNo As String = GridPrepareOT.SelectedItems(0).GetRow.Cells(0).Text
        '            ModNewInPatient.UpdateOTWating(NewInPatientNo, 1)
        '            ModNewInPatient.UpdateOTHistory(NewInPatientNo, 1, Now.Date)
        '            FindAction("", "", "")
        '        End If
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Sub FindAction(ByVal PatientNoFind As String, ByVal DateFrom1 As String, ByVal DateTo1 As String)
        PatientNo = PatientNoFind
        DateFrom = datefrom1
        DateTo = DateTo1
        BtnFind.Enabled = False
        Me.FMain.StatusLoading(True)
        TxtPatientNo.Enabled = False
        BtnReloadData.Enabled = False
        BtnShow.Enabled = False
        BgLoadNewInpatient.RunWorkerAsync()
    End Sub

    Private Sub BtnDailyInpatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FindAction("", "", "")
        'If MessageBox.Show("Do you want save daily in-patient record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    If ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text) = 1 Then
        '        MsgBox("Save Daily nurse oncall successfully.", MsgBoxStyle.Information, "Save")
        '    End If
        'End If
    End Sub

    Private Sub BtnViewDailyInpatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FDailyInpatient As New FrmDailyInpatient
        FDailyInpatient.ShowDialog()
        FDailyInpatient.Close()
        FDailyInpatient.Dispose()
    End Sub


    Private Sub BtnReportDisease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportDisease.Click
        Dim FWardPreview As New FRMWardPreview
        FWardPreview.ShowDialog()
        FWardPreview.Close()
        FWardPreview.Dispose()
    End Sub

    Private Sub BtnViewListOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If BtnViewListOT.ImageIndex = 0 Then
        '    ' SplitContainer1.Panel2Collapsed = True
        '    BtnViewListOT.ImageIndex = 1
        'Else
        '    '  SplitContainer1.Panel2Collapsed = False
        '    BtnViewListOT.ImageIndex = 0
        'End If
    End Sub

    Private Sub BtnFindHistoryPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindHistoryPatient.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim FOTRegistration As New FRMOTRegistration
                FOTRegistration.TxtPatientNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("PatientNo").Text
                FOTRegistration.TxtInpatientNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("NewInPatientNo").Text
                FOTRegistration.TxtPatientName.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("NameEng").Text
                FOTRegistration.TxtAge.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Age").Text
                FOTRegistration.TxtSex.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Sex").Text
                FOTRegistration.TxtAddress.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Address").Text
                FOTRegistration.CboEye.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Eye").Text
                FOTRegistration.CboOperationType.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("DiagnosisTem").Text
                FOTRegistration.ShowDialog()
                If FOTRegistration.isCloseOT = True Then
                    FindAction("", "", "")
                End If
                FOTRegistration.Dispose()
                FOTRegistration.Close()
            End If
        Catch ex As Exception
        End Try
        'Dim FFindInpatientHistory As New FrmFindInPatientHistory
        'FFindInpatientHistory.ShowDialog()
        'FFindInpatientHistory.Close()
        'FFindInpatientHistory.Dispose()
    End Sub

    Private Sub SetToNormalInPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetToNormal1.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you realy want to set this patient to normal In-patient?", "OT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = Windows.Forms.DialogResult.Yes Then
                    Dim NewInPatientNo As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                    ' Update To Normal In-Patient
                    ModNewInPatient.UpdateOTWating(NewInPatientNo, 0)
                    ' Delete Patient IOL in OT
                    ModOTRegistration.DeleteIOLByNewInpatient(NewInPatientNo)
                    ' Delete Patient From OT
                    ModOTRegistration.DeleteOTByNewInpatient(NewInPatientNo)
                    FindAction("", "", "")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        FindAction("", DateFromAdmid.Value, DateToAdmid.Value)
    End Sub

    Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                DIALOG_DELETE = MessageBox.Show("Do you want to cancel?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_DELETE = DialogResult.Yes Then
                    If ModNewInPatient.CancelNewInpatient(NewInNo) = 1 And ModNewInPatient.DeleteDaillyBookByNewInNo(NewInNo) >= 0 Then
                        MsgBox("Cancel new inpatient successful.", MsgBoxStyle.Information, "Delete")
                        FindAction("", "", "")
                        'ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text)
                        'GridDiallyBook.DataSource = ModDaillyBook.SelectDiallyByNo(NewInNo)
                    Else
                        MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Could you select New in-patient.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MUndoCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndoCancel.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                DIALOG_DELETE = MessageBox.Show("Do you want to undo cancel?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_DELETE = DialogResult.Yes Then
                    If ModNewInPatient.UndoCancelNewInPatient(NewInNo) = 1 And ModNewInPatient.UndoDeleteDiallyBook(NewInNo) >= 0 Then
                        MsgBox("Undo cancel new inpatient successful.", MsgBoxStyle.Information, "Delete")
                        FindAction("", "", "")
                        'ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text)
                        'GridDiallyBook.DataSource = ModDaillyBook.SelectDiallyByNo(NewInNo)
                    Else
                        MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Could you select New in-patient.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnUndoInPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fListUndo As New FrmListUndoPatient
        fListUndo.ShowDialog()
        fListUndo.Close()
        fListUndo.Dispose()
    End Sub

  

    Private Sub BtnReloadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReloadData.Click

        Try
            FindAction("", "", "")
            GridNewInPatient.RootTable.Groups.Remove(Me.GridNewInPatient.RootTable.Groups(0))
        Catch ex As Exception
            ' Display message for sort not add .
        End Try

    End Sub

    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindAction(TxtPatientNo.Text, "", "")
        End If
    End Sub

    Private Sub TxtPatientNo_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindAction(TxtPatientNo.Text, "", "")
    End Sub

    Private Sub BtnNewDiallyBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewDiallyBook.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim frmDaillyBook As New FRMDaillyBook
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                Dim PatientNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Text
                frmDaillyBook.TxtPatientNo.Text = PatientNo
                frmDaillyBook.LblNewInpatientNo.Text = NewInNo
                frmDaillyBook.ShowDialog()
                If frmDaillyBook.isCloseDaillBook = True Then
                    ' GridDiallyBook.DataSource = ModDaillyBook.SelectDaillyBookByNewInpatient(frmDaillyBook.LblNewInpatientNo.Text)
                End If
                frmDaillyBook.Close()
                frmDaillyBook.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Could you select patient info.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnPrepareOTRegistrattion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrepareOTRegistrattion.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                Dim PatientNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Text
                Dim PatientName As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(2).Text
                Dim Age As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(3).Text
                Dim Sex As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(4).Text
                Dim Address As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(5).Text
                Dim FOTRegistration As New FRMOTRegistration
                FOTRegistration.TxtPatientNo.Text = PatientNo
                FOTRegistration.TxtInpatientNo.Text = NewInNo
                FOTRegistration.TxtPatientName.Text = PatientName
                FOTRegistration.TxtAge.Text = Age
                FOTRegistration.TxtSex.Text = Sex
                FOTRegistration.TxtAddress.Text = Address
                FOTRegistration.ShowDialog()
                If FOTRegistration.isCloseOT = True Then
                    FindAction("", "", "")
                End If
                FOTRegistration.Dispose()
                FOTRegistration.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnMovePatientWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMovePatientWaiting.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you realy want move to prepare OT list?", "OT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = Windows.Forms.DialogResult.Yes Then
                    Dim NewInPatientNo As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                    ModNewInPatient.UpdateOTWating(NewInPatientNo, 2)
                    ModNewInPatient.UpdateOTHistory(NewInPatientNo, 2, Now.Date)
                    FindAction("", "", "")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSetToNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetToNormal.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you realy want to set this patient to normal In-patient?", "OT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = Windows.Forms.DialogResult.Yes Then
                    Dim NewInPatientNo As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                    ' Update To Normal In-Patient
                    ModNewInPatient.UpdateOTWating(NewInPatientNo, 0)
                    ' Delete Patient IOL in OT
                    ModOTRegistration.DeleteIOLByNewInpatient(NewInPatientNo)
                    ' Delete Patient From OT
                    ModOTRegistration.DeleteOTByNewInpatient(NewInPatientNo)
                    ModNewInPatient.UpdateOTHistory(NewInPatientNo, 0, Now.Date)
                    FindAction("", "", "")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Referal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Referal.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 1 Then
                    MsgBox("This patient is waiting for operation. If patient wants to leave then must set to normal In-patient.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                Dim DialogLeave As DialogResult = MessageBox.Show("Are you sure, this patient will leave today?", "Leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogLeave = DialogResult.Yes Then
                    If ModNewInPatient.UpdateLeave(NewInNo, "1") = 1 Then     ' ------------for Referal (Leave)-----------------

                        Dim FDateFollowUp As New FrmDateFollowUP
                        FDateFollowUp.LblSaveOption.Text = NewInNo
                        FDateFollowUp.ShowDialog()
                        If FDateFollowUp.isClose = True Then
                            MsgBox("This patient set to leave the hospital.", MsgBoxStyle.Information, "Leave")
                        Else
                            FDateFollowUp.Close()
                            FDateFollowUp.Dispose()
                        End If
                        FindAction("", "", "")
                    Else
                        MsgBox("Error update patient leave. Could contact system administrator", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PermissionLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionLeave.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 1 Then
                    MsgBox("This patient is waiting operation. If patient want leave must set to normal In-patient.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                Dim DialogLeave As DialogResult = MessageBox.Show("Are you sure, this patient will leave today?", "Leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogLeave = DialogResult.Yes Then
                    If ModNewInPatient.UpdateLeave(NewInNo, "2") = 1 Then     ' ------------for Referal (Leave)-----------------

                        Dim FDateFollowUp As New FrmDateFollowUP
                        FDateFollowUp.LblSaveOption.Text = NewInNo
                        FDateFollowUp.ShowDialog()
                        FDateFollowUp.Close()
                        FDateFollowUp.Dispose()
                        MsgBox("This patient set to leaved hospital.", MsgBoxStyle.Information, "Leave")
                        FindAction("", "", "")

                    Else
                        MsgBox("Error update patient leave. Could contact system administrator", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NoPermissionLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoPermissionLeave.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                If GridNewInPatient.SelectedItems(0).GetRow.Cells("Waiting").Value = 1 Then
                    MsgBox("This patient is waiting operation. If patient want leave must set to normal In-patient.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                Dim DialogLeave As DialogResult = MessageBox.Show("Are you sure, this patient will leave today?", "Leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogLeave = DialogResult.Yes Then
                    If ModNewInPatient.UpdateLeave(NewInNo, "3") = 1 Then     ' ------------for Referal (Leave)-----------------
                        Dim FDateFollowUp As New FrmDateFollowUP
                        FDateFollowUp.LblSaveOption.Text = NewInNo
                        FDateFollowUp.ShowDialog()
                        FDateFollowUp.Close()
                        FDateFollowUp.Dispose()
                        MsgBox("This patient set to leaved hospital.", MsgBoxStyle.Information, "Leave")
                        FindAction("", "", "")
                    Else
                        MsgBox("Error update patient leave. Could contact system administrator", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveDailyInPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDailyInPatient.Click
        'FindAction("", "", "")
        'Dim dialogResult As DialogResult = MessageBox.Show("Do you want save daily in-patient record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If dialogResult = Windows.Forms.DialogResult.Yes Then
        '    If ModNewInPatient.SaveDailyCountPatient(ModGlobleVariable.GeteDateServer, lblInpatient.Text, LblAdmision.Text, lblDischarge.Text, LblTotal.Text, LblTotalSurgery.Text, LblCataractOT.Text, LblOtherOT.Text, LblCorneaUlcer.Text, LblWaitingOT.Text, LblOthers.Text, TxtNote.Text) = 1 Then
        '        MsgBox("Save Daily nurse oncall successfully.", MsgBoxStyle.Information, "Save")
        '    End If
        'End If
    End Sub

    Private Sub ViewDailyInpatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDailyInpatient.Click
        Dim FDailyInpatient As New FrmDailyInpatient
        FDailyInpatient.ShowDialog()
        FDailyInpatient.Close()
        FDailyInpatient.Dispose()
    End Sub

    Private Sub Statistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Statistic.Click
        Dim FStatistictNewInPatient As New FrmWardNewInPatient
        FStatistictNewInPatient.ShowDialog()
        FStatistictNewInPatient.Close()
        FStatistictNewInPatient.Dispose()
    End Sub


    Private Sub BtnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrder.Click
        Try
            'FindAction("", "", "")
            'GridNewInPatient.RootTable.Groups.Remove(Me.GridNewInPatient.RootTable.Groups(0))
            GroupDataGridForInPatient.Column = GridNewInPatient.RootTable.Columns(14)
            GroupDataGridForInPatient.AllowRemove = True
            GroupDataGridForInPatient.GroupInterval = Janus.Windows.GridEX.GroupInterval.Text
            GroupDataGridForInPatient.GroupPrefix = "Type of Patient:"
            GroupDataGridForInPatient.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
            'sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
            GridNewInPatient.RootTable.Groups.Add(GroupDataGridForInPatient)
            GroupDataGridForInPatient.Collapse()
            Dim FTypeOfPatient As New FormTypeOfPatient
            FTypeOfPatient.ShowDialog()
            FTypeOfPatient.Close()
            FTypeOfPatient.Dispose()
            Me.Focus()
        Catch ex As Exception
            ' Error when select data grid not yet add group.
        End Try

    End Sub

    Private Sub BtnViewOTHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewOTHistory.Click
        Dim FPrepareForOperation As New FRMPreparedForOperation
        FPrepareForOperation.OptionReport = 2
        FPrepareForOperation.DateFrom = DateFromAdmid.Value.Date
        FPrepareForOperation.DateTo = DateToAdmid.Value.Date
        FPrepareForOperation.Title1 = "History Hospital Operation List"
        FPrepareForOperation.Title2 = " From " & Format(DateFromAdmid.Value, "dd-MMM-yyyy") & " To " & Format(DateToAdmid.Value, "dd-MMM-yyyy")
        FPrepareForOperation.ShowDialog()
    End Sub

    Private Sub ScleralBucklingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FScleralBucling As New FormScleralBuckling
        FScleralBucling.ShowDialog()
    End Sub

    Private Sub InjectionNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FInjection As New FormIntravitrealInjection
        FInjection.ShowDialog()
    End Sub

    Private Sub UCNewInPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FindAction("", "", "")
            GridNewInPatient.RootTable.Groups.Remove(Me.GridNewInPatient.RootTable.Groups(0))
        Catch ex As Exception
            ' Display message for sort not add .
        End Try
    End Sub

    Private Sub PrepareOTRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrepareOTRegistrationToolStripMenuItem.Click
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim FOTRegistration As New FRMOTRegistration
                FOTRegistration.TxtPatientNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("PatientNo").Text
                FOTRegistration.TxtInpatientNo.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("NewInPatientNo").Text
                FOTRegistration.TxtPatientName.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("NameEng").Text
                FOTRegistration.TxtAge.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Age").Text
                FOTRegistration.TxtSex.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Sex").Text
                FOTRegistration.TxtAddress.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Address").Text
                FOTRegistration.CboEye.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("Eye").Text
                FOTRegistration.CboOperationType.Text = GridNewInPatient.SelectedItems(0).GetRow.Cells("DiagnosisTem").Text
                FOTRegistration.ShowDialog()
                If FOTRegistration.isCloseOT = True Then
                    FindAction("", "", "")
                End If
                FOTRegistration.Dispose()
                FOTRegistration.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
