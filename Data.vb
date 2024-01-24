Imports System.IO.Ports
Public Class Data
    Public Arduino As SerialPort
    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        If vPhase = 0 Or txbParticipante.Text = "" Or IsNumeric(txbSesion.Text) = False Or txbCOM.Text = "" Then
            MsgBox("Por favor verifica que los datos ingresados sean correctos.")
        Else
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            txbParticipante.Visible = False
            txbCOM.Visible = False
            txbSesion.Visible = False
            btnFinalizar.Visible = True
            btnComenzar.Visible = False
            vTimeStart = Environment.TickCount
            FileOpen(1, "C:\Data\" & txbParticipante.Text & "_" & txbSesion.Text & ".txt", OpenMode.Append)
            WriteLine(1, "Participante: " & txbParticipante.Text)
            WriteLine(1, "Sesion: " & txbSesion.Text)
            WriteLine(1, "Fase: " & vPhase)
            Arduino.Close()
            Dim x As New Task
            x.Show()
            x.ArduinoVB()
        End If
    End Sub
    Private Sub rdoPhase1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPhase1.CheckedChanged, rdoPhase2.CheckedChanged, rdoPhase3.CheckedChanged
        vPhase = sender.Text.Substring(5)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Arduinobln = False Then
            Arduinobln = True
            Arduino = New SerialPort(txbCOM.Text, 9600)
            Arduino.Open()
        End If
        If blnIO = False Then
            blnIO = True
            Arduino.WriteLine("Q")
        ElseIf blnIO = True Then
            blnIO = False
            Arduino.WriteLine("q")
        End If
    End Sub
    Private Sub btnFinalizar_Click_1(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        End
    End Sub
End Class
