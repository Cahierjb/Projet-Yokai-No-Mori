Imports Bibliotheque

Public Class Plateau

    'D'abord, on instancie tous les objets issus du programme C# dont le programme va avoir besoin pour fonctionner
    'Champs
    Dim Joueur1 As InfoJoueur
    Dim Joueur2 As InfoJoueur

    Dim plateaucs As New Bibliotheque.Plateau

    Dim tabplateau(3, 2) As PictureBox
    Dim ReserveJ1(3) As PictureBox
    Dim ReserveJ2(3) As PictureBox

    Dim PieceX As Integer
    Dim PieceY As Integer

    Dim tourjoueur As Integer
    Dim action As Boolean
    Dim Piecepara As Pieces

    Dim tanuj1 As New Tanuki(3, 2, 1, "tanuki.jpg")
    Dim koroj1 As New Koropokkuru(3, 1, 1, "koro.jpg")
    Dim kitsj1 As New Kitsune(3, 0, 1, "kitsune.jpg")
    Dim kodj1 As New Kodama(2, 1, 1, "kodama.jpg")

    Dim tanuj2 As New Tanuki(0, 0, 2, "tanuki.jpg")
    Dim koroj2 As New Koropokkuru(0, 1, 2, "koro.jpg")
    Dim kitsj2 As New Kitsune(0, 2, 2, "kitsune.jpg")
    Dim kodj2 As New Kodama(1, 1, 2, "kodama.jpg")


    'Ici,on créés des accesseur au infoformations des Joueurs et au plateau afin de les utilisée dans les formulaires de fin de partie
    'Propriétées
    Public Property Joueur11 As InfoJoueur
        Get
            Return Joueur1
        End Get
        Set(value As InfoJoueur)
            Joueur1 = value
        End Set
    End Property

    Public Property Joueur22 As InfoJoueur
        Get
            Return Joueur2
        End Get
        Set(value As InfoJoueur)
            Joueur2 = value
        End Set
    End Property

    Public Property Plateaucs1 As Bibliotheque.Plateau
        Get
            Return plateaucs
        End Get
        Set(value As Bibliotheque.Plateau)
        End Set
    End Property



    'Methodes
    'cette methode permet de lié chaque picture box du design a un tableau de pictureBox equivalent au tableau de piece du programme C#
    'cela permet donc de faire le lien entre les objets et leur apparence physique sur le plateau
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
        ReserveJ1(0) = Resj1_1
        ReserveJ1(1) = Resj1_2
        ReserveJ1(2) = Resj1_3
        ReserveJ2(0) = Resj2_1
        ReserveJ2(1) = Resj2_2
        ReserveJ2(2) = Resj2_3
        MaJplateau()
    End Sub

    'La methode MaJplateau mets a jour l'affichage du plateau en fonctionne des differente action qui peuvent etre effectuer
    'c'est également cette methode qui verifie si les condition de fin de partie on etait obetenues
    Private Sub MaJplateau()
        Piecepara = Nothing
        'Si la partie n'est pas finis
        If (Plateaucs1.Findepartie = 0) Then
            'on initialise la couleur de fond de chaque picture box a "transparent"
            For Each element As PictureBox In tabplateau
                element.BackColor() = Color.Transparent
            Next element

            For i = 0 To 3
                For j = 0 To 2
                    'on verifie ensuite chaque case de notre tableau de piece pour remplir la picture box associé en consequence
                    ' si la case est vide alors on ne met aucune image dans la picture box correspondante
                    If Plateaucs1.Terrain(i, j) Is Nothing Then
                        tabplateau(i, j).Image() = Nothing
                    Else
                        'et si la case n'est pas vide,on recupere l'attribut image de la piece,on l'adapte a l'echelle du tableau et on la place dans la picture box
                        tabplateau(i, j).Load(Plateaucs1.Terrain(i, j).Image())
                        tabplateau(i, j).Image() = tabplateau(i, j).Image().GetThumbnailImage(90, 90, Nothing, IntPtr.Zero)
                        If (Plateaucs1.Terrain(i, j).NumJoueur = 2) Then
                            tabplateau(i, j).Image().RotateFlip(RotateFlipType.Rotate180FlipNone)
                        End If
                    End If
                Next j
            Next i
            'ici on applique le meme proceder que precedement mais appliqué au deux tableau de reserve
            For y = 0 To 2
                If (Plateaucs1.ReserveJ1(y) Is Nothing) Then
                    ReserveJ1(y).Image() = Nothing
                Else
                    ReserveJ1(y).Load(Plateaucs1.ReserveJ1(y).Image())
                    ReserveJ1(y).Image() = ReserveJ1(y).Image().GetThumbnailImage(80, 80, Nothing, IntPtr.Zero)
                End If
                If (Plateaucs1.ReserveJ2(y) Is Nothing) Then
                    ReserveJ2(y).Image() = Nothing
                Else
                    ReserveJ2(y).Load(Plateaucs1.ReserveJ2(y).Image())
                    ReserveJ2(y).Image() = ReserveJ2(y).Image().GetThumbnailImage(80, 80, Nothing, IntPtr.Zero)
                End If
            Next y

        End If
        'Si la partie est finis
        If (Plateaucs1.Findepartie > 0) Then
            'On nettoie le plateau des coloration due au mouvement des pieces
            For Each element As PictureBox In tabplateau
                element.BackColor() = Color.Transparent
            Next element
            'Puis on redirige le joueur vers le formulaire de fin de partie adéquat
            If Plateaucs1.Findepartie > 0 And Plateaucs1.Findepartie < 4 Then
                Ecran_victoire.Show()
            Else
                Ecran_match_nul.Show()
            End If
            Me.Close()
            Me.Hide()
        End If

    End Sub

    'Cette methode recupere le tableau "CaseAccessible" de la piece placer sur la picture box qui appelle la fonction 
    'et colorie les Cases sur les quels elle peut se deplacer en jaune 
    Private Sub DeplacementPossible()
        MaJplateau()
        Plateaucs1.Terrain(PieceX, PieceY).InitTableau()
        For i = 0 To 3
            For j = 0 To 2
                If Plateaucs1.Terrain(PieceX, PieceY).CaseAccessible(Plateaucs1)(i, j) = 1 Then
                    tabplateau(i, j).Image() = Nothing
                    tabplateau(i, j).BackColor() = Color.Yellow
                End If
            Next j
        Next i
    End Sub

    'Cette methode colorie en jaune toutes les cases libre du plateau qui sont apte a recevoir un parachutage
    Private Sub ParachutagePossible()
        MaJplateau()
        For i = 0 To 3
            For j = 0 To 2
                If Plateaucs1.Terrain(i, j) Is Nothing Then
                    tabplateau(i, j).BackColor() = Color.Yellow
                End If
            Next j
        Next i
    End Sub

    'Cette methode annoce le joueur qui commence et desactive les boutons de son adversaire pour le premiers tour
    Private Sub PremierJoueur()
        Plateaucs1.initJoueur(Joueur11, Joueur22)
        If Plateaucs1.Joueur1.Commence Then
            tourjoueur = 1
            tourj2.Enabled() = False
            abandj2.Enabled() = False
            MessageBox.Show(Joueur11.NomJoueur + " est le joueur qui commence !", "Premier Joueur :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If Plateaucs1.Joueur2.Commence Then
            tourjoueur = 2
            tourj1.Enabled() = False
            abandj1.Enabled() = False
            MessageBox.Show(Joueur22.NomJoueur + " est le joueur qui commence !", "Premier Joueur :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        action = True

    End Sub

    'Cette methode est appelé au chargtement du plateau, elle recupere les données des joueur fournis par le formulaire "Profils"
    'et initialise le terrain en placant chaque piece a sa position initiale
    Private Sub Plateau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelj1.Text = Profils.NameJ1()
        Labelj2.Text = Profils.NameJ2()

        Joueur11 = New InfoJoueur(Profils.NameJ1(), 1)
        Joueur22 = New InfoJoueur(Profils.NameJ2(), 2)
        Plateaucs1.Joueur1 = Joueur11
        Plateaucs1.Joueur2 = Joueur22
        Plateaucs1.initialisation(tanuj1, tanuj2, kitsj1, kitsj2, koroj1, koroj2, kodj1, kodj2)
        InitTabPlateau()
        PremierJoueur()
    End Sub

    'Cette methode evenement attend le clique sur les boutons tour suivant de chaque joueur.
    'lorsqu'un joueur clique la methode verifie qu'il a bien joué sont tour et desactive ses boutons 
    'pour activer ceux du joueur adverse
    Private Sub toursuivant(sender As Object, e As EventArgs) Handles tourj1.Click, tourj2.Click
        If (action = False) Then
            If (sender Is tourj1) Then
                MaJplateau()
                abandj1.Enabled() = False
                abandj2.Enabled() = True
                tourj1.Enabled() = False
                tourj2.Enabled() = True
                tourjoueur = 2
                action = True
            ElseIf (sender Is tourj2) Then
                MaJplateau()
                abandj2.Enabled() = False
                abandj1.Enabled() = True
                tourj2.Enabled() = False
                tourj1.Enabled() = True
                tourjoueur = 1
                action = True
            End If
        End If

    End Sub

    'Cette methode evenement attend le clique sur les boutons abandon de chaque joueurs. 
    'lorsqu'un joueur clique sur celui ci il fait automatiquement gagné sont adversaire
    Private Sub Abandon(sender As Object, e As EventArgs) Handles abandj1.Click, abandj2.Click
        If (sender Is abandj1) Then
            Plateaucs1.Findepartie() = 3
            Joueur22.Gagnant = True
        ElseIf (sender Is abandj2) Then
            Plateaucs1.Findepartie() = 3
            Joueur11.Gagnant = True
        End If
        MaJplateau()
    End Sub

    'Cette methode evenement gere un boutons aide qui explique au joueurs ce qu'il doivent faire pour jouer
    Private Sub Aide_Click(sender As Object, e As EventArgs) Handles Aide.Click
        MessageBox.Show("Cliquer sur l'une de vos pieces pour afficher les deplacements qu'elle peut effectuer, cliquer ensuite sur une une des cases coloriées pour deplacer votre piece !", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub

    'Cette region contient l'ensemble des methode evenement de chaque PictureBox du Plateau de jeu
    'Lorsqu'un joueur clique dessus on verifie l'action qu'il effectue :
    '-si la case est vide, il ne se passe rien
    '-si la case contient et affiche une piece,on recupere ses coordonnées et on appelle la methode deplacement possible
    '-si la case est coloré en jaune et qu'il s'agit d'un deplacement alors on deplace la piece qui a fait appelle a la methode "Deplacementpossible" dans cette case
    '-si la case est coloré en jaune et qu'il s'agit d'un parachutage alors on deplace la piece de la reserve qui a fait appelle a la methode "Parachutage" dans cette case
#Region "Clique Picture Box Plateau"
    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(0, 0, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(0, 0, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (action And tourjoueur = Plateaucs1.Terrain(0, 0).NumJoueur) Then
                PieceX = 0
                PieceY = 0
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(0, 1, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(0, 1, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(0, 1).NumJoueur And action) Then
                PieceX = 0
                PieceY = 1
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab3_Click(sender As Object, e As EventArgs) Handles tab3.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(0, 2, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(0, 2, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(0, 2).NumJoueur And action) Then
                PieceX = 0
                PieceY = 2
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab4_Click(sender As Object, e As EventArgs) Handles tab4.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(1, 0, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(1, 0, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(1, 0).NumJoueur And action) Then
                PieceX = 1
                PieceY = 0
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab5_Click(sender As Object, e As EventArgs) Handles tab5.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(1, 1, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(1, 1, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(1, 1).NumJoueur And action) Then
                PieceX = 1
                PieceY = 1
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab6_Click(sender As Object, e As EventArgs) Handles tab6.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(1, 2, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(1, 2, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(1, 2).NumJoueur And action) Then
                PieceX = 1
                PieceY = 2
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab7_Click(sender As Object, e As EventArgs) Handles tab7.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(2, 0, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(2, 0, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(2, 0).NumJoueur And action) Then
                PieceX = 2
                PieceY = 0
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab8_Click(sender As Object, e As EventArgs) Handles tab8.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(2, 1, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(2, 1, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(2, 1).NumJoueur And action) Then
                PieceX = 2
                PieceY = 1
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab9_Click(sender As Object, e As EventArgs) Handles tab9.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If tab9.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(2, 2, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(2, 2, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(2, 2).NumJoueur And action) Then
                PieceX = 2
                PieceY = 2
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab10_Click(sender As Object, e As EventArgs) Handles tab10.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(3, 0, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(3, 0, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (Not (Plateaucs1.Terrain(3, 0) Is Nothing) And tourjoueur = Plateaucs1.Terrain(3, 0).NumJoueur And action) Then
                PieceX = 3
                PieceY = 0
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab11_Click(sender As Object, e As EventArgs) Handles tab11.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(3, 1, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(3, 1, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(3, 1).NumJoueur And action) Then
                PieceX = 3
                PieceY = 1
                DeplacementPossible()
            End If
        End If
    End Sub

    Private Sub tab12_Click(sender As Object, e As EventArgs) Handles tab12.Click
        If Not sender.image() Is Nothing Or sender.BackColor() = Color.Yellow Then
            If sender.BackColor() = Color.Yellow Then
                If Not Piecepara Is Nothing And sender.Image() Is Nothing Then
                    Piecepara.Parachutage(3, 2, Plateaucs1)
                    Piecepara = Nothing
                    action = False
                ElseIf Piecepara Is Nothing Then
                    Plateaucs1.Terrain(PieceX, PieceY).Deplacement(3, 2, Plateaucs1)
                    action = False
                End If
                sender.BackColor() = Color.Transparent
                MaJplateau()
            ElseIf (tourjoueur = Plateaucs1.Terrain(3, 2).NumJoueur) Then
                PieceX = 3
                PieceY = 2
                DeplacementPossible()
            End If
        End If
    End Sub

#End Region

    'Cette region contient l'ensemble des methode evenement de chaque PictureBox des reserve
    'si la reserve contient la piece en question et que c'est le tour du joueur proprietaire de la reserve
    'alors on appelle la methode Parachutagepossible" pour cette piece
#Region "Clique Picture Box Reserve"
    Private Sub Resj1_1_Click(sender As Object, e As EventArgs) Handles Resj1_1.Click
        If Not Plateaucs1.ReserveJ1(0) Is Nothing And action And tourjoueur = 1 Then
            ParachutagePossible()
            Piecepara = Plateaucs1.ReserveJ1(0)
        End If
    End Sub
    Private Sub Resj1_2_Click(sender As Object, e As EventArgs) Handles Resj1_2.Click
        If Not Plateaucs1.ReserveJ1(1) Is Nothing And action And tourjoueur = 1 Then
            ParachutagePossible()
            Piecepara = Plateaucs1.ReserveJ1(1)
        End If
    End Sub
    Private Sub Resj1_3_Click(sender As Object, e As EventArgs) Handles Resj1_3.Click
        If Not Plateaucs1.ReserveJ1(2) Is Nothing And action And tourjoueur = 1 Then
            ParachutagePossible()
            Piecepara = Plateaucs1.ReserveJ1(2)
        End If
    End Sub
    Private Sub Resj2_1_Click(sender As Object, e As EventArgs) Handles Resj2_1.Click
        If Not Plateaucs1.ReserveJ2(0) Is Nothing And action And tourjoueur = 2 Then
            ParachutagePossible()
            Piecepara = Plateaucs1.ReserveJ2(0)
        End If
    End Sub
    Private Sub Resj2_2_Click(sender As Object, e As EventArgs) Handles Resj2_2.Click
        If Not Plateaucs1.ReserveJ2(1) Is Nothing And action And tourjoueur = 2 Then
            ParachutagePossible()
            Piecepara = Plateaucs1.ReserveJ2(1)
        End If
    End Sub
    Private Sub Resj2_3_Click(sender As Object, e As EventArgs) Handles Resj2_3.Click
        If Not Plateaucs1.ReserveJ2(2) Is Nothing And action And tourjoueur = 2 Then
            ParachutagePossible()
            Piecepara = Plateaucs1.ReserveJ2(2)
        End If
    End Sub

#End Region

End Class