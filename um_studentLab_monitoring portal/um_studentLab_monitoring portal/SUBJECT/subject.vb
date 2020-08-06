
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class subject

    Public Sub getSubjectData()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("SELECT * from mst_subject", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgvUser.Rows.Clear()
            While (rdr.Read() = True)
                dgvUser.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7))
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


    Private Sub subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getSubjectData()
        AutocompleteBySubjectName()
    End Sub

    Private Sub dgvUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUser.Click
        Try
            If dgvUser.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgvUser.SelectedRows(0)
                newSubject.lbid.Text = dr.Cells(0).Value.ToString
                newSubject.scode.Text = dr.Cells(1).Value.ToString
                newSubject.sName.Text = dr.Cells(2).Value.ToString
                newSubject.sDesc.Text = dr.Cells(3).Value.ToString
                newSubject.sSchd.Text = dr.Cells(4).Value.ToString
                newSubject.sType.Text = dr.Cells(5).Value.ToString
                newSubject.sTime.Text = dr.Cells(6).Value.ToString
                newSubject.sDept.Text = dr.Cells(7).Value.ToString
                newSubject.btnsave.Enabled = False
                newSubject.btndelete.Enabled = True
                newSubject.btnupdate.Enabled = True
                Me.Hide()
                newSubject.ShowDialog()
            End If


        Catch ex As Exception
            '  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub subjectSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectSearch.TextChanged
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("SELECT * from mst_subject where sbjctname like '" & subjectSearch.Text & "%' ", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgvUser.Rows.Clear()
            While (rdr.Read() = True)
                dgvUser.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class
