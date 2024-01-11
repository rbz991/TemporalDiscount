Public Class Filler
    Private Sub tmrFiller_Tick(sender As Object, e As EventArgs) Handles tmrFiller.Tick
        Button1.BackColor = Color.Black
        Button2.BackColor = Color.Black
        Button3.BackColor = Color.Black
        Button4.BackColor = Color.Black
        Button5.BackColor = Color.Black
        Button6.BackColor = Color.Black
        Button7.BackColor = Color.Black
        Button8.BackColor = Color.Black
        Button9.BackColor = Color.Black
        tmrFiller.Enabled = False
    End Sub
    Private Sub Filler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        If tmrFiller.Enabled = False Then
            If sender.Text = AciertosFiller Then
                sender.BackColor = Color.Green
                AciertosFiller += 1
                If AciertosFiller = 9 Then
                    'reset
                    tmrResetFiller.Enabled = True
                End If
            Else
                sender.BackColor = Color.Red
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
                tmrResetFiller.Enabled = True
            End If
        End If
    End Sub
    Private Sub tmrResetFiller_Tick(sender As Object, e As EventArgs) Handles tmrResetFiller.Tick
        tmrResetFiller.Enabled = False
        AciertosFiller = 1 'Siempre debe comenzar en 1 pues calcula el correcto sumando cada intento
        If FillerCount >= 3 Then
            FillerCount = 0
            Dim y As New Task
            y.Show()
            Me.Close()
        Else
            FillerCount += 1
            Dim y As New Filler
            y.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        btnComenzar.Visible = False
        lblIndicacion.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        Dim Numbers As New List(Of Integer)({1, 2, 3, 4, 5, 6, 7, 8, 9})
        Dim Rand As New Random
        Dim x As Integer = Rand.Next(Numbers.Count)
        Button1.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button2.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button3.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button4.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button5.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button6.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button7.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button8.Text = Numbers(x)
        Numbers.RemoveAt(x)
        x = Rand.Next(Numbers.Count)
        Button9.Text = Numbers(x)
        Numbers.RemoveAt(x)
        tmrFiller.Enabled = True
    End Sub
End Class