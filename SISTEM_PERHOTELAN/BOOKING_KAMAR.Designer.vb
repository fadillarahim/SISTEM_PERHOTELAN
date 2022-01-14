<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOKING_KAMAR
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
        Me.DataGridViewBooking = New System.Windows.Forms.DataGridView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BOOKINGKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TAMUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JENISKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnHapus.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(728, 585)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(157, 48)
        Me.BtnHapus.TabIndex = 7
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'DataGridViewBooking
        '
        Me.DataGridViewBooking.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.DataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBooking.Location = New System.Drawing.Point(34, 212)
        Me.DataGridViewBooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewBooking.Name = "DataGridViewBooking"
        Me.DataGridViewBooking.RowHeadersWidth = 62
        Me.DataGridViewBooking.RowTemplate.Height = 28
        Me.DataGridViewBooking.Size = New System.Drawing.Size(851, 281)
        Me.DataGridViewBooking.TabIndex = 6
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.MenuStrip.Font = New System.Drawing.Font("Poor Richard", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKINGKAMARToolStripMenuItem, Me.TAMUToolStripMenuItem, Me.JENISKAMARToolStripMenuItem, Me.KAMARToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(916, 39)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'BOOKINGKAMARToolStripMenuItem
        '
        Me.BOOKINGKAMARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHECKINToolStripMenuItem, Me.CHECKOUTToolStripMenuItem})
        Me.BOOKINGKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOOKINGKAMARToolStripMenuItem.Name = "BOOKINGKAMARToolStripMenuItem"
        Me.BOOKINGKAMARToolStripMenuItem.Size = New System.Drawing.Size(242, 35)
        Me.BOOKINGKAMARToolStripMenuItem.Text = "BOOKING KAMAR"
        '
        'CHECKINToolStripMenuItem
        '
        Me.CHECKINToolStripMenuItem.Name = "CHECKINToolStripMenuItem"
        Me.CHECKINToolStripMenuItem.Size = New System.Drawing.Size(248, 36)
        Me.CHECKINToolStripMenuItem.Text = "CHECK-IN"
        '
        'CHECKOUTToolStripMenuItem
        '
        Me.CHECKOUTToolStripMenuItem.Name = "CHECKOUTToolStripMenuItem"
        Me.CHECKOUTToolStripMenuItem.Size = New System.Drawing.Size(248, 36)
        Me.CHECKOUTToolStripMenuItem.Text = "CHECK-OUT"
        '
        'TAMUToolStripMenuItem
        '
        Me.TAMUToolStripMenuItem.Name = "TAMUToolStripMenuItem"
        Me.TAMUToolStripMenuItem.Size = New System.Drawing.Size(99, 35)
        Me.TAMUToolStripMenuItem.Text = "TAMU"
        '
        'JENISKAMARToolStripMenuItem
        '
        Me.JENISKAMARToolStripMenuItem.Name = "JENISKAMARToolStripMenuItem"
        Me.JENISKAMARToolStripMenuItem.Size = New System.Drawing.Size(187, 35)
        Me.JENISKAMARToolStripMenuItem.Text = "JENIS KAMAR"
        '
        'KAMARToolStripMenuItem
        '
        Me.KAMARToolStripMenuItem.Name = "KAMARToolStripMenuItem"
        Me.KAMARToolStripMenuItem.Size = New System.Drawing.Size(121, 35)
        Me.KAMARToolStripMenuItem.Text = "KAMAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DAFTAR BOOKING KAMAR HOTEL"
        '
        'BOOKING_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.DataGridViewBooking)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "BOOKING_KAMAR"
        Me.Text = "BOOKING_KAMAR"
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHapus As Button
    Friend WithEvents DataGridViewBooking As DataGridView
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents BOOKINGKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TAMUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JENISKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
