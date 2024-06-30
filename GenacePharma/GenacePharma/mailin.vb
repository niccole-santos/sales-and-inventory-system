Imports System.Data.OleDb
Imports System.Net.Mail
Public Class mailin
    Dim SenName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        dueAcc.Show()
    End Sub
    Private Sub mailin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAttac.Visible = False
        Label9.Visible = False

        Me.cmbDay.Items.Add("Current")
        Me.cmbDay.Items.Add("30")
        Me.cmbDay.Items.Add("60")
        Me.cmbDay.Items.Add("90")
        Me.cmbDay.Items.Add("120")
        Me.cmbDay.Items.Add("150")
        Me.cmbDay.Items.Add("Over 150 Days")

        txtMes.Text = "Dear Valued Client," + vbCrLf + "You have a remaining balance of __________ that is due on " + "January" + vbCrLf + vbCrLf + vbCrLf + "Thank You," + vbCrLf + vbCrLf + "Genace Pharma Distributor"
    End Sub

    Private Sub TextBox4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSenMail.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-z]{2,28}[a-zA-Z0-9]@[\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")

        If txtSenMail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtSenMail.Text) Then
                MessageBox.Show("Invalid e-mail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSenMail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim smtser As New SmtpClient
            Dim maile As New MailMessage
            Dim attac As System.Net.Mail.Attachment

            smtser.UseDefaultCredentials = False
            smtser.Credentials = New Net.NetworkCredential(txtSenMail.Text, txtPass.Text)
            smtser.Port = 587
            smtser.EnableSsl = True
            smtser.Host = "smtp.gmail.com"

            maile = New MailMessage()
            maile.From = New MailAddress(txtSenMail.Text)
            maile.To.Add(txtCliMail.Text)
            maile.Subject = txtSub.Text
            maile.IsBodyHtml = False
            maile.Body = txtMes.Text


            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(txtAttac.Text)
            maile.Attachments.Add(attachment)

            smtser.Send(maile)
            MessageBox.Show("Mail sent to client!", "E-mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            dueAcc.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSenName_Leave(sender As Object, e As EventArgs) Handles txtSenName.Leave
        If txtSenName.Text = "" Then
            txtMes.Text = "Dear Valued Client," + vbCrLf + "You have a remaining balance of " + txtBal.Text + " that is due on " + "January" + vbCrLf + vbCrLf + vbCrLf + "Thank You," + vbCrLf + vbCrLf + "Genace Pharma Distributor"
        Else
            txtMes.Text = "Dear Valued Client," + vbCrLf + "You have a remaining balance of " + txtBal.Text + " that is due on " + "January" + vbCrLf + vbCrLf + vbCrLf + "Thank You," + vbCrLf + vbCrLf + SenName + vbCrLf + "Genace Pharma Distributor"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        dueAcc.Show()
        Me.Close()
    End Sub
    Private Sub txtSub_TextChanged(sender As Object, e As EventArgs) Handles txtSub.TextChanged
        If txtSub.Text = "Due Accounts" Then
            txtSub.ForeColor = Color.Silver
        Else
            txtSub.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSub_Click(sender As Object, e As EventArgs) Handles txtSub.Click
        txtSub.Text = ""
    End Sub

    Private Sub txtSub_Leave(sender As Object, e As EventArgs) Handles txtSub.Leave
        If txtSub.Text = "" Then
            txtSub.Text = "Due Accounts"
        End If
    End Sub

    Private Sub txtSenName_TextChanged(sender As Object, e As EventArgs) Handles txtSenName.TextChanged
        SenName = txtSenName.Text
    End Sub
    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        Dim openfile As New OpenFileDialog()
        Dim filemane As String

        If (openfile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            filemane = openfile.FileName
            txtAttac.Text = filemane
            MessageBox.Show("Your file has been attached.", "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label9.Visible = True
        End If
    End Sub
    Private Sub fillClient1()
        Try
            Dim query As String = ("SELECT Client_Name FROM Clients WHERE Aging_Terms = 30")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbClient.DisplayMember = "Client_Name"
            cmbClient.ValueMember = "Client_ID"
            cmbClient.DataSource = ds.Tables(0)
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillClient2()
        Try
            Dim query As String = ("SELECT Client_Name FROM Clients WHERE Aging_Terms = 60")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbClient.DisplayMember = "Client_Name"
            cmbClient.ValueMember = "Client_ID"
            cmbClient.DataSource = ds.Tables(0)
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillClient3()
        Try
            Dim query As String = ("SELECT Client_Name FROM Clients WHERE Aging_Terms = 90")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbClient.DisplayMember = "Client_Name"
            cmbClient.ValueMember = "Client_ID"
            cmbClient.DataSource = ds.Tables(0)
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillClient4()
        Try
            Dim query As String = ("SELECT Client_Name FROM Clients WHERE Aging_Terms = 120")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbClient.DisplayMember = "Client_Name"
            cmbClient.ValueMember = "Client_ID"
            cmbClient.DataSource = ds.Tables(0)
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillClient5()
        Try
            Dim query As String = ("SELECT Client_Name FROM Clients WHERE Aging_Terms = 150")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbClient.DisplayMember = "Client_Name"
            cmbClient.ValueMember = "Client_ID"
            cmbClient.DataSource = ds.Tables(0)
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillAClient()
        Try
            Dim query As String = ("SELECT Client_Name FROM Clients")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbClient.DisplayMember = "Client_Name"
            cmbClient.ValueMember = "Client_ID"
            cmbClient.DataSource = ds.Tables(0)
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub fillOClient()
        Try
            Dim query As String = ("SELECT Client_Name FROM Clients WHERE Aging_Terms > 150")
            Dim da As New OleDb.OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            da.Fill(ds)

            cmbClient.DisplayMember = "Client_Name"
            cmbClient.ValueMember = "Client_ID"
            cmbClient.DataSource = ds.Tables(0)
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDay.SelectedIndexChanged
        If cmbDay.SelectedIndex = 0 Then
            fillAClient()
        ElseIf cmbDay.SelectedIndex = 1 Then
            fillClient1()
        ElseIf cmbDay.SelectedIndex = 2 Then
            fillClient2()
        ElseIf cmbDay.SelectedIndex = 3 Then
            fillClient3()
        ElseIf cmbDay.SelectedIndex = 4 Then
            fillClient4()
        ElseIf cmbDay.SelectedIndex = 5 Then
            fillClient5()
        Else
            fillOClient()
        End If
    End Sub

    Private Sub cmbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClient.SelectedIndexChanged
        If cmbClient.SelectedIndex = -1 Then
            txtAdd.Text = ""
            txtPhon.Text = ""
            txtCliMail.Text = ""
            txtBal.Text = ""
        Else
            cmd = New OleDbCommand("SELECT Address, Phone, Contact, Credit_Limit FROM Clients WHERE Client_Name ='" + cmbClient.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()

            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()

            While (dr.Read)
                Dim ad As String = dr("Address").ToString()
                Dim ph As String = dr("Phone").ToString()
                Dim co As String = dr("Contact").ToString()
                Dim lim As String = dr("Credit_Limit").ToString()
                txtAdd.Text = ad
                txtPhon.Text = ph
                txtCliMail.Text = co
                txtBal.Text = lim
            End While
            con.Close()
        End If
    End Sub

    Private Sub txtBal_TextChanged(sender As Object, e As EventArgs) Handles txtBal.TextChanged
        Refresh()
    End Sub
End Class
