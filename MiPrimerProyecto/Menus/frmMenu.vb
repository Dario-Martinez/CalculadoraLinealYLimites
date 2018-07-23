Public Class frmMenu
    Private Sub btnInterseccion_Click(sender As Object, e As EventArgs) Handles btnInterseccion.Click
        Me.Hide()
        frmInterseccion.Show()
    End Sub

    Private Sub btnExplicita_Click(sender As Object, e As EventArgs) Handles btnExplicita.Click
        Me.Hide()
        _frmEcuuacionExplicita.Show()
    End Sub

    Private Sub btnDistanciaDosPuntos_Click(sender As Object, e As EventArgs) Handles btnDistanciaDosPuntos.Click
        Me.Hide()
        frmDistancia2Puntos.Show()
    End Sub

    Private Sub btnLimites_Click(sender As Object, e As EventArgs) Handles btnLimites.Click
        Me.Hide()
        frmLimitesMenu.Show()
    End Sub
End Class