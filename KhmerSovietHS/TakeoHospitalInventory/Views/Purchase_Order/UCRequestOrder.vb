Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCRequestOrder

    Dim RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    'Dim RequestDataAdapter As New DSRequestTableAdapters.VRequestDepartmentDetailTableAdapter
    Dim RequestDataAdapter_V1 As New DSRequestTableAdapters.VRequestToDepartmentDetailTableAdapter
    Dim RequestItemDetailAdapter As New DSRequestTableAdapters.VRequestItemDetailTableAdapter
    Private THIDataContext As New BaseDataContext
    Private Sub UCRequestOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshRequestOrderTV()
    End Sub

    Public Sub RefreshRequestOrderTV()

        'Display data category TreeView
        TVRequestOrderStatus.Nodes.Clear()
        TVRequestOrderStatus.Nodes.Add(New TreeNode("Request Order"))
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.Nodes(0)
        RequestOrderRepo.PopulateTreeView(0, tNode)
        tNode.Expand()
        'Select fist node prevent user attempt to create new category without select on tree view node
        tNode.TreeView.SelectedNode = tNode.FirstNode
        tNode.TreeView.Focus()

    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FAddRequestOrder As New frmAddRequestOrder(Me)
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        FAddRequestOrder.labelStatus = tNode.Text
        If FAddRequestOrder.ShowDialog() = DialogResult.OK Then
            'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
        End If
        FAddRequestOrder.Close()
        FAddRequestOrder.Dispose()
    End Sub
    Private Sub TVRequestOrderStatus_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVRequestOrderStatus.AfterSelect
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        Select Case tNode.Text
            Case "Open"
                BtnNew.Enabled = True
                btnDelete.Enabled = True
                btnMarkOrderChecked.Enabled = True
                btnMarkOrderForward.Enabled = True
                btnMarkOrderApproved.Enabled = True
                GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
            Case "Checked"
                BtnNew.Enabled = False
                btnDelete.Enabled = True
                btnMarkOrderChecked.Enabled = False
                btnMarkOrderForward.Enabled = True
                btnMarkOrderApproved.Enabled = True
                GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
            Case "Forward"
                BtnNew.Enabled = False
                btnDelete.Enabled = True
                GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                GridRequestDetail.RowFormatStyle.BackColor = Color.Orange
                btnMarkOrderChecked.Enabled = False
                btnMarkOrderForward.Enabled = False
                btnMarkOrderApproved.Enabled = True

            Case "Approved"
                BtnNew.Enabled = False
                btnDelete.Enabled = False
                btnMarkOrderChecked.Enabled = False
                btnMarkOrderForward.Enabled = False
                btnMarkOrderApproved.Enabled = False
                GridRequestDetail.DataSource = RequestDataAdapter_V1.GetDataByRequestStatusID(CInt(tNode.Tag), CInt(DEPART_ID))
                GridRequestDetail.RowFormatStyle.BackColor = Color.GreenYellow
        End Select
    End Sub

    Private Sub GridRequestDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridRequestDetail.SelectionChanged
        Try
            Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
        Catch ex As Exception
            GridItemRequestDetail.DataSource = Nothing
        End Try

    End Sub

    Private Sub btnMarkOrderChecked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkOrderChecked.Click
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            If MessageBox.Show("Do you want save update Request Order status?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim requestID As Integer = Val(GridRequestDetail.GetValue("RequestID"))
                UpdateRequestOrderStatusCFA(requestID, 2)
                'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
            End If
        Else
            MessageBox.Show("Plese select the Request Order you want to update status.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnMarkOrderForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkOrderForward.Click
        
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            If MessageBox.Show("Do you want save update Request Order status?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim requestID As Integer = Val(GridRequestDetail.GetValue("RequestID"))
                UpdateRequestOrderStatusCFA(requestID, 3)
                'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.Orange
            End If
        Else
            MessageBox.Show("Plese select the Request Order you want to update status.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnMarkOrderApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkOrderApproved.Click
        'Dim FAddRequestOrder As New frmAddRequestOrder(Me)
        'FAddRequestOrder.labelStatus = "Approved"
        'FAddRequestOrder.requestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
        'FAddRequestOrder.ShowDialog()
        'FAddRequestOrder.Close()
        'FAddRequestOrder.Dispose()
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            If MessageBox.Show("Do you want save update Request Order status?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim requestID As Integer = Val(GridRequestDetail.GetValue("RequestID"))
                UpdateRequestOrderStatusCFA(requestID, 4)
                'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.GreenYellow
            End If
        Else
            MessageBox.Show("Plese select the Request Order you want to update status.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        Select Case tNode.Text
            Case "Open"
                Dim FAddRequestOrder As New frmAddRequestOrder(Me)
                FAddRequestOrder.labelStatus = "OpenEdit"
                FAddRequestOrder.requestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                FAddRequestOrder.ShowDialog()
                FAddRequestOrder.Close()
                FAddRequestOrder.Dispose()

            Case "Checked"
                Dim FAddRequestOrder As New frmAddRequestOrder(Me)
                FAddRequestOrder.labelStatus = "Checked"
                FAddRequestOrder.requestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                FAddRequestOrder.ShowDialog()
                FAddRequestOrder.Close()
                FAddRequestOrder.Dispose()

            Case "Forward"
                Dim FAddRequestOrder As New frmAddRequestOrder(Me)
                FAddRequestOrder.labelStatus = "Forward"
                FAddRequestOrder.requestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                FAddRequestOrder.ShowDialog()
                FAddRequestOrder.Close()
                FAddRequestOrder.Dispose()

            Case "Approved"
                Dim FAddRequestOrder As New frmAddRequestOrder(Me)
                FAddRequestOrder.labelStatus = "Approved"
                FAddRequestOrder.requestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                FAddRequestOrder.ShowDialog()
                FAddRequestOrder.Close()
                FAddRequestOrder.Dispose()

        End Select
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode
        Select Case tNode.Text
            Case "Open"
                DeleteRequestOrder(Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value))
                'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
            Case "Checked"
                DeleteRequestOrder(Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value))
                'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.LightGreen
            Case "Forward"
                DeleteRequestOrder(Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value))
                'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.Orange
        End Select
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
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        'TODO : implement when user click button refresh
    End Sub

    Private Sub UpdateRequestOrderStatusCFA(ByVal pReqeustID As Integer, ByVal pPOStatusID As Integer)

        Dim myRequestStatusTracking As New tblRequestStatusTracking
        Dim TransMsgStatus As String = ""

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", pReqeustID)
            '
            ' Insert new record in tblRequestStatusTracking                        
            myRequestStatusTracking.RequestID = pReqeustID 'RequestOrderRepo.GetMaxRequestID().ToString
            myRequestStatusTracking.POStatusID = pPOStatusID
            myRequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
            myRequestStatusTracking.UserIDRequestUpdateStatus = 1 ' TODO :change to dynamic value depend on user log in
            'myRequestStatusTracking.Comment = rtbComment.Text  ' TODO : Verify user need to add comment for update request order status to CHECKED

            THIDataContext.getTHIDataContext.tblRequestStatusTrackings.InsertOnSubmit(myRequestStatusTracking)
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

    Private Sub btnCompareStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompareStock.Click
        If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim itemID As Integer = Val(GridItemRequestDetail.GetValue("ItemID"))
            Dim FCompareItemInStock As New frmCompareItemInStock
            FCompareItemInStock.myItemID = itemID
            FCompareItemInStock.ShowDialog()
            FCompareItemInStock.Close()
            FCompareItemInStock.Dispose()
        End If
    End Sub


End Class
