Imports System.Data.OleDb
Public Class admins
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim str As String
        con.Open()
        str = "UPDATE Admin set Admin_Password ="
        str += """" & txtPass.Text.Trim() & """" & "where User_ID= " & txtAdmin.Text.Trim()
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("SAVED.")
    End Sub

    Private Sub admins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAdmin.Focus()
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Admin (Admin_ID, Admin_Name, Admin_Password) values("
            Str += """" & txtAdmin.Text.Trim() & """"
            Str += ","
            Str += """" & txtName.Text.Trim() & """"
            Str += ","
            Str += """" & txtPass.Text.Trim() & """"
            Str += ")"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Admin ORDER BY Admin_ID", con)
            dad.Fill(dst, "Admin")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            txtAdmin.Text = ""
            txtName.Text = ""
            txtPass.Text = ""

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub

    Private Sub txtAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdmin.KeyPress
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
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Admin] ORDER BY [Admin_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        accs.dtgAdmin.DataSource = dt4
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        accs.Show()
        refreshData()
        Me.Close()
    End Sub

    Private Sub btnSaveAd_Click(sender As Object, e As EventArgs) Handles btnSaveAd.Click
        Try
            con.Open()
            Dim str As String = "UPDATE Admin SET Admin_Password=? WHERE admin_id=?"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("Admin_Password", txtPass.Text)
            cmd.Parameters.AddWithValue("Admin_ID", txtAdmin.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Admin information has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class