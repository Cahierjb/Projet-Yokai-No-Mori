Public Class Ecran_victoire
    Private Sub Ecran_victoire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Ihm_Winform_VB.Plateau.Joueur11.Gagnant) Then
            nom_joueur.Text = Ihm_Winform_VB.Plateau.Joueur11.NomJoueur()
        ElseIf (Ihm_Winform_VB.Plateau.Joueur22.Gagnant) Then
            nom_joueur.Text = Ihm_Winform_VB.Plateau.Joueur22.NomJoueur()
        End If
        If (Ihm_Winform_VB.Plateau.Plateaucs1.Findepartie = 1) Then
            type_victoire.Text = "a attrapé le Koropokkuru adverse !"
        ElseIf (Ihm_Winform_VB.Plateau.Plateaucs1.Findepartie = 2) Then
            type_victoire.Text = "a emmené son Koropokkuru dans la zone adverse !"
        End If
    End Sub
    Private Sub bout_menu_Click(sender As Object, e As EventArgs) Handles bout_menu.Click
        Me.Close()
        Menu_princ.Show()
    End Sub

    Private Sub bout_revanche_Click(sender As Object, e As EventArgs) Handles bout_revanche.Click
        Me.Close()
        Plateau.Show()
    End Sub

    Private Sub bout_chang_joueur_Click(sender As Object, e As EventArgs) Handles bout_chang_joueur.Click
        Me.Close()
        Profils.Show()
    End Sub


End Class