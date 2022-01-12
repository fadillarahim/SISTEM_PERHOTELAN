<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KAMAR
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
        Me.BtnHapusKamar = New System.Windows.Forms.Button()
        Me.BtnEditKamar = New System.Windows.Forms.Button()
        Me.BtnTambahKamar = New System.Windows.Forms.Button()
        Me.DataGridViewKamar = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BOOKINGKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TAMUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JENISKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DAFTAR KAMAR HOTEL"
        '
        'BtnHapusKamar
        '
        Me.BtnHapusKamar.Font = New System.Drawing.Font("Poor Richard", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusKamar.Location = New System.Drawing.Point(521, 425)
        Me.BtnHapusKamar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnHapusKamar.Name = "BtnHapusKamar"
        Me.BtnHapusKamar.Size = New System.Drawing.Size(111, 39)
        Me.BtnHapusKamar.TabIndex = 9
        Me.BtnHapusKamar.Text = "HAPUS "
        Me.BtnHapusKamar.UseVisualStyleBackColor = True
        '
        'BtnEditKamar
        '
        Me.BtnEditKamar.Font = New System.Drawing.Font("Poor Richard", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditKamar.Location = New System.Drawing.Point(363, 425)
        Me.BtnEditKamar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEditKamar.Name = "BtnEditKamar"
        Me.BtnEditKamar.Size = New System.Drawing.Size(116, 42)
        Me.BtnEditKamar.TabIndex = 8
        Me.BtnEditKamar.Text = "EDIT"
        Me.BtnEditKamar.UseVisualStyleBackColor = True
        '
        'BtnTambahKamar
        '
        Me.BtnTambahKamar.Font = New System.Drawing.Font("Poor Richard", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahKamar.Location = New System.Drawing.Point(194, 424)
        Me.BtnTambahKamar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnTambahKamar.Name = "BtnTambahKamar"
        Me.BtnTambahKamar.Size = New System.Drawing.Size(128, 43)
        Me.BtnTambahKamar.TabIndex = 7
        Me.BtnTambahKamar.Text = "TAMBAH"
        Me.BtnTambahKamar.UseVisualStyleBackColor = True
        '
        'DataGridViewKamar
        '
        Me.DataGridViewKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKamar.Location = New System.Drawing.Point(194, 111)
        Me.DataGridViewKamar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridViewKamar.Name = "DataGridViewKamar"
        Me.DataGridViewKamar.RowHeadersWidth = 51
        Me.DataGridViewKamar.Size = New System.Drawing.Size(438, 270)
        Me.DataGridViewKamar.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKINGKAMARToolStripMenuItem, Me.TAMUToolStripMenuItem, Me.JENISKAMARToolStripMenuItem, Me.KAMARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BOOKINGKAMARToolStripMenuItem
        '
        Me.BOOKINGKAMARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHECKINToolStripMenuItem, Me.CHECKOUTToolStripMenuItem})
        Me.BOOKINGKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 13.2!)
        Me.BOOKINGKAMARToolStripMenuItem.Name = "BOOKINGKAMARToolStripMenuItem"
        Me.BOOKINGKAMARToolStripMenuItem.Size = New System.Drawing.Size(204, 29)
        Me.BOOKINGKAMARToolStripMenuItem.Text = "BOOKING KAMAR"
        '
        'CHECKINToolStripMenuItem
        '
        Me.CHECKINToolStripMenuItem.Name = "CHECKINToolStripMenuItem"
        Me.CHECKINToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.CHECKINToolStripMenuItem.Text = "CHECK IN"
        '
        'CHECKOUTToolStripMenuItem
        '
        Me.CHECKOUTToolStripMenuItem.Name = "CHECKOUTToolStripMenuItem"
        Me.CHECKOUTToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.CHECKOUTToolStripMenuItem.Text = "CHECK OUT"
        '
        'TAMUToolStripMenuItem
        '
        Me.TAMUToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 13.2!)
        Me.TAMUToolStripMenuItem.Name = "TAMUToolStripMenuItem"
        Me.TAMUToolStripMenuItem.Size = New System.Drawing.Size(84, 29)
        Me.TAMUToolStripMenuItem.Text = "TAMU"
        '
        'JENISKAMARToolStripMenuItem
        '
        Me.JENISKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 13.2!)
        Me.JENISKAMARToolStripMenuItem.Name = "JENISKAMARToolStripMenuItem"
        Me.JENISKAMARToolStripMenuItem.Size = New System.Drawing.Size(157, 29)
        Me.JENISKAMARToolStripMenuItem.Text = "JENIS KAMAR"
        '
        'KAMARToolStripMenuItem
        '
        Me.KAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 13.2!)
        Me.KAMARToolStripMenuItem.Name = "KAMARToolStripMenuItem"
        Me.KAMARToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.KAMARToolStripMenuItem.Text = "KAMAR"
        '
        'KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 551)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusKamar)
        Me.Controls.Add(Me.BtnEditKamar)
        Me.Controls.Add(Me.BtnTambahKamar)
        Me.Controls.Add(Me.DataGridViewKamar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "KAMAR"
        Me.Text = "KAMAR"
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapusKamar As Button
    Friend WithEvents BtnEditKamar As Button
    Friend WithEvents BtnTambahKamar As Button
    Friend WithEvents DataGridViewKamar As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BOOKINGKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TAMUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JENISKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAMARToolStripMenuItem As ToolStripMenuItem
End Class
