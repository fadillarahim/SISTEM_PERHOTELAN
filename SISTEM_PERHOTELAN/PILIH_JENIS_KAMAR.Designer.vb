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
        Me.btnambiljeniskamar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvambiljeniskamar = New System.Windows.Forms.DataGridView()
        CType(Me.dgvambiljeniskamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnambiljeniskamar
        '
        Me.btnambiljeniskamar.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnambiljeniskamar.Location = New System.Drawing.Point(309, 389)
        Me.btnambiljeniskamar.Name = "btnambiljeniskamar"
        Me.btnambiljeniskamar.Size = New System.Drawing.Size(180, 46)
        Me.btnambiljeniskamar.TabIndex = 40
        Me.btnambiljeniskamar.Text = "AMBIL"
        Me.btnambiljeniskamar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 35)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "DAFTAR JENIS KAMAR"
        '
        'dgvambiljeniskamar
        '
        Me.dgvambiljeniskamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvambiljeniskamar.Location = New System.Drawing.Point(176, 96)
        Me.dgvambiljeniskamar.Name = "dgvambiljeniskamar"
        Me.dgvambiljeniskamar.RowHeadersWidth = 51
        Me.dgvambiljeniskamar.RowTemplate.Height = 24
        Me.dgvambiljeniskamar.Size = New System.Drawing.Size(456, 258)
        Me.dgvambiljeniskamar.TabIndex = 38
        '
        'PILIH_JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnambiljeniskamar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvambiljeniskamar)
        Me.Name = "PILIH_JENIS_KAMAR"
        Me.Text = "PILIH_JENIS_KAMAR"
        CType(Me.dgvambiljeniskamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnambiljeniskamar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvambiljeniskamar As DataGridView
End Class
