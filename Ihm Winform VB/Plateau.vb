Imports Bibliotheque

Public Class Plateau
    Private Sub Plateau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelj1.Text = Profils.NameJ1()
        Labelj2.Text = Profils.NameJ2()

        Dim tabplateau(2, 3) As Pieces
        Dim plateaucs(2, 3) As  Bibliotheque.Plateau

        Dim tanuj1 As New Tanuki(3, 2, 1)
        Dim koroj1 As New Koropokkuru(3, 1, 1)
        Dim kitsj1 As New Kitsune(3, 0, 1)
        Dim kodj1 As New Kodama(2, 1, 1)

        Dim tanuj2 As New Tanuki(0, 0, 2)
        Dim koroj2 As New Koropokkuru(0, 1, 2)
        Dim kitsj2 As New Kitsune(0, 2, 2)
        Dim kodj2 As New Kodama(1, 1, 2)

        'Pieces joueurs 1
        tabplateau(3, 2) = tanuj1
        tabplateau(3, 1) = koroj1
        tabplateau(3, 0) = kitsj1
        tabplateau(2, 1) = kodj1
        'Pieces joueur 2
        tabplateau(0, 0) = tanuj2
        tabplateau(0, 1) = koroj2
        tabplateau(0, 2) = kitsj2
        tabplateau(1, 1) = kodj2



    End Sub


End Class