Module MRates

    Dim generalDAO As New GeneralDAO

    Public Sub InsertRates(ByVal Rates As Double, ByVal Users As String, ByVal DateIn As Date)
        Try
            '-----tblRate--------------------------------------------
            generalDAO.InsertDAO("INSERT INTO tblRates (Rates,Users,DateIn) VALUES(" & Rates & ",'" & Users & "','" & DateIn & "')")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try

    End Sub

    Public Function GetRateChange() As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select Rates from tblRates order by ID Desc")
    End Function

    Public Function GetRateChanges() As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select Rates, DateIn as [Date In] from tblRates order by ID Desc")
    End Function

End Module
