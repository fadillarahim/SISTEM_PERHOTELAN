<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PILIH_JENIS_KAMAR
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
        Me.DataGridViewPilihJenisKamar = New System.Windows.Forms.DataGridView()
        Me.BtnAmbilJenisKamar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewPilihJenisKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPilihJenisKamar
        '
        Me.DataGridViewPilihJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPilihJenisKamar.Location = New System.Drawing.Point(119, 88)
        Me.DataGridViewPilihJenisKamar.Name = "DataGridViewPilihJenisKamar"
        Me.DataGridViewPilihJenisKamar.Size = New System.Drawing.Size(323, 205)
        Me.DataGridViewPilihJenisKamar.TabIndex = 0
        '
        'BtnAmbilJenisKamar
        '
        Me.BtnAmbilJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnAmbilJenisKamar.Location = New System.Drawing.Point(240, 316)
        Me.BtnAmbilJenisKamar.Name = "BtnAmbilJenisKamar"
        Me.BtnAmbilJenisKamar.Size = New System.Drawing.Size(100, 36)
        Me.BtnAmbilJenisKamar.TabIndex = 1
        Me.BtnAmbilJenisKamar.Text = "AMBIL"
        Me.BtnAmbilJenisKamar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(175, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Daftar Jenis Kamar"
        '
        'PILIH_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 377)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAmbilJenisKamar)
        Me.Controls.Add(Me.DataGridViewPilihJenisKamar)
        Me.Name = "PILIH_JENIS_KAMAR"
        Me.Text = "PILIH_JENIS_KAMAR"
        CType(Me.DataGridViewPilihJenisKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewPilihJenisKamar As DataGridView
    Friend WithEvents BtnAmbilJenisKamar As Button
    Friend WithEvents Label1 As Label
End Class
