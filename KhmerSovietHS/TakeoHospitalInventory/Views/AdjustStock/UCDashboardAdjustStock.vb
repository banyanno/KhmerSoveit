Imports Janus.Windows.GridEX
Imports System.Data.Common

Public Class UCDashboardAdjustStock


    Dim DepartAdjustStockDataAdapter As DSDepartmentStockTableAdapters.VAdjustStockHistoryTableAdapter
    Dim IUser As IUserManagement = New UserManagementImplement
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        DepartAdjustStockDataAdapter = New DSDepartmentStockTableAdapters.VAdjustStockHistoryTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub myRefresh()


        'Dim User As Department_User = IUser.GetUID(CInt(USER_ID))

        'If User.isHospitalManager = True And User.isMainStockManager = True Then
        '    gridAdjustmentHistory.DataSource = DepartAdjustStockDataAdapter.GetData
        '    Exit Sub
        'End If

        'If User.isMainStockManager = True Then
        '    gridAdjustmentHistory.DataSource = DepartAdjustStockDataAdapter.GetDepartAdjustItem(MAIN_STOCK_DEPART_ID)
        'ElseIf User.isHospitalManager = True Then
        '    gridAdjustmentHistory.DataSource = DepartAdjustStockDataAdapter.GetAdjustmentDataByDepartID(MAIN_STOCK_DEPART_ID)        
        'End If
        gridAdjustmentHistory.DataSource = DepartAdjustStockDataAdapter.SelectAdjustDateToDate(DateAdjFrom.Value.Date, DateAdjTo.Value.Date)
        


    End Sub
    Private Sub BtnRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshData.Click
        myRefresh()
    End Sub

    Private Sub UCDashboardAdjustStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myRefresh()
    End Sub

    Private Sub BtnApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApproved.Click


        If Not gridAdjustmentHistory.CurrentRow Is Nothing AndAlso gridAdjustmentHistory.CurrentRow.RowType = RowType.Record Then

            If gridAdjustmentHistory.GetValue("IsApproval") = True Then
                MessageBox.Show("Adjustment already approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim THIDataContextAPPROVED As New BaseDataContext

            THIDataContextAPPROVED.getTHIDataContext.Connection.Close()
            THIDataContextAPPROVED.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContextAPPROVED.getTHIDataContext.Connection.BeginTransaction
            THIDataContextAPPROVED.getTHIDataContext.Transaction = trans

            If MessageBox.Show("Are you sure to approve adjust item ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try

                    If CInt(gridAdjustmentHistory.GetValue("DepartID")) <> MAIN_STOCK_DEPART_ID Then



                        'Dim myMainStock As New tblCentralInventory
                        ''--- Query to particular record to cut balance in main stock 
                        'Dim qaaa = From centralStock In THIDataContextAPPROVED.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))
                        'myMainStock = qaaa.SingleOrDefault
                        ''MsgBox(CDate(gridAdjustmentHistory.GetValue("AdjustDate")).Date & "  " & CDate(gridAdjustmentHistory.GetValue("AdjustDate")))
                        ''========================= Management Begin item quantity before perform transaction =========================
                        'Dim qBBT = (From BBT In THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate")).Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = Val(gridAdjustmentHistory.GetValue("ItemID")) Select BBT.BeginBalanceTraceID).Count
                        'If qBBT = 0 Then
                        '    '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                        '    Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                        '    mytblBeginBalanceTrace.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate"))
                        '    mytblBeginBalanceTrace.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID"))
                        '    mytblBeginBalanceTrace.BeginBalanceOfDay = myMainStock.UnitsInStock
                        '    mytblBeginBalanceTrace.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))

                        '    THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                        '    THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()
                        'End If


                        'Dim myDepartStock As New tblDeptStock
                        '' move to particular record to cut balance in department stock
                        'Dim qdepartStock = From departStock In THIDataContextAPPROVED.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = Val(gridAdjustmentHistory.GetValue("ItemID"))
                        'myDepartStock = qdepartStock.SingleOrDefault

                        '========================= Management Begin item quantity before perform transaction =========================
                        'Dim qdep = (From BBT In THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate")).Date And BBT.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID")) And BBT.ItemID = Val(gridAdjustmentHistory.GetValue("ItemID")) Select BBT.BeginBalanceTraceID).Count
                        'If qdep = 0 Then
                        '    '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                        '    Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                        '    mytblBeginBalanceTrace.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate")).Date
                        '    mytblBeginBalanceTrace.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID"))
                        '    mytblBeginBalanceTrace.BeginBalanceOfDay = myDepartStock.UnitsInStock
                        '    mytblBeginBalanceTrace.ItemID = Val(gridAdjustmentHistory.GetValue("ItemID"))

                        '    THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                        '    THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()
                        'End If


                        '--- Update Quantity item in department stock
                        Dim q = From departStock In THIDataContextAPPROVED.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID")) And departStock.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))
                        Dim TDepartStock As tblDeptStock = q.SingleOrDefault

                        Dim qdep = (From BBT In THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate")).Date And BBT.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID")) And BBT.ItemID = Val(gridAdjustmentHistory.GetValue("ItemID")) Select BBT.BeginBalanceTraceID).Count
                        If qdep = 0 Then
                            '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                            Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                            mytblBeginBalanceTrace.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate")).Date
                            mytblBeginBalanceTrace.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID"))
                            mytblBeginBalanceTrace.BeginBalanceOfDay = TDepartStock.UnitsInStock
                            mytblBeginBalanceTrace.ItemID = Val(gridAdjustmentHistory.GetValue("ItemID"))

                            THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                            THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()
                        End If

                        '--- Update status of adjustment record field IsApproval
                        Dim TmpAdjustStock = From adjustStock In THIDataContextAPPROVED.getTHIDataContext.tblAdjustStockHistories Where adjustStock.AdjustStockID = CInt(gridAdjustmentHistory.GetValue("AdjustStockID"))
                        Dim TAdjustStock As tblAdjustStockHistory = TmpAdjustStock.SingleOrDefault

                        TAdjustStock.IsApproval = True
                        THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()

                      

                        'TDepartStock.UnitsInStock = CInt(gridAdjustmentHistory.GetValue("NewQty"))
                        TDepartStock.UnitsInStock = TDepartStock.UnitsInStock + CInt(gridAdjustmentHistory.GetValue("Difference"))

                        THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()


                        trans.Commit()
                        THIDataContextAPPROVED.getTHIDataContext.Connection.Close()
                    Else

                        Dim myMainStock As New tblCentralInventory
                        '--- Query to particular record to cut balance in main stock 
                        Dim qaaa = From centralStock In THIDataContextAPPROVED.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))
                        myMainStock = qaaa.SingleOrDefault
                        '========================= Management Begin item quantity before perform transaction =========================
                        Dim qBBT = (From BBT In THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate")).Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = Val(gridAdjustmentHistory.GetValue("ItemID")) Select BBT.BeginBalanceTraceID).Count
                        If qBBT = 0 Then
                            '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                            Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                            mytblBeginBalanceTrace.Date = CDate(gridAdjustmentHistory.GetValue("AdjustDate"))
                            mytblBeginBalanceTrace.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID"))
                            mytblBeginBalanceTrace.BeginBalanceOfDay = myMainStock.UnitsInStock
                            mytblBeginBalanceTrace.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))

                            THIDataContextAPPROVED.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                            THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()
                        End If

                        '--- Update status of adjustment record field IsApproval
                        Dim TmpAdjustStock = From adjustStock In THIDataContextAPPROVED.getTHIDataContext.tblAdjustStockHistories Where adjustStock.AdjustStockID = CInt(gridAdjustmentHistory.GetValue("AdjustStockID"))
                        Dim TAdjustStock As tblAdjustStockHistory = TmpAdjustStock.SingleOrDefault

                        TAdjustStock.IsApproval = True
                        THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()

                        '--- Update Quantity item in department stock
                        Dim q = From mainStock In THIDataContextAPPROVED.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))
                        Dim TMainStock As tblCentralInventory = q.SingleOrDefault

                        'TMainStock.UnitsInStock = CInt(gridAdjustmentHistory.GetValue("NewQty"))
                        TMainStock.UnitsInStock = TMainStock.UnitsInStock + CInt(gridAdjustmentHistory.GetValue("Difference"))

                        THIDataContextAPPROVED.getTHIDataContext.SubmitChanges()



                        trans.Commit()
                        THIDataContextAPPROVED.getTHIDataContext.Connection.Close()

                    End If
                Catch ex As Exception
                    trans.Rollback()
                    THIDataContextAPPROVED.getTHIDataContext.Connection.Close()
                    MsgBox("Error :" + ex.Message)
                Finally
                    DEP_EOD.BtnEndofDay_Click(sender, e)
                    MessageBox.Show("Approve adjust item successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myRefresh() '--- refresh grid
                    trans = Nothing
                End Try


            End If
        End If

    End Sub

    
    Private Sub BtnRevert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRevert.Click

        If Not gridAdjustmentHistory.CurrentRow Is Nothing AndAlso gridAdjustmentHistory.CurrentRow.RowType = RowType.Record Then

            Dim THIDataContextRevert As New BaseDataContext

            THIDataContextRevert.getTHIDataContext.Connection.Close()
            THIDataContextRevert.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContextRevert.getTHIDataContext.Connection.BeginTransaction
            THIDataContextRevert.getTHIDataContext.Transaction = trans

            If gridAdjustmentHistory.GetValue("IsApproval") = False Then
                MessageBox.Show("Cannot revert adjust item not yet approval.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure to revert adjust item ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try

                    If CInt(gridAdjustmentHistory.GetValue("DepartID")) <> MAIN_STOCK_DEPART_ID Then
                        '--- Update status of adjustment record field IsApproval
                        Dim TmpAdjustStock = From adjustStock In THIDataContextRevert.getTHIDataContext.tblAdjustStockHistories Where adjustStock.AdjustStockID = CInt(gridAdjustmentHistory.GetValue("AdjustStockID"))
                        Dim TAdjustStock As tblAdjustStockHistory = TmpAdjustStock.SingleOrDefault

                        TAdjustStock.IsApproval = False
                        THIDataContextRevert.getTHIDataContext.SubmitChanges()

                        '--- Update Quantity item in department stock
                        Dim q = From departStock In THIDataContextRevert.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(gridAdjustmentHistory.GetValue("DepartID")) And departStock.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))
                        Dim TDepartStock As tblDeptStock = q.SingleOrDefault
                        TDepartStock.UnitsInStock = TDepartStock.UnitsInStock + (CInt(gridAdjustmentHistory.GetValue("Difference")) * -1)

                        THIDataContextRevert.getTHIDataContext.SubmitChanges()

                        trans.Commit()
                        THIDataContextRevert.getTHIDataContext.Connection.Close()
                    Else
                        '--- Update status of adjustment record field IsApproval
                        Dim TmpAdjustStock = From adjustStock In THIDataContextRevert.getTHIDataContext.tblAdjustStockHistories Where adjustStock.AdjustStockID = CInt(gridAdjustmentHistory.GetValue("AdjustStockID"))
                        Dim TAdjustStock As tblAdjustStockHistory = TmpAdjustStock.SingleOrDefault

                        TAdjustStock.IsApproval = False
                        THIDataContextRevert.getTHIDataContext.SubmitChanges()

                        '--- Update Quantity item in main stock
                        Dim q = From mainStock In THIDataContextRevert.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = CInt(gridAdjustmentHistory.GetValue("ItemID"))
                        Dim TMainStock As tblCentralInventory = q.SingleOrDefault
                        TMainStock.UnitsInStock = TMainStock.UnitsInStock + (CInt(gridAdjustmentHistory.GetValue("Difference")) * -1)

                        THIDataContextRevert.getTHIDataContext.SubmitChanges()

                        trans.Commit()
                        THIDataContextRevert.getTHIDataContext.Connection.Close()

                    End If

                Catch ex As Exception
                    trans.Rollback()
                    THIDataContextRevert.getTHIDataContext.Connection.Close()
                    MsgBox("Error :" + ex.Message)
                Finally
                    trans = Nothing
                End Try

                MessageBox.Show("Revert adjust item successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myRefresh()
            End If
        End If

    End Sub
End Class
