'SEX Female=0 Male=1
Public Class Survey
    Dim SexAns As String = Nothing
    Dim Reason As String = Nothing
    Dim WantExange As Boolean = Nothing
    Dim Contact As String = Nothing
    Dim IsContactPass As Boolean = Nothing

    Private Sub Survey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '禁止關閉視窗
        'Dim common1 As New Common
        'common1.DisableCloseButton(Me)


    End Sub

    Private Sub Button_female_Click(sender As Object, e As EventArgs) Handles Button_female.Click
        Button_female.Enabled = False
        Button_male.Enabled = True
        SexAns = 0
    End Sub

    Private Sub Button_male_Click(sender As Object, e As EventArgs) Handles Button_male.Click
        Button_female.Enabled = True
        Button_male.Enabled = False
        SexAns = 1
    End Sub

    Private Sub ExchangeYES_Click(sender As Object, e As EventArgs) Handles exchangeYES.Click
        WantExange = True
        exchangeNO.Enabled = True
        exchangeYES.Enabled = False
        contactBox.Enabled = True
        IsContactPass = False
        'Console.WriteLine(Int(WantExange))
    End Sub

    Private Sub ExchangeNO_Click(sender As Object, e As EventArgs) Handles exchangeNO.Click
        WantExange = False
        exchangeNO.Enabled = False
        exchangeYES.Enabled = True
        contactBox.Enabled = False
        IsContactPass = True
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If WantExange Then
            If contactBox.Text = Nothing Then
                IsContactPass = False
            Else
                Contact = contactBox.Text
                IsContactPass = True
            End If
        End If

        '檢查是否作答完成
        If SexAns = Nothing Or ReasonTextBox.Text = Nothing Or Not IsContactPass Or Contact = Nothing Then
            MessageBox.Show("作答還未完成喔!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Reason = ReasonTextBox.Text

        '上傳
        Me.UseWaitCursor = True
        Dim result = UploadToServer(UrlMaker(Main.Config(3).ToString))
        Me.UseWaitCursor = False

        If result <> "OK" Then
            MessageBox.Show("debug:資料庫錯誤，請通知實驗人員!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("實驗完成，十分感謝你的參與!", "完成!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If


    End Sub

    Function UploadToServer(ByVal DataBaseApiEndPoint)

        Dim webClient As New Net.WebClient
        Dim result As String = webClient.DownloadString(DataBaseApiEndPoint)
        Return result
    End Function

    Public Function UrlMaker(ByVal DataBaseApiEndPoint)
        DataBaseApiEndPoint += "?key=ChatExperimentTool"
        DataBaseApiEndPoint += $"&objectID='{Main.Config(4)}'"
        DataBaseApiEndPoint += $"&testobjectID='{Main.Config(5)}"
        DataBaseApiEndPoint += $"'&sexuality={SexAns}"
        DataBaseApiEndPoint += $"&reason='{Reason}'"
        DataBaseApiEndPoint += "&exchange=" & Int(WantExange)
        DataBaseApiEndPoint += $"&contact='{Contact}'"
        DataBaseApiEndPoint += "&message='" & ReadAllLog(Main.Config(4)) & "'"
        Console.WriteLine(DataBaseApiEndPoint)
        Return DataBaseApiEndPoint
    End Function

End Class