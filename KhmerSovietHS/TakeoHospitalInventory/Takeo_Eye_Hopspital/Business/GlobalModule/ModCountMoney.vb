Module ModCountMoney

    Function CountMoneyRielDollar(ByVal DateFrom As String, ByVal DateTo As String, ByVal FieldSelect As String, ByVal FieldSelectAs As String, ByVal FieldDate As String, ByVal TableView As String) As DataTable
        Dim sql As String = "SELECT DISTINCT(" & FieldSelect & ") AS " & FieldSelectAs & " FROM " & TableView & " WHERE DeleteOption=0 AND " & _
            " CAST(CONVERT(VARCHAR(10), " & FieldDate & ", 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) ORDER BY " & FieldSelect & ""
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
        Catch ex As Exception
            MsgBox("Error, this cannot count the money.", MsgBoxStyle.Information, "Error")
        End Try
    End Function

    'Function CountMoneyRielDollarALL(ByVal DateFrom As String, ByVal DateTo As String, ByVal FieldSelect As String, ByVal FieldSelectAs As String, ByVal FieldDate As String, ByVal TableView As String) As DataTable
    '    Dim sql As String = "SELECT DISTINCT(" & FieldSelect & ") AS " & FieldSelectAs & " FROM " & TableView & " WHERE DeleteOption=0 ADN " & _
    '        " CAST(CONVERT(VARCHAR(10), " & FieldDate & ", 1) as DateTime) BETWEEN " & _
    '        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
    '        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) ORDER BY " & FieldSelect & ""
    '    Try
    '        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    '    Catch ex As Exception
    '        MsgBox("Error, this cannot count the money.", MsgBoxStyle.Information, "Error")
    '    End Try
    'End Function

End Module
