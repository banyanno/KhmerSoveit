Public Class GeneralDAO
    Inherits AbstractConnection
    Implements IGeneralDAO
    Public Function DeleteDAO(ByVal sql As String) As Integer Implements IGeneralDAO.DeleteDAO
        Return DeleteTransaction(sql)
    End Function

    Public Function InsertDAO(ByVal sql As String) As Integer Implements IGeneralDAO.InsertDAO
        Return InsertTransaction(sql)
    End Function

    Public Function SelectDAOAsDataSet(ByVal sql As String) As System.Data.DataSet Implements IGeneralDAO.SelectDAOAsDataSet
        Return CType(SelectAsSqlDataSet(sql), DataSet)
    End Function

    Public Function SelectDAOAsDataTatable(ByVal sql As String) As System.Data.DataTable Implements IGeneralDAO.SelectDAOAsDataTatabl
        Return CType(SelectAsDataTable(sql), DataTable)
    End Function

    Public Function UpdateDAO(ByVal sql As String) As Integer Implements IGeneralDAO.UpdateDAO
        Return UpdateTransaction(sql)
    End Function

    Public Function SelectDAOAsScalar(ByVal sql As String) As Object Implements IGeneralDAO.SelectDAOAsScalar
        Return SelectAsScalar(sql)
    End Function
End Class
