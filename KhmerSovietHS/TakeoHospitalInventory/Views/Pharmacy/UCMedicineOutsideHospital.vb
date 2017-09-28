Imports Janus.Windows.GridEX

Public Class UCMedicineOutsideHospital

    'Dim MedicineOutsideHosDataAdapter As DSPharmacyTableAdapters.ITEM_OUTSIDE_INVENTORYTableAdapter
    Dim MedicineOutsideHosDataAdapter As DSPharmacyTableAdapters.V_ITEM_OUTSIDE_INVENTableAdapter
    Dim MedicineOutsideHosTransDataAdapter As DSPharmacyTableAdapters.V_ITEM_OUTSIDE_TRANSTableAdapter

    Private Sub UCMedicineOutsideHospital_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'MedicineOutsideHosDataAdapter = New DSPharmacyTableAdapters.ITEM_OUTSIDE_INVENTORYTableAdapter
        MedicineOutsideHosDataAdapter = New DSPharmacyTableAdapters.V_ITEM_OUTSIDE_INVENTableAdapter
        MedicineOutsideHosTransDataAdapter = New DSPharmacyTableAdapters.V_ITEM_OUTSIDE_TRANSTableAdapter
        LoadGridMedicineOutsideHospital()
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Sub LoadGridMedicineOutsideHospital()
        gridMedicineOutsideHospital.DataSource = MedicineOutsideHosDataAdapter.GetData
    End Sub

    Private Sub BtnRefreshPrescrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshPrescrip.Click
        LoadGridMedicineOutsideHospital()
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub BtnMedicineOutsideHospital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedicineOutsideHospital.Click
        Try
            '---- print request order ----------
            Dim FRptRequestView As New frmReportViewer
            FRptRequestView.ReportOption = 8
            If FRptRequestView.ShowDialog = DialogResult.OK Then
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnItemOutsideHos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemOutsideHos.Click

        Dim frmItemOutside As New frmItemOutsideHospital(Me)
        frmItemOutside.lblSaveOption.Text = "0"
        If frmItemOutside.ShowDialog() = DialogResult.OK Then
            'Me.FillDataByItemName(frmItemOutside.TxtItemName.Text)
            LoadGridMedicineOutsideHospital()
        End If
        frmItemOutside.Close()
        frmItemOutside.Dispose()

    End Sub

    'Public Sub FillDataByItemName(ByVal ItemName As String)
    '    gridMedicineOutsideHospital.DataSource = MedicineOutsideHosDataAdapter.GetItemDataOutsideFilterByItemName(ItemName)
    'End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If Not gridMedicineOutsideHospital.CurrentRow Is Nothing AndAlso gridMedicineOutsideHospital.CurrentRow.RowType = RowType.Record Then

            Dim frmItemOutside As New frmItemOutsideHospital(Me)
            frmItemOutside.lblSaveOption.Text = "1"
            frmItemOutside.TxtItemName.Text = gridMedicineOutsideHospital.GetValue("ItemName")
            frmItemOutside.TxtHiddenItemName.Text = gridMedicineOutsideHospital.GetValue("ItemName")
            frmItemOutside.ID = gridMedicineOutsideHospital.GetValue("ItemID")
            frmItemOutside.ShowDialog()
            frmItemOutside.Close()
            frmItemOutside.Dispose()

            LoadGridMedicineOutsideHospital()
          
        End If
    End Sub

    Private Sub BtnViewItemOutsideTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewItemOutsideTrans.Click
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = False
    End Sub

    Private Sub gridMedicineOutsideHospital_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridMedicineOutsideHospital.SelectionChanged

        If Not gridMedicineOutsideHospital.CurrentRow Is Nothing AndAlso gridMedicineOutsideHospital.CurrentRow.RowType = RowType.Record Then
            gridItemOutsideTrans.DataSource = MedicineOutsideHosTransDataAdapter.GetDataItemOutsideTrans(gridMedicineOutsideHospital.GetValue("ItemName"), dptFromDate.Value.Date, dptToDate.Value.Date)
        End If

    End Sub

    Private Sub dptFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dptFromDate.ValueChanged
        If Not gridMedicineOutsideHospital.CurrentRow Is Nothing AndAlso gridMedicineOutsideHospital.CurrentRow.RowType = RowType.Record Then
            gridItemOutsideTrans.DataSource = MedicineOutsideHosTransDataAdapter.GetDataItemOutsideTrans(gridMedicineOutsideHospital.GetValue("ItemName"), dptFromDate.Value.Date, dptToDate.Value.Date)
        End If
    End Sub

    Private Sub dptToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dptToDate.ValueChanged
        If Not gridMedicineOutsideHospital.CurrentRow Is Nothing AndAlso gridMedicineOutsideHospital.CurrentRow.RowType = RowType.Record Then
            gridItemOutsideTrans.DataSource = MedicineOutsideHosTransDataAdapter.GetDataItemOutsideTrans(gridMedicineOutsideHospital.GetValue("ItemName"), dptFromDate.Value.Date, dptToDate.Value.Date)
        End If
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try
            '---- print request order ----------
            Dim FRptRequestView As New frmReportViewer
            FRptRequestView.FDate = DTPFrom.Value.Date
            FRptRequestView.TDate = DTPTo.Value.Date
            FRptRequestView.ReportOption = 8
            If FRptRequestView.ShowDialog = DialogResult.OK Then
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
