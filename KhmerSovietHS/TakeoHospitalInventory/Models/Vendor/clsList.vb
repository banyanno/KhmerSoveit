Public Class clsList
    Private myItemDisplay As String
    Private myItemValue As String

    Public Sub New(ByVal strItemDisplay As String, ByVal strItemValue As String)
        Me.myItemDisplay = strItemDisplay
        Me.myItemValue = strItemValue
    End Sub 'New

    Public ReadOnly Property ItemDisplay() As String
        Get
            Return myItemDisplay
        End Get
    End Property

    Public ReadOnly Property ItemValue() As String
        Get
            Return myItemValue
        End Get
    End Property
End Class
