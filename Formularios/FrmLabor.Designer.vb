<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLabor
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
        Me.TxtDescripcionLabor = New System.Windows.Forms.TextBox()
        Me.TxtFechaIniLabor = New System.Windows.Forms.TextBox()
        Me.TxtFechaFinLabor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipoLabor = New System.Windows.Forms.TextBox()
        Me.BtnCrearLabor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdLabor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboxContratista = New System.Windows.Forms.ComboBox()
        Me.CboxTrabajador = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion de labor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Inicio Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Fin Labor"
        '
        'TxtDescripcionLabor
        '
        Me.TxtDescripcionLabor.Location = New System.Drawing.Point(210, 56)
        Me.TxtDescripcionLabor.Name = "TxtDescripcionLabor"
        Me.TxtDescripcionLabor.Size = New System.Drawing.Size(160, 20)
        Me.TxtDescripcionLabor.TabIndex = 3
        '
        'TxtFechaIniLabor
        '
        Me.TxtFechaIniLabor.Location = New System.Drawing.Point(210, 89)
        Me.TxtFechaIniLabor.Name = "TxtFechaIniLabor"
        Me.TxtFechaIniLabor.Size = New System.Drawing.Size(160, 20)
        Me.TxtFechaIniLabor.TabIndex = 4
        '
        'TxtFechaFinLabor
        '
        Me.TxtFechaFinLabor.Location = New System.Drawing.Point(210, 123)
        Me.TxtFechaFinLabor.Name = "TxtFechaFinLabor"
        Me.TxtFechaFinLabor.Size = New System.Drawing.Size(160, 20)
        Me.TxtFechaFinLabor.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de Labor"
        '
        'TxtTipoLabor
        '
        Me.TxtTipoLabor.Location = New System.Drawing.Point(210, 158)
        Me.TxtTipoLabor.Name = "TxtTipoLabor"
        Me.TxtTipoLabor.Size = New System.Drawing.Size(160, 20)
        Me.TxtTipoLabor.TabIndex = 7
        '
        'BtnCrearLabor
        '
        Me.BtnCrearLabor.Location = New System.Drawing.Point(38, 263)
        Me.BtnCrearLabor.Name = "BtnCrearLabor"
        Me.BtnCrearLabor.Size = New System.Drawing.Size(92, 23)
        Me.BtnCrearLabor.TabIndex = 8
        Me.BtnCrearLabor.Text = "Crear"
        Me.BtnCrearLabor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(267, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(379, 263)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID Labor"
        '
        'TxtIdLabor
        '
        Me.TxtIdLabor.Location = New System.Drawing.Point(210, 20)
        Me.TxtIdLabor.Name = "TxtIdLabor"
        Me.TxtIdLabor.Size = New System.Drawing.Size(160, 20)
        Me.TxtIdLabor.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Contratista "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Trabajador"
        '
        'CboxContratista
        '
        Me.CboxContratista.FormattingEnabled = True
        Me.CboxContratista.Location = New System.Drawing.Point(210, 188)
        Me.CboxContratista.Name = "CboxContratista"
        Me.CboxContratista.Size = New System.Drawing.Size(160, 21)
        Me.CboxContratista.TabIndex = 17
        '
        'CboxTrabajador
        '
        Me.CboxTrabajador.FormattingEnabled = True
        Me.CboxTrabajador.Location = New System.Drawing.Point(210, 216)
        Me.CboxTrabajador.Name = "CboxTrabajador"
        Me.CboxTrabajador.Size = New System.Drawing.Size(160, 21)
        Me.CboxTrabajador.TabIndex = 18
        '
        'FrmLabor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 340)
        Me.Controls.Add(Me.CboxTrabajador)
        Me.Controls.Add(Me.CboxContratista)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtIdLabor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnCrearLabor)
        Me.Controls.Add(Me.TxtTipoLabor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFechaFinLabor)
        Me.Controls.Add(Me.TxtFechaIniLabor)
        Me.Controls.Add(Me.TxtDescripcionLabor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLabor"
        Me.Text = "Labor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescripcionLabor As TextBox
    Friend WithEvents TxtFechaIniLabor As TextBox
    Friend WithEvents TxtFechaFinLabor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTipoLabor As TextBox
    Friend WithEvents BtnCrearLabor As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIdLabor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CboxContratista As ComboBox
    Friend WithEvents CboxTrabajador As ComboBox
End Class
