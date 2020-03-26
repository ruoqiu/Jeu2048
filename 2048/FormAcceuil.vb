Public Class FormAcceuil

    Private Sub btnjouer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjouer.Click
        Form2048.Show() 'pour ouvrir l'interface du jeu
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Le but du jeu est de faire glisser des tuiles sur une grille afin d’arriver à" &
               "avoir une tuile portant le nombre 2048. " & vbCr &
               "Le déplacement des tuiles se fait vers la gauche, la droite, le haut ou le bas," &
               "en utilisant soit les boutons présent sur l’interface soit avec les flèches du clavier. " & vbCr &
               "L’ensemble des tuiles du plateau sont déplacés dans la même direction jusqu'à rencontrer les bords du plateau ou une autre tuile sur leur chemin." &
               "La combinaison des tuiles est faite lorsqu’on a les mêmes valeurs, elles fusionnent et créer ainsi une tuile de valeur double " &
               "(par ex. : deux tuiles de valeur « 2 » donnent une tuile de valeur « 4 »). À chaque mouvement, une tuile portant un 2 ou un 4 apparaît dans une case vide de manière aléatoire." &
               "Le joueur peut toutefois continuer à jouer après cet objectif atteint pour faire le meilleur score possible.")
    End Sub
End Class