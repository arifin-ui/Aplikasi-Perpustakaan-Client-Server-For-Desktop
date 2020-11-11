Imports System.Data.Odbc

Public Class DataPengguna
    'FORM LOAD 
    Private Sub DataPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        pengguna()
    End Sub

    'SIMPAN DAN EDIT
    Private Sub ButtonPENGGUNA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPENGGUNA.Click
        If ButtonPENGGUNA.Text = "SIMPAN" Then
            Try

                If TextBoxKELAS.Text = "" Or TextBoxNAMA.Text = "" Or TextBoxNIM.Text = "" _
                    Or TextBoxPASSWORD.Text = "" Or ComboBoxJURUSAN.Text = "" Then

                    MessageBox.Show("Field data harus di isi semua", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    cmd = New OdbcCommand
                    cmd.Connection = con
                    query = "INSERT INTO tbpengguna(nama,jurusan,kelas,nim,password,akses)VALUES " & _
                        "('" & TextBoxNAMA.Text & "','" & ComboBoxJURUSAN.Text & "','" & TextBoxKELAS.Text & "', " & _
                        " '" & TextBoxNIM.Text & "','" & TextBoxPASSWORD.Text & "','" & akses & "')"
                    cmd.CommandText = query
                    Try
                        cmd.ExecuteNonQuery()
                        pengguna()
                        CLEAR()
                        MessageBox.Show("Sukses Menyimpan Data Pengguna", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf ButtonPENGGUNA.Text = "EDIT" Then
            Try

                If TextBoxKELAS.Text = "" Or TextBoxNAMA.Text = "" Or TextBoxNIM.Text = "" _
                    Or TextBoxPASSWORD.Text = "" Or ComboBoxJURUSAN.Text = "" Then

                    MessageBox.Show("Field data harus di isi semua", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    cmd = New OdbcCommand
                    cmd.Connection = con
                    query = "UPDATE tbpengguna SET nama='" & TextBoxNAMA.Text & "',jurusan='" & ComboBoxJURUSAN.Text & "', " & _
                        "kelas='" & TextBoxKELAS.Text & "',nim='" & TextBoxNIM.Text & "' WHERE id='" & LabelID.Text & "'"
                    cmd.CommandText = query
                    Try
                        cmd.ExecuteNonQuery()
                        pengguna()
                        CANCEL()
                        MessageBox.Show("Sukses Mengedit Data Pengguna", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'cancel button
    Sub CANCEL()
        Buttoncancel.Text = "CLEAR"
        ButtonPENGGUNA.Text = "SIMPAN"
        TextBoxKELAS.Text = ""
        TextBoxNAMA.Text = ""
        TextBoxNIM.Text = ""
        TextBoxPASSWORD.Text = ""
        ComboBoxJURUSAN.Text = ""
    End Sub
    'clear
    Sub CLEAR()
        TextBoxKELAS.Text = ""
        TextBoxNAMA.Text = ""
        TextBoxNIM.Text = ""
        TextBoxPASSWORD.Text = ""
        ComboBoxJURUSAN.Text = ""
    End Sub
    'Edit
    Private Sub EDITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITToolStripMenuItem.Click
        ButtonPENGGUNA.Text = "EDIT"
        Buttoncancel.Text = "CANCEL"
        Try

            With tabelANGGOTA
                LabelID.Text = .Item(0, .CurrentRow.Index).Value
                TextBoxNAMA.Text = .Item(1, .CurrentRow.Index).Value
                ComboBoxJURUSAN.Text = .Item(2, .CurrentRow.Index).Value
                TextBoxKELAS.Text = .Item(3, .CurrentRow.Index).Value
                TextBoxNIM.Text = .Item(4, .CurrentRow.Index).Value
                TextBoxPASSWORD.Text = .Item(5, .CurrentRow.Index).Value
            End With

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Hapus

    Private Sub HAPUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSToolStripMenuItem.Click
        Try
            With tabelANGGOTA
                LabelID.Text = .Item(0, .CurrentRow.Index).Value
            End With
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If MessageBox.Show("Yakin ingin Menghapus Data Pengguna ?", "PERHATIAN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "DELETE FROM tbpengguna WHERE id='" & LabelID.Text & "'"
            cmd.CommandText = query
            Try
                cmd.ExecuteNonQuery()
                pengguna()
                MessageBox.Show("Sukses Menghapus Data Pengguna", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Buttoncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncancel.Click
        If Buttoncancel.Text = "CLEAR" Then
            CLEAR()
        ElseIf Buttoncancel.Text = "CANCEL" Then
            CANCEL()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ds = New DataSet()
        query = "SELECT * FROM tbpengguna WHERE  NAMA LIKE '%" & TextBox1.Text & "%' AND AKSES='" & akses & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            tabelANGGOTA.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class