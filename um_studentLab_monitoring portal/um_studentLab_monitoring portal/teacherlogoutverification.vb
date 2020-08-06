Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class teacherlogoutverification
    Public Sub getSubjectData()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            cmd = New MySqlCommand("select s2.* from tbl_subject t1 " & _
                                    "left join mst_teacher s1 " & _
                                    "on t1.teacherid = s1.idno " & _
                                    "left join mst_subject s2 " & _
                                    "on t1.sbjctcode=s2.sbjctcode " & _
                                    "where t1.teacherid = '" & txtTeacherID.Text & "' and s2.type='" & mainmenu.ToolStripStatusLabel7.Text & "' OR s2.type='SEM'", con)
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

    Public Sub _reset()
        txtTeacherID.Text = ""
        dgvUser.DataSource = Nothing
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        getSubjectData()
    End Sub

    Private Sub dgvUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUser.Click
        If MessageBox.Show("Are you sure you want this subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                If dgvUser.Rows.Count > 0 Then
                    Dim dr As DataGridViewRow = dgvUser.SelectedRows(0)
                    Logout.lbCode.Text = dr.Cells(1).Value.ToString
                    Logout.lbSubjectName.Text = dr.Cells(2).Value.ToString
                    Logout.lbtype.Text = dr.Cells(5).Value.ToString
                    Logout.lbSubjectTime.Text = dr.Cells(6).Value.ToString
                    Me.Hide()
                End If
            Catch ex As Exception

            End Try
            



            Me.Hide()
        End If
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Logout.Close()
        Me.Hide()
    End Sub
End Class