Public Class UIShowAllItemBalanceInDeppartment

    Dim DSShowAllItemBalance As New DSEndofDayRun
    Dim DAEachItemIndepart As New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
    Dim DADepartment As New DSEndofDayRunTableAdapters.tblDepartmentTableAdapter
    Dim EndofDayRepo As IEndofDayRepository = New EndofDayRepository

    Dim CateAndItemDS As New DSCategoriesAndItems
    Dim DepartmentDataAdapter As New DSCategoriesAndItemsTableAdapters.tblDepartmentTableAdapter
    Dim VItemListInDepartDataAdapter As New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim MTakeoInventory As MainTakeoInventory
    Sub New(ByVal MTakeoInventory1 As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MTakeoInventory = MTakeoInventory1
    End Sub

    Sub FillDataAllDepartment()
        DepartmentDataAdapter.GetData()
        DepartmentDataAdapter.Fill(CateAndItemDS.tblDepartment)
        VItemListInDepartDataAdapter.GetData()
        VItemListInDepartDataAdapter.Fill(CateAndItemDS.VItemListInDepart)
    End Sub

    
    Private Sub BtnEODStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CheckDepartmentEODStatus()
        frmREDStatus.myDateRED = dptDate.Value.Date
        frmREDStatus.ShowDialog()
    End Sub

    Private Sub btnDepartCurrentStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepartCurrentStock.Click
        btnDepartCurrentStock.Enabled = False
        BgCheckRunEOD.RunWorkerAsync()

    End Sub

    Private Sub dptDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dptDate.ValueChanged

        CheckDepartmentEODStatus()
    End Sub
    Sub CheckDepartmentEODStatus()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf CheckDepartmentEODStatus))
        Else
            'IsRunEndofDayInParticularDay
            GroupStatus.Text = "Run End of Day Status " & Format(dptDate.Value.Date, "dd/MMM/yyyy")
            Dim tblDep As DataTable = DADepartment.GetData
            Dim LVITem As ListViewItem
            Dim DRow As DataRow
            LVDepStatus.Items.Clear()
            If tblDep Is Nothing Then
                Exit Sub
            End If
            For index As Integer = 0 To tblDep.Rows.Count - 1
                DRow = tblDep.Rows(index)
                LVITem = LVDepStatus.Items.Add(DRow(1).ToString)
                If EndofDayRepo.IsRunEndofDayInParticularDay(CInt(DRow(0).ToString), dptDate.Value.Date) = False Then
                    LVITem.ImageIndex = 0
                Else
                    LVITem.ImageIndex = 1
                End If
                LVITem.SubItems.Add(DRow(0).ToString)
            Next
        End If
    End Sub

   
    Private Sub BgCheckRunEOD_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgCheckRunEOD.RunWorkerCompleted
        GridAllItemBalance.DataSource = CateAndItemDS.tblDepartment
        GridAllItemBalance.RootTable.ChildTables(0).DataMember = "tblDepartment_VItemListInDepart"
        btnDepartCurrentStock.Enabled = True
        Application.DoEvents()
        MTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub BgCheckRunEOD_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgCheckRunEOD.DoWork
        MTakeoInventory.StatusLoading(True)
        FillDataAllDepartment()
        CheckDepartmentEODStatus()
    End Sub

    Private Sub BtnViewItemBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewItemBalance.Click

        Dim FHosItemBalance As New frmHosItemBalance
        If FHosItemBalance.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FHosItemBalance.Close()
            FHosItemBalance.Dispose()
        End If

    End Sub

  
End Class
