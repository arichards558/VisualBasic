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
        Me.btnSinister = New System.Windows.Forms.Button()
        Me.btnDexter = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblCenter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSinister
        '
        Me.btnSinister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinister.Location = New System.Drawing.Point(12, 175)
        Me.btnSinister.Name = "btnSinister"
        Me.btnSinister.Size = New System.Drawing.Size(75, 23)
        Me.btnSinister.TabIndex = 0
        Me.btnSinister.Text = "Sinister"
        Me.btnSinister.UseVisualStyleBackColor = True
        '
        'btnDexter
        '
        Me.btnDexter.Location = New System.Drawing.Point(206, 175)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(75, 23)
        Me.btnDexter.TabIndex = 1
        Me.btnDexter.Text = "Dexter"
        Me.btnDexter.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Location = New System.Drawing.Point(107, 175)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(75, 23)
        Me.btnMedium.TabIndex = 2
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Location = New System.Drawing.Point(12, 44)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(0, 13)
        Me.lblLeft.TabIndex = 3
        Me.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Location = New System.Drawing.Point(233, 44)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(0, 13)
        Me.lblRight.TabIndex = 4
        Me.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCenter
        '
        Me.lblCenter.AutoSize = True
        Me.lblCenter.Location = New System.Drawing.Point(122, 44)
        Me.lblCenter.Name = "lblCenter"
        Me.lblCenter.Size = New System.Drawing.Size(0, 13)
        Me.lblCenter.TabIndex = 5
        Me.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblCenter)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnDexter)
        Me.Controls.Add(Me.btnSinister)
        Me.Name = "Form1"
        Me.Text = "Latin to English"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSinister As System.Windows.Forms.Button
    Friend WithEvents btnDexter As System.Windows.Forms.Button
    Friend WithEvents btnMedium As System.Windows.Forms.Button
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblCenter As System.Windows.Forms.Label

End Class
