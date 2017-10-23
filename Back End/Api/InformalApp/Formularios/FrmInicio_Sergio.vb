Public Class FrmInicio_Sergio
    Dim con As New Conexion
    Dim conectado = False
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

    Private Sub ButtonTestCon_Click(sender As Object, e As EventArgs) Handles ButtonTestCon.Click

        If conectado Like False Then
            Me.con.Conectar(True)
            conectado = True
        Else
            Me.con.CerraConection(True)
            conectado = False
        End If
    End Sub
End Class