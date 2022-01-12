
Public Class PILIH_TAMU

    Public Shared tamu As TAMU

    Public Shared Selected_idtamu As String
    Public Shared Selected_namatamu As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        tamu = New TAMU()
        ' Add any initialization after the InitializeComponent() call.

        reloadDataTableDatabase()
    End Sub

    Private Sub PILIH_TAMU_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        dgvambiltamu.DataSource = TAMU.GetDataTamuDatabase()
    End Sub

    Private Sub btnambiltamu_Click(sender As Object, e As EventArgs) Handles btnambiltamu.Click
        CHECK_IN.TxtBoxNamaTamu.Text = Selected_namatamu
        CHECK_IN.Show()
        Me.Close()
    End Sub

    Private Sub dgvambiltamu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvambiltamu.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvambiltamu.Rows(index)


        Selected_idtamu = selectedRow.Cells(0).Value
        Selected_namatamu = selectedRow.Cells(2).Value
    End Sub

    Private Sub dgvambiltamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvambiltamu.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvambiltamu.Rows(index)

        Selected_idtamu = selectedRow.Cells(0).Value
        Selected_namatamu = selectedRow.Cells(2).Value
    End Sub
End Class