Public Class frmLimRaizCuadrada
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x1, num, x2 As Integer

        If (Trim(txtX1.Text) = "" Or Not Int32.TryParse(txtX1.Text, x1)) Then
            MsgBox("Debe ingresar un número en el coeficiente X", MsgBoxStyle.Exclamation, "Error")

        ElseIf (Trim(txtNum.Text) = "" Or Not Int32.TryParse(txtNum.Text, num)) Then
            MsgBox("Debe ingresar un número en el termino independiente", MsgBoxStyle.Exclamation, "Error")

        ElseIf (Trim(txtX2.Text) = "" Or Not Int32.TryParse(txtX2.Text, x2)) Then
            MsgBox("Debe ingresar un número en el valor al que tiende X", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim a As Integer
            Dim res As Double
            a = (x1 * x2) - num
            res = Math.Sqrt(a)
            MsgBox("El limite de f(x) cunado x --> " & x2 & " es: " & res, MsgBoxStyle.Exclamation, "Resultado")
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        txtX1.Clear()
        txtX2.Clear()
        txtNum.Clear()

        Hide()
        frmLimitesMenu.Show()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtX1.Clear()
        txtX2.Clear()
        txtNum.Clear()
    End Sub
End Class