Module Module2048

    Public n As Byte = 4 'représente le nombre de case sur une ligne et sur colone
    Public Jeu(n, n) As Short 'un tableau à deux dimensions 
    Public undo(n, n) As Short 'un tableau à deux dimensions pour conserver les valeurs précédente du jeu(n,n)
    Public undo1(n, n) As Short 'tableau intermédiaire pour avoir le tableau final undo
    Public jeu1(n, n) As Short 'pour vérifier si c'est la même valeur que undo
    Public Score As Short 'Variable pour conserver le score du jeu
    Public Bestscore As Short = 0
    Public undoscore As Short 'Conserver le score précédent
    Public undoscore1 As Short
    Public continugagne As Boolean 'une variable pour vérifier s'il a cliquer ou pas sur le bouton continuer

    Public Sub initialiser() 'Initialiser les tableaux 
        For i = 1 To n 'Boucle pour mettre toutes les valeurs du tableau a 0
            For j = 1 To n
                Jeu(i, j) = 0
                undo(i, j) = 0
            Next
        Next
        Score = 0
        undoscore = 0
        continugagne = False
    End Sub

    Public Function jeutermine() As Boolean
        Dim jcontinu As Boolean = False
        Dim peutfusionner As Boolean = False
        For i = 1 To n
            For m = 1 To n - 1
                If Jeu(i, m) <> 0 Then
                    peutfusionner = peutfusionner Or (Jeu(i, m) = Jeu(i, m + 1)) Or (Jeu(m, i) = Jeu(m + 1, i)) 'Boucle pour vérifier si c'est la meme valeurs ou pas autour d'un element dans ce tableau
                End If
            Next
            For j = 1 To n
                jcontinu = jcontinu Or (Jeu(i, j) = 0) Or peutfusionner ' s'il y a un element qui egal a 0 dans un table ou si le variable peutfusionner egal true, le variable jcontinu va etre ture
            Next
        Next
        Return jcontinu
    End Function

    Public Function jeugagner() As Boolean
        Dim jgagner As Boolean = False
        For i = 1 To n
            For j = 1 To n
                jgagner = jgagner Or (Jeu(i, j) = 2048) 'Boucle pour rechercher s'il y a un element dans ce tableau a la valeur 2048,si oui le variable jgagner va etre true
            Next
        Next
        Return jgagner
    End Function

    Public Sub tireraleatoirement()
        Dim lig As Byte, col As Byte, x As Byte
        Randomize() 'fonction pour tirer aléatoirement 
        Do
            lig = CByte(Int(n * Rnd() + 1))
            col = CByte(Int(n * Rnd() + 1))
        Loop Until Jeu(lig, col) = 0
        x = CByte(Int(2 * Rnd() + 1))
        Jeu(lig, col) = 2 ^ x
    End Sub

    Public Sub deplacergauche() 
        Dim peutdeplacer As Boolean = False
        Dim peutfusionner As Boolean = False
        For i = 1 To n
            For j = 1 To n
                undo1(i, j) = Jeu(i, j) 'Boucle pour donner tous les valeurs du jeu(i,j) au tableau undo1(i,j) 
                jeu1(i, j) = Jeu(i, j) 'Boucle pour donner tous les valeurs du jeu(i,j) au tableau jeu1(i,j) 
            Next
        Next
        undoscore1 = Score
        'Boucle pour effectuer un deplacement vers la gauche
        For i = 1 To n  'une bouble pour chaque ligne
            For j = 1 To n  'une bouble pour chaque colonne
                If jeu1(i, j) = 0 Then 'on commence a gauche, s'il y a un element dans cette ligne egale a 0
                    For k = j + 1 To n
                        If jeu1(i, k) <> 0 Then 'on verifie les elements suivant à cet element si il est superieur a 0 ou pas
                            jeu1(i, j) = jeu1(i, k) 'si oui, on change les valeurs pour les deux elements
                            jeu1(i, k) = 0
                            Exit For 'sauter le boucle
                        End If
                    Next
                End If
            Next
            For l = 1 To n 'une boucle pour verifier toutes les valeurs dans tableu jeu1 et tableau undo1
                peutdeplacer = peutdeplacer Or (jeu1(i, l) <> undo1(i, l)) 's'il y a une valeur diffrente dans les deux tableaux, le variable peutdeplacer va etre true
            Next
            For m = 1 To n - 1
                If jeu1(i, m) <> 0 Then 'pour chaque ligne,s'il y a un element egal 0, il peut deplacer.du coup, on vérifie juste pour les elements qui ont un valeur different a 0
                    peutfusionner = peutfusionner Or (jeu1(i, m) = jeu1(i, m + 1)) 'si la valeur autour de cet element est pareil, c'est a dire on peut fusionner, la varible peutfusionner va etre true
                End If
            Next
        Next

        If (peutfusionner = True Or peutdeplacer = True) Then
            For i = 1 To n
                For j = 1 To n  'Boucle pour effectuer un deplacement vers la gauche
                    If Jeu(i, j) = 0 Then
                        For k = j + 1 To n
                            If Jeu(i, k) <> 0 Then
                                Jeu(i, j) = Jeu(i, k)
                                Jeu(i, k) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            For a = 1 To n
                For b = 1 To n - 1 'Boucle pour faire la fusion
                    If Jeu(a, b) = Jeu(a, b + 1) Then
                        Jeu(a, b) = 2 * Jeu(a, b)
                        Score = Score + Jeu(a, b)
                        Jeu(a, b + 1) = 0
                    End If
                Next
                For c = 1 To n 'Boucle pour deplacer vers la gauche apres la fusion pour les même valeurs
                    If Jeu(a, c) = 0 Then
                        For k = c + 1 To n
                            If Jeu(a, k) <> 0 Then
                                Jeu(a, c) = Jeu(a, k)
                                Jeu(a, k) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            Call tireraleatoirement()
            For i = 1 To n
                For j = 1 To n
                    undo(i, j) = undo1(i, j) 'Boucle pour donner toutes les valeurs du undo1(i,j) au tableau undo(i,j),parce que undo(i,j) est le vrai tableau qu'on va afficher
                Next
            Next
            undoscore = undoscore1
        End If
    End Sub

    Public Sub deplacerdroit()
        Dim peutdeplacer As Boolean = False
        Dim peutfusionner As Boolean = False
        For i = 1 To n
            For j = 1 To n
                undo1(i, j) = Jeu(i, j)
                jeu1(i, j) = Jeu(i, j)
            Next
        Next
        undoscore1 = Score
        For i = 1 To n 'Boucle pour effectuer un deplacement vers la droite
            For j = n To 1 Step -1
                If jeu1(i, j) = 0 Then
                    For k = j - 1 To 1 Step -1
                        If jeu1(i, k) <> 0 Then
                            jeu1(i, j) = jeu1(i, k)
                            jeu1(i, k) = 0
                            Exit For
                        End If
                    Next
                End If
            Next
            For l = 1 To n
                peutdeplacer = peutdeplacer Or (jeu1(i, l) <> undo1(i, l))
            Next
            For m = 1 To n - 1
                If jeu1(i, m) <> 0 Then
                    peutfusionner = peutfusionner Or (jeu1(i, m) = jeu1(i, m + 1))
                End If
            Next
        Next
        If (peutfusionner = True Or peutdeplacer = True) Then
            For i = 1 To n
                For j = n To 1 Step -1
                    If Jeu(i, j) = 0 Then
                        For k = j - 1 To 1 Step -1
                            If Jeu(i, k) <> 0 Then
                                Jeu(i, j) = Jeu(i, k)
                                Jeu(i, k) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            For a = 1 To n 'Boucle pour faire la fusion
                For b = n To 2 Step -1
                    If Jeu(a, b) = Jeu(a, b - 1) Then
                        Jeu(a, b) = 2 * Jeu(a, b)
                        Score = Score + Jeu(a, b)
                        Jeu(a, b - 1) = 0
                    End If
                Next
                For c = n To 1 Step -1
                    If Jeu(a, c) = 0 Then
                        For k = c - 1 To 1 Step -1
                            If Jeu(a, k) <> 0 Then
                                Jeu(a, c) = Jeu(a, k)
                                Jeu(a, k) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            Call tireraleatoirement() 'Après avoir déplacer et fusioner on tire une valeur aléatoire
            For i = 1 To n
                For j = 1 To n
                    undo(i, j) = undo1(i, j) 'Boucle pour donner les valeurs du undo1(i,j) au tableau undo(i,j) avant d'effectuer un déplacement
                Next
            Next
            undoscore = undoscore1
        End If

    End Sub

    Public Sub deplacerhaut()
        Dim peutdeplacer As Boolean = False
        Dim peutfusionner As Boolean = False
        For i = 1 To n
            For j = 1 To n
                undo1(i, j) = Jeu(i, j)
                jeu1(i, j) = Jeu(i, j)
            Next
        Next
        undoscore1 = Score
        For i = 1 To n
            For j = 1 To n
                If jeu1(j, i) = 0 Then
                    For k = j + 1 To n
                        If jeu1(k, i) <> 0 Then
                            jeu1(j, i) = jeu1(k, i)
                            jeu1(k, i) = 0
                            Exit For
                        End If
                    Next
                End If
            Next
            For l = 1 To n
                peutdeplacer = peutdeplacer Or (jeu1(l, i) <> undo1(l, i))
            Next
            For m = 1 To n - 1
                If jeu1(m, i) <> 0 Then
                    peutfusionner = peutfusionner Or (jeu1(m, i) = jeu1(m + 1, i))
                End If
            Next
        Next
        If (peutfusionner = True Or peutdeplacer = True) Then
            For i = 1 To n
                For j = 1 To n
                    If Jeu(j, i) = 0 Then
                        For k = j + 1 To n
                            If Jeu(k, i) <> 0 Then
                                Jeu(j, i) = Jeu(k, i)
                                Jeu(k, i) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            For a = 1 To n
                For b = 1 To n - 1
                    If Jeu(b, a) = Jeu(b + 1, a) Then
                        Jeu(b, a) = 2 * Jeu(b, a)
                        Score = Score + Jeu(b, a)
                        Jeu(b + 1, a) = 0
                    End If
                Next
                For c = 1 To n
                    If Jeu(c, a) = 0 Then
                        For k = c + 1 To n
                            If Jeu(k, a) <> 0 Then
                                Jeu(c, a) = Jeu(k, a)
                                Jeu(k, a) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            Call tireraleatoirement()
            For i = 1 To n
                For j = 1 To n
                    undo(i, j) = undo1(i, j) 'Boucle pour donner les valeurs du undo1(i,j) au tableau undo(i,j) avant d'effectuer un déplacement
                Next
            Next
            undoscore = undoscore1
        End If
        
    End Sub

    Public Sub deplacerbas()
        Dim peutdeplacer As Boolean = False
        Dim peutfusionner As Boolean = False
        For i = 1 To n
            For j = 1 To n
                undo1(i, j) = Jeu(i, j)
                jeu1(i, j) = Jeu(i, j)
            Next
        Next
        undoscore1 = Score
        For i = 1 To n
            For j = n To 1 Step -1
                If jeu1(j, i) = 0 Then
                    For k = j - 1 To 1 Step -1
                        If jeu1(k, i) <> 0 Then
                            jeu1(j, i) = jeu1(k, i)
                            jeu1(k, i) = 0
                            Exit For
                        End If
                    Next
                End If
            Next
            For l = 1 To n
                peutdeplacer = peutdeplacer Or (jeu1(l, i) <> undo1(l, i))
            Next
            For m = 1 To n - 1
                If jeu1(m, i) <> 0 Then
                    peutfusionner = peutfusionner Or (jeu1(m, i) = jeu1(m + 1, i))
                End If
            Next
        Next
        If (peutfusionner = True Or peutdeplacer = True) Then
            For i = 1 To n
                For j = n To 1 Step -1
                    If Jeu(j, i) = 0 Then
                        For k = j - 1 To 1 Step -1
                            If Jeu(k, i) <> 0 Then
                                Jeu(j, i) = Jeu(k, i)
                                Jeu(k, i) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            For a = 1 To n
                For b = n To 2 Step -1
                    If Jeu(b, a) = Jeu(b - 1, a) Then
                        Jeu(b, a) = 2 * Jeu(b, a)
                        Score = Score + Jeu(b, a)
                        Jeu(b - 1, a) = 0
                    End If
                Next
                For c = n To 1 Step -1
                    If Jeu(c, a) = 0 Then
                        For k = c - 1 To 1 Step -1
                            If Jeu(k, a) <> 0 Then
                                Jeu(c, a) = Jeu(k, a)
                                Jeu(k, a) = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
            Call tireraleatoirement()
            For i = 1 To n
                For j = 1 To n
                    undo(i, j) = undo1(i, j) 'Boucle pour donner les valeurs du undo1(i,j) au tableau undo(i,j) avant d'effectuer un déplacement
                Next
            Next
            undoscore = undoscore1
        End If
    End Sub

    Public Sub retourner()
        For i = 1 To n 'Boucle pour mettre les valeurs du tableau undo() dans le tableau jeu()
            For j = 1 To n
                Jeu(i, j) = undo(i, j)
            Next
        Next
        Score = undoscore
    End Sub
End Module
