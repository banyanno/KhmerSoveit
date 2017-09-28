Module ModCashCollection

    Dim generalDAO As New GeneralDAO

    Function DailyCashCollection(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT HN, ReceiptNo, CashUSD, CashRiel, ConsultationFeeUSD," _
            & " ConsultationFeeRiel, FollowUpFeeUSD, FollowUpFeeRiel, OperationFeeUSD," _
            & " OperationFeeRiel, ArtificialEyeFeeUSD, ArtificialEyeFeeRiel, OtherFeeUSD, OtherFeeRiel," _
            & " MedicineFeeUSD, MedicineFeeRiel, GlassFeeUSD,GlassFeeRiel FROM tblPatientReceipt" _
            & " Where DateIn ='" & DateIn & "'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function IncomeSummary(ByVal DateIn As Date) As DataTable
        Dim Sql As String = "SELECT     SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) AS OutPatientUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) AS OutpatientRiel, " _
                      & " SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) AS InpatientUSD, SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) AS InpatientRiel, " _
                      & " SUM(GlassFeeUSD) AS GlassUSD, SUM(GlassFeeRiel) AS GlassRiel, SUM(MedicineFeeUSD) AS MedicineUSD, " _
                      & " SUM(MedicineFeeRiel) AS MedicineRiel,SUM(OtherFeeUSD) AS FeeUSD,SUM(OtherFeeRiel) AS FeeRIEL, SUM(ConsultationFeeUSD) + SUM(FollowUpFeeUSD) + SUM(OperationFeeUSD) + SUM(ArtificialEyeFeeUSD) " _
                      & " + SUM(OtherFeeUSD) + SUM(GlassFeeUSD) + SUM(MedicineFeeUSD) AS TotalUSD, SUM(ConsultationFeeRiel) + SUM(FollowUpFeeRiel) " _
                      & " + SUM(OperationFeeRiel) + SUM(ArtificialEyeFeeRiel) + SUM(OtherFeeRiel) + SUM(GlassFeeRiel) + SUM(MedicineFeeRiel) AS TotalRiel FROM tblPatientReceipt Where DateIn ='" & DateIn & "'"
        Return generalDAO.SelectDAOAsDataTatable(Sql)
    End Function

    Function DailyRemarks(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT tblAccountName.AccountName AS AccountName, tblAccountAmount.AmountUSD AS AmountUSD, tblAccountAmount.AmountRiel AS AmountRiel" _
                            & " FROM tblAccountAmount INNER JOIN tblAccountName ON tblAccountAmount.AID = tblAccountName.AID" _
                            & " Where tblAccountAmount.DateIn ='" & DateIn & "'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Function TotalDailyRemarks(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT SUM(AmountUSD) AS USD, SUM(AmountRiel) as RIEL from tblAccountAmount" _
                            & " Where DateIn ='" & DateIn & "'"
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
            Dim sqlHN = "Select ID FROM tblCashCount WHERE DateIn='" & DateIn & "'"
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

    Function SelectCashCount(ByVal DateIn As Date) As DataTable
        Dim sql As String = "SELECT * from tblCashCount Where DateIn ='" & DateIn & "'"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

End Module
