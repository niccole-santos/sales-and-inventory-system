Imports System.Data.OleDb
Imports System.String
Imports System.Data
Imports System.ComponentModel

Public Class accs
    Dim str As String
    Private Sub accs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com, com1, com2 As String

        com = "SELECT User_ID, Employee_Name, User_Password FROM Users"
        Dim da As New OleDbDataAdapter(com, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Users")
        dtgUsers.DataSource = ds.Tables(0)
        Me.dtgUsers.Columns(0).HeaderText = "User ID"
        Me.dtgUsers.Columns(1).HeaderText = "Name"
        Me.dtgUsers.Columns(2).HeaderText = "Password"

        com1 = "SELECT User_Name, Log_Info FROM GuestLog"
        Dim da1 As New OleDbDataAdapter(com1, con)
        Dim ds1 As New DataSet()
        da1.Fill(ds1, "GuestLog")
        dtgGuest.DataSource = ds1.Tables(0)
        Me.dtgGuest.Columns(0).HeaderText = "Name"
        Me.dtgGuest.Columns(1).HeaderText = "Log Information"

        com2 = "SELECT Admin_ID, Admin_Name, Admin_Password FROM Admin"
        Dim da2 As New OleDbDataAdapter(com2, con)
        Dim ds2 As New DataSet()
        da2.Fill(ds2, "Admin")
        dtgAdmin.DataSource = ds2.Tables(0)
        Me.dtgAdmin.Columns(0).HeaderText = "Admin ID"
        Me.dtgAdmin.Columns(1).HeaderText = "Name"
        Me.dtgAdmin.Columns(2).HeaderText = "Password"

        dtgGuest.Sort(dtgGuest.Columns(1), ListSortDirection.Descending)

        'USERS
        btnAdd1.Visible = False
        btnDel1.Visible = False
        txtSearch.Visible = False
        dtgUsers.Visible = False

        'GUESTS
        btnDelAll.Visible = False
        dtgGuest.Visible = False
        txtSearch2.Visible = False

        'ADMIN
        btnAdd3.Visible = False
        btnDel3.Visible = False
        dtgAdmin.Visible = False
        txtSearch3.Visible = False
    End Sub
    Private Sub autoRefreshData()
        Try
            str = "SELECT* FROM GuestLog"
            con.Open()
            Dim see As New OleDbDataAdapter(str, con)
            see.Fill(dst, "GuesLog")
            dtgGuest.DataSource = dst.Tables("GuestLog")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        'USERS
        btnAdd1.Visible = True
        btnDel1.Visible = True
        dtgUsers.Visible = True
        txtSearch.Visible = True
        txtSearch.Focus()

        'GUESTS
        btnDelAll.Visible = False
        dtgGuest.Visible = False
        txtSearch2.Visible = False

        'ADMIN
        btnAdd3.Visible = False
        btnDel3.Visible = False
        txtSearch3.Visible = False
        dtgAdmin.Visible = False

        txtSearch2.Text = ""
        txtSearch3.Text = ""

        refreshData()
        refreshData1()
        refreshData3()

    End Sub
    Private Sub btnAdmins_Click(sender As Object, e As EventArgs) Handles btnAdmins.Click
        'USERS
        btnAdd1.Visible = False
        btnDel1.Visible = False
        txtSearch.Visible = False
        dtgUsers.Visible = False

        'GUESTS
        btnDelAll.Visible = False
        dtgGuest.Visible = False
        txtSearch2.Visible = False

        'ADMIN
        btnAdd3.Visible = True
        btnDel3.Visible = True
        dtgAdmin.Visible = True
        txtSearch3.Visible = True
        txtSearch3.Focus()

        txtSearch2.Text = ""
        txtSearch.Text = ""

        refreshData()
        refreshData1()
        refreshData3()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homep.Enabled = True
        Me.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Users WHERE Employee_Name LIKE '%" & txtSearch.Text & "%'", con)
        da.Fill(dt)

        dtgUsers.DataSource = dt.DefaultView

        con.Close()

        refreshData()
        refreshData3()

    End Sub
    Private Sub txtSearch3_TextChanged(sender As Object, e As EventArgs) Handles txtSearch3.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Admin WHERE Admin_Name LIKE '%" & txtSearch3.Text & "%'", con)
        da.Fill(dt)

        dtgAdmin.DataSource = dt.DefaultView

        con.Close()

        refreshData()
        refreshData1()

    End Sub
    Private Sub txtSearch2_TextChanged(sender As Object, e As EventArgs) Handles txtSearch2.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM GuestLog WHERE User_Name LIKE '%" & txtSearch2.Text & "%'", con)
        da.Fill(dt)

        dtgGuest.DataSource = dt.DefaultView

        con.Close()

        refreshData1()
        refreshData3()

    End Sub
    Private Sub btnDel1_Click(sender As Object, e As EventArgs) Handles btnDel1.Click
        If Me.dtgUsers.Rows.Count > 0 Then

            If dtgUsers.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgUsers.SelectedRows(0).Cells("User_ID").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Users] WHERE [User_ID] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("User removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                refreshData1()
                con.Close()

            Else

                MessageBox.Show("No record selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else

            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub refreshData1()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Users] ORDER BY [User_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgUsers.DataSource = dt4
        con.Close()
    End Sub
    Private Sub refreshData()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [GuestLog] ORDER BY [User_Name]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgGuest.DataSource = dt4
        con.Close()
    End Sub
    Private Sub refreshData3()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM [Admin] ORDER BY [Admin_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgAdmin.DataSource = dt4
        con.Close()
    End Sub
    Private Sub btnDel3_Click(sender As Object, e As EventArgs) Handles btnDel3.Click
        If Me.dtgAdmin.Rows.Count > 0 Then

            If dtgAdmin.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgAdmin.SelectedRows(0).Cells("Admin_ID").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this admin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Admin] WHERE [Admin_ID] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Admin removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                refreshData3()
                con.Close()

            Else

                MessageBox.Show("No record selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else

            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub dtgUsers_DoubleClick(sender As Object, e As MouseEventArgs) Handles dtgUsers.DoubleClick
        Dim form As New users
        form.txtUser.Text = dtgUsers.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgUsers.CurrentRow.Cells(1).Value.ToString
        form.txtPass.Text = dtgUsers.CurrentRow.Cells(2).Value.ToString

        form.txtName.Enabled = False
        form.txtName.BackColor = Color.White

        form.txtUser.Enabled = False
        form.txtUser.BackColor = Color.White

        form.ShowDialog()
        form.btnAdd.Visible = False
        form.txtPass.Focus()
        form.btnSaveUs.Visible = True
    End Sub
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        users.Show()
        Me.Hide()

        users.btnSaveUs.Visible = False
        users.btnAdd.Visible = True
        users.txtUser.Focus()
    End Sub
    Private Sub dtgAdmin_DoubleClick(sender As Object, e As MouseEventArgs) Handles dtgAdmin.DoubleClick
        Dim form As New admins
        form.txtAdmin.Text = dtgAdmin.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgAdmin.CurrentRow.Cells(1).Value.ToString
        form.txtPass.Text = dtgAdmin.CurrentRow.Cells(2).Value.ToString

        form.txtName.Enabled = False
        form.txtName.BackColor = Color.White

        form.txtAdmin.Enabled = False
        form.txtAdmin.BackColor = Color.White

        form.ShowDialog()
        form.btnAdd.Visible = False
        form.txtPass.Focus()
        form.btnSaveAd.Visible = True
    End Sub
    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        admins.Show()
        Me.Hide()

        admins.btnSaveAd.Visible = False
        admins.btnAdd.Visible = True
        admins.txtAdmin.Focus()
    End Sub

    Private Sub btnGue_Click(sender As Object, e As EventArgs) Handles btnGue.Click
        'USERS
        btnAdd1.Visible = False
        btnDel1.Visible = False
        txtSearch.Visible = False
        dtgUsers.Visible = False

        'GUESTS
        btnDelAll.Visible = True
        dtgGuest.Visible = True
        txtSearch2.Visible = True
        txtSearch2.Focus()

        'ADMIN
        btnAdd3.Visible = False
        btnDel3.Visible = False
        dtgAdmin.Visible = False
        txtSearch3.Visible = False

        txtSearch.Text = ""
        txtSearch3.Text = ""

        refreshData()
        refreshData1()
        refreshData3()

    End Sub

    Private Sub btnDelAll_Click(sender As Object, e As EventArgs) Handles btnDelAll.Click
        Try
            str = "DELETE FROM GuestLog"
            con.Open()
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM GuestLog ORDER BY User_Name", con)
            dad.Fill(dst, "GuestLog")
            con.Close()
            MessageBox.Show("Records has been deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Records cannot be deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        autoRefreshData()
    End Sub
End Class