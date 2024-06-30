Imports System.Data.OleDb
Public Class stoAdd
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        stocks.Show()
        refreshData()

        stocks.RowsOn()
        stocks.RowsExp()

        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Stocks] ORDER BY [Stock_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        stocks.dtgStockss.DataSource = dt4
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Stocks (Stock_Code, Expiry_Date, Description, UOM, COG, SRP, OnHand, ReOrderLvl, Lot_No, Stock_Type, Stock_Classification, Agent_Name) values("
            Str += """" & txtCat.Text.Trim() + txtCode.Text.Trim() & """"
            Str += ","
            Str += """" & dtExpiry.Text.Trim() & """"
            Str += ","
            Str += """" & txtDesc.Text.Trim() & """"
            Str += ","
            Str += """" & txtUOM.Text.Trim() & """"
            Str += ","
            Str += """" & txtCOG.Text.Trim() & """"
            Str += ","
            Str += """" & txtSRP.Text.Trim() & """"
            Str += ","
            Str += """" & txtQty.Text.Trim() & """"
            Str += ","
            Str += """" & txtReO.Text.Trim() & """"
            Str += ","
            Str += """" & txtLot.Text.Trim() & """"
            Str += ","
            Str += """" & cmbBran.Text.Trim() & """"
            Str += ","
            Str += """" & cmbClass.Text.Trim() & """"
            Str += ","
            Str += """" & cmbAgent.Text.Trim() & """"
            Str += ")"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Stocks ORDER BY Stock_Code", con)
            dad.Fill(dst, "Stocks")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            con.Close()

            cmbBran.SelectedIndex = -1
            cmbAgent.SelectedIndex = -1
            txtDesc.Text = ""
            txtUOM.Text = ""
            txtCOG.Text = ""
            txtSRP.Text = ""
            txtReO.Text = ""
            txtLot.Text = ""
            txtQty.Text = ""
            dtExpiry.Text = ""
            txtCat.Clear()
            txtCode.Clear()
            cmbClass.SelectedIndex = -1

            RadioButton1.Checked = False
            RadioButton2.Checked = False

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
        con.Close()
    End Sub
    Private Sub txtCOG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCOG.KeyPress
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

    Private Sub txtReO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReO.KeyPress
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

    Private Sub txtSRP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSRP.KeyPress
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

    Private Sub stoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbClass.Items.Add("Galenicals-A")
        Me.cmbClass.Items.Add("Galenicals-B")
        Me.cmbClass.Items.Add("Ethicals")
        Me.cmbClass.Items.Add("Onco")

        btnFind.Visible = False
        txtCode.Enabled = False
        txtCode.Text = ""
        txtReO.Text = "0"

        cmbClass.Enabled = False
        notAble()

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

    End Sub
    Private Sub txtCOG_Leave(sender As Object, e As EventArgs) Handles txtCOG.Leave
        If txtCOG.Text = "" Then
            txtCOG.Text = "0.00"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtCOG.Text)
            txtCOG.Text = dek.ToString("n2")
        End If
    End Sub
    Private Sub txtSRP_Leave(sender As Object, e As EventArgs) Handles txtSRP.Leave
        If txtSRP.Text = "" Then
            txtSRP.Text = "0.00"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtSRP.Text)
            txtSRP.Text = dek.ToString("n2")
        End If
    End Sub
    Sub autonumA()
        Dim autoCode As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Stock_Code FROM Stocks WHERE Stock_Classification = 'Galenicals-A'"
        Dim rdr As OleDbDataReader
        rdr = cmd.ExecuteReader
        While rdr.Read
            autoCode = Val(rdr.Item("Stock_Code").ToString) + 1
        End While
        Select Case Len(Trim(autoCode))
            Case 1 : txtCode.Text = "0000" + Trim(Str(autoCode))
            Case 2 : txtCode.Text = "000" + Trim(Str(autoCode))
            Case 3 : txtCode.Text = "00" + Trim(Str(autoCode))
            Case 4 : txtCode.Text = "0" + Trim(Str(autoCode))
        End Select
        con.Close()
    End Sub
    Sub autonumB()
        Dim autoCode As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Stock_Code FROM Stocks WHERE Stock_Classification = 'Galenicals-B'"
        Dim rdr As OleDbDataReader
        rdr = cmd.ExecuteReader
        While rdr.Read
            autoCode = Val(rdr.Item("Stock_Code").ToString) + 1
        End While
        Select Case Len(Trim(autoCode))
            Case 1 : txtCode.Text = "0000" + Trim(Str(autoCode))
            Case 2 : txtCode.Text = "000" + Trim(Str(autoCode))
            Case 3 : txtCode.Text = "00" + Trim(Str(autoCode))
            Case 4 : txtCode.Text = "0" + Trim(Str(autoCode))
        End Select
        con.Close()
    End Sub
    Sub autonumC()
        Dim autoCode As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Stock_Code FROM Stocks WHERE Stock_Classification = 'Ethicals'"
        Dim rdr As OleDbDataReader
        rdr = cmd.ExecuteReader
        While rdr.Read
            autoCode = Val(rdr.Item("Stock_Code").ToString) + 1
        End While
        Select Case Len(Trim(autoCode))
            Case 1 : txtCode.Text = "0000" + Trim(Str(autoCode))
            Case 2 : txtCode.Text = "000" + Trim(Str(autoCode))
            Case 3 : txtCode.Text = "00" + Trim(Str(autoCode))
            Case 4 : txtCode.Text = "0" + Trim(Str(autoCode))
        End Select
        con.Close()
    End Sub

    Sub autonumD()
        Dim autoCode As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Stock_Code FROM Stocks WHERE Stock_Classification = 'Onco'"
        Dim rdr As OleDbDataReader
        rdr = cmd.ExecuteReader
        While rdr.Read
            autoCode = Val(rdr.Item("Stock_Code").ToString) + 1
        End While
        Select Case Len(Trim(autoCode))
            Case 1 : txtCode.Text = "0000" + Trim(Str(autoCode))
            Case 2 : txtCode.Text = "000" + Trim(Str(autoCode))
            Case 3 : txtCode.Text = "00" + Trim(Str(autoCode))
            Case 4 : txtCode.Text = "0" + Trim(Str(autoCode))
        End Select
        con.Close()
    End Sub
    Private Sub cmbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClass.SelectedIndexChanged
        If Me.cmbClass.SelectedIndex = 0 Then
            autonumA()
            txtCat.Text = "0701A"
            txtCode.Focus()

            cmbBran.Enabled = True
            txtDesc.Enabled = True
            txtUOM.Enabled = True
            txtCOG.Enabled = True
            txtSRP.Enabled = True
            txtReO.Enabled = True
            txtLot.Enabled = True
            dtExpiry.Enabled = True

        ElseIf cmbClass.SelectedIndex = 1 Then
            autonumB()
            txtCat.Text = "0701B"
            txtCode.Focus()

            cmbBran.Enabled = True
            txtDesc.Enabled = True
            txtUOM.Enabled = True
            txtCOG.Enabled = True
            txtSRP.Enabled = True
            txtReO.Enabled = True
            txtLot.Enabled = True
            dtExpiry.Enabled = True

        ElseIf cmbClass.SelectedIndex = 2 Then
            autonumC()
            txtCat.Text = "0702"
            txtCode.Focus()

            cmbBran.Enabled = True
            txtDesc.Enabled = True
            txtUOM.Enabled = True
            txtCOG.Enabled = True
            txtSRP.Enabled = True
            txtReO.Enabled = True
            txtLot.Enabled = True
            dtExpiry.Enabled = True

        Else
            autonumD()
            txtCat.Text = "0703"
            txtCode.Focus()

            cmbBran.Enabled = True
            txtDesc.Enabled = True
            txtUOM.Enabled = True
            txtCOG.Enabled = True
            txtSRP.Enabled = True
            txtReO.Enabled = True
            txtLot.Enabled = True
            dtExpiry.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        notAble()

        btnFind.Visible = False
        txtCode.Enabled = False
        btnFind.Enabled = False

        cmbClass.Enabled = True

        txtDesc.Text = ""
        txtUOM.Text = ""
        txtCOG.Text = ""
        txtSRP.Text = ""
        txtReO.Text = "0"
        txtLot.Text = ""
        txtQty.Text = "0"
        dtExpiry.Text = ""
        txtCat.Clear()
        txtCode.Clear()
        cmbClass.SelectedIndex = -1
        cmbBran.SelectedIndex = -1
        cmbAgent.SelectedIndex = -1

        FillBoxAge()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        notAble()

        btnFind.Visible = True
        txtCode.Enabled = True
        btnFind.Enabled = True

        cmbClass.Enabled = True

        txtDesc.Text = ""
        txtUOM.Text = ""
        txtCOG.Text = ""
        txtSRP.Text = ""
        txtReO.Text = "0"
        txtLot.Text = ""
        txtQty.Text = "0"
        dtExpiry.Text = ""
        txtCat.Clear()
        txtCode.Clear()
        cmbClass.SelectedIndex = -1
        cmbBran.SelectedIndex = -1
        cmbAgent.SelectedIndex = -1

        If cmbClass.SelectedIndex = 0 Then
            txtCode.Text = ""
        Else
            txtCode.Text = ""
        End If

        FillBoxAge()
    End Sub
    Private Sub txtReO_Click(sender As Object, e As EventArgs) Handles txtReO.Click
        txtReO.Text = ""
    End Sub
    Private Sub txtCode_Click(sender As Object, e As EventArgs) Handles txtCode.Click
        txtCode.Text = ""
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs)
        Dim con As New OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb")
        Dim cmd As New OleDbCommand("SELECT Description FROM Stocks WHERE Stock_Code = @stock_code", con)
        Dim coder = txtCat.Text + txtCode.Text
        cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = coder

        Dim dad As New OleDbDataAdapter(cmd)
        Dim tablee As New DataTable()

        dad.Fill(tablee)

        If tablee.Rows.Count() > 0 Then
            txtDesc.Text = tablee.Rows(0)(0).ToString()
        Else
            MessageBox.Show("Product does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDesc.Text = ""
        End If
    End Sub
    Private Sub FillBoxAge()
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
    Private Sub cmbBran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBran.SelectedIndexChanged
        If cmbBran.SelectedIndex = 0 Then
            cmbAgent.Enabled = True
        Else
            cmbAgent.Enabled = False
            cmbAgent.Text = ""
        End If
    End Sub
    Sub notAble()
        cmbBran.Enabled = False
        cmbAgent.Enabled = False
        txtDesc.Enabled = False
        txtUOM.Enabled = False
        txtCOG.Enabled = False
        txtSRP.Enabled = False
        txtReO.Enabled = False
        txtLot.Enabled = False
        dtExpiry.Enabled = False
    End Sub
    Sub abler()
        cmbBran.Enabled = True
        txtDesc.Enabled = True
        txtUOM.Enabled = True
        txtCOG.Enabled = True
        txtSRP.Enabled = True
        txtReO.Enabled = True
        txtLot.Enabled = True
        dtExpiry.Enabled = True
    End Sub

    Private Sub txtReO_Leave(sender As Object, e As EventArgs) Handles txtReO.Leave
        If txtReO.Text = "" Then
            txtReO.Text = "0"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.Open()
        Dim str As String = "UPDATE Stocks SET uom=?, cog=?, srp=? WHERE stock_type=? AND agent_name=?"
        cmd = New OleDbCommand(str, con)
        cmd.Parameters.AddWithValue("UOM", txtUOM.Text)
        cmd.Parameters.AddWithValue("COG", txtCOG.Text)
        cmd.Parameters.AddWithValue("SRP", txtSRP.Text)
        cmd.Parameters.AddWithValue("Stock_Type", cmbBran.Text)
        cmd.Parameters.AddWithValue("Agent_Name", cmbAgent.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Record has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim con As New OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb")
            Dim cmd As New OleDbCommand("SELECT Description FROM Stocks WHERE Stock_Code = @stock_code", con)
            Dim coder = txtCat.Text + txtCode.Text
            cmd.Parameters.Add("@stock_code", OleDbType.Char).Value = coder

            Dim dad As New OleDbDataAdapter(cmd)
            Dim tablee As New DataTable()

            dad.Fill(tablee)

            If tablee.Rows.Count() > 0 Then
                txtDesc.Text = tablee.Rows(0)(0).ToString()
            Else
                MessageBox.Show("Product does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDesc.Text = ""
            End If
        End If
    End Sub
End Class