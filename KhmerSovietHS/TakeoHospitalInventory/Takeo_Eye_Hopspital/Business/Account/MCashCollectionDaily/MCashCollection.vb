Module MCashCollection

    Dim generalDAO As New GeneralDAO

    Function DailyCashCollection(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT HN, ReceiptNo, CashUSD, CashRiel, ConsultationFeeUSD," _
            & " ConsultationFeeRiel, FollowUpFeeUSD, FollowUpFeeRiel, OperationFeeUSD," _
            & " OperationFeeRiel, ArtificialEyeFeeUSD, ArtificialEyeFeeRiel, OtherFeeUSD, OtherFeeRiel," _
            & " MedicineFeeUSD, MedicineFeeRiel, GlassFeeUSD,GlassFeeRiel FROM tblPatientReceipt" _
            & " Where IsPatientNill=0 AND CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) and ConPay='1' and ConDelete='0'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function IncomeSummary(ByVal DateIn As Date) As DataTable
        Dim Sql As String = "SELECT     SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) AS OutPatientUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) AS OutpatientRiel, " _
                      & " SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) AS InpatientUSD, SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) AS InpatientRiel, " _
                      & " SUM(GlassFeeUSD) AS GlassUSD, SUM(GlassFeeRiel) AS GlassRiel, SUM(MedicineFeeUSD) AS MedicineUSD, " _
                      & " SUM(MedicineFeeRiel) AS MedicineRiel,SUM(OtherFeeUSD) AS FeeUSD,SUM(OtherFeeRiel) AS FeeRIEL, SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) + SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) " _
                      & " + SUM(OtherFeeUSD) + SUM(GlassFeeUSD) + SUM(MedicineFeeUSD) AS TotalUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) " _
                      & " + SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) + SUM(OtherFeeRiel) + SUM(GlassFeeRiel) + SUM(MedicineFeeRiel) AS TotalRiel FROM tblPatientReceipt Where IsPatientNill=0 AND CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) and ConPay='1' and ConDelete='0'"
        Return generalDAO.SelectDAOAsDataTatable(Sql)
    End Function

    Function DailyRemarks(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT tblAccountName.AccountName AS AccountName, tblAccountAmount.AmountUSD AS AmountUSD, tblAccountAmount.AmountRiel AS AmountRiel" _
                            & " FROM tblAccountAmount INNER JOIN tblAccountName ON tblAccountAmount.AID = tblAccountName.AID" _
                            & " Where  CAST(CONVERT(VARCHAR(10), tblAccountAmount.DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) "
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function TotalDailyRemarks(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT SUM(AmountUSD) AS USD, SUM(AmountRiel) as RIEL from tblAccountAmount" _
                            & " Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime)"
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
    Sub SaveDiallyRemarkNote(ByVal DateRemark As Date, ByVal Remarks As String)
        generalDAO.InsertDAO("INSERT INTO CASH_REMARK_COLLECTION (RemarkDate,Remarks) VALUES('" & DateRemark & "','" & Remarks.Replace("'", "") & "')")
    End Sub
    Sub UpdateDaillyRemarkNote(ByVal RemarkID As Integer, ByVal Remarks As String)
        generalDAO.UpdateDAO("UPDATE CASH_REMARK_COLLECTION SET Remarks='" & Remarks.Replace("'", "") & "' WHERE RemarkID=" & RemarkID)
    End Sub
    Function SelectRemarksNote(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT RemarkID,RemarkDate, Remarks FROM CASH_REMARK_COLLECTION WHERE RemarkDate='" & DateIn & "'"

        '"SELECT tblAccountName.AccountName AS AccountName, tblAccountAmount.AmountUSD AS AmountUSD, tblAccountAmount.AmountRiel AS AmountRiel" _
        '                            & " FROM tblAccountAmount INNER JOIN tblAccountName ON tblAccountAmount.AID = tblAccountName.AID" _
        '                            & " Where  CAST(CONVERT(VARCHAR(10), tblAccountAmount.DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) "
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function CheckCashCount(ByVal DateIn As Date) As Boolean
        Try
            Dim sqlHN = "Select ID FROM tblCashCount WHERE CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime)"
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
                                & " DateIn='" & DateIn & "', Users='" & Users & "', DateUpdate='" & DateUpdate & "' Where DateIn='" & DateIn & "'")
            MsgBox("Update cash count successfully", MsgBoxStyle.OkOnly, "Cash Count")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Function ReportCashFlowDaily(ByVal DateFrom As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetCashCountDaily
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT  HN, ReceiptNo, CONVERT(VARCHAR(11),DateIn,106) AS DateIn, CashUSD AS CashUSD, CashRiel AS CashRiel," _
                        & " ConsultationFeeUSD + FollowUpFeeUSD AS OutPatientUSD," _
                        & " ConsultationFeeRiel + FollowUpFeeRiel AS OutPatientRiel," _
                        & " OperationFeeUSD  AS InPatientUSD," _
                        & " OperationFeeRiel AS InPatientRiel, GlassFeeUSD AS GlassFeeUSD," _
                        & " GlassFeeRiel AS GlassFeeRiel, ArtificialEyeFeeUSD AS ArtificialEyeFeeUSD, " _
                        & " ArtificialEyeFeeRiel AS ArtificialEyeFeeRiel,MedicineFeeRiel,MedicineFeeUSD, OtherFeeUSD AS OtherFeeUSD, OtherFeeRiel AS OtherFeeRiel" _
                        & " FROM tblPatientReceipt Where IsPatientNill=0 AND CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
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

    Public Function ReportCashCountDaily(ByVal DateFrom As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetCashCountNumber
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT CONVERT(VARCHAR(11),DateIn,106) AS DateIn, US100, US100T, US50, US50T," _
                & " US20, US20T, US10, US10T, US5, US5T, US1, US1T," _
                & " R100000, R100000T, R50000, R50000T, R20000, R20000T," _
                & " R10000, R10000T,R5000, R5000T,R2000, R2000T,R1000, R1000T," _
                & " R500, R500T, R100, R100T, R50, R50T from tblCashCount Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) Order by DateIn ASC"
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

    Public Function ReportCashRemarksDaily(ByVal DateFrom As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetRemarksDaily
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT tblAccountName.AccountName AS AccountName," _
                & " tblAccountAmount.AmountUSD AS AmountUSD, tblAccountAmount.AmountRiel AS AmountRiel FROM " _
                & " tblAccountAmount INNER JOIN tblAccountName ON tblAccountAmount.AID = tblAccountName.AID" _
                & " Where CAST(CONVERT(VARCHAR(10), tblAccountAmount.DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime)"
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

    Public Function ReportIncomeSummaryDaily(ByVal DateFrom As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetIncomeSummary
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Dim sql1 As String = "SELECT" _
                   & " SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) AS OutPatientUSD," _
                   & " SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) AS OutpatientRiel, " _
                   & " SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) AS InpatientUSD, " _
                   & " SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) AS InpatientRiel, " _
                   & " SUM(GlassFeeUSD) AS GlassUSD, " _
                   & " SUM(GlassFeeRiel) AS GlassRiel, " _
                   & " SUM(ArtificialEyeFeeUSD) AS ArtificialEyeFeeUSD, " _
                   & " SUM(ArtificialEyeFeeRiel) AS ArtificialEyeFeeRiel, " _
                   & " SUM(OtherFeeUSD) AS FeeUSD, " _
                   & " SUM(OtherFeeRiel) AS FeeRIEL," _
                   & " SUM(MedicineFeeUSD) AS MediceUSD, " _
                   & " SUM(MedicineFeeRiel) AS MediceRIEL, " _
                   & " SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) + SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) + SUM(OtherFeeUSD) + SUM(GlassFeeUSD) + SUM(MedicineFeeUSD) AS TotalUSD, " _
                   & " SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) + SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) + SUM(OtherFeeRiel)+ SUM(GlassFeeRiel) + SUM(MedicineFeeRiel) AS TotalRiel" _
                   & " FROM tblPatientReceipt Where IsPatientNill=0 AND CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) and ConPay='1' and ConDelete='0'"
            'Sql = "SELECT     SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) AS OutPatientUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) AS OutpatientRiel, " _
            '          & " SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) AS InpatientUSD, SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) AS InpatientRiel, " _
            '          & " SUM(GlassFeeUSD) AS GlassUSD, SUM(GlassFeeRiel) AS GlassRiel, SUM(ArtificialEyeFeeUSD) AS ArtificialEyeFeeUSD, " _
            '          & " SUM(ArtificialEyeFeeRiel) AS ArtificialEyeFeeRiel,SUM(OtherFeeUSD) AS FeeUSD,SUM(OtherFeeRiel) AS FeeRIEL, SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) + SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) " _
            '          & " + SUM(OtherFeeUSD) + SUM(GlassFeeUSD) + SUM(MedicineFeeUSD) AS TotalUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel),SUM(MedicineFeeUSD) AS MediceUSD,SUM(MedicineFeeRiel) AS MediceRIEL, " _
            '          & " + SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) + SUM(OtherFeeRiel) + SUM(GlassFeeRiel) + SUM(MedicineFeeRiel) AS TotalRiel FROM tblPatientReceipt Where IsPatientNill=0 AND CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) and ConPay='1' and ConDelete='0'"
            SqlCom.CommandText = Sql1
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

    End Function

    Function SelectCashCount(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT * from tblCashCount Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) =CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime)"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

End Module
