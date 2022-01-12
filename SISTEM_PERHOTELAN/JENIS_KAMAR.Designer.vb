<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JENIS_KAMAR
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
        Me.LblJenisKamar = New System.Windows.Forms.Label()
        Me.BtnHapusJenisKamar = New System.Windows.Forms.Button()
        Me.BtnEditJenisKamar = New System.Windows.Forms.Button()
        Me.BtnTambahJenisKamar = New System.Windows.Forms.Button()
        Me.DataGridViewJenisKamar = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BOOKINGKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TAMUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JENISKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewJenisKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblJenisKamar
        '
        Me.LblJenisKamar.AutoSize = True
        Me.LblJenisKamar.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKamar.Location = New System.Drawing.Point(259, 58)
        Me.LblJenisKamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisKamar.Name = "LblJenisKamar"
        Me.LblJenisKamar.Size = New System.Drawing.Size(0, 35)
        Me.LblJenisKamar.TabIndex = 10
        '
        'BtnHapusJenisKamar
        '
        Me.BtnHapusJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnHapusJenisKamar.Location = New System.Drawing.Point(450, 480)
        Me.BtnHapusJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapusJenisKamar.Name = "BtnHapusJenisKamar"
        Me.BtnHapusJenisKamar.Size = New System.Drawing.Size(103, 42)
        Me.BtnHapusJenisKamar.TabIndex = 9
        Me.BtnHapusJenisKamar.Text = "HAPUS"
        Me.BtnHapusJenisKamar.UseVisualStyleBackColor = True
        '
        'BtnEditJenisKamar
        '
        Me.BtnEditJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnEditJenisKamar.Location = New System.Drawing.Point(294, 480)
        Me.BtnEditJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditJenisKamar.Name = "BtnEditJenisKamar"
        Me.BtnEditJenisKamar.Size = New System.Drawing.Size(120, 42)
        Me.BtnEditJenisKamar.TabIndex = 8
        Me.BtnEditJenisKamar.Text = "EDIT"
        Me.BtnEditJenisKamar.UseVisualStyleBackColor = True
        '
        'BtnTambahJenisKamar
        '
        Me.BtnTambahJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnTambahJenisKamar.Location = New System.Drawing.Point(113, 480)
        Me.BtnTambahJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTambahJenisKamar.Name = "BtnTambahJenisKamar"
        Me.BtnTambahJenisKamar.Size = New System.Drawing.Size(132, 42)
        Me.BtnTambahJenisKamar.TabIndex = 7
        Me.BtnTambahJenisKamar.Text = "TAMBAH"
        Me.BtnTambahJenisKamar.UseVisualStyleBackColor = True
        '
        'DataGridViewJenisKamar
        '
        Me.DataGridViewJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisKamar.Location = New System.Drawing.Point(113, 119)
        Me.DataGridViewJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewJenisKamar.Name = "DataGridViewJenisKamar"
        Me.DataGridViewJenisKamar.RowHeadersWidth = 51
        Me.DataGridViewJenisKamar.Size = New System.Drawing.Size(457, 331)
        Me.DataGridViewJenisKamar.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKINGKAMARToolStripMenuItem, Me.TAMUToolStripMenuItem, Me.JENISKAMARToolStripMenuItem, Me.KAMARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 31)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BOOKINGKAMARToolStripMenuItem
        '
        Me.BOOKINGKAMARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHECKINToolStripMenuItem, Me.CHECKOUTToolStripMenuItem})
        Me.BOOKINGKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.BOOKINGKAMARToolStripMenuItem.Name = "BOOKINGKAMARToolStripMenuItem"
        Me.BOOKINGKAMARToolStripMenuItem.Size = New System.Drawing.Size(182, 27)
        Me.BOOKINGKAMARToolStripMenuItem.Text = "BOOKING KAMAR"
        '
        'CHECKINToolStripMenuItem
        '
        Me.CHECKINToolStripMenuItem.Name = "CHECKINToolStripMenuItem"
        Me.CHECKINToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.CHECKINToolStripMenuItem.Text = "CHECK IN"
        '
        'CHECKOUTToolStripMenuItem
        '
        Me.CHECKOUTToolStripMenuItem.Name = "CHECKOUTToolStripMenuItem"
        Me.CHECKOUTToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.CHECKOUTToolStripMenuItem.Text = "CHECK OUT"
        '
        'TAMUToolStripMenuItem
        '
        Me.TAMUToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.TAMUToolStripMenuItem.Name = "TAMUToolStripMenuItem"
        Me.TAMUToolStripMenuItem.Size = New System.Drawing.Size(75, 27)
        Me.TAMUToolStripMenuItem.Text = "TAMU"
        '
        'JENISKAMARToolStripMenuItem
        '
        Me.JENISKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.JENISKAMARToolStripMenuItem.Name = "JENISKAMARToolStripMenuItem"
        Me.JENISKAMARToolStripMenuItem.Size = New System.Drawing.Size(139, 27)
        Me.JENISKAMARToolStripMenuItem.Text = "JENIS KAMAR"
        '
        'KAMARToolStripMenuItem
        '
        Me.KAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.KAMARToolStripMenuItem.Name = "KAMARToolStripMenuItem"
        Me.KAMARToolStripMenuItem.Size = New System.Drawing.Size(91, 27)
        Me.KAMARToolStripMenuItem.Text = "KAMAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DAFTAR JENIS KAMAR HOTEL"
        '
        'JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 577)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblJenisKamar)
        Me.Controls.Add(Me.BtnHapusJenisKamar)
        Me.Controls.Add(Me.BtnEditJenisKamar)
        Me.Controls.Add(Me.BtnTambahJenisKamar)
        Me.Controls.Add(Me.DataGridViewJenisKamar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "JENIS_KAMAR"
        Me.Text = "JENIS_KAMAR"
        CType(Me.DataGridViewJenisKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJenisKamar As Label
    Friend WithEvents BtnHapusJenisKamar As Button
    Friend WithEvents BtnEditJenisKamar As Button
    Friend WithEvents BtnTambahJenisKamar As Button
    Friend WithEvents DataGridViewJenisKamar As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BOOKINGKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TAMUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JENISKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
