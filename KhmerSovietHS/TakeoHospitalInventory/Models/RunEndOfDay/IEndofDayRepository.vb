Public Interface IEndofDayRepository

    Function GetRequestListByDate(ByVal pRequestDay As Date, ByVal pDepartID As Integer) As List(Of tblRequest)
    Function GetRecievedListByDate(ByVal pRecievedDay As Date, ByVal pDepartID As Integer) As List(Of tblReceived)
    Function GetRequestDetailListByRequestID(ByVal pRequestID As Integer) As List(Of tblRequestDetail)
    Function GetRecievedDetailListByRecievedID(ByVal pRecieved As Integer) As List(Of tblReceivedDetail)
    Function GetDicItemsInRequest(ByVal pRequestList As List(Of tblRequest)) As Dictionary(Of String, Integer)
    Function GetDicItemsInRecieved(ByVal pRecievedList As List(Of tblReceived)) As Dictionary(Of String, Integer)


   

    Function GetUseListByDate(ByVal pUsedDay As Date, ByVal pDepartID As Integer) As List(Of tblUsed)
    Function GetAdjustListByDate(ByVal pAdjustDay As Date, ByVal pDepardID As Integer) As List(Of tblAdjustStockHistory)
    Function GetUsedDetailListByUsedID(ByVal pUseID As Integer) As List(Of tblUsedDetail)
    Function GetDicItemsInUsed(ByVal pUsedList As List(Of tblUsed)) As Dictionary(Of String, Integer)
    Function GetDicItemsInAdjusted(ByVal pAdjustList As List(Of tblAdjustStockHistory)) As Dictionary(Of String, Integer)
    Function IsRunEndofDayInCurrentDay(ByVal pDepartID As Integer) As Boolean
    Function IsRunEndofDayInParticularDay(ByVal pDepartID As Integer, ByVal pDate As Date) As Boolean

    Function GetCaritasRequestListByDate(ByVal pRequestDay As Date) As List(Of CARITAS_REQUEST_INVENTORY)
    Function GetCaritasDicItemsInRequest(ByVal pRequestList As List(Of CARITAS_REQUEST_INVENTORY), ByVal IsGetRec As Boolean) As Dictionary(Of String, Integer)
    Function GetCaritasReqDetailListByReqID(ByVal pReqID As Integer) As List(Of CARITAS_REQUEST_DETAIL_INVENTORY)

    'Interface for get Receive QTY from Caristas 
    Function GetReceivedCaritasBydate(ByVal receivedDate As Date) As List(Of CARITAS_REQUEST_DETAIL_INVENTORY)
    Function GetReceivedDicItem(ByVal received As List(Of CARITAS_REQUEST_DETAIL_INVENTORY), ByVal dateReceived As Date) As Dictionary(Of String, Integer)
    Function GetReceivelist(ByVal dateReceived As Date) As List(Of CARITAS_REQUEST_DETAIL_INVENTORY)


End Interface
