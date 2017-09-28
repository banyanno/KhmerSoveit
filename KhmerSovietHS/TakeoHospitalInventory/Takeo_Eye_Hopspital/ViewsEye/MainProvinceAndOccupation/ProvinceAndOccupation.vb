Public Class UCProvinceAndOccupation

    Private Sub GridProvince_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridProvince.SelectionChanged
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridProvince)
            Dim ProvinNo As String = GridProvince.Rows(index).Cells(0).Value
            GridDistrict.DataSource = ModProvince.SelectDistrict(ProvinNo)
            ModCommon.NumberAllRowHeaderDataGrid(GridDistrict)
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub GridDistrict_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDistrict.SelectionChanged
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridDistrict)
            Dim DistrictNo As String = GridDistrict.Rows(index).Cells(0).Value
            GridCommune.DataSource = ModProvince.SelectCommune(DistrictNo)
            ModCommon.NumberAllRowHeaderDataGrid(GridCommune)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDistrict.Click
        Try
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridProvince)
            Dim ProvinceNo As Integer = GridProvince.Rows(Index).Cells(0).Value
            Dim fNewDistrict As New FrmNewDistrict
            fNewDistrict.LblProvinceNo.Text = ProvinceNo
            If fNewDistrict.ShowDialog() = DialogResult.OK Then
                GridDistrict.DataSource = ModProvince.SelectDistrict(ProvinceNo)
                ModCommon.NumberAllRowHeaderDataGrid(GridDistrict)
            End If
            fNewDistrict.Close()
            fNewDistrict.Dispose()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridDistrict)
            Dim DistrictNo As Integer = GridDistrict.Rows(Index).Cells(0).Value
            Dim IndexPro As Integer = ModCommon.GetRowIndexDataGrid(GridProvince)
            Dim ProvinceNo As Integer = GridProvince.Rows(IndexPro).Cells(0).Value
            Dim fCommune As New FNewCommune
            fCommune.lblProvince.Text = ProvinceNo
            fCommune.LblDistric.Text = DistrictNo
            If fCommune.ShowDialog() = DialogResult.OK Then
                GridCommune.DataSource = ModProvince.SelectCommune(DistrictNo)
                ModCommon.NumberAllRowHeaderDataGrid(GridCommune)
            End If
            fCommune.Close()
            fCommune.Dispose()
        Catch ex As Exception

        End Try
    End Sub

   


    Private Sub BtnNewReferTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReferTo.Click
        Dim FNewRefer As New FrmNewReferOrg
        If FNewRefer.ShowDialog() = DialogResult.OK Then
            GridOrgRefer.DataSource = ModRefer.SelectRefer()
            ModCommon.NumberAllRowHeaderDataGrid(GridOrgRefer)
        End If

        FNewRefer.Close()
        FNewRefer.Dispose()
    End Sub

    Private Sub BtnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadData.Click
        GridOrgRefer.DataSource = ModRefer.SelectRefer()
        ModCommon.NumberAllRowHeaderDataGrid(GridOrgRefer)
    End Sub


    Private Sub BtnNewOccupation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewOccupation.Click
        Dim FNewOccupation As New FrmNewOccupation
        If FNewOccupation.ShowDialog() = DialogResult.OK Then
            GridOccupation.DataSource = ModOccupation.SelectAllOccupation()
            ModCommon.NumberAllRowHeaderDataGrid(GridOccupation)
        End If
        FNewOccupation.Close()
        FNewOccupation.Dispose()
    End Sub

    Private Sub BtnLoadOccupation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadOccupation.Click
        GridOccupation.DataSource = ModOccupation.SelectAllOccupation()
        ModCommon.NumberAllRowHeaderDataGrid(GridOccupation)
    End Sub

    Private Sub BtnProvince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProvince.Click
        GridProvince.DataSource = ModProvince.SelectProvice
        ModCommon.NumberAllRowHeaderDataGrid(GridProvince)
    End Sub

    Private Sub GridOrgRefer_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOrgRefer.CellContentDoubleClick
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOrgRefer)
            Dim ReferNo As Integer = GridOrgRefer.Rows(index).Cells(0).Value
            Dim Refer As String = GridOrgRefer.Rows(index).Cells(1).Value
            Dim Note As String = GridOrgRefer.Rows(index).Cells(2).Value
            Dim fNewRefer As New FrmNewReferOrg
            fNewRefer.lblSaveOption.Text = ReferNo
            fNewRefer.TxtReferName.Text = Refer
            fNewRefer.TxtNote.Text = Note
            If fNewRefer.ShowDialog() = DialogResult.OK Then
                GridOrgRefer.DataSource = ModRefer.SelectRefer()
                ModCommon.NumberAllRowHeaderDataGrid(GridOrgRefer)
            End If
            fNewRefer.Close()
            fNewRefer.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridOccupation_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOccupation.CellContentDoubleClick

        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOccupation)
            Dim OccuNo As Integer = GridOccupation.Rows(index).Cells(0).Value
            Dim Occupation As String = GridOccupation.Rows(index).Cells(1).Value
            Dim FOccupation As New FrmNewOccupation
            FOccupation.LblSaveOption.Text = OccuNo
            FOccupation.TxtOccupation.Text = Occupation
            If FOccupation.ShowDialog() = DialogResult.OK Then
                GridOccupation.DataSource = ModOccupation.SelectAllOccupation()
                ModCommon.NumberAllRowHeaderDataGrid(GridOccupation)
            End If
            FOccupation.Close()
            FOccupation.Dispose()
        Catch ex As Exception

        End Try

    End Sub

   

   

    Private Sub GridDistrict_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDistrict.DoubleClick
        Try
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridDistrict)
            Dim DistrictNo As Integer = GridDistrict.Rows(Index).Cells("DistrictNo").Value
            Dim ProvinNo As Integer = GridDistrict.Rows(Index).Cells("ProvinceNo").Value
            Dim District As String = GridDistrict.Rows(Index).Cells("District").Value
            Dim fNewDistrict As New FrmNewDistrict
            fNewDistrict.LblSaveOption.Text = DistrictNo
            fNewDistrict.TxtDistrictCode.Text = DistrictNo
            fNewDistrict.TxtDistrictCode.ReadOnly = True
            fNewDistrict.TxtDistrict.Text = District
            If fNewDistrict.ShowDialog() = DialogResult.OK Then
                GridDistrict.DataSource = ModProvince.SelectDistrict(ProvinNo)
                ModCommon.NumberAllRowHeaderDataGrid(GridDistrict)
            End If
            fNewDistrict.Close()
            fNewDistrict.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridCommune_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCommune.DoubleClick
        Try
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridCommune)
            Dim CommuneNo As Integer = GridCommune.Rows(Index).Cells(2).Value
            Dim DistrictNo As String = GridCommune.Rows(Index).Cells(1).Value
            Dim ProvinceNo As String = GridCommune.Rows(Index).Cells(0).Value
            Dim Commune As String = GridCommune.Rows(Index).Cells(3).Value
            Dim fCommune As New FNewCommune
            fCommune.LblSaveOption.Text = CommuneNo
            fCommune.LblDistric.Text = DistrictNo
            fCommune.lblProvince.Text = ProvinceNo
            fCommune.TxtCommuneCode.Text = CommuneNo
            fCommune.TxtCommuneCode.ReadOnly = True
            fCommune.TxtCommune.Text = Commune.Trim
            If fCommune.ShowDialog() = DialogResult.OK Then
                GridCommune.DataSource = ModProvince.SelectCommune(DistrictNo)
                ModCommon.NumberAllRowHeaderDataGrid(GridCommune)
            End If
            fCommune.Close()
            fCommune.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class
