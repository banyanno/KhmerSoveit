Imports System.Data.Common
Public Class UCOT_AND_IOLList
    Private THIDataContext As New BaseDataContext
    Private OLD_IOLID As Integer
    Dim ItemListInDepartDataAdapter As New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim DA_Item_Department As New DSOTCurrentStoctTableAdapters.tblDeptStockTableAdapter


    Dim DS_OPERATION As New DSOPERATIONNOTE
    Dim DA_OP As New DSOPERATIONNOTETableAdapters.View_OTRegistrationTableAdapter
    Dim DA_ScleralBuckling As New DSOPERATIONNOTETableAdapters.S_OPER_SCLERAL_BUCKLINGTableAdapter
    Dim DA_Intravitreal_Injection As New DSOPERATIONNOTETableAdapters.S_OPER_INJECTIONTableAdapter
    Dim DA_General_Operative As New DSOPERATIONNOTETableAdapters.S_OPER_GENERAL_OPERATIVETableAdapter
    Dim DA_Phacoe As New DSOPERATIONNOTETableAdapters.S_OPER_PHACOEMULSIFICATIONTableAdapter
    Dim DA_ECCE As New DSOPERATIONNOTETableAdapters.S_OPERA_ECCETableAdapter
    Dim DA_ParPlana As New DSOPERATIONNOTETableAdapters.S_OPER_PAR_PLANA_VITRECTOMYTableAdapter
    Dim DA_Trab As New DSOPERATIONNOTETableAdapters.S_OPER_TRABECULECTOMYTableAdapter
    Dim DA_Ptery As New DSOPERATIONNOTETableAdapters.S_OPER_PTERYGIUMTableAdapter
    Dim DAPatientWait As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    ' Create report instance
    Dim CRV_ScleralBuckling As New FormScleralBuckling1
    Dim CRV_Injection As New FormIntravitrealInjection1
    Dim CRV_GeneralOperative As New GeneralOperativeNote1
    Dim CRV_Phacoemulsification As New Phacoemulsification1
    Dim CRV_ECCE As New ECCE
    Dim CRV_PA_PLANA As New ParPlanaVitrectomy1
    Dim CRV_Trab As New Trabeculectomy1
    Dim CRV_Ptery As New PterygiumExcision
    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        ToolStripMenuItem1.Enabled = True
        MenuOperationReady.Enabled = True
        DeleteOTRegistrationToolStripMenuItem.Enabled = True
        ShowOTData(TxtPatientNo.Text)
    End Sub
    Sub ShowOTData(ByVal PatientNo As String)
        If PatientNo = "" Then
            DA_OP.FillBy(DS_OPERATION.View_OTRegistration)
        Else
            DA_OP.FillBy1(DS_OPERATION.View_OTRegistration, EmptyString(PatientNo))
        End If

        GridOT.DataSource = DS_OPERATION.View_OTRegistration
        DA_ScleralBuckling.Fill(DS_OPERATION.S_OPER_SCLERAL_BUCKLING)
        DA_Intravitreal_Injection.Fill(DS_OPERATION.S_OPER_INJECTION)
        DA_General_Operative.Fill(DS_OPERATION.S_OPER_GENERAL_OPERATIVE)
        DA_Phacoe.Fill(DS_OPERATION.S_OPER_PHACOEMULSIFICATION)
        DA_ECCE.Fill(DS_OPERATION.S_OPERA_ECCE)
        DA_ParPlana.Fill(DS_OPERATION.S_OPER_PAR_PLANA_VITRECTOMY)
        DA_Trab.Fill(DS_OPERATION.S_OPER_TRABECULECTOMY)
        DA_Ptery.Fill(DS_OPERATION.S_OPER_PTERYGIUM)

        GridOT.RootTable.ChildTables(0).DataMember = "OperationNotesScleral"
        GridOT.RootTable.ChildTables(1).DataMember = "OperInjection"
        GridOT.RootTable.ChildTables(2).DataMember = "GENERAL_OPERATIVE"
        GridOT.RootTable.ChildTables(3).DataMember = "Oper_Phacoemul"
        GridOT.RootTable.ChildTables(4).DataMember = "Oper_ECCE"
        GridOT.RootTable.ChildTables(5).DataMember = "OperParPlana"
        GridOT.RootTable.ChildTables(6).DataMember = "S_OPER_TRABECULECTOMY"
        GridOT.RootTable.ChildTables(7).DataMember = "S_OPER_PTERYGIUM"
        '  GridOT.ChildTables(0).DataMember = ""
        'GridOTRegistration.DataSource = ModOTRegistration.SelectListOT(TxtPatientNo.Text)
        'GridOT.DataSource = DA_OP.SelectWaitingOP ' ModOTRegistration.SelectListOT(TxtPatientNo.Text)
        'ModCommon.NumberAllRowHeaderDataGrid(GridOTRegistration)
    End Sub
    Sub ShowOTHistory(ByVal PatientNo As String)

        'GridOT.DataSource = ModOTRegistration.SelectOTHistory(EmptyString(TxtFindPatientNo.Text), DateFrom.Value, DateTo.Value)
        'GridOTRegistration.DataSource = ModOTRegistration.SelectOTHistory(EmptyString(TxtFindPatientNo.Text), DateFrom.Value, DateTo.Value)
        'ModCommon.NumberAllRowHeaderDataGrid(GridOTRegistration)
        If PatientNo = "" Then
            DA_OP.FillWithoutHistPno(DS_OPERATION.View_OTRegistration, DateFrom.Value.Date, DateTo.Value.Date)
        Else
            DA_OP.FillWithHistPNo(DS_OPERATION.View_OTRegistration, DateFrom.Value.Date, DateTo.Value.Date, EmptyString(PatientNo))
        End If

        GridOT.DataSource = DS_OPERATION.View_OTRegistration
        DA_ScleralBuckling.Fill(DS_OPERATION.S_OPER_SCLERAL_BUCKLING)
        DA_Intravitreal_Injection.Fill(DS_OPERATION.S_OPER_INJECTION)
        DA_General_Operative.Fill(DS_OPERATION.S_OPER_GENERAL_OPERATIVE)
        DA_Phacoe.Fill(DS_OPERATION.S_OPER_PHACOEMULSIFICATION)
        DA_ECCE.Fill(DS_OPERATION.S_OPERA_ECCE)
        DA_ParPlana.Fill(DS_OPERATION.S_OPER_PAR_PLANA_VITRECTOMY)
        DA_Trab.Fill(DS_OPERATION.S_OPER_TRABECULECTOMY)
        DA_Ptery.Fill(DS_OPERATION.S_OPER_PTERYGIUM)

        GridOT.RootTable.ChildTables(0).DataMember = "OperationNotesScleral"
        GridOT.RootTable.ChildTables(1).DataMember = "OperInjection"
        GridOT.RootTable.ChildTables(2).DataMember = "GENERAL_OPERATIVE"
        GridOT.RootTable.ChildTables(3).DataMember = "Oper_Phacoemul"
        GridOT.RootTable.ChildTables(4).DataMember = "Oper_ECCE"
        GridOT.RootTable.ChildTables(5).DataMember = "OperParPlana"
        GridOT.RootTable.ChildTables(6).DataMember = "S_OPER_TRABECULECTOMY"
        GridOT.RootTable.ChildTables(7).DataMember = "S_OPER_PTERYGIUM"
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Try
            MenuOperationReady.Enabled = True
            ToolStripMenuItem1.Enabled = True
            DeleteOTRegistrationToolStripMenuItem.Enabled = True
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(Index).Cells(0).Value
            Dim PatientNo As String = GridOTRegistration.Rows(Index).Cells(2).Value
            Dim PatientName As String = GridOTRegistration.Rows(Index).Cells(3).Value
            Dim Age As String = GridOTRegistration.Rows(Index).Cells(4).Value
            Dim Sex As String = GridOTRegistration.Rows(Index).Cells(5).Value
            'Dim DateOP As String = GridOTRegistration.Rows(Index).Cells("DateOperated").Value
            Dim FIOL As New FRMIOLRegistration
            FIOL.LblOTNo.Text = OTNo
            FIOL.txtPatientNo.Text = PatientNo
            FIOL.TxtName.Text = PatientName
            FIOL.TxtSex.Text = Sex
            FIOL.TxtAge.Text = Age
            'FIOL.LblDateCreateIOL.Text = DateOP
            FIOL.CboIOLItem.Text = GridOTRegistration.Rows(Index).Cells("IOL").Value
            FIOL.ShowDialog()
            If FIOL.isClose = True Then
                GridIOL.DataSource = ModIOLRegistration.SelectIOL(FIOL.LblOTNo.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient to create IOL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GridIOL_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridIOL.CellDoubleClick
        Try
            If IsReadyOP() = True Then
                If IsAdmin() = True Then
                    Dim fIOL As New FRMIOLRegistration
                    fIOL.LblOptionSave.Text = GridIOL.Rows(e.RowIndex).Cells(0).Value
                    fIOL.LblOTNo.Text = GridIOL.Rows(e.RowIndex).Cells(1).Value
                    fIOL.txtPatientNo.Text = GridIOL.Rows(e.RowIndex).Cells(2).Value
                    fIOL.TxtName.Text = GridIOL.Rows(e.RowIndex).Cells(3).Value
                    fIOL.TxtAge.Text = GridIOL.Rows(e.RowIndex).Cells(4).Value
                    fIOL.TxtSex.Text = GridIOL.Rows(e.RowIndex).Cells(5).Value
                    fIOL.CboSurgeon.Text = GridIOL.Rows(e.RowIndex).Cells(6).Value
                    fIOL.CboEye.Text = GridIOL.Rows(e.RowIndex).Cells(7).Value
                    fIOL.CboIOLItem.Text = GridIOL.Rows(e.RowIndex).Cells(8).Value
                    fIOL.DateIOL.Checked = True
                    fIOL.DateIOL.Value = GridIOL.Rows(e.RowIndex).Cells("CreateDate1").Value
                    fIOL.ShowDialog()
                    If fIOL.DialogResult = DialogResult.OK Then
                        GridIOL.DataSource = ModIOLRegistration.SelectIOL(fIOL.LblOTNo.Text)
                    End If
                Else
                    MessageBox.Show("You don't have permistion to edit IOL. Please contact system addmin to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Dim fIOL As New FRMIOLRegistration
                fIOL.LblOptionSave.Text = GridIOL.Rows(e.RowIndex).Cells(0).Value
                fIOL.LblOTNo.Text = GridIOL.Rows(e.RowIndex).Cells(1).Value
                fIOL.txtPatientNo.Text = GridIOL.Rows(e.RowIndex).Cells(2).Value
                fIOL.TxtName.Text = GridIOL.Rows(e.RowIndex).Cells(3).Value
                fIOL.TxtAge.Text = GridIOL.Rows(e.RowIndex).Cells(4).Value
                fIOL.TxtSex.Text = GridIOL.Rows(e.RowIndex).Cells(5).Value
                fIOL.CboSurgeon.Text = GridIOL.Rows(e.RowIndex).Cells(6).Value
                fIOL.CboEye.Text = GridIOL.Rows(e.RowIndex).Cells(7).Value
                fIOL.CboIOLItem.Text = GridIOL.Rows(e.RowIndex).Cells(8).Value
                fIOL.DateIOL.Checked = True
                fIOL.DateIOL.Value = GridIOL.Rows(e.RowIndex).Cells("CreateDate1").Value
                fIOL.ShowDialog()
                If fIOL.DialogResult = DialogResult.OK Then
                    GridIOL.DataSource = ModIOLRegistration.SelectIOL(fIOL.LblOTNo.Text)
                End If
            End If
            
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DeleteOTRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOTRegistrationToolStripMenuItem.Click
        Try
            'Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOT.GetRow.Cells("OTNo").Value '  GridOTRegistration.Rows(index).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModOTRegistration.DeleteOT(OTNo) = 1 Then
                    'ModIOLRegistration.DeleteIOLByOT(OTNo)
                    MsgBox("Delete OT registration successfully.", MsgBoxStyle.Information, "Delete")
                    ShowOTData(TxtPatientNo.Text)
                    'GridIOL.DataSource = ModIOLRegistration.SelectIOL(OTNo)
                Else
                    MsgBox("Error OT registration.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub DeleteIOLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteIOLToolStripMenuItem.Click
        Try
            Dim index = GridIOL.SelectedCells(0).RowIndex
            Dim OTNo As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim IOLNo As String = GridIOL.Rows(index).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModIOLRegistration.DeleteIOL(IOLNo) = 1 Then
                    MsgBox("Delete IOL registration successfully.", MsgBoxStyle.Information, "Delete")
                    GridIOL.DataSource = ModIOLRegistration.SelectIOL(OTNo)
                Else
                    MsgBox("Error delete IOL registration.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Function CheckCurrentStockIOL(ByVal itemID As Integer) As Integer
        Dim tblIOL As DataTable = ItemListInDepartDataAdapter.GetItemDataInDepartByItemID(13, itemID)
        If tblIOL.Rows.Count = 0 Then
            Return 0
        Else
            For Each rows As DataRow In tblIOL.Rows
                Return rows("UnitsInStock")
            Next
        End If
    End Function
    Private Sub ReadyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOperationReady.Click

        Try
            'Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            'Dim PNo As Long = GridOT.GetRow.Cells("PatientNo").Value
            'Dim OTNo As String = GridOT.GetRow.Cells("OTNo").Value ' GridOTRegistration.Rows(index).Cells("OTNo").Value
            'Dim NewInPatientNo As String = GridOT.GetRow.Cells("NewInPatientNo").Value
            'Dim IOL As String = GridOTRegistration.Rows(index).Cells("IOL").Value
            'Dim IOL_ID As Integer = GridOTRegistration.Rows(index).Cells("IOL_ID").Value

            'If IOL.Trim <> "".Trim Then
            '    'If CheckCurrentStockIOL(IOL_ID) = 0 Then
            '    '    MsgBox("IOL out of stock in system. Could you check again.", MsgBoxStyle.Critical, "Error")
            '    '    Exit Sub
            '    'End If
            '    If GridIOL.Rows.Count = 0 Then

            '        MessageBox.Show("Please create IOL number before set to operation ready.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        'Try
            '        'Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            '        'Dim OTNo As String = GridOTRegistration.Rows(Index).Cells(0).Value
            '        Dim PatientNo As String = GridOTRegistration.Rows(index).Cells(2).Value
            '        Dim PatientName As String = GridOTRegistration.Rows(index).Cells(3).Value
            '        Dim Age As String = GridOTRegistration.Rows(index).Cells(4).Value
            '        Dim Sex As String = GridOTRegistration.Rows(index).Cells(5).Value
            '        'Dim DateOP As String = GridOTRegistration.Rows(Index).Cells("DateOperated").Value
            '        Dim FIOL As New FRMIOLRegistration
            '        FIOL.LblOTNo.Text = OTNo
            '        FIOL.txtPatientNo.Text = PatientNo
            '        FIOL.TxtName.Text = PatientName
            '        FIOL.TxtSex.Text = Sex
            '        FIOL.TxtAge.Text = Age
            '        'FIOL.LblDateCreateIOL.Text = DateOP
            '        FIOL.CboIOLItem.Text = GridOTRegistration.Rows(index).Cells("IOL").Value
            '        FIOL.ShowDialog()
            '        If FIOL.isClose = True Then
            '            GridIOL.DataSource = ModIOLRegistration.SelectIOL(FIOL.LblOTNo.Text)
            '        End If
            '        'Catch ex As Exception
            '        '    MessageBox.Show("Please select patient to create IOL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        'End Try
            '        Exit Sub
            '    End If


            'End If
            Dim Dialog As DialogResult = MessageBox.Show("Are you sure this patient operation ready?", "Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Dialog = DialogResult.Yes Then

                If ModOTRegistration.UpdateStatus(GridOT.GetRow.Cells("OTNo").Value) = 1 And ModNewInPatient.UpdateOTWating(GridOT.GetRow.Cells("NewInPatientNo").Value, 3) >= 0 Then
                    'Update Operation note
                    ModOTRegistration.UpdateDateOperated(GridOT.GetRow.Cells("OTNo").Value, Now.Date)
                    ModNewInPatient.UpdateLeave(GridOT.GetRow.Cells("NewInPatientNo").Value, "1")
                    ShowOTData(TxtPatientNo.Text)

                    'If ModOTRegistration.UpdateDateOperated(OTNo, Now.Date) = 1 Then
                    '    Me.DialogResult = Windows.Forms.DialogResult.OK
                    'End If

                    'Dim FDateOperated As New FrmDateOperated
                    'FDateOperated.LblSaveOption.Text = OTNo

                    'If FDateOperated.ShowDialog() = DialogResult.OK Then
                    '    Dim DOT As Date = FDateOperated.DateOperated.Value.Date
                    '    ShowOTData(TxtPatientNo.Text)
                    '    ModNewInPatient.UpdateLeave(NewInPatientNo, "1")
                    '    '================== Case update stock
                    '    'If CInt(GridOTRegistration.Rows(index).Cells("Waiting").Value) = 3 And IOL.Trim <> "".Trim Then
                    '    '    If GridOTRegistration.Rows(index).Cells("IOL_ID_OLD").Value <> GridOTRegistration.Rows(index).Cells("IOL_ID").Value Then
                    '    '        ' Enable Menu OT
                    '    '        ContextMenuNewInPatient.Enabled = False
                    '    '        ProcessCutStoce(MyIOLItemID, DOT)
                    '    '    End If
                    '    'Else
                    '    'If (IOL_ID <> 0) Then
                    '    '    Dim MyIOLItemID As Integer = Val(GridOTRegistration.Rows(index).Cells("IOL_ID").Value)
                    '    '    'ContextMenuNewInPatient.Enabled = False
                    '    '    ProcessCutStoce(MyIOLItemID, DOT)
                    '    'Else
                    '    '    MessageBox.Show("Operation ready.", "OT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    '    ShowOTData(TxtPatientNo.Text)

                    '    'End If
                    '    'If IOL.Trim <> "".Trim And ModIOLRegistration.CheckIOLReady(PNo) = False Then
                    '    '============= Do cut stoce ===================

                    '    'Else

                    '    'End If

                    'End If


                    'MsgBox("This patient operation ready.", MsgBoxStyle.Information, "Update")
                Else
                    MsgBox("Error update status operation.", MsgBoxStyle.Critical, "Error")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Please select patient to set to operation already.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            'ContextMenuNewInPatient.Enabled = True

        End Try
        'ContextMenuNewInPatient.Enabled = True
    End Sub
    Sub ProcessCutStoce(ByVal MyIOLItemID As Integer, ByVal DateOT As Date)
        'ContextMenuNewInPatient.Enabled = False
        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            '=========== tblUsed ==============
            Dim mytblUsed As New tblUsed
            mytblUsed.UsedDepartID = CInt(DEPART_ID)
            mytblUsed.UsedDescription = "IOL use in By " & USER_NAME
            mytblUsed.UsedUserID = CInt(USER_ID)
            mytblUsed.UsedDate = DateOT ' dptUsedDate.Value.Date

            THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
            THIDataContext.getTHIDataContext.SubmitChanges()
            '============ tblUsedDetail ============
            'For Each rRow As Janus.Windows.GridEX.GridEXRow In gridUsedItemDetail.GetRows
            Dim mytblUsedDetail As New tblUsedDetail
            mytblUsedDetail.UsedID = mytblUsed.UsedID
            mytblUsedDetail.ItemID = MyIOLItemID 'Val(rRow.Cells("ItemID").Value)
            mytblUsedDetail.UsedQuantity = 1 'Val(rRow.Cells("UsedQuantity").Value)

            THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
            THIDataContext.getTHIDataContext.SubmitChanges()

            '=========== Process cut stock ===========
            If CInt(DEPART_ID) <> MAIN_STOCK_DEPART_ID Then

                Dim TblCurrentItemOT As DataTable = DA_Item_Department.GetDepartmentItemStock(CInt(DEPART_ID), MyIOLItemID)

                Dim myDepartStock As New tblDeptStock
                ' move to particular record to cut balance in department stock
                'Dim qdepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = MyIOLItemID  'Val(rRow.Cells("ItemID").Value)
                'myDepartStock = qdepartStock.Single
                For Each IOL As DataRow In TblCurrentItemOT.Rows
                    '========================= Management Begin item quantity before perform transaction =========================
                    Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = DateOT And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = MyIOLItemID Select BBT.BeginBalanceTraceID).Count
                    If q = 0 Then
                        '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                        Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                        mytblBeginBalanceTrace.Date = DateOT
                        mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                        mytblBeginBalanceTrace.BeginBalanceOfDay = CInt(IOL("UnitsInStock"))  'myDepartStock.UnitsInStock
                        mytblBeginBalanceTrace.ItemID = MyIOLItemID  'Val(rRow.Cells("ItemID").Value)
                        THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                        THIDataContext.getTHIDataContext.SubmitChanges(Data.Linq.ConflictMode.ContinueOnConflict)
                    End If

                    '--- Update balance in department stock

                    DA_Item_Department.UpdateStockIOL(IOL("UnitsInStock") - 1, DEPART_ID, MyIOLItemID)
                Next
                'myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - 1 'Val(rRow.Cells("UsedQuantity").Value)
                'THIDataContext.getTHIDataContext.SubmitChanges(Data.Linq.ConflictMode.ContinueOnConflict)

            End If
            ' Next

            '*** Finished
            trans.Commit()
            ' THIDataContext.getTHIDataContext.Connection.Close()
            'ContextMenuNewInPatient.Enabled = True

            'process run end of day.

        Catch ex As Exception
            trans.Rollback()
            MsgBox("Error : " & ex.Message)
        Finally
            THIDataContext.getTHIDataContext.Connection.Close()
            'MessageBox.Show("Used items save successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Application.DoEvents()
            'Application.DoEvents()
            'DEP_EOD.BtnEndofDay_Click(sender, e) ' 
            'ContextMenuNewInPatient.Enabled = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'trans = Nothing

            ShowOTData(TxtPatientNo.Text)
        End Try

    End Sub
    Private Sub BtnFindHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindHistory.Click
        ShowOTHistory(TxtFindPatientNo.Text)
    End Sub

    Private Sub BtnStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatistic.Click
        Dim FOTStatistic As New FrmOTStatistic
        FOTStatistic.ShowDialog()
        FOTStatistic.Close()
        FOTStatistic.Dispose()
    End Sub

    Private Sub cmdUndoDeleteOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndoDeleteOT.Click
        Dim frmUndoDelOT As New frmUndoDeleteOT
        frmUndoDelOT.ShowDialog()
    End Sub



    Private Sub GridOTRegistration_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        ModCommon.NumberAllRowHeaderDataGrid(GridOTRegistration)
    End Sub

    Private Sub BtnCreateIOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(Index).Cells(0).Value
            Dim PatientNo As String = GridOTRegistration.Rows(Index).Cells(2).Value
            Dim PatientName As String = GridOTRegistration.Rows(Index).Cells(3).Value
            Dim Age As String = GridOTRegistration.Rows(Index).Cells(4).Value
            Dim Sex As String = GridOTRegistration.Rows(Index).Cells(5).Value
            Dim FIOL As New FRMIOLRegistration
            FIOL.LblOTNo.Text = OTNo
            FIOL.txtPatientNo.Text = PatientNo
            FIOL.TxtName.Text = PatientName
            FIOL.TxtSex.Text = Sex
            FIOL.TxtAge.Text = Age
            FIOL.ShowDialog()
            If FIOL.isClose = True Then
                GridIOL.DataSource = ModIOLRegistration.SelectIOL(FIOL.LblOTNo.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient to create IOL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnOperationReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim Dialog As DialogResult = MessageBox.Show("Are you sure this patient operation ready?", "Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(index).Cells(0).Value
            Dim NewInPatientNo As String = GridOTRegistration.Rows(index).Cells("NewInPatientNo").Value
            If Dialog = DialogResult.Yes Then
                If ModOTRegistration.UpdateStatus(OTNo) = 1 And ModNewInPatient.UpdateOTWating(NewInPatientNo, 3) >= 0 Then
                    Dim FDateOperated As New FrmDateOperated
                    FDateOperated.LblSaveOption.Text = OTNo
                    FDateOperated.ShowDialog()
                    FDateOperated.Dispose()
                    FDateOperated.Close()
                    ShowOTData(TxtPatientNo.Text)
                    MsgBox("This patient operation ready.", MsgBoxStyle.Information, "Update")
                Else
                    MsgBox("Error update status operation.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient to set to operation already.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub UCOT_AND_IOLList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuReadyInOT = MenuOperationReady
        ShowOTData(TxtPatientNo.Text)
    End Sub

    
    Private Sub GridIOL_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridIOL.SelectionChanged
        Try

            If IsReadyOP() = True Then
                If IsAdmin() = True Then
                    DeleteIOLToolStripMenuItem.Enabled = True
                Else
                    DeleteIOLToolStripMenuItem.Enabled = False
                    'MessageBox.Show("You don't have permistion to delet IOL. Please contact system admin to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                DeleteIOLToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Function IsAdmin() As Boolean
        Dim Acess As String = ""
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Administrator" Then
                    Return True
                Else
                    Return False
                End If
            End With
        Next
    End Function
    Function IsReadyOP() As Boolean
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim IsReady As Boolean = GridOTRegistration.Rows(index).Cells("Status").Value
            If IsReady = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub GridOT_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridOT.RowDoubleClick
        If e.Row.GroupCaption <> "" Then
            MessageBox.Show("Please select operation note.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                'Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
                If GridOT.SelectedItems(0).Table.Key = "OTRegistration" Then
                    UpdateOTRgegis()
                End If

                If GridOT.SelectedItems(0).Table.Key = "SCLERAL BUCKLING" Then
                    UpdateScleralBuckling()
                End If

                If GridOT.SelectedItems(0).Table.Key = "INTRAVITREAL_INJECTION" Then
                    UpdateInjection()
                End If
                If GridOT.SelectedItems(0).Table.Key = "GENERAL_OPERATIVE" Then
                    UpdateGeneralOperation()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PHACOEMULSIFICATION" Then
                    UpdatePHACOEMULSIFICATION()
                End If
                If GridOT.SelectedItems(0).Table.Key = "ECCE" Then
                    UpdateECCE()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PAR_PLANA" Then
                    UpdateParPlana()
                End If
                If GridOT.SelectedItems(0).Table.Key = "TRABECULECTOMY" Then
                    UpdateTrabeculectomy()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PTERYGIUM" Then
                    UpdatePterygium()
                End If

            Catch ex As Exception
                ' MsgBox("Error " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
       
    End Sub
    Private Sub UpdatePterygium()
        Dim FPterygium As New PterygiumExcisionandGraft
        FPterygium.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_ID").Value
        FPterygium.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FPterygium.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FPterygium.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FPterygium.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FPterygium.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FPterygium.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        FPterygium.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FPterygium.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FPterygium.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        FPterygium.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FPterygium.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FPterygium.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FPterygium.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FPterygium.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FPterygium.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        FPterygium.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value
        FPterygium.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value

        FPterygium.PTERYGIUM_NASAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_NASAL").Value
        FPterygium.PTERYGIUM_TEMPORAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_TEMPORAL").Value
        FPterygium.BRIDAL_SUPERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_SUPERIOR").Value
        FPterygium.BRIDAL_70VICRYL.Checked = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_70VICRYL").Value
        FPterygium.BRIDAL_80SILK.Checked = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_80SILK").Value
        FPterygium.BRIDAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_OTHERS").Value
        FPterygium.SUBCONJUNCTIVAL_XYLOCAIN_WITH.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_XYLOCAIN_WITH").Value
        FPterygium.SUBCONJUNCTIVAL_XYLOCAIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_XYLOCAIN").Value
        FPterygium.SUBCONJUNCTIVAL_NONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_NONE").Value
        FPterygium.PTERYGIUM_SCISSORS.Checked = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_SCISSORS").Value
        FPterygium.PTERYGIUM_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_OTHER").Value
        FPterygium.CAUTERY_MILD.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_MILD").Value
        FPterygium.CAUTERY_69BLADE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_69BLADE").Value
        FPterygium.CAUTERY_MODRATE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_MODRATE").Value

        FPterygium.CAUTERY_EXTENSIVE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_EXTENSIVE").Value
        FPterygium.CONJUNCTIVAL_SUPERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_SUPERIOR").Value
        FPterygium.CONJUNCTIVAL_OTHER_SITE.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_OTHER_SITE").Value
        FPterygium.SIZE1.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE1").Value
        FPterygium.SIZE2.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE2").Value
        FPterygium.GRAFT_80VERGIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_80VERGIN").Value
        FPterygium.GRAFT_100NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_100NYLON").Value
        FPterygium.GRAFT_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_OTHER").Value

        FPterygium.GRAFT_90NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_90NYLON").Value
        FPterygium.GRAFT_RUNNING.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_RUNNING").Value
        FPterygium.GRAFT_INTERRUPTED.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_INTERRUPTED").Value
        FPterygium.GRAFT_COMBINED.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_COMBINED").Value
        FPterygium.SUBCONJUNCTIVAL_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_GENTAL").Value
        FPterygium.SUBCONJUNCTIVAL_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_CEFAZOLIN").Value
        FPterygium.SUBCONJUNCTIVAL_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_DEXAMETHASONE").Value
        FPterygium.SUBCONJUNCTIVAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_OTHERS").Value
        FPterygium.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FPterygium.TOPICAL_TOBRADEX.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_TOBRADEX").Value
        FPterygium.TOPICAL_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHER").Value
        FPterygium.EXTRA_NOTES.Text = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_NOTES").Value
        FPterygium.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value

        If FPterygium.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblPtery As DataTable = DA_Ptery.SelectPterygium(FPterygium.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Ptery, TblPtery, PreviewOP.AxAcroPDF1, "Ptery")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateTrabeculectomy()
        Dim Ftrab As New Trabeculectomy
        Ftrab.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("TRABECULECTIOMY_ID").Value
        Ftrab.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        Ftrab.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        Ftrab.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        Ftrab.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        Ftrab.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        Ftrab.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        Ftrab.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        Ftrab.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        Ftrab.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        Ftrab.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        Ftrab.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        Ftrab.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        Ftrab.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        Ftrab.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        Ftrab.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        Ftrab.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        Ftrab.S_AN_SUBCONJUNCTIVAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_SUBCONJUNCTIVAL").Value
        Ftrab.LOCATION.Text = GridOT.SelectedItems(0).GetRow.Cells("LOCATION").Value



        Ftrab.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value
        Ftrab.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value
        Ftrab.CONJUNCTIVA_LIMBAL_BASE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVA_LIMBAL_BASE").Value
        Ftrab.CONJUNCTIVAL_FORNIX_BASE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_FORNIX_BASE").Value
        Ftrab.CONJUNC_NOTE_FROM.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNC_NOTE_FROM").Value
        Ftrab.CONJUNC_NOTE_TO.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNC_NOTE_TO").Value
        Ftrab.SHAPE1.Checked = GridOT.SelectedItems(0).GetRow.Cells("SHAPE1").Value
        Ftrab.SHAPE2.Checked = GridOT.SelectedItems(0).GetRow.Cells("SHAPE2").Value
        Ftrab.SHAPE_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("SHAPE_OTHER").Value
        Ftrab.SIZE1.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE1").Value
        Ftrab.SIZE2.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE2").Value
        Ftrab.THICKNESS13.Checked = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS13").Value
        Ftrab.THICKNESS12.Checked = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS12").Value
        Ftrab.THICKNESS23.Checked = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS23").Value
        Ftrab.THICKNESS_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS_OTHER").Value
        Ftrab.ADJUNCTIVE_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_NO").Value
        Ftrab.ADJUNCTIVE_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_YES").Value
        Ftrab.ADJUNCTIVE_MMC.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_MMC").Value


        Ftrab.ADJUNCTIVE_MMC_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_MMC_NOTE").Value
        Ftrab.ADJUNCTIVE_5FU.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_5FU").Value
        Ftrab.ADJUNCTIVE_5FU_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_5FU_NOTE").Value
        Ftrab.INTRABLE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRABLE").Value
        Ftrab.SOAKED.Checked = GridOT.SelectedItems(0).GetRow.Cells("SOAKED").Value
        Ftrab.SOAKED_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SOAKED_NOTE").Value
        Ftrab.IRRIGATION_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_NO").Value
        Ftrab.IRRIGATION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_YES").Value
        Ftrab.IRRIGATION_WITH.Text = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_WITH").Value
        ' Ftrab.IRRIGATION_NOT_DONE.Text = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_NOT_DONE").Value
        Ftrab.PARACENTESIS_NOTE_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("PARACENTESIS_NOTE_DONE").Value
        Ftrab.PARACENTESIS_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("PARACENTESIS_DONE").Value
        Ftrab.PARACENTESIS_DONE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("PARACENTESIS_DONE_NOTE").Value
        Ftrab.TRABECULECTOMY1.Text = GridOT.SelectedItems(0).GetRow.Cells("TRABECULECTOMY1").Value
        Ftrab.TRABECULECTOMY2.Text = GridOT.SelectedItems(0).GetRow.Cells("TRABECULECTOMY2").Value
        Ftrab.IRIDECTOMY_NOT_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRIDECTOMY_NOT_DONE").Value
        Ftrab.IRIDECTOMY_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRIDECTOMY_DONE").Value
        Ftrab.IRIDECTOMY_DONE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("IRIDECTOMY_DONE_NOTE").Value


        Ftrab.SCLERAL_NOTE_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_NOTE_NO").Value
        Ftrab.SCLERAL_100NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_100NYLON").Value
        Ftrab.SCLERAL_100PROLENE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_100PROLENE").Value
        Ftrab.SCLERAL_RELEASABLE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_RELEASABLE").Value
        Ftrab.SCLERAL_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_NOTE").Value
        Ftrab.CONJUNCTIVAL_INTERRUPTED.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_INTERRUPTED").Value
        Ftrab.CONJUNCTIVAL_INTERRUPTED_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_INTERRUPTED_NOTE").Value
        Ftrab.CONJUNCTIVAL_100NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_100NYLON").Value
        Ftrab.CONJUNCTIVAL_100PROLENE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_100PROLENE").Value
        Ftrab.CONJUNCTIVAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_OTHERS").Value
        Ftrab.COPLICATION_NONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("COPLICATION_NONE").Value
        Ftrab.COPLICATION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("COPLICATION_YES").Value
        Ftrab.OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PROCEDURES").Value
        Ftrab.SUB_GENTAL2MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL2MG").Value
        Ftrab.SUB_CEFAZOLIN50MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN50MG").Value
        Ftrab.SUB_DEXAMETHASONE_25MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE_25MG").Value
        Ftrab.SUB_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHER").Value
        Ftrab.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value

        Ftrab.TOPICAL_PILOCARPINE2.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE2").Value
        Ftrab.TOPICAL_VIGAMOX.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_VIGAMOX").Value
        Ftrab.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        Ftrab.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value
        

        If Ftrab.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblTrab As DataTable = DA_Trab.SelectTrabeculectomy(Ftrab.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Trab, TblTrab, PreviewOP.AxAcroPDF1, "Trabeculectomy")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateParPlana()
        Dim FParPlana As New ParPlanaVitrectomy
        FParPlana.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("PA_PLANA_ID").Value
        FParPlana.LblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FParPlana.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FParPlana.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FParPlana.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FParPlana.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FParPlana.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FParPlana.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FParPlana.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FParPlana.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        FParPlana.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FParPlana.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FParPlana.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FParPlana.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FParPlana.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FParPlana.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value



        FParPlana.PERITOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITOMY").Value
        FParPlana.SCLEROTOMISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE").Value
        FParPlana.SCLEROTOMISE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE_NOTE").Value
        FParPlana.INFUSION_SIZE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE").Value
        FParPlana.INFUSION_SIZE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE_NOTE").Value
        FParPlana.CORE_VITRECTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY").Value
        FParPlana.CORE_VITRECTOMY_NOTE1.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE1").Value
        FParPlana.CORE_VITRECTOMY_NOTE2.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE2").Value
        FParPlana.PERIPHERAL_VITRECTORMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERIPHERAL_VITRECTORMY").Value
        FParPlana.PERFLUOCARBON.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERFLUOCARBON").Value
        FParPlana.ENDO.Checked = GridOT.SelectedItems(0).GetRow.Cells("ENDO").Value
        FParPlana.ENDO_LASER.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_LASER").Value
        FParPlana.ENDO_MW.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_MW").Value
        FParPlana.ENDO_SHOTS.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_SHOTS").Value
        FParPlana.RETINOCRYOPEXY.Checked = GridOT.SelectedItems(0).GetRow.Cells("RETINOCRYOPEXY").Value
        FParPlana.AIR_FLUID_EXCHANGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("AIR_FLUID_EXCHANGE").Value

        FParPlana.PERITOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITOMY").Value
        FParPlana.SCLEROTOMISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE").Value
        FParPlana.SCLEROTOMISE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE_NOTE").Value
        FParPlana.INFUSION_SIZE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE").Value
        FParPlana.INFUSION_SIZE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE_NOTE").Value
        FParPlana.CORE_VITRECTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY").Value
        FParPlana.CORE_VITRECTOMY_NOTE1.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE1").Value
        FParPlana.CORE_VITRECTOMY_NOTE2.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE2").Value
        FParPlana.PERIPHERAL_VITRECTORMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERIPHERAL_VITRECTORMY").Value
        FParPlana.PERFLUOCARBON.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERFLUOCARBON").Value
        FParPlana.ENDO.Checked = GridOT.SelectedItems(0).GetRow.Cells("ENDO").Value
        FParPlana.ENDO_LASER.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_LASER").Value
        FParPlana.ENDO_MW.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_MW").Value
        FParPlana.ENDO_SHOTS.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_SHOTS").Value
        FParPlana.RETINOCRYOPEXY.Checked = GridOT.SelectedItems(0).GetRow.Cells("RETINOCRYOPEXY").Value
        FParPlana.AIR_FLUID_EXCHANGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("AIR_FLUID_EXCHANGE").Value



        FParPlana.GAS_EXCHANGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("GAS_EXCHANGE").Value
        FParPlana.SF6.Checked = GridOT.SelectedItems(0).GetRow.Cells("SF6").Value
        FParPlana.C6F8.Checked = GridOT.SelectedItems(0).GetRow.Cells("C6F8").Value
        FParPlana.C6F8_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("C6F8_NOTE").Value
        FParPlana.SCLERAL_BUCHING.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_BUCHING").Value
        FParPlana.SILICONE_OIL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SILICONE_OIL").Value
        FParPlana.PAR_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("PAR_NOTE").Value
        FParPlana.SCLEROTOMY_VICRYL.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMY_VICRYL").Value
        FParPlana.SCLEROLOMY_NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROLOMY_NYLON").Value
        FParPlana.SCLEROLOMY_DEXON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROLOMY_DEXON").Value
        FParPlana.CONJUNTIVAL_NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNTIVAL_NYLON").Value
        FParPlana.CONJUNTIVAL_VICRYL.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNTIVAL_VICRYL").Value
        FParPlana.SUB_GENTAL2MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL2MG").Value
        FParPlana.SUB_CEFAZOLIN50MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN50MG").Value
        FParPlana.RETINOCRYOPEXY.Checked = GridOT.SelectedItems(0).GetRow.Cells("RETINOCRYOPEXY").Value
        FParPlana.SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE").Value

        FParPlana.SUB_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHERS").Value
        FParPlana.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FParPlana.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FParPlana.TOPICAL_ATROPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_ATROPINE").Value
        FParPlana.TOPICAL_ALPHAGAN.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_ALPHAGAN").Value
        FParPlana.TOPICAL_VIGAMOX.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_VIGAMOX").Value
        FParPlana.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        FParPlana.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value
       

        If FParPlana.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim tblParPlana As DataTable = DA_ParPlana.SelectPaPlana(FParPlana.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_PA_PLANA, tblParPlana, PreviewOP.AxAcroPDF1, "ParPlana")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateECCE()
        Dim FExtraEcce As New ExtracapsularCataractExtraction_ECCE_

        FExtraEcce.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("ECCE_ID").Value
        FExtraEcce.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FExtraEcce.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FExtraEcce.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FExtraEcce.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FExtraEcce.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FExtraEcce.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        FExtraEcce.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FExtraEcce.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FExtraEcce.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value

        FExtraEcce.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FExtraEcce.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FExtraEcce.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FExtraEcce.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FExtraEcce.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value

        FExtraEcce.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value
        FExtraEcce.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value
        FExtraEcce.VIS_HEALON5.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON5").Value
        FExtraEcce.VIS_HEALON_GV.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON_GV").Value
        FExtraEcce.VIS_IALF.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_IALF").Value
        FExtraEcce.VIS_VISSOAT.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_VISSOAT").Value
        FExtraEcce.VIS_PROVISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_PROVISE").Value
        FExtraEcce.BSS_PLUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("BSS_PLUS").Value
        FExtraEcce.BSS.Checked = GridOT.SelectedItems(0).GetRow.Cells("BSS").Value

        FExtraEcce.PERITO_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITO_YES").Value
        FExtraEcce.PERITO_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITO_NO").Value
        FExtraEcce.CARTERY_MILD.Checked = GridOT.SelectedItems(0).GetRow.Cells("CARTERY_MILD").Value
        FExtraEcce.CARTERY_MODERATE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CARTERY_MODERATE").Value
        FExtraEcce.CAUTERY_EXTENSIVE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_EXTENSIVE").Value
        FExtraEcce.INCISION_SITE_CORNEOSCLERAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SITE_CORNEOSCLERAL").Value
        FExtraEcce.INCISION_SITE_SCLERAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SITE_SCLERAL").Value
        FExtraEcce.INCISION_SIZE_SUPERRIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SIZE_SUPERRIOR").Value
        FExtraEcce.INCISION_SIZE_SUPERRIOR_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SIZE_SUPERRIOR_NOTE").Value

        FExtraEcce.INCISION_SIZE_SUPERRIOR_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SIZE_SUPERRIOR_OTHER").Value
        FExtraEcce.CAPSULOTOMY_CYSTOTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULOTOMY_CYSTOTOMY").Value
        FExtraEcce.CAPSULOTOMY_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("CAPSULOTOMY_OTHERS").Value
        FExtraEcce.CARTERY_MODERATE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CARTERY_MODERATE").Value
        FExtraEcce.NUCLEUS_EXPRESSION.Checked = GridOT.SelectedItems(0).GetRow.Cells("NUCLEUS_EXPRESSION").Value
        FExtraEcce.NUCLEUS_LENSLOOP.Checked = GridOT.SelectedItems(0).GetRow.Cells("NUCLEUS_LENSLOOP").Value
        FExtraEcce.NUCLEUS_VISCO.Checked = GridOT.SelectedItems(0).GetRow.Cells("NUCLEUS_VISCO").Value
        FExtraEcce.CORTEX_SIMCO_IA.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORTEX_SIMCO_IA").Value
        FExtraEcce.CAPSULE_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULE_YES").Value


        FExtraEcce.CAPSULE_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULE_NO").Value
        FExtraEcce.IOL_IN_CAPSULAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_CAPSULAR").Value
        FExtraEcce.IOL_IN_SULCUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_SULCUS").Value
        FExtraEcce.IOL_IN_AC.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_AC").Value
        FExtraEcce.SUTURE_NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_NYLON").Value
        FExtraEcce.SUTURE_NYLON_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_NYLON_NOTE").Value
        FExtraEcce.SUTURE_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_OTHERS").Value
        FExtraEcce.SUBCONJUN_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_GENTAL").Value
        FExtraEcce.SUBCONJUN_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_CEFAZOLIN").Value

        FExtraEcce.SUBCONJUN_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_DEXAMETHASONE").Value
        FExtraEcce.SUBCONJUN_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_OTHERS").Value
        FExtraEcce.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FExtraEcce.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FExtraEcce.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        FExtraEcce.EXTRA_IRRIDECTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_IRRIDECTOMY").Value
        FExtraEcce.EXTRA_LOCATION.Text = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_LOCATION").Value
        FExtraEcce.EXTRA_CAPSULAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_CAPSULAR").Value
        FExtraEcce.EXTRA_VITREOS.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_VITREOS").Value


        FExtraEcce.EXTRA_ANTERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_ANTERIOR").Value
        FExtraEcce.EXTRA_AC_HEMORRHAGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_AC_HEMORRHAGE").Value
        FExtraEcce.EXTRA_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_OTHER").Value
        FExtraEcce.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value

        If FExtraEcce.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim tblECCE As DataTable = DA_ECCE.SelectECCE(FExtraEcce.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_ECCE, tblECCE, PreviewOP.AxAcroPDF1, "ECCE")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdatePHACOEMULSIFICATION()
        Dim FPhacoemulsification As New Phacoemulsification
        FPhacoemulsification.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("PHACOEMULSIF_ID").Value
        FPhacoemulsification.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FPhacoemulsification.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FPhacoemulsification.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FPhacoemulsification.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FPhacoemulsification.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FPhacoemulsification.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FPhacoemulsification.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FPhacoemulsification.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value


        FPhacoemulsification.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FPhacoemulsification.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FPhacoemulsification.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FPhacoemulsification.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FPhacoemulsification.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FPhacoemulsification.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        FPhacoemulsification.VIS_HEALON_GV.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON_GV").Value
        FPhacoemulsification.VIS_IALF.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_IALF").Value
        FPhacoemulsification.VIS_VISSOAT.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_VISSOAT").Value


        FPhacoemulsification.VIS_DUOVISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_DUOVISE").Value
        FPhacoemulsification.VIS_HEALON5.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON5").Value
        FPhacoemulsification.VIS_OPHTHALINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_OPHTHALINE").Value
        FPhacoemulsification.VIS_PROVISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_PROVISE").Value
        FPhacoemulsification.BSS_PLUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("BSS_PLUS").Value
        FPhacoemulsification.POWER.Text = GridOT.SelectedItems(0).GetRow.Cells("POWER").Value
        FPhacoemulsification.FLOW_RATE.Text = GridOT.SelectedItems(0).GetRow.Cells("FLOW_RATE").Value
        FPhacoemulsification.VAC.Text = GridOT.SelectedItems(0).GetRow.Cells("VAC").Value
        FPhacoemulsification.PHACO_TIME.Text = GridOT.SelectedItems(0).GetRow.Cells("PHACO_TIME").Value


        FPhacoemulsification.IA_FLOW_RATE.Text = GridOT.SelectedItems(0).GetRow.Cells("IA_FLOW_RATE").Value
        FPhacoemulsification.IA_VAC.Text = GridOT.SelectedItems(0).GetRow.Cells("IA_VAC").Value
        FPhacoemulsification.NOT_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("NOT_DONE").Value
        FPhacoemulsification.DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("DONE").Value
        FPhacoemulsification.DONE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("DONE_NOTE").Value
        FPhacoemulsification.CORNEAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORNEAL").Value
        FPhacoemulsification.SCLERAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL").Value
        FPhacoemulsification.FINAL_SIZE.Checked = GridOT.SelectedItems(0).GetRow.Cells("FINAL_SIZE").Value
        FPhacoemulsification.FINAL_SIZE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("FINAL_SIZE_NOTE").Value


        FPhacoemulsification.CAPSULORHEXIS.Text = GridOT.SelectedItems(0).GetRow.Cells("CAPSULORHEXIS").Value
        FPhacoemulsification.HEYDRODISSECTION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("HEYDRODISSECTION_YES").Value
        FPhacoemulsification.HEYDRODISSECTION_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("HEYDRODISSECTION_NO").Value
        FPhacoemulsification.PHACO_DIVIDE.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_DIVIDE").Value
        FPhacoemulsification.PHACO_CHOP.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_CHOP").Value
        FPhacoemulsification.PHACO_STOP_CHOP.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_STOP_CHOP").Value
        FPhacoemulsification.PHACO_SCULPTING.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_SCULPTING").Value
        FPhacoemulsification.PHACO_CRACKING.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_CRACKING").Value
        FPhacoemulsification.PHACO_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("PHACO_OTHERS").Value




        FPhacoemulsification.IA_TIP.Checked = GridOT.SelectedItems(0).GetRow.Cells("IA_TIP").Value
        FPhacoemulsification.IA_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("IA_OTHER").Value
        FPhacoemulsification.CAPSULAR_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULAR_YES").Value
        FPhacoemulsification.CAPSULAR_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULAR_NO").Value
        FPhacoemulsification.IOL_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_NO").Value
        FPhacoemulsification.IOL_IN_CAPSULAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_CAPSULAR").Value
        FPhacoemulsification.IOL_IN_SULCUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_SULCUS").Value
        FPhacoemulsification.IOL_IN_AC.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_AC").Value
        FPhacoemulsification.SUTURE_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_YES").Value


        FPhacoemulsification.SUTURE_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_NO").Value
        FPhacoemulsification.SUB_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL").Value
        FPhacoemulsification.SUB_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN").Value
        FPhacoemulsification.SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE").Value
        FPhacoemulsification.SUB_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHERS").Value
        FPhacoemulsification.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FPhacoemulsification.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FPhacoemulsification.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        FPhacoemulsification.COMPLICATION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("COMPLICATION_YES").Value

        FPhacoemulsification.COMPLICATION_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("COMPLICATION_NO").Value
        FPhacoemulsification.COMPLICATION_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("COMPLICATION_NOTE").Value
        FPhacoemulsification.OTHER_PRO_ANTERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PRO_ANTERIOR").Value
        FPhacoemulsification.OTHER_PRO_PI.Checked = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PRO_PI").Value
        FPhacoemulsification.OTHER_PRO_AT.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PRO_AT").Value
        FPhacoemulsification.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value


        If FPhacoemulsification.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim Phacoe As DataTable = DA_Phacoe.SelectPhacoemulsification(FPhacoemulsification.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Phacoemulsification, Phacoe, PreviewOP.AxAcroPDF1, "Phacoemulsification")
            PreviewOP.ShowDialog()
        End If

    End Sub
    Private Sub UpdateGeneralOperation()
        Dim FGeneralOperative As New GeneralOperativeNote

        FGeneralOperative.lblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("GENERAL_ID").Value
        FGeneralOperative.lblOpNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FGeneralOperative.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FGeneralOperative.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FGeneralOperative.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FGeneralOperative.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FGeneralOperative.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FGeneralOperative.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FGeneralOperative.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FGeneralOperative.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value

        FGeneralOperative.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FGeneralOperative.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FGeneralOperative.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FGeneralOperative.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FGeneralOperative.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FGeneralOperative.S_AN_SUBCONJUNCTIVAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_SUBCONJUNCTIVAL").Value
        FGeneralOperative.OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PROCEDURES").Value
        FGeneralOperative.SUB_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL").Value


        FGeneralOperative.SUB_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN").Value
        FGeneralOperative.SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE").Value
        FGeneralOperative.SUB_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHER").Value
        FGeneralOperative.TOPICAL_MAXITRAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITRAL").Value
        FGeneralOperative.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FGeneralOperative.TOPICAL_ATROPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_ATROPINE").Value
        FGeneralOperative.TOPICAL_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHER").Value
        FGeneralOperative.OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PROCEDURES").Value
        FGeneralOperative.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value

        If FGeneralOperative.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblGeneralOP As DataTable = DA_General_Operative.SelectOperatID(FGeneralOperative.lblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_GeneralOperative, TblGeneralOP, PreviewOP.AxAcroPDF1, "General_Operative")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateInjection()
        Dim FInjection As New FormIntravitrealInjection
        FInjection.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("INJECTION_ID").Value
        FInjection.LblOpNumber.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FInjection.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FInjection.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FInjection.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FInjection.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FInjection.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FInjection.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value

        FInjection.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        FInjection.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FInjection.START_TIME.Checked = True
        FInjection.START_TIME.Text = GridOT.SelectedItems(0).GetRow.Cells("START_TIME").Value

        FInjection.IVTA.Checked = GridOT.SelectedItems(0).GetRow.Cells("IVTA").Value
        FInjection.AVASTIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("AVASTIN").Value
        FInjection.LUCENTIS.Checked = GridOT.SelectedItems(0).GetRow.Cells("LUCENTIS").Value
        FInjection.AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("AN_TOPICAL").Value
        FInjection.AN_SUBCONJUNCTIVAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("AN_SUBCONJUNCTIVAL").Value
        FInjection.FULL_PRE_OP.Checked = GridOT.SelectedItems(0).GetRow.Cells("FULL_PRE_OP").Value
        FInjection.PATIENT_FULL.Checked = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_FULL").Value


        FInjection.INTRA_TRIAMCINOLONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRA_TRIAMCINOLONE").Value
        FInjection.INTRA_TRIAM_DOSE.Text = GridOT.SelectedItems(0).GetRow.Cells("INTRA_TRIAM_DOSE").Value
        FInjection.INTRA_AVASTIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRA_AVASTIN").Value
        FInjection.INTRA_AVASTIN_DOSE.Text = GridOT.SelectedItems(0).GetRow.Cells("INTRA_AVASTIN_DOSE").Value
        FInjection.INTRA_LUCENTIS.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRA_LUCENTIS").Value
        FInjection.INTRA_LUCENTIS_DOSE.Text = GridOT.SelectedItems(0).GetRow.Cells("INTRA_LUCENTIS_DOSE").Value
        FInjection.ALPHAGAM.Checked = GridOT.SelectedItems(0).GetRow.Cells("ALPHAGAM").Value

        FInjection.NEO_SYNEPHRINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("NEO_SYNEPHRINE").Value
        FInjection.POLY_OPH_TROPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("POLY_OPH_TROPICAL").Value
        FInjection.VIGAMOX_TROPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIGAMOX_TROPICAL").Value
        FInjection.VIGAMO_TROPICAL_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("VIGAMO_TROPICAL_NOTE").Value
        FInjection.MAXITROL_EYE_OITMENT.Checked = GridOT.SelectedItems(0).GetRow.Cells("MAXITROL_EYE_OITMENT").Value
        FInjection.PATH.Checked = GridOT.SelectedItems(0).GetRow.Cells("PATH").Value
        FInjection.NO_COMPLICATION.Checked = GridOT.SelectedItems(0).GetRow.Cells("NO_COMPLICATION").Value
        FInjection.NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("NOTE").Value
        FInjection.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value
        If FInjection.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblInjection As DataTable = DA_Intravitreal_Injection.SelectInjectionOp(FInjection.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Injection, TblInjection, PreviewOP.AxAcroPDF1, "Injection_operation")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateOTRgegis()
        Dim IsReady As Boolean = GridOT.GetRow.Cells("Status").Value
        Dim Acess As String = ""
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Administrator" Then
                    Acess = "Administrator"
                End If
            End With
        Next

        If IsReady = True Then
            If Acess = "Administrator" Then
                Dim FOTRegistration As New FRMOTRegistration
                FOTRegistration.LblSaveOption.Text = GridOT.GetRow.Cells("OTNo").Value
                FOTRegistration.TxtInpatientNo.Text = GridOT.GetRow.Cells("NewInPatientNo").Value
                FOTRegistration.TxtPatientNo.Text = GridOT.GetRow.Cells("PatientNo").Value
                FOTRegistration.TxtPatientName.Text = GridOT.GetRow.Cells("NameEng").Value
                FOTRegistration.TxtAge.Text = GridOT.GetRow.Cells("Age").Value
                FOTRegistration.TxtSex.Text = GridOT.GetRow.Cells("Sex").Value
                FOTRegistration.TxtAddress.Text = GridOT.GetRow.Cells("Address").Value
                FOTRegistration.DateOT.Checked = True
                FOTRegistration.DateOT.Value = GridOT.GetRow.Cells("CreateDate").Value
                Try
                    FOTRegistration.CboOperationTime.Checked = True
                    FOTRegistration.CboOperationTime.Text = GridOT.GetRow.Cells("OperationTime").Value
                Catch ex As Exception
                    FOTRegistration.CboOperationTime.Checked = False
                End Try
                Try
                    FOTRegistration.DateOperated.Checked = True
                    FOTRegistration.DateOperated.Value = GridOT.GetRow.Cells("DateOperated").Value
                Catch ex As Exception
                    FOTRegistration.DateOperated.Checked = False
                End Try
                FOTRegistration.TxtAnesthesia.Text = GridOT.GetRow.Cells("Anesthesia").Value
                FOTRegistration.ChPrepareOT.Visible = False
                FOTRegistration.CboAnesthetist.Text = GridOT.GetRow.Cells("Anesthetist").Value
                FOTRegistration.CboEye.Text = GridOT.GetRow.Cells("Eye").Value
                FOTRegistration.CboOperationType.Text = GridOT.GetRow.Cells("OperationType").Value
                'GridOTRegistration .Rows(e.RowIndex).Cells("IOL_ID").Value 
                If TypeOf GridOT.GetRow.Cells("IOL_ID").Value Is DBNull Then
                Else
                    FOTRegistration.CboIOLItem.SelectedValue = GridOT.GetRow.Cells("IOL_ID").Value
                    FOTRegistration.lblIOLIDOLD.Text = GridOT.GetRow.Cells("IOL_ID").Value
                End If
                If TypeOf GridOT.GetRow.Cells("IOL").Value Is DBNull Then
                    FOTRegistration.CboIOLItem.Text = ""
                Else
                    FOTRegistration.CboIOLItem.Text = GridOT.GetRow.Cells("IOL").Value
                End If

                FOTRegistration.CboSurgeon.Text = GridOT.GetRow.Cells("Surgeon").Value
                FOTRegistration.CboAssistant.Text = GridOT.GetRow.Cells("Assistant").Value
                FOTRegistration.TxtCirculation.Text = GridOT.GetRow.Cells("Circulation").Value
                FOTRegistration.TxtCompli.Text = GridOT.GetRow.Cells("Compli").Value
                FOTRegistration.TxtOther.Text = GridOT.GetRow.Cells("Others").Value
                FOTRegistration.ShowDialog()
                If FOTRegistration.DialogResult = DialogResult.OK Then
                    TxtPatientNo.Text = FOTRegistration.TxtPatientNo.Text
                    ShowOTData(TxtPatientNo.Text)
                End If
                FOTRegistration.Dispose()
                FOTRegistration.Close()
            Else
                MessageBox.Show("You don't have permistion to edit IOL. Please contact system admin to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            Dim FOTRegistration As New FRMOTRegistration
            FOTRegistration.LblSaveOption.Text = GridOT.GetRow.Cells("OTNo").Value
            FOTRegistration.TxtInpatientNo.Text = GridOT.GetRow.Cells("NewInPatientNo").Value
            FOTRegistration.TxtPatientNo.Text = GridOT.GetRow.Cells("PatientNo").Value
            FOTRegistration.TxtPatientName.Text = GridOT.GetRow.Cells("NameEng").Value
            FOTRegistration.TxtAge.Text = GridOT.GetRow.Cells("Age").Value
            FOTRegistration.TxtSex.Text = GridOT.GetRow.Cells("Sex").Value
            FOTRegistration.TxtAddress.Text = GridOT.GetRow.Cells("Address").Value
            FOTRegistration.DateOT.Checked = True
            FOTRegistration.DateOT.Value = GridOT.GetRow.Cells("CreateDate").Value
            Try
                FOTRegistration.CboOperationTime.Checked = True
                FOTRegistration.CboOperationTime.Text = GridOT.GetRow.Cells("OperationTime").Value
            Catch ex As Exception
                FOTRegistration.CboOperationTime.Checked = False
            End Try
            Try
                FOTRegistration.DateOperated.Checked = True
                FOTRegistration.DateOperated.Value = GridOT.GetRow.Cells("DateOperated").Value
            Catch ex As Exception
                FOTRegistration.DateOperated.Checked = False
            End Try
            FOTRegistration.TxtAnesthesia.Text = GridOT.GetRow.Cells("Anesthesia").Value
            FOTRegistration.ChPrepareOT.Visible = False
            FOTRegistration.CboAnesthetist.Text = GridOT.GetRow.Cells("Anesthetist").Value
            FOTRegistration.CboEye.Text = GridOT.GetRow.Cells("Eye").Value
            FOTRegistration.CboOperationType.Text = GridOT.GetRow.Cells("OperationType").Value
            'GridOTRegistration .Rows(e.RowIndex).Cells("IOL_ID").Value 
            If TypeOf GridOT.GetRow.Cells("IOL_ID").Value Is DBNull Then
            Else
                FOTRegistration.CboIOLItem.SelectedValue = GridOT.GetRow.Cells("IOL_ID").Value
                FOTRegistration.lblIOLIDOLD.Text = GridOT.GetRow.Cells("IOL_ID").Value
            End If
            If TypeOf GridOT.GetRow.Cells("IOL").Value Is DBNull Then
                FOTRegistration.CboIOLItem.Text = ""
            Else
                FOTRegistration.CboIOLItem.Text = GridOT.GetRow.Cells("IOL").Value
            End If

            FOTRegistration.CboSurgeon.Text = GridOT.GetRow.Cells("Surgeon").Value
            FOTRegistration.CboAssistant.Text = GridOT.GetRow.Cells("Assistant").Value
            FOTRegistration.TxtCirculation.Text = GridOT.GetRow.Cells("Circulation").Value
            FOTRegistration.TxtCompli.Text = GridOT.GetRow.Cells("Compli").Value
            FOTRegistration.TxtOther.Text = GridOT.GetRow.Cells("Others").Value
            FOTRegistration.ShowDialog()
            If FOTRegistration.DialogResult = DialogResult.OK Then
                TxtPatientNo.Text = FOTRegistration.TxtPatientNo.Text
                ShowOTData(TxtPatientNo.Text)
            End If
            FOTRegistration.Dispose()
            FOTRegistration.Close()
        End If
    End Sub
    Private Sub UpdateScleralBuckling()
        Dim FScleralBucling As New FormScleralBuckling
        FScleralBucling.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_ID").Value
        FScleralBucling.LblOperationNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FScleralBucling.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FScleralBucling.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FScleralBucling.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FScleralBucling.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FScleralBucling.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        FScleralBucling.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FScleralBucling.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FScleralBucling.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value

        FScleralBucling.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value
        FScleralBucling.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value

        FScleralBucling.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FScleralBucling.S_PERITOMY360.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_PERITOMY360").Value
        FScleralBucling.S_RECTUS_MUSCLES.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_RECTUS_MUSCLES").Value
        FScleralBucling.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FScleralBucling.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FScleralBucling.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FScleralBucling.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FScleralBucling.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FScleralBucling.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        FScleralBucling.S_EX_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_EX_GA").Value
        FScleralBucling.S_EX_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_EX_RETROBULBAR").Value
        FScleralBucling.S_EX_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_EX_TOPICAL").Value
        FScleralBucling.S_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("S_NOTE").Value
        FScleralBucling.S_OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("S_OTHER_PROCEDURES").Value
        FScleralBucling.S_CON_8VICRYL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_CON_8VICRYL").Value
        FScleralBucling.S_CON_10NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_CON_10NYLON").Value
        FScleralBucling.S_CON_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("S_CON_OTHERS").Value

        FScleralBucling.S_SUB_GENTAMICIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_GENTAMICIN").Value
        FScleralBucling.S_SUB_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_CEFAZOLIN").Value
        FScleralBucling.S_SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_DEXAMETHASONE").Value
        FScleralBucling.S_SUB_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_OTHERS").Value
        FScleralBucling.S_TOP_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_MAXITROL").Value
        FScleralBucling.S_TOP_ATROPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_ATROPINE").Value
        FScleralBucling.S_TOP_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_OTHERS").Value
        FScleralBucling.S_TOP_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_PILOCARPINE").Value
        FScleralBucling.S_SUGEON_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("S_SUGEON_NAME").Value
        ' FScleralBucling.S_TOP_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_PILOCARPINE").Value
        If FScleralBucling.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblScleralBuckling As DataTable = DA_ScleralBuckling.SelectScleralBuckling(FScleralBucling.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_ScleralBuckling, TblScleralBuckling, PreviewOP.AxAcroPDF1, "Scleral_Buckling")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateStatusOP()
        ModOTRegistration.UpdateStatus(GridOT.GetRow.Cells("OTNo").Value)
        ModNewInPatient.UpdateOTWating(GridOT.GetRow.Cells("NewInPatientNo").Value, 3)
        ModOTRegistration.UpdateDateOperated(GridOT.GetRow.Cells("OTNo").Value, Now.Date)
        ModNewInPatient.UpdateLeave(GridOT.GetRow.Cells("NewInPatientNo").Value, "1")
        ShowOTData(TxtPatientNo.Text)
    End Sub
    

    Private Sub BtnIntravitrealInjection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIntravitrealInjection.Click
        
    End Sub

    Private Sub BtnGeneralNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGeneralNote.Click
        
    End Sub

    Private Sub BtnPhacoemulsification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPhacoemulsification.Click
        
    End Sub

    Private Sub BtnECCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnECCE.Click
        
    End Sub

    Private Sub BtnParPlana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParPlana.Click
        
    End Sub

    Private Sub BtnTrapbeculectomy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTrapbeculectomy.Click
        
    End Sub

    Private Sub GridOT_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOT.SelectionChanged
        Try
            'Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            If GridOT.SelectedItems(0).Table.Key = "OTRegistration" Then
        
                OperationNote.Enabled = True
                BtnScleralBuckling.Enabled = True
                BtnIntravitrealInjection.Enabled = True
                BtnGeneralNote.Enabled = True
                BtnPhacoemulsification.Enabled = True
                BtnECCE.Enabled = True
                BtnParPlana.Enabled = True
                BtnTrapbeculectomy.Enabled = True
                PictureBox1.Image = ByteArrayToImage(DAPatientWait.SelectPicture(GridOT.GetRow.Cells("PatientNo").Value))
            Else
                OperationNote.Enabled = False
                BtnScleralBuckling.Enabled = False
                BtnIntravitrealInjection.Enabled = False
                BtnGeneralNote.Enabled = False
                BtnPhacoemulsification.Enabled = False
                BtnECCE.Enabled = False
                BtnParPlana.Enabled = False
                BtnTrapbeculectomy.Enabled = False
                PictureBox1.Image = Nothing
            End If

            

        Catch ex As Exception
            ' MsgBox("Error " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnPterygium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPterygium.Click
        
    End Sub

    Private Sub ScleralBucklingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScleralBucklingToolStripMenuItem.Click
        Try
            Dim FScleralBucling As New FormScleralBuckling
            FScleralBucling.LblOperationNo.Text = GridOT.GetRow.Cells("OTNo").Value
            FScleralBucling.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FScleralBucling.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FScleralBucling.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FScleralBucling.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            FScleralBucling.SURGEON.Text = GridOT.GetRow.Cells("Surgeon").Value
            FScleralBucling.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FScleralBucling.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FScleralBucling.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FScleralBucling.ShowDialog() = DialogResult.OK Then
                UpdateStatusOP()
                'ShowOTData(FScleralBucling.PATIENT_NO.Text)
                'Dim PreviewOP As New OperationNotePreview
                'Dim TblScleralBuckling As DataTable = DA_ScleralBuckling.SelectScleralBuckling(GridOT.GetRow.Cells("OTNo").Value)
                'EXPORT_PDF_PRINTER(CRV_ScleralBuckling, TblScleralBuckling, PreviewOP.AxAcroPDF1, "Scleral_Buckling")
                'PreviewOP.ShowDialog()
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub IntravitrealInjectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntravitrealInjectionToolStripMenuItem.Click
        Try
            Dim FInjection As New FormIntravitrealInjection
            FInjection.LblOpNumber.Text = GridOT.GetRow.Cells("OTNo").Value
            FInjection.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FInjection.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FInjection.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FInjection.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            'FInjection.SURGEON.Text = GridOT.GetRow.Cells("Surgeon").Value
            FInjection.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FInjection.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FInjection.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FInjection.ShowDialog() = DialogResult.OK Then
                UpdateStatusOP()
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub GeneralOperativeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralOperativeToolStripMenuItem.Click
        Try
            Dim FGeneralOperative As New GeneralOperativeNote
            FGeneralOperative.lblOpNo.Text = GridOT.GetRow.Cells("OTNo").Value
            FGeneralOperative.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FGeneralOperative.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FGeneralOperative.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FGeneralOperative.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            '  FInjection.SURGEON.Text = GridOT.GetRow.Cells("Surgeon").Value
            FGeneralOperative.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FGeneralOperative.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FGeneralOperative.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FGeneralOperative.ShowDialog() = DialogResult.OK Then
                UpdateStatusOP()
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub PhacoemulsificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhacoemulsificationToolStripMenuItem.Click
        Try
            Dim FPhacoemulsification As New Phacoemulsification
            FPhacoemulsification.lblOperNo.Text = GridOT.GetRow.Cells("OTNo").Value
            FPhacoemulsification.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FPhacoemulsification.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FPhacoemulsification.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FPhacoemulsification.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            '  FInjection.SURGEON.Text = GridOT.GetRow.Cells("Surgeon").Value
            FPhacoemulsification.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FPhacoemulsification.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FPhacoemulsification.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FPhacoemulsification.ShowDialog() = DialogResult.OK Then
                UpdateStatusOP()
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub ExtracapsularCataractExtractionECCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtracapsularCataractExtractionECCEToolStripMenuItem.Click
        Try
            Dim FExtraEcce As New ExtracapsularCataractExtraction_ECCE_
            FExtraEcce.lblOperNo.Text = GridOT.GetRow.Cells("OTNo").Value
            FExtraEcce.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FExtraEcce.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FExtraEcce.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FExtraEcce.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            FExtraEcce.SURGEON.Text = GridOT.GetRow.Cells("Surgeon").Value
            FExtraEcce.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FExtraEcce.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FExtraEcce.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FExtraEcce.ShowDialog() = DialogResult.OK Then
                UpdateStatusOP()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ParPlanaVitrectomyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParPlanaVitrectomyToolStripMenuItem.Click
        Try
            Dim FParPlana As New ParPlanaVitrectomy
            FParPlana.LblOperNo.Text = GridOT.GetRow.Cells("OTNo").Value
            FParPlana.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FParPlana.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FParPlana.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FParPlana.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            FParPlana.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FParPlana.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FParPlana.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FParPlana.ShowDialog() = DialogResult.OK Then
                UpdateStatusOP()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TrapbeculectomyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrapbeculectomyToolStripMenuItem.Click
        Try
            Dim FTrapbeculectomy As New Trabeculectomy
            FTrapbeculectomy.lblOperNo.Text = GridOT.GetRow.Cells("OTNo").Value
            FTrapbeculectomy.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FTrapbeculectomy.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FTrapbeculectomy.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FTrapbeculectomy.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            FTrapbeculectomy.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FTrapbeculectomy.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FTrapbeculectomy.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FTrapbeculectomy.ShowDialog() = DialogResult.OK Then
                ' ModOTRegistration.UpdateDateOperated(GridOT.GetRow.Cells("OTNo").Value, Now.Date)
                UpdateStatusOP()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PterygiumExcisionAndGraftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PterygiumExcisionAndGraftToolStripMenuItem.Click
        Try
            Dim FPterygium As New PterygiumExcisionandGraft
            FPterygium.lblOperNo.Text = GridOT.GetRow.Cells("OTNo").Value
            FPterygium.PATIENT_NO.Text = GridOT.GetRow.Cells("PatientNo").Value
            FPterygium.PATIENT_NAME.Text = GridOT.GetRow.Cells("NameEng").Value
            FPterygium.PATIENT_SEX.Text = GridOT.GetRow.Cells("Sex").Value
            FPterygium.PATIENT_AGE.Text = GridOT.GetRow.Cells("Age").Value
            FPterygium.SURGEON.Text = GridOT.GetRow.Cells("SURGEON").Value
            FPterygium.SCRUB.Text = GridOT.GetRow.Cells("Assistant").Value
            FPterygium.CIRCULATING.Text = GridOT.GetRow.Cells("Circulation").Value
            FPterygium.ANESTHESIONLOGIST.Text = GridOT.GetRow.Cells("Anesthetist").Value
            If FPterygium.ShowDialog() = DialogResult.OK Then
                UpdateStatusOP()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
