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
        Me.NIP = New System.Windows.Forms.Label()
        Me.txtNip = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Jurusan = New System.Windows.Forms.Label()
        Me.Fakultas = New System.Windows.Forms.Label()
        Me.Process = New System.Windows.Forms.Button()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.lakilaki = New System.Windows.Forms.RadioButton()
        Me.perempuan = New System.Windows.Forms.RadioButton()
        Me.jeniskelamin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NIP
        '
        Me.NIP.AutoSize = True
        Me.NIP.Location = New System.Drawing.Point(43, 58)
        Me.NIP.Name = "NIP"
        Me.NIP.Size = New System.Drawing.Size(35, 20)
        Me.NIP.TabIndex = 0
        Me.NIP.Text = "NIP"
        '
        'txtNip
        '
        Me.txtNip.Location = New System.Drawing.Point(218, 58)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.Size = New System.Drawing.Size(190, 26)
        Me.txtNip.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(218, 100)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(411, 26)
        Me.txtNama.TabIndex = 2
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(43, 103)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(51, 20)
        Me.Nama.TabIndex = 3
        Me.Nama.Text = "Nama"
        '
        'Jurusan
        '
        Me.Jurusan.AutoSize = True
        Me.Jurusan.Location = New System.Drawing.Point(43, 250)
        Me.Jurusan.Name = "Jurusan"
        Me.Jurusan.Size = New System.Drawing.Size(66, 20)
        Me.Jurusan.TabIndex = 4
        Me.Jurusan.Text = "Jurusan"
        '
        'Fakultas
        '
        Me.Fakultas.AutoSize = True
        Me.Fakultas.Location = New System.Drawing.Point(43, 202)
        Me.Fakultas.Name = "Fakultas"
        Me.Fakultas.Size = New System.Drawing.Size(70, 20)
        Me.Fakultas.TabIndex = 5
        Me.Fakultas.Text = "Fakultas"
        '
        'Process
        '
        Me.Process.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process.Location = New System.Drawing.Point(47, 326)
        Me.Process.Name = "Process"
        Me.Process.Size = New System.Drawing.Size(134, 37)
        Me.Process.TabIndex = 6
        Me.Process.Text = "Process"
        Me.Process.UseVisualStyleBackColor = True
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.cmbFakultas.Location = New System.Drawing.Point(218, 202)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(340, 28)
        Me.cmbFakultas.TabIndex = 9
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cmbJurusan.Location = New System.Drawing.Point(218, 247)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(340, 28)
        Me.cmbJurusan.TabIndex = 10
        '
        'lakilaki
        '
        Me.lakilaki.AutoSize = True
        Me.lakilaki.Location = New System.Drawing.Point(218, 147)
        Me.lakilaki.Name = "lakilaki"
        Me.lakilaki.Size = New System.Drawing.Size(96, 24)
        Me.lakilaki.TabIndex = 11
        Me.lakilaki.TabStop = True
        Me.lakilaki.Text = "Laki Laki"
        Me.lakilaki.UseVisualStyleBackColor = True
        '
        'perempuan
        '
        Me.perempuan.AutoSize = True
        Me.perempuan.Location = New System.Drawing.Point(385, 147)
        Me.perempuan.Name = "perempuan"
        Me.perempuan.Size = New System.Drawing.Size(116, 24)
        Me.perempuan.TabIndex = 12
        Me.perempuan.TabStop = True
        Me.perempuan.Text = "Perempuan"
        Me.perempuan.UseVisualStyleBackColor = True
        '
        'jeniskelamin
        '
        Me.jeniskelamin.AutoSize = True
        Me.jeniskelamin.Location = New System.Drawing.Point(43, 147)
        Me.jeniskelamin.Name = "jeniskelamin"
        Me.jeniskelamin.Size = New System.Drawing.Size(106, 20)
        Me.jeniskelamin.TabIndex = 13
        Me.jeniskelamin.Text = "Jenis Kelamin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 416)
        Me.Controls.Add(Me.jeniskelamin)
        Me.Controls.Add(Me.perempuan)
        Me.Controls.Add(Me.lakilaki)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.Process)
        Me.Controls.Add(Me.Fakultas)
        Me.Controls.Add(Me.Jurusan)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNip)
        Me.Controls.Add(Me.NIP)
        Me.Name = "Form1"
        Me.Text = "oiuy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NIP As System.Windows.Forms.Label
    Friend WithEvents txtNip As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents Jurusan As System.Windows.Forms.Label
    Friend WithEvents Fakultas As System.Windows.Forms.Label
    Friend WithEvents Process As System.Windows.Forms.Button
    Friend WithEvents cmbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents lakilaki As System.Windows.Forms.RadioButton
    Friend WithEvents perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents jeniskelamin As System.Windows.Forms.Label

End Class
