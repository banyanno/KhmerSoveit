Public Class DashboardDoctorConsult
    Dim DA_Waiting_View As New DSWaitingConsultTableAdapters.S_WAITING_VIEWTableAdapter
    Dim DAPatient As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    Dim DA_VA As New DSWaitingConsultTableAdapters.S_VISUAL_ACUITYTableAdapter
    Dim DA_History As New DSConsultHistoryTableAdapters.S_REPORT_HISTORYTableAdapter
    Dim DA_ImageDiagnosis As New DSWaitingConsultTableAdapters.S_IMAGE_DIAGNOSISTableAdapter
    Dim DA_Waiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Dim DA_Doctor As New DSWaitingConsultTableAdapters.VUsersInGroupTableAdapter
    Dim DA_HistoryFollowUp As New DSConsultHistoryTableAdapters.S_FOLLOWUPTableAdapter
    Dim DAFollowUP As New DSWaitingConsultTableAdapters.S_PATIENT_FOLLOWUPTableAdapter
    Dim DA_PresciptionV1 As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter


    '==================== Operation Note ============================================
    Private THIDataContext As New BaseDataContext
    Private OLD_IOLID As Integer
    Dim ItemListInDepartDataAdapter As New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim DA_Item_Department As New DSOTCurrentStoctTableAdapters.tblDeptStockTableAdapter


    Dim DS_OPERATION As New DSOPERATIONNOTE
    Dim DA_OP As New DSOPERATIONNOTETableAdapters.View_OTRegistrationTableAdapter
    Dim DA_ScleralBuckling As New DSOPERATIONNOTETableAdapters.S_OPER_SCLERAL_BUCKLINGTableAdapter
    Dim DA_Intravitreal_Injection As New DSOPERATIONNOTETableAdapters.S_OPER_INJECTIONTableAdapter
    Dim DA_General_Operative As New DSOPERATIONNOTETableAdapters.S_OPER_GENERAL_OPERATIVETableAdapter
    Dim DA_Phacoe As New DSOPERATIONNOTETableAdapters.S_OPER_PHACOEMULSIFICATIONTableAdapter
    Dim DA_ECCE As New DSOPERATIONNOTETableAdapters.S_OPERA_ECCETableAdapter
    Dim DA_ParPlana As New DSOPERATIONNOTETableAdapters.S_OPER_PAR_PLANA_VITRECTOMYTableAdapter
    Dim DA_Trab As New DSOPERATIONNOTETableAdapters.S_OPER_TRABECULECTOMYTableAdapter
    Dim DA_Ptery As New DSOPERATIONNOTETableAdapters.S_OPER_PTERYGIUMTableAdapter
    ' Create report instance
    Dim CRV_ScleralBuckling As New FormScleralBuckling1
    Dim CRV_Injection As New FormIntravitrealInjection1
    Dim CRV_GeneralOperative As New GeneralOperativeNote1
    Dim CRV_Phacoemulsification As New Phacoemulsification1
    Dim CRV_ECCE As New ECCE
    Dim CRV_PA_PLANA As New ParPlanaVitrectomy1
    Dim CRV_Trab As New Trabeculectomy1
    Dim CRV_Ptery As New PterygiumExcision


    ' Insert in case patient follow up
    Dim DAPatientWaiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub ShowOperationHistory(ByVal PatientNo As Double)

        DA_OP.FillBy1(DS_OPERATION.View_OTRegistration, PatientNo)
        GridOT.DataSource = DS_OPERATION.View_OTRegistration
        DA_ScleralBuckling.Fill(DS_OPERATION.S_OPER_SCLERAL_BUCKLING)
        DA_Intravitreal_Injection.Fill(DS_OPERATION.S_OPER_INJECTION)
        DA_General_Operative.Fill(DS_OPERATION.S_OPER_GENERAL_OPERATIVE)
        DA_Phacoe.Fill(DS_OPERATION.S_OPER_PHACOEMULSIFICATION)
        DA_ECCE.Fill(DS_OPERATION.S_OPERA_ECCE)
        DA_ParPlana.Fill(DS_OPERATION.S_OPER_PAR_PLANA_VITRECTOMY)
        DA_Trab.Fill(DS_OPERATION.S_OPER_TRABECULECTOMY)
        DA_Ptery.Fill(DS_OPERATION.S_OPER_PTERYGIUM)

        GridOT.RootTable.ChildTables(0).DataMember = "OperationNotesScleral"
        GridOT.RootTable.ChildTables(1).DataMember = "OperInjection"
        GridOT.RootTable.ChildTables(2).DataMember = "GENERAL_OPERATIVE"
        GridOT.RootTable.ChildTables(3).DataMember = "Oper_Phacoemul"
        GridOT.RootTable.ChildTables(4).DataMember = "Oper_ECCE"
        GridOT.RootTable.ChildTables(5).DataMember = "OperParPlana"
        GridOT.RootTable.ChildTables(6).DataMember = "S_OPER_TRABECULECTOMY"
        GridOT.RootTable.ChildTables(7).DataMember = "S_OPER_PTERYGIUM"
        '  GridOT.ChildTables(0).DataMember = ""
        'GridOTRegistration.DataSource = ModOTRegistration.SelectListOT(TxtPatientNo.Text)
        'GridOT.DataSource = DA_OP.SelectWaitingOP ' ModOTRegistration.SelectListOT(TxtPatientNo.Text)
        'ModCommon.NumberAllRowHeaderDataGrid(GridOTRegistration)
    End Sub
    Private Sub BtnStartConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStartConsult.Click
        NewPatientExam
    End Sub
    Private Sub ViewPatientConsult(ByVal status As Double)
        'Try
        GridPatientWaiting.DataSource = DA_Waiting_View.SelectWaitingConsult(status)
        'Catch ex As Exception

        'End Try

    End Sub
  
    Private Sub ViewPatientHistory(ByVal PatientNo As Double)
        'Try
        GridHistoy.DataSource = DA_History.SelectHistoryPatientNo(PatientNo)
        'Catch ex As Exception
        '    GridHistoy.DataSource = Nothing
        'End Try

    End Sub
    Private Sub CleanInterFace()
        TxtRE.Text = ""
        TxtLE.Text = ""
        TxtRPh.Text = ""
        TxtLPh.Text = ""
        TxtRREF.Text = ""
        TxtLREF.Text = ""
        TxtRRE.Text = ""
        TxtLLE.Text = ""
        TxtNote.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub ViewPatientVANewExam(ByVal WaitingID As Double)
        Dim tblVA As DataTable = DA_VA.SelectVAByWaitingNo(WaitingID)
        For Each row As DataRow In tblVA.Rows
            TxtRE.Text = row("RE")
            TxtRPh.Text = row("RPH")
            TxtRREF.Text = row("RREF")
            TxtRRE.Text = row("RRE")

            TxtLE.Text = row("LE")
            TxtLPh.Text = row("LPH")
            TxtLREF.Text = row("LREF")
            TxtLLE.Text = row("LLE")
            TxtIOPLE.Text = IIf(IsDBNull(row("IOPLE")), "", row("IOPLE"))
            TxtIOPRE.Text = IIf(IsDBNull(row("IOPRE")), "", row("IOPRE"))
            TxtNote.Text = row("VA_NOTE")
        Next
    End Sub
    Private Sub ViewPatientVAHistory(ByVal WaitingID As Double)
        Dim tblVA As DataTable = DA_VA.SelectVAByWaitingNo(WaitingID)
        For Each row As DataRow In tblVA.Rows
            TxtRE1His.Text = row("RE")
            TxtRPh1_His.Text = row("RPH")
            TxtREF1_His.Text = row("RREF")
            TxtRRe1_His.Text = row("RRE")

            TxtLe1_His.Text = row("LE")
            TxtLPh1_His.Text = row("LPH")
            TxtLRef1_His.Text = row("LREF")
            TxtLLe1_His.Text = row("LLE")
            Try
                TxtIOPLE_His.Text = row("IOPLE")
                TxtIOPRE_His.Text = row("IOPRE")
            Catch ex As Exception

            End Try
            
            TxtHistory.Text = row("VA_NOTE")
        Next
    End Sub
  

    Private Sub GridPatientWaiting_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientWaiting.SelectionChanged
        Try
            If GridPatientWaiting.SelectedItems.Count = 0 Then
                CleanHistoryDetail()
                CleanInterFace()
                Exit Sub
            End If

            PictureBox1.Image = ByteArrayToImage(DAPatient.SelectPicture(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value))
            ViewPatientVANewExam(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
            ViewPatientHistory(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value)
            ShowOperationHistory(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value)
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub btnRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshData.Click
        ViewPatientConsult(2)
        ViewPatientFollowUpByDate(Now.Date, Now.Date)
    End Sub
    Private Sub ViewPatientFollowUpByDate(ByVal DateFollowup As Date, ByVal DateFollowUPto As Date)
        GridFollowUp.DataSource = DA_HistoryFollowUp.SelectFollowupByDoctor(USER_NAME, DateFollowup.Date, DateFollowUPto.Date)
    End Sub
    Private Sub GridHistoy_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridHistoy.SelectionChanged
        GridImageList.DataSource = Nothing
        If GridHistoy.SelectedItems.Count = 0 Then
            CleanHistoryDetail()
            Exit Sub
        Else
            ViewConsultDetail()
            ViewPatientVAHistory(GridHistoy.GetRow.Cells("WAIT_ID").Value)
            ViewPatPrescription(GridHistoy.GetRow.Cells("WAIT_ID").Value)
        End If
    End Sub
    Public Sub ViewPatPrescription(ByVal WaitingID As Integer)
        GridPrescription.DataSource = DA_PresciptionV1.SelectPrescriptionHistory(WaitingID)
    End Sub
    Private Sub CleanHistoryDetail()
        TxtRE1His.Text = ""
        TxtRPh1_His.Text = ""
        TxtREF1_His.Text = ""
        TxtRRe1_His.Text = ""

        TxtLe1_His.Text = ""
        TxtLPh1_His.Text = ""
        TxtLRef1_His.Text = ""
        TxtLLe1_His.Text = ""

        TxtHistory.Text = ""

        CboDiagnosis.Text = ""
        TxtDiagnosisCode.Text = ""

        'ChIssueGlasses.Checked = False
        RadDiagnosisLefEye.Checked = False

        RadDiagnosisRighEye.Checked = False

        RadDiagnosisBothEyes.Checked = False

        TxtDiagnosisNote.Text = ""
        RadManageInpatient.Checked = False

        RadManageOutPatient.Checked = False

        RadManageSurgery.Checked = False
        TxtSurgery.Text = ""

        TxtMedication.Text = ""
        CboDoctorConsult.Text = ""
        GridImageList.DataSource = Nothing
    End Sub
    Private Sub ViewConsultDetail()
        'It VA



        'TxtRE1.Text = GridHistoy.GetRow.Cells("RE").Value
        'TxtRPh1.Text = GridHistoy.GetRow.Cells("RPH").Value
        'TxtREF1.Text = GridHistoy.GetRow.Cells("RREF").Value
        'TxtRRe1.Text = GridHistoy.GetRow.Cells("RRE").Value

        'TxtLe1.Text = GridHistoy.GetRow.Cells("LE").Value
        'TxtLPh1.Text = GridHistoy.GetRow.Cells("LPH").Value
        'TxtLRef1.Text = GridHistoy.GetRow.Cells("LREF").Value
        'TxtLLe1.Text = GridHistoy.GetRow.Cells("LLE").Value

        'TxtHistory.Text = GridHistoy.GetRow.Cells("VA_NOTE").Value

        Try
            CboDiagnosis.Text = GridHistoy.GetRow.Cells("DIAGNOSIS").Value
            TxtDiagnosisCode.Text = GridHistoy.GetRow.Cells("DIAGNOSIS_CODE").Value
            Dim IS_Diagnosis As String = GridHistoy.GetRow.Cells("IS_ON_EYE").Value

            If IS_Diagnosis = "Left Eye" Then
                RadDiagnosisLefEye.Checked = True
            ElseIf IS_Diagnosis = "Right Eye" Then
                RadDiagnosisRighEye.Checked = True
            ElseIf IS_Diagnosis = "Both Eyes" Then
                RadDiagnosisBothEyes.Checked = True
            End If
            TxtDiagnosisNote.Text = GridHistoy.GetRow.Cells("DIAGNOSIS_NOTE").Value
            Dim IS_ManagePaitent As String = GridHistoy.GetRow.Cells("IS_ON_MANAGEMENT").Value
            If IS_ManagePaitent = "Inpatient" Then
                RadManageInpatient.Checked = True
            ElseIf IS_ManagePaitent = "Out Patient" Then
                RadManageOutPatient.Checked = True
            ElseIf IS_ManagePaitent = "Surgery" Then
                RadManageSurgery.Checked = True
                Try
                    TxtSurgery.Text = GridHistoy.GetRow.Cells("OPERATION_ON").Value
                Catch ex As Exception

                End Try

            End If
            TxtMedication.Text = GridHistoy.GetRow.Cells("MEDICATION").Value
            CboDoctorConsult.Text = GridHistoy.GetRow.Cells("OPHTHAMOLOGIST").Value
            GridImageList.DataSource = DA_ImageDiagnosis.SelectImageDiagnosis(GridHistoy.GetRow.Cells("WAIT_ID").Value)
        Catch ex As Exception
            CleanHistoryDetail()
        End Try

        'ChIssueGlasses.Checked = GridHistoy.GetRow.Cells("IS_GLASSES").Value



    End Sub


    Private Sub CboPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnDeleteWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteWaiting.Click
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete from waiting list", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Waiting.DeleteWaiting(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value) = 1 Then
                CleanHistoryDetail()
                CleanInterFace()
                ViewPatientConsult(2)
            End If
        End If
    End Sub

   

    Private Sub TxtPatientNoFind_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnPatientHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientHistory.Click
        Dim FReportHistory As New FormReportHistory
        If GridPatientWaiting.SelectedItems.Count = 0 Then

        Else
            FReportHistory.TxtPatientNo.Text = GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value
            FReportHistory.BtnPrintPreview_Click(sender, e)
        End If

        FReportHistory.ShowDialog()
    End Sub


    Private Sub GridPatientWaiting_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPatientWaiting.RowDoubleClick
        NewPatientExam()
    End Sub
    Sub NewPatientExam()
        If GridPatientWaiting.SelectedItems.Count = 0 Then Exit Sub
        If GridPatientWaiting.FilterRow.Selected = True Then
            MessageBox.Show("Please select patient before do examination", "Examination", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DA_Waiting.CheckDoctorConsulting(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value).Rows.Count > 0 Then
            MessageBox.Show("Doctor is consulting this patient. you can not start consult", "Consultation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DA_Waiting.CheckExamReady(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value) <> 1 Then
            MessageBox.Show("This patient already examination. Please refresh list waiting exam.", "Exam", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnRefreshData_Click(sender, e)
            Exit Sub
        End If
        ViewPatientVANewExam(GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
        Dim NConsult As New NewDoctorConsult(Me)
        NConsult.LblWaitingNo.Text = GridPatientWaiting.GetRow.Cells("WAIT_ID").Value
        NConsult.TxtPatientNo.Text = GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value
        NConsult.TxtNameEng.Text = GridPatientWaiting.GetRow.Cells("NameEng").Value
        NConsult.TxtNameKhmer.Text = GridPatientWaiting.GetRow.Cells("NameKhmer").Value
        NConsult.TxtAgePatient.Text = GridPatientWaiting.GetRow.Cells("Age").Value
        NConsult.CboSexPatien.Text = GridPatientWaiting.GetRow.Cells("Sex").Value
        NConsult.TxtTel.Text = GridPatientWaiting.GetRow.Cells("Telephone").Value
        NConsult.PictureBox1.Image = ByteArrayToImage(DAPatient.SelectPicture(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value))
        NConsult.TxtRE.Text = TxtRE.Text
        NConsult.TxtRPh.Text = TxtRPh.Text
        NConsult.TxtRREF.Text = TxtRREF.Text
        NConsult.TxtRRE.Text = TxtRRE.Text

        NConsult.TxtLE.Text = TxtLE.Text
        NConsult.TxtLPh.Text = TxtLPh.Text
        NConsult.TxtLREF.Text = TxtLREF.Text
        NConsult.TxtLLE.Text = TxtLLE.Text
        NConsult.TxtIOPLE.Text = TxtIOPLE.Text
        NConsult.TxtIOPRE.Text = TxtIOPRE.Text
        NConsult.TxtHistory.Text = TxtNote.Text
        DA_Waiting.UpdateDoctorConsulting(True, GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
        NConsult.Show()
        'If NConsult.IS_CLOSE = True Then

        'End If
        'If NConsult.ShowDialog() = DialogResult.OK Then
        '    DA_Waiting.UpdateDoctorConsulting(False, GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
        '    ViewPatientConsult(2)
        '    ViewPatientHistory(0)
        '    CleanInterFace()
        'End If
    End Sub
    
    Public Sub RefreshInterface()
        DA_Waiting.UpdateDoctorConsulting(False, GridPatientWaiting.GetRow.Cells("WAIT_ID").Value)
        ViewPatientConsult(2)
        ViewPatientHistory(0)
        CleanInterFace()
       
    End Sub

    Private Sub DashboardDoctorConsult_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnRefreshData_Click(sender, e)
        End If
    End Sub


    Private Sub GridOT_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridOT.RowDoubleClick
        If e.Row.GroupCaption <> "" Then
            MessageBox.Show("Please select operation note.", "Show", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                'Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)

                If GridOT.SelectedItems(0).Table.Key = "SCLERAL BUCKLING" Then
                    UpdateScleralBuckling()
                End If

                If GridOT.SelectedItems(0).Table.Key = "INTRAVITREAL_INJECTION" Then
                    UpdateInjection()
                End If
                If GridOT.SelectedItems(0).Table.Key = "GENERAL_OPERATIVE" Then
                    UpdateGeneralOperation()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PHACOEMULSIFICATION" Then
                    UpdatePHACOEMULSIFICATION()
                End If
                If GridOT.SelectedItems(0).Table.Key = "ECCE" Then
                    UpdateECCE()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PAR_PLANA" Then
                    UpdateParPlana()
                End If
                If GridOT.SelectedItems(0).Table.Key = "TRABECULECTOMY" Then
                    UpdateTrabeculectomy()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PTERYGIUM" Then
                    UpdatePterygium()
                End If

            Catch ex As Exception
                ' MsgBox("Error " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
       
    End Sub
    Private Sub UpdatePterygium()
        Dim FPterygium As New PterygiumExcisionandGraft
        FPterygium.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_ID").Value
        FPterygium.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FPterygium.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FPterygium.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FPterygium.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FPterygium.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FPterygium.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        FPterygium.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FPterygium.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FPterygium.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        FPterygium.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FPterygium.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FPterygium.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FPterygium.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FPterygium.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FPterygium.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        FPterygium.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value
        FPterygium.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value

        FPterygium.PTERYGIUM_NASAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_NASAL").Value
        FPterygium.PTERYGIUM_TEMPORAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_TEMPORAL").Value
        FPterygium.BRIDAL_SUPERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_SUPERIOR").Value
        FPterygium.BRIDAL_70VICRYL.Checked = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_70VICRYL").Value
        FPterygium.BRIDAL_80SILK.Checked = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_80SILK").Value
        FPterygium.BRIDAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("BRIDAL_OTHERS").Value
        FPterygium.SUBCONJUNCTIVAL_XYLOCAIN_WITH.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_XYLOCAIN_WITH").Value
        FPterygium.SUBCONJUNCTIVAL_XYLOCAIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_XYLOCAIN").Value
        FPterygium.SUBCONJUNCTIVAL_NONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_NONE").Value
        FPterygium.PTERYGIUM_SCISSORS.Checked = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_SCISSORS").Value
        FPterygium.PTERYGIUM_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_OTHER").Value
        FPterygium.CAUTERY_MILD.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_MILD").Value
        FPterygium.CAUTERY_69BLADE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_69BLADE").Value
        FPterygium.CAUTERY_MODRATE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_MODRATE").Value

        FPterygium.CAUTERY_EXTENSIVE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_EXTENSIVE").Value
        FPterygium.CONJUNCTIVAL_SUPERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_SUPERIOR").Value
        FPterygium.CONJUNCTIVAL_OTHER_SITE.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_OTHER_SITE").Value
        FPterygium.SIZE1.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE1").Value
        FPterygium.SIZE2.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE2").Value
        FPterygium.GRAFT_80VERGIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_80VERGIN").Value
        FPterygium.GRAFT_100NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_100NYLON").Value
        FPterygium.GRAFT_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_OTHER").Value

        FPterygium.GRAFT_90NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_90NYLON").Value
        FPterygium.GRAFT_RUNNING.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_RUNNING").Value
        FPterygium.GRAFT_INTERRUPTED.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_INTERRUPTED").Value
        FPterygium.GRAFT_COMBINED.Checked = GridOT.SelectedItems(0).GetRow.Cells("GRAFT_COMBINED").Value
        FPterygium.SUBCONJUNCTIVAL_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_GENTAL").Value
        FPterygium.SUBCONJUNCTIVAL_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_CEFAZOLIN").Value
        FPterygium.SUBCONJUNCTIVAL_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_DEXAMETHASONE").Value
        FPterygium.SUBCONJUNCTIVAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUNCTIVAL_OTHERS").Value
        FPterygium.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FPterygium.TOPICAL_TOBRADEX.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_TOBRADEX").Value
        FPterygium.TOPICAL_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHER").Value
        FPterygium.EXTRA_NOTES.Text = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_NOTES").Value
        FPterygium.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value

        If FPterygium.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblPtery As DataTable = DA_Ptery.SelectPterygium(FPterygium.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Ptery, TblPtery, PreviewOP.AxAcroPDF1, "Ptery")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateTrabeculectomy()
        Dim Ftrab As New Trabeculectomy
        Ftrab.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("TRABECULECTIOMY_ID").Value
        Ftrab.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        Ftrab.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        Ftrab.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        Ftrab.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        Ftrab.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        Ftrab.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        Ftrab.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        Ftrab.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        Ftrab.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        Ftrab.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        Ftrab.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        Ftrab.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        Ftrab.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        Ftrab.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        Ftrab.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        Ftrab.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        Ftrab.S_AN_SUBCONJUNCTIVAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_SUBCONJUNCTIVAL").Value
        Ftrab.LOCATION.Text = GridOT.SelectedItems(0).GetRow.Cells("LOCATION").Value



        Ftrab.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value
        Ftrab.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value
        Ftrab.CONJUNCTIVA_LIMBAL_BASE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVA_LIMBAL_BASE").Value
        Ftrab.CONJUNCTIVAL_FORNIX_BASE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_FORNIX_BASE").Value
        Ftrab.CONJUNC_NOTE_FROM.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNC_NOTE_FROM").Value
        Ftrab.CONJUNC_NOTE_TO.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNC_NOTE_TO").Value
        Ftrab.SHAPE1.Checked = GridOT.SelectedItems(0).GetRow.Cells("SHAPE1").Value
        Ftrab.SHAPE2.Checked = GridOT.SelectedItems(0).GetRow.Cells("SHAPE2").Value
        Ftrab.SHAPE_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("SHAPE_OTHER").Value
        Ftrab.SIZE1.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE1").Value
        Ftrab.SIZE2.Text = GridOT.SelectedItems(0).GetRow.Cells("SIZE2").Value
        Ftrab.THICKNESS13.Checked = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS13").Value
        Ftrab.THICKNESS12.Checked = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS12").Value
        Ftrab.THICKNESS23.Checked = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS23").Value
        Ftrab.THICKNESS_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("THICKNESS_OTHER").Value
        Ftrab.ADJUNCTIVE_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_NO").Value
        Ftrab.ADJUNCTIVE_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_YES").Value
        Ftrab.ADJUNCTIVE_MMC.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_MMC").Value


        Ftrab.ADJUNCTIVE_MMC_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_MMC_NOTE").Value
        Ftrab.ADJUNCTIVE_5FU.Checked = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_5FU").Value
        Ftrab.ADJUNCTIVE_5FU_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("ADJUNCTIVE_5FU_NOTE").Value
        Ftrab.INTRABLE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRABLE").Value
        Ftrab.SOAKED.Checked = GridOT.SelectedItems(0).GetRow.Cells("SOAKED").Value
        Ftrab.SOAKED_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SOAKED_NOTE").Value
        Ftrab.IRRIGATION_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_NO").Value
        Ftrab.IRRIGATION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_YES").Value
        Ftrab.IRRIGATION_WITH.Text = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_WITH").Value
        ' Ftrab.IRRIGATION_NOT_DONE.Text = GridOT.SelectedItems(0).GetRow.Cells("IRRIGATION_NOT_DONE").Value
        Ftrab.PARACENTESIS_NOTE_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("PARACENTESIS_NOTE_DONE").Value
        Ftrab.PARACENTESIS_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("PARACENTESIS_DONE").Value
        Ftrab.PARACENTESIS_DONE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("PARACENTESIS_DONE_NOTE").Value
        Ftrab.TRABECULECTOMY1.Text = GridOT.SelectedItems(0).GetRow.Cells("TRABECULECTOMY1").Value
        Ftrab.TRABECULECTOMY2.Text = GridOT.SelectedItems(0).GetRow.Cells("TRABECULECTOMY2").Value
        Ftrab.IRIDECTOMY_NOT_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRIDECTOMY_NOT_DONE").Value
        Ftrab.IRIDECTOMY_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("IRIDECTOMY_DONE").Value
        Ftrab.IRIDECTOMY_DONE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("IRIDECTOMY_DONE_NOTE").Value


        Ftrab.SCLERAL_NOTE_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_NOTE_NO").Value
        Ftrab.SCLERAL_100NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_100NYLON").Value
        Ftrab.SCLERAL_100PROLENE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_100PROLENE").Value
        Ftrab.SCLERAL_RELEASABLE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_RELEASABLE").Value
        Ftrab.SCLERAL_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_NOTE").Value
        Ftrab.CONJUNCTIVAL_INTERRUPTED.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_INTERRUPTED").Value
        Ftrab.CONJUNCTIVAL_INTERRUPTED_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_INTERRUPTED_NOTE").Value
        Ftrab.CONJUNCTIVAL_100NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_100NYLON").Value
        Ftrab.CONJUNCTIVAL_100PROLENE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_100PROLENE").Value
        Ftrab.CONJUNCTIVAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("CONJUNCTIVAL_OTHERS").Value
        Ftrab.COPLICATION_NONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("COPLICATION_NONE").Value
        Ftrab.COPLICATION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("COPLICATION_YES").Value
        Ftrab.OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PROCEDURES").Value
        Ftrab.SUB_GENTAL2MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL2MG").Value
        Ftrab.SUB_CEFAZOLIN50MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN50MG").Value
        Ftrab.SUB_DEXAMETHASONE_25MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE_25MG").Value
        Ftrab.SUB_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHER").Value
        Ftrab.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value

        Ftrab.TOPICAL_PILOCARPINE2.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE2").Value
        Ftrab.TOPICAL_VIGAMOX.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_VIGAMOX").Value
        Ftrab.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        Ftrab.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value


        If Ftrab.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblTrab As DataTable = DA_Trab.SelectTrabeculectomy(Ftrab.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Trab, TblTrab, PreviewOP.AxAcroPDF1, "Trabeculectomy")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateParPlana()
        Dim FParPlana As New ParPlanaVitrectomy
        FParPlana.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("PA_PLANA_ID").Value
        FParPlana.LblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FParPlana.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FParPlana.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FParPlana.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FParPlana.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FParPlana.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FParPlana.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FParPlana.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FParPlana.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        FParPlana.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FParPlana.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FParPlana.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FParPlana.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FParPlana.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FParPlana.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value



        FParPlana.PERITOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITOMY").Value
        FParPlana.SCLEROTOMISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE").Value
        FParPlana.SCLEROTOMISE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE_NOTE").Value
        FParPlana.INFUSION_SIZE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE").Value
        FParPlana.INFUSION_SIZE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE_NOTE").Value
        FParPlana.CORE_VITRECTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY").Value
        FParPlana.CORE_VITRECTOMY_NOTE1.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE1").Value
        FParPlana.CORE_VITRECTOMY_NOTE2.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE2").Value
        FParPlana.PERIPHERAL_VITRECTORMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERIPHERAL_VITRECTORMY").Value
        FParPlana.PERFLUOCARBON.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERFLUOCARBON").Value
        FParPlana.ENDO.Checked = GridOT.SelectedItems(0).GetRow.Cells("ENDO").Value
        FParPlana.ENDO_LASER.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_LASER").Value
        FParPlana.ENDO_MW.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_MW").Value
        FParPlana.ENDO_SHOTS.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_SHOTS").Value
        FParPlana.RETINOCRYOPEXY.Checked = GridOT.SelectedItems(0).GetRow.Cells("RETINOCRYOPEXY").Value
        FParPlana.AIR_FLUID_EXCHANGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("AIR_FLUID_EXCHANGE").Value

        FParPlana.PERITOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITOMY").Value
        FParPlana.SCLEROTOMISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE").Value
        FParPlana.SCLEROTOMISE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMISE_NOTE").Value
        FParPlana.INFUSION_SIZE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE").Value
        FParPlana.INFUSION_SIZE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("INFUSION_SIZE_NOTE").Value
        FParPlana.CORE_VITRECTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY").Value
        FParPlana.CORE_VITRECTOMY_NOTE1.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE1").Value
        FParPlana.CORE_VITRECTOMY_NOTE2.Text = GridOT.SelectedItems(0).GetRow.Cells("CORE_VITRECTOMY_NOTE2").Value
        FParPlana.PERIPHERAL_VITRECTORMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERIPHERAL_VITRECTORMY").Value
        FParPlana.PERFLUOCARBON.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERFLUOCARBON").Value
        FParPlana.ENDO.Checked = GridOT.SelectedItems(0).GetRow.Cells("ENDO").Value
        FParPlana.ENDO_LASER.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_LASER").Value
        FParPlana.ENDO_MW.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_MW").Value
        FParPlana.ENDO_SHOTS.Text = GridOT.SelectedItems(0).GetRow.Cells("ENDO_SHOTS").Value
        FParPlana.RETINOCRYOPEXY.Checked = GridOT.SelectedItems(0).GetRow.Cells("RETINOCRYOPEXY").Value
        FParPlana.AIR_FLUID_EXCHANGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("AIR_FLUID_EXCHANGE").Value



        FParPlana.GAS_EXCHANGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("GAS_EXCHANGE").Value
        FParPlana.SF6.Checked = GridOT.SelectedItems(0).GetRow.Cells("SF6").Value
        FParPlana.C6F8.Checked = GridOT.SelectedItems(0).GetRow.Cells("C6F8").Value
        FParPlana.C6F8_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("C6F8_NOTE").Value
        FParPlana.SCLERAL_BUCHING.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_BUCHING").Value
        FParPlana.SILICONE_OIL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SILICONE_OIL").Value
        FParPlana.PAR_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("PAR_NOTE").Value
        FParPlana.SCLEROTOMY_VICRYL.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLEROTOMY_VICRYL").Value
        FParPlana.SCLEROLOMY_NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROLOMY_NYLON").Value
        FParPlana.SCLEROLOMY_DEXON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLEROLOMY_DEXON").Value
        FParPlana.CONJUNTIVAL_NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNTIVAL_NYLON").Value
        FParPlana.CONJUNTIVAL_VICRYL.Checked = GridOT.SelectedItems(0).GetRow.Cells("CONJUNTIVAL_VICRYL").Value
        FParPlana.SUB_GENTAL2MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL2MG").Value
        FParPlana.SUB_CEFAZOLIN50MG.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN50MG").Value
        FParPlana.RETINOCRYOPEXY.Checked = GridOT.SelectedItems(0).GetRow.Cells("RETINOCRYOPEXY").Value
        FParPlana.SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE").Value

        FParPlana.SUB_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHERS").Value
        FParPlana.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FParPlana.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FParPlana.TOPICAL_ATROPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_ATROPINE").Value
        FParPlana.TOPICAL_ALPHAGAN.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_ALPHAGAN").Value
        FParPlana.TOPICAL_VIGAMOX.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_VIGAMOX").Value
        FParPlana.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        FParPlana.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value


        If FParPlana.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim tblParPlana As DataTable = DA_ParPlana.SelectPaPlana(FParPlana.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_PA_PLANA, tblParPlana, PreviewOP.AxAcroPDF1, "ParPlana")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateECCE()
        Dim FExtraEcce As New ExtracapsularCataractExtraction_ECCE_

        FExtraEcce.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("ECCE_ID").Value
        FExtraEcce.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FExtraEcce.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FExtraEcce.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FExtraEcce.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FExtraEcce.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FExtraEcce.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        FExtraEcce.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FExtraEcce.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FExtraEcce.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value

        FExtraEcce.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FExtraEcce.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FExtraEcce.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FExtraEcce.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FExtraEcce.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value

        FExtraEcce.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value
        FExtraEcce.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value
        FExtraEcce.VIS_HEALON5.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON5").Value
        FExtraEcce.VIS_HEALON_GV.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON_GV").Value
        FExtraEcce.VIS_IALF.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_IALF").Value
        FExtraEcce.VIS_VISSOAT.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_VISSOAT").Value
        FExtraEcce.VIS_PROVISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_PROVISE").Value
        FExtraEcce.BSS_PLUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("BSS_PLUS").Value
        FExtraEcce.BSS.Checked = GridOT.SelectedItems(0).GetRow.Cells("BSS").Value

        FExtraEcce.PERITO_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITO_YES").Value
        FExtraEcce.PERITO_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("PERITO_NO").Value
        FExtraEcce.CARTERY_MILD.Checked = GridOT.SelectedItems(0).GetRow.Cells("CARTERY_MILD").Value
        FExtraEcce.CARTERY_MODERATE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CARTERY_MODERATE").Value
        FExtraEcce.CAUTERY_EXTENSIVE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAUTERY_EXTENSIVE").Value
        FExtraEcce.INCISION_SITE_CORNEOSCLERAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SITE_CORNEOSCLERAL").Value
        FExtraEcce.INCISION_SITE_SCLERAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SITE_SCLERAL").Value
        FExtraEcce.INCISION_SIZE_SUPERRIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SIZE_SUPERRIOR").Value
        FExtraEcce.INCISION_SIZE_SUPERRIOR_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SIZE_SUPERRIOR_NOTE").Value

        FExtraEcce.INCISION_SIZE_SUPERRIOR_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("INCISION_SIZE_SUPERRIOR_OTHER").Value
        FExtraEcce.CAPSULOTOMY_CYSTOTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULOTOMY_CYSTOTOMY").Value
        FExtraEcce.CAPSULOTOMY_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("CAPSULOTOMY_OTHERS").Value
        FExtraEcce.CARTERY_MODERATE.Checked = GridOT.SelectedItems(0).GetRow.Cells("CARTERY_MODERATE").Value
        FExtraEcce.NUCLEUS_EXPRESSION.Checked = GridOT.SelectedItems(0).GetRow.Cells("NUCLEUS_EXPRESSION").Value
        FExtraEcce.NUCLEUS_LENSLOOP.Checked = GridOT.SelectedItems(0).GetRow.Cells("NUCLEUS_LENSLOOP").Value
        FExtraEcce.NUCLEUS_VISCO.Checked = GridOT.SelectedItems(0).GetRow.Cells("NUCLEUS_VISCO").Value
        FExtraEcce.CORTEX_SIMCO_IA.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORTEX_SIMCO_IA").Value
        FExtraEcce.CAPSULE_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULE_YES").Value


        FExtraEcce.CAPSULE_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULE_NO").Value
        FExtraEcce.IOL_IN_CAPSULAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_CAPSULAR").Value
        FExtraEcce.IOL_IN_SULCUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_SULCUS").Value
        FExtraEcce.IOL_IN_AC.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_AC").Value
        FExtraEcce.SUTURE_NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_NYLON").Value
        FExtraEcce.SUTURE_NYLON_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_NYLON_NOTE").Value
        FExtraEcce.SUTURE_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_OTHERS").Value
        FExtraEcce.SUBCONJUN_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_GENTAL").Value
        FExtraEcce.SUBCONJUN_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_CEFAZOLIN").Value

        FExtraEcce.SUBCONJUN_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_DEXAMETHASONE").Value
        FExtraEcce.SUBCONJUN_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUBCONJUN_OTHERS").Value
        FExtraEcce.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FExtraEcce.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FExtraEcce.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        FExtraEcce.EXTRA_IRRIDECTOMY.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_IRRIDECTOMY").Value
        FExtraEcce.EXTRA_LOCATION.Text = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_LOCATION").Value
        FExtraEcce.EXTRA_CAPSULAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_CAPSULAR").Value
        FExtraEcce.EXTRA_VITREOS.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_VITREOS").Value


        FExtraEcce.EXTRA_ANTERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_ANTERIOR").Value
        FExtraEcce.EXTRA_AC_HEMORRHAGE.Checked = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_AC_HEMORRHAGE").Value
        FExtraEcce.EXTRA_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("EXTRA_OTHER").Value
        FExtraEcce.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value

        If FExtraEcce.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim tblECCE As DataTable = DA_ECCE.SelectECCE(FExtraEcce.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_ECCE, tblECCE, PreviewOP.AxAcroPDF1, "ECCE")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdatePHACOEMULSIFICATION()
        Dim FPhacoemulsification As New Phacoemulsification
        FPhacoemulsification.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("PHACOEMULSIF_ID").Value
        FPhacoemulsification.lblOperNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FPhacoemulsification.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FPhacoemulsification.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FPhacoemulsification.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FPhacoemulsification.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FPhacoemulsification.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FPhacoemulsification.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FPhacoemulsification.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value


        FPhacoemulsification.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FPhacoemulsification.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FPhacoemulsification.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FPhacoemulsification.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FPhacoemulsification.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FPhacoemulsification.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        FPhacoemulsification.VIS_HEALON_GV.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON_GV").Value
        FPhacoemulsification.VIS_IALF.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_IALF").Value
        FPhacoemulsification.VIS_VISSOAT.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_VISSOAT").Value


        FPhacoemulsification.VIS_DUOVISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_DUOVISE").Value
        FPhacoemulsification.VIS_HEALON5.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_HEALON5").Value
        FPhacoemulsification.VIS_OPHTHALINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_OPHTHALINE").Value
        FPhacoemulsification.VIS_PROVISE.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIS_PROVISE").Value
        FPhacoemulsification.BSS_PLUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("BSS_PLUS").Value
        FPhacoemulsification.POWER.Text = GridOT.SelectedItems(0).GetRow.Cells("POWER").Value
        FPhacoemulsification.FLOW_RATE.Text = GridOT.SelectedItems(0).GetRow.Cells("FLOW_RATE").Value
        FPhacoemulsification.VAC.Text = GridOT.SelectedItems(0).GetRow.Cells("VAC").Value
        FPhacoemulsification.PHACO_TIME.Text = GridOT.SelectedItems(0).GetRow.Cells("PHACO_TIME").Value


        FPhacoemulsification.IA_FLOW_RATE.Text = GridOT.SelectedItems(0).GetRow.Cells("IA_FLOW_RATE").Value
        FPhacoemulsification.IA_VAC.Text = GridOT.SelectedItems(0).GetRow.Cells("IA_VAC").Value
        FPhacoemulsification.NOT_DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("NOT_DONE").Value
        FPhacoemulsification.DONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("DONE").Value
        FPhacoemulsification.DONE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("DONE_NOTE").Value
        FPhacoemulsification.CORNEAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("CORNEAL").Value
        FPhacoemulsification.SCLERAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL").Value
        FPhacoemulsification.FINAL_SIZE.Checked = GridOT.SelectedItems(0).GetRow.Cells("FINAL_SIZE").Value
        FPhacoemulsification.FINAL_SIZE_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("FINAL_SIZE_NOTE").Value


        FPhacoemulsification.CAPSULORHEXIS.Text = GridOT.SelectedItems(0).GetRow.Cells("CAPSULORHEXIS").Value
        FPhacoemulsification.HEYDRODISSECTION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("HEYDRODISSECTION_YES").Value
        FPhacoemulsification.HEYDRODISSECTION_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("HEYDRODISSECTION_NO").Value
        FPhacoemulsification.PHACO_DIVIDE.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_DIVIDE").Value
        FPhacoemulsification.PHACO_CHOP.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_CHOP").Value
        FPhacoemulsification.PHACO_STOP_CHOP.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_STOP_CHOP").Value
        FPhacoemulsification.PHACO_SCULPTING.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_SCULPTING").Value
        FPhacoemulsification.PHACO_CRACKING.Checked = GridOT.SelectedItems(0).GetRow.Cells("PHACO_CRACKING").Value
        FPhacoemulsification.PHACO_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("PHACO_OTHERS").Value




        FPhacoemulsification.IA_TIP.Checked = GridOT.SelectedItems(0).GetRow.Cells("IA_TIP").Value
        FPhacoemulsification.IA_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("IA_OTHER").Value
        FPhacoemulsification.CAPSULAR_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULAR_YES").Value
        FPhacoemulsification.CAPSULAR_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("CAPSULAR_NO").Value
        FPhacoemulsification.IOL_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_NO").Value
        FPhacoemulsification.IOL_IN_CAPSULAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_CAPSULAR").Value
        FPhacoemulsification.IOL_IN_SULCUS.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_SULCUS").Value
        FPhacoemulsification.IOL_IN_AC.Checked = GridOT.SelectedItems(0).GetRow.Cells("IOL_IN_AC").Value
        FPhacoemulsification.SUTURE_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_YES").Value


        FPhacoemulsification.SUTURE_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUTURE_NO").Value
        FPhacoemulsification.SUB_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL").Value
        FPhacoemulsification.SUB_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN").Value
        FPhacoemulsification.SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE").Value
        FPhacoemulsification.SUB_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHERS").Value
        FPhacoemulsification.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FPhacoemulsification.TOPICAL_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITROL").Value
        FPhacoemulsification.TOPICAL_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHERS").Value
        FPhacoemulsification.COMPLICATION_YES.Checked = GridOT.SelectedItems(0).GetRow.Cells("COMPLICATION_YES").Value

        FPhacoemulsification.COMPLICATION_NO.Checked = GridOT.SelectedItems(0).GetRow.Cells("COMPLICATION_NO").Value
        FPhacoemulsification.COMPLICATION_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("COMPLICATION_NOTE").Value
        FPhacoemulsification.OTHER_PRO_ANTERIOR.Checked = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PRO_ANTERIOR").Value
        FPhacoemulsification.OTHER_PRO_PI.Checked = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PRO_PI").Value
        FPhacoemulsification.OTHER_PRO_AT.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PRO_AT").Value
        FPhacoemulsification.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value


        If FPhacoemulsification.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim Phacoe As DataTable = DA_Phacoe.SelectPhacoemulsification(FPhacoemulsification.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Phacoemulsification, Phacoe, PreviewOP.AxAcroPDF1, "Phacoemulsification")
            PreviewOP.ShowDialog()
        End If

    End Sub
    Private Sub UpdateGeneralOperation()
        Dim FGeneralOperative As New GeneralOperativeNote

        FGeneralOperative.lblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("GENERAL_ID").Value
        FGeneralOperative.lblOpNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FGeneralOperative.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FGeneralOperative.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FGeneralOperative.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FGeneralOperative.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FGeneralOperative.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FGeneralOperative.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FGeneralOperative.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FGeneralOperative.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value

        FGeneralOperative.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FGeneralOperative.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FGeneralOperative.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FGeneralOperative.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FGeneralOperative.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FGeneralOperative.S_AN_SUBCONJUNCTIVAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_SUBCONJUNCTIVAL").Value
        FGeneralOperative.OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PROCEDURES").Value
        FGeneralOperative.SUB_GENTAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_GENTAL").Value


        FGeneralOperative.SUB_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_CEFAZOLIN").Value
        FGeneralOperative.SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("SUB_DEXAMETHASONE").Value
        FGeneralOperative.SUB_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("SUB_OTHER").Value
        FGeneralOperative.TOPICAL_MAXITRAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_MAXITRAL").Value
        FGeneralOperative.TOPICAL_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_PILOCARPINE").Value
        FGeneralOperative.TOPICAL_ATROPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_ATROPINE").Value
        FGeneralOperative.TOPICAL_OTHER.Text = GridOT.SelectedItems(0).GetRow.Cells("TOPICAL_OTHER").Value
        FGeneralOperative.OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("OTHER_PROCEDURES").Value
        FGeneralOperative.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value

        If FGeneralOperative.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblGeneralOP As DataTable = DA_General_Operative.SelectOperatID(FGeneralOperative.lblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_GeneralOperative, TblGeneralOP, PreviewOP.AxAcroPDF1, "General_Operative")
            PreviewOP.ShowDialog()
        End If
    End Sub
    Private Sub UpdateInjection()
        Dim FInjection As New FormIntravitrealInjection
        FInjection.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("INJECTION_ID").Value
        FInjection.LblOpNumber.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FInjection.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FInjection.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FInjection.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FInjection.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FInjection.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FInjection.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value

        FInjection.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value
        FInjection.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FInjection.START_TIME.Checked = True
        FInjection.START_TIME.Text = GridOT.SelectedItems(0).GetRow.Cells("START_TIME").Value

        FInjection.IVTA.Checked = GridOT.SelectedItems(0).GetRow.Cells("IVTA").Value
        FInjection.AVASTIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("AVASTIN").Value
        FInjection.LUCENTIS.Checked = GridOT.SelectedItems(0).GetRow.Cells("LUCENTIS").Value
        FInjection.AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("AN_TOPICAL").Value
        FInjection.AN_SUBCONJUNCTIVAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("AN_SUBCONJUNCTIVAL").Value
        FInjection.FULL_PRE_OP.Checked = GridOT.SelectedItems(0).GetRow.Cells("FULL_PRE_OP").Value
        FInjection.PATIENT_FULL.Checked = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_FULL").Value


        FInjection.INTRA_TRIAMCINOLONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRA_TRIAMCINOLONE").Value
        FInjection.INTRA_TRIAM_DOSE.Text = GridOT.SelectedItems(0).GetRow.Cells("INTRA_TRIAM_DOSE").Value
        FInjection.INTRA_AVASTIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRA_AVASTIN").Value
        FInjection.INTRA_AVASTIN_DOSE.Text = GridOT.SelectedItems(0).GetRow.Cells("INTRA_AVASTIN_DOSE").Value
        FInjection.INTRA_LUCENTIS.Checked = GridOT.SelectedItems(0).GetRow.Cells("INTRA_LUCENTIS").Value
        FInjection.INTRA_LUCENTIS_DOSE.Text = GridOT.SelectedItems(0).GetRow.Cells("INTRA_LUCENTIS_DOSE").Value
        FInjection.ALPHAGAM.Checked = GridOT.SelectedItems(0).GetRow.Cells("ALPHAGAM").Value

        FInjection.NEO_SYNEPHRINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("NEO_SYNEPHRINE").Value
        FInjection.POLY_OPH_TROPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("POLY_OPH_TROPICAL").Value
        FInjection.VIGAMOX_TROPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("VIGAMOX_TROPICAL").Value
        FInjection.VIGAMO_TROPICAL_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("VIGAMO_TROPICAL_NOTE").Value
        FInjection.MAXITROL_EYE_OITMENT.Checked = GridOT.SelectedItems(0).GetRow.Cells("MAXITROL_EYE_OITMENT").Value
        FInjection.PATH.Checked = GridOT.SelectedItems(0).GetRow.Cells("PATH").Value
        FInjection.NO_COMPLICATION.Checked = GridOT.SelectedItems(0).GetRow.Cells("NO_COMPLICATION").Value
        FInjection.NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("NOTE").Value
        FInjection.SURGEON_SIGNATURE.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON_SIGNATURE").Value
        If FInjection.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblInjection As DataTable = DA_Intravitreal_Injection.SelectInjectionOp(FInjection.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_Injection, TblInjection, PreviewOP.AxAcroPDF1, "Injection_operation")
            PreviewOP.ShowDialog()
        End If
    End Sub
   
    Private Sub UpdateScleralBuckling()
        Dim FScleralBucling As New FormScleralBuckling
        FScleralBucling.LblSaveOption.Text = GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_ID").Value
        FScleralBucling.LblOperationNo.Text = GridOT.SelectedItems(0).GetRow.Cells("OPERA_NO").Value
        FScleralBucling.PATIENT_NO.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NO").Value
        FScleralBucling.PATIENT_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_NAME").Value
        FScleralBucling.PATIENT_SEX.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_SEX").Value
        FScleralBucling.PATIENT_AGE.Text = GridOT.SelectedItems(0).GetRow.Cells("PATIENT_AGE").Value
        FScleralBucling.SURGEON.Text = GridOT.SelectedItems(0).GetRow.Cells("SURGEON").Value
        FScleralBucling.SCRUB.Text = GridOT.SelectedItems(0).GetRow.Cells("SCRUB").Value
        FScleralBucling.CIRCULATING.Text = GridOT.SelectedItems(0).GetRow.Cells("CIRCULATING").Value
        FScleralBucling.ANESTHESIONLOGIST.Text = GridOT.SelectedItems(0).GetRow.Cells("ANESTHESIONLOGIST").Value

        FScleralBucling.RIGHT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("RIGHT_EYE").Value
        FScleralBucling.LEFT_EYE.Checked = GridOT.SelectedItems(0).GetRow.Cells("LEFT_EYE").Value

        FScleralBucling.DIAGNOSIS.Text = GridOT.SelectedItems(0).GetRow.Cells("DIAGNOSIS").Value
        FScleralBucling.S_PERITOMY360.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_PERITOMY360").Value
        FScleralBucling.S_RECTUS_MUSCLES.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_RECTUS_MUSCLES").Value
        FScleralBucling.S_AN_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_GA").Value
        FScleralBucling.S_AN_NEURO.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_NEURO").Value
        FScleralBucling.S_AN_STANDBY.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_STANDBY").Value
        FScleralBucling.S_AN_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_RETROBULBAR").Value
        FScleralBucling.S_AN_PERIBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_PERIBULBAR").Value
        FScleralBucling.S_AN_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_AN_TOPICAL").Value
        FScleralBucling.S_EX_GA.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_EX_GA").Value
        FScleralBucling.S_EX_RETROBULBAR.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_EX_RETROBULBAR").Value
        FScleralBucling.S_EX_TOPICAL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_EX_TOPICAL").Value
        FScleralBucling.S_NOTE.Text = GridOT.SelectedItems(0).GetRow.Cells("S_NOTE").Value
        FScleralBucling.S_OTHER_PROCEDURES.Text = GridOT.SelectedItems(0).GetRow.Cells("S_OTHER_PROCEDURES").Value
        FScleralBucling.S_CON_8VICRYL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_CON_8VICRYL").Value
        FScleralBucling.S_CON_10NYLON.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_CON_10NYLON").Value
        FScleralBucling.S_CON_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("S_CON_OTHERS").Value

        FScleralBucling.S_SUB_GENTAMICIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_GENTAMICIN").Value
        FScleralBucling.S_SUB_CEFAZOLIN.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_CEFAZOLIN").Value
        FScleralBucling.S_SUB_DEXAMETHASONE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_DEXAMETHASONE").Value
        FScleralBucling.S_SUB_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("S_SUB_OTHERS").Value
        FScleralBucling.S_TOP_MAXITROL.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_MAXITROL").Value
        FScleralBucling.S_TOP_ATROPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_ATROPINE").Value
        FScleralBucling.S_TOP_OTHERS.Text = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_OTHERS").Value
        FScleralBucling.S_TOP_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_PILOCARPINE").Value
        FScleralBucling.S_SUGEON_NAME.Text = GridOT.SelectedItems(0).GetRow.Cells("S_SUGEON_NAME").Value
        ' FScleralBucling.S_TOP_PILOCARPINE.Checked = GridOT.SelectedItems(0).GetRow.Cells("S_TOP_PILOCARPINE").Value
        If FScleralBucling.ShowDialog() = DialogResult.OK Then
            Dim PreviewOP As New OperationNotePreview
            Dim TblScleralBuckling As DataTable = DA_ScleralBuckling.SelectScleralBuckling(FScleralBucling.LblSaveOption.Text)
            EXPORT_PDF_PRINTER(CRV_ScleralBuckling, TblScleralBuckling, PreviewOP.AxAcroPDF1, "Scleral_Buckling")
            PreviewOP.ShowDialog()
        End If
    End Sub

    Private Sub GridImageList_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridImageList.RowDoubleClick
        If GridImageList.SelectedItems.Count = 0 Then Exit Sub
        Dim ImgZoom As New ImageZoom
        ImgZoom.PictureZoom.Image = GridImageList.GetRow.Cells("DIAGNOSIS_IMAGE").Value
        ImgZoom.ShowDialog()
    End Sub

    Private Sub BtnUpdateOPNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateOPNote.Click
        Try
            If GridOT.GetRow.GroupCaption <> "" Then
                MessageBox.Show("Please select operation note.", "Show", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Try
                    'Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)

                    If GridOT.SelectedItems(0).Table.Key = "SCLERAL BUCKLING" Then
                        UpdateScleralBuckling()
                    End If

                    If GridOT.SelectedItems(0).Table.Key = "INTRAVITREAL_INJECTION" Then
                        UpdateInjection()
                    End If
                    If GridOT.SelectedItems(0).Table.Key = "GENERAL_OPERATIVE" Then
                        UpdateGeneralOperation()
                    End If
                    If GridOT.SelectedItems(0).Table.Key = "PHACOEMULSIFICATION" Then
                        UpdatePHACOEMULSIFICATION()
                    End If
                    If GridOT.SelectedItems(0).Table.Key = "ECCE" Then
                        UpdateECCE()
                    End If
                    If GridOT.SelectedItems(0).Table.Key = "PAR_PLANA" Then
                        UpdateParPlana()
                    End If
                    If GridOT.SelectedItems(0).Table.Key = "TRABECULECTOMY" Then
                        UpdateTrabeculectomy()
                    End If
                    If GridOT.SelectedItems(0).Table.Key = "PTERYGIUM" Then
                        UpdatePterygium()
                    End If

                Catch ex As Exception
                    ' MsgBox("Error " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub GridOT_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOT.SelectionChanged
        Try
            If GridOT.SelectedItems(0).Table.Key = "OTRegistration" Then
                BtnUpdateOPNote.Enabled = False
                BtnPrintPreview.Enabled = False
            Else
                BtnUpdateOPNote.Enabled = True
                BtnPrintPreview.Enabled = True
            End If

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If GridOT.GetRow.GroupCaption <> "" Then
            MessageBox.Show("Please select operation note.", "Show", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                'Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)

                If GridOT.SelectedItems(0).Table.Key = "SCLERAL BUCKLING" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim TblScleralBuckling As DataTable = DA_ScleralBuckling.SelectScleralBuckling(GridOT.SelectedItems(0).GetRow.Cells("SCLERAL_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_ScleralBuckling, TblScleralBuckling, PreviewOP.AxAcroPDF1, "Scleral_Buckling")
                    PreviewOP.ShowDialog()
                End If

                If GridOT.SelectedItems(0).Table.Key = "INTRAVITREAL_INJECTION" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim TblInjection As DataTable = DA_Intravitreal_Injection.SelectInjectionOp(GridOT.SelectedItems(0).GetRow.Cells("INJECTION_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_Injection, TblInjection, PreviewOP.AxAcroPDF1, "Injection_operation")
                    PreviewOP.ShowDialog()
                End If
                If GridOT.SelectedItems(0).Table.Key = "GENERAL_OPERATIVE" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim TblGeneralOP As DataTable = DA_General_Operative.SelectOperatID(GridOT.SelectedItems(0).GetRow.Cells("GENERAL_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_GeneralOperative, TblGeneralOP, PreviewOP.AxAcroPDF1, "General_Operative")
                    PreviewOP.ShowDialog()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PHACOEMULSIFICATION" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim Phacoe As DataTable = DA_Phacoe.SelectPhacoemulsification(GridOT.SelectedItems(0).GetRow.Cells("PHACOEMULSIF_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_Phacoemulsification, Phacoe, PreviewOP.AxAcroPDF1, "Phacoemulsification")
                    PreviewOP.ShowDialog()
                End If
                If GridOT.SelectedItems(0).Table.Key = "ECCE" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim tblECCE As DataTable = DA_ECCE.SelectECCE(GridOT.SelectedItems(0).GetRow.Cells("ECCE_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_ECCE, tblECCE, PreviewOP.AxAcroPDF1, "ECCE")
                    PreviewOP.ShowDialog()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PAR_PLANA" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim tblParPlana As DataTable = DA_ParPlana.SelectPaPlana(GridOT.SelectedItems(0).GetRow.Cells("PA_PLANA_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_PA_PLANA, tblParPlana, PreviewOP.AxAcroPDF1, "ParPlana")
                    PreviewOP.ShowDialog()
                End If
                If GridOT.SelectedItems(0).Table.Key = "TRABECULECTOMY" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim TblTrab As DataTable = DA_Trab.SelectTrabeculectomy(GridOT.SelectedItems(0).GetRow.Cells("TRABECULECTIOMY_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_Trab, TblTrab, PreviewOP.AxAcroPDF1, "Trabeculectomy")
                    PreviewOP.ShowDialog()
                End If
                If GridOT.SelectedItems(0).Table.Key = "PTERYGIUM" Then
                    Dim PreviewOP As New OperationNotePreview
                    Dim TblPtery As DataTable = DA_Ptery.SelectPterygium(GridOT.SelectedItems(0).GetRow.Cells("PTERYGIUM_ID").Value)
                    EXPORT_PDF_PRINTER(CRV_Ptery, TblPtery, PreviewOP.AxAcroPDF1, "Ptery")
                    PreviewOP.ShowDialog()
                End If

            Catch ex As Exception
                ' MsgBox("Error " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    
    Private Sub DashboardDoctorConsult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnRefreshData_Click(sender, e)
    End Sub

    Private Sub GridFollowUp_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFollowUp.RowDoubleClick
        '  DAPatientWaiting.InsertNewWaiting(GridFollowUp.GetRow.Cells("PatientNo").Value, 0, GridFollowUp.GetRow.Cells("FOLLOW_NOTE").Value, "2", GetDateServer.Date, "1")
    End Sub

    Private Sub BtnSendToConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendToConsult.Click
        If GridFollowUp.SelectedItems.Count = 0 Then Exit Sub
        If GridFollowUp.GetRow.Cells("FOLLO_STATUS").Value = 2 Then
            MessageBox.Show("The patient already send to waiting consultation!", "Follow Up", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to send to patient waiting list?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'DAPatientWaiting.InsertNewWaiting(GridPatientInformation.GetRow.Cells("PatientNo").Value, 0, "", "2", GetDateServer.Date, "1")
            If DAPatientWaiting.InsertNewWaiting(GridFollowUp.GetRow.Cells("PatientNo").Value, 0, GridFollowUp.GetRow.Cells("FOLLOW_NOTE").Value, "2", GetDateServer.Date, "1") = 1 Then
                DA_VA.InsertNewVA(GridFollowUp.GetRow.Cells("PatientNo").Value, DAPatientWaiting.SelectMaxWaitID, Now.Date, "", "", "", "", "", "", "", "", "", "", "", "")
                If DAFollowUP.UpdateStatus(2, GridFollowUp.GetRow.Cells("FOLLOW_ID").Value) = 1 Then
                    ViewPatientFollowUpByDate(Now.Date, Now.Date)
                End If
            End If
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
