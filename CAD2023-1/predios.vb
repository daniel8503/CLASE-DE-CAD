Public Class predios
    Private Sub ConectarConAutoCADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarConAutoCADToolStripMenuItem.Click
        inicializa_conexion("2022")

        If IsNothing(DOCUMENTO) Then
            dwgActual.Text = ""
        Else
            dwgActual.Text = DOCUMENTO.Name
        End If
    End Sub

    Private Sub dwgActual_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InformaciónPredioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónPredioToolStripMenuItem.Click
        '  Dim ObjEscuela As AcadObject
        ' Dim BlockEscuela As AcadBlockReference

        ' Dim ConjuntoBloques As AcadBlocks
        ' Dim UnBloque As AcadBlock

        ' ConjuntoBloques = AutoCAD.AcadApplication.ActiveDocument.Blocks
    End Sub
End Class