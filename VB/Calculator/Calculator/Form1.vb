Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim opper As String
    Dim mem As Decimal
    Private Sub displayTextBox1_TextChanged(sender As Object, e As EventArgs) Handles displayTextBox1.TextChanged
    End Sub

    Private Sub equalsButton17_Click(sender As Object, e As EventArgs) Handles b9Button12.Click, b8Button5.Click, b7Button4.Click, b6Button11.Click, b5Button6.Click, b4Button3.Click, b3Button10.Click, b2Button7.Click, b1Button2.Click, b0Button1.Click
        displayTextBox1.Text = displayTextBox1.Text + sender.text
    End Sub

    Private Sub clearButton9_Click(sender As Object, e As EventArgs) Handles clearButton9.Click
        displayTextBox1.Clear()
    End Sub

    Private Sub plusButton16_Click(sender As Object, e As EventArgs) Handles plusButton16.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        opper = sender.text
        displayTextBox1.Clear()
    End Sub

    Private Sub equalsButton17_Click_1(sender As Object, e As EventArgs) Handles equalsButton17.Click
        Decimal.TryParse(displayTextBox1.Text, second)
        If opper = "+" Then
            displayTextBox1.Text = first + second
        ElseIf opper = "-" Then
            displayTextBox1.Text = first - second
        ElseIf opper = "X" Then
            displayTextBox1.Text = Decimal.Multiply(first, second)
        ElseIf opper = "/" Then
            displayTextBox1.Text = first / second
        End If


    End Sub

    Private Sub minusButton15_Click(sender As Object, e As EventArgs) Handles minusButton15.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        opper = sender.text
        displayTextBox1.Clear()
    End Sub

    Private Sub multiplyButton14_Click(sender As Object, e As EventArgs) Handles multiplyButton14.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        opper = sender.text
        displayTextBox1.Clear()
    End Sub

    Private Sub divideButton13_Click(sender As Object, e As EventArgs) Handles divideButton13.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        opper = sender.text
        displayTextBox1.Clear()
    End Sub

    Private Sub squareootButton1_Click(sender As Object, e As EventArgs) Handles squareootButton1.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        displayTextBox1.Text = Math.Sqrt(first)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SINButton1_Click(sender As Object, e As EventArgs) Handles SINButton1.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        displayTextBox1.Text = Math.Sin(first)
    End Sub

    Private Sub cosButton3_Click(sender As Object, e As EventArgs) Handles cosButton3.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        displayTextBox1.Text = Math.Cos(first)

    End Sub

    Private Sub tanButton2_Click(sender As Object, e As EventArgs) Handles tanButton2.Click
        Decimal.TryParse(displayTextBox1.Text, first)
        displayTextBox1.Text = Math.Tan(first)


    End Sub

    Private Sub piButton1_Click(sender As Object, e As EventArgs) Handles piButton1.Click
        displayTextBox1.Text = Math.PI
    End Sub

    Private Sub mplusButton3_Click(sender As Object, e As EventArgs) Handles mplusButton3.Click
        Decimal.TryParse(displayTextBox1.Text, mem)
    End Sub

    Private Sub mcButton1_Click(sender As Object, e As EventArgs) Handles mcButton1.Click
        mem = 0
    End Sub

    Private Sub MRbutton2_Click(sender As Object, e As EventArgs) Handles MRbutton2.Click
        displayTextBox1.Text = mem
    End Sub
End Class
