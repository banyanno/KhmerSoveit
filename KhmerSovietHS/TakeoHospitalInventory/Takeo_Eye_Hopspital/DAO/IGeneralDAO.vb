Imports System.Data.DataSet
Public Interface IGeneralDAO
    Function InsertDAO(ByVal sql As String) As Integer
    Function UpdateDAO(ByVal sql As String) As Integer
    Function DeleteDAO(ByVal sql As String) As Integer
    Function SelectDAOAsDataSet(ByVal sql As String) As DataSet
    Function SelectDAOAsDataTatabl(ByVal sql As String) As DataTable
    Function SelectDAOAsScalar(ByVal sql As String) As Object
End Interface
