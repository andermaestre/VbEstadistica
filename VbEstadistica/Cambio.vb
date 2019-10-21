Public Class Cambio
    Dim elegido As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Alumnos.Remove(elegido)
        Dim aux As Alumno
        aux.nombre = tbcNombre.Text
        aux.nota = tbcNota.Text

        Alumnos.Add(aux, aux.nombre)







        'If Alumnos.Item(Integer.Parse(tbcIndex.Text)).nombre <> tbcNombre.Text And Alumnos.Item(Integer.Parse(tbcIndex.Text)).nota <> tbcNota.Text Then
        '    Dim aux As Alumno
        '    aux.nombre = tbcNombre.Text
        '    aux.nota = tbcNota.Text
        '    Alumnos.Remove(Integer.Parse(tbcIndex.Text))
        '    Alumnos(Integer.Parse(tbcIndex.Text)).nombre = aux.nombre
        '    Alumnos(Integer.Parse(tbcIndex.Text)).nota = aux.nota
        '    Alumnos.Add(aux)

        'End If
    End Sub

    Private Sub tbcIndex_TextChanged(sender As Object, e As EventArgs) Handles tbcIndex.TextChanged
        Dim indice As Integer
        Try
            indice = Integer.Parse(tbcIndex.Text)
        Catch ex As Exception
            tbcNombre.Text = ""
            tbcNota.Text = ""
        End Try
        If Alumnos.Count > Integer.Parse(tbcIndex.Text) And Integer.Parse(tbcIndex.Text) > 0 Then

            tbcNombre.Text = Alumnos.Item(indice).nombre
            tbcNota.Text = Alumnos.Item(indice).nota
            elegido = tbcNombre.Text
        End If

    End Sub
End Class