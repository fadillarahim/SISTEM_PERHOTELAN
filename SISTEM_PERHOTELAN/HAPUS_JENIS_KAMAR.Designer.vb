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
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.LblJenisKamarHapus = New System.Windows.Forms.Label()
        Me.BtnHapusJenisKamar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Poor Richard", 13.0!)
        Me.LblJudul.Location = New System.Drawing.Point(29, 35)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(311, 21)
        Me.LblJudul.TabIndex = 0
        Me.LblJudul.Text = "Apakah Anda Ingin menghapus jenis kamar?"
        '
        'LblJenisKamarHapus
        '
        Me.LblJenisKamarHapus.AutoSize = True
        Me.LblJenisKamarHapus.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblJenisKamarHapus.Location = New System.Drawing.Point(134, 80)
        Me.LblJenisKamarHapus.Name = "LblJenisKamarHapus"
        Me.LblJenisKamarHapus.Size = New System.Drawing.Size(133, 28)
        Me.LblJenisKamarHapus.TabIndex = 1
        Me.LblJenisKamarHapus.Text = "Jenis Kamar"
        '
        'BtnHapusJenisKamar
        '
        Me.BtnHapusJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnHapusJenisKamar.Location = New System.Drawing.Point(129, 128)
        Me.BtnHapusJenisKamar.Name = "BtnHapusJenisKamar"
        Me.BtnHapusJenisKamar.Size = New System.Drawing.Size(92, 44)
        Me.BtnHapusJenisKamar.TabIndex = 2
        Me.BtnHapusJenisKamar.Text = "HAPUS"
        Me.BtnHapusJenisKamar.UseVisualStyleBackColor = True
        '
        'HAPUS_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 219)
        Me.Controls.Add(Me.BtnHapusJenisKamar)
        Me.Controls.Add(Me.LblJenisKamarHapus)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "HAPUS_JENIS_KAMAR"
        Me.Text = "Hapus Jenis Kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents LblJenisKamarHapus As Label
    Friend WithEvents BtnHapusJenisKamar As Button
End Class
