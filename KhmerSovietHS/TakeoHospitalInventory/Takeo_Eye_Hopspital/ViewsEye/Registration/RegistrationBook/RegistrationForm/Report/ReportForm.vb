Public Class ReportForm
    Dim reportFormRegistration As New RegistrationForm
    Dim tbl As DataTable
    Dim RegisFormV2 As New RegistrationFormV2
    Dim DA_PReferralDetail As New DSPatientFormTableAdapters.REFFERAL_PATIENT_DETAILTableAdapter
    Sub LoadRegistrationForm()
        tbl = TblPatientReferalTableAdapter.GetDataByPatienNo(GLOBLE_PATIENT_NO)
        reportFormRegistration.SetDataSource(tbl)
        '  reportFormRegistration.PrintToPrinter(1, True, 1, 1000)
        ReportviewerForm.ReportSource = reportFormRegistration
        reportFormRegistration.Refresh()
    End Sub
    Sub LoadRegistrationFormV2()
        tbl = TblPatientReferalTableAdapter.GetDataByPatienNo(GLOBLE_PATIENT_NO)
        Dim tblPatientReferral As DataTable = DA_PReferralDetail.GetDataByPatientNo(GLOBLE_PATIENT_NO)
        RegisFormV2.SetDataSource(tbl)
        RegisFormV2.Subreports("PatientReferralList").SetDataSource(tblPatientReferral)
        ReportviewerForm.ReportSource = RegisFormV2
        RegisFormV2.Refresh()
    End Sub
End Class