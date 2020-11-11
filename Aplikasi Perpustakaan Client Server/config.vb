Imports System.Data.Odbc

Module config

    Public con As OdbcConnection
    Public cmd As OdbcCommand
    Public query As String
    Public da As OdbcDataAdapter
    Public dt As DataTable
    Public rd As OdbcDataReader
    Public ds As DataSet

    Sub koneksi()
        con = New OdbcConnection("DSN=perpustakaan")
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'MENAMPILKAN DATA BUKU
    Sub buku()
        ds = New DataSet()
        query = "SELECT * FROM tbbuku"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            DataBuku.tabelBUKU.DataSource = ds.Tables(0)
            User_buku.tabelBUKU.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'PENGGUNA
    Public akses As String = "pengguna"
    Sub pengguna()
        ds = New DataSet()
        query = "SELECT * FROM tbpengguna WHERE AKSES='" & akses & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            DataPengguna.tabelANGGOTA.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'tabel peminjaman
    Public status As String = "DIPINJAM"
    Sub peminjaman()
        ds = New DataSet()
        query = "SELECT * FROM  tbpeminjaman"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            DataPeminjaman.tabelDataPeminjaman.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'TABEL PENGEMBALIAN
    Public statusKEMBALI As String = "DIKEMBALIKAN"
    Sub pengembalian()
        ds = New DataSet()
        query = "SELECT*FROM tbpengembalian"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            DataPengembalian.tabelDataPengembalian.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'KOLEKSI BUKU
    Sub koleksi()
        Try
            query = "SELECT COUNT(id_buku) as koleksi from tbbuku"
            cmd = New OdbcCommand(query, con)
            rd = cmd.ExecuteReader
            If rd.Read Then
                Dashboard.LabelKoleksi.Text = rd("koleksi")
                rd.Close()
            Else
                rd.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'KOLEKSI' : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
