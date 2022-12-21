Public Class Fav_ArtistDAO
    Public ReadOnly Property Fav_Artists As Collection

    Public Sub New()
        Me.Fav_Artists = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim fa As Fav_Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM FAV_ARTISTS ORDER BY user , artist")
        For Each aux In col
            fa = New Fav_Artist(aux(1).ToString, aux(2).ToString)
            fa.favDate = Convert.ToDateTime(aux(3))
            Me.Fav_Artists.Add(fa)
        Next
    End Sub
    Public Sub Read(ByRef fa As Fav_Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM FAV_ARTISTS WHERE user = '" & fa.Fav_ArtistUser.Email & "' AND artist = " & fa.Fav_ArtistArtist.IdArtist & " ;")
        For Each aux In col
            fa.favDate = Convert.ToDateTime(aux(3))
        Next
    End Sub

    Public Function Insert(ByVal fa As Fav_Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO FAV_ARTISTS VALUES ('" & fa.Fav_ArtistUser.Email & "', " & fa.Fav_ArtistArtist.IdArtist & ",#" & fa.favDate & "#);")
    End Function

    Public Function Update(ByVal fa As Fav_Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE FAV_ARTISTS SET favDate=#" & fa.favDate & "# WHERE user ='" & fa.Fav_ArtistUser.Email & "' AND artist  = " & fa.Fav_ArtistArtist.IdArtist & ";")
    End Function

    Public Function Delete(ByVal fa As Fav_Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM FAV_ARTISTS WHERE user ='" & fa.Fav_ArtistUser.Email & "' AND artist = " & fa.Fav_ArtistArtist.IdArtist & ";")
    End Function
End Class
