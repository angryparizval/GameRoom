Imports Microsoft.VisualBasic.Devices

Public Class frmRPS

    'function to generate a random number
    Private Function genRandNum() As Integer
        'generates random number from 1-2
        Return Int((Rnd() * 3) + 1)
    End Function

    'sub to check if user wants to play again
    Private Sub playAgain()
        Dim userPlay As String
        userPlay = InputBox("Do you want to play again? Y/N", "Continue?")
        If userPlay.ToUpper = "Y" Then
            gamesPlayed += 1
            'clear the selections to allow a new selection
            rbRock.Checked = False
            rbPaper.Checked = False
            rbScissors.Checked = False
            'call game function again to restart RECURSION :)
            game()

        ElseIf userPlay.ToUpper = "N" Then
            MainRoom.Show()
            Me.Close()
        Else
            playAgain()
        End If
    End Sub

    'sub to run game
    Private Sub game()
        'resets game
        lblResult.Text = ""
        pbUser.Image = Nothing
        pbComputer.Image = Nothing
        lblResult.Visible = False


        If Not rbRock.Checked AndAlso Not rbPaper.Checked AndAlso Not rbScissors.Checked Then
            MessageBox.Show("Please select Rock, Paper, or Scissors to start.")
            Return
        End If

        'gets user selected option and sets the image at bottom to this select
        If rbPaper.Checked = True Then
            pbUser.Image = My.Resources.paper1
        ElseIf rbRock.Checked = True Then
            pbUser.Image = My.Resources.rocks1
        ElseIf rbScissors.Checked = True Then
            pbUser.Image = My.Resources.scissors1
        End If

        'gets random number from 1-2
        Dim compPick As Integer = genRandNum()
        'if 1 set computer image to rock
        If compPick = 1 Then
            pbComputer.Image = My.Resources.rocks1
        ElseIf compPick = 2 Then  'if 2 set computer image to paper
            pbComputer.Image = My.Resources.paper1
        ElseIf compPick = 3 Then 'if 3 set computer image to scissors
            pbComputer.Image = My.Resources.scissors1
        End If

        'If computer chose rock
        If compPick = 1 Then
            lblResult.Visible = True
            If rbRock.Checked = True Then 'if user chose rock they drew
                lblResult.Text = "You Drew!"

            ElseIf rbPaper.Checked = True Then 'if user picked paper they won
                lblResult.Text = "You Win!"
                gamesWon += 1
            ElseIf rbScissors.Checked = True Then 'if user picked scissors they lost
                lblResult.Text = "You Lose!"
                gamesLost += 1
            End If
        ElseIf compPick = 2 Then 'if computer chose Paper
            lblResult.Visible = True
            If rbRock.Checked = True Then 'if the user picked rock they lost
                lblResult.Text = "You Lose!"
                gamesLost += 1
            ElseIf rbPaper.Checked = True Then 'if user picked paper they drew
                lblResult.Text = "It's a Draw!"
            ElseIf rbScissors.Checked = True Then 'if user picked scissors they won
                lblResult.Text = "You Win!"
                gamesWon += 1
            End If
        ElseIf compPick = 3 Then 'if computer chose Scissors
            lblResult.Visible = True
            If rbRock.Checked = True Then 'if user picked rock they won
                lblResult.Text = "You Win!"
                gamesWon += 1
            ElseIf rbPaper.Checked = True Then
                lblResult.Text = "You Lose!" 'if user picked paper then lost
                gamesLost += 1
            ElseIf rbScissors.Checked = True Then
                lblResult.Text = "It's a Draw!" 'if user picked scissors they drew
            End If
        End If

        playAgain()

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        gamesPlayed += 1
        game()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainRoom.Show()
        Me.Close()
    End Sub


End Class
