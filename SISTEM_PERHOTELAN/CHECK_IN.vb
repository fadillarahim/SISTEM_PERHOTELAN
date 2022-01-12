Imports System.Text
Imports MySql.Data.MySqlClient

Public Class CHECK_IN



    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "system_perhotelan"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnAmbilData1_Click(sender As Object, e As EventArgs) Handles BtnAmbilData1.Click
        Dim form_pilih_tamu = New PILIH_TAMU
        form_pilih_tamu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAmbilData2_Click(sender As Object, e As EventArgs) Handles BtnAmbilData2.Click
        Dim form_pilih_jenis_kamar = New PILIH_JENIS_KAMAR
        form_pilih_jenis_kamar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAmbilData3_Click(sender As Object, e As EventArgs) Handles BtnAmbilData3.Click
        Dim form_pilih_kamar = New PILIH_KAMAR
        form_pilih_kamar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCheckIn_Click(sender As Object, e As EventArgs) Handles BtnCheckIn.Click
        BOOKING_KAMAR.buku_tamu.idtamuProperty = PILIH_TAMU.Selected_idtamu
        BOOKING_KAMAR.buku_tamu.namatamuProperty = TxtBoxNamaTamu.Text.ToString()
        BOOKING_KAMAR.buku_tamu.idjeniskamarProperty = PILIH_JENIS_KAMAR.Selected_idjeniskamar
        BOOKING_KAMAR.buku_tamu.jeniskamarProperty = TxtBoxJnsKmr.Text.ToString()
        BOOKING_KAMAR.buku_tamu.idkamarProperty = PILIH_KAMAR.Selected_idkamar
        BOOKING_KAMAR.buku_tamu.namakamarProperty = TxtBoxNoKmr.Text.ToString()


        Dim tanggal_check_in As String
        tanggal_check_in = DateTimePickerCI.Value.ToString("yyyy/MM/dd")
        BOOKING_KAMAR.buku_tamu.tanggalcheckinProperty = tanggal_check_in

        Dim tanggal_check_out As String
        tanggal_check_out = CHECK_OUT.dtpcheckout.Value.ToString("yyyy/MM/dd")
        BOOKING_KAMAR.buku_tamu.tanggalcheckoutProperty = tanggal_check_out



        BOOKING_KAMAR.buku_tamu.AddDataDaftarTamuDatabase(BOOKING_KAMAR.buku_tamu.idtamuProperty,
                                                        BOOKING_KAMAR.buku_tamu.idjeniskamarProperty,
                                                        BOOKING_KAMAR.buku_tamu.idkamarProperty,
                                                        BOOKING_KAMAR.buku_tamu.tanggalcheckinProperty)

        Me.Close()
    End Sub

End Class