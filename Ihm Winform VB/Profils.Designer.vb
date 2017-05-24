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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnConf = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(31, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom du joueur 1 :"
        '
        'TextBoxj1
        '
        Me.TextBoxj1.Location = New System.Drawing.Point(34, 239)
        Me.TextBoxj1.Name = "TextBoxj1"
        Me.TextBoxj1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxj1.TabIndex = 2
        Me.TextBoxj1.Text = "Joueur 1"
        '
        'TextBoxj2
        '
        Me.TextBoxj2.Location = New System.Drawing.Point(274, 239)
        Me.TextBoxj2.Name = "TextBoxj2"
        Me.TextBoxj2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxj2.TabIndex = 4
        Me.TextBoxj2.Text = "Joueur 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(283, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom du joueur 2 :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 300)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnConf
        '
        Me.BtnConf.Location = New System.Drawing.Point(158, 229)
        Me.BtnConf.Name = "BtnConf"
        Me.BtnConf.Size = New System.Drawing.Size(100, 30)
        Me.BtnConf.TabIndex = 5
        Me.BtnConf.Text = "Confirmer"
        Me.BtnConf.UseVisualStyleBackColor = True
        '
        'Profils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(511, 354)
        Me.Controls.Add(Me.BtnConf)
        Me.Controls.Add(Me.TextBoxj2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxj1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Profils"
        Me.Text = "Profils"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxj1 As TextBox
    Friend WithEvents TextBoxj2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnConf As Button
End Class
