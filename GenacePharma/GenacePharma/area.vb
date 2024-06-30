Imports System.Data.OleDb

Public Class area
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        records.Show()
        refreshData()
        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Area] ORDER BY [Area_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        records.dtgArea.DataSource = dt4
        con.Close()
    End Sub

    Private Sub area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCode.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Area ( Area_Code, Area_Name) VALUES ('" & txtCode.Text & "','" & txtName.Text & "')"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Area ORDER BY Area_Code", con)
            dad.Fill(dst, "Area")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            txtCode.Text = ""
            txtName.Text = ""

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Static letra As Char
        If letra = " "c Or txtName.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        letra = e.KeyChar

        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con.Open()
            Dim str As String = "UPDATE Area SET Area_Name=? WHERE area_code=?"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("Area_Name", txtName.Text)
            cmd.Parameters.AddWithValue("Area_Code", txtCode.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Record has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class