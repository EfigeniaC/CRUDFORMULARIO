<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presentacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PLogo = New System.Windows.Forms.Panel()
        Me.PBlogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnIngresarPresentacion = New FontAwesome.Sharp.IconButton()
        Me.PLogo.SuspendLayout()
        CType(Me.PBlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PLogo
        '
        Me.PLogo.Controls.Add(Me.PBlogo)
        Me.PLogo.Location = New System.Drawing.Point(12, 12)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(367, 106)
        Me.PLogo.TabIndex = 0
        '
        'PBlogo
        '
        Me.PBlogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBlogo.Image = Global.CRUDFORMULARIO.My.Resources.Resources.logouss
        Me.PBlogo.Location = New System.Drawing.Point(0, 0)
        Me.PBlogo.Name = "PBlogo"
        Me.PBlogo.Size = New System.Drawing.Size(367, 106)
        Me.PBlogo.TabIndex = 1
        Me.PBlogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Integrantes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "-Carrillo Cajo Cynthia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "-Gutierrez Balcazar Grabiela"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "-Piscoya Inoñan Sandra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(292, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "-Serrato Vilcherrez Fernando"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "-Chavez Manayalle Sebasty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "-Paico Chileno Daniel"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(80, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(339, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Crud Sobre el Registro de Alumnos"
        '
        'btnIngresarPresentacion
        '
        Me.btnIngresarPresentacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIngresarPresentacion.Font = New System.Drawing.Font("Garamond", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarPresentacion.IconChar = FontAwesome.Sharp.IconChar.ChevronRight
        Me.btnIngresarPresentacion.IconColor = System.Drawing.Color.Black
        Me.btnIngresarPresentacion.IconSize = 18
        Me.btnIngresarPresentacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresarPresentacion.Location = New System.Drawing.Point(272, 405)
        Me.btnIngresarPresentacion.Name = "btnIngresarPresentacion"
        Me.btnIngresarPresentacion.Rotation = 0R
        Me.btnIngresarPresentacion.Size = New System.Drawing.Size(147, 23)
        Me.btnIngresarPresentacion.TabIndex = 9
        Me.btnIngresarPresentacion.Text = "INGRESAR"
        Me.btnIngresarPresentacion.UseVisualStyleBackColor = True
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(460, 455)
        Me.Controls.Add(Me.btnIngresarPresentacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PLogo)
        Me.Name = "Presentacion"
        Me.Text = "Presentacion"
        Me.PLogo.ResumeLayout(False)
        CType(Me.PBlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PLogo As Panel
    Friend WithEvents PBlogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnIngresarPresentacion As FontAwesome.Sharp.IconButton
End Class
