Module ModMoPoTsyo
    Function SaveNewMoPoTsyoCode(ByVal PatientNo As Integer, ByVal MoPoTysoCode As String) As Integer
        Dim sql As String = "INSERT INTO TblMopoTyso (PatientNo,MoPoTsyCode) VALUES(PatientNo='" & PatientNo & "',MoPoTsyCode='" & MoPoTysoCode & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateMoPoTsyo(ByVal MoPoID As Integer, ByVal MoPoTsyCode As String, ByVal PeriodDiabete As String, ByVal Diagnosis As String, _
                            ByVal DRetina_desease As Boolean, ByVal DCataract As Boolean, ByVal DPteriguim As Boolean, _
                            ByVal DGlaucom As Boolean, ByVal DRefractive_error As Boolean, ByVal DOther_deseases As Boolean, _
                            ByVal TyeOfDR As String, ByVal Treatment As String, ByVal NewReceipt As Double, ByVal OldReceipt As Double, ByVal InReceipt As Double, ByVal OPTReceipt As Double, ByVal TreatmentFee As Single, _
                            ByVal AppDate As DateTime) As Integer
        Dim sql As String = "UPDATE TblMopoTyso SET MoPoTsyCode='" & MoPoTsyCode & "', PeriodDiabete='" & PeriodDiabete & _
         "',Diagnosis='" & Diagnosis & "',DRetina_desease='" & DRetina_desease & "',DCataract='" & DCataract & _
         "',DPteriguim='" & DPteriguim & "',DGlaucom='" & DGlaucom & "',DRefractive_error='" & DRefractive_error & _
         "',DOther_deseases='" & DOther_deseases & "',TyeOfDR='" & TyeOfDR & "',Treatment='" & Treatment & _
         "',NewReceipt=" & NewReceipt & ",OldReceipt=" & OldReceipt & ",InReceipt=" & InReceipt & ",OPTReceipt=" & OPTReceipt & ",TreatmentFee=" & TreatmentFee & ",AppDate='" & AppDate & "',Filled='1'" & _
         " WHERE MoPoID=" & MoPoID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SaveNewMoPoTsyo(ByVal MoPoTsyCode As String, ByVal PatientNo As Double, ByVal PeriodDiabete As String, _
    ByVal Diagnosis As String, ByVal DRetina_desease As Boolean, ByVal DCataract As Boolean, ByVal DPteriguim As Boolean, _
    ByVal DGlaucom As Boolean, ByVal DRefractive_error As Boolean, ByVal DOther_deseases As Boolean, ByVal TyeOfDR As String, _
    ByVal Treatment As String, ByVal NewReceipt As Double, ByVal OldReceipt As Double, ByVal InReceipt As Double, ByVal OPTReceipt As Double, ByVal TreatmentFee As Single, ByVal AppDate As DateTime) As Integer
        Dim sql As String = "INSERT INTO TblMopoTyso(MoPoTsyCode," & _
        "PatientNo,PeriodDiabete,Diagnosis,DRetina_desease,DCataract,DPteriguim,DGlaucom,DRefractive_error,DOther_deseases," & _
        "TyeOfDR,Treatment,NewReceipt,OldReceipt,InReceipt,OPTReceipt,TreatmentFee,AppDate,Filled) " & _
        "VALUES('" & MoPoTsyCode & "'," & PatientNo & ",'" & PeriodDiabete & "','" & Diagnosis & "','" & DRetina_desease & "','" & _
        DCataract & "','" & DPteriguim & "','" & DGlaucom & "','" & DRefractive_error & "','" & DOther_deseases & "','" & _
        TyeOfDR & "','" & Treatment & "'," & NewReceipt & "," & OldReceipt & "," & InReceipt & "," & OPTReceipt & "," & TreatmentFee & ",'" & AppDate & "','True')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function CountNotFill(ByVal DFrom As Date, ByVal DTo As Date) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblMopoTyso WHERE Filled='False'" & _
         " AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DTo & "' AS DATETIME), 1) as Datetime) "
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function CountFill(ByVal DFrom As Date, ByVal DTo As Date) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblMopoTyso WHERE Filled='True'" & _
         " AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DTo & "' AS DATETIME), 1) as Datetime) "
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
End Module
