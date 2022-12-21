Public Class SongDAO

    Public ReadOnly Property Songs As Collection

    Public Sub New()
        Me.Songs = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim s As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM SONGS ORDER BY IdSong")
        For Each aux In col
            s = New Song(Integer.Parse(aux(1)))
            s.sName = aux(2).ToString
            s.album.IdAlbum = Integer.Parse(aux(3))
            s.length = Integer.Parse(aux(4))
            Me.Songs.Add(s)
        Next
    End Sub

    Public Sub Read(ByRef s As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM SONGS WHERE IdSong =" & s.IdSong & ";")
        For Each aux In col
            s.sName = aux(2).ToString
            s.album.IdAlbum = Integer.Parse(aux(3))
            s.length = Integer.Parse(aux(4))
        Next
    End Sub

    Public Sub ObtainId(ByRef s As Song, name As String, id As Integer)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM SONGS WHERE sName = '" & name & "' AND Album = " & id & ";")
        For Each aux In col
            s.IdSong = Integer.Parse(aux(1))
            s.sName = aux(2).ToString
            s.length = Integer.Parse(aux(4))
        Next
    End Sub

    Public Sub ReadSpecial(id As Integer)
        Dim s As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM SONGS WHERE Album = " & id & ";")
        For Each aux In col
            s = New Song(Integer.Parse(aux(1)))
            s.sName = aux(2).ToString
            s.album.IdAlbum = Integer.Parse(aux(3))
            s.length = Integer.Parse(aux(4))
            Me.Songs.Add(s)
        Next
    End Sub

    Public Function Insert(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO SONGS VALUES (" & s.IdSong & " ,'" & s.sName & "', '" & s.album.IdAlbum & "', " & s.length & ");")
    End Function

    Public Function Update(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE SONGS SET sName = '" & s.sName & "', album = " & s.album.IdAlbum & ", length = " & s.length & " WHERE IdSong= " & s.IdSong & ";")
    End Function

    Public Function Delete(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM SONGS WHERE IdSong =" & s.IdSong & ";")
    End Function

    Public Function Getid(path As String)
        Dim col As Collection : Dim aux As Collection
        Dim counter As Integer

        col = DBBroker.GetBroker(path).Read("SELECT IdSong FROM SONGS ORDER BY IdSong")
        For Each aux In col
            counter += 1
            If counter <> Integer.Parse(aux(1)) Then
                Return counter
            End If
        Next
        Return counter + 1
    End Function

    Public Sub listSongPlaybacks(path As String, ByRef playbacks As Collection)
        Dim s As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT s.IdSong, s.sName, s.album, s.length, COUNT(*)
                                                FROM SONGS s, PLAYBACKS p
                                                    WHERE s.IdSong = p.song
                                                        GROUP BY s.IdSong, s.sName, s.album, s.length
                                                            ORDER BY COUNT(*) DESC;")
        For Each aux In col
            s = New Song(Integer.Parse(aux(1)))
            s.sName = aux(2).ToString
            s.album.IdAlbum = Integer.Parse(aux(3))
            s.length = Integer.Parse(aux(4))
            Me.Songs.Add(s)
            playbacks.Add(Integer.Parse(aux(5)))
        Next
    End Sub

End Class