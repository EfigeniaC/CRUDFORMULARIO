Imports capaNegocios
Imports capaEntidad
Public Class Form1
    Dim objNego As New clsNegocios
    Dim objEnt As New clsEntidad

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaAlumnos()


    End Sub
    Sub ListaAlumnos()
        Dim dt As DataTable = objNego.N_ListaAlumnos
        Dgv_Alumnos.DataSource = dt

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim sexo As String
        If rbFemenino.Checked = True Then
            sexo = "F"
        ElseIf rbMasculino.Checked = True Then
            sexo = "M"
        End If


        objEnt.nombre = txtNombreAlumno.Text
        objEnt.apellido = txtApellidosAlumnos.Text
        objEnt.sexo = sexo
        objEnt.numero = txtTelefono.Text
        objEnt.email = txtCorreo.Text
        objNego.N_InsertarAlumnos(objEnt)
        MessageBox.Show("Datos Insertados correctamente")
        Limpiar()
        ListaAlumnos()
    End Sub

    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim idAlumnos As Integer
        Dim i As Integer
        i = Dgv_Alumnos.CurrentRow.Index
        idAlumnos = Dgv_Alumnos.Item(0, i).Value()
        Dim sexo As String
        If rbFemenino.Checked = True Then
            sexo = "F"
        ElseIf rbMasculino.Checked = True Then
            sexo = "M"
        End If


        objEnt.nombre = txtNombreAlumno.Text
        objEnt.apellido = txtApellidosAlumnos.Text
        objEnt.sexo = sexo
        objEnt.numero = txtTelefono.Text
        objEnt.email = txtCorreo.Text
        objNego.N_EditarAlumnos(objEnt, idAlumnos)
        Limpiar()
        MsgBox("Actualización Exitosa")
        ListaAlumnos()
    End Sub
    Sub Limpiar()
        txtNombreAlumno.Clear()
        txtApellidosAlumnos.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idAlumn As Integer
        Dim i As Integer
        i = Dgv_Alumnos.CurrentRow.Index
        idAlumn = Dgv_Alumnos.Item(0, i).Value()
        objNego.N_EliminarAlumno(idAlumn)
        Limpiar()
        MsgBox("Eliminacion Exitosa")
        ListaAlumnos()
    End Sub

    Private Sub Dgv_Alumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Alumnos.CellClick
        Dim i As Integer
        i = Dgv_Alumnos.CurrentRow.Index
        txtNombreAlumno.Text = Dgv_Alumnos.Item(1, i).Value()
        txtApellidosAlumnos.Text = Dgv_Alumnos.Item(2, i).Value()
        txtTelefono.Text = Dgv_Alumnos.Item(4, i).Value()
        txtCorreo.Text = Dgv_Alumnos.Item(5, i).Value()
    End Sub
End Class
