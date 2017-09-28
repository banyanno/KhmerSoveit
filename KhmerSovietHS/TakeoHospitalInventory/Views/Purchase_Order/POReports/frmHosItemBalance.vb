Public Class frmHosItemBalance

    Dim CateDataAdapter As DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim CrItemBalanceInHos As New CRItemBalanceInHos
    Dim DAHosItemBalance As DSCategoriesAndItemsTableAdapters.V_HosItemsTableAdapter


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CateDataAdapter = New DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        DAHosItemBalance = New DSCategoriesAndItemsTableAdapters.V_HosItemsTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmHosItemBalance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            '---Load Information
            With CBCate
                .DataSource = CateDataAdapter.GetData
                .ValueMember = "CateID"
                .DisplayMember = "CateName"
                .SelectedIndex = -1
            End With

            '--- Department
            With CBDepart
                .DataSource = DepartDataAdapter.GetData
                .ValueMember = "DepartID"
                .DisplayMember = "DepartName"
                .SelectedIndex = -1
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewReport.Click

        Me.ContainerCtr.Visible = True
        Application.DoEvents()
        BackgroundLoadReport.RunWorkerAsync()

    End Sub

    Sub GenerateDataToReport()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf GenerateDataToReport))
        Else
            If ChBAllItem.Checked = False Then
                If ValidateCombobox(CBCate, "", ErrorCtr) = False Then Exit Sub
            End If

            If ChBAllDepart.Checked = False Then
                If ValidateCombobox(CBDepart, "", ErrorCtr) = False Then Exit Sub
            End If

            If ChBAllDepart.Checked = True And ChBAllItem.Checked = True Then
                Dim ItemBalanceInHosDT As DataTable = DAHosItemBalance.GetData
                CrItemBalanceInHos.SetDataSource(ItemBalanceInHosDT)
                CrItemBalanceInHos.SetParameterValue("PCate", "All Items")
                CRVReportViewer.ReportSource = CrItemBalanceInHos
                CRVReportViewer.Refresh()

            ElseIf ChBAllDepart.Checked = False And ChBAllItem.Checked = False Then

                Dim ItemBalanceInHosDT As DataTable = DAHosItemBalance.GetDataByDepartAndCate(CBDepart.SelectedValue, CBCate.SelectedValue)
                CrItemBalanceInHos.SetDataSource(ItemBalanceInHosDT)
                CrItemBalanceInHos.SetParameterValue("PCate", CBCate.Text)
                CRVReportViewer.ReportSource = CrItemBalanceInHos
                CRVReportViewer.Refresh()
            ElseIf ChBAllDepart.Checked = True And ChBAllItem.Checked = False Then

                Dim ItemBalanceInHosDT As DataTable = DAHosItemBalance.GetDataByCate(CBCate.SelectedValue)
                CrItemBalanceInHos.SetDataSource(ItemBalanceInHosDT)
                CrItemBalanceInHos.SetParameterValue("PCate", CBCate.Text)
                CRVReportViewer.ReportSource = CrItemBalanceInHos
                CRVReportViewer.Refresh()
            Else
                Dim ItemBalanceInHosDT As DataTable = DAHosItemBalance.GetDataByDepart(CBDepart.SelectedValue)
                CrItemBalanceInHos.SetDataSource(ItemBalanceInHosDT)
                CrItemBalanceInHos.SetParameterValue("PCate", "All Items")
                CRVReportViewer.ReportSource = CrItemBalanceInHos
                CRVReportViewer.Refresh()
            End If
        End If
    End Sub

    Private Sub ChBAllItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllItem.CheckedChanged

        If ChBAllItem.Checked = True Then
            CBCate.Enabled = False
        Else
            CBCate.Enabled = True
        End If
    End Sub

    Private Sub ChBAllDepart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllDepart.CheckedChanged

        If ChBAllDepart.Checked = True Then
            CBDepart.Enabled = False
        Else
            CBDepart.Enabled = True
        End If
    End Sub

    Private Sub BackgroundLoadReport_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundLoadReport.DoWork
        GenerateDataToReport()
    End Sub

    Private Sub BackgroundLoadReport_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundLoadReport.RunWorkerCompleted
        Application.DoEvents()
        Me.ContainerCtr.Visible = False
    End Sub

End Class