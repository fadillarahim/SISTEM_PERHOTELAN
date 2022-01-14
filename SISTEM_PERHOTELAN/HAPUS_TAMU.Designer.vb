<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HAPUS_TAMU
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
        Me.lblnamatamu = New System.Windows.Forms.Label()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.btntidak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnHapus.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnHapus.Location = New System.Drawing.Point(526, 304)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(123, 54)
        Me.BtnHapus.TabIndex = 8
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'lblnamatamu
        '
        Me.lblnamatamu.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamatamu.Location = New System.Drawing.Point(203, 184)
        Me.lblnamatamu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnamatamu.Name = "lblnamatamu"
        Me.lblnamatamu.Size = New System.Drawing.Size(427, 51)
        Me.lblnamatamu.TabIndex = 7
        Me.lblnamatamu.Text = "Nama Tamu"
        Me.lblnamatamu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJudul.Location = New System.Drawing.Point(128, 85)
        Me.LblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(554, 35)
        Me.LblJudul.TabIndex = 6
        Me.LblJudul.Text = "Apakah Anda Ingin Menghapus Tamu Berikut?"
        '
        'btntidak
        '
        Me.btntidak.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btntidak.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.btntidak.Location = New System.Drawing.Point(165, 304)
        Me.btntidak.Margin = New System.Windows.Forms.Padding(4)
        Me.btntidak.Name = "btntidak"
        Me.btntidak.Size = New System.Drawing.Size(123, 54)
        Me.btntidak.TabIndex = 9
        Me.btntidak.Text = "TIDAK"
        Me.btntidak.UseVisualStyleBackColor = False
        '
        'HAPUS_TAMU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btntidak)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.lblnamatamu)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "HAPUS_TAMU"
        Me.Text = "HAPUS_TAMU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents lblnamatamu As Label
    Friend WithEvents LblJudul As Label
    Friend WithEvents btntidak As Button
End Class
