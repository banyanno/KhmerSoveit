Imports CrystalDecisions.Shared

Public Class DashboardListCosult
    Dim DA_DRConsult As New DSConsultHistoryTableAdapters.S_DOCTOR_CONSULTTableAdapter
    Dim DA_USER As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDoctor
            .DataSource = DA_USER.GetDataUserByGroup(36)
            .ValueMember = "UserID"
            .DisplayMember = "UserName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click

        Dim DoctorConsult As New DoctorConsultlist
        Dim TblDrConsult As DataTable
        If ChDoctor.Checked = True Then
            TblDrConsult = DA_DRConsult.SelectDateToDateWithDoctor(DateFrom.Value.Date, DateTo.Value.Date, CInt(CboDoctor.SelectedValue))
        Else
            TblDrConsult = DA_DRConsult.SelectDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        End If

        DoctorConsult.SetDataSource(TblDrConsult)
        DoctorConsult.SetParameterValue("Title", "From: " & DateFrom.Text & " To: " & DateTo.Text)
        ' Declare for export Big app form
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\DRConsult.pdf"
        CrExportOptionsBig = DoctorConsult.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        DoctorConsult.Export()
        Application.DoEvents()
        Application.DoEvents()
        AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\DRConsult.pdf"
        AxAcroPDF1.setZoom(100)
    End Sub

    Private Sub ChDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDoctor.CheckedChanged
        CboDoctor.Enabled = ChDoctor.Checked
    End Sub
End Class
