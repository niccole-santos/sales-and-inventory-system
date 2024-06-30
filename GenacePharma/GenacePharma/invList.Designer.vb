<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class invList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.cmbCate = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.dtgInv = New System.Windows.Forms.DataGridView()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(517, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 59)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "INVOICE"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(566, 90)
        Me.Splitter1.TabIndex = 37
        Me.Splitter1.TabStop = False
        '
        'cmbCate
        '
        Me.cmbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCate.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCate.FormattingEnabled = True
        Me.cmbCate.Location = New System.Drawing.Point(12, 104)
        Me.cmbCate.Name = "cmbCate"
        Me.cmbCate.Size = New System.Drawing.Size(182, 27)
        Me.cmbCate.TabIndex = 41
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 146)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(182, 28)
        Me.txtSearch.TabIndex = 40
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Image = Global.GenacePharma.My.Resources.Resources.ekis
        Me.btnDel.Location = New System.Drawing.Point(484, 104)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 70)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDel.TabIndex = 46
        Me.btnDel.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.GenacePharma.My.Resources.Resources.add_green
        Me.btnAdd.Location = New System.Drawing.Point(395, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 70)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.TabStop = False
        '
        'dtgInv
        '
        Me.dtgInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgInv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgInv.Location = New System.Drawing.Point(12, 188)
        Me.dtgInv.Name = "dtgInv"
        Me.dtgInv.RowHeadersWidth = 25
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtgInv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgInv.RowTemplate.Height = 24
        Me.dtgInv.Size = New System.Drawing.Size(542, 444)
        Me.dtgInv.TabIndex = 47
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbType.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(12, 146)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(182, 27)
        Me.cmbType.TabIndex = 48
        '
        'invList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(566, 644)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.dtgInv)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbCate)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "invList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "invList"
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents cmbCate As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDel As PictureBox
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents dtgInv As DataGridView
    Friend WithEvents cmbType As ComboBox
End Class
