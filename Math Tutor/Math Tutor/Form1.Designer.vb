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
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(35, 78)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(105, 33)
        Me.btnAnswer.TabIndex = 0
        Me.btnAnswer.Text = "Show Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 78)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 28)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEquation
        '
        Me.lblEquation.AutoSize = True
        Me.lblEquation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquation.Location = New System.Drawing.Point(81, 25)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(133, 26)
        Me.lblEquation.TabIndex = 2
        Me.lblEquation.Text = "18 + 64 = ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 118)
        Me.Controls.Add(Me.lblEquation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAnswer)
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblEquation As System.Windows.Forms.Label

End Class
