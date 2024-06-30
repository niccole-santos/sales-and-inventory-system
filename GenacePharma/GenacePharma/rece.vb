Imports System.Data.OleDb
Public Class rece
    Dim ind As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        stocks.Show()
        refreshData()
        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT RR, Rec_Date, Supplier_Name FROM [Receiving] ORDER BY [RR]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        stocks.dtgRec.DataSource = dt4
        con.Close()
    End Sub

    Private Sub rece_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRecNo.Enabled = False
        cmbAgent.Visible = False
        txtLot.Enabled = False
        txtUOM.Enabled = False

        If cmbBranch.SelectedIndex = -1 Then
            btnAdd.Enabled = False
        End If


        fillSup()

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
        dtRec.Value = Today()
        dtIn.Value = Today()

        dtRec.Value = Now.Date()
        dtIn.Value = Now.Date()
    End Sub
    Private Sub dropCode()
        Try
            con.Open()
            Dim dtable As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dtable)

            Dim das As New OleDbDataAdapter("SELECT Stock_Code FROM Stocks WHERE Stock_Type ='" + cmbBranch.Text + "' AND Agent_Name ='" + cmbAgent.Text + "'", con)
            das.Fill(dtable)

            Dim ro As DataRow
            txtCode.AutoCompleteCustomSource.Clear()

            For Each ro In dtable.Rows
                txtCode.AutoCompleteCustomSource.Add(ro.Item(0).ToString)
            Next
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub autonum()
        Dim autono As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS RR FROM Receiving"
        rdr = cmd.ExecuteReader

        While rdr.Read
            autono = Val(rdr.Item("RR").ToString) + 1
        End While

        Select Case Len(Trim(autono))
            Case 1 : txtRecNo.Text = "R00" + Trim(Str(autono))
            Case 2 : txtRecNo.Text = "R0" + Trim(Str(autono))
        End Select
        con.Close()
    End Sub
    Private Sub fillSup()
        Try
            Dim query As String = ("SELECT Supplier_ID FROM Suppliers")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbSupplier.DisplayMember = "Supplier_ID"
            cmbSupplier.DataSource = ds.Tables(0)
            cmbSupplier.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillAgent()
        Try
            Dim query As String = ("SELECT DISTINCT Agent_Name FROM Agents")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbAgent.DisplayMember = "Agent_Name"
            cmbAgent.ValueMember = "Agent_Code"
            cmbAgent.DataSource = ds.Tables(0)
            cmbAgent.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Sub disa()
        cmbBranch.Enabled = False
        cmbExpiry.Enabled = False
        txtCode.Enabled = False
        txtFree.Enabled = False
        txtQty.Enabled = False
        cmbDes.Enabled = False
    End Sub
    Private Sub abbe()
        cmbBranch.Enabled = True
        cmbExpiry.Enabled = True
        txtCode.Enabled = True
        txtFree.Enabled = True
        txtQty.Enabled = True
        cmbDes.Enabled = True
    End Sub
    Private Sub fillDesc()
        Try
            Dim query As String = ("SELECT DISTINCT Description FROM Stocks WHERE Stock_Type = '" + cmbBranch.Text + "'" + "AND Agent_Name ='" + cmbAgent.Text + "'")
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
    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        If cmbSupplier.SelectedIndex = -1 Then
            lblSupplier.Text = "-"
            disa()
        Else
            abbe()
            cmd = New OleDbCommand("SELECT Supplier_Name FROM Suppliers WHERE Supplier_ID ='" + cmbSupplier.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim meh As String = dr("Supplier_Name").ToString()
                lblSupplier.Text = meh
            End While
            con.Close()
        End If
    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged
        If cmbBranch.SelectedIndex = -1 Then
            cmbAgent.SelectedIndex = -1
            lblBranch.Text = "-"
        ElseIf cmbBranch.SelectedIndex = 0 Then
            cmbAgent.Visible = True
            fillAgent()
            lblBranch.Text = "-"
        Else
            cmbAgent.Visible = False
            cmbAgent.SelectedIndex = -1
            cmd = New OleDbCommand("SELECT Branch_Name FROM Branch WHERE Branch_ID ='" + cmbBranch.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim meh As String = dr("Branch_Name").ToString()
                lblBranch.Text = meh
            End While
            con.Close()
        End If

        dropCode()
        fillDesc()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim cmd As New OleDbCommand("SELECT Description, UOM, COG FROM Stocks WHERE Stock_Code = @stock_code", con)
        Dim deet = txtCode.Text
        cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = deet

        Dim dad As New OleDbDataAdapter(cmd)
        Dim tablee As New DataTable()

        dad.Fill(tablee)

        If tablee.Rows.Count() > 0 Then
            cmbDes.Text = tablee.Rows(0)(1).ToString()
            txtUOM.Text = tablee.Rows(0)(2).ToString()
            lblCost.Text = tablee.Rows(0)(3).ToString()
        Else
            MessageBox.Show("Product does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbDes.Text = ""
            txtUOM.Text = ""
            lblCost.Text = "-"
        End If
    End Sub

    Private Sub cmbDes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDes.SelectedIndexChanged
        If cmbDes.SelectedIndex = -1 Then
            txtCode.Text = ""
            txtUOM.Text = ""
            lblCost.Text = "-"
        Else
            cmd = New OleDbCommand("SELECT Stock_Code, UOM, COG FROM Stocks WHERE Description ='" + cmbDes.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim agee As String = dr("Stock_Code").ToString()
                Dim uu As String = dr("UOM").ToString()
                Dim coo As String = dr("COG").ToString()
                txtCode.Text = agee
                txtUOM.Text = uu
                lblCost.Text = FormatCurrency(coo).Replace("$", "")
            End While
            con.Close()
        End If
        fillegg()
    End Sub

    Private Sub cmbAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        dropCode()
        fillDesc()
    End Sub
    Private Sub fillegg()
        Try
            Dim query As String = ("SELECT Expiry_Date FROM Stocks WHERE Stock_Type = '" + cmbBranch.Text + "'" + "AND Stock_Code ='" + txtCode.Text + "'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbExpiry.DisplayMember = "Expiry_Date"
            cmbExpiry.ValueMember = "Stock_Type AND Stock_Code"
            cmbExpiry.DataSource = ds.Tables(0)
            cmbExpiry.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbExpiry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpiry.SelectedIndexChanged
        If cmbExpiry.SelectedIndex = -1 Then
            txtLot.Text = ""
        Else
            cmd = New OleDbCommand("SELECT Lot_No FROM Stocks WHERE Description ='" + cmbDes.Text + "' AND Stock_Type ='" + cmbBranch.Text + "' AND Agent_Name ='" + cmbAgent.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim agee As String = dr("Lot_No").ToString()
                txtLot.Text = agee
            End While
            con.Close()
        End If
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

    Private Sub txtFree_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFree.KeyPress
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
    Private Sub adder(colType As String, colAgent As String, colCode As String, colExpiry As String, colDes As String, colLot As String, colQty As String, colFree As String, colCost As String, colUOM As String)
        Dim row As String() = New String(10) {}

        row(0) = colType
        row(1) = colAgent
        row(2) = colCode
        row(3) = colExpiry
        row(4) = colDes
        row(5) = colLot
        row(6) = colQty
        row(7) = colFree
        row(8) = colCost
        row(9) = colUOM

        dtgRev.Rows.Add(row)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        fillAll()

        adder(cmbBranch.Text, cmbAgent.Text, txtCode.Text, cmbExpiry.Text, cmbDes.Text, txtLot.Text, txtQty.Text, txtFree.Text, lblCost.Text, txtUOM.Text)

        cmbBranch.Enabled = False
        cmbAgent.Enabled = False
        burado()
    End Sub
    Private Sub burado()
        txtCode.Text = ""
        btnFind.Enabled = False
        cmbExpiry.SelectedIndex = -1
        cmbDes.SelectedIndex = -1
        txtFree.Clear()
        lblCost.Text = "-"
        txtLot.Text = ""
        txtQty.Text = ""
    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cmd As New OleDbCommand("SELECT Description, UOM, COG FROM Stocks WHERE Stock_Code = @stock_code", con)
            Dim deet = txtCode.Text
            cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = deet

            Dim dad As New OleDbDataAdapter(cmd)
            Dim tablee As New DataTable()

            dad.Fill(tablee)

            If tablee.Rows.Count() > 0 Then
                cmbDes.Text = tablee.Rows(0)(0).ToString()
                txtUOM.Text = tablee.Rows(0)(0).ToString()
                lblCost.Text = tablee.Rows(0)(0).ToString()
            Else
                MessageBox.Show("Product does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDes.Text = ""
                txtUOM.Text = ""
                lblCost.Text = "-"
            End If
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        dtgRev.Rows.RemoveAt(ind)
    End Sub

    Private Sub dtgRev_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRev.CellClick
        ind = e.RowIndex
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As OleDbCommand

        con.Open()

        For i As Integer = 0 To dtgRev.Rows.Count - 2 Step +1
            cmd = New OleDbCommand("INSERT INTO Receiving (RR, Rec_Date, In_Num, In_Date, Supplier_Code, Supplier_Name, Stock_Type, Stock_Code, Description, Expiry_Date, Lot_No, Quantity, Free, Cost, UOM, Agent_Name) values(@rr, @rec_date, @in_num, @in_date, @supplier_code, @supplier_name, @stock_type, @stock_code, @description, @expiry_date, @lot_no, @quantity, @free, @cost, @uom, @agent_name)", con)
            cmd.Parameters.Add("@rr", OleDbType.Char).Value = txtRecNo.Text.Trim()
            cmd.Parameters.Add("@rec_date", OleDbType.Date).Value = DateTime.Parse(dtRec.Text.Trim())
            cmd.Parameters.Add("@in_num", OleDbType.Char).Value = txtInvoiceNo.Text.Trim()
            cmd.Parameters.Add("@in_date", OleDbType.Date).Value = DateTime.Parse(dtIn.Text.Trim())
            cmd.Parameters.Add("@supplier_code", OleDbType.Char).Value = cmbSupplier.Text.Trim()
            cmd.Parameters.Add("@supplier_name", OleDbType.Char).Value = lblSupplier.Text.Trim()
            cmd.Parameters.Add("@stock_type", OleDbType.Char).Value = dtgRev.Rows(i).Cells(0).Value.ToString()
            cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = dtgRev.Rows(i).Cells(2).Value.ToString()
            cmd.Parameters.Add("@description", OleDbType.Char).Value = dtgRev.Rows(i).Cells(4).Value.ToString()
            cmd.Parameters.Add("@expiry_date", OleDbType.Date).Value = DateTime.Parse(dtgRev.Rows(i).Cells(3).Value.ToString())
            cmd.Parameters.Add("@lot_no", OleDbType.Char).Value = dtgRev.Rows(i).Cells(5).Value.ToString()
            cmd.Parameters.Add("@quantity", OleDbType.Integer).Value = Integer.Parse(dtgRev.Rows(i).Cells(6).Value.ToString())
            cmd.Parameters.Add("@free", OleDbType.Integer).Value = Integer.Parse(dtgRev.Rows(i).Cells(7).Value.ToString())
            cmd.Parameters.Add("@cost", OleDbType.Currency).Value = Integer.Parse(dtgRev.Rows(i).Cells(8).Value.ToString())
            cmd.Parameters.Add("@uom", OleDbType.Char).Value = dtgRev.Rows(i).Cells(9).Value.ToString()
            cmd.Parameters.Add("@agent_name", OleDbType.Char).Value = dtgRev.Rows(i).Cells(1).Value.ToString()

            cmd.ExecuteNonQuery()
        Next
        con.Close()
        MessageBox.Show("Record successfully saved.", "Genace Pharma Distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)

        dtIn.Value = Now.Date()
        dtRec.Value = Now.Date()
        dtgRev.Rows.Clear()
        cmbBranch.SelectedIndex = -1
        cmbAgent.SelectedIndex = -1
        txtCode.Text = ""
        cmbDes.Text = ""
        cmbExpiry.Text = ""
        txtLot.Text = ""
        txtQty.Text = ""
        cmbSupplier.SelectedIndex = -1
        lblSupplier.Text = "-"
        txtFree.Text = ""
        lblCost.Text = "-"
        lblBranch.Text = "-"
        txtUOM.Text = ""
        txtInvoiceNo.Text = ""
    End Sub
    Private Sub fillAll()
        If txtCode.Text = "" Then
            MessageBox.Show("Please enter stock code.", "Genace Pharma Distributor")
            btnAdd.Enabled = False
        ElseIf cmbExpiry.Text = "" Then
            MessageBox.Show("Please select an expiration date.", "Genace Pharma Distributor")
            btnAdd.Enabled = False
        ElseIf cmbDes.Text = "" Then
            MessageBox.Show("Please select stock description.", "Genace Pharma Distributor")
            btnAdd.Enabled = False
        ElseIf txtQty.Text = "" Then
            MessageBox.Show("Please enter quantity of product.", "Genace Pharma Distributor")
            btnAdd.Enabled = False
        ElseIf txtFree.Text = "" Then
            MessageBox.Show("Please enter number of free products.", "Genace Pharma Distributor")
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub
End Class