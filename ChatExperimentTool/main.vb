﻿Imports System.ComponentModel
Imports System.Net '網路功能
Imports System.Net.Sockets '連線功能
Imports System.Text '文字編碼
Imports System.Threading '多執行緒
Public Class Main

    Public Config As New List(Of String)
    Dim ObjectID As String = Nothing
    Dim Counter As Integer = 0
    Dim Count_limit = 0
    Dim Time_limit = False
    Private Time_count = 300

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConfigFilePath As String = "config.ini"

        Try
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
        Catch ex As Exception
            MessageBox.Show("debug:組態檔錯誤，請通知實驗人員!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Debug Only
        'For Each item As String In Config
        '    MsgBox(item)
        'Next

        '定義受試者ID
        ObjectID = Config(4)

        '取得聊天次數限制
        Count_limit = Int(Config(6))

        '取得時間限制
        Time_count = Int(Config(7))

        '清空檔案
        CleanFileText(ObjectID)

        'Console.WriteLine(Config(3))

        'Call Listen(Int(Config(1)))
        Call Start(Config(0), Config(2))

        '顯示實驗說明
        MessageBox.Show($"感謝您參與本次實驗{vbNewLine}本實驗目的為想要得知匿名聊天與性別上的關聯{vbNewLine}請在實驗過程中""不要直接或間接""告知對方您的姓名、性別、學號、班級座號等能識別出彼此身分的言論{vbNewLine}非常感謝您的配合！", "你好", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    Private Sub SentButton_Click(sender As Object, e As EventArgs) Handles SentButton.Click
        If SentTextBox.Text <> "" Then
            Sent(Config(0), Config(2), SentTextBox.Text)
        End If
    End Sub

    Private Sub SentTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SentTextBox.KeyDown
        If e.KeyCode = Keys.Return And SentTextBox.Text <> "" Then
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
            ChatBox.AppendText(Str + NL)
            Call AutoScrollBar()

            '計算對話次數
            Counter += 1
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
        ChatBox.AppendText(sent & NL)
        Call AutoScrollBar()
        '計算對話次數
        Counter += 1
        Console.WriteLine(Counter)
        '將對話紀錄寫入記錄檔
        WriteToLog(sent & NL, ObjectID)
        SentTextBox.Text = Nothing

        '檢查對話次數
        If Counter > Count_limit And Time_limit Then
            Call CloseSentFunction()
            MessageBox.Show("實驗即將完成，我們將開啟一個表單，請您回答問題", "實驗即將完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Survey.Show()
        End If
    End Sub

    Sub Start(ByVal IP As String, ByVal RemotePort As Integer)
        Control.CheckForIllegalCrossThreadCalls = False '不允許控制項檢查非法執行緒呼叫
        Thread1 = New Thread(AddressOf Listen)
        Thread1.Start()

        'Send Online Singal
        Sent(Config(0), Config(2), "Online Singal from " + ObjectID)
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        SentTextBox.Enabled = True
        SentButton.Enabled = True
        StartButton.Enabled = False

        Timer1.Start()
        'Call Timer_init()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerShow.Text = Time_count.ToString
        Time_count -= 1

        If Time_count <= 0 Then
            Time_limit = True
            TimerShow.Text = "Time's up!"
        End If
    End Sub

    Sub CloseSentFunction()
        SentTextBox.Enabled = False
        SentButton.Enabled = False
    End Sub

    Public Sub AutoScrollBar()
        ChatBox.SelectionStart = ChatBox.Text.Length
        ChatBox.ScrollToCaret()
        ChatBox.Refresh()
    End Sub
End Class