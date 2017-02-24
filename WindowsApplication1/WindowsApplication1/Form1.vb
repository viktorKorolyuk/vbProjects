Public Class Form1
    Dim moving As Boolean = False
    Dim xDif, yDif As Double
    'Start moving the window when the user clicks and holds
    Private Sub mvStart(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        moving = True
        'subtract frame location from mouse cursor position to get relative location of mouse in frame.
        xDif = Cursor.Position.X - Me.Left
        yDif = Cursor.Position.Y - Me.Top
    End Sub
    'if the user lets go of the mouse, stop moving
    Private Sub mvStop(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        moving = False
    End Sub
    'move the window
    Private Sub mvMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If moving = True Then
            'take the current mouse position and subtract the relative distance of the original click
            Me.Left = Cursor.Position.X - xDif
            Me.Top = Cursor.Position.Y - yDif
        End If
    End Sub
    'close the window
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
