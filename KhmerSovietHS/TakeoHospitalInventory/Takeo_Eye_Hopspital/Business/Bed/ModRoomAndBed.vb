Module ModRoomAndBed

    Public Sub SaveRoom(ByVal roomName As String, ByVal Description As String)
        Dim sql As String = "INSERT INTO TblRoom (Name,Description) VALUES('" & roomName & "','" & Description & "')"
        ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Sub
    Public Sub SaveBed(ByVal RoomNo As String, ByVal BedName As String, ByVal Description As String, ByVal available As String)
        Dim sql As String = "INSERT INTO TblBed (RoomNo,BedName,Description,Available) VALUES('" & RoomNo & "','" & BedName & "','" & Description & "','" & available & "')"
        ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Sub
    Function SelectRoom(ByVal name As String) As DataTable
        Dim sql As String = "SELECT RoomNo,Name,Description FROM TblRoom "
        If name <> "" Then
            sql = sql & "WHERE Name='" & name & "'"
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Public Sub UpdateRoom()
        Dim sql As String = ""
        ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Sub
    Public Sub UpdateBed(ByVal bedNo As Integer, ByVal roomNo As String, ByVal bedName As String, ByVal descr As String)
        Dim sql As String = "UPDATE TblBed SET RoomNo='" & roomNo & "',BedName='" & bedName & "',Description='" & descr & "' WHERE BedNo=" & bedNo
        If CheckAvailable(bedName) = True Then
            MsgBox("The bed not available.", MsgBoxStyle.Critical)
        Else
            ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
        End If

    End Sub
    Public Sub DeleteRoom()
        Dim sql As String = ""
        ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Sub
    Public Sub DeleteBed()
        Dim sql As String = ""
        ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Sub
    Public Function SelectRoom() As DataTable
        Dim sql As String = "SELECT Name From tblRoom"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Public Function SelectBed(ByVal room As String) As DataTable
        Dim sql As String = "SELECT BedNo, RoomNo,BedName,Description,Available FROM TblBed"
        If room <> "" Then
            sql = sql & " WHERE RoomNo='" & room & "'"
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Public Function CheckBed(ByVal bed As String) As Boolean
        Dim sql As String = "SELECT BedName FROM tblBed WHERE BedName='" & bed & "'"
        Dim bedName As String = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If bedName Is Nothing Then
            Return False
            Exit Function
        Else

        End If
        If bedName.ToUpper = bed.ToUpper Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CheckAvailable(ByVal bed As String) As Boolean
        Dim sql As String = "SELECT available FROM tblBed WHERE BedName='" & bed & "'"
        Dim avialable As String = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If avialable.ToUpper = "True".ToUpper Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
