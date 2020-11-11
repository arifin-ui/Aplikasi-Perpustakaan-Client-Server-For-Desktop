<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_pengembalian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_pengembalian))
        Me.GroupBoxPengembalian = New System.Windows.Forms.GroupBox()
        Me.TabelDataPengembalian = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Labelpengembalian = New System.Windows.Forms.Label()
        Me.GroupBoxPengembalian.SuspendLayout()
        CType(Me.TabelDataPengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxPengembalian
        '
        Me.GroupBoxPengembalian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPengembalian.Controls.Add(Me.TabelDataPengembalian)
        Me.GroupBoxPengembalian.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPengembalian.Location = New System.Drawing.Point(20, 66)
        Me.GroupBoxPengembalian.Name = "GroupBoxPengembalian"
        Me.GroupBoxPengembalian.Size = New System.Drawing.Size(826, 497)
        Me.GroupBoxPengembalian.TabIndex = 6
        Me.GroupBoxPengembalian.TabStop = False
        Me.GroupBoxPengembalian.Text = "Tabel Data Pengembalian"
        '
        'TabelDataPengembalian
        '
        Me.TabelDataPengembalian.AllowUserToAddRows = False
        Me.TabelDataPengembalian.AllowUserToDeleteRows = False
        Me.TabelDataPengembalian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabelDataPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelDataPengembalian.Location = New System.Drawing.Point(14, 35)
        Me.TabelDataPengembalian.Name = "TabelDataPengembalian"
        Me.TabelDataPengembalian.ReadOnly = True
        Me.TabelDataPengembalian.Size = New System.Drawing.Size(803, 441)
        Me.TabelDataPengembalian.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Labelpengembalian)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 44)
        Me.Panel1.TabIndex = 7
        '
        'Labelpengembalian
        '
        Me.Labelpengembalian.AutoSize = True
        Me.Labelpengembalian.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpengembalian.ForeColor = System.Drawing.Color.White
        Me.Labelpengembalian.Location = New System.Drawing.Point(17, 9)
        Me.Labelpengembalian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelpengembalian.Name = "Labelpengembalian"
        Me.Labelpengembalian.Size = New System.Drawing.Size(169, 21)
        Me.Labelpengembalian.TabIndex = 1
        Me.Labelpengembalian.Text = "Data Pengembalian :"
        '
        'User_pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBoxPengembalian)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User_pengembalian"
        Me.Text = "User_pengembalian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxPengembalian.ResumeLayout(False)
        CType(Me.TabelDataPengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxPengembalian As System.Windows.Forms.GroupBox
    Friend WithEvents TabelDataPengembalian As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Labelpengembalian As System.Windows.Forms.Label
End Class
