Imports System.Data.SqlClient

Public MustInherit Class AbstractConnection
    Implements IDataTransaction


    ' Look at file App.config
    Dim CnnString = My.Settings.TakeoDBConnectionString
    Dim cnn As SqlConnection
    Dim dTbl As DataTable
    Dim sqlDataadapter As SqlDataAdapter
    Dim dSet As DataSet
    Public Sub New()
        Me.getConnection()
    End Sub
    Public Function getConnection() As SqlConnection
        Try
            cnn = New SqlConnection(CnnString)
            ' Case connect 1 error will change to connection 2
            cnn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("First Server is error connection. it will chage to second server.", MsgBoxStyle.Information, "Change connection server")
            'ChangeConnectionStringProvider(CnnString1)
            'Try
            '    cnn.ConnectionString = My.Settings.Item("TakeoDBConnectionString")
            '    cnn.Open()
            'Catch ex2 As Exception
            '    MsgBox(ex2.Message)
            '    MsgBox("Second server error too. Please contact IT suport.", MsgBoxStyle.Critical, "Error")
            'End Try
        End Try
        Return cnn
    End Function

    ' This method use to do sql transaction
    Public Function InitTransaction(ByVal objSQl As Object) As Integer
        Try

            Dim SQLStatement As String = CType(objSQl, String)
            Dim dcmm As New SqlClient.SqlCommand(SQLStatement, Me.getConnection)
            dcmm.CommandType = CommandType.Text
            Return dcmm.ExecuteNonQuery()
            Me.getConnection.Dispose()
            Me.getConnection.Close()
        Catch ex As Exception
            Return 0
            MsgBox(ex.Message)
        Finally
            Me.getConnection.Close()
        End Try

    End Function

    Public Function DeleteTransaction(ByVal objSQL As Object) As Integer Implements IDataTransaction.DeleteTransaction
        Return InitTransaction(objSQL)
    End Function

    Public Function InsertTransaction(ByVal objSQL As Object) As Integer Implements IDataTransaction.InsertTransaction
        Return InitTransaction(objSQL)
    End Function

    Public Function SelectAsDataTable(ByVal objSQL As Object) As Object Implements IDataTransaction.SelectAsDataTable
        Dim dtbl As New DataTable
        Dim da As New SqlDataAdapter(CStr(objSQL), Me.getConnection)
        da.Fill(dtbl)
        dtbl.Dispose()
        da.Dispose()
        Me.getConnection.Dispose()
        Me.getConnection.Close()
        Return dtbl
    End Function

    Public Function SelectAsSqlDataSet(ByVal objSQL As Object) As Object Implements IDataTransaction.SelectAsSqlDataSet
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(CStr(objSQL), Me.getConnection)
        da.Fill(ds)
        ds.Dispose()
        da.Dispose()
        Me.getConnection.Dispose()
        Me.getConnection.Close()
        Return ds
    End Function

    Public Function UpdateTransaction(ByVal objSQL As Object) As Integer Implements IDataTransaction.UpdateTransaction
        Return InitTransaction(objSQL)
    End Function

    Public Function SelectAsScalar(ByVal sql As Object) As Object Implements IDataTransaction.SelectAsScalar
        Try
           
            Dim cmdScalar As SqlCommand = New SqlCommand(CStr(sql), Me.getConnection)
            cmdScalar.CommandType = CommandType.Text
            Return cmdScalar.ExecuteScalar
            cmdScalar.Dispose()
            Me.getConnection.Dispose()
            Me.getConnection.Close()
        Catch ex As Exception
            Return 0
        Finally
            cnn.Close()
        End Try
    End Function
End Class
