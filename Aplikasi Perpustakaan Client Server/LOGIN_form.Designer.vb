<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN_form
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN_form))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.LabelJAM = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.CheckBoxTampilkan = New System.Windows.Forms.CheckBox()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.Buttonlogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxnim = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Labelcopyright = New System.Windows.Forms.Label()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GunaGroupBox3.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaShadowPanel1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaShadowPanel1.Controls.Add(Me.Panel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGroupBox3)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGroupBox2)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGroupBox1)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel3)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(800, 541)
        Me.GunaShadowPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 42)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 42)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Perpustakaan Client-Server"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(693, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(743, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox3.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox3.Controls.Add(Me.MonthCalendar1)
        Me.GunaGroupBox3.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGroupBox3.Location = New System.Drawing.Point(517, 207)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Size = New System.Drawing.Size(263, 275)
        Me.GunaGroupBox3.TabIndex = 9
        Me.GunaGroupBox3.Text = "TANGGAL"
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(10, 8)
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 65)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.LabelJAM)
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGroupBox2.Location = New System.Drawing.Point(517, 63)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(263, 110)
        Me.GunaGroupBox2.TabIndex = 8
        Me.GunaGroupBox2.Text = "JAM"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'LabelJAM
        '
        Me.LabelJAM.AutoSize = True
        Me.LabelJAM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelJAM.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJAM.Location = New System.Drawing.Point(72, 49)
        Me.LabelJAM.Name = "LabelJAM"
        Me.LabelJAM.Size = New System.Drawing.Size(127, 37)
        Me.LabelJAM.TabIndex = 0
        Me.LabelJAM.Text = "00:00:00"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.CheckBoxTampilkan)
        Me.GunaGroupBox1.Controls.Add(Me.TextBoxpassword)
        Me.GunaGroupBox1.Controls.Add(Me.Buttonlogin)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.GunaGroupBox1.Controls.Add(Me.TextBoxnim)
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(26, 63)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(467, 419)
        Me.GunaGroupBox1.TabIndex = 7
        Me.GunaGroupBox1.Text = "LOGIN"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'CheckBoxTampilkan
        '
        Me.CheckBoxTampilkan.AutoSize = True
        Me.CheckBoxTampilkan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBoxTampilkan.Location = New System.Drawing.Point(124, 222)
        Me.CheckBoxTampilkan.Name = "CheckBoxTampilkan"
        Me.CheckBoxTampilkan.Size = New System.Drawing.Size(150, 21)
        Me.CheckBoxTampilkan.TabIndex = 12
        Me.CheckBoxTampilkan.Text = "Tampilkan Password"
        Me.CheckBoxTampilkan.UseVisualStyleBackColor = True
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Location = New System.Drawing.Point(124, 191)
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.Size = New System.Drawing.Size(215, 25)
        Me.TextBoxpassword.TabIndex = 11
        Me.TextBoxpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxpassword.UseSystemPasswordChar = True
        '
        'Buttonlogin
        '
        Me.Buttonlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonlogin.Location = New System.Drawing.Point(174, 284)
        Me.Buttonlogin.Name = "Buttonlogin"
        Me.Buttonlogin.Size = New System.Drawing.Size(107, 39)
        Me.Buttonlogin.TabIndex = 4
        Me.Buttonlogin.Text = "LOGIN"
        Me.Buttonlogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(121, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(121, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIM"
        '
        'TextBoxnim
        '
        Me.TextBoxnim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxnim.Location = New System.Drawing.Point(124, 110)
        Me.TextBoxnim.Name = "TextBoxnim"
        Me.TextBoxnim.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxnim.TabIndex = 0
        Me.TextBoxnim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.Labelcopyright)
        Me.Panel3.Location = New System.Drawing.Point(5, 495)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(790, 41)
        Me.Panel3.TabIndex = 6
        '
        'Labelcopyright
        '
        Me.Labelcopyright.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labelcopyright.AutoSize = True
        Me.Labelcopyright.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcopyright.ForeColor = System.Drawing.Color.White
        Me.Labelcopyright.Location = New System.Drawing.Point(304, 11)
        Me.Labelcopyright.Name = "Labelcopyright"
        Me.Labelcopyright.Size = New System.Drawing.Size(84, 21)
        Me.Labelcopyright.TabIndex = 0
        Me.Labelcopyright.Text = "copyright"
        '
        'LOGIN_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 541)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LOGIN_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents LabelJAM As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Labelcopyright As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Buttonlogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnim As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxpassword As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxTampilkan As System.Windows.Forms.CheckBox

End Class
