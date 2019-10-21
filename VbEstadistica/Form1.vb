Imports System.IO

Public Class Form1
    Private Sub NuevoDatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDatoToolStripMenuItem.Click
        Dim f1 As New Nuevo
        f1.Show()
    End Sub

    Private Sub CambiarDatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDatoToolStripMenuItem.Click
        Dim f2 As New Cambio
        f2.Show()
    End Sub

    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click
        Dim sw As New StreamWriter("Informe.txt")
        Dim suma As Double
        sw.WriteLine("{0,10}    {1,4}", "Alumno", "Nota")
        For Each a As Alumno In Alumnos
            sw.WriteLine("{0,10}    {1,4}", a.nombre, a.nota)
            suma += a.nota
        Next
        sw.WriteLine("Media:{0}", suma / Alumnos.Count)
        sw.Close()

    End Sub
End Class
