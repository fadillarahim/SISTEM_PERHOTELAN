<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DAFTAR_TAMU
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntambahtamu = New System.Windows.Forms.Button()
        Me.btnedittamu = New System.Windows.Forms.Button()
        Me.btnhapustamu = New System.Windows.Forms.Button()
        Me.dgvtamu = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BOOKINGKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TAMUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JENISKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvtamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DAFTAR TAMU HOTEL"
        '
        'btntambahtamu
        '
        Me.btntambahtamu.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btntambahtamu.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambahtamu.Location = New System.Drawing.Point(125, 638)
        Me.btntambahtamu.Name = "btntambahtamu"
        Me.btntambahtamu.Size = New System.Drawing.Size(180, 46)
        Me.btntambahtamu.TabIndex = 36
        Me.btntambahtamu.Text = "TAMBAH"
        Me.btntambahtamu.UseVisualStyleBackColor = False
        '
        'btnedittamu
        '
        Me.btnedittamu.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnedittamu.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedittamu.Location = New System.Drawing.Point(363, 638)
        Me.btnedittamu.Name = "btnedittamu"
        Me.btnedittamu.Size = New System.Drawing.Size(180, 46)
        Me.btnedittamu.TabIndex = 37
        Me.btnedittamu.Text = "EDIT"
        Me.btnedittamu.UseVisualStyleBackColor = False
        '
        'btnhapustamu
        '
        Me.btnhapustamu.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnhapustamu.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapustamu.Location = New System.Drawing.Point(604, 638)
        Me.btnhapustamu.Name = "btnhapustamu"
        Me.btnhapustamu.Size = New System.Drawing.Size(180, 46)
        Me.btnhapustamu.TabIndex = 38
        Me.btnhapustamu.Text = "HAPUS"
        Me.btnhapustamu.UseVisualStyleBackColor = False
        '
        'dgvtamu
        '
        Me.dgvtamu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgvtamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtamu.Location = New System.Drawing.Point(139, 146)
        Me.dgvtamu.Name = "dgvtamu"
        Me.dgvtamu.RowHeadersWidth = 51
        Me.dgvtamu.RowTemplate.Height = 24
        Me.dgvtamu.Size = New System.Drawing.Size(626, 444)
        Me.dgvtamu.TabIndex = 39
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Poor Richard", 16.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKINGKAMARToolStripMenuItem, Me.TAMUToolStripMenuItem, Me.JENISKAMARToolStripMenuItem, Me.KAMARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(916, 39)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BOOKINGKAMARToolStripMenuItem
        '
        Me.BOOKINGKAMARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHECKINToolStripMenuItem, Me.CHECKOUTToolStripMenuItem})
        Me.BOOKINGKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 16.0!)
        Me.BOOKINGKAMARToolStripMenuItem.Name = "BOOKINGKAMARToolStripMenuItem"
        Me.BOOKINGKAMARToolStripMenuItem.Size = New System.Drawing.Size(242, 35)
        Me.BOOKINGKAMARToolStripMenuItem.Text = "BOOKING KAMAR"
        '
        'CHECKINToolStripMenuItem
        '
        Me.CHECKINToolStripMenuItem.Name = "CHECKINToolStripMenuItem"
        Me.CHECKINToolStripMenuItem.Size = New System.Drawing.Size(241, 36)
        Me.CHECKINToolStripMenuItem.Text = "CHECK IN"
        '
        'CHECKOUTToolStripMenuItem
        '
        Me.CHECKOUTToolStripMenuItem.Name = "CHECKOUTToolStripMenuItem"
        Me.CHECKOUTToolStripMenuItem.Size = New System.Drawing.Size(241, 36)
        Me.CHECKOUTToolStripMenuItem.Text = "CHECK OUT"
        '
        'TAMUToolStripMenuItem
        '
        Me.TAMUToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 16.0!)
        Me.TAMUToolStripMenuItem.Name = "TAMUToolStripMenuItem"
        Me.TAMUToolStripMenuItem.Size = New System.Drawing.Size(99, 35)
        Me.TAMUToolStripMenuItem.Text = "TAMU"
        '
        'JENISKAMARToolStripMenuItem
        '
        Me.JENISKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 16.0!)
        Me.JENISKAMARToolStripMenuItem.Name = "JENISKAMARToolStripMenuItem"
        Me.JENISKAMARToolStripMenuItem.Size = New System.Drawing.Size(187, 35)
        Me.JENISKAMARToolStripMenuItem.Text = "JENIS KAMAR"
        '
        'KAMARToolStripMenuItem
        '
        Me.KAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 16.0!)
        Me.KAMARToolStripMenuItem.Name = "KAMARToolStripMenuItem"
        Me.KAMARToolStripMenuItem.Size = New System.Drawing.Size(121, 35)
        Me.KAMARToolStripMenuItem.Text = "KAMAR"
        '
        'DAFTAR_TAMU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 720)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvtamu)
        Me.Controls.Add(Me.btnhapustamu)
        Me.Controls.Add(Me.btnedittamu)
        Me.Controls.Add(Me.btntambahtamu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DAFTAR_TAMU"
        Me.Text = "DAFTAR TAMU"
        CType(Me.dgvtamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btntambahtamu As Button
    Friend WithEvents btnedittamu As Button
    Friend WithEvents btnhapustamu As Button
    Friend WithEvents dgvtamu As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BOOKINGKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TAMUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JENISKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAMARToolStripMenuItem As ToolStripMenuItem
End Class
