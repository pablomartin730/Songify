Public Class User
    Public Property Email As String
    Public Property name As String
    Public Property surname As String
    Public Property birthdate As DateTime
    Public ReadOnly Property uDAO As UserDAO

    Public Sub New()
        Me.uDAO = New UserDAO
    End Sub

    Public Sub New(E As String)
        Me.uDAO = New UserDAO
        Me.Email = E
    End Sub

    Public Sub ReadAllUsers(path As String)
        Me.uDAO.ReadAll(path)
    End Sub

    Public Sub ReadUsers()
        Me.uDAO.Read(Me)
    End Sub

    Public Function InsertUsers() As Integer
        Return Me.uDAO.Insert(Me)
    End Function

    Public Function UpdateUsers() As Integer
        Return Me.uDAO.Update(Me)
    End Function

    Public Function DeleteUsers() As Integer
        Return Me.uDAO.Delete(Me)
    End Function

    Public Sub uMoreTimeUsingApplication(path As String, ByRef playbacks As Collection)
        Me.uDAO.uMoreTimeUsingApplication(path, playbacks)
    End Sub

End Class

