Imports System.Data.OleDb
Public Class records
    Private Sub notAgent()
        dtgAgee.Visible = False
        btnAdd1.Visible = False
        btnDel1.Visible = False
        txtSearch1.Visible = False
    End Sub
    Private Sub notArea()
        dtgArea.Visible = False
        btnAdd2.Visible = False
        btnDel2.Visible = False
        txtSearch2.Visible = False
    End Sub
    Private Sub notBank()
        dtgBanks.Visible = False
        btnAdd3.Visible = False
        btnDel3.Visible = False
        txtSearch3.Visible = False
    End Sub
    Private Sub notBranch()
        dtgBranch.Visible = False
        btnAdd4.Visible = False
        btnDel4.Visible = False
        txtSearch4.Visible = False
    End Sub
    Private Sub notDiv()
        dtgDiv.Visible = False
        btnAdd5.Visible = False
        btnDel5.Visible = False
        txtSearch5.Visible = False
    End Sub
    Private Sub yaAgent()
        dtgAgee.Visible = True
        btnAdd1.Visible = True
        btnDel1.Visible = True
        txtSearch1.Visible = True
        txtSearch1.Focus()
    End Sub
    Private Sub yaArea()
        dtgArea.Visible = True
        btnAdd2.Visible = True
        btnDel2.Visible = True
        txtSearch2.Visible = True
        txtSearch2.Focus()
    End Sub
    Private Sub yaBank()
        dtgBanks.Visible = True
        btnAdd3.Visible = True
        btnDel3.Visible = True
        txtSearch3.Visible = True
        txtSearch3.Focus()
    End Sub
    Private Sub yaBranch()
        dtgBranch.Visible = True
        btnAdd4.Visible = True
        btnDel4.Visible = True
        txtSearch4.Visible = True
        txtSearch4.Focus()
    End Sub
    Private Sub yaDiv()
        dtgDiv.Visible = True
        btnAdd5.Visible = True
        btnDel5.Visible = True
        txtSearch5.Visible = True
        txtSearch5.Focus()
    End Sub
    Private Sub refreshData1()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Agent_Code, Agent_Name FROM [Agents] ORDER BY [Agent_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgAgee.DataSource = dt4
        con.Close()
    End Sub
    Private Sub refreshData2()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Area_Code, Area_Name FROM [Area] ORDER BY [Area_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgArea.DataSource = dt4
        con.Close()
    End Sub
    Private Sub refreshData3()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Bank_ID, Bank_Name FROM [Banks] ORDER BY [Bank_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgBanks.DataSource = dt4
        con.Close()
    End Sub
    Private Sub refreshData4()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Branch_ID, Branch_Name FROM [Branch] ORDER BY [Branch_ID]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgBranch.DataSource = dt4
        con.Close()
    End Sub
    Private Sub refreshData5()

        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Div_Code, Div_Name FROM [Division] ORDER BY [Div_Code]", con)
        Dim dt4 As New DataTable
        dad.Fill(dt4)
        dtgDiv.DataSource = dt4
        con.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homep.Enabled = True
        Me.Close()
    End Sub

    Private Sub records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Agent2.Agents' table. You can move, or remove it, as needed.
        Me.AgentsTableAdapter1.Fill(Me.Agent2.Agents)
        'TODO: This line of code loads data into the 'GenacePharmaDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.GenacePharmaDataSet.Branch)
        'TODO: This line of code loads data into the 'BankTable.Banks' table. You can move, or remove it, as needed.
        Me.BanksTableAdapter.Fill(Me.BankTable.Banks)
        'TODO: This line of code loads data into the 'AreaTable.Area' table. You can move, or remove it, as needed.
        Me.AreaTableAdapter.Fill(Me.AreaTable.Area)

        notArea()
        notAgent()
        notBank()
        notBranch()
        notDiv()

        Dim com As String = "SELECT DISTINCT Div_Code, Div_Name FROM Division"
        Dim da As New OleDbDataAdapter(com, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Division")
        dtgDiv.DataSource = ds.Tables(0)
        Me.dtgDiv.Columns(0).HeaderText = "Division Code"
        Me.dtgDiv.Columns(1).HeaderText = "Name"


        'ds.Tables("Division").DefaultView.ToTable(True, "Div_Code")
        'If ds.Tables.Count = 0 Then
        'Exit Sub
        'dt.DefaultView.ToTable(True, "Div_Code")
        'End If

    End Sub
    Private Sub btnAgent_Click(sender As Object, e As EventArgs) Handles btnAgent.Click
        yaAgent()
        notArea()
        notBranch()
        notBank()
        notDiv()

        txtSearch2.Text = ""
        txtSearch3.Text = ""
        txtSearch4.Text = ""
        txtSearch5.Text = ""

        refreshData1()
        refreshData2()
        refreshData3()
        refreshData4()
        refreshData5()
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        yaArea()
        notAgent()
        notBranch()
        notBank()
        notDiv()

        txtSearch1.Text = ""
        txtSearch3.Text = ""
        txtSearch4.Text = ""
        txtSearch5.Text = ""

        refreshData1()
        refreshData2()
        refreshData3()
        refreshData4()
        refreshData5()
    End Sub

    Private Sub btnBanks_Click(sender As Object, e As EventArgs) Handles btnBanks.Click
        yaBank()
        notAgent()
        notArea()
        notBranch()
        notDiv()

        txtSearch2.Text = ""
        txtSearch1.Text = ""
        txtSearch4.Text = ""
        txtSearch5.Text = ""

        refreshData1()
        refreshData2()
        refreshData3()
        refreshData4()
        refreshData5()
    End Sub

    Private Sub btnBran_Click(sender As Object, e As EventArgs) Handles btnBran.Click
        yaBranch()
        notArea()
        notAgent()
        notBank()
        notDiv()

        txtSearch2.Text = ""
        txtSearch3.Text = ""
        txtSearch1.Text = ""
        txtSearch5.Text = ""

        refreshData1()
        refreshData2()
        refreshData3()
        refreshData4()
        refreshData5()
    End Sub
    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        'For cel As Integer = 0 To dtgDiv.Rows.Count - 1
        'For cel2 As Integer = cel + 1 To dtgDiv.Rows.Count - 1
        'If dtgDiv.Rows(cel).Cells(0).Value = dtgDiv.Rows(cel2).Cells(0).Value Then
        '            dtgDiv.Rows.RemoveAt(cel2)
        'End If
        'Next
        'Next

        'Dim view As New DataView()
        'Dim disValue As DataTable = view.ToTable(True, "Div_Code")

        yaDiv()
        notArea()
        notAgent()
        notBank()
        notBranch()

        txtSearch2.Text = ""
        txtSearch3.Text = ""
        txtSearch4.Text = ""
        txtSearch1.Text = ""

        refreshData1()
        refreshData2()
        refreshData3()
        refreshData4()
        refreshData5()
    End Sub
    Private Sub btnDel1_Click(sender As Object, e As EventArgs) Handles btnDel1.Click
        Dim que As String
        Try
            con.Open()
            For i As Integer = Me.dtgAgee.SelectedRows.Count - 1 To 0 Step -1
                que = "DELETE FROM Agents WHERE Agent_Code= '" & Me.dtgAgee.SelectedRows(i).Cells(0).Value.ToString() & "'"
                dad = New OleDbDataAdapter(que, con)
                dst = New DataSet()
                dad.Fill(dst)
                Me.dtgAgee.Rows.Remove(Me.dtgAgee.SelectedRows(i))
            Next
            refreshData1()
            txtSearch1.Text = ""
            MessageBox.Show("Record has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnDel5_Click(sender As Object, e As EventArgs) Handles btnDel5.Click
        If Me.dtgDiv.Rows.Count > 0 Then

            If dtgDiv.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgDiv.SelectedRows(0).Cells("Div_Code").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Division] WHERE [Div_Code] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                refreshData5()
                txtSearch5.Text = ""
                con.Close()

            Else

                MessageBox.Show("No record selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else

            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub btnDel4_Click(sender As Object, e As EventArgs) Handles btnDel4.Click
        If Me.dtgBranch.Rows.Count > 0 Then

            If dtgBranch.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgBranch.SelectedRows(0).Cells("Branch_ID").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Branch] WHERE [Branch_ID] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                refreshData4()
                txtSearch4.Text = ""
                con.Close()

            Else

                MessageBox.Show("No record selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else

            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub btnDel3_Click(sender As Object, e As EventArgs) Handles btnDel3.Click
        If Me.dtgBanks.Rows.Count > 0 Then

            If dtgBanks.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgBanks.SelectedRows(0).Cells("Bank_ID").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Banks] WHERE [Bank_ID] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                refreshData3()
                txtSearch3.Text = ""
                con.Close()

            Else

                MessageBox.Show("No record selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else

            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub btnDel2_Click(sender As Object, e As EventArgs) Handles btnDel2.Click
        If Me.dtgArea.Rows.Count > 0 Then

            If dtgArea.SelectedRows.Count > 0 Then

                Dim intID As String = Me.dtgArea.SelectedRows(0).Cells("Area_Code").Value

                con.Close()
                con.Open()
                cmd = New OleDbCommand
                cmd.Connection = con

                If MessageBox.Show("Do you want to remove this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    cmd.CommandText = "DELETE FROM [Area] WHERE [Area_Code] = '" & intID & "'"
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                refreshData2()
                txtSearch2.Text = ""
                con.Close()

            Else

                MessageBox.Show("No record selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else

            MessageBox.Show("No record to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        agent.Show()
        agent.cmbAre.Text = ""
        agent.lblAre.Text = "-"
        agent.btnAdd.Enabled = False
        agent.btnAdd.BackColor = Color.Gray
        Me.Hide()
    End Sub
    Private Sub btnAdd4_Click(sender As Object, e As EventArgs) Handles btnAdd4.Click
        branch.Show()
        Me.Hide()

        branch.btnSave.Visible = False
        branch.btnAdd.Visible = True
    End Sub

    Private Sub btnAdd5_Click(sender As Object, e As EventArgs) Handles btnAdd5.Click
        division.Show()
        Me.Hide()

        division.btnAdd.Enabled = False
        division.btnAdd.BackColor = Color.Gray
        division.cmbAgent.Text = ""
        division.lblAgent.Text = "-"
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        bank.Show()
        Me.Hide()

        bank.btnSave.Visible = False
        bank.btnAdd.Visible = True
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        area.Show()
        Me.Hide()

        area.btnSave.Visible = False
        area.btnAdd.Visible = True
    End Sub
    Private Sub dtgDiv_DoubleClick(sender As Object, e As EventArgs) Handles dtgDiv.DoubleClick
        Dim form As New division
        form.txtCode.Text = dtgDiv.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgDiv.CurrentRow.Cells(1).Value.ToString

        form.cmbAgent.SelectedIndex = -1
        form.lblAgent.Text = ""

        form.txtCode.Enabled = False
        form.txtCode.BackColor = Color.White

        form.txtName.Enabled = False
        form.txtName.BackColor = Color.White

        form.ShowDialog()
        form.btnAdd.Enabled = True
    End Sub

    Private Sub dtgAgee_DoubleClick(sender As Object, e As EventArgs) Handles dtgAgee.DoubleClick
        Dim form As New agent
        form.txtCode.Text = dtgAgee.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgAgee.CurrentRow.Cells(1).Value.ToString

        form.cmbAre.SelectedIndex = -1
        form.lblAre.Text = ""

        form.txtCode.Enabled = False
        form.txtCode.BackColor = Color.White

        form.txtName.Enabled = False
        form.txtName.BackColor = Color.White

        form.ShowDialog()
        form.btnAdd.Enabled = True
    End Sub

    Private Sub dtgArea_DoubleClick(sender As Object, e As EventArgs) Handles dtgArea.DoubleClick
        Dim form As New area
        form.txtCode.Text = dtgArea.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgArea.CurrentRow.Cells(1).Value.ToString

        form.txtCode.Enabled = False
        form.txtCode.BackColor = Color.White

        form.ShowDialog()
        form.btnAdd.Enabled = True
    End Sub
    Private Sub dtgBanks_DoubleClick(sender As Object, e As EventArgs) Handles dtgBanks.DoubleClick
        Dim form As New bank
        form.txtCode.Text = dtgBanks.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgBanks.CurrentRow.Cells(1).Value.ToString

        form.txtCode.Enabled = False
        form.txtCode.BackColor = Color.White

        form.ShowDialog()
        form.btnAdd.Enabled = True
    End Sub
    Private Sub dtgBranch_DoubleClick(sender As Object, e As EventArgs) Handles dtgBranch.DoubleClick
        Dim form As New branch
        form.txtCode.Text = dtgBranch.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dtgBranch.CurrentRow.Cells(1).Value.ToString

        form.txtCode.Enabled = False
        form.txtCode.BackColor = Color.White

        form.ShowDialog()
        form.btnAdd.Enabled = True
    End Sub
    Private Sub txtSearch1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch1.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Agents WHERE Agent_Name LIKE '%" & txtSearch1.Text & "%'", con)
        da.Fill(dt)

        dtgAgee.DataSource = dt.DefaultView

        con.Close()
    End Sub
    Private Sub txtSearch2_TextChanged(sender As Object, e As EventArgs) Handles txtSearch2.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Area WHERE Area_Name LIKE '%" & txtSearch2.Text & "%'", con)
        da.Fill(dt)

        dtgArea.DataSource = dt.DefaultView

        con.Close()
    End Sub
    Private Sub txtSearch3_TextChanged(sender As Object, e As EventArgs) Handles txtSearch3.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Banks WHERE Bank_Name LIKE '%" & txtSearch3.Text & "%'", con)
        da.Fill(dt)

        dtgBanks.DataSource = dt.DefaultView

        con.Close()
    End Sub
    Private Sub txtSearch4_TextChanged(sender As Object, e As EventArgs) Handles txtSearch4.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Branch WHERE Branch_Name LIKE '%" & txtSearch4.Text & "%'", con)
        da.Fill(dt)

        dtgBranch.DataSource = dt.DefaultView

        con.Close()
    End Sub

    Private Sub txtSearch5_TextChanged(sender As Object, e As EventArgs) Handles txtSearch5.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT Div_Code, Div_Name FROM Division WHERE Div_Name LIKE '%" & txtSearch5.Text & "%'", con)
        da.Fill(dt)

        dtgDiv.DataSource = dt.DefaultView

        con.Close()
    End Sub
End Class