<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contratistas
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label_FecNacimientoT = New System.Windows.Forms.Label()
        Me.TextBoxCargo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.TextBoxEmpresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FecNacimiento = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(201, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 8)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(369, 143)
        Me.DataGridView1.TabIndex = 3
        '
        'Label_FecNacimientoT
        '
        Me.Label_FecNacimientoT.AutoSize = True
        Me.Label_FecNacimientoT.Location = New System.Drawing.Point(166, 103)
        Me.Label_FecNacimientoT.Name = "Label_FecNacimientoT"
        Me.Label_FecNacimientoT.Size = New System.Drawing.Size(108, 13)
        Me.Label_FecNacimientoT.TabIndex = 46
        Me.Label_FecNacimientoT.Text = "Fecha de Nacimiento"
        '
        'TextBoxCargo
        '
        Me.TextBoxCargo.Location = New System.Drawing.Point(60, 100)
        Me.TextBoxCargo.Name = "TextBoxCargo"
        Me.TextBoxCargo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCargo.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Cargo"
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(278, 67)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellido.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Apellido"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(60, 67)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Nombre"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(278, 41)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCedula.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Cédula"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(60, 41)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxId.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Id"
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(9, 12)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(57, 23)
        Me.ButtonGuardar.TabIndex = 34
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(72, 12)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(57, 23)
        Me.ButtonEliminar.TabIndex = 48
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Location = New System.Drawing.Point(135, 12)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(57, 23)
        Me.ButtonNuevo.TabIndex = 49
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'TextBoxEmpresa
        '
        Me.TextBoxEmpresa.Location = New System.Drawing.Point(60, 126)
        Me.TextBoxEmpresa.Name = "TextBoxEmpresa"
        Me.TextBoxEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEmpresa.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Empresa"
        '
        'FecNacimiento
        '
        Me.FecNacimiento.Location = New System.Drawing.Point(278, 97)
        Me.FecNacimiento.Name = "FecNacimiento"
        Me.FecNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.FecNacimiento.TabIndex = 52
        '
        'Contratistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 303)
        Me.Controls.Add(Me.FecNacimiento)
        Me.Controls.Add(Me.TextBoxEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonNuevo)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.Label_FecNacimientoT)
        Me.Controls.Add(Me.TextBoxCargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Contratistas"
        Me.Text = "Contratistas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label_FecNacimientoT As Label
    Friend WithEvents TextBoxCargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents TextBoxEmpresa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FecNacimiento As DateTimePicker
End Class
