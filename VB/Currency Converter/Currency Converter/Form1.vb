Public Class Form1
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles euPictureBox6.Click

    End Sub

    Private Sub usdTextBox1_TextChanged(sender As Object, e As EventArgs) Handles usdTextBox1.TextChanged
        Dim Dollars As Decimal
        Decimal.TryParse(usdTextBox1.Text, Dollars)
        Dim Cedi As Decimal
        Cedi = Dollars * 9.98
        ghanaTextBox2.Text = Cedi.ToString
        Dim USD As Decimal
        USD = Dollars * 1
        Decimal.TryParse(usdTextBox1.Text, Dollars)
        Dim CAD As Decimal
        CAD = Dollars * 1.3
        canadaTextBox3.Text = CAD.ToString
        Dim Dollar As Decimal
        Decimal.TryParse(usdTextBox1.Text, Dollars)
        Dim PoundSterling As Decimal
        PoundSterling = Dollars * 0.85
        ukTextBox4.Text = PoundSterling.ToString
        Decimal.TryParse(usdTextBox1.Text, Dollars)
        Dim SouthAfricanRand As Decimal
        SouthAfricanRand = Dollar * 16.85
        southafricaTextBox5.Text = Dollars * 16.85
        Decimal.TryParse(usdTextBox1.Text, Dollars)
        Dim AUD As Decimal
        AUD = Dollar * 1.45
        australiaTextBox6.Text = Dollars * 1.45
        Decimal.TryParse(usdTextBox1.Text, Dollars)
        Dim Euro As Decimal
        Euro = Dollar * 1
        euTextBox7.Text = Dollars * 1


    End Sub
End Class
