Public Class Artist
    Public Property IdArtist As Integer
    Public Property aName As String
    Public Property country As String

    Public Property image As String
    Public ReadOnly Property arDAO As ArtistDAO

    Public Sub New()
        Me.arDAO = New ArtistDAO
    End Sub

    Public Sub New(id As Integer)
        Me.arDAO = New ArtistDAO
        Me.IdArtist = id
    End Sub

    Public Sub ReadAllArtists(path As String)
        Me.arDAO.ReadAll(path)
    End Sub

    Public Sub ReadArtists()
        Me.arDAO.Read(Me)
    End Sub

    Public Sub ReadArtistByName()
        Me.arDAO.ReadByName(Me)
    End Sub

    Public Function InsertArtists() As Integer
        Return Me.arDAO.Insert(Me)
    End Function

    Public Function UpdateArtists() As Integer
        Return Me.arDAO.Update(Me)
    End Function

    Public Function DeleteArtists() As Integer
        Return Me.arDAO.Delete(Me)
    End Function

    Public Function Getid(path As String)
        Return Me.arDAO.Getid(path)
    End Function

    Public Sub listArtistPlaybacks(path As String, ByRef playbacks As Collection)
        Me.arDAO.listArtistPlaybacks(path, playbacks)
    End Sub

    Public Sub listArtistPlaybacksCountry(path As String, country As String, ByRef playbacks As Collection)
        Me.arDAO.listArtistPlaybacksCountry(path, country, playbacks)
    End Sub

    Public Sub arMostListenedByUserBetweenDates(path As String, initialDate As DateTime, finalDate As DateTime, email As String, ByRef playbacks As Collection)
        Me.arDAO.arMostListenedByUserBetweenDates(path, initialDate, finalDate, email, playbacks)
    End Sub

    Public Sub favArtistsPlaybackTime(path As String, email As String, ByRef playbacks As Collection)
        Me.arDAO.favArtistsPlaybackTime(path, email, playbacks)
    End Sub

End Class
