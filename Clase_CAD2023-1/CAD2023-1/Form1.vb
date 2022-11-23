Public Class Form1
    Private Sub ConectarConAutoCADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarConAutoCADToolStripMenuItem.Click
        inicializa_conexion("2022")
        If Not DOCUMENTO Is Nothing Then
            dwgActual.Text = DOCUMENTO.Name
        Else
            dwgActual.Text = ""
        End If
    End Sub

End Class
