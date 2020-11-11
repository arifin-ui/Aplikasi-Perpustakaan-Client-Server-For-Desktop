Imports System.Data.Odbc
Public Class User_pengembalian

    Private Sub User_pengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        pengembalianuser()
    End Sub

    Sub pengembalianuser()
        ds = New DataSet()
        query = "SELECT*FROM tbpengembalian WHERE id_pengguna='" & Pengguna_form.LabelID.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelDataPengembalian.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class