<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tiplabel2 = New System.Windows.Forms.Label()
        Me.mealcostTextBox3 = New System.Windows.Forms.TextBox()
        Me.totalTextBox1 = New System.Windows.Forms.TextBox()
        Me.totalLabel2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tenRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.fifteenRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.twentyRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.twentyfiveRadioButton4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'tiplabel2
        '
        Me.tiplabel2.AutoSize = True
        Me.tiplabel2.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiplabel2.Location = New System.Drawing.Point(300, 118)
        Me.tiplabel2.Name = "tiplabel2"
        Me.tiplabel2.Size = New System.Drawing.Size(58, 38)
        Me.tiplabel2.TabIndex = 3
        Me.tiplabel2.Text = "Tip"
        '
        'mealcostTextBox3
        '
        Me.mealcostTextBox3.Location = New System.Drawing.Point(649, 38)
        Me.mealcostTextBox3.Multiline = True
        Me.mealcostTextBox3.Name = "mealcostTextBox3"
        Me.mealcostTextBox3.Size = New System.Drawing.Size(214, 31)
        Me.mealcostTextBox3.TabIndex = 7
        '
        'totalTextBox1
        '
        Me.totalTextBox1.Location = New System.Drawing.Point(601, 328)
        Me.totalTextBox1.Multiline = True
        Me.totalTextBox1.Name = "totalTextBox1"
        Me.totalTextBox1.Size = New System.Drawing.Size(391, 54)
        Me.totalTextBox1.TabIndex = 11
        '
        'totalLabel2
        '
        Me.totalLabel2.AutoSize = True
        Me.totalLabel2.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel2.Location = New System.Drawing.Point(340, 328)
        Me.totalLabel2.Name = "totalLabel2"
        Me.totalLabel2.Size = New System.Drawing.Size(220, 54)
        Me.totalLabel2.TabIndex = 12
        Me.totalLabel2.Text = "Food Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Meal Cost"
        '
        'tenRadioButton1
        '
        Me.tenRadioButton1.AutoSize = True
        Me.tenRadioButton1.Location = New System.Drawing.Point(432, 133)
        Me.tenRadioButton1.Name = "tenRadioButton1"
        Me.tenRadioButton1.Size = New System.Drawing.Size(54, 20)
        Me.tenRadioButton1.TabIndex = 14
        Me.tenRadioButton1.TabStop = True
        Me.tenRadioButton1.Text = "10%"
        Me.tenRadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tenRadioButton1.UseVisualStyleBackColor = True
        '
        'fifteenRadioButton2
        '
        Me.fifteenRadioButton2.AutoSize = True
        Me.fifteenRadioButton2.Location = New System.Drawing.Point(601, 133)
        Me.fifteenRadioButton2.Name = "fifteenRadioButton2"
        Me.fifteenRadioButton2.Size = New System.Drawing.Size(54, 20)
        Me.fifteenRadioButton2.TabIndex = 15
        Me.fifteenRadioButton2.TabStop = True
        Me.fifteenRadioButton2.Text = "15%"
        Me.fifteenRadioButton2.UseVisualStyleBackColor = True
        '
        'twentyRadioButton3
        '
        Me.twentyRadioButton3.AutoSize = True
        Me.twentyRadioButton3.Location = New System.Drawing.Point(779, 133)
        Me.twentyRadioButton3.Name = "twentyRadioButton3"
        Me.twentyRadioButton3.Size = New System.Drawing.Size(54, 20)
        Me.twentyRadioButton3.TabIndex = 16
        Me.twentyRadioButton3.TabStop = True
        Me.twentyRadioButton3.Text = "20%"
        Me.twentyRadioButton3.UseVisualStyleBackColor = True
        '
        'twentyfiveRadioButton4
        '
        Me.twentyfiveRadioButton4.AutoSize = True
        Me.twentyfiveRadioButton4.Location = New System.Drawing.Point(927, 133)
        Me.twentyfiveRadioButton4.Name = "twentyfiveRadioButton4"
        Me.twentyfiveRadioButton4.Size = New System.Drawing.Size(54, 20)
        Me.twentyfiveRadioButton4.TabIndex = 17
        Me.twentyfiveRadioButton4.TabStop = True
        Me.twentyfiveRadioButton4.Text = "25%"
        Me.twentyfiveRadioButton4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1674, 450)
        Me.Controls.Add(Me.twentyfiveRadioButton4)
        Me.Controls.Add(Me.twentyRadioButton3)
        Me.Controls.Add(Me.fifteenRadioButton2)
        Me.Controls.Add(Me.tenRadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.totalLabel2)
        Me.Controls.Add(Me.totalTextBox1)
        Me.Controls.Add(Me.mealcostTextBox3)
        Me.Controls.Add(Me.tiplabel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tiplabel2 As Label
    Friend WithEvents mealcostTextBox3 As TextBox
    Friend WithEvents totalTextBox1 As TextBox
    Friend WithEvents totalLabel2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tenRadioButton1 As RadioButton
    Friend WithEvents fifteenRadioButton2 As RadioButton
    Friend WithEvents twentyRadioButton3 As RadioButton
    Friend WithEvents twentyfiveRadioButton4 As RadioButton
End Class
