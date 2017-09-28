Module ModNewOldPatient

    Public Function CheckReceiptDuplicate(ByVal receiptNoValCheck As Double) As Boolean
        Dim receiptNo As Double
        receiptNo = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar("SELECT ReceiptNo FROM tblNewOldOutPatient WHERE ReceiptNo=" & receiptNoValCheck)
        If receiptNoValCheck = receiptNo Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub SaveNewOldPatient(ByVal PatientNo As Double, ByVal ReceiptNo As Double, ByVal PatientName As String, ByVal Age As String, ByVal Sex As String, ByVal Address As String, ByVal PatientFee As String, ByVal DiagLeft As String, ByVal DiagRight As String, ByVal Other As String, ByVal CreateDate As String, ByVal UserNameLastUpdate As String)
        Dim sql As String = "INSERT INTO tblNewOldOutPatient " & _
          " (PatientNo,ReceiptNo,PatientName,Age,Sex" & _
           ",Address,PatientFee,DiagLeft,DiagRight" & _
           ",Other,CreateDate,UserNameLastUpdate)" & _
            "VALUES " & _
           "(" & PatientNo & "," & ReceiptNo & ", '" & PatientName.Replace("'", "''") & _
            "','" & Age & "','" & Sex & "','" & Address.Replace("'", "''") & "'," & PatientFee & ",'" & DiagLeft.Replace("'", "''") & _
            "','" & DiagRight.Replace("'", "''") & "','" & Other.Replace("'", "''") & "','" & CreateDate & "','" & UserNameLastUpdate.Replace("'", "''") & "')"
        ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)

    End Sub


    Public Sub UpdateNewOldPatient(ByVal ReceiptNo As Double, ByVal PatientFee As Double, ByVal DiagLeft As String, ByVal DiagRight As String, ByVal Other As String, ByVal UserNameLastUpdate As String)
        Dim sql As String = "UPDATE tblNewOldOutPatient SET" & _
        " PatientFee =" & PatientFee & _
        ",DiagLeft = '" & DiagLeft.Replace("'", "''") & _
        "',DiagRight= '" & DiagRight.Replace("'", "''") & _
        "',Other = '" & Other.Replace("'", "''") & _
        "',UserNameLastUpdate= '" & UserNameLastUpdate.Replace("'", "''") & _
        "' WHERE  ReceiptNo= " & ReceiptNo
        ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Sub
    
End Module
