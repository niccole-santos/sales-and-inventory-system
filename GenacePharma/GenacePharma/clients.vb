Imports System.Data.OleDb
Public Class clients
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homep.Enabled = True
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        clientAdd.Show()
        clientAdd.cmbDiv.Text = ""
        clientAdd.lblDiv.Text = "-"
        clientAdd.cmbAgent.Text = ""
        clientAdd.lblAge.Text = "-"
        clientAdd.cmbArea.Text = ""
        clientAdd.lblArea.Text = "-"
        clientAdd.btnSave.Visible = False
        clientAdd.btnAdd.Visible = True
    End Sub
    Private Sub clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientTable.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.ClientTable.Clients)
        Me.cmbCate.Items.Add("Dispensing")
        Me.cmbCate.Items.Add("Hospital")
        Me.cmbCate.Items.Add("Pharmacy")

        cmbCate.SelectedIndex = 0

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim que As String
        Try
            con.Open()
            For i As Integer = Me.dataClient.SelectedRows.Count - 1 To 0 Step -1
                que = "DELETE FROM Clients WHERE Client_ID= '" & Me.dataClient.SelectedRows(i).Cells(0).Value.ToString() & "'"
                dad = New OleDbDataAdapter(que, con)
                dst = New DataSet()
                dad.Fill(dst)
                Me.dataClient.Rows.Remove(Me.dataClient.SelectedRows(i))
            Next
            refreshData()
            fil()
            MessageBox.Show("Record has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub refreshData()
        con.Close()
        con.Open()
        dad = New OleDbDataAdapter("SELECT Client_ID, Client_Name FROM [Clients] ORDER BY [Client_ID]", con)
        Dim dt3 As New DataTable
        dad.Fill(dt3)
        dataClient.DataSource = dt3
        con.Close()
    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Clients WHERE Client_Name LIKE '%" & txtfind.Text & "%' AND Client_Type LIKE '%" & cmbCate.Text & "%'", con)
        da.Fill(dt)

        dataClient.DataSource = dt.DefaultView

        con.Close()
    End Sub

    Private Sub cmbCate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCate.SelectedIndexChanged
        fil()
    End Sub

    Private Sub dataClient_DoubleClick(sender As Object, e As EventArgs) Handles dataClient.DoubleClick
        Dim form As New clientAdd
        Dim index As Integer

        form.txtCode.Enabled = False
        form.cmbCode.Enabled = False
        form.lblDiv.Text = ""

        form.txtCode.Text = dataClient.CurrentRow.Cells(0).Value.ToString
        form.txtName.Text = dataClient.CurrentRow.Cells(1).Value.ToString


        form.ShowDialog()
    End Sub
    Private Sub fil()
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        dst.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Clients WHERE Client_Type LIKE '%" & cmbCate.Text & "%'", con)
        da.Fill(dt)

        dataClient.DataSource = dt.DefaultView

        con.Close()
    End Sub
End Class