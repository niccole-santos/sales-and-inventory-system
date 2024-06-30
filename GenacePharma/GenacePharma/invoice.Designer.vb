<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoice
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblInType = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtRebateAmnt = New System.Windows.Forms.TextBox()
        Me.txtRebatePer = New System.Windows.Forms.TextBox()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.lblAgent = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbCliCode = New System.Windows.Forms.ComboBox()
        Me.cmbCliCat = New System.Windows.Forms.ComboBox()
        Me.cmbCliName = New System.Windows.Forms.ComboBox()
        Me.cmbInType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSoNo = New System.Windows.Forms.TextBox()
        Me.dtSO = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtInvoice = New System.Windows.Forms.DateTimePicker()
        Me.txtInNo = New System.Windows.Forms.TextBox()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtFree = New System.Windows.Forms.TextBox()
        Me.lblBran = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.txtReb = New System.Windows.Forms.TextBox()
        Me.txtRebPer = New System.Windows.Forms.TextBox()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.txtLinePer = New System.Windows.Forms.TextBox()
        Me.txtUOM = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.cmbBran = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbItem = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbExpiry = New System.Windows.Forms.ComboBox()
        Me.dtgItems = New System.Windows.Forms.DataGridView()
        Me.Stock_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expiry_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Free = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAmnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAmnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNetAmnt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtBal = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 59)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "INVOICE"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1962, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1942, 90)
        Me.Splitter1.TabIndex = 31
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.lblInType)
        Me.GroupBox1.Controls.Add(Me.txtRemark)
        Me.GroupBox1.Controls.Add(Me.txtRebateAmnt)
        Me.GroupBox1.Controls.Add(Me.txtRebatePer)
        Me.GroupBox1.Controls.Add(Me.cmbArea)
        Me.GroupBox1.Controls.Add(Me.lblAgent)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cmbAgent)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cmbCliCode)
        Me.GroupBox1.Controls.Add(Me.cmbCliCat)
        Me.GroupBox1.Controls.Add(Me.cmbCliName)
        Me.GroupBox1.Controls.Add(Me.cmbInType)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSoNo)
        Me.GroupBox1.Controls.Add(Me.dtSO)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtInvoice)
        Me.GroupBox1.Controls.Add(Me.txtInNo)
        Me.GroupBox1.Controls.Add(Me.lblLoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(37, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 430)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoicing Information"
        '
        'lblInType
        '
        Me.lblInType.AutoSize = True
        Me.lblInType.BackColor = System.Drawing.Color.RosyBrown
        Me.lblInType.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInType.ForeColor = System.Drawing.Color.White
        Me.lblInType.Location = New System.Drawing.Point(308, 120)
        Me.lblInType.Name = "lblInType"
        Me.lblInType.Size = New System.Drawing.Size(0, 22)
        Me.lblInType.TabIndex = 36
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(173, 378)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(664, 29)
        Me.txtRemark.TabIndex = 35
        '
        'txtRebateAmnt
        '
        Me.txtRebateAmnt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRebateAmnt.Location = New System.Drawing.Point(569, 344)
        Me.txtRebateAmnt.Name = "txtRebateAmnt"
        Me.txtRebateAmnt.Size = New System.Drawing.Size(108, 29)
        Me.txtRebateAmnt.TabIndex = 34
        '
        'txtRebatePer
        '
        Me.txtRebatePer.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRebatePer.Location = New System.Drawing.Point(173, 343)
        Me.txtRebatePer.Name = "txtRebatePer"
        Me.txtRebatePer.Size = New System.Drawing.Size(145, 29)
        Me.txtRebatePer.TabIndex = 33
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbArea.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(102, 290)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(145, 29)
        Me.cmbArea.TabIndex = 32
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.BackColor = System.Drawing.Color.RosyBrown
        Me.lblAgent.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgent.ForeColor = System.Drawing.Color.White
        Me.lblAgent.Location = New System.Drawing.Point(269, 260)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(0, 22)
        Me.lblAgent.TabIndex = 30
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(7, 290)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 28)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Area"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(7, 343)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 28)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Rebate %"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.BackColor = System.Drawing.Color.RosyBrown
        Me.lblArea.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.White
        Me.lblArea.Location = New System.Drawing.Point(269, 290)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(0, 22)
        Me.lblArea.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(368, 343)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 28)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Rebate Amount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(7, 378)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 28)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Remarks"
        '
        'cmbAgent
        '
        Me.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAgent.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(102, 256)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(145, 29)
        Me.cmbAgent.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(7, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 28)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Agent"
        '
        'cmbCliCode
        '
        Me.cmbCliCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCliCode.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliCode.FormattingEnabled = True
        Me.cmbCliCode.Location = New System.Drawing.Point(384, 182)
        Me.cmbCliCode.Name = "cmbCliCode"
        Me.cmbCliCode.Size = New System.Drawing.Size(116, 29)
        Me.cmbCliCode.TabIndex = 22
        '
        'cmbCliCat
        '
        Me.cmbCliCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCliCat.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliCat.FormattingEnabled = True
        Me.cmbCliCat.Location = New System.Drawing.Point(256, 182)
        Me.cmbCliCat.Name = "cmbCliCat"
        Me.cmbCliCat.Size = New System.Drawing.Size(122, 29)
        Me.cmbCliCat.TabIndex = 21
        '
        'cmbCliName
        '
        Me.cmbCliName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCliName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliName.FormattingEnabled = True
        Me.cmbCliName.Location = New System.Drawing.Point(506, 182)
        Me.cmbCliName.Name = "cmbCliName"
        Me.cmbCliName.Size = New System.Drawing.Size(352, 29)
        Me.cmbCliName.TabIndex = 20
        '
        'cmbInType
        '
        Me.cmbInType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbInType.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInType.FormattingEnabled = True
        Me.cmbInType.Location = New System.Drawing.Point(189, 115)
        Me.cmbInType.Name = "cmbInType"
        Me.cmbInType.Size = New System.Drawing.Size(94, 29)
        Me.cmbInType.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 28)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Invoice Type"
        '
        'txtSoNo
        '
        Me.txtSoNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSoNo.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoNo.Location = New System.Drawing.Point(145, 78)
        Me.txtSoNo.Name = "txtSoNo"
        Me.txtSoNo.Size = New System.Drawing.Size(108, 29)
        Me.txtSoNo.TabIndex = 16
        '
        'dtSO
        '
        Me.dtSO.CustomFormat = "MMMMdd, yyyy"
        Me.dtSO.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSO.Location = New System.Drawing.Point(578, 77)
        Me.dtSO.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.dtSO.Name = "dtSO"
        Me.dtSO.Size = New System.Drawing.Size(242, 29)
        Me.dtSO.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(360, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "SO Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SO #"
        '
        'dtInvoice
        '
        Me.dtInvoice.CustomFormat = "MMMMdd, yyyy"
        Me.dtInvoice.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInvoice.Location = New System.Drawing.Point(578, 42)
        Me.dtInvoice.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.dtInvoice.Name = "dtInvoice"
        Me.dtInvoice.Size = New System.Drawing.Size(242, 29)
        Me.dtInvoice.TabIndex = 12
        '
        'txtInNo
        '
        Me.txtInNo.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInNo.Location = New System.Drawing.Point(145, 45)
        Me.txtInNo.Name = "txtInNo"
        Me.txtInNo.Size = New System.Drawing.Size(108, 29)
        Me.txtInNo.TabIndex = 3
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.BackColor = System.Drawing.Color.RosyBrown
        Me.lblLoc.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc.ForeColor = System.Drawing.Color.White
        Me.lblLoc.Location = New System.Drawing.Point(268, 216)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(0, 22)
        Me.lblLoc.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Invoice #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Letter Gothic Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Client Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(359, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Invoice Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Controls.Add(Me.txtCost)
        Me.GroupBox2.Controls.Add(Me.txtFree)
        Me.GroupBox2.Controls.Add(Me.lblBran)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnDel)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtLot)
        Me.GroupBox2.Controls.Add(Me.txtReb)
        Me.GroupBox2.Controls.Add(Me.txtRebPer)
        Me.GroupBox2.Controls.Add(Me.txtLine)
        Me.GroupBox2.Controls.Add(Me.txtLinePer)
        Me.GroupBox2.Controls.Add(Me.txtUOM)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtStockCode)
        Me.GroupBox2.Controls.Add(Me.cmbBran)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.cmbItem)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbExpiry)
        Me.GroupBox2.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(37, 573)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(865, 427)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invoicing Items"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(712, 229)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(127, 29)
        Me.txtCost.TabIndex = 60
        '
        'txtFree
        '
        Me.txtFree.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFree.Location = New System.Drawing.Point(495, 229)
        Me.txtFree.Name = "txtFree"
        Me.txtFree.Size = New System.Drawing.Size(76, 29)
        Me.txtFree.TabIndex = 59
        Me.txtFree.Text = "0"
        '
        'lblBran
        '
        Me.lblBran.AutoSize = True
        Me.lblBran.BackColor = System.Drawing.Color.RosyBrown
        Me.lblBran.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBran.ForeColor = System.Drawing.Color.White
        Me.lblBran.Location = New System.Drawing.Point(273, 38)
        Me.lblBran.Name = "lblBran"
        Me.lblBran.Size = New System.Drawing.Size(0, 22)
        Me.lblBran.TabIndex = 58
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LightCoral
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(628, 343)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 50)
        Me.btnEdit.TabIndex = 57
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.LightCoral
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(728, 343)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(94, 50)
        Me.btnDel.TabIndex = 56
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightCoral
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("HelveticaNeueLT Std Med", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(528, 343)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 50)
        Me.btnAdd.TabIndex = 55
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtLot
        '
        Me.txtLot.Enabled = False
        Me.txtLot.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot.Location = New System.Drawing.Point(728, 119)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(127, 29)
        Me.txtLot.TabIndex = 54
        '
        'txtReb
        '
        Me.txtReb.Enabled = False
        Me.txtReb.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReb.Location = New System.Drawing.Point(506, 300)
        Me.txtReb.Name = "txtReb"
        Me.txtReb.Size = New System.Drawing.Size(192, 29)
        Me.txtReb.TabIndex = 53
        '
        'txtRebPer
        '
        Me.txtRebPer.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRebPer.Location = New System.Drawing.Point(139, 297)
        Me.txtRebPer.Name = "txtRebPer"
        Me.txtRebPer.Size = New System.Drawing.Size(76, 29)
        Me.txtRebPer.TabIndex = 52
        Me.txtRebPer.Text = "0"
        '
        'txtLine
        '
        Me.txtLine.Enabled = False
        Me.txtLine.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine.Location = New System.Drawing.Point(506, 263)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(192, 29)
        Me.txtLine.TabIndex = 51
        '
        'txtLinePer
        '
        Me.txtLinePer.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinePer.Location = New System.Drawing.Point(139, 263)
        Me.txtLinePer.Name = "txtLinePer"
        Me.txtLinePer.Size = New System.Drawing.Size(76, 29)
        Me.txtLinePer.TabIndex = 50
        Me.txtLinePer.Text = "0"
        '
        'txtUOM
        '
        Me.txtUOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUOM.Enabled = False
        Me.txtUOM.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUOM.Location = New System.Drawing.Point(81, 162)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(77, 29)
        Me.txtUOM.TabIndex = 33
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(618, 119)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(103, 28)
        Me.Label40.TabIndex = 49
        Me.Label40.Text = "Lot No."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(295, 262)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(155, 28)
        Me.Label39.TabIndex = 48
        Me.Label39.Text = "Line Amount"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Letter Gothic Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(7, 162)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(55, 30)
        Me.Label38.TabIndex = 47
        Me.Label38.Text = "UOM"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(295, 296)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(181, 28)
        Me.Label37.TabIndex = 46
        Me.Label37.Text = "Rebate Amount"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Letter Gothic Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(7, 293)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(125, 30)
        Me.Label36.TabIndex = 45
        Me.Label36.Text = "Rebate %"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Letter Gothic Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(9, 259)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(97, 30)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Line %"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(139, 229)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(76, 29)
        Me.txtQty.TabIndex = 41
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Letter Gothic Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(8, 229)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(125, 30)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "Quantity"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(295, 230)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 28)
        Me.Label33.TabIndex = 39
        Me.Label33.Text = "Free"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(634, 229)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 28)
        Me.Label32.TabIndex = 38
        Me.Label32.Text = "Cost"
        '
        'txtStockCode
        '
        Me.txtStockCode.Enabled = False
        Me.txtStockCode.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockCode.Location = New System.Drawing.Point(164, 119)
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(132, 29)
        Me.txtStockCode.TabIndex = 37
        '
        'cmbBran
        '
        Me.cmbBran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBran.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBran.FormattingEnabled = True
        Me.cmbBran.Location = New System.Drawing.Point(129, 37)
        Me.cmbBran.Name = "cmbBran"
        Me.cmbBran.Size = New System.Drawing.Size(118, 29)
        Me.cmbBran.TabIndex = 18
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Letter Gothic Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(6, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(167, 30)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Description"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Letter Gothic Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(6, 41)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(97, 30)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Branch"
        '
        'cmbItem
        '
        Me.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbItem.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(182, 77)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(664, 29)
        Me.cmbItem.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(304, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 28)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Expiry Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Letter Gothic Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(5, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 30)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Stock Code"
        '
        'cmbExpiry
        '
        Me.cmbExpiry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExpiry.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpiry.FormattingEnabled = True
        Me.cmbExpiry.Location = New System.Drawing.Point(465, 120)
        Me.cmbExpiry.Name = "cmbExpiry"
        Me.cmbExpiry.Size = New System.Drawing.Size(145, 29)
        Me.cmbExpiry.TabIndex = 32
        '
        'dtgItems
        '
        Me.dtgItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Stock_Type, Me.Stock_Code, Me.Expiry_Date, Me.Description, Me.Lot_No, Me.Qty, Me.Free, Me.Cost, Me.UOM, Me.RPer, Me.RAmnt, Me.LPer, Me.LAmnt})
        Me.dtgItems.Location = New System.Drawing.Point(918, 220)
        Me.dtgItems.Name = "dtgItems"
        Me.dtgItems.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgItems.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgItems.RowTemplate.Height = 24
        Me.dtgItems.Size = New System.Drawing.Size(1106, 780)
        Me.dtgItems.TabIndex = 55
        '
        'Stock_Type
        '
        Me.Stock_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Stock_Type.HeaderText = "Stock Type"
        Me.Stock_Type.Name = "Stock_Type"
        Me.Stock_Type.Width = 109
        '
        'Stock_Code
        '
        Me.Stock_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Stock_Code.HeaderText = "Stock Code"
        Me.Stock_Code.Name = "Stock_Code"
        Me.Stock_Code.Width = 113
        '
        'Expiry_Date
        '
        Me.Expiry_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Expiry_Date.HeaderText = "Expiry Date"
        Me.Expiry_Date.Name = "Expiry_Date"
        Me.Expiry_Date.Width = 113
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 121
        '
        'Lot_No
        '
        Me.Lot_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Lot_No.HeaderText = "Lot No"
        Me.Lot_No.Name = "Lot_No"
        Me.Lot_No.Width = 61
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 98
        '
        'Free
        '
        Me.Free.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Free.HeaderText = "Free"
        Me.Free.Name = "Free"
        Me.Free.Width = 72
        '
        'Cost
        '
        Me.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Cost.HeaderText = "Cost"
        Me.Cost.Name = "Cost"
        Me.Cost.Width = 71
        '
        'UOM
        '
        Me.UOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.Width = 74
        '
        'RPer
        '
        Me.RPer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RPer.HeaderText = "Rebate %"
        Me.RPer.Name = "RPer"
        '
        'RAmnt
        '
        Me.RAmnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RAmnt.HeaderText = "Rebate Amount"
        Me.RAmnt.Name = "RAmnt"
        Me.RAmnt.Width = 136
        '
        'LPer
        '
        Me.LPer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LPer.HeaderText = "Line %"
        Me.LPer.Name = "LPer"
        Me.LPer.Width = 69
        '
        'LAmnt
        '
        Me.LAmnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LAmnt.HeaderText = "Line Amount"
        Me.LAmnt.Name = "LAmnt"
        Me.LAmnt.Width = 118
        '
        'txtNetAmnt
        '
        Me.txtNetAmnt.Enabled = False
        Me.txtNetAmnt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetAmnt.Location = New System.Drawing.Point(1094, 170)
        Me.txtNetAmnt.Name = "txtNetAmnt"
        Me.txtNetAmnt.Size = New System.Drawing.Size(145, 29)
        Me.txtNetAmnt.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.DarkGray
        Me.Label13.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(928, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 28)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Net Amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DarkGray
        Me.Label14.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1321, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 28)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Balance"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(1094, 132)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(145, 29)
        Me.txtTotal.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(928, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 28)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkGray
        Me.Label11.Font = New System.Drawing.Font("Letter Gothic Std", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1321, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 28)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(1458, 132)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(145, 29)
        Me.txtDiscount.TabIndex = 56
        '
        'txtBal
        '
        Me.txtBal.Enabled = False
        Me.txtBal.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBal.Location = New System.Drawing.Point(1458, 171)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(145, 29)
        Me.txtBal.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(918, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(733, 100)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.Image = Global.GenacePharma.My.Resources.Resources.check
        Me.btnOk.Location = New System.Drawing.Point(1891, 111)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 80)
        Me.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnOk.TabIndex = 59
        Me.btnOk.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = Global.GenacePharma.My.Resources.Resources.print__2_
        Me.btnPrint.Location = New System.Drawing.Point(1799, 111)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 80)
        Me.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPrint.TabIndex = 58
        Me.btnPrint.TabStop = False
        '
        'invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1942, 1102)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtBal)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.dtgItems)
        Me.Controls.Add(Me.txtNetAmnt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtRebateAmnt As TextBox
    Friend WithEvents txtRebatePer As TextBox
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents lblAgent As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbCliCode As ComboBox
    Friend WithEvents cmbCliCat As ComboBox
    Friend WithEvents cmbCliName As ComboBox
    Friend WithEvents cmbInType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSoNo As TextBox
    Friend WithEvents dtSO As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtInvoice As DateTimePicker
    Friend WithEvents txtInNo As TextBox
    Friend WithEvents lblLoc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtLot As TextBox
    Friend WithEvents txtReb As TextBox
    Friend WithEvents txtRebPer As TextBox
    Friend WithEvents txtLine As TextBox
    Friend WithEvents txtLinePer As TextBox
    Friend WithEvents txtUOM As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents cmbBran As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents cmbItem As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbExpiry As ComboBox
    Friend WithEvents dtgItems As DataGridView
    Friend WithEvents txtNetAmnt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblInType As Label
    Friend WithEvents txtFree As TextBox
    Friend WithEvents lblBran As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtBal As TextBox
    Friend WithEvents btnOk As PictureBox
    Friend WithEvents btnPrint As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Stock_Type As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Code As DataGridViewTextBoxColumn
    Friend WithEvents Expiry_Date As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Lot_No As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Free As DataGridViewTextBoxColumn
    Friend WithEvents Cost As DataGridViewTextBoxColumn
    Friend WithEvents UOM As DataGridViewTextBoxColumn
    Friend WithEvents RPer As DataGridViewTextBoxColumn
    Friend WithEvents RAmnt As DataGridViewTextBoxColumn
    Friend WithEvents LPer As DataGridViewTextBoxColumn
    Friend WithEvents LAmnt As DataGridViewTextBoxColumn
End Class
