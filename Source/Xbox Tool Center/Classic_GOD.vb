Public Class Classic_GOD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start("Data\Classic\Qwix\Qwix.exe")
        Catch ex As Exception
            MsgBox("Die angeforderte Datei konnte nicht gefunden werden. Eventuell verhindert ein Antiv Viren Programm den start.")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Process.Start("Data\Classic\GOD\GOD2XB1\God2XB1.exe")
        Catch ex As Exception
            MsgBox("Die angeforderte Datei konnte nicht gefunden werden. Eventuell verhindert ein Antiv Viren Programm den start.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start("Data\Classic\GOD\ISO2GOD\iso2god_v1.3.6-360h\Iso2God.exe")
        Catch ex As Exception
            MsgBox("Die angeforderte Datei konnte nicht gefunden werden. Eventuell verhindert ein Antiv Viren Programm den start.")
        End Try
    End Sub
End Class