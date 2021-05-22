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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUno = New System.Windows.Forms.TextBox()
        Me.txtExamen = New System.Windows.Forms.TextBox()
        Me.txtTrabajo = New System.Windows.Forms.TextBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Calcula = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTres = New System.Windows.Forms.TextBox()
        Me.txtDos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calificaciónes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Parciales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Examen Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Trabajo Final:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nota Final:"
        '
        'txtUno
        '
        Me.txtUno.Location = New System.Drawing.Point(203, 93)
        Me.txtUno.Name = "txtUno"
        Me.txtUno.Size = New System.Drawing.Size(80, 20)
        Me.txtUno.TabIndex = 5
        '
        'txtExamen
        '
        Me.txtExamen.Location = New System.Drawing.Point(227, 203)
        Me.txtExamen.Name = "txtExamen"
        Me.txtExamen.Size = New System.Drawing.Size(80, 20)
        Me.txtExamen.TabIndex = 6
        '
        'txtTrabajo
        '
        Me.txtTrabajo.Location = New System.Drawing.Point(227, 151)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.Size = New System.Drawing.Size(80, 20)
        Me.txtTrabajo.TabIndex = 6
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(227, 292)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(80, 20)
        Me.txtNota.TabIndex = 7
        '
        'Calcula
        '
        Me.Calcula.Location = New System.Drawing.Point(203, 253)
        Me.Calcula.Name = "Calcula"
        Me.Calcula.Size = New System.Drawing.Size(75, 23)
        Me.Calcula.TabIndex = 8
        Me.Calcula.Text = "Calcular"
        Me.Calcula.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nota 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nota 2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Nota 3:"
        '
        'txtTres
        '
        Me.txtTres.Location = New System.Drawing.Point(477, 93)
        Me.txtTres.Name = "txtTres"
        Me.txtTres.Size = New System.Drawing.Size(80, 20)
        Me.txtTres.TabIndex = 12
        '
        'txtDos
        '
        Me.txtDos.Location = New System.Drawing.Point(343, 93)
        Me.txtDos.Name = "txtDos"
        Me.txtDos.Size = New System.Drawing.Size(80, 20)
        Me.txtDos.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 348)
        Me.Controls.Add(Me.txtDos)
        Me.Controls.Add(Me.txtTres)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Calcula)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtTrabajo)
        Me.Controls.Add(Me.txtExamen)
        Me.Controls.Add(Me.txtUno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUno As TextBox
    Friend WithEvents txtExamen As TextBox
    Friend WithEvents txtTrabajo As TextBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents Calcula As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTres As TextBox
    Friend WithEvents txtDos As TextBox
End Class
