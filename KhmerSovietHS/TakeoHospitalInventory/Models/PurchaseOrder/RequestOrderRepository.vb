Public Class RequestOrderRepository
    Implements IRequestOrderRepository
    Private THIDataContext As New BaseDataContext

    Public Sub PopulateTreeViewReceivedRequestOrder(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode) Implements IRequestOrderRepository.PopulateTreeViewReceivedRequestOrder
        Dim POSs = From purchaseOrderStatus In THIDataContext.getTHIDataContext.tblPurchaseOrderStatus Where purchaseOrderStatus.Description = "ReceivedRequest"
        If POSs.Count > 0 Then
            For Each POS In POSs
                Dim parentnode As TreeNode
                'we'll provide some text for the tree node.
                Dim strLabel As String = POS.POStatus
                Dim POSID As String = POS.POStatusID
                parentnode = New TreeNode(strLabel)
                parentnode.Tag = POSID
                inTreeNode.Nodes.Add(parentnode)
            Next
        End If
    End Sub

    Public Sub PopulateTreeViewDepartReceivedRequestOrder(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode) Implements IRequestOrderRepository.PopulateTreeViewDepartReceivedRequestOrder

        Dim POSs = From purchaseOrderStatus In THIDataContext.getTHIDataContext.tblPurchaseOrderStatus Where purchaseOrderStatus.Description = "ReceivedRequest" 'purchaseOrderStatus.POStatusID = 5 Or purchaseOrderStatus.POStatusID = 7
        If POSs.Count > 0 Then
            For Each POS In POSs
                Dim parentnode As TreeNode
                'we'll provide some text for the tree node.
                Dim strLabel As String = POS.POStatus
                Dim POSID As String = POS.POStatusID
                parentnode = New TreeNode(strLabel)
                parentnode.Tag = POSID
                inTreeNode.Nodes.Add(parentnode)
            Next
        End If

    End Sub

    Public Sub PopulateTreeView(ByVal inParentID As Integer, ByRef inTreeNode As System.Windows.Forms.TreeNode) Implements IRequestOrderRepository.PopulateTreeView
        Dim POSs = From purchaseOrderStatus In THIDataContext.getTHIDataContext.tblPurchaseOrderStatus Where purchaseOrderStatus.Description = "Request"
        If POSs.Count > 0 Then
            For Each POS In POSs
                Dim parentnode As TreeNode
                'we'll provide some text for the tree node.
                Dim strLabel As String = POS.POStatus
                Dim POSID As String = POS.POStatusID
                parentnode = New TreeNode(strLabel)
                parentnode.Tag = POSID
                inTreeNode.Nodes.Add(parentnode)
            Next
        End If
    End Sub
    Public Sub PopulateTreeViewRequestOrder(ByVal inParentID As Integer, ByRef inTreeNode As System.Windows.Forms.TreeNode, ByVal Imglist As ImageList) Implements IRequestOrderRepository.PopulateTreeViewRequestOrder
        Dim POSs = From purchaseOrderStatus In THIDataContext.getTHIDataContext.tblPurchaseOrderStatus Where purchaseOrderStatus.Description = "Request"
        Dim Index As Integer = 0

        If POSs.Count > 0 Then
            For Each POS In POSs
                Dim parentnode As TreeNode
                'we'll provide some text for the tree node.
                Dim strLabel As String = POS.POStatus
                Dim POSID As String = POS.POStatusID
                parentnode = New TreeNode(strLabel)
                parentnode.ImageIndex = Index
                parentnode.Tag = POSID
                inTreeNode.Nodes.Add(parentnode)
                Index = Index + 1
            Next
        End If
    End Sub
    Public Function GetMaxRequestID() As Double Implements IRequestOrderRepository.GetMaxRequestID
        Try
            Dim q = (From Reqeust In THIDataContext.getTHIDataContext.tblRequests _
                    Select Reqeust.RequestID).Max
            ' Return max request order id
            If Val(q) = 0 Then
                Return 1
            Else
                Return Val(q) + 1
            End If
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Public Function GetRequestOrderByID(ByVal pRequestID As Integer) As tblRequest Implements IRequestOrderRepository.GetRequestOrderByID

        Dim request = From q In THIDataContext.getTHIDataContext.tblRequests _
                      Where q.RequestID = pRequestID

        Return request.SingleOrDefault

    End Function

    Public Function UpdateRequestOrder() As String Implements IRequestOrderRepository.UpdateRequestOrder
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function


End Class
