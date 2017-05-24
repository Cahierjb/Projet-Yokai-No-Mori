<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plateau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plateau))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tourj1 = New System.Windows.Forms.Button()
        Me.Labelj1 = New System.Windows.Forms.Label()
        Me.abandj1 = New System.Windows.Forms.Button()
        Me.abandj2 = New System.Windows.Forms.Button()
        Me.labelj2 = New System.Windows.Forms.Label()
        Me.tourj2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tourj1
        '
        Me.tourj1.Location = New System.Drawing.Point(51, 500)
        Me.tourj1.Name = "tourj1"
        Me.tourj1.Size = New System.Drawing.Size(100, 30)
        Me.tourj1.TabIndex = 1
        Me.tourj1.Text = "Tour suivant"
        Me.tourj1.UseVisualStyleBackColor = True
        '
        'Labelj1
        '
        Me.Labelj1.AutoSize = True
        Me.Labelj1.BackColor = System.Drawing.Color.Transparent
        Me.Labelj1.Location = New System.Drawing.Point(80, 465)
        Me.Labelj1.Name = "Labelj1"
        Me.Labelj1.Size = New System.Drawing.Size(39, 13)
        Me.Labelj1.TabIndex = 2
        Me.Labelj1.Text = "Label1"
        '
        'abandj1
        '
        Me.abandj1.Location = New System.Drawing.Point(51, 536)
        Me.abandj1.Name = "abandj1"
        Me.abandj1.Size = New System.Drawing.Size(100, 30)
        Me.abandj1.TabIndex = 4
        Me.abandj1.Text = "Abandonner"
        Me.abandj1.UseVisualStyleBackColor = True
        '
        'abandj2
        '
        Me.abandj2.Location = New System.Drawing.Point(654, 128)
        Me.abandj2.Name = "abandj2"
        Me.abandj2.Size = New System.Drawing.Size(100, 30)
        Me.abandj2.TabIndex = 7
        Me.abandj2.Text = "Abandonner"
        Me.abandj2.UseVisualStyleBackColor = True
        '
        'labelj2
        '
        Me.labelj2.AutoSize = True
        Me.labelj2.BackColor = System.Drawing.Color.Transparent
        Me.labelj2.Location = New System.Drawing.Point(683, 57)
        Me.labelj2.Name = "labelj2"
        Me.labelj2.Size = New System.Drawing.Size(39, 13)
        Me.labelj2.TabIndex = 6
        Me.labelj2.Text = "Label1"
        '
        'tourj2
        '
        Me.tourj2.Location = New System.Drawing.Point(654, 92)
        Me.tourj2.Name = "tourj2"
        Me.tourj2.Size = New System.Drawing.Size(100, 30)
        Me.tourj2.TabIndex = 5
        Me.tourj2.Text = "Tour suivant"
        Me.tourj2.UseVisualStyleBackColor = True
        '
        'Plateau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(833, 616)
        Me.Controls.Add(Me.abandj2)
        Me.Controls.Add(Me.labelj2)
        Me.Controls.Add(Me.tourj2)
        Me.Controls.Add(Me.abandj1)
        Me.Controls.Add(Me.Labelj1)
        Me.Controls.Add(Me.tourj1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Plateau"
        Me.Text = "Plateau"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tourj1 As Button
    Friend WithEvents Labelj1 As Label
    Friend WithEvents abandj1 As Button
    Friend WithEvents abandj2 As Button
    Friend WithEvents labelj2 As Label
    Friend WithEvents tourj2 As Button
End Class
