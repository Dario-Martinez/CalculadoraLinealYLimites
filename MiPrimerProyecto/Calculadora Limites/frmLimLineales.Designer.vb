<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLimLineales
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
        Me.lblLim = New System.Windows.Forms.Label()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.lblXLimite = New System.Windows.Forms.Label()
        Me.txtNumSolo = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.lblXtiende = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLim
        '
        Me.lblLim.AutoSize = True
        Me.lblLim.Location = New System.Drawing.Point(83, 64)
        Me.lblLim.Name = "lblLim"
        Me.lblLim.Size = New System.Drawing.Size(23, 13)
        Me.lblLim.TabIndex = 0
        Me.lblLim.Text = "Lim"
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(112, 61)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(40, 20)
        Me.txtX1.TabIndex = 1
        '
        'lblXLimite
        '
        Me.lblXLimite.AutoSize = True
        Me.lblXLimite.Location = New System.Drawing.Point(158, 64)
        Me.lblXLimite.Name = "lblXLimite"
        Me.lblXLimite.Size = New System.Drawing.Size(23, 13)
        Me.lblXLimite.TabIndex = 2
        Me.lblXLimite.Text = "X +"
        '
        'txtNumSolo
        '
        Me.txtNumSolo.Location = New System.Drawing.Point(187, 61)
        Me.txtNumSolo.Name = "txtNumSolo"
        Me.txtNumSolo.Size = New System.Drawing.Size(46, 20)
        Me.txtNumSolo.TabIndex = 3
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(118, 95)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(44, 20)
        Me.txtX2.TabIndex = 4
        '
        'lblXtiende
        '
        Me.lblXtiende.AutoSize = True
        Me.lblXtiende.Location = New System.Drawing.Point(83, 98)
        Me.lblXtiende.Name = "lblXtiende"
        Me.lblXtiende.Size = New System.Drawing.Size(29, 13)
        Me.lblXtiende.TabIndex = 5
        Me.lblXtiende.Text = "X -->"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(224, 159)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 159)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(118, 159)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'frmLimLineales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 209)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblXtiende)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtNumSolo)
        Me.Controls.Add(Me.lblXLimite)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.lblLim)
        Me.Name = "frmLimLineales"
        Me.Text = "frmLimFunLineales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLim As Label
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents lblXLimite As Label
    Friend WithEvents txtNumSolo As TextBox
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents lblXtiende As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnBorrar As Button
End Class
