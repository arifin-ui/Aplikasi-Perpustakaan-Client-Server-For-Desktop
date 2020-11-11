Imports System.Data.Odbc
Public Class DataPengembalian
    'FORM LOAD
    Private Sub DataPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        pengembalian()
    End Sub

    Private Sub ButtonCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCari.Click
        Pop_up.Show()
        Pop_up.GroupBoxPeminjaman.Visible = True
    End Sub

    Private Sub Buttoncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncancel.Click
        CLEAR()
    End Sub
    Sub CLEAR()
        TextBoxDenda.Text = ""
        TextBoxID.Text = ""
        TextBoxKeterangan.Text = ""
    End Sub

    Private Sub ButtonPENGEMBALIAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPENGEMBALIAN.Click
        If MessageBox.Show("Yakin ingin mengembalikan buku", "PERHATIAN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "INSERT INTO tbpengembalian (id_pinjam,id_buku,id_pengguna,jumlah_kembali,tanggal_kembali," & _
                "denda,keterangan,status)VALUES('" & TextBoxID.Text & "','" & Labelidbuku.Text & "','" & Labelidpengguna.Text & "', " & _
                "'" & TextBoxJUMLAH.Text & "','" & DateTimePicker1.Text & "','" & TextBoxDenda.Text & "','" & TextBoxKeterangan.Text & "','" & statusKEMBALI & "')"
            cmd.CommandText = query
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("SUKSES MENGEMBALIKAN BUKU", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pengembalian()
            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class