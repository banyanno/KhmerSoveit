Module ModDonation
    Function SaveNewDonation(ByVal DonationName As String, ByVal Description As String) As Integer
        Dim sql As String = "INSERT INTO Donation (DonationName,Description)" & _
                                   " VALUES (N'" & DonationName & "',N'" & Description & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateDonation(ByVal DonationID As Integer, ByVal DonationName As String, ByVal Description As String) As Integer
        Dim sql As String = "UPDATE Donation SET DonationName='" & DonationName & "',Description='" & Description & "' WHERE DonationID=" & DonationID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteDonation(ByVal DonationID As Integer) As Integer
        Dim sql As String = "DELETE FROM Donation WHERE DonationID=" & DonationID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function GetDonation() As DataTable
        Dim sql As String = "select DonationID,DonationName,Description FROM Donation"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SaveNewDonatPay(ByVal ReceiptNo As Double, ByVal HN As Double, ByVal NameEng As String, _
                            ByVal NameKhmer As String, ByVal Age As Integer, _
                            ByVal Sex As String, ByVal Address As String, ByVal Occupation As String, _
                            ByVal DonationPay As String, ByVal DateIn As Date, ByVal DonationID As Integer, ByVal DonationName As String, _
                            ByVal Operation As String, ByVal DonateNote As String, ByVal HosFee As Double, ByVal CashTotal As Double, ByVal DonateIn As String, ByVal Glasess_OR_Medicine As Integer, ByVal ComBindRefferal As String, ByVal DonateType As String) As Integer
        Dim SQL As String = "INSERT INTO DONATION_DETAIL (ReceiptNo,HN,NameEng,NameKhmer,Age,Sex,Address,Occupation,DonationPay,DateIn,DonationID,DonationName,Operation,DonateNote,HosFee,CashTotal,DonateIn,IS_GLASESS,ComBindRefferal,DonateType) VALUES " & _
        " (" & ReceiptNo & "," & HN & ",'" & NameEng & "','" & NameKhmer & "'," & Age & _
        ",'" & Sex & "','" & Address & "','" & Occupation & "'," & DonationPay & ",'" & DateIn & _
        "'," & DonationID & ",'" & DonationName & "','" & Operation & "','" & DonateNote & _
        "'," & HosFee & "," & CashTotal & ",'" & DonateIn & "'," & Glasess_OR_Medicine & ",'" & ComBindRefferal & "','" & DonateType & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(SQL)
    End Function
    Function UpdateDonatedPay(ByVal ID As Double, ByVal DonateID As Integer, ByVal DonateName As String, ByVal CashTotal As Double, ByVal DonatePay As Double, ByVal HosFee As Double, ByVal DateIn As Date, ByVal Operation As String) As Integer
        Dim SQL As String = "UPDATE DONATION_DETAIL SET DonationID=" & DonateID & ",DonationName='" & DonateName & "',CashTotal=" & CashTotal & " ,DonationPay= " & DonatePay & ",HosFee=" & HosFee & ",DateIn='" & DateIn & "',Operation='" & Operation & "'  WHERE ID=" & ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function DisableDonatedPay(ByVal ID As Double, ByVal Value As Boolean) As Integer
        Dim SQL As String = "UPDATE DONATION_DETAIL SET IsDelete='" & Value & "' WHERE ID=" & ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
End Module
