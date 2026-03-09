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
        Me.Horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.Font = New System.Drawing.Font("Ebrima", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.Location = New System.Drawing.Point(51, 49)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(111, 86)
        Me.Horas.TabIndex = 0
        Me.Horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 86)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.Font = New System.Drawing.Font("Ebrima", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.Location = New System.Drawing.Point(180, 49)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(111, 86)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.Font = New System.Drawing.Font("Ebrima", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dias.Location = New System.Drawing.Point(56, 178)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(141, 59)
        Me.Dias.TabIndex = 3
        Me.Dias.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Ebrima", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(58, 237)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(343, 45)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "09 de Marzo del 2026"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 355)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Horas)
        Me.Name = "Form1"
        Me.Text = "Reloj Digital"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Dias As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
End Class
