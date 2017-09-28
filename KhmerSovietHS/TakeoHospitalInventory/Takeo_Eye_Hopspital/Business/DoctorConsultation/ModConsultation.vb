Module ModConsultation

    Function FindPatientByNo(ByVal patientNo As Integer) As DataTable
        Dim sql As String = "SELECT PatientNo,NameEng,Age,Sex,Address,Telephone FROM TblPatients WHERE PatientNo=" & patientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckPatientRegisToday(ByVal PatientNo As String, ByVal Today As String) As Boolean
        Dim sql As String = "SELECT patientNo FROM TblFollowUp WHERE patientNo=" & PatientNo & " AND CONVERT(VARCHAR(10),CreateDate, 103)= CONVERT(VARCHAR(10),CAST('" & Today & "' as DATETIME),103)"
        Dim tblCheck As DataTable = ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
        If tblCheck.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckInpatient(ByVal FollowUPNo As String) As Boolean
        Dim sql As String = "SELECT FollowUpStatus FROM TblFollowUp WHERE HistoryNO=" & FollowUPNo
        Dim PatientStatus As Boolean = CBool(ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql))
        Return PatientStatus
    End Function
    Function DeleteHistory(ByVal PatientNo As String) As Integer
        Dim sql As String = "DELETE FROM FollowUpStatus WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function CheckPatient_And_ReceiptNo(ByVal PatientNo As String) As Boolean
        Dim sql As String = "SELECT PatientNo FROM TblFollowUp WHERE PatientNo=" & PatientNo
        Dim TblData As DataTable = ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
        If TblData.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetHistoryByPatientNo(ByVal patientNo As Double) As DataTable
        Dim sql As String = "SELECT HistoryNO," & _
        "PatientNo," & _
        "CreateDate," & _
        "Hearing," & _
        "Understand," & _
        "Seeing," & _
        "Physical," & _
        "BOV," & _
        "Diplopia," & _
        "EyePain," & _
        "Floaters," & _
        "EyeRedness," & _
        "FBSensation," & _
        "Tering," & _
        "EyeDischarge," & _
        "Photophobia," & _
        "OtherComplaint," & _
        "Duration," & _
        "OD," & _
        "OS," & _
        "OU," & _
        "CDMDPatient," & _
        "EyeSreening," & _
        "Self," & _
        "PatientReferal," & _
        "Friend_Relation," & _
        "OtherNGO," & _
        "Church," & _
        "HealthWorker," & _
        "OtherReferal," & _
        "PlainDate," & _
        "PlainVAR," & _
        "PlainVAL," & _
        "ICPHDate," & _
        "ICPHVAR," & _
        "ICPHVAL," & _
        "ICG1Date," & _
        "ICG1VAR," & _
        "ICG1VAL," & _
        "Initial_R_E," & _
        "Initial_L_E," & _
        "PrimDiag_RE," & _
        "PrimDiag_LE," & _
        "PrimDiag_RE_Code," & _
        "PrimDiag_LE_Code, " & _
        "HistoryIllness," & _
        "BlindNess," & _
        "Hypertension," & _
        "Diabetes," & _
        "Asthma," & _
        "Glaucoma," & _
        "Cataract," & _
        "AIDS," & _
        "TB," & _
        "Syphilis," & _
        "Treatment," & _
        "OperationType," & _
        "Spectacles," & _
        "FollowUpStatus," & _
        "ScreeningKV," & _
        "PreyKabasVC," & _
        "PreyScreening," & _
        "SchoolScreening," & _
        "MoPoCho " & _
        " FROM TblFollowUp WHERE PatientNo=" & patientNo & " ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function


    Function UpdatePatientHistory(ByVal HistoryNO As String, _
                                ByVal Hearing As Boolean, _
                                ByVal Understand As Boolean, _
                                ByVal Seeing As Boolean, _
                                ByVal Physical As Boolean, _
                                ByVal BOV As Boolean, _
                                ByVal Diplopia As Boolean, _
                                ByVal EyePain As Boolean, _
                                ByVal Floaters As Boolean, _
                                ByVal EyeRedness As Boolean, _
                                ByVal FBSensation As Boolean, _
                                ByVal Tering As Boolean, _
                                ByVal EyeDischarge As Boolean, _
                                ByVal Photophobia As Boolean, _
                                ByVal OtherComplaint As String, _
                                ByVal Duration As String, _
                                ByVal OD As String, _
                                ByVal OS As String, _
                                ByVal OU As String, _
                                ByVal CDMDPatient As Boolean, _
                                ByVal ScreeningKV As Boolean, _
                                ByVal EyeSreening As Boolean, _
                                ByVal Self As Boolean, _
                                ByVal PatientReferal As Boolean, _
                                ByVal Friend_Relation As Boolean, _
                                ByVal OtherNGO As Boolean, _
                                ByVal Church As Boolean, _
                                ByVal HealthWorker As Boolean, _
                                ByVal OtherReferal As Boolean, _
                                ByVal PlainDate As String, _
                                ByVal PlainVAR As String, _
                                ByVal PlainVAL As String, _
                                ByVal ICPHDate As String, _
                                ByVal ICPHVAR As String, _
                                ByVal ICPHVAL As String, _
                                ByVal ICG1Date As String, _
                                ByVal ICG1VAR As String, _
                                ByVal ICG1VAL As String, _
                                ByVal PrioritiyVAR As String, _
                                ByVal PriorityVAL As String, _
                                ByVal Initial_R_E As String, _
                                ByVal Initial_L_E As String, _
                                ByVal PrimDiag_RE As String, _
                                ByVal PrimDiag_LE As String, _
                                ByVal PriorityDiagnosis As String, _
                                ByVal PriorityEye As String, _
                                ByVal PrimDiag_RE_Code As String, _
                                ByVal PrimDiag_LE_Code As String, _
                                ByVal PriorityCode As String, _
                                ByVal HistoryIllness As String, _
                                ByVal BlindNess As Boolean, _
                                ByVal Hypertension As Boolean, _
                                ByVal Diabetes As Boolean, _
                                ByVal Asthma As Boolean, _
                                ByVal Glaucoma As Boolean, _
                                ByVal Cataract As Boolean, _
                                ByVal AIDS As Boolean, _
                                ByVal TB As Boolean, _
                                ByVal Syphilis As Boolean, _
                                ByVal Treatment As String, _
                                ByVal OperationType As String, _
                                ByVal Spectacles As String, _
                                ByVal FollowUpStatus As Boolean, _
                                ByVal PreyKabasVC As Boolean, _
                                ByVal PreyScreening As Boolean, _
                                ByVal SchoolScreening As Boolean, _
                                ByVal MoPoCho As Boolean, ByVal CombindReferal As String) As Integer
        Dim sql As String = "UPDATE TblFollowUp SET " & _
                            " Hearing = '" & Hearing & _
                            "' ,Understand =  '" & Understand & _
                            "' ,Seeing =  '" & Seeing & _
                            "' ,Physical =  '" & Physical & _
                            "' ,BOV =  '" & BOV & _
                            "' ,Diplopia =  '" & Diplopia & _
                            "' ,EyePain =  '" & EyePain & _
                            "' ,Floaters =  '" & Floaters & _
                            "' ,EyeRedness =  '" & EyeRedness & _
                            "' ,FBSensation =  '" & FBSensation & _
                            "' ,Tering =  '" & Tering & _
                            "' ,EyeDischarge =  '" & EyeDischarge & _
                            "' ,Photophobia =  '" & Photophobia & _
                            "' ,OtherComplaint =  '" & OtherComplaint & _
                            "' ,Duration =  '" & Duration & _
                            "' ,OD =  '" & OD & _
                            "' ,OS ='" & OS & _
                            "' ,OU ='" & OU & _
                            "' ,CDMDPatient =  '" & CDMDPatient & _
                            "' ,ScreeningKV = '" & ScreeningKV & _
                            "' ,EyeSreening =  '" & EyeSreening & _
                            "' ,Self =  '" & Self & _
                            "' ,PatientReferal  ='" & PatientReferal & _
                            "' ,Friend_Relation =  '" & Friend_Relation & _
                            "' ,OtherNGO =  '" & OtherNGO & _
                            "' ,Church =  '" & Church & _
                            "' ,HealthWorker =  '" & HealthWorker & _
                            "' ,OtherReferal =  '" & OtherReferal & _
                            "' ,PlainDate ='" & PlainDate & _
                            "' ,PlainVAR ='" & PlainVAR & _
                            "' ,PlainVAL ='" & PlainVAL & _
                            "' ,ICPHDate =  '" & ICPHDate & _
                            "' ,ICPHVAR ='" & ICPHVAR & _
                            "' ,ICPHVAL =  '" & ICPHVAL & _
                            "' ,ICG1Date =  '" & ICG1Date & _
                            "' ,ICG1VAR =  '" & ICG1VAR & _
                            "' ,ICG1VAL =  '" & ICG1VAL & _
                            "' ,PrioritiyVAR = '" & PrioritiyVAR & _
                            "' ,PriorityVAL = '" & PriorityVAL & _
                            "' ,Initial_R_E =  '" & Initial_R_E & _
                            "' ,Initial_L_E =  '" & Initial_L_E & _
                            "' ,PrimDiag_RE =  '" & PrimDiag_RE & _
                            "' ,PrimDiag_LE =  '" & PrimDiag_LE & _
                            "' ,PriorityDiagnosis= '" & PriorityDiagnosis & _
                            "' ,PriorityEye='" & PriorityEye & _
                            "' ,PrimDiag_RE_Code =  '" & PrimDiag_RE_Code & _
                            "' ,PrimDiag_LE_Code =  '" & PrimDiag_LE_Code & _
                            "' ,PriorityCode= '" & PriorityCode & _
                            "' ,HistoryIllness =  '" & HistoryIllness & _
                            "' ,BlindNess =  '" & BlindNess & _
                            "' ,Hypertension =  '" & Hypertension & _
                            "' ,Diabetes =  '" & Diabetes & _
                            "' ,Asthma =  '" & Asthma & _
                            "' ,Glaucoma =  '" & Glaucoma & _
                            "' ,Cataract =  '" & Cataract & _
                            "' ,AIDS =  '" & AIDS & _
                            "' ,TB ='" & TB & _
                            "' ,Syphilis =  '" & Syphilis & _
                            "' ,Treatment ='" & Treatment & _
                            "' ,OperationType ='" & OperationType & _
                            "' ,Spectacles ='" & Spectacles & _
                            "' ,FollowUpStatus ='" & FollowUpStatus & _
                            "' ,PreyKabasVC='" & PreyKabasVC & _
                            "' ,PreyScreening='" & PreyScreening & _
                            "' ,SchoolScreening='" & SchoolScreening & _
                            "' ,MoPoCho='" & MoPoCho & _
                            "' ,ComBindRefferal='" & CombindReferal & _
                            "' WHERE HistoryNO=" & HistoryNO
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Public Function SavePatientRegistration( _
            ByVal PatientNo As String _
           , ByVal CreateDate As String _
           , ByVal Hearing As Boolean _
           , ByVal Understand As Boolean _
           , ByVal Seeing As Boolean _
           , ByVal Physical As Boolean _
            , ByVal CDMDPatient As Boolean _
           , ByVal EyeSreening As Boolean _
           , ByVal Self As Boolean _
           , ByVal PatientReferal As Boolean _
           , ByVal Friend_Relation As Boolean _
           , ByVal OtherNGO As Boolean _
           , ByVal Church As Boolean _
           , ByVal HealthWorker As Boolean _
           , ByVal OtherReferal As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblFollowUp " & _
                  "(PatientNo" & _
                  ",CreateDate" & _
                    ",Hearing" & _
                    ",Understand" & _
                    ",Seeing" & _
                    ",Physical" & _
                    ",CDMDPatient" & _
                    ",EyeSreening" & _
                    ",Self" & _
                    ",PatientReferal" & _
                    ",Friend_Relation" & _
                    ",OtherNGO" & _
                    ",Church" & _
                    ",HealthWorker" & _
                    ",OtherReferal)" & _
                     " VALUES " & _
                    "(" & PatientNo & _
                    ",'" & CreateDate & _
                    "','" & Hearing & _
                  "','" & Understand & _
                  "','" & Seeing & _
                  "','" & Physical & _
                 "','" & CDMDPatient & _
                  "','" & EyeSreening & _
                  "','" & Self & _
                  "','" & PatientReferal & _
                  "','" & Friend_Relation & _
                  "','" & OtherNGO & _
                  "','" & Church & _
                  "','" & HealthWorker & _
                  "','" & OtherReferal & _
                   "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Public Function SavePatientHistory(ByVal PatientNo As String _
           , ByVal Hearing As Boolean _
           , ByVal Understand As Boolean _
           , ByVal Seeing As Boolean _
           , ByVal Physical As Boolean _
           , ByVal BOV As Boolean _
           , ByVal Diplopia As Boolean _
           , ByVal EyePain As Boolean _
           , ByVal Floaters As Boolean _
           , ByVal EyeRedness As Boolean _
           , ByVal FBSensation As Boolean _
           , ByVal Tering As Boolean _
           , ByVal EyeDischarge As Boolean _
           , ByVal Photophobia As Boolean _
           , ByVal OtherComplaint As String _
           , ByVal Duration As String _
           , ByVal OD As String _
           , ByVal OS As String _
           , ByVal OU As String _
           , ByVal CDMDPatient As Boolean _
           , ByVal EyeSreening As Boolean _
           , ByVal Self As Boolean _
           , ByVal PatientReferal As Boolean _
           , ByVal Friend_Relation As Boolean _
           , ByVal OtherNGO As Boolean _
           , ByVal Church As Boolean _
           , ByVal HealthWorker As Boolean _
           , ByVal OtherReferal As Boolean _
           , ByVal PlainDate As String _
           , ByVal PlainVAR As String _
           , ByVal PlainVAL As String _
           , ByVal ICPHDate As String _
           , ByVal ICPHVAR As String _
           , ByVal ICPHVAL As String _
           , ByVal ICG1Date As String _
           , ByVal ICG1VAR As String _
           , ByVal ICG1VAL As String _
           , ByVal PrioritiyVAR As String _
           , ByVal PriorityVAL As String _
           , ByVal Initial_R_E As String _
           , ByVal Initial_L_E As String _
           , ByVal PrimDiag_RE As String _
           , ByVal PrimDiag_LE As String _
           , ByVal PriorityDiagnosis As String _
           , ByVal PriorityEye As String _
           , ByVal PrimDiag_RE_Code As String _
           , ByVal PrimDiag_LE_Code As String _
           , ByVal HistoryIllness As String _
           , ByVal BlindNess As Boolean _
           , ByVal Hypertension As Boolean _
           , ByVal Diabetes As Boolean _
           , ByVal Asthma As Boolean _
           , ByVal Glaucoma As Boolean _
           , ByVal Cataract As Boolean _
           , ByVal AIDS As Boolean _
           , ByVal TB As Boolean _
           , ByVal Syphilis As Boolean _
           , ByVal Treatment As String _
           , ByVal OperationType As String _
           , ByVal Spectacles As String _
           , ByVal FollowUpStatus As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblFollowUp " & _
           "(PatientNo" & _
             ",Hearing" & _
           ",Understand" & _
           ",Seeing" & _
           ",Physical" & _
           ",BOV" & _
           ",Diplopia" & _
           ",EyePain" & _
           ",Floaters" & _
           ",EyeRedness" & _
           ",FBSensation" & _
           ",Tering" & _
           ",EyeDischarge" & _
           ",Photophobia" & _
           ",OtherComplaint" & _
           ",Duration" & _
           ",OD" & _
           ",OS" & _
           ",OU" & _
           ",CDMDPatient" & _
           ",EyeSreening" & _
           ",Self" & _
           ",PatientReferal" & _
           ",Friend_Relation" & _
           ",OtherNGO" & _
           ",Church" & _
           ",HealthWorker" & _
           ",OtherReferal" & _
           ",PlainDate" & _
           ",PlainVAR" & _
           ",PlainVAL" & _
           ",ICPHDate" & _
           ",ICPHVAR" & _
           ",ICPHVAL" & _
           ",ICG1Date" & _
           ",ICG1VAR" & _
           ",ICG1VAL" & _
           ",PrioritiyVAR" & _
           ",PriorityVAL" & _
           ",Initial_R_E" & _
           ",Initial_L_E" & _
           ",PrimDiag_RE" & _
           ",PrimDiag_LE" & _
           ",PriorityDiagnosis" & _
           ",PriorityEye" & _
           ",PrimDiag_RE_Code" & _
           ",PrimDiag_LE_Code" & _
           ",HistoryIllness" & _
           ",BlindNess" & _
           ",Hypertension" & _
           ",Diabetes" & _
           ",Asthma" & _
           ",Glaucoma" & _
           ",Cataract" & _
           ",AIDS" & _
           ",TB" & _
           ",Syphilis" & _
           ",Treatment" & _
           ",OperationType" & _
           ",Spectacles,FollowUpStatus)" & _
        " VALUES " & _
           "(" & PatientNo & _
          ",'" & Hearing & _
           "','" & Understand & _
           "','" & Seeing & _
           "','" & Physical & _
           "','" & BOV & _
           "','" & Diplopia & _
           "','" & EyePain & _
           "','" & Floaters & _
           "','" & EyeRedness & _
           "','" & FBSensation & _
           "','" & Tering & _
           "','" & EyeDischarge & _
           "','" & Photophobia & _
           "','" & OtherComplaint & _
           "','" & Duration & _
           "','" & OD & _
           "','" & OS & _
           "','" & OU & _
           "','" & CDMDPatient & _
           "','" & EyeSreening & _
           "','" & Self & _
           "','" & PatientReferal & _
           "','" & Friend_Relation & _
           "','" & OtherNGO & _
           "','" & Church & _
           "','" & HealthWorker & _
           "','" & OtherReferal & _
           "','" & PlainDate & _
           "','" & PlainVAR & _
           "','" & PlainVAL & _
           "','" & ICPHDate & _
           "','" & ICPHVAR & _
           "','" & ICPHVAL & _
           "','" & ICG1Date & _
           "','" & ICG1VAR & _
           "','" & ICG1VAL & _
           "','" & PrioritiyVAR & _
           "','" & PriorityVAL & _
           "','" & Initial_R_E & _
           "','" & Initial_L_E & _
           "','" & PrimDiag_RE & _
           "','" & PrimDiag_LE & _
           "','" & PriorityDiagnosis & _
           "','" & PriorityEye & _
           "','" & PrimDiag_RE_Code & _
           "','" & PrimDiag_LE_Code & _
           "','" & HistoryIllness & _
           "','" & BlindNess & _
           "','" & Hypertension & _
           "','" & Diabetes & _
           "','" & Asthma & _
           "','" & Glaucoma & _
           "','" & Cataract & _
           "','" & AIDS & _
           "','" & TB & _
           "','" & Syphilis & _
           "','" & Treatment & _
           "','" & OperationType & _
           "','" & Spectacles & _
           "','" & FollowUpStatus & _
           "')"

        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

End Module
