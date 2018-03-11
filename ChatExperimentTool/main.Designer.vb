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
        Me.ChatBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatBox.AutoWordSelection = True
        Me.ChatBox.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChatBox.Location = New System.Drawing.Point(12, 21)
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.Size = New System.Drawing.Size(491, 229)
        Me.ChatBox.TabIndex = 0
        Me.ChatBox.Text = ""
        '
        'SentTextBox
        '
        Me.SentTextBox.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SentTextBox.Location = New System.Drawing.Point(12, 267)
        Me.SentTextBox.Name = "SentTextBox"
        Me.SentTextBox.Size = New System.Drawing.Size(398, 29)
        Me.SentTextBox.TabIndex = 1
        '
        'SentButton
        '
        Me.SentButton.Location = New System.Drawing.Point(416, 267)
        Me.SentButton.Name = "SentButton"
        Me.SentButton.Size = New System.Drawing.Size(87, 29)
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
        Me.Text = "ChatExperimentTool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChatBox As RichTextBox
    Friend WithEvents SentTextBox As TextBox
    Friend WithEvents SentButton As Button
End Class
