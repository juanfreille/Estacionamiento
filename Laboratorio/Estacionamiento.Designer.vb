<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estacionamiento
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
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.cmbPisos = New System.Windows.Forms.ComboBox()
        Me.lstCocheras = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdEgresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAbona = New System.Windows.Forms.TextBox()
        Me.lblVuelto = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblEgresa = New System.Windows.Forms.Label()
        Me.lblIngresa = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPatente
        '
        Me.txtPatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPatente.Location = New System.Drawing.Point(15, 26)
        Me.txtPatente.MaxLength = 6
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(134, 20)
        Me.txtPatente.TabIndex = 1
        '
        'cmbPisos
        '
        Me.cmbPisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPisos.FormattingEnabled = True
        Me.cmbPisos.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbPisos.Location = New System.Drawing.Point(45, 27)
        Me.cmbPisos.Name = "cmbPisos"
        Me.cmbPisos.Size = New System.Drawing.Size(104, 21)
        Me.cmbPisos.TabIndex = 3
        '
        'lstCocheras
        '
        Me.lstCocheras.FormattingEnabled = True
        Me.lstCocheras.Location = New System.Drawing.Point(15, 85)
        Me.lstCocheras.Name = "lstCocheras"
        Me.lstCocheras.Size = New System.Drawing.Size(134, 212)
        Me.lstCocheras.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ubicación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ingresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Egresa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Importe"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Abona"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(96, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Vuelto"
        '
        'cmdIngresar
        '
        Me.cmdIngresar.Location = New System.Drawing.Point(6, 27)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(75, 23)
        Me.cmdIngresar.TabIndex = 19
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = True
        '
        'cmdEgresar
        '
        Me.cmdEgresar.Location = New System.Drawing.Point(97, 26)
        Me.cmdEgresar.Name = "cmdEgresar"
        Me.cmdEgresar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEgresar.TabIndex = 20
        Me.cmdEgresar.Text = "Egresar"
        Me.cmdEgresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdIngresar)
        Me.GroupBox1.Controls.Add(Me.cmdEgresar)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 56)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPatente)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 61)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lstCocheras)
        Me.GroupBox3.Controls.Add(Me.cmbPisos)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 313)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cochera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cochera"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Piso"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblMinutos)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtAbona)
        Me.GroupBox4.Controls.Add(Me.lblVuelto)
        Me.GroupBox4.Controls.Add(Me.lblImporte)
        Me.GroupBox4.Controls.Add(Me.lblEgresa)
        Me.GroupBox4.Controls.Add(Me.lblIngresa)
        Me.GroupBox4.Controls.Add(Me.lblUbicacion)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(225, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(185, 325)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos"
        '
        'lblMinutos
        '
        Me.lblMinutos.BackColor = System.Drawing.SystemColors.Menu
        Me.lblMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMinutos.Location = New System.Drawing.Point(6, 167)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(173, 20)
        Me.lblMinutos.TabIndex = 27
        Me.lblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Minutos totales"
        '
        'txtAbona
        '
        Me.txtAbona.Location = New System.Drawing.Point(7, 293)
        Me.txtAbona.Name = "txtAbona"
        Me.txtAbona.Size = New System.Drawing.Size(79, 20)
        Me.txtAbona.TabIndex = 25
        '
        'lblVuelto
        '
        Me.lblVuelto.BackColor = System.Drawing.SystemColors.Menu
        Me.lblVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVuelto.Location = New System.Drawing.Point(99, 293)
        Me.lblVuelto.Name = "lblVuelto"
        Me.lblVuelto.Size = New System.Drawing.Size(79, 20)
        Me.lblVuelto.TabIndex = 24
        Me.lblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblImporte
        '
        Me.lblImporte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.ForeColor = System.Drawing.Color.Green
        Me.lblImporte.Location = New System.Drawing.Point(6, 204)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(173, 67)
        Me.lblImporte.TabIndex = 22
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEgresa
        '
        Me.lblEgresa.BackColor = System.Drawing.SystemColors.Menu
        Me.lblEgresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEgresa.Location = New System.Drawing.Point(6, 128)
        Me.lblEgresa.Name = "lblEgresa"
        Me.lblEgresa.Size = New System.Drawing.Size(173, 20)
        Me.lblEgresa.TabIndex = 21
        Me.lblEgresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIngresa
        '
        Me.lblIngresa.BackColor = System.Drawing.SystemColors.Menu
        Me.lblIngresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIngresa.Location = New System.Drawing.Point(6, 83)
        Me.lblIngresa.Name = "lblIngresa"
        Me.lblIngresa.Size = New System.Drawing.Size(173, 20)
        Me.lblIngresa.TabIndex = 20
        Me.lblIngresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUbicacion
        '
        Me.lblUbicacion.BackColor = System.Drawing.SystemColors.Menu
        Me.lblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUbicacion.Location = New System.Drawing.Point(7, 39)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(172, 20)
        Me.lblUbicacion.TabIndex = 19
        Me.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 408)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Playa El Minuto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPatente As TextBox
    Friend WithEvents cmbPisos As ComboBox
    Friend WithEvents lstCocheras As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdIngresar As Button
    Friend WithEvents cmdEgresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblIngresa As Label
    Friend WithEvents lblImporte As Label
    Friend WithEvents lblEgresa As Label
    Friend WithEvents lblVuelto As Label
    Friend WithEvents txtAbona As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMinutos As Label
    Friend WithEvents Label3 As Label
End Class
