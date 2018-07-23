Public Class frmLimitesMenu
    Private Sub btnFuncionLineal_Click(sender As Object, e As EventArgs) Handles btnFuncionLineal.Click
        Me.Hide()
        frmLimLineales.Show()
    End Sub

    Private Sub btnFuncionFraccion_Click(sender As Object, e As EventArgs) Handles btnFuncionFraccion.Click
        Me.Hide()
        frmLimFraccion.Show()
    End Sub

    Private Sub btnFuncionRaiz_Click(sender As Object, e As EventArgs) Handles btnFuncionRaiz.Click
        Me.Hide()
        frmLimRaizCuadrada.Show()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class