Public Class MyMusic
    Private ar As Artist
    Private al As Album
    Private s As Song
    Private fa As Fav_Artist
    Dim album_id As Integer

    Private Sub MyMusic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ar = New Artist
        Dim aAux As Artist

        Try
            Me.ar.ReadAllArtists(Main.fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each aAux In Me.ar.arDAO.Artists
            Me.lstArtistsArtistInfo.Items.Add(aAux.aName)
        Next

    End Sub

    Private Sub lstArtistsArtistInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtistsArtistInfo.SelectedIndexChanged

        Me.lstAlbumsAlbumInfo.Items.Clear()
        Me.lstSongsSongInfo.Items.Clear()
        Me.lblAlbumNameArtistInfo.Text = "-"
        Me.lblAlbumIDArtistInfo.Text = "-"
        Me.lblAlbumReleaseDateArtistInfo.Text = "-"
        Me.lblArtistId.Text = "-"
        Me.lblTotallength.Text = "-"
        Me.lblSongIDAlbumInfo.Text = "-"
        Me.lblSongNameAlbumInfo.Text = "-"
        Me.lblSongLengthSongInfo.Text = "-"
        Me.lblAlbumId.Text = "-"
        Me.PictureBox2.Visible = False

        Me.al = New Album
        Me.fa = New Fav_Artist
        Dim alAux As Album
        Dim faAux As Fav_Artist

        Try

            Me.ar = New Artist()
            Me.ar.aName = lstArtistsArtistInfo.GetItemText(lstArtistsArtistInfo.SelectedItem)
            Me.ar.ReadArtistByName()
            lblArtistIDArtistInfo.Text = ar.IdArtist
            lblArtistNameArtistInfo.Text = ar.aName
            lblArtistCountryArtistInfo.Text = ar.country

        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        Try
            Me.fa.ReadAllFav_Artists(Main.fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        lblArtistFavArtistInfo.Text = "No"
        For Each faAux In Me.fa.faDAO.Fav_Artists
            If faAux.Fav_ArtistUser.Email = Main.User And faAux.Fav_ArtistArtist.IdArtist = Me.ar.IdArtist Then
                lblArtistFavArtistInfo.Text = "Yes"
            End If
        Next

        'Try

        'Me.PictureBox1.Image = Image.FromFile(ar.image)
        'Me.PictureBox1.Visible = True

        'Catch ex As Exception

        'Try

        'Me.PictureBox1.Image = Image.FromFile("C:\Users\oscar\OneDrive\Escritorio\BBDD\Practicas\Spotify\Resources\ImageNotFound.jpg")
        'Me.PictureBox1.Visible = True

        'Catch ex1 As Exception

        'MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End Try

        'End Try

        Try
            Me.al.SpecialAlbumRead(ar.IdArtist)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each alAux In Me.al.aDAO.Albums
            Me.lstAlbumsAlbumInfo.Items.Add(alAux.aName)
        Next

    End Sub

    Private Sub lstAlbumsAlbumInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumsAlbumInfo.SelectedIndexChanged

        Me.lstSongsSongInfo.Items.Clear()
        Me.lblSongIDAlbumInfo.Text = "-"
        Me.lblSongNameAlbumInfo.Text = "-"
        Me.lblSongLengthSongInfo.Text = "-"
        Me.lblAlbumId.Text = "-"

        Me.s = New Song
        Dim aux As Song
        Dim totaLength As Integer

        Try

            Me.al = New Album()
            al.aName = lstAlbumsAlbumInfo.GetItemText(lstAlbumsAlbumInfo.SelectedItem)
            lblAlbumNameArtistInfo.Text = lstAlbumsAlbumInfo.GetItemText(lstAlbumsAlbumInfo.SelectedItem)
            al.ObtainId(lstAlbumsAlbumInfo.GetItemText(lstAlbumsAlbumInfo.SelectedItem), Me.ar.IdArtist)
            lblAlbumIDArtistInfo.Text = al.IdAlbum
            lblAlbumReleaseDateArtistInfo.Text = al.releaseDate.ToString("dd/MM/yyyy")
            lblArtistId.Text = Me.ar.IdArtist

        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        'Try

        'Me.PictureBox2.Image = Image.FromFile(al.cover)
        'Me.PictureBox2.Visible = True

        'Catch ex As Exception

        'Try
        'Me.PictureBox2.Image = Image.FromFile("C:\Users\oscar\OneDrive\Escritorio\BBDD\Practicas\Spotify\Resources\ImageNotFound.jpg")
        'Me.PictureBox2.Visible = True

        'Catch ex1 As Exception

        'MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End Try

        'End Try

        Try
            Me.s.SpecialSongRead(al.IdAlbum)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each aux In Me.s.sDAO.Songs
            Me.lstSongsSongInfo.Items.Add(aux.sName)
            totaLength += aux.length
        Next

        Dim betterDuration As TimeSpan = TimeSpan.Zero
        For i As Integer = 1 To totaLength
            betterDuration += TimeSpan.FromSeconds(1)
        Next
        lblTotallength.Text = betterDuration.ToString
    End Sub

    Private Sub lstSongsSongInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSongsSongInfo.SelectedIndexChanged

        Try

            Me.s = New Song()
            s.sName = lstSongsSongInfo.GetItemText(lstSongsSongInfo.SelectedItem)
            s.ObtainId(lstSongsSongInfo.GetItemText(lstSongsSongInfo.SelectedItem), al.IdAlbum)
            lblSongIDAlbumInfo.Text = s.IdSong
            lblSongNameAlbumInfo.Text = lstSongsSongInfo.GetItemText(lstSongsSongInfo.SelectedItem)
            Dim betterDuration As TimeSpan = TimeSpan.Zero
            For i As Integer = 1 To s.length
                betterDuration += TimeSpan.FromSeconds(1)
            Next

            lblSongLengthSongInfo.Text = betterDuration.ToString
            lblAlbumId.Text = al.IdAlbum

        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub frm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub frm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.BManagement.Enabled = True
        Main.BMyMuisc.Enabled = True
        Main.BFavourites.Enabled = True
        Main.BPlay.Enabled = True
        Main.BPlayBack.Enabled = True
        Main.BChangeUser.Enabled = True
        Main.BQuerys.Enabled = True

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class