<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceRoll
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
        Me.components = New System.ComponentModel.Container()
        Me.btnDiceRoll = New System.Windows.Forms.Button()
        Me.pbRoll1 = New System.Windows.Forms.PictureBox()
        Me.pbRoll2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.pbRoll1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRoll2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDiceRoll
        '
        Me.btnDiceRoll.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDiceRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiceRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiceRoll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDiceRoll.Location = New System.Drawing.Point(356, 356)
        Me.btnDiceRoll.Name = "btnDiceRoll"
        Me.btnDiceRoll.Size = New System.Drawing.Size(208, 81)
        Me.btnDiceRoll.TabIndex = 0
        Me.btnDiceRoll.Text = "Roll Dice"
        Me.btnDiceRoll.UseVisualStyleBackColor = False
        '
        'pbRoll1
        '
        Me.pbRoll1.Image = Global.CSC163_Dice_Roll.My.Resources.Resources.Die1
        Me.pbRoll1.Location = New System.Drawing.Point(250, 154)
        Me.pbRoll1.Name = "pbRoll1"
        Me.pbRoll1.Size = New System.Drawing.Size(171, 145)
        Me.pbRoll1.TabIndex = 1
        Me.pbRoll1.TabStop = False
        '
        'pbRoll2
        '
        Me.pbRoll2.Image = Global.CSC163_Dice_Roll.My.Resources.Resources.Die1
        Me.pbRoll2.Location = New System.Drawing.Point(524, 154)
        Me.pbRoll2.Name = "pbRoll2"
        Me.pbRoll2.Size = New System.Drawing.Size(175, 147)
        Me.pbRoll2.TabIndex = 2
        Me.pbRoll2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(96, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(701, 93)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dice Roll Program"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(12, 21)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 31)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmDiceRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 539)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbRoll2)
        Me.Controls.Add(Me.pbRoll1)
        Me.Controls.Add(Me.btnDiceRoll)
        Me.Name = "frmDiceRoll"
        Me.Text = "Main"
        CType(Me.pbRoll1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRoll2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDiceRoll As Button
    Friend WithEvents pbRoll1 As PictureBox
    Friend WithEvents pbRoll2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnBack As Button
End Class
