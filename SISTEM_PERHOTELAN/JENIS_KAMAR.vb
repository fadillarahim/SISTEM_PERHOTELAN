Public Class JENIS_KAMAR
    Public Shared jenisKamar As JenisKamar

    Public Shared selected_koleksi As String
    Public Shared selectedtablejeniskamar
    Public Shared selectedtablejeniskamarnama As String

    Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()
        jenisKamar = New JenisKamar
        'ReloadDataTableDatabase()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnTambahJenisKamar_Click(sender As Object, e As EventArgs) Handles BtnTambahJenisKamar.Click
        TAMBAH_JENIS_KAMAR.Show()
    End Sub

    Private Sub BtnHapusJenisKamar_Click(sender As Object, e As EventArgs) Handles BtnHapusJenisKamar.Click
        HAPUS_JENIS_KAMAR.Show()
    End Sub

    Private Sub BtnEditJenisKamar_Click(sender As Object, e As EventArgs) Handles BtnEditJenisKamar.Click
        Dim selectedJenisKamar As List(Of String) = jenisKamar.GetDataJenisKamarByIDDatabase(selectedtablejeniskamar)


        jenisKamar.jenisKamarProperty = selectedJenisKamar(1)
        jenisKamar.hargaPermalamProperty = selectedJenisKamar(2)


        Dim formEdit = New EDIT_JENIS_KAMAR()
        formEdit.Show()

    End Sub


    Private Sub JENIS_KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewJenisKamar.DataSource = jenisKamar.GetDataJenisKamarDatabase()
    End Sub

    Private Sub DataGridJenisKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisKamar.Rows(index)

        selectedtablejeniskamar = selectedRow.Cells(0).Value
        selectedtablejeniskamarnama = selectedRow.Cells(1).Value
    End Sub

    Private Sub JENISKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JENISKAMARToolStripMenuItem.Click
        PILIH_JENIS_KAMAR.Show()
    End Sub

    'Private Sub BOOKINGKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGKAMARToolStripMenuItem.Click
    '    Dim form_booking_kamar = New BOOKING_KAMAR
    '    form_booking_kamar.Show()
    'End Sub

    'Private Sub CHECKINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKINToolStripMenuItem.Click
    '    Dim form_check_in = New CHECK_IN
    '    form_check_in.Show()
    'End Sub

    'Private Sub CHECKOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKOUTToolStripMenuItem.Click
    '    Dim form_check_out = New CHECK_OUT
    '    form_check_out.Show()
    'End Sub

    'Private Sub TAMUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TAMUToolStripMenuItem.Click
    '    Dim form_daftar_tamu = New DAFTAR_TAMU
    '    form_daftar_tamu.Show()
    'End Sub

    'Private Sub JENISKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JENISKAMARToolStripMenuItem.Click
    '    Dim form_jenis_kamar = New JENIS_KAMAR
    '    form_jenis_kamar.Show()
    'End Sub

    'Private Sub KAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KAMARToolStripMenuItem.Click
    '    Dim form_kamar = New KAMAR
    '    form_kamar.Show()
    'End Sub
End Class
