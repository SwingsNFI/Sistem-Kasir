Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles KarBut.Click
        Me.Hide()
        AdKaryawan.Show()
    End Sub

    Private Sub BarBut_Click(sender As Object, e As EventArgs) Handles BarBut.Click
        Me.Hide()
        AdBarang.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        TranAdmin.Show()
    End Sub

    Private Sub reportadmin_Click(sender As Object, e As EventArgs) Handles reportadmin.Click
        Me.Close()
        AllofReport.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MainForm.Show()
    End Sub
End Class