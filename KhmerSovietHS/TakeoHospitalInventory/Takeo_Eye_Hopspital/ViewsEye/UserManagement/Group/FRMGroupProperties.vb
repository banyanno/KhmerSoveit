Public Class FRMGroupProperties

    Private Sub FRMGroupProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdata()
    End Sub
    Sub showdata()
        Dim SQL As String, i As Int16, j As Int16
        SQL = "SELECT MENUDISPLAY from MENU_INVENTORY order by MENUDISPLAY"
        ShowCheckListBox(Ch1, SQL)
        SQL = "SELECT MenuDisplay FROM Menu_INVENTORY,Deppartment_Permistion_Menu,tblDepartment WHERE Menu_INVENTORY.MenuKey=Deppartment_Permistion_Menu.MenuNo AND tblDepartment.DepartName='" & TxtGroupName.Text.Replace("'", "''") & _
                "' AND tblDepartment.DepartID = Deppartment_Permistion_Menu.GroupNo "
        ShowCheckListBox(Ch2, SQL)
        For i = 0 To Ch2.Items.Count - 1
            For j = 0 To Ch1.Items.Count - 1
                If Ch1.Items(j) = Ch2.Items(i) Then
                    Ch1.Items.RemoveAt(j)
                    GoTo bb
                End If
            Next
bb:
        Next
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim i As Int32, GroupNo As String, MenuNo As String
        If TxtGroupName.Text <> "" Then
            If MessageBox.Show("Do you want save permistion", "Permistion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                GroupNo = LblGroupID.Text
                ModUser.DeleteGroupMenu(GroupNo)
                For i = 0 To Ch2.Items.Count - 1
                    MenuNo = ModUser.SelectMenuNo(Ch2.Items.Item(i)).ToString
                    ModUser.InsertGroupMenu(GroupNo, MenuNo)
                Next
                'Ch2.Items.Clear()
                'SQL = "select Menu from tblMenu order by MenuNo"
                'ShowCheckListBox(Ch1, SQL)
                'MsgBox("Set permistion successfully!", MsgBoxStyle.Information, "Save")
                'Me.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            
        Else
            MsgBox("Please select group name!", MsgBoxStyle.Question)
        End If
    End Sub

    Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
        While Ch1.CheckedItems.Count > 0
            Ch2.Items.Add(Ch1.CheckedItems(0))
            Ch1.Items.Remove(Ch1.CheckedItems(0))
        End While
    End Sub

    Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click
        While Ch2.CheckedItems.Count > 0
            Ch1.Items.Add(Ch2.CheckedItems(0))
            Ch2.Items.Remove(Ch2.CheckedItems(0))
        End While
    End Sub
End Class