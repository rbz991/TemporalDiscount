Imports System.IO.Ports

Module Module1
    Public Arduinobln As Boolean = False
    Public PuntajeFiller As Integer = 0
    Public AciertosFiller As Integer = 1
    Public FillerCount As Integer = 0
    Public TaskCount As Integer = 0
    Public Trial As Integer = 0
    Public blnWaited As Boolean = False
    Public Ref As Integer = 0
    Public Delays As New List(Of Integer)({5000, 15000, 30000, 60000})
    Public Choices(3, 2) As Boolean
    Public vPhase As Integer = 0
    Public vTimeStart As Integer = 0
    Public vTimeNow As Integer = 0
    Public ActiveDelay As Integer = 0
    Public blnIO As Boolean = False
    Public Rand As New Random
    Public Arduino As SerialPort
    Public Snaek As New Snake
End Module
