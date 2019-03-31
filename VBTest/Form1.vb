Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = MessageBox.Show("are you Sure ??", "yes or no", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btncon_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numconvert As Integer = Integer.Parse(txtcon.Text)
        lblbin.Text = Convert.ToString(numconvert, 2)
        lblhex.Text = Convert.ToString(numconvert, 16)
        lbloct.Text = Convert.ToString(numconvert, 8)

    End Sub

End Class
