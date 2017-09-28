Module ModPatientReciept

    Function checkNewOutPatient(ByVal patientNo As String) As Boolean
        Dim sql As String = "SELECT count(patientNo) FROM TblPatientReciept WHERE patientNo=" & patientNo & " AND CheckReciept='1'"
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If count >= 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    '1 defind as Reciept New out-patient
    '2 defind as reciept Old out-patient
    '3 defind as reciept In-patient
    '4 defind as reciept Cash-reciept
    '5 defind as reciept Official-reciept
    Function SaveRecieptNewOutPatient(ByVal RecieptNo As String, _
                                ByVal PatientNo As String, _
                                ByVal CreateDate As String, _
                                ByVal NewAountInWord As String, _
                                ByVal NewReciept As String, _
                                ByVal currNew As Boolean, _
                                ByVal NewTotal As String, _
                                ByVal OldAmountInWord As String, _
                                ByVal OldReciept As String, _
                                ByVal CurrOld As Boolean, _
                                ByVal OldTotal As String, _
                                ByVal InAmountInWord As String, _
                                ByVal InOpt As String, _
                                ByVal currInopt As Boolean, _
                                ByVal InArt As String, _
                                ByVal CurrInArt As Boolean, _
                                ByVal InOther As String, _
                                ByVal CurrInOther As Boolean, _
                                ByVal InTotal As String, _
                                ByVal CashAmountInWord As String, _
                                ByVal CashMedicine As String, _
                                ByVal CurrCashMedicine As Boolean, _
                                ByVal CashGlasses As String, _
                                ByVal CurrCashGlasses As Boolean, _
                                ByVal CashTotal As String, _
                                ByVal OfficAmountInWord As String, _
                                ByVal OfficAmount As String, _
                                ByVal CurrOffic As Boolean, _
                                ByVal ReceivedBy As String, _
                                ByVal CheckReciept As String, _
                                ByVal Paid As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblPatientReciept(RecieptNo," & _
                            "PatientNo,CreateDate,NewAountInWord,NewRecieptRiel," & _
                            "NewRecieptDollar,NewTotal,OldAmountInWord,OldRecieptRiel," & _
                            "OldRecieptDollar,OldTotal,InAmountInWord,InOptRiel," & _
                            "InOptDollar,InArtRiel,InArtDollar,InOtherRiel,InOtherDollar," & _
                            "InTotal,CashAmountInWord,CashMedicineRiel,CashMedicineDollar," & _
                            "CashGlassesRiel,CashGlassesDollar,CashTotal,OfficAmountInWord," & _
                            "OfficAmountRiel,OfficAmountDollar,ReceivedBy,CheckReciept,Paid)" & _
                            "VALUES (" & RecieptNo & "," & PatientNo & _
                            ",'" & CreateDate & "',N'" & NewAountInWord & _
                            "'," & IIf(currNew = True, NewReciept, "0") & "," & IIf(currNew = False, NewReciept, "0") & _
                            "," & NewTotal & ",N'" & OldAmountInWord & _
                            "'," & IIf(CurrOld = True, OldReciept, "0") & "," & IIf(CurrOld = False, OldReciept, "0") & _
                            "," & OldTotal & ",N'" & InAmountInWord & _
                            "'," & IIf(currInopt = True, InOpt, "0") & "," & IIf(currInopt = False, InOpt, "0") & _
                            "," & IIf(CurrInArt = True, InArt, "0") & "," & IIf(CurrInArt = False, InArt, "0") & _
                            "," & IIf(CurrInOther = True, InOther, "0") & "," & IIf(CurrInOther = False, InOther, "0") & _
                            "," & InTotal & ",N'" & CashAmountInWord & _
                            "'," & IIf(CurrCashMedicine = True, CashMedicine, "0") & "," & IIf(CurrCashMedicine = False, CashMedicine, "0") & _
                            "," & IIf(CurrCashGlasses = True, CashGlasses, "0") & "," & IIf(CurrCashGlasses = False, CashGlasses, "0") & _
                            "," & CashTotal & ",N'" & OfficAmountInWord & _
                            "'," & IIf(CurrOffic = True, OfficAmount, "0") & "," & IIf(CurrOffic = False, OfficAmount, "0") & _
                            ",'" & ReceivedBy & "','" & CheckReciept & "','" & Paid & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

    Function SelectNewOutPatientReciept(ByVal receiptNo As String, ByVal ReceiptDate As String) As DataTable

        Dim sql As String = "SELECT * FROM ViewNewOutPatient "
        If EmptyString(receiptNo) <> "0" Then
            sql = sql & " WHERE recieptNo=" & receiptNo
        End If
        If ReceiptDate <> "" Then
            sql = sql & " WHERE (CONVERT(VARCHAR(10),CreateDate, 103)>= CONVERT(VARCHAR(10),CAST('" & ReceiptDate & "' as DATETIME),103)) AND CheckReciept='1'"
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectNewOutPReceiptByPatientNo(ByVal patientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewNewOutPatient WHERE PatientNo=" & patientNo & " AND CheckReciept='1'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function UpdateNewOutPatientReciept(ByVal No As String, ByVal NewAountInWord As String, ByVal NewReciept As String, ByVal ReciewBy As String, ByVal currNewOut As Boolean) As Integer
        Dim sql As String = "UPDATE TblPatientReciept SET NewAountInWord = N'" & NewAountInWord & "',NewRecieptRiel = " & IIf(currNewOut = True, NewReciept, "0") & ",NewRecieptDollar =" & IIf(currNewOut = False, NewReciept, "0") & ",NewTotal = " & NewReciept & ",ReceivedBy = '" & ReciewBy & _
                    "' WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function


    '============================== End Reciept New out-patient =====================================


    '============================== Start Reciept Old out-patient ===================================

    Function SaveOldOutPatientReciept(ByVal RecieptNo As String, ByVal PatientNo As String, _
                                    ByVal CreateDate As String, ByVal OldAmountInWord As String, _
                                    ByVal OldReciept As String, ByVal currOldReciept As Boolean, _
                                    ByVal OldTotal As String, ByVal ReceivedBy As String, _
                                    ByVal CheckReciept As String, ByVal paid As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblPatientReciept(RecieptNo,PatientNo,CreateDate,OldAmountInWord,OldRecieptRiel,OldRecieptDollar,OldTotal,ReceivedBy,CheckReciept,Paid)" & _
                            "VALUES(" & RecieptNo & "," & PatientNo & ",'" & CreateDate & "',N'" & OldAmountInWord & "'," & IIf(currOldReciept = True, OldReciept, "0") & "," & IIf(currOldReciept = False, OldReciept, "0") & "," & OldTotal & ",'" & ReceivedBy & "','" & CheckReciept & "','" & paid & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateOldOutPatientReciept(ByVal No As String, ByVal OldAmountInword As String, ByVal oldAmount As String, ByVal currOldReciept As Boolean, ByVal ReceivedBy As String) As Integer
        Dim sql As String = "UPDATE TblPatientReciept SET OldAmountInWord = N'" & OldAmountInword & "',OldRecieptRiel = " & IIf(currOldReciept = True, oldAmount, "0") & ",OldRecieptDollar = " & IIf(currOldReciept = False, oldAmount, "0") & ",OldTotal = " & oldAmount & ",ReceivedBy = '" & ReceivedBy & _
            "' WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectOldOutPatientReciept(ByVal ReceiptNo As String, ByVal ReceiptDate As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewOldOutPatient "
        If EmptyString(ReceiptNo) <> "0" Then
            sql = sql & " WHERE recieptNo=" & ReceiptNo & " AND CheckReciept='2'"
        End If
        If ReceiptDate <> "" Then
            sql = sql & " WHERE (CONVERT(VARCHAR(10),CreateDate, 103)>= CONVERT(VARCHAR(10),CAST('" & ReceiptDate & "' as DATETIME),103)) AND CheckReciept='2'"
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectOldPatientByPatientNo(ByVal patientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewOldOutPatient WHERE patientNo=" & patientNo & " AND CheckReciept='2'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    '============================= End Reciept Old out-patient ======================================

    '============================= Start reciept in-patient    ======================================

    Function SaveInPatientReciept(ByVal RecieptNo As String, ByVal PatientNo As String, _
                                ByVal CreateDate As String, ByVal InAmountInWord As String, _
                                ByVal InOpt As String, ByVal CurrInOpt As Boolean, _
                                ByVal InArt As String, ByVal CurrInArt As Boolean, _
                                ByVal InOther As String, ByVal CurrInOther As Boolean, _
                                ByVal InTotal As String, ByVal ReceivedBy As String, _
                                ByVal CheckReciept As String, ByVal paid As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblPatientReciept (RecieptNo,PatientNo,CreateDate,InAmountInWord,InOptRiel,InOptDollar,InArtRiel,InArtDollar,InOtherRiel,InOtherDollar,InTotal,ReceivedBy,CheckReciept,Paid)" & _
                            " VALUES (" & RecieptNo & "," & PatientNo & _
                            ",'" & CreateDate & "',N'" & InAmountInWord & _
                            "'," & IIf(CurrInOpt = True, InOpt, "0") & _
                            "," & IIf(CurrInOpt = False, InOpt, "0") & _
                            "," & IIf(CurrInArt = True, InArt, "0") & _
                            "," & IIf(CurrInArt = False, InArt, "0") & _
                            "," & IIf(CurrInOther = True, InOther, "0") & _
                            "," & IIf(CurrInOther = False, InOther, "0") & _
                            "," & InTotal & ",'" & ReceivedBy & "','" & CheckReciept & "','" & paid & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function SaveNewInpatientToWard(ByVal ReceiptNo As String, ByVal PatientNo As String, ByVal FollowUpNo As String)
        Dim sql As String = "INSERT INTO TblNewInPatient (ReceiptNewInpatientNo,PatientNo,FollowUpNo) VALUES(" & ReceiptNo & "," & PatientNo & "," & FollowUpNo & ")"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateInpateintReciept(ByVal No As String, ByVal InAmountInWord As String, _
                                ByVal InOpt As String, ByVal CurrInOpt As Boolean, _
                                ByVal InArt As String, ByVal CurrInArt As Boolean, _
                                ByVal InOther As String, ByVal CurrInOther As Boolean, _
                                ByVal InTotal As String, ByVal ReceivedBy As String) As Integer
        Dim sql As String = "UPDATE TblPatientReciept SET InAmountInWord = N'" & InAmountInWord & "',InOptRiel =" & IIf(CurrInOpt = True, InOpt, "0") & ", InOptDollar = " & IIf(CurrInOpt = False, InOpt, "0") & ", InArtRiel = " & IIf(CurrInArt = True, InArt, "0") & ",InArtDollar = " & IIf(CurrInArt = False, InArt, "0") & ",InOtherRiel = " & IIf(CurrInOther = True, InOther, "0") & ",InOtherDollar = " & IIf(CurrInOther = False, InOther, "0") & ",InTotal = " & InTotal & ",ReceivedBy = '" & ReceivedBy & _
                            "' WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectInpatientReiept(ByVal ReceiptNo As String, ByVal ReceiptDate As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewInPatientReciept "
        If EmptyString(ReceiptNo) <> "0" Then
            sql = sql & " WHERE recieptNo=" & ReceiptNo & " AND CheckReciept='3'"
        End If
        If ReceiptDate <> "" Then
            sql = sql & " WHERE (CONVERT(VARCHAR(10),CreateDate, 103)>= CONVERT(VARCHAR(10),CAST('" & ReceiptDate & "' as DATETIME),103)) AND CheckReciept='3'"
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectInPatientByPatientNO(ByVal patientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewInPatientReciept WHERE PatientNo=" & patientNo & " AND CheckReciept='3'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    '============================ End reciept Cash Reciept  ======================================

    '============================ Start Cash-patient reciept =============================================

    Function SaveCashPatientReciept(ByVal RecieptNo As String, ByVal PatientNo As String, ByVal CreateDate As String, _
                                    ByVal CashAmountInWord As String, _
                                    ByVal CashMedicine As String, ByVal CurrCashMed As Boolean, _
                                    ByVal CashGlasses As String, ByVal CurrCashGlass As Boolean, _
                                    ByVal CashTotal As String, ByVal ReceivedBy As String, _
                                    ByVal CheckReciept As String, ByVal paid As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblPatientReciept(RecieptNo,PatientNo,CreateDate,CashAmountInWord,CashMedicineRiel,CashMedicineDollar,CashGlassesRiel,CashGlassesDollar,CashTotal,ReceivedBy,CheckReciept,Paid)" & _
                            " VALUES (" & RecieptNo & "," & PatientNo & ",'" & CreateDate & _
                            "',N'" & CashAmountInWord & _
                            "'," & IIf(CurrCashMed = True, CashMedicine, "0") & _
                            "," & IIf(CurrCashMed = False, CashMedicine, "0") & _
                            "," & IIf(CurrCashGlass = True, CashGlasses, "0") & _
                            "," & IIf(CurrCashGlass = False, CashGlasses, "0") & _
                            "," & CashTotal & ",'" & ReceivedBy & "','" & CheckReciept & "','" & paid & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateCashPatientReciept(ByVal No As String, _
                                    ByVal CashAmountInWord As String, _
                                    ByVal CashMedicine As String, ByVal CurrCashMed As Boolean, _
                                    ByVal CashGlasses As String, ByVal CurrCashGlass As Boolean, _
                                    ByVal CashTotal As String, ByVal ReceivedBy As String) As Integer
        Dim sql As String = "UPDATE TblPatientReciept SET CashAmountInWord =N'" & CashAmountInWord & "',CashMedicineRiel = " & IIf(CurrCashMed = True, CashMedicine, "0") & ", CashMedicineDollar = " & IIf(CurrCashMed = False, CashMedicine, "0") & ",CashGlassesRiel = " & IIf(CurrCashGlass = True, CashGlasses, "0") & ", CashGlassesDollar =" & IIf(CurrCashGlass = False, CashGlasses, "0") & ",CashTotal =" & CashTotal & ", ReceivedBy ='" & ReceivedBy & _
                            "' WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectCashPatientReciept(ByVal ReceiptNo As String, ByVal ReceiptDate As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewCashPatientReciept "
        If EmptyString(ReceiptNo) <> "0" Then
            sql = sql & " WHERE recieptNo=" & ReceiptNo & " AND CheckReciept='4'"
        End If
        If ReceiptDate <> "" Then
            sql = sql & " WHERE (CONVERT(VARCHAR(10),CreateDate, 103)>= CONVERT(VARCHAR(10),CAST('" & ReceiptDate & "' as DATETIME),103)) AND CheckReciept='4'"
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectCashByPatientNo(ByVal patientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewCashPatientReciept WHERE patientNo=" & patientNo & " AND CheckReciept='4'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    '============================ End cash-patient reciept =========================================

    '============================ Start official-patient reciept ===================================

    Function SaveOfficialReciept(ByVal RecieptNo As String, ByVal PatientNo As String, _
                                ByVal CreateDate As String, ByVal OfficAmountInWord As String, _
                                ByVal OfficAmount As String, ByVal CurrOffic As Boolean, _
                                ByVal ReceivedBy As String, ByVal CheckReciept As String, ByVal paid As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblPatientReciept(RecieptNo,PatientNo,CreateDate,OfficAmountInWord,OfficAmountRiel,OfficAmountDollar,ReceivedBy,CheckReciept,Paid)" & _
                            " VALUES (" & RecieptNo & "," & PatientNo & ",'" & CreateDate & "',N'" & OfficAmountInWord & "'," & IIf(CurrOffic = True, OfficAmount, "0") & "," & IIf(CurrOffic = False, OfficAmount, "0") & ",'" & ReceivedBy & "','" & CheckReciept & "','" & paid & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateOfficialReciept(ByVal No As String, ByVal OfficAmountInWord As String, _
                                ByVal OfficAmount As String, ByVal CurrOffic As Boolean, _
                                ByVal ReceivedBy As String) As Integer
        Dim sql As String = "UPDATE TblPatientReciept SET OfficAmountInWord = N'" & OfficAmountInWord & _
                            "',OfficAmountRiel = " & IIf(CurrOffic = True, OfficAmount, "0") & _
                            ",OfficAmountDollar =" & IIf(CurrOffic = False, OfficAmount, "0") & _
                            ",ReceivedBy = '" & ReceivedBy & _
                            "' WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectOfficialReciept(ByVal ReceiptNo As String, ByVal ReceiptDate As String) As DataTable

        Dim sql As String = "SELECT * FROM ViewOfficialPatientReciept "
        If EmptyString(ReceiptNo) <> "0" Then
            sql = sql & " WHERE recieptNo=" & ReceiptNo & " AND CheckReciept='5'"
        End If
        If ReceiptDate <> "" Then
            sql = sql & " WHERE (CONVERT(VARCHAR(10),CreateDate, 103)>= CONVERT(VARCHAR(10),CAST('" & ReceiptDate & "' as DATETIME),103)) AND CheckReciept='5'"
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectOfficialByPatientNo(ByVal patientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM ViewOfficialPatientReciept WHERE patientNo=" & patientNo & " AND CheckReciept='5'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
