<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStopTime
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStopTime))
        Me.tbStopTime = New System.Windows.Forms.TabControl()
        Me.StopWatchTab = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.TimerTab = New System.Windows.Forms.TabPage()
        Me.btnTimerExit = New System.Windows.Forms.Button()
        Me.btnTimerReset = New System.Windows.Forms.Button()
        Me.btnTimerStart = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudSeconds = New System.Windows.Forms.NumericUpDown()
        Me.nudMinutes = New System.Windows.Forms.NumericUpDown()
        Me.nudHours = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AboutTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrStopWatch = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDate = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StopTimeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.tbStopTime.SuspendLayout()
        Me.StopWatchTab.SuspendLayout()
        Me.TimerTab.SuspendLayout()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AboutTab.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbStopTime
        '
        Me.tbStopTime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbStopTime.Controls.Add(Me.StopWatchTab)
        Me.tbStopTime.Controls.Add(Me.TimerTab)
        Me.tbStopTime.Controls.Add(Me.AboutTab)
        Me.tbStopTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStopTime.Location = New System.Drawing.Point(12, 12)
        Me.tbStopTime.Name = "tbStopTime"
        Me.tbStopTime.SelectedIndex = 0
        Me.tbStopTime.Size = New System.Drawing.Size(375, 275)
        Me.tbStopTime.TabIndex = 8
        '
        'StopWatchTab
        '
        Me.StopWatchTab.BackColor = System.Drawing.Color.Transparent
        Me.StopWatchTab.Controls.Add(Me.Label6)
        Me.StopWatchTab.Controls.Add(Me.Label5)
        Me.StopWatchTab.Controls.Add(Me.Label4)
        Me.StopWatchTab.Controls.Add(Me.btnReset)
        Me.StopWatchTab.Controls.Add(Me.btnExit)
        Me.StopWatchTab.Controls.Add(Me.lblSeconds)
        Me.StopWatchTab.Controls.Add(Me.lblMinutes)
        Me.StopWatchTab.Controls.Add(Me.lblHours)
        Me.StopWatchTab.Controls.Add(Me.btnStart)
        Me.StopWatchTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopWatchTab.Location = New System.Drawing.Point(4, 25)
        Me.StopWatchTab.Name = "StopWatchTab"
        Me.StopWatchTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StopWatchTab.Size = New System.Drawing.Size(367, 246)
        Me.StopWatchTab.TabIndex = 0
        Me.StopWatchTab.Text = "StopWatch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 29)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 31)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "StopWatch"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(62, 176)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(118, 43)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.StopTimeToolTip.SetToolTip(Me.btnReset, "Reset the StopWatch to zero and stop the timer.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(186, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 43)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.StopTimeToolTip.SetToolTip(Me.btnExit, "Exit the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSeconds
        '
        Me.lblSeconds.BackColor = System.Drawing.Color.Silver
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(252, 65)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(62, 41)
        Me.lblSeconds.TabIndex = 12
        Me.lblSeconds.Text = "0"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StopTimeToolTip.SetToolTip(Me.lblSeconds, "Seconds")
        '
        'lblMinutes
        '
        Me.lblMinutes.BackColor = System.Drawing.Color.Silver
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(156, 65)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(64, 41)
        Me.lblMinutes.TabIndex = 11
        Me.lblMinutes.Text = "0"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StopTimeToolTip.SetToolTip(Me.lblMinutes, "Minutes")
        '
        'lblHours
        '
        Me.lblHours.BackColor = System.Drawing.Color.Silver
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(53, 65)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(71, 41)
        Me.lblHours.TabIndex = 10
        Me.lblHours.Text = "0"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StopTimeToolTip.SetToolTip(Me.lblHours, "Hours")
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(62, 129)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(242, 43)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start/Stop"
        Me.StopTimeToolTip.SetToolTip(Me.btnStart, "Start or stop the StopWatch.")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'TimerTab
        '
        Me.TimerTab.BackColor = System.Drawing.Color.Transparent
        Me.TimerTab.Controls.Add(Me.TimerLabel)
        Me.TimerTab.Controls.Add(Me.btnTimerExit)
        Me.TimerTab.Controls.Add(Me.btnTimerReset)
        Me.TimerTab.Controls.Add(Me.btnTimerStart)
        Me.TimerTab.Controls.Add(Me.Label9)
        Me.TimerTab.Controls.Add(Me.Label8)
        Me.TimerTab.Controls.Add(Me.nudSeconds)
        Me.TimerTab.Controls.Add(Me.nudMinutes)
        Me.TimerTab.Controls.Add(Me.nudHours)
        Me.TimerTab.Controls.Add(Me.Label7)
        Me.TimerTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerTab.Location = New System.Drawing.Point(4, 25)
        Me.TimerTab.Name = "TimerTab"
        Me.TimerTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TimerTab.Size = New System.Drawing.Size(367, 246)
        Me.TimerTab.TabIndex = 1
        Me.TimerTab.Text = "Timer"
        '
        'btnTimerExit
        '
        Me.btnTimerExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerExit.Location = New System.Drawing.Point(186, 176)
        Me.btnTimerExit.Name = "btnTimerExit"
        Me.btnTimerExit.Size = New System.Drawing.Size(118, 43)
        Me.btnTimerExit.TabIndex = 25
        Me.btnTimerExit.Text = "Exit"
        Me.StopTimeToolTip.SetToolTip(Me.btnTimerExit, "Exit the program.")
        Me.btnTimerExit.UseVisualStyleBackColor = True
        '
        'btnTimerReset
        '
        Me.btnTimerReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerReset.Location = New System.Drawing.Point(62, 176)
        Me.btnTimerReset.Name = "btnTimerReset"
        Me.btnTimerReset.Size = New System.Drawing.Size(118, 43)
        Me.btnTimerReset.TabIndex = 24
        Me.btnTimerReset.Text = "Reset"
        Me.StopTimeToolTip.SetToolTip(Me.btnTimerReset, "Reset the Timer to zero and stop the Timer.")
        Me.btnTimerReset.UseVisualStyleBackColor = True
        '
        'btnTimerStart
        '
        Me.btnTimerStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerStart.Location = New System.Drawing.Point(62, 127)
        Me.btnTimerStart.Name = "btnTimerStart"
        Me.btnTimerStart.Size = New System.Drawing.Size(242, 43)
        Me.btnTimerStart.TabIndex = 22
        Me.btnTimerStart.Text = "Start/Stop"
        Me.StopTimeToolTip.SetToolTip(Me.btnTimerStart, "Start or stop the Timer.")
        Me.btnTimerStart.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(237, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 29)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = ":"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 29)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudSeconds
        '
        Me.nudSeconds.AutoSize = True
        Me.nudSeconds.BackColor = System.Drawing.Color.Silver
        Me.nudSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSeconds.Location = New System.Drawing.Point(257, 62)
        Me.nudSeconds.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudSeconds.Name = "nudSeconds"
        Me.nudSeconds.Size = New System.Drawing.Size(73, 43)
        Me.nudSeconds.TabIndex = 19
        Me.nudSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StopTimeToolTip.SetToolTip(Me.nudSeconds, "Seconds")
        '
        'nudMinutes
        '
        Me.nudMinutes.AutoSize = True
        Me.nudMinutes.BackColor = System.Drawing.Color.Silver
        Me.nudMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMinutes.Location = New System.Drawing.Point(158, 62)
        Me.nudMinutes.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudMinutes.Name = "nudMinutes"
        Me.nudMinutes.Size = New System.Drawing.Size(73, 43)
        Me.nudMinutes.TabIndex = 18
        Me.nudMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StopTimeToolTip.SetToolTip(Me.nudMinutes, "Minutes")
        '
        'nudHours
        '
        Me.nudHours.AutoSize = True
        Me.nudHours.BackColor = System.Drawing.Color.Silver
        Me.nudHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHours.Location = New System.Drawing.Point(33, 62)
        Me.nudHours.Name = "nudHours"
        Me.nudHours.Size = New System.Drawing.Size(93, 43)
        Me.nudHours.TabIndex = 17
        Me.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StopTimeToolTip.SetToolTip(Me.nudHours, "Hours")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 31)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Timer"
        '
        'AboutTab
        '
        Me.AboutTab.Controls.Add(Me.Label1)
        Me.AboutTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutTab.Location = New System.Drawing.Point(4, 25)
        Me.AboutTab.Name = "AboutTab"
        Me.AboutTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AboutTab.Size = New System.Drawing.Size(367, 246)
        Me.AboutTab.TabIndex = 2
        Me.AboutTab.Text = "About"
        Me.AboutTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 240)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrStopWatch
        '
        Me.tmrStopWatch.Interval = 1000
        '
        'tmrDate
        '
        Me.tmrDate.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslDate, Me.tslTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 297)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(399, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StopTimeToolTip.SetToolTip(Me.StatusStrip1, "Current date and time.")
        '
        'tslDate
        '
        Me.tslDate.Name = "tslDate"
        Me.tslDate.Size = New System.Drawing.Size(0, 17)
        '
        'tslTime
        '
        Me.tslTime.Name = "tslTime"
        Me.tslTime.Size = New System.Drawing.Size(0, 17)
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 1000
        '
        'TimerLabel
        '
        Me.TimerLabel.Cursor = System.Windows.Forms.Cursors.Help
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(342, 218)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(22, 25)
        Me.TimerLabel.TabIndex = 26
        Me.TimerLabel.Text = "?"
        Me.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StopTimeToolTip.SetToolTip(Me.TimerLabel, "Click up and down on hours, minutes, and seconds. Screen will flash red when time" &
        " is complete." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'frmStopTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 319)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbStopTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStopTime"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StopTime!"
        Me.tbStopTime.ResumeLayout(False)
        Me.StopWatchTab.ResumeLayout(False)
        Me.StopWatchTab.PerformLayout()
        Me.TimerTab.ResumeLayout(False)
        Me.TimerTab.PerformLayout()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AboutTab.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbStopTime As TabControl
    Friend WithEvents StopWatchTab As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents TimerTab As TabPage
    Friend WithEvents tmrStopWatch As System.Windows.Forms.Timer
    Friend WithEvents tmrDate As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslDate As ToolStripStatusLabel
    Friend WithEvents tslTime As ToolStripStatusLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTimerExit As Button
    Friend WithEvents btnTimerReset As Button
    Friend WithEvents btnTimerStart As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nudSeconds As NumericUpDown
    Friend WithEvents nudMinutes As NumericUpDown
    Friend WithEvents nudHours As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents AboutTab As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents StopTimeToolTip As ToolTip
    Friend WithEvents TimerLabel As Label
End Class
