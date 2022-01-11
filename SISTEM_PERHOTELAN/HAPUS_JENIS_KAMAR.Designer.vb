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
        Me.SuspendLayout()
        '
        'BtnHapusJenisKamar
        '
        Me.BtnHapusJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnHapusJenisKamar.Location = New System.Drawing.Point(331, 302)
        Me.BtnHapusJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapusJenisKamar.Name = "BtnHapusJenisKamar"
        Me.BtnHapusJenisKamar.Size = New System.Drawing.Size(123, 54)
        Me.BtnHapusJenisKamar.TabIndex = 5
        Me.BtnHapusJenisKamar.Text = "HAPUS"
        Me.BtnHapusJenisKamar.UseVisualStyleBackColor = True
        '
        'LblJenisKamarHapus
        '
        Me.LblJenisKamarHapus.AutoSize = True
        Me.LblJenisKamarHapus.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblJenisKamarHapus.Location = New System.Drawing.Point(323, 190)
        Me.LblJenisKamarHapus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisKamarHapus.Name = "LblJenisKamarHapus"
        Me.LblJenisKamarHapus.Size = New System.Drawing.Size(214, 47)
        Me.LblJenisKamarHapus.TabIndex = 4
        Me.LblJenisKamarHapus.Text = "Jenis Kamar"
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
        'HAPUS_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
