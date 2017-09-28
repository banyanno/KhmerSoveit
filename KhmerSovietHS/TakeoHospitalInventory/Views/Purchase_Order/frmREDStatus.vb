Public Class frmREDStatus


    Dim DSShowAllItemBalance As New DSEndofDayRun
    Dim DAEachItemIndepart As New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
    Dim DADepartment As New DSEndofDayRunTableAdapters.tblDepartmentTableAdapter
    Dim EndofDayRepo As IEndofDayRepository = New EndofDayRepository
    Public myDateRED As Date

    Sub CheckDepartmentEODStatus()

        'IsRunEndofDayInParticularDay

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
            If EndofDayRepo.IsRunEndofDayInParticularDay(CInt(DRow(0).ToString), myDateRED) = False Then
                LVITem.ImageIndex = 0
            Else
                LVITem.ImageIndex = 1
            End If
            LVITem.SubItems.Add(DRow(0).ToString)
        Next

    End Sub

    Private Sub frmREDStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = "Run End of Day Status " & Format(myDateRED, "dd/MMM/yyyy")
        CheckDepartmentEODStatus()

    End Sub


End Class