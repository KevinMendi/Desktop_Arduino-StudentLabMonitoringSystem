Public Class mainmenu

  
    Private Sub mainmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _UserControl As New login
        Me.ShowModalPanel(_UserControl)

    End Sub

    Private Sub Login1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub AddNewStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewStudentRecordToolStripMenuItem.Click
        newstudent.ShowDialog()
    End Sub

    Private Sub feePaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles feePaymentToolStripMenuItem1.Click
        Dim _login As New login
        Me.ShowModalPanel(_login, DevComponents.DotNetBar.Controls.eSlideSide.Top)
        _login.txt_user.Text = ""
        _login.txt_pass.Text = ""
        ToolStripStatusLabel7.Text = ""
        lbCom.Text = ""
        connectionSetting.Close()
    End Sub

    Private Sub ManageBillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageBillingToolStripMenuItem.Click
        assignStudentSubject.ShowDialog()
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUserToolStripMenuItem.Click
        newuser.ShowDialog()
    End Sub

    Private Sub ManageNewCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageNewCourseToolStripMenuItem.Click
        course.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = DateAndTime.Now.ToString
    End Sub

    Private Sub ManageUserAccessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserAccessToolStripMenuItem.Click
        useraccess.Show()
    End Sub

    Private Sub AddNewTrainingCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewTrainingCourseToolStripMenuItem.Click
        monitoring.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        subjectperteacher.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        teacher.ShowDialog()
    End Sub

    Private Sub attendanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attendanceToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click

    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        newSubject.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click

    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Logout.ShowDialog()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        studentsubjectreport.ShowDialog()
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        teachersubjectreport.ShowDialog()
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSWordToolStripMenuItem.Click
        studentLogs.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        course.ShowDialog()
    End Sub
End Class
