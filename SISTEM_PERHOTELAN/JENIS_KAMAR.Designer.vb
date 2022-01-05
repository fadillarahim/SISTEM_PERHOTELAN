<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JENIS_KAMAR
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
        Me.DataGridViewJenisKamar = New System.Windows.Forms.DataGridView()
        Me.BtnTambahJenisKamar = New System.Windows.Forms.Button()
        Me.BtnEditJenisKamar = New System.Windows.Forms.Button()
        Me.BtnHapusJenisKamar = New System.Windows.Forms.Button()
        Me.LblJenisKamar = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BOOKINGKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TAMUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JENISKAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAMARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewJenisKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewJenisKamar
        '
        Me.DataGridViewJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisKamar.Location = New System.Drawing.Point(30, 65)
        Me.DataGridViewJenisKamar.Name = "DataGridViewJenisKamar"
        Me.DataGridViewJenisKamar.Size = New System.Drawing.Size(343, 269)
        Me.DataGridViewJenisKamar.TabIndex = 0
        '
        'BtnTambahJenisKamar
        '
        Me.BtnTambahJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnTambahJenisKamar.Location = New System.Drawing.Point(30, 358)
        Me.BtnTambahJenisKamar.Name = "BtnTambahJenisKamar"
        Me.BtnTambahJenisKamar.Size = New System.Drawing.Size(99, 34)
        Me.BtnTambahJenisKamar.TabIndex = 1
        Me.BtnTambahJenisKamar.Text = "TAMBAH"
        Me.BtnTambahJenisKamar.UseVisualStyleBackColor = True
        '
        'BtnEditJenisKamar
        '
        Me.BtnEditJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnEditJenisKamar.Location = New System.Drawing.Point(166, 358)
        Me.BtnEditJenisKamar.Name = "BtnEditJenisKamar"
        Me.BtnEditJenisKamar.Size = New System.Drawing.Size(90, 34)
        Me.BtnEditJenisKamar.TabIndex = 2
        Me.BtnEditJenisKamar.Text = "EDIT"
        Me.BtnEditJenisKamar.UseVisualStyleBackColor = True
        '
        'BtnHapusJenisKamar
        '
        Me.BtnHapusJenisKamar.Font = New System.Drawing.Font("Poor Richard", 13.8!)
        Me.BtnHapusJenisKamar.Location = New System.Drawing.Point(283, 358)
        Me.BtnHapusJenisKamar.Name = "BtnHapusJenisKamar"
        Me.BtnHapusJenisKamar.Size = New System.Drawing.Size(77, 34)
        Me.BtnHapusJenisKamar.TabIndex = 3
        Me.BtnHapusJenisKamar.Text = "HAPUS"
        Me.BtnHapusJenisKamar.UseVisualStyleBackColor = True
        '
        'LblJenisKamar
        '
        Me.LblJenisKamar.AutoSize = True
        Me.LblJenisKamar.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKamar.Location = New System.Drawing.Point(123, 25)
        Me.LblJenisKamar.Name = "LblJenisKamar"
        Me.LblJenisKamar.Size = New System.Drawing.Size(133, 28)
        Me.LblJenisKamar.TabIndex = 4
        Me.LblJenisKamar.Text = "Jenis Kamar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKINGKAMARToolStripMenuItem, Me.TAMUToolStripMenuItem, Me.JENISKAMARToolStripMenuItem, Me.KAMARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(416, 27)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BOOKINGKAMARToolStripMenuItem
        '
        Me.BOOKINGKAMARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHECKINToolStripMenuItem, Me.CHECKOUTToolStripMenuItem})
        Me.BOOKINGKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.BOOKINGKAMARToolStripMenuItem.Name = "BOOKINGKAMARToolStripMenuItem"
        Me.BOOKINGKAMARToolStripMenuItem.Size = New System.Drawing.Size(149, 23)
        Me.BOOKINGKAMARToolStripMenuItem.Text = "BOOKING KAMAR"
        '
        'CHECKINToolStripMenuItem
        '
        Me.CHECKINToolStripMenuItem.Name = "CHECKINToolStripMenuItem"
        Me.CHECKINToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CHECKINToolStripMenuItem.Text = "CHECK IN"
        '
        'CHECKOUTToolStripMenuItem
        '
        Me.CHECKOUTToolStripMenuItem.Name = "CHECKOUTToolStripMenuItem"
        Me.CHECKOUTToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CHECKOUTToolStripMenuItem.Text = "CHECK OUT"
        '
        'TAMUToolStripMenuItem
        '
        Me.TAMUToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.TAMUToolStripMenuItem.Name = "TAMUToolStripMenuItem"
        Me.TAMUToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.TAMUToolStripMenuItem.Text = "TAMU"
        '
        'JENISKAMARToolStripMenuItem
        '
        Me.JENISKAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.JENISKAMARToolStripMenuItem.Name = "JENISKAMARToolStripMenuItem"
        Me.JENISKAMARToolStripMenuItem.Size = New System.Drawing.Size(115, 23)
        Me.JENISKAMARToolStripMenuItem.Text = "JENIS KAMAR"
        '
        'KAMARToolStripMenuItem
        '
        Me.KAMARToolStripMenuItem.Font = New System.Drawing.Font("Poor Richard", 12.0!)
        Me.KAMARToolStripMenuItem.Name = "KAMARToolStripMenuItem"
        Me.KAMARToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.KAMARToolStripMenuItem.Text = "KAMAR"
        '
        'JENIS_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 408)
        Me.Controls.Add(Me.LblJenisKamar)
        Me.Controls.Add(Me.BtnHapusJenisKamar)
        Me.Controls.Add(Me.BtnEditJenisKamar)
        Me.Controls.Add(Me.BtnTambahJenisKamar)
        Me.Controls.Add(Me.DataGridViewJenisKamar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "JENIS_KAMAR"
        Me.Text = "Jenis Kamar"
        CType(Me.DataGridViewJenisKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewJenisKamar As DataGridView
    Friend WithEvents BtnTambahJenisKamar As Button
    Friend WithEvents BtnEditJenisKamar As Button
    Friend WithEvents BtnHapusJenisKamar As Button
    Friend WithEvents LblJenisKamar As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BOOKINGKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TAMUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JENISKAMARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAMARToolStripMenuItem As ToolStripMenuItem
End Class
