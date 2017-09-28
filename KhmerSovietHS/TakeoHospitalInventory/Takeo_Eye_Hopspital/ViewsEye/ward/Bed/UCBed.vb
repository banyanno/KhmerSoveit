Public Class UCBed

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        GeneratListView("")

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRoom.Click
        Dim fRoom As New FrmRooms
        fRoom.ShowDialog()
    End Sub

   
    Private Sub CboRoom_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboRoom.DropDown
        With CboRoom
            .DataSource = ModRoomAndBed.SelectRoom()
            .DisplayMember = "Name"
            .ValueMember = "Name"
            .Text = ""
        End With
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtBed, "bed name", ErrBed) = False Or ValidateCombobox(CboRoom, "room", ErrBed) = False Then
            Exit Sub
        End If
        If lblBedNo.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo)
            If DIALOG_SAVE = DialogResult.Yes Then
                If CheckBed(txtBed.Text.Trim) = False Then
                    ModRoomAndBed.SaveBed(CboRoom.Text, txtBed.Text, TxtDescription.Text, "False")
                    GeneratListView(CboRoom.Text)
                Else
                    MsgBox("The bed have already! Could you change to other one.", MsgBoxStyle.Critical)
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo)
            If DIALOG_UPDATE = DialogResult.Yes Then
                '  If CheckBed(txtBed.Text.Trim) = False Then
                ModRoomAndBed.UpdateBed(lblBedNo.Text, CboRoom.Text, txtBed.Text, TxtDescription.Text)
                'GeneratListView(CboRoom.Text)
                'Else
                '    MsgBox("The bed have already! Could you change to other one.", MsgBoxStyle.Critical)
                'End If

            End If
        End If

    End Sub
    Function checkTagGroup(ByVal tagVal As String) As ListViewGroup
        Dim i As Int16
        Dim lsGroup As ListViewGroup = Nothing
        For i = 0 To lsBed.Groups.Count - 1
            If lsBed.Groups.Item(i).Tag = tagVal Then
                lsGroup = lsBed.Groups.Item(i)
                lsGroup.Header = "Room : " & tagVal & "   Total Bed : " & lsBed.Groups.Item(i).Items.Count

            End If
        Next
        Return lsGroup
    End Function
    Sub GeneratListView(ByVal room As String)
        Dim tblBed As DataTable = ModRoomAndBed.SelectBed(room)
        Dim dRow As DataRow
        Dim dRowSub As DataRow
        Dim ListSubItem As ListViewItem
        Dim index As Integer
        Dim indexsub As Integer
        Dim listGroup As ListViewGroup

        Dim roomName As String
        lsBed.Items.Clear()
        If tblBed Is Nothing Then
            Exit Sub
        End If
        For index = 0 To tblBed.Rows.Count - 1
            dRow = tblBed.Rows(index)
            roomName = dRow(1).ToString

            ListSubItem = lsBed.Items.Add(dRow(2).ToString)
            lsBed.Items(index).SubItems.Add(dRow(0).ToString)
            lsBed.Items(index).SubItems.Add(dRow(1).ToString)
            lsBed.Items(index).SubItems.Add(dRow(3).ToString)
            lsBed.Items(index).SubItems.Add(dRow(4).ToString)

            If dRow(4).ToString = "True" Then
                lsBed.Items(index).ForeColor = Color.Red
                ListSubItem.ImageIndex = 0
            Else
                lsBed.Items(index).ForeColor = Color.Blue
                ListSubItem.ImageIndex = 1
            End If
            For indexsub = 0 To tblBed.Rows.Count - 1
                dRowSub = tblBed.Rows(indexsub)
                If roomName = dRowSub(1) Then
                    listGroup = Me.checkTagGroup(roomName)
                    If listGroup Is Nothing Then
                        listGroup = New ListViewGroup
                        listGroup.Header = "Room : " & roomName & "   Total Bed : " & 1
                        listGroup.Tag = roomName
                    End If
                    lsBed.Groups.Add(listGroup)
                    lsBed.Items(index).Group = listGroup
                End If
            Next
        Next
    End Sub
   
    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lsBed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsBed.SelectedIndexChanged

        If lsBed.SelectedIndices.Count > 0 Then
            Dim index As Integer = lsBed.SelectedIndices(0)
            txtBed.Text = lsBed.Items(index).Text
            lblBedNo.Text = lsBed.Items(index).SubItems(1).Text
            CboRoom.Text = lsBed.Items(index).SubItems(2).Text
            TxtDescription.Text = lsBed.Items(index).SubItems(3).Text
        End If

    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        GridRoom.DataSource = ModRoomAndBed.SelectRoom(TxtFindRoom.Text)
    End Sub

    
    Private Sub GridRoom_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridRoom.SelectionChanged
        Try
            Dim RowIndex As Integer = GridRoom.SelectedCells(0).RowIndex
            Dim Name As String = GridRoom.Rows(RowIndex).Cells(1).Value
            GeneratListView(Name)
        Catch ex As Exception

        End Try

    End Sub
End Class