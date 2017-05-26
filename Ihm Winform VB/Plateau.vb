Imports Bibliotheque

Public Class Plateau

    Private Sub MaJAffichage()


    End Sub


    Private Sub Plateau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelj1.Text = Profils.NameJ1()
        Labelj2.Text = Profils.NameJ2()

        Dim Joueur1 As New InfoJoueur(Profils.NameJ1(), 1)
        Dim Joueur2 As New InfoJoueur(Profils.NameJ2(), 2)

        Dim plateaucs As New Bibliotheque.Plateau

        Dim tanuj1 As New Tanuki(3, 2, 1)
        Dim koroj1 As New Koropokkuru(3, 1, 1)
        Dim kitsj1 As New Kitsune(3, 0, 1)
        Dim kodj1 As New Kodama(2, 1, 1)

        Dim tanuj2 As New Tanuki(0, 0, 2)
        Dim koroj2 As New Koropokkuru(0, 1, 2)
        Dim kitsj2 As New Kitsune(0, 2, 2)
        Dim kodj2 As New Kodama(1, 1, 2)

        plateaucs.Joueur1 = Joueur1
        plateaucs.Joueur1 = Joueur1
        plateaucs.initialisation(tanuj1, tanuj2, kitsj1, kitsj2, koroj1, koroj2, kodj1, kodj2)






    End Sub

End Class