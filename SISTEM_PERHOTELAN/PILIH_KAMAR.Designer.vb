<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PILIH_KAMAR
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
        Me.DataGridViewPilihKamar = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnambil = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPilihKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 28)
        Me.Label1.TabIndex = 5
        '
        'DataGridViewPilihKamar
        '
        Me.DataGridViewPilihKamar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.DataGridViewPilihKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPilihKamar.Location = New System.Drawing.Point(67, 121)
        Me.DataGridViewPilihKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewPilihKamar.Name = "DataGridViewPilihKamar"
        Me.DataGridViewPilihKamar.RowHeadersWidth = 51
        Me.DataGridViewPilihKamar.Size = New System.Drawing.Size(660, 217)
        Me.DataGridViewPilihKamar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 35)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DAFTAR KAMAR HOTEL"
        '
        'btnambil
        '
        Me.btnambil.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnambil.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnambil.Location = New System.Drawing.Point(314, 396)
        Me.btnambil.Name = "btnambil"
        Me.btnambil.Size = New System.Drawing.Size(180, 46)
        Me.btnambil.TabIndex = 38
        Me.btnambil.Text = "AMBIL"
        Me.btnambil.UseVisualStyleBackColor = False
        '
        'PILIH_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 497)
        Me.Controls.Add(Me.btnambil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewPilihKamar)
        Me.Name = "PILIH_KAMAR"
        Me.Text = "PILIH_KAMAR"
        CType(Me.DataGridViewPilihKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewPilihKamar As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnambil As Button
End Class
