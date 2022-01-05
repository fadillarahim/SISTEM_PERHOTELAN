Public Class HAPUS_JENIS_KAMAR
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LblJenisKamarHapus.Text = JENIS_KAMAR.selectedtablejeniskamarnama
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapusJenisKamar_Click(sender As Object, e As EventArgs) Handles BtnHapusJenisKamar.Click
        'Perpustakaan.Koleksi.RemoveKoleksi(Perpustakaan.ListBoxKoleksi.SelectedItem())
        JENIS_KAMAR.jenisKamar.DeleteDataJenisKamarByIDDatabase(JENIS_KAMAR.selectedtablejeniskamar)
        Me.Close()
    End Sub
End Class