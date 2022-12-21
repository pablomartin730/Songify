Public Class Song
    Public Property IdSong As Integer
    Public Property sName As String
    Public Property album As Album
    Public Property length As Integer
    Public ReadOnly Property sDAO As SongDAO

    Public Sub New()
        Me.sDAO = New SongDAO
    End Sub

    Public Sub New(id As Integer)
        Me.sDAO = New SongDAO
        Me.album = New Album
        Me.IdSong = id
    End Sub

    Public Sub ReadAllSong(path As String)
        Me.sDAO.ReadAll(path)
    End Sub

    Public Sub ReadSong()
        Me.sDAO.Read(Me)
    End Sub

    Public Sub SpecialSongRead(id As Integer)
        Me.sDAO.ReadSpecial(id)
    End Sub

    Public Sub ObtainId(name As String, id As Integer)
        Me.sDAO.ObtainId(Me, name, id)
    End Sub

    Public Function InsertSong() As Integer
        Return Me.sDAO.Insert(Me)
    End Function

    Public Function UpdateSong() As Integer
        Return Me.sDAO.Update(Me)
    End Function

    Public Function DeleteSong() As Integer
        Return Me.sDAO.Delete(Me)
    End Function

    Public Function Getid(path As String)
        Return Me.sDAO.Getid(path)
    End Function

    Public Sub listSongPlaybacks(path As String, ByRef playbacks As Collection)
        Me.sDAO.listSongPlaybacks(path, playbacks)
    End Sub

End Class