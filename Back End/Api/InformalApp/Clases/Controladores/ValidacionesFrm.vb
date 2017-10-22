Public Class ValidacionesFrm

    'Método de Solo Lectura'
    Public Sub SoloLectura(ByVal e As KeyPressEventArgs)
        e.Handled = False
    End Sub 'Fin Método SoloLectura'

    'Método para Validar que Solo se puedan ingresar Números'
    Public Sub ValidaNumeros(ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub 'Fin Método ValidaNumeros'

    'Método para Validar que Solo se puedan ingresar Letras'
    Public Sub ValidaLetras(ByVal e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub 'Fin Método ValidaLetras'

End Class 'Fin Clase ValidacionesFrm'
