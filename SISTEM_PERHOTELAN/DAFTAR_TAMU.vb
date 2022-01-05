
Public Class DAFTAR_TAMU

    Public Shared tamu As TAMU

    Public Shared selected_tamu As String
    Public Shared selectedtabletamu
    Public Shared selectedtabletamunama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tamu = New TAMU()

        'Manggil ReloadDataTableDatabase
        reloadDataTableDatabase()
    End Sub


    Private Sub btntambahtamu_Click(sender As Object, e As EventArgs) Handles btntambahtamu.Click
        Dim form_tambah_tamu = New TAMBAH_TAMU
        form_tambah_tamu.Show()
        Me.Hide()
    End Sub

    Private Sub btnhapustamu_Click(sender As Object, e As EventArgs) Handles btnhapustamu.Click
        HAPUS_TAMU.Show()
    End Sub

    Private Sub btnedittamu_Click(sender As Object, e As EventArgs) Handles btnedittamu.Click
        Dim selectedtamu As List(Of String) = tamu.GetDataTamuByIDDatabase(selectedtabletamu)

        tamu.niktamuProperty = selectedtamu(1)
        tamu.namatamuProperty = selectedtamu(2)
        tamu.alamattamuProperty = selectedtamu(3)
        tamu.jeniskelamintamuProperty = selectedtamu(4)

        Dim FORM_EDIT_TAMU = New EDIT_TAMU
        FORM_EDIT_TAMU.Show()
        Me.Close()

    End Sub

    Private Sub DAFTAR_TAMU_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        reloadDataTableDatabase()

    End Sub

    Private Sub reloadDataTableDatabase()
        dgvtamu.DataSource = tamu.GetDataTamuDatabase()
    End Sub


    Private Sub dgvtamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtamu.CellClick

        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = dgvtamu.Rows(index)

        selectedtabletamu = selectedrow.Cells(0).Value
        selectedtabletamunama = selectedrow.Cells(2).Value
    End Sub

    Private Sub BOOKINGKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGKAMARToolStripMenuItem.Click
        Dim form_booking_kamar = New BOOKING_KAMAR
        form_booking_kamar.show()

    End Sub

    Private Sub JENISKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JENISKAMARToolStripMenuItem.Click
        Dim form_jenis_kamar = New JENIS_KAMAR
        form_jenis_kamar.show()
    End Sub

    Private Sub KAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KAMARToolStripMenuItem.Click
        Dim form_kamar = New KAMAR
        form_kamar.show()
    End Sub

    Private Sub CHECKINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKINToolStripMenuItem.Click
        Dim form_check_in = New CHECK_IN
        form_check_in.show()
    End Sub

    Private Sub CHECKOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKOUTToolStripMenuItem.Click
        Dim form_check_out = New CHECK_OUT
        form_check_out.show()
    End Sub
End Class