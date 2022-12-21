Public Class AlbumDAO

    Public ReadOnly Property Albums As Collection

    Public Sub New()
        Me.Albums = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim a As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM ALBUMS ORDER BY IdAlbum")
        For Each aux In col
            a = New Album(Integer.Parse(aux(1)))
            a.aName = aux(2).ToString
            a.releaseDate = Convert.ToDateTime(aux(3))
            a.artist.IdArtist = Integer.Parse(aux(4))
            a.cover = aux(5).ToString
            Me.Albums.Add(a)
        Next
    End Sub

    Public Sub Read(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ALBUMS WHERE IdAlbum =" & a.IdAlbum & ";")
        For Each aux In col
            a.aName = aux(2).ToString
            a.releaseDate = Convert.ToDateTime(aux(3))
            a.artist.IdArtist = Integer.Parse(aux(4))
            a.cover = aux(5).ToString
        Next
    End Sub

    Public Sub ObtainId(ByRef a As Album, name As String, id As Integer)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ALBUMS WHERE aName = '" & name & "' AND artist = " & id & ";")
        For Each aux In col

            a.IdAlbum = Integer.Parse(aux(1))
            a.aName = aux(2).ToString
            a.releaseDate = Convert.ToDateTime(aux(3))
            a.cover = aux(5).ToString
        Next
    End Sub

    Public Sub ReadSpecial(id As Integer)
        Dim a As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ALBUMS WHERE artist = " & id & ";")
        For Each aux In col
            a = New Album(Integer.Parse(aux(1)))
            a.aName = aux(2).ToString
            a.releaseDate = Convert.ToDateTime(aux(3))
            a.artist.IdArtist = Integer.Parse(aux(4))
            a.cover = aux(5).ToString
            Me.Albums.Add(a)
        Next
    End Sub

    Public Function Insert(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO ALBUMS VALUES (" & a.IdAlbum & ", '" & a.aName & "', #" & a.releaseDate & "#, '" & a.artist.IdArtist & "', '" & a.cover & "');")
    End Function

    Public Function Update(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("UPDATE ALBUMS SET aName = '" & a.aName & "', releaseDate = #" & a.releaseDate & "#, artist = " & a.artist.IdArtist & ", cover = '" & a.cover & "' WHERE IdAlbum= " & a.IdAlbum & ";")
    End Function

    Public Function Delete(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM ALBUMS WHERE IdAlbum =" & a.IdAlbum & ";")
    End Function

    Public Function Getid(path As String)
        Dim col As Collection : Dim aux As Collection
        Dim counter As Integer

        col = DBBroker.GetBroker(path).Read("SELECT IdAlbum FROM ALBUMS ORDER BY IdAlbum")
        For Each aux In col
            counter += 1
            If counter <> Integer.Parse(aux(1)) Then
                Return counter
            End If
        Next
        Return counter + 1
    End Function

End Class
