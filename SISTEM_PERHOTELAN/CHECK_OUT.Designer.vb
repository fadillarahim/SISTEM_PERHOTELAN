<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHECK_OUT
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
        Me.dtpcheckout = New System.Windows.Forms.DateTimePicker()
        Me.BtnCO = New System.Windows.Forms.Button()
        Me.LblNominalByr = New System.Windows.Forms.Label()
        Me.LblTtlByr = New System.Windows.Forms.Label()
        Me.LblLogoCO = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnamatamu = New System.Windows.Forms.Label()
        Me.lblnamakamar = New System.Windows.Forms.Label()
        Me.lblidbookingkamar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltglcheckin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblhargapermalam = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpcheckout
        '
        Me.dtpcheckout.Font = New System.Drawing.Font("Poor Richard", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpcheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcheckout.Location = New System.Drawing.Point(242, 409)
        Me.dtpcheckout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpcheckout.Name = "dtpcheckout"
        Me.dtpcheckout.Size = New System.Drawing.Size(314, 34)
        Me.dtpcheckout.TabIndex = 11
        '
        'BtnCO
        '
        Me.BtnCO.Font = New System.Drawing.Font("Poor Richard", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCO.Location = New System.Drawing.Point(296, 600)
        Me.BtnCO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCO.Name = "BtnCO"
        Me.BtnCO.Size = New System.Drawing.Size(195, 31)
        Me.BtnCO.TabIndex = 10
        Me.BtnCO.Text = "CHECK OUT"
        Me.BtnCO.UseVisualStyleBackColor = True
        '
        'LblNominalByr
        '
        Me.LblNominalByr.AutoSize = True
        Me.LblNominalByr.Font = New System.Drawing.Font("Poor Richard", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNominalByr.Location = New System.Drawing.Point(321, 524)
        Me.LblNominalByr.Name = "LblNominalByr"
        Me.LblNominalByr.Size = New System.Drawing.Size(26, 28)
        Me.LblNominalByr.TabIndex = 9
        Me.LblNominalByr.Text = "0"
        '
        'LblTtlByr
        '
        Me.LblTtlByr.AutoSize = True
        Me.LblTtlByr.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTtlByr.Location = New System.Drawing.Point(343, 463)
        Me.LblTtlByr.Name = "LblTtlByr"
        Me.LblTtlByr.Size = New System.Drawing.Size(98, 23)
        Me.LblTtlByr.TabIndex = 8
        Me.LblTtlByr.Text = "Total Bayar"
        '
        'LblLogoCO
        '
        Me.LblLogoCO.AutoSize = True
        Me.LblLogoCO.Font = New System.Drawing.Font("Poor Richard", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogoCO.Location = New System.Drawing.Point(308, 28)
        Me.LblLogoCO.Name = "LblLogoCO"
        Me.LblLogoCO.Size = New System.Drawing.Size(167, 31)
        Me.LblLogoCO.TabIndex = 7
        Me.LblLogoCO.Text = " CHECK OUT"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(173, 161)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(122, 28)
        Me.lbl1.TabIndex = 12
        Me.lbl1.Text = "Nama Tamu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 28)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama Kamar"
        '
        'lblnamatamu
        '
        Me.lblnamatamu.AutoSize = True
        Me.lblnamatamu.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamatamu.Location = New System.Drawing.Point(484, 161)
        Me.lblnamatamu.Name = "lblnamatamu"
        Me.lblnamatamu.Size = New System.Drawing.Size(122, 28)
        Me.lblnamatamu.TabIndex = 14
        Me.lblnamatamu.Text = "Nama Tamu"
        '
        'lblnamakamar
        '
        Me.lblnamakamar.AutoSize = True
        Me.lblnamakamar.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamakamar.Location = New System.Drawing.Point(484, 218)
        Me.lblnamakamar.Name = "lblnamakamar"
        Me.lblnamakamar.Size = New System.Drawing.Size(133, 28)
        Me.lblnamakamar.TabIndex = 15
        Me.lblnamakamar.Text = "Nama Kamar"
        '
        'lblidbookingkamar
        '
        Me.lblidbookingkamar.AutoSize = True
        Me.lblidbookingkamar.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidbookingkamar.Location = New System.Drawing.Point(484, 101)
        Me.lblidbookingkamar.Name = "lblidbookingkamar"
        Me.lblidbookingkamar.Size = New System.Drawing.Size(122, 28)
        Me.lblidbookingkamar.TabIndex = 17
        Me.lblidbookingkamar.Text = "Nama Tamu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 28)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ID Booking"
        '
        'lbltglcheckin
        '
        Me.lbltglcheckin.AutoSize = True
        Me.lbltglcheckin.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltglcheckin.Location = New System.Drawing.Point(487, 335)
        Me.lbltglcheckin.Name = "lbltglcheckin"
        Me.lbltglcheckin.Size = New System.Drawing.Size(133, 28)
        Me.lbltglcheckin.TabIndex = 19
        Me.lbltglcheckin.Text = "Nama Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 28)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tanggal Check In"
        '
        'lblhargapermalam
        '
        Me.lblhargapermalam.AutoSize = True
        Me.lblhargapermalam.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhargapermalam.Location = New System.Drawing.Point(487, 274)
        Me.lblhargapermalam.Name = "lblhargapermalam"
        Me.lblhargapermalam.Size = New System.Drawing.Size(90, 28)
        Me.lblhargapermalam.TabIndex = 21
        Me.lblhargapermalam.Text = "200000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Harga Kamar Permalam"
        '
        'CHECK_OUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 717)
        Me.Controls.Add(Me.lblhargapermalam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltglcheckin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblidbookingkamar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblnamakamar)
        Me.Controls.Add(Me.lblnamatamu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.dtpcheckout)
        Me.Controls.Add(Me.BtnCO)
        Me.Controls.Add(Me.LblNominalByr)
        Me.Controls.Add(Me.LblTtlByr)
        Me.Controls.Add(Me.LblLogoCO)
        Me.Name = "CHECK_OUT"
        Me.Text = "CHECK_OUT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpcheckout As DateTimePicker
    Friend WithEvents BtnCO As Button
    Friend WithEvents LblNominalByr As Label
    Friend WithEvents LblTtlByr As Label
    Friend WithEvents LblLogoCO As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblnamatamu As Label
    Friend WithEvents lblnamakamar As Label
    Friend WithEvents lblidbookingkamar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltglcheckin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblhargapermalam As Label
    Friend WithEvents Label6 As Label
End Class
