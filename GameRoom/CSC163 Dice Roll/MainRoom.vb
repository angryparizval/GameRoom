Public Class MainRoom

    'event handler to handle if the user select the dice roll button
    Private Sub btnDiceRoll_Click(sender As Object, e As EventArgs) Handles btnDiceRoll.Click
        frmDiceRoll.Show()
        Me.Hide()
    End Sub

    'event handler to handle if the user select the higher lower button
    Private Sub btnHighLow_Click(sender As Object, e As EventArgs) Handles btnHighLow.Click
        frmHighLow.Show()
        Me.Hide()
    End Sub

    'event handler to handle if the user select the rock paper scissors button
    Private Sub btnRPS_Click(sender As Object, e As EventArgs) Handles btnRPS.Click
        frmRPS.Show()
        Me.Hide()
    End Sub

    'event handler to handle if the user select the number guess button
    Private Sub btnNumGuess_Click(sender As Object, e As EventArgs) Handles btnNumGuess.Click
        frmNumGuess.Show()
        Me.Hide()
    End Sub


    'procedure that sets the user game stats on load
    Private Sub MainRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGamesPlayed.Text = gamesPlayed
        lblGamesWon.Text = gamesWon
        lblGamesLost.Text = gamesLost
    End Sub

    'procedure that sets the user game stats on activate
    Private Sub MainRoom_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblGamesPlayed.Text = gamesPlayed
        lblGamesWon.Text = gamesWon
        lblGamesLost.Text = gamesLost
    End Sub

    'event handler to handle the user pressing the X button on the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class