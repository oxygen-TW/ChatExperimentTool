Module Log

    Sub WriteToLog(ByVal Text, ByVal ObjectID)
        Dim LogFilePath As String = ObjectID + ".txt"
        My.Computer.FileSystem.WriteAllText(
          LogFilePath, Now().ToString + " " + Text, True)
    End Sub

    Public Function ReadAllLog()

    End Function

    Sub CleanFileText(ByVal ObjectID)
        Dim LogFilePath As String = ObjectID + ".txt"
        My.Computer.FileSystem.WriteAllText(
          LogFilePath, "", False)
    End Sub
End Module
