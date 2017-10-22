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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Trabajador))
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
        Me.SuspendLayout()
        '
        'TextBox_CedulaT
        '
        Me.TextBox_CedulaT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CedulaT.Location = New System.Drawing.Point(176, 30)
        Me.TextBox_CedulaT.Name = "TextBox_CedulaT"
        Me.TextBox_CedulaT.Size = New System.Drawing.Size(254, 21)
        Me.TextBox_CedulaT.TabIndex = 0
        '
        'TextBox_NombresT
        '
        Me.TextBox_NombresT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NombresT.Location = New System.Drawing.Point(176, 56)
        Me.TextBox_NombresT.Name = "TextBox_NombresT"
        Me.TextBox_NombresT.Size = New System.Drawing.Size(254, 21)
        Me.TextBox_NombresT.TabIndex = 1
        '
        'TextBox_ApellidosT
        '
        Me.TextBox_ApellidosT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ApellidosT.Location = New System.Drawing.Point(176, 82)
        Me.TextBox_ApellidosT.Name = "TextBox_ApellidosT"
        Me.TextBox_ApellidosT.Size = New System.Drawing.Size(254, 21)
        Me.TextBox_ApellidosT.TabIndex = 2
        '
        'TextBox_ExpLaboralT
        '
        Me.TextBox_ExpLaboralT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ExpLaboralT.Location = New System.Drawing.Point(176, 215)
        Me.TextBox_ExpLaboralT.Name = "TextBox_ExpLaboralT"
        Me.TextBox_ExpLaboralT.Size = New System.Drawing.Size(254, 21)
        Me.TextBox_ExpLaboralT.TabIndex = 3
        '
        'ComboBox_GeneroT
        '
        Me.ComboBox_GeneroT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GeneroT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_GeneroT.FormattingEnabled = True
        Me.ComboBox_GeneroT.Items.AddRange(New Object() {"Hombre", "Mujer", "Otro"})
        Me.ComboBox_GeneroT.Location = New System.Drawing.Point(176, 108)
        Me.ComboBox_GeneroT.Name = "ComboBox_GeneroT"
        Me.ComboBox_GeneroT.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox_GeneroT.TabIndex = 5
        '
        'TextBox_ProfesionT
        '
        Me.TextBox_ProfesionT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProfesionT.Location = New System.Drawing.Point(176, 161)
        Me.TextBox_ProfesionT.Name = "TextBox_ProfesionT"
        Me.TextBox_ProfesionT.Size = New System.Drawing.Size(254, 21)
        Me.TextBox_ProfesionT.TabIndex = 6
        '
        'TextBox_LvlEducativoT
        '
        Me.TextBox_LvlEducativoT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_LvlEducativoT.Location = New System.Drawing.Point(176, 189)
        Me.TextBox_LvlEducativoT.Name = "TextBox_LvlEducativoT"
        Me.TextBox_LvlEducativoT.Size = New System.Drawing.Size(254, 21)
        Me.TextBox_LvlEducativoT.TabIndex = 7
        '
        'Button_ConsultarT
        '
        Me.Button_ConsultarT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ConsultarT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ConsultarT.Image = CType(resources.GetObject("Button_ConsultarT.Image"), System.Drawing.Image)
        Me.Button_ConsultarT.Location = New System.Drawing.Point(58, 311)
        Me.Button_ConsultarT.Name = "Button_ConsultarT"
        Me.Button_ConsultarT.Size = New System.Drawing.Size(77, 71)
        Me.Button_ConsultarT.TabIndex = 9
        Me.Button_ConsultarT.UseVisualStyleBackColor = True
        '
        'Button_CrearT
        '
        Me.Button_CrearT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_CrearT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_CrearT.Image = CType(resources.GetObject("Button_CrearT.Image"), System.Drawing.Image)
        Me.Button_CrearT.Location = New System.Drawing.Point(165, 311)
        Me.Button_CrearT.Name = "Button_CrearT"
        Me.Button_CrearT.Size = New System.Drawing.Size(75, 71)
        Me.Button_CrearT.TabIndex = 10
        Me.Button_CrearT.UseVisualStyleBackColor = True
        '
        'Button_ActualizarT
        '
        Me.Button_ActualizarT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ActualizarT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ActualizarT.Image = CType(resources.GetObject("Button_ActualizarT.Image"), System.Drawing.Image)
        Me.Button_ActualizarT.Location = New System.Drawing.Point(270, 311)
        Me.Button_ActualizarT.Name = "Button_ActualizarT"
        Me.Button_ActualizarT.Size = New System.Drawing.Size(75, 71)
        Me.Button_ActualizarT.TabIndex = 11
        Me.Button_ActualizarT.UseVisualStyleBackColor = True
        '
        'Button_EliminarT
        '
        Me.Button_EliminarT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_EliminarT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_EliminarT.Image = CType(resources.GetObject("Button_EliminarT.Image"), System.Drawing.Image)
        Me.Button_EliminarT.Location = New System.Drawing.Point(378, 311)
        Me.Button_EliminarT.Name = "Button_EliminarT"
        Me.Button_EliminarT.Size = New System.Drawing.Size(75, 71)
        Me.Button_EliminarT.TabIndex = 12
        Me.Button_EliminarT.UseVisualStyleBackColor = True
        '
        'Label_CedulaT
        '
        Me.Label_CedulaT.AutoSize = True
        Me.Label_CedulaT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CedulaT.Location = New System.Drawing.Point(98, 33)
        Me.Label_CedulaT.Name = "Label_CedulaT"
        Me.Label_CedulaT.Size = New System.Drawing.Size(55, 13)
        Me.Label_CedulaT.TabIndex = 13
        Me.Label_CedulaT.Text = "Cédula:"
        '
        'Label_NombresT
        '
        Me.Label_NombresT.AutoSize = True
        Me.Label_NombresT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NombresT.Location = New System.Drawing.Point(98, 59)
        Me.Label_NombresT.Name = "Label_NombresT"
        Me.Label_NombresT.Size = New System.Drawing.Size(69, 13)
        Me.Label_NombresT.TabIndex = 14
        Me.Label_NombresT.Text = "Nombres:"
        '
        'Label_ApellidosT
        '
        Me.Label_ApellidosT.AutoSize = True
        Me.Label_ApellidosT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ApellidosT.Location = New System.Drawing.Point(98, 85)
        Me.Label_ApellidosT.Name = "Label_ApellidosT"
        Me.Label_ApellidosT.Size = New System.Drawing.Size(71, 13)
        Me.Label_ApellidosT.TabIndex = 15
        Me.Label_ApellidosT.Text = "Apellidos:"
        '
        'Label_GeneroT
        '
        Me.Label_GeneroT.AutoSize = True
        Me.Label_GeneroT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_GeneroT.Location = New System.Drawing.Point(98, 111)
        Me.Label_GeneroT.Name = "Label_GeneroT"
        Me.Label_GeneroT.Size = New System.Drawing.Size(58, 13)
        Me.Label_GeneroT.TabIndex = 16
        Me.Label_GeneroT.Text = "Género:"
        '
        'Label_FecNacimientoT
        '
        Me.Label_FecNacimientoT.AutoSize = True
        Me.Label_FecNacimientoT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FecNacimientoT.Location = New System.Drawing.Point(97, 138)
        Me.Label_FecNacimientoT.Name = "Label_FecNacimientoT"
        Me.Label_FecNacimientoT.Size = New System.Drawing.Size(147, 13)
        Me.Label_FecNacimientoT.TabIndex = 17
        Me.Label_FecNacimientoT.Text = "Fecha de Nacimiento:"
        '
        'Label_ProfesiónT
        '
        Me.Label_ProfesiónT.AutoSize = True
        Me.Label_ProfesiónT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ProfesiónT.Location = New System.Drawing.Point(98, 164)
        Me.Label_ProfesiónT.Name = "Label_ProfesiónT"
        Me.Label_ProfesiónT.Size = New System.Drawing.Size(73, 13)
        Me.Label_ProfesiónT.TabIndex = 18
        Me.Label_ProfesiónT.Text = "Profesión:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 19
        '
        'Label_ExpLaboralT
        '
        Me.Label_ExpLaboralT.AutoSize = True
        Me.Label_ExpLaboralT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ExpLaboralT.Location = New System.Drawing.Point(75, 218)
        Me.Label_ExpLaboralT.Name = "Label_ExpLaboralT"
        Me.Label_ExpLaboralT.Size = New System.Drawing.Size(92, 13)
        Me.Label_ExpLaboralT.TabIndex = 20
        Me.Label_ExpLaboralT.Text = "Exp. Laboral:"
        '
        'Label_LvlEducativoT
        '
        Me.Label_LvlEducativoT.AutoSize = True
        Me.Label_LvlEducativoT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LvlEducativoT.Location = New System.Drawing.Point(55, 192)
        Me.Label_LvlEducativoT.Name = "Label_LvlEducativoT"
        Me.Label_LvlEducativoT.Size = New System.Drawing.Size(112, 13)
        Me.Label_LvlEducativoT.TabIndex = 21
        Me.Label_LvlEducativoT.Text = "Nivel Educativo:"
        '
        'Label_HojaVidaT
        '
        Me.Label_HojaVidaT.AutoSize = True
        Me.Label_HojaVidaT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_HojaVidaT.Location = New System.Drawing.Point(73, 245)
        Me.Label_HojaVidaT.Name = "Label_HojaVidaT"
        Me.Label_HojaVidaT.Size = New System.Drawing.Size(93, 13)
        Me.Label_HojaVidaT.TabIndex = 22
        Me.Label_HojaVidaT.Text = "Hoja de Vida:"
        '
        'MaskedTextBox_FecNacimientoT
        '
        Me.MaskedTextBox_FecNacimientoT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox_FecNacimientoT.Location = New System.Drawing.Point(254, 135)
        Me.MaskedTextBox_FecNacimientoT.Mask = "0000/00/00"
        Me.MaskedTextBox_FecNacimientoT.Name = "MaskedTextBox_FecNacimientoT"
        Me.MaskedTextBox_FecNacimientoT.Size = New System.Drawing.Size(132, 21)
        Me.MaskedTextBox_FecNacimientoT.TabIndex = 23
        Me.MaskedTextBox_FecNacimientoT.ValidatingType = GetType(Date)
        '
        'ComboBox_HojaVidaT
        '
        Me.ComboBox_HojaVidaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_HojaVidaT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_HojaVidaT.FormattingEnabled = True
        Me.ComboBox_HojaVidaT.Items.AddRange(New Object() {"Si", "No"})
        Me.ComboBox_HojaVidaT.Location = New System.Drawing.Point(176, 242)
        Me.ComboBox_HojaVidaT.Name = "ComboBox_HojaVidaT"
        Me.ComboBox_HojaVidaT.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox_HojaVidaT.TabIndex = 24
        '
        'Frm_Trabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(528, 420)
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
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Trabajador"
        Me.Text = "Trabajador"
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
End Class
