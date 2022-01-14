Public Class WELCOME_PAGE

    Public Shared users As USERS

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'booking_kamar = New booking_kamar
        users = New USERS()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim FORM_LOGIN = New LOGIN()
        FORM_LOGIN.Show()

        Me.Hide()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim FORM_SIGNUP = New SIGN_UP()
        FORM_SIGNUP.Show()

        Me.Hide()
    End Sub
End Class