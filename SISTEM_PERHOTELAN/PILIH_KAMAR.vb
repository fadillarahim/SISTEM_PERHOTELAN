Public Class PILIH_KAMAR

    Public Shared Kamar As CLASS_KAMAR
    Public Shared Selected_idkamar As String
    Public Shared Selected_namakamar As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Kamar = New CLASS_KAMAR()
        ' Add any initialization after the InitializeComponent() call.

        reloadDataTableDatabase()
    End Sub

    Private Sub PILIH_KAMAR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        DataGridViewPilihKamar.DataSource = Kamar.GetDataKamarDatabase()
    End Sub

    Private Sub BtnAmbilJenisKamar_Click(sender As Object, e As EventArgs) Handles btnambil.Click
        CHECK_IN.TxtBoxNoKmr.Text = Selected_namakamar
        CHECK_IN.Show()
        Me.Close()
    End Sub

    Private Sub DataGridViewPilihKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPilihKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewPilihKamar.Rows(index)

        Selected_idkamar = selectedRow.Cells(0).Value
        Selected_namakamar = selectedRow.Cells(1).Value
    End Sub

    Private Sub DataGridViewPilihKamar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPilihKamar.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewPilihKamar.Rows(index)


        Selected_idkamar = selectedRow.Cells(0).Value
        Selected_namakamar = selectedRow.Cells(1).Value
    End Sub
End Class