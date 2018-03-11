<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Survey
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
        Me.Button_female = New System.Windows.Forms.Button()
        Me.Button_male = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReasonTextBox = New System.Windows.Forms.RichTextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_female
        '
        Me.Button_female.Location = New System.Drawing.Point(50, 69)
        Me.Button_female.Name = "Button_female"
        Me.Button_female.Size = New System.Drawing.Size(103, 44)
        Me.Button_female.TabIndex = 0
        Me.Button_female.Text = "女生"
        Me.Button_female.UseVisualStyleBackColor = True
        '
        'Button_male
        '
        Me.Button_male.Location = New System.Drawing.Point(195, 69)
        Me.Button_male.Name = "Button_male"
        Me.Button_male.Size = New System.Drawing.Size(103, 44)
        Me.Button_male.TabIndex = 1
        Me.Button_male.Text = "男生"
        Me.Button_male.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "依照剛才的對話，你覺得對方是男生還是女生?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " 為甚麼會這麼覺得? 寫越詳細越好"
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReasonTextBox.Location = New System.Drawing.Point(25, 196)
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(333, 88)
        Me.ReasonTextBox.TabIndex = 4
        Me.ReasonTextBox.Text = ""
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(283, 302)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 5
        Me.Submit.Text = "提交"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Survey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 415)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.ReasonTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_male)
        Me.Controls.Add(Me.Button_female)
        Me.Name = "Survey"
        Me.Text = "Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_female As Button
    Friend WithEvents Button_male As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReasonTextBox As RichTextBox
    Friend WithEvents Submit As Button
End Class
