Public Class frmInterseccion

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        TxtX1.Clear()
        TxtY1.Clear()
        TxtR1.Clear()

        TxtX2.Clear()
        TxtY2.Clear()
        TxtR2.Clear()
        lblResultado.Text = ""
    End Sub

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        Dim X1, Y1, R1, X2, Y2, R2 As Integer

        If (Trim(TxtX1.Text) = "" Or Not Int32.TryParse(TxtX1.Text, X1)) Then
            MsgBox("Debe ingresar el valor X1", MsgBoxStyle.Critical, "Error")

        ElseIf (Trim(TxtY1.Text) = "" Or Not Int32.TryParse(TxtY1.Text, Y1)) Then
            MsgBox("Debe ingresar el valor Y1", "Error")

        ElseIf (Trim(TxtR1.Text) = "" Or Not Int32.TryParse(TxtR1.Text, R1)) Then
            MsgBox("Debe ingresar el valor R1", "Error")

        ElseIf (Trim(TxtX2.Text) = "" Or Not Int32.TryParse(TxtX2.Text, X2)) Then
            MsgBox("Debe ingresar el valor X2", "Error")

        ElseIf (Trim(TxtY2.Text) = "" Or Not Int32.TryParse(TxtY2.Text, Y2)) Then
            MsgBox("Debe ingresar el valor Y2", "Error")

        ElseIf (Trim(TxtR2.Text) = "" Or Not Int32.TryParse(TxtR2.Text, R2)) Then
            MsgBox("Debe ingresar el valor R2", "Error")

        Else
            Dim X1Aux, Y1Aux, R1Aux, X2Aux, Y2Aux, R2Aux As Integer
            Dim x, y As Double

            X1Aux = X1 * X2
            Y1Aux = Y1 * X2
            R1Aux = R1 * X2

            X2Aux = X2 * X1
            Y2Aux = Y2 * X1
            R2Aux = R2 * X1

            y = (R1Aux - R2Aux) / (Y1Aux - Y2Aux)
            x = (R1 - Y1Aux * y) / X1

            lblResultado.Text = "Punto de intersección: (" & y & " , " & x & ")"
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class
