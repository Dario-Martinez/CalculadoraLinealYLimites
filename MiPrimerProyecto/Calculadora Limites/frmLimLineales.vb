Public Class frmLimLineales
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        txtX1.Clear()
        txtX2.Clear()
        txtNumSolo.Clear()

        Me.Hide()
        frmLimitesMenu.Show()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtX1.Clear()
        txtX2.Clear()
        txtNumSolo.Clear()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x1, nsolo, x2 As Integer

        If (Trim(txtX1.Text) = "" Or Not Int32.TryParse(txtX1.Text, x1)) Then
            MsgBox("Debe ingresar un numero en el coeficiente x", MsgBoxStyle.Exclamation, "Error")

        ElseIf (Trim(txtNumSolo.Text) = "" Or Not Int32.TryParse(txtNumSolo.Text, nsolo)) Then
            MsgBox("Debe ingresar un numero en el termino independiente", MsgBoxStyle.Exclamation, "Error")

        ElseIf (Trim(txtX2.Text) = "" Or Not Int32.TryParse(txtX2.Text, x2)) Then
            MsgBox("Debe ingresar un numero en el valor al que tiende X", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim a, res As Integer
            a = (x1 * x2)
            res = a + nsolo
            MsgBox("El limite de f(x) cunado x --> " & x2 & " es: " & res, MsgBoxStyle.Exclamation, "Resultado")
        End If

    End Sub
End Class