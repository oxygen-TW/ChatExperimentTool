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
        Me.exchangeYES = New System.Windows.Forms.Button()
        Me.exchangeNO = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.contactBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_female
        '
        Me.Button_female.Location = New System.Drawing.Point(207, 60)
        Me.Button_female.Name = "Button_female"
        Me.Button_female.Size = New System.Drawing.Size(151, 44)
        Me.Button_female.TabIndex = 0
        Me.Button_female.Text = "女生"
        Me.Button_female.UseVisualStyleBackColor = True
        '
        'Button_male
        '
        Me.Button_male.Location = New System.Drawing.Point(25, 60)
        Me.Button_male.Name = "Button_male"
        Me.Button_male.Size = New System.Drawing.Size(151, 44)
        Me.Button_male.TabIndex = 1
        Me.Button_male.Text = "男生"
        Me.Button_male.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
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
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " 為甚麼會這麼覺得? 寫越具體越好"
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReasonTextBox.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReasonTextBox.Location = New System.Drawing.Point(24, 248)
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(333, 61)
        Me.ReasonTextBox.TabIndex = 4
        Me.ReasonTextBox.Text = ""
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(252, 452)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(106, 39)
        Me.Submit.TabIndex = 5
        Me.Submit.Text = "提交"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'exchangeYES
        '
        Me.exchangeYES.Location = New System.Drawing.Point(25, 364)
        Me.exchangeYES.Name = "exchangeYES"
        Me.exchangeYES.Size = New System.Drawing.Size(151, 40)
        Me.exchangeYES.TabIndex = 6
        Me.exchangeYES.Text = "好"
        Me.exchangeYES.UseVisualStyleBackColor = True
        '
        'exchangeNO
        '
        Me.exchangeNO.Location = New System.Drawing.Point(207, 364)
        Me.exchangeNO.Name = "exchangeNO"
        Me.exchangeNO.Size = New System.Drawing.Size(151, 40)
        Me.exchangeNO.TabIndex = 7
        Me.exchangeNO.Text = "不要"
        Me.exchangeNO.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 40)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "是否願意和對方交換聯絡資訊?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如果願意請填寫聯絡方式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'contactBox
        '
        Me.contactBox.Enabled = False
        Me.contactBox.Location = New System.Drawing.Point(24, 462)
        Me.contactBox.Name = "contactBox"
        Me.contactBox.Size = New System.Drawing.Size(222, 22)
        Me.contactBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 40)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "聯絡資料 (班級座號/方式/帳號)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "例: 13001/Line/apple1234" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(25, 157)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "語氣"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(24, 180)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "話題"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(24, 203)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.Text = "用詞"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(190, 157)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox4.TabIndex = 14
        Me.CheckBox4.Text = "打字速度"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(190, 180)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox5.TabIndex = 15
        Me.CheckBox5.Text = "錯字率"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "其他"
        '
        'Survey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 506)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.contactBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exchangeNO)
        Me.Controls.Add(Me.exchangeYES)
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
    Friend WithEvents exchangeYES As Button
    Friend WithEvents exchangeNO As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents contactBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Label5 As Label
End Class
