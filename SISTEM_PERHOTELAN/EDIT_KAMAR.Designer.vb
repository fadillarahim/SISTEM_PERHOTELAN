<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDIT_KAMAR
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
        Me.DataGridViewJenisKamar = New System.Windows.Forms.DataGridView()
        Me.LabelJenisKamarValue = New System.Windows.Forms.Label()
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
        Me.Label4.Location = New System.Drawing.Point(721, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 28)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Jenis Kamar"
        '
        'DataGridViewJenisKamar
        '
        Me.DataGridViewJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisKamar.Location = New System.Drawing.Point(581, 238)
        Me.DataGridViewJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewJenisKamar.Name = "DataGridViewJenisKamar"
        Me.DataGridViewJenisKamar.RowHeadersWidth = 51
        Me.DataGridViewJenisKamar.Size = New System.Drawing.Size(455, 185)
        Me.DataGridViewJenisKamar.TabIndex = 40
        '
        'LabelJenisKamarValue
        '
        Me.LabelJenisKamarValue.AutoSize = True
        Me.LabelJenisKamarValue.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJenisKamarValue.Location = New System.Drawing.Point(277, 238)
        Me.LabelJenisKamarValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJenisKamarValue.Name = "LabelJenisKamarValue"
        Me.LabelJenisKamarValue.Size = New System.Drawing.Size(122, 28)
        Me.LabelJenisKamarValue.TabIndex = 39
        Me.LabelJenisKamarValue.Text = "Jenis Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 35)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "EDIT KAMAR HOTEL"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(74, 463)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(125, 41)
        Me.BtnSimpan.TabIndex = 37
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TxtNamaKamar
        '
        Me.TxtNamaKamar.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaKamar.Location = New System.Drawing.Point(282, 308)
        Me.TxtNamaKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNamaKamar.Name = "TxtNamaKamar"
        Me.TxtNamaKamar.Size = New System.Drawing.Size(184, 34)
        Me.TxtNamaKamar.TabIndex = 36
        '
        'LblNamaKamar
        '
        Me.LblNamaKamar.AutoSize = True
        Me.LblNamaKamar.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKamar.Location = New System.Drawing.Point(69, 316)
        Me.LblNamaKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNamaKamar.Name = "LblNamaKamar"
        Me.LblNamaKamar.Size = New System.Drawing.Size(133, 28)
        Me.LblNamaKamar.TabIndex = 35
        Me.LblNamaKamar.Text = "Nama Kamar"
        '
        'LblJenisKamar
        '
        Me.LblJenisKamar.AutoSize = True
        Me.LblJenisKamar.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKamar.Location = New System.Drawing.Point(69, 238)
        Me.LblJenisKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisKamar.Name = "LblJenisKamar"
        Me.LblJenisKamar.Size = New System.Drawing.Size(122, 28)
        Me.LblJenisKamar.TabIndex = 34
        Me.LblJenisKamar.Text = "Jenis Kamar"
        '
        'EDIT_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 601)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewJenisKamar)
        Me.Controls.Add(Me.LabelJenisKamarValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtNamaKamar)
        Me.Controls.Add(Me.LblNamaKamar)
        Me.Controls.Add(Me.LblJenisKamar)
        Me.Name = "EDIT_KAMAR"
        Me.Text = "EDIT_KAMAR"
        CType(Me.DataGridViewJenisKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewJenisKamar As DataGridView
    Friend WithEvents LabelJenisKamarValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TxtNamaKamar As TextBox
    Friend WithEvents LblNamaKamar As Label
    Friend WithEvents LblJenisKamar As Label
End Class
