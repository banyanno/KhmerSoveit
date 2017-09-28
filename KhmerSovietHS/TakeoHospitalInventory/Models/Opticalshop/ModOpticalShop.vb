Module ModOpticalShop
    Dim DSServerEvn As New DSServerEnviromentTableAdapters.DataTableDateServerTableAdapter
    Dim DSOp As New DSOpticalShopTableAdapters.DataTableReceiptMaxTableAdapter
    Function GeneratReceiptNo() As String
        Dim DateServer As Date = CType(GetDateServer(), Date)
        Dim day As Integer = Microsoft.VisualBasic.DateAndTime.Year(DateServer)
        Dim month As String = Microsoft.VisualBasic.DateAndTime.Month(DateServer).ToString
        If month.Length = 1 Then
            month = "0" & month
        Else
            month = month
        End If
        Dim ReceiptNo As Double
        Try
            ReceiptNo = GetMax() + 1
        Catch ex As Exception
            ReceiptNo = 1
        End Try
        Return "R" & day & month.ToString & ReceiptNo.ToString
    End Function
    Function GetDateServer() As Date
        Dim DServer As DataTable = DSServerEvn.GetDateServer
        For Each row As DataRow In DServer.Rows
            Return row("DateServer")
        Next
    End Function
    Function GetMax() As Double
        Dim dTbl As DataTable = DSOp.GetDataReceiptMax
        For Each drow As DataRow In dTbl.Rows
            Return drow("ReceiptMaxAuto")
        Next
    End Function
End Module
