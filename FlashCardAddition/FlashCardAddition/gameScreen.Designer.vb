<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gameScreen
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtMath = New System.Windows.Forms.Label()
        Me.gpBoxScore = New System.Windows.Forms.GroupBox()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.gpBoxScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(31, 214)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(207, 49)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Stop"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtMath
        '
        Me.txtMath.AutoSize = True
        Me.txtMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMath.Location = New System.Drawing.Point(97, 146)
        Me.txtMath.Name = "txtMath"
        Me.txtMath.Size = New System.Drawing.Size(71, 25)
        Me.txtMath.TabIndex = 1
        Me.txtMath.Text = "Label1"
        '
        'gpBoxScore
        '
        Me.gpBoxScore.Controls.Add(Me.lblWrong)
        Me.gpBoxScore.Controls.Add(Me.lblRight)
        Me.gpBoxScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpBoxScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBoxScore.Location = New System.Drawing.Point(153, 12)
        Me.gpBoxScore.Name = "gpBoxScore"
        Me.gpBoxScore.Size = New System.Drawing.Size(119, 72)
        Me.gpBoxScore.TabIndex = 4
        Me.gpBoxScore.TabStop = False
        Me.gpBoxScore.Text = "Your Score"
        Me.gpBoxScore.UseCompatibleTextRendering = True
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Location = New System.Drawing.Point(7, 37)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(49, 15)
        Me.lblWrong.TabIndex = 1
        Me.lblWrong.Text = "Wrong: "
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Location = New System.Drawing.Point(7, 20)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(42, 15)
        Me.lblRight.TabIndex = 0
        Me.lblRight.Text = "Right: "
        '
        'txtResponse
        '
        Me.txtResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponse.Location = New System.Drawing.Point(172, 151)
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.Size = New System.Drawing.Size(100, 38)
        Me.txtResponse.TabIndex = 0
        '
        'gameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtResponse)
        Me.Controls.Add(Me.gpBoxScore)
        Me.Controls.Add(Me.txtMath)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gameScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gameScreen"
        Me.gpBoxScore.ResumeLayout(False)
        Me.gpBoxScore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents txtMath As Label
    Friend WithEvents gpBoxScore As GroupBox
    Friend WithEvents lblWrong As Label
    Friend WithEvents lblRight As Label
    Friend WithEvents txtResponse As TextBox
End Class
