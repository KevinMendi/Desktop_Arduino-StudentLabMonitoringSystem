Imports MySql.Data.MySqlClient
Module common
    Public con As MySqlConnection = Nothing
    Public cmd, cmd1 As MySqlCommand
    Public rdr As MySqlDataReader = Nothing
    Public ds As DataSet
    Public adp As MySqlDataAdapter
    Public dtable As DataTable
    Public TempFileNames2 As String
End Module
