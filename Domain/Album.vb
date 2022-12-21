
Public Class Album

    Public Property IdAlbum As Integer
    Public Property aName As String
    Public Property releaseDate As DateTime
    Public Property artist As Artist
    Public Property cover As String
    Public ReadOnly Property aDAO As AlbumDAO

    Public Sub New()
        Me.aDAO = New AlbumDAO
    End Sub

    Public Sub New(id As Integer)
        Me.aDAO = New AlbumDAO
        Me.artist = New Artist
        Me.IdAlbum = id
    End Sub

    Public Sub ReadAllAlbum(path As String)
        Me.aDAO.ReadAll(path)
    End Sub

    Public Sub ReadAlbum()
        Me.aDAO.Read(Me)
    End Sub

    Public Sub SpecialAlbumRead(id As Integer)
        Me.aDAO.ReadSpecial(id)
    End Sub

    Public Sub ObtainId(name As String, id As Integer)
        Me.aDAO.ObtainId(Me, name, id)
    End Sub

    Public Function InsertAlbum() As Integer
        Return Me.aDAO.Insert(Me)
    End Function

    Public Function UpdateAlbum() As Integer
        Return Me.aDAO.Update(Me)
    End Function

    Public Function DeleteAlbum() As Integer
        Return Me.aDAO.Delete(Me)
    End Function

    Public Function Getid(path As String)
        Return Me.aDAO.Getid(path)
    End Function

End Class
