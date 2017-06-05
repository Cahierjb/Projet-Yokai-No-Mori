<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ecran_victoire
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ecran_victoire))
        Me.nom_joueur = New System.Windows.Forms.Label()
        Me.type_victoire = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bout_revanche = New System.Windows.Forms.Button()
        Me.bout_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nom_joueur
        '
        Me.nom_joueur.AutoSize = True
        Me.nom_joueur.BackColor = System.Drawing.Color.Transparent
        Me.nom_joueur.Location = New System.Drawing.Point(132, 293)
        Me.nom_joueur.Name = "nom_joueur"
        Me.nom_joueur.Size = New System.Drawing.Size(83, 17)
        Me.nom_joueur.TabIndex = 0
        Me.nom_joueur.Text = "nom_joueur"
        '
        'type_victoire
        '
        Me.type_victoire.AutoSize = True
        Me.type_victoire.BackColor = System.Drawing.Color.Transparent
        Me.type_victoire.Location = New System.Drawing.Point(230, 293)
        Me.type_victoire.Name = "type_victoire"
        Me.type_victoire.Size = New System.Drawing.Size(88, 17)
        Me.type_victoire.TabIndex = 1
        Me.type_victoire.Text = "type_victoire"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Il remporte la partie !"
        '
        'bout_revanche
        '
        Me.bout_revanche.Location = New System.Drawing.Point(428, 154)
        Me.bout_revanche.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bout_revanche.Name = "bout_revanche"
        Me.bout_revanche.Size = New System.Drawing.Size(139, 46)
        Me.bout_revanche.TabIndex = 3
        Me.bout_revanche.Text = "Revanche"
        Me.bout_revanche.UseVisualStyleBackColor = True
        '
        'bout_menu
        '
        Me.bout_menu.Location = New System.Drawing.Point(37, 154)
        Me.bout_menu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bout_menu.Name = "bout_menu"
        Me.bout_menu.Size = New System.Drawing.Size(139, 46)
        Me.bout_menu.TabIndex = 5
        Me.bout_menu.Text = "Menu principal"
        Me.bout_menu.UseVisualStyleBackColor = True
        '
        'Ecran_victoire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(581, 402)
        Me.Controls.Add(Me.bout_menu)
        Me.Controls.Add(Me.bout_revanche)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.type_victoire)
        Me.Controls.Add(Me.nom_joueur)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Ecran_victoire"
        Me.Text = "Fin de la partie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nom_joueur As Label
    Friend WithEvents type_victoire As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bout_revanche As Button
    Friend WithEvents bout_menu As Button
End Class
