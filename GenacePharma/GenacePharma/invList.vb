Imports System.Data.OleDb
Public Class invList
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homep.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        invoice.Show()
        invoice.autonum()
        Me.Hide()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Me.dtgInv.Rows.Count > 0 Then

            If dtgInv.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgInv.SelectedRows(0).Cells("Invoice_Number").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Invoice] WHERE [Invoice_Number] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                refreshData()
                con.Close()

            Else

                MessageBox.Show("No record selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else

            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub refreshData()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Invoice] ORDER BY [Invoice_Number]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgInv.DataSource = dt4
        con.Close()
    End Sub
    Private Sub fillType()
        Try
            Dim query As String = ("SELECT Invoice_Info FROM InvoiceType")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbType.ValueMember = "Invoice_Info"
            cmbType.DataSource = ds.Tables(0)
            cmbType.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub invList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com As String = "SELECT Invoice_Number, In_Date, Client_Name FROM Invoice"
        Dim da As New OleDbDataAdapter(com, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Invoice")
        dtgInv.DataSource = ds.Tables(0)
        Me.dtgInv.Columns(0).HeaderText = "Invoice #"
        Me.dtgInv.Columns(1).HeaderText = "Date"
        Me.dtgInv.Columns(2).HeaderText = "Client Name"

        invoice.btnEdit.Visible = False
        cmbType.Visible = False
        txtSearch.Visible = False

        Me.cmbCate.Items.Add("Show All")
        Me.cmbCate.Items.Add("By Client")
        Me.cmbCate.Items.Add("By Type")
    End Sub

    Private Sub cmbCate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCate.SelectedIndexChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter

        If cmbCate.SelectedIndex = 0 Then
            txtSearch.Visible = False
            cmbType.Visible = False

            txtSearch.Text = ""
            cmbType.SelectedIndex = -1

        ElseIf cmbCate.SelectedIndex = 1 Then
            cmbType.Visible = False
            txtSearch.Visible = True

            cmbType.SelectedIndex = -1

            con.Open()
            dst.Tables.Add(dt)
            da = New OleDbDataAdapter("SELECT * FROM Invoice WHERE Client_Name LIKE '%" & txtSearch.Text & "%'", con)
            da.Fill(dt)
            dtgInv.DataSource = dt.DefaultView
            con.Close()

        Else
            cmbType.Visible = True
            txtSearch.Visible = False
            fillType()
            txtSearch.Text = ""

            con.Open()
            dst.Tables.Add(dt)
            da = New OleDbDataAdapter("SELECT * FROM Invoice WHERE In_Description LIKE '%" & cmbType.Text & "%'", con)
            da.Fill(dt)
            dtgInv.DataSource = dt.DefaultView
            con.Close()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Invoice WHERE Client_Name LIKE '%" & txtSearch.Text & "%'", con)
        da.Fill(dt)

        dtgInv.DataSource = dt.DefaultView

        con.Close()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Invoice WHERE In_Description LIKE '%" & cmbType.Text & "%'", con)
        da.Fill(dt)

        dtgInv.DataSource = dt.DefaultView

        con.Close()
    End Sub
End Class