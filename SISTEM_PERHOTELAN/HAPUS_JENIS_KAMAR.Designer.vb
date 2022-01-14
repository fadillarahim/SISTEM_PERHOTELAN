<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HAPUS_JENIS_KAMAR
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
        Me.BtnHapusJenisKamar = New System.Windows.Forms.Button()
        Me.LblJenisKamarHapus = New System.Windows.Forms.Label()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.btntidak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnHapusJenisKamar
        '
        Me.BtnHapusJenisKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnHapusJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnHapusJenisKamar.Location = New System.Drawing.Point(494, 327)
        Me.BtnHapusJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapusJenisKamar.Name = "BtnHapusJenisKamar"
        Me.BtnHapusJenisKamar.Size = New System.Drawing.Size(123, 54)
        Me.BtnHapusJenisKamar.TabIndex = 5
        Me.BtnHapusJenisKamar.Text = "HAPUS"
        Me.BtnHapusJenisKamar.UseVisualStyleBackColor = False
        '
        'LblJenisKamarHapus
        '
        Me.LblJenisKamarHapus.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblJenisKamarHapus.Location = New System.Drawing.Point(230, 193)
        Me.LblJenisKamarHapus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisKamarHapus.Name = "LblJenisKamarHapus"
        Me.LblJenisKamarHapus.Size = New System.Drawing.Size(322, 66)
        Me.LblJenisKamarHapus.TabIndex = 4
        Me.LblJenisKamarHapus.Text = "Jenis Kamar"
        Me.LblJenisKamarHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Poor Richard", 18.0!)
        Me.LblJudul.Location = New System.Drawing.Point(142, 83)
        Me.LblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(524, 35)
        Me.LblJudul.TabIndex = 3
        Me.LblJudul.Text = "Apakah Anda Ingin menghapus jenis kamar?"
        '
        'btntidak
        '
        Me.btntidak.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btntidak.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.btntidak.Location = New System.Drawing.Point(178, 327)
        Me.btntidak.Margin = New System.Windows.Forms.Padding(4)
        Me.btntidak.Name = "btntidak"
        Me.btntidak.Size = New System.Drawing.Size(123, 54)
        Me.btntidak.TabIndex = 6
        Me.btntidak.Text = "TIDAK"
        Me.btntidak.UseVisualStyleBackColor = False
        '
        'HAPUS_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btntidak)
        Me.Controls.Add(Me.BtnHapusJenisKamar)
        Me.Controls.Add(Me.LblJenisKamarHapus)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "HAPUS_JENIS_KAMAR"
        Me.Text = "HAPUS_JENIS_KAMAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapusJenisKamar As Button
    Friend WithEvents LblJenisKamarHapus As Label
    Friend WithEvents LblJudul As Label
    Friend WithEvents btntidak As Button
End Class
