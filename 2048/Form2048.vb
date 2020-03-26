Public Class Form2048

    Public Sub Form2048_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' initialise la form
        Call initialiser()
        Call tireraleatoirement()
        Call tireraleatoirement()
        Call Affiche()
        btnRestart.Enabled = False
        btnUndo.Enabled = False
    End Sub
    Public Sub apresbouger()
        If jeugagner() = True And continugagne = False Then
            Dim result As Integer = MessageBox.Show("vous avez gagné avec le score : " & Score & ", voulez vous continuer ?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                continugagne = True
            Else
                If Score > Bestscore Then 'pour verifier si le score en cour est superieur a le score le plus haut
                    Bestscore = Score ' s'il satisfait la condition, on donne la valeur de la variable score a la variable bestscore
                End If
                Call initialiser()
                Call tireraleatoirement()
                Call tireraleatoirement()
                Call Affiche()
                btnRestart.Enabled = False
                btnUndo.Enabled = False
            End If
        End If
        If jeutermine() = False Then 'appeler le fonction jeutermine(), s'il retourne une valeur egale à false, c'est a dire le jeu termine.
            If MessageBox.Show("vous avez perdu, voulez vous recommencer ?", "caption", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Score > Bestscore Then
                    Bestscore = Score
                End If
                Call initialiser()
                Call tireraleatoirement()
                Call tireraleatoirement()
                Call Affiche()
                btnRestart.Enabled = False
                btnUndo.Enabled = False
            End If
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Up Or keyData = Keys.W Then
            Call deplacerhaut() 'Fais appelle à la fonction deplacerhaut()
            Call Affiche() 'Afficher les valeurs du tableau jeu aprés avoir deplacer vers le haut
            Call apresbouger()
            btnRestart.Enabled = True
            btnUndo.Enabled = True
            Return True
        End If
            'detect down arrow key
            If keyData = Keys.Down Or keyData = Keys.S Then
                Call deplacerbas()
                Call Affiche()
            Call apresbouger()
                btnRestart.Enabled = True
                btnUndo.Enabled = True
                Return True
            End If
            'detect left arrow key
            If keyData = Keys.Left Or keyData = Keys.A Then
                Call deplacergauche()
                Call Affiche()
            Call apresbouger()
                btnRestart.Enabled = True
                btnUndo.Enabled = True
                Return True
            End If
            'detect right arrow key
            If keyData = Keys.Right Or keyData = Keys.D Then
                Call deplacerdroit()
                Call Affiche()
            Call apresbouger()
                btnRestart.Enabled = True
                btnUndo.Enabled = True
                Return True
            End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub Affiche()
        ' affiche la variable Jeu dans lbl1, lbl2, ... lbl16
        ' affiche le score
        ' gère l'accessibilité des boutons
        Dim l As Byte, i As Byte, j As Byte
        For i = 1 To n
            For j = 1 To n
                l = (i - 1) * n + j
                If Jeu(i, j) = 0 Then
                    Controls("lbl" & l).Text = "" 'Pour que le 0 ne s'affiche pas 
                Else
                    Controls("lbl" & l).Text = Jeu(i, j) 'donner les valeurs de tableau jeu(i,j) aux labels
                End If
                Select Case Jeu(i, j)  'pour afficher des couleurs differents dans labels pour les numeros differents
                    Case 2 : Controls("lbl" & l).BackColor = Color.FromArgb(241, 229, 220)
                        Controls("lbl" & l).ForeColor = Color.Black
                    Case 4 : Controls("lbl" & l).BackColor = Color.FromArgb(237, 224, 200)
                        Controls("lbl" & l).ForeColor = Color.Black
                    Case 8 : Controls("lbl" & l).BackColor = Color.FromArgb(245, 177, 121)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 16 : Controls("lbl" & l).BackColor = Color.FromArgb(249, 149, 99)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 32 : Controls("lbl" & l).BackColor = Color.FromArgb(249, 123, 94)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 64 : Controls("lbl" & l).BackColor = Color.FromArgb(249, 93, 57)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 128 : Controls("lbl" & l).BackColor = Color.FromArgb(241, 208, 113)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 256 : Controls("lbl" & l).BackColor = Color.FromArgb(241, 205, 97)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 512 : Controls("lbl" & l).BackColor = Color.FromArgb(241, 201, 78)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 1024 : Controls("lbl" & l).BackColor = Color.FromArgb(241, 198, 61)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 2048 : Controls("lbl" & l).BackColor = Color.FromArgb(241, 195, 43)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 4096 : Controls("lbl" & l).BackColor = Color.FromArgb(255, 58, 57)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 8192 : Controls("lbl" & l).BackColor = Color.FromArgb(255, 28, 26)
                        Controls("lbl" & l).ForeColor = Color.White
                    Case 16384 : Controls("lbl" & l).BackColor = Color.FromArgb(255, 28, 26)
                        Controls("lbl" & l).ForeColor = Color.White
                End Select
            Next
        Next
        lblScore.Text = Score 'affiche le valeur de score dans label lblScore
        lblHighscore.Text = Bestscore 'affiche le valeur de bestscore dans label lblHighscore
    End Sub

    Public Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        ' gère le redémarage d'une partie

        If Score > Bestscore Then 'meme si le joueur ne veut plus jouer, on enregistre le score s'il est superieur a le bestscore
            Bestscore = Score
        End If
        Call initialiser()
        Call tireraleatoirement()
        Call tireraleatoirement()
        Call Affiche()
        btnRestart.Enabled = False
        btnUndo.Enabled = False
    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        ' gère l'annulation du coup qui vient dêtre joué (on ne peut annuler qu'un coup)
        Call retourner()
        Call Affiche()
        btnUndo.Enabled = False
    End Sub

    Public Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        ' gère le déplacement à gauche
            Call deplacergauche()
            Call Affiche()
            Call apresbouger()
            btnRestart.Enabled = True
            btnUndo.Enabled = True
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        ' gère le déplacement à droite
            Call deplacerdroit()
            Call Affiche()
            Call apresbouger()
            btnRestart.Enabled = True
            btnUndo.Enabled = True
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        ' gère le déplacement vers le haut
            Call deplacerhaut()
            Call Affiche()
            Call apresbouger()
            btnRestart.Enabled = True
            btnUndo.Enabled = True
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        ' gère le déplacement vers le bas
        Call deplacerbas()
        Call Affiche()
        Call apresbouger()
        btnRestart.Enabled = True
        btnUndo.Enabled = True
    End Sub

End Class
