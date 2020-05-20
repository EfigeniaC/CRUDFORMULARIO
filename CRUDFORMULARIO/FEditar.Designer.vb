<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEditar))
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.txtApellidosAlumnos = New System.Windows.Forms.TextBox()
        Me.txtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New FontAwesome.Sharp.IconButton()
        Me.btnEditarAlumno = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(90, 359)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(247, 20)
        Me.txtCorreo.TabIndex = 25
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(90, 313)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(247, 20)
        Me.txtTelefono.TabIndex = 24
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(193, 270)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(88, 17)
        Me.rbMasculino.TabIndex = 23
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "MASCULINO"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(90, 270)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(81, 17)
        Me.rbFemenino.TabIndex = 22
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "FEMENINO"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'txtApellidosAlumnos
        '
        Me.txtApellidosAlumnos.Location = New System.Drawing.Point(90, 224)
        Me.txtApellidosAlumnos.Name = "txtApellidosAlumnos"
        Me.txtApellidosAlumnos.Size = New System.Drawing.Size(247, 20)
        Me.txtApellidosAlumnos.TabIndex = 21
        '
        'txtNombreAlumno
        '
        Me.txtNombreAlumno.Location = New System.Drawing.Point(90, 173)
        Me.txtNombreAlumno.Name = "txtNombreAlumno"
        Me.txtNombreAlumno.Size = New System.Drawing.Size(247, 20)
        Me.txtNombreAlumno.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Sexo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(120, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 123)
        Me.Panel1.TabIndex = 14
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Leaf
        Me.btnLimpiar.IconColor = System.Drawing.Color.Black
        Me.btnLimpiar.IconSize = 20
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(76, 398)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Rotation = 0R
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 28)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEditarAlumno
        '
        Me.btnEditarAlumno.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEditarAlumno.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarAlumno.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnEditarAlumno.IconColor = System.Drawing.Color.Black
        Me.btnEditarAlumno.IconSize = 20
        Me.btnEditarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarAlumno.Location = New System.Drawing.Point(220, 398)
        Me.btnEditarAlumno.Name = "btnEditarAlumno"
        Me.btnEditarAlumno.Rotation = 0R
        Me.btnEditarAlumno.Size = New System.Drawing.Size(131, 28)
        Me.btnEditarAlumno.TabIndex = 26
        Me.btnEditarAlumno.Text = "Editar"
        Me.btnEditarAlumno.UseVisualStyleBackColor = True
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
        'FEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEditarAlumno)
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
        Me.Name = "FEditar"
        Me.Text = "FEditar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditarAlumno As FontAwesome.Sharp.IconButton
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents txtApellidosAlumnos As TextBox
    Friend WithEvents txtNombreAlumno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
