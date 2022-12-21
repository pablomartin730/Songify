<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Favs
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BFav = New System.Windows.Forms.Button()
        Me.ArtistsBox = New System.Windows.Forms.ListBox()
        Me.FavArtistsBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnFav = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BFav
        '
        Me.BFav.BackColor = System.Drawing.Color.Tomato
        Me.BFav.Location = New System.Drawing.Point(498, 124)
        Me.BFav.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BFav.Name = "BFav"
        Me.BFav.Size = New System.Drawing.Size(115, 45)
        Me.BFav.TabIndex = 1
        Me.BFav.Text = "Fav"
        Me.BFav.UseVisualStyleBackColor = False
        '
        'ArtistsBox
        '
        Me.ArtistsBox.FormattingEnabled = True
        Me.ArtistsBox.ItemHeight = 16
        Me.ArtistsBox.Location = New System.Drawing.Point(56, 58)
        Me.ArtistsBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ArtistsBox.Name = "ArtistsBox"
        Me.ArtistsBox.Size = New System.Drawing.Size(139, 244)
        Me.ArtistsBox.TabIndex = 3
        '
        'FavArtistsBox
        '
        Me.FavArtistsBox.FormattingEnabled = True
        Me.FavArtistsBox.ItemHeight = 16
        Me.FavArtistsBox.Location = New System.Drawing.Point(248, 58)
        Me.FavArtistsBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FavArtistsBox.Name = "FavArtistsBox"
        Me.FavArtistsBox.Size = New System.Drawing.Size(143, 244)
        Me.FavArtistsBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Artists"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "FavArtists"
        '
        'UnFav
        '
        Me.UnFav.BackColor = System.Drawing.Color.Tomato
        Me.UnFav.Location = New System.Drawing.Point(498, 208)
        Me.UnFav.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UnFav.Name = "UnFav"
        Me.UnFav.Size = New System.Drawing.Size(115, 42)
        Me.UnFav.TabIndex = 7
        Me.UnFav.Text = "UnFav"
        Me.UnFav.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(640, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(595, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Favs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UnFav)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FavArtistsBox)
        Me.Controls.Add(Me.ArtistsBox)
        Me.Controls.Add(Me.BFav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Favs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BFav As Button
    Friend WithEvents ArtistsBox As ListBox
    Friend WithEvents FavArtistsBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UnFav As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
