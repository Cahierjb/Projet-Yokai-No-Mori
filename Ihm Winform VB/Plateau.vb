Imports Bibliotheque

Public Class Plateau

    Dim plateaucs As New Bibliotheque.Plateau
    Dim tabplateau(3, 2) As PictureBox
    Dim listepiecej1 As New List(Of PictureBox)
    Dim listepiecej2 As New List(Of PictureBox)
    Dim pieceSelec As PictureBox
    Dim PieceX As Integer
    Dim PieceY As Integer


    Dim tanuj1 As New Tanuki(3, 2, 1, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")
    Dim koroj1 As New Koropokkuru(3, 1, 1, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")
    Dim kitsj1 As New Kitsune(3, 0, 1, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")
    Dim kodj1 As New Kodama(2, 1, 1, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")

    Dim tanuj2 As New Tanuki(0, 0, 2, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")
    Dim koroj2 As New Koropokkuru(0, 1, 2, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")
    Dim kitsj2 As New Kitsune(0, 2, 2, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")
    Dim kodj2 As New Kodama(1, 1, 2, "C:\Users\Jean-Baptiste\Pictures\ancien steam.PNG")

    Private Sub InitTabPlateau()
        tabplateau(0, 0) = tab1
        tabplateau(0, 1) = tab2
        tabplateau(0, 2) = tab3
        tabplateau(1, 0) = tab4
        tabplateau(1, 1) = tab5
        tabplateau(1, 2) = tab6
        tabplateau(2, 0) = tab7
        tabplateau(2, 1) = tab8
        tabplateau(2, 2) = tab9
        tabplateau(3, 0) = tab10
        tabplateau(3, 1) = tab11
        tabplateau(3, 2) = tab12

        MaJplateau()
        'tabplateau(0, 0).Load(tanuj1.Image())
        'tabplateau(0, 1).Load(koroj1.Image())
        'tabplateau(0, 2).Load(kitsj1.Image())
        'tabplateau(1, 1).Load(kodj1.Image())
        'tabplateau(2, 1).Load(tanuj2.Image())
        'tabplateau(3, 0).Load(koroj2.Image())
        'tabplateau(3, 1).Load(kitsj2.Image())
        'tabplateau(3, 2).Load(kodj2.Image())


    End Sub

    Private Sub MaJplateau()
        Dim i, j As Integer
        For i = 0 To 3
            For j = 0 To 2
                If plateaucs.Terrain(i, j) Is Nothing Then
                    tabplateau(i, j).Image = Nothing
                Else
                    tabplateau(i, j).Load(plateaucs.Terrain(i, j).Image())
                End If
            Next j
        Next i
    End Sub

    Private Sub ListePieceJoueurs()
        For Each element As Pieces In plateaucs.Terrain
            If element.NumJoueur = 1 Then
                listepiecej1.Add(tabplateau(element.PositionX, element.PositionY))
            ElseIf element.NumJoueur = 2 Then
                listepiecej2.Add(tabplateau(element.PositionX, element.PositionY))
            End If
        Next element
    End Sub

    Private Sub DeplacementPossible()
        For i = 0 To 3
            For j = 0 To 2
                If plateaucs.Terrain(PieceX, PieceY).CaseAccesible(plateaucs)(i, j) = 1 Then
                    tabplateau(i, j).Load("C:\Users\Jean-Baptiste\Desktop\transparent-drop-shadow-reflection-vector-illustration-35982858.jpg")
                    tabplateau(i, j).BackColor() = Color.Gold
                Else
                    tabplateau(i, j).Load("C:\Users\Jean-Baptiste\Desktop\transparent-drop-shadow-reflection-vector-illustration-35982858.jpg")
                End If
            Next j
        Next i
    End Sub
    Private Sub tourjoueur1()
        Dim action As Boolean
        'action = False
        'While action = False
        'For Each element As PictureBox In listepiecej1
        'If listepiecej1.Contains(PieceSelec) Then
        'DeplacementPossible()
        '            action = True
        'End If
        'Next element

        'End While
    End Sub
    Private Sub tourjoueur2()
    End Sub

    Private Sub Plateau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelj1.Text = Profils.NameJ1()
        Labelj2.Text = Profils.NameJ2()

        Dim nbtours As Integer
        Dim Joueur1 As New InfoJoueur(Profils.NameJ1(), 1)
        Dim Joueur2 As New InfoJoueur(Profils.NameJ2(), 2)


        plateaucs.Joueur1 = Joueur1
        plateaucs.Joueur2 = Joueur2
        plateaucs.initialisation(tanuj1, tanuj2, kitsj1, kitsj2, koroj1, koroj2, kodj1, kodj2)
        InitTabPlateau()
        tourjoueur1()




    End Sub

    Private Sub tourj1_Click(sender As Object, e As EventArgs) Handles tourj1.Click
        tourjoueur2()
    End Sub


    Private Sub tourj2_Click(sender As Object, e As EventArgs) Handles tourj2.Click
        tourjoueur1()
    End Sub

#Region "Clique Picture Box"
    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click
        pieceSelec = tab1
        PieceX = 0
        PieceY = 0
        DeplacementPossible()
    End Sub
    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click
        pieceSelec = tab2
        PieceX = 0
        PieceY = 1
        DeplacementPossible()
    End Sub
    Private Sub tab3_Click(sender As Object, e As EventArgs) Handles tab3.Click
        pieceSelec = tab3
        PieceX = 0
        PieceY = 2
    End Sub
    Private Sub tab4_Click(sender As Object, e As EventArgs) Handles tab4.Click
        pieceSelec = tab4
        PieceX = 1
        PieceY = 0
    End Sub
    Private Sub tab5_Click(sender As Object, e As EventArgs) Handles tab5.Click
        pieceSelec = tab5
        PieceX = 1
        PieceY = 1
    End Sub
    Private Sub tab6_Click(sender As Object, e As EventArgs) Handles tab6.Click
        pieceSelec = tab6
        PieceX = 1
        PieceY = 2
    End Sub
    Private Sub tab7_Click(sender As Object, e As EventArgs) Handles tab7.Click
        pieceSelec = tab7
        PieceX = 2
        PieceY = 0
    End Sub
    Private Sub tab8_Click(sender As Object, e As EventArgs) Handles tab8.Click
        pieceSelec = tab8
        PieceX = 2
        PieceY = 1
    End Sub
    Private Sub tab9_Click(sender As Object, e As EventArgs) Handles tab9.Click
        pieceSelec = tab9
        PieceX = 2
        PieceY = 2
    End Sub
    Private Sub tab10_Click(sender As Object, e As EventArgs) Handles tab10.Click
        pieceSelec = tab10
        PieceX = 3
        PieceY = 0
    End Sub
    Private Sub tab11_Click(sender As Object, e As EventArgs) Handles tab11.Click
        pieceSelec = tab11
        PieceX = 3
        PieceY = 1
    End Sub
    Private Sub tab12_Click(sender As Object, e As EventArgs) Handles tab12.Click
        pieceSelec = tab12
        PieceX = 3
        PieceY = 2
    End Sub

#End Region

End Class