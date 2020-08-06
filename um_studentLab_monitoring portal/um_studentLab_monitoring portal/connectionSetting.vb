Imports System.Security.Cryptography
Imports System.Text
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Public Class connectionSetting
    Dim myPort As Array  'COM Ports detected on the system will be stored here
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub connectionSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available
        _viewTerm()
        cmbBaud.Items.Add(115200)

        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)    'Set cmbPort text to the first COM port detected
        cmbBaud.Text = cmbBaud.Items.Item(0)    'Set cmbBaud text to the first Baud rate on the list
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        SerialPort1.PortName = cmbPort.Text         'Set SerialPort1 to the selected COM port at startup
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on 

        'Other Serial Port Property
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8            'Open our serial port
        SerialPort1.Open()

        Me.Hide()
        mainmenu.lbCom.Text = cmbPort.Text
        mainmenu.ToolStripStatusLabel7.Text = cmbCourse.Text
        SerialPort1.Close()

    End Sub

#Region "DISTINCT"
    Public Sub _viewTerm()
        Try
            con = New MySqlConnection(conn)
            con.Open()
            adp = New MySqlDataAdapter()
            adp.SelectCommand = New MySqlCommand("SELECT distinct type FROM mst_subject", con)
            ds = New DataSet("course")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCourse.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCourse.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

  
End Class