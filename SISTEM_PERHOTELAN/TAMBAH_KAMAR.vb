Public Class TAMBAH_KAMAR

    Private jenis_kamar As String
    Private nama_kamar As String
    Private tambah_status As String

    Public Shared Selected_idJenisKamar As String
    Public Shared Selected_jenisKamar As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        KAMAR.CLASS_KAMAR.id_jenis_kamarProperty = Selected_idJenisKamar
        KAMAR.CLASS_KAMAR.nama_kamarProperty = TxtNamaKamar.Text.ToString()
        KAMAR.CLASS_KAMAR.tambah_statusProperty = 1


        KAMAR.CLASS_KAMAR.AddDataKamarDatabase(KAMAR.CLASS_KAMAR.id_jenis_kamarProperty,
                                               KAMAR.CLASS_KAMAR.nama_kamarProperty,
                                               KAMAR.CLASS_KAMAR.tambah_statusProperty)



        Me.Close()
    End Sub

    Private Sub DataGridViewJenisKamar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisKamar.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisKamar.Rows(index)


        Selected_idJenisKamar = selectedRow.Cells(0).Value
        Selected_jenisKamar = selectedRow.Cells(1).Value
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewJenisKamar.DataSource = KAMAR.CLASS_KAMAR.GetDataJenisKamarDatabase()
    End Sub

    Private Sub TAMBAH_KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()

    End Sub

    Private Sub DataGridViewJenisKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisKamar.Rows(index)

        Selected_idJenisKamar = selectedRow.Cells(0).Value
        Selected_jenisKamar = selectedRow.Cells(1).Value
        LblJenisKamarValue.Text = Selected_jenisKamar
    End Sub

End Class