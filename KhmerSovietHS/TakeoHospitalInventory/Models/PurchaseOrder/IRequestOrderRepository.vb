Public Interface IRequestOrderRepository
    Sub PopulateTreeView(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode)
    Function GetMaxRequestID() As Double
    Function GetRequestOrderByID(ByVal pRequestID As Integer) As tblRequest
    Sub PopulateTreeViewRequestOrder(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode, ByVal Imglist As ImageList)
    Function UpdateRequestOrder() As String

    '*** For received request order list ***
    Sub PopulateTreeViewReceivedRequestOrder(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode)
    '====

    '*** For received request order list ***
    Sub PopulateTreeViewDepartReceivedRequestOrder(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode)
    '====

End Interface
