Public Class Ecran_match_nul
    Private Sub bout_revanche_Click(sender As Object, e As EventArgs) Handles bout_revanche.Click
        Me.Close()
        Plateau.Show()
    End Sub

    Private Sub bout_chang_joueur_Click(sender As Object, e As EventArgs) Handles bout_chang_joueur.Click
        Me.Close()
        Profils.Show()
    End Sub
    Private Sub bout_menu_Click(sender As Object, e As EventArgs) Handles bout_menu.Click
        Me.Close()
        Menu_princ.Show()
    End Sub
End Class