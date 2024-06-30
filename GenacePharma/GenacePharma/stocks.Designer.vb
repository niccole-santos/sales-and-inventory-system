<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stocks
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtgStockss = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnHandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksTibl = New GenacePharma.StocksTibl()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAdd2 = New System.Windows.Forms.PictureBox()
        Me.dtgPhysical = New System.Windows.Forms.DataGridView()
        Me.PhysicalNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhyCounter = New GenacePharma.PhyCounter()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtgRec = New System.Windows.Forms.DataGridView()
        Me.PhysicalCountTableAdapter = New GenacePharma.PhyCounterTableAdapters.PhysicalCountTableAdapter()
        Me.StocksTableAdapter = New GenacePharma.StocksTiblTableAdapters.StocksTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgStockss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksTibl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.btnAdd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPhysical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhysicalCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhyCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgRec, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(190, 59)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "STOCKS"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(887, 90)
        Me.Splitter1.TabIndex = 34
        Me.Splitter1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(841, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-1, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(879, 711)
        Me.TabControl1.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtgStockss)
        Me.TabPage1.Controls.Add(Me.cmbClass)
        Me.TabPage1.Controls.Add(Me.cmbType)
        Me.TabPage1.Controls.Add(Me.cmbAgent)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmbSearch)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.btnDel)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 37)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(871, 670)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stock List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtgStockss
        '
        Me.dtgStockss.AutoGenerateColumns = False
        Me.dtgStockss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgStockss.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgStockss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStockss.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn, Me.ExpiryDateDataGridViewTextBoxColumn, Me.OnHandDataGridViewTextBoxColumn, Me.SRPDataGridViewTextBoxColumn, Me.AgentNameDataGridViewTextBoxColumn})
        Me.dtgStockss.DataSource = Me.StocksBindingSource
        Me.dtgStockss.Location = New System.Drawing.Point(9, 116)
        Me.dtgStockss.Name = "dtgStockss"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtgStockss.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgStockss.RowTemplate.Height = 24
        Me.dtgStockss.Size = New System.Drawing.Size(851, 539)
        Me.dtgStockss.TabIndex = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Stock_Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Stock Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 158
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 156
        '
        'ExpiryDateDataGridViewTextBoxColumn
        '
        Me.ExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "Expiry_Date"
        Me.ExpiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry Date"
        Me.ExpiryDateDataGridViewTextBoxColumn.Name = "ExpiryDateDataGridViewTextBoxColumn"
        Me.ExpiryDateDataGridViewTextBoxColumn.Width = 154
        '
        'OnHandDataGridViewTextBoxColumn
        '
        Me.OnHandDataGridViewTextBoxColumn.DataPropertyName = "OnHand"
        Me.OnHandDataGridViewTextBoxColumn.HeaderText = "On Hand"
        Me.OnHandDataGridViewTextBoxColumn.Name = "OnHandDataGridViewTextBoxColumn"
        Me.OnHandDataGridViewTextBoxColumn.Width = 133
        '
        'SRPDataGridViewTextBoxColumn
        '
        Me.SRPDataGridViewTextBoxColumn.DataPropertyName = "SRP"
        Me.SRPDataGridViewTextBoxColumn.HeaderText = "SRP"
        Me.SRPDataGridViewTextBoxColumn.Name = "SRPDataGridViewTextBoxColumn"
        Me.SRPDataGridViewTextBoxColumn.Width = 78
        '
        'AgentNameDataGridViewTextBoxColumn
        '
        Me.AgentNameDataGridViewTextBoxColumn.DataPropertyName = "Agent_Name"
        Me.AgentNameDataGridViewTextBoxColumn.HeaderText = "Agent"
        Me.AgentNameDataGridViewTextBoxColumn.Name = "AgentNameDataGridViewTextBoxColumn"
        Me.AgentNameDataGridViewTextBoxColumn.Width = 103
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "Stocks"
        Me.StocksBindingSource.DataSource = Me.StocksTibl
        '
        'StocksTibl
        '
        Me.StocksTibl.DataSetName = "StocksTibl"
        Me.StocksTibl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbClass
        '
        Me.cmbClass.BackColor = System.Drawing.Color.Beige
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClass.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(11, 66)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(161, 27)
        Me.cmbClass.TabIndex = 49
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.Beige
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbType.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(11, 66)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(161, 27)
        Me.cmbType.TabIndex = 48
        '
        'cmbAgent
        '
        Me.cmbAgent.BackColor = System.Drawing.Color.Beige
        Me.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAgent.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(11, 66)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(239, 27)
        Me.cmbAgent.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Search by:"
        '
        'cmbSearch
        '
        Me.cmbSearch.BackColor = System.Drawing.Color.Beige
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSearch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(11, 29)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(239, 27)
        Me.cmbSearch.TabIndex = 46
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(11, 66)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(239, 28)
        Me.txtSearch.TabIndex = 45
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Image = Global.GenacePharma.My.Resources.Resources.ekis
        Me.btnDel.Location = New System.Drawing.Point(790, 23)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 70)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDel.TabIndex = 44
        Me.btnDel.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.GenacePharma.My.Resources.Resources.add_green
        Me.btnAdd.Location = New System.Drawing.Point(701, 23)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 70)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 43
        Me.btnAdd.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(269, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 88)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label4.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Critical Stocks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(16, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "To Expire"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAdd2)
        Me.TabPage2.Controls.Add(Me.dtgPhysical)
        Me.TabPage2.Location = New System.Drawing.Point(4, 37)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(871, 670)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Physical Count"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAdd2
        '
        Me.btnAdd2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd2.Image = Global.GenacePharma.My.Resources.Resources.add_green
        Me.btnAdd2.Location = New System.Drawing.Point(772, 6)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(93, 95)
        Me.btnAdd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd2.TabIndex = 44
        Me.btnAdd2.TabStop = False
        '
        'dtgPhysical
        '
        Me.dtgPhysical.AutoGenerateColumns = False
        Me.dtgPhysical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgPhysical.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgPhysical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPhysical.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PhysicalNoDataGridViewTextBoxColumn, Me.EditDateDataGridViewTextBoxColumn})
        Me.dtgPhysical.DataSource = Me.PhysicalCountBindingSource
        Me.dtgPhysical.Location = New System.Drawing.Point(5, 6)
        Me.dtgPhysical.Name = "dtgPhysical"
        Me.dtgPhysical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtgPhysical.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgPhysical.RowTemplate.Height = 24
        Me.dtgPhysical.Size = New System.Drawing.Size(761, 658)
        Me.dtgPhysical.TabIndex = 0
        '
        'PhysicalNoDataGridViewTextBoxColumn
        '
        Me.PhysicalNoDataGridViewTextBoxColumn.DataPropertyName = "Physical_No"
        Me.PhysicalNoDataGridViewTextBoxColumn.HeaderText = "Physical No"
        Me.PhysicalNoDataGridViewTextBoxColumn.Name = "PhysicalNoDataGridViewTextBoxColumn"
        '
        'EditDateDataGridViewTextBoxColumn
        '
        Me.EditDateDataGridViewTextBoxColumn.DataPropertyName = "Edit_Date"
        Me.EditDateDataGridViewTextBoxColumn.HeaderText = "Edit Date"
        Me.EditDateDataGridViewTextBoxColumn.Name = "EditDateDataGridViewTextBoxColumn"
        '
        'PhysicalCountBindingSource
        '
        Me.PhysicalCountBindingSource.DataMember = "PhysicalCount"
        Me.PhysicalCountBindingSource.DataSource = Me.PhyCounter
        '
        'PhyCounter
        '
        Me.PhyCounter.DataSetName = "PhyCounter"
        Me.PhyCounter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.dtgRec)
        Me.TabPage3.Location = New System.Drawing.Point(4, 37)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(871, 670)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Receiving"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.GenacePharma.My.Resources.Resources.ekis
        Me.PictureBox1.Location = New System.Drawing.Point(778, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.GenacePharma.My.Resources.Resources.add_green
        Me.PictureBox2.Location = New System.Drawing.Point(778, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'dtgRec
        '
        Me.dtgRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgRec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRec.Location = New System.Drawing.Point(9, 9)
        Me.dtgRec.Name = "dtgRec"
        Me.dtgRec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtgRec.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgRec.RowTemplate.Height = 24
        Me.dtgRec.Size = New System.Drawing.Size(746, 648)
        Me.dtgRec.TabIndex = 0
        '
        'PhysicalCountTableAdapter
        '
        Me.PhysicalCountTableAdapter.ClearBeforeFill = True
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(887, 810)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stocks"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtgStockss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksTibl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.btnAdd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPhysical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhysicalCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhyCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Button3 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnDel As PictureBox
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents dtgPhysical As DataGridView
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents dtgProds As DataGridView
    Friend WithEvents btnAdd2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dtgRec As DataGridView
    Friend WithEvents PhyCounter As PhyCounter
    Friend WithEvents PhysicalCountBindingSource As BindingSource
    Friend WithEvents PhysicalCountTableAdapter As PhyCounterTableAdapters.PhysicalCountTableAdapter
    Friend WithEvents PhysicalNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dtgStockss As DataGridView
    Friend WithEvents StocksTibl As StocksTibl
    Friend WithEvents StocksBindingSource As BindingSource
    Friend WithEvents StocksTableAdapter As StocksTiblTableAdapters.StocksTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OnHandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SRPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
