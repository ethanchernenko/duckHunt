Public Class Form1
    Dim shotAnimationCounter As Integer
    Dim duckanimationCounter As Integer
    Dim duckanimationleftCounter As Integer
    Dim duckFallAnimationCounter As Integer
    Dim duckFallLeftAnimationCounter As Integer
    Dim r As New Random
    Dim duckLeftRightSpeed As Integer
    Dim duckUpDownSpeed As Integer
    Dim leftDuckLeftRightSpeed As Integer
    Dim leftDuckUpDownSpeed As Integer
    Dim goal(30) As PictureBox
    Dim goalDuckCounter As Integer
    Dim hits As Integer
    Dim shots As Integer
    Dim xSpot As Integer
    Dim ySpot As Integer

    Private Sub shootTimer_Tick(sender As Object, e As EventArgs) Handles shootTimer.Tick
        Select Case shotAnimationCounter
            Case 0
                gun1.Image = shot1.Image
                shotAnimationCounter += 1
            Case 1
                gun1.Image = shot2.Image
                shotAnimationCounter += 1
            Case 2
                gun1.Image = shot3.Image
                shotAnimationCounter += 1
            Case 3
                gun1.Image = reload1.Image
                shotAnimationCounter += 1
            Case 4
                gun1.Image = reload2.Image
                shotAnimationCounter += 1
            Case 5
                gun1.Image = reload3.Image
                shotAnimationCounter += 1
            Case 6
                gun1.Image = shot0.Image
                shootTimer.Stop()
                shotAnimationCounter = 0

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shotAnimationCounter = 0
        duckanimationCounter = 0
        duckanimationleftCounter = 0
        goalDuckCounter = -1
        makeGoalDucks()
        duckanimation.Stop()
        moveDuck.Stop()
        duckFallTimer.Stop()
        hits = 0
        shots = 0
        xSpot = 0
        ySpot = 0

    End Sub

    Private Sub field_MouseMove(sender As Object, e As MouseEventArgs) Handles field.MouseMove
        gun1.Left = e.Location.X - gun1.Width / 2
        xSpot = e.Location.X
        ySpot = e.Location.Y
    End Sub

    Private Sub field_Click(sender As Object, e As EventArgs) Handles field.Click
        shots += 1
        Label3.Text = ((hits / shots) * 100) \ 1
        shootTimer.Start()
        launchDuck()
        launchLeftDuck()
        shotMiss.Left = xSpot - shotMiss.Width / 2
        shotMiss.Top = ySpot
        shotMiss.Show()
        hideMissShot.Start()
    End Sub



    Sub makeGoalDucks()
        For i = 0 To 10
            goalDuckCounter += 1
            Me.Text = goalDuckCounter
            goal(i) = New PictureBox
            With goal(i)
                .Top = 21
                .Left = 184 + i * 17
                .Width = 16
                .Height = 16
                .Image = goalOg.Image
                .BackColor = Color.Transparent
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BringToFront()
            End With
            Me.Controls.Add(goal(i))
        Next
    End Sub

    Private Sub duckanimation_Tick(sender As Object, e As EventArgs) Handles duckanimation.Tick
        Select Case duckanimationCounter
            Case 0
                duck.Image = duck1.Image
                duckanimationCounter += 1
            Case 1
                duck.Image = duck2.Image
                duckanimationCounter += 1
            Case 2
                duck.Image = duck3.Image
                duckanimationCounter += 1
            Case 3
                duck.Image = duck4.Image
                duckanimationCounter += 1
            Case 4
                duck.Image = duck5.Image
                duckanimationCounter += 1
            Case 5
                duck.Image = duck6.Image
                duckanimationCounter += 1
            Case 6
                duck.Image = duck5.Image
                duckanimationCounter = 5
        End Select
    End Sub

    Private Sub duck_Click(sender As Object, e As EventArgs) Handles duck.Click
        duck.Enabled = False
        hits += 1
        shots += 1
        Label3.Text = ((hits / shots) * 100) \ 1
        duckanimation.Stop()
        duckFallTimer.Start()
        moveDuck.Stop()
        goal(goalDuckCounter).Hide()
        goalDuckCounter -= 1
        levelUp()
        shootTimer.Start()
    End Sub
    Sub levelUp()
        If goalDuckCounter <= 0 Then
            lblLevelUp.Show()
            duckanimation.Stop()
            moveDuck.Stop()
            For i = 0 To 10
                goal(i).Show()
            Next
            goalDuckCounter = 10
        End If
    End Sub

    Private Sub launchDuck()
        duck.Enabled = True
        duck.Top = field.Bottom
        duck.Left = r.Next(98, 417)
        duckLeftRightSpeed = r.Next(2, 10)
        duckUpDownSpeed = r.Next(-10, -2)
        duckanimation.Start()
        moveDuck.Start()

    End Sub

    Private Sub launchLeftDuck()
        duckLeft.Enabled = True
        duckLeft.Top = field.Bottom
        duckLeft.Left = r.Next(98, 417)
        leftDuckLeftRightSpeed = r.Next(2, 10)
        leftDuckUpDownSpeed = r.Next(-10, -2)
        duckLeftAnimation.Start()
        moveLeftDuck.Start()
    End Sub

    Private Sub moveDuck_Tick(sender As Object, e As EventArgs) Handles moveDuck.Tick
        duck.Left += duckLeftRightSpeed
        duck.Top += duckUpDownSpeed
        If duck.Left > field.Right Or duck.Top < field.Top Then
            launchDuck()

        End If
    End Sub

    Private Sub duckFallTimer_Tick(sender As Object, e As EventArgs) Handles duckFallTimer.Tick
        duckFallAnimationCounter += 1
        If duckFallAnimationCounter < 10 Then
            duck.Image = hit.Image
        Else
            duck.Image = duckfall.Image
            duck.Top += 25
            If duck.Bottom > field.Bottom Then
                duckFallTimer.Stop()
                duckFallAnimationCounter = 0
                If goalDuckCounter >= 1 Then
                    launchDuck()
                End If
            End If
        End If
    End Sub

    Private Sub duckLeftAnimation_Tick(sender As Object, e As EventArgs) Handles duckLeftAnimation.Tick
        Select Case duckanimationleftCounter
            Case 0
                duckLeft.Image = duckLeft1.Image
                duckanimationleftCounter += 1
            Case 1
                duckLeft.Image = duckLeft2.Image
                duckanimationleftCounter += 1
            Case 2
                duckLeft.Image = duckLeft3.Image
                duckanimationleftCounter += 1
            Case 3
                duckLeft.Image = duckLeft4.Image
                duckanimationleftCounter += 1
            Case 4
                duckLeft.Image = duckLeft5.Image
                duckanimationleftCounter += 1
            Case 5
                duckLeft.Image = duckLeft6.Image
                duckanimationleftCounter += 1
            Case 6
                duckLeft.Image = duckLeft5.Image
                duckanimationleftCounter = 5
        End Select
    End Sub


    Private Sub moveLeftDuck_Tick(sender As Object, e As EventArgs) Handles moveLeftDuck.Tick
        duckLeft.Left -= leftDuckLeftRightSpeed
        duckLeft.Top += leftDuckUpDownSpeed
        If duckLeft.Left < field.Left Or duckLeft.Top < field.Top Then
            launchLeftDuck()
        End If
    End Sub

    Private Sub duckLeft_Click(sender As Object, e As EventArgs) Handles duckLeft.Click
        duckLeft.Enabled = False
        hits += 1
        shots += 1
        Label3.Text = ((hits / shots) * 100) \ 1
        duckLeftAnimation.Stop()
        duckFallLeftTimer.Start()
        moveLeftDuck.Stop()
        goal(goalDuckCounter).Hide()
        goalDuckCounter -= 1
        levelUp()
        shootTimer.Start()

    End Sub

    Private Sub duckFallLeftTimer_Tick(sender As Object, e As EventArgs) Handles duckFallLeftTimer.Tick
        duckFallLeftAnimationCounter += 1
        If duckFallLeftAnimationCounter < 10 Then
            duckLeft.Image = duckHitLeft.Image
        Else
            duckLeft.Image = duckFallLeft.Image
            duckLeft.Top += 25
            If duckLeft.Bottom > field.Bottom Then
                duckFallLeftTimer.Stop()
                duckFallLeftAnimationCounter = 0
                If goalDuckCounter >= 1 Then
                    launchLeftDuck()
                End If
            End If
        End If
    End Sub

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        lblStart.Hide()
        duck.Show()
        launchDuck()
        duckLeft.Show()
        launchLeftDuck()
        Label2.Text += 1
    End Sub

    Private Sub lblLevelUp_Click(sender As Object, e As EventArgs) Handles lblLevelUp.Click
        lblLevelUp.Hide()
        launchDuck()
        launchLeftDuck()
        Label2.Text += 1
    End Sub
    Dim missShotCounter As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles hideMissShot.Tick
        missShotCounter += 1
        If missShotCounter > 5 Then
            shotMiss.Hide()
            hideMissShot.Stop()
            missShotCounter = 0
        End If


    End Sub
End Class
