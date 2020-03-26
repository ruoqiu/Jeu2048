<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2048
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2048))
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHighscore = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Bisque
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btnLeft.Location = New System.Drawing.Point(503, 304)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(58, 30)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Bisque
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btnRight.Location = New System.Drawing.Point(652, 304)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(62, 30)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Bisque
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btnUp.Location = New System.Drawing.Point(579, 278)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(54, 30)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.Bisque
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btnDown.Location = New System.Drawing.Point(579, 325)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(54, 30)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(3, 43)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(177, 27)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "le score..."
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRestart
        '
        Me.btnRestart.BackgroundImage = CType(resources.GetObject("btnRestart.BackgroundImage"), System.Drawing.Image)
        Me.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestart.Location = New System.Drawing.Point(555, 3)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(78, 73)
        Me.btnRestart.TabIndex = 6
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUndo.Location = New System.Drawing.Point(657, 47)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(58, 30)
        Me.btnUndo.TabIndex = 7
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(52, 144)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(102, 42)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "2048"
        '
        'lbl2
        '
        Me.lbl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(161, 144)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(102, 42)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "2048"
        '
        'lbl3
        '
        Me.lbl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(272, 144)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(102, 42)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "2048"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(386, 144)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(102, 42)
        Me.lbl4.TabIndex = 11
        Me.lbl4.Text = "2048"
        '
        'lbl5
        '
        Me.lbl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(52, 253)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(102, 42)
        Me.lbl5.TabIndex = 12
        Me.lbl5.Text = "2048"
        '
        'lbl6
        '
        Me.lbl6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(161, 253)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(102, 42)
        Me.lbl6.TabIndex = 13
        Me.lbl6.Text = "2048"
        '
        'lbl7
        '
        Me.lbl7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(272, 253)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(102, 42)
        Me.lbl7.TabIndex = 14
        Me.lbl7.Text = "2048"
        '
        'lbl8
        '
        Me.lbl8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.Location = New System.Drawing.Point(386, 253)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(102, 42)
        Me.lbl8.TabIndex = 15
        Me.lbl8.Text = "2048"
        '
        'lbl9
        '
        Me.lbl9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.Location = New System.Drawing.Point(52, 366)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(102, 42)
        Me.lbl9.TabIndex = 16
        Me.lbl9.Text = "2048"
        '
        'lbl10
        '
        Me.lbl10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(161, 366)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(102, 42)
        Me.lbl10.TabIndex = 17
        Me.lbl10.Text = "2048"
        '
        'lbl11
        '
        Me.lbl11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl11.AutoSize = True
        Me.lbl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.Location = New System.Drawing.Point(272, 366)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(102, 42)
        Me.lbl11.TabIndex = 18
        Me.lbl11.Text = "2048"
        '
        'lbl12
        '
        Me.lbl12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl12.AutoSize = True
        Me.lbl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.Location = New System.Drawing.Point(386, 366)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(102, 42)
        Me.lbl12.TabIndex = 19
        Me.lbl12.Text = "2048"
        '
        'lbl13
        '
        Me.lbl13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl13.AutoSize = True
        Me.lbl13.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.Location = New System.Drawing.Point(52, 473)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(102, 42)
        Me.lbl13.TabIndex = 20
        Me.lbl13.Text = "2048"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1372, 572)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LineShape6.BorderWidth = 6
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 377
        Me.LineShape6.X2 = 373
        Me.LineShape6.Y1 = 94
        Me.LineShape6.Y2 = 539
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LineShape5.BorderWidth = 6
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 264
        Me.LineShape5.X2 = 260
        Me.LineShape5.Y1 = 94
        Me.LineShape5.Y2 = 534
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LineShape4.BorderWidth = 6
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 155
        Me.LineShape4.X2 = 151
        Me.LineShape4.Y1 = 93
        Me.LineShape4.Y2 = 536
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LineShape3.BorderWidth = 6
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 41
        Me.LineShape3.X2 = 487
        Me.LineShape3.Y1 = 437
        Me.LineShape3.Y2 = 437
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LineShape2.BorderWidth = 6
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 42
        Me.LineShape2.X2 = 488
        Me.LineShape2.Y1 = 319
        Me.LineShape2.Y2 = 319
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LineShape1.BorderWidth = 6
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 43
        Me.LineShape1.X2 = 489
        Me.LineShape1.Y1 = 206
        Me.LineShape1.Y2 = 206
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RectangleShape1.BorderWidth = 6
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(45, 96)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(441, 441)
        '
        'lbl14
        '
        Me.lbl14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl14.AutoSize = True
        Me.lbl14.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.Location = New System.Drawing.Point(161, 473)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(102, 42)
        Me.lbl14.TabIndex = 22
        Me.lbl14.Text = "2048"
        '
        'lbl15
        '
        Me.lbl15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl15.AutoSize = True
        Me.lbl15.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15.Location = New System.Drawing.Point(272, 473)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(102, 42)
        Me.lbl15.TabIndex = 23
        Me.lbl15.Text = "2048"
        '
        'lbl16
        '
        Me.lbl16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl16.AutoSize = True
        Me.lbl16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16.Location = New System.Drawing.Point(386, 473)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(102, 42)
        Me.lbl16.TabIndex = 24
        Me.lbl16.Text = "2048"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 31)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "BestScore"
        '
        'lblHighscore
        '
        Me.lblHighscore.AutoSize = True
        Me.lblHighscore.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblHighscore.ForeColor = System.Drawing.Color.White
        Me.lblHighscore.Location = New System.Drawing.Point(20, 43)
        Me.lblHighscore.Name = "lblHighscore"
        Me.lblHighscore.Size = New System.Drawing.Size(177, 27)
        Me.lblHighscore.TabIndex = 26
        Me.lblHighscore.Text = "+haut score"
        Me.lblHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(171, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 73)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblHighscore)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(334, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 73)
        Me.Panel2.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 64)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "2048"
        '
        'Form2048
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1372, 572)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form2048"
        Me.Text = "Jeu du 2048"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHighscore As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
