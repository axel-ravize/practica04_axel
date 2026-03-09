Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
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
End Class
