<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mailin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.txtCliMail = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtSenMail = New System.Windows.Forms.TextBox()
        Me.txtSenName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbClient = New System.Windows.Forms.ComboBox()
        Me.txtBal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtPhon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAttac = New System.Windows.Forms.TextBox()
        Me.openfile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAttach = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.SlateGray
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(900, 32)
        Me.Splitter1.TabIndex = 29
        Me.Splitter1.TabStop = False
        '
        'txtCliMail
        '
        Me.txtCliMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliMail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliMail.ForeColor = System.Drawing.Color.Black
        Me.txtCliMail.Location = New System.Drawing.Point(16, 384)
        Me.txtCliMail.Name = "txtCliMail"
        Me.txtCliMail.Size = New System.Drawing.Size(261, 23)
        Me.txtCliMail.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.txtSenMail)
        Me.GroupBox1.Controls.Add(Me.txtSenName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(451, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 286)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sender Information"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(167, 238)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(243, 26)
        Me.TextBox7.TabIndex = 46
        Me.TextBox7.Text = "587"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(167, 201)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(243, 26)
        Me.TextBox6.TabIndex = 45
        Me.TextBox6.Text = "smtp.gmail.com"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 23)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "SMTP Port"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "SMTP Host"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(178, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 15)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "* Enter your Gmail password"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(167, 122)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(243, 26)
        Me.txtPass.TabIndex = 41
        '
        'txtSenMail
        '
        Me.txtSenMail.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenMail.Location = New System.Drawing.Point(167, 77)
        Me.txtSenMail.Name = "txtSenMail"
        Me.txtSenMail.Size = New System.Drawing.Size(243, 26)
        Me.txtSenMail.TabIndex = 40
        '
        'txtSenName
        '
        Me.txtSenName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenName.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenName.Location = New System.Drawing.Point(167, 30)
        Me.txtSenName.Name = "txtSenName"
        Me.txtSenName.Size = New System.Drawing.Size(243, 26)
        Me.txtSenName.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 23)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Sender Name"
        '
        'txtMes
        '
        Me.txtMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMes.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMes.ForeColor = System.Drawing.Color.Black
        Me.txtMes.Location = New System.Drawing.Point(16, 452)
        Me.txtMes.Multiline = True
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(698, 240)
        Me.txtMes.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.cmbClient)
        Me.GroupBox2.Controls.Add(Me.txtBal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbDay)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtAdd)
        Me.GroupBox2.Controls.Add(Me.txtPhon)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 286)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client's Information"
        '
        'cmbClient
        '
        Me.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClient.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClient.FormattingEnabled = True
        Me.cmbClient.Location = New System.Drawing.Point(167, 76)
        Me.cmbClient.Name = "cmbClient"
        Me.cmbClient.Size = New System.Drawing.Size(243, 27)
        Me.cmbClient.TabIndex = 48
        '
        'txtBal
        '
        Me.txtBal.Enabled = False
        Me.txtBal.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBal.Location = New System.Drawing.Point(167, 249)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(243, 26)
        Me.txtBal.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Balance"
        '
        'cmbDay
        '
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDay.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(167, 25)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(177, 27)
        Me.cmbDay.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Days"
        '
        'txtAdd
        '
        Me.txtAdd.Enabled = False
        Me.txtAdd.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(167, 171)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(243, 54)
        Me.txtAdd.TabIndex = 41
        '
        'txtPhon
        '
        Me.txtPhon.Enabled = False
        Me.txtPhon.Font = New System.Drawing.Font("Arial", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhon.Location = New System.Drawing.Point(167, 126)
        Me.txtPhon.Name = "txtPhon"
        Me.txtPhon.Size = New System.Drawing.Size(243, 26)
        Me.txtPhon.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 23)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 23)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Phone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Letter Gothic Std", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 23)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Client Name"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SlateGray
        Me.Button2.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(730, 515)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 78)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "SEND"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtSub
        '
        Me.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSub.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSub.ForeColor = System.Drawing.Color.Silver
        Me.txtSub.Location = New System.Drawing.Point(16, 423)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(207, 23)
        Me.txtSub.TabIndex = 49
        Me.txtSub.Text = "Due Accounts"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(730, 614)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 78)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtAttac
        '
        Me.txtAttac.Location = New System.Drawing.Point(530, 426)
        Me.txtAttac.Name = "txtAttac"
        Me.txtAttac.Size = New System.Drawing.Size(184, 22)
        Me.txtAttac.TabIndex = 52
        '
        'openfile
        '
        Me.openfile.FileName = "OpenFileDialog1"
        '
        'btnAttach
        '
        Me.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttach.Image = Global.GenacePharma.My.Resources.Resources.attach
        Me.btnAttach.Location = New System.Drawing.Point(745, 358)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(130, 125)
        Me.btnAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAttach.TabIndex = 54
        Me.btnAttach.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAttach, "Attach File")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.IndianRed
        Me.Label9.Location = New System.Drawing.Point(545, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "* File has been attached!"
        '
        'mailin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(900, 706)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.txtAttac)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSub)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCliMail)
        Me.Controls.Add(Me.Splitter1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mailin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mailin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnAttach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents txtCliMail As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtSenMail As TextBox
    Friend WithEvents txtSenName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMes As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents txtPhon As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtSub As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtAttac As TextBox
    Friend WithEvents openfile As OpenFileDialog
    Friend WithEvents btnAttach As PictureBox
    Friend WithEvents cmbClient As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label9 As Label
End Class
