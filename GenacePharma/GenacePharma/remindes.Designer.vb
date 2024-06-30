<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class remindes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(remindes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrinte = New System.Windows.Forms.PictureBox()
        Me.btnPrintu = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtgEx = New System.Windows.Forms.DataGridView()
        Me.dtgSto = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.rtStocks = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnPrinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrintu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgEx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgSto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MistyRose
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SOON TO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    EXPIRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkRed
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MistyRose
        Me.Label2.Location = New System.Drawing.Point(15, 223)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 50)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CRITICAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   STOCKS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnPrinte)
        Me.GroupBox1.Controls.Add(Me.btnPrintu)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(120, 390)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(64, 147)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 28)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 180)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 28)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrinte
        '
        Me.btnPrinte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrinte.Image = Global.GenacePharma.My.Resources.Resources.prient
        Me.btnPrinte.Location = New System.Drawing.Point(28, 302)
        Me.btnPrinte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrinte.Name = "btnPrinte"
        Me.btnPrinte.Size = New System.Drawing.Size(60, 65)
        Me.btnPrinte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPrinte.TabIndex = 61
        Me.btnPrinte.TabStop = False
        '
        'btnPrintu
        '
        Me.btnPrintu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintu.Image = Global.GenacePharma.My.Resources.Resources.prient
        Me.btnPrintu.Location = New System.Drawing.Point(28, 77)
        Me.btnPrintu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrintu.Name = "btnPrintu"
        Me.btnPrintu.Size = New System.Drawing.Size(60, 65)
        Me.btnPrintu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPrintu.TabIndex = 60
        Me.btnPrintu.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkRed
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MistyRose
        Me.Label4.Location = New System.Drawing.Point(16, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LESS THAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   15 STOCKS"
        '
        'dtgEx
        '
        Me.dtgEx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgEx.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgEx.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEx.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEx.Location = New System.Drawing.Point(134, 10)
        Me.dtgEx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtgEx.Name = "dtgEx"
        Me.dtgEx.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgEx.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgEx.RowTemplate.Height = 24
        Me.dtgEx.Size = New System.Drawing.Size(473, 185)
        Me.dtgEx.TabIndex = 5
        '
        'dtgSto
        '
        Me.dtgSto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgSto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgSto.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgSto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSto.Location = New System.Drawing.Point(134, 214)
        Me.dtgSto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtgSto.Name = "dtgSto"
        Me.dtgSto.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSto.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgSto.RowTemplate.Height = 24
        Me.dtgSto.Size = New System.Drawing.Size(473, 185)
        Me.dtgSto.TabIndex = 6
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument2
        '
        '
        'rtStocks
        '
        Me.rtStocks.Location = New System.Drawing.Point(134, 214)
        Me.rtStocks.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtStocks.Name = "rtStocks"
        Me.rtStocks.Size = New System.Drawing.Size(474, 191)
        Me.rtStocks.TabIndex = 7
        Me.rtStocks.Text = ""
        '
        'remindes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 414)
        Me.Controls.Add(Me.rtStocks)
        Me.Controls.Add(Me.dtgSto)
        Me.Controls.Add(Me.dtgEx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "remindes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REMINDERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnPrinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrintu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgEx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgSto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtgEx As DataGridView
    Friend WithEvents dtgSto As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPrintu As PictureBox
    Friend WithEvents btnPrinte As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents rtStocks As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
