Public Class EDIT_KAMAR


    Public Shared Selected_idJenisKamar As String
    Public Shared Selected_jenisKamar As String



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Selected_jenisKamar = KAMAR.Selected_jenisKamar
        LabelJenisKamarValue.Text = KAMAR.Selected_jenisKamar
        TxtNamaKamar.Text = KAMAR.CLASS_KAMAR.nama_kamarProperty
        Selected_idJenisKamar = KAMAR.Selected_id_JenisKamar


        ' LblStatus.Text = KAMAR.CLASS_KAMAR.tambah_statusProperty

        ReloadDataTableDatabase()
        ReloadLabel()
    End Sub

    Private Sub DataGridViewJenisKamar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisKamar.Rows(index)


        Selected_idJenisKamar = selectedRow.Cells(0).Value
        Selected_jenisKamar = selectedRow.Cells(1).Value

    End Sub

    Private Sub DataGridViewJenisKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisKamar.Rows(index)

        Selected_idJenisKamar = selectedRow.Cells(0).Value
        Selected_jenisKamar = selectedRow.Cells(1).Value
        LabelJenisKamarValue.Text = Selected_jenisKamar

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewJenisKamar.DataSource = KAMAR.CLASS_KAMAR.GetDataJenisKamarDatabase()
    End Sub

    Private Sub ReloadLabel()
        DataGridViewJenisKamar.DataSource = KAMAR.CLASS_KAMAR.GetDataJenisKamarDatabase()
    End Sub

    Private Sub EDIT_KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
        ReloadLabel()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click


        KAMAR.CLASS_KAMAR.id_jenis_kamarProperty = Selected_idJenisKamar
        KAMAR.CLASS_KAMAR.nama_kamarProperty = TxtNamaKamar.Text.ToString()
        KAMAR.CLASS_KAMAR.tambah_statusProperty = 1

        KAMAR.CLASS_KAMAR.UpdateDataKamarByIDDatabase(KAMAR.Selected_idKamar,
                                                      KAMAR.CLASS_KAMAR.id_jenis_kamarProperty,
                                                      KAMAR.CLASS_KAMAR.nama_kamarProperty,
                                                      KAMAR.CLASS_KAMAR.tambah_statusProperty)



        Me.Close()
    End Sub



End Class