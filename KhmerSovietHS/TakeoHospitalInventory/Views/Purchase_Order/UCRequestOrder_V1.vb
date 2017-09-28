Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCRequestOrder_V1

    Dim RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    'Dim RequestDataAdapter As New DSRequestTableAdapters.VRequestDepartmentDetailTableAdapter
    Dim RequestItemDetailAdapter As New DSRequestTableAdapters.VRequestItemDetailTableAdapter
    Dim RequestDataAdapter_V1 As New DSRequestTableAdapters.VRequestToDepartmentDetailTableAdapter
    Dim ResponseRequestDataAdapter As New DSRequestTableAdapters.VRequestDepartmentDetailTableAdapter
    Dim DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Dim ItemRepo As IItem = New Item
    Dim VRequestHistoryStatusTraceMasterDataAdapter As New DSRptRequestHistoryStatusTraceTableAdapters.VRequestHistoryStatusTraceMasterTableAdapter
    Dim VRequestHistoryStatusTraceDetailDataAdapter As New DSRptRequestHistoryStatusTraceTableAdapters.VRequestHistoryStatusTraceDetailTableAdapter
    Private THIDataContext As New BaseDataContext
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click

        Dim FAddRequestOrder As New frmAddRequestOrder(Me)
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        FAddRequestOrder.labelStatus = tNode.Text
        If FAddRequestOrder.ShowDialog() = DialogResult.OK Then
            GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
        End If
        FAddRequestOrder.Close()
        FAddRequestOrder.Dispose()

    End Sub

    Public Sub RefreshRequestOrderTV()

        'Display data category TreeView
        TVRequestOrderStatus.Nodes.Clear()
        TVRequestOrderStatus.Nodes.Add(New TreeNode("Request Order"))
        TVRequestOrderStatus.ImageList = ImgTV
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.Nodes(0)
        RequestOrderRepo.PopulateTreeViewRequestOrder(0, tNode, ImgTV)
        tNode.Expand()
        'Select fist node prevent user attempt to create new category without select on tree view node
        tNode.TreeView.SelectedNode = tNode.FirstNode
        tNode.TreeView.Focus()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim tNode As New TreeNode
            tNode = TVRequestOrderStatus.SelectedNode

            Dim FAddRequestOrder As New frmAddRequestOrder(Me)
            FAddRequestOrder.labelStatus = "OpenEdit"

            FAddRequestOrder.requestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value

            If FAddRequestOrder.ShowDialog = DialogResult.OK Then
                Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
            End If

            FAddRequestOrder.Close()
            FAddRequestOrder.Dispose()
        Else
            MessageBox.Show("There are no request avialable for edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim tNode As New TreeNode
            tNode = TVRequestOrderStatus.SelectedNode

            Select Case tNode.Text
                Case "Open"
                    DeleteRequestOrder(Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value))
                    GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                    GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
                Case "Checked"
                    DeleteRequestOrder(Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value))
                    GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                    GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
            End Select
        Else
            MessageBox.Show("There are no request avialable for delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
       
    End Sub

    Private Sub DeleteRequestOrder(ByVal pRequestID As Integer)

        Dim TransMsgStatus As String = ""
        If MessageBox.Show("Do you want delete Request Order ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '** Delete records in tblRequest depend on requestID
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequest where RequestID={0}", pRequestID)
                '===

                '** Delete records in tblRquestDetail depend on requestID
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestDetail where RequestID={0}", pRequestID)
                ' ===

                '** Delete records in tblRequestStatusTracking depend on requestID
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", pRequestID)
                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()
            Catch ex As Exception
                TransMsgStatus = ex.Message
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
            Finally
                trans = Nothing
            End Try

            ' Message validation save update request
            If TransMsgStatus = "" Then
                MsgBox("Delete request order successful.")
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If
        End If

    End Sub

    ' Status : OK
    Private Sub UCRequestOrder_V1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MenuReceivedAll = btnReceivedAll
        RefreshRequestOrderTV()
    End Sub

    'Invoke action when user click button send
    Private Sub btnMarkOrderChecked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkOrderChecked.Click

        ' Code v_1.0 | Date 12-Nov-2011
        'If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
        '    Dim tNode As New TreeNode
        '    tNode = TVRequestOrderStatus.SelectedNode
        '    Dim checkedRows() As Janus.Windows.GridEX.GridEXRow

        '    'get an array with all the rows that the user checked.
        '    checkedRows = GridRequestDetail.GetCheckedRows()

        '    If MessageBox.Show("Do you want to send selected request?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
        '    System.Windows.Forms.DialogResult.Yes Then

        '        Dim row As Janus.Windows.GridEX.GridEXRow
        '        For Each row In checkedRows
        '            UpdateRequestOrderStatusCFA(CInt(row.Cells("RequestID").Value), 2)

        '            '---- print request order ----------
        '            Dim FRptRequestView As New frmReportViewer
        '            FRptRequestView.RequestOrderID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
        '            FRptRequestView.ReportOption = 1
        '            If FRptRequestView.ShowDialog = DialogResult.OK Then

        '            End If

        '        Next

        '        GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
        '        GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
        '    End If
        'End If

        'Code v_1.1 | Date 12-Nov-2011
        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim tNode As New TreeNode
            tNode = TVRequestOrderStatus.SelectedNode
            If MessageBox.Show("Do you want to send selected request?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            System.Windows.Forms.DialogResult.Yes Then
                
                UpdateRequestOrderStatusCFA(CInt(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value), SENT)

                '---- print request order ----------
                Dim FRptRequestView As New frmReportViewer
                FRptRequestView.RequestOrderID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                FRptRequestView.ReportOption = 1

                If FRptRequestView.ShowDialog = DialogResult.OK Then
                    GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                    GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
                End If

            End If

        Else
            MessageBox.Show("There are no request avialable for send.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    '--- Invoke when user click button send

    Private Sub UpdateRequestOrderStatusCFA(ByVal pReqeustID As Integer, ByVal pPOStatusID As Integer)

        Dim myRequestStatusTracking As New tblRequestStatusTracking
        Dim TransMsgStatus As String = ""
        Dim myRequestHistoryStatusTracking As New tblRequestHistoryStatusTracking

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try

            THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", pReqeustID)
            THIDataContext.getTHIDataContext.SubmitChanges()

            '--- Mark original request item detail 
            THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblRequestDetail SET IsOrginalItemReq=1 where RequestID={0}", pReqeustID)
            THIDataContext.getTHIDataContext.SubmitChanges()

            ' Insert new record in tblRequestStatusTracking                        
            myRequestStatusTracking.RequestID = pReqeustID 'RequestOrderRepo.GetMaxRequestID().ToString
            myRequestStatusTracking.POStatusID = pPOStatusID
            myRequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
            myRequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)
            'myRequestStatusTracking.Comment = rtbComment.Text  ' TODO : Verify user need to add comment for update request order status to CHECKED

            THIDataContext.getTHIDataContext.tblRequestStatusTrackings.InsertOnSubmit(myRequestStatusTracking)
            THIDataContext.getTHIDataContext.SubmitChanges()

            '--- insert record in table tblRequestHistoryStatusTracking
            myRequestHistoryStatusTracking.RequestID = pReqeustID
            myRequestHistoryStatusTracking.POStatusID = pPOStatusID
            myRequestHistoryStatusTracking.UpdateRequestStatusDate = GetDateServer()
            myRequestHistoryStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

            THIDataContext.getTHIDataContext.tblRequestHistoryStatusTrackings.InsertOnSubmit(myRequestHistoryStatusTracking)
            THIDataContext.getTHIDataContext.SubmitChanges()
            
            '====
            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()
        Catch ex As Exception
            TransMsgStatus = ex.Message
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
        Finally
            trans = Nothing
        End Try

        ' Message validation transaction
        If TransMsgStatus = "" Then
            MsgBox("Update request order status successful.")
        Else
            MsgBox("Transaction Error: " & TransMsgStatus)
        End If
    End Sub

    Private Sub TVRequestOrderStatus_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVRequestOrderStatus.AfterSelect

        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        If tNode.Text = "Received" Then
            btnPatialReceived.Enabled = False
            btnReceivedAll.Enabled = False
            btnMarkOrderChecked.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            BtnNew.Enabled = False
            GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
        ElseIf tNode.Text = "Open" Then
            btnPatialReceived.Enabled = False
            btnReceivedAll.Enabled = False
            btnMarkOrderChecked.Enabled = True
            btnDelete.Enabled = True
            btnEdit.Enabled = True
            BtnNew.Enabled = True
            GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
        ElseIf tNode.Text = "Sent" Then
            btnPatialReceived.Enabled = False
            btnReceivedAll.Enabled = False
            btnMarkOrderChecked.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            BtnNew.Enabled = False
            GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
        ElseIf tNode.Text = "Patial Received" Then
            btnPatialReceived.Enabled = False
            btnReceivedAll.Enabled = True
            btnMarkOrderChecked.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            BtnNew.Enabled = False

            GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue

        Else ' Response request

            ' MsgBox(CInt(tNode.Tag))

            btnPatialReceived.Enabled = True
            btnReceivedAll.Enabled = True
            btnMarkOrderChecked.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            BtnNew.Enabled = False

            'Get Reponse request of current dapartment (  RequestFromDepartID= @OwnerDepart AND (POStatusID = 7 OR POStatusID = 9))            
            GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID)) ' 7 eqauls Approved
            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
        End If

        SplitContainer3.Panel1Collapsed = False
        SplitContainer3.Panel2Collapsed = True

    End Sub

    Private Sub GridRequestDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridRequestDetail.SelectionChanged
        Try

            Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)

        Catch ex As Exception
            GridItemRequestDetail.DataSource = Nothing
        End Try
    End Sub

    ' Status : OK
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshRequestOrderTV()
    End Sub

    Private Sub btnCompareStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompareStock.Click

        If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then

            Dim itemID As Integer = Val(GridItemRequestDetail.GetValue("ItemID"))
            Dim FCompareItemInStock As New frmCompareItemInStock
            If CInt(DEPART_ID) <> MAIN_STOCK_DEPART_ID Then
                FCompareItemInStock.isDepartRequestShow = True
            End If
            FCompareItemInStock.myItemID = itemID
            FCompareItemInStock.ShowDialog()
            FCompareItemInStock.Close()
            FCompareItemInStock.Dispose()

        End If

    End Sub

    Private Sub btnReceivedAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivedAll.Click

        'Code v_1.1 | Date 12-Nov-2011
        Dim tNode As New TreeNode
        Dim IS_RUNOFDAY As Boolean = False
        tNode = TVRequestOrderStatus.SelectedNode

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            If MessageBox.Show("Do you want save update Request Orders status to Received All ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
        System.Windows.Forms.DialogResult.Yes Then
                btnReceivedAll.Enabled = False
                Dim ReqID As Double = Val(GridRequestDetail.GetRow.Cells("RequestID").Value) ' GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value)

                '================= Transaction block =========================
                Dim TransMsgStatus As String = ""
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans
                'THIDataContext.getTHIDataContext.Refresh(System.Data.Linq.RefreshMode.KeepChanges)
                'THIDataContext.getTHIDataContext.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues)
                'THIDataContext.getTHIDataContext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues)
                Try
                    '============== tblReceived ==============

                    Dim myReceived As New tblReceived
                    myReceived.RequestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                    myReceived.ReceivedDate = GetDateServer()
                    myReceived.ReceivedDepartID = CInt(DEPART_ID)
                    ' THIDataContext.getTHIDataContext.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues)
                    THIDataContext.getTHIDataContext.tblReceiveds.InsertOnSubmit(myReceived)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '============= tblReceivedDetail ===========
                    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows
                        Dim myReceivedDetail As New tblReceivedDetail
                        myReceivedDetail.ReceivedID = myReceived.ReceivedID
                        myReceivedDetail.ItemID = Val(rRow.Cells("ItemID").Value)
                        '--- Gost coding in case line below change
                        myReceivedDetail.ReceivedQuantity = Val(rRow.Cells("ResponseQuantity").Value)
                        myReceivedDetail.Status = 13 ' Received fully
                        THIDataContext.getTHIDataContext.tblReceivedDetails.InsertOnSubmit(myReceivedDetail)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    Next
                    '============= tblReceivedStatusTracking =============
                    Dim myReceivedStatusTracking As New tblReceivedStatusTracking
                    myReceivedStatusTracking.ReceivedID = myReceived.ReceivedID
                    myReceivedStatusTracking.POStatusID = RECEIVED '13
                    myReceivedStatusTracking.UserIDReceivedUpdateStatus = CInt(USER_ID)
                    myReceivedStatusTracking.UpdateReceivedStatusDate = GetDateServer()
                    myReceivedStatusTracking.Comment = ""

                    THIDataContext.getTHIDataContext.tblReceivedStatusTrackings.InsertOnSubmit(myReceivedStatusTracking)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '============= tblRequestStatusTracking ==============
                    Dim requestID As Integer = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value)
                    Dim myRequestStatusTracking As New tblRequestStatusTracking
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", requestID)
                    myRequestStatusTracking.RequestID = requestID 'RequestOrderRepo.GetMaxRequestID().ToString
                    myRequestStatusTracking.POStatusID = RECEIVED '13 '13 is means Received
                    myRequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
                    myRequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.tblRequestStatusTrackings.InsertOnSubmit(myRequestStatusTracking)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '------------- tblRequestHistoryStatusTracking ---------------
                    Dim myRequestHistoryStatusTracking As New tblRequestHistoryStatusTracking

                    '--- insert record in table tblRequestHistoryStatusTracking
                    myRequestHistoryStatusTracking.RequestID = requestID
                    myRequestHistoryStatusTracking.POStatusID = RECEIVED '13          ' RECEIVED
                    myRequestHistoryStatusTracking.UpdateRequestStatusDate = GetDateServer()
                    myRequestHistoryStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.tblRequestHistoryStatusTrackings.InsertOnSubmit(myRequestHistoryStatusTracking)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '******************************* Incase of department request to department **************************

                    '============= Update requestToDepart cut-off ======== 
                    Dim myRequestToDepartID As Integer = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestToDepartID").Value)
                    Dim myRequestFromDepartID As Integer = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestFromDepartID").Value)


                    '******************************* Incase of department request to Main Stock OR Main Stock request to department **************************
                    If myRequestToDepartID = MAIN_STOCK_DEPART_ID Then

                        '============= insert new record to table tblUsed that give to department request =============
                        Dim mytblUsed As New tblUsed
                        mytblUsed.UsedDepartID = myRequestToDepartID
                        mytblUsed.UsedDate = GetDateServer.Date

                        '--- Get department name ----
                        Dim qdepartName = From depart In THIDataContext.getTHIDataContext.tblDepartments Where depart.DepartID = CInt(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestFromDepartID").Value) _
                        Select depart.DepartName

                        mytblUsed.UsedDescription = "Give to department " & qdepartName.First
                        mytblUsed.UsedUserID = CInt(USER_ID)

                        THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows
                            Dim responseQty As Integer = Val(rRow.Cells("ResponseQuantity").Value)
                            Dim itemID As Integer = Val(rRow.Cells("ItemID").Value)
                            Dim myMainStock As New tblCentralInventory

                            '========================= Get UnitsInStock of CentralIventory =========================
                            Dim q = From centralStock In THIDataContext.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = itemID
                            myMainStock = q.SingleOrDefault
                            If responseQty > myMainStock.UnitsInStock Then
                                MessageBox.Show("Unit in stock is small than QTY request. Please check in Main Inventory!", "Main Inventory out of stock.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                trans.Rollback()
                                THIDataContext.getTHIDataContext.Connection.Close()
                                IS_RUNOFDAY = True
                                btnReceivedAll.Enabled = True
                                Exit Sub
                            Else
                                IS_RUNOFDAY = False
                            End If
                            Dim unitsInStock1 As Integer = 0
                            If myRequestFromDepartID = MAIN_STOCK_DEPART_ID Or myRequestToDepartID = MAIN_STOCK_DEPART_ID Then
                                Dim itemID1 As Integer = Val(rRow.Cells("ItemID").Value)
                                Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = itemID1
                                unitsInStock1 = qMainStock.SingleOrDefault.UnitsInStock

                                Dim q1 = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = MAIN_STOCK_DEPART_ID And BBT.ItemID = itemID1 Select BBT.BeginBalanceTraceID).Count
                                If q1 = 0 Then
                                    '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                                    Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                                    mytblBeginBalanceTrace.Date = GetDateServer().Date
                                    mytblBeginBalanceTrace.DepartID = MAIN_STOCK_DEPART_ID
                                    mytblBeginBalanceTrace.BeginBalanceOfDay = unitsInStock1
                                    mytblBeginBalanceTrace.ItemID = itemID

                                    THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                End If
                            End If

                            '========================= Update UnitsInStock of CentralInventory ===============
                            myMainStock.UnitsInStock = myMainStock.UnitsInStock - responseQty
                            THIDataContext.getTHIDataContext.SubmitChanges()

                            '============= insert new record to table tblUsedDetail of all items that give to department request =============
                            Dim mytblUsedDetail As New tblUsedDetail
                            mytblUsedDetail.UsedID = mytblUsed.UsedID
                            mytblUsedDetail.ItemID = itemID
                            mytblUsedDetail.UsedQuantity = responseQty

                            THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        Next
                    End If








                    '========================= Management Begin item quantity before perform transaction =========================
                    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows

                        ' ======== Update ITEM_PROVIDER_TRANS to mark transaction is complete =======                    
                        THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE ITEM_PROVIDER_TRANS SET TransDate={0},Status=1 WHERE RequestID={1} AND ItemID={2}", GetDateServer(), ReqID, Val(rRow.Cells("ItemID").Value))
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        Dim unitsInStock As Integer = 0
                        If myRequestToDepartID <> MAIN_STOCK_DEPART_ID Then
                            Dim itemID As Integer = Val(rRow.Cells("ItemID").Value)
                            Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = myRequestToDepartID And departStock.ItemID = itemID
                            unitsInStock = qDepartStock.SingleOrDefault.UnitsInStock

                            Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = myRequestToDepartID And BBT.ItemID = itemID Select BBT.BeginBalanceTraceID).Count
                            If q = 0 Then
                                '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                                Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                                mytblBeginBalanceTrace.Date = GetDateServer()
                                mytblBeginBalanceTrace.DepartID = myRequestToDepartID
                                mytblBeginBalanceTrace.BeginBalanceOfDay = unitsInStock
                                mytblBeginBalanceTrace.ItemID = itemID

                                THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            End If

                        End If

                        If myRequestFromDepartID <> MAIN_STOCK_DEPART_ID Then
                            Dim itemID As Integer = Val(rRow.Cells("ItemID").Value)
                            Try
                                Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = myRequestFromDepartID And departStock.ItemID = itemID
                                unitsInStock = qDepartStock.SingleOrDefault.UnitsInStock

                                Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = myRequestFromDepartID And BBT.ItemID = itemID Select BBT.BeginBalanceTraceID).Count
                                If q = 0 Then
                                    '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                                    Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                                    mytblBeginBalanceTrace.Date = GetDateServer().Date
                                    mytblBeginBalanceTrace.DepartID = myRequestFromDepartID
                                    mytblBeginBalanceTrace.BeginBalanceOfDay = unitsInStock
                                    mytblBeginBalanceTrace.ItemID = itemID

                                    THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                End If
                            Catch ex As Exception
                                Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = myRequestFromDepartID And BBT.ItemID = itemID Select BBT.BeginBalanceTraceID).Count
                                If q = 0 Then
                                    '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                                    Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                                    mytblBeginBalanceTrace.Date = GetDateServer().Date
                                    mytblBeginBalanceTrace.DepartID = myRequestFromDepartID
                                    mytblBeginBalanceTrace.BeginBalanceOfDay = 0
                                    mytblBeginBalanceTrace.ItemID = itemID

                                    THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                                    THIDataContext.getTHIDataContext.SubmitChanges()

                                    '========================= Update Permission item for deparment =================                                   
                                    THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblPermissionItemShoworHideForDepart SET IsShow = 1 WHERE DepartID={0} AND ItemID={1}", myRequestFromDepartID, itemID)
                                    THIDataContext.getTHIDataContext.SubmitChanges()

                                End If
                            End Try

                        End If

                        'If myRequestFromDepartID = MAIN_STOCK_DEPART_ID Or myRequestToDepartID = MAIN_STOCK_DEPART_ID Then
                        '    Dim itemID As Integer = Val(rRow.Cells("ItemID").Value)
                        '    Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = itemID
                        '    unitsInStock = qMainStock.SingleOrDefault.UnitsInStock

                        '    Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = MAIN_STOCK_DEPART_ID And BBT.ItemID = itemID Select BBT.BeginBalanceTraceID).Count
                        '    If q = 0 Then
                        '        '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                        '        Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                        '        mytblBeginBalanceTrace.Date = GetDateServer()
                        '        mytblBeginBalanceTrace.DepartID = MAIN_STOCK_DEPART_ID
                        '        mytblBeginBalanceTrace.BeginBalanceOfDay = unitsInStock
                        '        mytblBeginBalanceTrace.ItemID = itemID

                        '        THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                        '        THIDataContext.getTHIDataContext.SubmitChanges()
                        '    End If
                        'End If
                    Next
                    '=============================================== End Management Begin item quantity before perform transaction ======

                    If myRequestToDepartID <> MAIN_STOCK_DEPART_ID Then
                        '============= insert new record to table tblUsed that give to department request =============
                        Dim mytblUsed As New tblUsed
                        mytblUsed.UsedDepartID = myRequestToDepartID
                        mytblUsed.UsedDate = GetDateServer.Date

                        '--- Get department name ----
                        Dim q = From depart In THIDataContext.getTHIDataContext.tblDepartments Where depart.DepartID = CInt(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestFromDepartID").Value) _
                        Select depart.DepartName

                        'mytblUsed.UsedDescription = "Give to department " & Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestFromDepartID").Value)
                        mytblUsed.UsedDescription = "Give to department " & q.First
                        mytblUsed.UsedUserID = CInt(USER_ID)

                        THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows

                            Dim responseQty As Integer = Val(rRow.Cells("ResponseQuantity").Value)
                            Dim itemID As Integer = Val(rRow.Cells("ItemID").Value)
                            Dim myDepartStock As New tblDeptStock
                            myDepartStock = DepartStockRepo.GetDepartStockByDepartIDAndItemID(myRequestToDepartID, itemID)
                            myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - responseQty

                            DepartStockRepo.UpdateDepartStock()

                            '============= insert new record to table tblUsedDetail of all items that give to department request =============
                            Dim mytblUsedDetail As New tblUsedDetail
                            mytblUsedDetail.UsedID = mytblUsed.UsedID
                            mytblUsedDetail.ItemID = itemID
                            mytblUsedDetail.UsedQuantity = responseQty

                            THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        Next
                    End If

                    '============= Update requestFromDeapart increase Quantity ======== 
                    If myRequestFromDepartID <> MAIN_STOCK_DEPART_ID Then
                        For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows
                            Dim responseQty As Integer = Val(rRow.Cells("ResponseQuantity").Value)
                            Dim myitemID As Integer = Val(rRow.Cells("ItemID").Value)
                            Dim myDepartStock As New tblDeptStock

                            Dim isItemExistInDepartStock As Boolean

                            '===================== Check department stock already have item request or not =========
                            Dim q = (From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = myRequestFromDepartID And departStock.ItemID = myitemID Select departStock.ItemID).Count()
                            If q Then
                                isItemExistInDepartStock = True
                            Else
                                isItemExistInDepartStock = False
                            End If

                            '*** Incase item exist in currect stock of department we update quantity of item
                            If isItemExistInDepartStock Then
                                ' THIDataContext.getTHIDataContext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues)
                                '====================== Get UnitsInStock of department request ======================================
                                Dim qdepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = myRequestFromDepartID And departStock.ItemID = myitemID
                                myDepartStock = qdepartStock.SingleOrDefault

                                '====================== Update current UnitsInStock of department
                                myDepartStock.UnitsInStock = myDepartStock.UnitsInStock + responseQty
                                'DepartStockRepo.UpdateDepartStock()
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Else

                                '*** Incase item not exist in current stock of department we initail item in department stock
                                myDepartStock.ItemID = myitemID
                                myDepartStock.DepartID = myRequestFromDepartID
                                myDepartStock.UnitsInStock = responseQty
                                myDepartStock.StockAlertQty = 0
                                THIDataContext.getTHIDataContext.tblDeptStocks.InsertOnSubmit(myDepartStock)
                                THIDataContext.getTHIDataContext.SubmitChanges()

                            End If

                        Next
                    End If
                    ''******************************* Incase of department request to Main Stock OR Main Stock request to department **************************
                    'If myRequestToDepartID = MAIN_STOCK_DEPART_ID Then

                    '    '============= insert new record to table tblUsed that give to department request =============
                    '    Dim mytblUsed As New tblUsed
                    '    mytblUsed.UsedDepartID = myRequestToDepartID
                    '    mytblUsed.UsedDate = GetDateServer.Date

                    '    '--- Get department name ----
                    '    Dim qdepartName = From depart In THIDataContext.getTHIDataContext.tblDepartments Where depart.DepartID = CInt(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestFromDepartID").Value) _
                    '    Select depart.DepartName

                    '    mytblUsed.UsedDescription = "Give to department " & qdepartName.First
                    '    mytblUsed.UsedUserID = CInt(USER_ID)

                    '    THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                    '    THIDataContext.getTHIDataContext.SubmitChanges()

                    '    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows
                    '        Dim responseQty As Integer = Val(rRow.Cells("ResponseQuantity").Value)
                    '        Dim itemID As Integer = Val(rRow.Cells("ItemID").Value)
                    '        Dim myMainStock As New tblCentralInventory

                    '        '========================= Get UnitsInStock of CentralIventory =========================
                    '        Dim q = From centralStock In THIDataContext.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = itemID
                    '        myMainStock = q.SingleOrDefault
                    '        If responseQty > myMainStock.UnitsInStock Then
                    '            MessageBox.Show("Unit in stock is small than QTY request. Please check in Main Inventory!", "Main Inventory out of stock.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '            trans.Rollback()

                    '            THIDataContext.getTHIDataContext.Connection.Close()
                    '            IS_RUNOFDAY = True
                    '            btnReceivedAll.Enabled = True
                    '            Exit Sub
                    '        Else
                    '            IS_RUNOFDAY = False
                    '        End If
                    '        '========================= Update UnitsInStock of CentralInventory ===============
                    '        myMainStock.UnitsInStock = myMainStock.UnitsInStock - responseQty
                    '        THIDataContext.getTHIDataContext.SubmitChanges()

                    '        '============= insert new record to table tblUsedDetail of all items that give to department request =============
                    '        Dim mytblUsedDetail As New tblUsedDetail
                    '        mytblUsedDetail.UsedID = mytblUsed.UsedID
                    '        mytblUsedDetail.ItemID = itemID
                    '        mytblUsedDetail.UsedQuantity = responseQty

                    '        THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                    '        THIDataContext.getTHIDataContext.SubmitChanges()

                    '    Next
                    'End If

                    ' =========== In case main stock request to department ======================
                    If myRequestFromDepartID = MAIN_STOCK_DEPART_ID Then
                        For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows

                            Dim responseQty As Integer = Val(rRow.Cells("ResponseQuantity").Value)
                            Dim itemID As Integer = Val(rRow.Cells("ItemID").Value)
                            Dim myMainStock As New tblCentralInventory

                            '========================= Get UnitsInStock of CentralIventory =========================
                            Dim q = From centralStock In THIDataContext.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = itemID
                            myMainStock = q.SingleOrDefault

                            '========================= Update UnitsInStock of CentralInventory ================
                            myMainStock.UnitsInStock = myMainStock.UnitsInStock + responseQty
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        Next
                    End If
                    '*** Finished

                    trans.Commit()
                    ' THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    TransMsgStatus = ex.Message
                    trans.Rollback()

                Finally
                    'If IS_RUNOFDAY = False Then
                    '    DEP_EOD.cbDepart.SelectedValue = DEPART_ID
                    '    DEP_EOD.BtnEndofDay_Click(sender, e)
                    'End If

                    If TransMsgStatus = "" Then
                        btnReceivedAll.Enabled = True
                        ' MsgBox("Update request order status successful.")
                    Else
                        MsgBox("Transaction Error: " & TransMsgStatus)
                    End If
                    THIDataContext.getTHIDataContext.Connection.Close()
                    ' trans = Nothing

                End Try

                ' Message validation transaction

                'End Transaction block

                GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
            End If
        Else
            MessageBox.Show("There are no response of request.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnPatialReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatialReceived.Click
        'Dim tNode As New TreeNode
        'tNode = TVRequestOrderStatus.SelectedNode
        'Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        ''get an array with all the rows that the user checked.
        'checkedRows = GridRequestDetail.GetCheckedRows()

        'If MessageBox.Show("Do you want save update Request Orders status to Checked?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
        'System.Windows.Forms.DialogResult.Yes Then
        '    Dim row As Janus.Windows.GridEX.GridEXRow
        '    For Each row In checkedRows
        '        UpdateRequestOrderStatusCFA(CInt(row.Cells("RequestID").Value), 2)
        '    Next
        '    GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
        '    GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
        'End If
    End Sub

    Private Sub btnPrintRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRequest.Click
        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            '---- print request order ----------
            Dim FRptRequestView As New frmReportViewer
            FRptRequestView.RequestOrderID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            FRptRequestView.ReportOption = 1

            If FRptRequestView.ShowDialog = DialogResult.OK Then

            End If
        End If

    End Sub

    Private Sub RadOpen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOpen.CheckedChanged
        SplitContainer3.Panel2Collapsed = False
        SplitContainer3.Panel1Collapsed = True
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click

        Dim FRptRequestView As New frmReportViewer

        FRptRequestView.ReportOption = 6
        FRptRequestView.FDate = dptFromDate.Value.Date
        FRptRequestView.TDate = dptToDate.Value.Date
        FRptRequestView.IsIncomingReq = False

        If RadOpen.Checked = True Then
            FRptRequestView.POStatus = OPEN
            FRptRequestView.StrOPStatus = "OPEN"
        End If


        If RadSent.Checked = True Then
            FRptRequestView.POStatus = SENT
            FRptRequestView.StrOPStatus = "SENT"
        End If

        If RadResponse.Checked = True Then
            FRptRequestView.POStatus = APPROVED
            FRptRequestView.StrOPStatus = "RESPONSE"
        End If

        If RadReceived.Checked = True Then
            FRptRequestView.POStatus = RECEIVED
            FRptRequestView.StrOPStatus = "RECEIVED"
        End If

        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If

    End Sub

    Private Sub RadSent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSent.CheckedChanged
        SplitContainer3.Panel2Collapsed = False
        SplitContainer3.Panel1Collapsed = True
    End Sub

    Private Sub RadResponse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadResponse.CheckedChanged
        SplitContainer3.Panel2Collapsed = False
        SplitContainer3.Panel1Collapsed = True
    End Sub

    Private Sub RadReceived_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceived.CheckedChanged
        SplitContainer3.Panel2Collapsed = False
        SplitContainer3.Panel1Collapsed = True
    End Sub

    Private Sub btnGridDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridDisplay.Click
        Dim RptRequestHistoryStatusTraceDS As New DSRptRequestHistoryStatusTrace

        Dim myPOStatusID As New Integer

        If RadOpen.Checked = True Then
            myPOStatusID = OPEN
            gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = False
        End If

        If RadSent.Checked = True Then
            myPOStatusID = SENT
            gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = False
        End If

        If RadResponse.Checked = True Then
            myPOStatusID = APPROVED
            gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = True
        End If

        If RadReceived.Checked = True Then
            myPOStatusID = RECEIVED
            gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = True
        End If

        'VRequestHistoryStatusTraceMasterDataAdapter.GetHisRequestBYStatus(CInt(DEPART_ID), myPOStatusID, dptFromDate.Value.Date, dptToDate.Value.Date)
        VRequestHistoryStatusTraceMasterDataAdapter.FillBy(RptRequestHistoryStatusTraceDS.VRequestHistoryStatusTraceMaster, CInt(DEPART_ID), myPOStatusID, dptFromDate.Value.Date, dptToDate.Value.Date)
        VRequestHistoryStatusTraceDetailDataAdapter.GetData()

        VRequestHistoryStatusTraceDetailDataAdapter.Fill(RptRequestHistoryStatusTraceDS.VRequestHistoryStatusTraceDetail)

        gridRequestHis.DataSource = RptRequestHistoryStatusTraceDS.VRequestHistoryStatusTraceMaster
        gridRequestHis.RootTable.ChildTables(0).DataMember = "VRequestHistoryStatusTraceMaster_VRequestHistoryStatusTraceDetail"


    End Sub

    
End Class
