Public Class PILIH_TAMU

    Public Shared tamu As TAMU

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
        dgvambiltamu.DataSource = tamu.GetDataTamuDatabase()
    End Sub

    Private Sub btnambiltamu_Click(sender As Object, e As EventArgs) Handles btnambiltamu.Click

    End Sub

End Class