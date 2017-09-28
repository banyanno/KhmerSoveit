Imports CrystalDecisions.Shared

Public Class FormReportHistory
    Dim DA_History As New DSConsultHistoryTableAdapters.S_REPORT_HISTORYTableAdapter
    Dim DA_Patient_Image As New DSConsultHistoryTableAdapters.S_PATIENT_IMAGE_VIEWTableAdapter
    Dim DA_VA As New DSWaitingConsultTableAdapters.S_VISUAL_ACUITYTableAdapter
    Private Sub FormReportHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim DA_PrescHist As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter
    Public Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Dim RPHistory As New ReportPatientHistory
        Dim TblPHistory As DataTable = DA_History.SelectHistoryPatientNo(EmptyString(TxtPatientNo.Text))
        Dim tblImgHistory As DataTable = DA_Patient_Image.SelectPatientNo(EmptyString(TxtPatientNo.Text))
        Dim TblVA As DataTable = DA_VA.SelectVAByPatientNo(EmptyString(TxtPatientNo.Text))
        Dim TblPresc As DataTable = DA_PrescHist.SelectPresPatientNo(EmptyString(TxtPatientNo.Text))
        RPHistory.SetDataSource(TblPHistory)
        RPHistory.Subreports("Finding").SetDataSource(TblVA)
        RPHistory.Subreports("VA").SetDataSource(TblVA)
        RPHistory.Subreports("ResultDiagnosis").SetDataSource(TblPHistory)
        RPHistory.Subreports("ManagePatient").SetDataSource(TblPHistory)
        RPHistory.Subreports("PatientImages").SetDataSource(tblImgHistory)
        RPHistory.Subreports("CryPrescription").SetDataSource(TblPresc)
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\PatientHistory.pdf"
        CrExportOptionsBig = RPHistory.ExportOptions

        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With

        RPHistory.Export()
        AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\PatientHistory.pdf"
        AxAcroPDF1.setZoom(100)
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class