Module ModBackupDatabase
    Function InsertBackupDB(ByVal UserName As String, ByVal BackupName As String, ByVal DateIn As Date) As Integer
        Dim sql As String = "INSERT INTO tblBackupDB (UserName,BackupName,DateIn) VALUES('" & UserName.Replace("'", "''") & "','" & BackupName.Replace("'", "''") & "','" & DateIn & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
End Module