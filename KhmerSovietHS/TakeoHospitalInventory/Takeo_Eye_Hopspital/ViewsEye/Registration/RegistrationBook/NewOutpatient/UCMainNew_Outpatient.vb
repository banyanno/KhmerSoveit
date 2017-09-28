Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Collections
Imports System.ComponentModel
Public Class UCMainNew_Outpatient
    Dim TblNewOutpatientTem As DataTable, TblDailyNewReport, TblOtherNewPatient As DataTable
    Dim PNo As String
    Dim DFrom, DailyDFrom As Date
    Dim DTo, DailyDTo As Date
    Dim TotalF As Integer
    Dim TotalM As Integer
    Dim TotalNil As Integer
    Dim TotalCanceled As Integer
    Dim TotalNotFillDiagnosis As Integer
    Dim Total As Integer
    Dim TotalPatientRiel As Integer
    Dim TotalPatientDolar As Integer
    Private CrNewOutpatient As New CROutPatientReport
    Private CrOtherNewPatient As New CROtherNewPatient
    Dim xx, yy As Integer
    Dim TotalRiel As Integer = 0
    Dim TotalNumbRiel As Integer = 0
    Dim TotalNumbFRiel As Integer = 0
    Dim TotalFRiel As Integer = 0
    Dim MainForm As MainTakeoInventory
    Dim IS_FIll As Integer = 0
    Sub New(ByVal MainForm As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainForm = MainForm
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplay.Click
        IS_FIll = 2
        ShowSplitPanel(1)
        CallBgNewOut()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        Me.tbCountMoney.Visible = False
    End Sub

    

    Private Sub CreateNewOutpatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewOutpatientToolStripMenuItem.Click
            Dim FNew_OutPatient As New FRMNew_Outpatient
            FNew_OutPatient.ShowDialog()
    End Sub



    Private Sub BtnNewOutPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'Dim FNewOutStatistic As New FRMNewOutStatistic
            'FNewOutStatistic.ShowDialog()
            'FNewOutStatistic.Dispose()
            'FNewOutStatistic.Close()

    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
            ModCommon.SetDisableKeyString(e)
    End Sub
    Private Sub CallBgNewOut()
            PNo = TxtPatientNo.Text
            DFrom = DateFrom.Value
            DTo = DateTo.Value
        MainForm.StatusLoading(True)
            BtnDisplay.Enabled = False
            BGNewOutpatient.RunWorkerAsync()
    End Sub
    Private Sub CallBgNewOutReport()
            DailyDFrom = DailyDateFrom.Value
            DailyDTo = DailyDateTo.Value
        'PicLoad2.Visible = True
        MainForm.StatusLoading(True)
            BtnPrintPreview.Enabled = False
            BgLoadNewReport.RunWorkerAsync()
    End Sub
    Private Sub BGNewOutpatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGNewOutpatient.DoWork
        If IS_FIll = 0 Then
            TblNewOutpatientTem = ModNew_Outpatient.SelecNewOutPatientByDateNotFillDiagnosis(EmptyString(PNo), DFrom, DTo, False, "")
        ElseIf IS_FIll = 1 Then
            TblNewOutpatientTem = ModNew_Outpatient.SelecNewOutPatientByDateNotVA(EmptyString(PNo), DFrom, DTo, False)
        ElseIf IS_FIll = 2 Then
            TblNewOutpatientTem = ModNew_Outpatient.SelectNewOutpatientByDate(EmptyString(PNo), DFrom, DTo, False)
        End If

            TotalPatientRiel = ModNew_Outpatient.SumNewPatientRiel(DFrom, DTo)
            TotalPatientDolar = ModNew_Outpatient.SumNewPatientDolar(DFrom, DTo)
            TotalM = ModNew_Outpatient.CMale("V_NewOutpatientDetail", DFrom, DTo, 0)
            TotalF = ModNew_Outpatient.CFemale("V_NewOutpatientDetail", DFrom, DTo, 0)
            TotalNil = ModNew_Outpatient.CNil("V_NewOutpatientDetail", DFrom, DTo, 0)
            TotalCanceled = ModNew_Outpatient.CountCanceled("V_NewOutpatientDetail", DFrom, DTo, 0)
            TotalNotFillDiagnosis = ModNew_Outpatient.CountNotFillDiagnosis("V_NewOutpatientDetail", DFrom, DTo, 0)
            Total = TotalM + TotalF
    End Sub
    Private Sub BgLoadNewReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadNewReport.DoWork

            TblDailyNewReport = Me.DataTable1TableAdapter.GetDataByNewOut(DailyDTo, DailyDFrom)
            If BgLoadNewReport.CancellationPending Then
                e.Cancel = True
                Return
            End If
    End Sub
    Private Sub BGNewOutpatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGNewOutpatient.RunWorkerCompleted
        GridEXNewPatientBook.DataSource = TblNewOutpatientTem

            LblM.Text = TotalM

            LblF.Text = TotalF

            LblTotalMF.Text = Total

            LblPatientNil.Text = TotalNil

            LblPatientCancel.Text = TotalCanceled

            LblFillDiagnosis.Text = TotalNotFillDiagnosis
            TxtTotalPatientFee.Text = TotalPatientRiel
            TxtTotalDolar.Text = TotalPatientDolar

        MainForm.StatusLoading(False)
        BtnDisplay.Enabled = True
        IS_FIll = 2
    End Sub
    'Sub ShowNoteBG()
    '        Dim BlankDiagnosis As String
    '        Dim DelOption As String
    '        Dim VA As String
    '        For Each rows As DataGridViewRow In Me.GridNewOutpatient.Rows
    '            BlankDiagnosis = rows.Cells.Item("Diagnosis").Value.ToString.Trim
    '            DelOption = rows.Cells.Item("DeleteOption").Value.ToString.Trim
    '            VA = rows.Cells.Item("VAStatus").Value.ToString
    '            If VA = "False" Then
    '                rows.DefaultCellStyle.BackColor = Color.Bisque
    '            End If
    '            If BlankDiagnosis = "" Then
    '                rows.DefaultCellStyle.BackColor = Color.LightSeaGreen
    '            End If
    '            If DelOption = "True" Then
    '                rows.DefaultCellStyle.BackColor = Color.DarkKhaki
    '            End If
    '        Next
    '        NumberAllRowHeaderDataGrid(GridNewOutpatient)
    'End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
            ShowSplitPanel(0)
            CRVDaillyNewOut.DisplayToolbar = True
            CallBgNewOutReport()
    End Sub
    Sub ShowSplitPanel(Optional ByVal con As Integer = 0)
            If con = 0 Then
                SplitNewOuppatient.Panel2Collapsed = False
                SplitNewOuppatient.Panel1Collapsed = True
            End If
            If con = 1 Then
                SplitNewOuppatient.Panel1Collapsed = False
                SplitNewOuppatient.Panel2Collapsed = True
            End If
    End Sub

    Private Sub BgLoadNewReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadNewReport.RunWorkerCompleted

            CrNewOutpatient.SetDataSource(TblDailyNewReport)
            CRVDaillyNewOut.ReportSource = CrNewOutpatient
            Dim myArrayList As ArrayList = New ArrayList()
            myArrayList.Add("Daily New Out-patient Between  " & Format(DailyDFrom, "dd/MM/yyyy") & " And " & Format(DailyDTo, "dd/MM/yyyy"))
            Dim MyparameterFields As ParameterFields = CRVDaillyNewOut.ParameterFieldInfo
            ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Label_Title")
            CrNewOutpatient.Refresh()
            BtnPrintPreview.Enabled = True
        MainForm.StatusLoading(False)
    End Sub

    Sub ShowSortGridColumn(ByVal dg As DataGridView, ByVal colIndex As Integer)
            Dim newColumn As DataGridViewColumn
            If dg.Columns.GetColumnCount(DataGridViewElementStates.Selected) = 1 Then
                newColumn = dg.SelectedColumns(colIndex)
            Else
                newColumn = Nothing
            End If
            Dim OldColumn As DataGridViewColumn = dg.SortedColumn
            Dim direction As ListSortDirection
            ' If oldColumn is null, then the DataGridView is not currently sorted.
            If OldColumn IsNot Nothing Then

                ' Sort the same column again, reversing the SortOrder.
                If OldColumn Is newColumn AndAlso dg.SortOrder = _
                    SortOrder.Ascending Then
                    direction = ListSortDirection.Descending
                Else

                    ' Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending
                    OldColumn.HeaderCell.SortGlyphDirection = SortOrder.None
                End If
            Else
                direction = ListSortDirection.Ascending
            End If


            ' If no column has been selected, display an error dialog  box.
            If newColumn Is Nothing Then
                MessageBox.Show("Select a single column and try again.", _
                    "Error: Invalid Selection", MessageBoxButtons.OK, _
                    MessageBoxIcon.Error)
            Else
                dg.Sort(newColumn, direction)
                If direction = ListSortDirection.Ascending Then
                    newColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending
                Else
                    newColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending
                End If
            End If


    End Sub
    Private Sub BgLoadOtherNewReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadOtherNewReport.DoWork
            TblOtherNewPatient = Me.TblOtherNewPatientTableAdapter.GetData(DailyDFrom, DailyDTo)
            If BgLoadOtherNewReport.CancellationPending Then
                e.Cancel = True
                Return
            End If
    End Sub

    Private Sub BgLoadOtherNewReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadOtherNewReport.RunWorkerCompleted
            CrOtherNewPatient.SetDataSource(TblOtherNewPatient)

            CRVDaillyNewOut.ReportSource = CrOtherNewPatient
            Dim myArrayList As ArrayList = New ArrayList()
            myArrayList.Add("List patient come by others from   " & Format(DailyDFrom, "dd/MM/yyyy") & " to " & Format(DailyDTo, "dd/MM/yyyy"))
            Dim MyparameterFields As ParameterFields = CRVDaillyNewOut.ParameterFieldInfo
            ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
            CRVDaillyNewOut.Refresh()
            CrOtherNewPatient.Refresh()
        MainForm.StatusLoading(False)
            BtnPrintViewOther.Enabled = True
    End Sub


    Private Sub BtnPrintViewOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintViewOther.Click
            ShowSplitPanel(0)
            CRVDaillyNewOut.DisplayToolbar = True
            PicLoad2.Visible = True
            BtnPrintViewOther.Enabled = False
            DailyDFrom = DateOtherFrom.Value
            DailyDTo = DateOtherTo.Value
            BgLoadOtherNewReport.RunWorkerAsync()
    End Sub
    Private Sub CreateVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCreateVA.Click

        'Try

        Dim PatientNo As String = GridEXNewPatientBook.GetRow.Cells("PatientNo").Value ' GridNewOutpatient.Rows(RowIndex).Cells(1).Value
        Dim PatientEngName As String = GridEXNewPatientBook.GetRow.Cells("NameEng").Value ' GridNewOutpatient.Rows(RowIndex).Cells(4).Value
        Dim PatientKh As String = GridEXNewPatientBook.GetRow.Cells("NameKhmer").Value ' GridNewOutpatient.Rows(RowIndex).Cells(5).Value
        Dim Age As String = GridEXNewPatientBook.GetRow.Cells("age").Value ' GridNewOutpatient.Rows(RowIndex).Cells(6).Value
        Dim Sex As String = GridEXNewPatientBook.GetRow.Cells("Sex").Value ' GridNewOutpatient.Rows(RowIndex).Cells(7).Value
        Dim Address As String = GridEXNewPatientBook.GetRow.Cells("Address").Value ' GridNewOutpatient.Rows(RowIndex).Cells(8).Value
        Dim FPatientVA As New FRMPatientVA
        FPatientVA.LblSave.Text = GridEXNewPatientBook.GetRow.Cells("NewOutPatientNo").Value
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
            ShowSplitPanel(1)
            CallBgNewOut()
        End If
        FPatientVA.Close()
        FPatientVA.Dispose()
        'Catch ex As Exception
        '    MsgBox("Could you select New out-patient.", MsgBoxStyle.Critical, "Error")
        'End Try

    End Sub

    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
            Try

            Dim NewOutNo As Integer = GridEXNewPatientBook.GetRow.Cells("NewOutPatientNo").Value
                DIALOG_DELETE = MessageBox.Show("Do you want to cancel", "cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_DELETE = DialogResult.Yes Then
                    If ModNew_Outpatient.UpdateToCancel(NewOutNo) = 1 Then
                        MsgBox("Patient canceled successful.", MsgBoxStyle.Information, "Cancel")
                        CallBgNewOut()
                    Else
                        MsgBox("Error cancel this patient.", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Could you select New out-patient.", MsgBoxStyle.Critical, "Error")
            End Try
    End Sub

    Private Sub UndoCancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndoCancel.Click
            Try

            Dim NewOutNo As Integer = GridEXNewPatientBook.GetRow.Cells("NewOutPatientNo").Value
                DIALOG_DELETE = MessageBox.Show("Do you want to undo cancel", "cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_DELETE = DialogResult.Yes Then
                    If ModNew_Outpatient.UpdateToUndo(NewOutNo) = 1 Then
                        MsgBox("Patient undo successfull.", MsgBoxStyle.Information, "Cancel")
                        CallBgNewOut()
                    Else
                        MsgBox("Error undo this patient", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Could you select New out-patient.", MsgBoxStyle.Critical, "Error")
            End Try
    End Sub

    Private Sub EnterDiagnosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEnterDiagnosis.Click
        'Try
        If GridEXNewPatientBook.SelectedItems.Count = 0 Then Exit Sub
        Dim FEnterDiagnosis As New FrmEnterNewDialognosis
        FEnterDiagnosis.lblNewPatientNo.Text = GridEXNewPatientBook.GetRow.Cells("NewOutPatientNo").Value
        FEnterDiagnosis.txtPatientNo.Text = GridEXNewPatientBook.GetRow.Cells("PatientNo").Value
        FEnterDiagnosis.ShowDialog()
        If FEnterDiagnosis.saveSucc = True Then
            CallBgNewOut()
        End If
        FEnterDiagnosis.Close()
        FEnterDiagnosis.Dispose()
        'Catch ex As Exception

        'End Try

    End Sub


    Private Sub GridNewOutpatient_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            MRemove.Enabled = False
            MCancel.Enabled = False
            MUndoCancel.Enabled = False
        End If


        'If RoleAccess <> "Administrator" Then
        '    MRemove.Enabled = False
        '    MCancel.Enabled = False
        '    MUndoCancel.Enabled = False
        'End If
        '    'Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridNewOutpatient)
        'Dim VA As String = GridNewOutpatient.Rows(Index).Cells("VAStatus").Value
        'If VA = "True" Then
        '    MCreateVA.Enabled = False
        'Else
        '    MCreateVA.Enabled = True
        'End If
    End Sub

    Private Sub BtnStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatistic.Click
            Dim FNewStatistic As New FRMStatistictNewOutPatient
            FNewStatistic.ShowDialog()
            FNewStatistic.Close()
            FNewStatistic.Dispose()
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
        'With Me.GridNewOutpatient
        '    For i As Integer = 0 To .Rows.Count - 1
        '        If .Rows(i).Cells(ColName).Value = Number Then
        '            Numb = Numb + 1
        '        End If
        '    Next
        'End With
        With Me.GridEXNewPatientBook
            For i As Integer = 0 To .RowCount - 1
                If .GetRow(i).Cells(ColName).Value = Number Then
                    Numb = Numb + 1
                End If
            Next
        End With
            Return Numb
    End Function

    Private Sub lblQuickSocial_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblQuickSocial.LinkClicked

        If GridEXNewPatientBook.SelectedItems.Count = 0 Then Exit Sub
            Me.dgvSRiel.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateFrom.Value, Me.DateTo.Value, "PatientFee", "[Fees Riel]", "CreateDate", "V_NewOutpatientDetail")
            Me.dgvSDolar.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateFrom.Value, Me.DateTo.Value, "PatientDolar", "[Fees $]", "CreateDate", "V_NewOutpatientDetail")
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

    Private Sub ShowDetailFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDetailFeesToolStripMenuItem.Click
            Me.tbCountMoney.Visible = True
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

    Private Sub BtnShowVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowVA.Click
        IS_FIll = 1
        ShowSplitPanel(1)
        CallBgNewOut()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        Me.tbCountMoney.Visible = False
        'GridNewOutpatient.Sort(GridNewOutpatient.Columns("VAStatus"), ListSortDirection.Descending)
        'ShowNoteBG()
    End Sub

    Private Sub GridNewOutpatient_ColumnSortModeChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs)

    End Sub

    Private Sub BtnShowEnterDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowEnterDiagnosis.Click

        IS_FIll = 0
        ShowSplitPanel(1)
        CallBgNewOut()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        Me.tbCountMoney.Visible = False
        'GridNewOutpatient.Sort(GridNewOutpatient.Columns("Diagnosis"), ListSortDirection.Ascending)
        'ShowNoteBG()
    End Sub

    Private Sub BtnShowPatientCanceled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowPatientCanceled.Click
        'GridNewOutpatient.Sort(GridNewOutpatient.Columns("DeleteOption"), ListSortDirection.Descending)
        'ShowNoteBG()
    End Sub

    Private Sub BtnDisplaySort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplaySort.Click
            BtnDisplay_Click(sender, e)
    End Sub

    Private Sub GridEXNewPatientBook_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXNewPatientBook.RowDoubleClick
        If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            Exit Sub
        End If
        'If RoleAccess <> "Administrator" Then
        '    Exit Sub
        'End If
        Try
            'Dim PatientFee As Integer
            Dim FNew_outpatient As New FRMNew_Outpatient

            FNew_outpatient.DateFollowUp.Checked = True
            FNew_outpatient.LblSaveOption.Text = GridEXNewPatientBook.GetRow.Cells("NewOutPatientNo").Value ' .Rows(e.RowIndex).Cells(0).Value
            FNew_outpatient.TxtPatientNo.Text = GridEXNewPatientBook.GetRow.Cells("PatientNo").Value '.Rows(e.RowIndex).Cells(1).Value
            FNew_outpatient.TxtReceiptNo.Text = GridEXNewPatientBook.GetRow.Cells("ReceiptNo").Value '.Rows(e.RowIndex).Cells(3).Value
            FNew_outpatient.TxtPatientName.Text = GridEXNewPatientBook.GetRow.Cells("NameKhmer").Value '.Rows(e.RowIndex).Cells(5).Value
            FNew_outpatient.TxtAge.Text = GridEXNewPatientBook.GetRow.Cells("Age").Value '.Rows(e.RowIndex).Cells(6).Value
            FNew_outpatient.TxtSex.Text = GridEXNewPatientBook.GetRow.Cells("Sex").Value '.Rows(e.RowIndex).Cells(7).Value
            FNew_outpatient.TxtAddress.Text = GridEXNewPatientBook.GetRow.Cells("Address").Value '.Rows(e.RowIndex).Cells(8).Value

            Dim Riel As String = GridEXNewPatientBook.GetRow.Cells("PatientFee").Value
            If Riel <> "0" Then
                FNew_outpatient.RadioDolar.Checked = False
                FNew_outpatient.RadioRiel.Checked = True
                FNew_outpatient.TxtPatientFee.Text = GridEXNewPatientBook.GetRow.Cells("PatientFee").Value
            Else
                FNew_outpatient.RadioDolar.Checked = True
                FNew_outpatient.RadioRiel.Checked = False
                FNew_outpatient.TxtPatientFee.Text = GridEXNewPatientBook.GetRow.Cells("PatientDolar").Value
            End If
            FNew_outpatient.CboDiagnosis.Text = GridEXNewPatientBook.GetRow.Cells("Diagnosis").Value '.Rows(e.RowIndex).Cells(11).Value
            FNew_outpatient.ChPrescribed.Checked = GridEXNewPatientBook.GetRow.Cells("Prescribed").Value '.Rows(e.RowIndex).Cells(12).Value
            FNew_outpatient.ChDispensed.Checked = GridEXNewPatientBook.GetRow.Cells("Dispensed").Value '.Rows(e.RowIndex).Cells(13).Value
            FNew_outpatient.ChHearing.Checked = GridEXNewPatientBook.GetRow.Cells("Hearing").Value '.Rows(e.RowIndex).Cells(14).Value
            FNew_outpatient.ChUnderstand.Checked = GridEXNewPatientBook.GetRow.Cells("Understand").Value '.Rows(e.RowIndex).Cells(15).Value
            FNew_outpatient.ChSeeing.Checked = GridEXNewPatientBook.GetRow.Cells("Seeing").Value '.Rows(e.RowIndex).Cells(16).Value
            FNew_outpatient.ChPhysical.Checked = GridEXNewPatientBook.GetRow.Cells("Physical").Value '.Rows(e.RowIndex).Cells(17).Value
            FNew_outpatient.TxtOther.Text = GridEXNewPatientBook.GetRow.Cells("Other").Value '.Rows(e.RowIndex).Cells(18).Value
            FNew_outpatient.DateFollowUp.Value = Format(GridEXNewPatientBook.GetRow.Cells("CreateDate").Value, "MM/dd/yyyy")
            FNew_outpatient.ChTypeOther.Checked = GridEXNewPatientBook.GetRow.Cells("TypeDiagnosis").Value
            If FNew_outpatient.ShowDialog() = DialogResult.OK Then
                GridEXNewPatientBook.DataSource = ModNew_Outpatient.SelectNewOutNo(EmptyString(FNew_outpatient.LblSaveOption.Text))
            End If
            'If FNew_outpatient.isNewClose = True Then

            '    'NumberAllRowHeaderDataGrid(GridNewOutpatient)
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnUpdateReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateReferral.Click
        If GridEXNewPatientBook.SelectedItems.Count = 0 Then Exit Sub
        Dim FUpdateReferral As New UpdateReferral
        FUpdateReferral.LblPatientNo.Text = GridEXNewPatientBook.GetRow.Cells("PatientNo").Value
        FUpdateReferral.lblBookID.Text = GridEXNewPatientBook.GetRow.Cells("NewOutPatientNo").Value
        FUpdateReferral.LblReferral.Text = GridEXNewPatientBook.GetRow.Cells("ComBindRefferal").Value
        If FUpdateReferral.ShowDialog() = DialogResult.OK Then
            Me.TxtPatientNo.Text = FUpdateReferral.LblPatientNo.Text
            BtnDisplay_Click(sender, e)
        End If
    End Sub



    Private Sub PrintNotFillDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNotFillDiagnosis.Click

        '---- print request no fill diagnosis ----------
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.FDate = DateFrom.Value.Date
        FRptRequestView.TDate = DateTo.Value.Date
        FRptRequestView.STATUS = False
        FRptRequestView.ReportOption = 18
        FRptRequestView.ShowDialog()
    End Sub

    Private Sub PrintWithDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintWithDiagnosis.Click
        '---- print request no fill diagnosis ----------
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.FDate = DateFrom.Value.Date
        FRptRequestView.TDate = DateTo.Value.Date
        FRptRequestView.STATUS = False
        If ChDiagnosis.Checked = True Then
            FRptRequestView.IS_DIAGNOSIS = True
            FRptRequestView.DIAGNOSIS = cboDiagnosis.Text
        Else
            FRptRequestView.IS_DIAGNOSIS = False
        End If
        FRptRequestView.ReportOption = 19
        FRptRequestView.ShowDialog()
    End Sub
    Private Sub UCMainNew_Outpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    
End Class
