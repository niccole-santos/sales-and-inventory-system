Imports System.Data.OleDb
Public Class stocks
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homep.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()

        stoAdd.Button2.Visible = False
        stoAdd.Show()
    End Sub

    Private Sub stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StocksTibl.Stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.StocksTibl.Stocks)
        'TODO: This line of code loads data into the 'PhyCounter.PhysicalCount' table. You can move, or remove it, as needed.
        Me.PhysicalCountTableAdapter.Fill(Me.PhyCounter.PhysicalCount)

        'not visible until searched
        cmbAgent.Visible = False
        cmbClass.Visible = False
        cmbType.Visible = False
        txtSearch.Visible = False

        'Search by
        Me.cmbSearch.Items.Add("All")
        Me.cmbSearch.Items.Add("Stock Type")
        Me.cmbSearch.Items.Add("Classification")
        Me.cmbSearch.Items.Add("Agent")

        Me.cmbClass.Items.Add("Galenicals-A")
        Me.cmbClass.Items.Add("Galenicals-B")
        Me.cmbClass.Items.Add("Ethicals")
        Me.cmbClass.Items.Add("Onco")

        Dim constr As String = "PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb"
        Using con As OleDbConnection = New OleDbConnection(constr)
            Using sda As OleDbDataAdapter = New OleDbDataAdapter("SELECT Branch_ID FROM Branch", con)
                'Fill the DataTable with records from Table.
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)

                'Insert the Default Item to DataTable.
                Dim row As DataRow = dt.NewRow()
                row(0) = "Agent"
                dt.Rows.InsertAt(row, 0)

                'Assign DataTable as DataSource.
                cmbType.DataSource = dt
                cmbType.ValueMember = "Branch_ID"
                cmbType.SelectedIndex = -1
            End Using
        End Using

        Dim com As String

        com = "SELECT RR, Rec_Date, Supplier_Name FROM Receiving"
        Dim da As New OleDbDataAdapter(com, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Receiving")
        dtgRec.DataSource = ds.Tables(0)
        Me.dtgRec.Columns(0).HeaderText = "RR No."
        Me.dtgRec.Columns(1).HeaderText = "Receive Date"
        Me.dtgRec.Columns(2).HeaderText = "Supplier"

        RowsOn()
        RowsExp()

    End Sub

    Private Sub dtgStockss_DoubleClick(sender As Object, e As EventArgs) Handles dtgStockss.DoubleClick
        Dim form As New stoAdd
        form.dtExpiry.Text = dtgStockss.CurrentRow.Cells(1).Value.ToString
        form.txtDesc.Text = dtgStockss.CurrentRow.Cells(2).Value.ToString
        form.txtUOM.Text = dtgStockss.CurrentRow.Cells(3).Value.ToString
        form.txtCOG.Text = dtgStockss.CurrentRow.Cells(4).Value.ToString
        form.txtSRP.Text = dtgStockss.CurrentRow.Cells(5).Value.ToString
        form.txtQty.Text = dtgStockss.CurrentRow.Cells(6).Value.ToString
        form.txtReO.Text = dtgStockss.CurrentRow.Cells(7).Value.ToString
        form.txtLot.Text = dtgStockss.CurrentRow.Cells(8).Value.ToString
        form.cmbBran.Text = dtgStockss.CurrentRow.Cells(9).Value.ToString
        form.cmbClass.Text = dtgStockss.CurrentRow.Cells(10).Value.ToString
        form.cmbAgent.Text = dtgStockss.CurrentRow.Cells(11).Value.ToString

        form.ShowDialog()
        form.Button1.Visible = False
        form.txtUOM.Focus()
        form.Button2.Visible = True
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim que As String
        Try
            con.Open()
            For i As Integer = Me.dtgStockss.SelectedRows.Count - 1 To 0 Step -1
                que = "DELETE FROM Stocks WHERE Stock_Code= '" & Me.dtgStockss.SelectedRows(i).Cells(0).Value.ToString() & "'"
                dad = New OleDbDataAdapter(que, con)
                dst = New DataSet()
                dad.Fill(dst)
                Me.dtgStockss.Rows.Remove(Me.dtgStockss.SelectedRows(i))
            Next
            refreshData()
            cmbSearch.SelectedIndex = -1
            txtSearch.Text = ""
            MessageBox.Show("Record has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        RowsOn()
        RowsExp()
    End Sub
    Private Sub refreshData()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Stock_Code, Description, Expiry_Date, OnHand, SRP, Agent_Name FROM [Stocks] ORDER BY [Stock_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgStockss.DataSource = dt4
        con.Close()
    End Sub
    Private Sub refreshData2()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT RR, Rec_Date, Supplier_Name FROM [Receiving] ORDER BY [RR]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgRec.DataSource = dt4
        con.Close()
    End Sub
    Private Sub fillAgee()
        Try
            Dim query As String = ("SELECT DISTINCT Agent_Name FROM Stocks WHERE Len(Agent_Name) > 0")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbAgent.ValueMember = "Agent_Name"
            cmbAgent.DataSource = ds.Tables(0)
            cmbAgent.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter

        If cmbSearch.SelectedIndex = 0 Then
            cmbAgent.Visible = False
            cmbClass.Visible = False
            cmbType.Visible = False
            txtSearch.Visible = True


            cmbType.SelectedIndex = -1
            cmbClass.SelectedIndex = -1
            cmbAgent.SelectedIndex = -1

            RowsOn()
            RowsExp()

        ElseIf cmbSearch.SelectedIndex = 1 Then
            cmbClass.Visible = False
            cmbAgent.Visible = False
            cmbType.Visible = True
            txtSearch.Visible = False

            cmbClass.SelectedIndex = -1
            cmbAgent.SelectedIndex = -1
            txtSearch.Text = ""

            RowsOn()
            RowsExp()

        ElseIf cmbSearch.SelectedIndex = 2 Then
            cmbAgent.Visible = False
            cmbType.Visible = False
            cmbClass.Visible = True
            txtSearch.Visible = False

            cmbType.SelectedIndex = -1
            cmbAgent.SelectedIndex = -1
            txtSearch.Text = ""

            RowsOn()
            RowsExp()

        Else
            fillAgee()

            cmbType.Visible = False
            cmbClass.Visible = False
            cmbAgent.Visible = True
            txtSearch.Visible = False

            cmbType.SelectedIndex = -1
            cmbClass.SelectedIndex = -1
            txtSearch.Text = ""

            RowsOn()
            RowsExp()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        phyCou.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        phyCou.Show()
        phyCou.autonum()
        phyCou.txtStockCo.Enabled = False
        phyCou.btnFind.Enabled = False
        phyCou.cmbDes.Enabled = False
        phyCou.cmbBranch.Text = ""
        phyCou.cmbAgent.Text = ""
        Me.Hide()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter

        con.Open()

        dst.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Stocks WHERE Description LIKE '%" & txtSearch.Text & "%'", con)
        da.Fill(dt)
        dtgStockss.DataSource = dt.DefaultView

        RowsExp()
        RowsOn()

        con.Close()

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter

        con.Open()

        dst.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Stocks WHERE Stock_Type LIKE '%" & cmbType.Text & "%'", con)
        da.Fill(dt)
        dtgStockss.DataSource = dt.DefaultView

        RowsOn()
        RowsExp()

        con.Close()
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClass.SelectedIndexChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter

        con.Open()

        dst.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Stocks WHERE Stock_Classification LIKE '%" & cmbClass.Text & "%'", con)
        da.Fill(dt)
        dtgStockss.DataSource = dt.DefaultView

        RowsExp()
        RowsOn()

        con.Close()
    End Sub

    Private Sub cmbAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter

        con.Open()

        dst.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Stocks WHERE Agent_Name LIKE '%" & cmbAgent.Text & "%'", con)
        da.Fill(dt)
        dtgStockss.DataSource = dt.DefaultView

        RowsOn()
        RowsExp()

        con.Close()
    End Sub
    Public Sub RowsOn()
        For i As Integer = 0 To dtgStockss.Rows.Count() - 1 Step +1
            Dim val As Integer
            val = dtgStockss.Rows(i).Cells(3).Value
            If val < 16 Then
                dtgStockss.Rows(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
                dtgStockss.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
    Public Sub RowsExp()
        For i As Integer = 0 To dtgStockss.Rows.Count() - 1 Step +1
            Dim bal As Date
            bal = dtgStockss.Rows(i).Cells(2).Value
            'If bal <= Date.Today.AddMonths(3).ToString("MM/dd/yyyy") Then
            'dtgStockss.Rows(i).DefaultCellStyle.ForeColor = Color.Maroon
            ' End If
        Next
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        rece.Show()
        rece.disa()
        rece.autonum()
        rece.cmbAgent.Visible = False
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.dtgRec.Rows.Count > 0 Then
            If dtgRec.Rows.Count > 0 Then
                Dim intID As String = Me.dtgRec.SelectedRows(0).Cells("RR").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                    cmd.CommandText = "DELETE FROM [Receiving] WHERE [RR] ='" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                refreshData2()
                con.Close()

            Else
                MessageBox.Show("No record selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class