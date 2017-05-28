<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profils
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profils))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxj1 = New System.Windows.Forms.TextBox()
        Me.TextBoxj2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnConf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(19, 229)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom du joueur 1 :"
        '
        'TextBoxj1
        '
        Me.TextBoxj1.Location = New System.Drawing.Point(23, 265)
        Me.TextBoxj1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxj1.Name = "TextBoxj1"
        Me.TextBoxj1.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxj1.TabIndex = 2
        Me.TextBoxj1.Text = "Joueur 1"
        '
        'TextBoxj2
        '
        Me.TextBoxj2.Location = New System.Drawing.Point(343, 265)
        Me.TextBoxj2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxj2.Name = "TextBoxj2"
        Me.TextBoxj2.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxj2.TabIndex = 4
        Me.TextBoxj2.Text = "Joueur 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(355, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom du joueur 2 :"
        '
        'BtnConf
        '
        Me.BtnConf.Location = New System.Drawing.Point(186, 250)
        Me.BtnConf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnConf.Name = "BtnConf"
        Me.BtnConf.Size = New System.Drawing.Size(133, 37)
        Me.BtnConf.TabIndex = 5
        Me.BtnConf.Text = "Confirmer"
        Me.BtnConf.UseVisualStyleBackColor = True
        '
        'Profils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(512, 322)
        Me.Controls.Add(Me.BtnConf)
        Me.Controls.Add(Me.TextBoxj2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxj1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Profils"
        Me.Text = "Profils"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxj1 As TextBox
    Friend WithEvents TextBoxj2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnConf As Button
End Class
