Public Class Estacionamiento
    Const CAPACIDAD As Integer = 250
    Const PRECIO As Double = 0.5
    Public Structure COCHES
        Public Patente As String
        Public Ingresa As Date
    End Structure
    Dim PLAYA(CAPACIDAD) As COCHES
    Dim POS As Integer
    Dim IMPORTE As Decimal
    Dim I As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For I = 1 To CAPACIDAD
            PLAYA(I).Patente = ""
        Next
        cmdIngresar.Enabled = False
        cmdEgresar.Enabled = False
        Limpiar()
    End Sub
    Sub ValidarCaracteres()
        Dim VALIDA As String
        Dim LETRA As Integer
        Dim C As Integer = 0

        If txtPatente.Text <> "" And lstCocheras.SelectedItem <> 0 Then
            VALIDA = txtPatente.Text

            'Confirma que la patente tiene 6 caracteres para empezar la validacion

            If VALIDA.Length = 6 Then

                'Se crea un ciclo for con una variable para que recorra los caracteres 0, 1 y 2  de txtpatente y compara cada caracter con
                'la simbologia de letras mayuscula en la tabla ascii. Luego, si los 3 caracteres cumplen los requisitos la variable C valdrá 3

                For LETRA = 1 To 3
                    If VALIDA.Substring(LETRA - 1, 1) > Chr(64) And VALIDA.Substring(LETRA - 1, 1) < Chr(91) Then
                        C = C + 1
                    End If
                Next

                'Si c = 3 y los 3 caracteres restantes son numeros se habilita el boton ingresar.

                If C = 3 And IsNumeric(VALIDA.Substring(3, 3)) Then
                    cmdIngresar.Enabled = True

                    'Se hace recorrido del vector y si la patente ya existe, se habilita el boton egresar.

                    For POS = 0 To CAPACIDAD
                        If PLAYA(POS).Patente = txtPatente.Text Then
                            cmdIngresar.Enabled = False
                            cmdEgresar.Enabled = True
                        End If
                    Next
                Else
                    MessageBox.Show("La patente no se puede ingresar al sistema." + vbNewLine + "Solo puede contener 3 letras y 3 números." + vbNewLine + "Por ejemplo: ABC123", "Formato de patente incorrecto!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmdIngresar.Enabled = False
                End If
            End If
        Else
            cmdIngresar.Enabled = False
            cmdEgresar.Enabled = False
        End If
    End Sub
    Sub Limpiar()
        lblUbicacion.Text = ""
        lblIngresa.Text = ""
        lblEgresa.Text = ""
        lblImporte.Text = "$ 0,00"
        lblMinutos.Text = ""
        lblVuelto.Text = ""
        txtAbona.Clear()
        cmbPisos.SelectedIndex = 0
    End Sub
    Sub ListaDeCocheras()
        Dim PISO As Integer
        Dim CONTADOR As Integer
        PISO = Val(cmbPisos.Text)
        'Usamos una multiplicacion para que nos de como resultado el indice del cual contamos cada cochera.

        CONTADOR = ((PISO - 1) * 50) + 1
        lstCocheras.Items.Clear()
        'Al contador le sumamos las restantes 49 cocheras para completar las 50 por piso.

        For I = CONTADOR To CONTADOR + 49
            If PLAYA(I).Patente = "" Then
                lstCocheras.Items.Add(I)
            End If
        Next
        cmdIngresar.Enabled = False
    End Sub
    Private Sub txtPatente_TextChanged(sender As Object, e As EventArgs) Handles txtPatente.TextChanged
        ValidarCaracteres()
        If txtPatente.Text <> "" Then
            DatosPlaya()
        Else
        End If
    End Sub
    Private Sub cmbPisos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPisos.SelectedIndexChanged
        ListaDeCocheras()
    End Sub
    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        'Al hacer click en ingresar se cargan los datos de patente y hora actual en el vector, y luego se recargan las cocheras libres.

        PLAYA(lstCocheras.SelectedItem).Patente = txtPatente.Text
        PLAYA(lstCocheras.SelectedItem).Ingresa = Now.ToString
        ListaDeCocheras()
        txtPatente.Clear()
        MessageBox.Show("Automovil ingresado con exito.", "Playa El Minuto", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub DatosPlaya()
        Dim FECHA1 As Date
        Dim FECHA2 As Date = Now
        Dim TIEMPO As TimeSpan
        Dim Piso As Integer
        IMPORTE = 0
        POS = 0
        Piso = 0
        Limpiar()

        'Se hace un recorrido por el vector y comprobamos si el numero de patente que figura en el el textbox ya esta cargado. De ser asi se haran
        'los calculos necesarios para completar los labelbox correspondientes. Usamos un timespan en minutos para hacer el calculo del tiempo.

        For POS = 0 To CAPACIDAD
            Select Case POS
                Case 1 To 50
                    Piso = 1
                Case 51 To 100
                    Piso = 2
                Case 101 To 150
                    Piso = 3
                Case 151 To 200
                    Piso = 4
                Case 201 To 250
                    Piso = 5
            End Select

            If PLAYA(POS).Patente = txtPatente.Text Then
                cmdIngresar.Enabled = False
                cmdEgresar.Enabled = True
                FECHA1 = PLAYA(POS).Ingresa
                lblIngresa.Text = FECHA1
                lblEgresa.Text = FECHA2
                lblUbicacion.Text = "Piso: " & Piso & ", " & "Cochera: " & POS
                TIEMPO = (FECHA2 - FECHA1)
                lblMinutos.Text = TIEMPO.Minutes
                IMPORTE = Val(TIEMPO.Minutes) * Val(PRECIO)
                lblImporte.Text = IMPORTE.ToString("$ 0.00")
            Else
            End If
        Next

    End Sub
    Private Sub cmdEgresar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmdEgresar.Click
        'Hacemos recorrido de vector al hacer click en egresar, si la patente del textbox ya esta cargada se borran las variables del vector.
        'Luego se limpian los campos, y se recarga la lista de cocheras libres.

        For POS = 0 To CAPACIDAD
            If PLAYA(POS).Patente = txtPatente.Text Then
                PLAYA(POS).Patente = ""
                PLAYA(POS).Ingresa = Nothing
                txtPatente.Clear()
            End If
        Next
        Limpiar()
        txtPatente.Clear()
        ListaDeCocheras()
        MessageBox.Show("Automovil egresado de la cochera.", "Playa El Minuto", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub lstCocheras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCocheras.SelectedIndexChanged
        ValidarCaracteres()
    End Sub

    Private Sub txtAbona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbona.KeyPress
        'Si lo que se ingresa son numeros, el caracter "." o la tecla de borrado, se continuara con la ejecución de las demás acciones relativas
        'al evento, ya que el handled permanecera en su estado por defecto false, de lo contrario pasa a true y no se procesa la pulsacion.

        If (IsNumeric(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = vbBack) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAbona_TextChanged(sender As Object, e As EventArgs) Handles txtAbona.TextChanged
        Dim ABONAR As Decimal
        Dim VUELTO As Decimal

        ABONAR = Val(txtAbona.Text)
        VUELTO = ABONAR - IMPORTE

        If VUELTO > 0 Then
            lblVuelto.Text = VUELTO.ToString("$ 0.00")
        Else
            lblVuelto.Text = ""
        End If
    End Sub
End Class
