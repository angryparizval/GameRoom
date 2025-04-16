Imports System.Resources

Public Class frmHighLow
    Dim randNum1
    Dim guessStreak = 0

    'procedure to set all the visibilities correctly, and generate the first numer
    Private Sub generateGame()
        'sets visibility for all components
        lblRules.Visible = False
        btnPlay.Visible = False
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        lblFstCard.Visible = True
        lblScdCard.Visible = True
        btnHigher.Visible = True
        btnLower.Visible = True

        'generates a randomnumber, set its to randNum1 and puts that value in the lblFstCard
        randNum1 = Int(Rnd() * 50)
        lblFstCard.Text = randNum1
        lblScdCard.Text = "?"
    End Sub

    'event handler for when the play button is clicked
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'adds one to games played and starts game
        gamesPlayed += 1
        generateGame()
    End Sub

    'event handler for if the user selected higher
    Private Sub btnHigher_Click(sender As Object, e As EventArgs) Handles btnHigher.Click
        'generates second number and sets the lblScdCard to it
        Dim randNum2 = Int(Rnd() * 50)
        lblScdCard.Text = randNum2

        'if the number was higher
        If randNum2 > randNum1 Then
            'tells user they are correct
            MessageBox.Show("Correct! " & randNum2 & " is higher.")
            guessStreak += 1
            'if the streak is 5 the user won and the game is reset to be played again if the user wants
            If (guessStreak = 5) Then
                gamesWon += 1
                MessageBox.Show("CONGRATS!! You guessed 5 in a row which means you win")
                guessStreak = 0
                lblRules.Visible = True
                btnPlay.Visible = True
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                lblFstCard.Visible = False
                lblScdCard.Visible = False
                btnHigher.Visible = False
                btnLower.Visible = False
            Else 'if the streak is not 5 the game continues
                generateGame()
            End If
        Else 'if the number was lower game resets and the user is given +1 to games lost
            MessageBox.Show("Wrong! " & randNum2 & " is not higher.")
            gamesLost += 1
            guessStreak = 0
            lblRules.Visible = True
            btnPlay.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            lblFstCard.Visible = False
            lblScdCard.Visible = False
            btnHigher.Visible = False
            btnLower.Visible = False
        End If
    End Sub

    'event handler to handle if user selects lower
    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        'generates second number and sets the lblScdCard to it
        Dim randNum2 = Int(Rnd() * 50)
        lblScdCard.Text = randNum2

        'if the number was lower
        If randNum2 < randNum1 Then
            'tells user they are correct
            MessageBox.Show("Correct! " & randNum2 & " is lower.")
            guessStreak += 1
            'if the streak is 5 the user won and the game is reset to be played again if the user wants
            If (guessStreak = 5) Then
                gamesWon += 1
                MessageBox.Show("CONGRATS!! You guessed 5 in a row which means you win")
                guessStreak = 0
                lblRules.Visible = True
                btnPlay.Visible = True
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                lblFstCard.Visible = False
                lblScdCard.Visible = False
                btnHigher.Visible = False
                btnLower.Visible = False
            Else 'if the streak is not 5 the game continues
                generateGame()
            End If

        Else 'if the number was lower game resets and the user is given +1 to games lost
            MessageBox.Show("Wrong! " & randNum2 & " is not lower.")
            gamesLost += 1
            guessStreak = 0
            btnPlay.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            lblFstCard.Visible = False
            lblScdCard.Visible = False
            btnHigher.Visible = False
            btnLower.Visible = False
        End If
    End Sub

    'on load sets the middle rules text to explain the goal
    Private Sub frmHighLow_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblRules.Text = "You need to guess 5 in a row to win"
    End Sub

    'event handler to handle if the user pressed back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'closes screen and reopens main screen
        MainRoom.Show()
        Me.Close()
    End Sub
End Class