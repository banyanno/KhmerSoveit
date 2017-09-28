Module MAccountReceivable

    Dim generalDAO As New GeneralDAO

    Public Sub SaveAccountName(ByVal AID As Long, ByVal AccountName As String, ByVal DateIn As Date, ByVal Users As String)
        Try
            '-----tblAccountName--------------------------------------------
            generalDAO.InsertDAO(" INSERT INTO tblAccountName (AID, AccountName, DateIn, Users) values(" & AID & ",'" & AccountName & "','" & DateIn & "','" & Users & "')")
            MsgBox("Insert new account name successfully", MsgBoxStyle.OkOnly, "New account name")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateAccountName(ByVal AID As Long, ByVal AccountName As String)
        Try
            generalDAO.UpdateDAO("Update tblAccountName set AccountName='" & AccountName & "' where AID=" & AID & "")
            MsgBox("Update account name successfully", MsgBoxStyle.OkOnly, "Update account name")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try

    End Sub

    Public Sub SaveAccountAount(ByVal AID As Long, ByVal AccountAmountUSD As Double, ByVal AccountAmountRiel As Double, ByVal DateIn As Date, ByVal Users As String)
        Try
            '-----tblAccountAccount--------------------------------------------
            generalDAO.InsertDAO(" INSERT INTO tblAccountAmount (AID, AmountUSD, AmountRiel, DateIn, Users) values(" & AID & "," & AccountAmountUSD & "," & AccountAmountRiel & ",'" & DateIn & "','" & Users & "')")
            MsgBox("Insert new amount successfully", MsgBoxStyle.OkOnly, "New amount name")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateAccountAount(ByVal ID As String, ByVal AID As Long, ByVal AccountAmountUSD As Double, ByVal AccountAmountRiel As Double, ByVal DateIn As Date, ByVal Users As String)
        Try
            '-----tblAccountAcount--------------------------------------------
            generalDAO.UpdateDAO("Update tblAccountAmount set AID=" & AID & " , AmountUSD=" & AccountAmountUSD & ", AmountRiel=" & AccountAmountRiel & ", DateIn='" & DateIn & "', Users='" & Users & "' Where  ID=" & ID)
            MsgBox("Update amount successfully", MsgBoxStyle.OkOnly, "Update amount")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateDateAccReceipt(ByVal AID As Long, ByVal DateIn As Date)
        Try
            '-----tblAccountAcount--------------------------------------------
            generalDAO.UpdateDAO("Update tblAccountAmount set DateIn='" & DateIn & "' Where  ID=" & AID & "")
            MsgBox("Update date account receipt successfully", MsgBoxStyle.OkOnly, "Update Date")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Function SelectAccountAmountAll() As DataTable
        Return generalDAO.SelectAsDataTable("Select A.ID as IDs, A.AID as ID ,N.AccountName as [Account Name], A.AmountUSD as [Amount USD],A.AmountRiel as [Amount RIEL], A.DateIn as [Date] from tblAccountAmount A INNER JOIN tblAccountName N ON A.AID=N.AID order by A.DateIn Desc")
    End Function

    Public Function SelectAccountAmountByDate(ByVal DateIn As Date) As DataTable
        Return generalDAO.SelectAsDataTable("Select A.ID as IDs, A.AID as ID ,N.AccountName as [Account Name], A.AmountUSD as [Amount USD],A.AmountRiel as [Amount RIEL], A.DateIn as [Date] from tblAccountAmount A INNER JOIN tblAccountName N ON A.AID=N.AID Where A.DateIn ='" & DateIn & "' order by A.DateIn Desc")
    End Function
    Public Function SelectAccountAmmountByDateBetweent(ByVal dateFrom As Date, ByVal DateTo As Date) As DataTable
        Return generalDAO.SelectAsDataTable("Select A.ID as IDs, A.AID as ID ,N.AccountName as [Account Name], A.AmountUSD as [Amount USD],A.AmountRiel as [Amount RIEL], A.DateIn as [Date] from tblAccountAmount A INNER JOIN tblAccountName N ON A.AID=N.AID Where A.DateIn between '" & dateFrom & "' and '" & DateTo & "' order by A.DateIn Desc")
    End Function
    Public Function SelectAccountAmountByAID(ByVal AID As Long) As DataTable
        Return generalDAO.SelectAsDataTable("Select A.ID as IDs, A.AID as ID ,N.AccountName as [Account Name], A.AmountUSD as [Amount USD],A.AmountRiel as [Amount RIEL], A.DateIn as [Date] from tblAccountAmount A INNER JOIN tblAccountName N ON A.AID=N.AID Where A.ID =" & AID & " order by A.DateIn Desc")
    End Function

    Public Function SelectAccountName() As DataTable
        Return generalDAO.SelectAsDataTable("Select AID as ID, AccountName as [Account Name], DateIn as [Date] from tblAccountName order by DateIn Desc")
    End Function

    Public Function SelectAccountCombo() As DataTable
        Return generalDAO.SelectAsDataTable("Select AID , AccountName from tblAccountName order by AccountName Asc")
    End Function

    Public Function getMaxIDAcc() As Integer
        Dim general As New GeneralDAO
        Dim day As Integer = Microsoft.VisualBasic.DateAndTime.Year(Now)
        Dim month As Integer = Microsoft.VisualBasic.DateAndTime.Month(Now)
        Dim idHn As Integer
        Try
            idHn = general.SelectDAOAsScalar("SELECT MAX(ID) from tblAccountName") + 1
        Catch ex As Exception
            idHn = 1
        End Try
        Return day.ToString & month.ToString & idHn.ToString
    End Function

    Public Function CheckIDAcc(ByVal AID As Long) As Boolean
        Try
            Dim sqlHN = "Select ID FROM tblAccountName WHERE AID=" & AID & ""
            Dim totalRow As Integer = generalDAO.SelectDAOAsDataTatable(sqlHN).Rows.Count
            If totalRow = 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Function

    Public Function CheckIDAccAmount(ByVal ID As Long, ByVal DateIn As Date) As Boolean
        Try
            Dim sqlHN = "Select ID FROM tblAccountAmount WHERE ID=" & ID & " and DateIn='" & DateIn & "'"
            Dim totalRow As Integer = generalDAO.SelectDAOAsDataTatable(sqlHN).Rows.Count
            If totalRow = 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Function

    Public Function CheckIDAccDate(ByVal AID As Long, ByVal DateIn As Date) As Boolean
        Try
            Dim sqlHN = "Select ID FROM tblAccountAmount WHERE AID=" & AID & " and DateIn='" & DateIn & "'"
            Dim totalRow As Integer = generalDAO.SelectDAOAsDataTatable(sqlHN).Rows.Count
            If totalRow = 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Function

End Module
