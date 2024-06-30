Imports System.Data.OleDb
Public Class SupplierAdd
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        suppliers.Show()
        refreshData()
        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Supplier_ID, Supplier_Name FROM [Suppliers] ORDER BY [Supplier_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        suppliers.dtgSup.DataSource = dt4
        con.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con.Open()
        Dim str As String = "UPDATE Suppliers SET Supplier_Name=? WHERE supplier_id=?"
        cmd = New OleDbCommand(str, con)
        cmd.Parameters.AddWithValue("Supplier_Name", txtName.Text)
        cmd.Parameters.AddWithValue("Supplier_ID", txtSup.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Record has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Suppliers (Supplier_ID, Supplier_Name) values("
            Str += """" & txtSup.Text.Trim() & """"
            Str += ","
            Str += """" & txtName.Text.Trim() & """"
            Str += ")"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Suppliers ORDER BY Supplier_ID", con)
            dad.Fill(dst, "Suppliers")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            txtSup.Text = ""
            txtName.Text = ""

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub SupplierAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSup.Focus()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Static letra As Char
        If letra = " "c Or txtName.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        letra = e.KeyChar
    End Sub
End Class