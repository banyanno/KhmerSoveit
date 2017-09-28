Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCRunEndOfDay

    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim MainStockItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim EndofDayRunDataAdapter As DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Private THIDataContext As New BaseDataContext
    Dim EndofDayRepo As IEndofDayRepository = New EndofDayRepository
    Dim VEODAccessRightDA As DSUserManagementTableAdapters.VEODAccessRightTableAdapter
    Dim MTakeoInventory As MainTakeoInventory

    Public Sub New(ByVal MTakeoInventory As MainTakeoInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        EndofDayRunDataAdapter = New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        MainStockItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VEODAccessRightDA = New DSUserManagementTableAdapters.VEODAccessRightTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub UCRunEndOfDay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Initial combo department
        With cbDepart
            '.DataSource = DepartDataAdapter.GetDepartDataByDepartID(CInt(DEPART_ID))
            .DataSource = VEODAccessRightDA.GetEODAccessRightByUserID(CInt(USER_ID)) '-- Get department list available for user run EOD
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbDepartS
            '.DataSource = DepartDataAdapter.GetDepartDataByDepartID(CInt(DEPART_ID))
            .DataSource = DepartDataAdapter.GetData '-- Get department list available for user run EOD
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(GetDateServer.Date, GetDateServer.Date)
        RunEndofDayStatus(REDCalendar.SelectionEnd.Date)

        '------- Activate Combo Department ------
        cbDepart.Enabled = Not (ChBAll.Checked)
        cbDepartS.Enabled = Not (ChBAllS.Checked)
        SplitContainer1.SplitterDistance = Me.Height / 3

    End Sub

    Private Sub BtnProcessEndOfDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcessEndOfDay.Click

        If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MTakeoInventory.StatusLoading(True)
            Application.DoEvents()
            If BgLoadingRunEOD.IsBusy = True Then
                BgLoadingRunEOD.CancelAsync()
            Else
                BgLoadingRunEOD.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        If ChBAllS.Checked = False Then
            If ValidateCombobox(cbDepartS, "", ErrorEOD) = False Then Exit Sub

            Try
                Dim myDepartID As Integer = cbDepartS.SelectedValue
                Dim fromDate As Date = dptFromDate.Value.Date
                Dim toDate As Date = dptToDate.Value.Date

                gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllItemEndofDaySearch(myDepartID, fromDate, toDate)
            Catch ex As Exception

            End Try
        Else
            Try
                Dim fromDate As Date = dptFromDate.Value.Date
                Dim toDate As Date = dptToDate.Value.Date

                gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(fromDate, toDate)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub REDCalendar_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles REDCalendar.DateChanged       
        RunEndofDayStatus(REDCalendar.SelectionStart.Date)
    End Sub

    Sub RunEndofDayStatus(ByVal pDate As Date)
        If EndofDayRepo.IsRunEndofDayInParticularDay(CInt(DEPART_ID), pDate) = False Then
            LbNotYet.Visible = True
            LbReady.Visible = False
        Else
            LbNotYet.Visible = False
            LbReady.Visible = True
        End If
    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        If ValidateCombobox(cbDepartS, "", ErrorEOD) = False Then Exit Sub

        Dim FRptRequestView As New frmReportViewer

        '  FRptRequestView.ReportOption = 9
        FRptRequestView.ReportOption = 16
        FRptRequestView.FDate = dptFromDate.Value.Date
        FRptRequestView.TDate = dptToDate.Value.Date
        FRptRequestView.DepartID = cbDepartS.SelectedValue
        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub BgLoadingRunEOD_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingRunEOD.DoWork
        Try
            MenuReceivedAll.Enabled = False
        Catch ex As Exception

        End Try
        Try
            MenuReadyInOT.Enabled = False
        Catch ex As Exception

        End Try

        RubEndOfDay()
    End Sub

    Sub RubEndOfDay()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf RubEndOfDay))
        Else

            If ChBAll.Checked = False Then
                If ValidateCombobox(cbDepart, "", ErrorEOD) = False Then Exit Sub
                'If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                ' Process summeries item request current day
                Dim DicItemsRequestInDay As New Dictionary(Of String, Integer)
                Dim DicItemsRecievedInDay As New Dictionary(Of String, Integer)
                Dim DicItemsUsedInDay As New Dictionary(Of String, Integer)
                Dim DicItemAdjustInDay As New Dictionary(Of String, Integer)
                Dim DicCaritasItemsRequestInDay As New Dictionary(Of String, Integer)
                Dim DicCaritasItemsRecievedInDay As New Dictionary(Of String, Integer)

                Dim sysDate As Date = REDCalendar.SelectionEnd.Date
                Dim mytblRequestList As List(Of tblRequest) = EndofDayRepo.GetRequestListByDate(sysDate, CInt(cbDepart.SelectedValue))
                Dim mytblRecievedList As List(Of tblReceived) = EndofDayRepo.GetRecievedListByDate(sysDate, CInt(cbDepart.SelectedValue))
                Dim mytblUsedList As List(Of tblUsed) = EndofDayRepo.GetUseListByDate(sysDate, CInt(cbDepart.SelectedValue))
                Dim mytblAdjustList As List(Of tblAdjustStockHistory) = EndofDayRepo.GetAdjustListByDate(sysDate, CInt(cbDepart.SelectedValue))

                ' Get list recieve

                '--- Get Caristas request list
                'If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                If CInt(cbDepart.SelectedValue) = MAIN_STOCK_DEPART_ID Then

                    Dim myCaritasReqList As List(Of CARITAS_REQUEST_INVENTORY) = EndofDayRepo.GetCaritasRequestListByDate(sysDate)
                    Dim myCaritasRecList As List(Of CARITAS_REQUEST_DETAIL_INVENTORY) = EndofDayRepo.GetReceivedCaritasBydate(sysDate)
                    If myCaritasReqList.Count > 0 Then
                        DicCaritasItemsRequestInDay = EndofDayRepo.GetCaritasDicItemsInRequest(myCaritasReqList, False)
                        'DicCaritasItemsRecievedInDay = EndofDayRepo.GetCaritasDicItemsInRequest(myCaritasReqList, True)
                    End If
                    If myCaritasRecList.Count > 0 Then
                        DicCaritasItemsRecievedInDay = EndofDayRepo.GetReceivedDicItem(myCaritasRecList, sysDate)
                    End If

                End If
                '--- End Get Caristas request list


                If mytblRequestList.Count > 0 Then
                    DicItemsRequestInDay = EndofDayRepo.GetDicItemsInRequest(mytblRequestList)
                End If
                If mytblRecievedList.Count > 0 Then
                    DicItemsRecievedInDay = EndofDayRepo.GetDicItemsInRecieved(mytblRecievedList)
                End If
                If mytblUsedList.Count > 0 Then
                    DicItemsUsedInDay = EndofDayRepo.GetDicItemsInUsed(mytblUsedList)
                End If
                If mytblAdjustList.Count > 0 Then
                    DicItemAdjustInDay = EndofDayRepo.GetDicItemsInAdjusted(mytblAdjustList)
                End If

                ' Incase user confuse process end of day but they have more Transaction to Add
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim Deltrans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = Deltrans

                Try
                    'THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRun WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(DEPART_ID), sysDate)
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRun WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(cbDepart.SelectedValue), sysDate)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    '--- Update table tblEndofDdayRunStatus
                    'THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRunStatus WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(DEPART_ID), sysDate)
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRunStatus WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(cbDepart.SelectedValue), sysDate)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    Dim EndofDayRunStatus As New tblEndofDayRunStatus
                    'EndofDayRunStatus.DepartID = CInt(DEPART_ID)
                    EndofDayRunStatus.DepartID = CInt(cbDepart.SelectedValue)
                    EndofDayRunStatus.RunEndOfDayDate = sysDate
                    EndofDayRunStatus.Status = 1

                    THIDataContext.getTHIDataContext.tblEndofDayRunStatus.InsertOnSubmit(EndofDayRunStatus)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    Deltrans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    Deltrans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    MessageBox.Show("Erorr in block delete data in table End-of-Day of current date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Deltrans = Nothing
                End Try


                Dim pair As KeyValuePair(Of String, Integer)
                '--- Incase some items request
                For Each pair In DicItemsRequestInDay
                    ' Add all request items in current day run end of day transaction
                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans

                    Try
                        Dim mytblEndofDayRun As New tblEndofDayRun
                        mytblEndofDayRun.RunEndOfDayDate = sysDate
                        'mytblEndofDayRun.DepartID = CInt(DEPART_ID)
                        mytblEndofDayRun.DepartID = CInt(cbDepart.SelectedValue)
                        mytblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                        mytblEndofDayRun.ItemID = Val(pair.Key)
                        mytblEndofDayRun.RequestQty = pair.Value
                        mytblEndofDayRun.ReceivedQty = 0
                        mytblEndofDayRun.UseQty = 0
                        mytblEndofDayRun.AdjustQTY = 0


                        THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(mytblEndofDayRun)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                        '====
                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                    Catch ex As Exception

                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                        MessageBox.Show("Error block count item request of other department : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        trans = Nothing
                    End Try
                Next

                '--- MainStock request to Caritas update End of day
                'If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                If CInt(cbDepart.SelectedValue) = MAIN_STOCK_DEPART_ID Then

                    For Each pair In DicCaritasItemsRequestInDay
                        ' Add all request items in current day run end of day transaction
                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans

                        Try
                            'Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(DEPART_ID) And qEndofDay.RunEndOfDayDate = sysDate
                            Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(cbDepart.SelectedValue) And qEndofDay.RunEndOfDayDate = sysDate
                            If q.ToList.Count = 0 Then
                                Dim mytblEndofDayRun As New tblEndofDayRun
                                mytblEndofDayRun.RunEndOfDayDate = sysDate
                                'mytblEndofDayRun.DepartID = CInt(DEPART_ID)
                                mytblEndofDayRun.DepartID = CInt(cbDepart.SelectedValue)
                                mytblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                                mytblEndofDayRun.ItemID = Val(pair.Key)
                                mytblEndofDayRun.RequestQty = pair.Value
                                mytblEndofDayRun.ReceivedQty = 0
                                mytblEndofDayRun.UseQty = 0
                                mytblEndofDayRun.AdjustQTY = 0

                                THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(mytblEndofDayRun)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Else
                                Dim CurEndofDayRun As tblEndofDayRun = q.SingleOrDefault
                                CurEndofDayRun.RequestQty = CurEndofDayRun.RequestQty + pair.Value
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            End If

                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()

                        Catch ex As Exception
                            MsgBox("Error block count item request to Caritas : " & ex.Message)
                            trans.Rollback()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        Finally
                            trans = Nothing
                        End Try
                    Next
                End If

                '---  MainStock Receive Item from Caritas update End of day

                If CInt(cbDepart.SelectedValue) = MAIN_STOCK_DEPART_ID Then

                    For Each pair In DicCaritasItemsRecievedInDay
                        ' Add all request items in current day run end of day transaction
                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans

                        'Try
                        'Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(DEPART_ID) And qEndofDay.RunEndOfDayDate = sysDate
                        Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(cbDepart.SelectedValue) And qEndofDay.RunEndOfDayDate = sysDate
                        If q.ToList.Count = 0 Then
                            Dim mytblEndofDayRun As New tblEndofDayRun
                            mytblEndofDayRun.RunEndOfDayDate = sysDate
                            'mytblEndofDayRun.DepartID = CInt(DEPART_ID)
                            mytblEndofDayRun.DepartID = CInt(cbDepart.SelectedValue)
                            mytblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                            mytblEndofDayRun.ItemID = Val(pair.Key)
                            mytblEndofDayRun.RequestQty = 0
                            mytblEndofDayRun.ReceivedQty = pair.Value
                            mytblEndofDayRun.UseQty = 0
                            mytblEndofDayRun.AdjustQTY = 0

                            THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(mytblEndofDayRun)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                        Else
                            Dim CurEndofDayRun As tblEndofDayRun = q.SingleOrDefault
                            CurEndofDayRun.ReceivedQty = CurEndofDayRun.ReceivedQty + pair.Value
                            THIDataContext.getTHIDataContext.SubmitChanges()
                        End If
                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        'Catch ex As Exception
                        '    MsgBox("Error block count item receive from Caritas: " & ex.Message)
                        '    trans.Rollback()
                        '    THIDataContext.getTHIDataContext.Connection.Close()
                        'Finally
                        '    trans = Nothing
                        'End Try
                    Next
                End If
                '--- End MainStock receive from Caritas update End of day
                '--- End MainStock request to Caritas update End of day

                '--- Incase some items recieved not exist in current request we have add
                For Each Rpair In DicItemsRecievedInDay
                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans
                    Try
                        ' query by departID,ItemID,Date
                        'Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(cbDepart.SelectedValue) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        If q = False Then
                            ' Insert new item recieved in table tblEndofDayRun
                            Dim myRtblEndofDayRun As New tblEndofDayRun
                            myRtblEndofDayRun.RunEndOfDayDate = sysDate 'GetDateServer()
                            'myRtblEndofDayRun.DepartID = CInt(DEPART_ID)
                            myRtblEndofDayRun.DepartID = CInt(cbDepart.SelectedValue)
                            myRtblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                            myRtblEndofDayRun.ItemID = Val(Rpair.Key)
                            myRtblEndofDayRun.RequestQty = 0
                            myRtblEndofDayRun.ReceivedQty = DicItemsRecievedInDay.Item(Rpair.Key)
                            myRtblEndofDayRun.UseQty = 0
                            myRtblEndofDayRun.AdjustQTY = 0

                            THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(myRtblEndofDayRun)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        Else ' In case item already exist in table tblEndofDayRun then modify recieved item quantity

                            Dim myRtblEndofDayRun As New tblEndofDayRun
                            'Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(cbDepart.SelectedValue) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            myRtblEndofDayRun = myEndofDayRun.SingleOrDefault
                            myRtblEndofDayRun.ReceivedQty = DicItemsRecievedInDay.Item(Rpair.Key)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        End If

                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                    Catch ex As Exception
                        MsgBox("Error block count item receive from other department : " & ex.Message)
                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Finally
                        trans = Nothing
                    End Try
                Next

                '--- End MainStock receive from Caritas update End of day
                'If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then



                '--- Process run end of day item used in current day
                For Each Upair In DicItemsUsedInDay

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans
                    Try
                        ' query by departID,ItemID,Date
                        'Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(cbDepart.SelectedValue) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        If q = False Then
                            ' Insert new item recieved in table tblEndofDayRun
                            Dim myUtblEndofDayRun As New tblEndofDayRun
                            myUtblEndofDayRun.RunEndOfDayDate = sysDate 'GetDateServer()
                            'myUtblEndofDayRun.DepartID = CInt(DEPART_ID)
                            myUtblEndofDayRun.DepartID = CInt(cbDepart.SelectedValue)
                            myUtblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                            myUtblEndofDayRun.ItemID = Val(Upair.Key)
                            myUtblEndofDayRun.RequestQty = 0
                            myUtblEndofDayRun.ReceivedQty = 0
                            myUtblEndofDayRun.AdjustQTY = 0
                            myUtblEndofDayRun.UseQty = DicItemsUsedInDay.Item(Upair.Key)

                            THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(myUtblEndofDayRun)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                            '====
                        Else ' In case item already exist in table tblEndofDayRun then modify recieved item quantity

                            Dim myUtblEndofDayRun As New tblEndofDayRun
                            'Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(cbDepart.SelectedValue) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            myUtblEndofDayRun = myEndofDayRun.SingleOrDefault
                            myUtblEndofDayRun.UseQty = DicItemsUsedInDay.Item(Upair.Key)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        End If
                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Catch ex As Exception
                        MsgBox("Error block count item use in department : " & ex.Message)
                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Finally
                        trans = Nothing
                    End Try
                Next


                '--- Process run of Day in for Adjust stok 
                For Each UpAdjust In DicItemAdjustInDay

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans
                    Try
                        ' query by departID,ItemID,Date
                        'Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(cbDepart.SelectedValue) And endofday.ItemID = CInt(UpAdjust.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        If q = False Then
                            ' Insert new item recieved in table tblEndofDayRun
                            Dim myUtblEndofDayRun As New tblEndofDayRun
                            myUtblEndofDayRun.RunEndOfDayDate = sysDate 'GetDateServer()
                            'myUtblEndofDayRun.DepartID = CInt(DEPART_ID)
                            myUtblEndofDayRun.DepartID = CInt(cbDepart.SelectedValue)
                            myUtblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                            myUtblEndofDayRun.ItemID = Val(UpAdjust.Key)
                            myUtblEndofDayRun.RequestQty = 0
                            myUtblEndofDayRun.ReceivedQty = 0
                            myUtblEndofDayRun.UseQty = 0
                            myUtblEndofDayRun.AdjustQTY = DicItemsUsedInDay.Item(UpAdjust.Key)

                            THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(myUtblEndofDayRun)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                            '====
                        Else ' In case item already exist in table tblEndofDayRun then modify recieved item quantity

                            Dim myUtblEndofDayRun As New tblEndofDayRun
                            'Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(cbDepart.SelectedValue) And endofday.ItemID = CInt(UpAdjust.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            myUtblEndofDayRun = myEndofDayRun.SingleOrDefault
                            myUtblEndofDayRun.AdjustQTY = DicItemsUsedInDay.Item(UpAdjust.Key)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        End If
                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Catch ex As Exception
                        MsgBox("Error block count item use in department : " & ex.Message)
                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Finally
                        trans = Nothing
                    End Try
                Next


                ' ======= Update BeginBalance and EndBalance of item in table tblEndofDayRun (fomular = UnitsInStock + UsedQTY - ReceivedQTY)==========
                'If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                If CInt(cbDepart.SelectedValue) = MAIN_STOCK_DEPART_ID Then
                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans

                    Try
                        'Dim lstrecEndofDayRun As List(Of tblEndofDayRun) = (From endofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofDayRun.DepartID = CInt(DEPART_ID) And endofDayRun.RunEndOfDayDate.Value.Date = sysDate).ToList
                        Dim lstrecEndofDayRun As List(Of tblEndofDayRun) = (From endofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofDayRun.DepartID = CInt(cbDepart.SelectedValue) And endofDayRun.RunEndOfDayDate.Value.Date = sysDate).ToList
                        If lstrecEndofDayRun.Count > 0 Then

                            For Each recEndofDayRun As tblEndofDayRun In lstrecEndofDayRun

                                '====== Getting particulart BeginBalance of item ======
                                'Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(DEPART_ID) And BBT.Date.Value.Date = sysDate And BBT.ItemID = recEndofDayRun.ItemID
                                Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(cbDepart.SelectedValue) And BBT.Date.Value.Date = sysDate And BBT.ItemID = recEndofDayRun.ItemID
                                Dim itemBeginBalance As Integer = qBeginBalance.SingleOrDefault.BeginBalanceOfDay

                                Dim updateEndofDayRun As New tblEndofDayRun
                                Dim q1 = From myEndofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where myEndofDayRun.RunEndOfDayID = recEndofDayRun.RunEndOfDayID
                                updateEndofDayRun = q1.SingleOrDefault

                                '====== Update EndBalance and BeginBalance of tbleEndofDayRun record ======
                                updateEndofDayRun.BeginBalance = itemBeginBalance
                                updateEndofDayRun.EndBalance = ((itemBeginBalance + updateEndofDayRun.ReceivedQty) + updateEndofDayRun.AdjustQTY) - (updateEndofDayRun.UseQty)
                                THIDataContext.getTHIDataContext.SubmitChanges()

                            Next
                        End If


                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        MessageBox.Show("Process run end of day successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetRunEndofDayByDepartIDandSpecificDate(CInt(DEPART_ID), sysDate)
                        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetRunEndofDayByDepartIDandSpecificDate(CInt(cbDepart.SelectedValue), sysDate)

                    Catch ex As Exception
                        MsgBox("Error block update table End-of-Day : " & ex.Message)
                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    End Try

                Else ' Department Stock

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans
                    Try
                        'Dim lstrecEndofDayRun As List(Of tblEndofDayRun) = (From endofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofDayRun.DepartID = CInt(DEPART_ID) And endofDayRun.RunEndOfDayDate.Value.Date = sysDate).ToList
                        Dim lstrecEndofDayRun As List(Of tblEndofDayRun) = (From endofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofDayRun.DepartID = CInt(cbDepart.SelectedValue) And endofDayRun.RunEndOfDayDate.Value.Date = sysDate).ToList
                        If lstrecEndofDayRun.Count > 0 Then

                            For Each recEndofDayRun As tblEndofDayRun In lstrecEndofDayRun

                                'Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(DEPART_ID) And BBT.Date.Value.Date = sysDate And BBT.ItemID = CInt(recEndofDayRun.ItemID)
                                Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(cbDepart.SelectedValue) And BBT.Date.Value.Date = sysDate And BBT.ItemID = CInt(recEndofDayRun.ItemID)
                                Dim itemBeginBalance As Integer = qBeginBalance.SingleOrDefault.BeginBalanceOfDay

                                Dim updateEndofDayRun As New tblEndofDayRun
                                Dim q1 = From myEndofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where myEndofDayRun.RunEndOfDayID = recEndofDayRun.RunEndOfDayID
                                updateEndofDayRun = q1.SingleOrDefault

                                '====== Update EndBalance and BeginBalance of tbleEndofDayRun record ======
                                updateEndofDayRun.BeginBalance = itemBeginBalance
                                updateEndofDayRun.EndBalance = ((itemBeginBalance + updateEndofDayRun.ReceivedQty) + updateEndofDayRun.AdjustQTY) - (updateEndofDayRun.UseQty)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Next
                        End If

                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        MessageBox.Show("Process run end of day successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetRunEndofDayByDepartIDandSpecificDate(CInt(DEPART_ID), sysDate)
                        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetRunEndofDayByDepartIDandSpecificDate(CInt(cbDepart.SelectedValue), sysDate)

                    Catch ex As Exception
                        MsgBox("Error block update table End-of-Day : " & ex.Message)
                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    End Try
                End If

                ''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''

            Else ' else of block chbAll = false -------------------------------------------------------------------------------------------------------------------------------

                Dim DepartTable As DataTable = DepartDataAdapter.GetData
                For Each row As DataRow In DepartTable.Rows
                    'row("DepartID")
                    'If ValidateCombobox(cbDepart, "", ErrorEOD) = False Then Exit Sub
                    'If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    ' Process summeries item request current day
                    Dim DicItemsRequestInDay As New Dictionary(Of String, Integer)
                    Dim DicItemsRecievedInDay As New Dictionary(Of String, Integer)
                    Dim DicItemsUsedInDay As New Dictionary(Of String, Integer)
                    Dim DicItemAdjustInDay As New Dictionary(Of String, Integer)
                    Dim DicCaritasItemsRequestInDay As New Dictionary(Of String, Integer)
                    Dim DicCaritasItemsRecievedInDay As New Dictionary(Of String, Integer)

                    Dim sysDate As Date = REDCalendar.SelectionEnd.Date
                    Dim mytblRequestList As List(Of tblRequest) = EndofDayRepo.GetRequestListByDate(sysDate, CInt(row("DepartID")))
                    Dim mytblRecievedList As List(Of tblReceived) = EndofDayRepo.GetRecievedListByDate(sysDate, CInt(row("DepartID")))
                    Dim mytblUsedList As List(Of tblUsed) = EndofDayRepo.GetUseListByDate(sysDate, CInt(row("DepartID")))
                    Dim mytblAdjustList As List(Of tblAdjustStockHistory) = EndofDayRepo.GetAdjustListByDate(sysDate, CInt(row("DepartID")))
                    ' Dim mytblReceivedCaritas As List(Of CARITAS_REQUEST_DETAIL_INVENTORY) = EndofDayRepo.getc

                    '--- Get Caristas request list
                    'If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                    If CInt(row("DepartID")) = MAIN_STOCK_DEPART_ID Then

                        Dim myCaritasReqList As List(Of CARITAS_REQUEST_INVENTORY) = EndofDayRepo.GetCaritasRequestListByDate(sysDate)
                        Dim myCaritasRecList As List(Of CARITAS_REQUEST_DETAIL_INVENTORY) = EndofDayRepo.GetReceivedCaritasBydate(sysDate)
                        If myCaritasReqList.Count > 0 Then
                            'DicCaritasItemsRequestInDay = EndofDayRepo.GetCaritasDicItemsInRequest(myCaritasReqList, False)
                            'DicCaritasItemsRecievedInDay = EndofDayRepo.GetReceivedDicItem(myCaritasRecList, sysDate) 'EndofDayRepo.GetCaritasDicItemsInRequest(myCaritasReqList, True)
                        End If
                        If myCaritasRecList.Count > 0 Then
                            DicCaritasItemsRecievedInDay = EndofDayRepo.GetReceivedDicItem(myCaritasRecList, sysDate)
                        End If
                    End If
                    '--- End Get Caristas request list


                    If mytblRequestList.Count > 0 Then
                        DicItemsRequestInDay = EndofDayRepo.GetDicItemsInRequest(mytblRequestList)
                    End If
                    If mytblRecievedList.Count > 0 Then
                        DicItemsRecievedInDay = EndofDayRepo.GetDicItemsInRecieved(mytblRecievedList)
                    End If
                    If mytblUsedList.Count > 0 Then
                        DicItemsUsedInDay = EndofDayRepo.GetDicItemsInUsed(mytblUsedList)
                    End If
                    If mytblAdjustList.Count > 0 Then
                        DicItemAdjustInDay = EndofDayRepo.GetDicItemsInAdjusted(mytblAdjustList)
                    End If
                    ' Incase user confuse process end of day but they have more Transaction to Add
                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim Deltrans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = Deltrans

                    'Try
                    'THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRun WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(DEPART_ID), sysDate)
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRun WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(row("DepartID")), sysDate)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    '--- Update table tblEndofDdayRunStatus
                    'THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRunStatus WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(DEPART_ID), sysDate)
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblEndofDayRunStatus WHERE DepartID={0} AND (CAST(CONVERT(VARCHAR(10), CAST(RunEndOfDayDate AS DATETIME), 1) AS Datetime))={1}", CInt(row("DepartID")), sysDate)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    Dim EndofDayRunStatus As New tblEndofDayRunStatus
                    'EndofDayRunStatus.DepartID = CInt(DEPART_ID)
                    EndofDayRunStatus.DepartID = CInt(row("DepartID"))
                    EndofDayRunStatus.RunEndOfDayDate = sysDate
                    EndofDayRunStatus.Status = 1

                    THIDataContext.getTHIDataContext.tblEndofDayRunStatus.InsertOnSubmit(EndofDayRunStatus)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    Deltrans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()

                    'Catch ex As Exception
                    '    MsgBox("Erorr in block delete data in table End-of-Day of current date: " & ex.Message)
                    '    Deltrans.Rollback()
                    '    THIDataContext.getTHIDataContext.Connection.Close()
                    'Finally
                    '    Deltrans = Nothing
                    'End Try


                    Dim pair As KeyValuePair(Of String, Integer)
                    '--- Incase some items request
                    For Each pair In DicItemsRequestInDay
                        ' Add all request items in current day run end of day transaction
                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans

                        'Try
                        Dim mytblEndofDayRun As New tblEndofDayRun
                        mytblEndofDayRun.RunEndOfDayDate = sysDate
                        'mytblEndofDayRun.DepartID = CInt(DEPART_ID)
                        mytblEndofDayRun.DepartID = CInt(row("DepartID"))
                        mytblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                        mytblEndofDayRun.ItemID = Val(pair.Key)
                        mytblEndofDayRun.RequestQty = pair.Value
                        mytblEndofDayRun.ReceivedQty = 0
                        mytblEndofDayRun.UseQty = 0
                        mytblEndofDayRun.AdjustQTY = 0


                        THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(mytblEndofDayRun)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                        '====
                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        'Catch ex As Exception
                        '    MsgBox("Error block count item request of other department : " & ex.Message)
                        '    trans.Rollback()
                        '    THIDataContext.getTHIDataContext.Connection.Close()
                        'Finally
                        '    trans = Nothing
                        'End Try
                    Next

                    '--- MainStock Request  to Caritas update End of day==================
                    '-------------

                    If CInt(row("DepartID")) = MAIN_STOCK_DEPART_ID Then

                        For Each pair In DicCaritasItemsRequestInDay
                            ' Add all request items in current day run end of day transaction
                            THIDataContext.getTHIDataContext.Connection.Close()
                            THIDataContext.getTHIDataContext.Connection.Open()
                            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                            THIDataContext.getTHIDataContext.Transaction = trans

                            'Try
                            'Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(DEPART_ID) And qEndofDay.RunEndOfDayDate = sysDate
                            Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(row("DepartID")) And qEndofDay.RunEndOfDayDate = sysDate
                            If q.ToList.Count = 0 Then
                                Dim mytblEndofDayRun As New tblEndofDayRun
                                mytblEndofDayRun.RunEndOfDayDate = sysDate
                                'mytblEndofDayRun.DepartID = CInt(DEPART_ID)
                                mytblEndofDayRun.DepartID = CInt(row("DepartID"))
                                mytblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                                mytblEndofDayRun.ItemID = Val(pair.Key)
                                mytblEndofDayRun.RequestQty = pair.Value
                                mytblEndofDayRun.ReceivedQty = 0
                                mytblEndofDayRun.UseQty = 0
                                mytblEndofDayRun.AdjustQTY = 0

                                THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(mytblEndofDayRun)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Else
                                Dim CurEndofDayRun As tblEndofDayRun = q.SingleOrDefault
                                CurEndofDayRun.RequestQty = CurEndofDayRun.RequestQty + pair.Value
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            End If

                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()

                            'Catch ex As Exception
                            '    MsgBox("Error block count item request to Caritas : " & ex.Message)
                            '    trans.Rollback()
                            '    THIDataContext.getTHIDataContext.Connection.Close()
                            'Finally
                            '    trans = Nothing
                            'End Try
                        Next
                    End If
                    '--- End MainStock request to Caritas update End of day

                    '---  MainStock Receive Item from Caritas update End of day

                    If CInt(row("DepartID")) = MAIN_STOCK_DEPART_ID Then

                        For Each pair In DicCaritasItemsRecievedInDay
                            ' Add all request items in current day run end of day transaction
                            THIDataContext.getTHIDataContext.Connection.Close()
                            THIDataContext.getTHIDataContext.Connection.Open()
                            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                            THIDataContext.getTHIDataContext.Transaction = trans

                            'Try
                            'Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(DEPART_ID) And qEndofDay.RunEndOfDayDate = sysDate
                            Dim q = From qEndofDay In THIDataContext.getTHIDataContext.tblEndofDayRuns Where qEndofDay.ItemID = Val(pair.Key) And qEndofDay.DepartID = CInt(row("DepartID")) And qEndofDay.RunEndOfDayDate = sysDate
                            If q.ToList.Count = 0 Then
                                Dim mytblEndofDayRun As New tblEndofDayRun
                                mytblEndofDayRun.RunEndOfDayDate = sysDate
                                'mytblEndofDayRun.DepartID = CInt(DEPART_ID)
                                mytblEndofDayRun.DepartID = CInt(row("DepartID"))
                                mytblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                                mytblEndofDayRun.ItemID = Val(pair.Key)
                                mytblEndofDayRun.RequestQty = 0
                                mytblEndofDayRun.ReceivedQty = pair.Value
                                mytblEndofDayRun.UseQty = 0
                                mytblEndofDayRun.AdjustQTY = 0

                                THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(mytblEndofDayRun)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Else
                                Dim CurEndofDayRun As tblEndofDayRun = q.SingleOrDefault
                                CurEndofDayRun.ReceivedQty = CurEndofDayRun.ReceivedQty + pair.Value
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            End If
                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()

                            'Catch ex As Exception
                            '    MsgBox("Error block count item receive from Caritas: " & ex.Message)
                            '    trans.Rollback()
                            '    THIDataContext.getTHIDataContext.Connection.Close()
                            'Finally
                            '    trans = Nothing
                            'End Try
                        Next
                    End If
                    '--- End MainStock receive from Caritas update End of day

                    '--- Incase some items recieved not exist in current request we have add
                    For Each Rpair In DicItemsRecievedInDay
                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans
                        'Try
                        ' query by departID,ItemID,Date
                        'Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(row("DepartID")) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        If q = False Then
                            ' Insert new item recieved in table tblEndofDayRun
                            Dim myRtblEndofDayRun As New tblEndofDayRun
                            myRtblEndofDayRun.RunEndOfDayDate = sysDate 'GetDateServer()
                            'myRtblEndofDayRun.DepartID = CInt(DEPART_ID)
                            myRtblEndofDayRun.DepartID = CInt(row("DepartID"))
                            myRtblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                            myRtblEndofDayRun.ItemID = Val(Rpair.Key)
                            myRtblEndofDayRun.RequestQty = 0
                            myRtblEndofDayRun.ReceivedQty = DicItemsRecievedInDay.Item(Rpair.Key)
                            myRtblEndofDayRun.UseQty = 0
                            myRtblEndofDayRun.AdjustQTY = 0

                            THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(myRtblEndofDayRun)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        Else ' In case item already exist in table tblEndofDayRun then modify recieved item quantity

                            Dim myRtblEndofDayRun As New tblEndofDayRun
                            'Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(row("DepartID")) And endofday.ItemID = CInt(Rpair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            myRtblEndofDayRun = myEndofDayRun.SingleOrDefault
                            myRtblEndofDayRun.ReceivedQty = DicItemsRecievedInDay.Item(Rpair.Key)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        End If

                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        'Catch ex As Exception
                        '    MsgBox("Error block count item receive from other department : " & ex.Message)
                        '    trans.Rollback()
                        '    THIDataContext.getTHIDataContext.Connection.Close()
                        'Finally
                        '    trans = Nothing
                        'End Try
                    Next


                    '--- Process run end of day item used in current day
                    For Each Upair In DicItemsUsedInDay

                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans
                        'Try
                        ' query by departID,ItemID,Date
                        'Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(row("DepartID")) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                        If q = False Then
                            ' Insert new item recieved in table tblEndofDayRun
                            Dim myUtblEndofDayRun As New tblEndofDayRun
                            myUtblEndofDayRun.RunEndOfDayDate = sysDate 'GetDateServer()
                            'myUtblEndofDayRun.DepartID = CInt(DEPART_ID)
                            myUtblEndofDayRun.DepartID = CInt(row("DepartID"))
                            myUtblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                            myUtblEndofDayRun.ItemID = Val(Upair.Key)
                            myUtblEndofDayRun.RequestQty = 0
                            myUtblEndofDayRun.ReceivedQty = 0
                            myUtblEndofDayRun.AdjustQTY = 0
                            myUtblEndofDayRun.UseQty = DicItemsUsedInDay.Item(Upair.Key)

                            THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(myUtblEndofDayRun)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                            '====
                        Else ' In case item already exist in table tblEndofDayRun then modify recieved item quantity

                            Dim myUtblEndofDayRun As New tblEndofDayRun
                            'Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(row("DepartID")) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                            myUtblEndofDayRun = myEndofDayRun.SingleOrDefault
                            myUtblEndofDayRun.UseQty = DicItemsUsedInDay.Item(Upair.Key)
                            THIDataContext.getTHIDataContext.SubmitChanges()

                        End If
                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()
                        'Catch ex As Exception
                        '    MsgBox("Error block count item use in department : " & ex.Message)
                        '    trans.Rollback()
                        '    THIDataContext.getTHIDataContext.Connection.Close()
                        'Finally
                        '    trans = Nothing
                        'End Try
                    Next

                    '--- Process run of Day in for Adjust stok 
                    For Each UpAdjust In DicItemAdjustInDay

                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans
                        Try
                            ' query by departID,ItemID,Date
                            'Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                            Dim q = (From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(row("DepartID")) And endofday.ItemID = CInt(UpAdjust.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate).Count()
                            If q = False Then
                                ' Insert new item recieved in table tblEndofDayRun
                                Dim myUtblEndofDayRun As New tblEndofDayRun
                                myUtblEndofDayRun.RunEndOfDayDate = sysDate 'GetDateServer()
                                'myUtblEndofDayRun.DepartID = CInt(DEPART_ID)
                                myUtblEndofDayRun.DepartID = CInt(row("DepartID"))
                                myUtblEndofDayRun.UserIDProcessRunEndOfDay = CInt(USER_ID)
                                myUtblEndofDayRun.ItemID = Val(UpAdjust.Key)
                                myUtblEndofDayRun.RequestQty = 0
                                myUtblEndofDayRun.ReceivedQty = 0
                                myUtblEndofDayRun.UseQty = 0
                                myUtblEndofDayRun.AdjustQTY = DicItemAdjustInDay.Item(UpAdjust.Key)

                                THIDataContext.getTHIDataContext.tblEndofDayRuns.InsertOnSubmit(myUtblEndofDayRun)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                                '====
                            Else ' In case item already exist in table tblEndofDayRun then modify recieved item quantity

                                Dim myUtblEndofDayRun As New tblEndofDayRun
                                'Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(DEPART_ID) And endofday.ItemID = CInt(Upair.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                                Dim myEndofDayRun = From endofday In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofday.DepartID = CInt(row("DepartID")) And endofday.ItemID = CInt(UpAdjust.Key) And endofday.RunEndOfDayDate.Value.Date = sysDate
                                myUtblEndofDayRun = myEndofDayRun.SingleOrDefault
                                myUtblEndofDayRun.AdjustQTY = DicItemAdjustInDay.Item(UpAdjust.Key)
                                THIDataContext.getTHIDataContext.SubmitChanges()

                            End If
                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        Catch ex As Exception
                            MsgBox("Error block count item use in department : " & ex.Message)
                            trans.Rollback()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        Finally
                            trans = Nothing
                        End Try
                    Next

                    ' ======= Update BeginBalance and EndBalance of item in table tblEndofDayRun (fomular = UnitsInStock + UsedQTY - ReceivedQTY)==========
                    'If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                    If CInt(row("DepartID")) = MAIN_STOCK_DEPART_ID Then
                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans

                        'Try
                        'Dim lstrecEndofDayRun As List(Of tblEndofDayRun) = (From endofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofDayRun.DepartID = CInt(DEPART_ID) And endofDayRun.RunEndOfDayDate.Value.Date = sysDate).ToList
                        Dim lstrecEndofDayRun As List(Of tblEndofDayRun) = (From endofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofDayRun.DepartID = CInt(row("DepartID")) And endofDayRun.RunEndOfDayDate.Value.Date = sysDate).ToList

                        If lstrecEndofDayRun.Count > 0 Then

                            For Each recEndofDayRun As tblEndofDayRun In lstrecEndofDayRun

                                '====== Getting particulart BeginBalance of item ======
                                'Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(DEPART_ID) And BBT.Date.Value.Date = sysDate And BBT.ItemID = recEndofDayRun.ItemID
                                Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(row("DepartID")) And BBT.Date.Value.Date = sysDate And BBT.ItemID = recEndofDayRun.ItemID
                                Dim itemBeginBalance As Integer
                                Try
                                    itemBeginBalance = qBeginBalance.SingleOrDefault.BeginBalanceOfDay
                                Catch ex As Exception
                                    itemBeginBalance = 0
                                End Try


                                Dim updateEndofDayRun As New tblEndofDayRun
                                Dim q1 = From myEndofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where myEndofDayRun.RunEndOfDayID = recEndofDayRun.RunEndOfDayID
                                updateEndofDayRun = q1.SingleOrDefault

                                '====== Update EndBalance and BeginBalance of tbleEndofDayRun record ======
                                updateEndofDayRun.BeginBalance = itemBeginBalance
                                updateEndofDayRun.EndBalance = ((itemBeginBalance + updateEndofDayRun.ReceivedQty) + updateEndofDayRun.AdjustQTY) - (updateEndofDayRun.UseQty)
                                'MsgBox(itemBeginBalance & " Item ID= " & recEndofDayRun.ItemID)
                                Threading.Thread.Sleep(100)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Next
                        End If


                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        'MessageBox.Show(row("DepartName") & ": Process run end of day successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(sysDate, sysDate)

                        'Catch ex As Exception
                        '    MsgBox("Error block update table End-of-Day : " & ex.Message)
                        '    trans.Rollback()
                        '    THIDataContext.getTHIDataContext.Connection.Close()
                        'End Try

                    Else ' Department Stock

                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans
                        'Try
                        Dim lstrecEndofDayRun As List(Of tblEndofDayRun) = (From endofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where endofDayRun.DepartID = CInt(row("DepartID")) And endofDayRun.RunEndOfDayDate.Value.Date = sysDate).ToList

                        If lstrecEndofDayRun.Count > 0 Then

                            For Each recEndofDayRun As tblEndofDayRun In lstrecEndofDayRun

                                'Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(DEPART_ID) And BBT.Date.Value.Date = sysDate And BBT.ItemID = CInt(recEndofDayRun.ItemID)
                                Dim qBeginBalance = From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.DepartID = CInt(row("DepartID")) And BBT.Date.Value.Date = sysDate And BBT.ItemID = CInt(recEndofDayRun.ItemID)
                                Dim itemBeginBalance As Integer
                                Try
                                    itemBeginBalance = qBeginBalance.SingleOrDefault.BeginBalanceOfDay

                                Catch ex As Exception
                                    itemBeginBalance = 0
                                End Try


                                Dim updateEndofDayRun As New tblEndofDayRun
                                Dim q1 = From myEndofDayRun In THIDataContext.getTHIDataContext.tblEndofDayRuns Where myEndofDayRun.RunEndOfDayID = recEndofDayRun.RunEndOfDayID
                                updateEndofDayRun = q1.SingleOrDefault

                                '====== Update EndBalance and BeginBalance of tbleEndofDayRun record ======
                                updateEndofDayRun.BeginBalance = itemBeginBalance
                                updateEndofDayRun.EndBalance = ((itemBeginBalance + updateEndofDayRun.ReceivedQty) + updateEndofDayRun.AdjustQTY) - (updateEndofDayRun.UseQty)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Next
                        End If

                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        'MessageBox.Show(row("DepartName") & ": Process run end of day successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(sysDate, sysDate)

                        'Catch ex As Exception
                        '    MsgBox("Error block update table End-of-Day : " & ex.Message)
                        '    trans.Rollback()
                        '    THIDataContext.getTHIDataContext.Connection.Close()
                        'End Try
                    End If

                Next
            End If
            'End If
            End If
    End Sub

    Private Sub BgLoadingRunEOD_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingRunEOD.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
        Try
            MenuReceivedAll.Enabled = True
        Catch ex As Exception

        End Try
        Try
            MenuReadyInOT.Enabled = True
        Catch ex As Exception

        End Try
        MessageBox.Show("Process run end of day successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

   
    Public Sub BtnEndofDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEndofDay.Click
        'If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        If BgLoadingRunEOD.IsBusy = True Then
            BgLoadingRunEOD.CancelAsync()
        Else
            BgLoadingRunEOD.RunWorkerAsync()
        End If
        'End If
    End Sub


    Private Sub ChBAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAll.CheckedChanged
        cbDepart.Enabled = Not (ChBAll.Checked)

    End Sub


    Private Sub ChBAllS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllS.CheckedChanged
        cbDepartS.Enabled = Not (ChBAllS.Checked)
    End Sub

    
End Class
