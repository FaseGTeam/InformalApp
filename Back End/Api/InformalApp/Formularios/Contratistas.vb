Imports System.Globalization

Public Class Contratistas
    Dim con As New Conexion
    Dim crud_Contratista As New CRUD_Contratista
    Private Sub Contratistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = con.ObtenerTabla("Select * from contratista")
    End Sub


    Private Sub cargarContratista(ByVal row As DataGridViewRow)
        If row IsNot Nothing Then
            TextBoxId.Text = row.Cells.Item(0).Value.ToString()
            TextBoxCedula.Text = row.Cells.Item(1).Value.ToString()
            TextBoxNombre.Text = row.Cells.Item(2).Value.ToString()
            TextBoxApellido.Text = row.Cells.Item(3).Value.ToString()
            FecNacimiento.Text = row.Cells.Item(4).Value.ToString()
            TextBoxCargo.Text = row.Cells.Item(5).Value.ToString()
            TextBoxEmpresa.Text = row.Cells.Item(6).Value.ToString()
        End If
    End Sub

    Private Sub limpiarContratista()
        TextBoxId.Text = ""
        TextBoxCedula.Text = ""
        TextBoxNombre.Text = ""
        TextBoxApellido.Text = ""
        FecNacimiento.Text = ""
        TextBoxCargo.Text = ""
        TextBoxEmpresa.Text = ""
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            TextBoxId.ResetText()
            TextBoxId.ReadOnly = False
            cargarContratista(DataGridView1.CurrentRow)
        End If
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        TextBoxId.Text = ""
        TextBoxId.ReadOnly = True
        limpiarContratista()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If TextBoxId.Text <> "" Then
            crud_Contratista.Eliminar(Integer.Parse(TextBoxId.Text))
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            cargarDatos()
        End If
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim a, d
        Dim h As Date

        'Convirtiendo información'
        Integer.TryParse(TextBoxCedula.Text, a)
        Integer.TryParse(TextBoxId.Text, d)
        Date.TryParse(FecNacimiento.Text, h)

        Dim contratista As New Contratista(a, TextBoxNombre.Text.ToString(), TextBoxApellido.Text.ToString(), "f", h.ToString("yyyy-MM-dd"), d, TextBoxEmpresa.Text.ToString(), TextBoxCargo.Text.ToString())
        Dim contratistaEnDb = Nothing

        'crea el contratista si no existe'
        If TextBoxId.Text = "" Then
            crud_Contratista.Insertar(contratista)
        Else
            crud_Contratista.Actualizar(contratista)
        End If
        cargarDatos()
    End Sub
End Class