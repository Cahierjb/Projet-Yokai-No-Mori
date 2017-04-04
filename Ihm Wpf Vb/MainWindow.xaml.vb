Imports Bibliotheque

Class MainWindow
    Private Sub btnOK_Click(sender As Object, e As RoutedEventArgs)
        Dim hw As New HelloWorld(tbPrenom.Text)

        lblMsg.Content = hw.Bonjour()
    End Sub
End Class
