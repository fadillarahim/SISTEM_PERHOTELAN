<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TAMBAH_KAMAR
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblJenisKamarValue = New System.Windows.Forms.Label()
        Me.DataGridViewJenisKamar = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TxtNamaKamar = New System.Windows.Forms.TextBox()
        Me.LblNamaKamar = New System.Windows.Forms.Label()
        Me.LblJenisKamar = New System.Windows.Forms.Label()
        CType(Me.DataGridViewJenisKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(719, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 28)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Jenis Kamar"
        '
        'LblJenisKamarValue
        '
        Me.LblJenisKamarValue.AutoSize = True
        Me.LblJenisKamarValue.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKamarValue.Location = New System.Drawing.Point(303, 251)
        Me.LblJenisKamarValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisKamarValue.Name = "LblJenisKamarValue"
        Me.LblJenisKamarValue.Size = New System.Drawing.Size(122, 28)
        Me.LblJenisKamarValue.TabIndex = 33
        Me.LblJenisKamarValue.Text = "Jenis Kamar"
        '
        'DataGridViewJenisKamar
        '
        Me.DataGridViewJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisKamar.Location = New System.Drawing.Point(579, 246)
        Me.DataGridViewJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewJenisKamar.Name = "DataGridViewJenisKamar"
        Me.DataGridViewJenisKamar.RowHeadersWidth = 51
        Me.DataGridViewJenisKamar.Size = New System.Drawing.Size(455, 185)
        Me.DataGridViewJenisKamar.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 35)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "TAMBAH KAMAR HOTEL"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(87, 477)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(133, 41)
        Me.BtnSimpan.TabIndex = 30
        Me.BtnSimpan.Text = "SIMPAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TxtNamaKamar
        '
        Me.TxtNamaKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaKamar.Location = New System.Drawing.Point(309, 320)
        Me.TxtNamaKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNamaKamar.Name = "TxtNamaKamar"
        Me.TxtNamaKamar.Size = New System.Drawing.Size(184, 33)
        Me.TxtNamaKamar.TabIndex = 29
        '
        'LblNamaKamar
        '
        Me.LblNamaKamar.AutoSize = True
        Me.LblNamaKamar.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKamar.Location = New System.Drawing.Point(82, 320)
        Me.LblNamaKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNamaKamar.Name = "LblNamaKamar"
        Me.LblNamaKamar.Size = New System.Drawing.Size(133, 28)
        Me.LblNamaKamar.TabIndex = 28
        Me.LblNamaKamar.Text = "Nama Kamar"
        '
        'LblJenisKamar
        '
        Me.LblJenisKamar.AutoSize = True
        Me.LblJenisKamar.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKamar.Location = New System.Drawing.Point(82, 251)
        Me.LblJenisKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisKamar.Name = "LblJenisKamar"
        Me.LblJenisKamar.Size = New System.Drawing.Size(122, 28)
        Me.LblJenisKamar.TabIndex = 27
        Me.LblJenisKamar.Text = "Jenis Kamar"
        '
        'TAMBAH_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 630)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblJenisKamarValue)
        Me.Controls.Add(Me.DataGridViewJenisKamar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtNamaKamar)
        Me.Controls.Add(Me.LblNamaKamar)
        Me.Controls.Add(Me.LblJenisKamar)
        Me.Name = "TAMBAH_KAMAR"
        Me.Text = "TAMBAH_KAMAR"
        CType(Me.DataGridViewJenisKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents LblJenisKamarValue As Label
    Friend WithEvents DataGridViewJenisKamar As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TxtNamaKamar As TextBox
    Friend WithEvents LblNamaKamar As Label
    Friend WithEvents LblJenisKamar As Label
End Class
