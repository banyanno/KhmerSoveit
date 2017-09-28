Module MCashReceipt

    Dim generalDAO As New GeneralDAO

    Public Sub SaveCashReceipt_Reserved( _
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
            MsgBox("Insert new cash receipt successfully", MsgBoxStyle.OkOnly, "New Cash Receipt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub SaveCashReceipt( _
        ByVal ReceiptNo As Long, ByVal IDCashReceipt As String, ByVal HN As Long, ByVal PatientName As String, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal MedicineFeeRiel As Double, ByVal MedicineFeeUSD As Double, _
        ByVal GlassFeeRiel As Double, ByVal GlassFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, _
        ByVal AmountWord As String, ByVal ConMed As String, ByVal ConGLA As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierIn As String, ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal DateNow As Date, ByVal Pay As String, ByVal Years As Integer)
        Try
            '-----tblPatientReceipt--------------------------------------------
            generalDAO.InsertDAO(" INSERT INTO tblPatientReceipt " _
                    & " (ReceiptNo, IDCashReceipt, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                    & " MedicineFeeRiel, MedicineFeeUSD, GlassFeeRiel, GlassFeeUSD, SocialFeeRiel," _
                    & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConMED, ConGLA, ConSocialFee, ConFullFee," _
                    & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, DateNow, ConPay, Years)" _
                    & " VALUES(" & ReceiptNo & ",'" & IDCashReceipt & "'," & HN & ",'" & PatientName & "'," _
                    & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                    & MedicineFeeRiel & "," & MedicineFeeUSD & "," & GlassFeeRiel & "," & GlassFeeUSD & "," _
                    & SocialFeeRiel & "," & SocialFeeUSD & "," _
                    & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
                    & AmountWord & "','" & ConMed & "','" & ConGLA & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
                    & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "','" & DateNow & "','" & Pay & "'," & Years & ")")
            MsgBox("Insert new cash receipt successfully", MsgBoxStyle.OkOnly, "New Cash Receipt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateCashReceipt( _
        ByVal ReceiptNo As Long, ByVal ID As Long, ByVal HN As Long, ByVal PatientName As String, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal MedicineFeeRiel As Double, ByVal MedicineFeeUSD As Double, _
        ByVal GlassFeeRiel As Double, ByVal GlassFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, _
        ByVal AmountWord As String, ByVal ConMed As String, ByVal ConGLA As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal DateUpdate As Date)
        Try
            '-----tblPatientReceipt--------------------------------------------
            generalDAO.UpdateDAO("UPDATE tblPatientReceipt SET" _
                    & " HN=" & HN & ", PatientName='" & PatientName & "'," _
                    & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & ", TotalRiel=" & TotalRiel & ", TotalUSD=" & TotalUSD & "," _
                    & " MedicineFeeRiel=" & MedicineFeeRiel & ", MedicineFeeUSD=" & MedicineFeeUSD & "," _
                    & " GlassFeeRiel=" & GlassFeeRiel & ", GlassFeeUSD=" & GlassFeeUSD & ", SocialFeeRiel=" & SocialFeeRiel & "," _
                    & " SocialFeeUSD=" & SocialFeeUSD & ", FullFeeRiel=" & FullFeeRiel & ", FullFeeUSD=" & FullFeeUSD & "," _
                    & " Rates=" & Rates & ", AmoutWord='" & AmountWord & "', ConMED='" & ConMed & "', ConGLA='" & ConGLA & "'," _
                    & " ConSocialFee='" & ConSocialFee & "', ConFullFee='" & ConFullFee & "'," _
                    & " ConGeneral='" & ConGeneral & "', CashierUpdate='" & CashierUpdate & "'," _
                    & " PrintCount=" & PrintCount & ", DateIn='" & DateIn & "', DateUpdate='" & DateUpdate & "' Where ID=" & ID & "")
            MsgBox("Update cash receipt successfully", MsgBoxStyle.OkOnly, "Cashier: Update Cash Receipt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Public Sub UpdateCashReceiptCashier(ByVal ID As Long, ByVal CashRiel As Double, _
                                    ByVal CashUSD As Double, ByVal Cashier As String, ByVal DateUpdate As Date)
        Try
            '-----tblPatientReceipt--------------------------------------------
            generalDAO.UpdateDAO("Update tblPatientReceipt Set" _
                    & " CashRiel=" & CashRiel & ", CashUSD=" & CashUSD & "," _
                    & " CashierUpdate='" & Cashier & "', DateUpdate='" & DateUpdate & "', ConPay='1' Where ID=" & ID & " and ConGeneral='CR'")
            MsgBox("Update cash receipt successfully", MsgBoxStyle.OkOnly, "Update Cash Receipt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

    Friend Function GenerateNo(ByVal FieldNo As String, ByVal Table As String) As String

        Dim day As Integer = Microsoft.VisualBasic.DateAndTime.Year(Now)
        Dim month As String = Microsoft.VisualBasic.DateAndTime.Month(Now).ToString
        If month.Length = 1 Then
            month = "0" & month
        Else
            month = month
        End If
        Dim idHn As Double
        Try
            idHn = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar("SELECT MAX(" & FieldNo & ") FROM " & Table) + 1
        Catch ex As Exception
            idHn = 1
        End Try
        Return day & month.ToString & idHn.ToString
    End Function

    Public Function getMaxID() As Double
        Dim DateServer As Date = ModGlobleVariable.GeteDateServer
        Dim years As Double = DateServer.Year
        Dim month As String = DateServer.Month.ToString
        If month.Length = 1 Then
            month = "0" & month
        Else
            month = month
        End If
        Dim idHn As Double
        Try
            idHn = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar("SELECT COUNT(ID) from tblPatientReceipt WHERE Years=" & years) + 1
        Catch ex As Exception
            idHn = 1
        End Try
        Return years.ToString.Substring(2, 2) & month.ToString & idHn.ToString
    End Function

    Function CheckDuplicateReceiptNo(ByVal ReceiptNo As Long, ByVal TableName As String) As Boolean
        Dim sql As String = "SELECT ReceiptNo FROM " & TableName & " WHERE ReceiptNo=" & ReceiptNo
        Dim no As Double = CDbl(ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql))
        If ReceiptNo = no Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckCashReceipt(ByVal IDCR As String) As Boolean
        Try
            Dim sqlHN = "Select ReceiptNo FROM tblPatientReceipt WHERE IDCashReceipt='" & IDCR & "'"
            Dim totalRow As Integer = generalDAO.SelectDAOAsDataTatable(sqlHN).Rows.Count
            If totalRow = 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function SelectCashReceiptByHN(ByVal HN As Long) As DataTable
        Dim sql As String = "SELECT HN, PatientName, IDCashReceipt, CashUSD, CashRiel, TotalUSD, TotalRiel," _
                        & " DateIn, CashierIn, AmoutWord, MedicineFeeRiel, MedicineFeeUSD, " _
                        & " GlassFeeRiel, GlassFeeUSD, ConMED, ConGLA, ConSocialFee,ID" _
                        & " FROM tblPatientReceipt Where HN=" & HN & " and ConGeneral='CR' and ConDelete='0' and DateIn<='" & Format(Date.Now(), "MM/dd/yyyy") & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectCashReceipt(ByVal ID As Long) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.IDCashReceipt, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.MedicineFeeRiel, PR.MedicineFeeUSD, " _
                        & " PR.GlassFeeRiel, PR.GlassFeeUSD, PR.ConMED, PR.ConGLA, PR.ConSocialFee,PR.ID" _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.ID=" & ID & " and PR.ConGeneral='CR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function SelectCashReceiptByRecID(ByVal RecID As String) As DataTable
        Dim sql As String = "SELECT PR.HN, P.NameKhmer, PR.IDCashReceipt, PR.CashUSD, PR.CashRiel, PR.TotalUSD, PR.TotalRiel," _
                        & " PR.DateIn, PR.CashierIn, PR.AmoutWord, PR.MedicineFeeRiel, PR.MedicineFeeUSD, " _
                        & " PR.GlassFeeRiel, PR.GlassFeeUSD, PR.ConMED, PR.ConGLA, PR.ConSocialFee,PR.ID" _
                        & " FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where PR.IDCashReceipt='" & RecID & "' and PR.ConGeneral='CR' and PR.ConDelete='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function ReportCashReceipt(ByVal IDCashReceipt As Long) As DataSet
        Try
            Dim Con As SqlClient.SqlConnection = generalDAO.getConnection
            Dim SqlAdapter As New SqlClient.SqlDataAdapter
            Dim DSet As New DataSetCashReceipt
            Dim Sql As String = ""
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim SqlCom As New SqlClient.SqlCommand
            Sql = "SELECT  HN, PatientName, ReceiptNo, CashUSD, CashRiel, TotalUSD, TotalRiel, DateIn," _
                    & " CashierIn, AmoutWord, MedicineFeeRiel, MedicineFeeUSD, " _
                    & " GlassFeeRiel, GlassFeeUSD, ConMED, ConGLA, IDCashReceipt " _
                    & " FROM tblPatientReceipt Where IDCashReceipt=" & IDCashReceipt & ""
            SqlCom.CommandText = Sql
            SqlCom.Connection = Con
            SqlAdapter.SelectCommand = SqlCom
            SqlAdapter.Fill(DSet)
            Con.Close()
            Return DSet
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Function

    Public Sub UpdatePayCashReceipt(ByVal IDCashReceipt As Long)
        Try
            '-----tblPatientReceipt--------------------------------------------
            generalDAO.UpdateDAO("Update tblPatientReceipt Set ConPay='1' Where IDCashReceipt=" & IDCashReceipt & " and ConGeneral='CR'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        End Try
    End Sub

End Module
