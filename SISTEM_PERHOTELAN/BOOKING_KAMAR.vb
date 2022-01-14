Public Class BOOKING_KAMAR

    Public Shared buku_tamu As BUKU_TAMU
    Public Shared Selected_idbookingkamar As String
    Public Shared Selected_namatamu As String
    Public Shared Selected_namakamar As String
    Public Shared Selected_tanggalcheckin As Date
    Public Shared selected_hargapermalam As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        buku_tamu = New BUKU_TAMU()

        ' Add any initialization after the InitializeComponent() call.
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        DataGridViewBooking.DataSource = buku_tamu.GetDataDaftarTamuDatabase()
    End Sub

    Private Sub TAMUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TAMUToolStripMenuItem.Click
        Dim form_tamu = New DAFTAR_TAMU
        form_tamu.Show()
        Me.Close()
    End Sub

    Private Sub JENISKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JENISKAMARToolStripMenuItem.Click
        Dim form_jenis_kamar = New JENIS_KAMAR
        form_jenis_kamar.Show()
        Me.Close()
    End Sub


    Private Sub CHECKINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKINToolStripMenuItem.Click
        Dim form_check_in = New CHECK_IN
        form_check_in.show()
    End Sub

    Private Sub CHECKOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKOUTToolStripMenuItem.Click
        If Selected_idbookingkamar IsNot Nothing Then
            Dim form_check_out = New CHECK_OUT
            form_check_out.Show()

        Else
            MessageBox.Show("Silahkan Select terlebih dahulu data pada tabel Daftar Booking Kamar Hotel")
        End If

    End Sub

    Private Sub KAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KAMARToolStripMenuItem.Click
        Dim form_kamar = New KAMAR
        form_kamar.Show()
        Me.Close()
    End Sub

    Private Sub BOOKING_KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBooking.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBooking.Rows(index)

        Selected_idbookingkamar = selectedRow.Cells(0).Value
        Selected_namatamu = selectedRow.Cells(2).Value
        Selected_namakamar = selectedRow.Cells(6).Value
        Selected_tanggalcheckin = selectedRow.Cells(7).Value
        selected_hargapermalam = selectedRow.Cells(9).Value

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim form_hapus_booking = New HAPUS_BOOKING_KAMAR()
        form_hapus_booking.Show()
    End Sub
End Class