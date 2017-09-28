Imports Janus.Windows.GridEX
Imports System.Data.Common

Public Class UCPrescriptionList

    Dim DSPha As New DSPharmacy
    Dim VPrescripMainDataAdapter As New DSPharmacyTableAdapters.VPRESCRIP_MAIN_INVENTORYTableAdapter
    Dim VPrescripDetailDataAdapter As New DSPharmacyTableAdapters.VPRESCRIP_DETAIL_INVENTORYTableAdapter
    Private THIDataContext As New BaseDataContext
    Dim MTakeoInventory As MainTakeoInventory
    Sub New(ByVal MInventor As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MInventor
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub UCPrescriptionList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'LoadGridPrescription()
        SplitContainerPrescription.Panel2Collapsed = True
        CheckStatusGive(0)
        With CboDoctor
            .DataSource = ModDoctor.SelectDoctor()
            .ValueMember = "doctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnNewPrescrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPrescrip.Click

        Dim FPrescription As New frmPrescription(Me)
        If FPrescription.ShowDialog() = DialogResult.OK Then
            'LoadGridPrescription()
            CheckStatusGive(0)
        End If

    End Sub

    Sub LoadGridPrescription()
        'VPrescripMainDataAdapter.'GetData()
        VPrescripMainDataAdapter.FillBy1(DSPha.VPRESCRIP_MAIN_INVENTORY, DFrom.Value.Date, DTo.Value.Date) 'Fill(DSPha.VPRESCRIP_MAIN_INVENTORY)
        VPrescripDetailDataAdapter.GetData()
        VPrescripDetailDataAdapter.Fill(DSPha.VPRESCRIP_DETAIL_INVENTORY)
        gridPrescriptions.DataSource = DSPha.VPRESCRIP_MAIN_INVENTORY
        gridPrescriptions.RootTable.ChildTables(0).DataMember = "VPRESCRIP_MAIN_INVENTORY_VPRESCRIP_DETAIL_INVENTORY"
    End Sub


    Private Sub BtnRefreshPrescrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshPrescrip.Click
        LoadGridPrescription()
        SplitContainerPrescription.Panel2Collapsed = True
    End Sub

    Private Sub BtnGiveMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGiveMedicine.Click
        SplitContainerPrescription.Panel2Collapsed = True
        If gridPrescriptions.GetRow.Cells("Status").Value = 1 Then
            MessageBox.Show("The medicince already griven.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        checkedRows = gridPrescriptions.GetCheckedRows()
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please select at least 1 prescription.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim message As String
            message = String.Format("You are about to give {0} prescription(s)." _
                        & vbCrLf & "Do you want to continue?", checkedRows.Length)
            If MessageBox.Show(message, "TEH", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
                System.Windows.Forms.DialogResult.Yes Then
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                ' Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                For I As Int16 = 0 To gridPrescriptions.GetRows.Count - 1
                    If gridPrescriptions.GetRow(I).Cells("Status").Value = 0 And gridPrescriptions.GetRow(I).Cells(0).Value = True Then
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        Try
                            'THIDataContext.getTHIDataContext.Connection.Close()
                            'THIDataContext.getTHIDataContext.Connection.Open()
                            'Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                            THIDataContext.getTHIDataContext.Transaction = trans
                            'Try
                            '--- Validate department have medicine available for particular prescription 
                            Dim prescriptID As Integer = CInt(gridPrescriptions.GetRow(I).Cells("PrescripID").Value)  'CInt(gridPrescriptions.GetValue("PrescripID"))
                            Dim isPrescriptHaveItemInDepart As Boolean = False
                            Dim listPrescriptDetail = From prescriptDetail In THIDataContext.getTHIDataContext.PRESCRIP_DETAIL_INVENTORies Where prescriptDetail.PrescripID = prescriptID

                            '--- Update Status Prescriptions
                            Dim prescription = From prescript In THIDataContext.getTHIDataContext.PRESCIP_INVENTORies Where prescript.PrescripID = prescriptID
                            Dim myPrescription As PRESCIP_INVENTORY = prescription.SingleOrDefault

                            If myPrescription.Status = 1 Then 'Indicate prescription already Process
                                Exit Sub
                            End If

                            myPrescription.Status = 1 ' Indicate prescription approved 
                            THIDataContext.getTHIDataContext.SubmitChanges()

                            For Each preDetail As PRESCRIP_DETAIL_INVENTORY In listPrescriptDetail.ToList

                                If preDetail.ItemID <> 0 And preDetail.IsOutsideMedicine = 1 Then 'Indicate item exist in Pharmacy
                                    Dim itemID As Integer = preDetail.ItemID
                                    Dim unitsInStock As Integer = 0

                                    '--- Register Begin Balance of item (myRequestToDepartID) 
                                    Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = PHARMACY_DEPART_ID And departStock.ItemID = itemID
                                    unitsInStock = qDepartStock.SingleOrDefault.UnitsInStock

                                    Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = PHARMACY_DEPART_ID And BBT.ItemID = itemID Select BBT.BeginBalanceTraceID).Count
                                    If q = 0 Then

                                        Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                                        mytblBeginBalanceTrace.Date = GetDateServer()
                                        mytblBeginBalanceTrace.DepartID = PHARMACY_DEPART_ID
                                        mytblBeginBalanceTrace.BeginBalanceOfDay = unitsInStock
                                        mytblBeginBalanceTrace.ItemID = itemID

                                        THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                                        THIDataContext.getTHIDataContext.SubmitChanges()
                                    End If

                                    isPrescriptHaveItemInDepart = True
                                End If

                            Next

                            '--- Insert tblUsed 
                            Dim mytblUsed As New tblUsed
                            If isPrescriptHaveItemInDepart = True Then

                                mytblUsed.UsedDepartID = PHARMACY_DEPART_ID
                                mytblUsed.UsedDate = GetDateServer.Date

                                '--- Get department name ----
                                Dim q = From depart In THIDataContext.getTHIDataContext.tblDepartments Where depart.DepartID = PHARMACY_DEPART_ID _
                                Select depart.DepartName

                                mytblUsed.UsedDescription = "Give to patient in prescription : " & prescriptID & " in " & q.First
                                mytblUsed.UsedUserID = CInt(USER_ID)

                                THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                                For Each preDetail As PRESCRIP_DETAIL_INVENTORY In listPrescriptDetail.ToList

                                    If preDetail.ItemID <> 0 And preDetail.IsOutsideMedicine = 1 Then 'Indicate item exist in Pharmacy

                                        Dim itemID As Integer = preDetail.ItemID

                                        '--- Updata Pharmacy stock
                                        Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = PHARMACY_DEPART_ID And departStock.ItemID = itemID

                                        Dim myDepartStock = qDepartStock.SingleOrDefault
                                        myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - preDetail.ItemQuantity
                                        THIDataContext.getTHIDataContext.SubmitChanges()

                                        '--- Insert tblUsedDetail
                                        Dim mytblUsedDetail As New tblUsedDetail
                                        mytblUsedDetail.UsedID = mytblUsed.UsedID
                                        mytblUsedDetail.ItemID = itemID
                                        mytblUsedDetail.UsedQuantity = preDetail.ItemQuantity

                                        THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                                        THIDataContext.getTHIDataContext.SubmitChanges()

                                    End If
                                Next
                            End If

                            trans.Commit()

                        Catch ex As Exception
                            trans.Rollback()
                            THIDataContext.getTHIDataContext.Connection.Close()
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                        'Catch ex As Exception

                        'End Try
                    End If
                Next
                THIDataContext.getTHIDataContext.Connection.Close()
                MessageBox.Show("Transaction save successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CheckStatusGive(0)
                gridPrescriptions.Refresh()
            End If

        End If
    End Sub

    Private Sub BtnEditPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditPrescription.Click
        If gridPrescriptions.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select prescription to edit.", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            'Dim FNewReceipt As New FrmNewReceipt(MTakeoInventory)
            'FNewReceipt.LblSaveStatus.Text = "1"
            'FNewReceipt.InvoiceNo = GridReceipt.SelectedItems(0).GetRow.Cells("ReceiptNo").Value
            'If FNewReceipt.ShowDialog() = DialogResult.OK Then
            '    LoadingReceiptByDateWithWaitAndPaid(DateTo.Value, DateFrom.Value, 2)
            'End If
            Dim FPrescription As New frmPrescription(Me)
            FPrescription.LblSaveStatus.Text = "1"
            FPrescription.PrescripID = gridPrescriptions.SelectedItems(0).GetRow.Cells("PrescripID").Value
            If FPrescription.ShowDialog() = DialogResult.OK Then
                LoadGridPrescription()
            End If
        End If
    End Sub

    Private Sub gridPrescriptions_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridPrescriptions.SelectionChanged
        Try
            If gridPrescriptions.GetValue("Status") <> 0 Then
                BtnEditPrescription.Enabled = False
            Else
                BtnEditPrescription.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    
    Dim IS_CHECK As Boolean = False
    Private Sub BtnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheck.Click
        Try
            If IS_CHECK = False Then
                For i As Integer = 0 To gridPrescriptions.GetRows.Count - 1
                    If gridPrescriptions.GetRow(i).Cells("Status").Value = 1 Then
                        gridPrescriptions.GetRow(i).CheckState = RowCheckState.Unchecked
                    Else
                        gridPrescriptions.GetRow(i).CheckState = RowCheckState.Checked
                    End If
                Next
                gridPrescriptions.Refresh()
                IS_CHECK = True
                BtnCheck.Text = "Uncheck All"
            Else
                For i As Integer = 0 To gridPrescriptions.GetRows.Count - 1
                    gridPrescriptions.GetRow(i).CheckState = RowCheckState.Unchecked
                Next
                gridPrescriptions.Refresh()
                IS_CHECK = False
                BtnCheck.Text = "Check All"
            End If
        Catch ex As Exception

        End Try
       
        
    End Sub

    Private Sub RdNotYetGive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdNotYetGive.CheckedChanged
        CheckStatusGive(0)
        SplitContainerPrescription.Panel2Collapsed = True
    End Sub
    Sub CheckStatusGive(ByVal Status As Integer)
        If RdNotYetGive.Checked = True Then
            VPrescripMainDataAdapter.FillByStatusGive(DSPha.VPRESCRIP_MAIN_INVENTORY, Status)
            VPrescripDetailDataAdapter.Fill(DSPha.VPRESCRIP_DETAIL_INVENTORY)
            gridPrescriptions.DataSource = DSPha.VPRESCRIP_MAIN_INVENTORY
            gridPrescriptions.RootTable.ChildTables(0).DataMember = "VPRESCRIP_MAIN_INVENTORY_VPRESCRIP_DETAIL_INVENTORY"
        Else
            VPrescripMainDataAdapter.FillByReadyWithDate(DSPha.VPRESCRIP_MAIN_INVENTORY, Status, DFrom.Value.Date, DTo.Value.Date)
            VPrescripDetailDataAdapter.Fill(DSPha.VPRESCRIP_DETAIL_INVENTORY)
            gridPrescriptions.DataSource = DSPha.VPRESCRIP_MAIN_INVENTORY
            gridPrescriptions.RootTable.ChildTables(0).DataMember = "VPRESCRIP_MAIN_INVENTORY_VPRESCRIP_DETAIL_INVENTORY"
        End If
        
    End Sub

    Private Sub RadGive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadGive.CheckedChanged
        CheckStatusGive(1)
        SplitContainerPrescription.Panel2Collapsed = True
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        SplitContainerPrescription.Panel2Collapsed = True
        Dim FPatient As New FindPatientPrescription(Me)
        FPatient.ShowDialog()
        FPatient.Dispose()
        FPatient.Close()
    End Sub
    Sub FindPatientPrescription(ByVal PatientNo As Double)
        VPrescripMainDataAdapter.FillByPatientNo(DSPha.VPRESCRIP_MAIN_INVENTORY, PatientNo) 'FillByStatusGive(DSPha.VPRESCRIP_MAIN_INVENTORY, Status)
        VPrescripDetailDataAdapter.Fill(DSPha.VPRESCRIP_DETAIL_INVENTORY)
        gridPrescriptions.DataSource = DSPha.VPRESCRIP_MAIN_INVENTORY
        gridPrescriptions.RootTable.ChildTables(0).DataMember = "VPRESCRIP_MAIN_INVENTORY_VPRESCRIP_DETAIL_INVENTORY"
    End Sub
    Dim DAPrescription As New DSPharmacy_V1TableAdapters.VPrescription_Pharmacy1TableAdapter
    Dim RPreDetail As New PrescriptionPharmacyByAll_Date
    Private Sub BtnPrescriptinPreveiw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrescriptinPreveiw.Click
        MTakeoInventory.StatusLoading(True)
        SplitContainerPrescription.Panel1Collapsed = True
        Application.DoEvents()
        BGLoadPrescription.RunWorkerAsync()
    End Sub
    Sub ViewPrescriptionDetail()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewPrescriptionDetail))
        Else
            Dim TblPrescrptTem As DataTable
            If RadAllPrescription.Checked = True Then

                TblPrescrptTem = DAPrescription.GetDataPrescriptionDate(DFrom.Value.Date, DTo.Value.Date)
                RPreDetail.SetDataSource(TblPrescrptTem)
                RPreDetail.SetParameterValue("Title_Prescription", "Pharmacy From " & FormatDateTime(DFrom.Value, DateFormat.ShortDate) & " To " & FormatDateTime(DTo.Value, DateFormat.ShortDate) & " By All prescription")
            End If
            If RadByDoctor.Checked = True Then
                If ValidateCombobox(CboDoctor, "", ErrPrescription) = False Then Exit Sub
                TblPrescrptTem = DAPrescription.GetDataByPrescriptionByDoc(DFrom.Value.Date, DTo.Value.Date, CboDoctor.SelectedValue)
                RPreDetail.SetDataSource(TblPrescrptTem)
                RPreDetail.SetParameterValue("Title_Prescription", "Pharmacy From " & FormatDateTime(DFrom.Value, DateFormat.ShortDate) & " To " & FormatDateTime(DTo.Value, DateFormat.ShortDate) & " By All Doctor: " & CboDoctor.Text )
            End If

            CRVPrescription.ReportSource = RPreDetail
            CRVPrescription.Refresh()
        End If
    End Sub
    Private Sub RadAllPrescription_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllPrescription.CheckedChanged
        SplitContainerPrescription.Panel1Collapsed = True
    End Sub

    Private Sub RadByDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByDoctor.CheckedChanged
        SplitContainerPrescription.Panel1Collapsed = True
    End Sub

    Private Sub BGLoadPrescription_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadPrescription.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub BGLoadPrescription_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadPrescription.DoWork
        ViewPrescriptionDetail()
    End Sub

    Private Sub p(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRVPrescription.Load

    End Sub
End Class
