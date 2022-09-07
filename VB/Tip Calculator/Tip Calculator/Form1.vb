Public Class Form1
    Private Sub tentipButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tenRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles tenRadioButton1.CheckedChanged, fifteenRadioButton2.CheckedChanged, twentyRadioButton3.CheckedChanged, twentyfiveRadioButton4.CheckedChanged
        Dim tip As Decimal

        If tenRadioButton1.Checked Then
            tip = 1.1 '10 percent 
        End If
        If fifteenRadioButton2.Checked Then
            tip = 1.15 '15 percent
        End If
        If twentyRadioButton3.Checked Then
            tip = 1.2 '20 percent 
        End If
        If twentyfiveRadioButton4.Checked Then
            tip = 1.25 '25 percent
        End If
        'Get the amount of the bill
        Dim amount As Decimal
        Decimal.TryParse(mealcostTextBox3.Text, amount) ' get the amount from the mealcostTextBox3 and put it in totalTextBox1
        'Now calculate the tip using the radio buttons 
        Dim total As Decimal
        total = amount * tip
        'Show the total in the food total textbox
        totalTextBox1.Text = total.ToString("C2")

    End Sub

    Private Sub totalTextBox3_TextChanged(sender As Object, e As EventArgs) Handles mealcostTextBox3.TextChanged


    End Sub
End Class
