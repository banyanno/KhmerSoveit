

Public Class UCMainInpatient
    Dim TblNewInpatientTem As DataTable
    Dim PNo As String
    Dim DFrom As Date
    Dim DTo As Date

    Dim TotalF As Integer
    Dim TotalM As Integer
    Dim Total As Integer
    Dim SumSosialRiel As Integer
    Dim SumSosialDolar As Integer
    Dim SumFullRiel As Integer
    Dim SumFullDolar As Integer

    Dim CountPaidSosialFee As Integer
    Dim CountPaidFullFee As Integer
    Dim countPatientFree As Integer
    Dim CountCancel As Integer
    'Dim CRPay As New CRPaymentReport
    Dim TblPayMore50 As DataTable
    Dim TblPayLess50 As DataTable
    Dim xx, yy As Integer
    Dim TotalRiel As Integer = 0
    Dim TotalNumbRiel As Integer = 0
    Dim TotalNumbFRiel As Integer = 0
    Dim TotalFRiel As Integer = 0

    Private Sub BtnCreateInpatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FInpatient As New FRMIn_patient
        FInpatient.ShowDialog()
        If FInpatient.DialogResult = DialogResult.OK Then
            GridInpatient.DataSource = ModInPatient.SelectInpatientDetailByReceipt(EmptyString(FInpatient.TxtReceiptNo.Text), FInpatient.TxtPatientNo.Text)
        End If
    End Sub

    Private Sub GridInpatient_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridInpatient.CellDoubleClick
        If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            Exit Sub
        End If
        'If RoleAccess <> "Administrator" Then
        '    Exit Sub
        'End If
        Try
            Dim FInpatient As New FRMIn_patient
            Dim SosialRiel As Integer
            Dim SosialDolar As Integer

            Dim FullRiel As Integer
            Dim FullDolar As Integer


            FInpatient.LblSaveOption.Text = GridInpatient.Rows(e.RowIndex).Cells("InNo").Value
            FInpatient.TxtPatientNo.Text = GridInpatient.Rows(e.RowIndex).Cells("PatientNo").Value
            FInpatient.TxtReceiptNo.Text = GridInpatient.Rows(e.RowIndex).Cells("ReceiptNo").Value
            FInpatient.TxtPatientName.Text = GridInpatient.Rows(e.RowIndex).Cells("NameKhmer1").Value
            FInpatient.TxtAge.Text = GridInpatient.Rows(e.RowIndex).Cells("Age").Value
            FInpatient.TxtSex.Text = GridInpatient.Rows(e.RowIndex).Cells("Sex").Value
            FInpatient.TxtAddress.Text = GridInpatient.Rows(e.RowIndex).Cells("Address").Value
            FInpatient.CboDiagnosis.Text = GridInpatient.Rows(e.RowIndex).Cells("Diagnosis").Value
            FInpatient.CboOperationType.Text = GridInpatient.Rows(e.RowIndex).Cells("TypeOfOperation").Value
            FInpatient.TxtHosFee.Text = GridInpatient.Rows(e.RowIndex).Cells("HosFee").Value
            ' Money as riel
            SosialRiel = GridInpatient.Rows(e.RowIndex).Cells("SocialFee").Value
            SosialDolar = GridInpatient.Rows(e.RowIndex).Cells("DolarSosial").Value

            If SosialRiel <> 0 Then
                FInpatient.TxtSosialServiceFee.Text = GridInpatient.Rows(e.RowIndex).Cells("SocialFee").Value
                FInpatient.RRielSSFee.Checked = True
            End If
            If SosialDolar <> 0 Then
                FInpatient.TxtSosialServiceFee.Text = GridInpatient.Rows(e.RowIndex).Cells("DolarSosial").Value
                FInpatient.RDolarSSFee.Checked = True
            End If
            ' Money Full fee as riel
            FullRiel = GridInpatient.Rows(e.RowIndex).Cells("FullFee").Value
            FullDolar = GridInpatient.Rows(e.RowIndex).Cells("DolarFull").Value
            If FullRiel <> 0 Then
                FInpatient.TxtFullFee.Text = GridInpatient.Rows(e.RowIndex).Cells("FullFee").Value
                FInpatient.RReilFFee.Checked = True
            End If
            If FullDolar <> 0 Then
                FInpatient.TxtFullFee.Text = GridInpatient.Rows(e.RowIndex).Cells("DolarFull").Value
                FInpatient.RDolarFFee.Checked = True
            End If
            FInpatient.TxtOther.Text = GridInpatient.Rows(e.RowIndex).Cells("Other").Value
            FInpatient.DateIn.Checked = True
            FInpatient.DateIn.Value = GridInpatient.Rows(e.RowIndex).Cells("CreateDate").Value
            FInpatient.ShowDialog()
            If FInpatient.isCloseIn = True Then
                GridInpatient.DataSource = ModInPatient.SelectInpatientDetailByReceipt(EmptyString(FInpatient.TxtReceiptNo.Text), FInpatient.TxtPatientNo.Text)
                ModCommon.NumberAllRowHeaderDataGrid(GridInpatient)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CreateInpatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateInpatientToolStripMenuItem.Click
        Dim FInpatient As New FRMIn_patient
        FInpatient.ShowDialog()
        If FInpatient.DialogResult = DialogResult.OK Then
            GridInpatient.DataSource = ModInPatient.SelectInpatientDetailByReceipt(EmptyString(FInpatient.TxtReceiptNo.Text), FInpatient.TxtPatientNo.Text)
        End If
    End Sub



    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub
    Private Sub CallBG()
        PNo = TxtPatientNo.Text
        DFrom = DateInFrom.Value
        DTo = DateInTo.Value
        BtnDisplay.Enabled = False
        PictLoading.Visible = True
        BgNewInpatient.RunWorkerAsync()
    End Sub

    Private Sub BgNewInpatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgNewInpatient.DoWork
        TblNewInpatientTem = ModInPatient.SelectInpatientDetailByDate(EmptyString(PNo), DFrom, DTo)
        SumSosialRiel = SumInpatientFee(DFrom, DTo, "SosialFee")
        SumSosialDolar = SumInpatientFee(DFrom, DTo, "DolarSosial")
        SumFullRiel = SumInpatientFee(DFrom, DTo, "FullFee")
        SumFullDolar = SumInpatientFee(DFrom, DTo, "DolarFull")

        CountPaidSosialFee = ModInPatient.CountPatientPaySocial(DFrom, DTo) ' ModInPatient.CountInpatientPaid(DFrom, DTo, "CalDolarSosial")
        CountPaidFullFee = ModInPatient.CountPatientPayFull(DFrom, DTo)  'ModInPatient.CountInpatientPaid(DFrom, DTo, "CalDolarFull")
        countPatientFree = ModInPatient.CountInpatientFree(DFrom, DTo)

        TotalM = ModNew_Outpatient.CMaleForInpatient("V_InpatientDetail", DFrom, DTo, 0)
        TotalF = ModNew_Outpatient.CFemaleForInPatient("V_InpatientDetail", DFrom, DTo, 0)
        CountCancel = ModNew_Outpatient.CountCanceledForInPatient("V_InpatientDetail", DFrom, DTo, 0)
        Total = TotalM + TotalF
        If (BgNewInpatient.CancellationPending) Then
            e.Cancel = True
            BgNewInpatient.CancelAsync()
            Return
        End If
    End Sub

    Private Sub BgNewInpatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgNewInpatient.RunWorkerCompleted
        GridInpatient.DataSource = TblNewInpatientTem
        Dim OType As String
        Dim Cancel As String
        For Each rows As DataGridViewRow In GridInpatient.Rows
            OType = rows.Cells.Item("TypeOfOperation").Value.ToString.Trim
            Cancel = rows.Cells.Item("DeleteOption").Value.ToString.Trim
            If OType = "" Then
                rows.DefaultCellStyle.BackColor = Color.LightSeaGreen
            End If
            If Cancel = "True" Then
                rows.DefaultCellStyle.BackColor = Color.DarkRed
            End If
        Next
        ModCommon.NumberAllRowHeaderDataGrid(GridInpatient)
        LblTotalM.Text = TotalM
        LblTotalF.Text = TotalF
        LblTotal.Text = Total
        TxtSosialRiel.Text = SumSosialRiel
        TxtSosialDolar.Text = SumSosialDolar
        TxtFullRiel.Text = SumFullRiel
        TxtFullDolar.Text = SumFullDolar
        LblPaidSosialFee.Text = CountPaidSosialFee
        LblPaidFullFee.Text = CountPaidFullFee
        TxtTotalFee.Text = CountPaidSosialFee + CountPaidFullFee
        LblFree.Text = countPatientFree
        LblCancel.Text = CountCancel
        BtnDisplay.Enabled = True
        PictLoading.Visible = False
    End Sub

    Private Sub ExportToExcel()
        'Dim excelPathName As String = "C:\Book1.xlsx"
        'Dim objExcel As New Excel.Application
        'Dim objBook As Excel.Workbook = objExcel.Workbooks.Open(excelPathName)
        'Dim objSheet As Excel.Worksheet = objBook.Worksheets(1)
        'objExcel.Visible = True

        'Dim bolFlag As Boolean = True
        'Dim excelRow As Integer = 7
        'Dim DGVRow As Integer = 1

        'Try
        '    Do While bolFlag = True

        '        If Convert.ToString(objSheet.Cells(excelRow, 1).value) = "" Then
        '            bolFlag = False
        '            Exit Do
        '        End If

        '        With Me.GridInpatient

        '            GridInpatient.Rows.Add()
        '            DGVRow += 1
        '            excelRow += 1

        '            .Rows(DGVRow).Cells(1).Value = objSheet.Cells(excelRow, 1).value
        '            .Rows(DGVRow).Cells(2).Value = objSheet.Cells(excelRow, 2).value
        '            .Rows(DGVRow).Cells(3).Value = objSheet.Cells(excelRow, 3).value
        '            .Rows(DGVRow).Cells(4).Value = objSheet.Cells(excelRow, 4).value
        '            .Rows(DGVRow).Cells(5).Value = objSheet.Cells(excelRow, 5).value
        '            .Rows(DGVRow).Cells(6).Value = objSheet.Cells(excelRow, 6).value
        '            .Rows(DGVRow).Cells(7).Value = objSheet.Cells(excelRow, 7).value
        '            .Rows(DGVRow).Cells(8).Value = objSheet.Cells(excelRow, 8).value
        '            .Rows(DGVRow).Cells(9).Value = objSheet.Cells(excelRow, 9).value

        '        End With

        '    Loop

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'Finally

        '    objBook.Close()
        '    'objExcel.Quit()
        'End Try
    End Sub

    Private Sub BtnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplay.Click
        ModCommon.ShowSplitPanel(SplitContainer1, 1)
        CallBG()
        Me.dgvListAmount.DataSource = Nothing
        Me.lstNumber.Items.Clear()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        TotalNumbFRiel = 0
        TotalFRiel = 0
        '----------------tab FullFee----------------------
        Me.dgvFDollar.DataSource = Nothing
        Me.dgvFRiel.DataSource = Nothing
        Me.lstFullFees.Items.Clear()
        Me.tbCountMoney.Visible = False
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModCommon.ShowSplitPanel(SplitContainer1, 0)
        CRVPayment.DisplayToolbar = True
        PicLoadReport.Visible = True
        BgLoadReport.RunWorkerAsync()
    End Sub



    Private Sub GridInpatient_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridInpatient.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(GridInpatient)
        Dim OType As String
        Dim Cancel As String
        For Each rows As DataGridViewRow In GridInpatient.Rows
            OType = rows.Cells.Item("TypeOfOperation").Value.ToString.Trim
            Cancel = rows.Cells.Item("DeleteOption").Value.ToString.Trim
            If OType = "" Then
                rows.DefaultCellStyle.BackColor = Color.LightSeaGreen
            End If
            If Cancel = "True" Then
                rows.DefaultCellStyle.BackColor = Color.DarkKhaki
            End If

        Next
    End Sub

    Private Sub GridInpatient_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridInpatient.CellContentClick

    End Sub

    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
        Try
            Dim RowIndex As Integer = ModCommon.GetRowIndexDataGrid(GridInpatient)
            Dim InNo As Integer = GridInpatient.Rows(RowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show("Do you want to cancel?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModInPatient.UpdateInToCancel(InNo) = 1 Then
                    MsgBox("Canceled successful.", MsgBoxStyle.Information, "Delete")
                    CallBG()
                Else
                    MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
            MsgBox("Could you select in-patient.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UndoCancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndo.Click
        Try
            Dim RowIndex As Integer = ModCommon.GetRowIndexDataGrid(GridInpatient)
            Dim InNo As Integer = GridInpatient.Rows(RowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show("Do you want to undo?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModInPatient.UpdateInToUndo(InNo) = 1 Then
                    MsgBox("undoed successful.", MsgBoxStyle.Information, "Delete")
                    CallBG()
                Else
                    MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
            MsgBox("Could you select in-patient.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GridInpatient_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridInpatient.SelectionChanged
        If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            MCancel.Enabled = False
            MUndo.Enabled = False
        End If

       
    End Sub

    'Private Sub GridInpatient_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles GridInpatient.SortCompare
    '    ' Try to sort based on the contents of the cell in the current column.
    '    e.SortResult = System.String.Compare(e.CellValue1.ToString(), _
    '        e.CellValue2.ToString())

    '    ' If the cells are equal, sort based on the ID column.
    '    If (e.SortResult = 0) AndAlso Not (e.Column.Name = "HosFee") Then
    '        e.SortResult = System.String.Compare( _
    '            Me.GridInpatient.Rows(e.RowIndex1).Cells("HosFee").Value.ToString(), _
    '            Me.GridInpatient.Rows(e.RowIndex2).Cells("HosFee").Value.ToString())
    '    End If

    '    e.Handled = True

    'End Sub

    Private Sub ShowDetailFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDetailFeesToolStripMenuItem.Click
        If Me.GridInpatient.CurrentCell Is Nothing Then Exit Sub
        Me.tbCountMoney.Visible = True
    End Sub

    Private Sub llbClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClose.LinkClicked, lblCloseSocial.LinkClicked, lblCloseFullFee.LinkClicked
        Me.dgvListAmount.DataSource = Nothing
        Me.lstNumber.Items.Clear()
        '---------------tab SocialFee----------------------
        Me.dgvSRiel.DataSource = Nothing
        Me.dgvSDolar.DataSource = Nothing
        Me.lstSocial.Items.Clear()
        TotalRiel = 0
        TotalNumbRiel = 0
        TotalNumbFRiel = 0
        TotalFRiel = 0
        '----------------tab FullFee----------------------
        Me.dgvFDollar.DataSource = Nothing
        Me.dgvFRiel.DataSource = Nothing
        Me.lstFullFees.Items.Clear()
        Me.tbCountMoney.Visible = False
    End Sub

    Private Sub llbClick_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        If Me.GridInpatient.CurrentCell Is Nothing Then Exit Sub
        Me.dgvListAmount.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateInFrom.Value, Me.DateInTo.Value, "HosFee", "[Hospital Fees]", "CreateDate", "V_InpatientDetail")
        ModCommon.NumberAllRowHeaderDataGrid(Me.dgvListAmount)
    End Sub

    Function CountMoney(ByVal Number As Integer, ByVal ColName As String) As Integer
        Dim Numb As Integer
        With Me.GridInpatient
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Cells(ColName).Value = Number Then
                    Numb = Numb + 1
                End If
            Next
        End With
        Return Numb
    End Function

    Private Sub dgvListAmount_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListAmount.CellClick
        If e.RowIndex >= 0 Then
            Dim i, Amnt, Numb, TotalNumb, Total As Integer
            Amnt = Me.dgvListAmount.Rows(e.RowIndex).Cells(0).Value
            '--------------------------Add to datagrid ------------------------
            If CheckListViewItem(Me.lstNumber, Amnt) = False Then
                Numb = CountMoney(Amnt, "HosFee")
                i = Me.lstNumber.Items.Count + 1
                With Me.lstNumber.Items.Add(i)
                    .SubItems.Add(Amnt)
                    .SubItems.Add(Numb)
                    .SubItems.Add(Convert.ToInt32(.SubItems(1).Text) * Convert.ToInt32(.SubItems(2).Text))
                End With
            End If
            For j As Integer = 0 To Me.lstNumber.Items.Count - 1
                TotalNumb += Convert.ToInt32(Me.lstNumber.Items(j).SubItems(2).Text)
                Total += Convert.ToInt32(Me.lstNumber.Items(j).SubItems(3).Text)
            Next
            Me.lblTotalNumb.Text = TotalNumb
            Me.lblTotalNumber.Text = Total
        End If
    End Sub

    Private Sub tbCountMoney_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCountMoney.MouseDown, TabPage1.MouseDown, TabPage2.MouseDown, TabPage3.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            xx = e.X
            yy = e.Y
        End If
    End Sub

    Private Sub tbCountMoney_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCountMoney.MouseMove, TabPage1.MouseMove, TabPage2.MouseMove, TabPage3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.tbCountMoney.Left += e.X - xx
            Me.tbCountMoney.Top += e.Y - yy
        End If
    End Sub

    Private Sub dgvListAmount_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListAmount.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(Me.dgvListAmount)
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

    Private Sub lblQuickView_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblQuickView.LinkClicked
        If Me.GridInpatient.CurrentCell Is Nothing Then Exit Sub
        Me.dgvListAmount.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateInFrom.Value, Me.DateInTo.Value, "HosFee", "[Hospital Fees]", "CreateDate", "V_InpatientDetail")
        ModCommon.NumberAllRowHeaderDataGrid(Me.dgvListAmount)
        Dim i, Amnt, Numb, TotalNumb, Total As Integer
        For row As Integer = 0 To Me.dgvListAmount.Rows.Count - 1
            Amnt = Me.dgvListAmount.Rows(row).Cells(0).Value
            '--------------------------Add to datagrid ------------------------
            If CheckListViewItem(Me.lstNumber, Amnt) = False Then
                Numb = CountMoney(Amnt, "HosFee")
                i = Me.lstNumber.Items.Count + 1
                With Me.lstNumber.Items.Add(i)
                    .SubItems.Add(Amnt)
                    .SubItems.Add(Numb)
                    .SubItems.Add(Convert.ToInt32(.SubItems(1).Text) * Convert.ToInt32(.SubItems(2).Text))
                End With
            End If
        Next
        For j As Integer = 0 To Me.lstNumber.Items.Count - 1
            TotalNumb += Convert.ToInt32(Me.lstNumber.Items(j).SubItems(2).Text)
            Total += Convert.ToInt32(Me.lstNumber.Items(j).SubItems(3).Text)
        Next
        Me.lblTotalNumb.Text = TotalNumb
        Me.lblTotalNumber.Text = Total
    End Sub

    Private Sub lblQuickSocial_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblQuickSocial.LinkClicked
        If Me.GridInpatient.CurrentCell Is Nothing Then Exit Sub
        Me.dgvSRiel.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateInFrom.Value, Me.DateInTo.Value, "SosialFee", "[Fees Riel]", "CreateDate", "V_InpatientDetail")
        Me.dgvSDolar.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateInFrom.Value, Me.DateInTo.Value, "DolarSosial", "[Fees $]", "CreateDate", "V_InpatientDetail")
        ModCommon.NumberAllRowHeaderDataGrid(Me.dgvSRiel)

        Dim i, Amnt, Numb As Integer
        For row As Integer = 0 To Me.dgvSRiel.Rows.Count - 1
            Amnt = Me.dgvSRiel.Rows(row).Cells(0).Value
            '--------------------------Add to datagrid ------------------------
            If CheckListViewItem(Me.lstSocial, Amnt) = False Then
                Numb = CountMoney(Amnt, "SocialFee")
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
            AmntD = Me.dgvSDolar.Rows(xx).Cells(0).Value
            '--------------------------Add to datagrid ------------------------

            If CheckListViewItemDollar(Me.lstSocial, AmntD) = False Then
                Numb = CountMoney(AmntD, "DolarSosial")
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

    Private Sub llbViewFullFee_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbViewFullFee.LinkClicked
        If Me.GridInpatient.CurrentCell Is Nothing Then Exit Sub
        Me.dgvFRiel.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateInFrom.Value, Me.DateInTo.Value, "FullFee", "[Fees Riel]", "CreateDate", "V_InpatientDetail")
        Me.dgvFDollar.DataSource = ModCountMoney.CountMoneyRielDollar(Me.DateInFrom.Value, Me.DateInTo.Value, "DolarFull", "[Fees $]", "CreateDate", "V_InpatientDetail")
        ModCommon.NumberAllRowHeaderDataGrid(Me.dgvFRiel)

        Dim i, Amnt, Numb As Integer
        For row As Integer = 0 To Me.dgvFRiel.Rows.Count - 1
            Amnt = Me.dgvFRiel.Rows(row).Cells(0).Value
            '--------------------------Add to datagrid ------------------------
            If CheckListViewItem(Me.lstFullFees, Amnt) = False Then
                Numb = CountMoney(Amnt, "FullFee")
                i = Me.lstFullFees.Items.Count + 1
                With Me.lstFullFees.Items.Add(i)
                    .SubItems.Add(Amnt)
                    .SubItems.Add(DBNull.Value.ToString)
                    .SubItems.Add(Numb)
                    .SubItems.Add(Convert.ToInt32(.SubItems(1).Text) * Convert.ToInt32(.SubItems(3).Text))
                    TotalNumbFRiel += Convert.ToInt32(.SubItems(3).Text)
                    TotalFRiel += Convert.ToInt32(.SubItems(4).Text)
                End With
            End If
        Next
        '--------------------------------------------------
        Call CountDollarsFullFee()
    End Sub

    Sub CountDollarsFullFee()
        Dim x, AmntD, Numbf, TotalNumbf, Totalf As Integer

        If CheckListViewItemSign(Me.lstFullFees, "0") = False Then
            x = "0"
            With Me.lstFullFees.Items.Add(x)
                .BackColor = Color.Blue
                .ForeColor = Color.White
                .SubItems.Add("Total:")
                .SubItems.Add(DBNull.Value.ToString)
                .SubItems.Add(TotalNumbFRiel)
                .SubItems.Add(TotalFRiel)
            End With
        End If

        For xx As Integer = 0 To Me.dgvFDollar.Rows.Count - 1
            AmntD = Me.dgvFDollar.Rows(xx).Cells(0).Value
            '--------------------------Add to datagrid ------------------------

            If CheckListViewItemDollar(Me.lstFullFees, AmntD) = False Then
                Numbf = CountMoney(AmntD, "DolarFull")
                x = Me.lstFullFees.Items.Count + 1
                With Me.lstFullFees.Items.Add(x)
                    .SubItems.Add(DBNull.Value.ToString)
                    .SubItems.Add(AmntD)
                    .SubItems.Add(Numbf)
                    .SubItems.Add(Convert.ToInt32(.SubItems(2).Text) * Convert.ToInt32(.SubItems(3).Text))
                    TotalNumbf += Convert.ToInt32(.SubItems(3).Text)
                    Totalf += Convert.ToInt32(.SubItems(4).Text)
                End With
            End If
        Next
        If CheckListViewItemSignDollar(Me.lstFullFees, "Total Dollar:") = False Then
            Dim n As Integer = 0
            With Me.lstFullFees.Items.Add(n)
                .BackColor = Color.Blue
                .ForeColor = Color.White
                .SubItems.Add("Total Dollar:")
                .SubItems.Add(DBNull.Value.ToString)
                .SubItems.Add(TotalNumbf)
                .SubItems.Add(Totalf)
            End With
        End If
    End Sub

   
   
End Class
