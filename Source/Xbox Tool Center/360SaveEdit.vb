Public Class _360SaveEdit

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Process.Start("Data\360\Saves\Editors\Call of Duty Classic TU2\COD-ClassicTrainer.exe")
        Catch ex As Exception
            MsgBox("Der Trainer wurde nicht gefunden!")
        End Try
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Try
            Process.Start("Data\360\Saves\Editors\Assassins Creed 2\AC2_SaveEdit.exe")
        Catch ex As Exception
            MsgBox("Der Trainer wurde nicht gefunden!")
        End Try
    End Sub
End Class