<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion6))
        Me.btnFields = New System.Windows.Forms.Button()
        Me.btnSectors = New System.Windows.Forms.Button()
        Me.btnBacktostart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picQuestion6 = New System.Windows.Forms.PictureBox()
        CType(Me.picQuestion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFields
        '
        Me.btnFields.Location = New System.Drawing.Point(309, 373)
        Me.btnFields.Name = "btnFields"
        Me.btnFields.Size = New System.Drawing.Size(113, 39)
        Me.btnFields.TabIndex = 10
        Me.btnFields.Text = "Numpad"
        Me.btnFields.UseVisualStyleBackColor = True
        '
        'btnSectors
        '
        Me.btnSectors.Location = New System.Drawing.Point(196, 373)
        Me.btnSectors.Name = "btnSectors"
        Me.btnSectors.Size = New System.Drawing.Size(113, 39)
        Me.btnSectors.TabIndex = 9
        Me.btnSectors.Text = "Functionkeys"
        Me.btnSectors.UseVisualStyleBackColor = True
        '
        'btnBacktostart
        '
        Me.btnBacktostart.Location = New System.Drawing.Point(83, 373)
        Me.btnBacktostart.Name = "btnBacktostart"
        Me.btnBacktostart.Size = New System.Drawing.Size(113, 39)
        Me.btnBacktostart.TabIndex = 8
        Me.btnBacktostart.Text = "Back to start"
        Me.btnBacktostart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(80, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "What are these called?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picQuestion6
        '
        Me.picQuestion6.BackColor = System.Drawing.Color.Transparent
        Me.picQuestion6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picQuestion6.Image = Global.Project.My.Resources.Resources.KeyboardFnKeys
        Me.picQuestion6.Location = New System.Drawing.Point(22, 25)
        Me.picQuestion6.Name = "picQuestion6"
        Me.picQuestion6.Size = New System.Drawing.Size(452, 304)
        Me.picQuestion6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQuestion6.TabIndex = 6
        Me.picQuestion6.TabStop = False
        '
        'frmQuestion6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(505, 450)
        Me.Controls.Add(Me.btnFields)
        Me.Controls.Add(Me.btnSectors)
        Me.Controls.Add(Me.btnBacktostart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picQuestion6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion6"
        Me.Text = "Question 6"
        CType(Me.picQuestion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFields As Button
    Friend WithEvents btnSectors As Button
    Friend WithEvents btnBacktostart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents picQuestion6 As PictureBox
End Class
