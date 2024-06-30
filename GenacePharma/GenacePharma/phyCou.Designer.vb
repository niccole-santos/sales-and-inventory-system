<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class phyCou
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.PictureBox()
        Me.txtStockCo = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.cmbExpiry = New System.Windows.Forms.ComboBox()
        Me.cmbDes = New System.Windows.Forms.ComboBox()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtEdit = New System.Windows.Forms.DateTimePicker()
        Me.txtCountNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtgIn = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exp_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SlateGray
        Me.Label3.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label3.Location = New System.Drawing.Point(12, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(394, 59)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "PHYSICAL COUNT"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1415, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 45)
        Me.Button3.TabIndex = 14
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
        Me.Splitter1.Size = New System.Drawing.Size(1472, 82)
        Me.Splitter1.TabIndex = 16
        Me.Splitter1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Controls.Add(Me.txtStockCo)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.cmbExpiry)
        Me.GroupBox2.Controls.Add(Me.cmbDes)
        Me.GroupBox2.Controls.Add(Me.cmbAgent)
        Me.GroupBox2.Controls.Add(Me.cmbBranch)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtLot)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(643, 347)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Image = Global.GenacePharma.My.Resources.Resources.searchna
        Me.btnFind.Location = New System.Drawing.Point(353, 105)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(45, 45)
        Me.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFind.TabIndex = 40
        Me.btnFind.TabStop = False
        '
        'txtStockCo
        '
        Me.txtStockCo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtStockCo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtStockCo.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockCo.Location = New System.Drawing.Point(202, 115)
        Me.txtStockCo.Name = "txtStockCo"
        Me.txtStockCo.Size = New System.Drawing.Size(143, 28)
        Me.txtStockCo.TabIndex = 30
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(202, 293)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(177, 28)
        Me.txtQty.TabIndex = 29
        '
        'cmbExpiry
        '
        Me.cmbExpiry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExpiry.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpiry.FormattingEnabled = True
        Me.cmbExpiry.Location = New System.Drawing.Point(202, 203)
        Me.cmbExpiry.Name = "cmbExpiry"
        Me.cmbExpiry.Size = New System.Drawing.Size(177, 27)
        Me.cmbExpiry.TabIndex = 28
        '
        'cmbDes
        '
        Me.cmbDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDes.FormattingEnabled = True
        Me.cmbDes.Location = New System.Drawing.Point(202, 162)
        Me.cmbDes.Name = "cmbDes"
        Me.cmbDes.Size = New System.Drawing.Size(420, 27)
        Me.cmbDes.TabIndex = 27
        '
        'cmbAgent
        '
        Me.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAgent.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(202, 69)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(420, 27)
        Me.cmbAgent.TabIndex = 25
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBranch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(202, 19)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(177, 27)
        Me.cmbBranch.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 28)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Lot No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 28)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Expiry Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 293)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 28)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 28)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 28)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Stock Code"
        '
        'txtLot
        '
        Me.txtLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLot.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot.Location = New System.Drawing.Point(202, 249)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(177, 28)
        Me.txtLot.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Branch"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agent Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.dtEdit)
        Me.GroupBox1.Controls.Add(Me.txtCountNo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 104)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'dtEdit
        '
        Me.dtEdit.CustomFormat = "MMMM dd, yyyy"
        Me.dtEdit.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEdit.Location = New System.Drawing.Point(292, 62)
        Me.dtEdit.MaxDate = New Date(2809, 12, 31, 0, 0, 0, 0)
        Me.dtEdit.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtEdit.Name = "dtEdit"
        Me.dtEdit.Size = New System.Drawing.Size(247, 27)
        Me.dtEdit.TabIndex = 27
        Me.dtEdit.Value = New Date(2019, 1, 16, 0, 0, 0, 0)
        '
        'txtCountNo
        '
        Me.txtCountNo.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountNo.Location = New System.Drawing.Point(292, 19)
        Me.txtCountNo.Name = "txtCountNo"
        Me.txtCountNo.Size = New System.Drawing.Size(131, 28)
        Me.txtCountNo.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(5, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(246, 28)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Physical Count No."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(5, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 28)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Edit Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.btnDel)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 551)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(643, 81)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Ivory
        Me.btnDel.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.LightSlateGray
        Me.btnDel.Location = New System.Drawing.Point(371, 21)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(251, 45)
        Me.btnDel.TabIndex = 30
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Ivory
        Me.btnAdd.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.LightSlateGray
        Me.btnAdd.Location = New System.Drawing.Point(16, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(251, 45)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = Global.GenacePharma.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(1390, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 70)
        Me.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSave.TabIndex = 68
        Me.btnSave.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save")
        '
        'dtgIn
        '
        Me.dtgIn.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dtgIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgIn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgIn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.Stock_Code, Me.Desc, Me.Exp_Date, Me.Lot_No, Me.colOn, Me.colAge})
        Me.dtgIn.Location = New System.Drawing.Point(655, 167)
        Me.dtgIn.Name = "dtgIn"
        Me.dtgIn.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgIn.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgIn.RowTemplate.Height = 24
        Me.dtgIn.Size = New System.Drawing.Size(805, 465)
        Me.dtgIn.TabIndex = 69
        '
        'colType
        '
        Me.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        Me.colType.Width = 82
        '
        'Stock_Code
        '
        Me.Stock_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Stock_Code.HeaderText = "Stock Code"
        Me.Stock_Code.Name = "Stock_Code"
        Me.Stock_Code.Width = 142
        '
        'Desc
        '
        Me.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Desc.HeaderText = "Description"
        Me.Desc.Name = "Desc"
        Me.Desc.Width = 137
        '
        'Exp_Date
        '
        Me.Exp_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Exp_Date.HeaderText = "Expiry Date"
        Me.Exp_Date.Name = "Exp_Date"
        Me.Exp_Date.Width = 141
        '
        'Lot_No
        '
        Me.Lot_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Lot_No.HeaderText = "Lot No"
        Me.Lot_No.Name = "Lot_No"
        Me.Lot_No.Width = 97
        '
        'colOn
        '
        Me.colOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colOn.HeaderText = "On Hand"
        Me.colOn.Name = "colOn"
        Me.colOn.Width = 116
        '
        'colAge
        '
        Me.colAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colAge.HeaderText = "Agent"
        Me.colAge.Name = "colAge"
        Me.colAge.Width = 90
        '
        'phyCou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1472, 644)
        Me.Controls.Add(Me.dtgIn)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "phyCou"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "prodAdd"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLot As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCountNo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtEdit As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents cmbExpiry As ComboBox
    Friend WithEvents cmbDes As ComboBox
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dtgIn As DataGridView
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Code As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents Exp_Date As DataGridViewTextBoxColumn
    Friend WithEvents Lot_No As DataGridViewTextBoxColumn
    Friend WithEvents colOn As DataGridViewTextBoxColumn
    Friend WithEvents colAge As DataGridViewTextBoxColumn
    Friend WithEvents txtStockCo As TextBox
    Friend WithEvents btnFind As PictureBox
End Class
