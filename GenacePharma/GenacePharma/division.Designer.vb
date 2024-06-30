<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class division
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.lblAgent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(604, 11)
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
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 59)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "DIVISION"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.SlateGray
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(653, 90)
        Me.Splitter1.TabIndex = 27
        Me.Splitter1.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Gainsboro
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.Image = Global.GenacePharma.My.Resources.Resources.check
        Me.btnOk.Location = New System.Drawing.Point(561, 203)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(70, 70)
        Me.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnOk.TabIndex = 57
        Me.btnOk.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.GenacePharma.My.Resources.Resources.add__2_
        Me.btnAdd.Location = New System.Drawing.Point(561, 116)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 70)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 56
        Me.btnAdd.TabStop = False
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.BackColor = System.Drawing.Color.RosyBrown
        Me.lblAgent.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgent.ForeColor = System.Drawing.Color.White
        Me.lblAgent.Location = New System.Drawing.Point(341, 237)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(0, 22)
        Me.lblAgent.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(26, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 28)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Agents"
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(233, 171)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(291, 27)
        Me.txtName.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 28)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Division Name"
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(233, 123)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(291, 27)
        Me.txtCode.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 28)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Division Code"
        '
        'cmbAgent
        '
        Me.cmbAgent.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(145, 232)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(142, 27)
        Me.cmbAgent.TabIndex = 59
        '
        'division
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(653, 306)
        Me.Controls.Add(Me.cmbAgent)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblAgent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "division"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "division"
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents btnOk As PictureBox
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents lblAgent As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAgent As ComboBox
End Class
