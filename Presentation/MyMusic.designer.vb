<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyMusic
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblArtistFavArtistInfo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotallength = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSongLengthSongInfo = New System.Windows.Forms.Label()
        Me.lstArtistsArtistInfo = New System.Windows.Forms.ListBox()
        Me.lstAlbumsAlbumInfo = New System.Windows.Forms.ListBox()
        Me.lstSongsSongInfo = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAlbumIDArtistInfo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAlbumNameArtistInfo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAlbumReleaseDateArtistInfo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSongIDAlbumInfo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblSongNameAlbumInfo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblArtistIDArtistInfo = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblArtistNameArtistInfo = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblArtistCountryArtistInfo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblArtistId = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblAlbumId = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(1085, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(1130, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "My Music"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Artists"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Albums"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(935, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Songs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Favourite Artist: "
        '
        'lblArtistFavArtistInfo
        '
        Me.lblArtistFavArtistInfo.AutoSize = True
        Me.lblArtistFavArtistInfo.Location = New System.Drawing.Point(295, 262)
        Me.lblArtistFavArtistInfo.Name = "lblArtistFavArtistInfo"
        Me.lblArtistFavArtistInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblArtistFavArtistInfo.TabIndex = 10
        Me.lblArtistFavArtistInfo.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(621, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total length:"
        '
        'lblTotallength
        '
        Me.lblTotallength.AutoSize = True
        Me.lblTotallength.Location = New System.Drawing.Point(704, 259)
        Me.lblTotallength.Name = "lblTotallength"
        Me.lblTotallength.Size = New System.Drawing.Size(13, 17)
        Me.lblTotallength.TabIndex = 12
        Me.lblTotallength.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(935, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Length:"
        '
        'lblSongLengthSongInfo
        '
        Me.lblSongLengthSongInfo.AutoSize = True
        Me.lblSongLengthSongInfo.Location = New System.Drawing.Point(993, 470)
        Me.lblSongLengthSongInfo.Name = "lblSongLengthSongInfo"
        Me.lblSongLengthSongInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblSongLengthSongInfo.TabIndex = 14
        Me.lblSongLengthSongInfo.Text = "-"
        '
        'lstArtistsArtistInfo
        '
        Me.lstArtistsArtistInfo.FormattingEnabled = True
        Me.lstArtistsArtistInfo.IntegralHeight = False
        Me.lstArtistsArtistInfo.ItemHeight = 16
        Me.lstArtistsArtistInfo.Location = New System.Drawing.Point(15, 120)
        Me.lstArtistsArtistInfo.Name = "lstArtistsArtistInfo"
        Me.lstArtistsArtistInfo.Size = New System.Drawing.Size(167, 212)
        Me.lstArtistsArtistInfo.TabIndex = 15
        '
        'lstAlbumsAlbumInfo
        '
        Me.lstAlbumsAlbumInfo.FormattingEnabled = True
        Me.lstAlbumsAlbumInfo.ItemHeight = 16
        Me.lstAlbumsAlbumInfo.Location = New System.Drawing.Point(448, 120)
        Me.lstAlbumsAlbumInfo.Name = "lstAlbumsAlbumInfo"
        Me.lstAlbumsAlbumInfo.Size = New System.Drawing.Size(167, 212)
        Me.lstAlbumsAlbumInfo.TabIndex = 16
        '
        'lstSongsSongInfo
        '
        Me.lstSongsSongInfo.FormattingEnabled = True
        Me.lstSongsSongInfo.ItemHeight = 16
        Me.lstSongsSongInfo.Location = New System.Drawing.Point(938, 120)
        Me.lstSongsSongInfo.Name = "lstSongsSongInfo"
        Me.lstSongsSongInfo.Size = New System.Drawing.Size(162, 212)
        Me.lstSongsSongInfo.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(621, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Album Id: "
        '
        'lblAlbumIDArtistInfo
        '
        Me.lblAlbumIDArtistInfo.AutoSize = True
        Me.lblAlbumIDArtistInfo.Location = New System.Drawing.Point(685, 191)
        Me.lblAlbumIDArtistInfo.Name = "lblAlbumIDArtistInfo"
        Me.lblAlbumIDArtistInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblAlbumIDArtistInfo.TabIndex = 19
        Me.lblAlbumIDArtistInfo.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(621, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Album name:"
        '
        'lblAlbumNameArtistInfo
        '
        Me.lblAlbumNameArtistInfo.AutoSize = True
        Me.lblAlbumNameArtistInfo.Location = New System.Drawing.Point(704, 208)
        Me.lblAlbumNameArtistInfo.Name = "lblAlbumNameArtistInfo"
        Me.lblAlbumNameArtistInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblAlbumNameArtistInfo.TabIndex = 21
        Me.lblAlbumNameArtistInfo.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(621, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Release date:"
        '
        'lblAlbumReleaseDateArtistInfo
        '
        Me.lblAlbumReleaseDateArtistInfo.AutoSize = True
        Me.lblAlbumReleaseDateArtistInfo.Location = New System.Drawing.Point(717, 225)
        Me.lblAlbumReleaseDateArtistInfo.Name = "lblAlbumReleaseDateArtistInfo"
        Me.lblAlbumReleaseDateArtistInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblAlbumReleaseDateArtistInfo.TabIndex = 23
        Me.lblAlbumReleaseDateArtistInfo.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(935, 419)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Song Id: "
        '
        'lblSongIDAlbumInfo
        '
        Me.lblSongIDAlbumInfo.AutoSize = True
        Me.lblSongIDAlbumInfo.Location = New System.Drawing.Point(1005, 419)
        Me.lblSongIDAlbumInfo.Name = "lblSongIDAlbumInfo"
        Me.lblSongIDAlbumInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblSongIDAlbumInfo.TabIndex = 25
        Me.lblSongIDAlbumInfo.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(935, 436)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Song Name: "
        '
        'lblSongNameAlbumInfo
        '
        Me.lblSongNameAlbumInfo.AutoSize = True
        Me.lblSongNameAlbumInfo.Location = New System.Drawing.Point(1027, 436)
        Me.lblSongNameAlbumInfo.Name = "lblSongNameAlbumInfo"
        Me.lblSongNameAlbumInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblSongNameAlbumInfo.TabIndex = 27
        Me.lblSongNameAlbumInfo.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(188, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Artist Id: "
        '
        'lblArtistIDArtistInfo
        '
        Me.lblArtistIDArtistInfo.AutoSize = True
        Me.lblArtistIDArtistInfo.Location = New System.Drawing.Point(257, 208)
        Me.lblArtistIDArtistInfo.Name = "lblArtistIDArtistInfo"
        Me.lblArtistIDArtistInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblArtistIDArtistInfo.TabIndex = 29
        Me.lblArtistIDArtistInfo.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(188, 225)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Artist name: "
        '
        'lblArtistNameArtistInfo
        '
        Me.lblArtistNameArtistInfo.AutoSize = True
        Me.lblArtistNameArtistInfo.Location = New System.Drawing.Point(281, 225)
        Me.lblArtistNameArtistInfo.Name = "lblArtistNameArtistInfo"
        Me.lblArtistNameArtistInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblArtistNameArtistInfo.TabIndex = 31
        Me.lblArtistNameArtistInfo.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(188, 245)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 17)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Artist country: "
        '
        'lblArtistCountryArtistInfo
        '
        Me.lblArtistCountryArtistInfo.AutoSize = True
        Me.lblArtistCountryArtistInfo.Location = New System.Drawing.Point(281, 242)
        Me.lblArtistCountryArtistInfo.Name = "lblArtistCountryArtistInfo"
        Me.lblArtistCountryArtistInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblArtistCountryArtistInfo.TabIndex = 33
        Me.lblArtistCountryArtistInfo.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(621, 242)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Artist Id:"
        '
        'lblArtistId
        '
        Me.lblArtistId.AutoSize = True
        Me.lblArtistId.Location = New System.Drawing.Point(686, 242)
        Me.lblArtistId.Name = "lblArtistId"
        Me.lblArtistId.Size = New System.Drawing.Size(13, 17)
        Me.lblArtistId.TabIndex = 35
        Me.lblArtistId.Text = "-"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(935, 453)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 17)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Album id:"
        '
        'lblAlbumId
        '
        Me.lblAlbumId.AutoSize = True
        Me.lblAlbumId.Location = New System.Drawing.Point(1012, 453)
        Me.lblAlbumId.Name = "lblAlbumId"
        Me.lblAlbumId.Size = New System.Drawing.Size(13, 17)
        Me.lblAlbumId.TabIndex = 38
        Me.lblAlbumId.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ArtistBindingSource, "image", True))
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(15, 386)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(448, 386)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 154)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'ArtistBindingSource
        '
        Me.ArtistBindingSource.DataSource = GetType(Spotify.Artist)
        '
        'MyMusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1207, 572)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAlbumId)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblArtistId)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblArtistCountryArtistInfo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblArtistNameArtistInfo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblArtistIDArtistInfo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblSongNameAlbumInfo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblSongIDAlbumInfo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblAlbumReleaseDateArtistInfo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblAlbumNameArtistInfo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblAlbumIDArtistInfo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lstSongsSongInfo)
        Me.Controls.Add(Me.lstAlbumsAlbumInfo)
        Me.Controls.Add(Me.lstArtistsArtistInfo)
        Me.Controls.Add(Me.lblSongLengthSongInfo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotallength)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblArtistFavArtistInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MyMusic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyMusic"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblArtistFavArtistInfo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotallength As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSongLengthSongInfo As Label
    Friend WithEvents lstArtistsArtistInfo As ListBox
    Friend WithEvents lstAlbumsAlbumInfo As ListBox
    Friend WithEvents lstSongsSongInfo As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblAlbumIDArtistInfo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAlbumNameArtistInfo As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAlbumReleaseDateArtistInfo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblSongIDAlbumInfo As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblSongNameAlbumInfo As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblArtistIDArtistInfo As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblArtistNameArtistInfo As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblArtistCountryArtistInfo As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblArtistId As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblAlbumId As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ArtistBindingSource As BindingSource
End Class
