Public Class ArtistDAO
    Public ReadOnly Property Artists As Collection

    Public Sub New()
        Me.Artists = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim a As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM ARTISTS ORDER BY IdArtist")
        For Each aux In col
            a = New Artist(Integer.Parse(aux(1)))
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
            Me.Artists.Add(a)
        Next

    End Sub

    Public Sub Read(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ARTISTS WHERE IdArtist =" & a.IdArtist & ";")
        For Each aux In col
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
        Next
    End Sub

    Public Sub ReadByName(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ARTISTS WHERE aName ='" & a.aName & "';")
        For Each aux In col
            a.IdArtist = Integer.Parse(aux(1))
            a.country = aux(3).ToString
            a.image = aux(4).ToString
        Next
    End Sub

    Public Function Insert(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO ARTISTS VALUES (" & a.IdArtist & ", '" & a.aName & "', '" & a.country & "', '" & a.image & "');")
    End Function

    Public Function Update(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE ARTISTS SET aName= '" & a.aName & "' , country ='" & a.country & "' , image = '" & a.image & "' WHERE IdArtist=" & a.IdArtist & ";")
    End Function

    Public Function Delete(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM ARTISTS WHERE IdArtist =" & a.IdArtist & ";")
    End Function

    Public Function Getid(path As String)
        Dim col As Collection : Dim aux As Collection
        Dim counter As Integer
        col = DBBroker.GetBroker(path).Read("SELECT IdArtist FROM ARTISTS ORDER BY IdArtist")
        For Each aux In col
            counter += 1
            If counter <> Integer.Parse(aux(1)) Then
                Return counter
            End If
        Next
        Return counter + 1
    End Function

    Public Sub listArtistPlaybacks(path As String, ByRef playbacks As Collection)
        Dim a As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT a.IdArtist, a.aName, a.country, a.image, COUNT(*)
                                                FROM ARTISTS a, ALBUMS al, SONGS s, PLAYBACKS p
                                                    WHERE a.IdArtist = al.artist AND al.IdAlbum = s.Album AND s.IdSong = p.Song 
                                                        GROUP BY a.IdArtist, a.aName, a.country, a.image
                                                            ORDER BY COUNT(*) DESC;")
        For Each aux In col
            a = New Artist(Integer.Parse(aux(1)))
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
            Me.Artists.Add(a)
            playbacks.Add(Integer.Parse(aux(5)))
        Next

    End Sub

    Public Sub listArtistPlaybacksCountry(path As String, country As String, ByRef playbacks As Collection)
        Dim a As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT a.IdArtist, a.aName, a.country, a.image, COUNT(*)
                                                FROM ARTISTS a, ALBUMS al, SONGS s, PLAYBACKS p
                                                    WHERE a.IdArtist = al.artist AND al.IdAlbum = s.Album AND s.IdSong = p.Song AND a.country = '" & country & "'
                                                        GROUP BY a.IdArtist, a.aName, a.country, a.image
                                                            ORDER BY COUNT(*) DESC;")
        For Each aux In col
            a = New Artist(Integer.Parse(aux(1)))
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
            Me.Artists.Add(a)
            playbacks.Add(Integer.Parse(aux(5)))
        Next

    End Sub

    Public Sub arMostListenedByUserBetweenDates(path As String, initialDate As DateTime, finalDate As DateTime, email As String, ByRef playbacks As Collection)
        Dim a As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT a.IdArtist, a.aName, a.country, a.image, COUNT(*)
                                                FROM ARTISTS AS a, ALBUMS AS al, SONGS AS s, PLAYBACKS AS p, USERS AS u
                                                    WHERE a.IdArtist = al.artist AND al.IdAlbum = s.Album AND s.IdSong = p.song AND p.user = u.Email AND u.Email = '" & email & "' AND p.plDate BETWEEN #" & initialDate & "# AND #" & finalDate & "#
                                                        GROUP BY a.IdArtist, a.aName, a.country, a.image
                                                            ORDER BY COUNT(*) DESC;")
        For Each aux In col
            a = New Artist(Integer.Parse(aux(1)))
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
            Me.Artists.Add(a)
            playbacks.Add(Integer.Parse(aux(5)))
        Next

    End Sub

    Public Sub favArtistsPlaybackTime(path As String, email As String, ByRef playbacks As Collection)
        Dim a As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT a.IdArtist, a.aName, a.country, a.image, SUM(s.length)
                                                FROM ARTISTS a, FAV_ARTISTS fa, ALBUMS al, SONGS s, USERS u, PLAYBACKS p
                                                    WHERE fa.artist = a.IdArtist AND fa.user = u.Email AND a.IdArtist = al.artist AND al.IdAlbum = s.Album AND s.IdSong = p.song AND p.user = u.Email AND u.Email = '" & email & "'
                                                        GROUP BY   a.IdArtist, a.aName, a.country, a.image
                                                            ORDER BY SUM(s.length) DESC;")
        For Each aux In col
            a = New Artist(Integer.Parse(aux(1)))
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
            Me.Artists.Add(a)
            playbacks.Add(Integer.Parse(aux(5)))
        Next

    End Sub

End Class
