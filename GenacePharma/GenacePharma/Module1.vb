Imports System.Data.OleDb

Module Module1
    Public query As String

    Public con As OleDbConnection = New OleDbConnection("PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\nxcos\Desktop\codes\GenacePharma\GenacePharma\GenacePharma.accdb")

    Public dad As OleDbDataAdapter
    Public rdr As OleDbDataReader
    Public dt As DataTable
    Public drd As OleDbDataReader
    Public cmd As OleDbCommand
    Public dst As New DataSet
    Public currentrow As Integer
    Public table1 As DataTableCollection
    Public source1 As New BindingSource

End Module