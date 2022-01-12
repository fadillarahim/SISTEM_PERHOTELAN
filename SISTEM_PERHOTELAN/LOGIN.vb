Public Class LOGIN

    'Public Shared bookingkamar As booking_kamar


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'bookingkamar = New bookingkamar

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim plainusername As String = txtusername.Text
        Dim plainpassword As String = txtpassword.Text

        Dim data_user As List(Of String) = WELCOME_PAGE.users.CheckAuthDatabase(plainusername, plainpassword)


        If data_user.Count > 0 Then
            WELCOME_PAGE.users.usernameproperty = data_user(1)
            'ini yg benar yg di bawah
            BOOKING_KAMAR.Show()

            'ini yg salah yg form BUKU_TAMU.SHOW . HAPUS AJA NTAR YAKKK
            'DAFTAR_TAMU.Show()

            Me.Hide()
        Else
            MessageBox.Show("Mohon Maaf Password Anda Salah")
        End If


    End Sub
End Class