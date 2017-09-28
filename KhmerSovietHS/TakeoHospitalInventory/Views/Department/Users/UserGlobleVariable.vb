Imports System.Data.OleDb

Module UserGlobleVariable

    Public MenuReadyInOT As ToolStripMenuItem
    Public MenuReceivedAll As ToolStripButton
    Public USER_NAME As String
    'Public PASSWORD As String
    Public USER_ID As String
    Public USER_PWD As String
    Public DEPART_ID As String
    Public DEPART_NAME As String
    Public EMPLOYEE_NAME As String
    Public EX_RATE As Double = 4000

    '************* inventory department id *************
    Public MAIN_STOCK_DEPART_ID As Integer '= 26
    Public PHARMACY_DEPART_ID As Integer '= 3
    Public OPTICALSHOP_DEPART_ID As Integer '= 28
    '***************************************************

    '--- REQUEST STATUS ID CONFIGURATION
    Public OPEN As Integer '= 1
    Public SENT As Integer '= 2
    Public RESPONSE As Integer '= 6
    Public RECEIVED As Integer '= 7

    '--- RESPONSE STATUS ID CONFIGURATION
    Public APPROVED As Integer '= 4


    Public Function GetAllDayInWeek() As Date()

        Dim daydiff(6) As Integer
        Dim dayInWeek(6) As Date
        Dim currentDayofWeek(6) As Date

        Dim iterator As Integer
        For iterator = 0 To 6
            Select Case iterator
                Case 0
                    daydiff(iterator) = Today.DayOfWeek - DayOfWeek.Monday
                    currentDayofWeek(iterator) = Today.AddDays(-daydiff(iterator))
                Case 1
                    daydiff(iterator) = Today.DayOfWeek - DayOfWeek.Tuesday
                    currentDayofWeek(iterator) = Today.AddDays(-daydiff(iterator))
                Case 2
                    daydiff(iterator) = Today.DayOfWeek - DayOfWeek.Wednesday
                    currentDayofWeek(iterator) = Today.AddDays(-daydiff(iterator))
                Case 3
                    daydiff(iterator) = Today.DayOfWeek - DayOfWeek.Thursday
                    currentDayofWeek(iterator) = Today.AddDays(-daydiff(iterator))
                Case 4
                    daydiff(iterator) = Today.DayOfWeek - DayOfWeek.Friday
                    currentDayofWeek(iterator) = Today.AddDays(-daydiff(iterator))
                Case 5
                    daydiff(iterator) = Today.DayOfWeek - DayOfWeek.Saturday
                    currentDayofWeek(iterator) = Today.AddDays(-daydiff(iterator))
                Case 6
                    daydiff(iterator) = Today.DayOfWeek - DayOfWeek.Sunday
                    currentDayofWeek(iterator) = Today.AddDays(-daydiff(iterator))
            End Select
        Next

        Return currentDayofWeek
    End Function

    Public Function Get6aftercurrentDay() As Date()

        Dim day6beforeToday(6) As Date
        day6beforeToday(0) = GetDateServer().Date
        day6beforeToday(1) = GetDateServer().AddDays(-1).Date
        day6beforeToday(2) = GetDateServer().AddDays(-2).Date
        day6beforeToday(3) = GetDateServer().AddDays(-3).Date
        day6beforeToday(4) = GetDateServer().AddDays(-4).Date
        day6beforeToday(5) = GetDateServer().AddDays(-5).Date
        day6beforeToday(6) = GetDateServer().AddDays(-6).Date
        Return day6beforeToday
    End Function
    Public Function FillDataSet(ByRef pDataSet As DataSet, ByVal pCommandText As String, ByVal pTableName As String) As String
        Try
            Dim myConnection As New OleDbConnection("Provider=SQLOLEDB;" & Global.TakeoHospitalInventory.My.MySettings.Default.TakeoDBConnectionString)
            Dim myCommand As New OleDbCommand
            Dim myDataAdapter As New OleDbDataAdapter
            'MsgBox(Global.TakeoHospitalInventory.My.MySettings.Default.TakeoInventoryConnectionString)
            myCommand.Connection = myConnection
            myCommand.CommandText = pCommandText
            myDataAdapter.SelectCommand = myCommand
            If pDataSet.Tables.Contains(pTableName) = True Then
                pDataSet.Tables.Remove(pTableName)
            End If
            myDataAdapter.Fill(pDataSet, pTableName)
            Return "TRUE"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Module
