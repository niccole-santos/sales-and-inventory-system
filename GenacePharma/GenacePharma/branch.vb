Imports System.Data.OleDb
Public Class branch
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        records.Show()
        refreshData()
        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Branch] ORDER BY [Branch_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        records.dtgBranch.DataSource = dt4
        con.Close()
    End Sub

    Private Sub branch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCode.Focus()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Branch (Branch_ID, Branch_Name) VALUES ('" & txtCode.Text & "','" & txtName.Text & "')"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Branch ORDER BY Branch_ID", con)
            dad.Fill(dst, "Branch")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            txtCode.Text = ""
            txtName.Text = ""

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con.Open()
            Dim str As String = "UPDATE Branch SET branch_Name=? WHERE branch_id=?"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("Branch_Name", txtName.Text)
            cmd.Parameters.AddWithValue("Branch_ID", txtCode.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Record has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class