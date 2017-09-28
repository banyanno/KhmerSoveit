Public Class UpdateReferral
    Dim DA_Referral As New DSREFFERRAL_TEHTableAdapters.REFFERAL_TEHTableAdapter
  
    Private Sub UpdateReferral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitChListReferral()
    End Sub
    Sub InitChListReferral()
        With ChListReferral
            .Items.Clear()
            Dim TblReferral As DataTable = DA_Referral.GetData
            For Each DRow As DataRow In TblReferral.Rows
                .Items.Add(DRow("REFFERAL_NAME"))
            Next
        End With
    End Sub
    Function GetTextReferralV1() As String
        Try
            Dim str As String = ""
            For i As Int16 = 0 To ChListReferral.Items.Count - 1
                If ChListReferral.GetItemChecked(i) = True Then
                    str = str & " + " & ChListReferral.Items(i).ToString
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If lblBookID.Text = "0" Then
        Else
            If GetTextReferralV1() = "" Then
                MessageBox.Show("Please select Referral list.", "Refferal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Do you want update Referral?", "Referral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If ModOld_Outpatient.UpdateReferral(GetTextReferralV1, lblBookID.Text) = 1 Then
                    ModOld_Outpatient.DeleteReferalDetail(LblPatientNo.Text)
                    ModRegistration.UpdatePatientLastReferal(LblPatientNo.Text, GetTextReferralV1)
                    For i As Int16 = 0 To ChListReferral.Items.Count - 1
                        If ChListReferral.GetItemChecked(i) = True Then
                            ModOld_Outpatient.InsertRefferal(LblPatientNo.Text, ChListReferral.Items(i))
                            'sqlComm.CommandText = SQLSavePatientReferral(TxtPatientNo.Text, ChListReferral.Items(i))
                            'sqlComm.ExecuteNonQuery()
                        End If
                    Next
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If

    End Sub
    Function SQLSavePatientReferral(ByVal PATIENT_NO As Double, ByVal REFERRAL_FROM As String) As String
        Dim SQL As String = "INSERT INTO REFFERAL_PATIENT_DETAIL (PATIENT_NO,REFERRAL_FROM) VALUES(" & PATIENT_NO & ",'" & REFERRAL_FROM & "')"
        Return SQL
    End Function
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class