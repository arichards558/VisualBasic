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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnPunchline = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 194)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnPunchline
        '
        Me.btnPunchline.Location = New System.Drawing.Point(197, 194)
        Me.btnPunchline.Name = "btnPunchline"
        Me.btnPunchline.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchline.TabIndex = 1
        Me.btnPunchline.Text = "Punchline"
        Me.btnPunchline.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblAnswer.Location = New System.Drawing.Point(-1, 48)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(27, 15)
        Me.lblAnswer.TabIndex = 2
        Me.lblAnswer.Text = "???"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnPunchline)
        Me.Controls.Add(Me.btnSetup)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnPunchline As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
