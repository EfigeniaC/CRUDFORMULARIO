Imports capaDatos
Imports capaEntidad

Public Class clsNegocios
    Private objDatos As New clsDatos
    Public Function N_ListaAlumnos() As DataTable
        Return objDatos.D_ListaAlumnos
    End Function

    Public Sub N_InsertarAlumnos(enti As clsEntidad)
        objDatos.D_InsertarAlumnos(enti)
    End Sub

    Public Sub N_EditarAlumnos(enti As clsEntidad, idAlumnos As Integer)
        objDatos.D_EditarAlumnos(enti, idAlumnos)
    End Sub

    Public Sub N_EliminarAlumno(idAlumn As Integer)
        objDatos.D_EliminarAlumnos(idAlumn)
    End Sub
End Class
