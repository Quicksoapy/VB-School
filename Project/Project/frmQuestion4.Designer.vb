<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion4))
        Me.picQuestion5 = New System.Windows.Forms.PictureBox()
        Me.lblQuestion4 = New System.Windows.Forms.Label()
        Me.btnBacktostart = New System.Windows.Forms.Button()
        Me.btnDefragmentation = New System.Windows.Forms.Button()
        Me.btnFormatting = New System.Windows.Forms.Button()
        Me.btnInterleaving = New System.Windows.Forms.Button()
        CType(Me.picQuestion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picQuestion5
        '
        Me.picQuestion5.Image = Global.Project.My.Resources.Resources.vraag5
        Me.picQuestion5.Location = New System.Drawing.Point(82, 12)
        Me.picQuestion5.Name = "picQuestion5"
        Me.picQuestion5.Size = New System.Drawing.Size(543, 300)
        Me.picQuestion5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQuestion5.TabIndex = 0
        Me.picQuestion5.TabStop = False
        '
        'lblQuestion4
        '
        Me.lblQuestion4.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion4.ForeColor = System.Drawing.Color.White
        Me.lblQuestion4.Location = New System.Drawing.Point(82, 315)
        Me.lblQuestion4.Name = "lblQuestion4"
        Me.lblQuestion4.Size = New System.Drawing.Size(543, 23)
        Me.lblQuestion4.TabIndex = 1
        Me.lblQuestion4.Text = "What is happening here?"
        Me.lblQuestion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBacktostart
        '
        Me.btnBacktostart.Location = New System.Drawing.Point(82, 341)
        Me.btnBacktostart.Name = "btnBacktostart"
        Me.btnBacktostart.Size = New System.Drawing.Size(131, 54)
        Me.btnBacktostart.TabIndex = 2
        Me.btnBacktostart.Text = "Back to start"
        Me.btnBacktostart.UseVisualStyleBackColor = True
        '
        'btnDefragmentation
        '
        Me.btnDefragmentation.Location = New System.Drawing.Point(219, 341)
        Me.btnDefragmentation.Name = "btnDefragmentation"
        Me.btnDefragmentation.Size = New System.Drawing.Size(131, 54)
        Me.btnDefragmentation.TabIndex = 3
        Me.btnDefragmentation.Text = "Defragmentation"
        Me.btnDefragmentation.UseVisualStyleBackColor = True
        '
        'btnFormatting
        '
        Me.btnFormatting.Location = New System.Drawing.Point(356, 341)
        Me.btnFormatting.Name = "btnFormatting"
        Me.btnFormatting.Size = New System.Drawing.Size(131, 54)
        Me.btnFormatting.TabIndex = 4
        Me.btnFormatting.Text = "Formatting"
        Me.btnFormatting.UseVisualStyleBackColor = True
        '
        'btnInterleaving
        '
        Me.btnInterleaving.Location = New System.Drawing.Point(493, 341)
        Me.btnInterleaving.Name = "btnInterleaving"
        Me.btnInterleaving.Size = New System.Drawing.Size(131, 54)
        Me.btnInterleaving.TabIndex = 5
        Me.btnInterleaving.Text = "Interleaving"
        Me.btnInterleaving.UseVisualStyleBackColor = True
        '
        'frmQuestion4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(706, 410)
        Me.Controls.Add(Me.btnInterleaving)
        Me.Controls.Add(Me.btnFormatting)
        Me.Controls.Add(Me.btnDefragmentation)
        Me.Controls.Add(Me.btnBacktostart)
        Me.Controls.Add(Me.lblQuestion4)
        Me.Controls.Add(Me.picQuestion5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion4"
        Me.Text = "Question 4"
        CType(Me.picQuestion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picQuestion5 As PictureBox
    Friend WithEvents lblQuestion4 As Label
    Friend WithEvents btnBacktostart As Button
    Friend WithEvents btnDefragmentation As Button
    Friend WithEvents btnFormatting As Button
    Friend WithEvents btnInterleaving As Button
End Class
