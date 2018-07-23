<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLimitesMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFuncionLineal = New System.Windows.Forms.Button()
        Me.btnFuncionFraccion = New System.Windows.Forms.Button()
        Me.btnFuncionRaiz = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular limites de:"
        '
        'btnFuncionLineal
        '
        Me.btnFuncionLineal.Location = New System.Drawing.Point(310, 90)
        Me.btnFuncionLineal.Name = "btnFuncionLineal"
        Me.btnFuncionLineal.Size = New System.Drawing.Size(123, 38)
        Me.btnFuncionLineal.TabIndex = 1
        Me.btnFuncionLineal.Text = "Limites de funciones lineales"
        Me.btnFuncionLineal.UseVisualStyleBackColor = True
        '
        'btnFuncionFraccion
        '
        Me.btnFuncionFraccion.Location = New System.Drawing.Point(310, 153)
        Me.btnFuncionFraccion.Name = "btnFuncionFraccion"
        Me.btnFuncionFraccion.Size = New System.Drawing.Size(123, 38)
        Me.btnFuncionFraccion.TabIndex = 2
        Me.btnFuncionFraccion.Text = "Limites de funciones con fracción"
        Me.btnFuncionFraccion.UseVisualStyleBackColor = True
        '
        'btnFuncionRaiz
        '
        Me.btnFuncionRaiz.Location = New System.Drawing.Point(310, 214)
        Me.btnFuncionRaiz.Name = "btnFuncionRaiz"
        Me.btnFuncionRaiz.Size = New System.Drawing.Size(123, 38)
        Me.btnFuncionRaiz.TabIndex = 3
        Me.btnFuncionRaiz.Text = "Limites de funciones con raíz cuadrada"
        Me.btnFuncionRaiz.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(48, 26)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmLimitesMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 341)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnFuncionRaiz)
        Me.Controls.Add(Me.btnFuncionFraccion)
        Me.Controls.Add(Me.btnFuncionLineal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLimitesMenu"
        Me.Text = "Limites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnFuncionLineal As Button
    Friend WithEvents btnFuncionFraccion As Button
    Friend WithEvents btnFuncionRaiz As Button
    Friend WithEvents btnAtras As Button
End Class
