Public Class ShowQuerys

    Private a As Artist
    Private al As Album
    Private s As Song
    Private p As PlayBack
    Private u As User
    Private f As Fav_Artist

    Private Sub ShowQuerys_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BArtistsNumberPlaybacks_Click(sender As Object, e As EventArgs) Handles BArtistsNumberPlaybacks.Click

        Try
            Me.lstQuerys.Items.Clear()
            Me.ListBox1.Items.Clear()

            Me.a = New Artist
            Dim aAux As Artist
            Dim num As Integer
            Dim playbacks As Collection
            playbacks = New Collection

            Try
                Me.a.listArtistPlaybacks(Main.fileName, playbacks)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            For Each aAux In Me.a.arDAO.Artists
                Me.lstQuerys.Items.Add(aAux.aName)
            Next

            For Each num In playbacks
                Me.ListBox1.Items.Add(num)
            Next

            Label4.Text = "Artists"
            Label5.Text = "Playbacks"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Me.lstQuerys.Items.Clear()
            Me.ListBox1.Items.Clear()

            Me.a = New Artist
            Dim aAux As Artist
            Dim num As Integer
            Dim playbacks As Collection
            playbacks = New Collection

            Try
                Me.a.listArtistPlaybacksCountry(Main.fileName, Me.TextBox1.Text, playbacks)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            For Each aAux In Me.a.arDAO.Artists
                Me.lstQuerys.Items.Add(aAux.aName)
            Next

            For Each num In playbacks
                Me.ListBox1.Items.Add(num)
            Next

            Label4.Text = "Artists"
            Label5.Text = "Playbacks"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub BSongsNumberPlaybacks_Click(sender As Object, e As EventArgs) Handles BSongsNumberPlaybacks.Click

        Try

            Me.lstQuerys.Items.Clear()
            Me.ListBox1.Items.Clear()

            Me.s = New Song
            Dim sAux As Song
            Dim num As Integer
            Dim playbacks As Collection
            playbacks = New Collection

            Try
                Me.s.listSongPlaybacks(Main.fileName, playbacks)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            For Each sAux In Me.s.sDAO.Songs
                Me.lstQuerys.Items.Add(sAux.sName)
            Next

            For Each num In playbacks
                Me.ListBox1.Items.Add(num)
            Next

            Label4.Text = "Songs"
            Label5.Text = "Playbacks"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub BArtistMostListened_Click(sender As Object, e As EventArgs) Handles BArtistMostListened.Click

        Try

            Me.lstQuerys.Items.Clear()
            Me.ListBox1.Items.Clear()

            Me.a = New Artist
            Dim aAux As Artist
            Dim num As Integer
            Dim playbacks As Collection
            playbacks = New Collection


            Try
                Me.a.arMostListenedByUserBetweenDates(Main.fileName, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value, Main.User, playbacks)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            For Each aAux In Me.a.arDAO.Artists
                Me.lstQuerys.Items.Add(aAux.aName)
            Next

            For Each num In playbacks
                Me.ListBox1.Items.Add(num)
            Next

            Label4.Text = "Artists"
            Label5.Text = "Playbacks"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub BTimeUsingApplication_Click(sender As Object, e As EventArgs) Handles BTimeUsingApplication.Click

        Try

            Me.lstQuerys.Items.Clear()
            Me.ListBox1.Items.Clear()

            Me.u = New User
            Dim uAux As User
            Dim num As Integer
            Dim playbacks As Collection
            playbacks = New Collection

            Try
                Me.u.uMoreTimeUsingApplication(Main.fileName, playbacks)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            For Each uAux In Me.u.uDAO.Users
                Me.lstQuerys.Items.Add(uAux.Email)
            Next

            Dim duration As TimeSpan = TimeSpan.Zero
            For Each num In playbacks
                For i As Integer = 1 To num
                    duration += TimeSpan.FromSeconds(1)
                Next
                Me.ListBox1.Items.Add(num)
            Next

            Label4.Text = "Users"
            Label5.Text = "Time"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub BPlaybacksFavArtist_Click(sender As Object, e As EventArgs) Handles BPlaybacksFavArtist.Click

        Try

            Me.lstQuerys.Items.Clear()
            Me.ListBox1.Items.Clear()

            Me.a = New Artist
            Dim aAux As Artist
            Dim num As Integer
            Dim playbacks As Collection
            playbacks = New Collection

            Try

                Me.a.favArtistsPlaybackTime(Main.fileName, Main.User, playbacks)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            For Each aAux In Me.a.arDAO.Artists
                Me.lstQuerys.Items.Add(aAux.aName)
            Next

            Dim duration As TimeSpan = TimeSpan.Zero
            For Each num In playbacks
                For i As Integer = 1 To num
                    duration += TimeSpan.FromSeconds(1)
                Next
                Me.ListBox1.Items.Add(num)
            Next

            Label4.Text = "Artists"
            Label5.Text = "Time"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

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
        Label4.Text = "-"
        Label5.Text = "-"
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class