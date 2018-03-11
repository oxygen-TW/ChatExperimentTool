'SEX Female=0 Male=1
Public Class Survey
    Dim SexAns As String = Nothing
    Dim Reason As String = Nothing

    Private Sub Survey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '禁止關閉視窗
        'Dim common1 As New Common
        'common1.DisableCloseButton(Me)


    End Sub

    Private Sub Button_female_Click(sender As Object, e As EventArgs) Handles Button_female.Click
        SexAns = 0
    End Sub

    Private Sub Button_male_Click(sender As Object, e As EventArgs) Handles Button_male.Click
        SexAns = 1
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        '檢查是否作答完成
        If SexAns = Nothing Or ReasonTextBox.Text = Nothing Then
            MessageBox.Show("作答未完成", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Reason = ReasonTextBox.Text

        '上傳
        Me.UseWaitCursor = True
        Dim result = UploadToServer(UrlMaker())
        Me.UseWaitCursor = False

        'MsgBox("debug:" + result)
    End Sub

    Function UploadToServer(ByVal DataBaseApiEndPoint)

        Dim webClient As New Net.WebClient
        Dim result As String = webClient.DownloadString(DataBaseApiEndPoint)
        Return result
    End Function

    Public Function UrlMaker()
        Dim DataBaseApiEndPoint As String = Main.Config(6)
        DataBaseApiEndPoint += "?key=ChatExperimentTool"
        DataBaseApiEndPoint += "&objectID='" & Main.Config(4) & "'"
        DataBaseApiEndPoint += "&testobjectID='" & Main.Config(5)
        DataBaseApiEndPoint += "'&sex=" & SexAns
        DataBaseApiEndPoint += "&reason='" & Reason & "'"
        'Console.WriteLine(url)
        Return DataBaseApiEndPoint
    End Function
End Class