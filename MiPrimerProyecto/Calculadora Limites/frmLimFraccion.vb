Public Class frmLimFraccion
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        txtX1.Clear()
        txtX2.Clear()
        txtX3.Clear()
        txtNum1.Clear()
        txtNum2.Clear()

        Me.Hide()
        frmLimitesMenu.Show()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtX1.Clear()
        txtX2.Clear()
        txtX3.Clear()
        txtNum1.Clear()
        txtNum2.Clear()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x1, x2, x3, n1, n2 As Integer

        If (Trim(txtX1.Text) = "" Or Not Int32.TryParse(txtX1.Text, x1)) Then
            MsgBox("Debe ingresar un número en el coeficiente X, en el Numerador", MsgBoxStyle.Exclamation, "Error")
        ElseIf (Trim(txtX2.Text) = "" Or Not Int32.TryParse(txtX2.Text, x2)) Then
            MsgBox("Debe ingresar un número en el coeficiente X, en el Denominador", MsgBoxStyle.Exclamation, "Error")
        ElseIf (Trim(txtX3.Text) = "" Or Not Int32.TryParse(txtX3.Text, x3)) Then
            MsgBox("Debe ingresar un numero en el valor al que tiende X", MsgBoxStyle.Exclamation, "Error")
        ElseIf (Trim(txtNum1.Text) = "" Or Not Int32.TryParse(txtNum1.Text, n1)) Then
            MsgBox("Debe ingresar un número en el coeficiente X, en el Numerador", MsgBoxStyle.Exclamation, "Error")
        ElseIf (Trim(txtNum2.Text) = "" Or Not Int32.TryParse(txtNum2.Text, n2)) Then
            MsgBox("Debe ingresar un número en el valor independiente, en el Denominador", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim a, c As Integer
            Dim b As Double

            a = (x1 * x3) + n1
            b = (x2 * x3) ^ 2
            c = b - n2

            If c = 0 Then
                MsgBox("El límite no existe", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            MsgBox("El limite de f(x) cunado x --> " & x3 & " es: " & a & "/" & c, MsgBoxStyle.Exclamation, "Resultado")
        End If

    End Sub
End Class