Public Class Snake
    Private CX(50), CY(50) As Integer
    Private Mov, MovAnt As Byte
    Private Lon As Short = 0
    Private Tail(50) As Label


    Private Sub Snake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(1400, 800)
        CX(0) = 200 : CY(0) = 200
        lblSnake.Location = New Point(CX(0), CY(0))
        tmrSnake.Enabled = True
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

        If Mov = 1 Then CX(0) = CX(0) + 50
        If Mov = 2 Then CX(0) = CX(0) - 50
        If Mov = 3 Then CY(0) = CY(0) + 50
        If Mov = 4 Then CY(0) = CY(0) - 50

        If lblFood.Visible = False Then SpawnFood()

        If CX(0) = lblFood.Location.X And CY(0) = lblFood.Location.Y Then
            Lon += 1
            CX(Lon) = CX(Lon - 1)
            CY(Lon) = CY(Lon - 1)
            Tail(Lon - 1).SetBounds(CX(Lon), CY(Lon), Tail(Lon - 1).Width, Tail(Lon - 1).Height)
            Tail(Lon - 1).Visible = True

            lblFood.Visible = False
        End If



        lblSnake.SetBounds(CX(0), CY(0), 50, 50)
    End Sub

    Private Sub SpawnTails()
        For a As Short = 0 To 50
            Tail(a) = New Label
            Tail(a).AutoSize = False
            Tail(a).Size = New Size(50, 50)
            Tail(a).Image = My.Resources.ball1
            Tail(a).BackColor = Color.Transparent
            Me.Controls.Add(Tail(a))
            Tail(a).Visible = False
        Next
    End Sub

    Private Sub SpawnFood()
        Randomize()
        Dim CFX, CFY As Integer
        CFX = Int(28 * Rnd() + 0)
        CFY = Int(16 * Rnd() + 0)
        lblFood.SetBounds(CFX * 50, CFY * 50, 50, 50)
        lblFood.Visible = True
    End Sub
End Class