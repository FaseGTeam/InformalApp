Public Class FrmLabor
    Private Sub BtnCrearLabor_Click(sender As Object, e As EventArgs) Handles BtnCrearLabor.Click
        Dim CrearLabor As New CRUD_Labor
        Try
            CrearLabor.InsertData(TxtIdLabor.Text,
                                  TxtDescripcionLabor.Text,
                                  TxtFechaIniLabor.Text,
                                  TxtFechaFinLabor.Text,
                                  CboxContratista.ValueMember,
                                  CboxTrabajador.ValueMember,
                                  TxtTipoLabor.Text)

        Catch ex As Exception

        End Try

    End Sub



    Private Sub CboxContratista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboxContratista.SelectedIndexChanged


    End Sub

    Private Sub FrmLabor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CrudTrabajador As New CRUD_Trabajador
        CboxTrabajador.DataSource = CrudTrabajador.ReadDataList
        CboxTrabajador.DisplayMember = "Nombre"
        CboxTrabajador.ValueMember = "Cedula"
        CboxTrabajador.Text = "Seleccione un trabajador"
    End Sub
End Class