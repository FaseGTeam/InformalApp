<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio_Sergio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio_Sergio))
        Me.Button_FrmTrabajador = New System.Windows.Forms.Button()
        Me.Button_FrmContratista = New System.Windows.Forms.Button()
        Me.Button_FrmLog = New System.Windows.Forms.Button()
        Me.Button_FrmLabor = New System.Windows.Forms.Button()
        Me.Label_TrabajadorInicio = New System.Windows.Forms.Label()
        Me.Label_ContratistaInicio = New System.Windows.Forms.Label()
        Me.Lable_LaborInicio = New System.Windows.Forms.Label()
        Me.Label_LogInicio = New System.Windows.Forms.Label()
        Me.ButtonTestCon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_FrmTrabajador
        '
        Me.Button_FrmTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_FrmTrabajador.Image = CType(resources.GetObject("Button_FrmTrabajador.Image"), System.Drawing.Image)
        Me.Button_FrmTrabajador.Location = New System.Drawing.Point(29, 182)
        Me.Button_FrmTrabajador.Name = "Button_FrmTrabajador"
        Me.Button_FrmTrabajador.Size = New System.Drawing.Size(135, 139)
        Me.Button_FrmTrabajador.TabIndex = 0
        Me.Button_FrmTrabajador.UseVisualStyleBackColor = True
        '
        'Button_FrmContratista
        '
        Me.Button_FrmContratista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_FrmContratista.Image = CType(resources.GetObject("Button_FrmContratista.Image"), System.Drawing.Image)
        Me.Button_FrmContratista.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_FrmContratista.Location = New System.Drawing.Point(187, 182)
        Me.Button_FrmContratista.Name = "Button_FrmContratista"
        Me.Button_FrmContratista.Size = New System.Drawing.Size(135, 139)
        Me.Button_FrmContratista.TabIndex = 1
        Me.Button_FrmContratista.UseVisualStyleBackColor = True
        '
        'Button_FrmLog
        '
        Me.Button_FrmLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_FrmLog.Image = CType(resources.GetObject("Button_FrmLog.Image"), System.Drawing.Image)
        Me.Button_FrmLog.Location = New System.Drawing.Point(503, 182)
        Me.Button_FrmLog.Name = "Button_FrmLog"
        Me.Button_FrmLog.Size = New System.Drawing.Size(135, 139)
        Me.Button_FrmLog.TabIndex = 2
        Me.Button_FrmLog.UseVisualStyleBackColor = True
        '
        'Button_FrmLabor
        '
        Me.Button_FrmLabor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_FrmLabor.Image = CType(resources.GetObject("Button_FrmLabor.Image"), System.Drawing.Image)
        Me.Button_FrmLabor.Location = New System.Drawing.Point(345, 182)
        Me.Button_FrmLabor.Name = "Button_FrmLabor"
        Me.Button_FrmLabor.Size = New System.Drawing.Size(135, 139)
        Me.Button_FrmLabor.TabIndex = 3
        Me.Button_FrmLabor.UseVisualStyleBackColor = True
        '
        'Label_TrabajadorInicio
        '
        Me.Label_TrabajadorInicio.AutoSize = True
        Me.Label_TrabajadorInicio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TrabajadorInicio.Location = New System.Drawing.Point(43, 149)
        Me.Label_TrabajadorInicio.Name = "Label_TrabajadorInicio"
        Me.Label_TrabajadorInicio.Size = New System.Drawing.Size(108, 18)
        Me.Label_TrabajadorInicio.TabIndex = 4
        Me.Label_TrabajadorInicio.Text = "Trabajador"
        '
        'Label_ContratistaInicio
        '
        Me.Label_ContratistaInicio.AutoSize = True
        Me.Label_ContratistaInicio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ContratistaInicio.Location = New System.Drawing.Point(203, 149)
        Me.Label_ContratistaInicio.Name = "Label_ContratistaInicio"
        Me.Label_ContratistaInicio.Size = New System.Drawing.Size(106, 18)
        Me.Label_ContratistaInicio.TabIndex = 5
        Me.Label_ContratistaInicio.Text = "Contratista"
        '
        'Lable_LaborInicio
        '
        Me.Lable_LaborInicio.AutoSize = True
        Me.Lable_LaborInicio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable_LaborInicio.Location = New System.Drawing.Point(383, 149)
        Me.Lable_LaborInicio.Name = "Lable_LaborInicio"
        Me.Lable_LaborInicio.Size = New System.Drawing.Size(59, 18)
        Me.Lable_LaborInicio.TabIndex = 6
        Me.Lable_LaborInicio.Text = "Labor"
        '
        'Label_LogInicio
        '
        Me.Label_LogInicio.AutoSize = True
        Me.Label_LogInicio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LogInicio.Location = New System.Drawing.Point(549, 149)
        Me.Label_LogInicio.Name = "Label_LogInicio"
        Me.Label_LogInicio.Size = New System.Drawing.Size(40, 18)
        Me.Label_LogInicio.TabIndex = 7
        Me.Label_LogInicio.Text = "Log"
        '
        'ButtonTestCon
        '
        Me.ButtonTestCon.Location = New System.Drawing.Point(29, 13)
        Me.ButtonTestCon.Name = "ButtonTestCon"
        Me.ButtonTestCon.Size = New System.Drawing.Size(122, 23)
        Me.ButtonTestCon.TabIndex = 8
        Me.ButtonTestCon.Text = "Test de Conexión"
        Me.ButtonTestCon.UseVisualStyleBackColor = True
        '
        'FrmInicio_Sergio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(671, 366)
        Me.Controls.Add(Me.ButtonTestCon)
        Me.Controls.Add(Me.Label_LogInicio)
        Me.Controls.Add(Me.Lable_LaborInicio)
        Me.Controls.Add(Me.Label_ContratistaInicio)
        Me.Controls.Add(Me.Label_TrabajadorInicio)
        Me.Controls.Add(Me.Button_FrmLabor)
        Me.Controls.Add(Me.Button_FrmLog)
        Me.Controls.Add(Me.Button_FrmContratista)
        Me.Controls.Add(Me.Button_FrmTrabajador)
        Me.Name = "FrmInicio_Sergio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_FrmTrabajador As Button
    Friend WithEvents Button_FrmContratista As Button
    Friend WithEvents Button_FrmLabor As Button
    Friend WithEvents Button_FrmLog As Button
    Friend WithEvents Label_TrabajadorInicio As Label
    Friend WithEvents Label_ContratistaInicio As Label
    Friend WithEvents Lable_LaborInicio As Label
    Friend WithEvents Label_LogInicio As Label
    Friend WithEvents ButtonTestCon As Button
End Class
