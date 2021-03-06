# vbProjects
## Index
 * [Intro](##Introduction)
 * [Custom Draggable Window](##Custom-Draggable-Window)

## Introduction
This is a collection of my visualbasic projects done in my highschool ICS class.
Download them and use them however you wan't (following microsoft/legal rules).

## Draggable Windows
Windows OS is popular due to its graphical user-interface/eye-candy.
Windows 7 has a unique GUI for windows which is very easy to understand and use, 
but in certain cases developers need more freedom to manipulate the application style at a higher level.
Thankfully, VisualBasic has a feature called `FromBorderStyle` which allows the developer to change the border of the form.

When the `FromBorderStyle = none` property is applied. 
The border disapears and leaves a clean, sharp look to the form; BUT the user cannot move the window from its location on the screen, this can lead to dissatisfied users and loss of customers.

### Solution:
```VB
Dim moving As Boolean = False
Dim xDif, yDif

'when user clicks and holds the mouse, start dragging
Private Sub moveStrt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
  moving = True
  'grab position of cursor relative to the form
  xDif = Cursor.Position.X - Me.Left
  yDif = Cursor.Position.Y - Me.Top
End Sub
'stop dragging if user lets go of mouse
Private Sub moveEnd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
  moving = False
End Sub

'move the form
Private Sub moveMv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
  If moving Then
    'Get the cursor position and subtract the relave-original distance to keep the cursor in the "same location".
    Me.Left = Cursor.Position.X - xDif
    Me.Top = Cursor.Position.Y - yDif
  End If
End Sub

'in case you have a button intended to close the window
Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
  Close()
End Sub

```
I have created a class library which can be added to your VisualBasic project through `project --> add reference` menu avaliable [here](https://github.com/viktorKorolyuk/vbProjects/blob/master/dragWindow_lib_compiled.zip).
