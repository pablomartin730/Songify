Public Class Favs
    Dim ID As Integer

    Private u As User
    Private ar As Artist
    Private fa As Fav_Artist

    Private Sub Favs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ar = New Artist
        Me.fa = New Fav_Artist
        Dim aAux As Artist
        Dim faAux As Fav_Artist

        Me.BFav.Enabled = False
        Me.UnFav.Enabled = False

        Try
            Me.ar.ReadAllArtists(Main.fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each aAux In Me.ar.arDAO.Artists
            Me.ArtistsBox.Items.Add(aAux.aName)
        Next

        Try
            Me.fa.ReadAllFav_Artists(Main.fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each faAux In Me.fa.faDAO.Fav_Artists
            If faAux.Fav_ArtistUserEmail = Main.User Then

                aAux = New Artist(faAux.Fav_ArtistArtistID)
                aAux.ReadArtists()
                Me.FavArtistsBox.Items.Add(aAux.aName)

            End If
        Next

    End Sub

    Private Sub ArtistsBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ArtistsBox.SelectedIndexChanged

        Me.BFav.Enabled = True
        Me.UnFav.Enabled = True

    End Sub

    Private Sub BFav_Click(sender As Object, e As EventArgs) Handles BFav.Click

        'ID = Integer.Parse(ArtistsBox.SelectedIndex + 1)

        Me.ar = New Artist()
        ar.aName = ArtistsBox.GetItemText(ArtistsBox.SelectedItem)
        ar.ReadArtistByName()
        ID = ar.IdArtist

        fa = New Fav_Artist(Main.User, ID)
        fa.favDate = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

        Try
            If Me.fa.InsertFav_Artist <> 1 Then
                MessageBox.Show("You haven't selected any artist", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Check if you have selected an artist or if you have already selected the artist as your favourite", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        Me.FavArtistsBox.Items.Add(ar.aName)


    End Sub

    Private Sub UnFav_Click(sender As Object, e As EventArgs) Handles UnFav.Click

        'ID = Integer.Parse(ArtistsBox.SelectedIndex + 1)

        Me.ar = New Artist()
        ar.aName = ArtistsBox.GetItemText(ArtistsBox.SelectedItem)
        ar.ReadArtistByName()
        ID = ar.IdArtist

        fa = New Fav_Artist(Main.User, ID)

        Try
            If Me.fa.DeleteFav_Artist <> 1 Then
                MessageBox.Show("Check if you have selected an artist or if the artist isn't one of your favourites", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        Me.FavArtistsBox.Items.Remove(ar.aName)

    End Sub

    'Windows settings

    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub frm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub frm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
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