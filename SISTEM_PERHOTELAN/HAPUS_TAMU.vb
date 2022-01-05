Public Class HAPUS_TAMU

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        lblnamatamu.Text = DAFTAR_TAMU.selectedtabletamunama



    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Perpustakaan.Koleksi.RemoveKoleksi(Perpustakaan.ListBoxKoleksi.SelectedItem())
        DAFTAR_TAMU.tamu.DeleteDataTamuByIDDatabase(DAFTAR_TAMU.selectedtabletamu)
        Me.Close()
    End Sub


End Class