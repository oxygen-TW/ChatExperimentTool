Public Class Survey
    Dim SexAns As String = Nothing
    Dim Reason As String = Nothing

    Private Sub Survey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '禁止關閉視窗
        Dim common1 As New Common
        common1.DisableCloseButton(Me)


    End Sub

    Private Sub Button_female_Click(sender As Object, e As EventArgs) Handles Button_female.Click
        SexAns = "Female"
    End Sub

    Private Sub Button_male_Click(sender As Object, e As EventArgs) Handles Button_male.Click
        SexAns = "Male"
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        '檢查是否作答完成
        If SexAns = Nothing Or ReasonTextBox.Text Then
            MessageBox.Show("作答未完成", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Reason = ReasonTextBox.Text

        '上傳
    End Sub

    Sub UploadToServer()

    End Sub
End Class