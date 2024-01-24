Imports System.IO.Ports
Public Class Task
    Function ArduinoVB() As Integer
        vTimeStart = Environment.TickCount
        Arduino = New SerialPort(Data.txbCOM.Text, 9600)
        Arduino.Open()
        Do
            vTimeNow = Environment.TickCount - vTimeStart
            Label1.Text = Choices(0, 0) & Choices(0, 1) & Choices(0, 2) & vbCrLf &
                Choices(1, 0) & Choices(1, 1) & Choices(1, 2) & vbCrLf &
                Choices(2, 0) & Choices(2, 1) & Choices(2, 2) & vbCrLf &
                Choices(3, 0) & Choices(3, 1) & Choices(3, 2)
            My.Application.DoEvents()
        Loop
        Return 0
    End Function
    Public Sub Delay()
        If vPhase <> 1 Then
            ProgressBar1.Visible = True
            tmrProgressBar.Enabled = True
        ElseIf vPhase = 1 Then
            tmrDelay.Interval = 2000
        End If
        If vPhase = 3 Then
            Snake_Load()
            'btnButton.Visible = True
            'btnButton.PerformClick()
        End If
        tmrDelay.Enabled = True
    End Sub
    Private Sub btnClick(sender As Object, e As EventArgs) Handles btnIzquierda.Click, btnDerecha.Click
        lblPrefieres.Visible = False
        btnIzquierda.Visible = False
        btnDerecha.Visible = False
        Ref = sender.text.Substring(0, 2)
        If Trial = 1 Then
            If sender.Text = "8 ml ahora" Then
                If ActiveDelay = 5000 Then Choices(0, 0) = False
                If ActiveDelay = 15000 Then Choices(1, 0) = False
                If ActiveDelay = 30000 Then Choices(2, 0) = False
                If ActiveDelay = 60000 Then Choices(3, 0) = False
                WriteLine(1, vTimeNow, sender.Text)
                If vPhase <> 1 Then
                    btnRef.Visible = True
                ElseIf vPhase = 1 Then
                    Delay()
                End If
            Else
                blnWaited = True
                If ActiveDelay = 5000 Then Choices(0, 0) = True
                If ActiveDelay = 15000 Then Choices(1, 0) = True
                If ActiveDelay = 30000 Then Choices(2, 0) = True
                If ActiveDelay = 60000 Then Choices(3, 0) = True
                WriteLine(1, vTimeNow, sender.Text)
                Delay()
            End If
        ElseIf Trial = 2 Then
            If sender.Text = "4 ml ahora" Or sender.Text = "12 ml ahora" Then
                If ActiveDelay = 5000 Then Choices(0, 1) = False
                If ActiveDelay = 15000 Then Choices(1, 1) = False
                If ActiveDelay = 30000 Then Choices(2, 1) = False
                If ActiveDelay = 60000 Then Choices(3, 1) = False
                WriteLine(1, vTimeNow, sender.Text)
                If vPhase <> 1 Then
                    btnRef.Visible = True
                ElseIf vPhase = 1 Then
                    Delay()
                End If
            Else
                blnWaited = True
                If ActiveDelay = 5000 Then Choices(0, 1) = True
                If ActiveDelay = 15000 Then Choices(1, 1) = True
                If ActiveDelay = 30000 Then Choices(2, 1) = True
                If ActiveDelay = 60000 Then Choices(3, 1) = True
                WriteLine(1, vTimeNow, sender.Text)
                Delay()
            End If
        ElseIf Trial = 3 Then
            If sender.Text = "2 ml ahora" Or sender.Text = "6 ml ahora" Or sender.Text = "10 ml ahora" Or sender.Text = "14 ml ahora" Then
                If ActiveDelay = 5000 Then Choices(0, 2) = False
                If ActiveDelay = 15000 Then Choices(1, 2) = False
                If ActiveDelay = 30000 Then Choices(2, 2) = False
                If ActiveDelay = 60000 Then Choices(3, 2) = False
                WriteLine(1, vTimeNow, sender.Text)
                If vPhase <> 1 Then
                    btnRef.Visible = True
                ElseIf vPhase = 1 Then
                    Delay()
                End If
            Else
                blnWaited = True
                If ActiveDelay = 5000 Then Choices(0, 2) = True
                If ActiveDelay = 15000 Then Choices(1, 2) = True
                If ActiveDelay = 30000 Then Choices(2, 2) = True
                If ActiveDelay = 60000 Then Choices(3, 2) = True
                WriteLine(1, vTimeNow, sender.Text)
                Delay()
            End If
        End If
    End Sub
    Private Sub tmrDelay_Tick(sender As Object, e As EventArgs) Handles tmrDelay.Tick
        tmrDelay.Enabled = False
        btnButton.Visible = False
        If vPhase <> 1 Then
            btnRef.Visible = True
        ElseIf vPhase = 1 Then
            BtnRef_()
        End If
        If vPhase = 3 Then Snake_End()
        ProgressBar1.Value = ProgressBar1.Maximum
    End Sub
    Private Sub BtnRef_()
        btnRef.Visible = False
        If Trial = 0 Then
            WriteLine(1, vTimeNow, 0)
            Trial += 1
            ReloadTask()
        Else
            If vPhase <> 1 Then
                Reinforce(Ref)
                If blnWaited = False Then
                    tmrRestart.Enabled = True
                ElseIf blnWaited = True Then
                    blnWaited = False
                    tmrRestart.Interval = (85000 - tmrDelay.Interval)
                    tmrRestart.Enabled = True
                End If
            ElseIf vPhase = 1 Then
                ReloadTask()
            End If
        End If
    End Sub
    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        BtnRef_()
    End Sub
    Private Sub Reinforce(x)
        Dim y
        If x = 2 Then y = 1
        If x = 4 Then y = 2
        If x = 6 Then y = 3
        If x = 8 Then y = 4
        If x = 10 Then y = 5
        If x = 12 Then y = 6
        If x = 14 Then y = 7
        If x = 16 Then y = 8
        Arduino.WriteLine(y)
        WriteLine(1, vTimeNow, x)
    End Sub
    Private Sub tmrRestart_Tick(sender As Object, e As EventArgs) Handles tmrRestart.Tick
        tmrRestart.Enabled = False
        lblEspera.Visible = False
        ReloadTask()
    End Sub
    Private Sub ReloadTask()
        btnRef.Text = "Servir"
        lblPrefieres.Text = "¿Qué prefieres?"
        lblPrefieres.Visible = True
        btnIzquierda.Visible = True
        btnDerecha.Visible = True
        If Delays.Count = 0 Then
            Delays.Add(5000)
            Delays.Add(15000)
            Delays.Add(30000)
            Delays.Add(60000)
        End If
        Dim y As Integer = Rand.Next(Delays.Count)
        ActiveDelay = Delays(y)
        Delays.RemoveAt(y)
        tmrDelay.Interval = ActiveDelay
        tmrRestart.Interval = 85000
        ProgressBar1.Maximum = ActiveDelay
        If vPhase = 1 Then tmrRestart.Interval = 1
        If TaskCount >= 4 Then
            TaskCount = 0
            Trial += 1
            If Trial > 3 Then
                For i = 0 To 3
                    Dim rim As String
                    rim = Choices(i, 0) & "," & Choices(i, 1) & "," & Choices(i, 2)
                    WriteLine(1, rim)
                Next
                Me.Close()
            End If
        End If
        If Trial = 1 Then
            LoadChoices("8 ml ahora", "16 ml en " & CStr(ActiveDelay / 1000) & " segundos")
        ElseIf Trial = 2 Then
            If ActiveDelay = 5000 Then
                If Choices(0, 0) = False Then LoadChoices("4 ml ahora", "16 ml en 5 segundos")
                If Choices(0, 0) = True Then LoadChoices("12 ml ahora", "16 ml en 5 segundos")
            ElseIf ActiveDelay = 15000 Then
                If Choices(1, 0) = False Then LoadChoices("4 ml ahora", "16 ml en 15 segundos")
                If Choices(1, 0) = True Then LoadChoices("12 ml ahora", "16 ml en 15 segundos")
            ElseIf ActiveDelay = 30000 Then
                If Choices(2, 0) = False Then LoadChoices("4 ml ahora", "16 ml en 30 segundos")
                If Choices(2, 0) = True Then LoadChoices("12 ml ahora", "16 ml en 30 segundos")
            ElseIf ActiveDelay = 60000 Then
                If Choices(3, 0) = False Then LoadChoices("4 ml ahora", "16 ml en 60 segundos")
                If Choices(3, 0) = True Then LoadChoices("12 ml ahora", "16 ml en 60 segundos")
            End If
        ElseIf Trial = 3 Then
            If ActiveDelay = 5000 Then
                If Choices(0, 0) = False And Choices(0, 1) = False Then LoadChoices("2 ml ahora", "16 ml en 5 segundos")
                If Choices(0, 0) = False And Choices(0, 1) = True Then LoadChoices("6 ml ahora", "16 ml en 5 segundos")
                If Choices(0, 0) = True And Choices(0, 1) = False Then LoadChoices("10 ml ahora", "16 ml en 5 segundos")
                If Choices(0, 0) = True And Choices(0, 1) = True Then LoadChoices("14 ml ahora", "16 ml en 5 segundos")
            ElseIf ActiveDelay = 15000 Then
                If Choices(1, 0) = False And Choices(1, 1) = False Then LoadChoices("2 ml ahora", "16 ml en 15 segundos")
                If Choices(1, 0) = False And Choices(1, 1) = True Then LoadChoices("6 ml ahora", "16 ml en 15 segundos")
                If Choices(1, 0) = True And Choices(1, 1) = False Then LoadChoices("10 ml ahora", "16 ml en 15 segundos")
                If Choices(1, 0) = True And Choices(1, 1) = True Then LoadChoices("14 ml ahora", "16 ml en 15 segundos")
            ElseIf ActiveDelay = 30000 Then
                If Choices(2, 0) = False And Choices(2, 1) = False Then LoadChoices("2 ml ahora", "16 ml en 30 segundos")
                If Choices(2, 0) = False And Choices(2, 1) = True Then LoadChoices("6 ml ahora", "16 ml en 30 segundos")
                If Choices(2, 0) = True And Choices(2, 1) = False Then LoadChoices("10 ml ahora", "16 ml en 30 segundos")
                If Choices(2, 0) = True And Choices(2, 1) = True Then LoadChoices("14 ml ahora", "16 ml en 30 segundos")
            ElseIf ActiveDelay = 60000 Then
                If Choices(3, 0) = False And Choices(3, 1) = False Then LoadChoices("2 ml ahora", "16 ml en 60 segundos")
                If Choices(3, 0) = False And Choices(3, 1) = True Then LoadChoices("6 ml ahora", "16 ml en 60 segundos")
                If Choices(3, 0) = True And Choices(3, 1) = False Then LoadChoices("10 ml ahora", "16 ml en 60 segundos")
                If Choices(3, 0) = True And Choices(3, 1) = True Then LoadChoices("14 ml ahora", "16 ml en 60 segundos")
            End If
        End If
    End Sub
    '
    Public Sub LoadChoices(x, y)
        Dim choice As New List(Of String)({x, y})
        Dim q As Integer = Rand.Next(choice.Count)
        btnIzquierda.Text = choice(q)
        choice.RemoveAt(q)
        q = Rand.Next(choice.Count)
        btnDerecha.Text = choice(q)
        choice.RemoveAt(q)
        TaskCount += 1
    End Sub
    Private Sub tmrProgressBar_Tick(sender As Object, e As EventArgs) Handles tmrProgressBar.Tick
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            tmrProgressBar.Enabled = False
            ProgressBar1.Visible = False
            lblEspera.Visible = False
            ProgressBar1.Value = 0
            btnRef.Visible = True
        Else
            ProgressBar1.Value = ProgressBar1.Value + ProgressBar1.Maximum / ((ProgressBar1.Maximum) / 500)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnButton.Click
        btnButton.Left = Rand.Next(100, 1100)
        btnButton.Top = Rand.Next(100, 500)
        btnButton.BackColor = Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256))
        WriteLine(1, vTimeNow, 10)
    End Sub
    Private Sub tmrDebug_Tick(sender As Object, e As EventArgs) Handles tmrDebug.Tick
        Me.Text = "Delay:" & ActiveDelay & " Trial:" & Trial & "DelaysLeft" & Delays.Count
    End Sub




    Private CX(50), CY(50) As Integer
    Private Mov, MovAnt As Byte
    Private Lon As Short = 0
    Private Tail(50) As Label
    Private Sub Snake_Load()
        tmrSnake.Enabled = True
        StartGame()
    End Sub
    Private Sub Snake_End()
        tmrSnake.Enabled = False
        GameOver()
        lblSnake.Location = New Point(-60, -60)
        lblFood.Location = New Point(-60, -60)
        lblFood.Visible = False
    End Sub
    Public Sub StartGame()
        'Me.ClientSize = New Size(1920, 1080)
        CX(0) = 180 : CY(0) = 180
        lblSnake.Location = New Point(CX(0), CY(0))
        SpawnTails()
    End Sub
    Private Sub Snake_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right And MovAnt <> 2 Then Mov = 1
        If e.KeyCode = Keys.Left And MovAnt <> 1 Then Mov = 2
        If e.KeyCode = Keys.Down And MovAnt <> 4 Then Mov = 3
        If e.KeyCode = Keys.Up And MovAnt <> 3 Then Mov = 4
        MovAnt = Mov
    End Sub
    Private Sub tmrSnake_Tick(sender As Object, e As EventArgs) Handles tmrSnake.Tick
        For i As Short = Lon To 1 Step -1
            CX(i) = CX(i - 1)
            CY(i) = CY(i - 1)
            Tail(i - 1).SetBounds(CX(i), CY(i), Tail(i - 1).Width, Tail(i - 1).Height)
        Next i
        If Mov = 1 Then CX(0) = CX(0) + 60
        If Mov = 2 Then CX(0) = CX(0) - 60
        If Mov = 3 Then CY(0) = CY(0) + 60
        If Mov = 4 Then CY(0) = CY(0) - 60
        If lblFood.Visible = False Then SpawnFood()
        If CX(0) = lblFood.Location.X And CY(0) = lblFood.Location.Y Then
            Lon += 1
            CX(Lon) = CX(Lon - 1)
            CY(Lon) = CY(Lon - 1)
            Tail(Lon - 1).SetBounds(CX(Lon), CY(Lon), Tail(Lon - 1).Width, Tail(Lon - 1).Height)
            Tail(Lon - 1).Visible = True
            lblFood.Visible = False
        End If
        lblSnake.SetBounds(CX(0), CY(0), 60, 60)
        If CX(0) >= 1400 Or CY(0) >= 750 Or CX(0) <= -10 Or CY(0) <= -10 Then
            GameOver()
        End If
        If Lon > 1 Then
            For i = 1 To Lon
                If CX(0) = CX(i) And CY(0) = CY(i) Then
                    GameOver()
                End If
            Next
        End If
    End Sub
    Private Sub SpawnTails()
        For a As Short = 0 To 50
            Tail(a) = New Label
            Tail(a).AutoSize = False
            Tail(a).Size = New Size(60, 60)
            Tail(a).Image = My.Resources.ball1
            Tail(a).BackColor = Color.Transparent
            Me.Controls.Add(Tail(a))
            Tail(a).Visible = False
        Next
    End Sub
    Private Sub SpawnFood()
        Randomize()
        Dim CFX, CFY As Integer
        CFX = Int(23 * Rnd() + 0)
        CFY = Int(13 * Rnd() + 0)
        lblFood.SetBounds(CFX * 60, CFY * 60, 60, 60)
        lblFood.Visible = True
    End Sub
    Public Sub GameOver()
        If Lon > 0 Then
            For i = 0 To Tail.Length - 1
                Tail(i).Dispose()
            Next
        End If
        Lon = 0
        Mov = 0
        StartGame()
    End Sub
End Class