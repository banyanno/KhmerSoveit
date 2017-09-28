Public Interface IDataTransaction
    Function UpdateTransaction(ByVal objSQL As Object) As Integer
    Function InsertTransaction(ByVal objSQL As Object) As Integer
    Function DeleteTransaction(ByVal objSQL As Object) As Integer
    Function SelectAsSqlDataSet(ByVal objSQL As Object) As Object
    Function SelectAsDataTable(ByVal objSQL As Object) As Object
    Function SelectAsScalar(ByVal sql As Object) As Object
End Interface