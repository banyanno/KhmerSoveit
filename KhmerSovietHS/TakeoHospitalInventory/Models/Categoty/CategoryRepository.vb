Imports System.Linq
Imports System.Data.Common
Imports System.Data.Linq.DataContext
Public Class CategoryRepository
    Implements ICategoryRepository
    Private THIDataContext As New BaseDataContext

    Public Function CreateCate(ByVal tblCategory As Object) As String Implements ICategoryRepository.CreateCate
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblCategories.InsertOnSubmit(tblCategory)
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()
        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function CreateCateWithoutTransCover(ByVal tblCategory As Object) As Boolean Implements ICategoryRepository.CreateCateWithoutTransCover
        THIDataContext.getTHIDataContext.tblCategories.InsertOnSubmit(tblCategory)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function DeleteCate(ByVal tblCategory As Object) As String Implements ICategoryRepository.DeleteCate
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblCategories.DeleteOnSubmit(tblCategory)
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()
        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            THIDataContext.getTHIDataContext.Connection.Close()
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function DeleteCateWithoutTransCover(ByVal tblCategory As Object) As Boolean Implements ICategoryRepository.DeleteCateWithoutTransCover
        THIDataContext.getTHIDataContext.tblCategories.DeleteOnSubmit(tblCategory)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetCateByID(ByVal pCateID As Integer) As tblCategory Implements ICategoryRepository.GetCateByID
        Dim cate = From tblCategory In THIDataContext.getTHIDataContext.tblCategories Where tblCategory.CateID = pCateID
        Return cate.SingleOrDefault
    End Function

    Public Function ListCate() As System.Collections.Generic.List(Of tblCategory) Implements ICategoryRepository.ListCate
        Return THIDataContext.getTHIDataContext.tblCategories.ToList
    End Function

    Public Function UpdateCate() As String Implements ICategoryRepository.UpdateCate

        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()
        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function UpdateCateWithoutTransCover() As Boolean Implements ICategoryRepository.UpdateCateWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetCateNameIEnum(ByVal mycombo As ComboBox) As IEnumerable Implements ICategoryRepository.GetCateNameIEnum

        Dim Filtered = THIDataContext.getTHIDataContext.tblCategories.Where(Function(cate) _
                                    cate.CateName.Contains(mycombo.SelectedText))
        Return Filtered
    End Function

    Public Sub PopulateTreeView(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode) Implements ICategoryRepository.PopulateTreeView

        Dim categories = From cate In THIDataContext.getTHIDataContext.tblCategories Where cate.ParentID = inParentID
        If categories.Count > 0 Then
            For Each cate In categories
                Dim parentnode As TreeNode
                'we'll provide some text for the tree node.
                Dim strLabel As String = cate.CateName & "(" & cate.ItemCount & ")"                
                parentnode = New TreeNode(strLabel, 0, 0)
                parentnode.Tag = cate.CateID
                inTreeNode.Nodes.Add(parentnode)
                'set the tag property for the current node. This comes in useful if 
                'you want to pass the value of a specific record id.
                'since the tag value is not visible, in the TreeView1_AfterSelect event 
                'you could pass the value to another sub routine, for example:
                'FillDataGrid(TreeView1.SelectedNode.Tag)
                'parentnode.Tag = cate.CateID
                'call the routine again to find childern of this record.
                PopulateTreeView(cate.CateID, parentnode)
            Next
        End If    
    End Sub
    Public Function GetCateIDByCateName(ByVal pCateName As String) As Integer Implements ICategoryRepository.GetCateIDByCateName
        Dim str As Integer = 0
        Dim category = From cate In THIDataContext.getTHIDataContext.tblCategories Where cate.CateName = pCateName

        If category.Count <> 0 Then
            Return category.SingleOrDefault.CateID
        Else
            Return 0
        End If
    End Function

    Public Function isCateExistSearchByCateName(ByVal pCateName As String) As Boolean Implements ICategoryRepository.isCateExistSearchByCateName

        Dim category = (From cate In THIDataContext.getTHIDataContext.tblCategories Where cate.CateName.ToUpper = UCase(pCateName) _
                         Select cate).Count()
        If category > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GenerateCateID() As Integer Implements ICategoryRepository.GenerateCateID

        If THIDataContext.getTHIDataContext.tblCategories.ToList.Count = 0 Then
            Return 1
        Else
            Dim q = (From cate In THIDataContext.getTHIDataContext.tblCategories _
        Select cate.CateID).Max
            Return Val(q) + 1
        End If

    End Function

    Public Function isCateHasSubCate(ByVal pCateID As Integer) As Boolean Implements ICategoryRepository.isCateHasSubCate
        
        Dim q = (From cate In THIDataContext.getTHIDataContext.tblCategories _
                 Where cate.ParentID = pCateID _
                Select cate.CateID).Count

        If q = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function GetItemCountByCateID(ByVal pCateID As Integer) As Integer Implements ICategoryRepository.GetItemCountByCateID
        Dim temp = THIDataContext.getTHIDataContext.ExecuteQuery(Of tblCategory)( _
        "SELECT [cate].CateID,[cate].ItemCount " & _
        "FROM tblCategory AS [cate] " & _
        "WHERE [cate].CateID ={0} ; ", pCateID)

        Return temp.SingleOrDefault.ItemCount

    End Function

    

End Class
