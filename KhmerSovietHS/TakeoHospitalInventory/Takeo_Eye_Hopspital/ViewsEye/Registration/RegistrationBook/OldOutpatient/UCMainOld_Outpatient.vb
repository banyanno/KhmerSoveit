Public Class UCMainOld_Outpatient
    Dim TblOld_OutPatientTem, TblDailyOldReport, TblOtherOld As DataTable
    Dim PNo As String
    Dim DFrom, DailyDFrom As Date
    Dim DTo, DailyDTo As Date
    Dim TotalF As Integer
    Dim TotalM As Integer
    Dim TotalNil As Integer
    Dim TotalCancel As Integer
    Dim TotalNotFillDiagnosis As Integer
    Dim Total As Integer
    Dim TotalOldPatientRiel As Integer
    Dim TotalOldPatientDolar As Integer
    Private CrOldOutpatient As New CROutPatientReport
    Private CrOther As New CrOtherOldPatient
    Dim xx, yy As Integer
    Dim TotalRiel As Integer = 0
    Dim TotalNumbRiel As Integer = 0
    Dim TotalNumbFRiel As Integer = 0
    Dim TotalFRiel As Integer = 0
    Dim MainTakeoInventory As MainTakeoInventory
    Dim IS_Fill As Integer '0 for not , 1 not fill VA
    Sub New(ByVal MainTakeoInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainTakeoInventory = MainTakeoInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnOldDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOldDisplay.Click

        ShowSplitPanel(SplitContOldOutpatient, 1)
        IS_Fill = 3
        CallBgWork()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        Me.tbCountMoney.Visible = False
    End Sub
    Private Sub CallBgWork()
        PNo = TxtPatientNo.Text
        DFrom = DateOldFrom.Value
        DTo = DateOldTo.Value
        BtnOldDisplay.Enabled = False
        Me.MainTakeoInventory.StatusLoading(True)
        BgOldOutPatient.RunWorkerAsync()
    End Sub
    Private Sub CallBgLoadReport()
        DailyDFrom = DailyDateFrom.Value
        DailyDTo = DailyDateTo.Value
        BtnPrintPreview.Enabled = False
        Me.MainTakeoInventory.StatusLoading(True)
        BgLoadReport.RunWorkerAsync()
    End Sub

   

    Private Sub CreateOldOutpatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateOldOutpatientToolStripMenuItem.Click
        Dim FOld_Outpatient As New FRMOld_Outpatient
        FOld_Outpatient.ShowDialog()
        If FOld_Outpatient.DialogResult = DialogResult.OK Then
            GridEXOldPatient.DataSource = ModOld_Outpatient.SelectOldDetailByReceiptNo(FOld_Outpatient.TxtReceiptNo.Text, FOld_Outpatient.Text)
        End If
    End Sub

   

    'Private Sub BtnOldStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOldStatistic.Click
    '    'Dim FOldStatistic As New FRMOldoutPatientStatistic
    '    'FOldStatistic.ShowDialog()
    '    Dim FStatisticOld As New FRMStatisticOldPatient
    '    FStatisticOld.ShowDialog()
    '    FStatisticOld.Close()
    '    FStatisticOld.Dispose()
    'End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub BgOldOutPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgOldOutPatient.DoWork
        If IS_Fill = 0 Then
            TblOld_OutPatientTem = ModOld_Outpatient.SelectOldPatientDetailByDateNotFillDiagnosis(EmptyString(PNo), DFrom, DTo, "")
        ElseIf IS_Fill = 1 Then
            TblOld_OutPatientTem = ModOld_Outpatient.SelectOldPatienDetailbyDateNotVA(EmptyString(PNo), DFrom, DTo)
        ElseIf IS_Fill = 3 Then
            TblOld_OutPatientTem = ModOld_Outpatient.SelectOldPatientDetailByDate(EmptyString(PNo), DFrom, DTo)
        End If

        TotalOldPatientRiel = ModOld_Outpatient.SumOldPatientRiel(DFrom, DTo)
        TotalOldPatientDolar = ModOld_Outpatient.SumOldPatientDolar(DFrom, DTo)
        TotalM = ModNew_Outpatient.CMaleForOldPatient("V_NewOutpatientDetail", DFrom, DTo, 1)
        TotalF = ModNew_Outpatient.CFemaleForOldPatient("V_NewOutpatientDetail", DFrom, DTo, 1)
        TotalNil = ModNew_Outpatient.CNilForOldPatient("V_NewOutpatientDetail", DFrom, DTo, 1)
        TotalCancel = ModNew_Outpatient.CountCanceledForOldPatient("V_NewOutpatientDetail", DFrom, DTo, 1)
        TotalNotFillDiagnosis = ModNew_Outpatient.CountNotFillDiagnosisForOldPatient("V_NewOutpatientDetail", DFrom, DTo, 1)
        Total = TotalM + TotalF
    End Sub

    Private Sub BgOldOutPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgOldOutPatient.RunWorkerCompleted
        GridEXOldPatient.DataSource = TblOld_OutPatientTem
        LblPatientDiagnosis.Text = TotalNotFillDiagnosis

        TxtTotalRiel.Text = TotalOldPatientRiel
        TxtTotalDolar.Text = TotalOldPatientDolar
        LblM.Text = TotalM
        LblF.Text = TotalF
        LblMF.Text = Total
        LblPatientNil.Text = TotalNil
        LblCanceled.Text = TotalCancel
        BtnOldDisplay.Enabled = True
        Me.MainTakeoInventory.StatusLoading(False)
        IS_Fill = 3
    End Sub
    'Sub PainOldPateintBG()
    '    Dim Diagnosis As String
    '    Dim Cancel As String
    '    For Each rows As DataGridViewRow In GridOldOutPatient.Rows
    '        Diagnosis = rows.Cells.Item("Diagnosis").Value.ToString.Trim
    '        Cancel = rows.Cells.Item("DeleteOption").Value.ToString.Trim
    '        If Diagnosis = "" Then
    '            rows.DefaultCellStyle.BackColor = Color.LightSeaGreen
    '        End If
    '        If Cancel = "True" Then
    '            rows.DefaultCellStyle.BackColor = Color.DarkKhaki
    '        End If
    '    Next
    '    ModCommon.NumberAllRowHeaderDataGrid(GridOldOutPatient)
    'End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        ShowSplitPanel(SplitContOldOutpatient, 0)
        CRVOldPatietDaily.DisplayToolbar = True
        CallBgLoadReport()
    End Sub

    Private Sub BgLoadReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadReport.DoWork
        If BgLoadReport.CancellationPending Then
            e.Cancel = True
            Return
        End If
        TblDailyOldReport = Me.DataTable1TableAdapter.GetDataByOldOut(DailyDTo, DailyDFrom)
    End Sub


    Private Sub BgLoadReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadReport.RunWorkerCompleted
        
        CrOldOutpatient.SetDataSource(TblDailyOldReport)
        CRVOldPatietDaily.ReportSource = CrOldOutpatient
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("Daily Old Out-patient Between  " & Format(DailyDFrom, "dd/MM/yyyy") & " And " & Format(DailyDTo, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVOldPatietDaily.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Label_Title")
        CRVOldPatietDaily.Refresh()
        BtnPrintPreview.Enabled = True
        Me.MainTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub BtnPrintPreviewOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreviewOther.Click
        ShowSplitPanel(SplitContOldOutpatient, 0)
        CRVOldPatietDaily.DisplayToolbar = True
        DailyDFrom = DateOtherFrom.Value
        DailyDTo = DateOtherOld.Value
        BtnPrintPreviewOther.Enabled = False
        PicLoad2.Visible = True
        BgLoadOtherOld.RunWorkerAsync()
    End Sub

    Private Sub BgLoadOtherOld_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadOtherOld.DoWork
        TblOtherOld = Me.TblOtherOldPatientTableAdapter.GetData(DailyDFrom, DailyDTo)
        If BgLoadOtherOld.CancellationPending Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub BgLoadOtherOld_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadOtherOld.RunWorkerCompleted
        BtnPrintPreviewOther.Enabled = True
        PicLoad2.Visible = False
        CrOther.SetDataSource(TblOtherOld)
        CRVOldPatietDaily.ReportSource = CrOther
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("List patient come by others from  " & Format(DailyDFrom, "dd/MM/yyyy") & " to " & Format(DailyDTo, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVOldPatietDaily.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CrOldOutpatient.Refresh()
        CRVOldPatietDaily.Refresh()
    End Sub

    
    

   
    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
        Try

            Dim OldNo As Integer = GridEXOldPatient.GetRow.Cells("NewOutPatientNo").Value  ' GridOldOutPatient.Rows(Rowindex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show("Do you want to cancel?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModNew_Outpatient.UpdateToCancel(OldNo) = 1 Then
                    MsgBox("This patient canceled.", MsgBoxStyle.Information, "Delete")
                    CallBgWork()
                Else
                    MsgBox("Cancel not successfull.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
            MsgBox("Could you select old out-patient.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UndoCancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndo.Click
        Try

            Dim OldNo As Integer = GridEXOldPatient.GetRow.Cells("NewOutPatientNo").Value
            DIALOG_DELETE = MessageBox.Show("Do you realy want to to undo this patient?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModNew_Outpatient.UpdateToUndo(OldNo) = 1 Then
                    MsgBox("This patient undo.", MsgBoxStyle.Information, "Delete")
                    CallBgWork()
                Else
                    MsgBox("Undo not successful.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
            MsgBox("Could you select old out-patient.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EnterDiagnosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEnterDiagnosis.Click
        Try

            Dim FEnterDiagnosis As New FrmEnterNewDialognosis
            FEnterDiagnosis.lblNewPatientNo.Text = GridEXOldPatient.GetRow.Cells("NewOutPatientNo").Value '  GridOldOutPatient.Rows(Rowindex).Cells("OldNo").Value
            FEnterDiagnosis.txtPatientNo.Text = GridEXOldPatient.GetRow.Cells("PatientNo").Value ' GridOldOutPatient.Rows(Rowindex).Cells("PatientNo").Value
            FEnterDiagnosis.ShowDialog()
            If FEnterDiagnosis.saveSucc = True Then
                CallBgWork()
            End If
            FEnterDiagnosis.Close()
            FEnterDiagnosis.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub GridOldOutPatient_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            MCancel.Enabled = False
            MUndo.Enabled = False
        End If

        'If RoleAccess <> "Administrator" Then
        '    MCancel.Enabled = False
        '    MUndo.Enabled = False
        'End If
    End Sub

    Private Sub BtnStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatistic.Click
        Dim FOldStatistic As New FRMStatisticOldPatient
        FOldStatistic.ShowDialog()
        FOldStatistic.Close()
        FOldStatistic.Dispose()
    End Sub

    Function CheckListViewItem(ByVal LVW As ListView, ByVal PN As String) As Boolean
        Dim i As Integer
        For i = 0 To LVW.Items.Count - 1
            If PN = LVW.Items(i).SubItems(1).Text Then
                CheckListViewItem = True
                Exit For
            End If
        Next
    End Function

    Function CheckListViewItemDollar(ByVal LVW As ListView, ByVal PN As String) As Boolean
        Dim i As Integer
        For i = 0 To LVW.Items.Count - 1
            If PN = LVW.Items(i).SubItems(2).Text Then
                CheckListViewItemDollar = True
                Exit For
            End If
        Next
    End Function

    Function CheckListViewItemSign(ByVal LVW As ListView, ByVal PN As String) As Boolean
        Dim i As Integer
        For i = 0 To LVW.Items.Count - 1
            If PN = LVW.Items(i).SubItems(0).Text Then
                CheckListViewItemSign = True
                Exit For
            End If
        Next
    End Function

    Function CheckListViewItemSignDollar(ByVal LVW As ListView, ByVal PN As String) As Boolean
        Dim i As Integer
        For i = 0 To LVW.Items.Count - 1
            If PN = LVW.Items(i).SubItems(1).Text Then
                CheckListViewItemSignDollar = True
                Exit For
            End If
        Next
    End Function

    Function GetListViewItem(ByVal LVW As ListView, ByVal PN As Integer) As Integer
        Dim i As Integer
        For i = 0 To LVW.Items.Count - 1
            If PN = LVW.Items(i).SubItems(1).Text Then
                GetListViewItem = i
                Exit For
            End If
        Next
    End Function

    Function CountMoney(ByVal Number As Integer, ByVal ColName As String) As Integer
        Dim Numb As Integer
        Try
            With Me.GridEXOldPatient
                For i As Integer = 0 To .RowCount - 1
                    If .GetRow(i).Cells(ColName).Value = Number Then
                        Numb = Numb + 1
                    End If
                Next
            End With
        Catch ex As Exception

        End Try
        
        Return Numb
    End Function

    Private Sub lblQuickSocial_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblQuickSocial.LinkClicked
        If GridEXOldPatient.SelectedItems.Count = 0 Then Exit Sub
        Me.dgvSRiel.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateOldFrom.Value, Me.DateOldTo.Value, "PatientFee", "[Fees Riel]", "CreateDate", "V_OldOutpatientDetail")
        Me.dgvSDolar.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateOldFrom.Value, Me.DateOldTo.Value, "PatientDolar", "[Fees $]", "CreateDate", "V_OldOutpatientDetail")
        ModCommon.NumberAllRowHeaderDataGrid(Me.dgvSRiel)

        Dim i, Amnt, Numb As Integer
        For row As Integer = 0 To Me.dgvSRiel.Rows.Count - 1
            Amnt = Me.dgvSRiel.Rows(row).Cells(0).Value
            '--------------------------Add to datagrid ------------------------
            If CheckListViewItem(Me.lstSocial, Amnt) = False Then
                Numb = CountMoney(Amnt, "PatientFee")
                i = Me.lstSocial.Items.Count + 1
                With Me.lstSocial.Items.Add(i)
                    .SubItems.Add(Amnt)
                    .SubItems.Add(DBNull.Value.ToString)
                    .SubItems.Add(Numb)
                    .SubItems.Add(Convert.ToInt32(.SubItems(1).Text) * Convert.ToInt32(.SubItems(3).Text))
                    TotalNumbRiel += Convert.ToInt32(.SubItems(3).Text)
                    TotalRiel += Convert.ToInt32(.SubItems(4).Text)
                End With
            End If
        Next
        '--------------------------------------------------

        Call CountDollars()
    End Sub

    Sub CountDollars()
        Dim x, AmntD, Numb, TotalNumbs, Totals As Integer

        If CheckListViewItemSign(Me.lstSocial, "0") = False Then
            x = "0"
            With Me.lstSocial.Items.Add(x)
                .BackColor = Color.Blue
                .ForeColor = Color.White
                .SubItems.Add("Total:")
                .SubItems.Add(DBNull.Value.ToString)
                .SubItems.Add(TotalNumbRiel)
                .SubItems.Add(TotalRiel)
            End With
        End If

        For xx As Integer = 0 To Me.dgvSDolar.Rows.Count - 1
            If TypeOf Me.dgvSDolar.Rows(xx).Cells(0).Value Is DBNull Then
            Else
                AmntD = Me.dgvSDolar.Rows(xx).Cells(0).Value
                '--------------------------Add to datagrid ------------------------

                If CheckListViewItemDollar(Me.lstSocial, AmntD) = False Then
                    Numb = CountMoney(AmntD, "PatientDolar")
                    x = Me.lstSocial.Items.Count + 1
                    With Me.lstSocial.Items.Add(x)
                        .SubItems.Add(DBNull.Value.ToString)
                        .SubItems.Add(AmntD)
                        .SubItems.Add(Numb)
                        .SubItems.Add(Convert.ToInt32(.SubItems(2).Text) * Convert.ToInt32(.SubItems(3).Text))
                        TotalNumbs += Convert.ToInt32(.SubItems(3).Text)
                        Totals += Convert.ToInt32(.SubItems(4).Text)
                    End With
                End If
            End If
           
        Next
        If CheckListViewItemSignDollar(Me.lstSocial, "Total Dollar:") = False Then
            Dim n As Integer = 0
            With Me.lstSocial.Items.Add(n)
                .BackColor = Color.Blue
                .ForeColor = Color.White
                .SubItems.Add("Total Dollar:")
                .SubItems.Add(DBNull.Value.ToString)
                .SubItems.Add(TotalNumbs)
                .SubItems.Add(Totals)
            End With
        End If

    End Sub

    Private Sub lblCloseSocial_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCloseSocial.LinkClicked
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        Me.tbCountMoney.Visible = False
    End Sub

    Private Sub tbCountMoney_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCountMoney.MouseDown, TabPage2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            xx = e.X
            yy = e.Y
        End If
    End Sub

    Private Sub tbCountMoney_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCountMoney.MouseMove, TabPage2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.tbCountMoney.Left += e.X - xx
            Me.tbCountMoney.Top += e.Y - yy
        End If
    End Sub

    Private Sub ShowDetailFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDetailFeesToolStripMenuItem.Click
        Me.tbCountMoney.Visible = True
    End Sub

    Private Sub BtnDisplayPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplayPatient.Click
        BtnOldDisplay_Click(sender, e)
    End Sub

    Private Sub BtnOrderDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrderDiagnosis.Click
        ShowSplitPanel(SplitContOldOutpatient, 1)
        IS_Fill = 0
        CallBgWork()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        Me.tbCountMoney.Visible = False

        'GridOldOutPatient.Sort(GridOldOutPatient.Columns("Diagnosis"), System.ComponentModel.ListSortDirection.Ascending)
        'PainOldPateintBG()
    End Sub

    Private Sub GridEXOldPatient_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXOldPatient.RowDoubleClick
        If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            Exit Sub
        End If
        'If RoleAccess <> "Administrator" Then
        '    Exit Sub
        'End If
        Try
            Dim FOld_Outpatient As New FRMOld_Outpatient
            FOld_Outpatient.GReferralFrom.Visible = False
            FOld_Outpatient.DateFollowUp.Checked = True
            FOld_Outpatient.LblSaveOption.Text = GridEXOldPatient.GetRow.Cells("NewOutPatientNo").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(0).Value
            FOld_Outpatient.TxtPatientNo.Text = GridEXOldPatient.GetRow.Cells("PatientNo").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(1).Value
            FOld_Outpatient.TxtReceiptNo.Text = GridEXOldPatient.GetRow.Cells("ReceiptNo").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(2).Value
            FOld_Outpatient.TxtReceiptNo.ReadOnly = True
            FOld_Outpatient.TxtPatientName.Text = GridEXOldPatient.GetRow.Cells("NameKhmer").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(3).Value
            FOld_Outpatient.TxtAge.Text = GridEXOldPatient.GetRow.Cells("Age").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(4).Value
            FOld_Outpatient.TxtSex.Text = GridEXOldPatient.GetRow.Cells("Sex").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(5).Value
            FOld_Outpatient.TxtAddress.Text = GridEXOldPatient.GetRow.Cells("Address").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(6).Value
            Dim Riel As String = GridEXOldPatient.GetRow.Cells("PatientFee").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(7).Value
            If Riel <> "0" Then
                FOld_Outpatient.RadioDolar.Checked = False
                FOld_Outpatient.RadioRiel.Checked = True
                FOld_Outpatient.TxtPatientFee.Text = GridEXOldPatient.GetRow.Cells("PatientFee").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(7).Value
            Else
                FOld_Outpatient.RadioDolar.Checked = True
                FOld_Outpatient.RadioRiel.Checked = False
                FOld_Outpatient.TxtPatientFee.Text = GridEXOldPatient.GetRow.Cells("PatientDolar").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(8).Value
            End If

            FOld_Outpatient.CboDiagnosis.Text = GridEXOldPatient.GetRow.Cells("Diagnosis").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(9).Value
            'FOld_Outpatient.ChPrescribed.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(10).Value
            'FOld_Outpatient.ChDispensed.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(11).Value
            FOld_Outpatient.ChHearing.Checked = GridEXOldPatient.GetRow.Cells("Hearing").Value 'GridOldOutPatient.Rows(e.RowIndex).Cells(12).Value
            FOld_Outpatient.ChUnderstand.Checked = GridEXOldPatient.GetRow.Cells("Understand").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(13).Value
            FOld_Outpatient.ChSeeing.Checked = GridEXOldPatient.GetRow.Cells("Seeing").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(14).Value
            FOld_Outpatient.ChPhysical.Checked = GridEXOldPatient.GetRow.Cells("Physical").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(15).Value
            FOld_Outpatient.TxtOther.Text = GridEXOldPatient.GetRow.Cells("Other").Value ' GridOldOutPatient.Rows(e.RowIndex).Cells(16).Value
            FOld_Outpatient.DateFollowUp.Value = Format(GridEXOldPatient.GetRow.Cells("CreateDate").Value, "MM/dd/yyyy")
            FOld_Outpatient.ShowDialog()
            If FOld_Outpatient.isCloseOld = True Then
                GridEXOldPatient.DataSource = ModOld_Outpatient.SelectOldDetailByReceiptNo(FOld_Outpatient.TxtReceiptNo.Text, FOld_Outpatient.TxtPatientNo.Text)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BgOldOutPatient_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BgOldOutPatient.ProgressChanged

    End Sub

    Private Sub BtnCreateVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateVA.Click

        'Try

        Dim PatientNo As String = GridEXOldPatient.GetRow.Cells("PatientNo").Value ' GridNewOutpatient.Rows(RowIndex).Cells(1).Value
        Dim PatientEngName As String = GridEXOldPatient.GetRow.Cells("NameEng").Value ' GridNewOutpatient.Rows(RowIndex).Cells(4).Value
        Dim PatientKh As String = GridEXOldPatient.GetRow.Cells("NameKhmer").Value ' GridNewOutpatient.Rows(RowIndex).Cells(5).Value
        Dim Age As String = GridEXOldPatient.GetRow.Cells("age").Value ' GridNewOutpatient.Rows(RowIndex).Cells(6).Value
        Dim Sex As String = GridEXOldPatient.GetRow.Cells("Sex").Value ' GridNewOutpatient.Rows(RowIndex).Cells(7).Value
        Dim Address As String = GridEXOldPatient.GetRow.Cells("Address").Value ' GridNewOutpatient.Rows(RowIndex).Cells(8).Value
        Dim FPatientVA As New FRMPatientVA
        FPatientVA.LblSave.Text = GridEXOldPatient.GetRow.Cells("NewOutPatientNo").Value
        FPatientVA.TxtPatientNo.Enabled = False
        FPatientVA.TxtPatientNo.Text = PatientNo
        FPatientVA.TxtEngName.Text = PatientEngName.Trim
        FPatientVA.TxtKhName.Text = PatientKh.Trim
        FPatientVA.TxtAge.Text = Age
        FPatientVA.TxtSex.Text = Sex
        FPatientVA.TxtAddress.Text = Address
        FPatientVA.ShowDialog()
        If FPatientVA.isClose = True Then
            ModNew_Outpatient.UpdateVAStatus(FPatientVA.LblSave.Text)
            ShowSplitPanel(SplitContOldOutpatient, 1)
            CallBgWork()
        End If
        FPatientVA.Close()
        FPatientVA.Dispose()
        'Catch ex As Exception
        '    MsgBox("Could you select New out-patient.", MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub ToolStripLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel5.Click
        ShowSplitPanel(SplitContOldOutpatient, 1)
        IS_Fill = 1
        CallBgWork()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        Me.tbCountMoney.Visible = False
    End Sub

    Private Sub BtnUpdateReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateReferral.Click
        Dim FUpdateReferral As New UpdateReferral
        FUpdateReferral.LblPatientNo.Text = GridEXOldPatient.GetRow.Cells("PatientNo").Value
        FUpdateReferral.lblBookID.Text = GridEXOldPatient.GetRow.Cells("NewOutPatientNo").Value
        FUpdateReferral.LblReferral.Text = GridEXOldPatient.GetRow.Cells("ComBindRefferal").Value
        If FUpdateReferral.ShowDialog() = DialogResult.OK Then
            Me.TxtPatientNo.Text = FUpdateReferral.LblPatientNo.Text
            BtnOldDisplay_Click(sender, e)
        End If
    End Sub

  
    Private Sub PrintListNotFillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintListNotFillToolStripMenuItem.Click
        '---- print request no fill diagnosis ----------
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.FDate = DateOldFrom.Value.Date
        FRptRequestView.TDate = DateOldTo.Value.Date
        FRptRequestView.STATUS = True
        FRptRequestView.ReportOption = 18
        FRptRequestView.ShowDialog()
    End Sub

    Private Sub PrintWithDiagnosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintWithDiagnosisToolStripMenuItem.Click
        '---- print request no fill diagnosis ----------
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.FDate = DateOldFrom.Value.Date
        FRptRequestView.TDate = DateOldTo.Value.Date
        FRptRequestView.STATUS = True
        If ChDiagnosis.Checked = True Then
            FRptRequestView.IS_DIAGNOSIS = True
            FRptRequestView.DIAGNOSIS = cboDiagnosis.Text
        Else
            FRptRequestView.IS_DIAGNOSIS = False
        End If
        FRptRequestView.ReportOption = 19
        FRptRequestView.ShowDialog()
    End Sub

    Private Sub UCMainOld_Outpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cboDiagnosis
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .ValueMember = "Surgery"
            .SelectedValue = "SID"
            .SelectedIndex = -1
            .SelectAll()
        End With
    End Sub

    Private Sub ChDiagnosis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDiagnosis.CheckedChanged
        cboDiagnosis.Enabled = ChDiagnosis.Checked
    End Sub

    Private Sub BtnOldStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOldStatistic.Click

    End Sub
End Class
