Public Class LabelArray
    Inherits System.Collections.CollectionBase
    Private ReadOnly HostForm As System.Windows.Forms.GroupBox
    Dim test As Integer = 30
    Public Function AddNewLabel(ByVal Text As String, ByVal Left As Integer, ByVal WidthLabel As Integer, ByVal Aligne As ContentAlignment) As System.Windows.Forms.Label
        Dim aLabel As New Label
        Me.List.Add(aLabel)
        HostForm.Controls.Add(aLabel)
        aLabel.Top = Count * 35
        aLabel.Width = WidthLabel
        'aLabel.BackColor = Color.Aqua
        aLabel.Left = Left
        aLabel.Tag = Me.Count
        aLabel.Text = Text
        aLabel.Font = New Font("Microsoft Sans Serif", 12)
        aLabel.TextAlign = Aligne
        Return aLabel
    End Function
    Public Function AddNewLabelForSubTotal(ByVal Text As String, ByVal Left As Integer, ByVal WidthLabel As Integer, ByVal Aligne As ContentAlignment, ByVal Top As Integer) As System.Windows.Forms.Label
        Dim aLabel As New Label
        Me.List.Add(aLabel)
        HostForm.Controls.Add(aLabel)
        aLabel.Top = Top
        aLabel.Width = WidthLabel
        aLabel.ForeColor = Color.Blue
        aLabel.Left = Left
        aLabel.Tag = Me.Count
        aLabel.Text = Text
        aLabel.Font = New Font("Microsoft Sans Serif", 12)
        aLabel.TextAlign = Aligne
        Return aLabel
    End Function
    Sub New(ByVal host As GroupBox)
        HostForm = host
        'AddNewLabel()
    End Sub
    Default Public ReadOnly Property _
        Item(ByVal Index As Integer) As _
        System.Windows.Forms.Label
        Get
            Return CType(Me.List.Item(Index), _
  System.Windows.Forms.Label)
        End Get
    End Property
    Public Sub Remove()
        ' Check to be sure there is a Label to remove.
        If Me.Count > 0 Then
            ' Remove the last Label added to the array 
            ' from the host form controls collection. 
            ' Note the use of the default property in 
            ' accessing the array.
            HostForm.Controls.Remove(Me(Me.Count - 1))
            Me.List.RemoveAt(Me.Count - 1)
        End If
    End Sub
End Class

