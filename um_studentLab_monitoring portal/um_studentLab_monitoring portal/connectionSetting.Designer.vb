<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connectionSetting
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tagNumber = New System.Windows.Forms.TextBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.bday = New System.Windows.Forms.MaskedTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btn_Login = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.tagNumber)
        Me.Panel1.Controls.Add(Me.rtbReceived)
        Me.Panel1.Controls.Add(Me.cmbBaud)
        Me.Panel1.Controls.Add(Me.txtTransmit)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(1151, 600)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 238
        '
        'tagNumber
        '
        Me.tagNumber.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tagNumber.Enabled = False
        Me.tagNumber.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagNumber.Location = New System.Drawing.Point(129, 13)
        Me.tagNumber.MaxLength = 0
        Me.tagNumber.Name = "tagNumber"
        Me.tagNumber.ReadOnly = True
        Me.tagNumber.Size = New System.Drawing.Size(31, 29)
        Me.tagNumber.TabIndex = 235
        Me.tagNumber.TabStop = False
        Me.tagNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(54, 13)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(15, 46)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'cmbBaud
        '
        Me.cmbBaud.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(4, 81)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(12, 24)
        Me.cmbBaud.TabIndex = 0
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(75, 30)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(11, 20)
        Me.txtTransmit.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.bday)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(23, 22)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Received Data"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Location = New System.Drawing.Point(25, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(19, 70)
        Me.ListBox1.TabIndex = 0
        '
        'bday
        '
        Me.bday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bday.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bday.Location = New System.Drawing.Point(50, 28)
        Me.bday.Mask = "00 / 00 / 00"
        Me.bday.Name = "bday"
        Me.bday.Size = New System.Drawing.Size(85, 28)
        Me.bday.TabIndex = 0
        Me.bday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.MetroLabel1)
        Me.Panel4.Controls.Add(Me.cmbCourse)
        Me.Panel4.Controls.Add(Me.cmbPort)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(30, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 81)
        Me.Panel4.TabIndex = 237
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(99, 48)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel1.TabIndex = 244
        Me.MetroLabel1.Text = "Current SY"
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Items.AddRange(New Object() {""})
        Me.cmbCourse.Location = New System.Drawing.Point(178, 43)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(140, 24)
        Me.cmbCourse.TabIndex = 243
        '
        'cmbPort
        '
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPort.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Items.AddRange(New Object() {""})
        Me.cmbPort.Location = New System.Drawing.Point(178, 13)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(140, 24)
        Me.cmbPort.TabIndex = 0
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM5"
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Login.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_Login.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Login.ForeColor = System.Drawing.Color.White
        Me.btn_Login.Location = New System.Drawing.Point(218, 150)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(138, 27)
        Me.btn_Login.Style = MetroFramework.MetroColorStyle.White
        Me.btn_Login.TabIndex = 240
        Me.btn_Login.Text = "&Connect"
        Me.btn_Login.UseCustomBackColor = True
        Me.btn_Login.UseSelectable = True
        Me.btn_Login.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(38, 77)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(164, 19)
        Me.MetroLabel4.TabIndex = 242
        Me.MetroLabel4.Text = "Please Select Arduino Port"
        '
        'connectionSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(391, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Movable = False
        Me.Name = "connectionSetting"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Arduino Port Connection Setting"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tagNumber As System.Windows.Forms.TextBox
    Friend WithEvents rtbReceived As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bday As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btn_Login As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
End Class
