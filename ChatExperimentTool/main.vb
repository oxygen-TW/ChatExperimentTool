Imports System.ComponentModel
Imports System.Net '網路功能
Imports System.Net.Sockets '連線功能
Imports System.Text '文字編碼
Imports System.Threading '多執行緒
Public Class Main

    Public Config As New List(Of String)
    Dim ObjectID As String = Nothing

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConfigFilePath As String = "config.ini"
        Using MyReader As New FileIO.TextFieldParser(
                          ConfigFilePath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(";")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow

                        'Read Config File
                        Config.Add(currentField)
                    Next
                Catch ex As FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
        "is not valid and will be skipped.")
                End Try
            End While
        End Using

        'Debug Only
        For Each item As String In Config
            MsgBox(item)
        Next

        '定義受試者ID
        ObjectID = Config(4)

        '清空檔案
        CleanFileText(ObjectID)

        'Call Listen(Int(Config(1)))
        Call Start(Config(0), Config(2))

        Survey.Show()
        Me.Close()
    End Sub

    Private Sub SentButton_Click(sender As Object, e As EventArgs) Handles SentButton.Click
        Sent(Config(0), Config(2), SentTextBox.Text)
    End Sub

    Private Sub SentTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SentTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            Sent(Config(0), Config(2), SentTextBox.Text)
        End If
    End Sub

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '使執行序正常關閉
        Try
            Thread1.Abort()
            UdpClient1.Close()
        Catch ex As Exception
        End Try
    End Sub

    Dim UdpClient1 As UdpClient
    Dim Thread1 As Thread
    Dim NL = vbNewLine

    '監聽
    Public Sub Listen()

        Dim port As Integer = Config(1)
        UdpClient1 = New UdpClient(port)
        Dim EndPoint As New IPEndPoint(IPAddress.Parse("127.0.0.1"), port)
        Do While True
            Dim ByteData() As Byte = UdpClient1.Receive(EndPoint)
            Dim Str As String = Encoding.Default.GetString(ByteData)
            ChatBox.Text += Str + NL

            '將對話紀錄寫入記錄檔
            WriteToLog(Str & NL, ObjectID)
        Loop
    End Sub

    Public Sub Sent(ByVal ip As String, ByVal RemotePort As Integer, ByVal Message As String)
        Dim sent As String = "<" & ObjectID & ">  " & Message
        Dim ByteData() As Byte = Encoding.Default.GetBytes(sent)
        'Dim A() As Byte = Encoding.Default.GetBytes("SystemmessageonlineNotlisten")
        Dim UdpClient2 As New UdpClient

        'If Button1.Enabled = True Then
        UdpClient2.Send(ByteData, ByteData.Length, ip, RemotePort)
        ' Else
        'S.Send(Encoding.Default.GetBytes("Systemmessageonline"), 19, IP, port)
        'End If

        UdpClient2.Close()
        ChatBox.Text += sent & NL
        '將對話紀錄寫入記錄檔
        WriteToLog(sent & NL, ObjectID)
        SentTextBox.Text = Nothing
    End Sub

    Sub Start(ByVal IP As String, ByVal RemotePort As Integer)
        Control.CheckForIllegalCrossThreadCalls = False '不允許控制項檢查非法執行緒呼叫
        Thread1 = New Thread(AddressOf Listen)
        Thread1.Start()

        'Send Online Singal
        Sent(Config(0), Config(2), "Online Singal")
    End Sub
End Class