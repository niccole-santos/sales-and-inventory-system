Imports System.ComponentModel

Public Class homep
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        oras.Text = TimeOfDay.ToString("hh:mm:ss tt")
        araw.Text = Date.Now.ToString("MMM. dd, yyyy")
        Label13.Text = Date.Now.ToString("[ dddd ]")
    End Sub

    Private Sub homep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.Manual
        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With

        tran.Hide()
        payments.Hide()
        rsns.Hide()
        report.Hide()

        Label6.Hide()
        Label11.Hide()
        Label4.Hide()
        Label5.Hide()
    End Sub
    Private Sub client_Click(sender As Object, e As EventArgs) Handles client.Click
        Me.Enabled = False
        clients.Show()
    End Sub
    Private Sub supplier_Click(sender As Object, e As EventArgs) Handles supplier.Click
        Me.Enabled = False
        suppliers.Show()
    End Sub
    Private Sub invoices_Click(sender As Object, e As EventArgs) Handles invoices.Click
        Me.Enabled = False
        invList.Show()
    End Sub
    Private Sub dueAccs_Click(sender As Object, e As EventArgs) Handles dueAccs.Click
        Me.Enabled = False
        dueAcc.Show()
    End Sub

    Private Sub record_Click(sender As Object, e As EventArgs) Handles record.Click
        Me.Enabled = False
        records.Show()
    End Sub

    Private Sub stock_Click(sender As Object, e As EventArgs) Handles stock.Click
        Me.Enabled = False
        stocks.Show()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
        remindes.Close()
        login.Show()
    End Sub

    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        Me.Enabled = False
        accs.Show()
    End Sub

    Private Sub btnRem_Click(sender As Object, e As EventArgs) Handles btnRem.Click
        Me.Enabled = True
        remindes.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub
End Class