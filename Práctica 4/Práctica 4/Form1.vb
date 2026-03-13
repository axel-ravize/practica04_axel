Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_O = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_O = DateTime.Now.ToString("dddd")
        Dim Time_O = DateTime.Now.ToString("HH:mm")

        Dim Time_Mod = Time_O.Split(":")

        Horas.Text = Time_Mod(0)
        Minutos.Text = Time_Mod(1)
        Dias.Text = Day_O
        Fecha.Text = Date_O
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub Config_Click(sender As Object, e As EventArgs) Handles Config.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub
End Class
