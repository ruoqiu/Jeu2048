<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAcceuil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAcceuil))
        Me.btnjouer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnjouer
        '
        Me.btnjouer.BackColor = System.Drawing.Color.Bisque
        Me.btnjouer.Font = New System.Drawing.Font("HYTangLiF", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnjouer.Location = New System.Drawing.Point(643, 409)
        Me.btnjouer.Name = "btnjouer"
        Me.btnjouer.Size = New System.Drawing.Size(83, 36)
        Me.btnjouer.TabIndex = 0
        Me.btnjouer.Text = "Jouer"
        Me.btnjouer.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Bisque
        Me.Button1.Font = New System.Drawing.Font("HYTangLiF", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Button1.Location = New System.Drawing.Point(622, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Regle du jeu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormAcceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(949, 626)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnjouer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAcceuil"
        Me.Text = "Jeu du 2048"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnjouer As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
