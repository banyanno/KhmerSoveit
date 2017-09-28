Module ModDaillyBook
    Function SaveNewDaillyBook(ByVal NewInpatientNo As String, ByVal PatientNo As String, ByVal Eye As String, ByVal Treatment As String, ByVal CreateDate As String) As Integer
        Dim sql As String = "INSERT INTO TblDaillyBook(NewInpatientNo,PatientNo,Eye,Treatment,CreateDate)" & _
                            " VALUES (" & NewInpatientNo & "," & PatientNo & ",'" & Eye & "','" & Treatment & "','" & CreateDate & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateDaillyBook(ByVal DaillyBookNo As String, ByVal Eye As String, ByVal Treatment As String, ByVal CreateDate As String) As Integer
        Dim sql As String = "UPDATE TblDaillyBook SET Eye = '" & Eye & "',Treatment = '" & Treatment & "',CreateDate ='" & CreateDate & "' WHERE DaillyBookNo=" & DaillyBookNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteDaillyBook(ByVal DaillyBookNo As String) As Integer
        Dim sql As String = "DELETE FROM TblDaillyBook WHERE DaillyBookNo=" & DaillyBookNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SelectDaillyBookByNewInpatient(ByVal NewInpatient As String) As DataTable
        Dim sql As String = "SELECT DaillyBookNo,NewInpatientNo,PatientNo,Eye,Treatment,CreateDate FROM TblDaillyBook  WHERE NewInpatientNo=" & NewInpatient
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectDiallyByNo(ByVal NewInpatientNo As String) As DataTable
        Dim sql As String = "SELECT DaillyBookNo,NewInpatientNo,PatientNo,Eye,Treatment,CreateDate FROM TblDaillyBook  WHERE NewInpatientNo=" & NewInpatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
