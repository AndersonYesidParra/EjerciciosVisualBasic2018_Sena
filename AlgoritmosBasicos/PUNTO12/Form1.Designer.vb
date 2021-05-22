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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUno = New System.Windows.Forms.TextBox()
        Me.txtDos = New System.Windows.Forms.TextBox()
        Me.txtTres = New System.Windows.Forms.TextBox()
        Me.txtporcentajeuno = New System.Windows.Forms.TextBox()
        Me.txtporcentajedos = New System.Windows.Forms.TextBox()
        Me.txtporcentajetres = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dinero de la empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Persona 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Persona 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Personas 3:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Persona 1 porcentaje:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Persona 2 porcentaje:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Personas 3 porcentaje:"
        '
        'txtUno
        '
        Me.txtUno.Location = New System.Drawing.Point(173, 72)
        Me.txtUno.Name = "txtUno"
        Me.txtUno.Size = New System.Drawing.Size(100, 20)
        Me.txtUno.TabIndex = 3
        '
        'txtDos
        '
        Me.txtDos.Location = New System.Drawing.Point(173, 108)
        Me.txtDos.Name = "txtDos"
        Me.txtDos.Size = New System.Drawing.Size(100, 20)
        Me.txtDos.TabIndex = 3
        '
        'txtTres
        '
        Me.txtTres.Location = New System.Drawing.Point(173, 138)
        Me.txtTres.Name = "txtTres"
        Me.txtTres.Size = New System.Drawing.Size(100, 20)
        Me.txtTres.TabIndex = 3
        '
        'txtporcentajeuno
        '
        Me.txtporcentajeuno.Location = New System.Drawing.Point(207, 220)
        Me.txtporcentajeuno.Name = "txtporcentajeuno"
        Me.txtporcentajeuno.Size = New System.Drawing.Size(100, 20)
        Me.txtporcentajeuno.TabIndex = 3
        '
        'txtporcentajedos
        '
        Me.txtporcentajedos.Location = New System.Drawing.Point(207, 256)
        Me.txtporcentajedos.Name = "txtporcentajedos"
        Me.txtporcentajedos.Size = New System.Drawing.Size(100, 20)
        Me.txtporcentajedos.TabIndex = 3
        '
        'txtporcentajetres
        '
        Me.txtporcentajetres.Location = New System.Drawing.Point(207, 286)
        Me.txtporcentajetres.Name = "txtporcentajetres"
        Me.txtporcentajetres.Size = New System.Drawing.Size(100, 20)
        Me.txtporcentajetres.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 343)
        Me.Controls.Add(Me.txtporcentajetres)
        Me.Controls.Add(Me.txtporcentajedos)
        Me.Controls.Add(Me.txtTres)
        Me.Controls.Add(Me.txtporcentajeuno)
        Me.Controls.Add(Me.txtDos)
        Me.Controls.Add(Me.txtUno)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUno As TextBox
    Friend WithEvents txtDos As TextBox
    Friend WithEvents txtTres As TextBox
    Friend WithEvents txtporcentajeuno As TextBox
    Friend WithEvents txtporcentajedos As TextBox
    Friend WithEvents txtporcentajetres As TextBox
End Class
