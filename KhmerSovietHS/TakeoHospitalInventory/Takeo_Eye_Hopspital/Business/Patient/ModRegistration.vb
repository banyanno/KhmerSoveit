Module ModRegistration
    Function CheckDuplicatePatient(ByVal PatientName As String, ByVal age As Integer, ByVal Sex As String, ByVal Address As String) As Integer
        Dim sql As String = "SELECT PatientNo FROM TblPatients WHERE NameKhmer='" & PatientName & "' AND age=" & age & " AND Sex='" & Sex & "' AND Address='" & Address & "'"
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Function NewRegistrationPatient( _
        ByVal PatientNo As String, _
        ByVal CreateDate As String, _
       ByVal province As String, _
       ByVal District As String, _
       ByVal Commune As String, _
       ByVal NameEng As String, _
       ByVal NameKh As String, _
       ByVal Age As String, _
       ByVal Sex As String, _
       ByVal address As String, _
       ByVal Occupation As String, _
       ByVal Tel As String, _
       ByVal neighbor As String, _
       ByVal Years As Integer, _
       Optional ByVal Achieve As Boolean = False) As Integer
        Dim Field As String = ""
        If Sex = "M" Then
            Field = "Male"
        Else
            Field = "Female"
        End If

        Dim sql As String = "INSERT INTO TblPatients (" & _
        "PatientNo," & _
        "CreateDate," & _
        "Province," & _
        "District," & _
        "Commune," & _
        "NameEng," & _
        "NameKhmer," & _
        "Age," & Field & " ," & _
        "Sex," & _
        "Address," & _
        "Occupation," & _
        "Telephone," & _
        "Neighborly," & _
        "Years,Achieve) " & _
        " VALUES(" & PatientNo & " ,'" & _
        CreateDate & "','" & _
       province.Replace("'", "''") & "','" & _
        District.Replace("'", "''") & "','" & _
        Commune.Replace("'", "''") & "','" & _
        NameEng.Replace("'", "''") & "','" & _
        NameKh.Replace("'", "''") & "'," & _
        Age & ",'" & _
        Sex & "','" & _
        Sex & "','" & _
        address.Replace("'", "''") & "','" & _
        Occupation.Replace("'", "''") & "','" & _
        Tel.Replace("'", "''") & "','" & _
        neighbor.Replace("'", "''") & "'," & Years & ",'" & Achieve & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    ' Insert new patient achieve registration form
    Function NewRegistrationPatientAchieve( _
    ByVal OldPatientNo As String, _
    ByVal NewPatientNo As String, _
    ByVal RegisDate As Date, _
    ByVal province As String, _
    ByVal District As String, _
    ByVal Commune As String, _
    ByVal NameEng As String, _
    ByVal NameKh As String, _
    ByVal Age As String, _
    ByVal Sex As String, _
    ByVal address As String, _
    ByVal Occupation As String, _
    ByVal Tel As String, _
    ByVal neighbor As String, _
    ByVal Years As Integer, _
    Optional ByVal Achieve As Boolean = False) As Integer
        Dim Field As String = ""
        If Sex = "M" Then
            Field = "Male"
        Else
            Field = "Female"
        End If

        Dim sql As String = "INSERT INTO TblPatients (" & _
        "PatientNo," & _
        "OlePatientNo," & _
        "CreateDate," & _
        "Province," & _
        "District," & _
        "Commune," & _
        "NameEng," & _
        "NameKhmer," & _
        "Age," & Field & " ," & _
        "Sex," & _
        "Address," & _
        "Occupation," & _
        "Telephone," & _
        "Neighborly," & _
        "Years,Achieve) " & _
        " VALUES(" & NewPatientNo & " ," & _
        OldPatientNo & " ,'" & _
        RegisDate & "','" & _
        province.Replace("'", "''") & "','" & _
        District.Replace("'", "''") & "','" & _
        Commune.Replace("'", "''") & "','" & _
        NameEng.Replace("'", "''") & "','" & _
        NameKh.Replace("'", "''") & "'," & _
        Age & ",'" & _
        Sex & "','" & _
        Sex & "','" & _
        address.Replace("'", "''") & "','" & _
        Occupation.Replace("'", "''") & "','" & _
        Tel.Replace("'", "''") & "','" & _
        neighbor.Replace("'", "''") & "'," & _
        Years & ",'" & _
        Achieve & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

    Function CheckExistingPatientNo(ByVal PatientNo As String) As Boolean
        Dim sql As String = "SELECT COUNT(patientNo) FROM TblPatients WHERE patientNo=" & PatientNo
        Dim existing As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If existing = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Function SavePatienToFollowUP(ByVal patientNo As String) As Integer
        Dim sql As String = "INSERT INTO TblFollowUp (patientNo,CreateDate) VALUES(" & patientNo & ",'" & Now & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Sub UpdatePrintPreview(ByVal print As Boolean)
        Try
            Dim sql As String = "UPDATE TblPrintPreview SET CheckPrince='" & print & "'"
            ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Function GetPrintPreview() As Boolean
        Dim sql As String = "SELECT CheckPrince FROM TblPrintPreview"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function UpdatePatient(ByVal No As String, ByVal province As String, ByVal District As String, ByVal Commune As String, ByVal NameEng As String, ByVal NameKh As String, ByVal Age As String, ByVal Sex As String, ByVal address As String, ByVal Occupation As String, ByVal Tel As String, ByVal CreateDate As String) As Integer
        Dim Field As String = ""
        If Sex = "M" Then
            Field = "Male='" & Sex & "', Female=null "
        Else
            Field = "Female='" & Sex & "', Male=null "
        End If
        Dim sql As String = "UPDATE TblPatients SET Province ='" & province.Replace("'", "''") & "' ," & _
                            "District ='" & District.Replace("'", "''") & _
                            "' ,Commune ='" & Commune.Replace("'", "''") & _
                            "' ,NameEng =N'" & NameEng.Replace("'", "''") & _
                            "' ,NameKhmer =N'" & NameKh.Replace("'", "''") & _
                            "' ,Age =" & Age.Replace("'", "''") & _
                            " ," & Field & _
                            " ,Sex='" & Sex.Replace("'", "''") & _
                            "',Address ='" & address.Replace("'", "''") & _
                            "' ,Occupation ='" & Occupation.Replace("'", "''") & _
                            "' ,Telephone ='" & Tel.Replace("'", "''") & _
                            "', CreateDate='" & CreateDate & _
                            "'  WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(Sql)
    End Function
    Function UpdatePatientLastReferal(ByVal PatientNo As String, ByVal Referall As String) As Integer
        Dim sql As String = "Update TblPatients set combindRefferal='" & Referall & "'WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function GetPatientByNo(ByVal patientNo As String) As DataTable
        Dim sql As String = "SELECT " & _
        " patientNo,CreateDate,Province,District,Commune,NameEng" & _
        " ,NameKhmer,Age,Male,Female,Sex,Address,Occupation,Telephone,Neighborly" & _
        " FROM TblPatients WHERE patientNo=" & patientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function GetAllPatient() As DataTable
        Dim sql As String = "SELECT " & _
        " patientNo,CreateDate,Province,District,Commune,NameEng" & _
        " ,NameKhmer,Age,Male,Female,Sex,Address,Occupation,Telephone,Neighborly" & _
        " FROM TblPatients"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function GetPatientAchieve() As DataTable
        Dim SQL As String = "SELECT PatientNo,NameEng,NameKhmer,Age,Sex,Address,Province,District,Commune,Occupation,Telephone FROM TblPatients WHERE Achieve='True'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(SQL)
    End Function
   
End Module
