Imports System.Drawing.Imaging
Imports System.Threading.Tasks

Public Class frmDiceRoll

    'Function to roll the dice in a sort of dice rolling animation
    Private Async Sub rollingAni()
        'rolls the dice 6 times
        For I As Integer = 0 To 6
            'generates 2 random numbers for each dice
            Dim Roll1 As Integer = Int((6 * Rnd()) + 1)
            Dim Roll2 As Integer = Int((6 * Rnd()) + 1)

            'checks what the random number was and sets dice1 to the respective dice image
            If (Roll1 = 1) Then
                pbRoll1.Image = My.Resources.Die1
            ElseIf (Roll1 = 2) Then
                pbRoll1.Image = My.Resources.Die2
            ElseIf (Roll1 = 3) Then
                pbRoll1.Image = My.Resources.Die3
            ElseIf (Roll1 = 4) Then
                pbRoll1.Image = My.Resources.Die4
            ElseIf (Roll1 = 5) Then
                pbRoll1.Image = My.Resources.Die5
            ElseIf (Roll1 = 6) Then
                pbRoll1.Image = My.Resources.Die6
            End If
            'checks what the random number was and sets dice2 to the respective dice image
            If (Roll2 = 1) Then
                pbRoll2.Image = My.Resources.Die1
            ElseIf (Roll2 = 2) Then
                pbRoll2.Image = My.Resources.Die2
            ElseIf (Roll2 = 3) Then
                pbRoll2.Image = My.Resources.Die3
            ElseIf (Roll2 = 4) Then
                pbRoll2.Image = My.Resources.Die4
            ElseIf (Roll2 = 5) Then
                pbRoll2.Image = My.Resources.Die5
            ElseIf (Roll2 = 6) Then
                pbRoll2.Image = My.Resources.Die6
            End If

            'Pauses so all 6 six rolls dont happen at the same time
            Await Task.Delay(250)
        Next
        'sets the dice roll button back to visible
        btnDiceRoll.Visible = True
    End Sub

    'function when the button is clicked
    Private Sub btnDiceRoll_Click(sender As Object, e As EventArgs) Handles btnDiceRoll.Click
        globalVars.gamesPlayed += 1
        btnDiceRoll.Visible = False

        'starts rollingAni function
        rollingAni()

        'generates 2 random numbers for each dice
        Dim Roll1 As Integer = Int((6 * Rnd()) + 1)
        Dim Roll2 As Integer = Int((6 * Rnd()) + 1)

        'checks what the random number was and sets dice1 to the respective dice image
        If (Roll1 = 1) Then
            pbRoll1.Image = My.Resources.Die1
        ElseIf (Roll1 = 2) Then
            pbRoll1.Image = My.Resources.Die2
        ElseIf (Roll1 = 3) Then
            pbRoll1.Image = My.Resources.Die3
        ElseIf (Roll1 = 4) Then
            pbRoll1.Image = My.Resources.Die4
        ElseIf (Roll1 = 5) Then
            pbRoll1.Image = My.Resources.Die5
        ElseIf (Roll1 = 6) Then
            pbRoll1.Image = My.Resources.Die6
        End If

        'checks what the random number was and sets dice2 to the respective dice image
        If (Roll2 = 1) Then
            pbRoll2.Image = My.Resources.Die1
        ElseIf (Roll2 = 2) Then
            pbRoll2.Image = My.Resources.Die2
        ElseIf (Roll2 = 3) Then
            pbRoll2.Image = My.Resources.Die3
        ElseIf (Roll2 = 4) Then
            pbRoll2.Image = My.Resources.Die4
        ElseIf (Roll2 = 5) Then
            pbRoll2.Image = My.Resources.Die5
        ElseIf (Roll2 = 6) Then
            pbRoll2.Image = My.Resources.Die6
        End If
    End Sub

    'On form load function 
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creates tooltip for button
        ToolTip1.SetToolTip(btnDiceRoll, "Click here to roll both dice randomly")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainRoom.Show()
        Me.Hide()
    End Sub
End Class
