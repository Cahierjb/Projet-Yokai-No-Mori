<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPartie = New System.Windows.Forms.Button()
        Me.BtnReg = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(16, 53)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 568)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BtnPartie
        '
        Me.BtnPartie.Location = New System.Drawing.Point(349, 301)
        Me.BtnPartie.Name = "BtnPartie"
        Me.BtnPartie.Size = New System.Drawing.Size(120, 40)
        Me.BtnPartie.TabIndex = 4
        Me.BtnPartie.Text = "Jouer une partie"
        Me.BtnPartie.UseVisualStyleBackColor = True
        '
        'BtnReg
        '
        Me.BtnReg.Location = New System.Drawing.Point(349, 360)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(120, 40)
        Me.BtnReg.TabIndex = 5
        Me.BtnReg.Text = "Règles du jeu"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.BtnPartie)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "Form1"
        Me.Text = "Yokai No Mori"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnPartie As Button
    Friend WithEvents BtnReg As Button
End Class
