<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion2))
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.btnBacktostart = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.picGPU = New System.Windows.Forms.PictureBox()
        Me.picCPU = New System.Windows.Forms.PictureBox()
        Me.picRAM = New System.Windows.Forms.PictureBox()
        CType(Me.picGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.21!)
        Me.lblQuestion2.Location = New System.Drawing.Point(71, 9)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(422, 39)
        Me.lblQuestion2.TabIndex = 0
        Me.lblQuestion2.Text = "The ... goes into the socket"
        '
        'btnBacktostart
        '
        Me.btnBacktostart.Location = New System.Drawing.Point(232, 260)
        Me.btnBacktostart.Name = "btnBacktostart"
        Me.btnBacktostart.Size = New System.Drawing.Size(100, 28)
        Me.btnBacktostart.TabIndex = 8
        Me.btnBacktostart.Text = "Back to start"
        Me.btnBacktostart.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 65)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "RAM-stick"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 65)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CPU"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(391, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 65)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Graphics Card"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'picGPU
        '
        Me.picGPU.Image = Global.Project.My.Resources.Resources.Graphics_Card_PNG_Transparent_HD_Photo
        Me.picGPU.Location = New System.Drawing.Point(391, 61)
        Me.picGPU.Name = "picGPU"
        Me.picGPU.Size = New System.Drawing.Size(158, 122)
        Me.picGPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU.TabIndex = 14
        Me.picGPU.TabStop = False
        '
        'picCPU
        '
        Me.picCPU.Image = Global.Project.My.Resources.Resources.purepng_com_cpu_processorelectronicscpuprocessor_941524672527kysg5
        Me.picCPU.Location = New System.Drawing.Point(205, 61)
        Me.picCPU.Name = "picCPU"
        Me.picCPU.Size = New System.Drawing.Size(158, 122)
        Me.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCPU.TabIndex = 13
        Me.picCPU.TabStop = False
        '
        'picRAM
        '
        Me.picRAM.Image = Global.Project.My.Resources.Resources.purepng_com_ramelectronicsram_941524673871z6dnm
        Me.picRAM.Location = New System.Drawing.Point(16, 61)
        Me.picRAM.Name = "picRAM"
        Me.picRAM.Size = New System.Drawing.Size(158, 122)
        Me.picRAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRAM.TabIndex = 12
        Me.picRAM.TabStop = False
        '
        'frmQuestion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(565, 292)
        Me.Controls.Add(Me.picGPU)
        Me.Controls.Add(Me.picCPU)
        Me.Controls.Add(Me.picRAM)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBacktostart)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion2"
        Me.Text = "Question 2"
        CType(Me.picGPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents btnBacktostart As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents picRAM As PictureBox
    Friend WithEvents picCPU As PictureBox
    Friend WithEvents picGPU As PictureBox
End Class
