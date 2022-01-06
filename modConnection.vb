Imports System.Data.OleDb
Module modConnection
    Public cn As New OleDb.OleDbConnection
    Public cm As New OleDb.OleDbCommand
    Public dr As OleDbDataReader
    Public Sub connection()
        cn = New OleDb.OleDbConnection
        With cn
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\Users\User\Documents\Visual Studio 2012\Projects\Sportmgkit\Sportmgkit\bin\Debug\StockDB.mdb"
            .Open()
        End With
    End Sub
End Module
