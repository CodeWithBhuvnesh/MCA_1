<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        AddBtn = New Button()
        MinBtn = New Button()
        MulBtn = New Button()
        DivBtn = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(158, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(98, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 1
        Label1.Text = "Value 1" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 3
        Label2.Text = "Value 2"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(158, 110)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(98, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 5
        Label3.Text = "Output"
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(158, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(98, 27)
        TextBox3.TabIndex = 4
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(34, 228)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(108, 96)
        AddBtn.TabIndex = 6
        AddBtn.Text = "+"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' MinBtn
        ' 
        MinBtn.Location = New Point(158, 228)
        MinBtn.Name = "MinBtn"
        MinBtn.Size = New Size(98, 96)
        MinBtn.TabIndex = 7
        MinBtn.Text = "-"
        MinBtn.UseVisualStyleBackColor = True
        ' 
        ' MulBtn
        ' 
        MulBtn.Location = New Point(34, 330)
        MulBtn.Name = "MulBtn"
        MulBtn.Size = New Size(108, 76)
        MulBtn.TabIndex = 8
        MulBtn.Text = "*"
        MulBtn.UseVisualStyleBackColor = True
        ' 
        ' DivBtn
        ' 
        DivBtn.Location = New Point(158, 330)
        DivBtn.Name = "DivBtn"
        DivBtn.Size = New Size(98, 76)
        DivBtn.TabIndex = 9
        DivBtn.Text = "/"
        DivBtn.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 433)
        Controls.Add(DivBtn)
        Controls.Add(MulBtn)
        Controls.Add(MinBtn)
        Controls.Add(AddBtn)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents MinBtn As Button
    Friend WithEvents MulBtn As Button
    Friend WithEvents DivBtn As Button
End Class
