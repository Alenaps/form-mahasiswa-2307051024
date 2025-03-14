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

        Dim nilaiTugas As Double = Double.Parse(txtTugas.Text)
        Dim nilaiUTS As Double = Double.Parse(txtUTS.Text)
        Dim nilaiUAS As Double = Double.Parse(txtUAS.Text)
        Dim totalNilai As Double = (nilaiTugas * 0.3) + (nilaiUTS * 0.3) + (nilaiUAS * 0.4)

        Dim grade As String
        Select Case totalNilai
            Case Is >= 78
                grade = "A"
            Case Is >= 65
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 40
                grade = "D"
            Case Else
                grade = "E"
        End Select

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
                        "Jenis Kelamin : " & jeniskelamin & vbCrLf &
                        "Nilai Akhir: " & totalNilai.ToString("F2") & vbCrLf &
                        "GRADE: " & grade, "Hasil")

    End Sub

    Private Sub cmbFakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFakultas.SelectedIndexChanged

    End Sub

    Private Sub Fakultas_Click(sender As Object, e As EventArgs) Handles Fakultas.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles lakilaki.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lbTugas.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbUTS.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lbGRADE.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
