Public Class Inicio
    Private Sub Btn_Contratistas_Click(sender As Object, e As EventArgs) Handles Btn_Contratistas.Click
        Dim formContratista = New Contratistas()
        formContratista.Show()
    End Sub

    Private Sub Btn_Trabajadores_Click(sender As Object, e As EventArgs) Handles Btn_Trabajadores.Click
        Dim formContratista = New Frm_Contratista()
        formContratista.Show()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class