<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDIT_JENIS_KAMAR
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
        Me.LblJenisKamar = New System.Windows.Forms.Label()
        Me.BtnSimpanJenisKamar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtHargaKamarPermalam
        '
        Me.TxtHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtHargaKamarPermalam.Location = New System.Drawing.Point(405, 222)
        Me.TxtHargaKamarPermalam.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtHargaKamarPermalam.Name = "TxtHargaKamarPermalam"
        Me.TxtHargaKamarPermalam.Size = New System.Drawing.Size(240, 38)
        Me.TxtHargaKamarPermalam.TabIndex = 19
        '
        'TxtJenisKamar
        '
        Me.TxtJenisKamar.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtJenisKamar.Location = New System.Drawing.Point(405, 169)
        Me.TxtJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtJenisKamar.Name = "TxtJenisKamar"
        Me.TxtJenisKamar.Size = New System.Drawing.Size(240, 38)
        Me.TxtJenisKamar.TabIndex = 18
        '
        'LblHargaKamarPermalam
        '
        Me.LblHargaKamarPermalam.AutoSize = True
        Me.LblHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblHargaKamarPermalam.Location = New System.Drawing.Point(153, 218)
        Me.LblHargaKamarPermalam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHargaKamarPermalam.Name = "LblHargaKamarPermalam"
        Me.LblHargaKamarPermalam.Size = New System.Drawing.Size(232, 28)
        Me.LblHargaKamarPermalam.TabIndex = 17
        Me.LblHargaKamarPermalam.Text = "Harga Kamar Permalam"
        '
        'LblKeteranganJenisKamar
        '
        Me.LblKeteranganJenisKamar.AutoSize = True
        Me.LblKeteranganJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblKeteranganJenisKamar.Location = New System.Drawing.Point(153, 169)
        Me.LblKeteranganJenisKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKeteranganJenisKamar.Name = "LblKeteranganJenisKamar"
        Me.LblKeteranganJenisKamar.Size = New System.Drawing.Size(122, 28)
        Me.LblKeteranganJenisKamar.TabIndex = 16
        Me.LblKeteranganJenisKamar.Text = "Jenis Kamar"
        '
        'LblJenisKamar
        '
        Me.LblJenisKamar.AutoSize = True
        Me.LblJenisKamar.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKamar.Location = New System.Drawing.Point(258, 55)
        Me.LblJenisKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisKamar.Name = "LblJenisKamar"
        Me.LblJenisKamar.Size = New System.Drawing.Size(270, 35)
        Me.LblJenisKamar.TabIndex = 15
        Me.LblJenisKamar.Text = "EDIT JENIS KAMAR"
        '
        'BtnSimpanJenisKamar
        '
        Me.BtnSimpanJenisKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnSimpanJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnSimpanJenisKamar.Location = New System.Drawing.Point(500, 314)
        Me.BtnSimpanJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSimpanJenisKamar.Name = "BtnSimpanJenisKamar"
        Me.BtnSimpanJenisKamar.Size = New System.Drawing.Size(147, 52)
        Me.BtnSimpanJenisKamar.TabIndex = 14
        Me.BtnSimpanJenisKamar.Text = "SIMPAN"
        Me.BtnSimpanJenisKamar.UseVisualStyleBackColor = False
        '
        'EDIT_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtHargaKamarPermalam)
        Me.Controls.Add(Me.TxtJenisKamar)
        Me.Controls.Add(Me.LblHargaKamarPermalam)
        Me.Controls.Add(Me.LblKeteranganJenisKamar)
        Me.Controls.Add(Me.LblJenisKamar)
        Me.Controls.Add(Me.BtnSimpanJenisKamar)
        Me.Name = "EDIT_JENIS_KAMAR"
        Me.Text = "EDIT_JENIS_KAMAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtHargaKamarPermalam As TextBox
    Friend WithEvents TxtJenisKamar As TextBox
    Friend WithEvents LblHargaKamarPermalam As Label
    Friend WithEvents LblKeteranganJenisKamar As Label
    Friend WithEvents LblJenisKamar As Label
    Friend WithEvents BtnSimpanJenisKamar As Button
End Class
