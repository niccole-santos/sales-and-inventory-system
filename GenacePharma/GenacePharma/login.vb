Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class login
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim uname2 As String = ""
        Dim pword2 As String
        Dim username2 As String = ""
        Dim pass2 As String
        If txtAdminName.Text = "" Or txtAdminPass.Text = "" Then
            MsgBox("Please fill all the information needed.")
        Else
            uname2 = txtAdminName.Text
            pword2 = txtAdminPass.Text
            Dim querry As String = "Select Admin_Password From Admin where Admin_ID= '" & uname2 & "';"
            Dim dbsource As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb"
            Dim cmd As New OleDbCommand(querry, con)
            con.Open()
            Try
                pass2 = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exist.")
            End Try
            If (pword2 = pass2) Then
                con.Close()
                txtAdminPass.Clear()
                txtAdminName.Clear()
                homep.Show()
                remindes.Show()
                If homep.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("Login Failed.")
                con.Close()
                txtAdminName.Clear()
                txtAdminPass.Clear()
            End If
        End If
    End Sub
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String

        If tbUser.Text = "" Or tbPass.Text = "" Then
            MsgBox("Please fill all the information needed.")
        Else
            uname = tbUser.Text
            pword = tbPass.Text
            Dim querry As String = "Select User_Password From Users where User_ID= '" & uname & "';"
            Dim dbsource As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb"
            Dim cmd As New OleDbCommand(querry, con)
            con.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exist.")
            End Try

            If (pword = pass) Then
                con.Close()
                tbUser.Clear()
                tbPass.Clear()
                homep.Show()
                remindes.Show()
                homep.btnAcc.Enabled = False
                If homep.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("Login Failed.")
                con.Close()
                tbUser.Clear()
                tbPass.Clear()
            End If
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        txtAdminName.Focus()
        txtGuestUser.Focus()
        tbUser.Focus()
        txtGuestUser.Clear()
        txtAdminPass.Clear()
        txtAdminName.Clear()
        tbPass.Clear()
        tbUser.Clear()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUser.Focus()
        Timer1.Enabled = True
        TextBox1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Date.Now.ToString("MM-dd-yyyy") + " | " + TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim Str As String

        Try
            Str = "INSERT INTO GuestLog (User_Name, Log_Info) values("
            Str += """" & txtGuestUser.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox1.Text.Trim() & """"
            Str += ")"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM GuestLog ORDER BY User_Name", con)
            dad.Fill(dst, "GuestLog")
            MsgBox("WELCOME " + txtGuestUser.Text() + "!")

            txtGuestUser.Text = ""
            Me.Hide()

            homep.Show()
            remindes.Show()
            homep.btnAcc.Enabled = False
            con.Close()

        Catch ex As Exception
            MessageBox.Show("PLEASE TRY AGAIN.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub

    Private Sub txtGuestUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGuestUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Str As String

            Try
                Str = "INSERT INTO GuestLog (User_Name, Log_Info) values("
                Str += """" & txtGuestUser.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox1.Text.Trim() & """"
                Str += ")"

                con.Open()
                cmd = New OleDbCommand(Str, con)
                cmd.ExecuteNonQuery()
                dst.Clear()
                dad = New OleDbDataAdapter("SELECT * FROM GuestLog ORDER BY User_Name", con)
                dad.Fill(dst, "GuestLog")
                MsgBox("WELCOME " + txtGuestUser.Text() + "!")

                txtGuestUser.Text = ""
                Me.Hide()
                homep.Show()
                remindes.Show()
                homep.btnAcc.Enabled = False
                con.Close()

            Catch ex As Exception
                MessageBox.Show("PLEASE TRY AGAIN.")
                MsgBox(ex.Message & "-" & ex.Source)
                con.Close()
            End Try
        End If
    End Sub
    'ENTER TO LOG IN
    Private Sub txtAdminPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAdminPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim uname2 As String = ""
            Dim pword2 As String
            Dim username2 As String = ""
            Dim pass2 As String
            If txtAdminName.Text = "" Or txtAdminPass.Text = "" Then
                MsgBox("Please fill all the information needed.")
            Else
                uname2 = txtAdminName.Text
                pword2 = txtAdminPass.Text
                Dim querry As String = "Select Admin_Password From Admin where Admin_ID= '" & uname2 & "';"
                Dim dbsource As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb"
                Dim cmd As New OleDbCommand(querry, con)
                con.Open()
                Try
                    pass2 = cmd.ExecuteScalar().ToString
                Catch ex As Exception
                    MsgBox("Username does not exist.")
                End Try
                If (pword2 = pass2) Then
                    con.Close()
                    txtAdminPass.Clear()
                    txtAdminName.Clear()
                    homep.Show()
                    remindes.Show()
                    If homep.Visible Then
                        Me.Hide()
                    End If

                Else
                    MsgBox("Login Failed.")
                    con.Close()
                    txtAdminName.Clear()
                    txtAdminPass.Clear()
                End If
            End If
        End If
    End Sub
    'ENTER TO LOG IN
    Private Sub tbPass_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim uname As String = ""
            Dim pword As String
            Dim username As String = ""
            Dim pass As String

            If tbUser.Text = "" Or tbPass.Text = "" Then
                MsgBox("Please fill all the information needed.")
            Else
                uname = tbUser.Text
                pword = tbPass.Text
                Dim querry As String = "Select User_Password From Users where User_ID= '" & uname & "';"
                Dim dbsource As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb"
                Dim cmd As New OleDbCommand(querry, con)
                con.Open()
                Try
                    pass = cmd.ExecuteScalar().ToString
                Catch ex As Exception
                    MsgBox("Username does not exist.")
                End Try
                If (pword = pass) Then
                    con.Close()
                    tbUser.Clear()
                    tbPass.Clear()
                    homep.Show()
                    remindes.Show()
                    homep.btnAcc.Enabled = False
                    If homep.Visible Then
                        Me.Hide()
                    End If

                Else
                    MsgBox("Login Failed.")
                    con.Close()
                    tbUser.Clear()
                    tbPass.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub txtAdminName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAdminName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAdminPass.Focus()
        End If
    End Sub

    Private Sub tbUser_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbPass.Focus()
        End If
    End Sub

    Private Sub tbUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUser.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAdminName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdminName.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuestUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuestUser.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
