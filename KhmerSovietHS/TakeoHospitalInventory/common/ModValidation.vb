Module ModValidation
    Function CheckReceipt(ByVal ReceiptNo As String) As Boolean
        Dim sql As String = "SELECT COUNT(ReceiptNo) FROM TblPatientReceipt WHERE  ReceiptNo=" & ReceiptNo
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidateTextField(ByVal txt As TextBox, ByVal fieldName As String, ByVal errProvider As ErrorProvider) As Boolean
        Try
            If txt.Text.Trim = "".Trim Then
                errProvider.SetError(txt, _
                   "The " & fieldName & " must not be blank. " & _
                   "Please enter a " & fieldName & ".")
                txt.Focus()
                Return False
            Else
                errProvider.SetError(txt, Nothing)
                Return True
            End If
        Catch ex As Exception

        End Try
        
    End Function
    Public Function ValidateCombobox(ByVal Cbo As ComboBox, ByVal cboName As String, ByVal errProvider As ErrorProvider) As Boolean
        If Cbo.Text.Trim = "".Trim Then
            errProvider.SetError(Cbo, _
               "The " & cboName & " must not be blank. " & _
               "Please enter a " & cboName & ".")
            'Cbo.Focus()
            Return False
        Else
            errProvider.SetError(Cbo, Nothing)
            Return True
        End If
    End Function
    Function ValidateLabelField(ByVal lbl As Label, ByVal lblName As String, ByVal ErrProvider As ErrorProvider) As Boolean
        If lbl.Text.Trim = "".Trim Then
            ErrProvider.SetError(lbl, _
               "The " & lblName & " must not be blank. " & _
               "Please enter a " & lblName & ".")

            Return False
        Else
            ErrProvider.SetError(lbl, Nothing)
            Return True
        End If
    End Function
    Function ValidateDateField(ByVal dateField As DateTimePicker, ByVal lblName As String, ByVal errProvider As ErrorProvider) As Boolean
        If dateField.Checked = False Then
            errProvider.SetError(dateField, _
              "The " & lblName & " must not be blank. " & _
              "Please enter a " & lblName & ".")
            Return False
        Else
            errProvider.SetError(dateField, Nothing)
            Return True
        End If
    End Function

    'Function CheckReceipt(ByVal ReceiptNo As String) As Boolean
    '    Dim sql As String = "SELECT COUNT(ReceiptNo) FROM TblPatientReceipt WHERE  ReceiptNo=" & ReceiptNo
    '    Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    '    If count > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Public Function ValidateDateTimePicker(ByVal DatePicker As DateTimePicker, ByVal cboName As String, ByVal errProvider As ErrorProvider) As Boolean
        If DatePicker.Checked = False Then
            errProvider.SetError(DatePicker, _
               "The " & cboName & " must not be blank. " & _
               "Please enter a " & cboName & ".")
            DatePicker.Focus()
            Return False
        Else
            errProvider.SetError(DatePicker, Nothing)
            Return True
        End If
    End Function
End Module
