<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asistente_Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Asistente_Configuracion))
        Me.holaL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InfoText = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.PanelConfig = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.consolaProceso = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TodoOk = New System.Windows.Forms.Button()
        Me.Clave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HostNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CrearBase = New System.Windows.Forms.CheckBox()
        Me.PanelFinal = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelConfig.SuspendLayout()
        Me.PanelFinal.SuspendLayout()
        Me.SuspendLayout()
        '
        'holaL
        '
        Me.holaL.AutoSize = True
        Me.holaL.Location = New System.Drawing.Point(18, 44)
        Me.holaL.Name = "holaL"
        Me.holaL.Size = New System.Drawing.Size(32, 13)
        Me.holaL.TabIndex = 0
        Me.holaL.Text = "Hola!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'InfoText
        '
        Me.InfoText.BackColor = System.Drawing.SystemColors.Control
        Me.InfoText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InfoText.CausesValidation = False
        Me.InfoText.Location = New System.Drawing.Point(21, 74)
        Me.InfoText.Name = "InfoText"
        Me.InfoText.Size = New System.Drawing.Size(401, 70)
        Me.InfoText.TabIndex = 2
        Me.InfoText.Text = resources.GetString("InfoText.Text")
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(175, 180)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Entiendo!"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'PanelConfig
        '
        Me.PanelConfig.Controls.Add(Me.PanelFinal)
        Me.PanelConfig.Controls.Add(Me.CrearBase)
        Me.PanelConfig.Controls.Add(Me.Button1)
        Me.PanelConfig.Controls.Add(Me.Label7)
        Me.PanelConfig.Controls.Add(Me.consolaProceso)
        Me.PanelConfig.Controls.Add(Me.Label6)
        Me.PanelConfig.Controls.Add(Me.TodoOk)
        Me.PanelConfig.Controls.Add(Me.Clave)
        Me.PanelConfig.Controls.Add(Me.Label5)
        Me.PanelConfig.Controls.Add(Me.Usuario)
        Me.PanelConfig.Controls.Add(Me.Label4)
        Me.PanelConfig.Controls.Add(Me.HostNombre)
        Me.PanelConfig.Controls.Add(Me.Label1)
        Me.PanelConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConfig.Location = New System.Drawing.Point(0, 0)
        Me.PanelConfig.Name = "PanelConfig"
        Me.PanelConfig.Size = New System.Drawing.Size(443, 310)
        Me.PanelConfig.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Proceso:"
        '
        'consolaProceso
        '
        Me.consolaProceso.BackColor = System.Drawing.SystemColors.Control
        Me.consolaProceso.Location = New System.Drawing.Point(30, 180)
        Me.consolaProceso.Name = "consolaProceso"
        Me.consolaProceso.ReadOnly = True
        Me.consolaProceso.Size = New System.Drawing.Size(369, 101)
        Me.consolaProceso.TabIndex = 11
        Me.consolaProceso.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Información de la Conexión"
        '
        'TodoOk
        '
        Me.TodoOk.Location = New System.Drawing.Point(186, 130)
        Me.TodoOk.Name = "TodoOk"
        Me.TodoOk.Size = New System.Drawing.Size(75, 23)
        Me.TodoOk.TabIndex = 8
        Me.TodoOk.Text = "Empezar"
        Me.TodoOk.UseVisualStyleBackColor = True
        '
        'Clave
        '
        Me.Clave.Location = New System.Drawing.Point(102, 91)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(100, 20)
        Me.Clave.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Contraseña"
        '
        'Usuario
        '
        Me.Usuario.Location = New System.Drawing.Point(299, 41)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(100, 20)
        Me.Usuario.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Usuario"
        '
        'HostNombre
        '
        Me.HostNombre.Location = New System.Drawing.Point(102, 41)
        Me.HostNombre.Name = "HostNombre"
        Me.HostNombre.Size = New System.Drawing.Size(100, 20)
        Me.HostNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Host"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 20)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrearBase
        '
        Me.CrearBase.AutoSize = True
        Me.CrearBase.Location = New System.Drawing.Point(253, 94)
        Me.CrearBase.Name = "CrearBase"
        Me.CrearBase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CrearBase.Size = New System.Drawing.Size(124, 17)
        Me.CrearBase.TabIndex = 14
        Me.CrearBase.Text = "Crear Base de Datos"
        Me.CrearBase.UseVisualStyleBackColor = True
        '
        'PanelFinal
        '
        Me.PanelFinal.Controls.Add(Me.Button2)
        Me.PanelFinal.Controls.Add(Me.RichTextBox1)
        Me.PanelFinal.Controls.Add(Me.Label8)
        Me.PanelFinal.Location = New System.Drawing.Point(30, 9)
        Me.PanelFinal.Name = "PanelFinal"
        Me.PanelFinal.Size = New System.Drawing.Size(369, 168)
        Me.PanelFinal.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(142, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 42)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(363, 84)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = "Todo está listo, podras volver a realizar esta configuración en cualquier momento" &
    " en Menú->Asistente de Configuración"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Entiendo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Asistente_Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 310)
        Me.Controls.Add(Me.PanelConfig)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.InfoText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.holaL)
        Me.Name = "Asistente_Configuracion"
        Me.Text = "Asistente de Configuración"
        Me.PanelConfig.ResumeLayout(False)
        Me.PanelConfig.PerformLayout()
        Me.PanelFinal.ResumeLayout(False)
        Me.PanelFinal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents holaL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InfoText As RichTextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents PanelConfig As Panel
    Friend WithEvents HostNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TodoOk As Button
    Friend WithEvents Clave As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents consolaProceso As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CrearBase As CheckBox
    Friend WithEvents PanelFinal As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label8 As Label
End Class
