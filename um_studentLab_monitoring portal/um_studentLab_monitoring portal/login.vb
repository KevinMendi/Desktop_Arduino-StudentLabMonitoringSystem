Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Public Class login
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(txt_user.Text)) = 0 Then
            ErrorProvider1.SetError(txt_user, "Please enter you Username")
            MessageBox.Show("Please enter you Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_user.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_pass.Text)) = 0 Then
            ErrorProvider1.SetError(txt_pass, "Please your password")
            MessageBox.Show("Please your password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_pass.Focus()
            Exit Sub
        End If

        Try
            con = New MySqlConnection(conn)
            con.Open()
            Dim ct As String = "select access,name from mst_user where username=@find and password=md5('" & txt_pass.Text & "')"
            Dim cmd As New MySqlCommand
            Dim rdr As MySqlDataReader
            cmd.Connection = con
            cmd.CommandText = ct
            cmd.Parameters.Add(New MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30, "username"))
            cmd.Parameters("@find").Value = txt_user.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then

                lbaccess.Text = rdr("access").ToString
                ' mainmenu.lbusername.Text = rdr("position").ToString
                mainmenu.lbuser.Text = rdr("name").ToString
                mainmenu.ToolStripStatusLabel6.Text = rdr("access").ToString.ToUpper
                mainmenu.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Top)
                connectionSetting.ShowDialog()
            Else
                MessageBox.Show("Invalid Username", "Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

                If rdr Is Nothing Then
                    rdr.Close()
                End If
            End If

            If lbaccess.Text = "Admin" Or lbaccess.Text = "ADMIN" Then
                mainmenu.userRegistrationToolStripMenuItem.Enabled = True
                mainmenu.studentToolStripMenuItem1.Enabled = True
                mainmenu.ToolStripMenuItem5.Enabled = True
                mainmenu.ToolStripMenuItem3.Enabled = True
                mainmenu.ToolStripMenuItem2.Enabled = True
                mainmenu.ToolStripMenuItem8.Enabled = True
            Else
                mainmenu.userRegistrationToolStripMenuItem.Enabled = False
                mainmenu.studentToolStripMenuItem1.Enabled = False
                mainmenu.ToolStripMenuItem5.Enabled = False
                mainmenu.ToolStripMenuItem3.Enabled = False
                mainmenu.ToolStripMenuItem2.Enabled = False
                mainmenu.ToolStripMenuItem8.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
