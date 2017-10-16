<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Trabajador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox_CedulaT = New System.Windows.Forms.TextBox()
        Me.TextBox_NombresT = New System.Windows.Forms.TextBox()
        Me.TextBox_ApellidosT = New System.Windows.Forms.TextBox()
        Me.TextBox_ExpLaboralT = New System.Windows.Forms.TextBox()
        Me.ComboBox_GeneroT = New System.Windows.Forms.ComboBox()
        Me.TextBox_ProfesionT = New System.Windows.Forms.TextBox()
        Me.TextBox_LvlEducativoT = New System.Windows.Forms.TextBox()
        Me.Button_ConsultarT = New System.Windows.Forms.Button()
        Me.Button_CrearT = New System.Windows.Forms.Button()
        Me.Button_ActualizarT = New System.Windows.Forms.Button()
        Me.Button_EliminarT = New System.Windows.Forms.Button()
        Me.Label_CedulaT = New System.Windows.Forms.Label()
        Me.Label_NombresT = New System.Windows.Forms.Label()
        Me.Label_ApellidosT = New System.Windows.Forms.Label()
        Me.Label_GeneroT = New System.Windows.Forms.Label()
        Me.Label_FecNacimientoT = New System.Windows.Forms.Label()
        Me.Label_ProfesiónT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_ExpLaboralT = New System.Windows.Forms.Label()
        Me.Label_LvlEducativoT = New System.Windows.Forms.Label()
        Me.Label_HojaVidaT = New System.Windows.Forms.Label()
        Me.MaskedTextBox_FecNacimientoT = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox_HojaVidaT = New System.Windows.Forms.ComboBox()
        Me.DataGridView_Trabajador = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_Trabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_CedulaT
        '
        Me.TextBox_CedulaT.Location = New System.Drawing.Point(132, 30)
        Me.TextBox_CedulaT.Name = "TextBox_CedulaT"
        Me.TextBox_CedulaT.Size = New System.Drawing.Size(192, 20)
        Me.TextBox_CedulaT.TabIndex = 0
        '
        'TextBox_NombresT
        '
        Me.TextBox_NombresT.Location = New System.Drawing.Point(132, 56)
        Me.TextBox_NombresT.Name = "TextBox_NombresT"
        Me.TextBox_NombresT.Size = New System.Drawing.Size(192, 20)
        Me.TextBox_NombresT.TabIndex = 1
        '
        'TextBox_ApellidosT
        '
        Me.TextBox_ApellidosT.Location = New System.Drawing.Point(132, 82)
        Me.TextBox_ApellidosT.Name = "TextBox_ApellidosT"
        Me.TextBox_ApellidosT.Size = New System.Drawing.Size(192, 20)
        Me.TextBox_ApellidosT.TabIndex = 2
        '
        'TextBox_ExpLaboralT
        '
        Me.TextBox_ExpLaboralT.Location = New System.Drawing.Point(132, 215)
        Me.TextBox_ExpLaboralT.Name = "TextBox_ExpLaboralT"
        Me.TextBox_ExpLaboralT.Size = New System.Drawing.Size(192, 20)
        Me.TextBox_ExpLaboralT.TabIndex = 3
        '
        'ComboBox_GeneroT
        '
        Me.ComboBox_GeneroT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GeneroT.FormattingEnabled = True
        Me.ComboBox_GeneroT.Items.AddRange(New Object() {"Hombre", "Mujer", "Otro"})
        Me.ComboBox_GeneroT.Location = New System.Drawing.Point(132, 108)
        Me.ComboBox_GeneroT.Name = "ComboBox_GeneroT"
        Me.ComboBox_GeneroT.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox_GeneroT.TabIndex = 5
        '
        'TextBox_ProfesionT
        '
        Me.TextBox_ProfesionT.Location = New System.Drawing.Point(132, 161)
        Me.TextBox_ProfesionT.Name = "TextBox_ProfesionT"
        Me.TextBox_ProfesionT.Size = New System.Drawing.Size(192, 20)
        Me.TextBox_ProfesionT.TabIndex = 6
        '
        'TextBox_LvlEducativoT
        '
        Me.TextBox_LvlEducativoT.Location = New System.Drawing.Point(132, 189)
        Me.TextBox_LvlEducativoT.Name = "TextBox_LvlEducativoT"
        Me.TextBox_LvlEducativoT.Size = New System.Drawing.Size(192, 20)
        Me.TextBox_LvlEducativoT.TabIndex = 7
        '
        'Button_ConsultarT
        '
        Me.Button_ConsultarT.Location = New System.Drawing.Point(44, 311)
        Me.Button_ConsultarT.Name = "Button_ConsultarT"
        Me.Button_ConsultarT.Size = New System.Drawing.Size(75, 23)
        Me.Button_ConsultarT.TabIndex = 9
        Me.Button_ConsultarT.Text = "Consultar"
        Me.Button_ConsultarT.UseVisualStyleBackColor = True
        '
        'Button_CrearT
        '
        Me.Button_CrearT.Location = New System.Drawing.Point(132, 311)
        Me.Button_CrearT.Name = "Button_CrearT"
        Me.Button_CrearT.Size = New System.Drawing.Size(75, 23)
        Me.Button_CrearT.TabIndex = 10
        Me.Button_CrearT.Text = "Crear"
        Me.Button_CrearT.UseVisualStyleBackColor = True
        '
        'Button_ActualizarT
        '
        Me.Button_ActualizarT.Location = New System.Drawing.Point(213, 311)
        Me.Button_ActualizarT.Name = "Button_ActualizarT"
        Me.Button_ActualizarT.Size = New System.Drawing.Size(75, 23)
        Me.Button_ActualizarT.TabIndex = 11
        Me.Button_ActualizarT.Text = "Actualizar"
        Me.Button_ActualizarT.UseVisualStyleBackColor = True
        '
        'Button_EliminarT
        '
        Me.Button_EliminarT.Location = New System.Drawing.Point(294, 311)
        Me.Button_EliminarT.Name = "Button_EliminarT"
        Me.Button_EliminarT.Size = New System.Drawing.Size(75, 23)
        Me.Button_EliminarT.TabIndex = 12
        Me.Button_EliminarT.Text = "Eliminar"
        Me.Button_EliminarT.UseVisualStyleBackColor = True
        '
        'Label_CedulaT
        '
        Me.Label_CedulaT.AutoSize = True
        Me.Label_CedulaT.Location = New System.Drawing.Point(74, 33)
        Me.Label_CedulaT.Name = "Label_CedulaT"
        Me.Label_CedulaT.Size = New System.Drawing.Size(43, 13)
        Me.Label_CedulaT.TabIndex = 13
        Me.Label_CedulaT.Text = "Cédula:"
        '
        'Label_NombresT
        '
        Me.Label_NombresT.AutoSize = True
        Me.Label_NombresT.Location = New System.Drawing.Point(74, 59)
        Me.Label_NombresT.Name = "Label_NombresT"
        Me.Label_NombresT.Size = New System.Drawing.Size(52, 13)
        Me.Label_NombresT.TabIndex = 14
        Me.Label_NombresT.Text = "Nombres:"
        '
        'Label_ApellidosT
        '
        Me.Label_ApellidosT.AutoSize = True
        Me.Label_ApellidosT.Location = New System.Drawing.Point(74, 85)
        Me.Label_ApellidosT.Name = "Label_ApellidosT"
        Me.Label_ApellidosT.Size = New System.Drawing.Size(52, 13)
        Me.Label_ApellidosT.TabIndex = 15
        Me.Label_ApellidosT.Text = "Apellidos:"
        '
        'Label_GeneroT
        '
        Me.Label_GeneroT.AutoSize = True
        Me.Label_GeneroT.Location = New System.Drawing.Point(74, 111)
        Me.Label_GeneroT.Name = "Label_GeneroT"
        Me.Label_GeneroT.Size = New System.Drawing.Size(45, 13)
        Me.Label_GeneroT.TabIndex = 16
        Me.Label_GeneroT.Text = "Género:"
        '
        'Label_FecNacimientoT
        '
        Me.Label_FecNacimientoT.AutoSize = True
        Me.Label_FecNacimientoT.Location = New System.Drawing.Point(73, 138)
        Me.Label_FecNacimientoT.Name = "Label_FecNacimientoT"
        Me.Label_FecNacimientoT.Size = New System.Drawing.Size(111, 13)
        Me.Label_FecNacimientoT.TabIndex = 17
        Me.Label_FecNacimientoT.Text = "Fecha de Nacimiento:"
        '
        'Label_ProfesiónT
        '
        Me.Label_ProfesiónT.AutoSize = True
        Me.Label_ProfesiónT.Location = New System.Drawing.Point(74, 164)
        Me.Label_ProfesiónT.Name = "Label_ProfesiónT"
        Me.Label_ProfesiónT.Size = New System.Drawing.Size(54, 13)
        Me.Label_ProfesiónT.TabIndex = 18
        Me.Label_ProfesiónT.Text = "Profesión:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 19
        '
        'Label_ExpLaboralT
        '
        Me.Label_ExpLaboralT.AutoSize = True
        Me.Label_ExpLaboralT.Location = New System.Drawing.Point(57, 218)
        Me.Label_ExpLaboralT.Name = "Label_ExpLaboralT"
        Me.Label_ExpLaboralT.Size = New System.Drawing.Size(69, 13)
        Me.Label_ExpLaboralT.TabIndex = 20
        Me.Label_ExpLaboralT.Text = "Exp. Laboral:"
        '
        'Label_LvlEducativoT
        '
        Me.Label_LvlEducativoT.AutoSize = True
        Me.Label_LvlEducativoT.Location = New System.Drawing.Point(41, 192)
        Me.Label_LvlEducativoT.Name = "Label_LvlEducativoT"
        Me.Label_LvlEducativoT.Size = New System.Drawing.Size(85, 13)
        Me.Label_LvlEducativoT.TabIndex = 21
        Me.Label_LvlEducativoT.Text = "Nivel Educativo:"
        '
        'Label_HojaVidaT
        '
        Me.Label_HojaVidaT.AutoSize = True
        Me.Label_HojaVidaT.Location = New System.Drawing.Point(55, 245)
        Me.Label_HojaVidaT.Name = "Label_HojaVidaT"
        Me.Label_HojaVidaT.Size = New System.Drawing.Size(71, 13)
        Me.Label_HojaVidaT.TabIndex = 22
        Me.Label_HojaVidaT.Text = "Hoja de Vida:"
        '
        'MaskedTextBox_FecNacimientoT
        '
        Me.MaskedTextBox_FecNacimientoT.Location = New System.Drawing.Point(190, 135)
        Me.MaskedTextBox_FecNacimientoT.Mask = "0000/00/00"
        Me.MaskedTextBox_FecNacimientoT.Name = "MaskedTextBox_FecNacimientoT"
        Me.MaskedTextBox_FecNacimientoT.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox_FecNacimientoT.TabIndex = 23
        Me.MaskedTextBox_FecNacimientoT.ValidatingType = GetType(Date)
        '
        'ComboBox_HojaVidaT
        '
        Me.ComboBox_HojaVidaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_HojaVidaT.FormattingEnabled = True
        Me.ComboBox_HojaVidaT.Items.AddRange(New Object() {"Si", "No"})
        Me.ComboBox_HojaVidaT.Location = New System.Drawing.Point(132, 242)
        Me.ComboBox_HojaVidaT.Name = "ComboBox_HojaVidaT"
        Me.ComboBox_HojaVidaT.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox_HojaVidaT.TabIndex = 24
        '
        'DataGridView_Trabajador
        '
        Me.DataGridView_Trabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Trabajador.Location = New System.Drawing.Point(44, 341)
        Me.DataGridView_Trabajador.Name = "DataGridView_Trabajador"
        Me.DataGridView_Trabajador.Size = New System.Drawing.Size(325, 150)
        Me.DataGridView_Trabajador.TabIndex = 25
        '
        'Frm_Trabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 492)
        Me.Controls.Add(Me.DataGridView_Trabajador)
        Me.Controls.Add(Me.ComboBox_HojaVidaT)
        Me.Controls.Add(Me.MaskedTextBox_FecNacimientoT)
        Me.Controls.Add(Me.Label_HojaVidaT)
        Me.Controls.Add(Me.Label_LvlEducativoT)
        Me.Controls.Add(Me.Label_ExpLaboralT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_ProfesiónT)
        Me.Controls.Add(Me.Label_FecNacimientoT)
        Me.Controls.Add(Me.Label_GeneroT)
        Me.Controls.Add(Me.Label_ApellidosT)
        Me.Controls.Add(Me.Label_NombresT)
        Me.Controls.Add(Me.Label_CedulaT)
        Me.Controls.Add(Me.Button_EliminarT)
        Me.Controls.Add(Me.Button_ActualizarT)
        Me.Controls.Add(Me.Button_CrearT)
        Me.Controls.Add(Me.Button_ConsultarT)
        Me.Controls.Add(Me.TextBox_LvlEducativoT)
        Me.Controls.Add(Me.TextBox_ProfesionT)
        Me.Controls.Add(Me.ComboBox_GeneroT)
        Me.Controls.Add(Me.TextBox_ExpLaboralT)
        Me.Controls.Add(Me.TextBox_ApellidosT)
        Me.Controls.Add(Me.TextBox_NombresT)
        Me.Controls.Add(Me.TextBox_CedulaT)
        Me.Name = "Frm_Trabajador"
        Me.Text = "Trabajador"
        CType(Me.DataGridView_Trabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_CedulaT As TextBox
    Friend WithEvents TextBox_NombresT As TextBox
    Friend WithEvents TextBox_ApellidosT As TextBox
    Friend WithEvents TextBox_ExpLaboralT As TextBox
    Friend WithEvents ComboBox_GeneroT As ComboBox
    Friend WithEvents TextBox_ProfesionT As TextBox
    Friend WithEvents TextBox_LvlEducativoT As TextBox
    Friend WithEvents Button_ConsultarT As Button
    Friend WithEvents Button_CrearT As Button
    Friend WithEvents Button_ActualizarT As Button
    Friend WithEvents Button_EliminarT As Button
    Friend WithEvents Label_CedulaT As Label
    Friend WithEvents Label_NombresT As Label
    Friend WithEvents Label_ApellidosT As Label
    Friend WithEvents Label_GeneroT As Label
    Friend WithEvents Label_FecNacimientoT As Label
    Friend WithEvents Label_ProfesiónT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_ExpLaboralT As Label
    Friend WithEvents Label_LvlEducativoT As Label
    Friend WithEvents Label_HojaVidaT As Label
    Friend WithEvents MaskedTextBox_FecNacimientoT As MaskedTextBox
    Friend WithEvents ComboBox_HojaVidaT As ComboBox
    Friend WithEvents DataGridView_Trabajador As DataGridView
End Class
