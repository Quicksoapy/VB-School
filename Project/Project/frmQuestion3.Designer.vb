<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion3))
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.21!)
        Me.lblQuestion3.Location = New System.Drawing.Point(4, 9)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(499, 39)
        Me.lblQuestion3.TabIndex = 0
        Me.lblQuestion3.Text = "Convert 1011010110 to decimal"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(11, 87)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(482, 22)
        Me.txtAnswer.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back to start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(179, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 51)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Empty field"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(347, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 51)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Answer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmQuestion3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(506, 223)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion3"
        Me.Text = "Question 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
