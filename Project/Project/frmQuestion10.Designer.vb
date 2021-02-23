<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion10))
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.btnBacktostart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picQuestion6 = New System.Windows.Forms.PictureBox()
        CType(Me.picQuestion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnswer3
        '
        Me.btnAnswer3.Location = New System.Drawing.Point(351, 360)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(113, 62)
        Me.btnAnswer3.TabIndex = 34
        Me.btnAnswer3.Text = "It's cheaper than alternatives"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.Location = New System.Drawing.Point(237, 360)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(113, 62)
        Me.btnAnswer2.TabIndex = 33
        Me.btnAnswer2.Text = "There's no warmup time"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(124, 360)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(113, 62)
        Me.btnAnswer.TabIndex = 32
        Me.btnAnswer.Text = "It's faster than alternatives"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'btnBacktostart
        '
        Me.btnBacktostart.Location = New System.Drawing.Point(11, 360)
        Me.btnBacktostart.Name = "btnBacktostart"
        Me.btnBacktostart.Size = New System.Drawing.Size(113, 62)
        Me.btnBacktostart.TabIndex = 31
        Me.btnBacktostart.Text = "Back to start"
        Me.btnBacktostart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(70, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "What is a positive about laserprinters?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picQuestion6
        '
        Me.picQuestion6.BackColor = System.Drawing.Color.Transparent
        Me.picQuestion6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picQuestion6.Image = Global.Project.My.Resources.Resources.ezgif_1_02cfb6a17c42
        Me.picQuestion6.Location = New System.Drawing.Point(12, 12)
        Me.picQuestion6.Name = "picQuestion6"
        Me.picQuestion6.Size = New System.Drawing.Size(452, 304)
        Me.picQuestion6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQuestion6.TabIndex = 29
        Me.picQuestion6.TabStop = False
        '
        'frmQuestion10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(480, 450)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnBacktostart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picQuestion6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion10"
        Me.Text = "Question 10"
        CType(Me.picQuestion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAnswer3 As Button
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents btnAnswer As Button
    Friend WithEvents btnBacktostart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents picQuestion6 As PictureBox
End Class
