<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agent
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuota = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        Me.cmbQuota = New System.Windows.Forms.ComboBox()
        Me.cmbAre = New System.Windows.Forms.ComboBox()
        Me.lblAre = New System.Windows.Forms.Label()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(612, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 59)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "AGENTS"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.SlateGray
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(661, 90)
        Me.Splitter1.TabIndex = 27
        Me.Splitter1.TabStop = False
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(201, 178)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(325, 27)
        Me.txtName.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 28)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Agent Name"
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(201, 130)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(325, 27)
        Me.txtCode.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 28)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Agent Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 28)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Quota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Area"
        '
        'txtQuota
        '
        Me.txtQuota.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuota.Location = New System.Drawing.Point(347, 232)
        Me.txtQuota.Name = "txtQuota"
        Me.txtQuota.Size = New System.Drawing.Size(179, 27)
        Me.txtQuota.TabIndex = 42
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.GenacePharma.My.Resources.Resources.add__2_
        Me.btnAdd.Location = New System.Drawing.Point(571, 129)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 70)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 43
        Me.btnAdd.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.Image = Global.GenacePharma.My.Resources.Resources.check
        Me.btnOk.Location = New System.Drawing.Point(571, 217)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(70, 70)
        Me.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnOk.TabIndex = 44
        Me.btnOk.TabStop = False
        '
        'cmbQuota
        '
        Me.cmbQuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbQuota.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQuota.FormattingEnabled = True
        Me.cmbQuota.Location = New System.Drawing.Point(201, 231)
        Me.cmbQuota.Name = "cmbQuota"
        Me.cmbQuota.Size = New System.Drawing.Size(140, 27)
        Me.cmbQuota.TabIndex = 46
        '
        'cmbAre
        '
        Me.cmbAre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAre.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAre.FormattingEnabled = True
        Me.cmbAre.Location = New System.Drawing.Point(199, 285)
        Me.cmbAre.Name = "cmbAre"
        Me.cmbAre.Size = New System.Drawing.Size(142, 27)
        Me.cmbAre.TabIndex = 61
        '
        'lblAre
        '
        Me.lblAre.AutoSize = True
        Me.lblAre.BackColor = System.Drawing.Color.RosyBrown
        Me.lblAre.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAre.ForeColor = System.Drawing.Color.White
        Me.lblAre.Location = New System.Drawing.Point(372, 289)
        Me.lblAre.Name = "lblAre"
        Me.lblAre.Size = New System.Drawing.Size(0, 22)
        Me.lblAre.TabIndex = 60
        '
        'agent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(661, 358)
        Me.Controls.Add(Me.cmbAre)
        Me.Controls.Add(Me.lblAre)
        Me.Controls.Add(Me.cmbQuota)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQuota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "agent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGENTS"
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuota As TextBox
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents btnOk As PictureBox
    Friend WithEvents cmbQuota As ComboBox
    Friend WithEvents cmbAre As ComboBox
    Friend WithEvents lblAre As Label
End Class
