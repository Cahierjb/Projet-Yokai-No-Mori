Public Class Profils

    Dim _nomj1, _nomj2 As String
    Private Sub BtnConf_Click(sender As Object, e As EventArgs) Handles BtnConf.Click
        _nomj1 = TextBoxj1.Text
        _nomj2 = TextBoxj2.Text
        Plateau.Show()
        Ihm_Winform_VB.Menu.Close()
        Me.Close()
    End Sub

    Public Property NameJ1() As String
        Get
            Return _nomj1
        End Get
        Set(value As String)
            _nomj1 = value
        End Set
    End Property

    Public Property NameJ2() As String
        Get
            Return _nomj2
        End Get
        Set(value As String)
            _nomj2 = value
        End Set
    End Property

End Class