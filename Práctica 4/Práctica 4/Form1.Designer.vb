<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Config = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tiempo = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Segundos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Config, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.BackColor = System.Drawing.SystemColors.WindowText
        Me.Horas.Font = New System.Drawing.Font("Ebrima", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.ForeColor = System.Drawing.Color.Lime
        Me.Horas.Location = New System.Drawing.Point(40, 149)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(84, 65)
        Me.Horas.TabIndex = 0
        Me.Horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(107, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.BackColor = System.Drawing.SystemColors.WindowText
        Me.Minutos.Font = New System.Drawing.Font("Ebrima", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.ForeColor = System.Drawing.Color.Lime
        Me.Minutos.Location = New System.Drawing.Point(130, 149)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(84, 65)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.BackColor = System.Drawing.SystemColors.WindowText
        Me.Dias.Font = New System.Drawing.Font("Ebrima", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dias.ForeColor = System.Drawing.Color.Lime
        Me.Dias.Location = New System.Drawing.Point(118, 251)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(114, 47)
        Me.Dias.TabIndex = 3
        Me.Dias.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.SystemColors.WindowText
        Me.Fecha.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.Lime
        Me.Fecha.Location = New System.Drawing.Point(45, 307)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(263, 32)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "09 de Marzo del 2026"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 535)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Config
        '
        Me.Config.Image = CType(resources.GetObject("Config.Image"), System.Drawing.Image)
        Me.Config.Location = New System.Drawing.Point(264, 364)
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(35, 35)
        Me.Config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Config.TabIndex = 6
        Me.Config.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(51, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 215)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(60, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(88, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "24h"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuraciones"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Tiempo)
        Me.Panel2.Controls.Add(Me.Reset)
        Me.Panel2.Controls.Add(Me.Start)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(52, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 215)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'Tiempo
        '
        Me.Tiempo.AutoSize = True
        Me.Tiempo.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo.Location = New System.Drawing.Point(33, 80)
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.Size = New System.Drawing.Size(185, 45)
        Me.Tiempo.TabIndex = 3
        Me.Tiempo.Text = "00:00:00.00"
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(147, 151)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 2
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(29, 151)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(64, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cronómetro"
        '
        'Segundos
        '
        Me.Segundos.AutoSize = True
        Me.Segundos.BackColor = System.Drawing.SystemColors.WindowText
        Me.Segundos.Font = New System.Drawing.Font("Ebrima", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Segundos.ForeColor = System.Drawing.Color.Lime
        Me.Segundos.Location = New System.Drawing.Point(225, 149)
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(84, 65)
        Me.Segundos.TabIndex = 8
        Me.Segundos.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(197, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 65)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = ":"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(223, 364)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(182, 364)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(52, 141)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 216)
        Me.Panel3.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 45)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "00:00"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(149, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(31, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "5 minutos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(58, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Temporizador"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 531)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Config)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Segundos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Reloj Digital"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Config, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Dias As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Config As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Segundos As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Tiempo As Label
    Friend WithEvents Reset As Button
    Friend WithEvents Start As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
End Class
