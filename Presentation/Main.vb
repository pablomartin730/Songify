Public Class Main

    'Need to other windows

    Public fileName As String

    Public User As String

    Public u As User

    'Conection to the database
    Private Sub ofdPath_FileLoad(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdPath.FileOk
        Me.ofdPath.InitialDirectory = Application.StartupPath
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles BSelect.Click
        If Me.ofdPath.ShowDialog = DialogResult.OK Then
            BConnect.Enabled = True
            fileName = ofdPath.FileName
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles BConnect.Click
        BLogin.Enabled = True
        LoginText.Enabled = True
    End Sub

    'Login
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles BLogin.Click

        Dim check As Boolean = False

        If LoginText.Text <> String.Empty Then
            Me.u = New User
            Dim uAux As User
            Try
                Me.u.ReadAllUsers(ofdPath.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            For Each uAux In Me.u.uDAO.Users
                If uAux.Email = LoginText.Text Then

                    User = LoginText.Text

                    MessageBox.Show("Login successful")

                    BConnect.Enabled = False
                    BSelect.Enabled = False
                    BLogin.Enabled = False
                    LoginText.Enabled = False
                    BChangeUser.Enabled = True
                    BManagement.Enabled = True 'AQUI METEIS LAS NUEVAS WINDOWS
                    BMyMuisc.Enabled = True
                    BFavourites.Enabled = True
                    BPlay.Enabled = True
                    BPlayBack.Enabled = True
                    BQuerys.Enabled = True
                    check = True

                End If
            Next

            If check = False Then
                MessageBox.Show("The user is not in the DB")
            End If

        Else
            MessageBox.Show("Email is empty, please fill this space", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Change user

    Private Sub ChangeUser_Click(sender As Object, e As EventArgs) Handles BChangeUser.Click
        LoginText.Enabled = True
        LoginText.Clear()
        BLogin.Enabled = True
        BManagement.Enabled = False
        BMyMuisc.Enabled = False
        BFavourites.Enabled = False
        BPlay.Enabled = False
        BPlayBack.Enabled = False
        BQuerys.Enabled = False
    End Sub

    'Windows
    Private Sub btnManagement_Click(sender As Object, e As EventArgs) Handles BManagement.Click
        BManagement.Enabled = False
        BMyMuisc.Enabled = False
        BFavourites.Enabled = False
        BPlay.Enabled = False
        BPlayBack.Enabled = False
        BChangeUser.Enabled = False
        BQuerys.Enabled = False
        Dim f2 As New Management
        f2.Show()
    End Sub

    Private Sub BMyMuisc_Click(sender As Object, e As EventArgs) Handles BMyMuisc.Click
        BManagement.Enabled = False
        BMyMuisc.Enabled = False
        BFavourites.Enabled = False
        BPlay.Enabled = False
        BPlayBack.Enabled = False
        BChangeUser.Enabled = False
        BQuerys.Enabled = False
        Dim f3 As New MyMusic
        f3.Show()
    End Sub

    Private Sub BFavourites_Click(sender As Object, e As EventArgs) Handles BFavourites.Click
        BManagement.Enabled = False
        BMyMuisc.Enabled = False
        BFavourites.Enabled = False
        BPlay.Enabled = False
        BPlayBack.Enabled = False
        BChangeUser.Enabled = False
        BQuerys.Enabled = False
        Dim f4 As New Favs
        f4.Show()
    End Sub

    Private Sub BPlay_Click(sender As Object, e As EventArgs) Handles BPlay.Click
        BManagement.Enabled = False
        BMyMuisc.Enabled = False
        BFavourites.Enabled = False
        BPlay.Enabled = False
        BPlayBack.Enabled = False
        BChangeUser.Enabled = False
        BQuerys.Enabled = False
        Dim f5 As New PlayASong
        f5.Show()
    End Sub

    Private Sub BPlayBack_Click(sender As Object, e As EventArgs) Handles BPlayBack.Click
        BManagement.Enabled = False
        BMyMuisc.Enabled = False
        BFavourites.Enabled = False
        BPlay.Enabled = False
        BPlayBack.Enabled = False
        BChangeUser.Enabled = False
        BQuerys.Enabled = False
        Dim f6 As New ShowPlayBack
        f6.Show()
    End Sub


    Private Sub BQuerys_Click(sender As Object, e As EventArgs) Handles BQuerys.Click
        BManagement.Enabled = False
        BMyMuisc.Enabled = False
        BFavourites.Enabled = False
        BPlay.Enabled = False
        BPlayBack.Enabled = False
        BChangeUser.Enabled = False
        BPlayBack.Enabled = False
        BQuerys.Enabled = False
        Dim f7 As New ShowQuerys
        f7.Show()
    End Sub

    'Windows settings

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
        End
    End Sub


    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class