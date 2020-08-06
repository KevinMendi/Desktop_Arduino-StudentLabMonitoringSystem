<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentsubjectreport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.subjectSearch = New MetroFramework.Controls.MetroTextBox()
        Me.dgvUser = New MetroFramework.Controls.MetroGrid()
        Me.col_sales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Login = New MetroFramework.Controls.MetroButton()
        Me.btnexport = New MetroFramework.Controls.MetroButton()
        Me.cmbtype = New MetroFramework.Controls.MetroComboBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subjectSearch
        '
        '
        '
        '
        Me.subjectSearch.CustomButton.Image = Nothing
        Me.subjectSearch.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.subjectSearch.CustomButton.Name = ""
        Me.subjectSearch.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.subjectSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.subjectSearch.CustomButton.TabIndex = 1
        Me.subjectSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.subjectSearch.CustomButton.UseSelectable = True
        Me.subjectSearch.CustomButton.Visible = False
        Me.subjectSearch.DisplayIcon = True
        Me.subjectSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.subjectSearch.Lines = New String(-1) {}
        Me.subjectSearch.Location = New System.Drawing.Point(12, 93)
        Me.subjectSearch.Margin = New System.Windows.Forms.Padding(40)
        Me.subjectSearch.MaxLength = 32767
        Me.subjectSearch.Name = "subjectSearch"
        Me.subjectSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.subjectSearch.PromptText = "Enter Subject Name"
        Me.subjectSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.subjectSearch.SelectedText = ""
        Me.subjectSearch.SelectionLength = 0
        Me.subjectSearch.SelectionStart = 0
        Me.subjectSearch.ShortcutsEnabled = True
        Me.subjectSearch.Size = New System.Drawing.Size(289, 30)
        Me.subjectSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.subjectSearch.TabIndex = 410
        Me.subjectSearch.UseSelectable = True
        Me.subjectSearch.WaterMark = "Enter Subject Name"
        Me.subjectSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.subjectSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUser.ColumnHeadersHeight = 45
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sales, Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUser.EnableHeadersVisualStyles = False
        Me.dgvUser.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUser.Location = New System.Drawing.Point(12, 129)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.Size = New System.Drawing.Size(1011, 384)
        Me.dgvUser.Style = MetroFramework.MetroColorStyle.Green
        Me.dgvUser.TabIndex = 409
        Me.dgvUser.Visible = False
        '
        'col_sales
        '
        Me.col_sales.DataPropertyName = "sales"
        Me.col_sales.HeaderText = "ID"
        Me.col_sales.Name = "col_sales"
        Me.col_sales.ReadOnly = True
        Me.col_sales.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_sales.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "SUBJECT CODE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "SUBJECT NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "SCHEDULE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "TYPE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "TIME"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Login.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_Login.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Login.ForeColor = System.Drawing.Color.White
        Me.btn_Login.Location = New System.Drawing.Point(597, 96)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(138, 27)
        Me.btn_Login.Style = MetroFramework.MetroColorStyle.White
        Me.btn_Login.TabIndex = 411
        Me.btn_Login.Text = "&Generate Report"
        Me.btn_Login.UseCustomBackColor = True
        Me.btn_Login.UseSelectable = True
        Me.btn_Login.UseStyleColors = True
        '
        'btnexport
        '
        Me.btnexport.BackColor = System.Drawing.Color.SeaGreen
        Me.btnexport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexport.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnexport.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnexport.ForeColor = System.Drawing.Color.White
        Me.btnexport.Location = New System.Drawing.Point(885, 519)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(138, 27)
        Me.btnexport.Style = MetroFramework.MetroColorStyle.White
        Me.btnexport.TabIndex = 412
        Me.btnexport.Text = "&Export to Excel"
        Me.btnexport.UseCustomBackColor = True
        Me.btnexport.UseSelectable = True
        Me.btnexport.UseStyleColors = True
        Me.btnexport.Visible = False
        '
        'cmbtype
        '
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.ItemHeight = 23
        Me.cmbtype.Items.AddRange(New Object() {"1ST TERM", "2ND TERM", "SEM"})
        Me.cmbtype.Location = New System.Drawing.Point(320, 94)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.PromptText = "Select User Type"
        Me.cmbtype.Size = New System.Drawing.Size(262, 29)
        Me.cmbtype.TabIndex = 413
        Me.cmbtype.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.SeaGreen
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton2.ForeColor = System.Drawing.Color.White
        Me.MetroButton2.Location = New System.Drawing.Point(741, 96)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(138, 27)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.White
        Me.MetroButton2.TabIndex = 414
        Me.MetroButton2.Text = "&Reset"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton1.ForeColor = System.Drawing.Color.White
        Me.MetroButton1.Location = New System.Drawing.Point(885, 96)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(138, 27)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroButton1.TabIndex = 422
        Me.MetroButton1.Text = "&Main Menu"
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'studentsubjectreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1031, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.btnexport)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.subjectSearch)
        Me.Controls.Add(Me.dgvUser)
        Me.Movable = False
        Me.Name = "studentsubjectreport"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Student Subject Report"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents subjectSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgvUser As MetroFramework.Controls.MetroGrid
    Friend WithEvents col_sales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Login As MetroFramework.Controls.MetroButton
    Friend WithEvents btnexport As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbtype As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
