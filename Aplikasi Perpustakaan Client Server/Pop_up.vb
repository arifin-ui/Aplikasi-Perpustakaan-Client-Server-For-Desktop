Imports System.Data.Odbc
Public Class Pop_up
    'form load
    Private Sub Pop_up_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        pengguna()
        buku()
        peminjamanpengembalian()
    End Sub
    'tabel pengguna
    Sub pengguna()
        ds = New DataSet()
        query = "SELECT id_pengguna,NAMA from tbpengguna WHERE AKSES='" & akses & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelPengguna.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'tabel buku
    Sub buku()
        ds = New DataSet()
        query = "SELECT id_buku,JUDUl_BUKU,STOK from tbbuku"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelBuku.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'cari penguna
    Private Sub TextBoxCariPengguna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCariPengguna.TextChanged
        ds = New DataSet()
        query = "SELECT ID,NAMA from tbpengguna WHERE NAMA like '%" & TextBoxCariPengguna.Text & "%' and AKSES='" & akses & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelPengguna.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'cari buku
    Private Sub TextBoxCariBuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCariBuku.TextChanged
        ds = New DataSet()
        query = "SELECT id_buku,JUDUl_BUKU from tbbuku WHERE JUDUL_BUKU like '%" & TextBoxCariBuku.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelBuku.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabelPengguna_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TabelPengguna.CellClick
        Try
            With TabelPengguna
                DataPeminjaman.LabelIDPENGGUNA.Text = .Item(0, .CurrentRow.Index).Value
                DataPeminjaman.TextBoxNama.Text = .Item(1, .CurrentRow.Index).Value
            End With

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabelBuku_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TabelBuku.CellClick
        Try
            With TabelBuku
                DataPeminjaman.LabelIDBUKU.Text = .Item(0, .CurrentRow.Index).Value
                DataPeminjaman.TextBoxJUDUl.Text = .Item(1, .CurrentRow.Index).Value
            End With

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'peminjaman
    Sub peminjamanpengembalian()
        ds = New DataSet()
        query = "SELECT tbpeminjaman.id, tbbuku.JUDUL_BUKU,tbpengguna.NAMA,tbpeminjaman.id_buku,tbpeminjaman.id_pengguna FROM tbpeminjaman, tbbuku, tbpengguna WHERE tbpeminjaman.ID_BUKU = tbbuku.id_buku AND tbpeminjaman.ID_PENGGUNA = tbpengguna.id_pengguna"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            With DataGridView1
                DataPengembalian.TextBoxID.Text = .Item(0, .CurrentRow.Index).Value
                DataPengembalian.Labelidbuku.Text = .Item(3, .CurrentRow.Index).Value
                DataPengembalian.Labelidpengguna.Text = .Item(4, .CurrentRow.Index).Value
            End With

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class