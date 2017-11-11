Public Class Asistente_Configuracion
    Dim con As New Conexion()
    Dim consolaTexo = ""
    Dim mensaje As String
    Dim continuarProceso As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        cambiarVisibilidadConf()
    End Sub

    'Muestra y oculta la información según el estado actual'
    Sub cambiarVisibilidadConf()
        'no es visible, se muestra'
        If PanelConfig.Visible = False Then
            PanelConfig.Show()
        Else
            PanelConfig.Hide()
        End If
    End Sub

    Sub cambiarSoloLectura(ByVal SoloLectura As Boolean)
        'Desactiva los controles'
        HostNombre.ReadOnly = SoloLectura
        Usuario.ReadOnly = SoloLectura
        Clave.ReadOnly = SoloLectura
    End Sub

    Sub escribirProceso(ByVal texto As String)
        consolaTexo = consolaTexo + IIf(consolaTexo Is "", $"{Date.Now()} - {texto}", $"{vbLf} {Date.Now()} - {texto}")
        consolaProceso.Text = consolaTexo
    End Sub

    Private Sub Asistente_Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelConfig.Hide()
        PanelFinal.Hide()
    End Sub

    Private Sub TodoOk_Click(sender As Object, e As EventArgs) Handles TodoOk.Click
        cambiarSoloLectura(True)
        continuarProceso = True

        con.ConfigurarConexion(HostNombre.Text, Usuario.Text, Clave.Text)
        escribirProceso("Conexión Guardada")

        mensaje = con.Conectar()

        If mensaje Is "00, Conexion Exitosa" Then
            escribirProceso("Conexión Establecida")
        Else
            continuarProceso = False
            escribirProceso(mensaje)
        End If

        con.CerraConection()

        If continuarProceso And CrearBase.Checked.Equals(True) Then
            mensaje = con.CrearDb()

            If mensaje = "Sentecia exitosa" Then
                con.ConfigurarConexion(HostNombre.Text, Usuario.Text, Clave.Text, "db_informalapp")
                escribirProceso("Base de datos creada")
            Else
                continuarProceso = False
                escribirProceso($"Error al crear la base de datos: {mensaje}")
            End If
        Else
            con.ConfigurarConexion(HostNombre.Text, Usuario.Text, Clave.Text, "db_informalapp")
        End If

        If continuarProceso = True Then
            PanelFinal.Show()
        End If

        mensaje = con.CerraConection()

        If mensaje Is "Ok" Then
            escribirProceso("Conexión Cerrada")
        Else
            escribirProceso(mensaje)
        End If

        cambiarSoloLectura(False)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        consolaTexo = ""
        consolaProceso.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formInicio As New FrmInicio_Sergio
        formInicio.Show()
        Me.Close()
    End Sub
End Class