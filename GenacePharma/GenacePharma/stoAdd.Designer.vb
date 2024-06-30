<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stoAdd
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtReO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtExpiry = New System.Windows.Forms.DateTimePicker()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.txtSRP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCOG = New System.Windows.Forms.TextBox()
        Me.txtUOM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.PictureBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBran = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(620, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.SlateGray
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(669, 58)
        Me.Splitter1.TabIndex = 30
        Me.Splitter1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Beige
        Me.GroupBox2.Controls.Add(Me.txtReO)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtExpiry)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.txtLot)
        Me.GroupBox2.Controls.Add(Me.txtSRP)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCOG)
        Me.GroupBox2.Controls.Add(Me.txtUOM)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 245)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'txtReO
        '
        Me.txtReO.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReO.Location = New System.Drawing.Point(247, 59)
        Me.txtReO.Name = "txtReO"
        Me.txtReO.Size = New System.Drawing.Size(130, 27)
        Me.txtReO.TabIndex = 9
        Me.txtReO.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Letter Gothic Std", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Re-Order Level"
        '
        'dtExpiry
        '
        Me.dtExpiry.CustomFormat = "MMMM dd, yyyy"
        Me.dtExpiry.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpiry.Location = New System.Drawing.Point(174, 193)
        Me.dtExpiry.Name = "dtExpiry"
        Me.dtExpiry.Size = New System.Drawing.Size(237, 27)
        Me.dtExpiry.TabIndex = 12
        '
        'txtQty
        '
        Me.txtQty.Enabled = False
        Me.txtQty.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(117, 157)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(112, 27)
        Me.txtQty.TabIndex = 11
        Me.txtQty.Text = "0"
        '
        'txtLot
        '
        Me.txtLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLot.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot.Location = New System.Drawing.Point(117, 121)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(136, 27)
        Me.txtLot.TabIndex = 10
        '
        'txtSRP
        '
        Me.txtSRP.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRP.Location = New System.Drawing.Point(76, 86)
        Me.txtSRP.Name = "txtSRP"
        Me.txtSRP.Size = New System.Drawing.Size(130, 27)
        Me.txtSRP.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Expiry Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "SRP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "COG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "OnHand"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Lot No."
        '
        'txtCOG
        '
        Me.txtCOG.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOG.Location = New System.Drawing.Point(76, 51)
        Me.txtCOG.Name = "txtCOG"
        Me.txtCOG.Size = New System.Drawing.Size(130, 27)
        Me.txtCOG.TabIndex = 7
        '
        'txtUOM
        '
        Me.txtUOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUOM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUOM.Location = New System.Drawing.Point(76, 16)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(130, 27)
        Me.txtUOM.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "UOM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RosyBrown
        Me.Button1.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(436, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 75)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Beige
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.txtCat)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.cmbClass)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbAgent)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbBran)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 173)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Image = Global.GenacePharma.My.Resources.Resources.searchna
        Me.btnFind.Location = New System.Drawing.Point(517, 0)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(45, 45)
        Me.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFind.TabIndex = 41
        Me.btnFind.TabStop = False
        '
        'txtCat
        '
        Me.txtCat.Enabled = False
        Me.txtCat.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCat.Location = New System.Drawing.Point(328, 11)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(64, 27)
        Me.txtCat.TabIndex = 36
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(398, 11)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(102, 27)
        Me.txtCode.TabIndex = 2
        '
        'cmbClass
        '
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClass.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(172, 11)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(151, 27)
        Me.cmbClass.TabIndex = 1
        '
        'txtDesc
        '
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(172, 127)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(423, 27)
        Me.txtDesc.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Description"
        '
        'cmbAgent
        '
        Me.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAgent.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(172, 89)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(423, 27)
        Me.cmbAgent.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Agent"
        '
        'cmbBran
        '
        Me.cmbBran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBran.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBran.FormattingEnabled = True
        Me.cmbBran.Location = New System.Drawing.Point(172, 54)
        Me.cmbBran.Name = "cmbBran"
        Me.cmbBran.Size = New System.Drawing.Size(136, 27)
        Me.cmbBran.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Branch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Stock Code"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.RosyBrown
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 54)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(391, 15)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(223, 28)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "EXISTING PRODUCT"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(206, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(163, 28)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "NEW PRODUCT"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(22, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = ">>"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RosyBrown
        Me.Button2.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(436, 431)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 102)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Save Changes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'stoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(669, 570)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stoAdd"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtExpiry As DateTimePicker
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtLot As TextBox
    Friend WithEvents txtSRP As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCOG As TextBox
    Friend WithEvents txtUOM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBran As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCat As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnFind As PictureBox
End Class
