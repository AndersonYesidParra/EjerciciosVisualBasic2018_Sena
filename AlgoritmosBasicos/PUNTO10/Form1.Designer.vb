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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPresopuesto = New System.Windows.Forms.TextBox()
        Me.txtGinecologia = New System.Windows.Forms.TextBox()
        Me.txtTraumotologia = New System.Windows.Forms.TextBox()
        Me.txtPediatria = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Presopuesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Traumatología 30%:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pediatría 30%:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ingrese el valor del Presopuesto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ginecologia 40% : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular:"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPresopuesto
        '
        Me.txtPresopuesto.Location = New System.Drawing.Point(225, 71)
        Me.txtPresopuesto.Name = "txtPresopuesto"
        Me.txtPresopuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtPresopuesto.TabIndex = 3
        '
        'txtGinecologia
        '
        Me.txtGinecologia.Location = New System.Drawing.Point(225, 138)
        Me.txtGinecologia.Name = "txtGinecologia"
        Me.txtGinecologia.Size = New System.Drawing.Size(100, 20)
        Me.txtGinecologia.TabIndex = 3
        '
        'txtTraumotologia
        '
        Me.txtTraumotologia.Location = New System.Drawing.Point(225, 186)
        Me.txtTraumotologia.Name = "txtTraumotologia"
        Me.txtTraumotologia.Size = New System.Drawing.Size(100, 20)
        Me.txtTraumotologia.TabIndex = 3
        '
        'txtPediatria
        '
        Me.txtPediatria.Location = New System.Drawing.Point(225, 234)
        Me.txtPediatria.Name = "txtPediatria"
        Me.txtPediatria.Size = New System.Drawing.Size(100, 20)
        Me.txtPediatria.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 325)
        Me.Controls.Add(Me.txtPediatria)
        Me.Controls.Add(Me.txtTraumotologia)
        Me.Controls.Add(Me.txtGinecologia)
        Me.Controls.Add(Me.txtPresopuesto)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPresopuesto As TextBox
    Friend WithEvents txtGinecologia As TextBox
    Friend WithEvents txtTraumotologia As TextBox
    Friend WithEvents txtPediatria As TextBox
End Class
