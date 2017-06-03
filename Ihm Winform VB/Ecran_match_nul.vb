Public Class Ecran_match_nul
    Private Sub bout_revanche_Click(sender As Object, e As EventArgs) Handles bout_revanche.Click
        Me.Close()
        Profils.Show()
    End Sub

    Private Sub bout_menu_Click(sender As Object, e As EventArgs) Handles bout_menu.Click
        Me.Close()
        Ihm_Winform_VB.Menu_princ.Show()
    End Sub
End Class