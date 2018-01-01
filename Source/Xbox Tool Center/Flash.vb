Public Class Flash

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Process.Start("Data\360\Flash\BootUSB\BootUSB.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Process.Start("Data\360\Flash\BootUSB\USBHacker.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Process.Start("Data\360\Flash\DVDKey32\DVDKey32.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Process.Start("Data\360\Flash\e-Tool_Win\e-Tool_Win\extrkey.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Process.Start("Data\360\Extras\CFWDownloader\CFWDownloader.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Process.Start("Data\360\QuickBOOT\QuickBoot.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Process.Start("Data\360\USBEditer\360Tools\360Tools.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("Data\360\Flash\FlashTool\360Flasher.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start("Data\360\Flash\JTAG\Jtag Tool.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start("Data\360\Flash\JungleFlasher\JungleFlasher.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Process.Start("Data\360\Flash\J-RUNNER\JRunner.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Process.Start("Data\360\Flash\XeBuild\external tools\xeBuild GUI XML Editor.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Process.Start("Data\360\Flash\XeBuild\xeBuildGUI.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden und kann deshalb nicht getsartet werden.")
        End Try
    End Sub
End Class