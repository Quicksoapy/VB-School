<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion1))
        Me.picMotherboard = New System.Windows.Forms.PictureBox()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btnBacktostart = New System.Windows.Forms.Button()
        CType(Me.picMotherboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMotherboard
        '
        Me.picMotherboard.Image = Global.Project.My.Resources.Resources.Inkedmsi_b450m_mortar_led_mask__1__LI
        Me.picMotherboard.Location = New System.Drawing.Point(12, 12)
        Me.picMotherboard.Name = "picMotherboard"
        Me.picMotherboard.Size = New System.Drawing.Size(508, 427)
        Me.picMotherboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMotherboard.TabIndex = 0
        Me.picMotherboard.TabStop = False
        '
        'lblQuestion1
        '
        Me.lblQuestion1.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.11!)
        Me.lblQuestion1.ForeColor = System.Drawing.Color.White
        Me.lblQuestion1.Location = New System.Drawing.Point(12, 442)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(508, 23)
        Me.lblQuestion1.TabIndex = 1
        Me.lblQuestion1.Text = "Which part is the chipset?"
        Me.lblQuestion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 468)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 49)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(117, 468)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(100, 49)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(222, 468)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(100, 49)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(327, 468)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(100, 49)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(432, 468)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(100, 49)
        Me.btn5.TabIndex = 6
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btnBacktostart
        '
        Me.btnBacktostart.Location = New System.Drawing.Point(222, 523)
        Me.btnBacktostart.Name = "btnBacktostart"
        Me.btnBacktostart.Size = New System.Drawing.Size(100, 28)
        Me.btnBacktostart.TabIndex = 7
        Me.btnBacktostart.Text = "Back to start"
        Me.btnBacktostart.UseVisualStyleBackColor = True
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(544, 555)
        Me.Controls.Add(Me.btnBacktostart)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.picMotherboard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion1"
        Me.Text = "Question 1"
        CType(Me.picMotherboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picMotherboard As PictureBox
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btnBacktostart As Button
End Class
