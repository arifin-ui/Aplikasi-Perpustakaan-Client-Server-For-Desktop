Imports System.Data.Odbc
Public Class Dashboard

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelWAKTU.Text = TimeOfDay
        buku()
        koleksi()
    End Sub
    Sub buku()
        Try
            query = "SELECT SUM(STOK) AS total_buku FROM tbbuku"
            cmd = New OdbcCommand(query, con)
            rd = cmd.ExecuteReader
            If rd.Read Then
                LabelJUMLAHBUKU.Text = rd("total_buku")
                rd.Close()
            Else
                rd.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'STOK' : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Sub koleksi()
        Try
            query = "SELECT COUNT(id_buku) as koleksi from tbbuku"
            cmd = New OdbcCommand(query, con)
            rd = cmd.ExecuteReader
            If rd.Read Then
                LabelKoleksi.Text = rd("koleksi")
                rd.Close()
            Else
                rd.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'KOLEKSI' : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class