Imports System.Data.OleDb
Public Class clientAdd
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clients.Show()
        refreshData()

        clients.cmbCate.SelectedIndex = 0
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Clients WHERE Client_Type LIKE '%" & clients.cmbCate.Text & "%'", con)
        da.Fill(dt)

        clients.dataClient.DataSource = dt.DefaultView

        con.Close()

        Me.Close()
    End Sub

    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Clients] ORDER BY [Client_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        clients.dataClient.DataSource = dt4
        con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con.Open()
            Dim str As String = "UPDATE Clients SET Address=?, fax_num=?, phone=?, contact=?, owner=?, agent_code=?, agent_name=?, div_code=?, div_name=?, area_code=?, area_name=?, bfad=?, cred_lim=?, agi_terms=?, iterm=? WHERE cli_id=?"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("Address", txtAd.Text)
            cmd.Parameters.AddWithValue("Fax_Num", txtFax.Text)
            cmd.Parameters.AddWithValue("Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("Contact", txtCon.Text)
            cmd.Parameters.AddWithValue("Owner", txtOwner.Text)
            cmd.Parameters.AddWithValue("Agent_Code", cmbAgent.Text)
            cmd.Parameters.AddWithValue("Agent_Name", lblAge.Text)
            cmd.Parameters.AddWithValue("Div_Code", cmbDiv.Text)
            cmd.Parameters.AddWithValue("Div_Name", lblDiv.Text)
            cmd.Parameters.AddWithValue("Area_Code", cmbArea.Text)
            cmd.Parameters.AddWithValue("Area_Name", lblArea.Text)
            cmd.Parameters.AddWithValue("BFAD", txtBFAD.Text)
            cmd.Parameters.AddWithValue("Credit_Limit", txtCred.Text)
            cmd.Parameters.AddWithValue("Aging_Terms", txtAging.Text)
            cmd.Parameters.AddWithValue("ITerms", txtInvoic.Text)
            cmd.Parameters.AddWithValue("Client_ID", txtCode.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtAging_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAging.KeyPress
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

    Private Sub txtCred_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCred.KeyPress
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

    Private Sub txtFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFax.KeyPress
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

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        Static letra As Char
        If letra = " "c Or txtName.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        letra = e.KeyChar
    End Sub

    Private Sub txtInvoic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvoic.KeyPress
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

    Private Sub txtOwner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOwner.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        Static letra As Char
        If letra = " "c Or txtOwner.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        letra = e.KeyChar
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Clients (Client_ID, Client_Name, Client_Type, Address, Fax_Num, Phone, Contact, Owner, Agent_Code, Agent_Name, Div_Code, Div_Name, Area_Code, Area_Name, BFAD, Credit_Limit, Aging_Terms, ITerms) VALUES ('" & txtCode.Text & "','" & txtName.Text & "','" & cmbCode.Text & "','" & txtAd.Text & "','" & txtFax.Text & "','" & txtPhone.Text & "','" & txtCon.Text & "','" & txtOwner.Text & "','" & cmbAgent.Text & "','" & lblAge.Text & "','" & cmbDiv.Text & "','" & lblDiv.Text & "','" & cmbArea.Text & "','" & lblArea.Text & "','" & txtBFAD.Text & "','" & txtCred.Text & "','" & txtAging.Text & "','" & txtInvoic.Text & "')"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Clients ORDER BY Client_ID", con)
            dad.Fill(dst, "Client")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            con.Close()

            txtName.Text = ""
            txtCode.Text = ""
            cmbCode.SelectedIndex = -1
            txtAd.Text = ""
            txtFax.Text = ""
            txtPhone.Text = ""
            txtCon.Text = ""
            txtOwner.Text = ""
            cmbAgent.Text = ""
            lblAge.Text = "-"
            cmbArea.Text = ""
            lblArea.Text = "-"
            cmbDiv.Text = ""
            lblDiv.Text = "-"
            txtBFAD.Text = ""
            txtCred.Text = ""
            txtAging.Text = ""
            txtInvoic.Text = ""

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub clientAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbCode.Items.Add("Dispensing")
        Me.cmbCode.Items.Add("Hospital")
        Me.cmbCode.Items.Add("Pharmacy")

        cmbAgent.SelectedIndex = -1
        cmbArea.SelectedIndex = -1
        cmbDiv.SelectedIndex = -1
        cmbCode.SelectedIndex = 0

        lblAge.Text = "-"
        lblArea.Text = "-"
        lblDiv.Text = "-"

        FillCombo1()
    End Sub
    Private Sub FillCombo1()
        Try
            Dim query As String = ("SELECT DISTINCT Div_Code FROM Division")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbDiv.ValueMember = "Div_Code"
            cmbDiv.DataSource = ds.Tables(0)
            cmbDiv.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub FillCombo2()
        Try
            Dim query As String = ("SELECT DISTINCT Agent_Code FROM Division WHERE Div_Code = '" + cmbDiv.Text + "'")
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
    Private Sub FillCombo3()
        Try
            Dim query As String = ("SELECT DISTINCT Area_Code FROM Agents WHERE Agent_Code = '" + cmbAgent.Text + "'")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbArea.ValueMember = "Area_Code"
            cmbArea.DataSource = ds.Tables(0)
            cmbArea.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub cmbDiv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiv.SelectedIndexChanged
        FillCombo2()

        cmbAgent.SelectedIndex = -1
        cmbArea.SelectedIndex = -1
        lblAge.Text = "-"
        lblArea.Text = "-"

        cmd = New OleDbCommand("SELECT Div_Name FROM Division WHERE Div_Code ='" + cmbDiv.Text + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        While (dr.Read)
            Dim divv As String = dr("Div_Name").ToString()
            lblDiv.Text = divv
        End While
        con.Close()

    End Sub

    Private Sub cmbAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        FillCombo3()

        If cmbAgent.SelectedIndex = -1 Then
            lblAge.Text = "-"
        Else
            cmd = New OleDbCommand("SELECT Agent_Name FROM Division WHERE Agent_Code ='" + cmbAgent.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim agee As String = dr("Agent_Name").ToString()
                lblAge.Text = agee
            End While
            con.Close()
        End If
    End Sub

    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArea.SelectedIndexChanged
        If cmbArea.SelectedIndex = -1 Then
            lblArea.Text = "-"
        Else
            cmd = New OleDbCommand("SELECT Area_Name FROM Agents WHERE Area_Code ='" + cmbArea.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim aree As String = dr("Area_Name").ToString()
                lblArea.Text = aree
            End While
            con.Close()
        End If
    End Sub

    Private Sub txtCred_Leave(sender As Object, e As EventArgs) Handles txtCred.Leave
        If txtCred.Text = "" Then
            txtCred.Text = "0"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtCred.Text)
            txtCred.Text = dek.ToString("n2")
        End If
    End Sub

    Private Sub cmbCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCode.SelectedIndexChanged
        If Me.cmbCode.SelectedIndex = -1 Then
            txtCode.Text = ""
        ElseIf Me.cmbCode.SelectedIndex = 0 Then
            autonumDis()

        ElseIf cmbCode.SelectedIndex = 1 Then
            autonumHos()

        Else
            autonumPhar()
        End If
    End Sub

    Private Sub txtAging_Leave(sender As Object, e As EventArgs) Handles txtAging.Leave
        If txtAging.Text = "" Then
            txtAging.Text = "0"
        End If
    End Sub
    Private Sub txtInvoic_Leave(sender As Object, e As EventArgs) Handles txtInvoic.Leave
        If txtInvoic.Text = "" Then
            txtInvoic.Text = "0"
        End If
    End Sub
    Sub autonumDis()
        Dim autoCode As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Client_Code FROM Clients WHERE Client_Type = 'Dispensing'"
        Dim rdr As OleDbDataReader
        rdr = cmd.ExecuteReader

        While rdr.Read
            autoCode = Val(rdr.Item("Client_Code").ToString) + 1
        End While

        Select Case Len(Trim(autoCode))
            Case 1 : txtCode.Text = "D-0000" + Trim(Str(autoCode))
            Case 2 : txtCode.Text = "D-000" + Trim(Str(autoCode))
            Case 3 : txtCode.Text = "D-00" + Trim(Str(autoCode))
            Case 4 : txtCode.Text = "D-0" + Trim(Str(autoCode))
        End Select
        con.Close()
    End Sub
    Sub autonumHos()
        Dim autoCode As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Client_Code FROM Clients WHERE Client_Type = 'Hospital'"
        Dim rdr As OleDbDataReader
        rdr = cmd.ExecuteReader

        While rdr.Read
            autoCode = Val(rdr.Item("Client_Code").ToString) + 1
        End While

        Select Case Len(Trim(autoCode))
            Case 1 : txtCode.Text = "H-0000" + Trim(Str(autoCode))
            Case 2 : txtCode.Text = "H-000" + Trim(Str(autoCode))
            Case 3 : txtCode.Text = "H-00" + Trim(Str(autoCode))
            Case 4 : txtCode.Text = "H-0" + Trim(Str(autoCode))
        End Select
        con.Close()
    End Sub
    Sub autonumPhar()
        Dim autoCode As Single
        con.Open()
        cmd.CommandText = "SELECT COUNT(*) AS Client_Code FROM Clients WHERE Client_Type = 'Pharmacy'"
        Dim rdr As OleDbDataReader
        rdr = cmd.ExecuteReader

        While rdr.Read
            autoCode = Val(rdr.Item("Client_Code").ToString) + 1
        End While

        Select Case Len(Trim(autoCode))
            Case 1 : txtCode.Text = "P-0000" + Trim(Str(autoCode))
            Case 2 : txtCode.Text = "P-000" + Trim(Str(autoCode))
            Case 3 : txtCode.Text = "P-00" + Trim(Str(autoCode))
            Case 4 : txtCode.Text = "P-0" + Trim(Str(autoCode))
        End Select
        con.Close()
    End Sub
    Private Sub txtAd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAd.KeyPress
        Static letra As Char
        If letra = " "c Or txtAd.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        letra = e.KeyChar
    End Sub
End Class