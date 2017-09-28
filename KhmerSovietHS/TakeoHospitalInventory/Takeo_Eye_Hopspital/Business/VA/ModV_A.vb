Module ModV_A
    Function NewPatientVALeftRight(ByVal TableName As String, ByVal PatientNo As String, _
    ByVal PlainVA As String, _
    ByVal PlainValue As String, _
    ByVal PlainCat As String, _
    ByVal PHVA As String, _
    ByVal PHValue As String, _
    ByVal PHCate As String, _
    ByVal GVA As String, _
    ByVal GValue As String, _
    ByVal GCate As String, _
    ByVal CreateDate As Date, ByVal FirstTime As Boolean) As Integer
        Dim sql As String = "INSERT INTO " & TableName & " (PatientNo,PlainVA,PlainValue,PlainCat,PHVA,PHValue,PHCate,GVA,GValue,GCate,CreateDate,FirstTime) " & _
        "VALUES(" & PatientNo & "," & PlainVA & ",'" & PlainValue & "','" & PlainCat & "'," & PHVA & ",'" & PHValue & "','" & PHCate & "'," & GVA & ",'" & GValue & "','" & GCate & "','" & CreateDate & "','" & FirstTime & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    
    Function NewMainVAPatient(ByVal PatientNo As String, ByVal Plain As String, ByVal Ph As String, ByVal Glasses As String, ByVal VADate As Date, ByVal Order1 As Integer, ByVal Order2 As Integer, ByVal Order3 As Integer) As Integer
        Dim sql As String = "INSERT INTO TblVA1(PatientNo,Plain,Ph,Glasses,CreateDate,Order1 , Order2  ,Order3) VALUES(" & PatientNo & ",'" & Plain & "','" & Ph & "','" & Glasses & "','" & VADate & "'," & Order1 & "," & Order2 & "," & Order3 & ")"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function CheckPatientVA(ByVal PatientNo As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblVA WHERE patientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function DeleteVA(ByVal VANo As String) As Integer
        Dim sql As String = "Delete FROM TblVA WHERE VANo=" & VANo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SelectVAByPatientNoR(ByVal PatientNo As String) As DataTable
        Dim sql As String = "SELECT RighNo,PatientNo,PlainVA,PlainValue,PlainCat,PHVA,PHValue,PHCate,GVA,GValue,GCate,CreateDate FROM TblVARight WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectVAByPatientNoL(ByVal PatientNo As String) As DataTable
        Dim sql As String = "SELECT LeftNo,PatientNo,PlainVA,PlainValue,PlainCat,PHVA,PHValue,PHCate,GVA,GValue,GCate,CreateDate FROM TblVALeft WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectVAByDate(ByVal CreateDate As String) As DataTable
        Dim sql As String = "SELECT VANo,PatientNo,PlainVA,PlainValue,PlainCat,PHVA,PHValue,PHCate,GVA,GValue,GCate,CreateDate FROM TblVA WHERE CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime)=CAST(CONVERT(VARCHAR(10),CAST('" & CreateDate & "' AS DATETIME), 1) as Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    
    Function UpdateVA(ByVal PatientNo As String, ByVal Plain As String, ByVal Ph As String, ByVal Glasses As String) As Integer
        Dim sql As String = "UPDATE TblVA1 SET Plain='" & Plain & "',Ph='" & Ph & "',Glasses='" & Glasses & "' WHERE  PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function VAStatisticR(ByVal month As String, ByVal years As String, ByVal field As String, ByVal age1 As String, ByVal age2 As String) As DataTable
        Dim sql As String = "SELECT COUNT(Male) as M,Count(Female) as F," & field & _
                                    " FROM " & _
                                    " TblVARight INNER JOIN " & _
                                    " TblPatients ON " & _
                                    " TblVARight.PatientNo = TblPatients.PatientNo" & _
                                    " WHERE" & _
                                    " month(TblVARight.createdate)='" & month & "' and year(TblVARight.createdate)='" & years & "' " & _
                                    " and FirstTime='False'" & _
                                    " AND tblPatients.age between " & age1 & " and " & age2 & _
                                    " GROUP BY " & field
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function VAStatistic(ByVal month As String, ByVal years As String, ByVal field As String, ByVal age1 As String, ByVal age2 As String) As DataTable
        Dim sql As String = "SELECT COUNT(Male) as M,Count(Female) as F," & field & _
                                    " FROM " & _
                                    " TblVALeft INNER JOIN " & _
                                    " TblPatients ON " & _
                                    " TblVALeft.PatientNo = TblPatients.PatientNo" & _
                                    " WHERE" & _
                                    " month(TblVALeft.createdate)='" & month & "' and year(TblVALeft.createdate)='" & years & "' " & _
                                    " and FirstTime='False'" & _
                                    " AND tblPatients.age between " & age1 & " and " & age2 & _
                                    " GROUP BY " & field
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

End Module
