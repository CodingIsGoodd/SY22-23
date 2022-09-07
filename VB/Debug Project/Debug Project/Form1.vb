Public Class Form1
    Private Sub pictureLabel1_Click(sender As Object, e As EventArgs) Handles pictureLabel1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        pictureLabel1.Text = "lovers"
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        pictureLabel1.Text = "knitters in phoenix"
    End Sub
End Class
