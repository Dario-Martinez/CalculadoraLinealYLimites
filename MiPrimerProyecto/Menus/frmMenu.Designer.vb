<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblOpciones = New System.Windows.Forms.Label()
        Me.btnInterseccion = New System.Windows.Forms.Button()
        Me.btnDistanciaDosPuntos = New System.Windows.Forms.Button()
        Me.btnExplicita = New System.Windows.Forms.Button()
        Me.btnLimites = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(212, 41)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(126, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "CALCULADORA LINEAL"
        '
        'lblOpciones
        '
        Me.lblOpciones.AutoSize = True
        Me.lblOpciones.Location = New System.Drawing.Point(102, 111)
        Me.lblOpciones.Name = "lblOpciones"
        Me.lblOpciones.Size = New System.Drawing.Size(85, 13)
        Me.lblOpciones.TabIndex = 1
        Me.lblOpciones.Text = "Elija una opción:"
        '
        'btnInterseccion
        '
        Me.btnInterseccion.Location = New System.Drawing.Point(215, 111)
        Me.btnInterseccion.Name = "btnInterseccion"
        Me.btnInterseccion.Size = New System.Drawing.Size(123, 40)
        Me.btnInterseccion.TabIndex = 2
        Me.btnInterseccion.Text = "Punto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Intersección"
        Me.btnInterseccion.UseVisualStyleBackColor = True
        '
        'btnDistanciaDosPuntos
        '
        Me.btnDistanciaDosPuntos.Location = New System.Drawing.Point(215, 180)
        Me.btnDistanciaDosPuntos.Name = "btnDistanciaDosPuntos"
        Me.btnDistanciaDosPuntos.Size = New System.Drawing.Size(123, 41)
        Me.btnDistanciaDosPuntos.TabIndex = 3
        Me.btnDistanciaDosPuntos.Text = "Distancia entre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dos puntos"
        Me.btnDistanciaDosPuntos.UseVisualStyleBackColor = True
        '
        'btnExplicita
        '
        Me.btnExplicita.Location = New System.Drawing.Point(369, 110)
        Me.btnExplicita.Name = "btnExplicita"
        Me.btnExplicita.Size = New System.Drawing.Size(123, 42)
        Me.btnExplicita.TabIndex = 4
        Me.btnExplicita.Text = "Ecuación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Explícita"
        Me.btnExplicita.UseVisualStyleBackColor = True
        '
        'btnLimites
        '
        Me.btnLimites.Location = New System.Drawing.Point(369, 180)
        Me.btnLimites.Name = "btnLimites"
        Me.btnLimites.Size = New System.Drawing.Size(123, 41)
        Me.btnLimites.TabIndex = 6
        Me.btnLimites.Text = "Limites"
        Me.btnLimites.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 302)
        Me.Controls.Add(Me.btnLimites)
        Me.Controls.Add(Me.btnExplicita)
        Me.Controls.Add(Me.btnDistanciaDosPuntos)
        Me.Controls.Add(Me.btnInterseccion)
        Me.Controls.Add(Me.lblOpciones)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblOpciones As Label
    Friend WithEvents btnInterseccion As Button
    Friend WithEvents btnDistanciaDosPuntos As Button
    Friend WithEvents btnExplicita As Button
    Friend WithEvents btnLimites As Button
End Class
