Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Membersihkan semua txtField di layar'
        txtNIP.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""

        'Membersihkan selection pada DataGrid'
        DataGridView1.ClearSelection()
        txtNIP.Focus()
        'Membuat kursor kembali ke posisi txtNIP'
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim res As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data dengan NIP " +
                        selectedRow.Cells(0).Value + " ?",
                        "Konfirmasi",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
        If (res = Windows.Forms.DialogResult.Yes) Then
            DataGridView1.Rows.Remove(selectedRow)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Jika datagrid ada yang dipilih maka
        If (DataGridView1.SelectedRows().Count > 0) Then
            'Buat variabel baru yaitu baris yang dipilh 
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells(0).Value = txtNIP.Text
            selectedRow.Cells(1).Value = txtNama.Text
            selectedRow.Cells(2).Value = txtAlamat.Text

            DataGridView1.Refresh()
        Else

            ' Menambahkan data pada masing masing '
            ' Textfield ke dalam dataGridView '
            DataGridView1.Rows.Add(txtNIP.Text,
                                   txtNama.Text,
                                   txtAlamat.Text)

            btnNew.PerformClick()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DataGridView1.Rows(e.RowIndex).Selected = True
        txtNIP.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        txtNama.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        txtAlamat.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class