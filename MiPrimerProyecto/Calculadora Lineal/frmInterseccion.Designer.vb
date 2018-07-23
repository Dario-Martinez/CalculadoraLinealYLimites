<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInterseccion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtX1 = New System.Windows.Forms.TextBox()
        Me.TxtY1 = New System.Windows.Forms.TextBox()
        Me.TxtR1 = New System.Windows.Forms.TextBox()
        Me.TxtX2 = New System.Windows.Forms.TextBox()
        Me.TxtY2 = New System.Windows.Forms.TextBox()
        Me.TxtR2 = New System.Windows.Forms.TextBox()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(321, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistemas Lineales - Calculadora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x +"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "y ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "x +"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(420, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "y ="
        '
        'TxtX1
        '
        Me.TxtX1.Location = New System.Drawing.Point(181, 86)
        Me.TxtX1.Name = "TxtX1"
        Me.TxtX1.Size = New System.Drawing.Size(100, 20)
        Me.TxtX1.TabIndex = 5
        '
        'TxtY1
        '
        Me.TxtY1.Location = New System.Drawing.Point(314, 86)
        Me.TxtY1.Name = "TxtY1"
        Me.TxtY1.Size = New System.Drawing.Size(100, 20)
        Me.TxtY1.TabIndex = 6
        '
        'TxtR1
        '
        Me.TxtR1.Location = New System.Drawing.Point(447, 86)
        Me.TxtR1.Name = "TxtR1"
        Me.TxtR1.Size = New System.Drawing.Size(100, 20)
        Me.TxtR1.TabIndex = 7
        '
        'TxtX2
        '
        Me.TxtX2.Location = New System.Drawing.Point(181, 135)
        Me.TxtX2.Name = "TxtX2"
        Me.TxtX2.Size = New System.Drawing.Size(100, 20)
        Me.TxtX2.TabIndex = 8
        '
        'TxtY2
        '
        Me.TxtY2.Location = New System.Drawing.Point(314, 134)
        Me.TxtY2.Name = "TxtY2"
        Me.TxtY2.Size = New System.Drawing.Size(100, 20)
        Me.TxtY2.TabIndex = 9
        '
        'TxtR2
        '
        Me.TxtR2.Location = New System.Drawing.Point(447, 135)
        Me.TxtR2.Name = "TxtR2"
        Me.TxtR2.Size = New System.Drawing.Size(100, 20)
        Me.TxtR2.TabIndex = 10
        '
        'Btnreset
        '
        Me.Btnreset.Location = New System.Drawing.Point(280, 238)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(75, 23)
        Me.Btnreset.TabIndex = 12
        Me.Btnreset.Text = "Resetear"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(376, 238)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular.TabIndex = 13
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(43, 24)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 14
        Me.btnAtras.Text = "<-- Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblResultado.Location = New System.Drawing.Point(277, 187)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(174, 16)
        Me.lblResultado.TabIndex = 18
        Me.lblResultado.Text = "Aquí aparecera el resultado"
        '
        'frmInterseccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 303)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.TxtR2)
        Me.Controls.Add(Me.TxtY2)
        Me.Controls.Add(Me.TxtX2)
        Me.Controls.Add(Me.TxtR1)
        Me.Controls.Add(Me.TxtY1)
        Me.Controls.Add(Me.TxtX1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInterseccion"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtX1 As TextBox
    Friend WithEvents TxtY1 As TextBox
    Friend WithEvents TxtR1 As TextBox
    Friend WithEvents TxtX2 As TextBox
    Friend WithEvents TxtY2 As TextBox
    Friend WithEvents TxtR2 As TextBox
    Friend WithEvents Btnreset As Button
    Friend WithEvents Btncalcular As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents lblResultado As Label
End Class
