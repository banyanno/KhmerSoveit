Module MNewOutpatientReceipt
    Public Sub SaveNewOutpatientReceipt_Reserved( _
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
            MsgBox("Insert new out patient receipt successfully", MsgBoxStyle.OkOnly, "New Medicine")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Function SaveNewOutpatientReceipt( _
        ByVal ReceiptNo As Long, _
        ByVal HN As Long, _
        ByVal PatientName As String, _
        ByVal CashRiel As Double, _
        ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, _
        ByVal TotalUSD As Double, _
        ByVal ConsultationFeeRiel As Double, _
        ByVal ConsultationFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, _
        ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, _
        ByVal FullFeeUSD As Double, _
        ByVal Rates As Double, _
        ByVal AmountWord As String, _
        ByVal ConCON As String, _
        ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, _
        ByVal ConGeneral As String, _
        ByVal CashierIn As String, _
        ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, _
        ByVal DateIn As Date, _
        ByVal DateNow As Date, _
        ByVal Years As Integer) As Integer

        '-----tblPatientReceipt--------------------------------------------
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO( _
                "INSERT INTO tblPatientReceipt " _
                 & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                 & " ConsultationFeeRiel, ConsultationFeeUSD, SocialFeeRiel," _
                 & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConCON, ConSocialFee, ConFullFee," _
                 & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, DateNow, Years)" _
                 & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
                 & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                 & ConsultationFeeRiel & "," & ConsultationFeeUSD & "," _
                 & SocialFeeRiel & "," & SocialFeeUSD & "," _
                 & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
                 & AmountWord & "','" & ConCON & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
                 & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "','" & DateNow & "'," & Years & ")")
    End Function

    Public Sub UpdateNewOutpatientReceipt( _
        ByVal ID As Long, ByVal HN As Long, ByVal PatientName As String, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal ConsultationFeeRiel As Double, ByVal ConsultationFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, _
        ByVal AmountWord As String, ByVal ConCON As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal DateUpdate As Date)
        Try
            '-----tblPatientReceipt--------------------------------------------
            ModGlobleVariable.GENERAL_DAO.UpdateDAO("UPDATE tblPatientReceipt SET" _
                    & " HN=" & HN & ", PatientName='" & PatientName & "', CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
                    & " TotalRiel=" & TotalRiel & ", TotalUSD=" & TotalUSD & ",ConsultationFeeRiel=" & ConsultationFeeRiel & "," _
                    & " ConsultationFeeUSD=" & ConsultationFeeUSD & ", SocialFeeRiel=" & SocialFeeRiel & "," _
                    & " SocialFeeUSD=" & SocialFeeUSD & ", FullFeeRiel=" & FullFeeRiel & ", FullFeeUSD=" & FullFeeUSD & "," _
                    & " Rates=" & Rates & ", AmoutWord='" & AmountWord & "', ConCON='" & ConCON & "', ConSocialFee='" & ConSocialFee & "'," _
                    & " ConFullFee='" & ConFullFee & "', ConGeneral='" & ConGeneral & "', " _
                    & " CashierUpdate='" & CashierUpdate & "', PrintCount=" & PrintCount & ", DateIn='" & DateIn & "'," _
                    & " DateUpdate='" & DateUpdate & "' Where ID=" & ID & "")
            MsgBox("Update new-out patient receipt successfully", MsgBoxStyle.OkOnly, "Update new-out patient receipt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateNewOutpatientReceiptCashier(ByVal ID As Long, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal ConsultationFeeRiel As Double, ByVal ConsultationFeeUSD As Double, _
        ByVal Rates As Double, ByVal AmountWord As String, _
    ByVal DateIn As DateTime, _
        ByVal CashierUpdate As String, ByVal DateUpdate As Date, ByVal Pay As String)

        Try
            '-----tblPatientReceipt--------------------------------------------------------------------
            ModGlobleVariable.GENERAL_DAO.UpdateDAO("UPDATE tblPatientReceipt SET" _
                    & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
                    & " ConsultationFeeRiel=" & ConsultationFeeRiel & "," _
                    & " ConsultationFeeUSD=" & ConsultationFeeUSD & ", " _
                    & " Rates=" & Rates & ", AmoutWord='" & AmountWord & "', " _
                    & " DateIn='" & DateIn & "'," _
                    & " CashierUpdate='" & CashierUpdate & "', " _
                    & " DateUpdate='" & DateUpdate & "'," _
                    & " ConPay='" & Pay & "' Where ID=" & ID & "")
            MsgBox("Update new-out patient receipt successfully", MsgBoxStyle.OkOnly, "Update new-out patient receipt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try

    End Sub

    'Public Sub UpdateNewOutpatientReceiptCashier(ByVal ReceiptNo As Long, ByVal CashRiel As Double, _
    '                                ByVal CashUSD As Double, ByVal Cashier As String, ByVal DateUpdate As Date)
    '    Try
    '        '-----tblPatientReceipt--------------------------------------------
    '        generalDAO.UpdateDAO("Update tblPatientReceipt Set" _
    '                & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
    '                & " CashierUpdate='" & Cashier & "', DateUpdate='" & DateUpdate & "', ConPay='1' Where ReceiptNo=" & ReceiptNo & " and ConGeneral='NR'")
    '        MsgBox("Update new out-patient receipt successfully", MsgBoxStyle.OkOnly, "Update New Out-patient Receipt")
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.OkCancel)
    '    End Try
    'End Sub

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

    Public Function SelectNewOutReceipt(ByVal ID As Long) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.ReceiptNo, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.ConsultationFeeRiel, PR.ConsultationFeeUSD, PR.ConCON, PR.ConSocialFee, PR.ID " _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.ID=" & ID & " and PR.ConGeneral='NR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectNewOutReceiptByID(ByVal RID As Long) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.ReceiptNo, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.ConsultationFeeRiel, PR.ConsultationFeeUSD, PR.ConCON, PR.ConSocialFee, PR.ID " _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.ReceiptNo=" & RID & " and PR.ConGeneral='NR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectNewOutReceiptByHN(ByVal HN As Long) As DataTable
        Dim sql As String = "SELECT HN, PatientName, ReceiptNo, CashUSD, CashRiel, TotalUSD, TotalRiel," _
                        & " DateIn, CashierIn, AmoutWord, ConsultationFeeRiel, ConsultationFeeUSD, ConCON, ConSocialFee " _
                        & " FROM tblPatientReceipt Where HN=" & HN & " and ConGeneral='NR' and ConDelete='0' and DateIn<='" & Format(Date.Now(), "MM/dd/yyyy") & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function ReportNewOutpatientReceipt(ByVal ReceiptID As Long) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetNewOutPatientReceipt
            Dim Sql As String = ""
            'If Con.State = ConnectionState.Closed Then
            '    Con.Open()
            'End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT  HN, PatientName, ReceiptNo, CashUSD, CashRiel, TotalUSD, TotalRiel, DateIn," _
                    & " CashierIn, AmoutWord, ConsultationFeeRiel, ConsultationFeeUSD, ConCON " _
                    & " FROM tblPatientReceipt Where ReceiptNo=" & ReceiptID & ""
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

    End Function

    Public Sub UpdatePayNewOutpatientReceipt(ByVal ReceiptID As Long)
        Try
            '-----tblPatientReceipt--------------------------------------------
            ModGlobleVariable.GENERAL_DAO.UpdateDAO("Update tblPatientReceipt Set ConPay='1' Where ReceiptNo=" & ReceiptID & " and ConGeneral='NR'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

End Module
