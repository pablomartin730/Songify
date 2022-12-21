Public Class PlayBackDAO

    Public ReadOnly Property PlayBacks As Collection

    Public Sub New()

        Me.PlayBacks = New Collection

    End Sub

    Public Sub ReadAll(path As String)

        Dim pb As PlayBack
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM PLAYBACKS ORDER BY IdPlay")

        For Each aux In col
            pb = New PlayBack(Integer.Parse(aux(1)))
            pb.pbUser.Email = aux(2).ToString
            pb.pbsong.IdSong = aux(3)
            pb.pbDate = Convert.ToDateTime(aux(4))
            Me.PlayBacks.Add(pb)
        Next
    End Sub
    Public Sub Read(ByRef pb As PlayBack)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM PLAYBACKS WHERE IdPlay (" & pb.IdPlay & ";")
        For Each aux In col
            pb.pbUser = New User
            pb.pbUser.Email = aux(2).ToString
            pb.pbsong = aux(3).
            pb.pbDate = Convert.ToDateTime(aux(4))
        Next
    End Sub
    Public Function Insert(ByVal pb As PlayBack) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO PLAYBACKS VALUES (" & pb.IdPlay & ", '" & pb.pbUser.Email & "', " & pb.pbsong.IdSong & ", #" & pb.pbDate & "#);")
    End Function

    Public Function Update(ByVal pb As PlayBack) As Integer
        Return DBBroker.GetBroker.Change("UPDATE PLAYBACKS SET song=" & pb.pbsong.IdSong & " WHERE PLAYBACKS=" & pb.IdPlay & " AND pbDate = #" & pb.pbDate & "#;")
    End Function

    Public Function Delete(ByVal pb As PlayBack) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM PLAYBACKS WHERE IdPlay= " & pb.IdPlay & ";")
    End Function
    Public Function Getid(path As String)
        Dim col As Collection : Dim aux As Collection
        Dim counter As Integer
        col = DBBroker.GetBroker(path).Read("SELECT * FROM PLAYBACKS ORDER BY IdPlay")
        For Each aux In col
            counter += 1
        Next
        Return counter + 1
    End Function








End Class
