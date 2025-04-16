<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRPS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbRock = New System.Windows.Forms.RadioButton()
        Me.rbPaper = New System.Windows.Forms.RadioButton()
        Me.rbScissors = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbComputer = New System.Windows.Forms.PictureBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CSC163_Dice_Roll.My.Resources.Resources.rocks1
        Me.PictureBox1.Location = New System.Drawing.Point(111, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CSC163_Dice_Roll.My.Resources.Resources.paper1
        Me.PictureBox2.Location = New System.Drawing.Point(337, 85)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CSC163_Dice_Roll.My.Resources.Resources.scissors1
        Me.PictureBox3.Location = New System.Drawing.Point(574, 85)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 113)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(221, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 54)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select Option:"
        '
        'rbRock
        '
        Me.rbRock.AutoSize = True
        Me.rbRock.Location = New System.Drawing.Point(156, 205)
        Me.rbRock.Name = "rbRock"
        Me.rbRock.Size = New System.Drawing.Size(17, 16)
        Me.rbRock.TabIndex = 1
        Me.rbRock.TabStop = True
        Me.rbRock.UseVisualStyleBackColor = True
        '
        'rbPaper
        '
        Me.rbPaper.AutoSize = True
        Me.rbPaper.Location = New System.Drawing.Point(383, 205)
        Me.rbPaper.Name = "rbPaper"
        Me.rbPaper.Size = New System.Drawing.Size(17, 16)
        Me.rbPaper.TabIndex = 2
        Me.rbPaper.TabStop = True
        Me.rbPaper.UseVisualStyleBackColor = True
        '
        'rbScissors
        '
        Me.rbScissors.AutoSize = True
        Me.rbScissors.Location = New System.Drawing.Point(622, 205)
        Me.rbScissors.Name = "rbScissors"
        Me.rbScissors.Size = New System.Drawing.Size(17, 16)
        Me.rbScissors.TabIndex = 3
        Me.rbScissors.TabStop = True
        Me.rbScissors.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(759, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "---------------------------"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Location = New System.Drawing.Point(355, 241)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 29)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(36, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "You Selected:"
        '
        'pbUser
        '
        Me.pbUser.Location = New System.Drawing.Point(50, 345)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(112, 113)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUser.TabIndex = 10
        Me.pbUser.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(569, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Computer Selected:"
        '
        'pbComputer
        '
        Me.pbComputer.Location = New System.Drawing.Point(622, 345)
        Me.pbComputer.Name = "pbComputer"
        Me.pbComputer.Size = New System.Drawing.Size(112, 113)
        Me.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbComputer.TabIndex = 12
        Me.pbComputer.TabStop = False
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Yellow
        Me.lblResult.Location = New System.Drawing.Point(239, 300)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(283, 158)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "You LOSE!"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResult.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 33)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmRPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.pbComputer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbScissors)
        Me.Controls.Add(Me.rbPaper)
        Me.Controls.Add(Me.rbRock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmRPS"
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbRock As RadioButton
    Friend WithEvents rbPaper As RadioButton
    Friend WithEvents rbScissors As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbComputer As PictureBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnBack As Button
End Class
