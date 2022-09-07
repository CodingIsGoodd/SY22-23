<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.nameLabel1 = New System.Windows.Forms.Label()
        Me.ccLabel2 = New System.Windows.Forms.Label()
        Me.expdateLabel3 = New System.Windows.Forms.Label()
        Me.amountLabel4 = New System.Windows.Forms.Label()
        Me.zipLabel5 = New System.Windows.Forms.Label()
        Me.nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.ccTextBox2 = New System.Windows.Forms.TextBox()
        Me.expdateTextBox3 = New System.Windows.Forms.TextBox()
        Me.zipTextBox4 = New System.Windows.Forms.TextBox()
        Me.amountTextBox5 = New System.Windows.Forms.TextBox()
        Me.buyButton1 = New System.Windows.Forms.Button()
        Me.cancelButton2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.feeLabel1 = New System.Windows.Forms.Label()
        Me.feeTextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'nameLabel1
        '
        Me.nameLabel1.AutoSize = True
        Me.nameLabel1.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel1.Location = New System.Drawing.Point(32, 54)
        Me.nameLabel1.Name = "nameLabel1"
        Me.nameLabel1.Size = New System.Drawing.Size(108, 74)
        Me.nameLabel1.TabIndex = 0
        Me.nameLabel1.Text = "Name"
        '
        'ccLabel2
        '
        Me.ccLabel2.AutoSize = True
        Me.ccLabel2.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccLabel2.Location = New System.Drawing.Point(32, 128)
        Me.ccLabel2.Name = "ccLabel2"
        Me.ccLabel2.Size = New System.Drawing.Size(97, 74)
        Me.ccLabel2.TabIndex = 1
        Me.ccLabel2.Text = "CC #"
        '
        'expdateLabel3
        '
        Me.expdateLabel3.AutoSize = True
        Me.expdateLabel3.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expdateLabel3.Location = New System.Drawing.Point(27, 197)
        Me.expdateLabel3.Name = "expdateLabel3"
        Me.expdateLabel3.Size = New System.Drawing.Size(153, 74)
        Me.expdateLabel3.TabIndex = 2
        Me.expdateLabel3.Text = "Exp Date"
        '
        'amountLabel4
        '
        Me.amountLabel4.AutoSize = True
        Me.amountLabel4.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountLabel4.Location = New System.Drawing.Point(31, 334)
        Me.amountLabel4.Name = "amountLabel4"
        Me.amountLabel4.Size = New System.Drawing.Size(141, 74)
        Me.amountLabel4.TabIndex = 3
        Me.amountLabel4.Text = "Amount"
        '
        'zipLabel5
        '
        Me.zipLabel5.AutoSize = True
        Me.zipLabel5.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipLabel5.Location = New System.Drawing.Point(31, 265)
        Me.zipLabel5.Name = "zipLabel5"
        Me.zipLabel5.Size = New System.Drawing.Size(78, 74)
        Me.zipLabel5.TabIndex = 4
        Me.zipLabel5.Text = "Zip"
        '
        'nameTextBox1
        '
        Me.nameTextBox1.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox1.Location = New System.Drawing.Point(150, 55)
        Me.nameTextBox1.Multiline = True
        Me.nameTextBox1.Name = "nameTextBox1"
        Me.nameTextBox1.Size = New System.Drawing.Size(182, 54)
        Me.nameTextBox1.TabIndex = 5
        '
        'ccTextBox2
        '
        Me.ccTextBox2.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccTextBox2.Location = New System.Drawing.Point(150, 128)
        Me.ccTextBox2.Multiline = True
        Me.ccTextBox2.Name = "ccTextBox2"
        Me.ccTextBox2.Size = New System.Drawing.Size(182, 58)
        Me.ccTextBox2.TabIndex = 6
        '
        'expdateTextBox3
        '
        Me.expdateTextBox3.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expdateTextBox3.Location = New System.Drawing.Point(173, 208)
        Me.expdateTextBox3.Multiline = True
        Me.expdateTextBox3.Name = "expdateTextBox3"
        Me.expdateTextBox3.Size = New System.Drawing.Size(182, 49)
        Me.expdateTextBox3.TabIndex = 7
        '
        'zipTextBox4
        '
        Me.zipTextBox4.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipTextBox4.Location = New System.Drawing.Point(150, 285)
        Me.zipTextBox4.Multiline = True
        Me.zipTextBox4.Name = "zipTextBox4"
        Me.zipTextBox4.Size = New System.Drawing.Size(182, 46)
        Me.zipTextBox4.TabIndex = 8
        '
        'amountTextBox5
        '
        Me.amountTextBox5.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountTextBox5.Location = New System.Drawing.Point(173, 356)
        Me.amountTextBox5.Multiline = True
        Me.amountTextBox5.Name = "amountTextBox5"
        Me.amountTextBox5.Size = New System.Drawing.Size(182, 52)
        Me.amountTextBox5.TabIndex = 9
        '
        'buyButton1
        '
        Me.buyButton1.Location = New System.Drawing.Point(678, 519)
        Me.buyButton1.Name = "buyButton1"
        Me.buyButton1.Size = New System.Drawing.Size(163, 62)
        Me.buyButton1.TabIndex = 10
        Me.buyButton1.Text = "Buy"
        Me.buyButton1.UseVisualStyleBackColor = True
        '
        'cancelButton2
        '
        Me.cancelButton2.Location = New System.Drawing.Point(911, 519)
        Me.cancelButton2.Name = "cancelButton2"
        Me.cancelButton2.Size = New System.Drawing.Size(185, 62)
        Me.cancelButton2.TabIndex = 11
        Me.cancelButton2.Text = "Cancel"
        Me.cancelButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1080, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(669, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'feeLabel1
        '
        Me.feeLabel1.AutoSize = True
        Me.feeLabel1.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeLabel1.Location = New System.Drawing.Point(40, 412)
        Me.feeLabel1.Name = "feeLabel1"
        Me.feeLabel1.Size = New System.Drawing.Size(73, 74)
        Me.feeLabel1.TabIndex = 14
        Me.feeLabel1.Text = "Fee"
        '
        'feeTextBox1
        '
        Me.feeTextBox1.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeTextBox1.Location = New System.Drawing.Point(120, 431)
        Me.feeTextBox1.Multiline = True
        Me.feeTextBox1.Name = "feeTextBox1"
        Me.feeTextBox1.Size = New System.Drawing.Size(235, 45)
        Me.feeTextBox1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 647)
        Me.Controls.Add(Me.feeTextBox1)
        Me.Controls.Add(Me.feeLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cancelButton2)
        Me.Controls.Add(Me.buyButton1)
        Me.Controls.Add(Me.amountTextBox5)
        Me.Controls.Add(Me.zipTextBox4)
        Me.Controls.Add(Me.expdateTextBox3)
        Me.Controls.Add(Me.ccTextBox2)
        Me.Controls.Add(Me.nameTextBox1)
        Me.Controls.Add(Me.zipLabel5)
        Me.Controls.Add(Me.amountLabel4)
        Me.Controls.Add(Me.expdateLabel3)
        Me.Controls.Add(Me.ccLabel2)
        Me.Controls.Add(Me.nameLabel1)
        Me.Font = New System.Drawing.Font("Gabriola", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "Form1"
        Me.Text = "myapp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel1 As Label
    Friend WithEvents ccLabel2 As Label
    Friend WithEvents expdateLabel3 As Label
    Friend WithEvents amountLabel4 As Label
    Friend WithEvents zipLabel5 As Label
    Friend WithEvents nameTextBox1 As TextBox
    Friend WithEvents ccTextBox2 As TextBox
    Friend WithEvents expdateTextBox3 As TextBox
    Friend WithEvents zipTextBox4 As TextBox
    Friend WithEvents amountTextBox5 As TextBox
    Friend WithEvents buyButton1 As Button
    Friend WithEvents cancelButton2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents feeLabel1 As Label
    Friend WithEvents feeTextBox1 As TextBox
End Class
