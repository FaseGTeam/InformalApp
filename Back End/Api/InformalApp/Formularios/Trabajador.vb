Imports MySql.Data.MySqlClient

Public Class Frm_Trabajador
    Dim HojaVidaTrabajador As Boolean
    Public DataTable As New DataTable
    Public DataReader As MySqlDataReader

    Private Sub Frm_Trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataTable.Columns.Add("Cédula")
        DataTable.Columns.Add("Nombres")
        DataTable.Columns.Add("Apellidos")
        DataTable.Columns.Add("Género")
        DataTable.Columns.Add("Fecha Nacimiento")
        DataTable.Columns.Add("Profesión")
        DataTable.Columns.Add("Nivel Educativo")
        DataTable.Columns.Add("Exp. Laboral")
        DataTable.Columns.Add("Hoja de Vida")

    End Sub

    Private Sub Button_ConsultarT_Click(sender As Object, e As EventArgs) Handles Button_ConsultarT.Click
        Dim ConsultarTrabajador As CRUD_Trabajador = New CRUD_Trabajador
        DataTable.Clear()
        Try
            ConsultarTrabajador.ReadData(TextBox_CedulaT.Text,
                                     TextBox_NombresT.Text,
                                     TextBox_ApellidosT.Text,
                                     ComboBox_GeneroT.Text,
                                     MaskedTextBox_FecNacimientoT.Text,
                                     TextBox_ProfesionT.Text,
                                     TextBox_LvlEducativoT.Text,
                                     TextBox_ExpLaboralT.Text,
                                     HojaVidaTrabajador)

            DataTable.Rows.Add(DataReader.Item("Cédula"),
                               DataReader.Item("Nombres"),
                               DataReader.Item("Apellidos"),
                               DataReader.Item("Género"),
                               DataReader.Item("Fecha Nacimiento"),
                               DataReader.Item("Profesión"),
                               DataReader.Item("Nivel Educativo"),
                               DataReader.Item("Exp. Laboral"),
                               DataReader.Item("Hoja de Vida"))

            DataReader.Close()
            DataGridView_Trabajador.DataSource = DataTable
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
