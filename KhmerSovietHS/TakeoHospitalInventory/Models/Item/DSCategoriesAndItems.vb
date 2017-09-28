Partial Class DSCategoriesAndItems
    Partial Class DT_ITEMLISTDataTable

    End Class

    Partial Class ItemReqDataTable

    End Class

    Partial Class tblDepartmentDataTable

        Private Sub tblDepartmentDataTable_tblDepartmentRowChanging(ByVal sender As System.Object, ByVal e As tblDepartmentRowChangeEvent) Handles Me.tblDepartmentRowChanging

        End Sub

    End Class

    Partial Class VItemListInDepartDataTable

        Private Sub VItemListInDepartDataTable_VItemListInDepartRowChanging(ByVal sender As System.Object, ByVal e As VItemListInDepartRowChangeEvent) Handles Me.VItemListInDepartRowChanging

        End Sub

    End Class

    Partial Class VItemListDataTable

        Private Sub VItemListDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ContainerNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
