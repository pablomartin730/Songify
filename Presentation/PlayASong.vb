Public Class PlayASong
    Private u As User
    Private s As Song
    Private pb As PlayBack
    Dim i As Integer
    Dim id As Integer
    Dim name1 As String
    Dim todaysdate As String
    Private Sub PlayASong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.s = New Song
        Dim sAux As Song

        Try
            Me.s.ReadAllSong(Main.fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each sAux In Me.s.sDAO.Songs
            Dim name As String
            Dim id As Integer
            Name = sAux.sName
            id = sAux.IdSong
            Me.lstSongsNameSongInfo.Items.Add(String.Format("{0} | {1}", id, Name))
        Next

    End Sub

    Private Sub lstSongsSongInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSongsNameSongInfo.SelectedIndexChanged
        lblPlayBackNameSongInfo.Text = lstSongsNameSongInfo.GetItemText(lstSongsNameSongInfo.SelectedItem)
    End Sub

    Private Sub BPlay_Click(sender As Object, e As EventArgs) Handles BPlay.Click

        Try

            Me.pb = New PlayBack
            i = pb.Getid(Main.fileName)
            pb = New PlayBack(i)
            todaysdate = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
            pb.pbDate = todaysdate
            id = Integer.Parse(lstSongsNameSongInfo.SelectedIndex + 1)
            s = New Song(id)
            pb.pbsong = s
            name = Main.User
            u = New User(name)
            pb.pbUser = u
            pb.InsertPlayBacks()

            Timer1.Start()

        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BPlay.Enabled = False
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 100 Then
            Timer1.Stop()
            MsgBox("Song finished ! ")
            ProgressBar2.Value = 0
            BPlay.Enabled = True
        End If

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

