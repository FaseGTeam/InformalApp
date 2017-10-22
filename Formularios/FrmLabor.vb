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

    Private Sub FrmLabor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CrudTrabajador As New CRUD_Trabajador
        CboxTrabajador.ValueMember = CrudTrabajador.ReadDataList

        CboxContratista.ValueMember = "Pepito"


    End Sub
End Class