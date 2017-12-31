Public Class Main

    Private Sub XboxClassicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XboxClassicToolStripMenuItem.Click
        Classic_GOD.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Process.Start("Data\Classic\Qwix\Qwix.exe")
        Catch ex As Exception
            MsgBox("Die angeforderte Datei konnte nicht gefunden werden. Eventuell verhindert ein Antiv Viren Programm den start.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Classic_GOD.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start("Data\360\ImageBrowser\Xbox Image Browser.exe")
        Catch ex As Exception
            MsgBox("Die angeforderte Datei konnte nicht gefunden werden. Eventuell verhindert ein Antiv Viren Programm den start.")
        End Try
    End Sub

    Private Sub ImageBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageBrowserToolStripMenuItem.Click
        Try
            Process.Start("Data\360\ImageBrowser\Xbox Image Browser.exe")
        Catch ex As Exception
            MsgBox("Die angeforderte Datei konnte nicht gefunden werden. Eventuell verhindert ein Antiv Viren Programm den start.")
        End Try
    End Sub
End Class
