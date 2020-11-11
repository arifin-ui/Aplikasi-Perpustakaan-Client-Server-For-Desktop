Imports System.Data.Odbc
Public Class DataBuku
    'form load
    Private Sub DataBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        buku()
    End Sub
   
    'SIMPAN DAN EDIT
    Private Sub ButtonBUKU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBUKU.Click
        If ButtonBUKU.Text = "SIMPAN" Then
            Try

                If TextBoxJUDUL.Text = "" Or TextBoxNAMAPENERBIT.Text = "" Or TextBoxNAMAPENGARANG.Text = "" _
                    Or TextBoxSTOK.Text = "" Or TextBoxTAHUNTERBIT.Text = "" Or ComboBoxASALBUKU.Text = "" Then

                    MessageBox.Show("Field data harus di isi semua", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    cmd = New OdbcCommand
                    cmd.Connection = con
                    query = "INSERT INTO tbbuku (judul_buku,nama_penerbit,tahun_terbit,stok,nama_pengarang,asal_buku )VALUES " & _
                        "('" & TextBoxJUDUL.Text & "','" & TextBoxNAMAPENERBIT.Text & "','" & TextBoxTAHUNTERBIT.Text & "', " & _
                        " '" & TextBoxSTOK.Text & "','" & TextBoxNAMAPENGARANG.Text & "','" & ComboBoxASALBUKU.Text & "')"
                    cmd.CommandText = query
                    Try
                        cmd.ExecuteNonQuery()
                        buku()
                        CLEAR()
                        MessageBox.Show("Sukses Menyimpan Data Buku", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf ButtonBUKU.Text = "EDIT" Then
            Try

                If TextBoxJUDUL.Text = "" Or TextBoxNAMAPENERBIT.Text = "" Or TextBoxNAMAPENGARANG.Text = "" _
                    Or TextBoxSTOK.Text = "" Or TextBoxTAHUNTERBIT.Text = "" Or ComboBoxASALBUKU.Text = "" Then

                    MessageBox.Show("Field data harus di isi semua", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    cmd = New OdbcCommand
                    cmd.Connection = con
                    query = "UPDATE tbbuku SET judul_buku='" & TextBoxJUDUL.Text & "',nama_penerbit='" & TextBoxNAMAPENERBIT.Text & "', " & _
                        "tahun_terbit='" & TextBoxTAHUNTERBIT.Text & "',stok='" & TextBoxSTOK.Text & "', " & _
                        "nama_pengarang='" & TextBoxNAMAPENGARANG.Text & "',asal_buku='" & ComboBoxASALBUKU.Text & "' " & _
                        "WHERE id_buku='" & LabelID.Text & "'"
                    cmd.CommandText = query
                    Try
                        cmd.ExecuteNonQuery()
                        buku()
                        CANCEL()
                        MessageBox.Show("Sukses Mengedit Data Buku", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'Edit Context menu script
    Private Sub EDITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITToolStripMenuItem.Click
        ButtonBUKU.Text = "EDIT"
        Buttoncancel.Text = "CANCEL"
        Try

            With tabelBUKU
                LabelID.Text = .Item(0, .CurrentRow.Index).Value
                TextBoxJUDUL.Text = .Item(1, .CurrentRow.Index).Value
                TextBoxNAMAPENERBIT.Text = .Item(2, .CurrentRow.Index).Value
                TextBoxTAHUNTERBIT.Text = .Item(3, .CurrentRow.Index).Value
                TextBoxSTOK.Text = .Item(4, .CurrentRow.Index).Value
                TextBoxNAMAPENGARANG.Text = .Item(5, .CurrentRow.Index).Value
                ComboBoxASALBUKU.Text = .Item(6, .CurrentRow.Index).Value
            End With

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buttoncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncancel.Click
        If Buttoncancel.Text = "CLEAR" Then
            CLEAR()
        ElseIf Buttoncancel.Text = "CANCEL" Then
            CANCEL()
        End If
    End Sub
    'cancel button
    Sub CANCEL()
        Buttoncancel.Text = "CLEAR"
        ButtonBUKU.Text = "SIMPAN"
        TextBoxJUDUL.Text = ""
        TextBoxNAMAPENERBIT.Text = ""
        TextBoxTAHUNTERBIT.Text = ""
        TextBoxSTOK.Text = ""
        TextBoxNAMAPENGARANG.Text = ""
        ComboBoxASALBUKU.Text = ""
    End Sub
    'CLEAR
    Sub CLEAR()
        TextBoxJUDUL.Text = ""
        TextBoxNAMAPENERBIT.Text = ""
        TextBoxTAHUNTERBIT.Text = ""
        TextBoxSTOK.Text = ""
        TextBoxNAMAPENGARANG.Text = ""
        ComboBoxASALBUKU.Text = ""
    End Sub
    'hapus buku
    Private Sub HAPUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSToolStripMenuItem.Click
        Try
            With tabelBUKU
                LabelID.Text = .Item(0, .CurrentRow.Index).Value
            End With
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If MessageBox.Show("Yakin ingin Menghapus Data Buku ?", "PERHATIAN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "DELETE FROM tbbuku WHERE id_buku='" & LabelID.Text & "'"
            cmd.CommandText = query
            Try
                cmd.ExecuteNonQuery()
                buku()
                MessageBox.Show("Sukses Menghapus Data Buku", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
       
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ds = New DataSet()
        query = "SELECT * FROM tbbuku WHERE JUDUL_BUKU like '%" & TextBox1.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            tabelBUKU.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class