Imports System.Data.Odbc
Public Class User_Peminjaman

    Private Sub User_Peminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        peminjamanuser()
    End Sub
    Sub peminjamanuser()
        ds = New DataSet()
        query = "SELECT * FROM  tbpeminjaman WHERE id_pengguna='" & Pengguna_form.LabelID.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            tabelDataPeminjaman.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class