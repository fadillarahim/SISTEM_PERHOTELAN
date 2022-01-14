Imports System.IO

Public Class KAMAR

    Public Shared CLASS_KAMAR As New CLASS_KAMAR


    Public Shared Selected_idKamar As String
    Public Shared Selected_namaKamar As String
    Public Shared Selected_jenisKamar As String
    Public Shared Selected_id_JenisKamar As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahKamar_Click(sender As Object, e As EventArgs) Handles BtnTambahKamar.Click
        Dim tambah_kamar = New TAMBAH_KAMAR()
        tambah_kamar.Show()
    End Sub

    Private Sub BtnEditKamar_Click(sender As Object, e As EventArgs) Handles BtnEditKamar.Click


        If Selected_idKamar IsNot Nothing Then
            Dim selectedKamar As List(Of String) = CLASS_KAMAR.GetDataKamarByIDDatabase(Selected_idKamar)


            CLASS_KAMAR.id_jenis_kamarProperty = selectedKamar(1)
            CLASS_KAMAR.nama_kamarProperty = selectedKamar(2)
            CLASS_KAMAR.tambah_statusProperty = selectedKamar(3)


            Dim edit_kamar = New EDIT_KAMAR()
            edit_kamar.Show()
        Else

            MessageBox.Show("pilih data di table")

        End If


    End Sub

    Private Sub BtnHapusKamar_Click(sender As Object, e As EventArgs) Handles BtnHapusKamar.Click
        Dim hapus_kamar = New HAPUS_KAMAR()
        hapus_kamar.Show()
    End Sub

    Private Sub DataGridViewKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewKamar.Rows(index)

        Selected_idKamar = selectedRow.Cells(0).Value
        Selected_namaKamar = selectedRow.Cells(1).Value
        Selected_jenisKamar = selectedRow.Cells(4).Value
        Selected_id_JenisKamar = selectedRow.Cells(3).Value
    End Sub

    'Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
    'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
    'Dim index As Integer = e.RowIndex
    'Dim selectedRow As DataGridViewRow
    '   selectedRow = DataGridViewKamar.Rows(index)

    '  selectedTableKamar = selectedRow.Cells(0).Value
    ' selectedTableKamarNama = selectedRow.Cells(1).Value

    '    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewKamar.DataSource = CLASS_KAMAR.GetDataKamarDatabase()

    End Sub

    Private Sub KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub




    Private Sub CHECKINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKINToolStripMenuItem.Click
        Dim form_check_in = New CHECK_IN
        form_check_in.Show()
        Me.Close()
    End Sub

    Private Sub JENISKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JENISKAMARToolStripMenuItem.Click
        Dim form_jenis_kamar = New JENIS_KAMAR
        form_jenis_kamar.Show()
        Me.Close()
    End Sub

    Private Sub CHECKOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKOUTToolStripMenuItem.Click
        If BOOKING_KAMAR.Selected_idbookingkamar IsNot Nothing Then
            Dim form_check_out = New CHECK_OUT
            form_check_out.Show()
            Me.Close()

        Else
            MessageBox.Show("Silahkan Select terlebih dahulu data pada tabel Buku Tamu pada Form Booking Kamar")
        End If
    End Sub

    Private Sub TAMUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TAMUToolStripMenuItem.Click
        Dim form_tamu = New DAFTAR_TAMU
        form_tamu.Show()
        Me.Close()
    End Sub

    Private Sub BOOKINGKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGKAMARToolStripMenuItem.Click
        Dim form_booking_kamar = New BOOKING_KAMAR
        form_booking_kamar.Show()
        Me.Close()
    End Sub
End Class