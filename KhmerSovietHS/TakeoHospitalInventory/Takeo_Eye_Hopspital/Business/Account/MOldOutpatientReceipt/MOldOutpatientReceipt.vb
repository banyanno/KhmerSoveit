Module MOldOutpatientReceipt

    Public Sub SaveOldOutpatientReceipt_Reserved( _
        ByVal ReceiptNo As Long, ByVal IDCashReceipt As Long, ByVal HN As Long, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal OperationFeeRiel As Double, ByVal OperationFeeUSD As Double, _
        ByVal ArtificialEyeFeeRiel As Double, ByVal ArtificialEyeUSD As Double, _
        ByVal OtherFeeRiel As Double, ByVal OtherFeeUSD As Double, _
        ByVal ConsultationFeeRiel As Double, ByVal ConsultationFeeUSD As Double, _
        ByVal FollowUpFeeRiel As Double, ByVal FollowUpFeeUSD As Double, _
        ByVal MedicineFeeRiel As Double, ByVal MedicineFeeUSD As Double, _
        ByVal GlassFeeRiel As Double, ByVal GlassFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, _
        ByVal AmountWord As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierIn As String, ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal DateUpdate As Date)
        Try
            '-----tblPatientReceipt--------------------------------------------
            ModGlobleVariable.GENERAL_DAO.InsertDAO(" INSERT INTO tblPatientReceipt " _
                    & " (ReceiptNo, IDCashReceipt, HN, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                    & " OperationFeeRiel, OperationFeeUSD, ArtificialEyeFeeRiel, ArtificialEyeFeeUSD, OtherFeeRiel," _
                    & " OtherFeeUSD, ConsultationFeeRiel, ConsultationFeeUSD, FollowUpFeeRiel, FollowUpFeeUSD," _
                    & " MedicineFeeRiel, MedicineFeeUSD, GlassFeeRiel, GlassFeeUSD, SocialFeeRiel," _
                    & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, AmoutWord, ConSocialFee, ConFullFee," _
                    & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, DateUpdate)" _
                    & " VALUES(" & ReceiptNo & "," & IDCashReceipt & "," & HN & "," _
                    & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                    & OperationFeeRiel & "," & OperationFeeUSD & "," & ArtificialEyeFeeRiel & "," & ArtificialEyeUSD & "," _
                    & OtherFeeRiel & "," & OtherFeeUSD & "," & ConsultationFeeRiel & "," & ConsultationFeeUSD & "," _
                    & FollowUpFeeRiel & "," & FollowUpFeeUSD & "," & MedicineFeeRiel & "," & MedicineFeeUSD & "," _
                    & GlassFeeRiel & "," & GlassFeeUSD & "," & SocialFeeRiel & "," & SocialFeeUSD & "," _
                    & FullFeeRiel & "," & FullFeeUSD & ",'" _
                    & AmountWord & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
                    & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "','" & DateUpdate & "')")
            MsgBox("Insert old out patient receipt successfully", MsgBoxStyle.OkOnly, "New Out Patient")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    'Public Function SaveOldOutpatientReceipt( _
    '    ByVal ReceiptNo As Long, ByVal HN As Long, ByVal PatientName As String, _
    '    ByVal CashRiel As Double, ByVal CashUSD As Double, _
    '    ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
    '    ByVal FollowUpFeeRiel As Double, ByVal FollowUpFeeUSD As Double, _
    '    ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
    '    ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, _
    '    ByVal AmountWord As String, ByVal ConFOL As String, ByVal ConSocialFee As String, _
    '    ByVal ConFullFee As String, ByVal ConGeneral As String, _
    '    ByVal CashierIn As String, ByVal CashierUpdate As String, _
    '    ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal Years As Integer) As Integer
    '    Try
    '        '-----tblPatientReceipt--------------------------------------------
    '        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(" INSERT INTO tblPatientReceipt " _
    '                & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
    '                & " FollowUpFeeRiel, FollowUpFeeUSD, SocialFeeRiel," _
    '                & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConFOL, ConSocialFee, ConFullFee," _
    '                & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, Years)" _
    '                & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
    '                & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
    '                & FollowUpFeeRiel & "," & FollowUpFeeUSD & "," _
    '                & SocialFeeRiel & "," & SocialFeeUSD & "," _
    '                & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
    '                & AmountWord & "','" & ConFOL & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
    '                & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "'," & Years & ")")
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.OkCancel)
    '    End Try
    'End Function

    Public Sub UpdateOldOutpatientReceipt( _
        ByVal ID As Long, ByVal HN As Long, ByVal PatientName As String, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal FollowUpFeeRiel As Double, ByVal FollowUpFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, _
        ByVal AmountWord As String, ByVal ConFOL As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal DateUpdate As Date)
        Try
            '-----tblPatientReceipt--------------------------------------------
            ModGlobleVariable.GENERAL_DAO.UpdateDAO("UPDATE tblPatientReceipt SET " _
                    & " HN=" & HN & ", PatientName='" & PatientName & "', CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
                    & " TotalRiel=" & TotalRiel & ", TotalUSD=" & TotalUSD & "," _
                    & " FollowUpFeeRiel=" & FollowUpFeeRiel & ", FollowUpFeeUSD=" & FollowUpFeeUSD & ", SocialFeeRiel=" & SocialFeeRiel & "," _
                    & " SocialFeeUSD=" & SocialFeeUSD & ", FullFeeRiel=" & FullFeeRiel & ", FullFeeUSD=" & FullFeeUSD & "," _
                    & " Rates=" & Rates & ", AmoutWord='" & AmountWord & "', ConFOL='" & ConFOL & "', ConSocialFee='" & ConSocialFee & "'," _
                    & " ConFullFee='" & ConFullFee & "', ConGeneral='" & ConGeneral & "', " _
                    & " CashierUpdate='" & CashierUpdate & "', PrintCount=" & PrintCount & ", DateIn='" & DateIn & "', DateUpdate='" & DateUpdate & "' Where ID=" & ID & "")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateReferalOutpatient( _
               ByVal HistoryNo As Long _
              , ByVal Hearing As Boolean _
              , ByVal Understand As Boolean _
              , ByVal Seeing As Boolean _
              , ByVal Physical As Boolean _
              , ByVal CDMDPatient As Boolean _
              , ByVal EyeScreeningTK As Boolean _
              , ByVal ScreeningKV As Boolean _
              , ByVal Self As Boolean _
              , ByVal PatientReferal As Boolean _
              , ByVal Friend_Relation As Boolean _
              , ByVal OtherNGO As Boolean _
              , ByVal Church As Boolean _
              , ByVal HealthWorker As Boolean _
              , ByVal OtherReferal As Boolean)
        Try
            ModGlobleVariable.GENERAL_DAO.UpdateDAO("UPDATE TblFollowUp SET " _
                & " Hearing ='" & Hearing & "', Understand='" & Understand & "', Seeing='" & Seeing & "', Physical='" & Physical & "', CDMDPatient='" & CDMDPatient & "', EyeSreening='" & EyeScreeningTK & "', " _
                & " ScreeningKV='" & ScreeningKV & "', Self='" & Self & "', PatientReferal='" & PatientReferal & "', Friend_Relation ='" & Friend_Relation & "', " _
                & " OtherNGO='" & OtherNGO & "', Church='" & Church & "', HealthWorker='" & HealthWorker & "', OtherReferal='" & OtherReferal & "' Where HistoryNo=" & HistoryNo & "")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateOldOutpatientReceiptCashier(ByVal ID As Long, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal FollowUpFeeRiel As Double, ByVal FollowUpFeeUSD As Double, _
        ByVal Rates As Double, ByVal AmountWord As String, ByVal DateIn As Date, ByVal CashierUpdate As String, _
        ByVal DateUpdate As Date, ByVal Pay As String)
        Try
            '-----tblPatientReceipt--------------------------------------------
            ModGlobleVariable.GENERAL_DAO.UpdateDAO("UPDATE tblPatientReceipt SET " _
                    & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
                    & " FollowUpFeeRiel=" & FollowUpFeeRiel & ", FollowUpFeeUSD=" & FollowUpFeeUSD & ", " _
                    & " Rates=" & Rates & ", AmoutWord='" & AmountWord & "', " _
                    & " DateIn='" & DateIn & "'," _
                    & " CashierUpdate='" & CashierUpdate & "', " _
                    & " DateUpdate='" & DateUpdate & "'," _
                    & " ConPay='" & Pay & "'  Where ID=" & ID & "")
            MsgBox("Update old-out patient receipt successfully", MsgBoxStyle.OkOnly, "Update Old-Out Patient")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    'Public Sub UpdateOldOutpatientReceiptCashier(ByVal ReceiptNo As Long, ByVal CashRiel As Double, _
    '                                ByVal CashUSD As Double, ByVal Cashier As String, ByVal DateUpdate As Date)
    '    Try
    '        '-----tblPatientReceipt--------------------------------------------
    '        generalDAO.UpdateDAO("Update tblPatientReceipt Set" _
    '                & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
    '                & " CashierUpdate='" & Cashier & "', DateUpdate='" & DateUpdate & "', ConPay='1' Where ReceiptNo=" & ReceiptNo & " and ConGeneral='OR'")
    '        MsgBox("Update old-out patient receipt successfully", MsgBoxStyle.OkOnly, "Update Old-Out patient Receipt")
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.OkCancel)
    '    End Try
    'End Sub

    Public Function SelectOldOutReceipt(ByVal ID As Long) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.ReceiptNo, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.FollowUpFeeRiel, PR.FollowUpFeeUSD, PR.ConFOL, PR.ConSocialFee, PR.ID " _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.ID=" & ID & " and PR.ConGeneral='OR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectOldOutReceiptByID(ByVal RID As Long) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.ReceiptNo, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.FollowUpFeeRiel, PR.FollowUpFeeUSD, PR.ConFOL, PR.ConSocialFee, PR.ID " _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.ReceiptNo=" & RID & " and PR.ConGeneral='OR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SearchReferal(ByVal PatientNo As Long, ByVal DateCreate As String) As DataTable
        Dim sql As String = "Select HistoryNo, Hearing, Understand, Seeing, Physical, CDMDPatient, EyeSreening, ScreeningKV, Self, PatientReferal, Friend_Relation, " _
                                      & " OtherNGO, Church, HealthWorker, OtherReferal from tblFollowUp Where PatientNo=" & PatientNo & " AND " _
                                      & " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) = " _
                                      & " CAST(CONVERT(VARCHAR(10),CAST('" & DateCreate & "' AS DATETIME), 1) as Datetime) AND FollowUpStatus = 'True'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectOldOutReceiptByHN(ByVal HN As Long) As DataTable
        Dim sql As String = "SELECT HN, PatientName, ReceiptNo, CashUSD, CashRiel, TotalUSD, TotalRiel," _
                        & " DateIn, CashierIn, AmoutWord, FollowUpFeeRiel, FollowUpFeeUSD, ConFOL, ConSocialFee " _
                        & " FROM tblPatientReceipt Where HN=" & HN & " and ConGeneral='OR' and ConDelete='0' and DateIn<='" & Format(Date.Now(), "MM/dd/yyyy") & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function CheckReceiptID(ByVal ReceiptID As Long) As Boolean
        Try
            Dim sqlHN = "Select ID FROM tblPatientReceipt WHERE ReceiptNo=" & ReceiptID & ""
            Dim totalRow As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sqlHN).Rows.Count
            If totalRow = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function getMaxID() As Integer
        Dim general As New GeneralDAO
        Dim day As Integer = Microsoft.VisualBasic.DateAndTime.Year(Now)
        Dim month As Integer = Microsoft.VisualBasic.DateAndTime.Month(Now)
        Dim idHn As Integer
        Try
            idHn = general.SelectDAOAsScalar("SELECT MAX(ID) from tblPatientReceipt") + 1
        Catch ex As Exception
            idHn = 1
        End Try
        Return day.ToString & month.ToString & idHn.ToString
    End Function

    Function UpdateSubSurgery(ByVal SIDS As String, ByVal SID As String, ByVal Surgerysub As String, ByVal Description As String, ByVal code As String) As Integer
        Dim sql As String = "UPDATE tblSurgerySub SET SID='" & SID & "', Surgerysub='" & Surgerysub.Replace("'", "''") & "',Description='" & Description.Replace("'", "''") & "',Code='" & code & "' where SSID=" & SIDS
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteSubSurgery(ByVal SID As String) As Integer
        Dim sql As String = "DELETE FROM tblSurgerySub WHERE sid=" & SID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function DeleteSubSurgeryBySSID(ByVal SSID As String) As Integer
        Dim sql As String = "DELETE FROM tblSurgerySub WHERE SSID=" & SSID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Public Function SelectSubSurgery(ByVal SID As String) As DataTable
        Dim sql As String = "SELECT * FROM tblSurgerySub where sid=" & SID
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Public Function ReportOldOutpatientReceipt(ByVal ReceiptID As Long) As DataSet
        Try
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetOldOutPatientReceipt
            Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
            Dim Sql As String = ""
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT  HN, PatientName, ReceiptNo, CashUSD, CashRiel, TotalUSD, TotalRiel, DateIn," _
                    & " CashierIn, AmoutWord, FollowUpFeeRiel, FollowUpFeeUSD, ConFOL " _
                    & " FROM tblPatientReceipt Where ReceiptNo=" & ReceiptID & ""
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

    End Function

    Public Sub UpdatePayOldOutpatientReceipt(ByVal ReceiptID As Long)
        Try
            '-----tblPatientReceipt--------------------------------------------
            ModGlobleVariable.GENERAL_DAO.UpdateDAO("Update tblPatientReceipt Set ConPay='1' Where ReceiptNo=" & ReceiptID & " and ConGeneral='OR'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

End Module
