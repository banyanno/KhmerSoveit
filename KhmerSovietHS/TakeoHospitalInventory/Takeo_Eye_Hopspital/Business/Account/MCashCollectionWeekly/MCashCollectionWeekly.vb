Module MCashCollectionWeekly

    Dim generalDAO As New GeneralDAO

    Function WeeklyCashCollection(ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "SELECT CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) AS DateIn, " _
            & " SUM(CashUSD) AS CashUSD, SUM(CashRiel) AS CashRiel," _
            & " SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) AS OutPatientUSD," _
            & " SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) AS OutPatientRiel," _
            & " SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeRiel) AS InPatientUSD," _
            & " SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeUSD) AS InPatientRiel, SUM(GlassFeeUSD) AS GlassFeeUSD," _
            & " SUM(GlassFeeRiel) AS GlassFeeRiel, SUM(ArtificialEyeFeeUSD) AS ArtificialEyeFeeUSD, " _
            & " SUM(ArtificialEyeFeeRiel) AS ArtificialEyeFeeRiel, SUM(OtherFeeUSD) AS OtherFeeUSD, SUM(OtherFeeRiel) AS OtherFeeRiel,SUM(MedicineFeeUSD) AS MediceUSD,SUM(MedicineFeeRiel) AS MediceRIEL " _
            & " FROM tblPatientReceipt Where IsPatientNill=0 AND CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "' and ConPay='1' and ConDelete='0'" _
            & " GROUP BY CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) ORDER BY DateIn ASC"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function IncomeSummary(ByVal DateIn As Date) As DataTable
        Dim Sql As String = "SELECT     SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) AS OutPatientUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) AS OutpatientRiel, " _
                      & " SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) AS InpatientUSD, SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) AS InpatientRiel, " _
                      & " SUM(GlassFeeUSD) AS GlassUSD, SUM(GlassFeeRiel) AS GlassRiel, SUM(MedicineFeeUSD) AS MedicineUSD, " _
                      & " SUM(MedicineFeeRiel) AS MedicineRiel,SUM(OtherFeeUSD) AS FeeUSD,SUM(OtherFeeRiel) AS FeeRIEL, SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) + SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) " _
                      & " + SUM(OtherFeeUSD) + SUM(GlassFeeUSD) + SUM(MedicineFeeUSD) AS TotalUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) " _
                      & " + SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) + SUM(OtherFeeRiel) + SUM(GlassFeeRiel) + SUM(MedicineFeeRiel) AS TotalRiel FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) ='" & DateIn & "' and ConPay='1' and ConDelete='0'"
        Return generalDAO.SelectDAOAsDataTatable(Sql)
    End Function

    Function DailyRemarks(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT tblAccountName.AccountName AS AccountName, tblAccountAmount.AmountUSD AS AmountUSD, tblAccountAmount.AmountRiel AS AmountRiel" _
                            & " FROM tblAccountAmount INNER JOIN tblAccountName ON tblAccountAmount.AID = tblAccountName.AID" _
                            & " Where CAST(CONVERT(VARCHAR(10), tblAccountAmount.DateIn, 1) AS DateTime) ='" & DateIn & "'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function TotalDailyRemarks(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT SUM(AmountUSD) AS USD, SUM(AmountRiel) as RIEL from tblAccountAmount" _
                            & " Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) ='" & DateIn & "'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Sub SaveCashCount(ByVal US100X As String, ByVal US100 As Integer, ByVal US100T As Long, _
                            ByVal US50X As String, ByVal US50 As Integer, ByVal US50T As Long, _
                            ByVal US20X As String, ByVal US20 As Integer, ByVal US20T As Long, _
                            ByVal US10X As String, ByVal US10 As Integer, ByVal US10T As Long, _
                            ByVal US5X As String, ByVal US5 As Integer, ByVal US5T As Long, _
                            ByVal US1X As String, ByVal US1 As Integer, ByVal US1T As Long, ByVal TotalUSD As Long, _
                            ByVal R100000X As String, ByVal R100000 As Integer, ByVal R100000T As Long, _
                            ByVal R50000X As String, ByVal R50000 As Integer, ByVal R50000T As Long, _
                            ByVal R20000X As String, ByVal R20000 As Integer, ByVal R20000T As Long, _
                            ByVal R10000X As String, ByVal R10000 As Integer, ByVal R10000T As Long, _
                            ByVal R5000X As String, ByVal R5000 As Integer, ByVal R5000T As Long, _
                            ByVal R2000X As String, ByVal R2000 As Integer, ByVal R2000T As Long, _
                            ByVal R1000X As String, ByVal R1000 As Integer, ByVal R1000T As Long, _
                            ByVal R500X As String, ByVal R500 As Integer, ByVal R500T As Long, _
                            ByVal R100X As String, ByVal R100 As Integer, ByVal R100T As Long, _
                            ByVal R50X As String, ByVal R50 As Integer, ByVal R50T As Long, ByVal TotalRIEL As Long, _
                            ByVal DateIn As Date, ByVal Users As String)
        Try
            generalDAO.InsertDAO("Insert Into tblCashCount (US100X, US100, US100T, US50X, US50, US50T, US20X," _
                                & " US20, US20T, US10X, US10, US10T, US5X, US5, US5T, US1X, US1, US1T, TotalUSD, R100000X," _
                                & " R100000, R100000T, R50000X, R50000, R50000T, R20000X, R20000, R20000T, R10000X," _
                                & " R10000, R10000T, R5000X, R5000, R5000T, R2000X,R2000, R2000T, R1000X, R1000," _
                                & " R1000T, R500X, R500, R500T, R100X, R100, R100T, R50X, R50, R50T, TotalRIEL, DateIn, Users)" _
                                & " values('" & US100X & "'," & US100 & "," & US100T & ",'" _
                                & US50X & "'," & US50 & "," & US50T & ",'" _
                                & US20X & "'," & US20 & "," & US20T & ",'" _
                                & US10X & "'," & US10 & "," & US10T & ",'" _
                                & US5X & "'," & US5 & "," & US5T & ",'" _
                                & US1X & "'," & US1 & "," & US1T & "," & TotalUSD & ",'" _
                                & R100000X & "'," & R100000 & "," & R100000T & ",'" _
                                & R50000X & "'," & R50000 & "," & R50000T & ",'" _
                                & R20000X & "'," & R20000 & "," & R20000T & ",'" _
                                & R10000X & "'," & R10000 & "," & R10000T & ",'" _
                                & R5000X & "'," & R5000 & "," & R5000T & ",'" _
                                & R2000X & "'," & R2000 & "," & R2000T & ",'" _
                                & R1000X & "'," & R1000 & "," & R1000T & ",'" _
                                & R500X & "'," & R500 & "," & R500T & ",'" _
                                & R100X & "'," & R100 & "," & R100T & ",'" _
                                & R50X & "'," & R50 & "," & R50T & "," & TotalRIEL & ",'" _
                                & DateIn & "','" & Users & "')")
            MsgBox("Insert cash count successfully", MsgBoxStyle.OkOnly, "Cash Count")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Function CheckCashCount(ByVal DateIn As Date) As Boolean
        Try
            Dim sqlHN = "Select ID FROM tblCashCount WHERE CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime)='" & DateIn & "'"
            Dim totalRow As Integer = generalDAO.SelectDAOAsDataTatable(sqlHN).Rows.Count
            If totalRow = 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Function

    Public Sub UpdateCashCount(ByVal US100X As String, ByVal US100 As Integer, ByVal US100T As Long, _
                            ByVal US50X As String, ByVal US50 As Integer, ByVal US50T As Long, _
                            ByVal US20X As String, ByVal US20 As Integer, ByVal US20T As Long, _
                            ByVal US10X As String, ByVal US10 As Integer, ByVal US10T As Long, _
                            ByVal US5X As String, ByVal US5 As Integer, ByVal US5T As Long, _
                            ByVal US1X As String, ByVal US1 As Integer, ByVal US1T As Long, ByVal TotalUSD As Long, _
                            ByVal R100000X As String, ByVal R100000 As Integer, ByVal R100000T As Long, _
                            ByVal R50000X As String, ByVal R50000 As Integer, ByVal R50000T As Long, _
                            ByVal R20000X As String, ByVal R20000 As Integer, ByVal R20000T As Long, _
                            ByVal R10000X As String, ByVal R10000 As Integer, ByVal R10000T As Long, _
                            ByVal R5000X As String, ByVal R5000 As Integer, ByVal R5000T As Long, _
                            ByVal R2000X As String, ByVal R2000 As Integer, ByVal R2000T As Long, _
                            ByVal R1000X As String, ByVal R1000 As Integer, ByVal R1000T As Long, _
                            ByVal R500X As String, ByVal R500 As Integer, ByVal R500T As Long, _
                            ByVal R100X As String, ByVal R100 As Integer, ByVal R100T As Long, _
                            ByVal R50X As String, ByVal R50 As Integer, ByVal R50T As Long, ByVal TotalRIEL As Long, _
                            ByVal DateIn As Date, ByVal Users As String, ByVal DateUpdate As Date)
        Try
            generalDAO.UpdateDAO("Update tblCashCount set US100X='" & US100X & "', US100=" & US100 & ", US100T=" & US100T & "," _
                                & " US50X='" & US50X & "', US50=" & US50 & ", US50T=" & US50T & "," _
                                & " US20X='" & US20X & "', US20=" & US20 & ", US20T=" & US20T & "," _
                                & " US10X='" & US10X & "', US10=" & US10 & ", US10T=" & US10T & "," _
                                & " US5X='" & US5X & "', US5=" & US5 & ", US5T=" & US5T & "," _
                                & " US1X='" & US1X & "', US1=" & US1 & ", US1T=" & US1T & ", TotalUSD=" & TotalUSD & "," _
                                & " R100000X='" & R100000X & "', R100000=" & R100000 & ", R100000T=" & R100000T & "," _
                                & " R50000X='" & R50000X & "', R50000=" & R50000 & ", R50000T=" & R50000T & "," _
                                & " R20000X='" & R20000X & "', R20000=" & R20000 & ", R20000T=" & R20000T & "," _
                                & " R10000X='" & R10000X & "',R10000=" & R10000 & ", R10000T=" & R10000T & "," _
                                & " R5000X='" & R5000X & "', R5000=" & R5000 & ", R5000T=" & R5000T & "," _
                                & " R2000X='" & R2000X & "',R2000=" & R2000 & ", R2000T=" & R2000T & "," _
                                & " R1000X='" & R1000X & "', R1000=" & R1000 & ", R1000T=" & R1000T & "," _
                                & " R500X='" & R500X & "', R500=" & R500 & ", R500T=" & R500T & "," _
                                & " R100X='" & R100X & "', R100=" & R100 & ", R100T=" & R100T & "," _
                                & " R50X='" & R50X & "', R50=" & R50 & ", R50T=" & R50T & ", TotalRIEL=" & TotalRIEL & "," _
                                & " DateIn='" & DateIn & "', Users='" & Users & "', DateUpdate='" & DateUpdate & "'")
            MsgBox("Update cash count successfully", MsgBoxStyle.OkOnly, "Cash Count")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Function SelectCashCountWeekly(ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "SELECT CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) AS DateIn, US100, US50," _
                                & " US20, US10, US5, US1," _
                                & " R100000, R50000, R20000," _
                                & " R10000,R5000,R2000,R1000," _
                                & " R500, R100, R50 from tblCashCount Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "' Order by DateIn ASC"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectCashCountWeeklyTotal(ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "SELECT SUM(US100)*100 AS US100, SUM(US50)*50 AS US50," _
                                & " SUM(US20)*20 AS US20, SUM(US10)*10 AS US10, SUM(US5)*5 AS US5, SUM(US1)*1 AS US1," _
                                & " SUM(R100000)*100000 AS R100000, SUM(R50000)*50000 AS R50000, SUM(R20000)*20000 AS R20000," _
                                & " SUM(R10000)*10000 AS R10000, SUM(R5000)*5000 AS R5000, SUM(R2000)*2000 AS R2000, SUM(R1000)*1000 AS R1000," _
                                & " SUM(R500)*500 AS R500, SUM(R100)*100 AS R100, SUM(R50)*50 AS R50 from tblCashCount Where " _
                                & " CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectCashCountWeeklyTotalAll(ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "SELECT SUM(US100)*100 + SUM(US50)*50 +" _
                                & " SUM(US20)*20 + SUM(US10)*10 + SUM(US5)*5 + SUM(US1)*1 AS US," _
                                & " SUM(R100000)*100000 + SUM(R50000)*50000 + SUM(R20000)*20000 +" _
                                & " SUM(R10000)*10000 + SUM(R5000)*5000 + SUM(R2000)*2000 + SUM(R1000)*1000 +" _
                                & " SUM(R500)*500 + SUM(R100)*100 + SUM(R50)*50 AS RIEL from tblCashCount Where " _
                                & " CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectCashCountWeeklyTotalAllFinal(ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "SELECT SUM(US100)*100 + SUM(US50)*50 +" _
                                & " SUM(US20)*20 + SUM(US10)*10 + SUM(US5)*5 + SUM(US1)*1 AS US," _
                                & " SUM(R100000)*100000 + SUM(R50000)*50000 + SUM(R20000)*20000 +" _
                                & " SUM(R10000)*10000 + SUM(R5000)*5000 + SUM(R2000)*2000 + SUM(R1000)*1000 +" _
                                & " SUM(R500)*500 + SUM(R100)*100 + SUM(R50)*50 AS RIEL from tblCashCount Where " _
                                 & " CAST(CONVERT(VARCHAR(10), DateIn, 1) as DateTime) BETWEEN " & _
                                    " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                                    " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function TotalDailyRemarksWeekly(ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "SELECT SUM(AmountUSD) AS USD, SUM(AmountRiel) as RIEL from tblAccountAmount" _
                            & " Where " _
                             & " CAST(CONVERT(VARCHAR(10), DateIn, 1) as DateTime) BETWEEN " & _
                                 " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                                " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function WeeklyRemarks(ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "SELECT tblAccountName.AccountName AS AccountName, SUM(tblAccountAmount.AmountUSD) AS AmountUSD, SUM(tblAccountAmount.AmountRiel) AS AmountRiel" _
                            & " FROM tblAccountAmount INNER JOIN tblAccountName ON tblAccountAmount.AID = tblAccountName.AID" _
                            & " Where   CAST(CONVERT(VARCHAR(10), tblAccountAmount.DateIn, 1) as DateTime) BETWEEN " & _
                                " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                                " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) " _
                            & " GROUP BY AccountName"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function ReportCashFlow(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetCashCollectionWeekly
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT CAST(CONVERT(VARCHAR(10), DateIn, 1) as DateTime) AS DateIn, SUM(CashUSD) AS CashUSD, SUM(CashRiel) AS CashRiel," _
                        & " SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) AS OutPatientUSD," _
                        & " SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) AS OutPatientRiel," _
                        & " SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) AS InPatientUSD," _
                        & " SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) AS InPatientRiel, SUM(GlassFeeUSD) AS GlassFeeUSD," _
                        & " SUM(GlassFeeRiel) AS GlassFeeRiel, SUM(ArtificialEyeFeeUSD) AS ArtificialEyeFeeUSD, " _
                        & " SUM(ArtificialEyeFeeRiel) AS ArtificialEyeFeeRiel, SUM(OtherFeeUSD) AS OtherFeeUSD, SUM(OtherFeeRiel) AS OtherFeeRiel,SUM(MedicineFeeUSD) AS MediceUSD,SUM(MedicineFeeRiel) AS MediceRIEL " _
                        & " FROM tblPatientReceipt Where IsPatientNill=0 AND " _
                          & "CAST(CONVERT(VARCHAR(10), DateIn, 1) as DateTime) BETWEEN " & _
                                " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                                " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) " _
                        & " and ConPay='1' and ConDelete='0' GROUP BY CAST(CONVERT(VARCHAR(10), DateIn, 1) as DateTime) ORDER BY DateIn"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

    End Function

    Public Function ReportCashCount(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetCashCount
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT CAST(CONVERT(VARCHAR(10), DateIn, 1) as DateTime) AS DateIn, US100, US50," _
                & " US20, US10, US5, US1," _
                & " R100000, R50000, R20000," _
                & " R10000,R5000,R2000,R1000," _
                & " R500, R100, R50 from tblCashCount Where " _
                & " CAST(CONVERT(VARCHAR(10), DateIn, 1) as DateTime) BETWEEN " & _
                    " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                    " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) " _
                & " Order by DateIn ASC"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

    End Function

    Public Function ReportCashRemarks(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetRemarks
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT tblAccountName.AccountName AS AccountName," _
                & " SUM(tblAccountAmount.AmountUSD) AS AmountUSD, SUM(tblAccountAmount.AmountRiel) AS AmountRiel FROM " _
                & " tblAccountAmount INNER JOIN tblAccountName ON tblAccountAmount.AID = tblAccountName.AID" _
                & " Where " _
                & "CAST(CONVERT(VARCHAR(10), tblAccountAmount.DateIn, 1) as DateTime) BETWEEN " & _
                    " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                    " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) " _
                    & " GROUP BY tblAccountName.AccountName"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

    End Function

End Module
