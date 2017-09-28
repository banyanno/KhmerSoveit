Module ModIOLRegistration

    Function SaveNewIOL(ByVal OTNo As String, ByVal PatientNo As String, ByVal Surgeon As String, ByVal Eye As String, ByVal IOLNumber As String, ByVal CreateDate As String) As Integer
        Dim sql As String = "INSERT INTO TblIOLRegistration (OTNo,PatientNo,Surgeon,Eye,IOLNumber,CreateDate)" & _
                            " VALUES(" & OTNo & "," & PatientNo & ",'" & Surgeon & "','" & Eye & "','" & IOLNumber & "','" & CreateDate & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function CheckIOLReady(ByVal PatientNo As Long) As Boolean
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblIOLRegistration WHERE PatientNo=" & PatientNo
        Dim value As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If value > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function UpdateIOL(ByVal IOLNo As String, ByVal Surgeon As String, ByVal Eye As String, ByVal IOLNumber As String, ByVal DateIOL As Date) As Integer
        Dim sql As String = "UPDATE TblIOLRegistration SET Surgeon = '" & Surgeon & "',Eye ='" & Eye & "',IOLNumber ='" & IOLNumber & "',CreateDate='" & DateIOL & "' WHERE IOLNo=" & IOLNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteIOLByOT(ByVal OTNo As String) As Integer
        Dim sql As String = "Update tblIOLRegistration set DeleteOption='True' WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function DeleteIOL(ByVal IOLNo As String) As Integer
        Dim sql As String = "DELETE FROM TblIOLRegistration WHERE IOLNo=" & IOLNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    Function UndoDeleteIOLByOT(ByVal OTNo As String) As Integer
        Dim sql As String = "Update tblIOLRegistration set DeleteOption='False' WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    Function SelectIOL(ByVal OTNo As String) As DataTable
        Dim sql As String = "SELECT *  FROM V_IOLRegistration WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckSaveIOL(ByVal OTNO As String) As Boolean
        Dim sql As String = "SELECT COUNT(OTNO) FROM TblIOLRegistration WHERE OTNO=" & OTNO
        Dim i As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If i >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
