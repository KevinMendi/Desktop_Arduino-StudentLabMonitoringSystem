<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monitoring
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbError = New System.Windows.Forms.Label()
        Me.panStudentDetails = New System.Windows.Forms.Panel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.idNo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lbSyr = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.lbSmajor = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.lbSname = New MetroFramework.Controls.MetroLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbtime = New MetroFramework.Controls.MetroLabel()
        Me.tagNumber = New MetroFramework.Controls.MetroTextBox()
        Me.lbDate = New MetroFramework.Controls.MetroLabel()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbName = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lbCode = New MetroFramework.Controls.MetroLabel()
        Me.lbSubjectName = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lbtype = New MetroFramework.Controls.MetroLabel()
        Me.lbSubjectTime = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.bday = New System.Windows.Forms.MaskedTextBox()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.panCon = New System.Windows.Forms.Panel()
        Me.lbport = New System.Windows.Forms.Label()
        Me.connect = New System.Windows.Forms.LinkLabel()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.panStudentDetails.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.panCon.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbError)
        Me.Panel2.Controls.Add(Me.panStudentDetails)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(13, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 458)
        Me.Panel2.TabIndex = 88
        '
        'lbError
        '
        Me.lbError.AutoSize = True
        Me.lbError.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbError.ForeColor = System.Drawing.Color.Red
        Me.lbError.Location = New System.Drawing.Point(69, 11)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(839, 38)
        Me.lbError.TabIndex = 100
        Me.lbError.Text = "YOU ARE NOT ENROLL OR YOU ALREADY LOGIN"
        Me.lbError.Visible = False
        '
        'panStudentDetails
        '
        Me.panStudentDetails.Controls.Add(Me.MetroLabel7)
        Me.panStudentDetails.Controls.Add(Me.idNo)
        Me.panStudentDetails.Controls.Add(Me.MetroLabel6)
        Me.panStudentDetails.Controls.Add(Me.lbSyr)
        Me.panStudentDetails.Controls.Add(Me.MetroLabel8)
        Me.panStudentDetails.Controls.Add(Me.lbSmajor)
        Me.panStudentDetails.Controls.Add(Me.MetroLabel9)
        Me.panStudentDetails.Controls.Add(Me.lbSname)
        Me.panStudentDetails.Location = New System.Drawing.Point(9, 74)
        Me.panStudentDetails.Name = "panStudentDetails"
        Me.panStudentDetails.Size = New System.Drawing.Size(570, 375)
        Me.panStudentDetails.TabIndex = 99
        Me.panStudentDetails.Visible = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(81, 29)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(56, 25)
        Me.MetroLabel7.TabIndex = 99
        Me.MetroLabel7.Text = "ID No"
        '
        'idNo
        '
        Me.idNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.idNo.AutoSize = True
        Me.idNo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.idNo.Location = New System.Drawing.Point(149, 29)
        Me.idNo.Name = "idNo"
        Me.idNo.Size = New System.Drawing.Size(49, 25)
        Me.idNo.TabIndex = 100
        Me.idNo.Text = "idNo"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(16, 73)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(121, 25)
        Me.MetroLabel6.TabIndex = 93
        Me.MetroLabel6.Text = "Student Name"
        '
        'lbSyr
        '
        Me.lbSyr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSyr.AutoSize = True
        Me.lbSyr.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbSyr.Location = New System.Drawing.Point(149, 191)
        Me.lbSyr.Name = "lbSyr"
        Me.lbSyr.Size = New System.Drawing.Size(49, 25)
        Me.lbSyr.TabIndex = 98
        Me.lbSyr.Text = "lbSyr"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(81, 128)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(56, 25)
        Me.MetroLabel8.TabIndex = 95
        Me.MetroLabel8.Text = "Major"
        '
        'lbSmajor
        '
        Me.lbSmajor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSmajor.AutoSize = True
        Me.lbSmajor.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbSmajor.Location = New System.Drawing.Point(149, 128)
        Me.lbSmajor.Name = "lbSmajor"
        Me.lbSmajor.Size = New System.Drawing.Size(79, 25)
        Me.lbSmajor.TabIndex = 97
        Me.lbSmajor.Text = "lbSmajor"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.Location = New System.Drawing.Point(48, 191)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(87, 25)
        Me.MetroLabel9.TabIndex = 96
        Me.MetroLabel9.Text = "Year Level"
        '
        'lbSname
        '
        Me.lbSname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSname.AutoSize = True
        Me.lbSname.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbSname.Location = New System.Drawing.Point(149, 73)
        Me.lbSname.Name = "lbSname"
        Me.lbSname.Size = New System.Drawing.Size(78, 25)
        Me.lbSname.TabIndex = 93
        Me.lbSname.Text = "lbSname"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.um_studentLab_monitoring_portal.My.Resources.Resources.try2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.lbtime)
        Me.Panel3.Controls.Add(Me.tagNumber)
        Me.Panel3.Controls.Add(Me.lbDate)
        Me.Panel3.Location = New System.Drawing.Point(585, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(383, 375)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.um_studentLab_monitoring_portal.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(71, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 312
        Me.PictureBox1.TabStop = False
        '
        'lbtime
        '
        Me.lbtime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbtime.AutoSize = True
        Me.lbtime.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbtime.Location = New System.Drawing.Point(94, 153)
        Me.lbtime.Name = "lbtime"
        Me.lbtime.Size = New System.Drawing.Size(59, 25)
        Me.lbtime.TabIndex = 317
        Me.lbtime.Text = "lbtime"
        '
        'tagNumber
        '
        '
        '
        '
        Me.tagNumber.CustomButton.Image = Nothing
        Me.tagNumber.CustomButton.Location = New System.Drawing.Point(224, 2)
        Me.tagNumber.CustomButton.Name = ""
        Me.tagNumber.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tagNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tagNumber.CustomButton.TabIndex = 1
        Me.tagNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tagNumber.CustomButton.UseSelectable = True
        Me.tagNumber.CustomButton.Visible = False
        Me.tagNumber.DisplayIcon = True
        Me.tagNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.tagNumber.Lines = New String(-1) {}
        Me.tagNumber.Location = New System.Drawing.Point(71, 78)
        Me.tagNumber.Margin = New System.Windows.Forms.Padding(40)
        Me.tagNumber.MaxLength = 32767
        Me.tagNumber.Name = "tagNumber"
        Me.tagNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tagNumber.ReadOnly = True
        Me.tagNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tagNumber.SelectedText = ""
        Me.tagNumber.SelectionLength = 0
        Me.tagNumber.SelectionStart = 0
        Me.tagNumber.ShortcutsEnabled = True
        Me.tagNumber.Size = New System.Drawing.Size(252, 30)
        Me.tagNumber.Style = MetroFramework.MetroColorStyle.Orange
        Me.tagNumber.TabIndex = 314
        Me.tagNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tagNumber.UseSelectable = True
        Me.tagNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tagNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbDate
        '
        Me.lbDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbDate.AutoSize = True
        Me.lbDate.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbDate.Location = New System.Drawing.Point(114, 128)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(59, 25)
        Me.lbDate.TabIndex = 101
        Me.lbDate.Text = "lbdate"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM17"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(124, 25)
        Me.MetroLabel1.TabIndex = 84
        Me.MetroLabel1.Text = "Teacher Name:"
        '
        'lbName
        '
        Me.lbName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbName.AutoSize = True
        Me.lbName.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbName.Location = New System.Drawing.Point(144, 22)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(72, 25)
        Me.lbName.TabIndex = 87
        Me.lbName.Text = "lbName"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 9)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(116, 25)
        Me.MetroLabel4.TabIndex = 83
        Me.MetroLabel4.Text = "Subject Code:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(537, 44)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(113, 25)
        Me.MetroLabel3.TabIndex = 85
        Me.MetroLabel3.Text = "Subject Time:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 44)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(122, 25)
        Me.MetroLabel2.TabIndex = 86
        Me.MetroLabel2.Text = "Subject Name:"
        '
        'lbCode
        '
        Me.lbCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbCode.AutoSize = True
        Me.lbCode.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbCode.Location = New System.Drawing.Point(152, 9)
        Me.lbCode.Name = "lbCode"
        Me.lbCode.Size = New System.Drawing.Size(66, 25)
        Me.lbCode.TabIndex = 88
        Me.lbCode.Text = "lbCode"
        '
        'lbSubjectName
        '
        Me.lbSubjectName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSubjectName.AutoSize = True
        Me.lbSubjectName.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbSubjectName.Location = New System.Drawing.Point(152, 44)
        Me.lbSubjectName.Name = "lbSubjectName"
        Me.lbSubjectName.Size = New System.Drawing.Size(127, 25)
        Me.lbSubjectName.TabIndex = 89
        Me.lbSubjectName.Text = "lbSubjectName"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(538, 9)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(110, 25)
        Me.MetroLabel5.TabIndex = 90
        Me.MetroLabel5.Text = "Subject Type:"
        '
        'lbtype
        '
        Me.lbtype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbtype.AutoSize = True
        Me.lbtype.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbtype.Location = New System.Drawing.Point(656, 9)
        Me.lbtype.Name = "lbtype"
        Me.lbtype.Size = New System.Drawing.Size(58, 25)
        Me.lbtype.TabIndex = 91
        Me.lbtype.Text = "lbtype"
        '
        'lbSubjectTime
        '
        Me.lbSubjectTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSubjectTime.AutoSize = True
        Me.lbSubjectTime.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbSubjectTime.Location = New System.Drawing.Point(656, 44)
        Me.lbSubjectTime.Name = "lbSubjectTime"
        Me.lbSubjectTime.Size = New System.Drawing.Size(118, 25)
        Me.lbSubjectTime.TabIndex = 92
        Me.lbSubjectTime.Text = "lbSubjectTime"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbSubjectTime)
        Me.Panel1.Controls.Add(Me.lbtype)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.lbSubjectName)
        Me.Panel1.Controls.Add(Me.lbCode)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Location = New System.Drawing.Point(13, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 82)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(947, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 37)
        Me.Button1.TabIndex = 316
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
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
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(75, 30)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(11, 20)
        Me.txtTransmit.TabIndex = 0
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(335, 125)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(352, 142)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'cmbBaud
        '
        Me.cmbBaud.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(29, 169)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(10, 24)
        Me.cmbBaud.TabIndex = 0
        '
        'panCon
        '
        Me.panCon.Controls.Add(Me.lbport)
        Me.panCon.Controls.Add(Me.connect)
        Me.panCon.Controls.Add(Me.cmbPort)
        Me.panCon.Location = New System.Drawing.Point(4, 125)
        Me.panCon.Name = "panCon"
        Me.panCon.Size = New System.Drawing.Size(127, 32)
        Me.panCon.TabIndex = 173
        '
        'lbport
        '
        Me.lbport.AutoSize = True
        Me.lbport.BackColor = System.Drawing.Color.Transparent
        Me.lbport.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbport.Location = New System.Drawing.Point(3, 11)
        Me.lbport.Name = "lbport"
        Me.lbport.Size = New System.Drawing.Size(68, 18)
        Me.lbport.TabIndex = 0
        Me.lbport.Text = "Com Port:"
        '
        'connect
        '
        Me.connect.AutoSize = True
        Me.connect.BackColor = System.Drawing.Color.Transparent
        Me.connect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.connect.ForeColor = System.Drawing.Color.DarkGray
        Me.connect.LinkColor = System.Drawing.Color.White
        Me.connect.Location = New System.Drawing.Point(171, 8)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(47, 13)
        Me.connect.TabIndex = 1
        Me.connect.TabStop = True
        Me.connect.Text = "Connect"
        '
        'cmbPort
        '
        Me.cmbPort.DropDownHeight = 1
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPort.DropDownWidth = 1
        Me.cmbPort.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPort.IntegralHeight = False
        Me.cmbPort.ItemHeight = 16
        Me.cmbPort.Location = New System.Drawing.Point(76, 7)
        Me.cmbPort.MaxDropDownItems = 2
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(89, 24)
        Me.cmbPort.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Controls.Add(Me.panCon)
        Me.Panel4.Controls.Add(Me.cmbBaud)
        Me.Panel4.Controls.Add(Me.rtbReceived)
        Me.Panel4.Controls.Add(Me.txtTransmit)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Location = New System.Drawing.Point(1365, 772)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 10)
        Me.Panel4.TabIndex = 315
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1003, 630)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Movable = False
        Me.Name = "monitoring"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Entrance Dashboard"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panStudentDetails.ResumeLayout(False)
        Me.panStudentDetails.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panCon.ResumeLayout(False)
        Me.panCon.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents tagNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbSyr As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbSmajor As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbSname As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panStudentDetails As System.Windows.Forms.Panel
    Friend WithEvents lbError As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents idNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbDate As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbtime As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbName As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbCode As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbSubjectName As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbtype As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbSubjectTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bday As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents rtbReceived As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents panCon As System.Windows.Forms.Panel
    Friend WithEvents lbport As System.Windows.Forms.Label
    Friend WithEvents connect As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
