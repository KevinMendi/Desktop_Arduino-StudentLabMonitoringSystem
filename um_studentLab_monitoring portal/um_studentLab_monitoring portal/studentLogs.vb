Imports MySql.Data.MySqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class studentLogs
    Public Sub getSubjectData()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("select s1.name, s2.sbjctname, s2.type, s2.sched, " & _
                                    "l1.timeIn, l2.timeOut, l1.dateIn from login l1 " & _
                                    "left join logout l2 " & _
                                    "on l1.studentid = l2.studentid " & _
                                    " left join mst_student s1 " & _
                                    "on s1.idno = l1.studentid " & _
                                    "left join mst_subject s2 " & _
                                    "on s2.sbjctcode = l1.tblsbjctid " & _
                                    "where s1.name='" & subjectSearch.Text & "' and s2.type='" & cmbtype.Text & "' and l1.dateIn between " & _
                                    " '" & dtpDateFrom.Text & "' and '" & dtpDateTo.Text & "' ", con)
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

    Public Sub getSubjectDataAll()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("select s1.name, s2.sbjctname, s2.type, s2.sched, " & _
                                    "l1.timeIn, l2.timeOut, l1.dateIn from login l1 " & _
                                    "left join logout l2 " & _
                                    "on l1.studentid = l2.studentid " & _
                                    " left join mst_student s1 " & _
                                    "on s1.idno = l1.studentid " & _
                                    "left join mst_subject s2 " & _
                                    "on s2.sbjctcode = l1.tblsbjctid " & _
                                    "where s1.name='" & subjectSearch.Text & "'  and l1.dateIn between " & _
                                    " '" & dtpDateFrom.Text & "' and '" & dtpDateTo.Text & "' ", con)
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
            cmd = New MySqlCommand("SELECT Distinct name FROM mst_student", con)
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


    Private Sub studentLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutocompleteBySubjectName()
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If Len(Trim(subjectSearch.Text)) = 0 Then
            ErrorProvider1.SetError(subjectSearch, "Please Enter Student Name")
            MessageBox.Show("Please Enter Student ID No", "Sytem Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            subjectSearch.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbtype.Text)) = 0 Then
            ErrorProvider1.SetError(cmbtype, "Please Type of Class")
            MessageBox.Show("Please Enter Student ID No", "Sytem Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbtype.Focus()
            Exit Sub
        End If


        If dtpDateTo.Text < dtpDateFrom.Text Then
            MessageBox.Show("Date To must no be greater than Date From", "Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvUser.Visible = False
            btnexport.Visible = False
            Exit Sub
        End If

        If cmbtype.Text = "1ST TERM" Or cmbtype.Text = "2ND TERM" Then
            getSubjectData()
            dgvUser.Visible = True
            btnexport.Visible = True
        Else
            getSubjectDataAll()
            dgvUser.Visible = True
            btnexport.Visible = True
        End If
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        dgvUser.Visible = False
        btnexport.Visible = False
        subjectSearch.Text = ""
        cmbtype.Text = Nothing
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

#Region "GET ALL DATA"
    Public Sub _fetchAlldata()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("select s1.name, s2.sbjctname, s2.type, s2.sched, " & _
                                    "l1.timeIn, l2.timeOut, l1.dateIn from login l1 " & _
                                    "left join logout l2 " & _
                                    "on l1.studentid = l2.studentid " & _
                                    " left join mst_student s1 " & _
                                    "on s1.idno = l1.studentid " & _
                                    "left join mst_subject s2 " & _
                                    "on s2.sbjctcode = l1.tblsbjctid " & _
                                    "where  l1.dateIn between " & _
                                    " '" & dtpDateFrom.Text & "' and '" & dtpDateTo.Text & "' ", con)
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
#End Region

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton3.Click
        If dtpDateTo.Text < dtpDateFrom.Text Then
            MessageBox.Show("Date To must no be greater than Date From", "Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvUser.Visible = False
            btnexport.Visible = False
            Exit Sub
        End If

        If cmbtype.Text = "1ST TERM" Or cmbtype.Text = "2ND TERM" Then
            _fetchAlldata()
            dgvUser.Visible = True
            btnexport.Visible = True
        Else
            _fetchAlldata()
            dgvUser.Visible = True
            btnexport.Visible = True
        End If
    End Sub
End Class