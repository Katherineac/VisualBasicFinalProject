<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
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
        Me.lblHowToPlay = New System.Windows.Forms.Label()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.lblRule1 = New System.Windows.Forms.Label()
        Me.lblRule2 = New System.Windows.Forms.Label()
        Me.lblRule3 = New System.Windows.Forms.Label()
        Me.lblRule4 = New System.Windows.Forms.Label()
        Me.lblRule5 = New System.Windows.Forms.Label()
        Me.lblRule6 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHowToPlay
        '
        Me.lblHowToPlay.AutoSize = True
        Me.lblHowToPlay.Location = New System.Drawing.Point(3, 12)
        Me.lblHowToPlay.Name = "lblHowToPlay"
        Me.lblHowToPlay.Size = New System.Drawing.Size(67, 13)
        Me.lblHowToPlay.TabIndex = 1
        Me.lblHowToPlay.Text = "How to Play:"
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Location = New System.Drawing.Point(12, 36)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(37, 13)
        Me.lblRules.TabIndex = 2
        Me.lblRules.Text = "Rules:"
        '
        'lblRule1
        '
        Me.lblRule1.AutoSize = True
        Me.lblRule1.Location = New System.Drawing.Point(22, 60)
        Me.lblRule1.Name = "lblRule1"
        Me.lblRule1.Size = New System.Drawing.Size(228, 13)
        Me.lblRule1.TabIndex = 3
        Me.lblRule1.Text = "Type the letters into the corresponding textbox."
        '
        'lblRule2
        '
        Me.lblRule2.AutoSize = True
        Me.lblRule2.Location = New System.Drawing.Point(22, 88)
        Me.lblRule2.Name = "lblRule2"
        Me.lblRule2.Size = New System.Drawing.Size(315, 13)
        Me.lblRule2.TabIndex = 4
        Me.lblRule2.Text = "Press hint to get a random letter. It may be one you already know."
        '
        'lblRule3
        '
        Me.lblRule3.AutoSize = True
        Me.lblRule3.Location = New System.Drawing.Point(22, 117)
        Me.lblRule3.Name = "lblRule3"
        Me.lblRule3.Size = New System.Drawing.Size(239, 13)
        Me.lblRule3.TabIndex = 5
        Me.lblRule3.Text = "To check if a letter is correct, click the cell it is in."
        '
        'lblRule4
        '
        Me.lblRule4.AutoSize = True
        Me.lblRule4.Location = New System.Drawing.Point(22, 142)
        Me.lblRule4.Name = "lblRule4"
        Me.lblRule4.Size = New System.Drawing.Size(192, 13)
        Me.lblRule4.TabIndex = 6
        Me.lblRule4.Text = "You may have to click more than once."
        '
        'lblRule5
        '
        Me.lblRule5.AutoSize = True
        Me.lblRule5.Location = New System.Drawing.Point(22, 170)
        Me.lblRule5.Name = "lblRule5"
        Me.lblRule5.Size = New System.Drawing.Size(271, 13)
        Me.lblRule5.TabIndex = 7
        Me.lblRule5.Text = "Press the High Scores Button to see current high scores"
        '
        'lblRule6
        '
        Me.lblRule6.AutoSize = True
        Me.lblRule6.Location = New System.Drawing.Point(22, 195)
        Me.lblRule6.Name = "lblRule6"
        Me.lblRule6.Size = New System.Drawing.Size(57, 13)
        Me.lblRule6.TabIndex = 8
        Me.lblRule6.Text = "Have Fun!"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 224)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(223, 40)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnHighScores
        '
        Me.btnHighScores.Location = New System.Drawing.Point(258, 224)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(232, 40)
        Me.btnHighScores.TabIndex = 0
        Me.btnHighScores.Text = "High Scores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 278)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.lblRule6)
        Me.Controls.Add(Me.lblRule5)
        Me.Controls.Add(Me.lblRule4)
        Me.Controls.Add(Me.lblRule3)
        Me.Controls.Add(Me.lblRule2)
        Me.Controls.Add(Me.lblRule1)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.lblHowToPlay)
        Me.Name = "StartScreen"
        Me.Text = "Start Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHowToPlay As System.Windows.Forms.Label
    Friend WithEvents lblRules As System.Windows.Forms.Label
    Friend WithEvents lblRule1 As System.Windows.Forms.Label
    Friend WithEvents lblRule2 As System.Windows.Forms.Label
    Friend WithEvents lblRule3 As System.Windows.Forms.Label
    Friend WithEvents lblRule4 As System.Windows.Forms.Label
    Friend WithEvents lblRule5 As System.Windows.Forms.Label
    Friend WithEvents lblRule6 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnHighScores As System.Windows.Forms.Button

End Class
