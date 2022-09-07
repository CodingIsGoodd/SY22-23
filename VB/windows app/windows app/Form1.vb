Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buyButton1_Click(sender As Object, e As EventArgs) Handles buyButton1.Click
        Dim amount As Decimal
        Decimal.TryParse(amountTextBox5.Text, amount)
        Dim fees As Decimal
        fees = amount * 0.03
        nameTextBox1.Clear()
        ccTextBox2.Clear()
        expdateTextBox3.Clear()
        zipTextBox4.Clear()
        amountTextBox5.Clear()
        feeTextBox1.Clear()
        feeTextBox1.Text = fees
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
