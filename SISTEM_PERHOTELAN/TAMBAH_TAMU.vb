Public Class TAMBAH_TAMU

    'pengaturan Keypress
    Private Sub txtniktamu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtniktamu.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Mohon Hanya mengisikan Angka!!!")
        End If
    End Sub

    Private Sub txtnamatamu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnamatamu.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukkan text")
        End If
    End Sub

    Private Sub rtbalamattamu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbalamattamu.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukkan text")
        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        DAFTAR_TAMU.tamu.niktamuProperty = txtniktamu.Text.ToString()
        DAFTAR_TAMU.tamu.namatamuProperty = txtnamatamu.Text.ToString()
        DAFTAR_TAMU.tamu.alamattamuProperty = rtbalamattamu.Text.ToString()
        DAFTAR_TAMU.tamu.jeniskelamintamuProperty = cbjeniskelamintamu.Text.ToString()


        DAFTAR_TAMU.tamu.AddDataTamuDatabase(DAFTAR_TAMU.tamu.niktamuProperty,
                                                DAFTAR_TAMU.tamu.namatamuProperty,
                                                DAFTAR_TAMU.tamu.alamattamuProperty,
                                                DAFTAR_TAMU.tamu.jeniskelamintamuProperty)

        Dim form_daftar_tamu = New DAFTAR_TAMU
        form_daftar_tamu.Show()

        Me.Close()
    End Sub
End Class