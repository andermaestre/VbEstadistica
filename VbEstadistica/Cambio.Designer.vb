<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cambio
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbcIndex = New System.Windows.Forms.TextBox()
        Me.tbcNombre = New System.Windows.Forms.TextBox()
        Me.tbcNota = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cambiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Posicion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nota"
        '
        'tbcIndex
        '
        Me.tbcIndex.Location = New System.Drawing.Point(12, 36)
        Me.tbcIndex.Name = "tbcIndex"
        Me.tbcIndex.Size = New System.Drawing.Size(100, 20)
        Me.tbcIndex.TabIndex = 4
        '
        'tbcNombre
        '
        Me.tbcNombre.Location = New System.Drawing.Point(12, 98)
        Me.tbcNombre.Name = "tbcNombre"
        Me.tbcNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbcNombre.TabIndex = 5
        '
        'tbcNota
        '
        Me.tbcNota.Location = New System.Drawing.Point(12, 158)
        Me.tbcNota.Name = "tbcNota"
        Me.tbcNota.Size = New System.Drawing.Size(100, 20)
        Me.tbcNota.TabIndex = 6
        '
        'Cambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 212)
        Me.Controls.Add(Me.tbcNota)
        Me.Controls.Add(Me.tbcNombre)
        Me.Controls.Add(Me.tbcIndex)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Cambio"
        Me.Text = "Cambio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbcIndex As TextBox
    Friend WithEvents tbcNombre As TextBox
    Friend WithEvents tbcNota As TextBox
End Class
