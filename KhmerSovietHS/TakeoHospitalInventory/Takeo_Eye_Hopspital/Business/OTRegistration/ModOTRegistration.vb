Module ModOTRegistration

    Function SaveNewOTRegist( _
        ByVal NewInpatient As String _
            , ByVal PatientNo As String _
            , ByVal OperationTime As String _
            , ByVal Anesthesia As String _
            , ByVal Anesthetist As String _
            , ByVal Eye As String _
            , ByVal OperationType As String _
            , ByVal OperationTypeTem As String _
            , ByVal IOL_ID As Integer _
            , ByVal IOL_ID_OLD As Integer _
            , ByVal IOL As String _
            , ByVal Surgeon As String _
            , ByVal Assistant As String _
            , ByVal Circulation As String _
            , ByVal Compli As String _
            , ByVal TypeOtherOT As Boolean _
            , ByVal CreateDate As String, _
            ByVal DateOperated As String, _
            ByVal Others As String) As Integer
        Dim sql As String = "INSERT INTO TblOTRegistration" & _
           "(NewInpatientNo" & _
           ",PatientNo" & _
           ",OperationTime" & _
           ",Anesthesia" & _
           ",Anesthetist" & _
           ",Eye" & _
           ",OperationType" & _
           ",OperationTypeTem" & _
           ",IOL_ID" & _
           ",IOL_ID_OLD" & _
           ",IOL" & _
           ",Surgeon" & _
           ",Assistant" & _
           ",Circulation" & _
           ",Compli" & _
           ",TypeOtherOT" & _
           ",CreateDate" & _
           ",DateOperated" & _
           ",Others)" & _
           "VALUES " & _
           "(" & NewInpatient & _
           "," & PatientNo & _
           ",'" & OperationTime & _
           "','" & Anesthesia & _
           "','" & Anesthetist & _
           "','" & Eye & _
           "','" & OperationType & _
           "','" & OperationTypeTem & _
           "'," & IOL_ID & _
           "," & IOL_ID_OLD & _
           ",'" & IOL & _
           "','" & Surgeon & _
           "','" & Assistant & _
           "','" & Circulation & _
           "','" & Compli & _
           "','" & TypeOtherOT & _
           "','" & CreateDate & _
           "','" & DateOperated & _
           "','" & Others & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateIOLID_OLD(ByVal OTNo As String, ByVal IOL_ID As Integer) As Integer
        Dim sql As String = "UPDATE TblOTRegistration SET IOL_ID_OLD=" & IOL_ID & "WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateOTRegistration(ByVal OTNO As String, _
            ByVal NewInpatient As String _
            , ByVal PatientNo As String _
            , ByVal OperationTime As String _
            , ByVal Anesthesia As String _
            , ByVal Anesthetist As String _
            , ByVal Eye As String _
            , ByVal OperationType As String _
            , ByVal OperationTypeTem As String _
            , ByVal IOL_ID As Integer _
            , ByVal IOL_ID_OLD As Integer _
            , ByVal IOL As String _
            , ByVal Surgeon As String _
            , ByVal Assistant As String _
            , ByVal Circulation As String _
            , ByVal TypeOtherOT As Boolean _
            , ByVal Compli As String _
            , ByVal DateOperated As String _
            , ByVal Others As String, ByVal EDIT_LOG As String) As Integer
        Dim sql As String = "UPDATE TblOTRegistration SET " & _
        "OperationTime =" & OperationTime & "," & _
        "Anesthesia ='" & Anesthesia & "'," & _
        "Anesthetist='" & Anesthetist & "'," & _
        "Eye ='" & Eye & "'," & _
        "OperationType ='" & OperationType & "'," & _
        "OperationTypeTem='" & OperationTypeTem & "'," & _
        "IOL_ID=" & IOL_ID & "," & _
        "IOL_ID_OLD=" & IOL_ID_OLD & "," & _
        "IOL='" & IOL & "'," & _
        "Surgeon ='" & Surgeon & "'," & _
        "Assistant ='" & Assistant & "', " & _
        "Circulation ='" & Circulation & "', " & _
        "Compli ='" & Compli & "' ," & _
        "TypeOtherOT='" & TypeOtherOT & "'," & _
        "DateOperated=" & DateOperated & "," & _
        "Others='" & Others & "'," & _
        "EDIT_LOG='" & EDIT_LOG & "'" & _
        " WHERE OTNo=" & OTNO
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function


    Function SelectOTRegistration(ByVal PatientNo As String, ByVal ExamNo As String) As DataTable
        Dim sql As String = "SELECT *" & _
            " FROM View_OTRegistration WHERE PatientNo=" & PatientNo
        If ExamNo <> String.Empty Then
            sql = sql & " AND PatientHistoryNo=" & ExamNo
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function DeleteOT(ByVal OTNo As String) As Integer
        Dim sql As String = "Update tblOTRegistration set DeleteOption='True' WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    Function UndoDeleteOT(ByVal OTNo As String) As Integer
        Dim sql As String = "Update tblOTRegistration set DeleteOption='False' WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    Function DeleteOTByNewInpatient(ByVal NewInNo As String) As Integer
        Dim sql As String = "DELETE FROM tblOTRegistration WHERE NewInpatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function DeleteIOLByNewInpatient(ByVal NewInNo As String) As Integer
        Dim sql As String = "DELETE FROM TblIOLRegistration WHERE tblIOLRegistration.OTNo=(SELECT OTNo FROM tblOTRegistration WHERE NewInpatientNo=" & NewInNo & ")"
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function UpdateStatus(ByVal OTNo As String) As Integer
        Dim sql As String = "UPDATE tblOTRegistration SET Status='True' WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateDateOperated(ByVal OTNo As String, ByVal DateOperated As String) As Integer
        Dim sql As String = "UPDATE tblOTRegistration SET DateOperated='" & DateOperated & "' WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectListOT(ByVal PatientNo As String) As DataTable
        'CONVERT(VARCHAR(10),CreateDate, 103)= CONVERT(VARCHAR(10),CAST('" & RegisDate & "' as DATETIME),103)
        Dim sql As String = "SELECT * FROM View_OTRegistration WHERE Waiting=2 AND Status='False' AND DeleteOption='False' "
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo & ""
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectOTHistory(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String) As DataTable
        Dim sql As String = "SELECT * FROM View_OTRegistration WHERE Status='True'  AND DeleteOption='False' AND " & _
            " CAST(CONVERT(VARCHAR(10), DateOperated, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime)"
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo & ""
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectDeleteOT(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String) As DataTable
        Dim sql As String = "SELECT * FROM View_OTRegistration WHERE Status='True' and DeleteOption='True' AND " & _
            " CAST(CONVERT(VARCHAR(10), DateOperated, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo & ""
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    'Function CheckExistingOTR(ByVal NewInNo As String) As Boolean
    '    Dim sql As String = "SELECT COUNT(NewInpatientNo) FROM TblOTRegistration WHERE NewInpatientNo=" & NewInNo
    '    Dim i As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    '    If i > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    Function UpdateStatus(ByVal OTNo As String, ByVal Status As Boolean) As Integer
        Dim sql As String = "Update tblOTRegistration SET Status='" & Status & "' WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
End Module
