Public Class FormTypeOfPatient

    Private Sub FormTypeOfPatient_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FormTypeOfPatient_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub


    Private Sub FormTypeOfPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click

    End Sub
End Class