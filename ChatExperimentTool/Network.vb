'Config List Format (IP,Port1,Port2,Server Address,Object ID)

Imports System.ComponentModel
Imports System.Net '網路功能
Imports System.Net.Sockets '連線功能
Imports System.Text '文字編碼
Imports System.Threading '多執行緒

Friend Module Network
    Dim UdpClient1 As UdpClient
    Dim Thread1 As Thread
    Dim name As String
    Dim NL = vbNewLine

    '監聽
    Public Sub Listen(ByVal port As Integer)

        'If TextBox1.Text = "" Then
        '    MsgBox("無法取得接收port" & vbCrLf & "Error#03", 16)
        '    Exit Sub
        'ElseIf TextBox4.Text = "" Then
        '    MsgBox("無法取得目標port" & vbCrLf & "Error#01", 16)
        '    Exit Sub
        '    'ElseIf TextBox4.Text = TextBox1.Text Then
        '    '    MsgBox("目標port不可與接收port相同" & vbCrLf & "Error#02", 16)
        '    '    Exit Sub
        'End If

        UdpClient1 = New UdpClient(port)
        Dim EndPoint As New IPEndPoint(IPAddress.Parse("127.0.0.1"), port)
        Do While True
            Dim ByteData() As Byte = UdpClient1.Receive(EndPoint)
            Dim Str As String = Encoding.Default.GetString(ByteData)

        Loop
    End Sub

    Public Sub Sent(ByVal ip As String, ByVal RemotePort As Integer)
        Dim sent As String = "<" & name & "> " & "TEST STRING"
        Dim ByteData() As Byte = Encoding.Default.GetBytes(sent)
        'Dim A() As Byte = Encoding.Default.GetBytes("SystemmessageonlineNotlisten")
        Dim UdpClient2 As New UdpClient

        'If TextBox3.Text = "Systemmessageonline" Or TextBox3.Text = "Systemmessageoffline" Then
        '    MsgBox("您已發出更改狀態指令", 48)
        'ElseIf TextBox4.Text = "" Then
        '    MsgBox("無法取得目標port" & vbCrLf & "Error#01", 16)
        '    Exit Sub
        '    'ElseIf TextBox4.Text = TextBox1.Text Then
        '    '    MsgBox("目標port不可與接收port相同" & vbCrLf & "Error#02", 16)
        '    '    Exit Sub
        'End If

        'If Button1.Enabled = True Then
        UdpClient2.Send(ByteData, ByteData.Length, ip, RemotePort)
        ' Else
        'S.Send(Encoding.Default.GetBytes("Systemmessageonline"), 19, IP, port)
        'End If

        UdpClient2.Close()
        Main.ChatBox.Text += sent & NL
        Main.SentTextBox.Text = Nothing
    End Sub

    Sub Start(ByVal IP As String, ByVal RemotePort As Integer)
        Control.CheckForIllegalCrossThreadCalls = False '不允許控制項檢查非法執行緒呼叫
        Thread1 = New Thread(AddressOf Listen)
        Thread1.Start()
        'Button1.Enabled = False
        'Button4.Enabled = True

        'Label6.ForeColor = Color.Orange
        'Label6.Text = "等候通知"

        Dim UdpClient3 As New UdpClient
        Dim ByteData() As Byte = Encoding.Default.GetBytes("Systemmessageonline")
        UdpClient3.Send(ByteData, ByteData.Length, IP, RemotePort)
        UdpClient3.Close()
    End Sub
End Module
