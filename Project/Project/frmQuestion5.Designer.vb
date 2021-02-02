<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion5))
        Me.picQuestion5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBacktostart = New System.Windows.Forms.Button()
        Me.btnSectors = New System.Windows.Forms.Button()
        Me.btnFields = New System.Windows.Forms.Button()
        Me.btnSpaces = New System.Windows.Forms.Button()
        CType(Me.picQuestion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picQuestion5
        '
        Me.picQuestion5.BackColor = System.Drawing.Color.Transparent
        Me.picQuestion5.Image = Global.Project.My.Resources.Resources.hdd_disk
        Me.picQuestion5.Location = New System.Drawing.Point(70, 12)
        Me.picQuestion5.Name = "picQuestion5"
        Me.picQuestion5.Size = New System.Drawing.Size(332, 332)
        Me.picQuestion5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picQuestion5.TabIndex = 0
        Me.picQuestion5.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(70, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What are those fields called?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBacktostart
        '
        Me.btnBacktostart.Location = New System.Drawing.Point(12, 373)
        Me.btnBacktostart.Name = "btnBacktostart"
        Me.btnBacktostart.Size = New System.Drawing.Size(113, 39)
        Me.btnBacktostart.TabIndex = 2
        Me.btnBacktostart.Text = "Back to start"
        Me.btnBacktostart.UseVisualStyleBackColor = True
        '
        'btnSectors
        '
        Me.btnSectors.Location = New System.Drawing.Point(125, 373)
        Me.btnSectors.Name = "btnSectors"
        Me.btnSectors.Size = New System.Drawing.Size(113, 39)
        Me.btnSectors.TabIndex = 3
        Me.btnSectors.Text = "Sectors"
        Me.btnSectors.UseVisualStyleBackColor = True
        '
        'btnFields
        '
        Me.btnFields.Location = New System.Drawing.Point(238, 373)
        Me.btnFields.Name = "btnFields"
        Me.btnFields.Size = New System.Drawing.Size(113, 39)
        Me.btnFields.TabIndex = 4
        Me.btnFields.Text = "Fields"
        Me.btnFields.UseVisualStyleBackColor = True
        '
        'btnSpaces
        '
        Me.btnSpaces.Location = New System.Drawing.Point(351, 373)
        Me.btnSpaces.Name = "btnSpaces"
        Me.btnSpaces.Size = New System.Drawing.Size(113, 39)
        Me.btnSpaces.TabIndex = 5
        Me.btnSpaces.Text = "Spaces"
        Me.btnSpaces.UseVisualStyleBackColor = True
        '
        'frmQuestion5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(472, 508)
        Me.Controls.Add(Me.btnSpaces)
        Me.Controls.Add(Me.btnFields)
        Me.Controls.Add(Me.btnSectors)
        Me.Controls.Add(Me.btnBacktostart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picQuestion5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion5"
        Me.Text = "Question 5"
        CType(Me.picQuestion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picQuestion5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBacktostart As Button
    Friend WithEvents btnSectors As Button
    Friend WithEvents btnFields As Button
    Friend WithEvents btnSpaces As Button
End Class
