<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clients
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.cmbCate = New System.Windows.Forms.ComboBox()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dataClient = New System.Windows.Forms.DataGridView()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTable = New GenacePharma.clientTable()
        Me.ClientsTableAdapter = New GenacePharma.clientTableTableAdapters.ClientsTableAdapter()
        Me.btnDel = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        CType(Me.dataClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Olive
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 59)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "CLIENTS"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(498, 90)
        Me.Splitter1.TabIndex = 20
        Me.Splitter1.TabStop = False
        '
        'cmbCate
        '
        Me.cmbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCate.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCate.FormattingEnabled = True
        Me.cmbCate.Location = New System.Drawing.Point(12, 101)
        Me.cmbCate.Name = "cmbCate"
        Me.cmbCate.Size = New System.Drawing.Size(194, 27)
        Me.cmbCate.TabIndex = 22
        '
        'txtfind
        '
        Me.txtfind.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfind.Location = New System.Drawing.Point(12, 143)
        Me.txtfind.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(194, 28)
        Me.txtfind.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(449, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dataClient
        '
        Me.dataClient.AutoGenerateColumns = False
        Me.dataClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataClient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataClient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.ClientNameDataGridViewTextBoxColumn})
        Me.dataClient.DataSource = Me.ClientsBindingSource
        Me.dataClient.Location = New System.Drawing.Point(12, 186)
        Me.dataClient.Name = "dataClient"
        Me.dataClient.RowHeadersWidth = 25
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dataClient.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataClient.RowTemplate.Height = 24
        Me.dataClient.Size = New System.Drawing.Size(474, 481)
        Me.dataClient.TabIndex = 27
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "Client ID"
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        '
        'ClientNameDataGridViewTextBoxColumn
        '
        Me.ClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name"
        Me.ClientNameDataGridViewTextBoxColumn.HeaderText = "Client Name"
        Me.ClientNameDataGridViewTextBoxColumn.Name = "ClientNameDataGridViewTextBoxColumn"
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.ClientTable
        '
        'ClientTable
        '
        Me.ClientTable.DataSetName = "clientTable"
        Me.ClientTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Image = Global.GenacePharma.My.Resources.Resources.ekis
        Me.btnDel.Location = New System.Drawing.Point(416, 101)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 70)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDel.TabIndex = 25
        Me.btnDel.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.GenacePharma.My.Resources.Resources.add_green
        Me.btnAdd.Location = New System.Drawing.Point(327, 101)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 70)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.TabStop = False
        '
        'clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(498, 679)
        Me.Controls.Add(Me.dataClient)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbCate)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "clients"
        CType(Me.dataClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents cmbCate As ComboBox
    Friend WithEvents txtfind As TextBox
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents btnDel As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents dataClient As DataGridView
    Friend WithEvents ClientTable As clientTable
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As clientTableTableAdapters.ClientsTableAdapter
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
