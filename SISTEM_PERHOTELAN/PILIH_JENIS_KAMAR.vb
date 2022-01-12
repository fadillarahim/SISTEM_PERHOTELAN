Public Class PILIH_JENIS_KAMAR

    Public Shared jeniskamar As JenisKamar
    Public Shared Selected_idjeniskamar As String
    Public Shared Selected_jeniskamar As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        jeniskamar = New JenisKamar()
        ' Add any initialization after the InitializeComponent() call.

        reloadDataTableDatabase()
    End Sub

    Private Sub PILIH_JENIS_KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        dgvambiljeniskamar.DataSource = jeniskamar.GetDataJenisKamarDatabase()
    End Sub

    Private Sub btnambiljeniskamar_Click(sender As Object, e As EventArgs) Handles btnambiljeniskamar.Click
        CHECK_IN.TxtBoxJnsKmr.Text = Selected_jeniskamar
        CHECK_IN.Show()
        Me.Close()
    End Sub

    Private Sub dgvambiljeniskamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvambiljeniskamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvambiljeniskamar.Rows(index)

        Selected_idjeniskamar = selectedRow.Cells(0).Value
        Selected_jeniskamar = selectedRow.Cells(1).Value
    End Sub

    Private Sub dgvambiljeniskamar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvambiljeniskamar.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvambiljeniskamar.Rows(index)


        Selected_idjeniskamar = selectedRow.Cells(0).Value
        Selected_jeniskamar = selectedRow.Cells(1).Value
    End Sub
End Class