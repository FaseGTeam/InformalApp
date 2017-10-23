Public Class Frm_Contratista
    Dim modulo As New CRUD_Contratista()
    Private Sub Frm_Contratista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub cargarContratista(ByVal Id As Integer)
        Dim contratista = modulo.ObtenerPorId(Id)

        If contratista IsNot Nothing Then
            TextBoxId.Text = contratista.Id
            TextBoxCedula.Text = contratista.Cedula
            TextBoxNombre.Text = contratista.Nombres
            TextBoxApellido.Text = contratista.Apellidos
            FecNacimiento.Text = contratista.FecNacimiento
            TextBoxCargo.Text = contratista.Cargo
        End If
    End Sub
End Class