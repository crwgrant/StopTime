' Made by Christian Grant on January 26, 2016 (Updated 3/27/2016)
' Nothing like a nice timer to help you keep track of your game play!
' This is a super simple timer program that I made in a few hours so that
'   I could have some fun and keep track of my game time!
' Maybe someday I will make a database to keep track of time and create 
'   some kind of statistics for how much time we are "wasting" playing
'   them video games...
' Most likely going to stick with this version. The C# version was too
'   slow. 

Public Class frmStopTime
    ' Form load action
    Private Sub frmStopTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrDate.Enabled = True
        tmrStopWatch.Enabled = False
        tmrTimer.Enabled = False
    End Sub

    ' Date and Time timer displayed at the bottom outside of the tabs
    Private Sub tmrDate_Tick(sender As Object, e As EventArgs) Handles tmrDate.Tick
        tslDate.Text = DateTime.Now.ToLongDateString
        tslTime.Text = DateTime.Now.ToLongTimeString
    End Sub

#Region "StopWatch Tab Operations"
    ''' <summary>
    ''' There is a known issue here.
    ''' When the timer reaches 59 and iterates plus 1,
    '''     the timer minutes will go to 60 for a second 
    '''     and then switch back to 0. I might try to 
    '''     find a way to fix that.
    ''' </summary>
    ' StopWatch timer tick action
    Private Sub tmrStopWatch_Tick(sender As Object, e As EventArgs) Handles tmrStopWatch.Tick
        lblSeconds.Text += 1
        If lblSeconds.Text > 59 Then
            lblSeconds.Text = 0
            lblMinutes.Text += 1
        ElseIf lblMinutes.Text > 59 Then
            lblMinutes.Text = 0
            lblHours.Text += 1
        ElseIf lblHours.Text > 99 Then
            tmrStopWatch.Enabled = False
            MessageBox.Show("Too much time...")
        End If
    End Sub

    ' Start/Stop button action
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If tmrStopWatch.Enabled = False Then
            tmrStopWatch.Enabled = True
        Else
            tmrStopWatch.Enabled = False
        End If
    End Sub

    ' Reset button action
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tmrStopWatch.Enabled = False
        lblHours.Text = 0
        lblMinutes.Text = 0
        lblSeconds.Text = 0
    End Sub

    ' Exit button action
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region

#Region "Timer Tab Operations"
    ' Timer timer tick action
    Private Async Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick

        ' Iterate through time like a Time Lord
        If nudSeconds.Value > 0 Then
            nudSeconds.Value -= 1
        ElseIf nudMinutes.Value > 0 Then
            If nudSeconds.Value = 0 Then
                nudMinutes.Value -= 1
                nudSeconds.Value = 59
            End If
        ElseIf nudHours.Value > 0 Then
            If nudMinutes.Value = 0 Then
                If nudSeconds.Value = 0 Then
                    nudHours.Value -= 1
                    nudMinutes.Value = 59
                    nudSeconds.Value = 59
                End If
            End If
        End If

        ' If values are zero, make the timer stop and turn red!
        If nudHours.Value = 0 And nudMinutes.Value = 0 And nudSeconds.Value = 0 Then
            tmrTimer.Enabled = False
            TimerTab.BackColor = Color.Red
            Await Task.Delay(500)
            TimerTab.BackColor = Color.Transparent
            Await Task.Delay(500)
            TimerTab.BackColor = Color.Red
            Await Task.Delay(500)
            TimerTab.BackColor = Color.Transparent
            Await Task.Delay(500)
            TimerTab.BackColor = Color.Red
        End If
    End Sub

    ' Start/Stop button action
    Private Sub btnTimerStart_Click(sender As Object, e As EventArgs) Handles btnTimerStart.Click
        If nudHours.Value <> 0 Or nudMinutes.Value <> 0 Or nudSeconds.Value <> 0 Then
            If tmrTimer.Enabled = False Then
                tmrTimer.Enabled = True
            Else
                tmrTimer.Enabled = False
            End If
        End If

    End Sub

    ' Reset button action
    Private Sub btnTimerReset_Click(sender As Object, e As EventArgs) Handles btnTimerReset.Click
        tmrTimer.Enabled = False
        nudHours.Value = 0
        nudMinutes.Value = 0
        nudSeconds.Value = 0
        TimerTab.BackColor = Color.Transparent
    End Sub

    ' Exit button action
    Private Sub btnTimerExit_Click(sender As Object, e As EventArgs) Handles btnTimerExit.Click
        Me.Close()
    End Sub
#End Region
End Class
