Public Interface IRequestDetailRepository
    Function ListRequestDetailByRequestID(ByVal pRequestID As Integer) As List(Of tblRequestDetail)
    Function AllItemRequestList(ByVal FDate As Date, ByVal TDate As Date) As List(Of VAllRequestItem)
    Function AllItemUsedList(ByVal FDate As Date, ByVal TDate As Date) As List(Of VAllUsedItem)
    Function AllItemBeginBalanceList(ByVal FDate As Date, ByVal TDate As Date) As List(Of VAllBeginBalance)

    Function GetDicItemsRequest(ByVal pItemRequestList As List(Of VAllRequestItem)) As Dictionary(Of String, VAllRequestItem)
    Function GetDicItemsUsed(ByVal pItemsUsedList As List(Of VAllUsedItem)) As Dictionary(Of String, Double)
    Function GetDicItemsBeginBalance(ByVal pItemsBeginBalanceList As List(Of VAllBeginBalance)) As Dictionary(Of String, Double)



End Interface
