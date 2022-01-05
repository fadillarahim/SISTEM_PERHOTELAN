<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EDIT_TAMU
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
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbjeniskelamintamuedit = New System.Windows.Forms.ComboBox()
        Me.rtbalamattamuedit = New System.Windows.Forms.RichTextBox()
        Me.txtnamatamuedit = New System.Windows.Forms.TextBox()
        Me.txtniktamuedit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(286, 536)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(180, 46)
        Me.btnedit.TabIndex = 57
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, -56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 35)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "TAMBAH TAMU HOTEL"
        '
        'cbjeniskelamintamuedit
        '
        Me.cbjeniskelamintamuedit.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.cbjeniskelamintamuedit.FormattingEnabled = True
        Me.cbjeniskelamintamuedit.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbjeniskelamintamuedit.Location = New System.Drawing.Point(299, 425)
        Me.cbjeniskelamintamuedit.Name = "cbjeniskelamintamuedit"
        Me.cbjeniskelamintamuedit.Size = New System.Drawing.Size(357, 39)
        Me.cbjeniskelamintamuedit.TabIndex = 55
        '
        'rtbalamattamuedit
        '
        Me.rtbalamattamuedit.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbalamattamuedit.Location = New System.Drawing.Point(299, 251)
        Me.rtbalamattamuedit.Name = "rtbalamattamuedit"
        Me.rtbalamattamuedit.Size = New System.Drawing.Size(362, 146)
        Me.rtbalamattamuedit.TabIndex = 54
        Me.rtbalamattamuedit.Text = ""
        '
        'txtnamatamuedit
        '
        Me.txtnamatamuedit.Font = New System.Drawing.Font("Poor Richard", 16.2!)
        Me.txtnamatamuedit.Location = New System.Drawing.Point(299, 185)
        Me.txtnamatamuedit.Name = "txtnamatamuedit"
        Me.txtnamatamuedit.Size = New System.Drawing.Size(363, 38)
        Me.txtnamatamuedit.TabIndex = 53
        '
        'txtniktamuedit
        '
        Me.txtniktamuedit.Font = New System.Drawing.Font("Poor Richard", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtniktamuedit.Location = New System.Drawing.Point(299, 128)
        Me.txtniktamuedit.Name = "txtniktamuedit"
        Me.txtniktamuedit.Size = New System.Drawing.Size(363, 38)
        Me.txtniktamuedit.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 28)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 28)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 28)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Nama Tamu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 28)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "NIK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(271, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 35)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "EDIT TAMU HOTEL"
        '
        'EDIT_TAMU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbjeniskelamintamuedit)
        Me.Controls.Add(Me.rtbalamattamuedit)
        Me.Controls.Add(Me.txtnamatamuedit)
        Me.Controls.Add(Me.txtniktamuedit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "EDIT_TAMU"
        Me.Text = "EDIT_TAMU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnedit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbjeniskelamintamuedit As ComboBox
    Friend WithEvents rtbalamattamuedit As RichTextBox
    Friend WithEvents txtnamatamuedit As TextBox
    Friend WithEvents txtniktamuedit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
