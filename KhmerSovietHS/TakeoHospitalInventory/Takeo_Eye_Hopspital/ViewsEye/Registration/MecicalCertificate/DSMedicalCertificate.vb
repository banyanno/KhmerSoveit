Partial Class DSMedicalCertificate
    Partial Class V_MEDICAL_CERTIFICATEDataTable

        Private Sub V_MEDICAL_CERTIFICATEDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.EYEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
