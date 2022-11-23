Imports System.Data.OleDb

Module CODIGO
    Public Sub inicializa_conexion(ByRef version As String)
        Dim R As String

        If version = "2000" Then
            R = "AUTOCAD.Application.15" 'R2000-2002
        ElseIf version = "2004" Then
            R = "AUTOCAD.Application.16" 'R2004-R2006
        ElseIf version = "2007" Or version = "2009" Then
            R = "AUTOCAD.Application.17" 'R2007-R2008-R2009
        ElseIf version = "2010" Then
            R = "AUTOCAD.Application.18" 'R2010-R2011-R2012
        ElseIf version = "2013" Then
            R = "AUTOCAD.Application.19" 'R2013-R2014
        ElseIf version = "2015" Then
            R = "AUTOCAD.Application.20" 'R2015-R2016
        ElseIf version = "2017" Then
            R = "AUTOCAD.Application.21" 'R2017
        ElseIf version = "2018" Then
            R = "AUTOCAD.Application.22" 'R2018
        ElseIf version = "2021" Or version = "2022" Then    'R2021-R2022
            R = "AUTOCAD.Application.24"
        Else
            R = ""
        End If

        Try
            DOCUMENTO = Nothing
            AUTOCADAPP = GetObject(, R)
            DOCUMENTO = AUTOCADAPP.ActiveDocument
            UTILITY = DOCUMENTO.Utility
            AUTOCADAPP.Visible = True
        Catch er As Exception
            MsgBox(er.Message, MsgBoxStyle.Information, "CAD")
        End Try

    End Sub
End Module
