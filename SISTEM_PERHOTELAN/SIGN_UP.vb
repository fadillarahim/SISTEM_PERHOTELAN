Imports System.IO

Public Class SIGN_UP
    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        If txtusernameuser.Text.Length > 0 And txtpassworduser.Text.Length > 0 And txtemailuser.Text.Length > 0 And txtnamauser.Text.Length > 0 Then
            WELCOME_PAGE.users.AddUsersDatabase(txtusernameuser.Text, txtpassworduser.Text, txtemailuser.Text, txtnamauser.Text, rtbalamatuser.Text)

            Me.Close()
            WELCOME_PAGE.Show()
        Else
            MessageBox.Show("Lengkapi Data Terlebih Dahulu")
        End If
        'LOGIN.Users.addusersdataregist(txtusernameregist.Text, txtpasswordregist.Text)
    End Sub


End Class