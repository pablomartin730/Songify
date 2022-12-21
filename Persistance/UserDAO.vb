Public Class UserDAO
    Public ReadOnly Property Users As Collection
    Public Sub New()
        Me.Users = New Collection
    End Sub
    Public Sub ReadAll(path As String)
        Dim u As User
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM USERS ORDER BY Email")

        For Each aux In col
            u = New User(aux(1).ToString)
            u.name = aux(2).ToString
            u.surname = aux(3).ToString
            u.birthdate = Convert.ToDateTime(aux(4))
            Me.Users.Add(u)
        Next
    End Sub

    Public Sub Read(ByRef u As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM USERS WHERE Email='" & u.Email & "';")
        For Each aux In col
            u.name = aux(2).ToString
            u.surname = aux(3).ToString
            u.birthdate = Convert.ToDateTime(aux(4))
        Next

    End Sub
    Public Function Insert(ByVal u As User) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO USERS VALUES ('" & u.Email & "', '" & u.name & "', '" & u.surname & "', #" & u.birthdate & "#);")
    End Function

    Public Function Update(ByVal u As User) As Integer
        Return DBBroker.GetBroker.Change("UPDATE USERS SET uName= '" & u.name & "' , uSurname='" & u.surname & "' , birthdate=#" & u.birthdate & "# WHERE Email='" & u.Email & "';")
    End Function

    Public Function Delete(ByVal u As User) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM USERS WHERE Email='" & u.Email & "';")
    End Function

    Public Sub uMoreTimeUsingApplication(path As String, ByRef playbacks As Collection)
        Dim u As User
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT u.Email, u.uName, u.uSurname, u.birthdate, SUM(s.length)
                                                FROM USERS u, PLAYBACKS p, SONGS s
                                                    WHERE u.Email = p.user AND s.IdSong = p.song
                                                        GROUP BY u.Email, u.uName, u.uSurname, u.birthdate
                                                            ORDER BY SUM(s.length) DESC;")

        For Each aux In col
            u = New User(aux(1).ToString)
            u.name = aux(2).ToString
            u.surname = aux(3).ToString
            u.birthdate = Convert.ToDateTime(aux(4))
            Me.Users.Add(u)
            playbacks.Add(Integer.Parse(aux(5)))
        Next
    End Sub

End Class
