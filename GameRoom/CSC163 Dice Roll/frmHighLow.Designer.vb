<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighLow
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.btnHigher = New System.Windows.Forms.Button()
        Me.lblFstCard = New System.Windows.Forms.Label()
        Me.lblScdCard = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(740, 78)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Higher or Lower Game"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Location = New System.Drawing.Point(286, 369)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(179, 69)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(126, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Number"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(428, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Second Number"
        Me.Label3.Visible = False
        '
        'btnLower
        '
        Me.btnLower.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLower.Location = New System.Drawing.Point(83, 369)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(179, 69)
        Me.btnLower.TabIndex = 5
        Me.btnLower.Text = "Lower"
        Me.btnLower.UseVisualStyleBackColor = False
        Me.btnLower.Visible = False
        '
        'btnHigher
        '
        Me.btnHigher.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHigher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHigher.Location = New System.Drawing.Point(500, 369)
        Me.btnHigher.Name = "btnHigher"
        Me.btnHigher.Size = New System.Drawing.Size(179, 69)
        Me.btnHigher.TabIndex = 6
        Me.btnHigher.Text = "HIgher"
        Me.btnHigher.UseVisualStyleBackColor = False
        Me.btnHigher.Visible = False
        '
        'lblFstCard
        '
        Me.lblFstCard.AutoSize = True
        Me.lblFstCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFstCard.ForeColor = System.Drawing.Color.Yellow
        Me.lblFstCard.Location = New System.Drawing.Point(181, 120)
        Me.lblFstCard.Name = "lblFstCard"
        Me.lblFstCard.Size = New System.Drawing.Size(68, 74)
        Me.lblFstCard.TabIndex = 7
        Me.lblFstCard.Text = "2"
        Me.lblFstCard.Visible = False
        '
        'lblScdCard
        '
        Me.lblScdCard.AutoSize = True
        Me.lblScdCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScdCard.ForeColor = System.Drawing.Color.Yellow
        Me.lblScdCard.Location = New System.Drawing.Point(513, 120)
        Me.lblScdCard.Name = "lblScdCard"
        Me.lblScdCard.Size = New System.Drawing.Size(68, 74)
        Me.lblScdCard.TabIndex = 8
        Me.lblScdCard.Text = "?"
        Me.lblScdCard.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(126, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(524, 36)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Is the second number higher or lower?"
        Me.Label4.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(5, 403)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 35)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblRules
        '
        Me.lblRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRules.Location = New System.Drawing.Point(143, 134)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRules.Size = New System.Drawing.Size(507, 173)
        Me.lblRules.TabIndex = 11
        Me.lblRules.Text = "You need to guess 5 in a row to win"
        Me.lblRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHighLow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblScdCard)
        Me.Controls.Add(Me.lblFstCard)
        Me.Controls.Add(Me.btnHigher)
        Me.Controls.Add(Me.btnLower)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHighLow"
        Me.Text = "frmHighLow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLower As Button
    Friend WithEvents btnHigher As Button
    Friend WithEvents lblFstCard As Label
    Friend WithEvents lblScdCard As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblRules As Label
End Class
