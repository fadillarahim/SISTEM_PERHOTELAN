Public Class CHECK_OUT
    Public total_bayar As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblidbookingkamar.Text = BOOKING_KAMAR.Selected_idbookingkamar
        lblnamatamu.Text = BOOKING_KAMAR.Selected_namatamu
        lblnamakamar.Text = BOOKING_KAMAR.Selected_namakamar
        lblhargapermalam.Text = BOOKING_KAMAR.selected_hargapermalam
        lbltglcheckin.Text = BOOKING_KAMAR.Selected_tanggalcheckin

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpcheckout.ValueChanged
        Dim tanggal_check_in
        Dim tanggal_check_out

        tanggal_check_in = DatePart("y", BOOKING_KAMAR.Selected_tanggalcheckin)
        tanggal_check_out = DatePart("y", dtpcheckout.Value)
        total_bayar = (tanggal_check_out - tanggal_check_in) * BOOKING_KAMAR.selected_hargapermalam
        LblNominalByr.Text = total_bayar


    End Sub

    Private Sub BtnCO_Click(sender As Object, e As EventArgs) Handles BtnCO.Click

        BOOKING_KAMAR.buku_tamu.tanggalcheckoutProperty = dtpcheckout.Value.ToString("yyyy/MM/dd")
        BOOKING_KAMAR.buku_tamu.totalbayarProperty = total_bayar

        BOOKING_KAMAR.buku_tamu.UpdateDataDaftarTamuByIDDatabase(BOOKING_KAMAR.Selected_idbookingkamar,
                                                                BOOKING_KAMAR.buku_tamu.tanggalcheckoutProperty,
                                                                BOOKING_KAMAR.buku_tamu.totalbayarProperty)

        Me.Close()
    End Sub
End Class