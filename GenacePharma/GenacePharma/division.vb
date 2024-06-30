Imports System.Data.OleDb
Public Class division
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        records.Show()
        refreshData()
        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Division] ORDER BY [Div_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        records.dtgDiv.DataSource = dt4
        con.Close()
    End Sub

    Private Sub division_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        cmbAgent.SelectedIndex = -1
        lblAgent.Text = "-"
    End Sub
    Private Sub FillCombo()
        Try
            Dim fillme As New OleDb.OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb")
            Dim query As String = ("SELECT Agent_Code FROM Agents")
            Dim da As New OleDb.OleDbDataAdapter(query, fillme)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbAgent.ValueMember = "Agent_Code"
            cmbAgent.DataSource = ds.Tables(0)
            cmbAgent.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub cmbAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        cmd = New OleDbCommand("SELECT Agent_Name FROM Agents WHERE Agent_Code ='" + cmbAgent.Text + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        While (dr.Read)
            Dim agee As String = dr("Agent_Name").ToString()
            lblAgent.Text = agee
        End While
        con.Close()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Division (Div_Code, Div_Name, Agent_Code, Agent_Name) values("
            Str += """" & txtCode.Text.Trim() & """"
            Str += ","
            Str += """" & txtName.Text.Trim() & """"
            Str += ","
            Str += """" & cmbAgent.Text.Trim() & """"
            Str += ","
            Str += """" & lblAgent.Text.Trim() & """"
            Str += ")"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Division ORDER BY Div_Code", con)
            dad.Fill(dst, "Division")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            con.Close()

            txtCode.Text = ""
            txtName.Text = ""
            cmbAgent.Text = " "
            lblAgent.Text = "-"

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cmbAgent.SelectedIndex = -1
        lblAgent.Text = "-"
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
End Class