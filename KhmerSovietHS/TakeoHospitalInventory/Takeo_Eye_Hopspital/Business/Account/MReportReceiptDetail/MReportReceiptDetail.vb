Module MReportReceiptDetail

    Dim generalDAO As New GeneralDAO

    Public Function ReportReceiptDetailIP_OP(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='IR' and ConOP='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailIP_AE(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='IR' and ConAE='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailIP_OT(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='IR' and ConOT='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailIP_OP_AE(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='IR' and ConOP='1' and ConAE='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailIP_OP_OT(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='IR' and ConOP='1' and ConOT='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailIP_AE_OT(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='IR' and ConAE='1' and ConOT='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailIP(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='IR' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailNP(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='NR' and ConCON='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailOP(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='OR' and ConFOL='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailCR_MED(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='CR' and ConMED='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailCR_GLA(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='CR' and ConGLA='1' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Function ReportReceiptDetailCR(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetReportDetail
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel, DateIn, ConPay, " _
                    & " ConGeneral, ID FROM tblPatientReceipt Where CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) >='" & DateFrom & "' and CAST(CONVERT(VARCHAR(10), DateIn, 1) AS DateTime) <='" & DateTo & "'" _
                    & " and ConGeneral='CR' and ConPay='1' and ConDelete='0' ORDER BY ReceiptNo"
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

End Module
