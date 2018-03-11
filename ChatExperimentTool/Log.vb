Module Log

    Sub WriteToLog(ByVal Text, ByVal ObjectID)
        Dim LogFilePath As String = ObjectID + ".txt"
        My.Computer.FileSystem.WriteAllText(
          LogFilePath, Text, True)
    End Sub
End Module
