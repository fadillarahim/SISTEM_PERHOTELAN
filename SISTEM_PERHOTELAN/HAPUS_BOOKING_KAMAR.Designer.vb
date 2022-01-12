<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HAPUS_BOOKING_KAMAR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.lblnamatamu = New System.Windows.Forms.Label()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblidbooking = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnHapus.Location = New System.Drawing.Point(320, 343)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(123, 54)
        Me.BtnHapus.TabIndex = 11
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'lblnamatamu
        '
        Me.lblnamatamu.AutoSize = True
        Me.lblnamatamu.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamatamu.Location = New System.Drawing.Point(405, 243)
        Me.lblnamatamu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnamatamu.Name = "lblnamatamu"
        Me.lblnamatamu.Size = New System.Drawing.Size(209, 47)
        Me.lblnamatamu.TabIndex = 10
        Me.lblnamatamu.Text = "Nama Tamu"
        Me.lblnamatamu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJudul.Location = New System.Drawing.Point(84, 89)
        Me.LblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(616, 35)
        Me.LblJudul.TabIndex = 9
        Me.LblJudul.Text = "Apakah Anda Ingin Menghapus Data Tamu Berikut?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 149)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 47)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblidbooking
        '
        Me.lblidbooking.AutoSize = True
        Me.lblidbooking.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidbooking.Location = New System.Drawing.Point(405, 149)
        Me.lblidbooking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidbooking.Name = "lblidbooking"
        Me.lblidbooking.Size = New System.Drawing.Size(202, 47)
        Me.lblidbooking.TabIndex = 13
        Me.lblidbooking.Text = "ID Booking"
        Me.lblidbooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 243)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 47)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nama Tamu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HAPUS_BOOKING_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblidbooking)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.lblnamatamu)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "HAPUS_BOOKING_KAMAR"
        Me.Text = "HAPUS_BOOKING_KAMAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents lblnamatamu As Label
    Friend WithEvents LblJudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblidbooking As Label
    Friend WithEvents Label2 As Label
End Class
