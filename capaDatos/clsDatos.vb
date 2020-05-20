Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports capaEntidad
Public Class clsDatos
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("crudAlumnos").ConnectionString)

    'MostrarTabla
    Public Function D_ListaAlumnos() As DataTable
        Dim cmd As New SqlCommand("Select * from Alumnos", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function

    'Insertar alumnos
    Public Sub D_InsertarAlumnos(enti As clsEntidad)
        Dim cmd As New SqlCommand("insert into Alumnos values(@nomAlum,@apeAlum,@sexAlum,@numAlum,@emailAlum)", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@nomAlum", enti.nombre)
            .AddWithValue("@apeAlum", enti.apellido)
            .AddWithValue("@sexAlum", enti.sexo)
            .AddWithValue("@numAlum", enti.numero)
            .AddWithValue("@emailAlum", enti.email)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub
    Public Sub D_EditarAlumnos(enti As clsEntidad, idAlumnos As Integer)
        Dim cmd As New SqlCommand("update Alumnos set nombre=@nomAlum,apellidos=@apeAlum,sexo=@sexAlum,numero=@numAlum,email=@emailAlum where idAlumnos=@idAlum", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@idAlum", idAlumnos)
            .AddWithValue("@nomAlum", enti.nombre)
            .AddWithValue("@apeAlum", enti.apellido)
            .AddWithValue("@sexAlum", enti.sexo)
            .AddWithValue("@numAlum", enti.numero)
            .AddWithValue("@emailAlum", enti.email)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub
    Public Sub D_EliminarAlumnos(idAlumn As Integer)
        Dim cmd As New SqlCommand("delete from Alumnos where idAlumnos=@idAlum", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@idAlum", idAlumn)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub

End Class
