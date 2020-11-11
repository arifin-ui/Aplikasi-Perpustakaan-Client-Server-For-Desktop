<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Peminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Peminjaman))
        Me.GroupBoxPeminjaman = New System.Windows.Forms.GroupBox()
        Me.tabelDataPeminjaman = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Labelpeminjaman = New System.Windows.Forms.Label()
        Me.GroupBoxPeminjaman.SuspendLayout()
        CType(Me.tabelDataPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxPeminjaman
        '
        Me.GroupBoxPeminjaman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPeminjaman.Controls.Add(Me.tabelDataPeminjaman)
        Me.GroupBoxPeminjaman.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPeminjaman.Location = New System.Drawing.Point(12, 68)
        Me.GroupBoxPeminjaman.Name = "GroupBoxPeminjaman"
        Me.GroupBoxPeminjaman.Size = New System.Drawing.Size(826, 492)
        Me.GroupBoxPeminjaman.TabIndex = 4
        Me.GroupBoxPeminjaman.TabStop = False
        Me.GroupBoxPeminjaman.Text = "Tabel Data Peminjaman"
        '
        'tabelDataPeminjaman
        '
        Me.tabelDataPeminjaman.AllowUserToAddRows = False
        Me.tabelDataPeminjaman.AllowUserToDeleteRows = False
        Me.tabelDataPeminjaman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabelDataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataPeminjaman.Location = New System.Drawing.Point(14, 35)
        Me.tabelDataPeminjaman.Name = "tabelDataPeminjaman"
        Me.tabelDataPeminjaman.ReadOnly = True
        Me.tabelDataPeminjaman.Size = New System.Drawing.Size(803, 436)
        Me.tabelDataPeminjaman.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Labelpeminjaman)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 44)
        Me.Panel1.TabIndex = 5
        '
        'Labelpeminjaman
        '
        Me.Labelpeminjaman.AutoSize = True
        Me.Labelpeminjaman.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpeminjaman.ForeColor = System.Drawing.Color.White
        Me.Labelpeminjaman.Location = New System.Drawing.Point(13, 9)
        Me.Labelpeminjaman.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelpeminjaman.Name = "Labelpeminjaman"
        Me.Labelpeminjaman.Size = New System.Drawing.Size(155, 21)
        Me.Labelpeminjaman.TabIndex = 0
        Me.Labelpeminjaman.Text = "Data Peminjaman :"
        '
        'User_Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 572)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBoxPeminjaman)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User_Peminjaman"
        Me.Text = "User_Peminjaman"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxPeminjaman.ResumeLayout(False)
        CType(Me.tabelDataPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxPeminjaman As System.Windows.Forms.GroupBox
    Friend WithEvents tabelDataPeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Labelpeminjaman As System.Windows.Forms.Label
End Class
