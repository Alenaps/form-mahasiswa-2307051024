<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbNPM = New System.Windows.Forms.Label()
        Me.txtNpm = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Jurusan = New System.Windows.Forms.Label()
        Me.lbMataKuliah = New System.Windows.Forms.Label()
        Me.cmbMataKuliah = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.rblakilaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.jeniskelamin = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbGRADE = New System.Windows.Forms.Label()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.lbUAS = New System.Windows.Forms.Label()
        Me.lbUTS = New System.Windows.Forms.Label()
        Me.lbTugas = New System.Windows.Forms.Label()
        Me.lbNilai = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kolomnpm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolomnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolomjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolomjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolommatakuliah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolomgrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbNPM
        '
        Me.lbNPM.AutoSize = True
        Me.lbNPM.Location = New System.Drawing.Point(30, 49)
        Me.lbNPM.Name = "lbNPM"
        Me.lbNPM.Size = New System.Drawing.Size(43, 20)
        Me.lbNPM.TabIndex = 0
        Me.lbNPM.Text = "NPM"
        '
        'txtNpm
        '
        Me.txtNpm.Location = New System.Drawing.Point(205, 49)
        Me.txtNpm.Name = "txtNpm"
        Me.txtNpm.Size = New System.Drawing.Size(215, 26)
        Me.txtNpm.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(205, 91)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(474, 26)
        Me.txtNama.TabIndex = 2
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(30, 94)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(51, 20)
        Me.Nama.TabIndex = 3
        Me.Nama.Text = "Nama"
        '
        'Jurusan
        '
        Me.Jurusan.AutoSize = True
        Me.Jurusan.Location = New System.Drawing.Point(17, 164)
        Me.Jurusan.Name = "Jurusan"
        Me.Jurusan.Size = New System.Drawing.Size(66, 20)
        Me.Jurusan.TabIndex = 4
        Me.Jurusan.Text = "Jurusan"
        '
        'lbMataKuliah
        '
        Me.lbMataKuliah.AutoSize = True
        Me.lbMataKuliah.Location = New System.Drawing.Point(17, 216)
        Me.lbMataKuliah.Name = "lbMataKuliah"
        Me.lbMataKuliah.Size = New System.Drawing.Size(92, 20)
        Me.lbMataKuliah.TabIndex = 5
        Me.lbMataKuliah.Text = "Mata Kuliah"
        '
        'cmbMataKuliah
        '
        Me.cmbMataKuliah.FormattingEnabled = True
        Me.cmbMataKuliah.Items.AddRange(New Object() {"FMIPA", " " & Global.Microsoft.VisualBasic.ChrW(9) & "ilkom", "FKIP", "" & Global.Microsoft.VisualBasic.ChrW(9) & "keguruan", "FEB", "" & Global.Microsoft.VisualBasic.ChrW(9) & "bisnis digital"})
        Me.cmbMataKuliah.Location = New System.Drawing.Point(192, 216)
        Me.cmbMataKuliah.Name = "cmbMataKuliah"
        Me.cmbMataKuliah.Size = New System.Drawing.Size(475, 28)
        Me.cmbMataKuliah.TabIndex = 9
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(192, 161)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(475, 28)
        Me.cmbJurusan.TabIndex = 10
        '
        'rblakilaki
        '
        Me.rblakilaki.AutoSize = True
        Me.rblakilaki.Location = New System.Drawing.Point(193, 116)
        Me.rblakilaki.Name = "rblakilaki"
        Me.rblakilaki.Size = New System.Drawing.Size(96, 24)
        Me.rblakilaki.TabIndex = 11
        Me.rblakilaki.TabStop = True
        Me.rblakilaki.Text = "Laki Laki"
        Me.rblakilaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(405, 114)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(116, 24)
        Me.rbperempuan.TabIndex = 12
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'jeniskelamin
        '
        Me.jeniskelamin.AutoSize = True
        Me.jeniskelamin.Location = New System.Drawing.Point(30, 138)
        Me.jeniskelamin.Name = "jeniskelamin"
        Me.jeniskelamin.Size = New System.Drawing.Size(106, 20)
        Me.jeniskelamin.TabIndex = 13
        Me.jeniskelamin.Text = "Jenis Kelamin"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbGRADE)
        Me.GroupBox1.Controls.Add(Me.txtUAS)
        Me.GroupBox1.Controls.Add(Me.rblakilaki)
        Me.GroupBox1.Controls.Add(Me.rbperempuan)
        Me.GroupBox1.Controls.Add(Me.txtUTS)
        Me.GroupBox1.Controls.Add(Me.txtTugas)
        Me.GroupBox1.Controls.Add(Me.cmbJurusan)
        Me.GroupBox1.Controls.Add(Me.Jurusan)
        Me.GroupBox1.Controls.Add(Me.lbUAS)
        Me.GroupBox1.Controls.Add(Me.cmbMataKuliah)
        Me.GroupBox1.Controls.Add(Me.lbMataKuliah)
        Me.GroupBox1.Controls.Add(Me.lbUTS)
        Me.GroupBox1.Controls.Add(Me.lbTugas)
        Me.GroupBox1.Controls.Add(Me.lbNilai)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1195, 337)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'lbGRADE
        '
        Me.lbGRADE.AutoSize = True
        Me.lbGRADE.Location = New System.Drawing.Point(691, 275)
        Me.lbGRADE.Name = "lbGRADE"
        Me.lbGRADE.Size = New System.Drawing.Size(88, 20)
        Me.lbGRADE.TabIndex = 23
        Me.lbGRADE.Text = "--GRADE--"
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(567, 272)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(100, 26)
        Me.txtUAS.TabIndex = 22
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(405, 272)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(100, 26)
        Me.txtUTS.TabIndex = 21
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(247, 272)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(100, 26)
        Me.txtTugas.TabIndex = 20
        '
        'lbUAS
        '
        Me.lbUAS.AutoSize = True
        Me.lbUAS.Location = New System.Drawing.Point(518, 276)
        Me.lbUAS.Name = "lbUAS"
        Me.lbUAS.Size = New System.Drawing.Size(43, 20)
        Me.lbUAS.TabIndex = 19
        Me.lbUAS.Text = "UAS"
        '
        'lbUTS
        '
        Me.lbUTS.AutoSize = True
        Me.lbUTS.Location = New System.Drawing.Point(359, 278)
        Me.lbUTS.Name = "lbUTS"
        Me.lbUTS.Size = New System.Drawing.Size(41, 20)
        Me.lbUTS.TabIndex = 18
        Me.lbUTS.Text = "UTS"
        '
        'lbTugas
        '
        Me.lbTugas.AutoSize = True
        Me.lbTugas.Location = New System.Drawing.Point(188, 277)
        Me.lbTugas.Name = "lbTugas"
        Me.lbTugas.Size = New System.Drawing.Size(53, 20)
        Me.lbTugas.TabIndex = 17
        Me.lbTugas.Text = "Tugas"
        '
        'lbNilai
        '
        Me.lbNilai.AutoSize = True
        Me.lbNilai.Location = New System.Drawing.Point(19, 277)
        Me.lbNilai.Name = "lbNilai"
        Me.lbNilai.Size = New System.Drawing.Size(38, 20)
        Me.lbNilai.TabIndex = 16
        Me.lbNilai.Text = "Nilai"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 374)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1195, 69)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(522, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(669, 35)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(251, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(267, 35)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(127, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 35)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(6, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(118, 35)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 456)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1195, 254)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolomnpm, Me.kolomnama, Me.kolomjeniskelamin, Me.kolomjurusan, Me.kolommatakuliah, Me.kolomgrade})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.Location = New System.Drawing.Point(6, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1183, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'kolomnpm
        '
        Me.kolomnpm.HeaderText = "NPM"
        Me.kolomnpm.Name = "kolomnpm"
        Me.kolomnpm.ReadOnly = True
        '
        'kolomnama
        '
        Me.kolomnama.HeaderText = "Nama"
        Me.kolomnama.Name = "kolomnama"
        Me.kolomnama.ReadOnly = True
        Me.kolomnama.Width = 200
        '
        'kolomjeniskelamin
        '
        Me.kolomjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.kolomjeniskelamin.Name = "kolomjeniskelamin"
        Me.kolomjeniskelamin.ReadOnly = True
        Me.kolomjeniskelamin.Width = 130
        '
        'kolomjurusan
        '
        Me.kolomjurusan.HeaderText = "Jurusan"
        Me.kolomjurusan.Name = "kolomjurusan"
        Me.kolomjurusan.ReadOnly = True
        Me.kolomjurusan.Width = 130
        '
        'kolommatakuliah
        '
        Me.kolommatakuliah.HeaderText = "Mata Kuliah"
        Me.kolommatakuliah.Name = "kolommatakuliah"
        Me.kolommatakuliah.ReadOnly = True
        Me.kolommatakuliah.Width = 130
        '
        'kolomgrade
        '
        Me.kolomgrade.HeaderText = "GRADE"
        Me.kolomgrade.Name = "kolomgrade"
        Me.kolomgrade.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 727)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.jeniskelamin)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNpm)
        Me.Controls.Add(Me.lbNPM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNPM As System.Windows.Forms.Label
    Friend WithEvents txtNpm As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents Jurusan As System.Windows.Forms.Label
    Friend WithEvents lbMataKuliah As System.Windows.Forms.Label
    Friend WithEvents cmbMataKuliah As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents rblakilaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents jeniskelamin As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents lbUAS As System.Windows.Forms.Label
    Friend WithEvents lbUTS As System.Windows.Forms.Label
    Friend WithEvents lbTugas As System.Windows.Forms.Label
    Friend WithEvents lbNilai As System.Windows.Forms.Label
    Friend WithEvents lbGRADE As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents kolomnpm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolomnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolomjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolomjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolommatakuliah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolomgrade As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
