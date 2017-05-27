﻿Imports Bibliotheque

Public Class Plateau
    Dim Joueur1 As InfoJoueur
    Dim Joueur2 As InfoJoueur
    Dim plateaucs As New Bibliotheque.Plateau
    Dim tabplateau(3, 2) As PictureBox
    Dim PieceX As Integer
    Dim PieceY As Integer
    Dim tourjoueur As Integer
    Dim action As Boolean
    Dim nbtours As Integer



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

    End Sub

    Private Sub MaJplateau()
        If (plateaucs.Findepartie() = 0) Then
            For i = 0 To 3
                For j = 0 To 2
                    If plateaucs.Terrain(i, j) Is Nothing Then
                        tabplateau(i, j).Image() = Nothing
                        tabplateau(i, j).BackColor() = Color.Transparent
                    Else
                        tabplateau(i, j).Load(plateaucs.Terrain(i, j).Image())
                    End If
                Next j
            Next i
        Else
            Me.Enabled = False
        End If

    End Sub

    Private Sub DeplacementPossible()
        If Not (plateaucs.Terrain(PieceX, PieceY) Is Nothing) Then
            MaJplateau()
            For i = 0 To 3
                For j = 0 To 2
                    If plateaucs.Terrain(PieceX, PieceY).CaseAccesible(plateaucs)(i, j) = 1 Then
                        tabplateau(i, j).BackColor() = Color.Yellow
                    End If
                Next j
            Next i
        End If
    End Sub

    Private Sub PremierJoueur()
        plateaucs.initJoueur(Joueur1, Joueur2)
        If plateaucs.Joueur1.Commence Then
            tourjoueur = 1
            tourj2.Enabled() = False
        End If
        If plateaucs.Joueur2.Commence Then
            tourjoueur = 2
            tourj1.Enabled() = False
        End If
        action = True
    End Sub


    Private Sub Plateau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelj1.Text = Profils.NameJ1()
        Labelj2.Text = Profils.NameJ2()

        Joueur1 = New InfoJoueur(Profils.NameJ1(), 1)
        Joueur2 = New InfoJoueur(Profils.NameJ2(), 2)
        plateaucs.Joueur1 = Joueur1
        plateaucs.Joueur2 = Joueur2
        plateaucs.initialisation(tanuj1, tanuj2, kitsj1, kitsj2, koroj1, koroj2, kodj1, kodj2)
        InitTabPlateau()
        PremierJoueur()
    End Sub

    Private Sub tourj1_Click(sender As Object, e As EventArgs) Handles tourj1.Click
        tourj1.Enabled() = False
        tourjoueur = 2
        action = True
        tourj2.Enabled() = True
        nbtours += 1
    End Sub

    Private Sub tourj2_Click(sender As Object, e As EventArgs) Handles tourj2.Click
        tourj2.Enabled() = False
        tourjoueur = 1
        action = True
        tourj1.Enabled() = True
    End Sub

#Region "Clique Picture Box"
    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click
        If tab1.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(0, 0, plateaucs)
            MaJplateau()
            action = False
            tab1.BackColor() = Color.Transparent
        Else
            If (tourjoueur = plateaucs.Terrain(0, 0).NumJoueur And action) Then
                PieceX = 0
                PieceY = 0
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click
        If tab2.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(0, 1, plateaucs)
            MaJplateau()
            action = False
            tab2.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(0, 1).NumJoueur And action) Then
            PieceX = 0
            PieceY = 1
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab3_Click(sender As Object, e As EventArgs) Handles tab3.Click
        If tab3.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(0, 2, plateaucs)
            MaJplateau()
            action = False
            tab3.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(0, 2).NumJoueur And action) Then
            PieceX = 0
            PieceY = 2
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab4_Click(sender As Object, e As EventArgs) Handles tab4.Click
        If tab4.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(1, 0, plateaucs)
            MaJplateau()
            action = False
            tab4.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(1, 0).NumJoueur And action) Then
            PieceX = 1
            PieceY = 0
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab5_Click(sender As Object, e As EventArgs) Handles tab5.Click
        If tab5.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(1, 1, plateaucs)
            MaJplateau()
            action = False
            tab5.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(1, 1).NumJoueur And action) Then
            PieceX = 1
            PieceY = 1
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab6_Click(sender As Object, e As EventArgs) Handles tab6.Click
        If tab6.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(1, 2, plateaucs)
            MaJplateau()
            action = False
            tab6.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(1, 2).NumJoueur And action) Then
            PieceX = 1
            PieceY = 2
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab7_Click(sender As Object, e As EventArgs) Handles tab7.Click
        If tab7.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(2, 0, plateaucs)
            MaJplateau()
            action = False
            tab7.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(2, 0).NumJoueur And action) Then
            PieceX = 2
            PieceY = 0
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab8_Click(sender As Object, e As EventArgs) Handles tab8.Click
        If tab8.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(2, 1, plateaucs)
            MaJplateau()
            action = False
            tab8.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(2, 1).NumJoueur And action) Then
            PieceX = 2
            PieceY = 1
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab9_Click(sender As Object, e As EventArgs) Handles tab9.Click
        If tab9.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(2, 2, plateaucs)
            MaJplateau()
            action = False
            tab9.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(2, 2).NumJoueur And action) Then
            PieceX = 2
            PieceY = 2
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab10_Click(sender As Object, e As EventArgs) Handles tab10.Click
        If tab10.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(3, 0, plateaucs)
            MaJplateau()
            action = False
            tab10.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(3, 0).NumJoueur And action) Then
            PieceX = 3
            PieceY = 0
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab11_Click(sender As Object, e As EventArgs) Handles tab11.Click
        If tab11.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(3, 1, plateaucs)
            MaJplateau()
            action = False
            tab11.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(3, 1).NumJoueur And action) Then
            PieceX = 3
            PieceY = 1
            DeplacementPossible()
        End If
    End Sub

    Private Sub tab12_Click(sender As Object, e As EventArgs) Handles tab12.Click
        If tab12.BackColor() = Color.Yellow Then
            plateaucs.Terrain(PieceX, PieceY).Deplacement(3, 2, plateaucs)
            MaJplateau()
            action = False
            tab12.BackColor() = Color.Transparent
        ElseIf (tourjoueur = plateaucs.Terrain(3, 2).NumJoueur And action) Then
            PieceX = 3
            PieceY = 2
            DeplacementPossible()
        End If
    End Sub

#End Region

End Class