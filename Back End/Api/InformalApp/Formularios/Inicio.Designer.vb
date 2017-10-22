<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.Btn_Trabajadores = New System.Windows.Forms.Button()
        Me.Btn_Contratistas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Trabajadores
        '
        Me.Btn_Trabajadores.Location = New System.Drawing.Point(145, 42)
        Me.Btn_Trabajadores.Name = "Btn_Trabajadores"
        Me.Btn_Trabajadores.Size = New System.Drawing.Size(87, 23)
        Me.Btn_Trabajadores.TabIndex = 0
        Me.Btn_Trabajadores.Text = "Trabajadores"
        Me.Btn_Trabajadores.UseVisualStyleBackColor = True
        '
        'Btn_Contratistas
        '
        Me.Btn_Contratistas.Location = New System.Drawing.Point(36, 42)
        Me.Btn_Contratistas.Name = "Btn_Contratistas"
        Me.Btn_Contratistas.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Contratistas.TabIndex = 1
        Me.Btn_Contratistas.Text = "Contratistas"
        Me.Btn_Contratistas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bienvenido a InformalApp"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Contratistas)
        Me.Controls.Add(Me.Btn_Trabajadores)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Trabajadores As Button
    Friend WithEvents Btn_Contratistas As Button
    Friend WithEvents Label1 As Label
End Class
