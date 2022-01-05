<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PILIH_TAMU
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
        Me.btnambiltamu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvambiltamu = New System.Windows.Forms.DataGridView()
        CType(Me.dgvambiltamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnambiltamu
        '
        Me.btnambiltamu.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnambiltamu.Location = New System.Drawing.Point(309, 389)
        Me.btnambiltamu.Name = "btnambiltamu"
        Me.btnambiltamu.Size = New System.Drawing.Size(180, 46)
        Me.btnambiltamu.TabIndex = 40
        Me.btnambiltamu.Text = "AMBIL"
        Me.btnambiltamu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 35)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "DAFTAR TAMU HOTEL"
        '
        'dgvambiltamu
        '
        Me.dgvambiltamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvambiltamu.Location = New System.Drawing.Point(89, 92)
        Me.dgvambiltamu.Name = "dgvambiltamu"
        Me.dgvambiltamu.RowHeadersWidth = 51
        Me.dgvambiltamu.RowTemplate.Height = 24
        Me.dgvambiltamu.Size = New System.Drawing.Size(622, 258)
        Me.dgvambiltamu.TabIndex = 38
        '
        'PILIH_TAMU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnambiltamu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvambiltamu)
        Me.Name = "PILIH_TAMU"
        Me.Text = "PILIH_TAMU"
        CType(Me.dgvambiltamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnambiltamu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvambiltamu As DataGridView
End Class
