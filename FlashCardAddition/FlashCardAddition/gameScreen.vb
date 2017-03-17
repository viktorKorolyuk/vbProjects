Public Class gameScreen
    Dim exists As Boolean = False
    Dim char1, char2 As Integer
    Dim min, max As Integer
    Dim margin As Integer = 20
    Dim right, wrong As Integer
    Public Sub New(_min As Integer, _max As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        min = _min
        max = _max
    End Sub
    Private Sub gameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = WindowState.Maximized
        'Panel1.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - Panel1.Width, Screen.PrimaryScreen.Bounds.Height / 2 - Panel1.Height)

        'resizing and repositioning stop button
        btnClose.Location = New Point(0, Screen.PrimaryScreen.Bounds.Height - btnClose.Height * 2)
        btnClose.Width = Screen.PrimaryScreen.Bounds.Width
        btnClose.Height = btnClose.Height * 2

        'Setting maximum length of text to modify all variables that depend on it
        txtMath.Text = max & " + " & max & " = "
        txtMath.Font = New Font("Arial", Screen.PrimaryScreen.Bounds.Height / txtMath.Text.Length)
        txtMath.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - txtMath.Width + 20, Screen.PrimaryScreen.Bounds.Height / 2 - txtMath.Height)

        'setting position of the response textbox

        txtResponse.Width = txtMath.Font.Size * 3
        txtResponse.Font = txtMath.Font
        txtResponse.Location = New Point(txtMath.Location.X + txtMath.Width, txtMath.Location.Y)

        gpBoxScore.Location = New Point(Screen.PrimaryScreen.Bounds.Width - gpBoxScore.Width, 0)
        'starting game 
        changeState()
    End Sub

    Private Sub setRight()
        right += 1
        txtMath.ForeColor = Color.Green
    End Sub

    Private Sub checkEnter(sender As Object, e As KeyPressEventArgs) Handles txtResponse.KeyPress
        Select Case (e.KeyChar)
            Case ControlChars.Cr
                If (txtResponse.Text <> "") Then
                    changeState()
                End If
            Case CChar("0") To CChar("9"), CChar(".")
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub setWrong()
        wrong += 1
        txtMath.ForeColor = Color.Red
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub changeState() Handles MyBase.MouseDown, txtMath.MouseClick
        If (exists) Then
            txtMath.Text = char1 & " + " & char2 & " = " + (char1 + char2).ToString
            If (CDbl(txtResponse.Text) - (char1 + char2) = 0) Then
                'Correct
                setRight()
            Else
                'Incorrect
                setWrong()
            End If

            lblRight.Text = "Right: " + right.ToString
            lblWrong.Text = "Wrong: " + wrong.ToString

            txtResponse.Visible = False
            exists = False
            ' changeState()
        Else

            Dim r As New Random()
            char1 = r.Next(min, max + 1)
            char2 = r.Next(min, max + 1)
            txtMath.ForeColor = Color.Black
            txtMath.Text = char1 & " + " & char2 & " = "
            txtResponse.Visible = True
            txtResponse.Text = "" 'empty the text

            exists = True
        End If

    End Sub
End Class