Public Class FormGrantPermistionInventory
    Dim Menu1DataAdapter As New DSUserManagementTableAdapters.Menu_INVENTORYTableAdapter
    Dim Menu2DataAdapter As New DSUserManagementTableAdapters.VGroupPermistionTableAdapter

    Private Sub FormGrantPermistion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadingPermistion()
    End Sub
    Sub LoadingPermistion()
        Try
            Dim tblMenuGrant As DataTable = Menu2DataAdapter.GetDataByGroupNo(LblGroupID.Text)
            Dim tblMenuRevoke As DataTable = Menu1DataAdapter.GetData
            tblMenuRevoke.PrimaryKey = New DataColumn() {tblMenuRevoke.Columns("MenuNo")}
            'Remove menu permistion from invoke 
            For Each row As DataRow In tblMenuGrant.Rows
                tblMenuRevoke.Rows.Find(row("MenuNo")).Delete()
            Next
            GridPermistion1.DataSource = tblMenuRevoke
            GridPermistion2.DataSource = tblMenuGrant
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnGrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrand.Click
        CheckPermistionToGrant()
    End Sub

    Sub CheckPermistionToGrant()
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        'get an array with all the rows that the user checked.
        checkedRows = GridPermistion1.GetCheckedRows()
        'if the user didn't check any row, you will get an empty array
        'MsgBox(checkedRows)
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please select at least 1 permistion to be grant to department.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim message As String
            message = String.Format("You are about to grant {0} permistion(s) to department." _
                        & vbCrLf & "Do you want to Save?", checkedRows.Length)
            If MessageBox.Show(message, "Takeo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            System.Windows.Forms.DialogResult.Yes Then
                Dim UPermistion As New UserManagementImplement
                For Each row As Janus.Windows.GridEX.GridEXRow In checkedRows
                    Dim Permistion As New Deppartment_Permistion_Menu
                    Permistion.GroupNo = LblGroupID.Text
                    Permistion.MenuNo = CInt(row.Cells("MenuNo").Value)
                    UPermistion.GrantPermistion(Permistion)
                Next
            End If
            LoadingPermistion()
        End If
    End Sub
    Sub CheckPermistionToRevoke()
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        'get an array with all the rows that the user checked.
        checkedRows = GridPermistion2.GetCheckedRows()
        'if the user didn't check any row, you will get an empty array
        'MsgBox(checkedRows)
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please select at least 1 permistion to be revoke to department.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim message As String
            message = String.Format("You are about to revoke {0} permistion(s) from department." _
                        & vbCrLf & "Do you want to Save?", checkedRows.Length)
            If MessageBox.Show(message, "Takeo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            System.Windows.Forms.DialogResult.Yes Then
                Dim UPermistion As New UserManagementImplement
                For Each row As Janus.Windows.GridEX.GridEXRow In checkedRows
                    Dim Permistion As New Deppartment_Permistion_Menu
                    Permistion.GroupID = CInt(row.Cells("GroupID").Value)
                    Permistion.GroupNo = CInt(LblGroupID.Text)
                    Permistion.MenuNo = CStr(row.Cells("MenuNo").Value)
                    UPermistion.RevokePermistion(Permistion)
                Next
            End If
            LoadingPermistion()
        End If
    End Sub

    Private Sub BtnRevoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRevoke.Click
        CheckPermistionToRevoke()
    End Sub
End Class