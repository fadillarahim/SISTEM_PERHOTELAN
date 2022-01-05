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
        Me.LblJenisKamar = New System.Windows.Forms.Label()
        Me.BtnSimpanJenisKamar = New System.Windows.Forms.Button()
        Me.LblKeteranganJenisKamar = New System.Windows.Forms.Label()
        Me.LblHargaKamarPermalam = New System.Windows.Forms.Label()
        Me.TxtJenisKamar = New System.Windows.Forms.TextBox()
        Me.TxtHargaKamarPermalam = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblJenisKamar
        '
        Me.LblJenisKamar.AutoSize = True
        Me.LblJenisKamar.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKamar.Location = New System.Drawing.Point(117, 34)
        Me.LblJenisKamar.Name = "LblJenisKamar"
        Me.LblJenisKamar.Size = New System.Drawing.Size(179, 28)
        Me.LblJenisKamar.TabIndex = 9
        Me.LblJenisKamar.Text = "Edit Jenis Kamar"
        '
        'BtnSimpanJenisKamar
        '
        Me.BtnSimpanJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnSimpanJenisKamar.Location = New System.Drawing.Point(306, 221)
        Me.BtnSimpanJenisKamar.Name = "BtnSimpanJenisKamar"
        Me.BtnSimpanJenisKamar.Size = New System.Drawing.Size(110, 42)
        Me.BtnSimpanJenisKamar.TabIndex = 7
        Me.BtnSimpanJenisKamar.Text = "SIMPAN"
        Me.BtnSimpanJenisKamar.UseVisualStyleBackColor = True
        '
        'LblKeteranganJenisKamar
        '
        Me.LblKeteranganJenisKamar.AutoSize = True
        Me.LblKeteranganJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblKeteranganJenisKamar.Location = New System.Drawing.Point(46, 103)
        Me.LblKeteranganJenisKamar.Name = "LblKeteranganJenisKamar"
        Me.LblKeteranganJenisKamar.Size = New System.Drawing.Size(98, 22)
        Me.LblKeteranganJenisKamar.TabIndex = 10
        Me.LblKeteranganJenisKamar.Text = "Jenis Kamar"
        '
        'LblHargaKamarPermalam
        '
        Me.LblHargaKamarPermalam.AutoSize = True
        Me.LblHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.LblHargaKamarPermalam.Location = New System.Drawing.Point(46, 143)
        Me.LblHargaKamarPermalam.Name = "LblHargaKamarPermalam"
        Me.LblHargaKamarPermalam.Size = New System.Drawing.Size(183, 22)
        Me.LblHargaKamarPermalam.TabIndex = 11
        Me.LblHargaKamarPermalam.Text = "Harga Kamar Permalam"
        '
        'TxtJenisKamar
        '
        Me.TxtJenisKamar.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtJenisKamar.Location = New System.Drawing.Point(235, 103)
        Me.TxtJenisKamar.Name = "TxtJenisKamar"
        Me.TxtJenisKamar.Size = New System.Drawing.Size(181, 32)
        Me.TxtJenisKamar.TabIndex = 12
        '
        'TxtHargaKamarPermalam
        '
        Me.TxtHargaKamarPermalam.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.TxtHargaKamarPermalam.Location = New System.Drawing.Point(235, 146)
        Me.TxtHargaKamarPermalam.Name = "TxtHargaKamarPermalam"
        Me.TxtHargaKamarPermalam.Size = New System.Drawing.Size(181, 32)
        Me.TxtHargaKamarPermalam.TabIndex = 13
        '
        'EDIT_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 275)
        Me.Controls.Add(Me.TxtHargaKamarPermalam)
        Me.Controls.Add(Me.TxtJenisKamar)
        Me.Controls.Add(Me.LblHargaKamarPermalam)
        Me.Controls.Add(Me.LblKeteranganJenisKamar)
        Me.Controls.Add(Me.LblJenisKamar)
        Me.Controls.Add(Me.BtnSimpanJenisKamar)
        Me.Name = "EDIT_JENIS_KAMAR"
        Me.Text = "Edit Jenis Kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJenisKamar As Label
    Friend WithEvents BtnSimpanJenisKamar As Button
    Friend WithEvents LblKeteranganJenisKamar As Label
    Friend WithEvents LblHargaKamarPermalam As Label
    Friend WithEvents TxtJenisKamar As TextBox
    Friend WithEvents TxtHargaKamarPermalam As TextBox
End Class
