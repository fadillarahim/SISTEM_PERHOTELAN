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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblNamaKamar = New System.Windows.Forms.Label()
        Me.LblPertanyaan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 35)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "HAPUS KAMAR"
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(348, 356)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(121, 50)
        Me.BtnHapus.TabIndex = 6
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblNamaKamar
        '
        Me.LblNamaKamar.AutoSize = True
        Me.LblNamaKamar.Font = New System.Drawing.Font("Poor Richard", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKamar.Location = New System.Drawing.Point(314, 247)
        Me.LblNamaKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNamaKamar.Name = "LblNamaKamar"
        Me.LblNamaKamar.Size = New System.Drawing.Size(200, 38)
        Me.LblNamaKamar.TabIndex = 5
        Me.LblNamaKamar.Text = "Nama Kamar"
        '
        'LblPertanyaan
        '
        Me.LblPertanyaan.AutoSize = True
        Me.LblPertanyaan.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPertanyaan.Location = New System.Drawing.Point(210, 156)
        Me.LblPertanyaan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPertanyaan.Name = "LblPertanyaan"
        Me.LblPertanyaan.Size = New System.Drawing.Size(381, 28)
        Me.LblPertanyaan.TabIndex = 4
        Me.LblPertanyaan.Text = "Apakah Anda Ingin Menghapus Kamar ?"
        '
        'HAPUS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblNamaKamar)
        Me.Controls.Add(Me.LblPertanyaan)
        Me.Name = "HAPUS_KAMAR"
        Me.Text = "HAPUS_KAMAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblNamaKamar As Label
    Friend WithEvents LblPertanyaan As Label
End Class
