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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.elefantess = New System.Windows.Forms.RadioButton()
        Me.jirafass = New System.Windows.Forms.RadioButton()
        Me.chimpa = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zoologico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chimpa)
        Me.GroupBox1.Controls.Add(Me.jirafass)
        Me.GroupBox1.Controls.Add(Me.elefantess)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 120)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Animales:"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(118, 82)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 20)
        Me.txtEdad.TabIndex = 3
        '
        'elefantess
        '
        Me.elefantess.AutoSize = True
        Me.elefantess.Location = New System.Drawing.Point(39, 19)
        Me.elefantess.Name = "elefantess"
        Me.elefantess.Size = New System.Drawing.Size(64, 17)
        Me.elefantess.TabIndex = 0
        Me.elefantess.TabStop = True
        Me.elefantess.Text = "Elefante"
        Me.elefantess.UseVisualStyleBackColor = True
        '
        'jirafass
        '
        Me.jirafass.AutoSize = True
        Me.jirafass.Location = New System.Drawing.Point(39, 52)
        Me.jirafass.Name = "jirafass"
        Me.jirafass.Size = New System.Drawing.Size(55, 17)
        Me.jirafass.TabIndex = 0
        Me.jirafass.TabStop = True
        Me.jirafass.Text = "Jirafas"
        Me.jirafass.UseVisualStyleBackColor = True
        '
        'chimpa
        '
        Me.chimpa.AutoSize = True
        Me.chimpa.Location = New System.Drawing.Point(39, 84)
        Me.chimpa.Name = "chimpa"
        Me.chimpa.Size = New System.Drawing.Size(83, 17)
        Me.chimpa.TabIndex = 0
        Me.chimpa.TabStop = True
        Me.chimpa.Text = "Chimpancés"
        Me.chimpa.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 268)
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
        Me.ClientSize = New System.Drawing.Size(389, 317)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chimpa As RadioButton
    Friend WithEvents jirafass As RadioButton
    Friend WithEvents elefantess As RadioButton
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Button1 As Button
End Class
