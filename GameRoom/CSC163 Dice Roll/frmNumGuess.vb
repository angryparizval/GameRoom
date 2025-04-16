Imports System.Net.Configuration

Public Class frmNumGuess
    Dim userInput As Integer

    'procedure that runs the game
    Private Sub runGame()
        'generates the random number and clears the current guesses list
        Dim randNum = (Int(Rnd() * 20) + 1)
        Dim attempts = 0
        Dim playAgain
        lbGuesses.Items.Clear()
        'loop to allow the user to keep playing the game for as long as they want
        Do
            'gets a number from the user and adds it to the guess list
            userInput = InputBox("Please Enter a number between 1-20", "Enter")
            lbGuesses.Items.Add(userInput)
            'if they were correct exits loop and congratulates them
            If (userInput = randNum) Then
                MessageBox.Show("You got it! The correct answer was " + randNum.ToString)
                gamesWon += 1
                Exit Do

            Else 'if they were wrong
                attempts += 1
                'if the user guessed too high
                If (userInput > randNum) Then
                    MessageBox.Show("NOPE! You guessed too high try again! You have " + (5 - attempts).ToString() + " attempts left")
                ElseIf (userInput < randNum) Then 'if the user guessed too low
                    MessageBox.Show("NOPE! You guessed too low try again! You have " + (5 - attempts).ToString() + " attempts left")
                End If
            End If
        Loop Until (attempts = 5)
        'if user exited loop with 5 attempts, +1 is added to games lost
        If (attempts = 5) Then
            MessageBox.Show("Looks like you ran out of attempts! Nice try! The correct answer was " + randNum.ToString())
            gamesLost += 1
        End If
        'asks user if they want to play again
        playAgain = InputBox("Do you want to play again? Y/N", "Play Again?")
        'if yes add to gamesplayed and start again
        If (playAgain = "Y" Or playAgain = "y") Then
            runGame()
            gamesPlayed += 1
        ElseIf (playAgain = "n" Or playAgain = "N") Then ' if they user doesnt want to keep playing close screen and reopen main screen
            MainRoom.Show()
            Me.Close()
        End If
    End Sub

    'event handler to handle the play button
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        gamesPlayed += 1
        runGame()
    End Sub

    'event handler to handle the back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainRoom.Show()
        Me.Close()
    End Sub
End Class