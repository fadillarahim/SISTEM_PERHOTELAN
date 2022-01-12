Public Class HAPUS_BOOKING_KAMAR

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblnamatamu.Text = BOOKING_KAMAR.Selected_namatamu
        lblidbooking.Text = BOOKING_KAMAR.Selected_idbookingkamar
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        BOOKING_KAMAR.buku_tamu.DeleteDataDaftarTamuByIDDatabase(BOOKING_KAMAR.Selected_idbookingkamar)

        Me.Close()
    End Sub
End Class