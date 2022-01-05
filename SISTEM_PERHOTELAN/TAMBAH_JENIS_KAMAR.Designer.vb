<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TAMBAH_JENIS_KAMAR
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
        Me.TxtHargaKamarPermalam = New System.Windows.Forms.TextBox()
        Me.TxtJenisKamar = New System.Windows.Forms.TextBox()
        Me.LblHargaKamarPermalam = New System.Windows.Forms.Label()
        Me.LblKeteranganJenisKamar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambahJenisKamar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtHargaKamarPermalam
        '
        Me.TxtHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtHargaKamarPermalam.Location = New System.Drawing.Point(225, 125)
        Me.TxtHargaKamarPermalam.Name = "TxtHargaKamarPermalam"
        Me.TxtHargaKamarPermalam.Size = New System.Drawing.Size(198, 32)
        Me.TxtHargaKamarPermalam.TabIndex = 17
        '
        'TxtJenisKamar
        '
        Me.TxtJenisKamar.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtJenisKamar.Location = New System.Drawing.Point(225, 75)
        Me.TxtJenisKamar.Name = "TxtJenisKamar"
        Me.TxtJenisKamar.Size = New System.Drawing.Size(198, 32)
        Me.TxtJenisKamar.TabIndex = 16
        '
        'LblHargaKamarPermalam
        '
        Me.LblHargaKamarPermalam.AutoSize = True
        Me.LblHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblHargaKamarPermalam.Location = New System.Drawing.Point(36, 131)
        Me.LblHargaKamarPermalam.Name = "LblHargaKamarPermalam"
        Me.LblHargaKamarPermalam.Size = New System.Drawing.Size(183, 22)
        Me.LblHargaKamarPermalam.TabIndex = 15
        Me.LblHargaKamarPermalam.Text = "Harga Kamar Permalam"
        '
        'LblKeteranganJenisKamar
        '
        Me.LblKeteranganJenisKamar.AutoSize = True
        Me.LblKeteranganJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblKeteranganJenisKamar.Location = New System.Drawing.Point(36, 85)
        Me.LblKeteranganJenisKamar.Name = "LblKeteranganJenisKamar"
        Me.LblKeteranganJenisKamar.Size = New System.Drawing.Size(98, 22)
        Me.LblKeteranganJenisKamar.TabIndex = 14
        Me.LblKeteranganJenisKamar.Text = "Jenis Kamar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tambah Jenis Kamar"
        '
        'BtnTambahJenisKamar
        '
        Me.BtnTambahJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnTambahJenisKamar.Location = New System.Drawing.Point(322, 198)
        Me.BtnTambahJenisKamar.Name = "BtnTambahJenisKamar"
        Me.BtnTambahJenisKamar.Size = New System.Drawing.Size(101, 42)
        Me.BtnTambahJenisKamar.TabIndex = 19
        Me.BtnTambahJenisKamar.Text = "TAMBAH"
        Me.BtnTambahJenisKamar.UseVisualStyleBackColor = True
        '
        'TAMBAH_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 278)
        Me.Controls.Add(Me.BtnTambahJenisKamar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtHargaKamarPermalam)
        Me.Controls.Add(Me.TxtJenisKamar)
        Me.Controls.Add(Me.LblHargaKamarPermalam)
        Me.Controls.Add(Me.LblKeteranganJenisKamar)
        Me.Name = "TAMBAH_JENIS_KAMAR"
        Me.Text = "Tambah Jenis Kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtHargaKamarPermalam As TextBox
    Friend WithEvents TxtJenisKamar As TextBox
    Friend WithEvents LblHargaKamarPermalam As Label
    Friend WithEvents LblKeteranganJenisKamar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambahJenisKamar As Button
End Class
