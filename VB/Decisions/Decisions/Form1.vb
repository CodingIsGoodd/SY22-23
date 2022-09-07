Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Integer.TryParse(TextBox1.Text, age)
        Label1.Text = age
        If age > 17 Then
            Label1.Text = "You can vote"
        Else Label1.Text = "You can vote"
            Me.BackColor = Color.Red
        End If
        If CheckBox1.Checked Then
            Me.BackColor = Color.Aqua
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
