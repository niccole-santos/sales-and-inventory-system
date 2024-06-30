Imports System.Data.OleDb
Public Class dueAcc
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homep.Enabled = True
        Me.Close()
    End Sub

    Private Sub dueAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com As String = "SELECT Client_ID, Client_Name, Credit_Limit FROM Clients WHERE Credit_Limit > 150"
        Dim da As New OleDbDataAdapter(com, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Clients")
        dtgDue.DataSource = ds.Tables(0)
        Me.dtgDue.Columns(0).HeaderText = "Client ID"
        Me.dtgDue.Columns(1).HeaderText = "Name"
        Me.dtgDue.Columns(2).HeaderText = "Balance"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mailin.Show()
        Me.Hide()
    End Sub
End Class