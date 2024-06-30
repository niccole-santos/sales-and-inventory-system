<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rece
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtIn = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtRec = New System.Windows.Forms.DateTimePicker()
        Me.txtRecNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtgRev = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAgent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExpiry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFree = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.txtFree = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUOM = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.cmbExpiry = New System.Windows.Forms.ComboBox()
        Me.cmbDes = New System.Windows.Forms.ComboBox()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgRev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Size = New System.Drawing.Size(247, 59)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "RECEIVING"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1180, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 45)
        Me.Button3.TabIndex = 17
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
        Me.Splitter1.Size = New System.Drawing.Size(1237, 82)
        Me.Splitter1.TabIndex = 19
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.lblSupplier)
        Me.GroupBox1.Controls.Add(Me.cmbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dtIn)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtRec)
        Me.GroupBox1.Controls.Add(Me.txtRecNo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1213, 192)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receiving Information"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = Global.GenacePharma.My.Resources.Resources.check
        Me.btnSave.Location = New System.Drawing.Point(1081, 51)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 98)
        Me.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSave.TabIndex = 69
        Me.btnSave.TabStop = False
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.BackColor = System.Drawing.Color.RosyBrown
        Me.lblSupplier.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.ForeColor = System.Drawing.Color.White
        Me.lblSupplier.Location = New System.Drawing.Point(447, 140)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(0, 19)
        Me.lblSupplier.TabIndex = 34
        '
        'cmbSupplier
        '
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSupplier.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(288, 140)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(131, 27)
        Me.cmbSupplier.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(28, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 28)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Supplier"
        '
        'dtIn
        '
        Me.dtIn.CustomFormat = "MMMM dd, yyyy"
        Me.dtIn.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtIn.Location = New System.Drawing.Point(743, 83)
        Me.dtIn.MaxDate = New Date(2809, 12, 31, 0, 0, 0, 0)
        Me.dtIn.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtIn.Name = "dtIn"
        Me.dtIn.Size = New System.Drawing.Size(247, 27)
        Me.dtIn.TabIndex = 31
        Me.dtIn.Value = New Date(2019, 1, 16, 0, 0, 0, 0)
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(288, 82)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(131, 28)
        Me.txtInvoiceNo.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 28)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Invoice #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(486, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Invoice Date"
        '
        'dtRec
        '
        Me.dtRec.CustomFormat = "MMMM dd, yyyy"
        Me.dtRec.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRec.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRec.Location = New System.Drawing.Point(743, 40)
        Me.dtRec.MaxDate = New Date(2809, 12, 31, 0, 0, 0, 0)
        Me.dtRec.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtRec.Name = "dtRec"
        Me.dtRec.Size = New System.Drawing.Size(247, 27)
        Me.dtRec.TabIndex = 27
        Me.dtRec.Value = New Date(2019, 1, 16, 0, 0, 0, 0)
        '
        'txtRecNo
        '
        Me.txtRecNo.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.Location = New System.Drawing.Point(288, 39)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(131, 28)
        Me.txtRecNo.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(26, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 28)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Receiving #"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(486, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 28)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Receive Date"
        '
        'dtgRev
        '
        Me.dtgRev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgRev.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgRev.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgRev.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRev.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colAgent, Me.colCode, Me.colExpiry, Me.colDes, Me.colLot, Me.colQty, Me.colFree, Me.colCost, Me.colUOM})
        Me.dtgRev.Location = New System.Drawing.Point(663, 286)
        Me.dtgRev.Name = "dtgRev"
        Me.dtgRev.ReadOnly = True
        Me.dtgRev.RowHeadersWidth = 25
        Me.dtgRev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgRev.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgRev.RowTemplate.Height = 24
        Me.dtgRev.Size = New System.Drawing.Size(562, 353)
        Me.dtgRev.TabIndex = 33
        '
        'colType
        '
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 86
        '
        'colAgent
        '
        Me.colAgent.HeaderText = "Agent"
        Me.colAgent.Name = "colAgent"
        Me.colAgent.ReadOnly = True
        Me.colAgent.Width = 93
        '
        'colCode
        '
        Me.colCode.HeaderText = "Stock Code"
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        Me.colCode.Width = 144
        '
        'colExpiry
        '
        Me.colExpiry.HeaderText = "Expiry Date"
        Me.colExpiry.Name = "colExpiry"
        Me.colExpiry.ReadOnly = True
        Me.colExpiry.Width = 141
        '
        'colDes
        '
        Me.colDes.HeaderText = "Description"
        Me.colDes.Name = "colDes"
        Me.colDes.ReadOnly = True
        Me.colDes.Width = 138
        '
        'colLot
        '
        Me.colLot.HeaderText = "Lot No"
        Me.colLot.Name = "colLot"
        Me.colLot.ReadOnly = True
        Me.colLot.Width = 98
        '
        'colQty
        '
        Me.colQty.HeaderText = "Quantity"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 114
        '
        'colFree
        '
        Me.colFree.HeaderText = "Free"
        Me.colFree.Name = "colFree"
        Me.colFree.ReadOnly = True
        Me.colFree.Width = 81
        '
        'colCost
        '
        Me.colCost.HeaderText = "Cost"
        Me.colCost.Name = "colCost"
        Me.colCost.ReadOnly = True
        Me.colCost.Width = 82
        '
        'colUOM
        '
        Me.colUOM.HeaderText = "UOM"
        Me.colUOM.Name = "colUOM"
        Me.colUOM.ReadOnly = True
        Me.colUOM.Width = 88
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.cmbAgent)
        Me.GroupBox3.Controls.Add(Me.btnDel)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.lblCost)
        Me.GroupBox3.Controls.Add(Me.txtLot)
        Me.GroupBox3.Controls.Add(Me.txtFree)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtUOM)
        Me.GroupBox3.Controls.Add(Me.txtQty)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnFind)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.lblBranch)
        Me.GroupBox3.Controls.Add(Me.txtCode)
        Me.GroupBox3.Controls.Add(Me.cmbExpiry)
        Me.GroupBox3.Controls.Add(Me.cmbDes)
        Me.GroupBox3.Controls.Add(Me.cmbBranch)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(645, 353)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receiving Items"
        '
        'cmbAgent
        '
        Me.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAgent.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(313, 35)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(319, 27)
        Me.cmbAgent.TabIndex = 50
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Ivory
        Me.btnDel.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.LightSlateGray
        Me.btnDel.Location = New System.Drawing.Point(519, 308)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(118, 39)
        Me.btnDel.TabIndex = 49
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Ivory
        Me.btnAdd.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 12.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.LightSlateGray
        Me.btnAdd.Location = New System.Drawing.Point(393, 308)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 39)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.BackColor = System.Drawing.Color.RosyBrown
        Me.lblCost.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.White
        Me.lblCost.Location = New System.Drawing.Point(528, 202)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 19)
        Me.lblCost.TabIndex = 47
        '
        'txtLot
        '
        Me.txtLot.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot.Location = New System.Drawing.Point(366, 250)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(167, 28)
        Me.txtLot.TabIndex = 46
        '
        'txtFree
        '
        Me.txtFree.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFree.Location = New System.Drawing.Point(366, 200)
        Me.txtFree.Name = "txtFree"
        Me.txtFree.Size = New System.Drawing.Size(71, 28)
        Me.txtFree.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(236, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 28)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Lot No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(459, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 28)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Cost"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(236, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 28)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Free"
        '
        'txtUOM
        '
        Me.txtUOM.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUOM.Location = New System.Drawing.Point(146, 250)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(71, 28)
        Me.txtUOM.TabIndex = 42
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(146, 200)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(71, 28)
        Me.txtQty.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 28)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "UOM"
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Image = Global.GenacePharma.My.Resources.Resources.searchna
        Me.btnFind.Location = New System.Drawing.Point(297, 74)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(45, 45)
        Me.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFind.TabIndex = 39
        Me.btnFind.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(375, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 28)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Expiry"
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.BackColor = System.Drawing.Color.RosyBrown
        Me.lblBranch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranch.ForeColor = System.Drawing.Color.White
        Me.lblBranch.Location = New System.Drawing.Point(334, 37)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(0, 19)
        Me.lblBranch.TabIndex = 37
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(161, 85)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(127, 28)
        Me.txtCode.TabIndex = 30
        '
        'cmbExpiry
        '
        Me.cmbExpiry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExpiry.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpiry.FormattingEnabled = True
        Me.cmbExpiry.Location = New System.Drawing.Point(477, 84)
        Me.cmbExpiry.Name = "cmbExpiry"
        Me.cmbExpiry.Size = New System.Drawing.Size(149, 27)
        Me.cmbExpiry.TabIndex = 28
        '
        'cmbDes
        '
        Me.cmbDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDes.FormattingEnabled = True
        Me.cmbDes.Location = New System.Drawing.Point(174, 140)
        Me.cmbDes.Name = "cmbDes"
        Me.cmbDes.Size = New System.Drawing.Size(463, 27)
        Me.cmbDes.TabIndex = 27
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBranch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(110, 34)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(177, 27)
        Me.cmbBranch.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(3, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 28)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Quantity"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(2, 140)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(155, 28)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Description"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(2, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 28)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Branch"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(3, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(142, 28)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Stock Code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'rece
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1237, 648)
        Me.Controls.Add(Me.dtgRev)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rece"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rece"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgRev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtIn As DateTimePicker
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtRec As DateTimePicker
    Friend WithEvents txtRecNo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtgRev As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents txtLot As TextBox
    Friend WithEvents txtFree As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUOM As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnFind As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblBranch As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents cmbExpiry As ComboBox
    Friend WithEvents cmbDes As ComboBox
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colAgent As DataGridViewTextBoxColumn
    Friend WithEvents colCode As DataGridViewTextBoxColumn
    Friend WithEvents colExpiry As DataGridViewTextBoxColumn
    Friend WithEvents colDes As DataGridViewTextBoxColumn
    Friend WithEvents colLot As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colFree As DataGridViewTextBoxColumn
    Friend WithEvents colCost As DataGridViewTextBoxColumn
    Friend WithEvents colUOM As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As PictureBox
    Friend WithEvents cmbAgent As ComboBox
End Class
