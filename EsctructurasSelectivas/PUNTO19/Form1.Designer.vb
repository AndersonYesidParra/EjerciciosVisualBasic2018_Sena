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
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Marca = New System.Windows.Forms.GroupBox()
        Me.nosy = New System.Windows.Forms.RadioButton()
        Me.otraMarca = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Marca.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aparato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(117, 76)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(127, 20)
        Me.txtPrecio.TabIndex = 2
        '
        'Marca
        '
        Me.Marca.Controls.Add(Me.otraMarca)
        Me.Marca.Controls.Add(Me.nosy)
        Me.Marca.Location = New System.Drawing.Point(61, 129)
        Me.Marca.Name = "Marca"
        Me.Marca.Size = New System.Drawing.Size(200, 100)
        Me.Marca.TabIndex = 3
        Me.Marca.TabStop = False
        Me.Marca.Text = "Marcas:"
        '
        'nosy
        '
        Me.nosy.AutoSize = True
        Me.nosy.Location = New System.Drawing.Point(51, 28)
        Me.nosy.Name = "nosy"
        Me.nosy.Size = New System.Drawing.Size(55, 17)
        Me.nosy.TabIndex = 4
        Me.nosy.TabStop = True
        Me.nosy.Text = "NOSY"
        Me.nosy.UseVisualStyleBackColor = True
        '
        'otraMarca
        '
        Me.otraMarca.AutoSize = True
        Me.otraMarca.Location = New System.Drawing.Point(51, 62)
        Me.otraMarca.Name = "otraMarca"
        Me.otraMarca.Size = New System.Drawing.Size(78, 17)
        Me.otraMarca.TabIndex = 4
        Me.otraMarca.TabStop = True
        Me.otraMarca.Text = "Otra Marca"
        Me.otraMarca.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 323)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Marca)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Marca.ResumeLayout(False)
        Me.Marca.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Marca As GroupBox
    Friend WithEvents otraMarca As RadioButton
    Friend WithEvents nosy As RadioButton
    Friend WithEvents Button1 As Button
End Class
