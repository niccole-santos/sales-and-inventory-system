<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suppliers
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.dtgSup = New System.Windows.Forms.DataGridView()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTable = New GenacePharma.SuppliersTable()
        Me.btnDel = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.SuppliersTableAdapter = New GenacePharma.SuppliersTableTableAdapters.SuppliersTableAdapter()
        Me.Supplier_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgSup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 118)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(239, 28)
        Me.txtSearch.TabIndex = 25
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
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Olive
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 59)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "SUPPLIERS"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(498, 90)
        Me.Splitter1.TabIndex = 24
        Me.Splitter1.TabStop = False
        '
        'dtgSup
        '
        Me.dtgSup.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Supplier_ID, Me.Supplier_Name})
        Me.dtgSup.DataSource = Me.SuppliersBindingSource
        Me.dtgSup.Location = New System.Drawing.Point(12, 179)
        Me.dtgSup.Name = "dtgSup"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSup.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgSup.RowHeadersWidth = 25
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtgSup.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgSup.RowTemplate.Height = 24
        Me.dtgSup.Size = New System.Drawing.Size(474, 478)
        Me.dtgSup.TabIndex = 27
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.SuppliersTable
        '
        'SuppliersTable
        '
        Me.SuppliersTable.DataSetName = "SuppliersTable"
        Me.SuppliersTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Image = Global.GenacePharma.My.Resources.Resources.ekis
        Me.btnDel.Location = New System.Drawing.Point(416, 96)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 70)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDel.TabIndex = 29
        Me.btnDel.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.GenacePharma.My.Resources.Resources.add_green
        Me.btnAdd.Location = New System.Drawing.Point(340, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 70)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.TabStop = False
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'Supplier_ID
        '
        Me.Supplier_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Supplier_ID.DataPropertyName = "Supplier_ID"
        Me.Supplier_ID.HeaderText = "Supplier ID"
        Me.Supplier_ID.Name = "Supplier_ID"
        Me.Supplier_ID.Width = 136
        '
        'Supplier_Name
        '
        Me.Supplier_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Supplier_Name.DataPropertyName = "Supplier_Name"
        Me.Supplier_Name.HeaderText = "Supplier Name"
        Me.Supplier_Name.Name = "Supplier_Name"
        '
        'suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(498, 668)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtgSup)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "suppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "suppliers"
        CType(Me.dtgSup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents dtgSup As DataGridView
    Friend WithEvents btnDel As PictureBox
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents SuppliersTable As SuppliersTable
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As SuppliersTableTableAdapters.SuppliersTableAdapter
    Friend WithEvents Supplier_ID As DataGridViewTextBoxColumn
    Friend WithEvents Supplier_Name As DataGridViewTextBoxColumn
End Class
