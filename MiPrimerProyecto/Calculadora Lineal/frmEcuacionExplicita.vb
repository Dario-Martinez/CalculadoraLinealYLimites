Public Class _frmEcuuacionExplicita
    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        txtX1.Clear()
        txtY1.Clear()

        txtX2.Clear()
        txtY2.Clear()
        lblResultado.Text = ""
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x1, y1, x2, y2 As Integer

        If (Trim(txtX1.Text) = "" Or Not Int32.TryParse(txtX1.Text, x1)) Then
            MsgBox("Debe ingresar un número en X1")

        ElseIf (Trim(txtY1.Text) = "" Or Not Int32.TryParse(txtY1.Text, y1)) Then
            MsgBox("Debe ingresar un número Y1")

        ElseIf (Trim(txtX2.Text) = "" Or Not Int32.TryParse(txtX2.Text, x2)) Then
            MsgBox("Debe ingresar un número X2")

        ElseIf (Trim(txtY2.Text) = "" Or Not Int32.TryParse(txtY2.Text, y2)) Then
            MsgBox("Debe ingresar un número Y2")

        Else
            Dim m, b As Integer
            m = (y1 - y2) / (x1 - x2)
            b = (m * x1) - y1

            lblResultado.Text = "Ecuación Explícita: Y = " & m & "x" & " +" & b & vbCrLf & vbCrLf & "Ecuación General: " & m & "x " & "-y" & " +" & b & " = 0"
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        txtX1.Clear()
        txtY1.Clear()

        txtX2.Clear()
        txtY2.Clear()
        lblResultado.Text = ""

        Me.Hide()
        frmMenu.Show()
    End Sub
End Class