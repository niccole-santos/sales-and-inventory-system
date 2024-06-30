Imports System.IO
Imports System.IO.Directory
Imports System.IO.DirectoryInfo
Imports System.IO.Path
Imports System.Environment
Imports System.IO.FileStream
Imports System.IO.File
Imports System.IO.FileInfo
Imports System.Data
Imports System.Data.OleDb
Public Class suppliers
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homep.Enabled = True
        Me.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select Supplier_ID, Supplier_Name From Suppliers where Supplier_Name like '%" & txtSearch.Text & "%' order by Supplier_ID", con)
        dst.Clear()
        dad.Fill(dst, "Suppliers")
        table1 = dst.Tables
        Dim view As New DataView(table1(0))
        source1.DataSource = view
        dtgSup.DataSource = view
        UpdateTextBox(0)
        con.Close()
    End Sub
    Public Sub UpdateTextBox(ByVal x As Integer)
        Try
            txtSearch.Text = dst.Tables("Supplier_Name").Rows(x)("Supplier_Id")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Me.dtgSup.Rows.Count > 0 Then

            If dtgSup.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgSup.SelectedRows(0).Cells("Supplier_ID").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Suppliers] WHERE [Supplier_ID] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Supplier removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        dad = New OleDbDataAdapter("SELECT Supplier_ID, Supplier_Name FROM [Suppliers] ORDER BY [Supplier_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgSup.DataSource = dt4
        con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        SupplierAdd.Show()
        SupplierAdd.btnAdd.Visible = True
        SupplierAdd.txtSup.Enabled = True
        SupplierAdd.btnSave.Visible = False
    End Sub

    Private Sub suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SuppliersTable.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.SuppliersTable.Suppliers)

    End Sub

    Private Sub dtgSup_DoubleClick(sender As Object, e As MouseEventArgs) Handles dtgSup.DoubleClick
        Dim form As New SupplierAdd

        form.txtSup.Text = dtgSup.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgSup.CurrentRow.Cells(1).Value.ToString

        form.btnAdd.Visible = False
        form.txtSup.Enabled = False
        form.txtSup.BackColor = Color.White
        form.txtName.Focus()
        form.btnSave.Visible = True

        form.ShowDialog()
    End Sub
End Class