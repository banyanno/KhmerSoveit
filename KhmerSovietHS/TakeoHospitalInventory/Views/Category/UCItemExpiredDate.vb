Public Class UCItemExpiredDate
    Dim MTakeoInventory As MainTakeoInventory
    Dim DTItem As New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim DTItemExpiredDateList As New DSCategoriesAndItemsTableAdapters.VItemExpiredListTableAdapter
    Dim DTCategory As New DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
    Dim RptItemExpiredDate As New CrItemExpiredDate

    Public Sub New(ByVal MTakeoInventory As MainTakeoInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        InitCategory()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub InitCategory()
        With CboCategory
            .DataSource = DTCategory.GetData
            .ValueMember = "CateID"
            .DisplayMember = "CateName"
            .SelectedIndex = -1
        End With
    End Sub


    Private Sub ChBAllItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllItem.CheckedChanged
        If ChBAllItem.Checked = True Then
            CBItem.Enabled = False
        Else
            CBItem.Enabled = True
        End If
    End Sub


    Private Sub ChBActivePeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBActivePeriod.CheckedChanged
        If ChBActivePeriod.Checked = True Then
            DTPFDate.Enabled = True
            DTPToDate.Enabled = True
        Else
            DTPFDate.Enabled = False
            DTPToDate.Enabled = False
        End If
    End Sub

    Private Sub UCItemExpiredDate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '--- Get list item
        With CBItem
            .DataSource = DTItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        BGWExpiredDate.RunWorkerAsync()
    End Sub

    Private Sub BGWExpiredDate_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWExpiredDate.DoWork
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        Me.ViewData()
    End Sub
    Private Sub BGWExpiredDate_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWExpiredDate.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub

    Sub ViewData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewData))
        Else            
            Dim IsViewReport As Integer = ControlPanelDisplay() ' Return 1 (report) , 0 (table)
            If IsViewReport = 1 Then
                Dim DTItemExpiredDate As New DataTable
                'If ChBAllItem.Checked = True Then
                '    If ChBActivePeriod.Checked = False Then
                '        DTItemExpiredDate = DTItemExpiredDateList.GetData
                '    Else
                '        DTItemExpiredDate = DTItemExpiredDateList.GetItemExpiredDateInPeriod(DTPFDate.Value.Date, DTPToDate.Value.Date)
                '    End If
                'Else '--- Get the specific item
                '    If ChBActivePeriod.Checked = False Then
                '        DTItemExpiredDate = DTItemExpiredDateList.GetExpiredDateByItemID(CBItem.SelectedValue)
                '    Else
                '        DTItemExpiredDate = DTItemExpiredDateList.GetExpiredDateByItemIDInPeriod(EmptyString(CBItem.SelectedValue), DTPFDate.Value.Date, DTPToDate.Value.Date)
                '    End If
                'End If
                If ChCategory.Checked = True Then
                    If ChBActivePeriod.Checked = False Then
                        DTItemExpiredDate = DTItemExpiredDateList.GetData
                    Else
                        DTItemExpiredDate = DTItemExpiredDateList.GetItemExpiredDateInPeriod(DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If
                Else
                    If ChBActivePeriod.Checked = False Then
                        DTItemExpiredDate = DTItemExpiredDateList.GetDataByCategoryID(CboCategory.SelectedValue)
                    Else
                        DTItemExpiredDate = DTItemExpiredDateList.GetDataByCategoryID_With_Period(CboCategory.SelectedValue, DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If

                End If
                RptItemExpiredDate.SetDataSource(DTItemExpiredDate)
                If ChBActivePeriod.Checked = True Then
                    RptItemExpiredDate.SetParameterValue("fromDate", Format(DTPFDate.Value.Date, "dd/MMM/yyyy"))
                    RptItemExpiredDate.SetParameterValue("toDate", Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))
                Else
                    RptItemExpiredDate.SetParameterValue("fromDate", "")
                    RptItemExpiredDate.SetParameterValue("toDate", "")
                End If
                CRVReportViewer.ReportSource = RptItemExpiredDate
                CRVReportViewer.Refresh()
            Else
                'If ChBAllItem.Checked = True Then
                '    If ChBActivePeriod.Checked = False Then
                '        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetData
                '    Else
                '        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetItemExpiredDateInPeriod(DTPFDate.Value.Date, DTPToDate.Value.Date)
                '    End If
                'Else '--- Get the specific item
                '    If ChBActivePeriod.Checked = False Then
                '        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetExpiredDateByItemID(CBItem.SelectedValue)
                '    Else
                '        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetExpiredDateByItemIDInPeriod(CBItem.SelectedValue, DTPFDate.Value.Date, DTPToDate.Value.Date)
                '    End If
                'End If
                If ChCategory.Checked = True Then
                    If ChBActivePeriod.Checked = False Then
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetData
                    Else
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetItemExpiredDateInPeriod(DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If
                Else
                    If ChBActivePeriod.Checked = False Then
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetDataByCategoryID(CboCategory.SelectedValue)
                    Else
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetDataByCategoryID_With_Period(CboCategory.SelectedValue, DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If

                End If

            End If
        End If
    End Sub

    Function ControlPanelDisplay() As Integer
        If RBViewReport.Checked = True Then ' View as report
            SplitContainer2.Panel1Collapsed = True
            SplitContainer2.Panel2Collapsed = False
            Return 1
        Else ' View as table
            SplitContainer2.Panel1Collapsed = False
            SplitContainer2.Panel2Collapsed = True
            Return 0
        End If
    End Function

    
    Private Sub ChCategory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChCategory.CheckedChanged
        If ChCategory.Checked = True Then
            CboCategory.Enabled = False
        Else
            CboCategory.Enabled = True
        End If

    End Sub
End Class
