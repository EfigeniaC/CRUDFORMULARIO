Public Class Presentacion
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnIngresarPresentacion.Click
        Dim fc As New Form1
        fc.Show()
        Me.Hide()
    End Sub

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class