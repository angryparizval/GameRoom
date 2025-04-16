<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainRoom
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRPS = New System.Windows.Forms.Button()
        Me.btnDiceRoll = New System.Windows.Forms.Button()
        Me.btnHighLow = New System.Windows.Forms.Button()
        Me.btnNumGuess = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGamesLost = New System.Windows.Forms.Label()
        Me.lblGamesWon = New System.Windows.Forms.Label()
        Me.lblGamesPlayed = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(746, 135)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game Room"
        '
        'btnRPS
        '
        Me.btnRPS.BackColor = System.Drawing.Color.Red
        Me.btnRPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRPS.Location = New System.Drawing.Point(75, 309)
        Me.btnRPS.Name = "btnRPS"
        Me.btnRPS.Size = New System.Drawing.Size(205, 115)
        Me.btnRPS.TabIndex = 3
        Me.btnRPS.Text = "Rock, Paper, Scissors"
        Me.btnRPS.UseVisualStyleBackColor = False
        '
        'btnDiceRoll
        '
        Me.btnDiceRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDiceRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiceRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiceRoll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDiceRoll.Location = New System.Drawing.Point(75, 168)
        Me.btnDiceRoll.Name = "btnDiceRoll"
        Me.btnDiceRoll.Size = New System.Drawing.Size(205, 115)
        Me.btnDiceRoll.TabIndex = 4
        Me.btnDiceRoll.Text = "Dice Roll"
        Me.btnDiceRoll.UseVisualStyleBackColor = False
        '
        'btnHighLow
        '
        Me.btnHighLow.BackColor = System.Drawing.Color.Fuchsia
        Me.btnHighLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighLow.Location = New System.Drawing.Point(351, 168)
        Me.btnHighLow.Name = "btnHighLow"
        Me.btnHighLow.Size = New System.Drawing.Size(205, 115)
        Me.btnHighLow.TabIndex = 5
        Me.btnHighLow.Text = "Higher or Lower"
        Me.btnHighLow.UseVisualStyleBackColor = False
        '
        'btnNumGuess
        '
        Me.btnNumGuess.BackColor = System.Drawing.Color.Yellow
        Me.btnNumGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNumGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumGuess.Location = New System.Drawing.Point(351, 309)
        Me.btnNumGuess.Name = "btnNumGuess"
        Me.btnNumGuess.Size = New System.Drawing.Size(205, 115)
        Me.btnNumGuess.TabIndex = 6
        Me.btnNumGuess.Text = "Number Guess"
        Me.btnNumGuess.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGamesLost)
        Me.GroupBox1.Controls.Add(Me.lblGamesWon)
        Me.GroupBox1.Controls.Add(Me.lblGamesPlayed)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(588, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 261)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lblGamesLost
        '
        Me.lblGamesLost.AutoSize = True
        Me.lblGamesLost.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamesLost.Location = New System.Drawing.Point(84, 212)
        Me.lblGamesLost.Name = "lblGamesLost"
        Me.lblGamesLost.Size = New System.Drawing.Size(26, 29)
        Me.lblGamesLost.TabIndex = 5
        Me.lblGamesLost.Text = "5"
        '
        'lblGamesWon
        '
        Me.lblGamesWon.AutoSize = True
        Me.lblGamesWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamesWon.Location = New System.Drawing.Point(84, 132)
        Me.lblGamesWon.Name = "lblGamesWon"
        Me.lblGamesWon.Size = New System.Drawing.Size(26, 29)
        Me.lblGamesWon.TabIndex = 4
        Me.lblGamesWon.Text = "5"
        '
        'lblGamesPlayed
        '
        Me.lblGamesPlayed.AutoSize = True
        Me.lblGamesPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamesPlayed.Location = New System.Drawing.Point(84, 50)
        Me.lblGamesPlayed.Name = "lblGamesPlayed"
        Me.lblGamesPlayed.Size = New System.Drawing.Size(26, 29)
        Me.lblGamesPlayed.TabIndex = 3
        Me.lblGamesPlayed.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(41, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Games Lost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Games Won"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Games Played"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(752, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(31, 32)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'MainRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNumGuess)
        Me.Controls.Add(Me.btnHighLow)
        Me.Controls.Add(Me.btnDiceRoll)
        Me.Controls.Add(Me.btnRPS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainRoom"
        Me.Text = "MainRoom"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRPS As Button
    Friend WithEvents btnDiceRoll As Button
    Friend WithEvents btnHighLow As Button
    Friend WithEvents btnNumGuess As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblGamesPlayed As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGamesLost As Label
    Friend WithEvents lblGamesWon As Label
    Friend WithEvents btnExit As Button
End Class
