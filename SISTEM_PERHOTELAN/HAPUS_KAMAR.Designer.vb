<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HAPUS_KAMAR
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblNamaKamar = New System.Windows.Forms.Label()
        Me.btntidak = New System.Windows.Forms.Button()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnHapus.Font = New System.Drawing.Font("Poor Richard", 14.0!)
        Me.BtnHapus.Location = New System.Drawing.Point(500, 350)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(121, 50)
        Me.BtnHapus.TabIndex = 6
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'LblNamaKamar
        '
        Me.LblNamaKamar.Font = New System.Drawing.Font("Poor Richard", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKamar.Location = New System.Drawing.Point(201, 201)
        Me.LblNamaKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNamaKamar.Name = "LblNamaKamar"
        Me.LblNamaKamar.Size = New System.Drawing.Size(396, 56)
        Me.LblNamaKamar.TabIndex = 5
        Me.LblNamaKamar.Text = "Nama Kamar"
        Me.LblNamaKamar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btntidak
        '
        Me.btntidak.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btntidak.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.btntidak.Location = New System.Drawing.Point(182, 346)
        Me.btntidak.Margin = New System.Windows.Forms.Padding(4)
        Me.btntidak.Name = "btntidak"
        Me.btntidak.Size = New System.Drawing.Size(123, 54)
        Me.btntidak.TabIndex = 10
        Me.btntidak.Text = "TIDAK"
        Me.btntidak.UseVisualStyleBackColor = False
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJudul.Location = New System.Drawing.Point(135, 96)
        Me.LblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(567, 35)
        Me.LblJudul.TabIndex = 11
        Me.LblJudul.Text = "Apakah Anda Ingin Menghapus Kamar Berikut?"
        '
        'HAPUS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblJudul)
        Me.Controls.Add(Me.btntidak)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblNamaKamar)
        Me.Name = "HAPUS_KAMAR"
        Me.Text = "HAPUS_KAMAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblNamaKamar As Label
    Friend WithEvents btntidak As Button
    Friend WithEvents LblJudul As Label
End Class
