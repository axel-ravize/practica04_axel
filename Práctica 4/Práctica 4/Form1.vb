Public Class Form1
    Dim Formato As Boolean = True
    Dim Boton_Start As Boolean = False
    Dim Tiempo_Crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Iniciar los Timers
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Crear una variable, le asigna un valor, el valor es la fecha del día de hoy convertida a String
        ' En el formato de "dd 'de' MMMM 'del' yyyy" (dd es el número del día, MMMM es el mes en texto, yyyy es para el año)
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

        If Label3.Text = ":" Then
            Label3.Text = ""
        ElseIf Label3.Text = "" Then
            Label3.Text = ":"
        End If
    End Sub

    ' Boton de Configuraciones
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
            Segundos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Dias.ForeColor = Color.White
            Fecha.ForeColor = Color.White

        ElseIf Color_Texto = "Rojo" Then
            Horas.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Segundos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            Dias.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red

        ElseIf Color_Texto = "Azul" Then
            Horas.ForeColor = Color.Aqua
            Minutos.ForeColor = Color.Aqua
            Segundos.ForeColor = Color.Aqua
            Label1.ForeColor = Color.Aqua
            Label3.ForeColor = Color.Aqua
            Dias.ForeColor = Color.Aqua
            Fecha.ForeColor = Color.Aqua

        ElseIf Color_Texto = "Amarillo" Then
            Horas.ForeColor = Color.Yellow
            Minutos.ForeColor = Color.Yellow
            Segundos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Label3.ForeColor = Color.Yellow
            Dias.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow

        ElseIf Color_Texto = "Verde" Then
            Horas.ForeColor = Color.Lime
            Minutos.ForeColor = Color.Lime
            Segundos.ForeColor = Color.Lime
            Label1.ForeColor = Color.Lime
            Label3.ForeColor = Color.Lime
            Dias.ForeColor = Color.Lime
            Fecha.ForeColor = Color.Lime
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

    ' Código para el cronómetro

    Private StartTime As DateTime
    Private Elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If Boton_Start = False Then
            Timer3.Enabled = True
            Boton_Start = True
            Start.Text = "Stop"
            StartTime = DateTime.Now

        ElseIf Boton_Start = True Then
            Timer3.Enabled = False
            Boton_Start = False
            Start.Text = "Start"
            Elapsed += DateTime.Now - StartTime
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Elapsed = TimeSpan.Zero
        Timer3.Enabled = False
        Tiempo.Text = "00:00:00.00"
        Boton_Start = False
        Start.Text = "Start"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Current = Elapsed + (DateTime.Now - StartTime)
        Tiempo.Text = Current.ToString("hh\:mm\:ss\.ff")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    ' Código del temporizador
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        ElseIf Panel3.Visible = False Then
            Panel3.Visible = True
        End If
    End Sub
End Class
