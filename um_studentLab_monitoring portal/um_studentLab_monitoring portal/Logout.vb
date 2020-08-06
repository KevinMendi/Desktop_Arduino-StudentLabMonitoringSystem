Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports System.IO
Public Class Logout
    Public con As MySqlConnection
    Dim a As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\char.txt")
    Dim myPort As Array  'COM Ports detected on the system will be stored here
    Delegate Sub SetTextCallback(ByVal [text] As String)

#Region "CHECK ENROLL STUDENT"
    Public Sub _checkTeacher()
        Try
            con = New MySqlConnection(conn)
            con.Open()

            Dim qry As String = "select s2.sbjctcode, s2.sbjctname, s2.type, s2.time, s1.name from tbl_subject t1 " & _
                                "left join mst_teacher s1 " & _
                                "on t1.teacherid = s1.idno " & _
                                "left join mst_subject s2 " & _
                                "on t1.sbjctcode=s2.sbjctcode " & _
                                "where t1.teacherid='" & teacherlogoutverification.txtTeacherID.Text & "'"
            Dim dr As MySqlDataReader
            Dim adapt As New MySqlDataAdapter
            Dim cmd As New MySqlCommand

            cmd.CommandText = qry
            cmd.Connection = con
            adapt.SelectCommand = cmd
            dr = cmd.ExecuteReader
            If dr.Read Then
                Panel2.Visible = True
                lbName.Text = dr("name").ToString
                'lbCode.Text = dr("sbjctcode").ToString
                'lbSubjectName.Text = dr("sbjctname").ToString
                'lbtype.Text = dr("type").ToString
                'lbSubjectTime.Text = dr("time").ToString
                '  _viewDetails()
            Else
                ' MessageBox.Show("Teacher ID Not Exist", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If Not dr Is Nothing Then
                dr.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
#End Region

    Private Sub Logout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        teacherlogoutverification.ShowDialog()

        _checkTeacher()
        cmbPort.Text = mainmenu.lbCom.Text
        cmbBaud.Text = connectionSetting.cmbBaud.Text
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on 
        'Other Serial Port Property
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8            'Open our serial port
        SerialPort1.Open()
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())    'Automatically called every time a data is received at the serialPort
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.rtbReceived.Text &= validstr([text])
        End If
    End Sub

    Function validstr(ByVal strIn As String) As String
        Dim strOut As String = ""
        For Each c As Char In strIn.ToCharArray()
            If Char.IsLetterOrDigit(c) Then
                strOut &= c.ToString()
            End If
        Next
        Return strOut
    End Function

    Private Sub rtbReceived_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbReceived.TextChanged

        If rtbReceived.Text.Length > 4 Then
            Console.Beep()
            ListBox1.Items.Add(rtbReceived.Text)
            tagNumber.Text = rtbReceived.Text
            rtbReceived.Text = ""

        Else
            tagNumber.Text = ""
        End If
    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        teacherlogoutverification._reset()
        Me.Hide()
        SerialPort1.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbDate.Text = Now.ToShortDateString
        lbtime.Text = Now.ToShortTimeString
    End Sub
#Region "SET STUDENT DETAILS VISIBLE"
    Public Sub _viewDetails()
        Try
            con = New MySqlConnection(conn)
            con.Open()

            Dim qry As String = "select s1.* from mst_student s1 " & _
                                "left join tbl_studentsbjct s2 " & _
                                "on s1.idno = s2.studentid " & _
                                "where s1.rfid = '" & tagNumber.Text & "' and s2.tblsbjctid='" & lbCode.Text & "' and s1.tag='1'"
            Dim dr As MySqlDataReader
            Dim adapt As New MySqlDataAdapter
            Dim cmd As New MySqlCommand

            cmd.CommandText = qry
            cmd.Connection = con
            adapt.SelectCommand = cmd
            dr = cmd.ExecuteReader
            If dr.Read Then
                panStudentDetails.Visible = True
                lbError.Visible = False
                idNo.Text = dr("idno").ToString
                lbSname.Text = dr("name").ToString
                lbSmajor.Text = dr("course").ToString
                lbSyr.Text = dr("year").ToString
                Dim data As Byte() = DirectCast(dr("photo"), Byte())
                Dim ms As New MemoryStream(data)
                PictureBox1.Image = Image.FromStream(ms)
                _saveLogData()
                _updateStatus()
            Else
                'MessageBox.Show("Teacher ID Not Exist", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                lbError.Visible = True
                panStudentDetails.Visible = False
                PictureBox1.Image = um_studentLab_monitoring_portal.My.Resources.images
            End If
            If Not dr Is Nothing Then
                dr.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
#End Region

    Private Sub tagNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tagNumber.TextChanged
        _viewDetails()
    End Sub

#Region "mybless"
    Public Sub _something()
        Try
            con = New MySqlConnection(conn)
            con.Open()

            Dim qry As String = "select * from logout where studentid='" & idNo.Text & "' OR dateOut='" & lbDate.Text & "' OR tblsbjctid='" & lbCode.Text & "'"
            Dim dr As MySqlDataReader
            Dim adapt As New MySqlDataAdapter
            Dim cmd As New MySqlCommand

            cmd.CommandText = qry
            cmd.Connection = con
            adapt.SelectCommand = cmd
            dr = cmd.ExecuteReader
            If dr.Read Then
                lbError.Visible = True
                panStudentDetails.Visible = False
                PictureBox1.Image = um_studentLab_monitoring_portal.My.Resources.images
            Else
                _viewDetails()

            End If
            If Not dr Is Nothing Then
                dr.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
#End Region

#Region "SAVE LOG DATA"
    Public Sub _saveLogData()
        Try
            con = New MySqlConnection(conn)
            con.Open()

            Dim cb As String = "INSERT INTO logout( studentid, 	tblsbjctid, timeOut, dateout)" & _
                "VALUES( '" & idNo.Text & "', '" & lbCode.Text.ToUpper & "', '" & lbtime.Text & "', '" & lbDate.Text & "')"
            cmd = New MySqlCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region


#Region "UPDATE STATUS"
    Public Sub _updateStatus()
        Try
            con = New MySqlConnection(conn)
            con.Open()

            Dim qry As String = " UPDATE mst_student SET  tag='0'  where rfid=@rfid"
            cmd = New MySqlCommand(qry)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@rfid", tagNumber.Text)

            cmd.ExecuteNonQuery()
            con.Close()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region
End Class