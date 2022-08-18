Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles displayPictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles teslaButton1.Click
        displayPictureBox1.Image = TeslaPictureBox1.Image
        nameLabel1.Text = "Tesla Model S Plaid"
        specsLabel3.Text = "1,020 Horsepower, 0-60 1.99 Seconds"
        priceLabel3.Text = "$127,590 - $158,440"
        topspeedLabel1.Text = "200 MPH"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles porscheButton2.Click
        displayPictureBox1.Image = porschePictureBox1.Image
        nameLabel1.Text = "Porsche 911 Turrbo S Cabriolet"
        specsLabel3.Text = "640 Horsepower, 0-60 2.2 Seconds"
        priceLabel3.Text = "$228,900 - $238,200"
        topspeedLabel1.Text = "204 MPH"
    End Sub

    Private Sub TeslaPictureBox1_Click(sender As Object, e As EventArgs) Handles TeslaPictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles nameLabel1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub huracanButton1_Click(sender As Object, e As EventArgs) Handles huracanButton1.Click
        displayPictureBox1.Image = huracanPictureBox1.Image
        nameLabel1.Text = "Lamborghini Huracan Evo Spyder"
        specsLabel3.Text = "630 Horsepower, 0-60 2.7 Seconds"
        priceLabel3.Text = "$230,266"
        topspeedLabel1.Text = "202 MPH"
    End Sub

    Private Sub roadsterButton1_Click(sender As Object, e As EventArgs) Handles roadsterButton1.Click
        displayPictureBox1.Image = roadsterPictureBox2.Image
        nameLabel1.Text = "Tesla Roadster 2.0"
        specsLabel3.Text = "1,020 Horsepower 0-60 1.9 Seconds"
        priceLabel3.Text = "$200,000-$250,000"
        topspeedLabel1.Text = "205 MPH"
    End Sub

    Private Sub specsLabel3_Click(sender As Object, e As EventArgs) Handles specsLabel3.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles topspeedLabel1.Click

    End Sub

    Private Sub mercedesButton1_Click(sender As Object, e As EventArgs) Handles mercedesButton1.Click
        displayPictureBox1.Image = amgPictureBox1.Image
        nameLabel1.Text = "Mercedes Benz AMG Sl 63 Roadster"
        specsLabel3.Text = "577 Horsepower 0-60 3.3 Seconds"
        priceLabel3.Text = "$179,000 - $185,000"
        topspeedLabel1.Text = "193 MPH"
    End Sub
End Class

