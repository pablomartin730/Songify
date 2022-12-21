Public Class PlayBack
    Public Property IdPlay As Integer
    Public Property pbUser As User
    Public Property pbsong As Song
    Public Property pbDate As DateTime
    Public ReadOnly Property pbDAO As PlayBackDAO

    Public Sub New()
        Me.pbDAO = New PlayBackDAO
    End Sub

    Public Sub New(ID As Integer)
        Me.pbDAO = New PlayBackDAO
        Me.pbUser = New User
        Me.pbsong = New Song
        Me.IdPlay = ID
    End Sub

    Public Sub ReadAllPlayBacks(path As String)
        Me.pbDAO.ReadAll(path)
    End Sub

    Public Sub ReadPlayBacks()
        Me.pbDAO.Read(Me)
    End Sub

    Public Function InsertPlayBacks() As Integer
        Return Me.pbDAO.Insert(Me)
    End Function

    Public Function UpdatePlayBacks() As Integer
        Return Me.pbDAO.Update(Me)
    End Function

    Public Function DeletePlayBacks() As Integer
        Return Me.pbDAO.Delete(Me)
    End Function

    Public Function Getid(path As String)
        Return Me.pbDAO.Getid(path)
    End Function
End Class

