Public Class Fav_Artist
    Public Property Fav_ArtistUser As User
    Public Property Fav_ArtistUserEmail As String
    Public Property Fav_ArtistArtist As Artist
    Public Property Fav_ArtistArtistID As Integer
    Public Property favDate As DateTime
    Public Property faDAO As Fav_ArtistDAO

    Public Sub New()
        Me.faDAO = New Fav_ArtistDAO
    End Sub

    Public Sub New(faUser As String, faArt As Integer)
        Me.faDAO = New Fav_ArtistDAO
        Me.Fav_ArtistUser = New User(faUser)
        Me.Fav_ArtistArtist = New Artist(faArt)
        Me.Fav_ArtistArtistID = faArt
        Me.Fav_ArtistUserEmail = faUser

    End Sub

    Public Sub ReadAllFav_Artists(path As String)
        Me.faDAO.ReadAll(path)
    End Sub

    Public Sub ReadFav_Artist()
        Me.faDAO.Read(Me)
    End Sub

    Public Function InsertFav_Artist() As Integer
        Return Me.faDAO.Insert(Me)
    End Function

    Public Function UpdateFav_Artist() As Integer
        Return Me.faDAO.Update(Me)
    End Function

    Public Function DeleteFav_Artist() As Integer
        Return Me.faDAO.Delete(Me)
    End Function
End Class
