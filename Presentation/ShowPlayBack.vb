Public Class ShowPlayBack

    Private pb As PlayBack

    Private s As Song
    Private Sub ShowPlayBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.pb = New PlayBack
        Dim pbAux As PlayBack

        Me.s = New Song
        Dim sAux As Song

        Try
            Me.pb.ReadAllPlayBacks(Main.fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each pbAux In Me.pb.pbDAO.PlayBacks

            If pbAux.pbUser.Email = Main.User Then

                sAux = New Song(pbAux.pbsong.IdSong)
                sAux.ReadSong()
                Me.Songs.Items.Add(sAux.sName)

                Me.Dates.Items.Add(pbAux.pbDate)

            End If
        Next
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