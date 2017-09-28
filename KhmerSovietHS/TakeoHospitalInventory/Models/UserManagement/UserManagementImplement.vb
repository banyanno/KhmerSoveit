
Imports System.Linq
Imports System.Data.Common
Imports System.Data.Linq.DataContext
Public Class UserManagementImplement
    Implements IUserManagement
    Private THIUserContex As New BaseDataContext


    Public Function SaveNewUser(ByVal user As Object) As Boolean Implements IUserManagement.SaveNewUser
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
        Try
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans
            THIUserContex.getTHIDataContextUserManagement.Department_Users.InsertOnSubmit(user)
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveUserIntoDepartment(ByVal dep_user As Object) As Boolean Implements IUserManagement.SaveUserIntoDepartment
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
        Try
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans


            THIUserContex.getTHIDataContextUserManagement.Department_Add_Users.InsertOnSubmit(dep_user)
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveNewMenu(ByVal Menu As Object) As Boolean Implements IUserManagement.SaveNewMenu
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
        Try
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans
            THIUserContex.getTHIDataContextUserManagement.Menu_INVENTORies.InsertOnSubmit(Menu)
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function GetUserNameByID(ByVal pId As Integer) As String Implements IUserManagement.GetUserNameByID
        Dim q = From user In THIUserContex.getTHIDataContextUserManagement.Department_Users Where user.UserID = pId Select user.UserName
        Return q.SingleOrDefault
    End Function

    Public Function GrantPermistion(ByVal obj As Object) As Boolean Implements IUserManagement.GrantPermistion
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
        Try
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans

            THIUserContex.getTHIDataContextUserManagement.Deppartment_Permistion_Menus.InsertOnSubmit(obj)
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function RevokePermistion(ByVal obj As Object) As Boolean Implements IUserManagement.RevokePermistion
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction

        Try
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans
            THIUserContex.getTHIDataContextUserManagement.Deppartment_Permistion_Menus.Attach(obj)
            THIUserContex.getTHIDataContextUserManagement.Deppartment_Permistion_Menus.DeleteOnSubmit(obj)
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function UpdateMenu(ByVal Menu As Object) As Boolean Implements IUserManagement.UpdateMenu
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
        Try
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans
            THIUserContex.getTHIDataContextUserManagement.Menu_INVENTORies.Attach(Menu)
            THIUserContex.getTHIDataContextUserManagement.Refresh(Data.Linq.RefreshMode.KeepCurrentValues, Menu)
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function ChangePwdUser(ByVal user As Object) As Boolean Implements IUserManagement.ChangePwdUser
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
        Try
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans
            THIUserContex.getTHIDataContextUserManagement.Department_Users.Attach(user)
            THIUserContex.getTHIDataContextUserManagement.Refresh(Data.Linq.RefreshMode.KeepCurrentValues, user)
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function UpdateUser() As Boolean Implements IUserManagement.UpdateUser
        THIUserContex.getTHIDataContextUserManagement.Connection.Open()
        Dim trans As DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
        THIUserContex.getTHIDataContextUserManagement.Transaction = trans
        Try
            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try

    End Function

    Public Function GetUID(ByVal uid As Integer) As Department_User Implements IUserManagement.GetUID
        Dim User = From Department_User In THIUserContex.getTHIDataContextUserManagement.Department_Users Where Department_User.UserID = uid
        Return User.SingleOrDefault
    End Function

    Public Function DeleteUser(ByVal UserID As Integer) As Boolean Implements IUserManagement.DeleteUser
        If THIUserContex.getTHIDataContextOpticalShop.Connection.State = ConnectionState.Closed Then
            THIUserContex.getTHIDataContextOpticalShop.Connection.Open()
        End If
        Dim trans As Common.DbTransaction = THIUserContex.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THIUserContex.getTHIDataContextOpticalShop.Transaction = trans
            THIUserContex.getTHIDataContextOpticalShop.ExecuteCommand("DELETE FROM Department_User WHERE UserID={0}", UserID)
            THIUserContex.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THIUserContex.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THIUserContex.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function
End Class
