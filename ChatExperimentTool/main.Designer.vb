<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ChatBox = New System.Windows.Forms.RichTextBox()
        Me.SentTextBox = New System.Windows.Forms.TextBox()
        Me.SentButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ChatBox
        '
        Me.ChatBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatBox.AutoWordSelection = True
        Me.ChatBox.EnableAutoDragDrop = True
        Me.ChatBox.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChatBox.Location = New System.Drawing.Point(12, 32)
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.ReadOnly = True
        Me.ChatBox.Size = New System.Drawing.Size(491, 229)
        Me.ChatBox.TabIndex = 0
        Me.ChatBox.Text = ""
        '
        'SentTextBox
        '
        Me.SentTextBox.Enabled = False
        Me.SentTextBox.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SentTextBox.Location = New System.Drawing.Point(12, 267)
        Me.SentTextBox.Name = "SentTextBox"
        Me.SentTextBox.Size = New System.Drawing.Size(398, 29)
        Me.SentTextBox.TabIndex = 1
        '
        'SentButton
        '
        Me.SentButton.Enabled = False
        Me.SentButton.Location = New System.Drawing.Point(416, 267)
        Me.SentButton.Name = "SentButton"
        Me.SentButton.Size = New System.Drawing.Size(87, 29)
        Me.SentButton.TabIndex = 2
        Me.SentButton.Text = "Sent"
        Me.SentButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "和與你配對的朋友聊聊天吧"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000000
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(428, 7)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 19)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Debug Only"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 308)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SentButton)
        Me.Controls.Add(Me.SentTextBox)
        Me.Controls.Add(Me.ChatBox)
        Me.Name = "Main"
        Me.Text = "ChatExperimentTool /  Program designer 30719  / Ver. 1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChatBox As RichTextBox
    Friend WithEvents SentTextBox As TextBox
    Friend WithEvents SentButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
