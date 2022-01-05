Public Class PILIH_JENIS_KAMAR
    Public Shared jenis_kamar As JenisKamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        jenis_kamar = New JenisKamar()
        ' Add any initialization after the InitializeComponent() call.

        reloadDataTableDatabase()
    End Sub

    Private Sub PILIH_JENIS_KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        DataGridViewPilihJenisKamar.DataSource = jenis_kamar.GetDataJenisKamarDatabase()
    End Sub

    Private Sub BtnAmbilJenisKamar_Click(sender As Object, e As EventArgs) Handles BtnAmbilJenisKamar.Click
        'DAFTAR_TAMU.Show()
        Me.Close()
    End Sub
End Class