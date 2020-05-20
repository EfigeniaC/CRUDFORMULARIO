<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Agregar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Agregar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.txtApellidosAlumnos = New System.Windows.Forms.TextBox()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregarAlumno = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(97, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 123)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Correo:"
        '
        'txtNombreAlumno
        '
        Me.txtNombreAlumno.Location = New System.Drawing.Point(67, 173)
        Me.txtNombreAlumno.Name = "txtNombreAlumno"
        Me.txtNombreAlumno.Size = New System.Drawing.Size(247, 20)
        Me.txtNombreAlumno.TabIndex = 6
        '
        'txtApellidosAlumnos
        '
        Me.txtApellidosAlumnos.Location = New System.Drawing.Point(67, 224)
        Me.txtApellidosAlumnos.Name = "txtApellidosAlumnos"
        Me.txtApellidosAlumnos.Size = New System.Drawing.Size(247, 20)
        Me.txtApellidosAlumnos.TabIndex = 7
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(67, 270)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(81, 17)
        Me.rbFemenino.TabIndex = 8
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "FEMENINO"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(170, 270)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(88, 17)
        Me.rbMasculino.TabIndex = 9
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "MASCULINO"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(67, 313)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(247, 20)
        Me.txtTelefono.TabIndex = 10
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(67, 359)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(247, 20)
        Me.txtCorreo.TabIndex = 11
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Leaf
        Me.btnLimpiar.IconColor = System.Drawing.Color.Black
        Me.btnLimpiar.IconSize = 20
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(53, 398)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Rotation = 0R
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 28)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregarAlumno
        '
        Me.btnAgregarAlumno.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAgregarAlumno.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAlumno.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAgregarAlumno.IconColor = System.Drawing.Color.Black
        Me.btnAgregarAlumno.IconSize = 20
        Me.btnAgregarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarAlumno.Location = New System.Drawing.Point(197, 398)
        Me.btnAgregarAlumno.Name = "btnAgregarAlumno"
        Me.btnAgregarAlumno.Rotation = 0R
        Me.btnAgregarAlumno.Size = New System.Drawing.Size(131, 28)
        Me.btnAgregarAlumno.TabIndex = 12
        Me.btnAgregarAlumno.Text = "AGREGAR"
        Me.btnAgregarAlumno.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 123)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'F_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregarAlumno)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.rbMasculino)
        Me.Controls.Add(Me.rbFemenino)
        Me.Controls.Add(Me.txtApellidosAlumnos)
        Me.Controls.Add(Me.txtNombreAlumno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_Agregar"
        Me.Text = "F_Agregar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreAlumno As TextBox
    Friend WithEvents txtApellidosAlumnos As TextBox
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnAgregarAlumno As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiar As FontAwesome.Sharp.IconButton
End Class
