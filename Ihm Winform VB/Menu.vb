Imports Bibliotheque

Public Class Menu_princ

    Dim rep

    Private Sub BtnPartie_Click(sender As Object, e As EventArgs) Handles BtnPartie.Click
        Profils.Show()
    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        Regles.Show()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        rep = MessageBox.Show("Voulez-vous vraiment quitter?", "Quitter", MessageBoxButtons.YesNo)
        If (rep = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
