Imports MySql.Data.MySqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class teachersubjectreport
    Public Sub getSubjectData()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("select s2.* from tbl_subject t1 " & _
                                    "left join mst_teacher s1 " & _
                                    "on t1.teacherid = s1.idno " & _
                                    "left join mst_subject s2 " & _
                                    "on t1.sbjctcode=s2.sbjctcode " & _
                                    "where s1.name = '" & subjectSearch.Text & "'", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgvUser.Rows.Clear()
            While (rdr.Read() = True)
                dgvUser.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub getSubjectDatafilter()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("select s2.* from tbl_subject t1 " & _
                                    "left join mst_teacher s1 " & _
                                    "on t1.teacherid = s1.idno " & _
                                    "left join mst_subject s2 " & _
                                    "on t1.sbjctcode=s2.sbjctcode " & _
                                    "where s1.name = '" & subjectSearch.Text & "' and s2.type='" & cmbtype.Text & "'", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgvUser.Rows.Clear()
            While (rdr.Read() = True)
                dgvUser.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

#Region "AUTO COMPLETE"
    Sub AutocompleteBySubjectName()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("SELECT Distinct name FROM mst_teacher", con)
            ds = New DataSet()
            adp = New MySqlDataAdapter(cmd)
            adp.Fill(ds, "name")
            Dim col As AutoCompleteStringCollection = New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("name").ToString())
            Next
            subjectSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            subjectSearch.AutoCompleteCustomSource = col
            subjectSearch.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
#End Region

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If cmbtype.Text = "1ST TERM" Or cmbtype.Text = "2ND TERM" Then
            getSubjectDatafilter()
            btnexport.Visible = True
            dgvUser.Visible = True
        Else
            getSubjectData()
            btnexport.Visible = True
            dgvUser.Visible = True
        End If
    End Sub

    Private Sub teachersubjectreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutocompleteBySubjectName()
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        subjectSearch.Text = ""
        cmbtype.Text = Nothing
        btnexport.Visible = False
        dgvUser.Visible = False
    End Sub

    Private Sub btnexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexport.Click
        If dgvUser.RowCount = Nothing Then
            MessageBox.Show("Nothing to be export", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else



            Dim rowsTotal, colsTotal As Short
            Dim I, j, iC As Short
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Excel.Application
            Try
                Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
                Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
                xlApp.Visible = True

                rowsTotal = dgvUser.RowCount
                colsTotal = dgvUser.Columns.Count - 1
                With excelWorksheet
                    .Cells.Select()
                    .Cells.Delete()
                    For iC = 0 To colsTotal
                        .Cells(1, iC + 1).Value = dgvUser.Columns(iC).HeaderText
                    Next
                    For I = 0 To rowsTotal - 1
                        For j = 0 To colsTotal
                            .Cells(I + 2, j + 1).value = dgvUser.Rows(I).Cells(j).Value
                        Next j
                    Next I
                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 12

                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                xlApp = Nothing
            End Try
        End If
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class