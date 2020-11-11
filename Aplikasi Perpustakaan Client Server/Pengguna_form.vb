Imports System.Data.Odbc
Public Class Pengguna_form
    Sub pengguna()
        dt = New DataTable()
        query = "SELECT*FROM tbpengguna WHERE NIM='" & LOGIN_form.TextBoxnim.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(dt)
            LabelID.Text = dt.Rows(0)(0)
            TextBoxUSERNAME.Text = dt.Rows(0)(1)
            Dashboard.LabelNama.Text = dt.Rows(0)(1)
        Catch ex As Exception
            MessageBox.Show("Error 'LOAD PROFILE' : " & ex.Message, "PERHATIAN", _
                 MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Pengguna_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pengguna()
        buku()
        'koleksi()
        peminjamanuser()
        pengembalianuser()
        Labelcopyright.Text = My.Application.Info.Copyright + " Febi Arifin TI-1"
        panelshow(Dashboard)
        Dashboard.WindowState = FormWindowState.Maximized
    End Sub
    Sub panelshow(ByVal panel As Form)
        PanelMain.Controls.Clear()
        panel.TopLevel = False
        PanelMain.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub ButtonDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDashboard.Click
        buku()
        panelshow(Dashboard)
        Dashboard.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonDataBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDataBuku.Click
        panelshow(User_buku)
        User_buku.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        buku()
        peminjamanuser()
        pengembalianuser()
    End Sub

    Private Sub ButtonDataPeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDataPeminjaman.Click
        panelshow(User_Peminjaman)
        User_Peminjaman.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonDataPengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDataPengembalian.Click
        panelshow(User_pengembalian)
        User_pengembalian.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Yakin ingin Logout ?", "PERHATIAN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Me.Close()
            LOGIN_form.Show()
        End If
    End Sub
    Sub peminjamanuser()
        ds = New DataSet()
        query = "SELECT * FROM  tbpeminjaman WHERE id_pengguna='" & LabelID.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            User_Peminjaman.tabelDataPeminjaman.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub pengembalianuser()
        ds = New DataSet()
        query = "SELECT*FROM tbpengembalian WHERE id_pengguna='" & LabelID.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            User_pengembalian.TabelDataPengembalian.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbout.Click
        panelshow(About)
        About.WindowState = FormWindowState.Maximized
    End Sub
End Class