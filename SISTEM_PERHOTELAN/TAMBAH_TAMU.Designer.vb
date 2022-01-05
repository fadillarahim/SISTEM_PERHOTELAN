<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TAMBAH_TAMU
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
        Me.cbjeniskelamintamu = New System.Windows.Forms.ComboBox()
        Me.rtbalamattamu = New System.Windows.Forms.RichTextBox()
        Me.txtnamatamu = New System.Windows.Forms.TextBox()
        Me.txtniktamu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbjeniskelamintamu
        '
        Me.cbjeniskelamintamu.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.cbjeniskelamintamu.FormattingEnabled = True
        Me.cbjeniskelamintamu.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbjeniskelamintamu.Location = New System.Drawing.Point(313, 477)
        Me.cbjeniskelamintamu.Name = "cbjeniskelamintamu"
        Me.cbjeniskelamintamu.Size = New System.Drawing.Size(357, 39)
        Me.cbjeniskelamintamu.TabIndex = 45
        '
        'rtbalamattamu
        '
        Me.rtbalamattamu.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbalamattamu.Location = New System.Drawing.Point(313, 303)
        Me.rtbalamattamu.Name = "rtbalamattamu"
        Me.rtbalamattamu.Size = New System.Drawing.Size(362, 146)
        Me.rtbalamattamu.TabIndex = 44
        Me.rtbalamattamu.Text = ""
        '
        'txtnamatamu
        '
        Me.txtnamatamu.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.txtnamatamu.Location = New System.Drawing.Point(313, 237)
        Me.txtnamatamu.Name = "txtnamatamu"
        Me.txtnamatamu.Size = New System.Drawing.Size(363, 38)
        Me.txtnamatamu.TabIndex = 42
        '
        'txtniktamu
        '
        Me.txtniktamu.Font = New System.Drawing.Font("Poor Richard", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtniktamu.Location = New System.Drawing.Point(313, 180)
        Me.txtniktamu.Name = "txtniktamu"
        Me.txtniktamu.Size = New System.Drawing.Size(363, 38)
        Me.txtniktamu.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(150, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 28)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 28)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 28)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nama Tamu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 28)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 35)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "TAMBAH TAMU HOTEL"
        '
        'btntambah
        '
        Me.btntambah.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Location = New System.Drawing.Point(301, 578)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(180, 46)
        Me.btntambah.TabIndex = 47
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'TAMBAH_TAMU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 659)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbjeniskelamintamu)
        Me.Controls.Add(Me.rtbalamattamu)
        Me.Controls.Add(Me.txtnamatamu)
        Me.Controls.Add(Me.txtniktamu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "TAMBAH_TAMU"
        Me.Text = "TAMBAH_TAMU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbjeniskelamintamu As ComboBox
    Friend WithEvents rtbalamattamu As RichTextBox
    Friend WithEvents txtnamatamu As TextBox
    Friend WithEvents txtniktamu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btntambah As Button
End Class
