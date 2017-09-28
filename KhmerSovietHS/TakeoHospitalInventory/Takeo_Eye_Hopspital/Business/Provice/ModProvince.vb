Module ModProvince

    Function SelectProvice() As DataTable
        Dim sql As String = "SELECT IDProvCode,Province FROM tblProvinces"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckProvince(ByVal ProvinceName As String) As Integer
        Dim sql As String = "SELECT COUNT(Province) FROM TblProvinces WHERE Province='" & ProvinceName & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectAsScalar(sql)
    End Function

    '============================ District Block =====================================
    Function SelectDistrict(ByVal ProvinceID As Integer) As DataTable
        Dim sql As String = "SELECT SrokCode,IDProvCode,DISTRICT FROM tblDistricts WHERE IDProvCode=" & ProvinceID
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckDistictCode(ByVal DisCode As Integer) As Boolean
        Dim sql As String = "SELECT Count(SrokCode) FROM tblDistricts WHERE SrokCode=" & DisCode
        Dim code As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If code > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckDistric(ByVal ProNo As String, ByVal Distric As String) As Integer
        Dim sql As String = "SELECT COUNT(DISTRICT) FROM tblDistricts WHERE DISTRICT='" & Distric.Replace("'", "''") & "' AND IDProvCode=" & ProNo
        Return ModGlobleVariable.GENERAL_DAO.SelectAsScalar(sql)
    End Function
    Function InsertDistrict(ByVal ProvinceNo As Integer, ByVal SrokCode As Integer, ByVal District As String) As Integer
        Dim sql As String = "Insert Into tblDistricts (IDProvCode,SrokCode,DISTRICT) VALUES(" & ProvinceNo & "," & SrokCode & ",'" & District & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateDistrict(ByVal DistrictNo As Integer, ByVal District As String) As Integer
        Dim sql As String = "UPDATE TblDistricts SET DISTRICT='" & District & "' WHERE SrokCode=" & DistrictNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteDistrict(ByVal DistrictNo As Integer) As Integer
        Dim sql As String = ""
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    '=========================== Commune Block ================================
    Function SelectCommune(ByVal DistrictID As Integer) As DataTable
        Dim sql As String = "SELECT IDProvCode,SrokCode,KhumCode,Commune FROM tblCommunes WHERE SrokCode =" & DistrictID
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckComCode(ByVal ComCode As Integer) As Boolean
        Dim sql As String = "select count(KhumCode) FROM tblCommunes WHERE KhumCode=" & ComCode
        Dim Code As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If Code > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckCommun(ByVal DiscNo As String, ByVal Commune As String) As Integer
        Dim sql As String = "SELECT COUNT(Commune) FROM tblCommunes WHERE Commune='" & Commune.Replace("'", "''") & "' AND SrokCode=" & DiscNo
        Return ModGlobleVariable.GENERAL_DAO.SelectAsScalar(sql)

    End Function
    Function SelectSelectionByProvince(ByVal ProvinceNo As Integer) As DataTable
        Dim sql As String = "SELECT IDProvCode,SrokCode,KhumCode,Commune FROM tblCommunes WHERE IDProvCode=" & ProvinceNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function InsertCommune(ByVal IDProvCode As String, ByVal SrokCode As Integer, ByVal KhumCode As Integer, ByVal CommuneName As String) As Integer
        Dim sql As String = "INSERT INTO tblCommunes (IDProvCode,SrokCode,Commune) VALUES(" & IDProvCode & "," & SrokCode & "," & KhumCode & ",'" & CommuneName & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

    Function UpdateCommune(ByVal CommuneNo As String, ByVal CommuneName As String) As Integer
        Dim sql As String = "UPDATE TblCommunes SET Commune ='" & CommuneName & "' WHERE KhumCode=" & CommuneNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteCommune(ByVal CommuneNo As String) As Integer
        Dim sql As String = "DELETE FROM TblCommunes WHERE KhumCode=" & CommuneNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
End Module
