Imports System.Data.OleDb
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Public Class remindes
    Private strFormat As StringFormat
    Private arrcolLeft As ArrayList
    Private arrcolWidth As ArrayList
    Private iCellHeight As Integer = 0
    Private iTotalWidth As Integer = 0
    Private iRow As Integer = 0
    Private bFirst As Boolean = False
    Private bNew As Boolean = False
    Private iHeaderHeight As Integer = 0
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer
    Private Sub reminders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim com As String = "SELECT Description, OnHand FROM Stocks WHERE OnHand <= 15"
        Dim da As New OleDbDataAdapter(com, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Stocks")
        dtgSto.DataSource = ds.Tables(0)
        Me.dtgSto.Columns(1).HeaderText = "On Hand"

        Dim comm As String = "SELECT Description, Expiry_Date, OnHand FROM Stocks WHERE cdate(Expiry_Date) <= cdate('" & Date.Today.AddMonths(3).ToString("MM/dd/yyyy") & "')"
        Dim daa As New OleDbDataAdapter(comm, con)
        Dim dss As New DataSet()
        daa.Fill(dss, "Stocks")
        dtgEx.DataSource = dss.Tables(0)

        rtStocks.Visible = False
        Button1.Hide()
        Button2.Hide()
    End Sub
    Private Sub btnPrintu_Click(sender As Object, e As EventArgs) Handles btnPrintu.Click
        Dim PrintDlg As PrintDialog = New PrintDialog()
        Dim PrintDlgRslt As DialogResult = New DialogResult()
        Dim MyDoc As PrintDocument = New PrintDocument()

        PrintDlg.Document = MyDoc

        PrintDlgRslt = PrintDlg.ShowDialog()
        If PrintDlgRslt = DialogResult.OK Then
            AddHandler MyDoc.PrintPage, AddressOf PrintDocument1_PrintPage
            MyDoc.Print()
        End If
    End Sub

    Private Sub btnPrinte_Click(sender As Object, e As EventArgs) Handles btnPrinte.Click
        dtgSto.Visible = False

        For i As Integer = 0 To dtgSto.Rows.Count - 2 Step +1
            For j As Integer = 0 To dtgSto.Columns.Count - 1 Step +1
                rtStocks.AppendText(vbTab & dtgSto.Rows(i).Cells(j).Value.ToString() & vbTab)
            Next
            rtStocks.AppendText("")
            rtStocks.AppendText("_________________________________")
        Next
        MessageBox.Show("Document is ready for printing", "Print document", MessageBoxButtons.OK, MessageBoxIcon.Information)

        rtStocks.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim printdoc As New PrintDocument
            AddHandler printdoc.PrintPage, AddressOf Me.printText
            printdoc.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Beep()
        End Try
    End Sub
    Private Sub printText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        ev.Graphics.DrawString(rtStocks.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 0))
    End Sub
    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Try
            e.Graphics.DrawString(rtStocks.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 0))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Beep()
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim oStringFormat As StringFormat
        Dim TotalWidth As Integer
        Dim nRowPos As Integer = 0
        Dim NewPage As Boolean = True

        Dim PageNo As Integer = 1
        Dim Header As String = "Consolidated Report"
        Dim sUserName As String = "Genace Pharma Distributor"

        Dim oColumnLefts As New ArrayList
        Dim oColumnWidths As New ArrayList
        Dim oColumnTypes As New ArrayList

        Dim Height As Integer
        Dim Width As Integer
        Dim i As Integer
        Dim RowsPerPage As Integer
        Dim Top As Integer = e.MarginBounds.Top
        Dim Left As Integer = e.MarginBounds.Left

        TotalWidth = 0

        For Each DColumn As DataGridViewColumn In dtgEx.Columns
            TotalWidth += DColumn.Width
        Next

        If PageNo = 1 Then
            For Each DColumn As DataGridViewColumn In dtgEx.Columns
                Width = CType(Math.Floor(DColumn.Width / TotalWidth * TotalWidth * (e.MarginBounds.Width / TotalWidth)), Int16)
                Height = e.Graphics.MeasureString(DColumn.HeaderText, DColumn.InheritedStyle.Font, Width).Height + 11
                oColumnLefts.Add(Left)
                oColumnWidths.Add(Width)
                oColumnTypes.Add(DColumn.GetType)
                Left += Width
            Next
        End If

        Do While nRowPos < dtgEx .Rows.Count
            Dim oRow As DataGridViewRow = dtgEx.Rows(nRowPos)
            If Top + Height >= e.MarginBounds.Height + e.MarginBounds.Top Then
                DrawFooter(e, RowsPerPage)
                NewPage = True
                PageNo += 1
                e.HasMorePages = True
                Exit Sub
            Else

                If NewPage Then
                    Top = e.MarginBounds.Top
                    i = 0
                    For Each oColumn As DataGridViewColumn In dtgEx.Columns
                        e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), Top, oColumnWidths(i), Height))
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), Top, oColumnWidths(i), Height))
                        e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), Top, oColumnWidths(i), Height), oStringFormat)
                        i += 1
                    Next
                    NewPage = False
                End If
                Top += Height
                i = 0
                For Each oCell As DataGridViewCell In oRow.Cells

                    If oColumnTypes(i) Is GetType(DataGridViewTextBoxColumn) Then
                        e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), Top, oColumnWidths(i), Height), oStringFormat)

                    ElseIf oColumnTypes(i) Is GetType(DataGridViewImageColumn) Then
                        Dim oCellSize As Rectangle = New Rectangle(oColumnLefts(i), Top, oColumnWidths(i), Height)
                        Dim oImageSize As Size = CType(oCell.Value, Image).Size
                        e.Graphics.DrawImage(oCell.Value, New Rectangle(oColumnLefts(i) + CType(((oCellSize.Width - oImageSize.Width) / 2), Int32), Top + CType(((oCellSize.Height - oImageSize.Height) / 2), Int32), CType(oCell.Value, Image).Width, CType(oCell.Value, Image).Height))
                    End If

                    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), Top, oColumnWidths(i), Height))
                    i += 1
                Next
            End If

            nRowPos += 1
            RowsPerPage += 1
        Loop
        DrawFooter(e, RowsPerPage)
        e.HasMorePages = False
    End Sub

    Private Sub DrawFooter(e As PrintPageEventArgs, rowsPerPage As Integer)
        Throw New NotImplementedException()
    End Sub
End Class