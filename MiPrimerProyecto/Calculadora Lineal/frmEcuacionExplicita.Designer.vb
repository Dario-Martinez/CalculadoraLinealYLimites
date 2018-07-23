<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _frmEcuuacionExplicita
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblParX1 = New System.Windows.Forms.Label()
        Me.lblcomEq1 = New System.Windows.Forms.Label()
        Me.lblParX2 = New System.Windows.Forms.Label()
        Me.lblParY1 = New System.Windows.Forms.Label()
        Me.lblParY2 = New System.Windows.Forms.Label()
        Me.lblcomEq2 = New System.Windows.Forms.Label()
        Me.btnResetear = New System.Windows.Forms.Button()
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.lblY1 = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.lblY2 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtX1
        '
        Me.txtX1.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.txtX1.Location = New System.Drawing.Point(195, 40)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(32, 20)
        Me.txtX1.TabIndex = 0
        '
        'txtY1
        '
        Me.txtY1.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.txtY1.Location = New System.Drawing.Point(249, 40)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(36, 20)
        Me.txtY1.TabIndex = 1
        '
        'txtX2
        '
        Me.txtX2.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.txtX2.Location = New System.Drawing.Point(195, 98)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(32, 20)
        Me.txtX2.TabIndex = 2
        '
        'txtY2
        '
        Me.txtY2.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.txtY2.Location = New System.Drawing.Point(249, 98)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(36, 20)
        Me.txtY2.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.btnCalcular.Location = New System.Drawing.Point(252, 187)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblParX1
        '
        Me.lblParX1.AutoSize = True
        Me.lblParX1.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblParX1.Location = New System.Drawing.Point(178, 43)
        Me.lblParX1.Name = "lblParX1"
        Me.lblParX1.Size = New System.Drawing.Size(11, 15)
        Me.lblParX1.TabIndex = 5
        Me.lblParX1.Text = "("
        '
        'lblcomEq1
        '
        Me.lblcomEq1.AutoSize = True
        Me.lblcomEq1.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblcomEq1.Location = New System.Drawing.Point(232, 47)
        Me.lblcomEq1.Name = "lblcomEq1"
        Me.lblcomEq1.Size = New System.Drawing.Size(10, 15)
        Me.lblcomEq1.TabIndex = 6
        Me.lblcomEq1.Text = ","
        '
        'lblParX2
        '
        Me.lblParX2.AutoSize = True
        Me.lblParX2.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblParX2.Location = New System.Drawing.Point(178, 101)
        Me.lblParX2.Name = "lblParX2"
        Me.lblParX2.Size = New System.Drawing.Size(11, 15)
        Me.lblParX2.TabIndex = 7
        Me.lblParX2.Text = "("
        '
        'lblParY1
        '
        Me.lblParY1.AutoSize = True
        Me.lblParY1.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblParY1.Location = New System.Drawing.Point(290, 43)
        Me.lblParY1.Name = "lblParY1"
        Me.lblParY1.Size = New System.Drawing.Size(11, 15)
        Me.lblParY1.TabIndex = 8
        Me.lblParY1.Text = ")"
        '
        'lblParY2
        '
        Me.lblParY2.AutoSize = True
        Me.lblParY2.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblParY2.Location = New System.Drawing.Point(290, 101)
        Me.lblParY2.Name = "lblParY2"
        Me.lblParY2.Size = New System.Drawing.Size(11, 15)
        Me.lblParY2.TabIndex = 9
        Me.lblParY2.Text = ")"
        '
        'lblcomEq2
        '
        Me.lblcomEq2.AutoSize = True
        Me.lblcomEq2.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblcomEq2.Location = New System.Drawing.Point(232, 105)
        Me.lblcomEq2.Name = "lblcomEq2"
        Me.lblcomEq2.Size = New System.Drawing.Size(10, 15)
        Me.lblcomEq2.TabIndex = 10
        Me.lblcomEq2.Text = ","
        '
        'btnResetear
        '
        Me.btnResetear.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.btnResetear.Location = New System.Drawing.Point(152, 187)
        Me.btnResetear.Name = "btnResetear"
        Me.btnResetear.Size = New System.Drawing.Size(75, 23)
        Me.btnResetear.TabIndex = 11
        Me.btnResetear.Text = "Resetar"
        Me.btnResetear.UseVisualStyleBackColor = True
        '
        'lblX1
        '
        Me.lblX1.AutoSize = True
        Me.lblX1.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblX1.Location = New System.Drawing.Point(192, 24)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.Size = New System.Drawing.Size(21, 15)
        Me.lblX1.TabIndex = 12
        Me.lblX1.Text = "X1"
        '
        'lblY1
        '
        Me.lblY1.AutoSize = True
        Me.lblY1.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblY1.Location = New System.Drawing.Point(246, 24)
        Me.lblY1.Name = "lblY1"
        Me.lblY1.Size = New System.Drawing.Size(21, 15)
        Me.lblY1.TabIndex = 13
        Me.lblY1.Text = "Y1"
        '
        'lblX2
        '
        Me.lblX2.AutoSize = True
        Me.lblX2.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblX2.Location = New System.Drawing.Point(195, 79)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(21, 15)
        Me.lblX2.TabIndex = 14
        Me.lblX2.Text = "X2"
        '
        'lblY2
        '
        Me.lblY2.AutoSize = True
        Me.lblY2.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblY2.Location = New System.Drawing.Point(249, 79)
        Me.lblY2.Name = "lblY2"
        Me.lblY2.Size = New System.Drawing.Size(21, 15)
        Me.lblY2.TabIndex = 15
        Me.lblY2.Text = "Y2"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.btnAtras.Location = New System.Drawing.Point(32, 19)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 16
        Me.btnAtras.Text = "<-- Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.lblResultado.Location = New System.Drawing.Point(153, 136)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(158, 15)
        Me.lblResultado.TabIndex = 17
        Me.lblResultado.Text = "Aquí aparecera el resultado"
        '
        '_frmEcuuacionExplicita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 222)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lblY2)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.lblY1)
        Me.Controls.Add(Me.lblX1)
        Me.Controls.Add(Me.btnResetear)
        Me.Controls.Add(Me.lblcomEq2)
        Me.Controls.Add(Me.lblParY2)
        Me.Controls.Add(Me.lblParY1)
        Me.Controls.Add(Me.lblParX2)
        Me.Controls.Add(Me.lblcomEq1)
        Me.Controls.Add(Me.lblParX1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtY2)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtY1)
        Me.Controls.Add(Me.txtX1)
        Me.Name = "_frmEcuuacionExplicita"
        Me.Text = "_frmEcuuacionExplicita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtX1 As TextBox
    Friend WithEvents txtY1 As TextBox
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents txtY2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblParX1 As Label
    Friend WithEvents lblcomEq1 As Label
    Friend WithEvents lblParX2 As Label
    Friend WithEvents lblParY1 As Label
    Friend WithEvents lblParY2 As Label
    Friend WithEvents lblcomEq2 As Label
    Friend WithEvents btnResetear As Button
    Friend WithEvents lblX1 As Label
    Friend WithEvents lblY1 As Label
    Friend WithEvents lblX2 As Label
    Friend WithEvents lblY2 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents lblResultado As Label
End Class
