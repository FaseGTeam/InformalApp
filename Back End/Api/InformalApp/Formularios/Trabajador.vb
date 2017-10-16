Public Class Frm_Trabajador
    Dim HojaVidaTrabajador As Boolean
    Dim HojaVidaTrabajadorS As String
    Dim DataReader As MySql.Data.MySqlClient.MySqlDataReader

    Private Sub Frm_Trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button_ConsultarT_Click(sender As Object, e As EventArgs) Handles Button_ConsultarT.Click
        Dim ConsultarTrabajador As CRUD_Trabajador = New CRUD_Trabajador
        Try

            DataReader = ConsultarTrabajador.ReadData(TextBox_CedulaT.Text)

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
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Button_CrearT_Click(sender As Object, e As EventArgs) Handles Button_CrearT.Click
        Dim CrearTrabajador As CRUD_Trabajador = New CRUD_Trabajador

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
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Button_ActualizarT_Click(sender As Object, e As EventArgs) Handles Button_ActualizarT.Click
        Dim ActualizarTrabajador As CRUD_Trabajador = New CRUD_Trabajador

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
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Button_EliminarT_Click(sender As Object, e As EventArgs) Handles Button_EliminarT.Click
        Dim EliminarTrabajador As CRUD_Trabajador = New CRUD_Trabajador

        Try
            EliminarTrabajador.DeleteData(TextBox_CedulaT.Text)

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

End Class
