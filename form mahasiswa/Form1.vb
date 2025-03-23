Public Class Form1
    ' ErrorProvider untuk validasi input
    Dim errorProvider As New ErrorProvider()

    ' Inisialisasi data mata kuliah sesuai jurusan
    Dim mataKuliahByJurusan As New Dictionary(Of String, List(Of String)) From {
        {"Matematika", New List(Of String) From {"Aljabar Linear Lanjut", "Matematika Diskrit", "Teori Bilangan", "Statistika Inferensial"}},
        {"Kimia", New List(Of String) From {"Kimia Organik", "Kimia Analitik", "Termokimia"}},
        {"Biologi", New List(Of String) From {"Genetika", "Ekologi", "Microbiologi Terapan", "Bioteknologi"}},
        {"Fisika", New List(Of String) From {"Mekanika Kuantum", "Elektrodinamika", "Termodinamika", "Fisika Statistik"}},
        {"Ilmu Komputer", New List(Of String) From {"IOT", "Machine Learning", "Kecerdasan Buatan", "Pemrograman Terstruktur"}},
        {"Manajemen Informatika", New List(Of String) From {"Pemrograman Desktop", "Pemrograman Web Lanjut", "Pemrograman Mobile", "Keamanan Sistem Informasi"}}
    }

    ' Fungsi: Bersihkan semua input field
    Private Sub ClearFields()
        txtNpm.Text = ""
        txtNama.Text = ""
        rblakilaki.Checked = False
        rbperempuan.Checked = False
        cmbJurusan.SelectedIndex = -1
        cmbMataKuliah.SelectedIndex = -1
        txtTugas.Text = ""
        txtUTS.Text = ""
        txtUAS.Text = ""
        lbGRADE.Text = ""

        txtNpm.Enabled = True ' Mengaktifkan kembali input NPM
        txtNpm.Focus() ' Membuat cursor kembali ke NPM

        Dim jeniskelamin As String = ""
        If rblakilaki.Checked Then
            jeniskelamin = "Laki-Laki"
        ElseIf rbperempuan.Checked Then
            jeniskelamin = "Perempuan"
        End If

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbNPM.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Nama.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Jurusan.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNpm.TextChanged
        If Not IsNumeric(txtNpm.Text) Then
            errorProvider.SetError(txtNpm, "NIP harus berupa angka")
            txtNpm.Clear()
            txtNpm.Focus()
        Else
            errorProvider.SetError(txtNpm, "")
        End If
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJurusan.SelectedIndexChanged
        ' Mengosongkan ComboBox Mata Kuliah
        cmbMataKuliah.Items.Clear()

        ' Validasi jika ComboBox Jurusan tidak memiliki nilai yang dipilih
        If cmbJurusan.SelectedItem IsNot Nothing Then
            ' Mengambil jurusan yang dipilih
            Dim jurusanDipilih As String = cmbJurusan.SelectedItem.ToString()

            ' Mengosongkan ComboBox Mata Kuliah
            cmbMataKuliah.Items.Clear()

            ' Mengisi mata kuliah sesuai jurusan
            If mataKuliahByJurusan.ContainsKey(jurusanDipilih) Then
                cmbMataKuliah.Items.AddRange(mataKuliahByJurusan(jurusanDipilih).ToArray())
            End If
        End If


    End Sub

    Private Sub Process_Click(sender As Object, e As EventArgs)

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
        If rblakilaki.Checked Then
            jeniskelamin = "Laki-Laki"
        Else
            jeniskelamin = "Perempuan"
        End If

        MessageBox.Show("Hai : " & txtNama.Text & vbCrLf &
                        "Nip : " & txtNpm.Text & vbCrLf &
                        "Fakultas : " & cmbMataKuliah.SelectedItem & vbCrLf &
                        "Jurusan : " & cmbJurusan.SelectedItem & vbCrLf &
                        "Jenis Kelamin : " & jeniskelamin & vbCrLf &
                        "Nilai Akhir: " & totalNilai.ToString("F2") & vbCrLf &
                        "GRADE: " & grade, "Hasil")

    End Sub

    Private Sub cmbFakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMataKuliah.SelectedIndexChanged

    End Sub

    Private Sub Fakultas_Click(sender As Object, e As EventArgs) Handles lbMataKuliah.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rblakilaki.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form Load untuk mengisi ComboBox Jurusan
        cmbJurusan.Items.AddRange(mataKuliahByJurusan.Keys.ToArray())
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lbTugas.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbUTS.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lbGRADE.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearFields()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Mengambil nilai Jenis Kelamin
        Dim jeniskelamin As String = ""
        If rblakilaki.Checked Then
            jeniskelamin = "Laki-Laki"
        ElseIf rbperempuan.Checked Then
            jeniskelamin = "Perempuan"
        End If

        If txtNpm.Enabled Then
            ' Menambahkan data baru ke DataGridView
            DataGridView1.Rows.Add(txtNpm.Text, txtNama.Text, jeniskelamin, cmbJurusan.SelectedItem, cmbMataKuliah.SelectedItem, lbGRADE.Text)
        Else
            ' Update data yang dipilih di DataGridView
            Dim selectedRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells(0).Value = txtNpm.Text
            selectedRow.Cells(1).Value = txtNama.Text
            selectedRow.Cells(2).Value = jeniskelamin
            selectedRow.Cells(3).Value = cmbJurusan.SelectedItem
            selectedRow.Cells(4).Value = cmbMataKuliah.SelectedItem
            selectedRow.Cells(5).Value = lbGRADE.Text
        End If
        ClearFields()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim dialogResult As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data dengan NPM " + selectedRow.Cells(0).Value + " ?", "Konfirmasi", MessageBoxButtons.YesNo)
            If dialogResult = dialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            End If
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub HitungGrade(sender As Object, e As EventArgs) Handles txtTugas.TextChanged, txtUTS.TextChanged, txtUAS.TextChanged
        Dim tugas, uts, uas As Integer
        If Integer.TryParse(txtTugas.Text, tugas) AndAlso
           Integer.TryParse(txtUTS.Text, uts) AndAlso
           Integer.TryParse(txtUAS.Text, uas) Then

            ' Menghitung nilai akhir berdasarkan bobot
            Dim totalNilai As Integer = CInt(tugas * 0.3 + uts * 0.3 + uas * 0.4)

            ' Menentukan GRADE berdasarkan nilai akhir
            lbGRADE.Text =
                If(totalNilai >= 78, "A",
                    If(totalNilai >= 65, "B",
                        If(totalNilai >= 50, "C",
                            If(totalNilai >= 40, "D", "E")
                        )
                    )
                )
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            txtNpm.Text = selectedRow.Cells(0).Value.ToString()
            txtNama.Text = selectedRow.Cells(1).Value.ToString()
            jeniskelamin.Text = selectedRow.Cells(2).Value.ToString()
            cmbJurusan.SelectedItem = selectedRow.Cells(3).Value.ToString()
            cmbMataKuliah.SelectedItem = selectedRow.Cells(4).Value.ToString()
            lbGRADE.Text = selectedRow.Cells(5).Value.ToString()
            txtNpm.Enabled = False
        End If

    End Sub
End Class
