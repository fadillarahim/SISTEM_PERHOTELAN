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
        Me.BtnTambahJenisKamar = New System.Windows.Forms.Button()
        Me.TxtHargaKamarPermalam = New System.Windows.Forms.TextBox()
        Me.TxtJenisKamar = New System.Windows.Forms.TextBox()
        Me.LblHargaKamarPermalam = New System.Windows.Forms.Label()
        Me.LblKeteranganJenisKamar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTambahJenisKamar
        '
        Me.BtnTambahJenisKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnTambahJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnTambahJenisKamar.Location = New System.Drawing.Point(523, 306)
        Me.BtnTambahJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTambahJenisKamar.Name = "BtnTambahJenisKamar"
        Me.BtnTambahJenisKamar.Size = New System.Drawing.Size(135, 52)
        Me.BtnTambahJenisKamar.TabIndex = 25
        Me.BtnTambahJenisKamar.Text = "TAMBAH"
        Me.BtnTambahJenisKamar.UseVisualStyleBackColor = False
        '
        'TxtHargaKamarPermalam
        '
        Me.TxtHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtHargaKamarPermalam.Location = New System.Drawing.Point(394, 216)
        Me.TxtHargaKamarPermalam.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtHargaKamarPermalam.Name = "TxtHargaKamarPermalam"
        Me.TxtHargaKamarPermalam.Size = New System.Drawing.Size(263, 38)
        Me.TxtHargaKamarPermalam.TabIndex = 23
        '
        'TxtJenisKamar
        '
        Me.TxtJenisKamar.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtJenisKamar.Location = New System.Drawing.Point(394, 154)
        Me.TxtJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtJenisKamar.Name = "TxtJenisKamar"
        Me.TxtJenisKamar.Size = New System.Drawing.Size(263, 38)
        Me.TxtJenisKamar.TabIndex = 22
        '
        'LblHargaKamarPermalam
        '
        Me.LblHargaKamarPermalam.AutoSize = True
        Me.LblHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblHargaKamarPermalam.Location = New System.Drawing.Point(142, 223)
        Me.LblHargaKamarPermalam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHargaKamarPermalam.Name = "LblHargaKamarPermalam"
        Me.LblHargaKamarPermalam.Size = New System.Drawing.Size(232, 28)
        Me.LblHargaKamarPermalam.TabIndex = 21
        Me.LblHargaKamarPermalam.Text = "Harga Kamar Permalam"
        '
        'LblKeteranganJenisKamar
        '
        Me.LblKeteranganJenisKamar.AutoSize = True
        Me.LblKeteranganJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblKeteranganJenisKamar.Location = New System.Drawing.Point(142, 167)
        Me.LblKeteranganJenisKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKeteranganJenisKamar.Name = "LblKeteranganJenisKamar"
        Me.LblKeteranganJenisKamar.Size = New System.Drawing.Size(122, 28)
        Me.LblKeteranganJenisKamar.TabIndex = 20
        Me.LblKeteranganJenisKamar.Text = "Jenis Kamar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 35)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "TAMBAH JENIS KAMAR HOTEL"
        '
        'TAMBAH_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnTambahJenisKamar)
        Me.Controls.Add(Me.TxtHargaKamarPermalam)
        Me.Controls.Add(Me.TxtJenisKamar)
        Me.Controls.Add(Me.LblHargaKamarPermalam)
        Me.Controls.Add(Me.LblKeteranganJenisKamar)
        Me.Name = "TAMBAH_JENIS_KAMAR"
        Me.Text = "TAMBAH_JENIS_KAMAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambahJenisKamar As Button
    Friend WithEvents TxtHargaKamarPermalam As TextBox
    Friend WithEvents TxtJenisKamar As TextBox
    Friend WithEvents LblHargaKamarPermalam As Label
    Friend WithEvents LblKeteranganJenisKamar As Label
    Friend WithEvents Label1 As Label
End Class
