<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ecran_match_nul
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ecran_match_nul))
        Me.bout_revanche = New System.Windows.Forms.Button()
        Me.bout_menu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bout_revanche
        '
        Me.bout_revanche.Location = New System.Drawing.Point(166, 94)
        Me.bout_revanche.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bout_revanche.Name = "bout_revanche"
        Me.bout_revanche.Size = New System.Drawing.Size(104, 37)
        Me.bout_revanche.TabIndex = 0
        Me.bout_revanche.Text = "Revanche"
        Me.bout_revanche.UseVisualStyleBackColor = True
        '
        'bout_menu
        '
        Me.bout_menu.Location = New System.Drawing.Point(166, 171)
        Me.bout_menu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bout_menu.Name = "bout_menu"
        Me.bout_menu.Size = New System.Drawing.Size(104, 37)
        Me.bout_menu.TabIndex = 2
        Me.bout_menu.Text = "Menu principal"
        Me.bout_menu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Un Yokaï a effectué 3 aller-retour !"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 266)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "La partie se termine en match nul !"
        '
        'Ecran_match_nul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(436, 327)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bout_menu)
        Me.Controls.Add(Me.bout_revanche)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Ecran_match_nul"
        Me.Text = "Ecran_match_nul"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bout_revanche As Button
    Friend WithEvents bout_menu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
