Imports System.Data.OleDb
Public Class users
    Private Sub btnSaveUs_Click(sender As Object, e As EventArgs) Handles btnSaveUs.Click
        Try
            con.Open()
            Dim str As String = "UPDATE Users SET User_Password=? WHERE user_id=?"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("User_Password", txtPass.Text)
            cmd.Parameters.AddWithValue("User_ID", txtUser.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("User information has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Users ( User_ID, Employee_Name, User_Password) VALUES ('" & txtUser.Text & "','" & txtName.Text _
            & "','" & txtPass.Text & "')"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Users ORDER BY User_ID", con)
            dad.Fill(dst, "Users")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            txtUser.Text = ""
            txtName.Text = ""
            txtPass.Text = ""

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub
    Private Sub refreshData()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Users] ORDER BY [User_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        accs.dtgUsers.DataSource = dt4
        con.Close()
    End Sub
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        accs.Show()
        refreshData()
        Me.Close()
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()
        txtPass.UseSystemPasswordChar = True
    End Sub
End Class