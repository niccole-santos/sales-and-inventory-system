Imports System.Data.OleDb
Public Class invoice
    Dim table As New DataTable("Table")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        invList.Show()
        invList.dtgInv.Refresh()
        Me.Close()
    End Sub
    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.Manual
        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With

        cmbCliCat.Items.Add("Dispensing")
        cmbCliCat.Items.Add("Hospital")
        cmbCliCat.Items.Add("Pharmacy")

        txtInNo.Enabled = False
        dtSO.Enabled = False
        cmbCliCode.Enabled = False

        cmbCliCode.SelectedIndex = -1
        cmbCliCat.SelectedIndex = -1
        cmbAgent.SelectedIndex = -1
        cmbArea.SelectedIndex = -1
        cmbBran.SelectedIndex = -1

        lblInType.Text = "-"

        fillInType()

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
                cmbBran.DataSource = dt
                cmbBran.ValueMember = "Branch_ID"
                cmbBran.SelectedIndex = -1
            End Using
        End Using
        dtInvoice.MaxDate = Today()
        dtSO.MaxDate = Today()

        dtInvoice.Value = Now.Date()
        dtSO.Value = Now.Date()

    End Sub
    Sub autonum()
        Dim autono As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Invoice_Number FROM Invoice"
        rdr = cmd.ExecuteReader

        While rdr.Read
            autono = Val(rdr.Item("Invoice_Number").ToString) + 1
        End While

        Select Case Len(Trim(autono))
            Case 1 : txtInNo.Text = "00" + Trim(Str(autono))
            Case 2 : txtInNo.Text = "0" + Trim(Str(autono))
        End Select
        con.Close()
    End Sub
    Private Sub txtBal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBal.KeyPress
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

    Private Sub txtBal_Leave(sender As Object, e As EventArgs) Handles txtBal.Leave
        If txtBal.Text = "" Then
            txtBal.Text = "0.00"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtBal.Text)
            txtBal.Text = dek.ToString("n2")
        End If
    End Sub

    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress
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

    Private Sub txtCost_Leave(sender As Object, e As EventArgs) Handles txtCost.Leave
        If txtCost.Text = "" Then
            txtCost.Text = "0.00"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtCost.Text)
            txtCost.Text = dek.ToString("n2")
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
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

    Private Sub txtDiscount_Leave(sender As Object, e As EventArgs) Handles txtDiscount.Leave
        If txtDiscount.Text = "" Then
            txtDiscount.Text = "0"
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

    Private Sub txtFree_Leave(sender As Object, e As EventArgs) Handles txtFree.Leave
        If txtFree.Text = "" Then
            txtFree.Text = "0"
        End If
    End Sub

    Private Sub txtLine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLine.KeyPress
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

    Private Sub txtLine_Leave(sender As Object, e As EventArgs) Handles txtLine.Leave
        If txtLine.Text = "" Then
            txtLine.Text = "0"
        End If
    End Sub

    Private Sub txtLinePer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLinePer.KeyPress
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

    Private Sub txtLinePer_Leave(sender As Object, e As EventArgs) Handles txtLinePer.Leave
        If txtLinePer.Text = "" Then
            txtLinePer.Text = "0"
        End If

        Dim qtcost As Double
        Dim subtot As Double
        Dim finaltot As Double

        qtcost = FormatCurrency(txtCost.Text * txtQty.Text).Replace("$", "")

        subtot = CInt((Val(qtcost) * Val(txtLinePer.Text)) / 100)
        finaltot = Val(qtcost) - Val(subtot)
        txtLine.Text = FormatCurrency(finaltot).Replace("$", "")
    End Sub

    Private Sub txtNetAmnt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNetAmnt.KeyPress
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

    Private Sub txtNetAmnt_Leave(sender As Object, e As EventArgs) Handles txtNetAmnt.Leave
        If txtNetAmnt.Text = "" Then
            txtNetAmnt.Text = "0.00"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtNetAmnt.Text)
            txtNetAmnt.Text = dek.ToString("n2")
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

    Private Sub txtReb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReb.KeyPress
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

    Private Sub txtReb_Leave(sender As Object, e As EventArgs) Handles txtReb.Leave
        If txtReb.Text = "" Then
            txtReb.Text = "0.00"
        End If
    End Sub

    Private Sub txtRebateAmnt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRebateAmnt.KeyPress
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

    Private Sub txtRebateAmnt_Leave(sender As Object, e As EventArgs) Handles txtRebateAmnt.Leave
        If txtRebateAmnt.Text = "" Then
            txtRebateAmnt.Text = "0.00"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtRebateAmnt.Text)
            txtRebateAmnt.Text = dek.ToString("n2")
        End If
    End Sub
    Private Sub txtRebatePer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRebatePer.KeyPress
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

    Private Sub txtRebatePer_Leave(sender As Object, e As EventArgs) Handles txtRebatePer.Leave
        If txtRebatePer.Text = "" Then
            txtRebatePer.Text = "0"
        End If
    End Sub

    Private Sub txtRebPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRebPer.KeyPress
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

    Private Sub txtRebPer_Leave(sender As Object, e As EventArgs) Handles txtRebPer.Leave
        If txtRebPer.Text = "" Then
            txtRebPer.Text = "0"
        End If
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
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

    Private Sub txtTotal_Leave(sender As Object, e As EventArgs) Handles txtTotal.Leave
        If txtTotal.Text = "" Then
            txtTotal.Text = "0.00"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtTotal.Text)
            txtTotal.Text = dek.ToString("n2")
        End If
    End Sub

    Private Sub txtSoNo_TextChanged(sender As Object, e As EventArgs) Handles txtSoNo.TextChanged
        If txtSoNo.Text = "" Then
            dtSO.Enabled = False
        Else
            dtSO.Enabled = True
        End If
    End Sub

    Private Sub cmbBran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBran.SelectedIndexChanged
        If cmbBran.SelectedIndex = 0 Then
            lblBran.Text = "-"
        Else
            cmd = New OleDbCommand("SELECT Branch_Name FROM Branch WHERE Branch_ID ='" + cmbBran.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim brans As String = dr("Branch_Name").ToString()
                lblBran.Text = brans
            End While
            con.Close()
        End If
        fillItem()
    End Sub

    Private Sub cmbCliCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliCat.SelectedIndexChanged
        If cmbCliCat.SelectedIndex = 0 Then
            fillDis()
            cmbCliCode.Enabled = True
        ElseIf cmbCliCat.SelectedIndex = 1 Then
            fillHos()
            cmbCliCode.Enabled = True
        Else
            fillPhar()
            cmbCliCode.Enabled = True
        End If

    End Sub
    Private Sub fillInType()
        Try
            Dim query As String = ("SELECT Invoice_Type FROM InvoiceType")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbInType.ValueMember = "Invoice_Type"
            cmbInType.DataSource = ds.Tables(0)
            cmbInType.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillDis()
        Try
            Dim query As String = ("SELECT Client_ID FROM Clients WHERE Client_Type= 'Dispensing'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbCliCode.ValueMember = "Client_ID"
            cmbCliCode.DataSource = ds.Tables(0)
            cmbCliCode.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillHos()
        Try
            Dim query As String = ("SELECT Client_ID FROM Clients WHERE Client_Type= 'Hospital'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbCliCode.ValueMember = "Client_ID"
            cmbCliCode.DataSource = ds.Tables(0)
            cmbCliCode.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillPhar()
        Try
            Dim query As String = ("SELECT Client_ID FROM Clients WHERE Client_Type= 'Pharmacy'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbCliCode.ValueMember = "Client_ID"
            cmbCliCode.DataSource = ds.Tables(0)
            cmbCliCode.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillAgee()
        Try
            Dim query As String = ("SELECT DISTINCT Agent_Code FROM Agents")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbAgent.ValueMember = "Agent_Code"
            cmbAgent.DataSource = ds.Tables(0)
            cmbAgent.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillAree()
        Try
            Dim que As String = "SELECT Area_Code FROM Agents WHERE Agent_Code ='" + cmbAgent.Text + "'"
            Dim da As New OleDbDataAdapter(que, con)
            Dim ds As New DataSet

            da.Fill(ds)
            cmbArea.ValueMember = "Area_Code"
            cmbArea.DataSource = ds.Tables(0)
            cmbArea.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Sub diAll()
        cmbCliCode.Enabled = False
    End Sub

    Private Sub cmbInType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInType.SelectedIndexChanged
        If cmbInType.SelectedIndex = -1 Then
            lblInType.Text = "-"
        Else
            cmd = New OleDbCommand("SELECT Invoice_Info FROM InvoiceType WHERE Invoice_Type ='" + cmbInType.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim meh As String = dr("Invoice_Info").ToString()
                lblInType.Text = meh
            End While
            con.Close()
        End If
    End Sub

    Private Sub cmbCliCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliCode.SelectedIndexChanged
        fillAgee()

        If cmbCliCode.SelectedIndex = -1 Then
            cmbCliName.SelectedIndex = -1
            cmbAgent.SelectedIndex = -1
            cmbArea.SelectedIndex = -1

            lblAgent.Text = "-"
            lblArea.Text = "-"

        Else
            con.Close()
            cmd = New OleDbCommand("SELECT Client_Name, Address, Agent_Code, Agent_Name, Area_Code, Area_Name FROM Clients WHERE Client_ID ='" + cmbCliCode.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim meh As String = dr("Client_Name").ToString()
                Dim ad As String = dr("Address").ToString()
                Dim agc As String = dr("Agent_Code").ToString()
                Dim agn As String = dr("Agent_Name").ToString()
                Dim arc As String = dr("Area_Code").ToString()
                Dim arn As String = dr("Area_Name").ToString()

                cmbCliName.Text = meh
                cmbAgent.Text = agc
                lblAgent.Text = agn
                cmbArea.Text = arc
                lblArea.Text = arn
            End While

            con.Close()
        End If
    End Sub
    Private Sub cmbAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        fillAree()

        lblAgent.Text = "-"

        cmd = New OleDbCommand("SELECT Agent_Name FROM Agents WHERE Agent_Code ='" + cmbAgent.Text + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()

        While (dr.Read)
            Dim meh As String = dr("Agent_Name").ToString()
            lblAgent.Text = meh
        End While

        con.Close()

    End Sub
    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArea.SelectedIndexChanged
        lblArea.Text = "-"

        cmd = New OleDbCommand("SELECT Area_Name FROM Agents WHERE Area_Code ='" + cmbArea.Text + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()

        While (dr.Read)
            Dim meh As String = dr("Area_Name").ToString()
            lblArea.Text = meh
        End While

        con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        table.Rows.Add(cmbBran.Text, txtStockCode.Text, cmbExpiry.Text, cmbItem.Text, txtLot.Text, txtQty.Text, txtFree.Text, txtCost.Text, txtUOM.Text, txtRebPer.Text, txtRebateAmnt.Text, txtLinePer.Text, txtLine.Text, cmbAgent.Text)
        dtgItems.DataSource = table
    End Sub
    Private Sub fillItem()
        Try
            Dim query As String = ("SELECT Description FROM Stocks WHERE Stock_Type ='" & cmbBran.Text & "'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbItem.DisplayMember = "Description"
            cmbItem.ValueMember = "Stock_Code"
            cmbItem.DataSource = ds.Tables(0)
            cmbItem.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub cmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItem.SelectedIndexChanged
        If cmbItem.SelectedIndex = -1 Then
            txtStockCode.Text = ""
        Else
            cmd = New OleDbCommand("SELECT Stock_Code FROM Stocks WHERE Description='" + cmbItem.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()

            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()

            While (dr.Read)
                Dim codee As String = dr("Stock_Code").ToString()
                txtStockCode.Text = codee
            End While
            con.Close()
        End If
        fillExp()
    End Sub
    Private Sub fillExp()
        Try
            Dim query As String = ("SELECT Expiry_Date FROM Stocks WHERE Stock_Type ='" + cmbBran.Text + "' AND Stock_Code ='" + txtStockCode.Text + "'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbExpiry.ValueMember = "Expiry_Date"
            cmbExpiry.DataSource = ds.Tables(0)
            cmbExpiry.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbExpiry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpiry.SelectedIndexChanged
        If cmbExpiry.SelectedIndex = -1 Then
            txtLot.Text = ""
            txtUOM.Text = ""
            txtCost.Text = ""
        Else
            cmd = New OleDbCommand("SELECT Lot_No, UOM, COG FROM Stocks WHERE Stock_Type='" + cmbBran.Text + "' AND Stock_Code ='" + txtStockCode.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()

            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()

            While (dr.Read)
                Dim lo As String = dr("Lot_No").ToString()
                Dim uo As String = dr("UOM").ToString()
                Dim cot As String = dr("COG").ToString()

                txtLot.Text = lo
                txtUOM.Text = uo
                txtCost.Text = FormatCurrency(cot).Replace("$", "")

            End While
            con.Close()
        End If
    End Sub
    Private Sub txtQty_Leave(sender As Object, e As EventArgs) Handles txtQty.Leave
        Dim qtycost As Integer
        Dim qt As Integer
        Dim coo As Integer

        qt = txtQty.Text
        coo = txtCost.Text

        qtycost = qt * coo

        txtLine.Text = FormatCurrency(qtycost).Replace("$", "")
        txtReb.Text = FormatCurrency(qtycost).Replace("$", "")
    End Sub
End Class