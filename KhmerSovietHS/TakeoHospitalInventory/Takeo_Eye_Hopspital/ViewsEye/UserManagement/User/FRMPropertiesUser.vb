Public Class FRMPropertiesUser
    Dim LsView1 As ListViewItem, LsView2 As ListViewItem

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
        Dim index As Integer = 0
        While Ls1.CheckedItems.Count > 0
            LsView2 = Ls2.Items.Add(Ls1.CheckedItems(0).SubItems(0).Text)
            Ls2.Items(Ls2.Items.Count - 1).SubItems.Add(Ls1.CheckedItems(0).SubItems(1).Text)
            Ls1.Items.Remove(Ls1.CheckedItems(0))
            index = index + 1
        End While
    End Sub

    Private Sub FRMPropertiesUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdata()
    End Sub
    Sub showdata()
        Dim i As Int16, _
        j As Int16, _
        DRowGroup As DataRow, _
        TblGroup As DataTable = ModUser.SelectGroup, DRowGrou1 As DataRow, TblGroup1 As DataTable = ModUser.SelectGroupByUserID(LblUserId.Text)


        ' Add data into ls1
        For Index As Integer = 0 To TblGroup.Rows.Count - 1
            DRowGroup = TblGroup.Rows(Index)
            LsView1 = Ls1.Items.Add(DRowGroup(1).ToString)
            Ls1.Items(Index).SubItems.Add(DRowGroup(0).ToString)
        Next

        ' Add data into ls1
        For Index As Integer = 0 To TblGroup1.Rows.Count - 1
            DRowGrou1 = TblGroup1.Rows(Index)
            LsView2 = Ls2.Items.Add(DRowGrou1(1).ToString)
            Ls2.Items(Index).SubItems.Add(DRowGrou1(0).ToString)
        Next

        'Compare if the same value removed
        For i = 0 To Ls2.Items.Count - 1
            For j = 0 To Ls1.Items.Count - 1
                If Ls1.Items(j).SubItems(0).Text = Ls2.Items(i).SubItems(0).Text Then
                    Ls1.Items.RemoveAt(j)
                    'MsgBox(Ls1.Items(j).SubItems(0).Text)
                    GoTo bb
                End If
            Next
bb:
        Next
    End Sub

    Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click

        While Ls2.CheckedItems.Count > 0
            Ls1.Items.Add(Ls2.CheckedItems(0).SubItems(0).Text)
            Ls1.Items(Ls1.Items.Count - 1).SubItems.Add(Ls2.CheckedItems(0).SubItems(1).Text)
            Ls2.Items.Remove(Ls2.CheckedItems(0))

        End While
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim i As Int32, UserNo As String, GroupNo As String
        If TxtUserName.Text <> "" Then
            UserNo = LblUserId.Text
            ModUser.DeleteGroupByUserID(UserNo)
            For i = 0 To Ls2.Items.Count - 1
                GroupNo = Ls2.Items(i).SubItems(1).Text
                ModUser.InsertUserGroup(UserNo, GroupNo)
            Next
            'Ch2.Items.Clear()
            'SQL = "select Menu from tblMenu order by MenuNo"
            'ShowCheckListBox(Ch1, SQL)
            MsgBox("Set permistion successfully!", MsgBoxStyle.Information, "Save")
            Me.Close()
        Else
            MsgBox("Please select group name!", MsgBoxStyle.Question)
        End If
    End Sub
End Class