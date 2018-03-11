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
        Me.ChatBox = New System.Windows.Forms.RichTextBox()
        Me.SentTextBox = New System.Windows.Forms.TextBox()
        Me.SentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChatBox
        '
        Me.ChatBox.Location = New System.Drawing.Point(50, 23)
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.Size = New System.Drawing.Size(398, 183)
        Me.ChatBox.TabIndex = 0
        Me.ChatBox.Text = ""
        '
        'SentTextBox
        '
        Me.SentTextBox.Location = New System.Drawing.Point(50, 226)
        Me.SentTextBox.Name = "SentTextBox"
        Me.SentTextBox.Size = New System.Drawing.Size(398, 22)
        Me.SentTextBox.TabIndex = 1
        '
        'SentButton
        '
        Me.SentButton.Location = New System.Drawing.Point(373, 254)
        Me.SentButton.Name = "SentButton"
        Me.SentButton.Size = New System.Drawing.Size(75, 23)
        Me.SentButton.TabIndex = 2
        Me.SentButton.Text = "Sent"
        Me.SentButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 308)
        Me.Controls.Add(Me.SentButton)
        Me.Controls.Add(Me.SentTextBox)
        Me.Controls.Add(Me.ChatBox)
        Me.Name = "Main"
        Me.Text = "main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChatBox As RichTextBox
    Friend WithEvents SentTextBox As TextBox
    Friend WithEvents SentButton As Button
End Class
