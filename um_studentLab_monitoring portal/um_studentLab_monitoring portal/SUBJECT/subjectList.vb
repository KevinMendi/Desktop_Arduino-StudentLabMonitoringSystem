
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class subjectList
    Public Sub getSubjectData()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("SELECT * from mst_subject", con)
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
            cmd = New MySqlCommand("SELECT Distinct sbjctname FROM mst_subject", con)
            ds = New DataSet()
            adp = New MySqlDataAdapter(cmd)
            adp.Fill(ds, "sbjctname")
            Dim col As AutoCompleteStringCollection = New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("sbjctname").ToString())
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
    Private Sub subjectList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getSubjectData()
        AutocompleteBySubjectName()
    End Sub

    Private Sub subjectSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectSearch.Click
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("SELECT * from mst_student where name like '" & subjectSearch.Text & "%' ", con)
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

    Private Sub dgvUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUser.Click
        Try
            If dgvUser.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgvUser.SelectedRows(0)
                assignStudentSubject.lbid.Text = dr.Cells(0).Value.ToString
                assignStudentSubject.subjctcode.Text = dr.Cells(1).Value.ToString
                assignStudentSubject.subjctname.Text = dr.Cells(2).Value.ToString
                assignStudentSubject.subjctdesc.Text = dr.Cells(3).Value.ToString
                assignStudentSubject.subjcttype.Text = dr.Cells(5).Value.ToString
                assignStudentSubject.sunbjcttime.Text = dr.Cells(6).Value.ToString
                assignStudentSubject.subjctsched.Text = dr.Cells(4).Value.ToString
                assignStudentSubject.btnsave.Enabled = True
                Me.Hide()
                assignStudentSubject.Show()
            End If


        Catch ex As Exception
            '  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub subjectSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectSearch.TextChanged
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("SELECT * from mst_student where name like '" & subjectSearch.Text & "%' ", con)
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
End Class