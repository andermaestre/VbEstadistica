Public Class Nuevo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not Alumnos.Contains(tbnNombre.Text) And Integer.Parse(tbnNota.Text) >= 0 And Integer.Parse(tbnNota.Text) <= 10 Then
            Dim aux As Alumno
            aux.nombre = tbnNombre.Text
            aux.nota = tbnNota.Text

            Alumnos.Add(aux, aux.nombre)
        Else
            MsgBox("No tiene sentido eso que me dices" + vbCrLf + "ERROR: dlafgjadlfkjdsfjsadklfj" + vbCrLf + "Aque jode.")
        End If

    End Sub
End Class