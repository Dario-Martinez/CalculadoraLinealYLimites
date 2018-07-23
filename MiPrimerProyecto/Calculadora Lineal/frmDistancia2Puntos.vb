Public Class frmDistancia2Puntos
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtX1.Clear()
        txtX2.Clear()

        txtY1.Clear()
        txtY2.Clear()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x1, x2, y1, y2 As Decimal

        If (Trim(txtX1.Text) = "" Or Not Int32.TryParse(txtX1.Text, x1)) Then
            MsgBox("Debe ingresar un numero en X1")

        ElseIf (Trim(txtX2.Text) = "" Or Not Int32.TryParse(txtX2.Text, x2)) Then
            MsgBox("Debe ingresar un numero X2")

        ElseIf (Trim(txtY1.Text) = "" Or Not Int32.TryParse(txtY1.Text, y1)) Then
            MsgBox("Debe ingresar un numero Y1")

        ElseIf (Trim(txtY2.Text) = "" Or Not Int32.TryParse(txtY2.Text, y2)) Then
            MsgBox("Debe ingresar un numero Y2")

        Else
            Dim c, m, j, t, n, k As Double
            c = x2 - x1
            m = y2 - y1
            j = c ^ (2)
            t = m ^ (2)
            n = j + t
            k = Math.Sqrt(n)
            MsgBox("La distancia entre los dos puntos es: " & k.ToString)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtX1.Clear()
        txtX2.Clear()

        txtY1.Clear()
        txtY2.Clear()

        Me.Hide()
        frmMenu.Show()
    End Sub
End Class