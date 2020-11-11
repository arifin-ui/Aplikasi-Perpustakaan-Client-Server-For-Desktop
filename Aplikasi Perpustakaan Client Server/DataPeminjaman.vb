Imports System.Data.Odbc

Public Class DataPeminjaman
    ' Dim status As String = "DIPINJAM"
    'cari pengguna
    Private Sub ButtonCariPengguna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCariPengguna.Click
        Pop_up.Show()
        Pop_up.GroupBoxPengguna.Visible = True
    End Sub
    'cari buku
    Private Sub ButtonCariBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCariBuku.Click
        Pop_up.Show()
        Pop_up.GroupBoxBuku.Visible = True
    End Sub

    'simpann dan edit
    Private Sub ButtonPEMINJAMAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPEMINJAMAN.Click
        If TextBoxJUDUl.Text = "" Or TextBoxJUMLAH.Text = "" Or TextBoxNama.Text = "" _
                    Or DateTimePicker1.Text = "" Then

            MessageBox.Show("Field data harus di isi semua", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "INSERT INTO `tbpeminjaman` ( `ID_PENGGUNA`, `ID_BUKU`, `TANGGAL_PINJAM`, `JUMLAH_PINJAM`, `STATUS`) VALUES " & _
                "('" & LabelIDPENGGUNA.Text & "','" & LabelIDBUKU.Text & "','" & DateTimePicker1.Text & "', " & _
                " '" & TextBoxJUMLAH.Text & "','" & status & "')"
            cmd.CommandText = query
            Try
                cmd.ExecuteNonQuery()
                peminjaman()
                CLEAR()
                MessageBox.Show("Sukses Menyimpan Data Pengguna", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'form load
    Private Sub DataPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        peminjaman()
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSToolStripMenuItem.Click
        Try
            With tabelDataPeminjaman
                LabelID.Text = .Item(0, .CurrentRow.Index).Value
            End With
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If MessageBox.Show("Yakin ingin Menghapus Data Peminjaman ?", "PERHATIAN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "DELETE FROM tbpeminjaman WHERE id='" & LabelID.Text & "'"
            cmd.CommandText = query
            Try
                cmd.ExecuteNonQuery()
                peminjaman()
                MessageBox.Show("Sukses Menghapus Data Peminjaman", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Buttoncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncancel.Click
        CLEAR()
    End Sub
    'clear
    Sub CLEAR()
        TextBoxJUDUl.Text = ""
        TextBoxNama.Text = ""
    End Sub
End Class