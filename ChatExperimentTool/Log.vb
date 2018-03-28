Module Log

    Sub WriteToLog(ByVal Text, ByVal ObjectID)
        Dim LogFilePath As String = ObjectID + ".txt"
        My.Computer.FileSystem.WriteAllText(
          LogFilePath, Now().ToString + " " + Text, True)
    End Sub

    Public Function ReadAllLog(ByVal ObjectID)
        Try

            Dim LogFilePath As String = ObjectID + ".txt"
        Dim fileReader As String = Nothing

        fileReader = My.Computer.FileSystem.ReadAllText(LogFilePath)

        Return fileReader
        Catch ex As Exception
        MessageBox.Show("debug:取得資料錯誤，請通知實驗人員!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Function

    Sub CleanFileText(ByVal ObjectID)
        Dim LogFilePath As String = ObjectID + ".txt"
        My.Computer.FileSystem.WriteAllText(
          LogFilePath, "", False)
    End Sub
End Module
