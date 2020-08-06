<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txt_pass = New MetroFramework.Controls.MetroTextBox()
        Me.txt_user = New MetroFramework.Controls.MetroTextBox()
        Me.lbaccess = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_pass
        '
        '
        '
        '
        Me.txt_pass.CustomButton.Image = Nothing
        Me.txt_pass.CustomButton.Location = New System.Drawing.Point(374, 2)
        Me.txt_pass.CustomButton.Name = ""
        Me.txt_pass.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pass.CustomButton.TabIndex = 1
        Me.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pass.CustomButton.UseSelectable = True
        Me.txt_pass.CustomButton.Visible = False
        Me.txt_pass.DisplayIcon = True
        Me.txt_pass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txt_pass.Lines = New String(-1) {}
        Me.txt_pass.Location = New System.Drawing.Point(135, 422)
        Me.txt_pass.MaxLength = 32767
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_pass.PromptText = "Password"
        Me.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pass.SelectedText = ""
        Me.txt_pass.SelectionLength = 0
        Me.txt_pass.SelectionStart = 0
        Me.txt_pass.ShortcutsEnabled = True
        Me.txt_pass.Size = New System.Drawing.Size(402, 30)
        Me.txt_pass.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pass.TabIndex = 144
        Me.txt_pass.UseSelectable = True
        Me.txt_pass.UseSystemPasswordChar = True
        Me.txt_pass.WaterMark = "Password"
        Me.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pass.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txt_user
        '
        '
        '
        '
        Me.txt_user.CustomButton.Image = Nothing
        Me.txt_user.CustomButton.Location = New System.Drawing.Point(374, 2)
        Me.txt_user.CustomButton.Name = ""
        Me.txt_user.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txt_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_user.CustomButton.TabIndex = 1
        Me.txt_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_user.CustomButton.UseSelectable = True
        Me.txt_user.CustomButton.Visible = False
        Me.txt_user.DisplayIcon = True
        Me.txt_user.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txt_user.Lines = New String(-1) {}
        Me.txt_user.Location = New System.Drawing.Point(135, 385)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(40)
        Me.txt_user.MaxLength = 32767
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_user.PromptText = "Username"
        Me.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_user.SelectedText = ""
        Me.txt_user.SelectionLength = 0
        Me.txt_user.SelectionStart = 0
        Me.txt_user.ShortcutsEnabled = True
        Me.txt_user.Size = New System.Drawing.Size(402, 30)
        Me.txt_user.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_user.TabIndex = 143
        Me.txt_user.UseSelectable = True
        Me.txt_user.WaterMark = "Username"
        Me.txt_user.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_user.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbaccess
        '
        Me.lbaccess.AutoSize = True
        Me.lbaccess.Location = New System.Drawing.Point(215, 430)
        Me.lbaccess.Name = "lbaccess"
        Me.lbaccess.Size = New System.Drawing.Size(45, 19)
        Me.lbaccess.TabIndex = 145
        Me.lbaccess.Text = "access"
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(277, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 30)
        Me.Button1.TabIndex = 146
        Me.Button1.Text = "&Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(410, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 30)
        Me.Button2.TabIndex = 147
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.um_studentLab_monitoring_portal.My.Resources.Resources.um
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbaccess)
        Me.Controls.Add(Me.txt_user)
        Me.Name = "login"
        Me.Size = New System.Drawing.Size(1427, 750)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_pass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_user As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbaccess As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
