Public Class FrmFindInPatientHistory

    Function SelectNewInPatientNormal(ByVal PatientNo As String, ByVal From As String, ByVal DateTo As String) As String
        Dim sql As String = "SELECT " & _
       " * FROM V_NewInpatientDetialLeave" & _
       " WHERE " & _
       " (CAST(CONVERT(VARCHAR(10), DateDischarge, 1)  " & _
        " AS DateTime) BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & From & "' AS DATETIME), 1) AS Datetime) " & _
        " AND CAST(CONVERT(VARCHAR(10), " & _
        " CAST('" & DateTo & "' AS DATETIME), 1) AS Datetime))  "
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " ORDER BY CreateDate ASC"
        Return sql
    End Function
    Function SelectDateFollowUp(ByVal DateFollowUp As String) As String
        Dim SQL As String = "SELECT * FROM V_NewInpatientDetialLeave WHERE CAST(CONVERT(VARCHAR(10), DateFollowUp, 1) as DateTime) " & _
        "=CAST(CONVERT(VARCHAR(10),CAST('" & DateFollowUp & "' AS DATETIME), 1) as Datetime)"
        Return SQL
    End Function
    Private Sub FillHistoryDateFollowUp()
        Me.DSWardWithOT.Clear()
        Dim SQlDataAdapter As New SqlClient.SqlDataAdapter
        Dim Cnn As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim SqlComman As New SqlClient.SqlCommand
        Try
            SqlComman.CommandText = SelectDateFollowUp(DateFollowUp.Value)
            SqlComman.Connection = Cnn
            SQlDataAdapter.SelectCommand = SqlComman
            SQlDataAdapter.Fill(DSWardWithOT.V_NewInpatientDetialLeave)
            SQlDataAdapter.Dispose()
            SqlComman.Dispose()
            'DSWardWithOT.Dispose()
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub FillNewInPatientHistory()
        Me.DSWardWithOT.Clear()
        Dim SQlDataAdapter As New SqlClient.SqlDataAdapter
        Dim Cnn As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim SqlComman As New SqlClient.SqlCommand
        Try
            SqlComman.CommandText = SelectNewInPatientNormal(TxtPatienNo.Text, DateFrom.Value, DateTo.Value)
            SqlComman.Connection = Cnn
            SQlDataAdapter.SelectCommand = SqlComman
            SQlDataAdapter.Fill(DSWardWithOT.V_NewInpatientDetialLeave)
            SQlDataAdapter.Dispose()
            SqlComman.Dispose()
            'DSWardWithOT.Dispose()
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        GetHistoryInPatient()
    End Sub
    Sub GetHistoryInPatient()
        FillNewInPatientHistory()
        Me.View_OTRegistrationTableAdapter.Fill(Me.DSWardWithOT.View_OTRegistration)
        Me.V_IOLRegistrationTableAdapter.Fill(Me.DSWardWithOT.V_IOLRegistration)
    End Sub

    Private Sub GridNewInPatient_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridNewInPatient.SelectionChanged
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Text
                GridDiallyBook.DataSource = ModDaillyBook.SelectDaillyBookByNewInpatient(NewInNo)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtPatienNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatienNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub BtnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplay.Click
        FillHistoryDateFollowUp()
        Me.View_OTRegistrationTableAdapter.Fill(Me.DSWardWithOT.View_OTRegistration)
        Me.V_IOLRegistrationTableAdapter.Fill(Me.DSWardWithOT.V_IOLRegistration)
    End Sub

    Private Sub GridNewInPatient_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridNewInPatient.DoubleClick
        Try
            If GridNewInPatient.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim FNewInPatient As New FRMNewInPatient()
                Dim NewInNo As Integer = GridNewInPatient.SelectedItems(0).GetRow.Cells(0).Value
                Dim PatientNo As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(1).Value
                Dim PatienName As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(2).Value
                Dim Age As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(3).Value
                Dim Sex As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(4).Value
                Dim address As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(5).Value
                Dim Eye As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(6).Value
                Dim Diagnosis As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(7).Value
                Dim VA_RE As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(8).Value
                Dim VA_LE As String = GridNewInPatient.SelectedItems(0).GetRow.Cells(9).Value
                Try
                    FNewInPatient.DateDischarge.Checked = True
                    FNewInPatient.DateDischarge.Value = GridNewInPatient.SelectedItems(0).GetRow.Cells(10).Value
                Catch ex As Exception
                    FNewInPatient.DateDischarge.Checked = False
                End Try
                Try
                    FNewInPatient.DateFollowUp.Checked = True
                    FNewInPatient.DateFollowUp.Value = GridNewInPatient.SelectedItems(0).GetRow.Cells(11).Value
                Catch ex As Exception
                    FNewInPatient.DateFollowUp.Checked = False
                End Try
                Dim Signature As Boolean = GridNewInPatient.SelectedItems(0).GetRow.Cells(12).Value
                Dim TypeDiagnosis As Boolean = GridNewInPatient.SelectedItems(0).GetRow.Cells(16).Value
                Dim Waiting As Boolean = GridNewInPatient.SelectedItems(0).GetRow.Cells(14).Value
                FNewInPatient.LblSaveOption.Text = NewInNo
                FNewInPatient.TxtPatientNo.Text = PatientNo
                FNewInPatient.TxtPatientNo.Enabled = False
                FNewInPatient.TxtPatientName.Text = PatienName
                FNewInPatient.TxtAge.Text = Age
                FNewInPatient.TxtSex.Text = Sex
                FNewInPatient.TxtAddress.Text = address
                FNewInPatient.CboEye.Text = Eye
                FNewInPatient.CboDiagnosis.Text = Diagnosis
                FNewInPatient.TxtVARE.Text = VA_RE
                FNewInPatient.txtVALE.Text = VA_LE
                FNewInPatient.ChSignature.Checked = Signature
                FNewInPatient.ChTypeOther.Checked = TypeDiagnosis
                'FNewInPatient.ChWaitingOT.Checked = Waiting
                FNewInPatient.ShowDialog()
                If FNewInPatient.isCloseNewInPatient = True Then
                    GetHistoryInPatient()
                End If
                FNewInPatient.Dispose()
                FNewInPatient.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class