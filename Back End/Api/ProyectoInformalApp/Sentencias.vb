Public Class Sentencias
    Public cadena As String
    Function CrearPersona(ByVal persona As Persona) As Integer
        cadena = $"insert into Persona  values {persona.Nombres}"
        Return 0
    End Function
End Class
