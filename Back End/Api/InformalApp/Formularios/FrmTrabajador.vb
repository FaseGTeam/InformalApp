Public Class Frm_Trabajador
    Dim HojaVidaTrabajador As Boolean
    Dim HojaVidaTrabajadorS As String
    Dim ValidacionFrm As ValidacionesFrm = New ValidacionesFrm
    Dim DataReader As MySql.Data.MySqlClient.MySqlDataReader

    Private Sub Frm_Trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'Evento Click Botón CONSULTAR Trabajador'
    Private Sub Button_ConsultarT_Click(sender As Object, e As EventArgs) Handles Button_ConsultarT.Click
        Dim ConsultarTrabajador As CRUD_Trabajador = New CRUD_Trabajador

        Try
            If TextBox_CedulaT.Text <> "" Then
                DataReader = ConsultarTrabajador.ReadData(TextBox_CedulaT.Text)

                If DataReader.HasRows <> Nothing Then
                    While DataReader.Read()
                        If DataReader("HojaVida").ToString = True Then
                            HojaVidaTrabajadorS = "Si"
                        Else
                            HojaVidaTrabajadorS = "No"
                        End If

                        TextBox_CedulaT.Text = DataReader("Cedula").ToString
                        TextBox_NombresT.Text = DataReader("Nombre").ToString
                        TextBox_ApellidosT.Text = DataReader("Apellido").ToString
                        ComboBox_GeneroT.Text = DataReader("Genero").ToString
                        MaskedTextBox_FecNacimientoT.Text = DataReader.GetDateTime("Fecha_Nacimiento").ToString("yyyy/MM/dd")
                        TextBox_ProfesionT.Text = DataReader("Profesion").ToString
                        TextBox_LvlEducativoT.Text = DataReader("LvlEducativo").ToString
                        TextBox_ExpLaboralT.Text = DataReader("ExpTrabajo").ToString
                        ComboBox_HojaVidaT.Text = HojaVidaTrabajadorS

                    End While

                Else
                    MsgBox("¡El registro No se encuentra Disponible en la Base de Datos!")
                End If
            Else
                MsgBox("¡Complete el campo Cédula!")
                TextBox_CedulaT.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub 'Fin Evento CONSULTAR Trabajador'

    'Evento Click Botón CREAR Trabajador'
    Private Sub Button_CrearT_Click(sender As Object, e As EventArgs) Handles Button_CrearT.Click
        Dim CrearTrabajador As CRUD_Trabajador = New CRUD_Trabajador

        If ValidarFormulario_FrmTrabajador() = False Then 'Se realiza la validación de los campos del Formulario'
            If ComboBox_HojaVidaT.SelectedItem = "Si" Then
                HojaVidaTrabajador = True
            Else
                HojaVidaTrabajador = False
            End If

            Try
                CrearTrabajador.InsertData(TextBox_CedulaT.Text,
                                           TextBox_NombresT.Text,
                                           TextBox_ApellidosT.Text,
                                           ComboBox_GeneroT.Text,
                                           MaskedTextBox_FecNacimientoT.Text,
                                           TextBox_ProfesionT.Text,
                                           TextBox_LvlEducativoT.Text,
                                           TextBox_ExpLaboralT.Text,
                                           HojaVidaTrabajador)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If 'Fin If ValidarFormulario_FrmTrabajador'

    End Sub 'Fin Evento CREAR Trabajador'

    'Evento Click Botón ACTUALIZAR Trabajador'
    Private Sub Button_ActualizarT_Click(sender As Object, e As EventArgs) Handles Button_ActualizarT.Click
        Dim ActualizarTrabajador As CRUD_Trabajador = New CRUD_Trabajador

        If TextBox_CedulaT.Text <> "" Then 'Se valida que el TextBox Cédula se le Ingrese un Valor'
            If ComboBox_HojaVidaT.SelectedItem = "Si" Then
                HojaVidaTrabajador = True
            Else
                HojaVidaTrabajador = False
            End If

            Try
                ActualizarTrabajador.UpdateData(TextBox_CedulaT.Text,
                                            TextBox_NombresT.Text,
                                            TextBox_ApellidosT.Text,
                                            ComboBox_GeneroT.Text,
                                            MaskedTextBox_FecNacimientoT.Text,
                                            TextBox_ProfesionT.Text,
                                            TextBox_LvlEducativoT.Text,
                                            TextBox_ExpLaboralT.Text,
                                            HojaVidaTrabajador)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("¡Los datos que intenta actualizar se encuentran Incompletos!")
            TextBox_CedulaT.Select()
        End If

    End Sub 'Fin Evento Botón ACTUALIZAR Trabajador'

    'Evento Click Botón ELIMINAR Trabajador'
    Private Sub Button_EliminarT_Click(sender As Object, e As EventArgs) Handles Button_EliminarT.Click
        Dim EliminarTrabajador As CRUD_Trabajador = New CRUD_Trabajador

        If TextBox_CedulaT.Text = "" Then
            Try
                EliminarTrabajador.DeleteData()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                EliminarTrabajador.DeleteDataForCedula(TextBox_CedulaT.Text)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub 'Fin Evento Botón ELIMINAR Trabajador'

    Private Sub TextBox_CedulaT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_CedulaT.KeyPress
        ValidacionFrm.ValidaNumeros(e)
    End Sub

    Private Sub TextBox_NombresT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NombresT.KeyPress
        ValidacionFrm.ValidaLetras(e)
    End Sub

    Private Sub TextBox_ApellidosT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ApellidosT.KeyPress
        ValidacionFrm.ValidaLetras(e)
    End Sub

    Private Sub TextBox_ProfesionT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ProfesionT.KeyPress
        ValidacionFrm.ValidaLetras(e)
    End Sub

    Private Sub TextBox_LvlEducativoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_LvlEducativoT.KeyPress
        ValidacionFrm.ValidaLetras(e)
    End Sub

    'Función que VALIDA que los TextBox del formulario FrmTrabajador no se encuentren vácios'
    Public Function ValidarFormulario_FrmTrabajador()
        Dim Salida As Boolean = False
        If TextBox_CedulaT.Text = "" Then
            MsgBox("Complete el campo Cédula")
            TextBox_CedulaT.Select()
            Salida = True
        ElseIf TextBox_NombresT.Text = "" Then
            MsgBox("Complete el campo Nombres")
            TextBox_NombresT.Select()
            Salida = True
        ElseIf TextBox_ApellidosT.Text = "" Then
            MsgBox("Complete el campo Apellidos")
            TextBox_ApellidosT.Select()
            Salida = True
        ElseIf ComboBox_GeneroT.Text = "" Then
            MsgBox("Complete el campo Género")
            ComboBox_GeneroT.Select()
            Salida = True
        ElseIf MaskedTextBox_FecNacimientoT.Text = "    /  /" Then
            MsgBox("Complete el campo Fecha de Nacimiento")
            MaskedTextBox_FecNacimientoT.Select()
            Salida = True
        ElseIf TextBox_ProfesionT.Text = "" Then
            MsgBox("Complete el campo Profesión")
            TextBox_ProfesionT.Select()
            Salida = True
        ElseIf TextBox_LvlEducativoT.Text = "" Then
            MsgBox("Complete el campo Nivel Educativo")
            TextBox_LvlEducativoT.Select()
            Salida = True
        ElseIf TextBox_ExpLaboralT.Text = "" Then
            MsgBox("Complete el campo experiencia Laboral")
            TextBox_ExpLaboralT.Select()
            Salida = True
        ElseIf ComboBox_HojaVidaT.Text = "" Then
            MsgBox("Complete el campo Hoja de vida")
            ComboBox_HojaVidaT.Select()
            Salida = True
        End If
        Return Salida 'Returna Salida'

    End Function 'Fin función ValidarFormulario_FrmTrabajador'

End Class 'Fin Clase Frm_Trabajador'
