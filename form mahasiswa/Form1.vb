Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles NIP.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Nama.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Jurusan.Click

    End Sub

    Dim errorProvider As New ErrorProvider()

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNip.TextChanged
        If Not IsNumeric(txtNip.Text) Then
            errorProvider.SetError(txtNip, "NIP harus berupa angka")
            txtNip.Clear()
            txtNip.Focus()
        Else
            errorProvider.SetError(txtNip, "")
        End If
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJurusan.SelectedIndexChanged

    End Sub

    Private Sub Process_Click(sender As Object, e As EventArgs) Handles Process.Click

        Dim jeniskelamin As String = ""
        If lakilaki.Checked Then
            jeniskelamin = "Laki-Laki"
        Else
            jeniskelamin = "Perempuan"
        End If
        MessageBox.Show("Hai : " & txtNama.Text & vbCrLf &
                        "Nip : " & txtNip.Text & vbCrLf &
                        "Fakultas : " & cmbFakultas.SelectedItem & vbCrLf &
                        "Jurusan : " & cmbJurusan.SelectedItem & vbCrLf &
                        "Jenis Kelamin : " & jeniskelamin)

    End Sub

    Private Sub cmbFakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFakultas.SelectedIndexChanged

    End Sub

    Private Sub Fakultas_Click(sender As Object, e As EventArgs) Handles Fakultas.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles lakilaki.CheckedChanged

    End Sub
End Class
