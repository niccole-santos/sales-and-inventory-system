Imports System.Data.OleDb
Public Class agent
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        records.Show()
        refreshData()
        Me.Close()
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Agents] ORDER BY [Agent_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        records.dtgAgee.DataSource = dt4
        con.Close()
    End Sub
    Private Sub FillCombo()
        Try
            Dim fillme As New OleDb.OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb")
            Dim query As String = ("SELECT Area_Code FROM Area")
            Dim da As New OleDb.OleDbDataAdapter(query, fillme)
            Dim ds As New DataSet
            da.Fill(ds)
            cmbAre.ValueMember = "Area_Code"
            cmbAre.DataSource = ds.Tables(0)
            cmbAre.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()

        lblAre.Text = ""
        cmbAre.SelectedIndex = -1

        Me.cmbQuota.Items.Add("January")
        Me.cmbQuota.Items.Add("February")
        Me.cmbQuota.Items.Add("March")
        Me.cmbQuota.Items.Add("April")
        Me.cmbQuota.Items.Add("May")
        Me.cmbQuota.Items.Add("June")
        Me.cmbQuota.Items.Add("July")
        Me.cmbQuota.Items.Add("August")
        Me.cmbQuota.Items.Add("September")
        Me.cmbQuota.Items.Add("October")
        Me.cmbQuota.Items.Add("November")
        Me.cmbQuota.Items.Add("December")

        txtQuota.Text = "0"
    End Sub
    Private Sub txtQuota_Leave(sender As Object, e As EventArgs) Handles txtQuota.Leave
        If txtQuota.Text = "" Then
            txtQuota.Text = "0"
        Else
            Dim dek As Decimal
            dek = Convert.ToDecimal(txtQuota.Text)
            txtQuota.Text = dek.ToString("n2")
        End If
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Agents (Agent_Code, Agent_Name, Area_Code, Area_Name, QuotaMonth, Quota) values("
            Str += """" & txtCode.Text.Trim() & """"
            Str += ","
            Str += """" & txtName.Text.Trim() & """"
            Str += ","
            Str += """" & cmbAre.Text.Trim() & """"
            Str += ","
            Str += """" & lblAre.Text.Trim() & """"
            Str += ","
            Str += """" & cmbQuota.Text.Trim() & """"
            Str += ","
            Str += """" & txtQuota.Text.Trim() & """"
            Str += ")"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Agents ORDER BY Agent_Code", con)
            dad.Fill(dst, "Agents")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            con.Close()

            txtCode.Text = ""
            txtName.Text = ""
            cmbQuota.SelectedIndex = -1
            txtQuota.Text = ""
            cmbAre.SelectedIndex = -1
            lblAre.Text = "-"

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
        con.Close()
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
    Private Sub txtQuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuota.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = "-" Then
            e.Handled = False
        End If
        If e.KeyChar = Chr(0) Then
            e.Handled = False
        End If
    End Sub

    Private Sub cmbAre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAre.SelectedIndexChanged
        cmd = New OleDbCommand("SELECT Area_Name FROM Area WHERE Area_Code ='" + cmbAre.Text + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        While (dr.Read)
            Dim arew As String = dr("Area_Name").ToString()
            lblAre.Text = arew
        End While
        con.Close()
    End Sub

    Private Sub cmbQuota_Leave(sender As Object, e As EventArgs) Handles cmbQuota.Leave
        If cmbQuota.Text = "" Then
            cmbQuota.Text = "-"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtQuota.Text = "0"
        cmbQuota.SelectedIndex = -1
        cmbAre.SelectedIndex = -1
        lblAre.Text = "-"
    End Sub
End Class