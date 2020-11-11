Imports System.Data.Odbc
Public Class Admin_Form
    'copyright
    Private Sub Admin_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penggunaProfil()
        buku()
        'koleksi()
        pengguna()
        peminjaman()
        pengembalian()
        Labelcopyright.Text = My.Application.Info.Copyright + " Febi Arifin TI-1"
        panelshow(Dashboard)
        Dashboard.WindowState = FormWindowState.Maximized
    End Sub
    'profile
    Sub penggunaProfil()
        dt = New DataTable()
        query = "SELECT*FROM tbpengguna WHERE NIM='" & LOGIN_form.TextBoxnim.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(dt)
            TextBoxUSERNAME.Text = dt.Rows(0)(1)
            Dashboard.LabelNama.Text = dt.Rows(0)(1)
        Catch ex As Exception
            MessageBox.Show("Error 'LOAD PROFILE' : " & ex.Message, "PERHATIAN", _
                 MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'close window
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    'minimize
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'form show code
    Sub panelshow(ByVal panel As Form)
        PanelMain.Controls.Clear()
        panel.TopLevel = False
        PanelMain.Controls.Add(panel)
        panel.Show()
    End Sub
    'DASHBOARD
    Private Sub ButtonDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDashboard.Click
        panelshow(Dashboard)
        Dashboard.WindowState = FormWindowState.Maximized
    End Sub
    'Data Buku
    Private Sub ButtonDataBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDataBuku.Click
        panelshow(DataBuku)
        DataBuku.WindowState = FormWindowState.Maximized
        buku()
    End Sub
    'Logout
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Yakin ingin Logout ?", "PERHATIAN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Me.Close()
            LOGIN_form.Show()
        End If
    End Sub
    'data pengguna
    Private Sub ButtonDataPenguna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDataPenguna.Click
        panelshow(DataPengguna)
        DataPengguna.WindowState = FormWindowState.Maximized
        pengguna()
    End Sub
    'data peminjaman
    Private Sub ButtonDataPeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDataPeminjaman.Click
        panelshow(DataPeminjaman)
        DataPeminjaman.WindowState = FormWindowState.Maximized
        peminjaman()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        buku()
        pengguna()
        peminjaman()
        pengembalian()
    End Sub

    Private Sub ButtonDataPengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDataPengembalian.Click
        panelshow(DataPengembalian)
        DataPengembalian.WindowState = FormWindowState.Maximized
        pengembalian()
    End Sub

    Private Sub ButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbout.Click
        panelshow(About)
        About.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonPengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPengembalian.Click
        panelshow(Laporan)
        Laporan.WindowState = FormWindowState.Maximized
    End Sub
End Class