Imports System.Data.OleDb
Public Class phyCou
    Dim ind As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        stocks.Show()
        refreshData()
        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [PhysicalCount] ORDER BY [Edit_Date]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        stocks.dtgPhysical.DataSource = dt4
        con.Close()
    End Sub
    Private Sub dropCode()
        Try
            con.Open()
            Dim dtable As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dtable)

            Dim das As New OleDbDataAdapter("SELECT Stock_Code FROM Stocks WHERE Stock_Type= '" + cmbBranch.Text + "'", con)
            das.Fill(dtable)

            Dim ro As DataRow
            txtStockCo.AutoCompleteCustomSource.Clear()

            For Each ro In dtable.Rows
                txtStockCo.AutoCompleteCustomSource.Add(ro.Item(0).ToString)
            Next
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub phyCou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        fillegg()

        txtStockCo.Enabled = False
        txtCountNo.Enabled = False
        txtLot.Enabled = False

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
                cmbBranch.DataSource = dt
                cmbBranch.ValueMember = "Branch_ID"
                cmbBranch.SelectedIndex = -1
            End Using
        End Using

        dtEdit.MaxDate = Today()
        dtEdit.Value = Now.Date()

    End Sub
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = "-" Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub FillCombo()
        Try
            Dim fillme As New OleDb.OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb")
            Dim query As String = ("SELECT DISTINCT Agent_Name FROM Agents")
            Dim da As New OleDb.OleDbDataAdapter(query, fillme)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbAgent.ValueMember = "Agent_Name"
            cmbAgent.DataSource = ds.Tables(0)
            cmbAgent.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillItem()
        Try
            Dim query As String = ("SELECT DISTINCT Description FROM Stocks WHERE Stock_Type = '" + cmbBranch.Text + "' AND Agent_Name = '" + cmbAgent.Text + "'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbDes.DisplayMember = "Description"
            cmbDes.ValueMember = "Stock_Type"
            cmbDes.DataSource = ds.Tables(0)
            cmbDes.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillegg()
        Try
            Dim query As String = ("SELECT Lot_No FROM Stocks WHERE Stock_Type = '" + cmbBranch.Text + "' AND Agent_Name ='" + cmbAgent.Text + "' AND Stock_Code ='" + txtStockCo.Text + "'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbExpiry.DisplayMember = "Lot_No"
            cmbExpiry.ValueMember = "Stock_Type AND Stock_Code"
            cmbExpiry.DataSource = ds.Tables(0)
            cmbExpiry.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub adder(colType As String, Stock_Code As String, Des As String, Exp_Date As String, Lot_No As String, colOn As String, colAge As String)
        Dim row As String() = New String(7) {}

        row(0) = colType
        row(1) = Stock_Code
        row(2) = Des
        row(3) = Exp_Date
        row(4) = Lot_No
        row(5) = colOn
        row(6) = colAge

        dtgIn.Rows.Add(row)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        adder(cmbBranch.Text, txtStockCo.Text, cmbDes.Text, cmbExpiry.Text, txtLot.Text, txtQty.Text, cmbAgent.Text)

        burado()
    End Sub
    Private Sub burado()
        txtStockCo.Text = ""
        btnFind.Enabled = False
        cmbExpiry.SelectedIndex = -1
        cmbDes.SelectedIndex = -1
        txtLot.Text = ""
        txtQty.Text = ""
    End Sub
    Sub autonum()
        Dim autono As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(Physical_No) AS Physical_No FROM PhysicalCount GROUP BY Physical_No"
        rdr = cmd.ExecuteReader

        While rdr.Read
            autono = Val(rdr.Item("Physical_No").ToString) + 1
        End While

        Select Case Len(Trim(autono))
            Case 1 : txtCountNo.Text = "P000" + Trim(Str(autono))
            Case 2 : txtCountNo.Text = "P00" + Trim(Str(autono))
            Case 3 : txtCountNo.Text = "P0" + Trim(Str(autono))
        End Select
        con.Close()
    End Sub
    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged
        txtLot.Text = ""
        cmbAgent.Text = "-"

        If cmbBranch.SelectedIndex = 0 Then
            cmbAgent.Enabled = True

            txtStockCo.Enabled = True
            btnFind.Enabled = True
            cmbDes.Enabled = True

            txtStockCo.Clear()
            cmbDes.SelectedIndex = -1
            cmbExpiry.SelectedIndex = -1

        Else
            cmbAgent.SelectedIndex = -1
            cmbAgent.Enabled = False

            txtStockCo.Enabled = True
            btnFind.Enabled = True
            cmbDes.Enabled = True

            txtStockCo.Clear()
            cmbDes.SelectedIndex = -1
            cmbExpiry.SelectedIndex = -1
        End If

        dropCode()
        fillItem()
    End Sub
    Private Sub cmbAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        fillItem()
        cmbDes.SelectedIndex = -1
        txtLot.Text = ""
        If cmbAgent.SelectedIndex = -1 Then
            cmbAgent.Text = "-"
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        dtgIn.Rows.RemoveAt(ind)
    End Sub
    Private Sub dtgIn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgIn.CellClick
        ind = e.RowIndex
    End Sub

    Private Sub cmbDes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDes.SelectedIndexChanged
        txtLot.Text = ""

        If cmbDes.SelectedIndex = -1 Then
            txtStockCo.Text = ""
        Else
            con.Close()
            cmd = New OleDbCommand("SELECT Stock_Code FROM Stocks WHERE Description ='" + cmbDes.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim agee As String = dr("Stock_Code").ToString()
                txtStockCo.Text = agee
            End While
            con.Close()
        End If

        fillegg()
    End Sub
    Private Sub cmbExpiry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpiry.SelectedIndexChanged
        If cmbExpiry.SelectedIndex = -1 Then
            txtLot.Text = ""
        Else
            con.Close()
            cmd = New OleDbCommand("SELECT Expiry_Date FROM Stocks WHERE Description ='" + cmbDes.Text + "' AND Stock_Type ='" +
                                   cmbBranch.Text + "' AND Agent_Name ='" + cmbAgent.Text + "' AND Lot_No ='" + cmbExpiry.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim agee As String = dr("Expiry_Date").ToString()
                txtLot.Text = Date.Parse(agee)
            End While
            con.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As OleDbCommand

        con.Open()

        For i As Integer = 0 To dtgIn.Rows.Count - 2 Step +1
            cmd = New OleDbCommand("INSERT INTO PhysicalCount (Physical_No, Stock_Type, Stock_Code, Description, Expiry_Date, Edit_Date, Lot_No, On_Hand, Agent_Name) values(@physical_no, @stock_type, @stock_code, @description, @expiry_date, @edit_date, @lot_no, @on_hand, @agent_name)", con)
            cmd.Parameters.Add("@physical_no", OleDbType.Char).Value = txtCountNo.Text.Trim()
            cmd.Parameters.Add("stock_type", OleDbType.Char).Value = dtgIn.Rows(i).Cells(0).Value.ToString()
            cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = dtgIn.Rows(i).Cells(1).Value.ToString()
            cmd.Parameters.Add("@description", OleDbType.Char).Value = dtgIn.Rows(i).Cells(2).Value.ToString()
            cmd.Parameters.Add("@expiry_date", OleDbType.Date).Value = DateTime.Parse(dtgIn.Rows(i).Cells(3).Value.ToString())
            cmd.Parameters.Add("@edit_date", OleDbType.Date).Value = DateTime.Parse(dtEdit.Text.Trim())
            cmd.Parameters.Add("@lot_no", OleDbType.Char).Value = dtgIn.Rows(i).Cells(4).Value.ToString
            cmd.Parameters.Add("@on_hand", OleDbType.Integer).Value = Integer.Parse(dtgIn.Rows(i).Cells(5).Value.ToString())
            cmd.Parameters.Add("@agent_name", OleDbType.Char).Value = dtgIn.Rows(i).Cells(6).Value.ToString()

            cmd.ExecuteNonQuery()
        Next
        con.Close()
        MessageBox.Show("Record successfully saved.", "Genace Pharma Distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)

        dtEdit.Value = Now.Date()
        dtgIn.Rows.Clear()
        cmbBranch.SelectedIndex = -1
        cmbAgent.SelectedIndex = -1
        txtStockCo.Text = ""
        cmbDes.Text = ""
        cmbExpiry.Text = ""
        txtLot.Text = ""
        txtQty.Text = ""

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim cmd As New OleDbCommand("SELECT Description FROM Stocks WHERE Stock_Code = @stock_code", con)
        Dim deet = txtStockCo.Text
        cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = deet

        Dim dad As New OleDbDataAdapter(cmd)
        Dim tablee As New DataTable()

        dad.Fill(tablee)

        If tablee.Rows.Count() > 0 Then
            cmbDes.Text = tablee.Rows(0)(0).ToString()
        Else
            MessageBox.Show("Product does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbDes.Text = ""
        End If
    End Sub

    Private Sub txtStockCo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStockCo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cmd As New OleDbCommand("SELECT Description FROM Stocks WHERE Stock_Code = @stock_code", con)
            Dim deet = txtStockCo.Text
            cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = deet

            Dim dad As New OleDbDataAdapter(cmd)
            Dim tablee As New DataTable()

            dad.Fill(tablee)

            If tablee.Rows.Count() > 0 Then
                cmbDes.Text = tablee.Rows(0)(0).ToString()
            Else
                MessageBox.Show("Product does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDes.Text = ""
            End If
        End If
    End Sub
End Class