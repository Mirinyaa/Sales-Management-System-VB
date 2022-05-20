<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FLogin))
        Me.BCANCEL = New System.Windows.Forms.Button()
        Me.BLOGIN = New System.Windows.Forms.Button()
        Me.TPASSWORD = New System.Windows.Forms.TextBox()
        Me.TUSERNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'BCANCEL
        '
        Me.BCANCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BCANCEL.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCANCEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BCANCEL.Location = New System.Drawing.Point(683, 484)
        Me.BCANCEL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BCANCEL.Name = "BCANCEL"
        Me.BCANCEL.Size = New System.Drawing.Size(109, 42)
        Me.BCANCEL.TabIndex = 17
        Me.BCANCEL.Text = "CANCEL"
        Me.BCANCEL.UseVisualStyleBackColor = False
        '
        'BLOGIN
        '
        Me.BLOGIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BLOGIN.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLOGIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BLOGIN.Location = New System.Drawing.Point(554, 484)
        Me.BLOGIN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BLOGIN.Name = "BLOGIN"
        Me.BLOGIN.Size = New System.Drawing.Size(111, 42)
        Me.BLOGIN.TabIndex = 16
        Me.BLOGIN.Text = "LOGIN"
        Me.BLOGIN.UseVisualStyleBackColor = False
        '
        'TPASSWORD
        '
        Me.TPASSWORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TPASSWORD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPASSWORD.Location = New System.Drawing.Point(583, 414)
        Me.TPASSWORD.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TPASSWORD.Name = "TPASSWORD"
        Me.TPASSWORD.Size = New System.Drawing.Size(209, 22)
        Me.TPASSWORD.TabIndex = 15
        Me.TPASSWORD.UseSystemPasswordChar = True
        '
        'TUSERNAME
        '
        Me.TUSERNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TUSERNAME.Location = New System.Drawing.Point(583, 348)
        Me.TUSERNAME.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TUSERNAME.Name = "TUSERNAME"
        Me.TUSERNAME.Size = New System.Drawing.Size(209, 22)
        Me.TUSERNAME.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(395, 414)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(395, 348)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "USERNAME"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(359, 309)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(571, 263)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1284, 600)
        Me.Controls.Add(Me.BCANCEL)
        Me.Controls.Add(Me.BLOGIN)
        Me.Controls.Add(Me.TPASSWORD)
        Me.Controls.Add(Me.TUSERNAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "FLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCANCEL As Button
    Friend WithEvents BLOGIN As Button
    Friend WithEvents TPASSWORD As TextBox
    Friend WithEvents TUSERNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
