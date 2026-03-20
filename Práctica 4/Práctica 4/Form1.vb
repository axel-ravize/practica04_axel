Public Class Form1
    Dim Formato As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Iniciar los Timers
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Crear una variable, le asigna un valor, el valor es la fecha del día de hoy convertida a String
        ' En el formato de "dd 'de' MMMM 'del' yyyy" (dd- número del día, MMMM- el mes en texto, yyyy- para el año)
        Dim Date_O = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_O = DateTime.Now.ToString("dddd")
        Dim Time_O As String = ""


        ' Este es el formato de 24h
        If Formato = True Then
            Time_O = DateTime.Now.ToString("HH:mm:ss")
        ElseIf Formato = False Then
            Time_O = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_Mod = Time_O.Split(":")
        ' Time_Mod(0) = "08"
        ' Time_Mod(1) = "06"
        ' Time_Mod(2) = "56"
        ' Time_Mod(3) = "12"
        Horas.Text = Time_Mod(0)
        Minutos.Text = Time_Mod(1)
        Segundos.Text = Time_Mod(2)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Color_Texto As String = ComboBox1.SelectedItem.ToString()
        If Color_Texto = "Blanco" Then
            Horas.ForeColor = Color.White
            Minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Dias.ForeColor = Color.White
            Fecha.ForeColor = Color.White
        ElseIf Color_Texto = "Rojo" Then
            Horas.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Dias.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
        ElseIf Color_Texto = "Azul" Then
            Horas.ForeColor = Color.Blue
            Minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Dias.ForeColor = Color.Blue
            Fecha.ForeColor = Color.Blue
        ElseIf Color_Texto = "Amarillo" Then
            Horas.ForeColor = Color.Yellow
            Minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Dias.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow
        ElseIf Color_Texto = "Verde" Then
            Horas.ForeColor = Color.Green
            Minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Dias.ForeColor = Color.Green
            Fecha.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Formato = True Then
            Button1.Text = "12h"
            Formato = False
        ElseIf Formato = False Then
            Button1.Text = "24h"
            Formato = True
        End If
    End Sub
End Class
