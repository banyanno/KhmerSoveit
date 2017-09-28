Public Class RequestDetailRepository
    Implements IRequestDetailRepository
    Private THIDataContext As New BaseDataContext

    Public Function ListRequestDetailByRequestID(ByVal pRequestID As Integer) As System.Collections.Generic.List(Of tblRequestDetail) Implements IRequestDetailRepository.ListRequestDetailByRequestID
        Dim lstRequestDetail = From q In THIDataContext.getTHIDataContext.tblRequestDetails _
                               Where q.RequestID = pRequestID
        Return lstRequestDetail.ToList
    End Function

    Public Function AllItemRequestList(ByVal FDate As Date, ByVal TDate As Date) As List(Of VAllRequestItem) Implements IRequestDetailRepository.AllItemRequestList
        Dim listItemRequest = From q In THIDataContext.getTHIDataContext.VAllRequestItems _
                              Where q.ReceivedDate.Value.Date >= FDate And q.ReceivedDate.Value.Date <= TDate
        'Where q.RequestDate.Value.Date >= FDate And q.RequestDate <= TDate

        Return listItemRequest.ToList
    End Function

    Public Function AllItemUsedList(ByVal FDate As Date, ByVal TDate As Date) As List(Of VAllUsedItem) Implements IRequestDetailRepository.AllItemUsedList
        Dim listUsedItem = From q In THIDataContext.getTHIDataContext.VAllUsedItems _
                              Where q.RunEndOfDayDate.Value.Date >= FDate And q.RunEndOfDayDate.Value.Date <= TDate And q.DepartID = MAIN_STOCK_DEPART_ID
        Return listUsedItem.ToList
    End Function

    Public Function AllItemBeginBalanceList(ByVal FDate As Date, ByVal TDate As Date) As List(Of VAllBeginBalance) Implements IRequestDetailRepository.AllItemBeginBalanceList
        Dim listBeginBalance = From q In THIDataContext.getTHIDataContext.VAllBeginBalances _
                               Where q.RunEndOfDayDate.Value.Date >= FDate And q.RunEndOfDayDate.Value.Date <= TDate And q.DepartID = MAIN_STOCK_DEPART_ID Order By q.RunEndOfDayDate Descending
        Return listBeginBalance.ToList
    End Function

    Public Function GetDicItemsRequest(ByVal pItemRequestList As List(Of VAllRequestItem)) As Dictionary(Of String, VAllRequestItem) Implements IRequestDetailRepository.GetDicItemsRequest
        Dim DicItemsRequestList As New Dictionary(Of String, VAllRequestItem)
        For Each myItemRequest As VAllRequestItem In pItemRequestList
            If DicItemsRequestList.Count = 0 Then
                DicItemsRequestList.Add(myItemRequest.ItemID.ToString, myItemRequest)
            Else
                If DicItemsRequestList.ContainsKey(myItemRequest.ItemID.ToString) = False Then
                    DicItemsRequestList.Add(myItemRequest.ItemID.ToString, myItemRequest)
                Else
                    'DicItemsRequestList.Item(myItemRequest.ItemID.ToString) = DicItemsRequestList.Item(myItemRequest.ItemID.ToString) + myItemRequest.Request
                End If
            End If
        Next
        Return DicItemsRequestList
    End Function

    Public Function GetDicItemsUsed(ByVal pItemsUsedList As List(Of VAllUsedItem)) As Dictionary(Of String, Double) Implements IRequestDetailRepository.GetDicItemsUsed
        Dim DicItemsUsedList As New Dictionary(Of String, Double)
        For Each myItemUsed As VAllUsedItem In pItemsUsedList

            If DicItemsUsedList.Count = 0 Then
                DicItemsUsedList.Add(myItemUsed.ItemID.ToString, myItemUsed.Used)
            Else
                If DicItemsUsedList.ContainsKey(myItemUsed.ItemID.ToString) = False Then
                    DicItemsUsedList.Add(myItemUsed.ItemID.ToString, myItemUsed.Used)
                Else
                    DicItemsUsedList.Item(myItemUsed.ItemID.ToString) = DicItemsUsedList.Item(myItemUsed.ItemID.ToString) + myItemUsed.Used
                End If
            End If
        Next
        Return DicItemsUsedList
    End Function

    Public Function GetDicItemsBeginBalance(ByVal pItemsBeginBalanceList As List(Of VAllBeginBalance)) As Dictionary(Of String, Double) Implements IRequestDetailRepository.GetDicItemsBeginBalance
        '--- OK if the list VAllBeginBalance sort in acs
        Dim DicItemsBeginBalanceList As New Dictionary(Of String, Double)
        For Each myItemBeginBalance As VAllBeginBalance In pItemsBeginBalanceList

            If DicItemsBeginBalanceList.Count = 0 Then
                DicItemsBeginBalanceList.Add(myItemBeginBalance.ItemID.ToString, myItemBeginBalance.EndBalance)
            Else
                If DicItemsBeginBalanceList.ContainsKey(myItemBeginBalance.ItemID.ToString) = False Then
                    DicItemsBeginBalanceList.Add(myItemBeginBalance.ItemID.ToString, myItemBeginBalance.EndBalance)
                End If
            End If
        Next
        Return DicItemsBeginBalanceList
    End Function

End Class
