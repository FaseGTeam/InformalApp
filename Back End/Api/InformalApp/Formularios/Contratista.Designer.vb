<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Contratista
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
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCargo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FecNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.Label_FecNacimientoT = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(124, 26)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxId.TabIndex = 1
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(124, 52)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCedula.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cédula"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(124, 78)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(124, 104)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido"
        '
        'TextBoxCargo
        '
        Me.TextBoxCargo.Location = New System.Drawing.Point(124, 156)
        Me.TextBoxCargo.Name = "TextBoxCargo"
        Me.TextBoxCargo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCargo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cargo"
        '
        'FecNacimiento
        '
        Me.FecNacimiento.Location = New System.Drawing.Point(124, 130)
        Me.FecNacimiento.Mask = "0000/00/00"
        Me.FecNacimiento.Name = "FecNacimiento"
        Me.FecNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.FecNacimiento.TabIndex = 25
        Me.FecNacimiento.ValidatingType = GetType(Date)
        '
        'Label_FecNacimientoT
        '
        Me.Label_FecNacimientoT.AutoSize = True
        Me.Label_FecNacimientoT.Location = New System.Drawing.Point(5, 127)
        Me.Label_FecNacimientoT.Name = "Label_FecNacimientoT"
        Me.Label_FecNacimientoT.Size = New System.Drawing.Size(108, 13)
        Me.Label_FecNacimientoT.TabIndex = 24
        Me.Label_FecNacimientoT.Text = "Fecha de Nacimiento"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(244, 51)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(8, 8)
        Me.FlowLayoutPanel1.TabIndex = 26
        '
        'Frm_Contratista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FecNacimiento)
        Me.Controls.Add(Me.Label_FecNacimientoT)
        Me.Controls.Add(Me.TextBoxCargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Contratista"
        Me.Text = "Frm_Contratista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FecNacimiento As MaskedTextBox
    Friend WithEvents Label_FecNacimientoT As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
