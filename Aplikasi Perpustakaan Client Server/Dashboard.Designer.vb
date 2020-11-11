<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.LabelJUMLAHBUKU = New System.Windows.Forms.Label()
        Me.LabelWAKTU = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGroupBox4 = New Guna.UI.WinForms.GunaGroupBox()
        Me.LabelKoleksi = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GunaGroupBox3.SuspendLayout()
        Me.GunaGroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Perpustakaan_Client_Server.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(66, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 415)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 44)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DASHBOARD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hai...!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(415, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Selamat datng di Aplikasi Perpustakaan !"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GunaGroupBox4)
        Me.Panel2.Controls.Add(Me.GunaGroupBox3)
        Me.Panel2.Controls.Add(Me.GunaGroupBox2)
        Me.Panel2.Controls.Add(Me.GunaGroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(524, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 560)
        Me.Panel2.TabIndex = 4
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.LabelWAKTU)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(3, 14)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(299, 98)
        Me.GunaGroupBox1.TabIndex = 5
        Me.GunaGroupBox1.Text = "JAM"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(128, 67)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(83, 30)
        Me.LabelNama.TabIndex = 5
        Me.LabelNama.Text = "[nama]"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.MonthCalendar1)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Location = New System.Drawing.Point(3, 120)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(299, 233)
        Me.GunaGroupBox2.TabIndex = 6
        Me.GunaGroupBox2.Text = "KALENDER"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox3.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox3.Controls.Add(Me.LabelJUMLAHBUKU)
        Me.GunaGroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox3.Location = New System.Drawing.Point(3, 468)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Size = New System.Drawing.Size(299, 99)
        Me.GunaGroupBox3.TabIndex = 7
        Me.GunaGroupBox3.Text = "STOK BUKU"
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(10, 8)
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(37, 49)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'LabelJUMLAHBUKU
        '
        Me.LabelJUMLAHBUKU.AutoSize = True
        Me.LabelJUMLAHBUKU.BackColor = System.Drawing.Color.Silver
        Me.LabelJUMLAHBUKU.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJUMLAHBUKU.Location = New System.Drawing.Point(75, 37)
        Me.LabelJUMLAHBUKU.Name = "LabelJUMLAHBUKU"
        Me.LabelJUMLAHBUKU.Size = New System.Drawing.Size(146, 47)
        Me.LabelJUMLAHBUKU.TabIndex = 0
        Me.LabelJUMLAHBUKU.Text = "[00000]"
        '
        'LabelWAKTU
        '
        Me.LabelWAKTU.AutoSize = True
        Me.LabelWAKTU.BackColor = System.Drawing.Color.Silver
        Me.LabelWAKTU.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWAKTU.Location = New System.Drawing.Point(75, 40)
        Me.LabelWAKTU.Name = "LabelWAKTU"
        Me.LabelWAKTU.Size = New System.Drawing.Size(158, 47)
        Me.LabelWAKTU.TabIndex = 1
        Me.LabelWAKTU.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GunaGroupBox4
        '
        Me.GunaGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox4.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox4.Controls.Add(Me.LabelKoleksi)
        Me.GunaGroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox4.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox4.Location = New System.Drawing.Point(0, 359)
        Me.GunaGroupBox4.Name = "GunaGroupBox4"
        Me.GunaGroupBox4.Size = New System.Drawing.Size(299, 99)
        Me.GunaGroupBox4.TabIndex = 8
        Me.GunaGroupBox4.Text = "KOLEKSI BUKU"
        Me.GunaGroupBox4.TextLocation = New System.Drawing.Point(10, 8)
        '
        'LabelKoleksi
        '
        Me.LabelKoleksi.AutoSize = True
        Me.LabelKoleksi.BackColor = System.Drawing.Color.Silver
        Me.LabelKoleksi.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKoleksi.Location = New System.Drawing.Point(75, 37)
        Me.LabelKoleksi.Name = "LabelKoleksi"
        Me.LabelKoleksi.Size = New System.Drawing.Size(146, 47)
        Me.LabelKoleksi.TabIndex = 0
        Me.LabelKoleksi.Text = "[00000]"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 604)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox3.PerformLayout()
        Me.GunaGroupBox4.ResumeLayout(False)
        Me.GunaGroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents LabelJUMLAHBUKU As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents LabelWAKTU As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaGroupBox4 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents LabelKoleksi As System.Windows.Forms.Label
End Class
