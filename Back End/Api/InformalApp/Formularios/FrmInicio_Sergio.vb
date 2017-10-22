Public Class FrmInicio_Sergio
    Private Sub Button_FrmLabor_Click(sender As Object, e As EventArgs) Handles Button_FrmLabor.Click

    End Sub

    Private Sub Button_FrmContratista_Click(sender As Object, e As EventArgs) Handles Button_FrmContratista.Click
        Dim formContratista = New Contratistas()
        formContratista.Show()
    End Sub

    Private Sub Button_FrmTrabajador_Click(sender As Object, e As EventArgs) Handles Button_FrmTrabajador.Click
        Dim frm_Trabajador = New Frm_Trabajador()
        frm_Trabajador.Show()
    End Sub
End Class