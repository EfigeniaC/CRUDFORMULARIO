Imports capaNegocios
Imports capaEntidad


Public Class F_Agregar
    Dim objNeg As New clsNegocios
    Dim objEnt As New clsEntidad

    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnAgregarAlumno.Click
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
        objNeg.N_InsertarAlumnos(objEnt)
        MessageBox.Show("Datos Insertados correctamente")
        Me.Close()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombreAlumno.Clear()
        txtApellidosAlumnos.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
    End Sub
End Class