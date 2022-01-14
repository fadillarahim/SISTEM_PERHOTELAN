Public Class HAPUS_KAMAR

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNamaKamar.Text = KAMAR.Selected_namaKamar
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        KAMAR.CLASS_KAMAR.DeleteDataKamarByIDDatabase(KAMAR.Selected_idKamar)
        Me.Close()
    End Sub

    Private Sub btntidak_Click(sender As Object, e As EventArgs) Handles btntidak.Click

        Me.Close()
    End Sub
End Class