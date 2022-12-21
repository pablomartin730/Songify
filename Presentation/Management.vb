Public Class Management

    Private s As Song
    Private a As Artist
    Private u As User
    Private al As Album
    Private opt As String

    Private Sub BLoadClick(sender As Object, e As EventArgs) Handles BLoad.Click

        Me.s = New Song
        Dim sAux As Song

        Me.a = New Artist
        Dim aAux As Artist

        Me.u = New User
        Dim uAux As User

        Me.al = New Album
        Dim alAux As Album

        BUpdate.Enabled = True
        BDelete.Enabled = True
        BInsert.Enabled = True

        opt = Me.optionBox.SelectedItem
        Select Case opt

            Case "Users"

                Try

                    Me.u.ReadAllUsers(Main.fileName)
                    Me.managementTable1.Items.Clear()
                    Me.ListBox1.Items.Clear()

                    For Each uAux In Me.u.uDAO.Users
                        Me.managementTable1.Items.Add(uAux.Email)
                    Next

                    labelManagement1.Visible = True
                    labelManagement2.Visible = True
                    labelManagement3.Visible = True
                    labelManagement4.Visible = True
                    labelManagement5.Visible = False

                    textAtManagement1.Visible = True
                    textAtManagement2.Visible = True
                    textAtManagement3.Visible = True
                    textAtManagement4.Visible = True
                    textAtManagement5.Visible = False

                    labelManagement1.Text = "Email :"
                    labelManagement2.Text = "Name :"
                    labelManagement3.Text = "Surname :"
                    labelManagement4.Text = "Birthday :"

                    If managementTable1.Items.Count <> 0 Then
                        managementTable1.SelectedIndex = 0
                        BView.Enabled = True
                    Else
                        BView.Enabled = False
                    End If

                    labelTable1.Visible = True
                    labelTable1.Text = "User e-mail"

                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    BView.Enabled = False
                    BDelete.Enabled = False
                    BInsert.Enabled = False
                    BUpdate.Enabled = False

                End Try

            Case "Songs"

                Try

                    Me.s.ReadAllSong(Main.fileName)
                    Me.managementTable1.Items.Clear()
                    Me.ListBox1.Items.Clear()

                    For Each sAux In Me.s.sDAO.Songs
                        Me.managementTable1.Items.Add(sAux.IdSong)
                        Me.ListBox1.Items.Add(sAux.sName)
                    Next

                    labelManagement1.Visible = False
                    labelManagement2.Visible = True
                    labelManagement3.Visible = True
                    labelManagement4.Visible = True
                    labelManagement5.Visible = False

                    textAtManagement1.Visible = False
                    textAtManagement2.Visible = True
                    textAtManagement3.Visible = True
                    textAtManagement4.Visible = True
                    textAtManagement5.Visible = False

                    labelManagement1.Text = "ID Song :"
                    labelManagement2.Text = "Name :"
                    labelManagement3.Text = "Album :"
                    labelManagement4.Text = "Length :"

                    If managementTable1.Items.Count <> 0 Then
                        managementTable1.SelectedIndex = 0
                        BView.Enabled = True
                    Else
                        BView.Enabled = False
                    End If

                    labelTable1.Visible = True
                    labelTable1.Text = "ID Song"

                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    BView.Enabled = False
                    BDelete.Enabled = False
                    BInsert.Enabled = False
                    BUpdate.Enabled = False

                End Try

            Case "Artists"

                Try

                    Me.a.ReadAllArtists(Main.fileName)
                    Me.managementTable1.Items.Clear()
                    Me.ListBox1.Items.Clear()

                    For Each aAux In Me.a.arDAO.Artists
                        Me.managementTable1.Items.Add(aAux.IdArtist)
                        Me.ListBox1.Items.Add(aAux.aName)
                    Next

                    labelManagement1.Visible = False
                    labelManagement2.Visible = True
                    labelManagement3.Visible = True
                    labelManagement4.Visible = True
                    labelManagement5.Visible = False

                    textAtManagement1.Visible = False
                    textAtManagement2.Visible = True
                    textAtManagement3.Visible = True
                    textAtManagement4.Visible = True
                    textAtManagement5.Visible = False

                    labelManagement1.Text = "ID Artist :"
                    labelManagement2.Text = "Name :"
                    labelManagement3.Text = "Country :"
                    labelManagement4.Text = "Image Path :"

                    If managementTable1.Items.Count <> 0 Then
                        managementTable1.SelectedIndex = 0
                        BView.Enabled = True
                    Else
                        BView.Enabled = False
                    End If

                    labelTable1.Visible = True
                    labelTable1.Text = "ID Artist"

                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    BView.Enabled = False
                    BDelete.Enabled = False
                    BInsert.Enabled = False
                    BUpdate.Enabled = False

                End Try

            Case "Albums"

                Try

                    Me.al.ReadAllAlbum(Main.fileName)
                    Me.managementTable1.Items.Clear()
                    Me.ListBox1.Items.Clear()

                    For Each alAux In Me.al.aDAO.Albums
                        Me.managementTable1.Items.Add(alAux.IdAlbum)
                        Me.ListBox1.Items.Add(alAux.aName)
                    Next

                    labelManagement1.Visible = False
                    labelManagement2.Visible = True
                    labelManagement3.Visible = True
                    labelManagement4.Visible = True
                    labelManagement5.Visible = True

                    textAtManagement1.Visible = False
                    textAtManagement2.Visible = True
                    textAtManagement3.Visible = True
                    textAtManagement4.Visible = True
                    textAtManagement5.Visible = True

                    labelManagement1.Text = "ID Album :"
                    labelManagement2.Text = "Name :"
                    labelManagement3.Text = "Release Date :"
                    labelManagement4.Text = "Artist :"
                    labelManagement5.Text = "Cover Path :"

                    If managementTable1.Items.Count <> 0 Then
                        managementTable1.SelectedIndex = 0
                        BView.Enabled = True
                    Else
                        BView.Enabled = False
                    End If

                    labelTable1.Visible = True
                    labelTable1.Text = "ID Album"

                Catch ex As Exception

                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    BView.Enabled = False
                    BDelete.Enabled = False
                    BInsert.Enabled = False
                    BUpdate.Enabled = False

                End Try

        End Select

    End Sub

    Private Sub BView_Click(sender As Object, e As EventArgs) Handles BView.Click

        Me.s = New Song
        Me.u = New User
        Me.a = New Artist
        Me.al = New Album

        Select Case opt

            Case "Users"

                Me.u = New User(managementTable1.SelectedItem)
                u.ReadUsers()
                textAtManagement1.Text = u.Email
                textAtManagement2.Text = u.name
                textAtManagement3.Text = u.surname
                textAtManagement4.Text = u.birthdate

            Case "Songs"

                Me.s = New Song(Integer.Parse(managementTable1.SelectedItem))
                s.ReadSong()
                textAtManagement1.Text = s.IdSong
                textAtManagement2.Text = s.sName
                textAtManagement3.Text = s.album.IdAlbum
                textAtManagement4.Text = s.length

            Case "Artists"

                Me.a = New Artist(Integer.Parse(managementTable1.SelectedItem))
                a.ReadArtists()
                textAtManagement1.Text = a.IdArtist
                textAtManagement2.Text = a.aName
                textAtManagement3.Text = a.country
                textAtManagement4.Text = a.image

            Case "Albums"

                Me.al = New Album(Integer.Parse(managementTable1.SelectedItem))
                al.ReadAlbum()
                textAtManagement1.Text = al.IdAlbum
                textAtManagement2.Text = al.aName
                textAtManagement3.Text = al.releaseDate
                textAtManagement4.Text = al.artist.IdArtist
                textAtManagement5.Text = al.cover

        End Select

    End Sub

    Private Sub BUpdate_Click(sender As Object, e As EventArgs) Handles BUpdate.Click

        Select Case opt

            Case "Users"

                Try

                    u = New User(textAtManagement1.Text)
                    u.name = textAtManagement2.Text
                    u.surname = textAtManagement3.Text
                    u.birthdate = Convert.ToDateTime(textAtManagement4.Text)

                    Try

                        If Me.u.UpdateUsers <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Songs"

                Try

                    s = New Song(Integer.Parse(textAtManagement1.Text))
                    s.sName = textAtManagement2.Text
                    s.album = New Album(Integer.Parse(textAtManagement3.Text))
                    s.length = Integer.Parse(textAtManagement4.Text)

                    Try

                        If Me.s.UpdateSong <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Artists"

                Try

                    a = New Artist(Integer.Parse(textAtManagement1.Text))
                    a.aName = textAtManagement2.Text
                    a.country = textAtManagement3.Text
                    a.image = textAtManagement4.Text

                    Try

                        If Me.a.UpdateArtists <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Albums"

                Try

                    al = New Album(Integer.Parse(textAtManagement1.Text))
                    al.aName = textAtManagement2.Text
                    al.releaseDate = Convert.ToDateTime(textAtManagement3.Text)
                    al.artist = New Artist(Integer.Parse(textAtManagement4.Text))
                    al.cover = textAtManagement5.Text

                    Try

                        If Me.al.UpdateAlbum <> 1 Then
                            MessageBox.Show("UPDATE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

        End Select

    End Sub

    Private Sub BInsert_Click(sender As Object, e As EventArgs) Handles BInsert.Click

        Select Case opt

            Case "Users"

                Try

                    If textAtManagement1.Text <> String.Empty And textAtManagement2.Text <> String.Empty And textAtManagement3.Text <> String.Empty And textAtManagement4.Text <> String.Empty Then

                        u = New User(textAtManagement1.Text)
                        u.name = textAtManagement2.Text
                        u.surname = textAtManagement3.Text
                        u.birthdate = Convert.ToDateTime(textAtManagement4.Text)

                        Try

                            If Me.u.InsertUsers <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If

                        Catch ex As Exception

                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub

                        End Try

                        Me.managementTable1.Items.Add(u.Email)
                        BView.Enabled = True
                        managementTable1.SelectedIndex = 0

                    Else

                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Songs"

                Try

                    If textAtManagement2.Text <> String.Empty And textAtManagement3.Text <> String.Empty And textAtManagement4.Text <> String.Empty Then

                        Dim i As Integer

                        s = New Song()
                        i = s.Getid(Main.fileName)
                        s = New Song(i)
                        s.sName = textAtManagement2.Text
                        s.album = New Album(Integer.Parse(textAtManagement3.Text))
                        s.length = Integer.Parse(textAtManagement4.Text)

                        Try

                            If Me.s.InsertSong <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If

                        Catch ex As Exception

                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub

                        End Try

                        Me.managementTable1.Items.Add(s.IdSong)
                        BView.Enabled = True
                        managementTable1.SelectedIndex = 0

                    Else

                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Artists"

                Try

                    If textAtManagement2.Text <> String.Empty And textAtManagement3.Text <> String.Empty And textAtManagement4.Text <> String.Empty Then

                        Dim i As Integer

                        a = New Artist()
                        i = a.Getid(Main.fileName)
                        a = New Artist(i)
                        a.aName = textAtManagement2.Text
                        a.country = textAtManagement3.Text
                        a.image = textAtManagement4.Text

                        Try

                            If Me.a.InsertArtists <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If

                        Catch ex As Exception

                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub

                        End Try

                        Me.managementTable1.Items.Add(a.IdArtist)
                        BView.Enabled = True
                        managementTable1.SelectedIndex = 0

                    Else

                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Albums"

                Try

                    If textAtManagement2.Text <> String.Empty And textAtManagement3.Text <> String.Empty And textAtManagement4.Text <> String.Empty And textAtManagement5.Text <> String.Empty Then

                        Dim i As Integer

                        al = New Album()
                        i = al.Getid(Main.fileName)
                        al = New Album(i)
                        al.aName = textAtManagement2.Text
                        al.releaseDate = Convert.ToDateTime(textAtManagement3.Text)
                        al.artist = New Artist(Integer.Parse(textAtManagement4.Text))
                        al.cover = textAtManagement5.Text

                        Try

                            If Me.al.InsertAlbum <> 1 Then
                                MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If

                        Catch ex As Exception

                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub

                        End Try

                        Me.managementTable1.Items.Add(al.IdAlbum)
                        BView.Enabled = True
                        managementTable1.SelectedIndex = 0

                    Else

                        MessageBox.Show("Id and/or Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

        End Select

    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click

        Select Case opt

            Case "Users"

                Try

                    u = New User(textAtManagement1.Text)
                    u.name = textAtManagement2.Text
                    u.surname = textAtManagement3.Text
                    u.birthdate = Convert.ToDateTime(textAtManagement4.Text)

                    Try

                        If Me.u.DeleteUsers <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub

                    End Try

                    Me.managementTable1.Items.Remove(u.Email)

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Songs"

                Try

                    s = New Song(Integer.Parse(textAtManagement1.Text))
                    s.sName = textAtManagement2.Text
                    s.album = New Album(Integer.Parse(textAtManagement3.Text))
                    s.length = Integer.Parse(textAtManagement4.Text)

                    Try

                        If Me.s.DeleteSong <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub

                    End Try

                    Me.managementTable1.Items.Remove(s.IdSong)

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Artists"

                Try

                    a = New Artist(Integer.Parse(textAtManagement1.Text))
                    a.aName = textAtManagement2.Text
                    a.country = textAtManagement3.Text
                    a.image = textAtManagement4.Text

                    Try

                        If Me.a.DeleteArtists <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub

                    End Try

                    Me.managementTable1.Items.Remove(a.IdArtist)

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            Case "Albums"

                Try

                    al = New Album(Integer.Parse(textAtManagement1.Text))
                    al.aName = textAtManagement2.Text
                    al.releaseDate = Convert.ToDateTime(textAtManagement3.Text)
                    al.artist = New Artist(Integer.Parse(textAtManagement4.Text))
                    al.cover = textAtManagement5.Text

                    Try

                        If Me.al.DeleteAlbum <> 1 Then
                            MessageBox.Show("DELETE <> -1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub

                    End Try

                    Me.managementTable1.Items.Remove(al.IdAlbum)

                Catch ex As Exception

                    MessageBox.Show("Wrong data type, please follow the naming criteria", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

        End Select

    End Sub

    'Como Hacer que la ventana se mueva arrastrando con el raton
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Hide()
        Main.BManagement.Enabled = True
        Main.BMyMuisc.Enabled = True
        Main.BFavourites.Enabled = True
        Main.BPlay.Enabled = True
        Main.BPlayBack.Enabled = True
        Main.BChangeUser.Enabled = True
        Main.BQuerys.Enabled = True
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles minButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class