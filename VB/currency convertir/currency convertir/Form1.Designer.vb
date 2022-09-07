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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(655, 221)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 51)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(456, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount ($)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1244, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Translate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        'Me.PictureBox1.Image = Global.currency_convertir.My.Resources.Resources.Flag_of_Europe_svg
        'Me.PictureBox1.Location = New System.Drawing.Point(243, 530)
        'Me.PictureBox1.Name = "PictureBox1"
        'Me.PictureBox1.Size = New System.Drawing.Size(149, 111)
        'Me.PictureBox1.TabIndex = 4
        'Me.PictureBox1.TabStop = False
        ''
        ''PictureBox2
        ''
        'Me.PictureBox2.Image = Global.currency_convertir.My.Resources.Resources._1200px_Flag_of_Ghana_svg
        'Me.PictureBox2.Location = New System.Drawing.Point(28, 530)
        'Me.PictureBox2.Name = "PictureBox2"
        'Me.PictureBox2.Size = New System.Drawing.Size(154, 111)
        'Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        'Me.PictureBox2.TabIndex = 5
        'Me.PictureBox2.TabStop = False
        ''
        ''PictureBox3
        ''
        'Me.PictureBox3.Location = New System.Drawing.Point(634, 530)
        'Me.PictureBox3.Name = "PictureBox3"
        'Me.PictureBox3.Size = New System.Drawing.Size(168, 111)
        'Me.PictureBox3.TabIndex = 6
        'Me.PictureBox3.TabStop = False
        ''
        ''PictureBox4
        ''
        'Me.PictureBox4.Location = New System.Drawing.Point(426, 530)
        'Me.PictureBox4.Name = "PictureBox4"
        'Me.PictureBox4.Size = New System.Drawing.Size(154, 111)
        'Me.PictureBox4.TabIndex = 7
        'Me.PictureBox4.TabStop = False
        ''
        ''PictureBox5
        ''
        'Me.PictureBox5.Location = New System.Drawing.Point(845, 530)
        'Me.PictureBox5.Name = "PictureBox5"
        'Me.PictureBox5.Size = New System.Drawing.Size(171, 111)
        'Me.PictureBox5.TabIndex = 8
        'Me.PictureBox5.TabStop = False
        ''
        ''PictureBox6
        ''
        'Me.PictureBox6.Location = New System.Drawing.Point(1096, 530)
        'Me.PictureBox6.Name = "PictureBox6"
        'Me.PictureBox6.Size = New System.Drawing.Size(171, 111)
        'Me.PictureBox6.TabIndex = 9
        'Me.PictureBox6.TabStop = False
        ''
        ''Button2
        ''
        'Me.Button2.Location = New System.Drawing.Point(28, 457)
        'Me.Button2.Name = "Button2"
        'Me.Button2.Size = New System.Drawing.Size(75, 23)
        'Me.Button2.TabIndex = 10
        'Me.Button2.Text = "Button2"
        'Me.Button2.UseVisualStyleBackColor = True
        ''
        ''Button3
        ''
        'Me.Button3.Location = New System.Drawing.Point(243, 486)
        'Me.Button3.Name = "Button3"
        'Me.Button3.Size = New System.Drawing.Size(75, 23)
        'Me.Button3.TabIndex = 11
        'Me.Button3.Text = "Button3"
        'Me.Button3.UseVisualStyleBackColor = True
        ''
        ''Button4
        ''
        'Me.Button4.Location = New System.Drawing.Point(426, 486)
        'Me.Button4.Name = "Button4"
        'Me.Button4.Size = New System.Drawing.Size(75, 23)
        'Me.Button4.TabIndex = 12
        'Me.Button4.Text = "Button4"
        'Me.Button4.UseVisualStyleBackColor = True
        ''
        ''Button5
        ''
        'Me.Button5.Location = New System.Drawing.Point(634, 486)
        'Me.Button5.Name = "Button5"
        'Me.Button5.Size = New System.Drawing.Size(75, 23)
        'Me.Button5.TabIndex = 13
        'Me.Button5.Text = "Button5"
        'Me.Button5.UseVisualStyleBackColor = True
        ''
        ''Button6
        ''
        'Me.Button6.Location = New System.Drawing.Point(845, 477)
        'Me.Button6.Name = "Button6"
        'Me.Button6.Size = New System.Drawing.Size(75, 23)
        'Me.Button6.TabIndex = 14
        'Me.Button6.Text = "Button6"
        'Me.Button6.UseVisualStyleBackColor = True
        ''
        ''Button7
        ''
        'Me.Button7.Location = New System.Drawing.Point(1096, 477)
        'Me.Button7.Name = "Button7"
        'Me.Button7.Size = New System.Drawing.Size(75, 23)
        'Me.Button7.TabIndex = 15
        'Me.Button7.Text = "Button7"
        'Me.Button7.UseVisualStyleBackColor = True
        ''
        ''Form1
        ''
        'Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.ClientSize = New System.Drawing.Size(1528, 776)
        'Me.Controls.Add(Me.Button7)
        'Me.Controls.Add(Me.Button6)
        'Me.Controls.Add(Me.Button5)
        'Me.Controls.Add(Me.Button4)
        'Me.Controls.Add(Me.Button3)
        'Me.Controls.Add(Me.Button2)
        'Me.Controls.Add(Me.PictureBox6)
        'Me.Controls.Add(Me.PictureBox5)
        'Me.Controls.Add(Me.PictureBox4)
        'Me.Controls.Add(Me.PictureBox3)
        'Me.Controls.Add(Me.PictureBox2)
        'Me.Controls.Add(Me.PictureBox1)
        'Me.Controls.Add(Me.Button1)
        'Me.Controls.Add(Me.Label2)
        'Me.Controls.Add(Me.Label1)
        'Me.Controls.Add(Me.TextBox1)
        'Me.Name = "Form1"
        'Me.Text = "Form1"
        'CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
