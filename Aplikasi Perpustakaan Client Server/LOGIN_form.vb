Imports System.Data.Odbc
Public Class LOGIN_form

    'close window
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
    'minimize
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'jam
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelJAM.Text = TimeOfDay
    End Sub

    'tampilkan dan sembunyikan password
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTampilkan.CheckedChanged
        If CheckBoxTampilkan.Checked Then
            TextBoxpassword.UseSystemPasswordChar = False
            CheckBoxTampilkan.Text = "Sembunyikan Password"
        Else
            TextBoxpassword.UseSystemPasswordChar = True
            CheckBoxTampilkan.Text = "Tampilkan Password"
        End If
    End Sub

    'copyright
    Private Sub Dashboard_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TextBoxnim.Focus()
        Labelcopyright.Text = My.Application.Info.Copyright + " Febi Arifin TI-1"
    End Sub

    'login code

    Private Sub Buttonlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonlogin.Click
        Try
            If TextBoxnim.Text = "" Or TextBoxpassword.Text = "" Then
                MessageBox.Show("NIM dan Password Tidak Boleh Kosong, Silahkan Coba Lagi !", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmd = New OdbcCommand
                cmd.Connection = con
                query = "select*from tbpengguna where NIM='" & TextBoxnim.Text & "' and PASSWORD='" & TextBoxpassword.Text & "'"
                cmd.CommandText = query
                da = New OdbcDataAdapter(query, con)
                dt = New DataTable()
                Try
                    da.Fill(dt)
                    If (dt.Rows.Count > 0) Then
                        MessageBox.Show("Login Sebagai : " + dt.Rows(0)(1), "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If (dt.Rows(0)(6) = "admin") Then
                            Admin_Form.Show()
                            Me.Hide()
                            berhasil()
                        ElseIf (dt.Rows(0)(6) = "pengguna") Then
                            Pengguna_form.Show()
                            Me.Hide()
                            berhasil()
                        End If
                    Else
                        gagal()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error : " & ex.Message, "PERHATIAN", _
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "PERHATIAN", _
                 MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub gagal()
        MessageBox.Show("NIM dan Password Salah, Silahkan Coba Lagi !", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        TextBoxnim.Text = ""
        TextBoxpassword.Text = ""
        TextBoxnim.Focus()
    End Sub
    Sub berhasil()
        TextBoxnim.Text = ""
        TextBoxpassword.Text = ""
        TextBoxnim.Focus()
    End Sub

End Class
