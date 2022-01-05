Public Class EDIT_TAMU

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        txtniktamuedit.Text = DAFTAR_TAMU.tamu.niktamuProperty
        txtnamatamuedit.Text = DAFTAR_TAMU.tamu.namatamuProperty
        rtbalamattamuedit.Text = DAFTAR_TAMU.tamu.alamattamuProperty
        cbjeniskelamintamuedit.SelectedItem() = DAFTAR_TAMU.tamu.jeniskelamintamuProperty
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        DAFTAR_TAMU.tamu.niktamuProperty = txtniktamuedit.Text.ToString()
        DAFTAR_TAMU.tamu.namatamuProperty = txtnamatamuedit.Text.ToString()
        DAFTAR_TAMU.tamu.alamattamuProperty = rtbalamattamuedit.Text.ToString()
        DAFTAR_TAMU.tamu.jeniskelamintamuProperty = cbjeniskelamintamuedit.SelectedItem().ToString()

        'DAFTAR_TAMU.tamu.addtamu(txtnamatamuedit.Text.ToString())


        DAFTAR_TAMU.tamu.UpdateDataTamuByIDDatabase(DAFTAR_TAMU.selectedtabletamu,
                                                            DAFTAR_TAMU.tamu.niktamuProperty,
                                                            DAFTAR_TAMU.tamu.namatamuProperty,
                                                            DAFTAR_TAMU.tamu.alamattamuProperty,
                                                            DAFTAR_TAMU.tamu.jeniskelamintamuProperty)


        DAFTAR_TAMU.Show()
        Me.Close()
    End Sub

    Private Sub txtniktamuedit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtniktamuedit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Mohon Hanya mengisikan Angka!!!")
        End If
    End Sub

    Private Sub txtnamatamuedit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnamatamuedit.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukkan text")
        End If
    End Sub

    Private Sub rtbalamattamuedit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbalamattamuedit.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukkan text")
        End If
    End Sub



    'Public Function EncryptMD5(ByVal password As String)
    'Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
    'Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
    '   bs = x.ComputeHash(bs)
    'Dim s As New System.Text.StringBuilder()

    'For Each b As Byte In bs
    '       s.Append(b.ToString("x2").ToLower())
    'Next
    'Return s.ToString()
    'End Function

End Class