Module MInpatientReceipt

    Dim generalDAO As New GeneralDAO

    Public Sub SaveInpatientReceipt_Reserved( _
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
            generalDAO.InsertDAO(" INSERT INTO tblPatientReceipt " _
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
            MsgBox("Insert new inpatient receipt successfully", MsgBoxStyle.OkOnly, "New Medicine")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Function SaveInpatientReceipt( _
        ByVal ReceiptNo As Long, ByVal HN As Long, ByVal PatientName As String, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal OperationFeeRiel As Double, ByVal OperationFeeUSD As Double, _
        ByVal ArtificialEyeFeeRiel As Double, ByVal ArtificialEyeUSD As Double, _
        ByVal OtherFeeRiel As Double, ByVal OtherFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, ByVal AmountWord As String, _
        ByVal ConOP As String, ByVal ConAE As String, ByVal ConOT As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierIn As String, ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, _
        ByVal DateNow As Date, ByVal Years As Integer, ByVal Operation As String, _
        ByVal IsDonation As Boolean, ByVal DonationID As Double, ByVal DonationName As String, _
        ByVal DonationPay As Double) As Integer
        Try
            '-----tblPatientReceipt--------------------------------------------
            Return generalDAO.InsertDAO("INSERT INTO tblPatientReceipt " _
                    & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                    & " OperationFeeRiel, OperationFeeUSD, ArtificialEyeFeeRiel, ArtificialEyeFeeUSD, OtherFeeRiel," _
                    & " OtherFeeUSD, SocialFeeRiel," _
                    & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConOP, ConAE, ConOT, ConSocialFee, ConFullFee," _
                    & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, DateNow,Years, Operation)" _
                    & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
                    & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                    & OperationFeeRiel & "," & OperationFeeUSD & "," & ArtificialEyeFeeRiel & "," & ArtificialEyeUSD & "," _
                    & OtherFeeRiel & "," & OtherFeeUSD & "," _
                    & SocialFeeRiel & "," & SocialFeeUSD & "," _
                    & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
                    & AmountWord & "','" & ConOP & "','" & ConAE & "','" & ConOT & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
                    & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "','" & DateNow & "'," & Years & ",'" & Operation & "')")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Function
    Function CheckDateDuplicate(ByVal PatientNo As Double, ByVal DateIn As Date) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInpatient WHERE PatientNo=" & PatientNo & " AND  " & _
        "CAST(CONVERT(VARCHAR(10), CAST(CreateDate AS DATETIME), 1) AS Datetime)=CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) AND  Status='True'"
        Return generalDAO.SelectDAOAsScalar(sql)
    End Function
    Public Sub UpdateInpatientReceipt( _
        ByVal ID As Long, ByVal HN As Long, ByVal PatientName As String, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal OperationFeeRiel As Double, ByVal OperationFeeUSD As Double, _
        ByVal ArtificialEyeFeeRiel As Double, ByVal ArtificialEyeUSD As Double, _
        ByVal OtherFeeRiel As Double, ByVal OtherFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, ByVal AmountWord As String, _
        ByVal ConOP As String, ByVal ConAE As String, ByVal ConOT As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal DateUpdate As Date, ByVal Operation As String, _
        ByVal IsDonation As Boolean, ByVal DonationID As Integer, ByVal DonationName As String, _
        ByVal DonationPay As Double, ByVal DonateNote As String, ByVal HosFee As Double, ByVal CashTotal As Double)
        Try
            '-----tblPatientReceipt--------------------------------------------
            generalDAO.UpdateDAO("UPDATE tblPatientReceipt SET " _
                    & " HN=" & HN & ", PatientName='" & PatientName & "', CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
                    & " TotalRiel=" & TotalRiel & ", TotalUSD=" & TotalUSD & ", OperationFeeRiel=" & OperationFeeRiel & "," _
                    & " OperationFeeUSD=" & OperationFeeUSD & ", ArtificialEyeFeeRiel=" & ArtificialEyeFeeRiel & "," _
                    & " ArtificialEyeFeeUSD=" & ArtificialEyeUSD & ", OtherFeeRiel=" & OtherFeeRiel & "," _
                    & " OtherFeeUSD=" & OtherFeeUSD & ", SocialFeeRiel=" & SocialFeeRiel & "," _
                    & " SocialFeeUSD=" & SocialFeeUSD & ", FullFeeRiel=" & FullFeeRiel & ", FullFeeUSD=" & FullFeeUSD & "," _
                    & " Rates=" & Rates & ", AmoutWord='" & AmountWord & "', ConOP='" & ConOP & "'," _
                    & " ConAE='" & ConAE & "', ConOT='" & ConOT & "', ConSocialFee='" & ConSocialFee & "'," _
                    & " ConFullFee='" & ConFullFee & "', ConGeneral='" & ConGeneral & "'," _
                    & " CashierUpdate='" & CashierUpdate & "', PrintCount=" & PrintCount & ", DateIn='" & DateIn _
                    & "', DateUpdate='" & DateUpdate & "',Operation='" & Operation & "',IsDonation='" & IsDonation _
                    & "',DonationID=" & DonationID & ",DonationName='" & DonationName & "',DonationPay=" & DonationPay _
                    & ",DonateNote='" & DonateNote & "',HosFee=" & HosFee & " ,  CashTotal=" & CashTotal & " WHERE ID=" & ID & "")
            MsgBox("Update inpatient receipt successfully", MsgBoxStyle.OkOnly, "Update Inpatient Receipt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateInpatientReceiptCashier(ByVal ID As Long, _
        ByVal CashRiel As Double, _
        ByVal CashUSD As Double, _
        ByVal OperationFeeRiel As Double, _
        ByVal OperationFeeUSD As Double, _
        ByVal ArtificialEyeFeeRiel As Double, _
        ByVal ArtificialEyeUSD As Double, _
        ByVal OtherFeeRiel As Double, _
        ByVal OtherFeeUSD As Double, _
        ByVal Rates As Double, _
        ByVal AmountWord As String, _
        ByVal DateIn As Date, _
        ByVal CashierUpdate As String, _
        ByVal DateUpdate As Date, _
        ByVal Pay As String, _
        ByVal HosFee As Double, _
        ByVal CashFee As Double)

        'Try
        '-----tblPatientReceipt--------------------------------------------
        Dim SQlUpdateReceipt As String = "UPDATE tblPatientReceipt SET " _
                 & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
                 & " OperationFeeRiel=" & OperationFeeRiel & "," _
                 & " OperationFeeUSD=" & OperationFeeUSD & ", " _
                 & " ArtificialEyeFeeRiel=" & ArtificialEyeFeeRiel & "," _
                 & " ArtificialEyeFeeUSD=" & ArtificialEyeUSD & ", " _
                 & " OtherFeeRiel=" & OtherFeeRiel & "," _
                 & " OtherFeeUSD=" & OtherFeeUSD & ", " _
                 & " Rates=" & Rates & ", AmoutWord='" & AmountWord & "', " _
                 & " DateIn='" & DateIn & "'," _
                 & " CashierUpdate='" & CashierUpdate & "', " _
                 & " DateUpdate='" & DateUpdate & "'," _
                 & " ConPay='" & Pay & "'," _
                 & " HosFee=" & HosFee & "," _
                 & " CashTotal=" & CashFee _
                 & " WHERE ID=" & ID & ""
        If generalDAO.UpdateDAO(SQlUpdateReceipt) = 1 Then
            MsgBox("Update inpatient receipt successfully", MsgBoxStyle.OkOnly, "Update Inpatient Receipt")
        Else
            MsgBox("Error save cash receipt. could you check agian.", MsgBoxStyle.OkOnly, "Update Inpatient Receipt")
        End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        'End Try

    End Sub

    'Public Sub UpdateInpatientReceiptCashier(ByVal ReceiptNo As Long, ByVal CashRiel As Double, _
    '                                ByVal CashUSD As Double, ByVal Cashier As String, ByVal DateUpdate As Date)
    '    Try
    '        '-----tblPatientReceipt--------------------------------------------
    '        generalDAO.UpdateDAO("Update tblPatientReceipt Set" _
    '                & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
    '                & " CashierUpdate='" & Cashier & "', DateUpdate='" & DateUpdate & "', ConPay='1' Where ReceiptNo=" & ReceiptNo & " and ConGeneral='IR'")
    '        MsgBox("Update inpatient receipt successfully", MsgBoxStyle.OkOnly, "Update Inpatient Receipt")
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.OkCancel)
    '    End Try
    'End Sub

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

    Public Function CheckReceiptID(ByVal ReceiptID As Long) As Boolean
        Try
            Dim sqlHN = "Select ID FROM tblPatientReceipt WHERE ReceiptNo=" & ReceiptID & ""
            Dim totalRow As Integer = generalDAO.SelectDAOAsDataTatable(sqlHN).Rows.Count
            If totalRow = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function ReportInpatientReceipt(ByVal ReceiptID As Long) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetInpatientReceipt
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT  HN, PatientName, ReceiptNo, CashUSD, CashRiel, TotalUSD, TotalRiel, DateIn," _
                    & " CashierIn, AmoutWord, OperationFeeRiel, OperationFeeUSD, " _
                    & " ArtificialEyeFeeRiel, ArtificialEyeFeeUSD, OtherFeeRiel, OtherFeeUSD, ConOP, ConAE, ConOT, Operation,IsDonation,DonationID,DonationName,DonationPay " _
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

    Public Function SelectInpatientReceipt(ByVal ID As Long) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.ReceiptNo, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.OperationFeeRiel, PR.OperationFeeUSD, " _
                        & " PR.ArtificialEyeFeeRiel, PR.ArtificialEyeFeeUSD, PR.OtherFeeRiel, PR.OtherFeeUSD, " _
                        & " PR.ConOP, PR.ConAE, PR.ConOT, PR.ConSocialFee, PR.Operation, PR.ID,PR.IsDonation," _
                        & " PR.DonationID,PR.DonationName,PR.DonationPay,PR.DonateNote,PR.HosFee,PR.CashTotal " _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.ID=" & ID _
                        & " and PR.ConGeneral='IR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectInpatientReceiptByID(ByVal RID As Long) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.ReceiptNo, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.OperationFeeRiel, PR.OperationFeeUSD, " _
                        & " PR.ArtificialEyeFeeRiel, PR.ArtificialEyeFeeUSD, PR.OtherFeeRiel, PR.OtherFeeUSD, PR.ConOP, PR.ConAE, PR.ConOT, PR.ConSocialFee, PR.Operation, PR.ID" _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.ReceiptNo=" & RID & " and PR.ConGeneral='IR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectInpatientReceiptByHN(ByVal HN As Long) As DataTable
        Dim sql As String = "SELECT HN, PatientName, ReceiptNo, CashUSD, CashRiel, TotalUSD, TotalRiel," _
                        & " DateIn, CashierIn, AmoutWord, OperationFeeRiel, OperationFeeUSD, " _
                        & " ArtificialEyeFeeRiel, ArtificialEyeFeeUSD, OtherFeeRiel, OtherFeeUSD, ConOP, ConAE, ConOT, ConSocialFee, Operation, ID" _
                        & " FROM tblPatientReceipt Where HN=" & HN & " and ConGeneral='IR' and ConDelete='0' and DateIn<='" & Format(Date.Now(), "MM/dd/yyyy") & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Sub UpdatePayInpatientReceipt(ByVal ReceiptID As Long)
        Try
            '-----tblPatientReceipt--------------------------------------------
            generalDAO.UpdateDAO("Update tblPatientReceipt Set ConPay='1' Where ReceiptNo=" & ReceiptID & " and ConGeneral='IR'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

End Module
