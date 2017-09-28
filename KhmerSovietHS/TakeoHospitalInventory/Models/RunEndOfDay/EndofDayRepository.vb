Public Class EndofDayRepository
    Implements IEndofDayRepository




    Private THIDataContext As New BaseDataContext
    Public Function GetRequestListByDate(ByVal pRequestDay As Date, ByVal pDepartID As Integer) As System.Collections.Generic.List(Of tblRequest) Implements IEndofDayRepository.GetRequestListByDate
        Dim q = From request In THIDataContext.getTHIDataContext.tblRequests Where request.RequestDate.Value.Date = pRequestDay And request.RequestFromDepartID = pDepartID
        Return q.ToList
    End Function

    Public Function GetRecievedListByDate(ByVal pRecievedDay As Date, ByVal pDepartID As Integer) As List(Of tblReceived) Implements IEndofDayRepository.GetRecievedListByDate
        Dim q = From recieved In THIDataContext.getTHIDataContext.tblReceiveds Where recieved.ReceivedDate.Value.Date = pRecievedDay And recieved.ReceivedDepartID = pDepartID
        Return q.ToList
    End Function

    Public Function GetRequestDetailListByRequestID(ByVal pRequestID As Integer) As List(Of tblRequestDetail) Implements IEndofDayRepository.GetRequestDetailListByRequestID
        Dim q = From requestDetail In THIDataContext.getTHIDataContext.tblRequestDetails Where requestDetail.RequestID = pRequestID
        Return q.ToList
    End Function

    Public Function GetRecievedDetailListByRecievedID(ByVal pRecieved As Integer) As List(Of tblReceivedDetail) Implements IEndofDayRepository.GetRecievedDetailListByRecievedID
        Dim q = From recievedDetail In THIDataContext.getTHIDataContext.tblReceivedDetails Where recievedDetail.ReceivedID = pRecieved
        Return q.ToList
    End Function


    Public Function GetDicItemsInRequest(ByVal pRequestList As List(Of tblRequest)) As Dictionary(Of String, Integer) Implements IEndofDayRepository.GetDicItemsInRequest

        Dim DicItemsInRequest As New Dictionary(Of String, Integer)

        For Each myRequest As tblRequest In pRequestList
            Dim mytblRequestDetailList As List(Of tblRequestDetail) = GetRequestDetailListByRequestID(myRequest.RequestID)
            For Each mytblRequestDetail As tblRequestDetail In mytblRequestDetailList
                If DicItemsInRequest.Count = 0 Then
                    DicItemsInRequest.Add(mytblRequestDetail.ItemID.ToString, mytblRequestDetail.Quantity)
                Else
                    If DicItemsInRequest.ContainsKey(mytblRequestDetail.ItemID.ToString) = False Then
                        DicItemsInRequest.Add(mytblRequestDetail.ItemID.ToString, mytblRequestDetail.Quantity)
                    Else
                        DicItemsInRequest.Item(mytblRequestDetail.ItemID.ToString) = DicItemsInRequest.Item(mytblRequestDetail.ItemID.ToString) + mytblRequestDetail.Quantity
                    End If
                End If
            Next
        Next

        Return DicItemsInRequest

    End Function



    Public Function GetDicItemsInRecieved(ByVal pRecievedList As List(Of tblReceived)) As Dictionary(Of String, Integer) Implements IEndofDayRepository.GetDicItemsInRecieved

        Dim DicItemsInRecieved As New Dictionary(Of String, Integer)

        For Each myRecieved As tblReceived In pRecievedList
            Dim mytblRecievedDetailList As List(Of tblReceivedDetail) = GetRecievedDetailListByRecievedID(myRecieved.ReceivedID)
            For Each mytblReceivedDetail As tblReceivedDetail In mytblRecievedDetailList
                If DicItemsInRecieved.Count = 0 Then
                    DicItemsInRecieved.Add(mytblReceivedDetail.ItemID.ToString, mytblReceivedDetail.ReceivedQuantity)
                Else
                    If DicItemsInRecieved.ContainsKey(mytblReceivedDetail.ItemID.ToString) = False Then
                        DicItemsInRecieved.Add(mytblReceivedDetail.ItemID.ToString, mytblReceivedDetail.ReceivedQuantity)
                    Else
                        DicItemsInRecieved.Item(mytblReceivedDetail.ItemID.ToString) = DicItemsInRecieved.Item(mytblReceivedDetail.ItemID.ToString) + mytblReceivedDetail.ReceivedQuantity
                    End If
                End If
            Next
        Next

        Return DicItemsInRecieved

    End Function




    Public Function GetUsedDetailListByUsedID(ByVal pUseID As Integer) As List(Of tblUsedDetail) Implements IEndofDayRepository.GetUsedDetailListByUsedID
        Dim q = From usedDetail In THIDataContext.getTHIDataContext.tblUsedDetails Where usedDetail.UsedID = pUseID
        Return q.ToList
    End Function



    Public Function IsRunEndofDayInCurrentDay(ByVal pDepartID As Integer) As Boolean Implements IEndofDayRepository.IsRunEndofDayInCurrentDay

        Try
            Dim q = (From runendofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where runendofDay.DepartID = pDepartID And runendofDay.RunEndOfDayDate.Value.Date = GetDateServer().Date Select runendofDay.RunEndOfDayID).Count
            If q Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function IsRunEndofDayInParticularDay(ByVal pDepartID As Integer, ByVal pDate As Date) As Boolean Implements IEndofDayRepository.IsRunEndofDayInParticularDay

        Try
            Dim q = (From runendofDay In THIDataContext.getTHIDataContext.tblEndofDayRunStatus Where runendofDay.DepartID = pDepartID And runendofDay.RunEndOfDayDate.Value.Date = pDate Select runendofDay.RunEndOfDayStatusID).Count
            If q Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function GetCaritasRequestListByDate(ByVal pRequestDay As Date) As List(Of CARITAS_REQUEST_INVENTORY) Implements IEndofDayRepository.GetCaritasRequestListByDate

        'Dim q = From request In THIDataContext.getTHIDataContext.CARITAS_REQUEST_INVENTORies Where request.RequestDate.Value.Date = pRequestDay
        Dim q = From request In THIDataContext.getTHIDataContext.CARITAS_REQUEST_INVENTORies Where request.ReceivedDate.Value.Date = pRequestDay
        Return q.ToList

    End Function

    Public Function GetCaritasDicItemsInRequest(ByVal pRequestList As List(Of CARITAS_REQUEST_INVENTORY), ByVal IsGetRec As Boolean) As Dictionary(Of String, Integer) Implements IEndofDayRepository.GetCaritasDicItemsInRequest

        If IsGetRec = False Then
            'Dim DicItemsInRequest As New Dictionary(Of String, Integer)
            'For Each myRequest As CARITAS_REQUEST_INVENTORY In pRequestList
            '    'If myRequest.Status = 2 Then '--- Caritas Receive is approved
            '    Dim CaritasReqDetailList As List(Of CARITAS_REQUEST_DETAIL_INVENTORY) = GetCaritasReqDetailListByReqID(myRequest.RequestID)
            '    For Each CaritasReqDetail As CARITAS_REQUEST_DETAIL_INVENTORY In CaritasReqDetailList
            '        If DicItemsInRequest.Count = 0 Then
            '            DicItemsInRequest.Add(CaritasReqDetail.ItemID.ToString, CaritasReqDetail.RequestQuantity)
            '        Else
            '            If DicItemsInRequest.ContainsKey(CaritasReqDetail.ItemID.ToString) = False Then
            '                DicItemsInRequest.Add(CaritasReqDetail.ItemID.ToString, CaritasReqDetail.RequestQuantity)
            '            Else
            '                DicItemsInRequest.Item(CaritasReqDetail.ItemID.ToString) = DicItemsInRequest.Item(CaritasReqDetail.ItemID.ToString) + CaritasReqDetail.RequestQuantity
            '            End If
            '        End If
            '    Next
            '    'End If
            'Next
            'Return DicItemsInRequest
        Else

            Dim DicItemsInRequest As New Dictionary(Of String, Integer)

            For Each myRequest As CARITAS_REQUEST_INVENTORY In pRequestList
                'If myRequest.Status = 2 Then '--- Caritas Receive is approved
                Dim CaritasReqDetailList As List(Of CARITAS_REQUEST_DETAIL_INVENTORY) = GetCaritasReceivedDetailListByReceivedID(myRequest.RequestID, Now.Date)
                For Each CaritasReqDetail As CARITAS_REQUEST_DETAIL_INVENTORY In CaritasReqDetailList
                    If DicItemsInRequest.Count = 0 Then
                        DicItemsInRequest.Add(CaritasReqDetail.ItemID.ToString, CaritasReqDetail.ReceivedQuantity)
                    Else
                        If DicItemsInRequest.ContainsKey(CaritasReqDetail.ItemID.ToString) = False Then
                            DicItemsInRequest.Add(CaritasReqDetail.ItemID.ToString, CaritasReqDetail.ReceivedQuantity)
                        Else
                            DicItemsInRequest.Item(CaritasReqDetail.ItemID.ToString) = DicItemsInRequest.Item(CaritasReqDetail.ItemID.ToString) + CaritasReqDetail.ReceivedQuantity
                        End If
                    End If
                Next
                'End If
            Next

            Return DicItemsInRequest
        End If
    End Function

    Public Function GetCaritasReqDetailListByReqID(ByVal pReqID As Integer) As List(Of CARITAS_REQUEST_DETAIL_INVENTORY) Implements IEndofDayRepository.GetCaritasReqDetailListByReqID
        Dim q = From requestDetail In THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies Where requestDetail.RequestID = pReqID And requestDetail.IsReady = True And requestDetail.IsReceive = True
        Return q.ToList
    End Function
    Public Function GetCaritasReceivedDetailListByReceivedID(ByVal pReqID As Integer, ByVal receivedDate As Date) As List(Of CARITAS_REQUEST_DETAIL_INVENTORY)
        Dim q = From requestDetail In THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies _
                Where requestDetail.RequestID = pReqID And requestDetail.IsReady = True _
                And requestDetail.IsReceive = True And requestDetail.ReceiveDateDetail = receivedDate
        Return q.ToList
    End Function
    Public Function GetReceivedDicItemCaritas(ByVal received As System.Collections.Generic.List(Of CARITAS_REQUEST_DETAIL_INVENTORY), ByVal dateReceived As Date) As System.Collections.Generic.Dictionary(Of String, Integer) Implements IEndofDayRepository.GetReceivedDicItem
        Dim DicItemsInReceived As New Dictionary(Of String, Integer)
        For Each myReceivedCaritas As CARITAS_REQUEST_DETAIL_INVENTORY In received
            Dim cariReceived As List(Of CARITAS_REQUEST_DETAIL_INVENTORY) = GetReceivelistCaritatas(dateReceived)
            For Each receivedC As CARITAS_REQUEST_DETAIL_INVENTORY In cariReceived
                If DicItemsInReceived.Count = 0 Then
                    DicItemsInReceived.Add(receivedC.ItemID.ToString, receivedC.ReceivedQuantity)
                Else
                    If DicItemsInReceived.ContainsKey(receivedC.ItemID.ToString) = False Then
                        DicItemsInReceived.Add(receivedC.ItemID.ToString, receivedC.ReceivedQuantity)
                        'Else
                        '    DicItemsInReceived.Item(receivedC.ItemID.ToString) = DicItemsInReceived.Item(receivedC.ItemID.ToString) + receivedC.ReceivedQuantity
                    End If
                End If
            Next
        Next
        Return DicItemsInReceived
    End Function
    Public Function GetReceivedCaritasBydate(ByVal receivedDate As Date) As System.Collections.Generic.List(Of CARITAS_REQUEST_DETAIL_INVENTORY) Implements IEndofDayRepository.GetReceivedCaritasBydate
        Dim q = From requestDetail In THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies Where (requestDetail.IsReady = True) And (requestDetail.IsReceive = True) And (requestDetail.ReceiveDateDetail = receivedDate)
        Return q.ToList
    End Function

    Public Function GetReceivelistCaritatas(ByVal dateReceived As Date) As System.Collections.Generic.List(Of CARITAS_REQUEST_DETAIL_INVENTORY) Implements IEndofDayRepository.GetReceivelist
        Dim q = From ReceivedtDetail In THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies _
                Where ReceivedtDetail.IsReady = True _
                And ReceivedtDetail.IsReceive = True And ReceivedtDetail.ReceiveDateDetail = dateReceived
        Return q.ToList
    End Function

    Public Function GetUseListByDate(ByVal pUsedDay As Date, ByVal pDepartID As Integer) As List(Of tblUsed) Implements IEndofDayRepository.GetUseListByDate
        Dim q = From used In THIDataContext.getTHIDataContext.tblUseds Where used.UsedDate.Value.Date = pUsedDay And used.UsedDepartID = pDepartID
        Return q.ToList
    End Function


    Public Function GetDicItemsInUsed(ByVal pUsedList As List(Of tblUsed)) As Dictionary(Of String, Integer) Implements IEndofDayRepository.GetDicItemsInUsed

        Dim DicItemsUsed As New Dictionary(Of String, Integer)
        For Each myUsed As tblUsed In pUsedList
            Dim mytblUsedDetailList As List(Of tblUsedDetail) = GetUsedDetailListByUsedID(myUsed.UsedID)
            For Each myUsedDetail As tblUsedDetail In mytblUsedDetailList
                If DicItemsUsed.Count = 0 Then
                    DicItemsUsed.Add(myUsedDetail.ItemID.ToString, myUsedDetail.UsedQuantity)
                Else
                    If DicItemsUsed.ContainsKey(myUsedDetail.ItemID.ToString) = False Then
                        DicItemsUsed.Add(myUsedDetail.ItemID.ToString, myUsedDetail.UsedQuantity)
                    Else
                        DicItemsUsed.Item(myUsedDetail.ItemID.ToString) = DicItemsUsed.Item(myUsedDetail.ItemID.ToString) + myUsedDetail.UsedQuantity
                    End If
                End If
            Next
        Next

        Return DicItemsUsed
    End Function
    Public Function GetAdjustListByDate(ByVal pAdjustDay As Date, ByVal pDepardID As Integer) As System.Collections.Generic.List(Of tblAdjustStockHistory) Implements IEndofDayRepository.GetAdjustListByDate
        Dim Adj = From AdjustStock In THIDataContext.getTHIDataContext.tblAdjustStockHistories Where AdjustStock.AdjustDate.Value.Date = pAdjustDay And AdjustStock.DepartID = pDepardID And AdjustStock.IsApproval = True
        Return Adj.ToList
    End Function

    Public Function GetDicItemsInAdjusted(ByVal pAdjustList As System.Collections.Generic.List(Of tblAdjustStockHistory)) As System.Collections.Generic.Dictionary(Of String, Integer) Implements IEndofDayRepository.GetDicItemsInAdjusted
        Dim DicItemsAdjust As New Dictionary(Of String, Integer)
        For Each myAdjust As tblAdjustStockHistory In pAdjustList
            If DicItemsAdjust.Count = 0 Then
                DicItemsAdjust.Add(myAdjust.ItemID.ToString, myAdjust.Difference)
            Else
                If DicItemsAdjust.ContainsKey(myAdjust.ItemID.ToString) = False Then
                    DicItemsAdjust.Add(myAdjust.ItemID.ToString, myAdjust.Difference)
                Else
                    DicItemsAdjust.Item(myAdjust.ItemID.ToString) = DicItemsAdjust.Item(myAdjust.ItemID.ToString) + myAdjust.Difference
                End If
            End If
        Next

        Return DicItemsAdjust
    End Function


End Class
